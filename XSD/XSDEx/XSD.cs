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
		private MyCodeTypeDeclarations typesDeclaredInsideNamespace = new MyCodeTypeDeclarations();
		private MyCodeTypeDeclarations enumsDeclaredInsideNamespace = new MyCodeTypeDeclarations();
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
				XSDParams parameters = default;
				parameters = json.ReadSettings();
				if (default == parameters)
				{
					parameters = parameters ?? new XSDParams();
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

				#region process file or files
				typesDeclaredInsideNamespace.Clear();
				enumsDeclaredInsideNamespace.Clear();
				if (settings.mixFiles)
				{
					// all XSD will generate 1 file
					MyTags tags = new MyTags();
					XmlSchemas xsds = new XmlSchemas();
					string fileName = null;
					// load all selected files into a schema and compile
					foreach (string file in settings.xsdSettings.Files)
					{
						FileInfo fi = new FileInfo(file);
						//if (string.IsNullOrEmpty(fileName))
						//fileName = settings.xsdSettings.Files[0] + GetExtension(settings.xsdSettings);
						fileName = fi.Directory.FullName + Path.AltDirectorySeparatorChar + Path.GetFileNameWithoutExtension(fi.FullName) + GetExtension(settings.xsdSettings);
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
						FileInfo fi = new FileInfo(settings.xsdSettings.Files[i]);
						string fileName = fi.Directory.FullName + Path.AltDirectorySeparatorChar + Path.GetFileNameWithoutExtension(fi.FullName) + GetExtension(settings.xsdSettings);
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
				#endregion
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
				settings.Nmspace += (XSDSettings.NameSpace.None == settings.NamespaceToDeclare ? null : $".{settings.NamespaceToDeclare}");

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

				// display in texbox
				//CodeGenerator.ValidateIdentifiers(codeNamespace);
				CodeGenerator.ValidateIdentifiers(newCodeNamespace);

				// create the code
				msg.Text = "Generating code";

				Code = GenerateCode(settings, newCodeNamespace);

				// add preprocessor around the code
				//if (!string.IsNullOrEmpty(beginPreprocessor))
				//{
				//Code = $"{beginPreprocessor}\r\n{Code}{endPreprocessor}";
				//}

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
			bool addNewtonSoft = false;
			bool addSerialization = false;
			CodeNamespace newCodeNamespace = null;

			msg.Text = "Post process";
			try
			{
				string lengthMethod = NexoXSDStrings.AccessorLength,
				 getItemMethod = NexoXSDStrings.AccessorGetItem,
				 setItemMethod = NexoXSDStrings.AccessorSetItem,
				 addItemMethod = NexoXSDStrings.AccessorAddItem,
				 removeItemMethod = NexoXSDStrings.AccessorRemoveItem,
				 insertItemMethod = NexoXSDStrings.AccessorInsertItem,
				 isArray = "array",
				 isCounterI = "i",
				 isCounterJ = "j",
				 isCounterK = "k",
				 isField = "Field",
				 isLength = "Length",
				 isEx = "ex",
				 isIndex = "index",
				 isValue = "value",
				 bXSD = "BEGIN ADDED BY XSD",
				 eXSD = "END ADDED BY XSD";

				// file specific objects to add
				List<CodeTypeDeclaration> newCodeTypeDeclarations = new List<CodeTypeDeclaration>();

				// create file specific list of types
				CodeTypeDeclarationCollection thisFileTypes = new CodeTypeDeclarationCollection();

				// prepare a list of all types declared inside the namespace (specific types)
				foreach (CodeTypeDeclaration codeType in codeNamespace.Types)
				{
					try
					{
						// add this type to the list of types to generate
						typesDeclaredInsideNamespace.Add(codeType.Name, codeType);
						if (codeType.IsEnum)
							enumsDeclaredInsideNamespace.Add(codeType.Name, codeType);
						// add this type to the list of types to declare in this file (for multi-files XSD)
						thisFileTypes.Add(codeType);
					}
					catch (Exception ex)
					{
						settings.Exception = ex.Message;
					}
				}

				string header = msg.Header;

				// declare a counter of processed objects
				int internalcounter = 0;
				foreach (CodeTypeDeclaration codeType in codeNamespace.Types)
				{
					CodeBinaryOperatorExpression cboe;
					CodeConditionStatement ccs;
					CodeStatement[] css;
					CodeStatement cs;
					CodeExpression ce;
					CodeAttributeArgument caa;
					CodeAttributeDeclaration cad;
					CodeAssignStatement cas;
					CodePrimitiveExpression cpe;
					CodeMethodReturnStatement cmrs;
					CodeMemberProperty cmp;
					CodeMemberField cmf;
					CodeTypeMember ctm;
					CodeMemberMethod cmm;
					CodeTypeReference ctr;
					CodeTypeReferenceExpression ctre;
					int counter;

					internalcounter++;
					msg.Header = $"{header} - Object #{internalcounter}";

					try
					{
						#region codetype management
						string b = $"{bXSD}";
						string e = $"{eXSD}";
						bool addInterface = false;
						bool visible = ((TypeAttributes.Public == (codeType.TypeAttributes & TypeAttributes.Public)) ||
								(TypeAttributes.NestedPublic == (codeType.TypeAttributes & TypeAttributes.NestedPublic))) &&
								(TypeAttributes.Abstract != (codeType.TypeAttributes & TypeAttributes.Abstract));

						if (settings.UseNullableIntegralTypes)

							AddClassIXmlSerializableInheritance(codeType);

						// create a HASBEENSET flag stating a XSD specific type has (TRUE) or not (FALSE) been set
						CodeMemberProperty hasBeenSetProperty = CreatePropertyMember(HasbeenSetPropertyName(), new CodeTypeReference(typeof(bool)), MemberAttributes.Public | MemberAttributes.Final);

						CodeMemberField optimizingField = null;
						CodeMemberProperty optimizingProperty = null;
						if (settings.UseOptimizingFlag)
						{
							// prepare OPTIMIZING flag statements to allow optimizing resulting XML
							optimizingField = CreateFieldMember(NexoXSDStrings.NexoOptimizingField, new CodeTypeReference(typeof(bool)), (settings.PrivateByInternal ? MemberAttributes.Assembly : MemberAttributes.Private) | MemberAttributes.Final, false);
							optimizingProperty = CreatePropertyMember(NexoXSDStrings.NexoOptimizingProperty, new CodeTypeReference(typeof(bool)), MemberAttributes.Assembly | MemberAttributes.Final);
						}

						// create class name property ( flag stating a user type has or not been set (create an additional bool value set to true if the data has been set, false otherwise)
						CodeMemberProperty className = CreatePropertyMember($"{codeType.Name}{NexoXSDStrings.NexoClassName}", new CodeTypeReference(typeof(string)), MemberAttributes.Public | MemberAttributes.Final);

						// create a list of properties that will receive special processing from XSDEx
						// list of all namespace types (declared inside the namespace) that must be processed for HASBEENSET processing
						List<CodeMemberProperty> namespaceTypesToProcessInHasBeenSet = new List<CodeMemberProperty>();
						// list of all primitive properties that must be processed for HASBEENSET processing
						List<CodeMemberProperty> primitivesToProcessInHadBeenSet = new List<CodeMemberProperty>();
						// list of all arrays that must be processed for HASBEENSET processing
						List<CodeMemberProperty> arraysToProcessInHadBeenSet = new List<CodeMemberProperty>();
						// properties having a "specified" flag that will require to be processed for HASBEENSET processing
						List<CodeMemberProperty> optionalsToProcessInHadBeenSet = new List<CodeMemberProperty>();
						// list of all namespace types (declared inside the namespace) that must be processed for HASBEENSET processing
						List<CodeMemberProperty> xmlWriteAndRead = new List<CodeMemberProperty>();
						#endregion

						// a class or struct that can be used outside the namespace
						if (visible && (codeType.IsClass || codeType.IsStruct))
						{
							#region class pre-processing
							int i;

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
							CodeTypeMemberCollection deletedMembers = new CodeTypeMemberCollection();
							CodeTypeMemberCollection addedToConstructor = new CodeTypeMemberCollection();

							// create a list of all fields supporting the HASBEENSET flag for a property
							List<CodeMemberField> hasBeenSetFields = new List<CodeMemberField>();

							//// create an initializing procedure
							//CodeMemberMethod initializeMethod = new CodeMemberMethod();
							//initializeMethod.Attributes = MemberAttributes.Private | MemberAttributes.Final;
							//initializeMethod.Name = $"{codeType.Name}{classInitMethod}";
							//initializeMethod.ReturnType = new CodeTypeReference(typeof(void));
							//addedMembers.Add(initializeMethod);

							// search for a default constructor, if none let's create it
							CodeConstructor defaultConstructor = GetDefaultClassConstructor(codeType);
							if (null == defaultConstructor)
							{
								defaultConstructor = new CodeConstructor();
								defaultConstructor.Statements.AddRange(new CodeStatement[] { });
								defaultConstructor.Attributes = MemberAttributes.Public | MemberAttributes.Final;
								//defaultConstructor.Statements.Add(new CodeMethodInvokeExpression(
								//	new CodeMethodReferenceExpression(
								//		new CodeThisReferenceExpression(),
								//		initializeMethod.Name)));
								codeType.Members.Add(defaultConstructor);
							}
							defaultConstructor.Statements.Clear();
							#endregion

							#region property management
							// parse all property members
							foreach (CodeTypeMember member in codeType.Members)
							{
								// process properties...
								if (member is CodeMemberProperty)
								{
									#region property pre-processing
									CodeMemberProperty property = (CodeMemberProperty)member;

									// first add the property name to the list of tags
									try
									{
										tags.Add(member.Name, member.Name);
									}
									catch (Exception ex)
									{
									}

									// get the kind of type for this property
									CodeTypeDeclaration ctd = null;
									try
									{
										ctd = typesDeclaredInsideNamespace[property.Type.BaseType];
										if (null != ctd && ctd.IsEnum) ctd = null;
									}
									catch (Exception ex)
									{
									}

									// by default do not change the type to nullable
									bool makeNullableType = settings.UseNullableIntegralTypes;
									bool canBeUsedInHasBeenSet = true;

									// search field linked to the property
									string pname;
									CodeMemberField propertyField = null;
									if (!property.Name.EndsWith(NexoXSDStrings.Specified))
									{
										pname = property.Name + isField;
									}
									else
									{
										int index = property.Name.LastIndexOf(NexoXSDStrings.Specified);
										pname = property.Name.Substring(0, index) + isField + NexoXSDStrings.Specified;
									}
									propertyField = (CodeMemberField)GetMemberByName<CodeMemberField>(codeType, property, pname);
									if (null == propertyField)
									{
										propertyField = CreateFieldMember(pname, property.Type, (settings.PrivateByInternal ? MemberAttributes.Assembly : MemberAttributes.Private) | MemberAttributes.Final, new CodeDefaultValueExpression(property.Type));
										addedMembers.Add(propertyField);
									}

									// verify if type is to be converted
									CodeTypeReference t = ConvertType(settings, parameters, property.Type);
									property.Type = t;
									propertyField.Type = t;
									#endregion

									#region search linked fields and properties
									// search whether this property has any default value
									cad = new CodeAttributeDeclaration(new CodeTypeReference(typeof(System.ComponentModel.DefaultValueAttribute)));
									caa = GetAttributeArgument(property, cad);
									CodePrimitiveExpression propertyDefaultValue = null;
									if (null != caa)
									{
										propertyDefaultValue = GetAttributeArgumentValue(caa);
									}

									// check whether type must be changed from string to integral type
									// check whether the type should be integer but is carried by a string
									CodeExpression propertyFieldInit = null;
									caa = new CodeAttributeArgument("DataType", new CodePrimitiveExpression("integer"));
									cad = new CodeAttributeDeclaration(new CodeTypeReference(typeof(System.Xml.Serialization.XmlAttributeAttribute)), caa);
									if (null != (caa = GetAttributeArgument(property, cad, caa)) && settings.ConvertStringIntegralToIntegral && IsStringType(property.Type) && !IsArray(property.Type))
									{
										// convert from string to integral type
										property.Type = new CodeTypeReference(typeof(int));
										propertyField.Type = property.Type;
										if (null != propertyDefaultValue)
											propertyDefaultValue = new CodePrimitiveExpression(int.Parse(propertyDefaultValue.Value.ToString()));
										// replace default value attribute by the new one
										cad = new CodeAttributeDeclaration(
											new CodeTypeReference(typeof(System.ComponentModel.DefaultValueAttribute)),
											new CodeAttributeArgument[] { new CodeAttributeArgument(propertyDefaultValue) });
										SetAttributeArgument(property, cad);

										// replace attribute type by nothing
										cad = new CodeAttributeDeclaration(new CodeTypeReference(typeof(System.Xml.Serialization.XmlAttributeAttribute)));
										SetAttributeArgument(property, cad);
									}
									propertyField.InitExpression = propertyFieldInit = new CodeDefaultValueExpression(property.Type);
									#endregion

									#region default value management
									// If a default value exists create a property to reflect it
									CodeMemberField propertyDefaultValueField = null;
									CodeMemberProperty propertyDefaultValueProperty = null;
									if (null != propertyDefaultValue)
									{
										// create a property to access that constant anywhere
										propertyDefaultValueProperty = CreatePropertyMember($"{property.Name}{NexoXSDStrings.NexoDefaultValueForProperty}", property.Type, MemberAttributes.Public | MemberAttributes.Final);
										propertyDefaultValueField = CreateFieldMember($"{FieldNameFromPropretyName(property.Name)}{NexoXSDStrings.NexoDefaultValueForProperty}", property.Type, (settings.PrivateByInternal ? MemberAttributes.Assembly : MemberAttributes.Private) | MemberAttributes.Final, propertyDefaultValue.Value);
										propertyDefaultValueProperty.GetStatements.Add(new CodeMethodReturnStatement(
											new CodeFieldReferenceExpression(
												new CodeThisReferenceExpression(),
												propertyDefaultValueField.Name)));
										addedMembers.Add(propertyDefaultValueField);
										addedMembers.Add(propertyDefaultValueProperty);
										// assign the default value to the linked field
										propertyField.InitExpression = propertyFieldInit = propertyDefaultValue;
										// put this statement inside the default constructor
										cs = new CodeAssignStatement(
											new CodeFieldReferenceExpression(new CodeThisReferenceExpression(),
											propertyField.Name),
											new CodeFieldReferenceExpression(
												new CodeThisReferenceExpression(),
												propertyDefaultValueField.Name));
										defaultConstructor.Statements.Add(cs);
									}
									#endregion

									#region <property>Specified management
									// if the property is not a ...Specified property search the attached ...Specified property and field, create them if they don't exist
									bool propertyToProcessInHasBeenSet = !property.Name.EndsWith(NexoXSDStrings.Specified);
									CodeMemberProperty propertySpecifiedProperty = null;
									CodeMemberField propertySpecifiedPropertyField = null;
									// only integral types and classes declared inside the namespace will have a ..Specified linked property
									// by doing so we allow any namespace defined class to be present or not inside the resulting XML by setting the <memberName>Specified proerpty to true (present) or false (not present)
									if (!property.Name.EndsWith(NexoXSDStrings.Specified))// && (IsPrimitiveType(property.Type) || null != ctd || IsArray(property.Type)))
									{
										//bool propertySpecifiedPropertyWasCreated = false;
										// <property>Specified
										pname = property.Name + NexoXSDStrings.Specified;
										propertySpecifiedProperty = (CodeMemberProperty)GetMemberByName<CodeMemberProperty>(codeType, property, pname);
										if (null == propertySpecifiedProperty)
										{
											propertySpecifiedProperty = CreatePropertyMember(pname, new CodeTypeReference(typeof(bool)), MemberAttributes.Public | MemberAttributes.Final);
											addedMembers.Add(propertySpecifiedProperty);
											//propertySpecifiedPropertyWasCreated = true;
										}

										// <property>FieldSpecified
										pname = propertyField.Name + NexoXSDStrings.Specified;
										propertySpecifiedPropertyField = (CodeMemberField)GetMemberByName<CodeMemberField>(codeType, propertySpecifiedProperty, pname);
										if (null == propertySpecifiedPropertyField)
										{
											propertySpecifiedPropertyField = CreateFieldMember(pname, new CodeTypeReference(typeof(bool)), (settings.PrivateByInternal ? MemberAttributes.Assembly : MemberAttributes.Private) | MemberAttributes.Final, false);
											addedMembers.Add(propertySpecifiedPropertyField);
										}
										propertySpecifiedPropertyField.InitExpression = new CodePrimitiveExpression(false);
									}

									// process ...Specified properties
									if (null != propertySpecifiedProperty)
									{
										// ...Specified GET
										propertySpecifiedProperty.GetStatements.Clear();
										propertySpecifiedProperty.GetStatements.Add(new CodeCommentStatement($"{bXSD}"));

										cs = new CodeMethodReturnStatement(
											// specified ||
											new CodeBinaryOperatorExpression(
												new CodeFieldReferenceExpression(
													new CodeThisReferenceExpression(),
													propertySpecifiedPropertyField.Name),
												CodeBinaryOperatorType.BooleanOr,
												IsArray(property.Type)
												// 0 != Length()
												? (CodeExpression)new CodeBinaryOperatorExpression(
													new CodeMethodInvokeExpression(
														new CodeMethodReferenceExpression(
															new CodeThisReferenceExpression(),
															property.Name + lengthMethod),
														new CodeExpression[] { }),
													CodeBinaryOperatorType.GreaterThan,
													new CodePrimitiveExpression(0))
												: null != ctd
												// hasbeenset
												? (CodeExpression)new CodePropertyReferenceExpression(
													new CodePropertyReferenceExpression(
														new CodeThisReferenceExpression(),
														property.Name),
													HasbeenSetPropertyName())
												// no other explanation
												: (CodeExpression)new CodePrimitiveExpression(false)));

										propertySpecifiedProperty.GetStatements.Add(cs);
										propertySpecifiedProperty.GetStatements.Add(new CodeCommentStatement($"{eXSD}"));

										// ...Specified SET
										propertySpecifiedProperty.SetStatements.Clear();
										propertySpecifiedProperty.SetStatements.Add(new CodeCommentStatement($"{bXSD}"));

										cs = new CodeAssignStatement(
											new CodeFieldReferenceExpression(
												new CodeThisReferenceExpression(),
												propertySpecifiedPropertyField.Name),
											new CodePropertySetValueReferenceExpression());
										propertySpecifiedProperty.SetStatements.Add(cs);

										if (null != propertyDefaultValue)
										{
											cs = new CodeConditionStatement(
												new CodeBinaryOperatorExpression(
													new CodeFieldReferenceExpression(
														new CodeThisReferenceExpression(),
														propertySpecifiedPropertyField.Name),
													CodeBinaryOperatorType.BooleanAnd,
													new CodeBinaryOperatorExpression(
														new CodeFieldReferenceExpression(
															new CodeThisReferenceExpression(),
															propertyField.Name),
														CodeBinaryOperatorType.IdentityEquality,
														new CodeDefaultValueExpression(property.Type))),
												new CodeStatement[]
												{
														new CodeAssignStatement(
															new CodeFieldReferenceExpression(
																new CodeThisReferenceExpression(),
																propertyField.Name),
															new CodeFieldReferenceExpression(
																new CodeThisReferenceExpression(),
																propertyDefaultValueField.Name))
												});
											propertySpecifiedProperty.SetStatements.Add(cs);
										}
										propertySpecifiedProperty.SetStatements.Add(new CodeCommentStatement($"{eXSD}"));
									}
									#endregion

									#region property type management
									if (propertyToProcessInHasBeenSet)
									{
										#region has been set property management
										// the field is an array, provide an initializer if no exception to it is set
										if (IsArray(property.Type))
										{
											propertyField.InitExpression = new CodeArrayCreateExpression(propertyField.Type.BaseType, 0);
											arraysToProcessInHadBeenSet.Add(property);
										}
										// the field is a primitive type
										else if (IsPrimitiveType(property.Type))
										{
											propertyField.InitExpression = new CodeDefaultValueExpression(property.Type);
											//propertyField.InitExpression = new CodeDefaultValueExpression(new CodeTypeReference(notNullableType));
											//AddHasBeenSetFlag(propertyField);
											if (canBeUsedInHasBeenSet)
												primitivesToProcessInHadBeenSet.Add(property);
										}
										// the property is not a System.<Type>, isn't an array, isn't a specific type of is one but not an enum one, we provide an initializer
										else if (null != ctd)
										{
											// create "field = new Type();"
											propertyField.InitExpression = new CodeObjectCreateExpression(propertyField.Type.BaseType, new CodeExpression[] { });
											namespaceTypesToProcessInHasBeenSet.Add(property);
										}
										#endregion

										#region property SET management
										// "set" property part
										if (property.HasSet)
										{
											// remove all set statements to add ours
											property.SetStatements.Clear();

											CodeExpression cenovalue = null, cetest = new CodePrimitiveExpression(false);
											// determine the type of initialiser
											if (IsArray(property.Type))
											{
												cenovalue = new CodeDefaultValueExpression(property.Type);
												ce = new CodeArrayCreateExpression(property.Type, 0);
											}
											else if (null != ctd)
											{
												cenovalue = new CodeDefaultValueExpression(property.Type);
												ce = new CodeObjectCreateExpression(property.Type, new CodeExpression[] { });
											}
											else if (null == propertyDefaultValue)
											{
												cenovalue = new CodeDefaultValueExpression(property.Type);
												ce = new CodeDefaultValueExpression(property.Type);
											}
											else
											{
												ce = new CodeFieldReferenceExpression(
													new CodeThisReferenceExpression(),
													propertyDefaultValueProperty.Name);
												cenovalue = ce;
												if (IsStringType(property.Type))
													cetest = new CodeBinaryOperatorExpression(
														new CodePropertySetValueReferenceExpression(),
														CodeBinaryOperatorType.IdentityEquality,
														new CodeDefaultValueExpression(property.Type));
											}

											cs = new CodeConditionStatement(
												// value == null or default
												new CodeBinaryOperatorExpression(
													new CodeBinaryOperatorExpression(
														new CodePropertySetValueReferenceExpression(),
														CodeBinaryOperatorType.IdentityEquality,
														cenovalue),
													CodeBinaryOperatorType.BooleanOr,
													cetest),
												// then
												new CodeStatement[]
												{
													// property = default
													new CodeAssignStatement(
														new CodeFieldReferenceExpression(
															new CodeThisReferenceExpression(),
															propertyField.Name),
														ce),
													// specified = false
													new CodeAssignStatement(
														new CodeFieldReferenceExpression(
															new CodeThisReferenceExpression(),
															propertySpecifiedPropertyField.Name),
														new CodePrimitiveExpression(false))
												},
												// else
												IsArray(property.Type)
												? new CodeStatement[]
												{
													// property = value
													new CodeAssignStatement(
														new CodeFieldReferenceExpression(
															new CodeThisReferenceExpression(),
															propertyField.Name),
														new CodePropertySetValueReferenceExpression()),
													// specified = length()!=0
													new CodeAssignStatement(
														new CodeFieldReferenceExpression(
															new CodeThisReferenceExpression(),
															propertySpecifiedPropertyField.Name),
														new CodeBinaryOperatorExpression(
															new CodeMethodInvokeExpression(
																new CodeMethodReferenceExpression(
																	new CodeThisReferenceExpression(),
																	property.Name + lengthMethod),
																new CodeExpression[] { }),
															CodeBinaryOperatorType.GreaterThan,
															new CodePrimitiveExpression(0)))
												}
												: null != ctd
												? new CodeStatement[]
												{
													// property=value
													new CodeAssignStatement(
														new CodeFieldReferenceExpression(
															new CodeThisReferenceExpression(),
															propertyField.Name),
														new CodePropertySetValueReferenceExpression()),
													// specified = hasbeenset
													new CodeAssignStatement(
														new CodeFieldReferenceExpression(
															new CodeThisReferenceExpression(),
															propertySpecifiedPropertyField.Name),
														new CodePropertyReferenceExpression(
															new CodePropertyReferenceExpression(
																new CodeThisReferenceExpression(),
																property.Name),
															HasbeenSetPropertyName()))
												}
												: new CodeStatement[]
												{
													// property=value
													new CodeAssignStatement(
														new CodeFieldReferenceExpression(
															new CodeThisReferenceExpression(),
															propertyField.Name),
														new CodePropertySetValueReferenceExpression()),
													// specified=true
													new CodeAssignStatement(
														new CodeFieldReferenceExpression(
															new CodeThisReferenceExpression(),
															propertySpecifiedPropertyField.Name),
														new CodePrimitiveExpression(true))
												});
											property.SetStatements.Insert(0, new CodeCommentStatement($"{bXSD} - prevent {(IsArray(property.Type) ? "array" : "class")} from being null"));
											property.SetStatements.Insert(1, cs);
											property.SetStatements.Insert(2, new CodeCommentStatement($"{eXSD}"));

										}
										#endregion

										#region property GET management
										// "get" property part
										if (property.HasGet)
										{
										}
										#endregion
									}
									#endregion

									#region property array accessors
									// if array then create accessors if requested
									//if (CanConvertArray(parameters, property.Type, property) && settings.CreateArrayAccessors)
									if (IsArray(property.Type) &&
										//settings.CreateArrayAccessors &&
										(null == parameters.ArrayTypesWithoutAccessors ||
											(null != parameters.ArrayTypesWithoutAccessors && !parameters.ArrayTypesWithoutAccessors.Contains(property.Type.BaseType))))
									{
										#region length
										// getLength method
										string addenda = lengthMethod;
										cmm = new CodeMemberMethod();
										cmm.Attributes = MemberAttributes.Public | MemberAttributes.Final;
										cmm.Name = property.Name + addenda;
										cmm.ReturnType = new CodeTypeReference(typeof(int));
										ccs = new CodeConditionStatement(
											// itemlist==null
											new CodeBinaryOperatorExpression(
												new CodeFieldReferenceExpression(
													new CodeThisReferenceExpression(),
													propertyField.Name),
												CodeBinaryOperatorType.ValueEquality,
												new CodeDefaultValueExpression(property.Type)
												),
											// return 0
											new CodeStatement[]
											{
												new CodeMethodReturnStatement(
													new CodePrimitiveExpression(0))
											},
											new CodeStatement[]
											{
												// return itemlist.Length
												new CodeMethodReturnStatement(
													new CodePropertyReferenceExpression(
														new CodeFieldReferenceExpression(
															new CodeThisReferenceExpression(),
															propertyField.Name),
														isLength))
											});
										cmm.Statements.Add(new CodeCommentStatement($"{bXSD} - array {addenda} accessor"));
										cmm.Statements.Add(ccs);
										cmm.Statements.Add(new CodeCommentStatement($"{eXSD}"));
										addedMembers.Add(cmm);
										#endregion

										#region get item
										// getItem method
										addenda = getItemMethod;
										cmm = new CodeMemberMethod();
										cmm.Attributes = MemberAttributes.Public | MemberAttributes.Final;
										cmm.Name = property.Name + addenda;
										cmm.ReturnType = new CodeTypeReference(property.Type.BaseType);
										CodeParameterDeclarationExpression cpde = new CodeParameterDeclarationExpression(
											new CodeTypeReference(typeof(int)), isIndex);
										cmm.Parameters.Add(cpde);
										CodeTryCatchFinallyStatement ctcf =
											new CodeTryCatchFinallyStatement(
												new CodeStatement[]
												{
													new CodeConditionStatement(
														// itemlist==null
														new CodeBinaryOperatorExpression(
															new CodeFieldReferenceExpression(
																new CodeThisReferenceExpression(),
																propertyField.Name),
															CodeBinaryOperatorType.ValueEquality,
															new CodeDefaultValueExpression(property.Type)),
														// then return null
														new CodeStatement[]
														{
															new CodeMethodReturnStatement(
																new CodeDefaultValueExpression(cmm.ReturnType)),
														},
														// else
														new CodeStatement[]
														{
															new CodeConditionStatement(
																// 0 > index
																new CodeBinaryOperatorExpression(
																	new CodePrimitiveExpression(0),
																	CodeBinaryOperatorType.GreaterThan,
																	new CodeArgumentReferenceExpression(isIndex)),
																// then return null
																new CodeStatement[]
																{
																	new CodeMethodReturnStatement(
																		new CodeDefaultValueExpression(cmm.ReturnType)),
																},
																// else
																new CodeStatement[]
																{
																	new CodeConditionStatement(
																		// itemlist.length <= index
																		new CodeBinaryOperatorExpression(
																			new CodePropertyReferenceExpression(
																				new CodeFieldReferenceExpression(
																					new CodeThisReferenceExpression(),
																					propertyField.Name),
																				isLength),
																			CodeBinaryOperatorType.LessThanOrEqual,
																			new CodeArgumentReferenceExpression(isIndex)),
																		// then return null
																		new CodeStatement[]
																		{
																			new CodeMethodReturnStatement(
																				new CodeDefaultValueExpression(cmm.ReturnType)),
																		},
																		// else
																		new CodeStatement[]
																		{
																			new CodeMethodReturnStatement(
																				new CodeArrayIndexerExpression(
																					new CodeFieldReferenceExpression(
																						new CodeThisReferenceExpression(),
																						propertyField.Name),
																					new CodeArgumentReferenceExpression(isIndex)))
																		})
																})
														}),
												},
												new CodeCatchClause[]
												{
													new CodeCatchClause(
														isEx,
														new CodeTypeReference(typeof(Exception)),
														new CodeMethodReturnStatement(
															new CodeDefaultValueExpression(cmm.ReturnType)))
												});
										cmm.Statements.Add(new CodeCommentStatement($"{bXSD} - array {addenda} accessor"));
										cmm.Statements.Add(ctcf);
										cmm.Statements.Add(new CodeCommentStatement($"{eXSD}"));
										addedMembers.Add(cmm);
										#endregion

										#region set item
										// setItem method
										addenda = setItemMethod;
										cmm = new CodeMemberMethod();
										cmm.Attributes = MemberAttributes.Public | MemberAttributes.Final;
										cmm.Name = property.Name + addenda;
										cmm.ReturnType = new CodeTypeReference(typeof(bool));
										cpde = new CodeParameterDeclarationExpression(
											new CodeTypeReference(typeof(int)), isIndex);
										cmm.Parameters.Add(cpde);
										cpde = new CodeParameterDeclarationExpression(
											new CodeTypeReference(property.Type.BaseType), isValue);
										cmm.Parameters.Add(cpde);
										ctcf = new CodeTryCatchFinallyStatement(
											new CodeStatement[]
											{
												new CodeConditionStatement(
													// itemlist==null
													new CodeBinaryOperatorExpression(
														new CodeFieldReferenceExpression(
															new CodeThisReferenceExpression(),
															propertyField.Name),
														CodeBinaryOperatorType.ValueEquality,
														new CodeDefaultValueExpression(property.Type)),
													// then return null
													new CodeStatement[]
													{
														new CodeMethodReturnStatement(
															new CodePrimitiveExpression(false)),
													},
													// else
													new CodeStatement[]
													{
													new CodeConditionStatement(
														// 0 > index
														new CodeBinaryOperatorExpression(
															new CodePrimitiveExpression(0),
															CodeBinaryOperatorType.GreaterThan,
															new CodeArgumentReferenceExpression(isIndex)),
														// then return null
														new CodeStatement[]
														{
															new CodeMethodReturnStatement(
																new CodePrimitiveExpression(false)),
														},
														// else
														new CodeStatement[]
														{
															new CodeConditionStatement(
																// itemlist.length <= index
																new CodeBinaryOperatorExpression(
																	new CodePropertyReferenceExpression(
																		new CodeFieldReferenceExpression(
																			new CodeThisReferenceExpression(),
																			propertyField.Name),
																		isLength),
																	CodeBinaryOperatorType.LessThanOrEqual,
																	new CodeArgumentReferenceExpression(isIndex)),
																// then return null
																new CodeStatement[]
																{
																	new CodeMethodReturnStatement(
																		new CodePrimitiveExpression(false))
																},
																// else
																new CodeStatement[]
																{
																	new CodeAssignStatement(
																		new CodeArrayIndexerExpression(
																			new CodeFieldReferenceExpression(
																				new CodeThisReferenceExpression(),
																				propertyField.Name),
																			new CodeArgumentReferenceExpression(isIndex)),
																		new CodeArgumentReferenceExpression(isValue)),
																	new CodeMethodReturnStatement(
																		new CodePrimitiveExpression(true))
																}),
														})
													})
											},
											new CodeCatchClause[]
											{
												new CodeCatchClause(
													isEx,
													new CodeTypeReference(typeof(Exception)),
													new CodeMethodReturnStatement(
														new CodePrimitiveExpression(false)))
											});
										cmm.Statements.Add(new CodeCommentStatement($"{bXSD} - array {addenda} accessor"));
										cmm.Statements.Add(ctcf);
										cmm.Statements.Add(new CodeCommentStatement($"{eXSD}"));
										addedMembers.Add(cmm);
										#endregion

										#region add item
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
											{
												new CodeConditionStatement(
													// itemlist==null
													new CodeBinaryOperatorExpression(
														new CodeFieldReferenceExpression(
															new CodeThisReferenceExpression(),
															propertyField.Name),
														CodeBinaryOperatorType.ValueEquality,
														new CodeDefaultValueExpression(property.Type)),
													// then return null
													new CodeStatement[]
													{
														new CodeMethodReturnStatement(
															new CodePrimitiveExpression(false))
													},
													// else
													new CodeStatement[]
													{
														// declare a new array of the same type + 1 item
														new CodeVariableDeclarationStatement(
															//new CodeTypeReference(m.Type.BaseType),
															property.Type,
															isArray,
															new CodeArrayCreateExpression(
																new CodeTypeReference(property.Type.BaseType),
																new CodeBinaryOperatorExpression(
																	new CodePropertyReferenceExpression(
																		new CodeFieldReferenceExpression(
																			new CodeThisReferenceExpression(),
																			propertyField.Name),
																		isLength),
																	CodeBinaryOperatorType.Add,
																	new CodePrimitiveExpression(1)))),
														// declare the counter
														new CodeVariableDeclarationStatement(
															typeof(int),
															isCounterI,
															new CodePrimitiveExpression(0)),
														// for loop to copy old items inside the new array
														new CodeIterationStatement(
															// initializer
															new CodeAssignStatement(
																new CodeVariableReferenceExpression(isCounterI),
																new CodePrimitiveExpression(0)),
															// test
															new CodeBinaryOperatorExpression(
																new CodeVariableReferenceExpression(isCounterI),
																CodeBinaryOperatorType.LessThan,
																new CodePropertyReferenceExpression(
																	new CodeFieldReferenceExpression(
																		new CodeThisReferenceExpression(),
																		propertyField.Name),
																	isLength)),
															// update counter
															new CodeAssignStatement(
																new CodeVariableReferenceExpression(isCounterI),
																new CodeBinaryOperatorExpression(
																	new CodeVariableReferenceExpression(isCounterI),
																	CodeBinaryOperatorType.Add,
																	new CodePrimitiveExpression(1))),
															new CodeStatement[]
															{
																// assign existing values to the new array
																new CodeAssignStatement(
																	new CodeArrayIndexerExpression(
																		new CodeArgumentReferenceExpression(isArray),
																		new CodeArgumentReferenceExpression(isCounterI)),
																	new CodeArrayIndexerExpression(
																		new CodeArgumentReferenceExpression(propertyField.Name),
																		new CodeArgumentReferenceExpression(isCounterI)))
															}),
														// copy new value to the new array
														new CodeAssignStatement(
															new CodeArrayIndexerExpression(
																new CodeArgumentReferenceExpression(isArray),
																new CodeArgumentReferenceExpression(isCounterI)),
															new CodeArgumentReferenceExpression(isValue)),
														// replace existing array by new array
														new CodeAssignStatement(
															new CodeFieldReferenceExpression(
																new CodeThisReferenceExpression(),
																property.Name),
															new CodeArgumentReferenceExpression(isArray)),
														// return true
														new CodeMethodReturnStatement(
															new CodePrimitiveExpression(true))
													})
											},
										// catch statement
										new CodeCatchClause[]
										{
											new CodeCatchClause(
												isEx,
												new CodeTypeReference(typeof(Exception)),
												new CodeMethodReturnStatement(
													new CodePrimitiveExpression(false)))
										});
										cmm.Statements.Add(new CodeCommentStatement($"{bXSD} - array {addenda} accessor"));
										cmm.Statements.Add(ctcf);
										cmm.Statements.Add(new CodeCommentStatement($"{eXSD}"));
										addedMembers.Add(cmm);
										#endregion

										#region remove item
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
											new CodeStatement[]
											{
												new CodeConditionStatement(
													// itemlist==null
													new CodeBinaryOperatorExpression(
														new CodeFieldReferenceExpression(
															new CodeThisReferenceExpression(),
															propertyField.Name),
														CodeBinaryOperatorType.ValueEquality,
														new CodeDefaultValueExpression(property.Type)
														),
													// then return null
													new CodeStatement[]
													{
														new CodeMethodReturnStatement(
															new CodePrimitiveExpression(false)),
													},
													// else
													new CodeStatement[]
													{
														new CodeConditionStatement(
															// 0 > index
															new CodeBinaryOperatorExpression(
																new CodePrimitiveExpression(0),
																CodeBinaryOperatorType.GreaterThan,
																new CodeArgumentReferenceExpression(isIndex)),
															// then return null
															new CodeStatement[]
															{
																new CodeMethodReturnStatement(
																	new CodePrimitiveExpression(false)),
															},
															// else
															new CodeStatement[]
															{
																new CodeConditionStatement(
																	// itemlist.length <= index
																	new CodeBinaryOperatorExpression(
																		new CodePropertyReferenceExpression(
																			new CodeFieldReferenceExpression(
																				new CodeThisReferenceExpression(),
																				propertyField.Name),
																			isLength),
																		CodeBinaryOperatorType.LessThanOrEqual,
																		new CodeArgumentReferenceExpression(isIndex)),
																	// then return null
																	new CodeStatement[]
																	{
																		new CodeMethodReturnStatement(
																			new CodePrimitiveExpression(false)),
																	},
																	// else
																	new CodeStatement[]
																	{
																		// declare a new array of the same type - 1 item
																		new CodeVariableDeclarationStatement(
																			//new CodeTypeReference(m.Type.BaseType),
																			property.Type,
																			isArray,
																			new CodeArrayCreateExpression(
																				new CodeTypeReference(property.Type.BaseType),
																				new CodeBinaryOperatorExpression(
																					new CodePropertyReferenceExpression(
																						new CodeFieldReferenceExpression(
																							new CodeThisReferenceExpression(),
																							propertyField.Name),
																						isLength),
																					CodeBinaryOperatorType.Subtract,
																					new CodePrimitiveExpression(1)))),
																		// declare the counter
																		new CodeVariableDeclarationStatement(
																			typeof(int),
																			isCounterI,
																			new CodePrimitiveExpression(0)),
																		// for loop to copy old items below requested index inside the new array
																		new CodeIterationStatement(
																			// initializer
																			new CodeAssignStatement(
																				new CodeVariableReferenceExpression(isCounterI),
																				new CodePrimitiveExpression(0)),
																			// test
																			new CodeBinaryOperatorExpression(
																				new CodeVariableReferenceExpression(isCounterI),
																				CodeBinaryOperatorType.LessThan,
																				new CodeVariableReferenceExpression(isIndex)),
																			// update counter
																			new CodeAssignStatement(
																				new CodeVariableReferenceExpression(isCounterI),
																				new CodeBinaryOperatorExpression(
																					new CodeVariableReferenceExpression(isCounterI),
																					CodeBinaryOperatorType.Add,
																					new CodePrimitiveExpression(1))),
																			new CodeStatement[]
																			{ 
																				// assign existing values to the new array
																				new CodeAssignStatement(
																					new CodeArrayIndexerExpression(
																						new CodeArgumentReferenceExpression(isArray),
																						new CodeArgumentReferenceExpression(isCounterI)),
																					new CodeArrayIndexerExpression(
																						new CodeArgumentReferenceExpression(propertyField.Name),
																						new CodeArgumentReferenceExpression(isCounterI)))
																			}),
																		// for loop to copy old items above requested index inside the new array
																		new CodeIterationStatement(
																			// initializer
																			new CodeAssignStatement(
																				new CodeVariableReferenceExpression(isCounterI),
																				new CodeBinaryOperatorExpression(
																					new CodeVariableReferenceExpression(isCounterI),
																					CodeBinaryOperatorType.Add,
																					new CodePrimitiveExpression(1))),
																			// test
																			new CodeBinaryOperatorExpression(
																				new CodeVariableReferenceExpression(isCounterI),
																				CodeBinaryOperatorType.LessThan,
																				new CodePropertyReferenceExpression(
																					new CodeFieldReferenceExpression(
																						new CodeThisReferenceExpression(),
																						propertyField.Name),
																					isLength)),																
																			// update counter
																			new CodeAssignStatement(
																				new CodeVariableReferenceExpression(isCounterI),
																				new CodeBinaryOperatorExpression(
																					new CodeVariableReferenceExpression(isCounterI),
																					CodeBinaryOperatorType.Add,
																					new CodePrimitiveExpression(1))),
																			new CodeStatement[]
																			{
																				// assign existing values to the new array
																				new CodeAssignStatement(
																					new CodeArrayIndexerExpression(
																						new CodeArgumentReferenceExpression(isArray),
																						new CodeArgumentReferenceExpression(isCounterI)),
																					new CodeArrayIndexerExpression(
																						new CodeArgumentReferenceExpression(propertyField.Name),
																						new CodeArgumentReferenceExpression(isCounterI))),
																			}),
																		// replace existing array by new array
																		new CodeAssignStatement(
																			new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), property.Name),
																			new CodeArgumentReferenceExpression(isArray)),
																		// return true
																		new CodeMethodReturnStatement(new CodePrimitiveExpression(true))
																	})
															})
													})
											},
											// catch statement
											new CodeCatchClause[] {
												new CodeCatchClause(
													isEx,
													new CodeTypeReference(typeof(Exception)),
													new CodeStatement[] {
														new CodeMethodReturnStatement(
															new CodePrimitiveExpression(false))
													})
											});
										cmm.Statements.Add(new CodeCommentStatement($"{bXSD} - array {addenda} accessor"));
										cmm.Statements.Add(ctcf);
										cmm.Statements.Add(new CodeCommentStatement($"{eXSD}"));
										addedMembers.Add(cmm);
										#endregion

										#region insert item
										// insert Item method 
										addenda = insertItemMethod;
										cmm = new CodeMemberMethod();
										cmm.Attributes = MemberAttributes.Public | MemberAttributes.Final;
										cmm.Name = property.Name + addenda;
										cmm.ReturnType = new CodeTypeReference(typeof(int));
										cpde = new CodeParameterDeclarationExpression(
											new CodeTypeReference(typeof(int)), isIndex);
										cmm.Parameters.Add(cpde);
										cpde = new CodeParameterDeclarationExpression(
											new CodeTypeReference(property.Type.BaseType), isValue);
										cmm.Parameters.Add(cpde);
										ctcf = new CodeTryCatchFinallyStatement(
											new CodeStatement[]
											{
											new CodeConditionStatement(
												// itemlist==null
												new CodeBinaryOperatorExpression(
													new CodeFieldReferenceExpression(
														new CodeThisReferenceExpression(),
														propertyField.Name),
													CodeBinaryOperatorType.ValueEquality,
													new CodeDefaultValueExpression(property.Type)),
												// then return -1
												new CodeStatement[]
												{
													new CodeMethodReturnStatement(
														new CodePrimitiveExpression(-1))
												},
												new CodeStatement[]
												{
													// if index over Length
													new CodeConditionStatement(
														new CodeBinaryOperatorExpression(
															new CodePropertyReferenceExpression(
																new CodeFieldReferenceExpression(
																	new CodeThisReferenceExpression(),
																	propertyField.Name),
																isLength),
																CodeBinaryOperatorType.LessThanOrEqual,
																new CodeArgumentReferenceExpression(isIndex)),
														// then call the addItem method
														new CodeStatement[]
														{
															new CodeConditionStatement(
																new CodeBinaryOperatorExpression(
																	new CodeMethodInvokeExpression(
																		new CodeMethodReferenceExpression(
																			new CodeThisReferenceExpression(),
																			property.Name + addItemMethod),
																		new CodeArgumentReferenceExpression(isValue)),
																	CodeBinaryOperatorType.ValueEquality,
																	new CodePrimitiveExpression(true)),
																// then return length
																new CodeStatement[]
																{
																new CodeMethodReturnStatement(
																	new CodeMethodInvokeExpression(
																			new CodeMethodReferenceExpression(
																				new CodeThisReferenceExpression(),
																				property.Name + lengthMethod)))
																},
																// else return -1
																new CodeStatement[]
																{
																	new CodeMethodReturnStatement(
																		new CodePrimitiveExpression(-1))
																})
														},
														// else
														new CodeStatement[]
														{
															// if index < 0
															new CodeConditionStatement(
																new CodeBinaryOperatorExpression(
																	new CodeArgumentReferenceExpression(isIndex),
																	CodeBinaryOperatorType.LessThan,
																	new CodePrimitiveExpression(0)),
																new CodeStatement[]
																{
																	new CodeAssignStatement(
																		new CodeArgumentReferenceExpression(isIndex),
																		new CodePrimitiveExpression(0)),
																},
																new CodeStatement[] { }),
															// declare a new array of the same type
															new CodeVariableDeclarationStatement(
																property.Type,
																isArray,
																new CodeArrayCreateExpression(
																	new CodeTypeReference(property.Type.BaseType),
																	new CodeBinaryOperatorExpression(
																		new CodePropertyReferenceExpression(
																			new CodeFieldReferenceExpression(
																				new CodeThisReferenceExpression(),
																				propertyField.Name),
																			isLength),
																		CodeBinaryOperatorType.Add,
																		new CodePrimitiveExpression(1)))),
															// declare the counter
															new CodeVariableDeclarationStatement(
																typeof(int),
																isCounterI,
																new CodePrimitiveExpression(0)),
															// for loop to copy old items below requested index inside the new array
															new CodeIterationStatement(
																// initializer
																new CodeAssignStatement(
																	new CodeVariableReferenceExpression(isCounterI),
																	new CodePrimitiveExpression(0)),
																// test
																new CodeBinaryOperatorExpression(
																	new CodeVariableReferenceExpression(isCounterI),
																	CodeBinaryOperatorType.LessThan,
																	new CodeArgumentReferenceExpression(isIndex)),
																// update counter
																new CodeAssignStatement(
																	new CodeVariableReferenceExpression(isCounterI),
																	new CodeBinaryOperatorExpression(
																		new CodeVariableReferenceExpression(isCounterI),
																		CodeBinaryOperatorType.Add,
																		new CodePrimitiveExpression(1))),
																new CodeStatement[]
																{ 
																	// assign existing values to the new array
																	new CodeAssignStatement(
																		new CodeArrayIndexerExpression(
																			new CodeVariableReferenceExpression(isArray),
																			new CodeVariableReferenceExpression(isCounterI)),
																		new CodeArrayIndexerExpression(
																			new CodeArgumentReferenceExpression(propertyField.Name),
																			new CodeArgumentReferenceExpression(isCounterI)))
																}),
															// insert new item
															new CodeAssignStatement(
																new CodeArrayIndexerExpression(
																	new CodeVariableReferenceExpression(isArray),
																	new CodeArgumentReferenceExpression(isIndex)),
																new CodeArgumentReferenceExpression(isValue)),
															// declare J counter
															new CodeVariableDeclarationStatement(
																typeof(int),
																isCounterJ,
																new CodePrimitiveExpression(0)),
															// declare K counter
															new CodeVariableDeclarationStatement(
																typeof(int),
																isCounterK,
																new CodeBinaryOperatorExpression(
																	new CodeArgumentReferenceExpression(isIndex),
																	CodeBinaryOperatorType.Add,
																	new CodePrimitiveExpression(1))),
															// for loop to copy old items above requested index inside the new array
															new CodeIterationStatement(
																// initializer
																new CodeAssignStatement(
																	new CodeVariableReferenceExpression(isCounterJ),
																	new CodeVariableReferenceExpression(isCounterI)),
																// test
																new CodeBinaryOperatorExpression(
																	new CodeVariableReferenceExpression(isCounterJ),
																	CodeBinaryOperatorType.LessThan,
																	new CodePropertyReferenceExpression(
																		new CodeFieldReferenceExpression(
																			new CodeThisReferenceExpression(),
																			propertyField.Name),
																		isLength)),
																// update counter
																new CodeAssignStatement(
																	new CodeVariableReferenceExpression(isCounterJ),
																	new CodeBinaryOperatorExpression(
																		new CodeVariableReferenceExpression(isCounterJ),
																		CodeBinaryOperatorType.Add,
																		new CodePrimitiveExpression(1))),
																new CodeStatement[]
																{ 
																	// assign existing values to the new array
																	new CodeAssignStatement(
																		new CodeArrayIndexerExpression(
																			new CodeArgumentReferenceExpression(isArray),
																			new CodeArgumentReferenceExpression(isCounterK)),
																		new CodeArrayIndexerExpression(
																			new CodeArgumentReferenceExpression(propertyField.Name),
																			new CodeArgumentReferenceExpression(isCounterJ))),
																	new CodeAssignStatement(
																		new CodeArgumentReferenceExpression(isCounterK),
																		new CodeBinaryOperatorExpression(
																			new CodeVariableReferenceExpression(isCounterK),
																			CodeBinaryOperatorType.Add,
																			new CodePrimitiveExpression(1))),
																}),
															// replace existing array by new array
															new CodeAssignStatement(
																new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), property.Name),
																new CodeArgumentReferenceExpression(isArray)),
															// return true
															new CodeMethodReturnStatement(
																new CodeVariableReferenceExpression(isIndex))
														})
												})
											},
											// catch statement
											new CodeCatchClause[] {
												new CodeCatchClause(
													isEx,
													new CodeTypeReference(typeof(Exception)),
													new CodeStatement[] {
														new CodeMethodReturnStatement(
															new CodePrimitiveExpression(-1))
													})
											});
										cmm.Statements.Add(new CodeCommentStatement($"{bXSD} - array {addenda} accessor"));
										cmm.Statements.Add(ctcf);
										cmm.Statements.Add(new CodeCommentStatement($"{eXSD}"));
										addedMembers.Add(cmm);
										#endregion

									}
									#endregion
								}
							}
							#endregion

							#region insert or delete statements or members
							// add all...hasBeenSet fields
							foreach (CodeMemberField cmfx in hasBeenSetFields)
							{
								codeType.Members.Add(cmfx);
							}

							// update the collection of new members to the already existing ones inside this type
							// they are new methods for instance
							if (0 != deletedMembers.Count)
							{
								foreach (CodeTypeMember ctmx in deletedMembers)
									codeType.Members.Remove(ctmx);
							}

							// update the collection of new members to the already existing ones inside this type
							// they are new methods for instance
							if (0 != addedMembers.Count)
							{
								codeType.Members.AddRange(addedMembers);
							}
							#endregion

							#region has_been_modified management
							//*****
							// HASBEENSET property processing
							// "GET" statements
							AddComment(hasBeenSetProperty, b, true);
							CodeExpression expression = new CodePrimitiveExpression(false);
							foreach (CodeMemberProperty xcmp in namespaceTypesToProcessInHasBeenSet)
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
											new CodeDefaultValueExpression(xcmp.Type)),
										CodeBinaryOperatorType.BooleanAnd,
										new CodeFieldReferenceExpression(
											new CodeThisReferenceExpression(),
											xcmp.Name + NexoXSDStrings.Specified)));
							}
							// add size of array element
							foreach (CodeMemberProperty xcmp in arraysToProcessInHadBeenSet)
							{
								expression = new CodeBinaryOperatorExpression(
									expression,
									CodeBinaryOperatorType.BooleanOr,
									new CodeBinaryOperatorExpression(
										new CodeMethodInvokeExpression(
											new CodeMethodReferenceExpression(
												new CodeThisReferenceExpression(),
												xcmp.Name + lengthMethod),
											new CodeExpression[] { }),
										CodeBinaryOperatorType.IdentityInequality,
										new CodePrimitiveExpression(0)));
							}
							// add HASBEENSET flag of primitive data
							//foreach (CodeMemberField xcmp in hasBeenSetFields)
							//{
							//	expression = new CodeBinaryOperatorExpression(
							//			expression,
							//			CodeBinaryOperatorType.BooleanOr,
							//			new CodeFieldReferenceExpression(
							//				new CodeThisReferenceExpression(),
							//				xcmp.Name));
							//}
							foreach (CodeMemberProperty xcmp in primitivesToProcessInHadBeenSet)
							{
								//expression = new CodeBinaryOperatorExpression(
								//		expression,
								//		CodeBinaryOperatorType.BooleanOr,
								//		new CodeBinaryOperatorExpression(
								//		new CodePropertyReferenceExpression(
								//			new CodeThisReferenceExpression(),
								//			xcmp.Name),
								//		CodeBinaryOperatorType.IdentityInequality,
								//		new CodeDefaultValueExpression(xcmp.Type)));
								expression = new CodeBinaryOperatorExpression(
									expression,
									CodeBinaryOperatorType.BooleanOr,
									new CodeBinaryOperatorExpression(
										new CodeBinaryOperatorExpression(
											new CodePropertyReferenceExpression(
												new CodeThisReferenceExpression(),
												xcmp.Name),
											CodeBinaryOperatorType.IdentityInequality,
											new CodeDefaultValueExpression(xcmp.Type)),
										CodeBinaryOperatorType.BooleanAnd,
										new CodePropertyReferenceExpression(
											new CodeThisReferenceExpression(),
											xcmp.Name + NexoXSDStrings.Specified)));
							}
							//// add ...Specified flag of primitive data without null ability
							//foreach (CodeMemberProperty xcmp in optionalsToProcessInHadBeenSet)
							//{
							//	expression = new CodeBinaryOperatorExpression(
							//		expression,
							//		CodeBinaryOperatorType.BooleanOr,
							//		new CodePropertyReferenceExpression(
							//			new CodeThisReferenceExpression(),
							//			xcmp.Name));
							//}
							hasBeenSetProperty.GetStatements.Add(new CodeMethodReturnStatement(expression));
							AddComment(hasBeenSetProperty, e, true);

							//// "SET" statements
							//AddSetStatementFromValue(hasBeenSetProperty, null, b, e);
							codeType.Members.Add(hasBeenSetProperty);
							#endregion

							#region optimizing management
							List<CodeStatement> statements = new List<CodeStatement>();
							if (settings.UseOptimizingFlag)
							{
								//*****
								// OPTIMIZING property processing
								// "GET" add set optimizing flag to all
								AddGetStatementFromField(optimizingProperty, optimizingField, b, e);
								AddSetStatementFromValue(optimizingProperty, optimizingField, b, e);
								AddComment(optimizingProperty, b, false);
								statements.Clear();
								// process all user defined types to indicate OPTIMIZING is in progress
								foreach (CodeMemberProperty xcmp in namespaceTypesToProcessInHasBeenSet)
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
								foreach (CodeMemberProperty xcmp in arraysToProcessInHadBeenSet)
								{
									if (!IsPrimitiveType(xcmp.Type))
									{
										if (!counterIsDeclared)
										{
											// declare a counter
											statements.Add(new CodeVariableDeclarationStatement(
												typeof(int),
												isCounterI,
												new CodePrimitiveExpression(0)));
											counterIsDeclared = true;
										}
										// for loop to copy old items inside the new array
										statements.Add(new CodeIterationStatement(
											// initializer
											new CodeAssignStatement(
												new CodeVariableReferenceExpression(isCounterI),
												new CodePrimitiveExpression(0)),
											// test
											new CodeBinaryOperatorExpression(
												new CodeVariableReferenceExpression(isCounterI),
												CodeBinaryOperatorType.LessThan,
												new CodeMethodInvokeExpression(
													new CodeMethodReferenceExpression(
														new CodeThisReferenceExpression(),
														xcmp.Name + lengthMethod))),
											// iteration
											new CodeAssignStatement(
												new CodeVariableReferenceExpression(isCounterI),
												new CodeBinaryOperatorExpression(
													new CodeVariableReferenceExpression(isCounterI),
													CodeBinaryOperatorType.Add,
													new CodePrimitiveExpression(1))),
											// set a value of any user defined record
											new CodeAssignStatement(
												new CodePropertyReferenceExpression(
													new CodeArrayIndexerExpression(
														new CodePropertyReferenceExpression(
															new CodeThisReferenceExpression(),
															xcmp.Name),
														new CodeArgumentReferenceExpression(isCounterI)),
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
							}
							#endregion

							#region class name management
							//*****
							// class name property
							// "GET" statements
							AddComment(className, b, true);
							className.GetStatements.Add(new CodeMethodReturnStatement(new CodePrimitiveExpression(codeType.Name)));
							AddComment(className, e, true);
							codeType.Members.Add(className);
							#endregion

							#region finalize members to use
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
								counter = 1;
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
								catch (Exception ex)
								{
									settings.Exception = ex.Message;
								}
							}
							#endregion

							#region alternate constructor
							CodeConstructor defaultConstructorFromObject = GetDefaultClassConstructorFromObject(codeType, new CodeTypeReference(codeType.Name));
							if (null == defaultConstructorFromObject)
							{
								defaultConstructorFromObject = new CodeConstructor();
								defaultConstructorFromObject.Attributes = MemberAttributes.Public | MemberAttributes.Final;
								defaultConstructorFromObject.Parameters.Add(new CodeParameterDeclarationExpression(new CodeTypeReference(codeType.Name), isValue));
								codeType.Members.Add(defaultConstructorFromObject);
							}

							//// create a basic constructor
							//CodeConstructor constructor = new CodeConstructor();
							//constructor = new CodeConstructor() { Attributes = MemberAttributes.Public | MemberAttributes.Final };
							//// search for a pre-existing default constructor
							//bool constructorIsPresent = false;
							//for (i = 0, constructorIsPresent = false; i < codeType.Members.Count && !constructorIsPresent; i++)
							//{
							//	constructorIsPresent = codeType.Members[i] is CodeConstructor
							//		&& ((CodeConstructor)codeType.Members[i]).Parameters.Count == 0;
							//}
							//// is there already a basic constructor member
							//if (!constructorIsPresent)
							//{
							//	constructor.Statements.AddRange(new CodeStatement[] { });
							//	codeType.Members.Add(constructor);
							//	//// there's one, replace all default assignments with using default value
							//	//codeType.Members.RemoveAt(i);
							//}

							//// specific constructor to copy an object to another one
							//constructor = new CodeConstructor();
							//constructor.Attributes = MemberAttributes.Public | MemberAttributes.Final;
							//// Add parameter of the same type to the constructor
							//constructor.Parameters.Add(
							//	new CodeParameterDeclarationExpression(
							//		new CodeTypeReference(
							//			codeType.Name),
							//		isValue));
							// add all members assignment
							List<CodeStatement> lcs = new List<CodeStatement>();
							Func<CodeTypeMember, int> AddAssignment = (CodeTypeMember mbr) =>
							{
								cas = new CodeAssignStatement(
								  new CodePropertyReferenceExpression(
									  new CodeThisReferenceExpression(),
									  mbr.Name),
								  new CodePropertyReferenceExpression(
									  new CodeArgumentReferenceExpression(isValue),
									  mbr.Name));
								lcs.Add(cas);
								return lcs.Count;
							};
							foreach (CodeTypeMember mbr in codeType.Members)
							{
								if (mbr is CodeMemberProperty &&
									(((mbr.Attributes & MemberAttributes.AccessMask) == MemberAttributes.Public) ||
									((mbr.Attributes & MemberAttributes.AccessMask) == MemberAttributes.Assembly)) &&
									((CodeMemberProperty)mbr).HasSet)
									AddAssignment(mbr);
							}
							// create the constructor with all required assignments
							css = new CodeStatement[]
							{
								new CodeConditionStatement(
									new CodeBinaryOperatorExpression(
										new CodeArgumentReferenceExpression(isValue),
										CodeBinaryOperatorType.ValueEquality,
										new CodeDefaultValueExpression(
											new CodeTypeReference(codeType.Name))),
									//then
									new CodeStatement[] { },
									// else
									lcs.ToArray())
							};
							// add the constructor to the object declaration
							defaultConstructorFromObject.Statements.Add(new CodeCommentStatement($"{bXSD} - copy constructor"));
							defaultConstructorFromObject.Statements.AddRange(css);
							defaultConstructorFromObject.Statements.Add(new CodeCommentStatement($"{eXSD} - copy constructor"));
							//codeType.Members.Add(defaultConstructorFromObject);
							#endregion
						}

						#region interface management
						// an interface that can be used outside the namespace
						else if (visible && codeType.IsInterface)
						{
							msg.Header = $"{msg.Header} - Interface {codeType.Name}";

							// if the interface must be visible on COM indicate how it will be visible
							if (settings.MakeClassComVisible)
							{
								AddGuid(codeType.CustomAttributes);
								AddInterfaceType(codeType.CustomAttributes);
							}
							// make it COM visible
							AddComVisible(codeType.CustomAttributes, settings.MakeClassComVisible);
						}
						#endregion

						#region enum management
						// an enum that can be used outside the namespace
						else if (visible && codeType.IsEnum)
						{
							msg.Header = $"{msg.Header} - Enum {codeType.Name}";

							// make it COM visible
							AddComVisible(codeType.CustomAttributes, settings.MakeEnumComVisible);

							// if generic attributes _begin, _none and _end are to be added
							if (settings.AddDefaultAttributesToEnum)
							{
								// _none
								CodeMemberField cm = new CodeMemberField("System.Int32", NexoXSDStrings.EnumNone);
								cm.InitExpression = new CodePrimitiveExpression(settings.UseEnumBeginEnd ? -2 : -1);
								codeType.Members.Insert(0, cm);
								if (settings.UseEnumBeginEnd)
								{
									// _begin
									cm = new CodeMemberField("System.Int32", NexoXSDStrings.EnumBegin);
									cm.InitExpression = new CodePrimitiveExpression(-1);
									codeType.Members.Insert(1, new CodeMemberField("System.Int32", NexoXSDStrings.EnumBegin));
									// _end
									codeType.Members.Add(new CodeMemberField("System.Int32", NexoXSDStrings.EnumEnd));
								}
							}
						}
						#endregion
					}
					catch (Exception ex)
					{
						settings.Exception = ex.Message;
					}
				}

				#region tags management
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
					catch (Exception ex)
					{
						settings.Exception = ex.Message;
					}
				}
				#endregion

				#region namespace management
				// add all specific classes, enums,... to the newly created namespace
				newCodeNamespace = new CodeNamespace(codeNamespace.Name);
				newCodeNamespace.Types.AddRange(thisFileTypes);
				newCodeNamespace.Types.AddRange(newCodeTypeDeclarations.ToArray());

				// add the required imports 
				if (addNewtonSoft)
					newCodeNamespace.Imports.Add(new CodeNamespaceImport("Newtonsoft.Json"));
				if (addSerialization)
					newCodeNamespace.Imports.Add(new CodeNamespaceImport("System.Runtime.Serialization"));
				if (settings.AddDispID && settings.DeclareClassInterface)
					newCodeNamespace.Imports.Add(new CodeNamespaceImport("System.Runtime.InteropServices"));
				#endregion
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
				type.BaseType == typeof(System.Decimal).ToString() ||
				type.BaseType == typeof(System.Int16?).ToString() ||
				type.BaseType == typeof(System.Int32?).ToString() ||
				type.BaseType == typeof(System.Int64?).ToString() ||
				type.BaseType == typeof(System.UInt16?).ToString() ||
				type.BaseType == typeof(System.UInt32?).ToString() ||
				type.BaseType == typeof(System.UInt64?).ToString() ||
				type.BaseType == typeof(System.Double?).ToString() ||
				type.BaseType == typeof(System.Decimal?).ToString()))
			{
				ntype = new CodeTypeReference(typeof(string));
			}
			// replace scalar type by string if replacement requested
			else if (settings.BooleanToString && settings.ConvertTypes &&
				(type.BaseType == typeof(System.Boolean).ToString() ||
				type.BaseType == typeof(System.Boolean?).ToString()))
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
			Type t = Type.GetType(0 == type.TypeArguments.Count ? type.BaseType : type.TypeArguments[0].BaseType);
			if (null != t)
				return 0 == string.Compare(t.FullName, "system.object", true);
			return false;
		}
		private static bool IsStringType(CodeTypeReference type)
		{
			Type t = Type.GetType(0 == type.TypeArguments.Count ? type.BaseType : type.TypeArguments[0].BaseType);
			if (null != t)
				return 0 == string.Compare(t.FullName, "system.string", true);
			return false;
		}
		/// <summary>
		/// primitive types are: not nullable type OR string OR object
		/// </summary>
		/// <param name="type">Type to check</param>
		/// <returns>TRUE if primitive, FALSE otherwise</returns>
		private static bool IsPrimitiveType(CodeTypeReference type)
		{
			Type t = Type.GetType(0 == type.TypeArguments.Count ? type.BaseType : type.TypeArguments[0].BaseType);
			if (null != t)
				return t.IsPrimitive || IsStringType(type) || IsObjectType(type);
			return false;
		}
		/// <summary>
		/// byte, short, int, double,..., bool
		/// </summary>
		/// <param name="type"></param>
		/// <returns></returns>
		private static bool IsIntegralType(CodeTypeReference type)
		{
			Type t = Type.GetType(0 == type.TypeArguments.Count ? type.BaseType : type.TypeArguments[0].BaseType);
			if (null != t)
				return t.IsPrimitive && !IsStringType(type) && !IsObjectType(type);
			return false;
		}
		private static Type GetNullableType(CodeTypeReference type, out Type notNullableType)
		{
			notNullableType = Type.GetType(type.BaseType);
			if (null != notNullableType)
			{
				// Use Nullable.GetUnderlyingType() to remove the Nullable<T> wrapper if type is already nullable.
				notNullableType = Nullable.GetUnderlyingType(notNullableType) ?? notNullableType; // avoid type becoming null
				if (notNullableType.IsValueType)
				{
					return typeof(Nullable<>).MakeGenericType(notNullableType);
				}
			}
			return null;
		}
		private static bool IsNullableType(Type type)
		{
			return Nullable.GetUnderlyingType(type) != null;
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
		{
			//attrs.Add(new CodeAttributeDeclaration(new CodeTypeReference("System.Runtime.InteropServices.GuidAttribute"), new CodeAttributeArgument[] { new CodeAttributeArgument(new CodePrimitiveExpression(Guid.NewGuid().ToString())) })); }
			AddAttribute(attrs, "System.Runtime.InteropServices.GuidAttribute", new CodeAttributeArgument[] { new CodeAttributeArgument(new CodePrimitiveExpression(Guid.NewGuid().ToString())) });
		}
		private static void AddComVisible(CodeAttributeDeclarationCollection attrs, bool visible = true)
		{
			//attrs.Add(new CodeAttributeDeclaration(new CodeTypeReference("System.Runtime.InteropServices.ComVisibleAttribute"), new CodeAttributeArgument[] { new CodeAttributeArgument(new CodePrimitiveExpression(visible)) }));
			AddAttribute(attrs, "System.Runtime.InteropServices.ComVisibleAttribute", new CodeAttributeArgument[] { new CodeAttributeArgument(new CodePrimitiveExpression(visible)) });
		}
		private static void AddClassInterface(CodeAttributeDeclarationCollection attrs, ClassInterfaceType clsif = ClassInterfaceType.None)
		{
			//attrs.Add(new CodeAttributeDeclaration(new CodeTypeReference("System.Runtime.InteropServices.ClassInterface"),
			//new CodeAttributeArgument[] { new CodeAttributeArgument(new CodeFieldReferenceExpression(new CodeTypeReferenceExpression("System.Runtime.InteropServices.ClassInterfaceType"), clsif.ToString())) }));
			AddAttribute(attrs, "System.Runtime.InteropServices.ClassInterface", new CodeAttributeArgument[] { new CodeAttributeArgument(new CodeFieldReferenceExpression(new CodeTypeReferenceExpression("System.Runtime.InteropServices.ClassInterfaceType"), clsif.ToString())) });
		}
		private static void AddInterfaceType(CodeAttributeDeclarationCollection attrs, ComInterfaceType cit = ComInterfaceType.InterfaceIsDual)
		{
			//attrs.Add(new CodeAttributeDeclaration(new CodeTypeReference("System.Runtime.InteropServices.InterfaceTypeAttribute"), new CodeAttributeArgument[] { new CodeAttributeArgument(new CodeFieldReferenceExpression(new CodeTypeReferenceExpression("System.Runtime.InteropServices.ComInterfaceType"), cit.ToString())) }));
			AddAttribute(attrs, "System.Runtime.InteropServices.InterfaceTypeAttribute", new CodeAttributeArgument[] { new CodeAttributeArgument(new CodeFieldReferenceExpression(new CodeTypeReferenceExpression("System.Runtime.InteropServices.ComInterfaceType"), cit.ToString())) });
		}
		private static void AddDispID(CodeAttributeDeclarationCollection attrs, int dispid)
		{
			//attrs.Add(new CodeAttributeDeclaration(new CodeTypeReference("DispId"), new CodeAttributeArgument[] { new CodeAttributeArgument(new CodePrimitiveExpression(dispid)) }));
			AddAttribute(attrs, "DispId", new CodeAttributeArgument[] { new CodeAttributeArgument(new CodePrimitiveExpression(dispid)) });
		}
		private static void AddXmlIgnoreAttribute(CodeAttributeDeclarationCollection attrs)
		{
			AddAttribute(attrs, XML_IGNORE_ATTRIBUTE);
			AddAttribute(attrs, JSON_IGNORE_ATTRIBUTE);
		}
		/// <summary>
		/// Add an attribute to a member
		/// </summary>
		/// <param name="attrs"></param>
		/// <param name="attribute"></param>
		/// <param name="arguments"></param>
		private static void AddAttribute(CodeAttributeDeclarationCollection attrs, string attribute, CodeAttributeArgument[] arguments = null)
		{
			if (!attrs.Contains(new CodeAttributeDeclaration(attribute)))
			{
				if (null == arguments)
					attrs.Add(new CodeAttributeDeclaration(new CodeTypeReference(attribute)));
				else
					attrs.Add(new CodeAttributeDeclaration(new CodeTypeReference(attribute), arguments));
			}
		}

		private static void AddClassIXmlSerializableInheritance(CodeTypeDeclaration codeType)
		{
			if (!codeType.BaseTypes.Contains(new CodeTypeReference(typeof(IXmlSerializable))))
			{
				codeType.BaseTypes.Add(new CodeTypeReference(typeof(IXmlSerializable)));
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="name"></param>
		/// <param name="type"></param>
		/// <param name="attr"></param>
		/// <returns></returns>
		private CodeMemberProperty CreatePropertyMember(string name, CodeTypeReference type, MemberAttributes attr)//, CodeMemberField field, string b = null, string e = null)
		{
			CodeMemberProperty cmp = new CodeMemberProperty()
			{
				Name = name,
				Type = type,
				Attributes = attr,
			};
			// that init flag statement will not be serialized inside XML
			AddXmlIgnoreAttribute(cmp.CustomAttributes);
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
		private CodeMemberField CreateFieldMember(string name, CodeTypeReference type, MemberAttributes attr, object value)
		{
			CodeMemberField cmf = new CodeMemberField(type, FieldNameFromPropretyName(name));
			cmf.Attributes = attr;
			cmf.InitExpression = new CodePrimitiveExpression(value);
			return cmf;
		}
		private string FieldNameFromPropretyName(string name)
		{
			return name.Substring(0, 1).ToLower() + name.Substring(1);
		}
		private string HasbeenSetPropertyName()
		{
			//return $"{typeName}{NexoXSDStrings.NexoHasBeenSetProperty}";
			return $"{NexoXSDStrings.NexoHasBeenSetProperty}";
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
		private CodeConstructor GetDefaultClassConstructor(CodeTypeDeclaration codeType)
		{
			CodeConstructor cc = null;
			foreach (CodeTypeMember xctm in codeType.Members)
			{
				// search a constructor
				if (xctm is CodeConstructor && 0 == ((CodeConstructor)xctm).Parameters.Count)
				{
					// we've found the default constructor
					cc = (CodeConstructor)xctm;
					break;
				}
			}
			return cc;
		}
		/// <summary>
		/// Constructor accepting a specific object as the only parameter
		/// </summary>
		/// <param name="codeType"></param>
		/// <param name="type"></param>
		/// <returns></returns>
		private CodeConstructor GetDefaultClassConstructorFromObject(CodeTypeDeclaration codeType, CodeTypeReference type)
		{
			CodeConstructor cc = null;
			foreach (CodeTypeMember xctm in codeType.Members)
			{
				// search a constructor
				if (xctm is CodeConstructor && 1 == ((CodeConstructor)xctm).Parameters.Count && type == ((CodeConstructor)xctm).Parameters[0].Type)
				{
					// we've found that specific constructor
					cc = (CodeConstructor)xctm;
					break;
				}
			}
			return cc;
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
		private bool UpdatePropertyFieldInsideConstructor(CodeConstructor constructor, CodeMemberField field, CodeExpression exp)
		{
			// only if a field to update is present
			if (null != field)
			{
				// inside the class constructor replace the value by the const in the assignment
				if (null != constructor && 0 != constructor.Statements.Count)
				{
					// search a statement initialising the property with its default value
					foreach (CodeStatement xcss in constructor.Statements)
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
		/// <summary>
		/// Get a memeber object by its name
		/// </summary>
		/// <param name="codeType"></param>
		/// <param name="property"></param>
		/// <param name="name"></param>
		/// <returns></returns>
		private static CodeTypeMember GetMemberByName<NxT>(CodeTypeDeclaration codeType, CodeMemberProperty property, string name)
		{
			if (null != property)
			{
				foreach (CodeTypeMember mtb in codeType.Members)
				{
					if (mtb is NxT)
					{
						if (0 == string.Compare(name, mtb.Name, true))
						{
							return mtb;
						}
					}
				}
			}
			return default;
		}
		#endregion
	}
}