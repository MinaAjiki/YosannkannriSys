Imports System.Data.SqlClient
Imports System.Deployment.Application
Imports System.IO.DirectoryInfo
Imports System.ComponentModel
Imports System.Deployment.Application.ApplicationDeployment
Imports System.Windows.Forms.Form
Public Class 予算選択
    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Try

            Cursor.Current = Cursors.WaitCursor

            If ホーム.Connection.State = ConnectionState.Open Then
                ホーム.Connection.Close()
            End If

            ホーム.Connection.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & FilePath.Text & ";Integrated Security=True"
            ホーム.Connection.Open()
            ホーム.Sql.Connection = ホーム.Connection

            ホーム.Enabled = True

            If Contract_NoList.SelectedItem = "当初" Then
                ホーム.Text = "予算管理システム(当初)" & FilePath.Text
                ホーム.BudgetNo = 0
            ElseIf Contract_NoList.SelectedItem = "変更予算作成" Then


                ホーム.Transaction = ホーム.Connection.BeginTransaction

                ホーム.Sql.Transaction = ホーム.Transaction

                ホーム.Sql.Parameters.Clear()
                ホーム.Sql.CommandText = ""

                ホーム.Sql.CommandText = "SELECT MAX(budget_no) FROM budget_summary"
                Dim MaxNo As Integer = ホーム.Sql.ExecuteScalar

                ホーム.Sql.CommandText = "SELECT * INTO #tmp_item FROM budget_summary WHERE budget_no=" & MaxNo
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = "UPDATE #tmp_item SET budget_no =" & MaxNo + 1
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = "INSERT INTO budget_summary SELECT * FROM #tmp_item"
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = "DROP TABLE #tmp_item"
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = "SELECT budget_no,cstclss_code,prjctcst_no,prjctcst_name,prjctcst_spec,prjctcst_unit,prjctcst_quanity,
                                        prjctcst_costea,prjctcst_laborea,prjctcst_materialea,prjctcst_machineea,prjctcst_subcntrctea,prjctcst_expenseea 
                                        INTO #projectcost_item FROM project_costs WHERE budget_no=" & MaxNo & " AND prjctcst_id>0"
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = "UPDATE #projectcost_item SET budget_no =" & MaxNo + 1
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = "SELECT * INTO #prjctcst FROM project_costs WHERE budget_no=" & MaxNo
                ホーム.Sql.ExecuteNonQuery()


                ホーム.Sql.CommandText = "ALTER TABLE #prjctcst ADD new_id smallint DEFAULT ((0)) NOT NULL"
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = "CREATE TABLE #OutputTbl (output_id smallint,clsscode smallint,costno smallint)"
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = "INSERT INTO project_costs OUTPUT inserted.prjctcst_id,inserted.cstclss_code,inserted.prjctcst_no INTO #OutputTbl(output_id,clsscode,costno)
                                          SELECT * FROM #projectcost_item"
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = "DROP TABLE #projectcost_item"
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = "UPDATE #prjctcst SET #prjctcst.new_id=#OutputTbl.output_id FROM #OutputTbl WHERE #prjctcst.cstclss_code=#OutputTbl.clsscode AND 
                                          #prjctcst.prjctcst_no=#OutputTbl.costno"
                ホーム.Sql.ExecuteNonQuery()


                'ホーム.Sql.CommandText = "UPDATE #OutputTbl SET #OutputTbl.prjctcst_id= project_costs.prjctcst_id FROM project_costs WHERE  budget_no=" & MaxNo + 1 & " AND prjctcst_id>0
                '                          "
                'ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = " CREATE TABLE ##prjctcst_bd (
    [prjctcst_bd_id]        INT             IDENTITY (1, 1) NOT NULL,
    [prjctcst_id]           INT             DEFAULT ((0)) NOT NULL,
    [cstclss_code]          SMALLINT        DEFAULT ((0)) NOT NULL,
    [cstmstr_id]            INT             DEFAULT ((0)) NOT NULL,
    [prjctcst_bd_no]        SMALLINT        DEFAULT ((0)) NOT NULL,
    [prjctcst_bd_name]      NVARCHAR (50)   DEFAULT ('') NOT NULL,
    [prjctcst_bd_spec]      NVARCHAR (50)   DEFAULT ('') NOT NULL,
    [prjctcst_bd_unit]      NVARCHAR (6)    DEFAULT ('') NOT NULL,
    [prjctcst_bd_quanity]   DECIMAL (15, 2) DEFAULT ((0)) NOT NULL,
    [prjctcst_bd_costea]    MONEY           DEFAULT ((0)) NOT NULL,
    [prjctcst_bd_labor]     MONEY           DEFAULT ((0)) NOT NULL,
    [prjctcst_bd_material]  MONEY           DEFAULT ((0)) NOT NULL,
    [prjctcst_bd_machine]   MONEY           DEFAULT ((0)) NOT NULL,
    [prjctcst_bd_subcntrct] MONEY           DEFAULT ((0)) NOT NULL,
    [prjctcst_bd_expense]   MONEY           DEFAULT ((0)) NOT NULL,
    [prjctcst_bd_remarks]   NVARCHAR (30)   DEFAULT ('') NOT NULL);"
                ホーム.Sql.ExecuteNonQuery()



                ホーム.Sql.CommandText = "INSERT INTO ##prjctcst_bd SELECT project_cost_breakdowns.prjctcst_id,project_cost_breakdowns.cstclss_code,project_cost_breakdowns.cstmstr_id,project_cost_breakdowns.prjctcst_bd_no,
                                          project_cost_breakdowns.prjctcst_bd_name,project_cost_breakdowns.prjctcst_bd_spec,project_cost_breakdowns.prjctcst_bd_unit,project_cost_breakdowns.prjctcst_bd_quanity,
                                          project_cost_breakdowns.prjctcst_bd_costea,project_cost_breakdowns.prjctcst_bd_labor,project_cost_breakdowns.prjctcst_bd_material,project_cost_breakdowns.prjctcst_bd_machine,
                                          project_cost_breakdowns.prjctcst_bd_subcntrct,project_cost_breakdowns.prjctcst_bd_expense,project_cost_breakdowns.prjctcst_bd_remarks FROM  project_cost_breakdowns 
                                          INNER JOIN #prjctcst ON project_cost_breakdowns.prjctcst_id = #prjctcst.prjctcst_id"
                ホーム.Sql.ExecuteNonQuery()


                ホーム.Sql.CommandText = "UPDATE ##prjctcst_bd SET ##prjctcst_bd.prjctcst_id=#prjctcst.new_id FROM #prjctcst WHERE ##prjctcst_bd.prjctcst_id=#prjctcst.prjctcst_id"
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = "UPDATE ##prjctcst_bd SET ##prjctcst_bd.cstmstr_id=#prjctcst.new_id FROM #prjctcst WHERE ##prjctcst_bd.cstclss_code=#prjctcst.cstclss_code
                                          AND ##prjctcst_bd.cstmstr_id=#prjctcst.prjctcst_id"
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = "INSERT INTO project_cost_breakdowns SELECT prjctcst_id,cstclss_code,cstmstr_id,prjctcst_bd_no,prjctcst_bd_name,prjctcst_bd_spec,
                                          prjctcst_bd_unit,prjctcst_bd_quanity,prjctcst_bd_costea,prjctcst_bd_labor,prjctcst_bd_material,prjctcst_bd_machine,prjctcst_bd_subcntrct,
                                          prjctcst_bd_expense,prjctcst_bd_remarks FROM ##prjctcst_bd"
                ホーム.Sql.ExecuteNonQuery()


                ホーム.Sql.CommandText = "DROP TABLE ##prjctcst_bd"
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = "SELECT * INTO #details FROM details WHERE budget_no=" & MaxNo
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = "UPDATE #details SET #details.budget_no=" & MaxNo + 1
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = "UPDATE #details SET #details.cstmstr_id=#prjctcst.new_id FROM #prjctcst WHERE #details.cstclss_code=#prjctcst.cstclss_code
                                          AND #details.cstmstr_id=#prjctcst.prjctcst_id"
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = "ALTER TABLE #details DROP COLUMN dtl_id"
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = "CREATE TABLE #OutputTbl_dtl (new_id smallint,old_id smallint)"
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = "INSERT INTO details OUTPUT inserted.dtl_id INTO #OutputTbl_dtl(new_id) SELECT * FROM #details"
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = "UPDATE #OutputTbl_dtl SET #OutputTbl_dtl.old_id=details.dtl_id FROM details WHERE details.budget_no=" & MaxNo
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = "DROP TABLE #OutputTbl"
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = "DROP TABLE #details"
                ホーム.Sql.ExecuteNonQuery()



                ホーム.Sql.CommandText = "SELECT Count(*) FROM outsourcing_plans WHERE budget_no=" & MaxNo
                Dim OutsourcingCount As Integer = ホーム.Sql.ExecuteScalar

                If OutsourcingCount > 0 Then
                    ホーム.Sql.CommandText = "SELECT MAX(outsrc_no) FROM outsourcing_plans WHERE budget_no=" & MaxNo
                    Dim OutsrcMaxNo As Integer = ホーム.Sql.ExecuteScalar

                    ホーム.Sql.CommandText = "SELECT * INTO ##outsourcing_plans FROM outsourcing_plans WHERE budget_no=" & MaxNo & " AND outsrc_no=" & OutsrcMaxNo
                    ホーム.Sql.ExecuteNonQuery()

                    ホーム.Sql.CommandText = "UPDATE ##outsourcing_plans SET ##outsourcing_plans.budget_no=" & MaxNo + 1 & ",##outsourcing_plans.outsrc_no=" & OutsrcMaxNo + 1 &
                                             ",##outsourcing_plans.created_date=@createddate,##outsourcing_plans.dtl_id=#OutputTbl_dtl.new_id FROM #OutputTbl_dtl 
                                              WHERE ##outsourcing_plans.dtl_id=#OutputTbl_dtl.old_id"
                    ホーム.Sql.Parameters.Add("@createddate", SqlDbType.DateTime).Value = Today
                    ホーム.Sql.ExecuteNonQuery()

                    ホーム.Sql.CommandText = "INSERT INTO outsourcing_plans SELECT * FROM ##outsourcing_plans"
                    ホーム.Sql.ExecuteNonQuery()

                    ホーム.Sql.CommandText = "DROP TABLE ##outsourcing_plans"
                    ホーム.Sql.ExecuteNonQuery()
                End If

                ホーム.Sql.Parameters.Clear()
                ホーム.Sql.CommandText = "SELECT Count(*) FROM productions"
                Dim ProductionsCount As Integer = ホーム.Sql.ExecuteScalar

                If ProductionsCount > 0 Then
                    ホーム.Sql.CommandText = "SELECT MAX(closing_date) FROM productions"
                    Dim MaxClosingDate As DateTime = ホーム.Sql.ExecuteScalar

                    ホーム.Sql.CommandText = "SELECT * INTO ##productions FROM productions WHERE closing_date=@closingdate"
                    ホーム.Sql.Parameters.Add("@closingdate", SqlDbType.DateTime).Value = MaxClosingDate
                    ホーム.Sql.ExecuteNonQuery()

                    ホーム.Sql.Parameters.Clear()
                    ホーム.Sql.CommandText = "UPDATE ##productions SET  ##productions.closing_date=@closingdate, ##productions.dtl_id=#OutputTbl_dtl.new_id FROM  #OutputTbl_dtl
                                              WHERE ##productions.dtl_id=#OutputTbl_dtl.old_id"
                    ホーム.Sql.Parameters.Add("@closingdate", SqlDbType.DateTime).Value = Today
                    ホーム.Sql.ExecuteNonQuery()

                    ホーム.Sql.CommandText = "INSERT INTO productions SELECT * FROM ##productions"
                    ホーム.Sql.ExecuteNonQuery()

                    ホーム.Sql.CommandText = "DROP TABLE ##productions"
                    ホーム.Sql.ExecuteNonQuery()

                End If

                ホーム.Sql.CommandText = "SELECT budget_no,stexpns_code,stexpns_name,stexpns_amount INTO #expense_item FROM site_expenses WHERE budget_no=" & MaxNo & " AND stexpns_id>0"
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = "UPDATE #expense_item SET budget_no =" & MaxNo + 1
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = "SELECT * INTO #siteexpense FROM site_expenses WHERE budget_no=" & MaxNo
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = "ALTER TABLE #siteexpense ADD new_id smallint DEFAULT ((0)) NOT NULL"
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = "CREATE TABLE #OutputTbl_expense (output_id smallint,code smallint)"
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = "INSERT INTO site_expenses OUTPUT inserted.stexpns_id,inserted.stexpns_code INTO #OutputTbl_expense(output_id,code) SELECT * FROM #expense_item"
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = "DROP TABLE #expense_item"
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = "UPDATE #siteexpense SET #siteexpense.new_id=#OutputTbl_expense.output_id FROM #OutputTbl_expense WHERE #siteexpense.stexpns_code=#OutputTbl_expense.code"
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = " CREATE TABLE ##expense_bd (
      [expns_bd_id]      INT             IDENTITY (1, 1) NOT NULL,
    [stexpns_id]       INT             DEFAULT ((0)) NOT NULL,
    [expns_bd_no]      SMALLINT        DEFAULT ((0)) NOT NULL,
    [expns_bd_name]    NVARCHAR (30)   DEFAULT ('') NOT NULL,
    [expns_bd_spec]    NVARCHAR (30)   DEFAULT ((0)) NOT NULL,
    [expns_bd_unit]    NVARCHAR (6)    DEFAULT ('') NOT NULL,
    [expns_bd_quanity] DECIMAL (15, 2) DEFAULT ((0)) NOT NULL,
    [expns_bd_costea]  MONEY           DEFAULT ((0)) NOT NULL);"
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = "INSERT INTO ##expense_bd SELECT expense_breakdowns.stexpns_id,expense_breakdowns.expns_bd_no,
                                          expense_breakdowns.expns_bd_name,expense_breakdowns.expns_bd_spec,expense_breakdowns.expns_bd_unit,expense_breakdowns.expns_bd_quanity,
                                          expense_breakdowns.expns_bd_costea FROM expense_breakdowns 
                                          INNER JOIN #siteexpense ON expense_breakdowns.stexpns_id = #siteexpense.stexpns_id"
                ホーム.Sql.ExecuteNonQuery()


                ホーム.Sql.CommandText = "UPDATE ##expense_bd SET ##expense_bd.stexpns_id=#siteexpense.new_id FROM #siteexpense WHERE ##expense_bd.stexpns_id=#siteexpense.stexpns_id"
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = "INSERT INTO expense_breakdowns SELECT stexpns_id,expns_bd_no,expns_bd_name,expns_bd_spec,
                                          expns_bd_unit,expns_bd_quanity,expns_bd_costea FROM ##expense_bd"
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = "DROP TABLE ##expense_bd"
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = "DROP TABLE #prjctcst"
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = "DROP TABLE #OutputTbl_dtl"
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = "DROP TABLE #siteexpense"
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Transaction.Commit()

                MsgBox("第" & MaxNo + 1 & "回変更データを作成しました。", MsgBoxStyle.OkOnly, "予算選択")

                ホーム.Text = "予算管理システム" & "(第" & MaxNo + 1 & "回変更)" & FilePath.Text
                ホーム.BudgetNo = MaxNo + 1


            Else
                ホーム.Text = "予算管理システム" & "(" & Contract_NoList.SelectedItem & ")" & FilePath.Text
                Dim BudgetNo As String = Contract_NoList.SelectedItem
                BudgetNo = BudgetNo.Replace("第", "")
                BudgetNo = BudgetNo.Replace("回変更", "")
                ホーム.BudgetNo = BudgetNo
            End If

            ホーム.Sql.CommandText = "SELECT Count(budget_no) FROM budget_summary"
            Dim DataCount As Integer = ホーム.Sql.ExecuteScalar

            If DataCount = 0 Then
                ホーム.見積.Enabled = False
                ホーム.外注管理.Enabled = False
                ホーム.参照作成command.Enabled = False
                ホーム.予算内訳登録.Enabled = False
            Else
                ホーム.見積.Enabled = True
                ホーム.外注管理.Enabled = True
                'ホーム.参照作成command.Enabled = True
                ホーム.予算内訳登録.Enabled = True

                ホーム.HomeTreeView.Nodes.Clear()

                ホーム.Sql.CommandText = "SELECT contents FROM controldata WHERE class_code=20"
                Dim ProjectCode As String = ホーム.Sql.ExecuteScalar

                ホーム.Sql.CommandText = "SELECT contents FROM controldata WHERE class_code=21"
                Dim ProjectName As String = ホーム.Sql.ExecuteScalar

                ホーム.HomeTreeView.Columns(0).HeaderText = ProjectCode & " " & ProjectName

                Dim index As Integer = 0
                ホーム.Sql.CommandText = "SELECT DISTINCT l_wrktyp_code,l_wrktyp_name,s_wrktyp_code,s_wrktyp_name FROM L_worktype_total 
                                          WHERE budget_no=" & ホーム.BudgetNo & " OR budget_no IS NULL AND NOT l_wrktyp_code=890
                                          GROUP BY l_wrktyp_code,l_wrktyp_name,s_wrktyp_code,s_wrktyp_name ORDER BY l_wrktyp_code,s_wrktyp_code ASC"
                Dim s_wrktypReader As SqlDataReader = ホーム.Sql.ExecuteReader
                While s_wrktypReader.Read
                    If Not s_wrktypReader.Item("l_wrktyp_code") = 890 Then
                        If ホーム.HomeTreeView.Nodes.Count = 0 Then
                            ホーム.HomeTreeView.Nodes.Add(s_wrktypReader.Item("l_wrktyp_code") & " " & s_wrktypReader.Item("l_wrktyp_name"))
                            ホーム.HomeTreeView.Nodes(index).Nodes.Add(s_wrktypReader.Item("s_wrktyp_code") & " " & s_wrktypReader.Item("s_wrktyp_name"))
                        Else
                            If ホーム.HomeTreeView.Nodes(index).GetValue = s_wrktypReader.Item("l_wrktyp_code") & " " & s_wrktypReader.Item("l_wrktyp_name") Then
                                ホーム.HomeTreeView.Nodes(index).Nodes.Add(s_wrktypReader.Item("s_wrktyp_code") & " " & s_wrktypReader.Item("s_wrktyp_name"))
                            Else
                                ホーム.HomeTreeView.Nodes.Add(s_wrktypReader.Item("l_wrktyp_code") & " " & s_wrktypReader.Item("l_wrktyp_name"))
                                index += 1
                                ホーム.HomeTreeView.Nodes(index).Nodes.Add(s_wrktypReader.Item("s_wrktyp_code") & " " & s_wrktypReader.Item("s_wrktyp_name"))
                            End If

                        End If
                    End If
                End While
                s_wrktypReader.Close()

            End If

            Me.Close()

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub 予算選択_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            If ホーム.UserDataName <> "" Then

                Dim Prjct_Name As String
                Dim Prjct_Code As String

                ホーム.Sql.CommandText = "select max(budget_no) from budget_summary"
                ホーム.BudgetNo = ホーム.Sql.ExecuteScalar

                ホーム.Sql.CommandText = "SELECT contents FROM controldata WHERE class_code=20"
                Prjct_Code = ホーム.Sql.ExecuteScalar

                ホーム.Sql.CommandText = "SELECT contents FROM controldata WHERE class_code=21"
                Prjct_Name = ホーム.Sql.ExecuteScalar

                Contract_NoList.Items.Add("当初")

                For No As Integer = 1 To ホーム.BudgetNo
                    Contract_NoList.Items.Add("第" & No & "回変更")
                Next

                Contract_NoList.Items.Add("変更予算作成")

                If ホーム.BudgetNo = 0 Then
                    Contract_NoList.SelectedItem = "当初"
                Else
                    Contract_NoList.SelectedItem = "第" & ホーム.BudgetNo & "回変更"
                End If

                Project.Value = Prjct_Code & " " & Prjct_Name
                FilePath.Value = ホーム.UserDataPath & ホーム.UserDataName

            Else

                ホーム.Enabled = True
                Me.Close()
            End If

            Cursor.Current = Cursors.Default


        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub
    Private Sub OK_MouseEnter(sender As Object, e As EventArgs) Handles OK.MouseEnter
        OK.Cursor = Cursors.Hand
        OK.ImageIndex = 1
    End Sub

    Private Sub OK_MouseDown(sender As Object, e As MouseEventArgs) Handles OK.MouseDown
        OK.ImageIndex = 2
    End Sub

    Private Sub OK_MouseLeave(sender As Object, e As EventArgs) Handles OK.MouseLeave
        OK.ImageIndex = 0
    End Sub

    Private Sub OK_MouseUp(sender As Object, e As MouseEventArgs) Handles OK.MouseUp
        OK.ImageIndex = 0
    End Sub
End Class