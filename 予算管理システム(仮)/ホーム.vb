Imports C1.Win.C1Command
Imports System.Data.SqlClient
Imports System.Deployment.Application
Imports System.IO.DirectoryInfo
Imports System.ComponentModel
Imports System.Deployment.Application.ApplicationDeployment
Imports System.Windows.Forms.Form
Imports System.Data.Odbc
Imports C1.Win.C1FlexGrid

Public Class ホーム

    Public ErrorMessage As String                                       'エラーメッセージ
    Public StackTrace As String                                       　 'スタックトレース
    Public SystmMdfCnnctn As New SqlConnection                          'system_mdf
    Public SystemMdf As New SqlCommand                                  'system_mdf
    Public SystemSqlCnnctn As New SqlConnection(My.Settings.SystemSql)  'system_sql
    Public SystemSql As New SqlCommand                                  'system_sql
    Public UserDataName As String = ""
    Public UserDataPath As String = ""
    Public Connection As New SqlConnection                              'user_mdf
    Public Sql As New SqlCommand                                        'user_mdf
    Public Transaction As SqlTransaction
    Public BudgetNo As Integer                                          '作成予算回数
    Public AutoCmpCllctn As New AutoCompleteStringCollection
    'Public CAP21Connection As New OdbcConnection(My.Settings.CAP21_ODBC) 'CAP21ODBC接続
    'Public CAP21CommandText As New OdbcCommand                           'CAP21ODBC接続
    Public Modified As String = "False"                                    'データ修正判断
    Public lworktypecode As Integer
    Public lworktypename As String
    Public sworktypecode As Integer
    Public sworktypename As String
    Public ProjectCostForm As New List(Of Form)
    Public ProjectCostSelectRow As New List(Of Integer)
    Public ProjectCostID As New List(Of Integer)
    Public PrjctCstClassCode As New List(Of Integer)
    Public PrjctCstList As New List(Of C1FlexGrid)
    Public ExpnsbdID As Integer
    Public ExpnsbdCode As Integer
    Public ExpnsbdName As String
    Public ReportPath As String
    Public Report As String


    Private Sub ホーム_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            SystemSqlCnnctn.Open()
            SystemSql.Connection = SystemSqlCnnctn

            If System.IO.File.Exists("C:\PMS\system.mdf") = True Then



                SystmMdfCnnctn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\PMS\system.mdf;Integrated Security=True"
                SystmMdfCnnctn.Open()

                SystemMdf.Connection = SystmMdfCnnctn
                SystemMdf.CommandText = "SELECT TOP 1 * FROM userfiles ORDER BY filedate DESC"
                Dim FileReader As SqlDataReader = SystemMdf.ExecuteReader
                While FileReader.Read
                    UserDataName = FileReader.Item("filename")
                    UserDataPath = FileReader.Item("filepath")
                End While
                FileReader.Close()

                If UserDataName <> "" Then

                    Connection.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & UserDataPath & UserDataName & ";Integrated Security=True"
                    Connection.Open()
                    Sql.Connection = Connection


                    Sql.CommandText = "SELECT Count(budget_no) FROM budget_summary"
                    Dim DataCount As Integer = Sql.ExecuteScalar

                    If DataCount >= 1 Then

                        予算選択.Show()

                    Else
                        Me.Enabled = True
                        Me.Text = "予算管理システム　(" & UserDataPath & UserDataName & ")"
                        BudgetNo = 0

                        見積.Enabled = False
                        外注管理.Enabled = False

                    End If

                    SystemSql.CommandText = "SELECT NAME FROM M_TANT_ALL WHERE NON_SEARCH=0"
                        Dim M_TANTReader As SqlDataReader = SystemSql.ExecuteReader
                        While M_TANTReader.Read
                            AutoCmpCllctn.Add(M_TANTReader.Item("NAME"))
                        End While
                    M_TANTReader.Close()

                    'レポートのデザインが格納されているファイルのパスを変数に代入する
                    ReportPath = Application.StartupPath & "\予算管理システムレポート.flxr"

                Else


                        Me.Enabled = True
                    予算.Enabled = False
                    見積.Enabled = False
                    外注管理.Enabled = False
                    出力.Enabled = False
                    マスタ.Enabled = False
                    開く.Enabled = False
                    材料表インポート.Enabled = False
                    参照作成.Enabled = False
                End If
            Else

                Me.Enabled = True
                予算.Enabled = False
                見積.Enabled = False
                外注管理.Enabled = False
                出力.Enabled = False
                マスタ.Enabled = False
                開く.Enabled = False
                材料表インポート.Enabled = False
                参照作成.Enabled = False
            End If

        Catch ex As Exception
            ErrorMessage = ex.Message
            StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try


    End Sub

    Private Sub 開く_Click(sender As Object, e As ClickEventArgs) Handles 開く.Click
        If FormPanel.Controls.Count > 0 Then
            Dim FormClose As String = ""

            Dim FormCloseLoad As New FormClose(FormPanel.Controls.Item(0))
            FormClose = FormCloseLoad.FormCheck
        End If
        DB選択.Show()
    End Sub

    Private Sub 参照作成_Click(sender As Object, e As ClickEventArgs) Handles 参照作成.Click
        Form参照作成.Show()
    End Sub

    Private Sub 協力業者登録_Click(sender As Object, e As ClickEventArgs) Handles 協力業者登録.Click

        Try
            If FormPanel.Controls.Count > 0 Then
                Dim FormClose As String = ""

                Dim FormCloseLoad As New FormClose(FormPanel.Controls.Item(0))
                FormClose = FormCloseLoad.FormCheck
            End If

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

        If FormPanel.Controls.Count > 0 Then
            Dim FormClose As String = ""

            Dim FormCloseLoad As New FormClose(FormPanel.Controls.Item(0))
            FormClose = FormCloseLoad.FormCheck
        End If

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
        Try
            If FormPanel.Controls.Count > 0 Then
            Dim FormClose As String = ""

            Dim FormCloseLoad As New FormClose(FormPanel.Controls.Item(0))
            FormClose = FormCloseLoad.FormCheck
        End If

        予算総括入力.TopLevel = False
        FormPanel.Controls.Add(予算総括入力)
        予算総括入力.Show()


        Catch ex As Exception
            ErrorMessage = ex.Message
            StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub 材料表インポート_Click(sender As Object, e As ClickEventArgs) Handles 材料表インポート.Click

        ImportFileDialog.ShowDialog()

    End Sub

    Private Sub 予算内訳登録_Click(sender As Object, e As ClickEventArgs) Handles 予算内訳登録.Click
        Try
            If FormPanel.Controls.Count > 0 Then
            Dim FormClose As String = ""

            Dim FormCloseLoad As New FormClose(FormPanel.Controls.Item(0))
            FormClose = FormCloseLoad.FormCheck
        End If

            大工種選択.TopLevel = False
            FormPanel.Controls.Add(大工種選択)
            大工種選択.Show()

        Catch ex As Exception
            ErrorMessage = ex.Message
            StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub 外注計画登録_Click(sender As Object, e As ClickEventArgs) Handles 外注計画登録.Click
        '外注内訳入力.TopLevel = False
        'FormPanel.Controls.Add(外注内訳入力)
        '外注内訳入力.BackgroundWorker1.RunWorkerAsync()
        外注内訳入力.Show()
    End Sub

    Private Sub 代価表_Click(sender As Object, e As ClickEventArgs) Handles 代価表.Click
        印刷代価選択.Show()
    End Sub

    Private Sub 新規作成_Click(sender As Object, e As ClickEventArgs) Handles 新規作成.Click

        If FormPanel.Controls.Count > 0 Then
            Dim FormClose As String = ""

            Dim FormCloseLoad As New FormClose(FormPanel.Controls.Item(0))
            FormClose = FormCloseLoad.FormCheck
        End If

        If MsgBox("新しい現場データファイルを作成します。", MsgBoxStyle.OkCancel, "新規作成") = MsgBoxResult.Ok Then
            CreateFileDialog.ShowDialog()
        End If
    End Sub

    Private Sub CreateFileDialog_FileOk(sender As Object, e As CancelEventArgs) Handles CreateFileDialog.FileOk
        Try
            If System.IO.File.Exists("C:\PMS\system.mdf") = False Then
                SystmMdfCnnctn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\PMS\system.mdf;Integrated Security=True"
                SystmMdfCnnctn.Open()
            End If

            If System.IO.File.Exists(CreateFileDialog.FileName) = False Then

                System.IO.File.Copy("C:\PMS\user.mdf", CreateFileDialog.FileName)
            Else
                MsgBox("この名前のファイルは既に存在します。" & vbCrLf & "作成できません。", MsgBoxStyle.Exclamation, "新規作成")
                Exit Sub
            End If

            Dim FilePath As String = IO.Path.GetDirectoryName(CreateFileDialog.FileName)
            If Not FilePath.Last = "\" Then
                FilePath = FilePath & "\"
            End If

            Dim FileName As String = IO.Path.GetFileName(CreateFileDialog.FileName)

            If Connection.State = ConnectionState.Open Then
                Connection.Close()
            End If
            Connection.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & CreateFileDialog.FileName & ";Integrated Security=True"
            Connection.Open()
            Sql.Connection = Connection

            Transaction = Connection.BeginTransaction

            Sql.Transaction = Transaction

            Sql.Parameters.Clear()
            Sql.CommandText = ""

            Sql.CommandText = "SELECT cstclss_code,cstmstr_category,cstmstr_code,cstmstr_name,cstmstr_spec,cstmstr_unit,cstmstr_costea,changecode,cstmstr_seq INTO cost_masters FROM [SVACD001].[PMS].[dbo].[cost_masters]"
            Sql.ExecuteNonQuery()

            Sql.CommandText = "ALTER TABLE cost_masters ADD cstmstr_id smallint IDENTITY(1,1)"
            Sql.ExecuteNonQuery()

            Sql.CommandText = "ALTER TABLE cost_masters ADD CONSTRAINT PK_cost_masters PRIMARY KEY (cstmstr_id)"
            Sql.ExecuteNonQuery()

            Sql.CommandText = "SELECT * INTO cost_classes FROM [SVACD001].[PMS].[dbo].[cost_classes]"
            Sql.ExecuteNonQuery()

            Sql.CommandText = "ALTER TABLE cost_classes ADD CONSTRAINT PK_cost_classes PRIMARY KEY (cstclss_code)"
            Sql.ExecuteNonQuery()

            Sql.CommandText = "SELECT stexpns_code,stexpns_name INTO #site_expenses FROM [SVACD001].[PMS].[dbo].[site_expenses]"
            Sql.ExecuteNonQuery()

            Sql.CommandText = "ALTER TABLE #site_expenses ADD budget_no smallint,stexpns_amount money"
            Sql.ExecuteNonQuery()

            Sql.CommandText = "UPDATE #site_expenses SET budget_no=0,stexpns_amount=0"
            Sql.ExecuteNonQuery()

            Sql.CommandText = "INSERT INTO site_expenses SELECT budget_no,stexpns_code,stexpns_name,stexpns_amount FROM #site_expenses"
            Sql.ExecuteNonQuery()

            Sql.CommandText = "SELECT stexpns_id,expns_bd_no,expns_bd_name,expns_bd_spec,expns_bd_unit,expns_bd_costea INTO #expense_bd FROM [SVACD001].[PMS].[dbo].[expense_breakdowns]"
            Sql.ExecuteNonQuery()

            Sql.CommandText = "ALTER TABLE #expense_bd ADD expns_bd_quanity decimal(15,2)"
            Sql.ExecuteNonQuery()

            Sql.CommandText = "UPDATE #expense_bd SET expns_bd_quanity=0"
            Sql.ExecuteNonQuery()

            Sql.CommandText = "INSERT INTO expense_breakdowns SELECT stexpns_id,expns_bd_no,expns_bd_name,expns_bd_spec,expns_bd_unit,expns_bd_quanity,expns_bd_costea FROM #expense_bd"
            Sql.ExecuteNonQuery()

            Transaction.Commit()

            SystemMdf.Connection = SystmMdfCnnctn
            SystemMdf.CommandText = "INSERT INTO userfiles (filename,filepath,filedate) VALUES (@filename,@filepath,@filedate)"
            SystemMdf.Parameters.Add(New SqlParameter("@filename", SqlDbType.NVarChar))
            SystemMdf.Parameters.Add(New SqlParameter("@filepath", SqlDbType.NVarChar))
            SystemMdf.Parameters.Add(New SqlParameter("@filedate", SqlDbType.Date))
            SystemMdf.Parameters("@filename").Value = FileName
            SystemMdf.Parameters("@filepath").Value = FilePath
            SystemMdf.Parameters("@filedate").Value = Today
            SystemMdf.ExecuteNonQuery()

            Me.Text = "予算管理システム　(" & CreateFileDialog.FileName & ")"

            MsgBox("作成完了" & vbCrLf & vbCrLf & CreateFileDialog.FileName, MsgBoxStyle.Information, "新規作成")


            予算.Enabled = True
            マスタ.Enabled = True
            開く.Enabled = True
            材料表インポート.Enabled = True
            参照作成.Enabled = True

            SystemMdf.Parameters.Clear()


        Catch ex As Exception
            ErrorMessage = ex.Message
            StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try

    End Sub

    Private Sub ホーム_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            If Connection.State = ConnectionState.Open Then
            Connection.Close()
        End If
        If SystmMdfCnnctn.State = ConnectionState.Open Then
            SystmMdfCnnctn.Close()
        End If

        Catch ex As Exception
            ErrorMessage = ex.Message
            StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub 出来高査定チェックフォーム_Click(sender As Object, e As ClickEventArgs) Handles 出来高査定.Click
        Try
            If FormPanel.Controls.Count > 0 Then
                Dim FormClose As String = ""

                Dim FormCloseLoad As New FormClose(FormPanel.Controls.Item(0))
                FormClose = FormCloseLoad.FormCheck
            End If

            出来高査定チェックフォーム.Anchor = AnchorStyles.Top
            '協力業者入力.Anchor = AnchorStyles.Bottom
            出来高査定チェックフォーム.Anchor = AnchorStyles.Left
            '協力業者入力.Anchor = AnchorStyles.Right

            出来高査定チェックフォーム.TopLevel = False
            FormPanel.Controls.Add(出来高査定チェックフォーム)
            出来高査定チェックフォーム.Show()
        Catch ex As Exception
            ErrorMessage = ex.Message
            StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub 出来形数量査定書_Excel_Click(sender As Object, e As ClickEventArgs) Handles 出来形数量査定書_Excel.Click
        If FormPanel.Controls.Count > 0 Then
            Dim FormClose As String = ""

            Dim FormCloseLoad As New FormClose(FormPanel.Controls.Item(0))
            FormClose = FormCloseLoad.FormCheck
        End If

        現場経費作成.Anchor = AnchorStyles.Top
        '協力業者入力.Anchor = AnchorStyles.Bottom
        現場経費作成.Anchor = AnchorStyles.Left
        '協力業者入力.Anchor = AnchorStyles.Right

        現場経費作成.TopLevel = False
        FormPanel.Controls.Add(現場経費作成)
        現場経費作成.Show()
    End Sub

    Private Sub 入力表作成_Click(sender As Object, e As ClickEventArgs) Handles 入力表作成.Click
        Try
            If FormPanel.Controls.Count > 0 Then
                Dim FormClose As String = ""

                Dim FormCloseLoad As New FormClose(FormPanel.Controls.Item(0))
                FormClose = FormCloseLoad.FormCheck
            End If

            Sql.Parameters.Clear()
            Sql.CommandText = ""
            Sql.CommandText = "SELECT Count(*) FROM Details WHERE budget_no=" & BudgetNo
            Dim DetailsCount As Integer = Sql.ExecuteScalar

            If DetailsCount > 0 Then
                詳細入力表.Show()
                詳細入力表.Visible = True
            Else
                MsgBox("予算内訳を登録して下さい。", MsgBoxStyle.Exclamation, "ホーム")
            End If

        Catch ex As Exception
            ErrorMessage = ex.Message
            StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub 代価表作成_Click(sender As Object, e As ClickEventArgs) Handles 代価表作成.Click
        Try
            If FormPanel.Controls.Count > 0 Then
                Dim FormClose As String = ""

                Dim FormCloseLoad As New FormClose(FormPanel.Controls.Item(0))
                FormClose = FormCloseLoad.FormCheck
            End If
            作成代価選択.Show()
        Catch ex As Exception
            ErrorMessage = ex.Message
        StackTrace = ex.StackTrace
        エラー.Show()
        Exit Sub
        End Try
    End Sub

    Private Sub ImportFileDialog_FileOk(sender As Object, e As CancelEventArgs) Handles ImportFileDialog.FileOk
        Try

            Sql.CommandText = ""
            Sql.Parameters.Clear()
            Sql.CommandText = "SELECT Count(*) FROM cost_masters WHERE cstclss_code=2"
            Dim DataCount As Integer = Sql.ExecuteScalar

            Dim Import As String = ""
            Dim ImportMaterialLoad As New ImportMaterial(ImportFileDialog.FileName)


            If DataCount > 0 Then
                If MsgBox("材料表はインポート済みです。" & vbCrLf & "新しい材料表をインポートしますか?" & vbCrLf & "※新しいデータは追加登録されます。(上書き登録ではありません。)",
                           MsgBoxStyle.OkCancel, "材料表インポート") = MsgBoxResult.Ok Then
                    Import = ImportMaterialLoad.ImportMaterial
                End If
            Else
                Import = ImportMaterialLoad.ImportMaterial
            End If

        Catch ex As Exception
            ErrorMessage = ex.Message
            StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub 予算総括表_Click(sender As Object, e As ClickEventArgs) Handles 予算総括表.Click
        レポート.Show()
    End Sub

    Private Sub 外注計画_Click(sender As Object, e As ClickEventArgs) Handles 外注計画.Click
        '値がTrueの場合、変数に帳票名を代入する
        Report = "外注計画"
        'レポートのデザインが格納されているファイルのパスを変数に代入する
        'ReportPath = Application.StartupPath & "\予算管理システムレポート.flxr"
        ReportPath = "C:\Users\217003\source\repos\MinaAjiki\YosankanriSys\予算管理システム(仮)\予算管理システムレポート.flxr"
        レポート.Show()
    End Sub

    Private Sub 外注計画報告書_Click(sender As Object, e As ClickEventArgs) Handles 外注計画報告書.Click
        '値がTrueの場合、変数に帳票名を代入する
        Report = "外注計画報告書"
        'レポートのデザインが格納されているファイルのパスを変数に代入する
        'ReportPath = Application.StartupPath & "\予算管理システムレポート.flxr"
        ReportPath = "C:\Users\217003\source\repos\MinaAjiki\YosankanriSys\予算管理システム(仮)\予算管理システムレポート.flxr"
        レポート.Show()
    End Sub
End Class
