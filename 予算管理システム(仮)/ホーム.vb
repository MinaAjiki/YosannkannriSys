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
    Public BeforeForm As String
    Public ItemSelect As String
    Public SelectNodeList As New List(Of C1.Win.TreeView.C1TreeNode)

    Private Sub ホーム_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            SystemSqlCnnctn.Open()
            SystemSql.Connection = SystemSqlCnnctn

            If System.IO.File.Exists("C:\PMS\system.mdf") = True Then



                SystmMdfCnnctn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\PMS\system.mdf;Integrated Security=True"
                SystmMdfCnnctn.Open()

                Dim fileDate As Date

                SystemMdf.Connection = SystmMdfCnnctn
                SystemMdf.CommandText = "SELECT TOP 1 * FROM userfiles ORDER BY filedate DESC"
                Dim FileReader As SqlDataReader = SystemMdf.ExecuteReader
                While FileReader.Read
                    UserDataName = FileReader.Item("filename")
                    UserDataPath = FileReader.Item("filepath")
                    fileDate = FileReader.Item("filedate")
                End While
                FileReader.Close()

                Dim checkdate As Date = fileDate.AddMonths(1)


                If IsNetworkDeployed = True Then
                    'ClickOnceアプリケーションの場合、アプリケーションがアップデート可能かどうかを判別する
                    Dim AD As ApplicationDeployment = ApplicationDeployment.CurrentDeployment
                    If AD.CheckForUpdate = True Then
                        If checkdate <= Today Then
                            'メッセージを表示し、ユーザーの返答を判別する
                            If MsgBox("予算管理システムの最新バージョンが利用できます。更新しますか?", MsgBoxStyle.YesNo, "更新の確認") = MsgBoxResult.Yes Then
                                'メッセージに対し[はい]を選択した場合、アップデートする
                                AD.Update()
                                'メッセージを表示し、ユーザーの返答を判別する
                                If MsgBox("更新が完了しました。" & vbCrLf & "予算管理システムを再起動します。", MsgBoxStyle.OkOnly, "再起動の確認") = MsgBoxResult.Ok Then
                                    Application.Restart()
                                End If
                            Else
                                アップデート.Enabled = True
                            End If
                        Else
                            アップデート.Enabled = True
                        End If

                    Else
                        アップデート.Enabled = False
                    End If
                Else
                    アップデート.Enabled = False
                End If

                If UserDataName <> "" Then

                    If System.IO.File.Exists(UserDataPath & UserDataName) = True Then

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
                                参照作成command.Enabled = True
                            End If

                        Else
                            Me.Enabled = True
                            Me.Text = "予算管理システム　(" & UserDataPath & UserDataName & ")"
                            BudgetNo = 0
                            HomeTreeView.Columns(0).HeaderText = ""
                            予算内訳登録.Enabled = False
                            出力.Enabled = False
                            見積.Enabled = False
                            外注管理.Enabled = False
                            参照作成command.Enabled = False
                        End If

                        SystemSql.CommandText = "SELECT NAME FROM M_TANT_ALL WHERE NON_SEARCH=0"
                        Dim M_TANTReader As SqlDataReader = SystemSql.ExecuteReader
                        While M_TANTReader.Read
                            AutoCmpCllctn.Add(M_TANTReader.Item("NAME"))
                        End While
                        M_TANTReader.Close()

                        'レポートのデザインが格納されているファイルのパスを変数に代入する
                        Reportpath = Application.StartupPath & "\予算管理システムレポート.flxr"
                    Else


                        SystemMdf.CommandText = "DELETE FROM userfiles WHERE filename=@name AND filepath=@path"
                        SystemMdf.Parameters.Add(New SqlParameter("@name", SqlDbType.NVarChar)).Value = UserDataName
                        SystemMdf.Parameters.Add(New SqlParameter("@path", SqlDbType.NVarChar)).Value = UserDataPath
                        SystemMdf.ExecuteNonQuery()

                        If MsgBox("前回使用していたファイルが存在しません。" & vbCrLf & UserDataPath & UserDataName & vbCrLf & vbCrLf & "新しいファイルを作成しますか ?" & vbCrLf, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            CreateFileDialog.ShowDialog()
                        Else
                            DB選択.Show()
                            DB選択.TopMost = True

                        End If
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
                    参照作成command.Enabled = False
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
                参照作成command.Enabled = False
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

    Private Sub 参照作成_Click(sender As Object, e As ClickEventArgs) Handles 参照作成command.Click
        参照作成.Show()
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

            BeforeForm = "予算"
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

            Sql.CommandText = "INSERT INTO expense_breakdowns SELECT stexpns_id,expns_bd_no,expns_bd_name,expns_bd_spec,expns_bd_unit,expns_bd_quanity,expns_bd_costea FROM #expense_bd"
            Sql.ExecuteNonQuery()

            Transaction.Commit()

            SystemMdf.Parameters.Clear()
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

            HomeTreeView.Columns(0).HeaderText = ""
            HomeTreeView.Nodes.Clear()
            予算.Enabled = True
            マスタ.Enabled = True
            開く.Enabled = True
            材料表インポート.Enabled = True
            参照作成command.Enabled = True

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

        Try
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

        Catch ex As Exception
            ErrorMessage = ex.Message
            StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
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

        Try
            Dim SavePath As String = SaveFileDialog1.FileName
            Dim ReportLoad As String = ""
            SaveFileDialog1.FileName = "外注計画"
            Dim ExportXLoadRead As New Export外注計画(SavePath)
            ReportLoad = ExportXLoadRead.ExportLoad

            'メッセージを表示する
            MsgBox("エクスポート完了", MsgBoxStyle.OkOnly, "エクスポート")

        Catch ex As Exception
            ErrorMessage = ex.Message
            StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
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
        Try
            Cursor.Current = Cursors.WaitCursor

            Dim ReportLoad As String = ""
            Dim ReportLoadRead As New 全_簡易
            ReportLoad = ReportLoadRead.ReportLoad

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            ErrorMessage = ex.Message
            StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
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

            BeforeForm = "見積"
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

    Private Sub 見積表紙_Click(sender As Object, e As ClickEventArgs) Handles 見積表紙.Click
        ReportName = "見積書"
        レポート.Show()
    End Sub

    Private Sub 値引き無_Click(sender As Object, e As ClickEventArgs) Handles 値引き無.Click
        ReportName = "見積書_値引き無"
        レポート.Show()
    End Sub

    Private Sub 値引き有_Click(sender As Object, e As ClickEventArgs) Handles 値引き有.Click
        ReportName = "見積書_値引き有"
        レポート.Show()
    End Sub

    Private Sub 見積条件詳細_Click(sender As Object, e As ClickEventArgs) Handles 見積条件詳細.Click
        ReportName = "見積条件詳細"
        レポート.Show()
    End Sub

    Private Sub 金込_Click(sender As Object, e As ClickEventArgs) Handles 金込.Click
        ReportName = "見積内訳"
        レポート.Show()
    End Sub

    Private Sub 金抜_Click(sender As Object, e As ClickEventArgs) Handles 金抜.Click
        ReportName = "見積内訳(金抜き)"
        レポート.Show()
    End Sub

    Private Sub 見積代価_金込_Click(sender As Object, e As ClickEventArgs) Handles 見積代価_金込.Click
        ReportName = "見積代価内訳"
        レポート.Show()
    End Sub

    Private Sub 見積代価_金抜_Click(sender As Object, e As ClickEventArgs) Handles 見積代価_金抜.Click
        ReportName = "見積代価内訳(金抜き)"
        レポート.Show()
    End Sub

    Private Sub 代価_Click(sender As Object, e As ClickEventArgs) Handles 代価.Click
        ReportName = "代価内訳書_簡易"
        印刷代価選択.Show()
    End Sub

    Private Sub HomeTreeView_Expanded(sender As Object, e As C1.Win.TreeView.C1TreeViewEventArgs) Handles HomeTreeView.Expanded
        Try
            Sql.Parameters.Clear()
            Sql.CommandText = ""

            Dim childcount As Integer = e.Node.Nodes.Count

            For nodeindex As Integer = 0 To childcount - 1
                Dim childnode As C1.Win.TreeView.C1TreeNode = e.Node.Nodes(nodeindex)
                Dim nodevalue As String = childnode.GetValue

                If e.Node.Level = 0 Then

                    Dim scode As Integer = Integer.Parse(nodevalue.Substring(0, 3))

                    If Not scode = 841 Then
                        Sql.CommandText = "SELECT * FROM details WHERE budget_no=" & BudgetNo & "  AND s_worktype_code=" & scode & " AND cstclss_code > 11 ORDER BY dtl_no ASC"
                        Dim DetailsReader As SqlDataReader = Sql.ExecuteReader
                        While DetailsReader.Read

                            Dim remarks As String = DetailsReader.Item("dtl_remarks")
                            remarks = remarks.Remove(0, 1)
                            remarks = remarks.Remove(remarks.Length - 1, 1)

                            e.Node.Nodes(nodeindex).Nodes.Add(DetailsReader.Item("dtl_no") & " " & DetailsReader.Item("dtl_name") & "(" & remarks & ")")

                        End While
                        DetailsReader.Close()
                    End If

                ElseIf e.Node.Level = 1 Then

                        Dim parentvalue As String = e.Node.GetValue
                        Dim scode As Integer = Integer.Parse(parentvalue.Substring(0, 3))
                        Dim spaceindex As Integer = nodevalue.IndexOf(" ")
                        Dim dtlno As Integer = Integer.Parse(nodevalue.Substring(0, spaceindex))

                        Sql.CommandText = "SELECT cstmstr_id FROM details WHERE budget_no=" & BudgetNo & "  AND s_worktype_code=" & scode & " AND dtl_no=" & dtlno
                        Dim cstmstrid As Integer = Sql.ExecuteScalar

                        Sql.CommandText = "SELECT * FROM project_cost_breakdowns WHERE prjctcst_id=" & cstmstrid & " AND cstclss_code > 11 ORDER BY prjctcst_bd_no ASC"
                        Dim PrjctCstBDReader As SqlDataReader = Sql.ExecuteReader
                        While PrjctCstBDReader.Read

                            Dim remarks As String = PrjctCstBDReader.Item("prjctcst_bd_remarks")
                            remarks = remarks.Remove(0, 1)
                            remarks = remarks.Remove(remarks.Length - 1, 1)

                            e.Node.Nodes(nodeindex).Nodes.Add(PrjctCstBDReader.Item("prjctcst_bd_no") & " " & PrjctCstBDReader.Item("prjctcst_bd_name") & "(" & remarks & ")")

                        End While
                        PrjctCstBDReader.Close()

                    ElseIf e.Node.Level >= 2 Then

                        Sql.CommandText = ""
                    Sql.Parameters.Clear()

                Dim index As Integer = nodevalue.LastIndexOf("(")
                Dim cost As String = nodevalue.Substring(index + 1, 1)
                    Dim costno As Integer = Integer.Parse(nodevalue.Substring(index + 3, 5))

                    Dim clssname As String = "工事代価" & cost

                    Sql.CommandText = "SELECT cstclss_code FROM cost_classes WHERE cstclss_name=@name"
                    Sql.Parameters.Add(New SqlParameter("@name", SqlDbType.NVarChar)).Value = clssname
                    Dim clsscode As Integer = Sql.ExecuteScalar



                    Sql.CommandText = ""
                    Sql.Parameters.Clear()
                    Sql.CommandText = "SELECT prjctcst_id FROM project_costs WHERE budget_no=" & BudgetNo & "  AND cstclss_code=" & clsscode & " AND prjctcst_no=" & costno
                    Dim prjctcstid As Integer = Sql.ExecuteScalar

                    Sql.CommandText = "SELECT Count(prjctcst_bd_remarks) FROM project_cost_breakdowns WHERE prjctcst_id=" & prjctcstid & " AND cstclss_code > 11"
                    Dim Count As Integer = Sql.ExecuteScalar


                    Sql.CommandText = "SELECT * FROM project_cost_breakdowns WHERE prjctcst_id=" & prjctcstid & " AND cstclss_code > 11 ORDER BY prjctcst_bd_no ASC"
                    Dim PrjctCstBDReader As SqlDataReader = Sql.ExecuteReader
                    While PrjctCstBDReader.Read

                        Dim bdremarks As String = ""
                        bdremarks = PrjctCstBDReader.Item("prjctcst_bd_remarks")
                        If bdremarks <> "" Then
                            bdremarks = bdremarks.Remove(0, 1)
                            bdremarks = bdremarks.Remove(bdremarks.Length - 1, 1)

                            e.Node.Nodes(nodeindex).Nodes.Add(PrjctCstBDReader.Item("prjctcst_bd_no") & " " & PrjctCstBDReader.Item("prjctcst_bd_name") & "(" & bdremarks & ")")
                        End If
                    End While
                    PrjctCstBDReader.Close()

                End If
            Next

        Catch ex As Exception
        ErrorMessage = ex.Message
        StackTrace = ex.StackTrace
        エラー.Show()
        Exit Sub
        End Try
    End Sub


    Private Sub ReferenceMode_Click(sender As Object, e As EventArgs) Handles ReferenceMode.Click

        Try

            Dim node As C1.Win.TreeView.C1TreeNode = HomeTreeView.SelectedNodes(0)

            Dim nodevalue As String = node.GetValue
            Dim level As Integer = node.Level

            Dim index As Integer = nodevalue.Length - 1
            Dim cost As String = nodevalue.Substring(index - 8, 1)
            Dim costno As Integer = Integer.Parse(nodevalue.Substring(index - 6, 5))

            Dim clssname As String = "工事代価" & cost
            Sql.CommandText = ""
            Sql.Parameters.Clear()
            Sql.CommandText = "SELECT cstclss_code FROM cost_classes WHERE cstclss_name=@name"
            Sql.Parameters.Add(New SqlParameter("@name", SqlDbType.NVarChar)).Value = clssname
            Dim clsscode As Integer = Sql.ExecuteScalar

            Sql.CommandText = ""
            Sql.Parameters.Clear()
            Sql.CommandText = "SELECT prjctcst_id FROM project_costs WHERE budget_no=" & BudgetNo & "  AND cstclss_code=" & clsscode & " AND prjctcst_no=" & costno
            Dim prjctcstid As Integer = Sql.ExecuteScalar

            Dim DaikaForm As New 代価表入力
            DaikaForm.CostID = prjctcstid
            DaikaForm.ClassCode = clsscode
            DaikaForm.TopLevel = True
            DaikaForm.TopMost = True
            DaikaForm.FormBorderStyle = FormBorderStyle.Sizable
            DaikaForm.CostNo.Enabled = False
            DaikaForm.CostName.Enabled = False
            DaikaForm.CostSpec.Enabled = False
            DaikaForm.CostQuanity.Enabled = False
            DaikaForm.CostUnit.Enabled = False
            DaikaForm.CostUnitPrice.Enabled = False
            DaikaForm.CostCostea.Enabled = False
            DaikaForm.BreakDownList.AllowEditing = False
            DaikaForm.ItemSelect.Visible = False
            DaikaForm.CostCreation.Visible = False
            DaikaForm.CostModify.Visible = False
            DaikaForm.CostCopy.Visible = False
            DaikaForm.Reference.Visible = False
            DaikaForm.Entry.Visible = False
            DaikaForm.BreakDownList.ContextMenuStrip.Visible = False
            DaikaForm.Show()
            DaikaForm.TopMost = False

        Catch ex As Exception
            ErrorMessage = ex.Message
            StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub HomeTreeView_DoubleClick(sender As Object, e As EventArgs) Handles HomeTreeView.DoubleClick
        Try
            Cursor.Current = Cursors.WaitCursor
            If HomeTreeView.SelectedNodes.Count >= 1 Then

                If FormPanel.Controls.Count > 0 Then
                    Dim FormClose As String = ""

                    Dim FormCloseLoad As New FormClose(FormPanel.Controls.Item(0))
                    FormClose = FormCloseLoad.FormCheck
                End If

                Dim formcount As Integer = ProjectCostForm.Count
                If formcount > 0 Then
                    For formloop As Integer = 0 To formcount - 1
                        ProjectCostForm.RemoveAt(formloop)
                        ProjectCostID.RemoveAt(formloop)
                        ProjectCostSelectRow.RemoveAt(formloop)
                        PrjctCstClassCode.RemoveAt(formloop)
                        PrjctCstList.RemoveAt(formloop)
                    Next
                End If


                lworktypecode = 0
                lworktypename = 0
                sworktypecode = 0
                sworktypename = 0


                Dim SelectNode As C1.Win.TreeView.C1TreeNode = HomeTreeView.SelectedNodes(0)

                Dim nodevalue As String = SelectNode.GetValue
                Dim level As Integer = SelectNode.Level

                If IsNothing(nodevalue) = False Then


                    If level = 0 Then
                        右クリックメニュー.Visible = False

                        SelectNodeList.Add(SelectNode)
                        Dim length As Integer = nodevalue.Length

                        Dim lcode As Integer = Integer.Parse(nodevalue.Substring(0, 3))
                        Dim lname As String = nodevalue.Remove(0, 4)

                        lworktypecode = lcode
                        lworktypename = lname

                        小工種選択.TopLevel = False
                        FormPanel.Controls.Add(小工種選択)
                        小工種選択.Show()


                    ElseIf level = 1 Then

                        右クリックメニュー.Visible = False

                        Dim length As Integer = nodevalue.Length

                        Dim scode As Integer = Integer.Parse(nodevalue.Substring(0, 3))
                        Dim sname As String = nodevalue.Remove(0, 4)
                        Dim parentnode As C1.Win.TreeView.C1TreeNode = SelectNode.ParentCollection.Parent
                        Dim parentvalue As String = parentnode.GetValue
                        lworktypecode = Integer.Parse(parentvalue.Substring(0, 3))
                        lworktypename = parentvalue.Remove(0, 4)
                        SelectNodeList.Add(parentnode)
                        SelectNodeList.Add(SelectNode)

                        sworktypecode = scode
                        sworktypename = sname

                        If Not scode = 841 Then
                            明細書入力.TopLevel = False
                            FormPanel.Controls.Add(明細書入力)
                            明細書入力.Show()
                        Else
                            現場経費作成.TopLevel = False
                            FormPanel.Controls.Add(現場経費作成)
                            現場経費作成.Show()
                        End If

                    Else
                        SelectNodeList.Add(SelectNode)
                        右クリックメニュー.Visible = True

                        Dim index As Integer = nodevalue.Length - 1
                        Dim subindex As Integer = nodevalue.LastIndexOf("(")
                        Dim cost As String = nodevalue.Substring(subindex + 1, 1)
                        Dim costno As Integer = Integer.Parse(nodevalue.Substring(index - 5, 5))

                        Dim clssname As String = "工事代価" & cost
                        Sql.CommandText = ""
                        Sql.Parameters.Clear()
                        Sql.CommandText = "SELECT cstclss_code FROM cost_classes WHERE cstclss_name=@name"
                        Sql.Parameters.Add(New SqlParameter("@name", SqlDbType.NVarChar)).Value = clssname
                        Dim clsscode As Integer = Sql.ExecuteScalar

                        Sql.CommandText = ""
                        Sql.Parameters.Clear()
                        Sql.CommandText = "SELECT prjctcst_id FROM project_costs WHERE budget_no=" & BudgetNo & "  AND cstclss_code=" & clsscode & " AND prjctcst_no=" & costno
                        Dim prjctcstid As Integer = Sql.ExecuteScalar

                        Dim ProjectCostList As New C1FlexGrid

                        ProjectCostForm.Add(New 代価表入力)
                        ProjectCostForm(0).TopLevel = False
                        FormPanel.Controls.Add(ProjectCostForm(0))
                        ProjectCostSelectRow.Add(0)
                        ProjectCostID.Add(prjctcstid)
                        PrjctCstClassCode.Add(clsscode)
                        PrjctCstList.Add(ProjectCostList)
                        ProjectCostForm(0).Show()
                    End If
                End If
            End If
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            ErrorMessage = ex.Message
            StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub 閉じる_Click(sender As Object, e As ClickEventArgs) Handles 閉じる.Click
        Try
            If FormPanel.Controls.Count > 0 Then
                Dim FormClose As String = ""

                Dim FormCloseLoad As New FormClose(FormPanel.Controls.Item(0))
                FormClose = FormCloseLoad.FormCheck
            End If

            Me.Close()
        Catch ex As Exception
            ErrorMessage = ex.Message
            StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub HomeTreeView_Collapsed(sender As Object, e As C1.Win.TreeView.C1TreeViewEventArgs) Handles HomeTreeView.Collapsed
        Try
            Sql.Parameters.Clear()
            Sql.CommandText = ""

            Dim childcount As Integer = e.Node.Nodes.Count
            For nodeindex As Integer = 0 To childcount - 1
                Dim childnode As C1.Win.TreeView.C1TreeNode = e.Node.Nodes(nodeindex)
                childnode.Nodes.Clear()
                childnode.Collapse()
            Next

        Catch ex As Exception
            ErrorMessage = ex.Message
            StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub アップデート_Click(sender As Object, e As ClickEventArgs) Handles アップデート.Click
        Dim AD As ApplicationDeployment = ApplicationDeployment.CurrentDeployment
        'メッセージを表示し、ユーザーの返答を判別する
        If MsgBox("予算管理システムの最新バージョンが利用できます。更新しますか?", MsgBoxStyle.YesNo, "更新の確認") = MsgBoxResult.Yes Then
            'メッセージに対し[はい]を選択した場合、アップデートする
            AD.Update()
            'メッセージを表示し、ユーザーの返答を判別する
            If MsgBox("更新が完了しました。" & vbCrLf & "予算管理システムを再起動します。", MsgBoxStyle.YesNo, "再起動の確認") = MsgBoxResult.Yes Then
                'メッセージに対し[はい]を選択した場合、再起動する
                Application.Restart()
            End If
        End If

    End Sub

    Private Sub バージョン情報_Click(sender As Object, e As ClickEventArgs) Handles バージョン情報.Click

        Dim AD As ApplicationDeployment = ApplicationDeployment.CurrentDeployment
        Dim version As String = AD.CurrentVersion.ToString
        MsgBox("Version " & version, MsgBoxStyle.OkOnly, "予算管理システム")
    End Sub
End Class
