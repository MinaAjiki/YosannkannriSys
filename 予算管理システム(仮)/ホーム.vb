Imports C1.Win.C1Command
Imports System.Data.SqlClient
Imports System.Deployment.Application
Imports System.IO.DirectoryInfo
Imports System.ComponentModel
Imports System.Deployment.Application.ApplicationDeployment
Imports System.Windows.Forms.Form

Public Class ホーム
    Public Connection As New SqlConnection 'サーバーへの接続
    Public ErrorMessage As String 'エラーメッセージ
    Public StackTrace As String 'スタクとレース
    Public SQL As New SqlCommand 'SQLコマンド
    Public systmcnnctn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & Application.StartupPath & "\予算管理システム(system_sql).mdf;Integrated Security=True")
    Public systemsql As New SqlCommand

    Private Sub ホーム_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        systmcnnctn.Open()
        systemsql.Connection = systmcnnctn
        Dim path As String = ""
        systemsql.CommandText = "SELECT MAX(updatedate),filepath FROM userfiles GROUP BY filepath"
        Dim filereader As SqlDataReader = systemsql.ExecuteReader
        While filereader.Read
            path = filereader.Item("filepath")
        End While
        filereader.Close()

        If path <> "" Then
            予算選択.Show()
        Else
            Me.Enabled = True
        End If

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

    Private Sub 締切処理_Click(sender As Object, e As ClickEventArgs) Handles 締切処理.Click
        締切日入力.Show()
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

        '出来高入力.TopLevel = False
        'FormPanel.Controls.Add(出来高入力)
        出来高入力.Show()
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

    Private Sub 材料表インポート_Click(sender As Object, e As ClickEventArgs) Handles 材料表インポート.Click
        進行状況.Show()
    End Sub

    Private Sub 予算内訳登録_Click(sender As Object, e As ClickEventArgs) Handles 予算内訳登録.Click
        大工種選択.TopLevel = False
        FormPanel.Controls.Add(大工種選択)
        大工種選択.Show()
    End Sub

    Private Sub 外注計画登録_Click(sender As Object, e As ClickEventArgs) Handles 外注計画登録.Click
        '外注内訳入力.TopLevel = False
        'FormPanel.Controls.Add(外注内訳入力)
        外注内訳入力.Show()
    End Sub

    Private Sub 代価表_Click(sender As Object, e As ClickEventArgs) Handles 代価表.Click
        印刷代価選択.Show()
    End Sub
End Class
