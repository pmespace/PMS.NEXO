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
	Private currentParentNode As TreeNode
	Private currentNode As TreeNode
	Private valueNode As TreeNode
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
			TreeView1.Nodes.Add(New TreeNode($"{nexoItem.GetType().Name}")) '[{T}]"))
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
			If MemberTypes.Property = p.MemberType AndAlso p.PropertyType.IsPublic AndAlso Not p.Name.StartsWith(NexoXSDStrings.XSD) Then
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
						node.Text = SetNodeText(node)
						node = New TreeNode() With {.Tag = New MyNode() With {.NodeType = MyNodeType.ArrayType, .Type = myNode.Type}}
						node.Text = SetNodeText(node)
						parentNode.Nodes(i).Nodes.Add(node)
						Dim arr As Array = value
						If Not IsNothing(arr) Then
							For j As Integer = 0 To arr.Length - 1
								AddItem(node.Parent, arr(j))
							Next
						End If
					Else
						myNode.NodeType = MyNodeType.Leaf

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
						node = New TreeNode() With {.Tag = New MyNode() With {.NodeType = MyNodeType.Type, .Type = myNode.Type}}
						node.Text = SetNodeText(node)
						parentNode.Nodes(i).Nodes.Add(node)
						'value node
						node = New TreeNode() With {.Tag = New MyNode() With {.NodeType = MyNodeType.Value, .Value = value, .Type = myNode.Type, .PI = p, .ParentObject = o}}
						node.Text = SetNodeText(node)
						parentNode.Nodes(i).Nodes.Add(node)
						SetNodeFont(node)
					End If
				Else
					myNode.NodeType = MyNodeType.Tree
					node.Text = SetNodeText(node)
					AddToTree(target, node)
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
						node.Parent.NodeFont = fontB 'New Font(TreeView1.Font, TreeView1.Font.Style Or FontStyle.Bold)
					Else
						node.Parent.NodeFont = Nothing
					End If

				Case MyNodeType.Array
					If 1 < node.Nodes.Count Then
						node.NodeFont = fontB 'New Font(TreeView1.Font, TreeView1.Font.Style Or FontStyle.Bold)
					Else
						node.NodeFont = Nothing
					End If
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

				ElseIf MyNodeType.ArrayItem = myNode.NodeType Then
					Return $"{NODE_ITEM} {myNode.Value}"

				ElseIf MyNodeType.Type = myNode.NodeType Then
					Return $"{NODE_TYPE} {myNode.Type.Name}"

				ElseIf MyNodeType.ArrayType = myNode.NodeType Then
					Return $"{NODE_ARRAY_TYPE} {myNode.Type.Name}"

				ElseIf MyNodeType.Tree = myNode.NodeType Then
					Return $"{myNode.Name} (Structure)"

				ElseIf MyNodeType.Array = myNode.NodeType Then
					Return $"{myNode.Name} (Array)"

				ElseIf MyNodeType.Leaf = myNode.NodeType Then
					Return $"{myNode.Name} (Data)"
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
				Case MyNodeType.ArrayItem, MyNodeType.ArrayType, MyNodeType.Type, MyNodeType.Value
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
		If MyNodeType.Value = GetNodeType(e.Node) OrElse MyNodeType.ArrayItem = GetNodeType(e.Node) Then
			currentNode = e.Node
			valueNode = currentNode
			currentParentNode = GetParentNode(currentNode)
			StartEditNodeValue(currentNode)
		End If
	End Sub

	Private Sub SetNodeContext(node As TreeNode)
		currentNode = node
		currentParentNode = GetParentNode(currentNode)
		Dim myNode As MyNode = currentNode.Tag
		If myNode.NodeType = MyNodeType.Leaf OrElse myNode.NodeType = MyNodeType.Type Then
			valueNode = GetNodeOfType(currentParentNode, MyNodeType.Value)
		ElseIf myNode.NodeType = MyNodeType.Value OrElse myNode.NodeType = MyNodeType.ArrayItem Then
			valueNode = currentNode
		Else
			valueNode = Nothing
		End If
	End Sub

	Private Sub TreeView1_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
		If Not IsNothing(e.Node.Tag) AndAlso MouseButtons.Right = e.Button AndAlso 1 = e.Clicks Then
			SetNodeContext(e.Node)
			Dim myNode As MyNode = currentNode.Tag
			TreeView1.SelectedNode = currentNode
			'hide unnecessary items inside the contextmenu
			SetValueToolStripMenuItem.Visible = Not IsNothing(valueNode)
			ResetvalueToolStripMenuItem.Visible = Not IsNothing(valueNode)
			Dim inArray As Boolean = myNode.NodeType = MyNodeType.Array OrElse myNode.NodeType = MyNodeType.ArrayType OrElse myNode.NodeType = MyNodeType.ArrayItem
			AddItemToolStripMenuItem.Visible = inArray
			RemoveItemToolStripMenuItem.Visible = myNode.NodeType = MyNodeType.ArrayItem
			If Not IsNothing(valueNode) OrElse inArray Then
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
		If Not IsNothing(valueNode) Then
			StartEditNodeValue(valueNode)
		End If
	End Sub

	Private Sub ResetvalueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetvalueToolStripMenuItem.Click
		If Not IsNothing(valueNode) Then
			Dim myNode As MyNode = valueNode.Tag
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
			'valueNode.Text = SetNodeText(valueNode)
			'SetNodeFont(valueNode)
			UpdateLabelAppearance(valueNode)
		End If
	End Sub

	Private Sub TreeView1_BeforeLabelEdit(sender As Object, e As NodeLabelEditEventArgs) Handles TreeView1.BeforeLabelEdit
		SetNodeContext(e.Node)
	End Sub

	Private Sub TreeView1_AfterLabelEdit(sender As Object, e As NodeLabelEditEventArgs) Handles TreeView1.AfterLabelEdit
		'If Not IsNothing(e.Label) Then
		'	Dim ok As Boolean = False
		'	SetNodeContext(e.Node)
		'	Dim myNode As MyNode = valueNode.Tag
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
			Dim myNode As MyNode = valueNode.Tag
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
		node.Text = SetNodeText(node)
		SetNodeFont(node)
	End Sub

	Private Sub AddItem(parent As TreeNode, Optional item As Object = Nothing, Optional currentNode As TreeNode = Nothing)
		'Dim details As MyNode = GetDetails(currentNode)
		Dim myNode As MyNode = GetDetails(parent)
		If Not IsNothing(myNode) Then
			'check whether a no parameter constructor exists
			Dim ci As ConstructorInfo = myNode.Type.GetConstructor(Type.EmptyTypes)
			Dim addIt As Boolean = False
			Dim o As Object
			'create a new object to analyse
			If IsNothing(ci) Then
				If GetType(Byte) = myNode.Type Then
					Dim x As Byte = 0
					If Not IsNothing(item) Then x = item
					o = x
				ElseIf GetType(Object) = myNode.Type Then
					Dim x As Object = Nothing
					If Not IsNothing(item) Then x = item
					o = x
				ElseIf GetType(String) = myNode.Type Then
					Dim x As String = Nothing
					If Not IsNothing(item) Then x = item
					o = x
				ElseIf GetType(Boolean) = myNode.Type Then
					Dim x As Boolean = False
					If Not IsNothing(item) Then x = item
					o = x
				ElseIf GetType(Integer) = myNode.Type Then
					Dim x As Integer = 0
					If Not IsNothing(item) Then x = item
					o = x
				ElseIf GetType(Double) = myNode.Type Then
					Dim x As Double = 0
					If Not IsNothing(item) Then x = item
					o = x
				Else
					If Not IsNothing(item) Then
						o = item
					Else
						o = Activator.CreateInstance(myNode.Type, New Object() {Nothing})
					End If
					addIt = True
				End If
			Else
				If Not IsNothing(item) Then
					o = item
				Else
					o = Activator.CreateInstance(myNode.Type)
				End If
				addIt = True
			End If

			'determine the type of the node to add
			myNode = New MyNode() With {.Type = myNode.Type, .Value = o}
			If addIt Then
				myNode.NodeType = MyNodeType.Tree
				myNode.Name = DirectCast(parent.Tag, MyNode).Name
			Else
				myNode.NodeType = MyNodeType.ArrayItem
			End If
			Dim newNode As TreeNode = New TreeNode() With {.Tag = myNode}
			newNode.Text = SetNodeText(newNode)

			Dim ok As Boolean = False
			If Not IsNothing(item) Then
				'add the item to the list of items
				myNode = GetDetails(parent)

				'is it an insert or an add operation
				Dim methodName As String = $"{myNode.Name}AddItem"
				Dim paramsToUse() As Object
				If Not IsNothing(currentNode) Then
					methodName = $"{myNode.Name}InsertItem"
					ReDim paramsToUse(1)
					paramsToUse = {currentNode.Index, o}
				Else
					methodName = $"{myNode.Name}AddItem"
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
				If Not IsNothing(myMethod) Then
					'call the add item method
					Dim res = myMethod.Invoke(myNode.ParentObject, paramsToUse)
					If Not IsNothing(currentNode) Then
						ok = -1 <> res
					Else
						ok = res
					End If
				Else
					ok = True
				End If
			End If

			'arrived here check whether the item has been added or not and add node it success
			If ok Then
				'add the node and add the array item to the nexo object
				parent.Nodes.Add(newNode)
				SetNodeFont(parent)
				If addIt Then
					AddToTree(o, newNode)
				End If
			End If
		End If
	End Sub

	Private Sub AddItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddItemToolStripMenuItem.Click
		AddItem(currentParentNode)
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
			ok = removeMethod.Invoke(mynode.ParentObject, New Object() {currentNode.Index - 1})
		End If
		If ok Then
			parent.Nodes.Remove(node)
			SetNodeFont(parent)
		End If
	End Sub

	Private Sub RemoveItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveItemToolStripMenuItem.Click
		RemoveItem(currentNode, currentParentNode)
	End Sub

	Private Sub FBuilder_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
		If DialogResult.None = DialogResult Then DialogResult = DialogResult.Cancel
	End Sub

	Private Sub InsertItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertItemToolStripMenuItem.Click
		'AddItem(currentParentNode, Nothing, currentNode)
	End Sub

End Class