Imports C1.Win.C1Command
Imports System.Data.SqlClient
Imports System.Deployment.Application
Imports System.IO.DirectoryInfo
Imports System.ComponentModel
Imports System.Deployment.Application.ApplicationDeployment
Imports System.Windows.Forms.Form

Public Class ホーム

    Public ErrorMessage As String 'エラーメッセージ
    Public StackTrace As String 'スタクとレース
    Public SystmCnnctn As New SqlConnection
    Public SystemSql As New SqlCommand
    Public UserDataName As String = ""
    Public UserDataPath As String = ""
    Public Connection As New SqlConnection 'サーバーへの接続
    Public Sql As New SqlCommand 'SQLコマンド



    Private Sub ホーム_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try


        If System.IO.File.Exists("D:\予算管理システム\system\予算管理システム(system_sql).mdf") = True Then



            SystmCnnctn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\予算管理システム\system\予算管理システム(system_sql).mdf;Integrated Security=True"
            SystmCnnctn.Open()

            SystemSql.Connection = SystmCnnctn
            SystemSql.CommandText = "SELECT TOP 1 * FROM userfiles ORDER BY filedate DESC"
            Dim FileReader As SqlDataReader = SystemSql.ExecuteReader
            While FileReader.Read
                UserDataName = FileReader.Item("filename")
                UserDataPath = FileReader.Item("filepath")
            End While
            FileReader.Close()

            If UserDataName <> "" Then

                Connection.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & UserDataPath & UserDataName & ";Integrated Security=True"
                Connection.Open()
                Sql.Connection = Connection


                Sql.CommandText = "SELECT Count(cntrct_no) FROM budget_summary"
                Dim DataCount As Integer = Sql.ExecuteScalar

                If DataCount >= 1 Then
                    予算選択.Show()

                Else
                    Me.Enabled = True
                    Me.Text = "予算管理システム　(" & UserDataPath & UserDataName & ")"

                End If

            Else

                Me.Enabled = True
                予算.Enabled = False
                見積.Enabled = False
                外注管理.Enabled = False
                出力.Enabled = False
                マスタ.Enabled = False

            End If
        Else

            Me.Enabled = True
            予算.Enabled = False
            見積.Enabled = False
            外注管理.Enabled = False
            出力.Enabled = False
            マスタ.Enabled = False
        End If

        'Catch ex As Exception
        '    ErrorMessage = ex.Message
        '    StackTrace = ex.StackTrace
        '    エラー.Show()
        '    Exit Sub
        'End Try


    End Sub

    Private Sub 開く_Click(sender As Object, e As ClickEventArgs) Handles 開く.Click
        DB選択.Show()
    End Sub

    Private Sub 参照作成_Click(sender As Object, e As ClickEventArgs) Handles 参照作成.Click
        Form参照作成.Show()
    End Sub

    Private Sub 協力業者登録_Click(sender As Object, e As ClickEventArgs) Handles 協力業者登録.Click

        Try
            協力業者入力.Anchor = AnchorStyles.Top
            '協力業者入力.Anchor = AnchorStyles.Bottom
            協力業者入力.Anchor = AnchorStyles.Left
            '協力業者入力.Anchor = AnchorStyles.Right

            協力業者入力.TopLevel = False
            FormPanel.Controls.Add(協力業者入力)
            協力業者入力.Show()
        Catch ex As Exception
            ErrorMessage = ex.Message
            StackTrace = ex.StackTrace
            エラー.Show()
        Exit Sub
        End Try
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

    Private Sub 新規作成_Click(sender As Object, e As ClickEventArgs) Handles 新規作成.Click
        If MsgBox("新しい現場データファイルを作成します。", MsgBoxStyle.OkCancel, "新規作成") = MsgBoxResult.Ok Then
            CreateFileDialog.ShowDialog()
        End If
    End Sub

    Private Sub CreateFileDialog_FileOk(sender As Object, e As CancelEventArgs) Handles CreateFileDialog.FileOk


        System.IO.Directory.CreateDirectory("D:\予算管理システム\system")
        System.IO.File.Copy(Application.StartupPath & "\予算管理システム(system_sql).mdf", "D:\予算管理システム\system\予算管理システム(system_sql).mdf")
        System.IO.File.Copy(Application.StartupPath & "\現場データ.mdf", CreateFileDialog.FileName)


        Dim FilePath As String = IO.Path.GetDirectoryName(CreateFileDialog.FileName)
        Dim FileName As String = IO.Path.GetFileName(CreateFileDialog.FileName)


        SystmCnnctn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\予算管理システム\system\予算管理システム(system_sql).mdf;Integrated Security=True"
        SystmCnnctn.Open()
        SystemSql.Connection = SystmCnnctn
        SystemSql.CommandText = "INSERT INTO userfiles (filename,filepath,filedate) VALUES (@filename,@filepath,@filedate)"
        SystemSql.Parameters.Add(New SqlParameter("@filename", SqlDbType.NVarChar))
        SystemSql.Parameters.Add(New SqlParameter("@filepath", SqlDbType.NVarChar))
        SystemSql.Parameters.Add(New SqlParameter("@filedate", SqlDbType.Date))
        SystemSql.Parameters("@filename").Value = FileName
        SystemSql.Parameters("@filepath").Value = FilePath
        SystemSql.Parameters("@filedate").Value = Today

        SystemSql.ExecuteNonQuery()

        MsgBox("作成完了" & vbCrLf & vbCrLf & CreateFileDialog.FileName, MsgBoxStyle.Information, "新規作成")

        Connection.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & CreateFileDialog.FileName & ";Integrated Security=True"
        Connection.Open()
        Sql.Connection = Connection
        Me.Text = "予算管理システム　(" & CreateFileDialog.FileName & ")"

        予算.Enabled = True
        見積.Enabled = True
        外注管理.Enabled = True
        出力.Enabled = True
        マスタ.Enabled = True

    End Sub
End Class
