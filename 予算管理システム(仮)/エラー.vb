Public Class エラー
    Private Sub エラー_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If ホーム.ErrorMessage.Contains("タイムアウト") = True Then
            'エラーメッセージに｢タイムアウト｣が含まれている場合
            'メッセージを表示し、この画面を閉じ、システムを再起動する
            MsgBox("タイムアウトが発生しました。" & vbCrLf & "システムを再起動します。", MsgBoxStyle.OkOnly, "エラー")
            Me.Close()
            Application.Restart()
        End If



        'エラーメッセージとスタックトレースを表示する
        ErrorMessage.Text = ホーム.ErrorMessage
        StackTrace.Text = ホーム.StackTrace

    End Sub
End Class