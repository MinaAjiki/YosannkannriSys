Imports C1.Win.TreeView
Public Class TreeNode_ChildExpand
    Private selectnode As C1TreeNode
    Private selectname As String
    Public Sub New(ByVal node As C1.Win.TreeView.C1TreeNode, ByVal name As String)
        selectnode = node
        selectname = name
    End Sub
    Public Function NodeExpand() As String

        NodeExpand = ""

        For nodeloop As Integer = 0 To selectnode.Nodes.Count - 1

            Dim value As String = selectnode.Nodes(nodeloop).GetValue

            If value.Contains(selectname) = True Then
                ホーム.SelectNodeList.Add(selectnode.Nodes(nodeloop))
                Dim maxindex As Integer = ホーム.SelectNodeList.Count - 1
                ホーム.SelectNodeList(maxindex).Expand()
                Exit For
            End If
        Next

        Return NodeExpand
    End Function

End Class
