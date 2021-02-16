#define DECLAREHASBEENSET
#define DECLAREOPTIMIZER
#define USEOPTIMIZER

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
		#region properties
		public Control Ctrl = null;
		public string Code { get; private set; }

		/// <summary>
		///  Dictionary of all tags inside all XSD files
		/// </summary>
		class MyTags : SortedDictionary<string, string> { }
		private MyTags tags = new MyTags();

		/// <summary>
		/// dictionary of all objects contained inside all the XSD files
		/// </summary>
		class MyCodeTypeDeclarations : SortedDictionary<string, CodeTypeDeclaration> { }
		private MyCodeTypeDeclarations codeTypeDeclarations;

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
		/// <param name="mixFiles"></param>
		/// <returns></returns>
		public bool AnalyseXSD(XSDSettings settings, bool mixFiles)
		{
			XmlSchema xsd;
			try
			{
				codeTypeDeclarations = new MyCodeTypeDeclarations();
				if (mixFiles)
				{
					// all XSD will generate 1 file
					MyTags tags = new MyTags();
					XmlSchemas xsds = new XmlSchemas();
					string fileName = null;
					// load all selected files into a schema and compile
					foreach (string file in settings.Files)
					{
						if (string.IsNullOrEmpty(fileName))
							fileName = settings.Files[0] + GetExtension(settings);
						using (var stream = new FileStream(file, FileMode.Open, FileAccess.Read))
						{
							xsd = XmlSchema.Read(stream, null);
						}
						xsds.Add(xsd);
					}
					xsds.Compile(null, true);
					return ProcessFile(settings, xsds, fileName, true);
				}
				else
				{
					// each XSD generates 1 file
					bool fOK = true;
					// load all selected files into a schema and compile
					for (int i = 0; i < settings.Files.Count; i++)
					{
						string fileName = settings.Files[i] + GetExtension(settings);
						XmlSchemas xsds = new XmlSchemas();
						using (var stream = new FileStream(settings.Files[i], FileMode.Open, FileAccess.Read))
						{
							xsd = XmlSchema.Read(stream, null);
						}
						xsds.Add(xsd);
						xsds.Compile(null, true);
						// allow special processing for the last file
						fOK = fOK && ProcessFile(settings, xsds, fileName, i == settings.Files.Count - 1);
					}
					return fOK;
				}
			}
			catch (Exception ex)
			{
				settings.Exception = ex.Message;
				//CodeNamespace = default;
				return false;
			}
		}
		/// <summary>
		/// Prepare a file to be created by the processing adding all necessary attributes and processing the types it contains
		/// </summary>
		/// <param name="settings"></param>
		/// <param name="xsds"></param>
		/// <param name="fileName"></param>
		/// <param name="lastFile"></param>
		/// <returns></returns>
		private bool ProcessFile(XSDSettings settings, XmlSchemas xsds, string fileName, bool lastFile)
		{
			try
			{
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
				CodeNamespace newCodeNamespace = PostProcess(settings, codeNamespace, lastFile);

				// add the required imports 
				newCodeNamespace.Imports.Add(new CodeNamespaceImport("System.Runtime.Serialization"));
				if (settings.AddDispID && settings.DeclareClassInterface)
					newCodeNamespace.Imports.Add(new CodeNamespaceImport("System.Runtime.InteropServices"));


				// display in texbox
				//CodeGenerator.ValidateIdentifiers(codeNamespace);
				CodeGenerator.ValidateIdentifiers(newCodeNamespace);

				// create the code
				//Code = GenerateCode(settings, codeNamespace);
				Code = GenerateCode(settings, newCodeNamespace);
				if (!string.IsNullOrEmpty(beginPreprocessor))
				{
					Code = $"{beginPreprocessor}\r\n{Code}{endPreprocessor}";
				}

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
		/// <param name="codeNamespace"></param>
		/// <param name="lastFile"></param>
		/// <returns></returns>
		private CodeNamespace PostProcess(XSDSettings settings, CodeNamespace codeNamespace, bool lastFile)
		{
			#region init parameters
			// try to open the type conversino file
			CJson<XSDParams> json = new CJson<XSDParams>(settings.ParametersFileName);
			XSDParams parameters = json.ReadSettings();
			if (null == parameters)
			{
				parameters = new XSDParams();
				json.WriteSettings(parameters);
			}
			bool fakeConversions = false, fakeArrays = false;
			if (null == parameters.TypeConversions)
			{
				parameters.TypeConversions = new XSDTypeConversions();
				parameters.TypeConversions.Add("myBaseType1", new XSDTargetType()
				{
					TargetType = "myTargetType",
					TargetProperty = "myTargetProperty",
				});
				parameters.TypeConversions.Add("myBaseType2", new XSDTargetType()
				{
					TargetType = "myTargetType",
					TargetProperty = "myTargetProperty",
				});
				fakeConversions = true;
			}
			if (null == parameters.ArraysWithoutInitializer)
			{
				parameters.ArraysWithoutInitializer = new XSDArraysWithoutInitializer();
				parameters.ArraysWithoutInitializer.Add("myArrayType1");
				parameters.ArraysWithoutInitializer.Add("myArrayType2");
				fakeArrays = true;
			}
			if (null == parameters.FieldsWithoutInitializer)
			{
				parameters.FieldsWithoutInitializer = new XSDFieldsWithoutInitializer();
				parameters.FieldsWithoutInitializer.Add("myPropertyName1", new XSDField() { Type = "myPropertyType" });
				parameters.FieldsWithoutInitializer.Add("myPropertyName2", new XSDField() { Type = "myPropertyType" });
				fakeArrays = true;
			}
			json.WriteSettings(parameters);
			if (fakeConversions)
				parameters.TypeConversions = null;
			if (fakeArrays)
				parameters.ArraysWithoutInitializer = null;
			#endregion

			CodeNamespace newCodeNamespace = null;

			string bXSD = "BEGIN ADDED BY XSD";
			string eXSD = "END ADDED BY XSD";

			try
			{
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
						codeTypeDeclarations.Add(codeType.Name /*+ "myXSDClassOrStruct"*/, codeType);
						// arrived here the type can be added 
						thisFileTypes.Add(codeType);
						//if (codeType.IsEnum)
						//	enums.Add(codeType.Name, codeType);
					}
					catch (Exception) { }
				}

				int internalcounter = 0;
				foreach (CodeTypeDeclaration codeType in codeNamespace.Types)
				{
					internalcounter++;

#if DECLAREHASBEENSET
					// prepare init flag statements (create an additional bool value set to true if the data has been set, false otherwise)
					CodeMemberField hasBeenSetField = CreateFieldMember(NexoXSDStrings.NexoHasBeenSetField, typeof(bool), MemberAttributes.Private, false);
					CodeMemberProperty hasBeenSetProperty = CreatePropertyMember(NexoXSDStrings.NexoHasBeenSetProperty, typeof(bool), MemberAttributes.Public | MemberAttributes.Final, hasBeenSetField, bXSD, eXSD);
#else
					string hasBeenSetFieldStr = NexoXSDStrings.NexoHasBeenSetField;
#endif

#if DECLAREOPTIMIZER
					// prepare optimizing flag statements as a FIELD (create an additional bool value set to true if optimizing the class, false otherwise)
					CodeMemberField optimizingField = CreateFieldMember(NexoXSDStrings.NexoOptimizingField, typeof(bool), MemberAttributes.Private, false);
					CodeMemberProperty optimizingProperty = CreatePropertyMember(NexoXSDStrings.NexoOptimizingProperty, typeof(bool), MemberAttributes.Assembly | MemberAttributes.Final, optimizingField, bXSD, eXSD);
#else
					string optimizerFieldStr = NexoXSDStrings.NexoOptimizingField;
#endif

					// create a list of properties that will receive special processing from XSDEx
					List<CodeMemberProperty> propertiesToProcess = new List<CodeMemberProperty>();
					List<CodeMemberProperty> optionalToProcess = new List<CodeMemberProperty>();

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
							int i;

							// remove debugger settings
							CodeAttributeDeclaration cad = new CodeAttributeDeclaration("System.Diagnostics.DebuggerStepThroughAttribute");
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

							// create a collection for all new members (created by XSDEx) inside the type
							CodeTypeMemberCollection newCollection = new CodeTypeMemberCollection();

							// create collection of objects setting the "HasBeenSet" flag

							// parse all members
							foreach (CodeTypeMember member in codeType.Members)
							{
								// process fields...
								if (member is CodeMemberField)
								{
									CodeMemberField field = (CodeMemberField)member;

									//if (0<>field.Type.Nested)
									//if (0<>field.Type.ArrayRank)
									//{
									//	Array array = (Array)field.GetValue();
									//}
									string aaa = field.Type.ToString();

									// verify if type needs to be converted (decimal to double,...)
									field.Type = ConvertType(settings, parameters, field.Type);

									// get the kind of type for this field
									CodeTypeDeclaration ctd = null;
									try
									{
										ctd = codeTypeDeclarations[field.Type.BaseType];
									}
									catch (Exception) { }

									// should private be replaced by internal ?
									if (settings.PrivateByInternal && MemberAttributes.Private == field.Attributes)
									{
										field.Attributes = MemberAttributes.Assembly;
									}

									// set field initalizers
									if (settings.ArrayCreateInitializer)
										// the field does not describe a System.<Type> and isn't an array, provide an initializer
										if (!IsSystemType(field.Type.BaseType) && 0 == field.Type.ArrayRank && !ctd.IsEnum)
										{
											// create "field = new Type();"
											field.InitExpression = new CodeObjectCreateExpression(field.Type.BaseType, new CodeExpression[] { });
										}
										// the field is an array, provide an initializer if no exception to it is set
										else if (CanConvertArray(parameters, field.Type, field))
										{
											// create "field = new Type[0];"
											field.InitExpression = new CodeArrayCreateExpression(field.Type.BaseType, 0);
										}
								}

								// process properties...
								else if (member is CodeMemberProperty)
								{
									// first add the property name to the list of tags
									try
									{ tags.Add(member.Name, member.Name); }
									catch (Exception) { }

									CodeMemberProperty property = (CodeMemberProperty)member;

									// get the kind of type for this property
									CodeTypeDeclaration ctd = null;
									try
									{
										ctd = codeTypeDeclarations[property.Type.BaseType];
									}
									catch (Exception) { }

									// verify if type needs to be converted
									property.Type = ConvertType(settings, parameters, property.Type);

									// search linked field
									const string specified = "Field";
									CodeTypeMember propertyField = null;
									foreach (CodeTypeMember mtb in codeType.Members)
										if (mtb is CodeMemberField)
											if (0 == string.Compare(property.Name + specified, mtb.Name, true))
											{
												propertyField = mtb;
												break;
											}

									// search whether this property is optional (there's a <name>Specified property, generated by the framework)
									bool optional = false;
									const string optionalSpecified = "Specified";
									foreach (CodeTypeMember mtb in codeType.Members)
										if (mtb is CodeMemberProperty)
											if (optional = (0 == string.Compare(property.Name + optionalSpecified, mtb.Name, true)))
												break;

									// search whether this is a "Specified" flag keeping track of the optional member
									bool optionalFlag = property.Name.EndsWith(optionalSpecified);
									optionalFlag = optionalFlag && IsSystemType(property.Type.BaseType);

									// if not a system object or an array we add the object to the list of properties that will be treated by XSDEx
									if (!IsSystemType(property.Type.BaseType) && !IsArray(property.Type) && !ctd.IsEnum && !optionalFlag)
									{
										propertiesToProcess.Add(property);
									}
									// if it is an optional flag save it for later use
									if (optionalFlag)
									{
										optionalToProcess.Add(property);
									}

									// "set" property part
									if (property.HasSet)
									{
										// not a system type
										if (!IsSystemType(property.Type.BaseType) && !ctd.IsEnum)
										{
											// remove all set statements to add ours
											property.SetStatements.Clear();

											// if not an enum...
											if (null != ctd && !ctd.IsEnum)
											{
												CodeExpression ce;
												if (IsArray(property.Type))
													ce = new CodeArrayCreateExpression(property.Type, 0);
												else
													ce = new CodeObjectCreateExpression(property.Type, new CodeExpression[] { });

												// create "if (null==value) { object=new} else { object=value;}"
												CodeConditionStatement ccs = new CodeConditionStatement(
													new CodeBinaryOperatorExpression(
														new CodePropertySetValueReferenceExpression(),
														CodeBinaryOperatorType.ValueEquality,
														new CodePrimitiveExpression(null)),
													// if true
													new CodeStatement[]
														{
															//new CodeAssignStatement(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), hasBeenSetFieldStr), new CodeBinaryOperatorExpression(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), hasBeenSetFieldStr), CodeBinaryOperatorType.BitwiseOr, new CodePropertyReferenceExpression(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), propertyField.Name), hasBeenSetFieldStr))),
															new CodeAssignStatement(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), propertyField.Name), ce)
														},
													// if false
													new CodeStatement[]
														{
															//new CodeAssignStatement(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), hasBeenSetFieldStr), new CodePrimitiveExpression(true)),
															new CodeAssignStatement(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(),propertyField.Name), new CodePropertySetValueReferenceExpression())
														}
													);
												property.SetStatements.Insert(0, new CodeCommentStatement($"{bXSD} - prevent {(IsArray(property.Type) ? "array" : "class")} from being null"));
												property.SetStatements.Insert(1, ccs);
												property.SetStatements.Insert(2, new CodeCommentStatement($"{eXSD}"));
											}
											// this is an enum, let's do nothing
											else
											{
											}
										}

										// system type
										else
										{
											CodeAssignStatement cas;

											// if optional property update FieldSpecified flag when the property is set
											if (optional)
											{
												// set ...fieldSpecified when setting the property
												string st = property.Name + optionalSpecified;
												cas = new CodeAssignStatement(new CodePropertyReferenceExpression(new CodeThisReferenceExpression(), st), new CodePrimitiveExpression(true));
												property.SetStatements.Add(new CodeCommentStatement($"{bXSD} - indicate optional system property value may have been changed - {st} = true"));
												property.SetStatements.Add(cas);
												property.SetStatements.Add(new CodeCommentStatement($"{eXSD}"));
											}

											// specified flag, managed by the framework
											if (optionalFlag)
											{
												// do nothing
											}
											else
											{
												// add set the init flag once the property is set
												// every property once set must set the type init flag
												cas = new CodeAssignStatement(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), hasBeenSetField.Name), new CodePrimitiveExpression(true));
												property.SetStatements.Insert(0, new CodeCommentStatement($"{bXSD} - indicate system value has been changed"));
												property.SetStatements.Insert(1, cas);
												property.SetStatements.Insert(2, new CodeCommentStatement($"{eXSD}"));
											}
										}
									}

									// "get" property part
									if (property.HasGet)
									{
										// Set a "return null;" if array is of size 0
										if (CanConvertArray(parameters, property.Type, property) && settings.ArrayGetReturnsNullEmpty)
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
															"Length"),
														CodeBinaryOperatorType.ValueEquality,
														new CodePrimitiveExpression(0))),
													new CodeMethodReturnStatement(new CodePrimitiveExpression(null)));
											property.GetStatements.Insert(0, new CodeCommentStatement($"{bXSD} - return null if array count is 0, still keeping the array"));
											property.GetStatements.Insert(1, ccs);
											property.GetStatements.Insert(2, new CodeCommentStatement($"{eXSD}"));
										}

