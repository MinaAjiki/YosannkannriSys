Public Class TreeNode_ParentExpand
    Public Function NodeExpand() As String

        NodeExpand = ""

        For nodeloop As Integer = 0 To ホーム.SelectNodeList.Count - 1

            ホーム.SelectNodeList(nodeloop).Expand()
            If nodeloop = ホーム.SelectNodeList.Count - 1 Then
                ホーム.SelectNodeList.RemoveAt(nodeloop)
            End If
        Next

        Return NodeExpand
    End Function

End Class
