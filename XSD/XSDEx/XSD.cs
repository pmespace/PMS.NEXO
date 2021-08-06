using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml.Schema;
using System.Reflection;
using System.CodeDom;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using Microsoft.VisualBasic;
using COMMON;
using System.Windows.Forms;

using NEXO;

namespace XSDEx
{
	/// <summary>
	/// XSD to code class
	/// </summary>
	public class XSD
	{
		#region const
		private const string XML_IGNORE_ATTRIBUTE = "System.Xml.Serialization.XmlIgnoreAttribute";
		private const string JSON_IGNORE_ATTRIBUTE = "Newtonsoft.Json.JsonIgnore";
		#endregion

		#region properties
		public Control Ctrl = null;
		public string Code { get; private set; }

		/// <summary>
		///  Dictionary of all tags inside all XSD files
		/// </summary>
		class MyTags : SortedDictionary<string, string> { }
		private MyTags tags = new MyTags();

		class Message
		{
			public Message() { }
			public Label Lbl = null;
			public CThreadData threadData = null;
			public XSDAddActivity WndDelegate
			{
				get => _processui;
				set
				{
					if (null != value)
						_processui = new XSDAddActivity(value);
					else
						_processui = null;
				}
			}
			private XSDAddActivity _processui = null;
			public bool Silent { get; set; }
			public string Header
			{
				get => _header;
				set { _text = null; _header = value; Set(); }
			}
			private string _header = null;
			public string Text
			{
				get => _text;
				set { _text = value; Set(); }
			}
			private string _text = null;
			private void Set()
			{
				if (Silent) return;
				if (null != Lbl)
				{
					string s = ((null != Header ? $"{Header}: " : null) + Text);
					if (null == threadData || IntPtr.Zero == threadData.WindowToWarn)
					{
						Lbl.Text = ((null != Header ? $"{Header}: " : null) + Text);
						Lbl.Refresh();
					}
					else
					{
						Lbl.Invoke(WndDelegate, new XSDActivity() { Evt = XSDActivityEvent.message, Message = s });
					}
				}
			}
		}

		/// <summary>
		/// dictionary of all objects contained inside all the XSD files
		/// </summary>
		class MyCodeTypeDeclarations : SortedDictionary<string, CodeTypeDeclaration> { }
		private MyCodeTypeDeclarations typesDeclaredInsideNamespace;

		/// <summary>
		///  Dictionary of all tags inside all XSD files
		/// </summary>
		private MyCodeTypeDeclarations interfaces = new MyCodeTypeDeclarations();
		#endregion