#if USEOPTIMIZER
										// if it is not a System type, if optimizing is on and the class hasn't been updated return what's appropriate
										if (!IsArray(property.Type) && !IsSystemType(property.Type.BaseType))
										{
											// check the kind of type for this property
											if (null != ctd && !ctd.IsEnum)
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
												property.GetStatements.Insert(0, new CodeCommentStatement($"{bXSD} - return null if array count is 0, still keeping the array"));
												property.GetStatements.Insert(1, ccs);
												property.GetStatements.Insert(2, new CodeCommentStatement($"{eXSD}"));
											}
											else
											{
												// it is an enum, do nothing special
											}
										}
#endif

									}

									#region declare accessors
									// if array then create accessors if requested
									if (CanConvertArray(parameters, property.Type, property) && settings.CreateArrayAccessors)
									{
										string isEx = "ex";
										string isLength = "Length";
										// get Size method (if null!=array ? return array.size : 0)
										string addenda = "Size";
										CodeMemberMethod cmm = new CodeMemberMethod();
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
										newCollection.Add(cmm);

										// get Item method (try	{return null != array ? array.Length - 1 >= index ? array[index] : default : default;}	catch (Exception) { return default; })
										addenda = "GetItem";
										string isIndex = "index";
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
										newCollection.Add(cmm);

										// set Item method (try	{return null != array ? array.Length - 1 >= index ? array[index] : default : default;}	catch (Exception) { return default; })
										addenda = "SetItem";
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
										newCollection.Add(cmm);

										// add Item method (try	{return null != array ? array.Length - 1 >= index ? array[index] : default : default;}	catch (Exception) { return default; })
										addenda = "AddItem";
										cmm = new CodeMemberMethod();
										cmm.Attributes = MemberAttributes.Public | MemberAttributes.Final;
										cmm.Name = property.Name + addenda;
										cmm.ReturnType = new CodeTypeReference(typeof(bool));
										cpde = new CodeParameterDeclarationExpression(
											new CodeTypeReference(property.Type.BaseType), isValue);
										cmm.Parameters.Add(cpde);
										string isArray = "array";
										string isCounter = "i";
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
														new CodeAssignStatement(new CodeVariableReferenceExpression(isCounter), new CodePrimitiveExpression(0)),
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
										newCollection.Add(cmm);

										// remove Item method 
										addenda = "RemoveItem";
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
										newCollection.Add(cmm);
									}
									#endregion
								}
							}

							List<CodeStatement> statements = new List<CodeStatement>();

