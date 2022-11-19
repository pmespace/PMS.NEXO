Imports System
Imports System.Reflection
Imports System.Runtime.Remoting
Imports COMMON.WIN32
Imports COMMON
Imports NEXO

Public Class FBuilder
	Public O As NexoObject = Nothing
	Public MakeRequest As Boolean = True
	Public Target As String = Nothing
	Public NotTheTarget As String = Nothing
	Private nexoRequest As SaleToPOIRequest
	Private nexoReply As SaleToPOIResponse
	Private nexoItem As Object = Nothing
	Private contextCurrentParentNode As TreeNode
	Private contextCurrentNode As TreeNode
	Private contextCurrentValueNode As TreeNode
	Private fontN, fontB As Font

	Enum MyNodeAction
		Update
		Added
		Deleted
	End Enum

	Enum MyNodeType
		_none
		Tree
		Array
		ArrayType
		ArrayItem
		Leaf
		Type
		Value
	End Enum

	Class MyNode
		Public NodeType As MyNodeType
		Public Type As Type = Nothing
		Public TypeX As Type = Nothing
		Public Name As String = Nothing
		Public Value As Object = Nothing
		Public IsArray As Boolean = False
		Public PI As PropertyInfo = Nothing
		Public MI As List(Of MethodInfo) = Nothing
		Public ParentObject As Object
		Public ParentNode As TreeNode
		Public Leaves As Integer = 0
	End Class

	Private Const NODE_TYPE As String = "Type:"
	Private Const NODE_ITEM As String = "Item:"
	Private Const NODE_VALUE As String = "Value:"
	Private Const NODE_ARRAY_TYPE As String = "Type: array of"

	Protected Overrides Sub WndProc(ByRef m As Message)
		Select Case m.Msg
			Case Win32.WMUser
				Close()
		End Select
		MyBase.WndProc(m)
	End Sub

	Private Sub FBuilder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		fontN = New Font(TreeView1.Font, TreeView1.Font.Style)
		fontB = New Font(TreeView1.Font, TreeView1.Font.Style Or FontStyle.Bold)

		Dim s As String
		DialogResult = DialogResult.None
		nexoRequest = O.Request
		nexoReply = O.Reply
		Dim item As Object
		If MakeRequest Then
			nexoItem = nexoRequest
			item = nexoRequest.Item
			s = MessageTypeEnumeration.Request
		Else
			nexoItem = nexoReply
			item = nexoReply.Item
			s = MessageTypeEnumeration.Response
		End If

		If Not IsNothing(nexoItem) Then
			Text = $"Creating SaleToPOI{s} with {item.GetType}"
			TreeView1.Nodes.Add(New TreeNode($"{nexoItem.GetType().Name}") With {.ImageIndex = TreeView1.ImageList.Images.IndexOfKey("home"), .SelectedImageIndex = TreeView1.ImageList.Images.IndexOfKey("home")})
			AddToTree(nexoItem, TreeView1.TopNode)
			TreeView1.TopNode.Expand()
		Else
			MsgBox("Invalid object requested")
			Win32.PostMessage(Handle, Win32.WMUser, 0, 0)
		End If

	End Sub

	Private Sub AddToTree(o As Object, parentNode As TreeNode)
		If IsNothing(o) Then Return
		'list all properties inside the object
		Dim properties As List(Of PropertyInfo) = o.GetType().GetProperties().ToList()
		Dim methods As List(Of MethodInfo) = o.GetType().GetMethods().ToList()
		Dim myParentNode As MyNode = GetDetails(parentNode)
		For Each p As PropertyInfo In properties
			If MemberTypes.Property = p.MemberType _
				AndAlso p.PropertyType.IsPublic _
				AndAlso Not p.Name.StartsWith(NexoXSDStrings.XSD) _
				AndAlso Not p.Name.EndsWith(NexoXSDStrings.Specified) _
				AndAlso 0 <> String.Compare(p.Name, NexoXSDStrings.NexoHasBeenSetProperty) _
				AndAlso 0 <> String.Compare(p.Name, NexoXSDStrings.NexoClassName) _
				AndAlso 0 <> String.Compare(p.Name, NexoXSDStrings.NexoDefaultValueForProperty) _
				AndAlso 0 <> String.Compare(p.Name, NexoXSDStrings.NexoOptimizingProperty) _
				AndAlso p.CanWrite Then
				Dim value As Object = p.GetValue(o, Nothing)
				Dim valuetype As Type = p.PropertyType
				Dim target As Object = value
				If Not IsNothing(value) Then
					valuetype = value.GetType()
				End If
				'add the node
				Dim myNode As New MyNode() With {.TypeX = valuetype, .Type = Type.GetType(.TypeX.AssemblyQualifiedName.Replace("[]", "")), .Name = p.Name, .IsArray = valuetype.IsArray, .PI = p, .MI = methods, .ParentObject = o}
				Dim node As New TreeNode($"{myNode.Name}") With {.Tag = myNode}
				Dim i As Integer = parentNode.Nodes.Add(node)
				If "System" = myNode.Type.Namespace OrElse myNode.IsArray Then
					If myNode.IsArray Then
						myNode.NodeType = MyNodeType.Array
						node.SelectedImageIndex = TreeView1.ImageList.Images.IndexOfKey("array")
						node.ImageIndex = node.SelectedImageIndex
						node.Text = SetNodeText(node)
						'node = New TreeNode() With {.Tag = New MyNode() With {.NodeType = MyNodeType.ArrayType, .Type = myNode.Type}}
						'node.Text = SetNodeText(node)
						'parentNode.Nodes(i).Nodes.Add(node)
						Dim arr As Array = value
						If Not IsNothing(arr) Then
							For j As Integer = 0 To arr.Length - 1
								AddItem(node, arr(j))
							Next
						End If
					Else
						myNode.NodeType = MyNodeType.Leaf
						node.SelectedImageIndex = TreeView1.ImageList.Images.IndexOfKey("leaf")
						node.ImageIndex = node.SelectedImageIndex

						'*****
						'I really don't know why but sometimes this keeps giving an exception on first call, not on second one !
						'what createds the exception is the assignment, not the function call and node.Type actually is being assigned the value
						'I guess it is some kind of problem inside .NET because the node doesn't look right when displayed (the text is not completely displayed)
						Dim sz As String = SetNodeText(node)
						Try
							node.Text = sz
						Catch ex As Exception
							Try
								node.Text = sz
							Catch ex1 As Exception

							End Try
						End Try
						'*****

						'type node
						Dim myNewNode As New MyNode() With {.NodeType = MyNodeType.Type, .Type = myNode.Type}
						node = New TreeNode() With {.Tag = myNewNode}
						node.SelectedImageIndex = TreeView1.ImageList.Images.IndexOfKey("type")
						node.ImageIndex = node.SelectedImageIndex
						node.Text = SetNodeText(node)
						parentNode.Nodes(i).Nodes.Add(node)
						'value node
						myNewNode = New MyNode() With {.NodeType = MyNodeType.Value, .Value = value, .Type = myNode.Type, .PI = p, .ParentObject = o}
						node = New TreeNode() With {.Tag = myNewNode}
						node.SelectedImageIndex = TreeView1.ImageList.Images.IndexOfKey("value")
						node.ImageIndex = node.SelectedImageIndex
						node.Text = SetNodeText(node)
						parentNode.Nodes(i).Nodes.Add(node)
						SetNodeFont(node)
					End If
				Else
					myNode.NodeType = MyNodeType.Tree
					node.Text = SetNodeText(node)
					node.SelectedImageIndex = TreeView1.ImageList.Images.IndexOfKey("tree")
					node.ImageIndex = node.SelectedImageIndex
					AddToTree(target, node)
					SetNodeFont(node)
				End If
				'If "System" <> myNode.Type.Namespace AndAlso Not IsNothing(valuetype) Then
				'End If
			End If
		Next
	End Sub

	Private Sub SetNodeFont(node As TreeNode, Optional bold As Boolean = False)
		Dim myNode As MyNode = GetDetails(node)
		If Not IsNothing(myNode) Then
			Dim style As FontStyle = TreeView1.Font.Style
			Select Case myNode.NodeType
				Case MyNodeType.Value
					If Not IsNothing(myNode.Value) Then
						node.Parent.NodeFont = fontB
					Else
						node.Parent.NodeFont = Nothing
					End If
					node.Parent.Text = node.Parent.Text

				Case MyNodeType.Array
					If 1 < node.Nodes.Count Then
						node.NodeFont = fontB
					Else
						node.NodeFont = Nothing
					End If
					node.Text = node.Text
			End Select
		End If
	End Sub

	Private Function SetNodeText(node As TreeNode) As String
		If Not IsNothing(node.Tag) Then
			Dim myNode As MyNode = node.Tag
			Try

				If MyNodeType.Value = myNode.NodeType Then
					If (myNode.Value <> myNode.PI.GetValue(myNode.ParentObject)) Then
						myNode.PI.SetValue(myNode.ParentObject, myNode.Value)
					End If
					Return $"{NODE_VALUE} {myNode.Value}"

					'ElseIf MyNodeType.ArrayItem = myNode.NodeType Then
					'	Return $"{NODE_ITEM} {myNode.Value}"

				ElseIf MyNodeType.Type = myNode.NodeType Then
					Return $"{NODE_TYPE} {myNode.Type.Name}"

				ElseIf MyNodeType.ArrayType = myNode.NodeType Then
					Return $"{NODE_ARRAY_TYPE} {myNode.Type.Name}"

				ElseIf MyNodeType.Tree = myNode.NodeType OrElse MyNodeType.ArrayItem = myNode.NodeType Then
					Return $"{myNode.Name} (Structure)"

				ElseIf MyNodeType.Array = myNode.NodeType Then
					Return $"{myNode.Name} (Array)"

				ElseIf MyNodeType.Leaf = myNode.NodeType Then
					Return $"{myNode.Name} (Data)"

				Else
					Return $"{myNode.Name} (???)"
				End If

			Catch ex As Exception

			End Try

		End If
		Return Nothing
	End Function

	Private Sub Cancelling()
		DialogResult = DialogResult.Cancel
		Close()
	End Sub

	Private Sub pbCancel_Click(sender As Object, e As EventArgs) Handles pbCancel.Click
		Cancelling()
	End Sub

	Private Sub pbAccept_Click(sender As Object, e As EventArgs) Handles pbAccept.Click
		Dim ok As Boolean = True
		Dim captionToShow As String = Nothing
		Target = Nothing
		NotTheTarget = Nothing
		If ok Then
			'O.OptimizeXml = cbOptimize.Checked
			If MakeRequest Then
				If NexoRetailer.UseJson Then
					captionToShow = "JSON"
					Target = O.SerializedRequest
					NexoRetailer.UseJson = Not NexoRetailer.UseJson
					NotTheTarget = O.SerializedRequest
				Else
					captionToShow = "XML"
					Target = O.SerializedRequest
					NexoRetailer.UseJson = Not NexoRetailer.UseJson
					NotTheTarget = O.SerializedRequest
				End If
			Else
				If NexoRetailer.UseJson Then
					captionToShow = "JSON"
					Target = O.SerializedReply
					NexoRetailer.UseJson = Not NexoRetailer.UseJson
					NotTheTarget = O.SerializedReply
				Else
					captionToShow = "XML"
					Target = O.SerializedReply
					NexoRetailer.UseJson = Not NexoRetailer.UseJson
					NotTheTarget = O.SerializedReply
				End If
			End If
			NexoRetailer.UseJson = Not NexoRetailer.UseJson
		End If
		If Not IsNothing(Target) Then
			Select Case MsgBox($"Serialized {captionToShow}{vbCrLf}{vbCrLf}{Target}", MsgBoxStyle.YesNoCancel Or MsgBoxStyle.DefaultButton1)
				Case MsgBoxResult.Yes
					'copy xml to clipboard
					Try
						Clipboard.SetText(Target)
					Catch ex As Exception
					End Try
					Dim f As New FMessage() With {.Message = "The object has been saved to clipboard", .Duration = 1}
					f.ShowDialog()
					f.Dispose()
					DialogResult = DialogResult.Yes
					Close()
				Case MsgBoxResult.No
					DialogResult = DialogResult.No
					Close()
				Case MsgBoxResult.Cancel
			End Select
		Else
			MsgBox($"Serializing object has failed")
			DialogResult = DialogResult.No
			Close()
		End If
	End Sub

	Private Sub pbExpandAll_Click(sender As Object, e As EventArgs) Handles pbExpandAll.Click
		TreeView1.ExpandAll()
	End Sub

	Private Function GetDetails(node As TreeNode) As MyNode
		If Not IsNothing(node.Tag) And TypeOf node.Tag Is MyNode Then
			Return DirectCast(node.Tag, MyNode)
		End If
		Return Nothing
	End Function

	Private Function GetParentNode(node As TreeNode) As TreeNode
		'search the parent node containing information
		If Not IsNothing(node.Tag) Then
			Select Case DirectCast(node.Tag, MyNode).NodeType
				Case MyNodeType.Tree, MyNodeType.Array, MyNodeType.Leaf
					Return node
				Case MyNodeType.ArrayItem,
					  MyNodeType.Type,
					  MyNodeType.Value,
					  MyNodeType.ArrayType
					Return node.Parent
			End Select
		End If
		'no valid parent node (this must be the TopNode)
		Return Nothing
	End Function

	Private Function GetNodeOfType(node As TreeNode, type As MyNodeType, Optional index As Integer = 0) As TreeNode
		Dim i As Integer = 0
		For Each subNode As TreeNode In node.Nodes
			If type = GetNodeType(subNode) Then
				i += 1
				If i >= index Then
					Return subNode
				End If
			End If
		Next
		'no node of that type or index out of range
		Return Nothing
	End Function

	Private Function GetNodeType(node As TreeNode) As MyNodeType
		If Not IsNothing(node.Tag) Then
			If TypeOf node.Tag Is MyNode Then
				Return DirectCast(node.Tag, MyNode).NodeType
			End If
		End If
		Return MyNodeType._none
	End Function

	Private Sub TreeView1_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseDoubleClick
		'is it a value node
		If MyNodeType.Value = GetNodeType(e.Node) Then 'OrElse MyNodeType.ArrayItem = GetNodeType(e.Node) Then
			contextCurrentNode = e.Node
			contextCurrentValueNode = contextCurrentNode
			contextCurrentParentNode = GetParentNode(contextCurrentNode)
			StartEditNodeValue(contextCurrentNode)
		End If
	End Sub

	''' <summary>
	''' Set the current context based on a specified node
	''' Context is set through <see cref="contextCurrentNode"/>, <see cref="contextCurrentParentNode"/> and <see cref="contextCurrentValueNode"/>
	''' </summary>
	''' <param name="node">The currently selected or pointed node</param>
	Private Sub SetNodeContext(node As TreeNode)
		contextCurrentNode = node
		contextCurrentParentNode = GetParentNode(contextCurrentNode)
		Dim myNode As MyNode = contextCurrentNode.Tag
		If myNode.NodeType = MyNodeType.Leaf OrElse myNode.NodeType = MyNodeType.Type Then
			contextCurrentValueNode = GetNodeOfType(contextCurrentParentNode, MyNodeType.Value)
			'ElseIf myNode.NodeType = MyNodeType.Value OrElse myNode.NodeType = MyNodeType.ArrayItem Then
		ElseIf myNode.NodeType = MyNodeType.Value Then
			contextCurrentValueNode = contextCurrentNode
		Else
			contextCurrentValueNode = Nothing
		End If
	End Sub

	Private Sub TreeView1_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
		If Not IsNothing(e.Node.Tag) AndAlso MouseButtons.Right = e.Button AndAlso 1 = e.Clicks Then
			SetNodeContext(e.Node)
			Dim myNode As MyNode = contextCurrentNode.Tag
			TreeView1.SelectedNode = contextCurrentNode
			'hide unnecessary items inside the contextmenu
			SetValueToolStripMenuItem.Visible = Not IsNothing(contextCurrentValueNode)
			ResetvalueToolStripMenuItem.Visible = Not IsNothing(contextCurrentValueNode)
			Dim inArray As Boolean = myNode.NodeType = MyNodeType.Array _
				OrElse myNode.NodeType = MyNodeType.ArrayItem _
				OrElse myNode.NodeType = MyNodeType.ArrayType
			'_
			'	OrElse mynode.NodeType=MyNodeType.Tree AndAlso DirectCast(contextCurrentParentNode.Tag, MyNode).NodeType=mynode

			AddItemToolStripMenuItem.Visible = inArray
			RemoveItemToolStripMenuItem.Visible = myNode.NodeType = MyNodeType.ArrayItem
			InsertItemToolStripMenuItem.Visible = myNode.NodeType = MyNodeType.ArrayItem
			If Not IsNothing(contextCurrentValueNode) OrElse inArray Then
				ContextMenuStrip1.Show(TreeView1, New Point(e.X, e.Y), ToolStripDropDownDirection.Default)
			End If
		End If
	End Sub

	Private Sub StartEditNodeValue(node As TreeNode)
		Dim parent As TreeNode = GetParentNode(node)
		If Not IsNothing(parent) Then
			parent.Expand()
			TreeView1.SelectedNode = node
			node.Text = $"{DirectCast(node.Tag, MyNode).Value}"
			node.BeginEdit()
		End If
	End Sub

	Private Sub SetValueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetValueToolStripMenuItem.Click
		If Not IsNothing(contextCurrentValueNode) Then
			StartEditNodeValue(contextCurrentValueNode)
		End If
	End Sub

	Private Sub ResetvalueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetvalueToolStripMenuItem.Click
		If Not IsNothing(contextCurrentValueNode) Then
			Dim myNode As MyNode = contextCurrentValueNode.Tag
			If myNode.Type = GetType(String) Then
				myNode.Value = Nothing
			ElseIf myNode.Type = GetType(Integer) Then
				myNode.Value = 0
			ElseIf myNode.Type = GetType(Double) Then
				myNode.Value = 0
			ElseIf myNode.Type = GetType(Boolean) Then
				myNode.Value = False
			Else
				myNode.Value = Nothing
			End If
			'contextCurrentValueNode.Text = SetNodeText(contextCurrentValueNode)
			'SetNodeFont(contextCurrentValueNode)
			UpdateLabelAppearance(contextCurrentValueNode)
		End If
	End Sub

	Private Sub TreeView1_BeforeLabelEdit(sender As Object, e As NodeLabelEditEventArgs) Handles TreeView1.BeforeLabelEdit
		SetNodeContext(e.Node)
	End Sub

	Private Sub TreeView1_AfterLabelEdit(sender As Object, e As NodeLabelEditEventArgs) Handles TreeView1.AfterLabelEdit
		'If Not IsNothing(e.Label) Then
		'	Dim ok As Boolean = False
		'	SetNodeContext(e.Node)
		'	Dim myNode As MyNode = contextCurrentValueNode.Tag
		'	'editing a node has ended, test the value
		'	If GetType(String) = myNode.Type Then
		'		Dim x As New NexoTextString() With {.Value = e.Label}
		'		If e.Label = x.Value Then myNode.Value = x.Value
		'	ElseIf GetType(Integer) = myNode.Type Then
		'		Dim x As New NexoInteger() With {.Value = e.Label}
		'		If e.Label = x.Value Then myNode.Value = x.AsInteger
		'	ElseIf GetType(Double) = myNode.Type Then
		'		Dim x As New NexoDecimal() With {.Value = e.Label}
		'		If e.Label = x.Value Then myNode.Value = x.AsDecimal
		'	ElseIf GetType(Boolean) = myNode.Type Then
		'		Dim x As New NexoBoolean() With {.Value = e.Label}
		'		If e.Label = x.Value Then myNode.Value = x.AsBoolean
		'	End If
		'	e.CancelEdit = True
		'	e.Node.Text = SetNodeText(e.Node)
		'	SetNodeFont(e.Node)
		'End If
		'e.Node.Text = SetNodeText(e.Node)

		If Not IsNothing(e.Label) Then
			Dim ok As Boolean = False
			SetNodeContext(e.Node)
			Dim myNode As MyNode = contextCurrentValueNode.Tag
			'editing a node has ended, test the value
			If GetType(String) = myNode.Type Then
				Dim x As New NexoTextString() With {.Value = e.Label}
				If e.Label = x.Value Then myNode.Value = x.Value
			ElseIf GetType(Integer) = myNode.Type Then
				Dim x As New NexoInteger() With {.Value = e.Label}
				If e.Label = x.Value Then myNode.Value = x.AsInteger
			ElseIf GetType(Double) = myNode.Type Then
				Dim x As New NexoDecimal() With {.Value = e.Label}
				If e.Label = x.Value Then myNode.Value = x.AsDecimal
			ElseIf GetType(Boolean) = myNode.Type Then
				Dim x As New NexoBoolean() With {.Value = e.Label}
				If e.Label = x.Value Then myNode.Value = x.AsBoolean
			End If
			e.CancelEdit = True
			UpdateLabelAppearance(e.Node)
		End If
		e.Node.Text = SetNodeText(e.Node)
	End Sub

	Private Sub UpdateLabelAppearance(node As TreeNode)
		SetNodeFont(node)
		node.Text = SetNodeText(node)
	End Sub

	Private Sub AddItem(parent As TreeNode, Optional item As Object = Nothing, Optional contextCurrentNode As TreeNode = Nothing)
		'Dim details As MyNode = GetDetails(contextCurrentNode)
		Dim myParentNode As MyNode = GetDetails(parent)
		If Not IsNothing(myParentNode) Then
			'check whether a no parameter constructor exists
			Dim ci As ConstructorInfo = myParentNode.Type.GetConstructor(Type.EmptyTypes)
			Dim addIt As Boolean = False
			Dim o As Object
			'create a new object to analyse
			If IsNothing(ci) Then
				If GetType(Byte) = myParentNode.Type Then
					Dim x As Byte = 0
					If Not IsNothing(item) Then x = item
					o = x
				ElseIf GetType(Object) = myParentNode.Type Then
					Dim x As Object = Nothing
					If Not IsNothing(item) Then x = item
					o = x
				ElseIf GetType(String) = myParentNode.Type Then
					Dim x As String = Nothing
					If Not IsNothing(item) Then x = item
					o = x
				ElseIf GetType(Boolean) = myParentNode.Type Then
					Dim x As Boolean = False
					If Not IsNothing(item) Then x = item
					o = x
				ElseIf GetType(Integer) = myParentNode.Type Then
					Dim x As Integer = 0
					If Not IsNothing(item) Then x = item
					o = x
				ElseIf GetType(Double) = myParentNode.Type Then
					Dim x As Double = 0
					If Not IsNothing(item) Then x = item
					o = x
				Else
					If Not IsNothing(item) Then
						o = item
					Else
						o = Activator.CreateInstance(myParentNode.Type, New Object() {Nothing})
					End If
					addIt = True
				End If
			Else
				If Not IsNothing(item) Then
					o = item
				Else
					o = Activator.CreateInstance(myParentNode.Type)
				End If
				addIt = True
			End If

			If Not IsNothing(o) Then
				Dim ok As Boolean = False
				Dim methodName As String

				'determine the type of the node to add
				Dim myNode As New MyNode() With {.Type = myParentNode.Type, .Value = o}
				If addIt Then
					If myParentNode.NodeType = MyNodeType.Array Then
						myNode.NodeType = MyNodeType.ArrayItem
					Else
						myNode.NodeType = MyNodeType.Tree
					End If
					myNode.Name = DirectCast(parent.Tag, MyNode).Name
				Else
					myNode.NodeType = MyNodeType.ArrayItem
				End If
				Dim newNode As TreeNode = New TreeNode() With {.Tag = myNode}
				newNode.Text = SetNodeText(newNode)

				'add the item to the list of items
				myNode = GetDetails(parent)

				'is it an insert or an add operation
				Dim paramsToUse() As Object
				Dim isInserting As Boolean = Not IsNothing(contextCurrentNode)
				If isInserting Then
					methodName = $"{myNode.Name}{NexoXSDStrings.AccessorInsertItem}"
					ReDim paramsToUse(1)
					paramsToUse = {contextCurrentNode.Index, o}
				Else
					methodName = $"{myNode.Name}{NexoXSDStrings.AccessorAddItem}"
					ReDim paramsToUse(0)
					paramsToUse = {o}
				End If
				'search the method to add an item
				Dim myMethod As MethodInfo = Nothing
				For Each mi As MethodInfo In myNode.MI
					If mi.Name = methodName Then
						myMethod = mi
						Exit For
					End If
				Next
				Dim pos As Integer = -1
				If Not IsNothing(myMethod) Then
					'call the add item method
					Dim res = myMethod.Invoke(myNode.ParentObject, paramsToUse)
					If isInserting Then
						ok = -1 <> res
						pos = res
					Else
						ok = res
					End If
				Else
					ok = True
				End If

				'arrived here check whether the item has been added or not and add node it success
				If ok Then
					'add the node and add the array item to the nexo object
					If isInserting Then
						parent.Nodes.Insert(pos, newNode)
					Else
						parent.Nodes.Add(newNode)
					End If
					newNode.SelectedImageIndex = TreeView1.ImageList.Images.IndexOfKey("arrayitem")
					newNode.ImageIndex = newNode.SelectedImageIndex
					SetNodeFont(parent)
					If addIt Then
						AddToTree(o, newNode)
					End If
					parent.Expand()
				End If
			End If
		End If
	End Sub

	Private Sub AddItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddItemToolStripMenuItem.Click
		AddItem(contextCurrentParentNode)
	End Sub

	Private Sub RemoveItem(node As TreeNode, parent As TreeNode)
		'remove the item from the list of items
		Dim mynode As MyNode = GetDetails(parent)
		'search the method to add an item
		Dim methodName As String = $"{mynode.Name}RemoveItem"
		Dim removeMethod As MethodInfo = Nothing
		For Each mi As MethodInfo In mynode.MI
			If mi.Name = methodName Then
				removeMethod = mi
				Exit For
			End If
		Next
		Dim ok As Boolean = False
		If Not IsNothing(removeMethod) Then
			'call the add item method
			ok = removeMethod.Invoke(mynode.ParentObject, New Object() {contextCurrentNode.Index - 1})
		End If
		If ok Then
			SetNodeFont(parent)
			parent.Nodes.Remove(node)
		End If
	End Sub

	Private Sub RemoveItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveItemToolStripMenuItem.Click
		RemoveItem(contextCurrentNode, contextCurrentParentNode)
	End Sub

	Private Sub FBuilder_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
		If DialogResult.None = DialogResult Then DialogResult = DialogResult.Cancel
	End Sub

	Private Sub InsertItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertItemToolStripMenuItem.Click
		AddItem(contextCurrentParentNode, Nothing, contextCurrentNode)
	End Sub

End Class