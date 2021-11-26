Public Class CancelClick
    Private FormName As Form
    Public Sub New(ByVal OpenForm As Form)
        FormName = OpenForm
    End Sub
    Public Function ModifyCheck() As String

        ModifyCheck = ""

        If ホーム.Modified = "True" Then

            If MsgBox("変更した内容は登録されません。終了しますか？", MsgBoxStyle.OkCancel, "予算管理システム(仮)") = vbOK Then
                ホーム.Modified = "False"
                FormName.Close()
            End If
        Else
            FormName.Close()

        End If

        Return ModifyCheck
    End Function

End Class
