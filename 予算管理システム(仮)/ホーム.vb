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

    Private Sub 協力業者登録_Click(sender As Object, e As ClickEventArgs) Handles 協力業者登録.Click

        協力業者入力.Anchor = AnchorStyles.Top
        '協力業者入力.Anchor = AnchorStyles.Bottom
        協力業者入力.Anchor = AnchorStyles.Left
        '協力業者入力.Anchor = AnchorStyles.Right

        協力業者入力.TopLevel = False
        FormPanel.Controls.Add(協力業者入力)
        協力業者入力.Show()
    End Sub

    Private Sub 注文書番号入力_Click(sender As Object, e As ClickEventArgs) Handles 注文書番号登録.Click

        注文書番号入力.Anchor = AnchorStyles.Top
        '協力業者入力.Anchor = AnchorStyles.Bottom
        注文書番号入力.Anchor = AnchorStyles.Left
        '協力業者入力.Anchor = AnchorStyles.Right

        注文書番号入力.TopLevel = False
        FormPanel.Controls.Add(注文書番号入力)
        注文書番号入力.Show()
    End Sub

    Private Sub 出来高登録_Click(sender As Object, e As ClickEventArgs) Handles 出来高登録.Click

        業者選択_出来高.Anchor = AnchorStyles.Top
        '協力業者入力.Anchor = AnchorStyles.Bottom
        業者選択_出来高.Anchor = AnchorStyles.Left
        '協力業者入力.Anchor = AnchorStyles.Right

        業者選択_出来高.TopLevel = False
        FormPanel.Controls.Add(業者選択_出来高)
        業者選択_出来高.Show()
    End Sub

    Private Sub マスタ_Click(sender As Object, e As ClickEventArgs) Handles マスタ.Click
        マスタメンテナンス.Show()
    End Sub

    Private Sub 管理者登録_Click(sender As Object, e As ClickEventArgs) Handles 管理者登録.Click
        管理者マスタ一覧.Show()
    End Sub

    Private Sub 予算総括登録_Click(sender As Object, e As ClickEventArgs) Handles 予算総括登録.Click
        予算総括入力.TopLevel = False
        FormPanel.Controls.Add(予算総括入力)
        予算総括入力.Show()
    End Sub
End Class
