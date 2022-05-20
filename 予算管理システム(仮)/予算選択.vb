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

                ホーム.Sql.CommandText = "SELECT budget_no,cstclss_code,prjctcst_no,prjctcst_name,prjctcst_spec,prjctcst_unit,prjctcst_quanity,
                                        prjctcst_costea,prjctcst_laborea,prjctcst_materialea,prjctcst_machineea,prjctcst_subcntrctea,prjctcst_expenseea 
                                        INTO #projectcost_item FROM project_costs WHERE budget_no=" & MaxNo & " AND prjctcst_id>0"
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = "UPDATE #projectcost_item SET budget_no =" & MaxNo + 1
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = "CREATE TABLE #OutputTbl (new_id INT,no INT,classcode INT)"
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = "INSERT INTO project_costs OUTPUT inserted.prjctcst_id,inserted.prjctcst_no,inserted.cstclss_code INTO #OutputTbl(new_id,no,classcode) SELECT * FROM #projectcost_item"
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = "SELECT budget_no,stexpns_code,stexpns_name,stexpns_amount INTO #site_expenses FROM site_expenses WHERE budget_no=" & MaxNo
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = "UPDATE #site_expenses SET budget_no =" & MaxNo + 1
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = "CREATE TABLE ##OutputTbl_expenses (new_id INT)"
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = "INSERT INTO site_expenses OUTPUT inserted.stexpns_id INTO ##OutputTbl_expenses(new_id) SELECT * FROM #site_expenses"
                ホーム.Sql.ExecuteNonQuery()

                Dim ProcessCommand As New SqlCommand
                Dim ProcessConnection As New SqlConnection
                ProcessConnection.ConnectionString = ホーム.Connection.ConnectionString
                ProcessConnection.Open()
                ProcessCommand.Connection = ProcessConnection



                ProcessCommand.CommandText = "SELECT budget_no,dtl_no,s_worktype_code,cstclss_code,cstmstr_id,dtl_name,dtl_spec,dtl_unit,dtl_quanity,dtl_costea,dtl_labor,
                                            dtl_material,dtl_machine,dtl_subcntrct,dtl_expens,dtl_fraction,dtl_remarks INTO ##details FROM details WHERE budget_no=" & MaxNo
                ProcessCommand.ExecuteNonQuery()

                ProcessCommand.CommandText = "UPDATE ##details SET budget_no=" & MaxNo + 1
                ProcessCommand.ExecuteNonQuery()

                Dim OldIDList_dtl As New List(Of Integer)
                ホーム.Sql.CommandText = "SELECT dtl_id FROM details WHERE budget_no=" & MaxNo
                Dim OldIDReader As SqlDataReader = ホーム.Sql.ExecuteReader
                While OldIDReader.Read
                    OldIDList_dtl.Add(OldIDReader.Item("dtl_id"))
                End While
                OldIDReader.Close()

                Dim OldIDList_expense As New List(Of Integer)
                ホーム.Sql.CommandText = "SELECT stexpns_id FROM site_expenses WHERE budget_no=" & MaxNo
                Dim OldID_expnsReader As SqlDataReader = ホーム.Sql.ExecuteReader
                While OldID_expnsReader.Read
                    OldIDList_expense.Add(OldID_expnsReader.Item("stexpns_id"))
                End While
                OldID_expnsReader.Close()


                Dim ProcessCommand1 As New SqlCommand
                Dim ProcessConnection1 As New SqlConnection
                ProcessConnection1.ConnectionString = ホーム.Connection.ConnectionString
                ProcessConnection1.Open()
                ProcessCommand1.Connection = ProcessConnection1

                Dim OldIDList_prjctcst As New List(Of Integer)
                ホーム.Sql.CommandText = "SELECT prjctcst_id FROM project_costs WHERE budget_no=" & MaxNo
                Dim OldID_prjctcstReader As SqlDataReader = ホーム.Sql.ExecuteReader
                While OldID_prjctcstReader.Read
                    OldIDList_prjctcst.Add(OldID_prjctcstReader.Item("prjctcst_id"))
                End While
                OldID_prjctcstReader.Close()

                Dim Count As Integer = 0
                Dim NewIDList As New List(Of Integer)
                ホーム.Sql.CommandText = "SELECT * FROM #OutputTbl"
                Dim OldIDSelect As SqlDataReader = ホーム.Sql.ExecuteReader
                While OldIDSelect.Read

                    ProcessCommand.CommandText = "SELECT prjctcst_id,cstclss_code,cstmstr_id,prjctcst_bd_no,prjctcst_bd_name,prjctcst_bd_spec,prjctcst_bd_unit,prjctcst_bd_quanity,
                                              prjctcst_bd_costea,prjctcst_bd_labor,prjctcst_bd_material,prjctcst_bd_machine,prjctcst_bd_subcntrct,prjctcst_bd_expense,prjctcst_bd_remarks 
                                              INTO #prjctcst_bd FROM project_cost_breakdowns WHERE prjctcst_id=" & OldIDList_prjctcst.Item(Count)
                    ProcessCommand.ExecuteNonQuery()

                    ProcessCommand.CommandText = "UPDATE #prjctcst_bd SET prjctcst_id=" & OldIDSelect.Item("new_id") & " WHERE prjctcst_id=" & OldIDList_prjctcst.Item(Count)
                    ProcessCommand.ExecuteNonQuery()

                    ProcessCommand.CommandText = "CREATE TABLE #OutputTbl_bd (new_id INT,no INT,classcode INT,cstmstr_id INT)"
                    ProcessCommand.ExecuteNonQuery()

                    ProcessCommand.CommandText = "INSERT INTO project_cost_breakdowns OUTPUT inserted.prjctcst_bd_id,inserted.prjctcst_bd_no,inserted.cstclss_code,inserted.cstmstr_id 
                                               INTO #OutputTbl_bd(new_id,no,classcode,cstmstr_id) SELECT * FROM #prjctcst_bd"
                    ProcessCommand.ExecuteNonQuery()

                    ProcessCommand.CommandText = "SELECT * FROM  #OutputTbl_bd"
                    Dim bdSelect As SqlDataReader = ProcessCommand.ExecuteReader
                    While bdSelect.Read
                        If bdSelect.Item("classcode") = OldIDSelect.Item("classcode") AndAlso bdSelect.Item("cstmstr_id") = OldIDList_prjctcst.Item(Count) Then
                            ProcessCommand1.CommandText = "UPDATE project_cost_breakdowns SET cstmstr_id=" & OldIDSelect.Item("new_id") & " WHERE prjctcst_bd_id=" & bdSelect.Item("new_id")
                            ProcessCommand1.ExecuteNonQuery()
                        End If
                    End While
                    bdSelect.Close()

                    ProcessCommand.CommandText = "UPDATE ##details SET cstmstr_id=" & OldIDSelect.Item("new_id") & " WHERE cstclss_code=" & OldIDSelect.Item("classcode") &
                                                        " AND cstmstr_id=" & OldIDList_prjctcst.Item(Count)
                    ProcessCommand.ExecuteNonQuery()

                    ProcessCommand.CommandText = "DROP TABLE #prjctcst_bd"
                    ProcessCommand.ExecuteNonQuery()

                    ProcessCommand.CommandText = "DROP TABLE #OutputTbl_bd"
                    ProcessCommand.ExecuteNonQuery()

                    Count += 1
                End While
                OldIDSelect.Close()

                ProcessCommand.CommandText = "CREATE TABLE ##OutputTbl_dtl (new_id INT)"
                ProcessCommand.ExecuteNonQuery()

                ProcessCommand.CommandText = "INSERT INTO details OUTPUT inserted.dtl_id INTO ##OutputTbl_dtl(new_id) SELECT * FROM ##details"
                ProcessCommand.ExecuteNonQuery()

                ホーム.Sql.CommandText = "SELECT Count(*) FROM outsourcing_plans WHERE budget_no=" & MaxNo
                Dim OutsourcingCount As Integer = ホーム.Sql.ExecuteScalar

                If OutsourcingCount > 0 Then
                    ホーム.Sql.CommandText = "SELECT MAX(outsrc_no) FROM outsourcing_plans WHERE budget_no=" & MaxNo
                    Dim OutsrcMaxNo As Integer = ホーム.Sql.ExecuteScalar

                    ホーム.Sql.CommandText = "SELECT * INTO ##outsourcing_plans FROM outsourcing_plans WHERE budget_no=" & MaxNo & " AND outsrc_no=" & OutsrcMaxNo
                    ホーム.Sql.ExecuteNonQuery()

                    ホーム.Sql.CommandText = "UPDATE ##outsourcing_plans SET budget_no=" & MaxNo + 1 & ",outsrc_no=" & OutsrcMaxNo + 1 & ",created_date=@createddate"
                    ホーム.Sql.Parameters.Add("@createddate", SqlDbType.DateTime).Value = Today
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
                    ホーム.Sql.CommandText = "UPDATE ##productions SET closing_date=@closingdate"
                    ホーム.Sql.Parameters.Add("@closingdate", SqlDbType.DateTime).Value = Today
                    ホーム.Sql.ExecuteNonQuery()
                End If

                Dim DetailsCount As Integer = 0
                ホーム.Sql.Parameters.Clear()
                ProcessCommand.CommandText = "SELECT * FROM ##OutputTbl_dtl"
                Dim DetailsSelect As SqlDataReader = ProcessCommand.ExecuteReader
                While DetailsSelect.Read

                    If OutsourcingCount > 0 Then
                        ホーム.Sql.CommandText = "UPDATE ##outsourcing_plans SET dtl_id=" & DetailsSelect.Item("new_id") & " WHERE dtl_id=" & OldIDList_dtl.Item(DetailsCount)
                        ホーム.Sql.ExecuteNonQuery()
                    End If
                    If ProductionsCount > 0 Then
                        ホーム.Sql.CommandText = "UPDATE ##productions SET dtl_id=" & DetailsSelect.Item("new_id") & " WHERE dtl_id=" & OldIDList_dtl.Item(DetailsCount)
                        ホーム.Sql.ExecuteNonQuery()
                    End If
                    DetailsCount += 1
                End While
                DetailsSelect.Close()

                If OutsourcingCount > 0 Then
                    ホーム.Sql.CommandText = "INSERT INTO outsourcing_plans SELECT * FROM ##outsourcing_plans"
                    ホーム.Sql.ExecuteNonQuery()
                End If

                If ProductionsCount > 0 Then
                    ホーム.Sql.CommandText = "INSERT INTO productions SELECT * FROM ##productions"
                    ホーム.Sql.ExecuteNonQuery()
                End If

                Dim StexpnsCount As Integer = 0
                ホーム.Sql.CommandText = "SELECT * FROM ##OutputTbl_expenses"
                Dim OldID_StexpnsSelect As SqlDataReader = ホーム.Sql.ExecuteReader
                While OldID_StexpnsSelect.Read

                    ProcessCommand.CommandText = "SELECT stexpns_id,expns_bd_no,expns_bd_name,expns_bd_spec,expns_bd_unit,expns_bd_quanity,expns_bd_costea INTO #expense_bd FROM expense_breakdowns WHERE stexpns_id=" & OldIDList_expense.Item(StexpnsCount)
                    ProcessCommand.ExecuteNonQuery()

                    ProcessCommand.CommandText = "UPDATE #expense_bd SET stexpns_id=" & OldID_StexpnsSelect.Item("new_id") & " WHERE stexpns_id=" & OldIDList_expense.Item(StexpnsCount)
                    ProcessCommand.ExecuteNonQuery()

                    ProcessCommand.CommandText = "INSERT INTO expense_breakdowns SELECT * FROM #expense_bd"
                    ProcessCommand.ExecuteNonQuery()

                    ProcessCommand.CommandText = "DROP TABLE #expense_bd"
                    ProcessCommand.ExecuteNonQuery()

                    StexpnsCount += 1
                End While
                OldID_StexpnsSelect.Close()

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
                ホーム.参照作成command.Enabled = True
                ホーム.予算内訳登録.Enabled = True

                ホーム.HomeTreeView.Nodes.Clear()

                ホーム.Sql.CommandText = "SELECT contents FROM controldata WHERE class_code=20"
                Dim ProjectCode As String = ホーム.Sql.ExecuteScalar

                ホーム.Sql.CommandText = "SELECT contents FROM controldata WHERE class_code=21"
                Dim ProjectName As String = ホーム.Sql.ExecuteScalar

                ホーム.HomeTreeView.Columns(0).HeaderText = ProjectCode & " " & ProjectName

                Dim index As Integer = 0
                ホーム.Sql.CommandText = "SELECT DISTINCT l_wrktyp_code,l_wrktyp_name,s_wrktyp_code,s_wrktyp_name FROM L_worktype_total 
                                          WHERE budget_no=" & ホーム.BudgetNo & " AND NOT l_wrktyp_code=890 
                                          GROUP BY l_wrktyp_code,l_wrktyp_name,s_wrktyp_code,s_wrktyp_name ORDER BY l_wrktyp_code,s_wrktyp_code ASC"
                Dim s_wrktypReader As SqlDataReader = ホーム.Sql.ExecuteReader
                While s_wrktypReader.Read

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