#if DECLAREHASBEENSET
							// add init flag statements
							AddComment(hasBeenSetProperty, b, true);
							CodeExpression expression = new CodePropertyReferenceExpression(new CodeThisReferenceExpression(), hasBeenSetField.Name);
							foreach (CodeMemberProperty cmp in propertiesToProcess)
							{
								expression = new CodeBinaryOperatorExpression(
									expression,
									CodeBinaryOperatorType.BooleanOr,
									new CodePropertyReferenceExpression(
										new CodePropertyReferenceExpression(
											new CodeThisReferenceExpression(),
											cmp.Name),
										hasBeenSetProperty.Name));
							}
							foreach (CodeMemberProperty cmp in optionalToProcess)
							{
								expression = new CodeBinaryOperatorExpression(
									expression,
									CodeBinaryOperatorType.BooleanOr,
									new CodePropertyReferenceExpression(
										new CodeThisReferenceExpression(),
										cmp.Name));
							}
							hasBeenSetProperty.GetStatements.Add(new CodeMethodReturnStatement(expression));
							AddComment(hasBeenSetProperty, e, true);


							AddSetStatementFromValue(hasBeenSetProperty, hasBeenSetField, b, e);
							AddComment(hasBeenSetProperty, b, false);
							foreach (CodeMemberProperty cmp in propertiesToProcess)
							{
								statements.Add(new CodeAssignStatement(
									new CodePropertyReferenceExpression(
										new CodeThisReferenceExpression(),
										cmp.Name),
									new CodePrimitiveExpression(null)));
							}
							foreach (CodeMemberProperty cmp in optionalToProcess)
							{
								statements.Add(new CodeAssignStatement(
									new CodePropertyReferenceExpression(
										new CodeThisReferenceExpression(),
										cmp.Name),
									new CodePrimitiveExpression(false)));
							}
							hasBeenSetProperty.SetStatements.Add(new CodeConditionStatement(
								new CodeBinaryOperatorExpression(
									new CodePropertyReferenceExpression(
										new CodeThisReferenceExpression(), hasBeenSetField.Name),
										CodeBinaryOperatorType.IdentityEquality,
										new CodePrimitiveExpression(false)),
									statements.ToArray()));
							AddComment(hasBeenSetProperty, e, false);
							codeType.Members.Add(hasBeenSetField);
							codeType.Members.Add(hasBeenSetProperty);
