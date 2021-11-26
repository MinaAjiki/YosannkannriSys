Public Class FormClose
    Private FormName As Form
    Public Sub New(ByVal OpenForm As Form)
        FormName = OpenForm
    End Sub
    Public Function FormCheck() As String

        FormCheck = ""

        If ホーム.FormPanel.Controls.Count > 0 AndAlso ホーム.Modified = "True" Then


            If MsgBox("変更した内容は登録されません。" & vbCrLf & "現在の画面を閉じますか？" _
                        , MsgBoxStyle.OkCancel, "予算管理システム(仮)") = MsgBoxResult.Ok Then
                FormName.Close()
            End If
        Else
            FormName.Close()

        End If

        Return FormCheck
    End Function

End Class
