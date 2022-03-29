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
    Public ProjectCommand As String
    Public ExpnsbdID As Integer
    Public ExpnsbdCode As Integer
    Public ExpnsbdName As String
    Public Reportpath As String
    Public ReportName As String


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

                        Sql.CommandText = "SELECT contents FROM controldata WHERE class_code=12"
                        Dim Year As Integer = 0
                        If IsError(Year = Sql.ExecuteScalar) = True Then
                            予算内訳登録.Enabled = False
                        Else
                            予算内訳登録.Enabled = True
                        End If

                    Else
                        Me.Enabled = True
                        Me.Text = "予算管理システム　(" & UserDataPath & UserDataName & ")"
                        BudgetNo = 0

                        予算内訳登録.Enabled = False
                        出力.Enabled = False
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
        ReportName = "代価内訳書"
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
            Cursor.Current = Cursors.WaitCursor

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

            Sql.CommandText = "INSERT INTO cost_masters SELECT cstclss_code,cstmstr_category,cstmstr_code,cstmstr_name,cstmstr_spec,cstmstr_unit,cstmstr_costea,changecode,cstmstr_seq FROM [SVACD001].[PMS].[dbo].[cost_masters]"
            Sql.ExecuteNonQuery()

            Sql.CommandText = "INSERT INTO cost_classes SELECT * FROM [SVACD001].[PMS].[dbo].[cost_classes]"
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

            Sql.CommandText = "INSERT INTO expense_breakdowns SELECT stexpns_id,expns_bd_no,expns_bd_name,expns_bd_spec,expns_bd_unit,expns_bd_costea,expns_bd_quanity FROM #expense_bd"
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

            Cursor.Current = Cursors.Default
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
            協力業者選択.ParentFormName = "出来高査定"
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
            MsgBox("材料表の取込に失敗しました。" & vbCrLf & "材料表データが適切でない可能性があります。" & vbCrLf & "システム課までお問合せ下さい。", MsgBoxStyle.Exclamation, "材料表インポート")
            Exit Sub
        End Try
    End Sub

    Private Sub 予算総括表_Click(sender As Object, e As ClickEventArgs) Handles 予算総括表.Click
        ReportName = "予算総括表"
        レポート.Show()
    End Sub

    Private Sub 材料表_Click(sender As Object, e As ClickEventArgs) Handles 材料表.Click
        ReportName = "材料表"
        レポート.Show()
    End Sub

    Private Sub 現場経費_Click(sender As Object, e As ClickEventArgs) Handles 現場経費.Click
        ReportName = "現場経費"
        レポート.Show()
    End Sub


    Private Sub 外注計画_Click(sender As Object, e As ClickEventArgs) Handles 外注計画.Click
        Try
            If FormPanel.Controls.Count > 0 Then
                Dim FormClose As String = ""

                Dim FormCloseLoad As New FormClose(FormPanel.Controls.Item(0))
                FormClose = FormCloseLoad.FormCheck
            End If
            協力業者選択.ParentFormName = "外注計画"
            協力業者選択.Anchor = AnchorStyles.Top
            '協力業者入力.Anchor = AnchorStyles.Bottom
            協力業者選択.Anchor = AnchorStyles.Left
            '協力業者入力.Anchor = AnchorStyles.Right

            協力業者選択.TopLevel = False
            FormPanel.Controls.Add(協力業者選択)
            協力業者選択.Show()
        Catch ex As Exception
            ErrorMessage = ex.Message
            StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub 外注計画報告書_Click(sender As Object, e As ClickEventArgs) Handles 外注計画報告書.Click
        '値がTrueの場合、変数に帳票名を代入する
        ReportName = "外注計画報告書"
        'レポートのデザインが格納されているファイルのパスを変数に代入する

        'Reportpath = "C:\Users\217003\source\repos\MinaAjiki\YosankanriSys\予算管理システム(仮)\予算管理システムレポート.flxr"
        レポート.Show()
    End Sub
    Private Sub 予算大内訳_Click(sender As Object, e As ClickEventArgs) Handles 予算大内訳.Click
        ReportName = "実行予算大内訳書"
        レポート.Show()
    End Sub

    Private Sub 予算内訳書_Click(sender As Object, e As ClickEventArgs) Handles 予算内訳書.Click
        ReportName = "実行予算内訳書"
        レポート.Show()
    End Sub

    Private Sub 予算総括表_簡易_Click(sender As Object, e As ClickEventArgs) Handles 予算総括表_簡易.Click
        ReportName = "予算総括表"
        レポート.Show()
    End Sub

    Private Sub 予算書_Click(sender As Object, e As ClickEventArgs) Handles 予算書.Click
        ReportName = "実行予算内訳書_簡易"
        レポート.Show()
    End Sub

    Private Sub 明細内訳書_Click(sender As Object, e As ClickEventArgs) Handles 明細内訳書.Click
        ReportName = "明細内訳書"

        レポート.Show()
    End Sub

    Private Sub 明細書_Click(sender As Object, e As ClickEventArgs) Handles 明細書.Click
        ReportName = "明細内訳書_簡易"
        レポート.Show()
    End Sub

    Private Sub 現場経費_簡易_Click(sender As Object, e As ClickEventArgs) Handles 現場経費_簡易.Click
        ReportName = "現場経費"
        レポート.Show()
    End Sub

    Private Sub 代価一覧表_Click(sender As Object, e As ClickEventArgs) Handles 代価一覧表.Click
        ReportName = "代価一覧表"
        印刷代価選択.Show()
    End Sub

    Private Sub 代価内訳_Click(sender As Object, e As ClickEventArgs) Handles 代価内訳.Click
        ReportName = "代価内訳書_簡易"
        印刷代価選択.Show()
    End Sub

    Private Sub 注文書_Click(sender As Object, e As ClickEventArgs) Handles 注文書.Click

    End Sub

    Private Sub 注文書_金込_Click(sender As Object, e As ClickEventArgs) Handles 注文書_金込.Click
        Try
            If FormPanel.Controls.Count > 0 Then
                Dim FormClose As String = ""

                Dim FormCloseLoad As New FormClose(FormPanel.Controls.Item(0))
                FormClose = FormCloseLoad.FormCheck
            End If

            協力業者選択.Anchor = AnchorStyles.Top
            '協力業者入力.Anchor = AnchorStyles.Bottom
            協力業者選択.Anchor = AnchorStyles.Left
            '協力業者入力.Anchor = AnchorStyles.Right

            協力業者選択.TopLevel = False
            FormPanel.Controls.Add(協力業者選択)
            協力業者選択.ParentFormName = "注文書"
            協力業者選択.HeadLine.Text = "<< 協力業者選択(注文書)"
            協力業者選択.Show()

        Catch ex As Exception
            ErrorMessage = ex.Message
            StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub 注文書_金抜_Click(sender As Object, e As ClickEventArgs) Handles 注文書_金抜.Click
        Try
            If FormPanel.Controls.Count > 0 Then
                Dim FormClose As String = ""

                Dim FormCloseLoad As New FormClose(FormPanel.Controls.Item(0))
                FormClose = FormCloseLoad.FormCheck
            End If

            協力業者選択.Anchor = AnchorStyles.Top
            '協力業者入力.Anchor = AnchorStyles.Bottom
            協力業者選択.Anchor = AnchorStyles.Left
            '協力業者入力.Anchor = AnchorStyles.Right

            協力業者選択.TopLevel = False
            FormPanel.Controls.Add(協力業者選択)
            協力業者選択.ParentFormName = "注文書金抜"
            協力業者選択.HeadLine.Text = "<< 協力業者選択(金抜注文書)"
            協力業者選択.Show()

        Catch ex As Exception
            ErrorMessage = ex.Message
            StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub 折衝用業者別内訳_Click(sender As Object, e As ClickEventArgs) Handles 折衝用業者別内訳.Click
        Try
            If FormPanel.Controls.Count > 0 Then
                Dim FormClose As String = ""

                Dim FormCloseLoad As New FormClose(FormPanel.Controls.Item(0))
                FormClose = FormCloseLoad.FormCheck
            End If

            協力業者選択.Anchor = AnchorStyles.Top
            '協力業者入力.Anchor = AnchorStyles.Bottom
            協力業者選択.Anchor = AnchorStyles.Left
            '協力業者入力.Anchor = AnchorStyles.Right

            協力業者選択.TopLevel = False
            FormPanel.Controls.Add(協力業者選択)
            協力業者選択.ParentFormName = "注文書折衝"
            協力業者選択.HeadLine.Text = "<< 協力業者選択(折衝用内訳書)"
            協力業者選択.Show()

        Catch ex As Exception
            ErrorMessage = ex.Message
            StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub 基礎代価一覧表_簡易_Click(sender As Object, e As ClickEventArgs) Handles 基礎代価一覧表_簡易.Click
        ReportName = "基礎代価一覧表"
        レポート.Show()
    End Sub

    Private Sub 基礎代価内訳_Click(sender As Object, e As ClickEventArgs) Handles 基礎代価内訳.Click
        ReportName = "基礎代価内訳書_簡易"
        レポート.Show()
    End Sub

    Private Sub 基礎代価一覧表_Click(sender As Object, e As ClickEventArgs) Handles 基礎代価一覧表.Click
        ReportName = "基礎代価一覧表"
        レポート.Show()
    End Sub

    Private Sub 基礎代価簡易内訳書_Click(sender As Object, e As ClickEventArgs) Handles 基礎代価簡易内訳書.Click
        ReportName = "基礎代価内訳書_簡易"
        レポート.Show()
    End Sub

    Private Sub 基礎代価詳細内訳書_Click(sender As Object, e As ClickEventArgs) Handles 基礎代価詳細内訳書.Click
        ReportName = "基礎代価内訳書"
        レポート.Show()
    End Sub

    Private Sub 全て印刷_Click(sender As Object, e As ClickEventArgs) Handles 全て印刷.Click
        Cursor.Current = Cursors.WaitCursor

        Dim ReportLoad As String = ""
        Dim ReportLoadRead As New 全_詳細
        ReportLoad = ReportLoadRead.ReportLoad

        Cursor.Current = Cursors.Default

    End Sub

    Private Sub 注文内訳書_Excel_Click(sender As Object, e As ClickEventArgs) Handles 注文内訳書_Excel.Click
        Try
            If FormPanel.Controls.Count > 0 Then
                Dim FormClose As String = ""

                Dim FormCloseLoad As New FormClose(FormPanel.Controls.Item(0))
                FormClose = FormCloseLoad.FormCheck
            End If

            協力業者選択.Anchor = AnchorStyles.Top
            '協力業者入力.Anchor = AnchorStyles.Bottom
            協力業者選択.Anchor = AnchorStyles.Left
            '協力業者入力.Anchor = AnchorStyles.Right

            協力業者選択.TopLevel = False
            FormPanel.Controls.Add(協力業者選択)
            協力業者選択.ParentFormName = "注文書Excel"
            協力業者選択.HeadLine.Text = "<< 協力業者選択(注文内訳書Excel出力)"
            協力業者選択.Show()

        Catch ex As Exception
            ErrorMessage = ex.Message
            StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub 外注計画_Excel_Click(sender As Object, e As ClickEventArgs) Handles 外注計画_Excel.Click
        ReportName = "外注計画"
        SaveFileDialog1.ShowDialog()
    End Sub
                                  
    Private Sub 入力表_工務課用_Click(sender As Object, e As ClickEventArgs) Handles 入力表_工務課用.Click
        ReportName = "入力表_工務課用"

        レポート.Show()
    End Sub


    Private Sub SaveFileDialog1_FileOk(sender As Object, e As CancelEventArgs) Handles SaveFileDialog1.FileOk
        Dim SavePath As String = SaveFileDialog1.FileName
        Dim ReportLoad As String = ""
        SaveFileDialog1.FileName = "外注計画"
        Dim ExportXLoadRead As New Export外注計画(SavePath)
            ReportLoad = ExportXLoadRead.ExportLoad

            'メッセージを表示する
            MsgBox("エクスポート完了", MsgBoxStyle.OkOnly, "エクスポート")
    End Sub

    Private Sub 注文書明細_CSV_Click(sender As Object, e As ClickEventArgs) Handles 注文書明細_CSV.Click
        Try
            If FormPanel.Controls.Count > 0 Then
                Dim FormClose As String = ""

                Dim FormCloseLoad As New FormClose(FormPanel.Controls.Item(0))
                FormClose = FormCloseLoad.FormCheck
            End If

            協力業者選択.Anchor = AnchorStyles.Top
            '協力業者入力.Anchor = AnchorStyles.Bottom
            協力業者選択.Anchor = AnchorStyles.Left
            '協力業者入力.Anchor = AnchorStyles.Right

            協力業者選択.TopLevel = False
            FormPanel.Controls.Add(協力業者選択)
            協力業者選択.ParentFormName = "注文書CSV"
            協力業者選択.HeadLine.Text = "<< 協力業者選択(注文内訳書CSV出力)"
            協力業者選択.Show()

        Catch ex As Exception
            ErrorMessage = ex.Message
            StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub
                                    
    Private Sub 入力表_Click(sender As Object, e As ClickEventArgs) Handles 入力表.Click
        ReportName = "入力表"
        レポート.Show()

    End Sub

    Private Sub SaveFileDialog_FileOk(sender As Object, e As CancelEventArgs) Handles SaveFileDialog.FileOk
        Try
            Dim ReportLoad As String = ""

            If ReportName = "実行予算CSV" Then
                Dim ReportLoadRead As New Export実行予算(SaveFileDialog.FileName)
                ReportLoad = ReportLoadRead.ReportLoad
            ElseIf ReportName = "明細書" Then
                Dim ReportLoadRead As New Export明細書(SaveFileDialog.FileName)
                ReportLoad = ReportLoadRead.ReportLoad
            End If

        Catch ex As Exception
            ErrorMessage = ex.Message
            StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub 実行予算_csv_cap21_Click(sender As Object, e As ClickEventArgs) Handles 実行予算_csv_cap21.Click
        Try
            If FormPanel.Controls.Count > 0 Then
                Dim FormClose As String = ""

                Dim FormCloseLoad As New FormClose(FormPanel.Controls.Item(0))
                FormClose = FormCloseLoad.FormCheck
            End If

            ReportName = "実行予算CSV"
            SaveFileDialog.Filter = "CSVファイル|*.csv"
            SaveFileDialog.FileName = "実行予算CSV(cap21).csv"
            SaveFileDialog.ShowDialog()


        Catch ex As Exception
            ErrorMessage = ex.Message
            StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub 明細書一覧_Excel_Click(sender As Object, e As ClickEventArgs) Handles 明細書一覧_Excel.Click
        Try
            If FormPanel.Controls.Count > 0 Then
                Dim FormClose As String = ""

                Dim FormCloseLoad As New FormClose(FormPanel.Controls.Item(0))
                FormClose = FormCloseLoad.FormCheck
            End If

            ReportName = "明細書"
            SaveFileDialog.Filter = "XLSXファイル|*.xlsx"
            SaveFileDialog.FileName = "明細書.xlsx"
            SaveFileDialog.ShowDialog()


        Catch ex As Exception
            ErrorMessage = ex.Message
            StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub 全て印刷_簡易_Click(sender As Object, e As ClickEventArgs) Handles 全て印刷_簡易.Click
        Cursor.Current = Cursors.WaitCursor

        Dim ReportLoad As String = ""
        Dim ReportLoadRead As New 全_簡易
        ReportLoad = ReportLoadRead.ReportLoad

        Cursor.Current = Cursors.Default
    End Sub

    Private Sub 見積書作成_Click(sender As Object, e As ClickEventArgs) Handles 見積書作成.Click
        Try
            If FormPanel.Controls.Count > 0 Then
                Dim FormClose As String = ""

                Dim FormCloseLoad As New FormClose(FormPanel.Controls.Item(0))
                FormClose = FormCloseLoad.FormCheck
            End If

            見積書表紙.TopLevel = False
            FormPanel.Controls.Add(見積書表紙)
            見積書表紙.Show()


        Catch ex As Exception
            ErrorMessage = ex.Message
            StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub 見積内訳登録_Click(sender As Object, e As ClickEventArgs) Handles 見積内訳登録.Click
        Try
            If FormPanel.Controls.Count > 0 Then
                Dim FormClose As String = ""

                Dim FormCloseLoad As New FormClose(FormPanel.Controls.Item(0))
                FormClose = FormCloseLoad.FormCheck
            End If

            見積掛率入力.ShowDialog()

        Catch ex As Exception
            ErrorMessage = ex.Message
            StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub
End Class