#endif

#if DECLAREOPTIMIZER
							//add set optimizing flag to all
							AddGetStatementFromField(optimizingProperty, optimizingField, b, e);
							AddSetStatementFromValue(optimizingProperty, optimizingField, b, e);
							AddComment(optimizingProperty, b, false);
							statements.Clear();
							foreach (CodeMemberProperty cmp in propertiesToProcess)
							{
								statements.Add(new CodeConditionStatement(
									new CodeBinaryOperatorExpression(
										 new CodePropertyReferenceExpression(
											 new CodeThisReferenceExpression(),
											 cmp.Name),
										CodeBinaryOperatorType.IdentityInequality,
										new CodePrimitiveExpression(null)),
									new CodeStatement[]
									{
										new CodeAssignStatement(
											new CodePropertyReferenceExpression(
												new CodePropertyReferenceExpression(
													new CodeThisReferenceExpression(),
													cmp.Name),
												optimizingProperty.Name),
											new CodeFieldReferenceExpression(
												new CodeThisReferenceExpression(),
												optimizingField.Name))
									}));
							}
							optimizingProperty.SetStatements.AddRange(statements.ToArray());
							AddComment(optimizingProperty, e, false);
							codeType.Members.Add(optimizingField);
							codeType.Members.Add(optimizingProperty);
