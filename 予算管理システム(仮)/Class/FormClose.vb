
Public Class FormClose
    Private FN As Form
    Public Sub New(ByVal OpenForm As Form)
        FN = OpenForm
    End Sub
    Public Function FormCheck() As String

        FormCheck = ""

        Dim closecount As Integer = ホーム.FormPanel.Controls.Count - 1
        For formloop As Integer = 0 To closecount
            Dim FormName As Form = ホーム.FormPanel.Controls.Item(formloop)

            If ホーム.FormPanel.Controls.Count > 0 AndAlso ホーム.Modified = "True" Then
                If MsgBox("変更した内容は登録されません。" & vbCrLf & "現在の画面を閉じますか？" _
                            , MsgBoxStyle.OkCancel, "予算管理システム(仮)") = MsgBoxResult.Ok Then
                    ホーム.Modified = "False"
                    closecount = closecount - 1
                    FormName.Close()
                    ホーム.FormPanel.Controls.RemoveAt(formloop)
                End If
                If formloop = closecount Then
                    Exit For
                End If
            Else
                FormName.Close()
                ホーム.FormPanel.Controls.Clear()
                Exit For
            End If

        Next

        Return FormCheck
    End Function

End Class
