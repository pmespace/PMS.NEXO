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

namespace XSDEx
{

	/// <summary>
	/// XSD to code class
	/// </summary>
	public class XSD
	{
		#region properties
		public string Code { get; private set; }
		private CodeNamespace CodeNamespace = default;
		#endregion

		#region methods
		/// <summary>
		/// 
		/// </summary>
		/// <param name="settings"></param>
		/// <returns></returns>
		public bool AnalyseXSD(XSDSettings settings)
		{
			XmlSchema xsd;
			XmlSchemas xsds = new XmlSchemas();
			try
			{
				// load all selected files into a schema and compile
				foreach (string file in settings.Files)
				{
					using (var stream = new FileStream(file, FileMode.Open, FileAccess.Read))
					{
						xsd = XmlSchema.Read(stream, null);
					}
					xsds.Add(xsd);
				}
				xsds.Compile(null, true);

				// create the context
				if (string.IsNullOrEmpty(settings.Nmspace))
					settings.Nmspace = "XSD";
				XmlSchemaImporter schemaImporter = new XmlSchemaImporter(xsds);
				CodeNamespace = new CodeNamespace(settings.Nmspace);
				CodeNamespace.Imports.Add(new CodeNamespaceImport("System.Runtime.Serialization"));
				CodeNamespace.Imports.Add(new CodeNamespaceImport("System.Runtime.InteropServices"));
				XmlCodeExporter codeExporter = new XmlCodeExporter(CodeNamespace, null, CodeGenerationOptions.GenerateProperties);

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
				foreach (var map in maps)
					codeExporter.ExportTypeMapping(map);

				// process the files to generate a class
				PostProcess(settings, CodeNamespace);

				// create the code
				Code = GenerateCode(settings);

				// display in texbox
				CodeGenerator.ValidateIdentifiers(CodeNamespace);
				return true;
			}
			catch (Exception ex)
			{
				settings.Exception = ex.Message;
				CodeNamespace = default;
				return false;
			}
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
			if (null != parameters.Conversions && settings.ConvertTypes && parameters.Conversions.ContainsKey(type.BaseType))
			{
				ntype = new CodeTypeReference(parameters.Conversions[type.BaseType].TargetType);
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
			return (0 != type.ArrayRank /* BEWARE multi dimensional arrays are not well managed */
				&& (null == parameters.Arrays
					|| (null != parameters.Arrays && !parameters.Arrays.Contains(type.BaseType)))
				&& (null == parameters.Data
					|| (null != parameters.Data && !parameters.Data.ContainsKey(member.Name))
					|| (null != parameters.Data && parameters.Data.ContainsKey(member.Name) && type.BaseType != parameters.Data[member.Name].Type)));
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="settings"></param>
		/// <param name="CodeNamespace"></param>
		private static void PostProcess(XSDSettings settings, CodeNamespace CodeNamespace)
		{
			#region init parameters
			// try to open the type conversino file
			CJson<XSDParams> json = new CJson<XSDParams>(settings.ParametersFileName);
			XSDParams parameters = json.ReadSettings();
			if (null == parameters)
				parameters = new XSDParams();
			bool fakeConversions = false, fakeArrays = false;
			if (null == parameters.Conversions)
			{
				parameters.Conversions = new XSDTypeConversions();
				parameters.Conversions.Add("myBaseType1", new XSDTargetType()
				{
					TargetType = "myTargetType",
					TargetProperty = "myTargetProperty",
				});
				parameters.Conversions.Add("myBaseType2", new XSDTargetType()
				{
					TargetType = "myTargetType",
					TargetProperty = "myTargetProperty",
				});
				fakeConversions = true;
			}
			if (null == parameters.Arrays)
			{
				parameters.Arrays = new XSDArraysWithoutInitializer();
				parameters.Arrays.Add("myArrayType1");
				parameters.Arrays.Add("myArrayType2");
				fakeArrays = true;
			}
			if (null == parameters.Data)
			{
				parameters.Data = new XSDFieldsWithoutInitializer();
				parameters.Data.Add("myPropertyName1", new XSDField() { Type = "myPropertyType" });
				parameters.Data.Add("myPropertyName2", new XSDField() { Type = "myPropertyType" });
				fakeArrays = true;
			}
			json.WriteSettings(parameters);
			if (fakeConversions)
				parameters.Conversions = null;
			if (fakeArrays)
				parameters.Arrays = null;
			#endregion

			try
			{
				string myXSDData = "myXSDClass";
				string myXSDClassType = myXSDData + "Type";
				string myXSDClassGenerating = "Generating";

				SortedDictionary<string, string> tags = new SortedDictionary<string, string>();
				List<CodeTypeDeclaration> codeTypeDeclarations = new List<CodeTypeDeclaration>();
				foreach (CodeTypeDeclaration codeType in CodeNamespace.Types)
				{
					bool add = true;
					bool addInterface = false;
					bool visible = ((TypeAttributes.Public == (codeType.TypeAttributes & TypeAttributes.Public)) ||
							(TypeAttributes.NestedPublic == (codeType.TypeAttributes & TypeAttributes.NestedPublic))) &&
							(TypeAttributes.Abstract != (codeType.TypeAttributes & TypeAttributes.Abstract));
					if (visible && (codeType.IsClass || codeType.IsStruct))
					{
						int i;
						bool contains = false;
						CodeAttributeDeclaration cad = new CodeAttributeDeclaration("System.Diagnostics.DebuggerStepThroughAttribute");
						for (i = 0; i < codeType.CustomAttributes.Count; i++)
							if (contains = (codeType.CustomAttributes[i].Name == cad.Name))
								break;
						if (contains)
							codeType.CustomAttributes.RemoveAt(i);

						if (addInterface = settings.MakeClassComVisible)
						{
							AddGuid(codeType.CustomAttributes);
							AddClassInterface(codeType.CustomAttributes, settings.ClassInterface);
						}
						AddComVisible(codeType.CustomAttributes, addInterface);

						// prepare init flag statements
						string before = "xsd", after = "InitFlag", attheend = "Field", baseName = before + codeType.Name + after;
						CodeMemberField cmf = new CodeMemberField(new CodeTypeReference(typeof(bool)), baseName + attheend);
						cmf.Attributes = MemberAttributes.Assembly;
						cmf.InitExpression = new CodePrimitiveExpression(false);
						CodeMemberProperty cmp = new CodeMemberProperty();
						cmp.CustomAttributes.Add(new CodeAttributeDeclaration("System.Xml.Serialization.XmlIgnoreAttribute"));
						cmp.Name = baseName;
						cmp.Type = new CodeTypeReference(typeof(bool));
						cmp.Attributes = MemberAttributes.Public | MemberAttributes.Final;
						cmp.GetStatements.Add(new CodeMethodReturnStatement(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), cmf.Name)));
						cmp.SetStatements.Add(new CodeAssignStatement(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), cmf.Name), new CodePropertySetValueReferenceExpression()));

						bool manageInitFlag = settings.ManageInitFlag && codeType.IsClass;

						// change data type if requested
						CodeTypeMember[] members;
						members = new CodeTypeMember[codeType.Members.Count + 1];
						codeType.Members.CopyTo(members, 0);

						CodeTypeMemberCollection newCollection = new CodeTypeMemberCollection();

						foreach (CodeTypeMember member in codeType.Members)
						{
							// process fields...
							if (member is CodeMemberField)
							{
								CodeMemberField m = (CodeMemberField)member;

								// verify if type needs to be converted
								m.Type = ConvertType(settings, parameters, m.Type);

								// private by internal ?
								if (settings.PrivateByInternal && MemberAttributes.Private == m.Attributes)
								{
									m.Attributes = settings.PrivateByInternalVisibility;
								}

								// set field initalizers
								if (settings.CreateArrayInitializer)
									// the field does not describe a System.<Type> and isn't an array, provide an initializer
									if (!m.Type.BaseType.Contains("System.") && 0 == m.Type.ArrayRank)
									{
										// create "field = new Type();"
										m.InitExpression = new CodeObjectCreateExpression(m.Type.BaseType, new CodeExpression[] { });
									}
									// the field is an array, provide an initializer if no exception to it is set
									else if (CanConvertArray(parameters, m.Type, m))
									{
										// create "field = new Type[0];"
										m.InitExpression = new CodeArrayCreateExpression(m.Type.BaseType, 0);
									}
							}
							// and properties
							else if (member is CodeMemberProperty)
							{
								// first add the property name to the list of tags
								try
								{ tags.Add(member.Name, member.Name); }
								catch (Exception) { }

								CodeMemberProperty m = (CodeMemberProperty)member;

								// verify if type needs to be converted
								m.Type = ConvertType(settings, parameters, m.Type);

								// attributes according to property type <<<>>>
								if (0 == m.Type.ArrayRank && "System.Decimal" == m.Type.BaseType)
								{
									// add Decimal formatting attribute
									AddDecimalFormatter(m.CustomAttributes, "0.00");
								}

								// search linked field
								const string specified = "Field";
								CodeTypeMember mtbp = null;
								foreach (CodeTypeMember mtb in codeType.Members)
									if (mtb is CodeMemberField)
										if (0 == string.Compare(m.Name + specified, mtb.Name, true))
										{
											mtbp = mtb;
											break;
										}

								// search whether this property is optional (there's a <name>Specified property)
								bool optional = false;
								const string specifiedOptional = "Specified";
								foreach (CodeTypeMember mtb in codeType.Members)
									if (mtb is CodeMemberProperty)
										if (optional = (0 == string.Compare(m.Name + specifiedOptional, mtb.Name, true)))
											break;

								// "set" property part
								if (m.HasSet)
								{
									// if optional property update FieldSpecified flag when the property is set
									if (optional)
									{
										// set ...FieldSpecified when setting the property
										CodeAssignStatement cas = new CodeAssignStatement(new CodePropertyReferenceExpression(new CodeThisReferenceExpression(), m.Name + specifiedOptional), new CodePrimitiveExpression(true));
										m.SetStatements.Add(cas);
									}

									// add set the init flag once the property is set
									if (manageInitFlag)//&& 0 == m.Type.ArrayRank)
									{
										// every property once set must set the type init flag
										CodeAssignStatement cas = new CodeAssignStatement(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), cmf.Name), new CodePrimitiveExpression(true));
										m.SetStatements.Insert(0, cas);
									}

									// if array , set a "return null;" if size = 0
									if (CanConvertArray(parameters, m.Type, m) && settings.AutomaticArrays)
									{
										if (null != mtbp)
										{
											// create "if (array == null) return new array;"
											CodeConditionStatement ccs = new CodeConditionStatement(
												new CodeBinaryOperatorExpression(
													new CodeFieldReferenceExpression(
														new CodeThisReferenceExpression(), mtbp.Name),
													CodeBinaryOperatorType.ValueEquality,
													new CodePrimitiveExpression(null)),
												new CodeMethodReturnStatement(new CodeArrayCreateExpression(m.Type.BaseType, new CodeExpression[] { })));
											m.GetStatements.Insert(0, ccs);
										}
									}
								}

								// "get" property part
								if (m.HasGet)
								{
									// THIS HAS BEEN COMMENTED OUT BECAUSE FINDING A DEFAULT VALUE CAN BE HARD FOR SOME TYPES LIKE System.Boolean OR DateTime
									//// if optional property return a default value if the property hasn't been set
									//if (optional)
									//	{
									//	// set the default value if the property hasn't been set
									//	CodeConditionStatement ccs = new CodeConditionStatement(
									//		new CodeBinaryOperatorExpression(
									//			new CodePropertyReferenceExpression(
									//				new CodeThisReferenceExpression(), m.Name + specifiedOptional),
									//			CodeBinaryOperatorType.ValueEquality,
									//			new CodePrimitiveExpression(false)),
									//		new CodeMethodReturnStatement(new CodePrimitiveExpression(0)));
									//	m.GetStatements.Insert(0, ccs);
									//	}

									// Set a "return null;" if array is of size 0
									if (CanConvertArray(parameters, m.Type, m) && settings.GetReturnsNullIfArrayIsEmpty)
									{
										if (null != mtbp)
										{
											// create "if (array == null || array.Length == 0) return null;"
											//CodeConditionStatement ccs = new CodeConditionStatement(
											//	new CodeBinaryOperatorExpression(
											//		new CodePropertyReferenceExpression(
											//			new CodePropertyReferenceExpression(
											//				new CodeThisReferenceExpression(), mtbp.Name), "Length"),
											//		CodeBinaryOperatorType.ValueEquality,
											//		new CodePrimitiveExpression(0)),
											//	new CodeMethodReturnStatement(new CodePrimitiveExpression(null)));

											CodeConditionStatement ccs = new CodeConditionStatement(
												new CodeBinaryOperatorExpression(
													new CodeBinaryOperatorExpression(
														new CodeFieldReferenceExpression(
															new CodeThisReferenceExpression(), mtbp.Name),
														CodeBinaryOperatorType.ValueEquality,
														new CodePrimitiveExpression(null)),
													CodeBinaryOperatorType.BooleanOr,
													new CodeBinaryOperatorExpression(
														new CodePropertyReferenceExpression(
															new CodeFieldReferenceExpression(
																new CodeThisReferenceExpression(), mtbp.Name),
															"Length"),
														CodeBinaryOperatorType.ValueEquality,
														new CodePrimitiveExpression(0))),
													new CodeMethodReturnStatement(new CodePrimitiveExpression(null)));
											m.GetStatements.Insert(0, ccs);
										}
									}
									else if (manageInitFlag && 0 == m.Type.ArrayRank && !m.Type.BaseType.StartsWith("System") && !m.Type.BaseType.EndsWith("Enumeration") && settings.OptimizeStructs) //<<<>>>
									{
										//// create "if (type....InitFlag == false) return null;"
										//CodeConditionStatement ccs = new CodeConditionStatement(
										//	new CodeBinaryOperatorExpression(
										//		new CodePropertyReferenceExpression(
										//			new CodePropertyReferenceExpression(
										//				new CodeThisReferenceExpression(), mtbp.Name), before + m.Type.BaseType + after),
										//		CodeBinaryOperatorType.ValueEquality,
										//		new CodePrimitiveExpression(false)),
										//	new CodeMethodReturnStatement(new CodePrimitiveExpression(null)));
										// create "if (type....InitFlag == false) return null;"
										CodeConditionStatement ccs = new CodeConditionStatement(
											new CodeBinaryOperatorExpression(
												new CodeBinaryOperatorExpression(
													new CodePropertyReferenceExpression(
														new CodeVariableReferenceExpression(myXSDData),
														myXSDClassGenerating),
													CodeBinaryOperatorType.ValueEquality,
													new CodePrimitiveExpression(true)),
												CodeBinaryOperatorType.BooleanAnd,
												new CodeBinaryOperatorExpression(
													new CodePropertyReferenceExpression(
														new CodePropertyReferenceExpression(
															new CodeThisReferenceExpression(), mtbp.Name), before + m.Type.BaseType + after),
													CodeBinaryOperatorType.ValueEquality,
													new CodePrimitiveExpression(false))),
											new CodeMethodReturnStatement(new CodePrimitiveExpression(null)));
										m.GetStatements.Insert(0, ccs);
									}
								}

								// if array then create accessors
								if (CanConvertArray(parameters, m.Type, m) && settings.CreateArrayAccessors)
								{
									string isEx = "ex";
									string isLength = "Length";
									// get Size method (if null!=array ? return array.size : 0)
									string addenda = "Size";
									CodeMemberMethod cmm = new CodeMemberMethod();
									cmm.Attributes = MemberAttributes.Public | MemberAttributes.Final;
									cmm.Name = m.Name + addenda;
									cmm.ReturnType = new CodeTypeReference(typeof(int));
									CodeConditionStatement ccs = new CodeConditionStatement(
										new CodeBinaryOperatorExpression(
											new CodeFieldReferenceExpression(
												new CodeThisReferenceExpression(), mtbp.Name),
											CodeBinaryOperatorType.ValueEquality,
											new CodePrimitiveExpression(null)),
										new CodeStatement[] { new CodeMethodReturnStatement(new CodePrimitiveExpression(0)) },
										new CodeStatement[] { new CodeMethodReturnStatement(
											new CodePropertyReferenceExpression(
												new CodeFieldReferenceExpression(
													new CodeThisReferenceExpression(), mtbp.Name),
													isLength)) });
									cmm.Statements.Add(ccs);
									newCollection.Add(cmm);

									// get Item method (try	{return null != array ? array.Length - 1 >= index ? array[index] : default : default;}	catch (Exception) { return default; })
									addenda = "GetItem";
									string isIndex = "index";
									cmm = new CodeMemberMethod();
									cmm.Attributes = MemberAttributes.Public | MemberAttributes.Final;
									cmm.Name = m.Name + addenda;
									cmm.ReturnType = new CodeTypeReference(m.Type.BaseType);
									CodeParameterDeclarationExpression cpde = new CodeParameterDeclarationExpression(
										new CodeTypeReference(typeof(int)), isIndex);
									cmm.Parameters.Add(cpde);
									CodeTryCatchFinallyStatement ctcf = new CodeTryCatchFinallyStatement(
										new CodeStatement[]
											{ new CodeConditionStatement(
												new CodeBinaryOperatorExpression(
													new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), mtbp.Name),
													CodeBinaryOperatorType.ValueEquality,
													new CodeDefaultValueExpression(m.Type)),
												new CodeStatement[] { new CodeMethodReturnStatement(new CodeDefaultValueExpression(cmm.ReturnType)) },
												new CodeStatement[] {
													new CodeConditionStatement(
														new CodeBinaryOperatorExpression(
															new CodeBinaryOperatorExpression(
																new CodePropertyReferenceExpression(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), mtbp.Name), isLength),
																CodeBinaryOperatorType.Subtract,
																new CodePrimitiveExpression(1)),
															CodeBinaryOperatorType.GreaterThanOrEqual,
															//new CodePrimitiveExpression(parameter)),
															new CodeArgumentReferenceExpression(isIndex)),
														new CodeStatement[] { new CodeMethodReturnStatement(new CodeArrayIndexerExpression(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), mtbp.Name), new CodeArgumentReferenceExpression(isIndex))) },
														new CodeStatement[] { new CodeMethodReturnStatement(new CodeDefaultValueExpression(cmm.ReturnType)) }) }) },
										new CodeCatchClause[] { new CodeCatchClause(
											isEx,
											new CodeTypeReference(typeof(Exception)),
											new CodeStatement[] { new CodeMethodReturnStatement(new CodeDefaultValueExpression(cmm.ReturnType)) }) });
									cmm.Statements.Add(ctcf);
									newCollection.Add(cmm);

									// set Item method (try	{return null != array ? array.Length - 1 >= index ? array[index] : default : default;}	catch (Exception) { return default; })
									addenda = "SetItem";
									cmm = new CodeMemberMethod();
									cmm.Attributes = MemberAttributes.Public | MemberAttributes.Final;
									cmm.Name = m.Name + addenda;
									cmm.ReturnType = new CodeTypeReference(typeof(bool));
									cpde = new CodeParameterDeclarationExpression(
										new CodeTypeReference(typeof(int)), isIndex);
									cmm.Parameters.Add(cpde);
									string isValue = "value";
									cpde = new CodeParameterDeclarationExpression(
										new CodeTypeReference(m.Type.BaseType), isValue);
									cmm.Parameters.Add(cpde);
									ctcf = new CodeTryCatchFinallyStatement(
										new CodeStatement[]
											{ new CodeConditionStatement(
												new CodeBinaryOperatorExpression(
													new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), mtbp.Name),
													CodeBinaryOperatorType.ValueEquality,
													new CodeDefaultValueExpression(m.Type)),
												new CodeStatement[] { new CodeMethodReturnStatement(new CodePrimitiveExpression(false)) },
												new CodeStatement[] {
														new CodeAssignStatement(
															new CodeArrayIndexerExpression(
																new CodeFieldReferenceExpression(
																	new CodeThisReferenceExpression(), mtbp.Name),
																new CodeArgumentReferenceExpression(isIndex)),
															new CodeArgumentReferenceExpression(isValue)),
														new CodeMethodReturnStatement(new CodePrimitiveExpression(true))}) },
										new CodeCatchClause[] { new CodeCatchClause(
											isEx,
											new CodeTypeReference(typeof(Exception)),
											new CodeStatement[] { new CodeMethodReturnStatement(new CodePrimitiveExpression(false)) }) });
									cmm.Statements.Add(ctcf);
									newCollection.Add(cmm);

									// add Item method (try	{return null != array ? array.Length - 1 >= index ? array[index] : default : default;}	catch (Exception) { return default; })
									addenda = "AddItem";
									cmm = new CodeMemberMethod();
									cmm.Attributes = MemberAttributes.Public | MemberAttributes.Final;
									cmm.Name = m.Name + addenda;
									cmm.ReturnType = new CodeTypeReference(typeof(bool));
									cpde = new CodeParameterDeclarationExpression(
										new CodeTypeReference(m.Type.BaseType), isValue);
									cmm.Parameters.Add(cpde);
									string isArray = "array";
									string isCounter = "i";
									ctcf = new CodeTryCatchFinallyStatement(
										// try statement
										new CodeStatement[]
											{ new CodeConditionStatement(
												new CodeBinaryOperatorExpression(
													new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), mtbp.Name),
													CodeBinaryOperatorType.ValueEquality,
													new CodeDefaultValueExpression(m.Type)),
												new CodeStatement[] { new CodeMethodReturnStatement(new CodePrimitiveExpression(false)) },
												new CodeStatement[] {
													// declare a new array of the same type + 1 item
													new CodeVariableDeclarationStatement(
														//new CodeTypeReference(m.Type.BaseType),
														m.Type,
														isArray,
														new CodeArrayCreateExpression(
															new CodeTypeReference(m.Type.BaseType),
															new CodeBinaryOperatorExpression(
																new CodePropertyReferenceExpression(
																	new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), mtbp.Name),
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
																new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), mtbp.Name),
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
																	new CodeArgumentReferenceExpression(mtbp.Name),
																	new CodeArgumentReferenceExpression(isCounter))) }),
													// copy new value to the new array
													new CodeAssignStatement(
														new CodeArrayIndexerExpression(
															new CodeArgumentReferenceExpression(isArray),
															new CodeArgumentReferenceExpression(isCounter)),
														new CodeArgumentReferenceExpression(isValue)),
													// replace existing array by new array
													new CodeAssignStatement(
														new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), m.Name),
														new CodeArgumentReferenceExpression(isArray)),
													// return true
													new CodeMethodReturnStatement(new CodePrimitiveExpression(true)) }) },
										// catch statement
										new CodeCatchClause[] { new CodeCatchClause(
											isEx,
											new CodeTypeReference(typeof(Exception)),
											new CodeStatement[] { new CodeMethodReturnStatement(new CodePrimitiveExpression(false)) }) });
									cmm.Statements.Add(ctcf);
									newCollection.Add(cmm);

									// remove Item method 
									addenda = "RemoveItem";
									cmm = new CodeMemberMethod();
									cmm.Attributes = MemberAttributes.Public | MemberAttributes.Final;
									cmm.Name = m.Name + addenda;
									cmm.ReturnType = new CodeTypeReference(typeof(bool));
									cpde = new CodeParameterDeclarationExpression(
										new CodeTypeReference(typeof(int)), isIndex);
									cmm.Parameters.Add(cpde);
									ctcf = new CodeTryCatchFinallyStatement(
										// try statement
										new CodeStatement[]
											{ new CodeConditionStatement(
												new CodeBinaryOperatorExpression(
													new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), mtbp.Name),
													CodeBinaryOperatorType.ValueEquality,
													new CodeDefaultValueExpression(m.Type)),
												new CodeStatement[] { new CodeMethodReturnStatement(new CodePrimitiveExpression(false)) },
												new CodeStatement[]
													{
													new CodeConditionStatement(
														new CodeBinaryOperatorExpression(
															new CodePropertyReferenceExpression(new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), mtbp.Name), isLength),
															CodeBinaryOperatorType.LessThanOrEqual,
															new CodeArgumentReferenceExpression(isIndex)),
														new CodeStatement[] { new CodeMethodReturnStatement(new CodePrimitiveExpression(false)) },
														new CodeStatement[] {
															// declare a new array of the same type - 1 item
															new CodeVariableDeclarationStatement(
																//new CodeTypeReference(m.Type.BaseType),
																m.Type,
																isArray,
																new CodeArrayCreateExpression(
																	new CodeTypeReference(m.Type.BaseType),
																	new CodeBinaryOperatorExpression(
																		new CodePropertyReferenceExpression(
																			new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), mtbp.Name),
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
																			new CodeArgumentReferenceExpression(mtbp.Name),
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
																		new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), mtbp.Name),
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
																			new CodeArgumentReferenceExpression(mtbp.Name),
																			new CodeArgumentReferenceExpression(isCounter))) }),
															// replace existing array by new array
															new CodeAssignStatement(
																new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), m.Name),
																new CodeArgumentReferenceExpression(isArray)),
															// return true
															new CodeMethodReturnStatement(new CodePrimitiveExpression(true)) }) }) },
										// catch statement
										new CodeCatchClause[] { new CodeCatchClause(
											isEx,
											new CodeTypeReference(typeof(Exception)),
											new CodeStatement[] { new CodeMethodReturnStatement(new CodePrimitiveExpression(false)) }) });
									cmm.Statements.Add(ctcf);
									newCollection.Add(cmm);
								}
							}
						}

						// set the code to manage the init flag inside the type
						if (manageInitFlag)
						{
							// add init flag statements
							codeType.Members.Add(cmf);
							codeType.Members.Add(cmp);
						}

						if (0 != newCollection.Count)
						{
							codeType.Members.AddRange(newCollection);
						}
					}
					else if (visible && codeType.IsInterface)
					{
						if (settings.MakeClassComVisible)
						{
							AddInterfaceType(codeType.CustomAttributes);
						}
						AddComVisible(codeType.CustomAttributes, settings.MakeClassComVisible);
					}
					else if (visible && codeType.IsEnum)
						AddComVisible(codeType.CustomAttributes, settings.MakeEnumComVisible);
					else
						add = false;

					if (add && addInterface && settings.DeclareClassInterface)
					{
						// if a public class and COM declaration is requested
						CodeTypeDeclaration itf = new CodeTypeDeclaration() { Name = string.Format("I{0}", codeType.Name), IsInterface = true };
						AddGuid(itf.CustomAttributes);
						AddInterfaceType(itf.CustomAttributes);
						AddComVisible(itf.CustomAttributes, addInterface);
						codeType.BaseTypes.Add(new CodeTypeReference(itf.Name));
						int counter = 0;
						foreach (CodeTypeMember m in codeType.Members)
						{
							var itfM = CloneMember(m);
							itfM.CustomAttributes.Clear();
							if (settings.AddDispID)
								AddDispID(itfM.CustomAttributes, counter++);
							itf.Members.Add(itfM);
						}
						codeTypeDeclarations.Add(itf);
					}
				}
				// create a type with all tags and add it to the list of types
				CodeTypeDeclaration tagsType = new CodeTypeDeclaration("TagsEnumeration");
				AddComVisible(tagsType.CustomAttributes, settings.MakeEnumComVisible);
				tagsType.IsEnum = true;
				foreach (KeyValuePair<string, string> kv in tags)
				{
					CodeMemberField cm = new CodeMemberField("System.Int32", kv.Key);
					tagsType.Members.Add(cm);
				}
				codeTypeDeclarations.Add(tagsType);

				//// create a Decimal formatting attribute
				//CodeAttributeDeclaration decimalFormat = new CodeAttributeDeclaration("DecimalFormatterAttribute");
				//codeTypeDeclarations.Add(decimalFormat);

				if (settings.OptimizeStructs)
				{
					// add class controlling how XML is generated
					CodeTypeDeclaration ctd = new CodeTypeDeclaration(myXSDClassType);
					AddComVisible(ctd.CustomAttributes, false);
					ctd.IsClass = true;
					ctd.TypeAttributes = (ctd.TypeAttributes & ~TypeAttributes.VisibilityMask) | TypeAttributes.NestedAssembly;
					ctd.Comments.Add(new CodeCommentStatement("This class allows making empty objects invisible when generating XML"));
					CodeMemberField cmf1 = new CodeMemberField();
					cmf1.Name = myXSDClassGenerating;
					cmf1.Attributes = MemberAttributes.Public;
					cmf1.Type = new CodeTypeReference(typeof(bool));
					cmf1.InitExpression = new CodePrimitiveExpression(false);
					cmf1.Comments.Add(new CodeCommentStatement("True indicates XML generation is on, false otherwise"));
					ctd.Members.Add(cmf1);
					codeTypeDeclarations.Add(ctd);
				}

				// add all specific classes, enums,...
				CodeNamespace.Types.AddRange(codeTypeDeclarations.ToArray());
			}
			catch (Exception ex)
			{
				settings.Exception = ex.Message;
			}
		}
		/// <summary>
		/// Generate code in supported language
		/// </summary>
		/// <param name="settings">settings to use</param>
		/// <returns>Generated code or an empty string if an error has occurred</returns>
		public string GenerateCode(XSDSettings settings)
		{
			// verify language 
			if (CMisc.IsEnumValue(typeof(enumLanguage), settings.Language))
			{
				CodeDomProvider codeProvider = enumLanguage.csharp == settings.Language ? (CodeDomProvider)new CSharpCodeProvider() : (CodeDomProvider)new VBCodeProvider();
				using (var writer = new StringWriter())
				{
					codeProvider.GenerateCodeFromNamespace(CodeNamespace, writer, new CodeGeneratorOptions());
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
		private static void AddDecimalFormatter(CodeAttributeDeclarationCollection attrs, string formatter)
		{ attrs.Add(new CodeAttributeDeclaration(new CodeTypeReference("DecimalFormatter"), new CodeAttributeArgument(new CodePrimitiveExpression(formatter)))); }
		#endregion
	}
}