#endif

							// update the collection of new members to the already existing ones inside this type
							// they are new methods for instance
							if (0 != newCollection.Count)
							{
								codeType.Members.AddRange(newCollection);
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
									codeTypeDeclarations.Add(key, itf);
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

				//// create a Decimal formatting attribute
				//CodeAttributeDeclaration decimalFormat = new CodeAttributeDeclaration("DecimalFormatterAttribute");
				//codeTypeDeclarations.Add(decimalFormat);

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
						codeTypeDeclarations.Add(tagsType.Name, tagsType);
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
		private static CodeTypeReference ConvertType(XSDSettings settings, XSDParams parameters, CodeTypeReference type)
		{
			CodeTypeReference ntype = null;
			// convert type if declared in the list of types to convert
			if (null != parameters.TypeConversions && settings.ConvertTypes && parameters.TypeConversions.ContainsKey(type.BaseType))
			{
				ntype = new CodeTypeReference(parameters.TypeConversions[type.BaseType].TargetType);
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
			return ntype ?? type;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="parameters"></param>
		/// <param name="type"></param>
		/// <param name="member"></param>
		/// <returns></returns>
		private static bool CanConvertArray(XSDParams parameters, CodeTypeReference type, CodeTypeMember member)
		{
			return (IsArray(type) /* BEWARE multi dimensional arrays are not well managed */
				&& (null == parameters.ArraysWithoutInitializer
					|| (null != parameters.ArraysWithoutInitializer && !parameters.ArraysWithoutInitializer.Contains(type.BaseType)))
				&& (null == parameters.FieldsWithoutInitializer
					|| (null != parameters.FieldsWithoutInitializer && !parameters.FieldsWithoutInitializer.ContainsKey(member.Name))
					|| (null != parameters.FieldsWithoutInitializer && parameters.FieldsWithoutInitializer.ContainsKey(member.Name) && type.BaseType != parameters.FieldsWithoutInitializer[member.Name].Type)));
		}
		private static bool IsArray(CodeTypeReference type)
		{
			int rank = type.ArrayRank;
			return 0 != type.ArrayRank;
		}
		private static bool IsSystemType(string value)
		{
			return value.Contains("System.");
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
		{ attrs.Add(new CodeAttributeDeclaration(new CodeTypeReference("System.Runtime.InteropServices.ClassInterface"), new CodeAttributeArgument(new CodeFieldReferenceExpression(new CodeTypeReferenceExpression("System.Runtime.InteropServices.ClassInterfaceType"), clsif.ToString())))); }
		private static void AddInterfaceType(CodeAttributeDeclarationCollection attrs, ComInterfaceType cit = ComInterfaceType.InterfaceIsDual)
		{ attrs.Add(new CodeAttributeDeclaration(new CodeTypeReference("System.Runtime.InteropServices.InterfaceTypeAttribute"), new CodeAttributeArgument(new CodeFieldReferenceExpression(new CodeTypeReferenceExpression("System.Runtime.InteropServices.ComInterfaceType"), cit.ToString())))); }
		private static void AddDispID(CodeAttributeDeclarationCollection attrs, int dispid)
		{ attrs.Add(new CodeAttributeDeclaration(new CodeTypeReference("DispId"), new CodeAttributeArgument(new CodePrimitiveExpression(dispid)))); }
		/// <summary>
		/// 
		/// </summary>
		/// <param name="name"></param>
		/// <param name="type"></param>
		/// <param name="attr"></param>
		/// <param name="field"></param>
		/// <param name="b"></param>
		/// <param name="e"></param>
		/// <returns></returns>
		private CodeMemberProperty CreatePropertyMember(string name, Type type, MemberAttributes attr, CodeMemberField field, string b = null, string e = null)
		{
			CodeMemberProperty cmp = new CodeMemberProperty()
			{
				Name = name,
				Type = new CodeTypeReference(type),
				Attributes = attr,
			};
			// that init flag statement will not be serialized inside XML
			cmp.CustomAttributes.Add(new CodeAttributeDeclaration("System.Xml.Serialization.XmlIgnoreAttribute"));
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
		private void AddGetStatementFromField(CodeMemberProperty cmp, CodeMemberField field, string b = null, string e = null)
		{
			if (!string.IsNullOrEmpty(b)) cmp.GetStatements.Add(new CodeCommentStatement($"{b} - {MethodBase.GetCurrentMethod().Name}"));
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
		#endregion
	}
}