		#region methods
		/// <summary>
		/// Determine the extension of the generated file
		/// </summary>
		/// <param name="settings"></param>
		/// <returns></returns>
		private string GetExtension(XSDSettings settings)
		{
			return (enumLanguage.csharp == settings.Language ? ".cs" : (enumLanguage.vb == settings.Language ? ".vb" : ".unknown"));
		}
		/// <summary>
		/// Alalyse specified XSD files and process them according to the desired result
		/// Result can be all XSD help generate 1 file or each XSD help generates 1 file
		/// </summary>
		/// <param name="settings"></param>
		/// <returns></returns>
		public bool AnalyseXSD(AnalyseSettings settings)
		{
			Message msg = new Message() { Lbl = settings.lbl, WndDelegate = settings.processUI, threadData = settings.threadData, Silent = settings.xsdSettings.Silent };
			XmlSchema xsd;
			try
			{
				#region init parameters
				// try to open the type conversino file
				CJson<XSDParams> json = new CJson<XSDParams>(settings.xsdSettings.ParametersFileName);
				XSDParams parameters = json.ReadSettings(out bool except);
				if (null == parameters)
				{
					parameters = new XSDParams();
					json.WriteSettings(parameters);
				}
				if (null == parameters.TypeConversions)
				{
					parameters.TypeConversions = new XSDTypeConversions();
					parameters.TypeConversions.Add("myDummyBaseType1", new XSDTypeConversion()
					{
						TargetType = "myDummyTargetType",
						Rank = 0,
					});
					parameters.TypeConversions.Add("myDummyBaseType2", new XSDTypeConversion()
					{
						TargetType = "myDummyTargetType",
						Rank = 0,
					});
				}
				if (null == parameters.ArrayConversions)
				{
					parameters.TypeConversions = new XSDTypeConversions();
					parameters.TypeConversions.Add("myDummyArrayType1", new XSDTypeConversion()
					{
						TargetType = "myDummyTargetType",
						Rank = 1,
					});
					parameters.TypeConversions.Add("myDummyArrayType2", new XSDTypeConversion()
					{
						TargetType = "myDummyTargetType",
						Rank = 1,
					});
				}
				if (null == parameters.TypesWithoutInitializer)
				{
					parameters.TypesWithoutInitializer = new XSDTypesWithSpecialProcessing();
					parameters.TypesWithoutInitializer.Add("myDummyType1");
					parameters.TypesWithoutInitializer.Add("myDummyType2");
				}
				if (null == parameters.ArrayTypesWithoutInitializer)
				{
					parameters.ArrayTypesWithoutInitializer = new XSDTypesWithSpecialProcessing();
					parameters.ArrayTypesWithoutInitializer.Add("myDummyArrayType1");
					parameters.ArrayTypesWithoutInitializer.Add("myDummyArrayType2");
				}
				if (null == parameters.ArrayTypesWithoutAccessors)
				{
					parameters.ArrayTypesWithoutAccessors = new XSDTypesWithSpecialProcessing();
					parameters.ArrayTypesWithoutAccessors.Add("myDummyArrayType1");
					parameters.ArrayTypesWithoutAccessors.Add("myDummyArrayType2");
				}
				json.WriteSettings(parameters);
				#endregion

				typesDeclaredInsideNamespace = new MyCodeTypeDeclarations();
				if (settings.mixFiles)
				{
					// all XSD will generate 1 file
					MyTags tags = new MyTags();
					XmlSchemas xsds = new XmlSchemas();
					string fileName = null;
					// load all selected files into a schema and compile
					foreach (string file in settings.xsdSettings.Files)
					{
						if (string.IsNullOrEmpty(fileName))
							fileName = settings.xsdSettings.Files[0] + GetExtension(settings.xsdSettings);
						using (var stream = new FileStream(file, FileMode.Open, FileAccess.Read))
						{
							xsd = XmlSchema.Read(stream, null);
						}
						xsds.Add(xsd);
					}
					xsds.Compile(null, true);
					return ProcessFile(settings.xsdSettings, parameters, xsds, fileName, true, msg, false);
				}
				else
				{
					// each XSD generates 1 file
					bool fOK = true;
					// load all selected files into a schema and compile
					for (int i = 0; i < settings.xsdSettings.Files.Count; i++)
					{
						string fileName = settings.xsdSettings.Files[i] + GetExtension(settings.xsdSettings);
						XmlSchemas xsds = new XmlSchemas();
						using (var stream = new FileStream(settings.xsdSettings.Files[i], FileMode.Open, FileAccess.Read))
						{
							xsd = XmlSchema.Read(stream, null);
						}
						xsds.Add(xsd);
						xsds.Compile(null, true);
						// allow special processing for the last file
						fOK = fOK && ProcessFile(settings.xsdSettings, parameters, xsds, fileName, i == settings.xsdSettings.Files.Count - 1, msg, true);
					}
					return fOK;
				}
			}
			catch (Exception ex)
			{
				settings.xsdSettings.Exception = ex.Message;
				//CodeNamespace = default;
				return false;
			}
		}
		public class AnalyseSettings
		{
			public XSDSettings xsdSettings { get; set; }
			public CThreadData threadData { get; set; }
			public bool mixFiles { get; set; }
			public Label lbl { get; set; }
			public XSDAddActivity processUI { get; set; }
		}
		/// <summary>
		/// Prepare a file to be created by the processing adding all necessary attributes and processing the types it contains
		/// </summary>
		/// <param name="settings"></param>
		/// <param name="parameters"></param>
		/// <param name="xsds"></param>
		/// <param name="fileName"></param>
		/// <param name="lastFile"></param>
		/// <param name="msg"></param>
		/// <param name="useNamespace"></param>
		/// <returns></returns>
		private bool ProcessFile(XSDSettings settings, XSDParams parameters, XmlSchemas xsds, string fileName, bool lastFile, Message msg, bool useNamespace)
		{
			try
			{
				msg.Header = fileName;

				// create the context
				if (string.IsNullOrEmpty(settings.Nmspace))
					settings.Nmspace = "XSD";
				XmlSchemaImporter schemaImporter = new XmlSchemaImporter(xsds);
				CodeNamespace codeNamespace = new CodeNamespace(settings.Nmspace);

				// if preprocessor variable to use, add it
				string beginPreprocessor = null, endPreprocessor = null;
				if (!string.IsNullOrEmpty(settings.Preprocessor))
				{
					if (enumLanguage.csharp == settings.Language)
					{
						beginPreprocessor = $"#if {settings.Preprocessor}";
						endPreprocessor = $"#endif";
					}
					else if (enumLanguage.vb == settings.Language)
					{
						beginPreprocessor = $"#If {settings.Preprocessor} Then";
						endPreprocessor = $"#End If";
					}
				}

				// export the code inside the namespace
				msg.Text = "Exporting XSD";
				XmlCodeExporter codeExporter = new XmlCodeExporter(codeNamespace, null, CodeGenerationOptions.GenerateProperties);

				// load objects fromm the XSD
				var maps = new List<XmlTypeMapping>();
				foreach (XmlSchema schema in xsds)
				{
					if (settings.UseTypes)
					{
						foreach (XmlSchemaType schemaT in schema.SchemaTypes.Values)
							maps.Add(schemaImporter.ImportSchemaType(schemaT.QualifiedName));
					}
					if (settings.UseElements)
					{
						foreach (XmlSchemaElement schemaT in schema.Elements.Values)
							maps.Add(schemaImporter.ImportTypeMapping(schemaT.QualifiedName));
					}
					//if (settings.UseNotations)
					//	{
					//	foreach (XmlSchemaNotation schemaT in schema.Notations.Values)
					//		maps.Add(schemaImporter.ImportTypeMapping(schemaT.QualifiedName));
					//	}
				}
				// export all selected objects to the namespace code
				foreach (var map in maps)
					codeExporter.ExportTypeMapping(map);

				// process the files to update classes and other objects
				CodeNamespace newCodeNamespace = PostProcess(settings, parameters, codeNamespace, lastFile, msg);

				msg.Text = "Finalising";

				// add the required imports 
				//newCodeNamespace.Imports.Add(new CodeNamespaceImport("System.Runtime.Serialization"));
				if (settings.AddDispID && settings.DeclareClassInterface)
					newCodeNamespace.Imports.Add(new CodeNamespaceImport("System.Runtime.InteropServices"));
				//// add newtonsoft.json
				//newCodeNamespace.Imports.Add(new CodeNamespaceImport("Newtonsoft.Json"));

				// display in texbox
				//CodeGenerator.ValidateIdentifiers(codeNamespace);
				CodeGenerator.ValidateIdentifiers(newCodeNamespace);

				// create the code
				msg.Text = "Generating code";

				//Code = GenerateCode(settings, codeNamespace);
				Code = GenerateCode(settings, newCodeNamespace);
				if (!string.IsNullOrEmpty(beginPreprocessor))
				{
					Code = $"{beginPreprocessor}\r\n{Code}{endPreprocessor}";
				}

				msg.Text = "Writing file";

				// create the file
				using (StreamWriter sw = new StreamWriter(fileName))
				{
					sw.WriteLine(Code);
				}
				return true;
			}
			catch (Exception ex)
			{
				settings.Exception = ex.Message;
				//CodeNamespace = default;
				return false;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="settings"></param>
		/// <param name="parameters"></param>
		/// <param name="codeNamespace"></param>
		/// <param name="lastFile"></param>
		/// <param name="msg"></param>
		/// <returns></returns>
		private CodeNamespace PostProcess(XSDSettings settings, XSDParams parameters, CodeNamespace codeNamespace, bool lastFile, Message msg)
		{
			CodeNamespace newCodeNamespace = null;

			const string bXSD = "BEGIN ADDED BY XSD";
			const string eXSD = "END ADDED BY XSD";
			const string isSpecified = "Specified";

			msg.Text = "Post process";
			try
			{
				const string sizeMethod = "Size", getItemMethod = "GetItem", setItemMethod = "SetItem", addItemMethod = "AddItem", removeItemMethod = "RemoveItem", isArray = "array", isCounter = "i", isField = "Field", isLength = "Length", isEx = "ex", isIndex = "index";

				// file specific objects to add
				List<CodeTypeDeclaration> newCodeTypeDeclarations = new List<CodeTypeDeclaration>();

				// create our own list of types
				CodeTypeDeclarationCollection thisFileTypes = new CodeTypeDeclarationCollection();
				//Dictionary<string, CodeTypeDeclaration> enums = new Dictionary<string, CodeTypeDeclaration>();

				// prepare a list of all types before all
				foreach (CodeTypeDeclaration codeType in codeNamespace.Types)
				{
					try
					{
						// add this type to the list of types to generate
						typesDeclaredInsideNamespace.Add(codeType.Name /*+ "myXSDClassOrStruct"*/, codeType);
						// arrived here the type can be added 
						thisFileTypes.Add(codeType);
						//if (codeType.IsEnum)
						//	enums.Add(codeType.Name, codeType);
					}
					catch (Exception) { }
				}

				string header = msg.Header;
				int internalcounter = 0;
				foreach (CodeTypeDeclaration codeType in codeNamespace.Types)
				{
					internalcounter++;
					msg.Header = $"{header} - Object #{internalcounter}";

					// create HASBEENSET flag stating a user type has or not been set (create an additional bool value set to true if the data has been set, false otherwise)
					//CodeMemberField hasBeenSetField = CreateFieldMember(NexoXSDStrings.NexoHasBeenSetField, typeof(bool), MemberAttributes.Private, false);
					CodeMemberProperty hasBeenSetProperty = CreatePropertyMember(NexoXSDStrings.NexoHasBeenSetProperty, typeof(bool), MemberAttributes.Assembly | MemberAttributes.Final);//, hasBeenSetField, bXSD, eXSD);

					// prepare OPTIMIZING flag statements as a FIELD (create an additional bool value set to true if optimizing the class, false otherwise)
					CodeMemberField optimizingField = CreateFieldMember(NexoXSDStrings.NexoOptimizingField, typeof(bool), MemberAttributes.Private, false);
					CodeMemberProperty optimizingProperty = CreatePropertyMember(NexoXSDStrings.NexoOptimizingProperty, typeof(bool), MemberAttributes.Assembly | MemberAttributes.Final);//, optimizingField, bXSD, eXSD);

					// create a list of properties that will receive special processing from XSDEx
					// properties that will require to be processed for HASBEENSET processing
					List<CodeMemberProperty> propertiesToProcess = new List<CodeMemberProperty>();
					// arrays that will require to be processed for HASBEENSET processing
					List<CodeMemberProperty> arraysToProcess = new List<CodeMemberProperty>();
					// properties having a "specified" flag that will require to be processed for HASBEENSET processing
					List<CodeMemberProperty> optionalsToProcess = new List<CodeMemberProperty>();

					try
					{
						string b = $"{bXSD}";
						string e = $"{eXSD}";
						bool addInterface = false;
						bool visible = ((TypeAttributes.Public == (codeType.TypeAttributes & TypeAttributes.Public)) ||
								(TypeAttributes.NestedPublic == (codeType.TypeAttributes & TypeAttributes.NestedPublic))) &&
								(TypeAttributes.Abstract != (codeType.TypeAttributes & TypeAttributes.Abstract));
						if (visible && (codeType.IsClass || codeType.IsStruct))
						{
							#region class pre-processing
							int i;
							CodeExpression ce;
							CodeConstructor cc;
							CodeAttributeArgument caa;
							CodeAttributeDeclaration cad;
							CodeAssignStatement cas;
							CodePrimitiveExpression cpe;
							CodeMethodReturnStatement cmrs;
							CodeMemberProperty cmp;
							CodeMemberMethod cmm;

							msg.Header = $"{msg.Header} - Class {codeType.Name}";

							// remove debugger settings
							cad = new CodeAttributeDeclaration("System.Diagnostics.DebuggerStepThroughAttribute");
							bool contains = false;
							for (i = 0; i < codeType.CustomAttributes.Count; i++)
								if (contains = (codeType.CustomAttributes[i].Name == cad.Name))
									break;
							if (contains)
								codeType.CustomAttributes.RemoveAt(i);

							// if the class must be visible on COM create its interface and make it visible too
							if (addInterface = settings.MakeClassComVisible)
							{
								AddGuid(codeType.CustomAttributes);
								AddClassInterface(codeType.CustomAttributes, settings.ClassInterface);
							}
							// make the type COM visible
							AddComVisible(codeType.CustomAttributes, addInterface);

							// create a collection for all new members (methods and consts created by XSDEx) inside the type
							CodeTypeMemberCollection addedMembers = new CodeTypeMemberCollection();
							// fields requiring to have a HASBEENSET flag
							List<CodeMemberField> fieldsHasBeenSetFlag = new List<CodeMemberField>();
							#endregion

							#region field management
							// parse all field members
							foreach (CodeTypeMember member in codeType.Members)
							{
								// process fields...
								if (member is CodeMemberField)
								{
									CodeMemberField field = (CodeMemberField)member;

									// verify if type needs to be converted (decimal to double,...)
									field.Type = ConvertType(settings, parameters, field.Type);

									// get the kind of type for this field
									CodeTypeDeclaration ctd = null;
									try
									{
										ctd = typesDeclaredInsideNamespace[field.Type.BaseType];
									}
									catch (Exception) { }

									// should private be replaced by internal ?
									if (settings.PrivateByInternal && MemberAttributes.Private == field.Attributes)
									{
										field.Attributes = MemberAttributes.Assembly;
									}

									// is it a field indicating whether a property has been set or no
									bool isSpecifiedField = field.Name.EndsWith(isSpecified);

									// the field does not describe a System.<Type>, isn't an array or an enum, we provide an initializer
									if (!IsPrimitiveType(field.Type) && !IsArray(field.Type) && (null == ctd || !ctd.IsEnum)
										&& (null == parameters.TypesWithoutInitializer ||
											(null != parameters.TypesWithoutInitializer && !parameters.TypesWithoutInitializer.Contains(field.Type.BaseType))))
									{
										// create "field = new Type();"
										field.InitExpression = new CodeObjectCreateExpression(field.Type.BaseType, new CodeExpression[] { });
									}
									// the field is an array, provide an initializer if no exception to it is set
									//else if (CanConvertArray(parameters, field.Type, field))
									else if (IsArray(field.Type)
										&& settings.ArrayCreateInitializer
										&& (null == parameters.ArrayTypesWithoutInitializer ||
											(null != parameters.ArrayTypesWithoutInitializer && !parameters.ArrayTypesWithoutInitializer.Contains(field.Type.BaseType))))
									{
										// create "field = new Type[0];"
										field.InitExpression = new CodeArrayCreateExpression(field.Type.BaseType, 0);
									}
									// the field is a primitive/system type, not an array, we provide a default initialiser and create a HASBEENSET flag
									else if ((null == parameters.TypesWithoutInitializer ||
										(null != parameters.TypesWithoutInitializer && !parameters.TypesWithoutInitializer.Contains(field.Type.BaseType))) &&
										!isSpecifiedField)
									{
										field.InitExpression = new CodeDefaultValueExpression(field.Type);
										fieldsHasBeenSetFlag.Add(new CodeMemberField() { Name = field.Name + NexoXSDStrings.NexoHasBeenSetField, InitExpression = new CodePrimitiveExpression(false), Type = new CodeTypeReference(typeof(bool)) });
									}
									else if (isSpecifiedField)
									{
										field.InitExpression = new CodePrimitiveExpression(false);
									}
									else
									{
										// nothing special
									}
								}
							}
							#endregion

							#region property type management
							// parse all property members
							foreach (CodeTypeMember member in codeType.Members)
							{
								// process properties...
								if (member is CodeMemberProperty)
								{
									#region property pre-processing
									CodePrimitiveExpression propertyDefault = null;

									// first add the property name to the list of tags
									try
									{ tags.Add(member.Name, member.Name); }
									catch (Exception) { }

									CodeMemberProperty property = (CodeMemberProperty)member;

									// get the kind of type for this property
									CodeTypeDeclaration ctd = null;
									try
									{
										ctd = typesDeclaredInsideNamespace[property.Type.BaseType];
									}
									catch (Exception) { }

									/*
									 * verify if type needs to be converted
									 */
									CodeTypeReference t = ConvertType(settings, parameters, property.Type);
									property.Type = t;

									/*
									 * search field linked to the property 
									 */
									CodeMemberField propertyField = null;
									foreach (CodeTypeMember mtb in codeType.Members)
										if (mtb is CodeMemberField)
											if (0 == string.Compare(property.Name + isField, mtb.Name, true))
											{
												propertyField = (CodeMemberField)mtb;
												break;
											}

									/*
									 * search whether this property is optional (there's a <name>Specified property, generated by the framework)
									 */
									bool optional = false;
									CodeMemberProperty propertySpecified = null;
									if (IsPrimitiveType(property.Type))
									{
										foreach (CodeTypeMember mtb in codeType.Members)
											if (mtb is CodeMemberProperty)
												if (optional = (0 == string.Compare(property.Name + isSpecified, mtb.Name, true)))
												{
													propertySpecified = (CodeMemberProperty)mtb;
													break;
												}
									}

									/*
									 * search whether this property has default value
									 */
									cad = new CodeAttributeDeclaration(new CodeTypeReference(typeof(System.ComponentModel.DefaultValueAttribute)));
									caa = GetAttributeArgument(property, cad);
									if (null != caa)
									{
										propertyDefault = GetAttributeArgumentValue(caa);
									}

									/*
									 * check whether type must be changed from string to integral type
									 * it is better to not do that !!!
									 */
									if (settings.ConvertStringIntegralToIntegral && IsStringType(property.Type) && !IsArray(property.Type))
									{
										caa = new CodeAttributeArgument("DataType", new CodePrimitiveExpression("integer"));
										cad = new CodeAttributeDeclaration(new CodeTypeReference(typeof(System.Xml.Serialization.XmlAttributeAttribute)), caa);
										if (null != (caa = GetAttributeArgument(property, cad, caa)))
										{
											// convert from string to integral type
											property.Type = new CodeTypeReference(typeof(int));
											if (null != propertyField)
											{
												propertyField.Type = property.Type;
												propertyField.InitExpression = new CodeDefaultValueExpression(propertyField.Type);
												if (null != propertyDefault)
												{
													try
													{
														propertyDefault = new CodePrimitiveExpression(int.Parse(propertyDefault.Value.ToString()));
														// replace default value attribute by the new one
														cad = new CodeAttributeDeclaration(new CodeTypeReference(typeof(System.ComponentModel.DefaultValueAttribute)), new CodeAttributeArgument[] { new CodeAttributeArgument(propertyDefault) });
														SetAttributeArgument(property, cad);
													}
													catch (Exception ex) { }
												}
											}
											// replace attribute type by nothing
											cad = new CodeAttributeDeclaration(new CodeTypeReference(typeof(System.Xml.Serialization.XmlAttributeAttribute)));
											SetAttributeArgument(property, cad);
										}
									}

									/*
									 * if the property is initialised within the constructor let's check the type is right
									 */
									// inside the class constructor replace the value by the const in the assignment
									UpdatePropertyFieldInsideConstructor(codeType, propertyField, propertyDefault);

									// if not a system object or an array we add the object to the list of properties that will be treated by XSDEx
									if (IsArray(property.Type))
									{
										arraysToProcess.Add(property);
									}
									else if (!IsPrimitiveType(property.Type) && null != ctd && !ctd.IsEnum && !optional)
									{
										propertiesToProcess.Add(property);
									}
									// if it is an optional flag save it for later use
									if (optional)
									{
										optionalsToProcess.Add(propertySpecified);
									}
									#endregion

									#region property accessors management
									// "set" property part
									if (property.HasSet)
									{
										// not a system type
										if (!IsPrimitiveType(property.Type) || IsArray(property.Type))
										{
											// remove all set statements to add ours
											property.SetStatements.Clear();

											// if not an enum...
											if (null == ctd || !ctd.IsEnum)
											{

												// determine the type of initialiser depending if array or not
												if (IsArray(property.Type))
												{
													ce = new CodeArrayCreateExpression(property.Type, 0);
												}
												else
												{
													ce = new CodeObjectCreateExpression(property.Type, new CodeExpression[] { });
												}

												// create "if (null==value) { object=new} else { object=value;}"
												CodeConditionStatement ccs = new CodeConditionStatement(
													new CodeBinaryOperatorExpression(
														new CodePropertySetValueReferenceExpression(),
														CodeBinaryOperatorType.ValueEquality,
														new CodePrimitiveExpression(null)),
													// if true
													new CodeStatement[]
														{
															//new CodeAssignStatement(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), NexoXSDStrings.NexoHasBeenSetField), new CodeBinaryOperatorExpression(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), hasBeenSetFieldStr), CodeBinaryOperatorType.BitwiseOr, new CodePropertyReferenceExpression(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), propertyField.Name), hasBeenSetFieldStr))),
															new CodeAssignStatement(
																new CodeFieldReferenceExpression(
																	new CodeThisReferenceExpression(),
																	propertyField.Name), ce)
														},
													// if false
													new CodeStatement[]
														{
															//new CodeAssignStatement(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), NexoXSDStrings.NexoHasBeenSetField), new CodePrimitiveExpression(true)),
															new CodeAssignStatement(
																new CodeFieldReferenceExpression(
																	new CodeThisReferenceExpression(),
																	propertyField.Name),
																new CodePropertySetValueReferenceExpression())
														}
													);
												property.SetStatements.Insert(0, new CodeCommentStatement($"{bXSD} - prevent {(IsArray(property.Type) ? "array" : "class")} from being null"));
												property.SetStatements.Insert(1, ccs);
												property.SetStatements.Insert(2, new CodeCommentStatement($"{eXSD}"));
											}
											// if an enum
											else
											{
												// let's do nothing
											}
										}

										// system type, not an array
										else
										{
											// if optional property update FieldSpecified flag when the property is set
											if (optional)
											{
												// set "...fieldSpecified=true" when setting the property
												string st = property.Name + isSpecified;
												cas = new CodeAssignStatement(
													new CodePropertyReferenceExpression(
														new CodeThisReferenceExpression(),
														st),
													new CodePrimitiveExpression(true));
												property.SetStatements.Add(new CodeCommentStatement($"{bXSD} - indicate optional system property value has been changed - {st} = true"));
												property.SetStatements.Add(cas);
												property.SetStatements.Add(new CodeCommentStatement($"{eXSD}"));
											}
										}

										// add set the "has been set" flag once the property is set
										if (null != propertySpecified && null != propertyField)
										{
											// this is non nullable data managed with ...Specified, let's not add a HASBEEN SET flag
											cas = null;
										}
										else if (null != propertyField && IsPrimitiveType(property.Type) && !IsArray(property.Type))
										{
											ce = (null == propertyDefault || !settings.UseDefaultValueForHasBeenModified ? (CodeExpression)new CodeDefaultValueExpression(propertyField.Type) : propertyDefault);
											// this is standard data supporting null let's add a HASBEEN SET flag
											cas = new CodeAssignStatement(
												new CodeFieldReferenceExpression(
													new CodeThisReferenceExpression(),
													propertyField.Name + NexoXSDStrings.NexoHasBeenSetField),
												new CodeBinaryOperatorExpression(
													new CodeFieldReferenceExpression(
														new CodeThisReferenceExpression(),
														propertyField.Name),
													CodeBinaryOperatorType.IdentityInequality,
													ce));
										}
										else
										{
											cas = null;
										}

										// if a CodeAssignStatement has been created add it
										if (null != cas)
										{
											property.SetStatements.Add(new CodeCommentStatement($"{bXSD} - indicate system value has been changed"));
											property.SetStatements.Add(cas);
											property.SetStatements.Add(new CodeCommentStatement($"{eXSD}"));
										}
									}

									// "get" property part
									if (property.HasGet)
									{
										// Set a "return null;" if array is of size 0
										//if (CanConvertArray(parameters, property.Type, property) && settings.ArrayGetReturnsNullEmpty)
										if (IsArray(property.Type) &&
											settings.ArrayGetReturnsNullEmpty)
										{
											CodeConditionStatement ccs = new CodeConditionStatement(
												new CodeBinaryOperatorExpression(
													new CodeBinaryOperatorExpression(
														new CodeFieldReferenceExpression(
															new CodeThisReferenceExpression(), propertyField.Name),
														CodeBinaryOperatorType.ValueEquality,
														new CodePrimitiveExpression(null)),
													CodeBinaryOperatorType.BooleanOr,
													new CodeBinaryOperatorExpression(
														new CodePropertyReferenceExpression(
															new CodeFieldReferenceExpression(
																new CodeThisReferenceExpression(), propertyField.Name),
															isLength),
														CodeBinaryOperatorType.ValueEquality,
														new CodePrimitiveExpression(0))),
													new CodeMethodReturnStatement(new CodePrimitiveExpression(null)));
											property.GetStatements.Insert(0, new CodeCommentStatement($"{bXSD} - return null if array count is 0, still keeping the array"));
											property.GetStatements.Insert(1, ccs);
											property.GetStatements.Insert(2, new CodeCommentStatement($"{eXSD}"));
										}

										// if it is not a System type, if optimizing is on and the class hasn't been updated return what's appropriate
										else if (!IsPrimitiveType(property.Type))
										{
											// if not an enum
											if (null == ctd || !ctd.IsEnum)
											{
												// in this case return null
												CodeConditionStatement ccs = new CodeConditionStatement(
																			new CodeBinaryOperatorExpression(
																				new CodeBinaryOperatorExpression(
																					new CodeFieldReferenceExpression(
																						new CodeThisReferenceExpression(), optimizingField.Name),
																					CodeBinaryOperatorType.ValueEquality,
																					new CodePrimitiveExpression(true)),
																				CodeBinaryOperatorType.BooleanAnd,
																				new CodeBinaryOperatorExpression(
																					new CodePropertyReferenceExpression(
																						new CodeFieldReferenceExpression(
																							new CodeThisReferenceExpression(), propertyField.Name),
																						hasBeenSetProperty.Name),
																					CodeBinaryOperatorType.ValueEquality,
																					new CodePrimitiveExpression(false))),
																				new CodeMethodReturnStatement(new CodePrimitiveExpression(null)));
												property.GetStatements.Insert(0, new CodeCommentStatement($"{bXSD} - return null if user type hasBeenModified=false"));
												property.GetStatements.Insert(1, ccs);
												property.GetStatements.Insert(2, new CodeCommentStatement($"{eXSD}"));
											}
											// if enum
											else
											{
												// do nothing
											}
										}
									}
									#endregion

									#region declare array accessors
									// if array then create accessors if requested
									//if (CanConvertArray(parameters, property.Type, property) && settings.CreateArrayAccessors)
									if (IsArray(property.Type) &&
										settings.CreateArrayAccessors &&
										(null == parameters.ArrayTypesWithoutAccessors ||
											(null != parameters.ArrayTypesWithoutAccessors && !parameters.ArrayTypesWithoutAccessors.Contains(property.Type.BaseType))))
									{
										// get Size method (if null!=array ? return array.size : 0)
										string addenda = sizeMethod;
										cmm = new CodeMemberMethod();
										cmm.Attributes = MemberAttributes.Public | MemberAttributes.Final;
										cmm.Name = property.Name + addenda;
										cmm.ReturnType = new CodeTypeReference(typeof(int));
										CodeConditionStatement ccs = new CodeConditionStatement(
											new CodeBinaryOperatorExpression(
												new CodeFieldReferenceExpression(
													new CodeThisReferenceExpression(), propertyField.Name),
												CodeBinaryOperatorType.ValueEquality,
												new CodePrimitiveExpression(null)),
											new CodeStatement[] { new CodeMethodReturnStatement(new CodePrimitiveExpression(0)) },
											new CodeStatement[] { new CodeMethodReturnStatement(
											new CodePropertyReferenceExpression(
												new CodeFieldReferenceExpression(
													new CodeThisReferenceExpression(), propertyField.Name),
													isLength)) });
										cmm.Statements.Add(new CodeCommentStatement($"{bXSD} - array {addenda} accessor"));
										cmm.Statements.Add(ccs);
										cmm.Statements.Add(new CodeCommentStatement($"{eXSD}"));
										addedMembers.Add(cmm);

										// get Item method (try	{return null != array ? array.Length - 1 >= index ? array[index] : default : default;}	catch (Exception) { return default; })
										addenda = getItemMethod;
										cmm = new CodeMemberMethod();
										cmm.Attributes = MemberAttributes.Public | MemberAttributes.Final;
										cmm.Name = property.Name + addenda;
										cmm.ReturnType = new CodeTypeReference(property.Type.BaseType);
										CodeParameterDeclarationExpression cpde = new CodeParameterDeclarationExpression(
											new CodeTypeReference(typeof(int)), isIndex);
										cmm.Parameters.Add(cpde);
										CodeTryCatchFinallyStatement ctcf = new CodeTryCatchFinallyStatement(
											new CodeStatement[]
												{ new CodeConditionStatement(
												new CodeBinaryOperatorExpression(
													new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), propertyField.Name),
													CodeBinaryOperatorType.ValueEquality,
													new CodeDefaultValueExpression(property.Type)),
												new CodeStatement[] { new CodeMethodReturnStatement(new CodeDefaultValueExpression(cmm.ReturnType)) },
												new CodeStatement[] {
													new CodeConditionStatement(
														new CodeBinaryOperatorExpression(
															new CodeBinaryOperatorExpression(
																new CodePropertyReferenceExpression(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), propertyField.Name), isLength),
																CodeBinaryOperatorType.Subtract,
																new CodePrimitiveExpression(1)),
															CodeBinaryOperatorType.GreaterThanOrEqual,
															//new CodePrimitiveExpression(parameter)),
															new CodeArgumentReferenceExpression(isIndex)),
														new CodeStatement[] { new CodeMethodReturnStatement(new CodeArrayIndexerExpression(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), propertyField.Name), new CodeArgumentReferenceExpression(isIndex))) },
														new CodeStatement[] { new CodeMethodReturnStatement(new CodeDefaultValueExpression(cmm.ReturnType)) }) }) },
											new CodeCatchClause[] { new CodeCatchClause(
											isEx,
											new CodeTypeReference(typeof(Exception)),
											new CodeStatement[] { new CodeMethodReturnStatement(new CodeDefaultValueExpression(cmm.ReturnType)) }) });
										cmm.Statements.Add(new CodeCommentStatement($"{bXSD} - array {addenda} accessor"));
										cmm.Statements.Add(ctcf);
										cmm.Statements.Add(new CodeCommentStatement($"{eXSD}"));
										addedMembers.Add(cmm);

										// set Item method (try	{return null != array ? array.Length - 1 >= index ? array[index] : default : default;}	catch (Exception) { return default; })
										addenda = setItemMethod;
										cmm = new CodeMemberMethod();
										cmm.Attributes = MemberAttributes.Public | MemberAttributes.Final;
										cmm.Name = property.Name + addenda;
										cmm.ReturnType = new CodeTypeReference(typeof(bool));
										cpde = new CodeParameterDeclarationExpression(
											new CodeTypeReference(typeof(int)), isIndex);
										cmm.Parameters.Add(cpde);
										string isValue = "value";
										cpde = new CodeParameterDeclarationExpression(
											new CodeTypeReference(property.Type.BaseType), isValue);
										cmm.Parameters.Add(cpde);
										ctcf = new CodeTryCatchFinallyStatement(
											new CodeStatement[]
												{ new CodeConditionStatement(
												new CodeBinaryOperatorExpression(
													new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), propertyField.Name),
													CodeBinaryOperatorType.ValueEquality,
													new CodeDefaultValueExpression(property.Type)),
												new CodeStatement[] { new CodeMethodReturnStatement(new CodePrimitiveExpression(false)) },
												new CodeStatement[] {
														new CodeAssignStatement(
															new CodeArrayIndexerExpression(
																new CodeFieldReferenceExpression(
																	new CodeThisReferenceExpression(), propertyField.Name),
																new CodeArgumentReferenceExpression(isIndex)),
															new CodeArgumentReferenceExpression(isValue)),
														new CodeMethodReturnStatement(new CodePrimitiveExpression(true))}) },
											new CodeCatchClause[] { new CodeCatchClause(
											isEx,
											new CodeTypeReference(typeof(Exception)),
											new CodeStatement[] { new CodeMethodReturnStatement(new CodePrimitiveExpression(false)) }) });
										cmm.Statements.Add(new CodeCommentStatement($"{bXSD} - array {addenda} accessor"));
										cmm.Statements.Add(ctcf);
										cmm.Statements.Add(new CodeCommentStatement($"{eXSD}"));
										addedMembers.Add(cmm);

										// add Item method (try	{return null != array ? array.Length - 1 >= index ? array[index] : default : default;}	catch (Exception) { return default; })
										addenda = addItemMethod;
										cmm = new CodeMemberMethod();
										cmm.Attributes = MemberAttributes.Public | MemberAttributes.Final;
										cmm.Name = property.Name + addenda;
										cmm.ReturnType = new CodeTypeReference(typeof(bool));
										cpde = new CodeParameterDeclarationExpression(
											new CodeTypeReference(property.Type.BaseType), isValue);
										cmm.Parameters.Add(cpde);
										ctcf = new CodeTryCatchFinallyStatement(
											// try statement
											new CodeStatement[]
												{ new CodeConditionStatement(
												new CodeBinaryOperatorExpression(
													new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), propertyField.Name),
													CodeBinaryOperatorType.ValueEquality,
													new CodeDefaultValueExpression(property.Type)),
												new CodeStatement[] { new CodeMethodReturnStatement(new CodePrimitiveExpression(false)) },
												new CodeStatement[] {
													// declare a new array of the same type + 1 item
													new CodeVariableDeclarationStatement(
														//new CodeTypeReference(m.Type.BaseType),
														property.Type,
														isArray,
														new CodeArrayCreateExpression(
															new CodeTypeReference(property.Type.BaseType),
															new CodeBinaryOperatorExpression(
																new CodePropertyReferenceExpression(
																	new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), propertyField.Name),
																	isLength),
																CodeBinaryOperatorType.Add,
																new CodePrimitiveExpression(1)))),
													// declare the counter
													new CodeVariableDeclarationStatement(typeof(int), isCounter, new CodePrimitiveExpression(0)),
													// for loop to copy old items inside the new array
													new CodeIterationStatement(
														// initializer
														new CodeAssignStatement(
															new CodeVariableReferenceExpression(isCounter),
															new CodePrimitiveExpression(0)),
														// test
														new CodeBinaryOperatorExpression(
															new CodeVariableReferenceExpression(isCounter),
															CodeBinaryOperatorType.LessThan,
															new CodePropertyReferenceExpression(
																new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), propertyField.Name),
																isLength)),
														// update counter
														new CodeAssignStatement(
															new CodeVariableReferenceExpression(isCounter),
															new CodeBinaryOperatorExpression(
																new CodeVariableReferenceExpression(isCounter),
																CodeBinaryOperatorType.Add,
																new CodePrimitiveExpression(1))),
														new CodeStatement[] { 
															// assign existing values to the new array
															new CodeAssignStatement(
																new CodeArrayIndexerExpression(
																	new CodeArgumentReferenceExpression(isArray),
																	new CodeArgumentReferenceExpression(isCounter)),
																new CodeArrayIndexerExpression(
																	new CodeArgumentReferenceExpression(propertyField.Name),
																	new CodeArgumentReferenceExpression(isCounter))) }),
													// copy new value to the new array
													new CodeAssignStatement(
														new CodeArrayIndexerExpression(
															new CodeArgumentReferenceExpression(isArray),
															new CodeArgumentReferenceExpression(isCounter)),
														new CodeArgumentReferenceExpression(isValue)),
													// replace existing array by new array
													new CodeAssignStatement(
														new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), property.Name),
														new CodeArgumentReferenceExpression(isArray)),
													// return true
													new CodeMethodReturnStatement(new CodePrimitiveExpression(true)) }) },
											// catch statement
											new CodeCatchClause[] { new CodeCatchClause(
											isEx,
											new CodeTypeReference(typeof(Exception)),
											new CodeStatement[] { new CodeMethodReturnStatement(new CodePrimitiveExpression(false)) }) });
										cmm.Statements.Add(new CodeCommentStatement($"{bXSD} - array {addenda} accessor"));
										cmm.Statements.Add(ctcf);
										cmm.Statements.Add(new CodeCommentStatement($"{eXSD}"));
										addedMembers.Add(cmm);

										// remove Item method 
										addenda = removeItemMethod;
										cmm = new CodeMemberMethod();
										cmm.Attributes = MemberAttributes.Public | MemberAttributes.Final;
										cmm.Name = property.Name + addenda;
										cmm.ReturnType = new CodeTypeReference(typeof(bool));
										cpde = new CodeParameterDeclarationExpression(
											new CodeTypeReference(typeof(int)), isIndex);
										cmm.Parameters.Add(cpde);
										ctcf = new CodeTryCatchFinallyStatement(
											// try statement
											new CodeStatement[]
												{ new CodeConditionStatement(
												new CodeBinaryOperatorExpression(
													new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), propertyField.Name),
													CodeBinaryOperatorType.ValueEquality,
													new CodeDefaultValueExpression(property.Type)),
												new CodeStatement[] { new CodeMethodReturnStatement(new CodePrimitiveExpression(false)) },
												new CodeStatement[]
													{
													new CodeConditionStatement(
														new CodeBinaryOperatorExpression(
															new CodePropertyReferenceExpression(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), propertyField.Name), isLength),
															CodeBinaryOperatorType.LessThanOrEqual,
															new CodeArgumentReferenceExpression(isIndex)),
														new CodeStatement[] { new CodeMethodReturnStatement(new CodePrimitiveExpression(false)) },
														new CodeStatement[] {
															// declare a new array of the same type - 1 item
															new CodeVariableDeclarationStatement(
																//new CodeTypeReference(m.Type.BaseType),
																property.Type,
																isArray,
																new CodeArrayCreateExpression(
																	new CodeTypeReference(property.Type.BaseType),
																	new CodeBinaryOperatorExpression(
																		new CodePropertyReferenceExpression(
																			new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), propertyField.Name),
																			isLength),
																		CodeBinaryOperatorType.Subtract,
																		new CodePrimitiveExpression(1)))),
															// declare the counter
															new CodeVariableDeclarationStatement(typeof(int), isCounter, new CodePrimitiveExpression(0)),
															// for loop to copy old items below requested index inside the new array
															new CodeIterationStatement(
																// initializer
																new CodeAssignStatement(new CodeVariableReferenceExpression(isCounter), new CodePrimitiveExpression(0)),
																// test
																new CodeBinaryOperatorExpression(
																	new CodeVariableReferenceExpression(isCounter),
																	CodeBinaryOperatorType.LessThan,
																	new CodeVariableReferenceExpression(isIndex)),
																// update counter
																new CodeAssignStatement(
																	new CodeVariableReferenceExpression(isCounter),
																	new CodeBinaryOperatorExpression(
																		new CodeVariableReferenceExpression(isCounter),
																		CodeBinaryOperatorType.Add,
																		new CodePrimitiveExpression(1))),
																new CodeStatement[] { 
																	// assign existing values to the new array
																	new CodeAssignStatement(
																		new CodeArrayIndexerExpression(
																			new CodeArgumentReferenceExpression(isArray),
																			new CodeArgumentReferenceExpression(isCounter)),
																		new CodeArrayIndexerExpression(
																			new CodeArgumentReferenceExpression(propertyField.Name),
																			new CodeArgumentReferenceExpression(isCounter))) }),
															// for loop to copy old items above requested index inside the new array
															new CodeIterationStatement(
																// initializer
																new CodeAssignStatement(
																	new CodeVariableReferenceExpression(isCounter),
																	new CodeBinaryOperatorExpression(
																		new CodeVariableReferenceExpression(isCounter),
																		CodeBinaryOperatorType.Add,
																		new CodePrimitiveExpression(1))),
																// test
																new CodeBinaryOperatorExpression(
																	new CodeVariableReferenceExpression(isCounter),
																	CodeBinaryOperatorType.LessThan,
																	new CodePropertyReferenceExpression(
																		new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), propertyField.Name),
																		isLength)),																
																// update counter
																new CodeAssignStatement(
																	new CodeVariableReferenceExpression(isCounter),
																	new CodeBinaryOperatorExpression(
																		new CodeVariableReferenceExpression(isCounter),
																		CodeBinaryOperatorType.Add,
																		new CodePrimitiveExpression(1))),
																new CodeStatement[] { 
																	// assign existing values to the new array
																	new CodeAssignStatement(
																		new CodeArrayIndexerExpression(
																			new CodeArgumentReferenceExpression(isArray),
																			new CodeArgumentReferenceExpression(isCounter)),
																		new CodeArrayIndexerExpression(
																			new CodeArgumentReferenceExpression(propertyField.Name),
																			new CodeArgumentReferenceExpression(isCounter))) }),
															// replace existing array by new array
															new CodeAssignStatement(
																new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), property.Name),
																new CodeArgumentReferenceExpression(isArray)),
															// return true
															new CodeMethodReturnStatement(new CodePrimitiveExpression(true)) }) }) },
											// catch statement
											new CodeCatchClause[] { new CodeCatchClause(
											isEx,
											new CodeTypeReference(typeof(Exception)),
											new CodeStatement[] { new CodeMethodReturnStatement(new CodePrimitiveExpression(false)) }) });
										cmm.Statements.Add(new CodeCommentStatement($"{bXSD} - array {addenda} accessor"));
										cmm.Statements.Add(ctcf);
										cmm.Statements.Add(new CodeCommentStatement($"{eXSD}"));
										addedMembers.Add(cmm);
									}
									#endregion
								}
							}
							#endregion

							List<CodeStatement> statements = new List<CodeStatement>();

							// add all...hasBeenSet fields
							foreach (CodeMemberField cmf in fieldsHasBeenSetFlag)
							{
								codeType.Members.Add(cmf);
							}

							#region has_been_modified management
							//*****
							// HASBEENSET property processing
							// "GET" statements
							AddComment(hasBeenSetProperty, b, true);
							CodeExpression expression = new CodePrimitiveExpression(false);
							foreach (CodeMemberProperty xcmp in propertiesToProcess)
							{
								// add user types HASBEENSET flag
								expression = new CodeBinaryOperatorExpression(
									expression,
									CodeBinaryOperatorType.BooleanOr,
									new CodeBinaryOperatorExpression(
										new CodeBinaryOperatorExpression(
											new CodePropertyReferenceExpression(
												new CodeThisReferenceExpression(),
												xcmp.Name),
											CodeBinaryOperatorType.IdentityInequality,
											new CodePrimitiveExpression(null)),
										CodeBinaryOperatorType.BooleanAnd,
										new CodePropertyReferenceExpression(
											new CodePropertyReferenceExpression(
												new CodeThisReferenceExpression(),
												xcmp.Name),
											hasBeenSetProperty.Name)));
							}
							// add size of array element
							foreach (CodeMemberProperty xcmp in arraysToProcess)
							{
								expression = new CodeBinaryOperatorExpression(
									expression,
									CodeBinaryOperatorType.BooleanOr,
									new CodeBinaryOperatorExpression(
										new CodeMethodInvokeExpression(
											new CodeMethodReferenceExpression(
												new CodeThisReferenceExpression(),
												xcmp.Name + sizeMethod),
											new CodeExpression[] { }),
										CodeBinaryOperatorType.IdentityInequality,
										new CodePrimitiveExpression(0)));
							}
							// add HASBEENSET flag of primitive data
							foreach (CodeMemberField xcmp in fieldsHasBeenSetFlag)
							{
								expression = new CodeBinaryOperatorExpression(
										expression,
										CodeBinaryOperatorType.BooleanOr,
										new CodeFieldReferenceExpression(
											new CodeThisReferenceExpression(),
											xcmp.Name));
							}
							// add ...Specified flag of primitive data without null ability
							foreach (CodeMemberProperty xcmp in optionalsToProcess)
							{
								expression = new CodeBinaryOperatorExpression(
									expression,
									CodeBinaryOperatorType.BooleanOr,
									new CodePropertyReferenceExpression(
										new CodeThisReferenceExpression(),
										xcmp.Name));
							}
							hasBeenSetProperty.GetStatements.Add(new CodeMethodReturnStatement(expression));
							AddComment(hasBeenSetProperty, e, true);
							#endregion

							#region optimizing management
							//// "SET" statements
							//AddSetStatementFromValue(hasBeenSetProperty, null, b, e);

							codeType.Members.Add(hasBeenSetProperty);

							//*****
							// OPTIMIZING property processing
							// "GET" add set optimizing flag to all
							AddGetStatementFromField(optimizingProperty, optimizingField, b, e);
							AddSetStatementFromValue(optimizingProperty, optimizingField, b, e);
							AddComment(optimizingProperty, b, false);
							statements.Clear();
							// process all user defined types to indicate OPTIMIZING is in progress
							foreach (CodeMemberProperty xcmp in propertiesToProcess)
							{
								//if (!IsArray(cmp.Type))
								//{
								statements.Add(new CodeConditionStatement(
									new CodeBinaryOperatorExpression(
										new CodePropertyReferenceExpression(
											new CodeThisReferenceExpression(),
											xcmp.Name),
										CodeBinaryOperatorType.IdentityInequality,
										new CodePrimitiveExpression(null)),
									new CodeStatement[]
									{
										new CodeAssignStatement(
											new CodePropertyReferenceExpression(
												new CodePropertyReferenceExpression(
													new CodeThisReferenceExpression(),
													xcmp.Name),
												optimizingProperty.Name),
											new CodeFieldReferenceExpression(
												new CodeThisReferenceExpression(),
												optimizingField.Name))
									}));
								//}
							}
							// process all arrays to indicate OPTIMIZING is in progress
							bool counterIsDeclared = false;
							foreach (CodeMemberProperty xcmp in arraysToProcess)
							{
								if (!IsPrimitiveType(xcmp.Type))
								{
									if (!counterIsDeclared)
									{
										// declare a counter
										statements.Add(new CodeVariableDeclarationStatement(
											typeof(int),
											isCounter,
											new CodePrimitiveExpression(0)));
										counterIsDeclared = true;
									}
									// for loop to copy old items inside the new array
									statements.Add(new CodeIterationStatement(
										// initializer
										new CodeAssignStatement(
											new CodeVariableReferenceExpression(isCounter),
											new CodePrimitiveExpression(0)),
										// test
										new CodeBinaryOperatorExpression(
											new CodeVariableReferenceExpression(isCounter),
											CodeBinaryOperatorType.LessThan,
											new CodeMethodInvokeExpression(
												new CodeMethodReferenceExpression(
													new CodeThisReferenceExpression(),
													xcmp.Name + sizeMethod))),
										// iteration
										new CodeAssignStatement(
											new CodeVariableReferenceExpression(isCounter),
											new CodeBinaryOperatorExpression(
												new CodeVariableReferenceExpression(isCounter),
												CodeBinaryOperatorType.Add,
												new CodePrimitiveExpression(1))),
										// set a value of any user defined record
										new CodeAssignStatement(
											new CodePropertyReferenceExpression(
												new CodeArrayIndexerExpression(
													new CodePropertyReferenceExpression(
														new CodeThisReferenceExpression(),
														xcmp.Name),
													new CodeArgumentReferenceExpression(isCounter)),
												NexoXSDStrings.NexoOptimizingProperty),
											new CodeFieldReferenceExpression(
												new CodeThisReferenceExpression(),
												NexoXSDStrings.NexoOptimizingField))));
								}
							}
							optimizingProperty.SetStatements.AddRange(statements.ToArray());
							AddComment(optimizingProperty, e, false);
							codeType.Members.Add(optimizingField);
							codeType.Members.Add(optimizingProperty);
							#endregion

							// update the collection of new members to the already existing ones inside this type
							// they are new methods for instance
							if (0 != addedMembers.Count)
							{
								codeType.Members.AddRange(addedMembers);
							}

							/*
							 * NEVER DO THAT IT GENERATES SERIALIZATION EXCEPTIONS
							 * 
							// add the base class if required
							if (!string.IsNullOrEmpty(settings.DerivedClassName) && codeType.IsClass)
							{
								codeType.BaseTypes.Add(new CodeTypeReference(settings.DerivedClassName));
							}
							*/

							// create the interface, adding all properties and methods
							if (addInterface || settings.DeclareClassInterface)
							{
								// if a public class and COM declaration is requested, let's crete the interface
								CodeTypeDeclaration itf = new CodeTypeDeclaration() { Name = string.Format("I{0}", codeType.Name), IsInterface = true };
								AddGuid(itf.CustomAttributes);
								AddInterfaceType(itf.CustomAttributes);
								AddComVisible(itf.CustomAttributes, addInterface);
								// add the interface to the list of inherited objects
								if (addInterface)
								{
									codeType.BaseTypes.Add(new CodeTypeReference(itf.Name));
								}
								// add all properties and methods declared inside the the object
								int counter = 1;
								foreach (CodeTypeMember m in codeType.Members)
								{
									if (MemberAttributes.Public == (m.Attributes & MemberAttributes.Public))
									{
										var itfM = CloneMember(m);
										itfM.CustomAttributes.Clear();
										if (settings.AddDispID)
											AddDispID(itfM.CustomAttributes, counter++);
										itf.Members.Add(itfM);
									}
								}

								// add interface as a new type element inside the generated code, if not already added
								try
								{
									string key = itf.Name + "myXSDInterface";
									typesDeclaredInsideNamespace.Add(key, itf);
									// arrived the interface doesn 't exist yet and can be added to the list of types/interaces inside this file
									thisFileTypes.Add(itf);
								}
								catch (Exception ex) { }
							}

						}
						else if (visible && codeType.IsInterface)
						{
							// if the class must be visible on COM indicate how it will be visible
							if (settings.MakeClassComVisible)
							{
								AddInterfaceType(codeType.CustomAttributes);
							}
							AddComVisible(codeType.CustomAttributes, settings.MakeClassComVisible);
						}
						else if (visible && codeType.IsEnum)
						{
							AddComVisible(codeType.CustomAttributes, settings.MakeEnumComVisible);
						}
					}
					catch (Exception ex) { }
				}

				// review all properties to add a JsonIgnore if XML ignore
				foreach (CodeTypeDeclaration codeType in codeNamespace.Types)
				{
					// process fields...
					foreach (CodeTypeMember member in codeType.Members)
					{
						if (member is CodeMemberProperty)
						{
							CodeMemberProperty property = (CodeMemberProperty)member;
							if (property.CustomAttributes.Contains(new CodeAttributeDeclaration(XML_IGNORE_ATTRIBUTE)) &&
								!property.CustomAttributes.Contains(new CodeAttributeDeclaration(JSON_IGNORE_ATTRIBUTE)))
							{
								property.CustomAttributes.Add(new CodeAttributeDeclaration(JSON_IGNORE_ATTRIBUTE));
							}
							bool xmlIgnore = false, jsonIgnore = false;
							foreach (CodeAttributeDeclaration attr in property.CustomAttributes)
							{
								xmlIgnore = xmlIgnore || 0 == string.Compare(attr.Name, XML_IGNORE_ATTRIBUTE, true);
								jsonIgnore = jsonIgnore || 0 == string.Compare(attr.Name, JSON_IGNORE_ATTRIBUTE, true);
							}
							if (xmlIgnore && !jsonIgnore)
								property.CustomAttributes.Add(new CodeAttributeDeclaration(JSON_IGNORE_ATTRIBUTE));
							if (!xmlIgnore && jsonIgnore)
								property.CustomAttributes.Add(new CodeAttributeDeclaration(XML_IGNORE_ATTRIBUTE));
						}
					}
				}

				//// create a Decimal formatting attribute
				//CodeAttributeDeclaration decimalFormat = new CodeAttributeDeclaration("DecimalFormatterAttribute");
				//typesDeclaredInsideNamespace.Add(decimalFormat);

				// if it is time to add the tags let's do it
				if (lastFile)
				{
					// tags are all names found across the classes
					// create a type with all tags and add it to the list of types
					CodeTypeDeclaration tagsType = new CodeTypeDeclaration("TagsEnumeration");
					AddComVisible(tagsType.CustomAttributes, settings.MakeEnumComVisible);
					tagsType.IsEnum = true;
					foreach (KeyValuePair<string, string> kv in tags)
					{
						CodeMemberField cm = new CodeMemberField("System.Int32", kv.Key);
						tagsType.Members.Add(cm);
					}

					// add tags
					try
					{
						typesDeclaredInsideNamespace.Add(tagsType.Name, tagsType);
						newCodeTypeDeclarations.Add(tagsType);
					}
					catch (Exception ex) { }
				}

				// add all specific classes, enums,... to the newly created namespace
				newCodeNamespace = new CodeNamespace(codeNamespace.Name);
				newCodeNamespace.Types.AddRange(thisFileTypes);
				newCodeNamespace.Types.AddRange(newCodeTypeDeclarations.ToArray());
			}
			catch (Exception ex)
			{
				settings.Exception = ex.Message;
			}
			return newCodeNamespace;
		}
		/// <summary>
		/// Generate code in supported language
		/// </summary>
		/// <param name="settings">settings to use</param>
		/// <param name="codeNameSpace">settings to use</param>
		/// <returns>Generated code or an empty string if an error has occurred</returns>
		public string GenerateCode(XSDSettings settings, CodeNamespace codeNameSpace)
		{
			// verify language 
			if (CMisc.IsEnumValue(typeof(enumLanguage), settings.Language))
			{
				CodeDomProvider codeProvider = enumLanguage.csharp == settings.Language ? (CodeDomProvider)new CSharpCodeProvider() : (CodeDomProvider)new VBCodeProvider();
				using (var writer = new StringWriter())
				{
					codeProvider.GenerateCodeFromNamespace(codeNameSpace, writer, new CodeGeneratorOptions());
					string s0 = writer.GetStringBuilder().ToString();
					string s1 = s0;
					string s2;
					do
					{
						s2 = s1;
						s1 = s1.Replace(" " + Chars.CRLF, Chars.CRLF);
						s1 = s1.Replace(Chars.CRLF + Chars.CRLF, Chars.CRLF);
					}
					while (s2 != s1);
					return s1;
				}
			}
			return string.Empty;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="settings"></param>
		/// <param name="parameters"></param>
		/// <param name="type"></param>
		/// <returns></returns>
		private static CodeTypeReference ConvertType(XSDSettings settings, XSDParams parameters, CodeTypeReference type)
		{
			XSDTypeConversions conversions = (IsArray(type) ? parameters.ArrayConversions : parameters.TypeConversions);
			CodeTypeReference ntype = null;
			// convert type if declared in the list of types to convert
			if (null != conversions && settings.ConvertTypes && conversions.ContainsKey(type.BaseType))
			{
				ntype = new CodeTypeReference(conversions[type.BaseType].TargetType);
			}
			// replace DateTime type by string if replacement requested
			else if (settings.DateTimeToString && settings.ConvertTypes && type.BaseType == typeof(System.DateTime).ToString())
			{
				ntype = new CodeTypeReference(typeof(string));
			}
			// replace scalar type by string if replacement requested
			else if (settings.NumericToString && settings.ConvertTypes &&
				(type.BaseType == typeof(System.Int16).ToString() ||
				type.BaseType == typeof(System.Int32).ToString() ||
				type.BaseType == typeof(System.Int64).ToString() ||
				type.BaseType == typeof(System.UInt16).ToString() ||
				type.BaseType == typeof(System.UInt32).ToString() ||
				type.BaseType == typeof(System.UInt64).ToString() ||
				type.BaseType == typeof(System.Double).ToString() ||
				type.BaseType == typeof(System.Decimal).ToString()))
			{
				ntype = new CodeTypeReference(typeof(string));
			}
			// replace scalar type by string if replacement requested
			else if (settings.BooleanToString && settings.ConvertTypes &&
				(type.BaseType == typeof(System.Boolean).ToString()))
			{
				ntype = new CodeTypeReference(typeof(string));
			}
			if (IsArray(type) && null != ntype)
				ntype.ArrayRank = conversions[type.BaseType].Rank;
			return ntype ?? type;
		}
		///// <summary>
		///// 
		///// </summary>
		///// <param name="parameters"></param>
		///// <param name="type"></param>
		///// <param name="member"></param>
		///// <returns></returns>
		//private static bool CanConvertArray(XSDParams parameters, CodeTypeReference type, CodeTypeMember member)
		//{
		//	//return (IsArray(type) /* BEWARE multi dimensional arrays are not well managed */
		//	//	&& (null == parameters.ArrayTypesWithoutInitializer
		//	//		|| (null != parameters.ArrayTypesWithoutInitializer && !parameters.ArrayTypesWithoutInitializer.Contains(type.BaseType)))
		//	//	&& (null == parameters.FieldsWithoutInitializer
		//	//		|| (null != parameters.FieldsWithoutInitializer && !parameters.FieldsWithoutInitializer.Contains(member.Name))
		//	//		|| (null != parameters.FieldsWithoutInitializer && parameters.FieldsWithoutInitializer.Contains(member.Name))));

		//	return (IsArray(type)
		//		&& (null == parameters.ArrayTypesWithoutInitializer
		//			|| (null != parameters.ArrayTypesWithoutInitializer && !parameters.ArrayTypesWithoutInitializer.Contains(type.BaseType))));
		//}
		private static bool IsArray(CodeTypeReference type)
		{
			int rank = type.ArrayRank;
			return 0 != type.ArrayRank;
		}
		private static bool IsObjectType(CodeTypeReference type)
		{
			Type t = Type.GetType(type.BaseType);
			if (null != t)
				return 0 == string.Compare(t.FullName, "system.object", true);
			return false;
		}
		private static bool IsStringType(CodeTypeReference type)
		{
			Type t = Type.GetType(type.BaseType);
			if (null != t)
				return 0 == string.Compare(t.FullName, "system.string", true);
			return false;
		}
		private static bool IsPrimitiveType(CodeTypeReference type)
		{
			Type t = Type.GetType(type.BaseType);
			if (null != t)
				return t.IsPrimitive || IsStringType(type) || IsObjectType(type);
			return false;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="m"></param>
		/// <returns></returns>
		private static CodeTypeMember CloneMember(CodeTypeMember m)
		{
			var ms = new MemoryStream();
			var formatter = new BinaryFormatter();
			formatter.Serialize(ms, m);
			ms.Seek(0, SeekOrigin.Begin);
			return formatter.Deserialize(ms) as CodeTypeMember;
		}
		private static void AddGuid(CodeAttributeDeclarationCollection attrs)
		{ attrs.Add(new CodeAttributeDeclaration(new CodeTypeReference("System.Runtime.InteropServices.GuidAttribute"), new CodeAttributeArgument(new CodePrimitiveExpression(Guid.NewGuid().ToString())))); }

		private static void AddComVisible(CodeAttributeDeclarationCollection attrs, bool visible = true)
		{ attrs.Add(new CodeAttributeDeclaration(new CodeTypeReference("System.Runtime.InteropServices.ComVisibleAttribute"), new CodeAttributeArgument(new CodePrimitiveExpression(visible)))); }

		private static void AddClassInterface(CodeAttributeDeclarationCollection attrs, ClassInterfaceType clsif = ClassInterfaceType.None)
		{
			attrs.Add(new CodeAttributeDeclaration(new CodeTypeReference("System.Runtime.InteropServices.ClassInterface"),
			 new CodeAttributeArgument(new CodeFieldReferenceExpression(new CodeTypeReferenceExpression("System.Runtime.InteropServices.ClassInterfaceType"), clsif.ToString()))));
		}

		private static void AddInterfaceType(CodeAttributeDeclarationCollection attrs, ComInterfaceType cit = ComInterfaceType.InterfaceIsDual)
		{ attrs.Add(new CodeAttributeDeclaration(new CodeTypeReference("System.Runtime.InteropServices.InterfaceTypeAttribute"), new CodeAttributeArgument(new CodeFieldReferenceExpression(new CodeTypeReferenceExpression("System.Runtime.InteropServices.ComInterfaceType"), cit.ToString())))); }

		private static void AddDispID(CodeAttributeDeclarationCollection attrs, int dispid)
		{ attrs.Add(new CodeAttributeDeclaration(new CodeTypeReference("DispId"), new CodeAttributeArgument(new CodePrimitiveExpression(dispid)))); }

		private static void AddElementAttribute(CodeAttributeDeclarationCollection attrs, string name, Type type)
		{
			attrs.Add(new CodeAttributeDeclaration(
				new CodeTypeReference("System.Xml.Serialization.XmlElementAttribute"),
				new CodeAttributeArgument(new CodeTypeOfExpression(type))));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="name"></param>
		/// <param name="type"></param>
		/// <param name="attr"></param>
		/// <returns></returns>
		private CodeMemberProperty CreatePropertyMember(string name, Type type, MemberAttributes attr)//, CodeMemberField field, string b = null, string e = null)
		{
			CodeMemberProperty cmp = new CodeMemberProperty()
			{
				Name = name,
				Type = new CodeTypeReference(type),
				Attributes = attr,
			};

			//*** for no reason I can understand JsonIgnore doesn't work !!!
			//// that init flag statement will not be serialized inside Json
			//cmp.CustomAttributes.Add(new CodeAttributeDeclaration("Newtonsoft.Json.JsonIgnore"));

			// that init flag statement will not be serialized inside XML
			cmp.CustomAttributes.Add(new CodeAttributeDeclaration(XML_IGNORE_ATTRIBUTE));
			cmp.CustomAttributes.Add(new CodeAttributeDeclaration(JSON_IGNORE_ATTRIBUTE));
			return cmp;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="name"></param>
		/// <param name="type"></param>
		/// <param name="attr"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		private CodeMemberField CreateFieldMember(string name, Type type, MemberAttributes attr, object value)
		{
			CodeMemberField cmf = new CodeMemberField(new CodeTypeReference(type), name);
			cmf.Attributes = attr;
			cmf.InitExpression = new CodePrimitiveExpression(value);
			return cmf;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="cmp"></param>
		/// <param name="field"></param>
		/// <param name="b"></param>
		/// <param name="e"></param>
		private void AddGetStatementFromField(CodeMemberProperty cmp, CodeMemberField field = null, string b = null, string e = null)
		{
			if (!string.IsNullOrEmpty(b)) cmp.GetStatements.Add(new CodeCommentStatement($"{b} - {MethodBase.GetCurrentMethod().Name}"));
			if (null != field)
				cmp.GetStatements.Add(new CodeMethodReturnStatement(new CodePropertyReferenceExpression(new CodeThisReferenceExpression(), field.Name)));
			if (!string.IsNullOrEmpty(e)) cmp.GetStatements.Add(new CodeCommentStatement($"{e} - {MethodBase.GetCurrentMethod().Name}"));
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="cmp"></param>
		/// <param name="field"></param>
		/// <param name="b"></param>
		/// <param name="e"></param>
		private void AddSetStatementFromValue(CodeMemberProperty cmp, CodeMemberField field, string b = null, string e = null)
		{
			if (!string.IsNullOrEmpty(b)) cmp.SetStatements.Add(new CodeCommentStatement($"{b} - {MethodBase.GetCurrentMethod().Name}"));
			if (null != field)
				cmp.SetStatements.Add(new CodeAssignStatement(new CodePropertyReferenceExpression(new CodeThisReferenceExpression(), field.Name), new CodePropertySetValueReferenceExpression()));
			if (!string.IsNullOrEmpty(e)) cmp.SetStatements.Add(new CodeCommentStatement($"{e} - {MethodBase.GetCurrentMethod().Name}"));
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="cmp"></param>
		/// <param name="comment"></param>
		/// <param name="get"></param>
		private void AddComment(CodeMemberProperty cmp, string comment, bool get)
		{
			if (!string.IsNullOrEmpty(comment))
				if (get)
					cmp.GetStatements.Add(new CodeCommentStatement(comment));
				else
					cmp.SetStatements.Add(new CodeCommentStatement(comment));
		}
		/// <summary>
		/// Allows parsing a property's custom attributes to retrieve a specific (or not) argument
		/// </summary>
		/// <param name="prop">The property to parse</param>
		/// <param name="decl">The Attribute to look for</param>
		/// <param name="arg">The argument to look for, null if no specific argument to look for</param>
		/// <returns>The argument to look for, null if not found</returns>
		private CodeAttributeArgument GetAttributeArgument(CodeMemberProperty prop, CodeAttributeDeclaration decl, CodeAttributeArgument arg = null)
		{
			CodeAttributeArgument o = null;
			bool hasBeenFound = false;
			// loop on all property attributes
			foreach (CodeAttributeDeclaration xcad in prop.CustomAttributes)
			{
				// search for a specific attribute
				if (0 == string.Compare(decl.Name, xcad.Name, true) &&
					0 != xcad.Arguments.Count)
				{
					// loop on all property attribute arguments
					foreach (CodeAttributeArgument caas in xcad.Arguments)
					{
						// if necessary search for a specific argument for this attribute
						if (null != arg)
						{
							if (0 == string.Compare(arg.Name, caas.Name, true) &&
								0 == string.Compare(((CodePrimitiveExpression)arg.Value).Value.ToString(), ((CodePrimitiveExpression)caas.Value).Value.ToString(), true))
							{
								// the argument is the one looked for, let's save it
								o = caas;
								hasBeenFound = true;
								break;
							}
						}
						else
						{
							// no specif argument to look for, the first one is to be saved
							o = caas;
							hasBeenFound = true;
							break;
						}
					}
				}
				if (hasBeenFound) break;
			}
			// return the found argument, if any
			return o;
		}
		/// <summary>
		/// Allows updating a property's custom attributes to a new declaration
		/// </summary>
		/// <param name="prop">The property to parse</param>
		/// <param name="decl">The Attribute to look for</param>
		/// <returns>The argument to look for, null if not found</returns>
		private bool SetAttributeArgument(CodeMemberProperty prop, CodeAttributeDeclaration decl)
		{
			bool hasBeenFound = false;
			int index;
			// loop on all property attributes
			for (index = 0; !hasBeenFound && index < prop.CustomAttributes.Count; index++)
			{
				// search for a specific attribute
				if (hasBeenFound = (0 == string.Compare(decl.Name, prop.CustomAttributes[index].Name, true) && 0 != prop.CustomAttributes[index].Arguments.Count))
					break;
			}
			// if found, replace the attribute
			if (hasBeenFound)
			{
				prop.CustomAttributes[index] = decl;
			}
			return hasBeenFound;
		}
		private CodePrimitiveExpression GetAttributeArgumentValue(CodeAttributeArgument arg)
		{
			if (null != arg)
				return (CodePrimitiveExpression)arg.Value;
			return null;
		}
		private CodeConstructor GetClassConstructor(CodeTypeDeclaration codeType)
		{
			bool found = false;
			CodeConstructor cc = null;
			foreach (CodeTypeMember xctm in codeType.Members)
			{
				// search a constructor
				if (found = (xctm is CodeConstructor))
				{
					cc = (CodeConstructor)xctm;
				}
				if (found) break;
			}
			return cc;
		}
		private bool UpdatePropertyFieldInsideConstructor(CodeTypeDeclaration codeType, CodeMemberField field, CodeExpression exp)
		{
			// only if a fiedl to update is present
			if (null != field)
			{
				// inside the class constructor replace the value by the const in the assignment
				CodeConstructor cc = GetClassConstructor(codeType);
				if (null != cc && 0 != cc.Statements.Count)
				{
					// search a statement initialising the property with its default value
					foreach (CodeStatement xcss in cc.Statements)
					{
						if ((xcss is CodeAssignStatement) &&
							(((CodeAssignStatement)xcss).Left is CodeFieldReferenceExpression) &&
							(((CodeFieldReferenceExpression)((CodeAssignStatement)xcss).Left).FieldName == field.Name))
						{
							// change the assignment to use
							if (null == exp)
								((CodeAssignStatement)xcss).Right = new CodeDefaultValueExpression(field.Type);
							else
								((CodeAssignStatement)xcss).Right = exp;
							return true;
						}
					}
				}
			}
			return false;
		}
		#endregion
	}
}