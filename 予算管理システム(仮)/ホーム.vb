Imports C1.Win.C1Command
Imports System.Windows.Forms.Form

Public Class ホーム
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        予算選択.Show()

    End Sub

    Private Sub 開く_Click(sender As Object, e As ClickEventArgs) Handles 開く.Click
        DB選択.Show()
    End Sub

    Private Sub 参照作成_Click(sender As Object, e As ClickEventArgs) Handles 参照作成.Click
        Form参照作成.Show()
    End Sub

    Private Sub 管理者登録_Click(sender As Object, e As ClickEventArgs) Handles 管理者登録.Click
        管理者マスタ一覧.Show()
        Me.Enabled = False
    End Sub
End Class
