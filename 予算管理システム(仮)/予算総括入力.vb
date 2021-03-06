Imports C1.Win.C1FlexGrid
Imports System.Windows.Forms.Form
Imports C1.Win.C1Command
Imports System.Data.SqlClient
Public Class 予算総括入力

    Dim DrctCnstrctnCstValue As Int64 = 0
    Dim TmprryExpnssValue As Int64 = 0
    Dim MtrldffrncValue As Int64 = 0
    Dim ExpectedTotalValue As Int64 = 0
    Dim SiteCostsValue As Int64 = 0
    Dim FormLoad As String = "False"

    Private Sub 予算総括入力_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.KeyPreview = True

            FormLoad = "True"

            Director.AutoCompleteCustomSource = ホーム.AutoCmpCllctn
            Manager.AutoCompleteCustomSource = ホーム.AutoCmpCllctn
            Chief.AutoCompleteCustomSource = ホーム.AutoCmpCllctn
            Expert1.AutoCompleteCustomSource = ホーム.AutoCmpCllctn
            Expert2.AutoCompleteCustomSource = ホーム.AutoCmpCllctn
            Expert3.AutoCompleteCustomSource = ホーム.AutoCmpCllctn
            Staff1.AutoCompleteCustomSource = ホーム.AutoCmpCllctn
            Staff2.AutoCompleteCustomSource = ホーム.AutoCmpCllctn
            Staff3.AutoCompleteCustomSource = ホーム.AutoCmpCllctn
            Staff4.AutoCompleteCustomSource = ホーム.AutoCmpCllctn

            OutsoucersList.Cols(0).ShowButtons = ShowButtonsEnum.Always

            ホーム.SystemSql.CommandText = "SELECT year FROM years ORDER BY year DESC"
            Dim YearsReader As SqlDataReader = ホーム.SystemSql.ExecuteReader
            While YearsReader.Read
                Year.Items.Add(YearsReader.Item("year"))
            End While
            YearsReader.Close()

            ホーム.SystemSql.CommandText = "SELECT item_name,class_code FROM name_masters WHERE class_code<=2"
            Dim CompanyReader As SqlDataReader = ホーム.SystemSql.ExecuteReader
            While CompanyReader.Read
                If CompanyReader.Item("class_code") = 1 Then
                    Company.Items.Add(CompanyReader.Item("item_name"))
                Else
                    BdgtDprtmnt.Items.Add(CompanyReader.Item("item_name"))
                End If
            End While
            CompanyReader.Close()

            For AuthorizerCount As Integer = 1 To 5
                ホーム.SystemMdf.CommandText = "SELECT contents FROM controldata WHERE class_code=" & 9 + AuthorizerCount
                AuthorizerPanel.Controls.Item("Authorizer" & AuthorizerCount).Text = ホーム.SystemMdf.ExecuteScalar
            Next

            For CirculatorCount As Integer = 1 To 5
                ホーム.SystemMdf.CommandText = "SELECT contents FROM controldata WHERE class_code=" & 19 + CirculatorCount
                CirculatorPanel.Controls.Item("Circulator" & CirculatorCount).Text = ホーム.SystemMdf.ExecuteScalar
            Next


            ホーム.Sql.CommandText = "SELECT Count(*) FROM budget_summary WHERE budget_no=" & ホーム.BudgetNo
            Dim BudgetCount As Integer = ホーム.Sql.ExecuteScalar

            If BudgetCount > 0 Then

                Dim ClassCode(5) As Integer
                Dim ControlName(5) As String
                ClassCode(0) = 11
                ClassCode(1) = 12
                ClassCode(2) = 20
                ClassCode(3) = 21
                ClassCode(4) = 22
                ClassCode(5) = 23
                ControlName(0) = "Company"
                ControlName(1) = "Year"
                ControlName(2) = "ProjectCode"
                ControlName(3) = "ProjectName"
                ControlName(4) = "ProjectAddress"
                ControlName(5) = "Contractee"

                For ControlCount As Integer = 0 To 5
                    ホーム.Sql.CommandText = "SELECT contents FROM controldata WHERE class_code=" & ClassCode(ControlCount)
                    FormPanel.Controls.Item(ControlName(ControlCount)).Text = ホーム.Sql.ExecuteScalar
                Next

                Dim subcntrctratecode As Integer = 0
                ホーム.Sql.CommandText = "SELECT * FROM budget_summary WHERE budget_no=" & ホーム.BudgetNo
                Dim BudgetReader As SqlDataReader = ホーム.Sql.ExecuteReader
                While BudgetReader.Read
                    TermS.Value = BudgetReader.Item("prjct_term_s")
                    TermE.Value = BudgetReader.Item("prjct_term_e")
                    Amount.Value = BudgetReader.Item("cntrct_amount")
                    Category.Value = BudgetReader.Item("prjct_category")
                    If Not BudgetReader.Item("cnsdrtn_date") = DateTime.Parse("1900/01/01") Then
                        CnsdrtnDate.Value = BudgetReader.Item("cnsdrtn_date")
                    End If
                    Summary.Value = BudgetReader.Item("prjct_summary")
                    Remarks.Value = BudgetReader.Item("remarks")
                    Department.Value = BudgetReader.Item("department")
                    Director.Value = BudgetReader.Item("director")
                    Manager.Value = BudgetReader.Item("manager")
                    Chief.Value = BudgetReader.Item("chief")
                    Expert1.Value = BudgetReader.Item("expert_1")
                    Expert2.Value = BudgetReader.Item("expert_2")
                    Expert3.Value = BudgetReader.Item("expert_3")
                    Staff1.Value = BudgetReader.Item("staff_1")
                    Staff2.Value = BudgetReader.Item("staff_2")
                    Staff3.Value = BudgetReader.Item("staff_3")
                    Staff4.Value = BudgetReader.Item("staff_4")
                    BdgtDprtmnt.Value = BudgetReader.Item("bdgt_dprtmnt")
                    ExpenseRate.Value = BudgetReader.Item("expense_rate")
                    subcntrctratecode = BudgetReader.Item("sbcntrct_rate_code")
                End While
                BudgetReader.Close()

                ProjectAmount.Value = Amount.Value

                If subcntrctratecode = 0 Then
                    Others.Checked = True
                Else

                    ホーム.SystemSql.CommandText = "SELECT * FROM name_masters WHERE class_code=6 AND detail_code=" & subcntrctratecode
                    Dim MasterReader As SqlDataReader = ホーム.SystemSql.ExecuteReader
                    While MasterReader.Read
                        Dim ItemName As String = MasterReader.Item("item_name")
                        Dim RateNo As Integer = Integer.Parse(ItemName.Last)
                        If ItemName.Contains("岐阜県") = True Then
                            Prefecture.Checked = True
                        ElseIf ItemName.Contains("岐阜市") = True Then
                            City.Checked = True
                        End If

                        If RateNo = 1 Then
                            Rate1.Checked = True
                        ElseIf RateNo = 2 Then
                            Rate2.Checked = True
                        ElseIf RateNo = 3 Then
                            Rate3.Checked = True
                        End If
                    End While
                    MasterReader.Close()

                End If


            End If

            ホーム.Sql.CommandText = "SELECT Count(*) FROM site_expenses WHERE budget_no=" & ホーム.BudgetNo
            Dim SiteExpenseCount As Integer = ホーム.Sql.ExecuteScalar
            If SiteExpenseCount > 0 Then
                ホーム.Sql.CommandText = "SELECT SUM(stexpns_amount) FROM site_expenses WHERE budget_no=" & ホーム.BudgetNo
                If IsDBNull(ホーム.Sql.ExecuteScalar) = False Then
                    SiteCostsValue = ホーム.Sql.ExecuteScalar
                    SiteCosts.Value = SiteCostsValue
                End If
            End If

            ホーム.Sql.CommandText = "SELECT Count(*) FROM details WHERE budget_no=" & ホーム.BudgetNo
            Dim DetailCount As Integer = ホーム.Sql.ExecuteScalar
            If DetailCount > 0 Then
                ホーム.Sql.CommandText = "SELECT SUM(dtl_quanity * dtl_costea) FROM details WHERE budget_no=" & ホーム.BudgetNo & " AND s_worktype_code <200"
                If IsDBNull(ホーム.Sql.ExecuteScalar) = False Then
                    DrctCnstrctnCstValue = ホーム.Sql.ExecuteScalar
                    DrctCnstrctnCst.Value = DrctCnstrctnCstValue
                End If

                ホーム.Sql.CommandText = "SELECT SUM(dtl_quanity * dtl_costea) FROM details WHERE budget_no=" & ホーム.BudgetNo & " AND s_worktype_code>=200 AND s_worktype_code <800"
                If IsDBNull(ホーム.Sql.ExecuteScalar) = False Then
                    TmprryExpnssValue = ホーム.Sql.ExecuteScalar
                    TmprryExpnss.Value = TmprryExpnssValue
                End If

                ホーム.Sql.CommandText = "SELECT SUM(dtl_quanity * dtl_costea) FROM details WHERE budget_no=" & ホーム.BudgetNo & " AND s_worktype_code=861"
                If IsDBNull(ホーム.Sql.ExecuteScalar) = False Then
                    MtrldffrncValue = ホーム.Sql.ExecuteScalar
                    Mtrldffrnc.Value = MtrldffrncValue
                End If

                ホーム.Sql.CommandText = "SELECT SUM(dtl_quanity * dtl_costea) FROM details WHERE budget_no=" & ホーム.BudgetNo & " AND s_worktype_code=881"
                If IsDBNull(ホーム.Sql.ExecuteScalar) = False Then
                    ExpectedTotalValue = ホーム.Sql.ExecuteScalar
                    ExpectedTotal.Value = ExpectedTotalValue
                End If



                SubTotal.Value = DrctCnstrctnCstValue + TmprryExpnssValue + MtrldffrncValue + ExpectedTotalValue
                ConstractionCost.Value = SubTotal.Value + SiteCostsValue
                ProfitAndLoss.Value = Amount.Value - ConstractionCost.Value
                DrctCnstrctnCstRt.Value = Math.Round((DrctCnstrctnCstValue / Amount.Value) * 100, 1, MidpointRounding.AwayFromZero)
                TmprryExpnssRate.Value = Math.Round((TmprryExpnssValue / Amount.Value) * 100, 1, MidpointRounding.AwayFromZero)
                MtrldffrncRate.Value = Math.Round((MtrldffrncValue / Amount.Value) * 100, 1, MidpointRounding.AwayFromZero)
                ExpectedTotalRate.Value = Math.Round((ExpectedTotalValue / Amount.Value) * 100, 1, MidpointRounding.AwayFromZero)
                SubTotalRate.Value = Math.Round((SubTotal.Value / Amount.Value) * 100, 1, MidpointRounding.AwayFromZero)
                SiteCostsRate.Value = Math.Round((SiteCostsValue / Amount.Value) * 100, 1, MidpointRounding.AwayFromZero)
                ConstractionCostRate.Value = Math.Round((ConstractionCost.Value / Amount.Value) * 100, 1, MidpointRounding.AwayFromZero)
                ProfitAndLossRate.Value = Math.Round((ProfitAndLoss.Value / Amount.Value) * 100, 1, MidpointRounding.AwayFromZero)

            End If

            ホーム.Sql.CommandText = "SELECT Count(*) FROM outsourcers"
            Dim OutsourcersCount As Integer = ホーム.Sql.ExecuteScalar

            If OutsourcersCount > 0 Then
                Dim DataCount As Integer = 0

                ホーム.Sql.CommandText = "SELECT * FROM outsourcers"
                Dim OutsourcersReader As SqlDataReader = ホーム.Sql.ExecuteReader
                While OutsourcersReader.Read
                    DataCount += 1
                    OutsoucersList(DataCount, 1) = OutsourcersReader.Item("outsrcr_id")
                    OutsoucersList(DataCount, 3) = OutsourcersReader.Item("outsrcr_code")
                    OutsoucersList(DataCount, 4) = OutsourcersReader.Item("outsrcr_name")
                    OutsoucersList(DataCount, 5) = OutsourcersReader.Item("outsrcr_name_ryaku")
                    OutsoucersList(DataCount, 6) = OutsourcersReader.Item("worktype")
                End While
                OutsourcersReader.Close()
            End If


            ホーム.Modified = "False"
            FormLoad = "False"


        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try


    End Sub
    Private Sub OutsoucersList_CellButtonClick(sender As Object, e As C1.Win.C1FlexGrid.RowColEventArgs) Handles OutsoucersList.CellButtonClick
        Try
            If Company.Text <> "" Then
                業者一覧.ParentFormName = "予算総括入力"
                業者一覧.Show()
                業者一覧.SelectRowIndex = e.Row
            Else
                MsgBox("会社名を選択して下さい。", MsgBoxStyle.Exclamation, "予算総括入力")
                Exit Sub
            End If

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub
    Private Sub Cancel_MouseDown(sender As Object, e As MouseEventArgs) Handles Cancel.MouseDown
        Cancel.ImageIndex = 8
    End Sub

    Private Sub Cancel_MouseEnter(sender As Object, e As EventArgs) Handles Cancel.MouseEnter
        Cancel.Cursor = Cursors.Hand
        Cancel.ImageIndex = 7
    End Sub

    Private Sub Cancel_MouseLeave(sender As Object, e As EventArgs) Handles Cancel.MouseLeave
        Cancel.ImageIndex = 6
    End Sub

    Private Sub Cancel_MouseUp(sender As Object, e As MouseEventArgs) Handles Cancel.MouseUp
        Cancel.ImageIndex = 6
    End Sub

    Private Sub Entry_MouseUp(sender As Object, e As MouseEventArgs) Handles Entry.MouseUp
        Entry.ImageIndex = 3
    End Sub
    Private Sub Entry_MouseDown(sender As Object, e As MouseEventArgs) Handles Entry.MouseDown
        Entry.ImageIndex = 5
    End Sub

    Private Sub Entry_MouseEnter(sender As Object, e As EventArgs) Handles Entry.MouseEnter
        Entry.Cursor = Cursors.Hand
        Entry.ImageIndex = 4
    End Sub

    Private Sub Entry_MouseLeave(sender As Object, e As EventArgs) Handles Entry.MouseLeave
        Entry.ImageIndex = 3
    End Sub

    Private Sub Entry_Click(sender As Object, e As EventArgs) Handles Entry.Click

        Me.ImeMode = ImeMode.On

        Dim ErrorText As String = ""

        For CntrlCnt As Integer = 0 To FormPanel.Controls.Count - 1

            If Not FormPanel.Controls.Item(CntrlCnt).Text <> "" Then
                If FormPanel.Controls.Item(CntrlCnt).Name = "Company" Or FormPanel.Controls.Item(CntrlCnt).Name = "ProjectCode" Or
                       FormPanel.Controls.Item(CntrlCnt).Name = "ProjectName" Or FormPanel.Controls.Item(CntrlCnt).Name = "Amount" Or
                       FormPanel.Controls.Item(CntrlCnt).Name = "TermS" Or FormPanel.Controls.Item(CntrlCnt).Name = "TermE" Or
                       FormPanel.Controls.Item(CntrlCnt).Name = "Year" Then

                    FormPanel.Controls.Item(CntrlCnt).BackColor = Color.FromArgb(255, 192, 192)

                    ErrorText = "必須項目が入力されていません。"

                End If
            Else
                If FormPanel.Controls.Item(CntrlCnt).Name.Contains("Label") = False Then
                    FormPanel.Controls.Item(CntrlCnt).BackColor = Color.White
                End If
            End If
        Next

        If Not ErrorText <> "" AndAlso TermS.Text >= TermE.Text Then
            TermE.BackColor = Color.FromArgb(255, 192, 192)
            ErrorText += vbCrLf & "工期が適切ではありません。"
        ElseIf Not ErrorText <> "" AndAlso TermS.Text < TermE.Text Then
            TermE.BackColor = Color.White
        End If

        If ErrorText <> "" Then
            MsgBox(ErrorText, MsgBoxStyle.Exclamation, "入力エラー")
            Exit Sub
        End If

        ホーム.Transaction = ホーム.Connection.BeginTransaction

        Try

            ホーム.Sql.CommandText = ""
            ホーム.Sql.Parameters.Clear()

            ホーム.Sql.Transaction = ホーム.Transaction

            Dim ControlData(5, 1) As String
            ControlData(0, 0) = 11
            ControlData(0, 1) = Company.Value
            ControlData(1, 0) = 12
            ControlData(1, 1) = Year.Text
            ControlData(2, 0) = 20
            ControlData(2, 1) = ProjectCode.Text
            ControlData(3, 0) = 21
            ControlData(3, 1) = ProjectName.Text
            ControlData(4, 0) = 22
            ControlData(4, 1) = Contractee.Text
            ControlData(5, 0) = 23
            ControlData(5, 1) = ProjectAddress.Text

            ホーム.Sql.Parameters.Add(New SqlParameter("@classcode", SqlDbType.SmallInt))
            ホーム.Sql.Parameters.Add(New SqlParameter("@contents", SqlDbType.NVarChar))
            ホーム.SystemMdf.Parameters.Add(New SqlParameter("@classcode", SqlDbType.SmallInt))
            ホーム.SystemMdf.Parameters.Add(New SqlParameter("@contents", SqlDbType.NVarChar))

            For ControlDataCount As Integer = 0 To 5
                ホーム.Sql.CommandText = "UPDATE controldata SET contents=@contents WHERE class_code=@classcode"
                ホーム.Sql.Parameters("@classcode").Value = ControlData(ControlDataCount, 0)
                ホーム.Sql.Parameters("@contents").Value = ControlData(ControlDataCount, 1)
                ホーム.Sql.ExecuteNonQuery()
            Next

            For AuthorizerCount As Integer = 1 To 5
                ホーム.SystemMdf.CommandText = "UPDATE controldata SET contents=@contents WHERE class_code=@classcode"
                ホーム.SystemMdf.Parameters("@classcode").Value = 9 + AuthorizerCount
                ホーム.SystemMdf.Parameters("@contents").Value = AuthorizerPanel.Controls.Item("Authorizer" & AuthorizerCount).Text
                ホーム.SystemMdf.ExecuteNonQuery()
            Next

            For CirculatorCount As Integer = 1 To 5
                ホーム.SystemMdf.CommandText = "UPDATE controldata SET contents=@contents WHERE class_code=@classcode"
                ホーム.SystemMdf.Parameters("@classcode").Value = 19 + CirculatorCount
                ホーム.SystemMdf.Parameters("@contents").Value = CirculatorPanel.Controls.Item("Circulator" & CirculatorCount).Text
                ホーム.SystemMdf.ExecuteNonQuery()
            Next

            ホーム.Sql.CommandText = ""
            ホーム.Sql.Parameters.Clear()

            ホーム.Sql.CommandText = "SELECT Count(budget_no) FROM budget_summary"
            Dim DataCount As Integer = ホーム.Sql.ExecuteScalar


            Dim sbcntrctratecode As Integer = 0
            Dim itemname As String = ""

            If Prefecture.Checked = True Then
                itemname = "岐阜県"
            ElseIf City.Checked = True Then
                itemname = "岐阜市"
            End If

            If Rate1.Checked = True Then
                itemname = itemname & "1"
            ElseIf Rate2.Checked = True Then
                itemname = itemname & "2"
            ElseIf Rate3.Checked = True Then
                itemname = itemname & "3"
            End If

            ホーム.SystemSql.CommandText = "SELECT detail_code FROM name_masters WHERE item_name=@itemname"
            ホーム.SystemSql.Parameters.Add("@itemname", SqlDbType.NVarChar).Value = itemname
            sbcntrctratecode = ホーム.SystemSql.ExecuteScalar

            ホーム.SystemSql.Parameters.Clear()

            ホーム.Sql.Parameters.Add(New SqlParameter("@budgetno", SqlDbType.SmallInt)).Value = Integer.Parse(ホーム.BudgetNo)
            ホーム.Sql.Parameters.Add(New SqlParameter("@terms", SqlDbType.DateTime)).Value = DateTime.Parse(TermS.Text)
            ホーム.Sql.Parameters.Add(New SqlParameter("@terme", SqlDbType.DateTime)).Value = DateTime.Parse(TermE.Text)
            ホーム.Sql.Parameters.Add(New SqlParameter("@amount", SqlDbType.Money)).Value = Amount.Value
            ホーム.Sql.Parameters.Add(New SqlParameter("@category", SqlDbType.NVarChar)).Value = Category.Text
            If Not CnsdrtnDate.Text <> "" Then
                ホーム.Sql.Parameters.Add(New SqlParameter("@cnsdrtndate", SqlDbType.DateTime)).Value = DateTime.Parse("1900/01/01")
            Else
                ホーム.Sql.Parameters.Add(New SqlParameter("@cnsdrtndate", SqlDbType.DateTime)).Value = DateTime.Parse(CnsdrtnDate.Text)
            End If
            ホーム.Sql.Parameters.Add(New SqlParameter("@summary", SqlDbType.NVarChar)).Value = Summary.Text
            ホーム.Sql.Parameters.Add(New SqlParameter("@subcontractrate", SqlDbType.SmallInt)).Value = sbcntrctratecode
            ホーム.Sql.Parameters.Add(New SqlParameter("@remarks", SqlDbType.NVarChar)).Value = Remarks.Text
            ホーム.Sql.Parameters.Add(New SqlParameter("@department", SqlDbType.NVarChar)).Value = Department.Text
            ホーム.Sql.Parameters.Add(New SqlParameter("@director", SqlDbType.NVarChar)).Value = Director.Text
            ホーム.Sql.Parameters.Add(New SqlParameter("@manager", SqlDbType.NVarChar)).Value = Manager.Text
            ホーム.Sql.Parameters.Add(New SqlParameter("@chief", SqlDbType.NVarChar)).Value = Chief.Text
            ホーム.Sql.Parameters.Add(New SqlParameter("@expert1", SqlDbType.NVarChar)).Value = Expert1.Text
            ホーム.Sql.Parameters.Add(New SqlParameter("@expert2", SqlDbType.NVarChar)).Value = Expert2.Text
            ホーム.Sql.Parameters.Add(New SqlParameter("@expert3", SqlDbType.NVarChar)).Value = Expert3.Text
            ホーム.Sql.Parameters.Add(New SqlParameter("@staff1", SqlDbType.NVarChar)).Value = Staff1.Text
            ホーム.Sql.Parameters.Add(New SqlParameter("@staff2", SqlDbType.NVarChar)).Value = Staff2.Text
            ホーム.Sql.Parameters.Add(New SqlParameter("@staff3", SqlDbType.NVarChar)).Value = Staff3.Text
            ホーム.Sql.Parameters.Add(New SqlParameter("@staff4", SqlDbType.NVarChar)).Value = Staff4.Text
            ホーム.Sql.Parameters.Add(New SqlParameter("@bdgtdprtmnt", SqlDbType.NVarChar)).Value = BdgtDprtmnt.Text
            If IsDBNull(ExpenseRate.Value) = False Then
                ホーム.Sql.Parameters.Add(New SqlParameter("@expenserate", SqlDbType.Decimal)).Value = Decimal.Parse(ExpenseRate.Value)
            Else
                ホーム.Sql.Parameters.Add(New SqlParameter("@expenserate", SqlDbType.Decimal)).Value = 0
            End If
            If DataCount >= 1 Then

                ホーム.Sql.CommandText = "UPDATE budget_summary SET prjct_term_s=@terms,prjct_term_e=@terme,cntrct_amount=@amount,prjct_category=@category 
                                        ,cnsdrtn_date=@cnsdrtndate,prjct_summary=@summary,sbcntrct_rate_code=@subcontractrate,remarks=@remarks,department=@department,director=@director
                                        ,manager=@manager,chief=@chief,expert_1=@expert1,expert_2=@expert2,expert_3=@expert3,staff_1=@staff1,staff_2=@staff2
                                        ,staff_3=@staff3,staff_4=@staff4,bdgt_dprtmnt=@bdgtdprtmnt,expense_rate=@expenserate WHERE budget_no=@budgetno"
            Else

                ホーム.Sql.CommandText = "INSERT INTO budget_summary (budget_no,prjct_term_s,prjct_term_e,cntrct_amount,prjct_category,cnsdrtn_date,prjct_summary
                                                                   ,sbcntrct_rate_code,remarks,department,director,manager,chief,expert_1,expert_2
                                                                    ,expert_3,staff_1,staff_2,staff_3,staff_4,bdgt_dprtmnt,expense_rate) 
                                      VALUES (@budgetno,@terms,@terme,@amount,@category,@cnsdrtndate,@summary,@subcontractrate,@remarks,@department,
                                              @director,@manager,@chief,@expert1,@expert2,@expert3,@staff1,@staff2,@staff3,@staff4,@bdgtdprtmnt,@expenserate)"


            End If
            ホーム.Sql.ExecuteNonQuery()

            Dim ListRowCount As Integer = OutsoucersList.Rows.Count
            For ListRow As Integer = 0 To ListRowCount - 2

                ホーム.Sql.CommandText = ""
                ホーム.Sql.Parameters.Clear()

                Dim IDCell As Integer = OutsoucersList(ListRow + 1, 1)
                Dim DeleteCell As String = "False"
                If IsNothing(OutsoucersList(ListRow + 1, 2)) = False Then
                    DeleteCell = "True"
                End If


                Dim OutsrcrCodeCell As Integer = OutsoucersList(ListRow + 1, 3)
                Dim OutsrceNameCell As String = OutsoucersList(ListRow + 1, 4)
                Dim OutsrceNameRyaku As String = OutsoucersList(ListRow + 1, 5)
                Dim WorkTypeCell As String = OutsoucersList(ListRow + 1, 6)
                If IsNothing(OutsoucersList(ListRow + 1, 6)) = True Then
                    WorkTypeCell = ""
                End If

                If Not IDCell = 0 AndAlso DeleteCell = "False" Then
                    ホーム.Sql.CommandText = "UPDATE outsourcers SET worktype=@worktype WHERE outsrcr_id=" & IDCell
                    ホーム.Sql.Parameters.Add(New SqlParameter("@worktype", SqlDbType.NVarChar)).Value = WorkTypeCell
                    ホーム.Sql.ExecuteNonQuery()

                ElseIf IDCell = 0 AndAlso OutsrceNameCell <> "" AndAlso DeleteCell = "False" Then
                    ホーム.Sql.CommandText = "INSERT INTO outsourcers (outsrcr_code,outsrcr_name,outsrcr_name_ryaku,outsrcr_term_s,outsrcr_term_e,worktype,ordrfrm,e_cntrct) 
                                                VALUES (@code,@name,@ryaku,@terms,@terme,@worktype,@ordrfrm,@ecntrct)"
                    ホーム.Sql.Parameters.Add(New SqlParameter("@code", SqlDbType.Int)).Value = Integer.Parse(OutsrcrCodeCell)
                    ホーム.Sql.Parameters.Add(New SqlParameter("@name", SqlDbType.NVarChar)).Value = OutsrceNameCell
                    ホーム.Sql.Parameters.Add(New SqlParameter("@ryaku", SqlDbType.NVarChar)).Value = OutsrceNameRyaku
                    ホーム.Sql.Parameters.Add(New SqlParameter("@terms", SqlDbType.DateTime)).Value = DateTime.Parse(TermS.Text)
                    ホーム.Sql.Parameters.Add(New SqlParameter("@terme", SqlDbType.DateTime)).Value = DateTime.Parse(TermE.Text)
                    ホーム.Sql.Parameters.Add(New SqlParameter("@worktype", SqlDbType.NVarChar)).Value = WorkTypeCell
                    ホーム.Sql.Parameters.Add(New SqlParameter("@ordrfrm", SqlDbType.SmallInt)).Value = 0
                    ホーム.Sql.Parameters.Add(New SqlParameter("@ecntrct", SqlDbType.NVarChar)).Value = ""
                    ホーム.Sql.ExecuteNonQuery()

                ElseIf Not IDCell = 0 AndAlso DeleteCell = "True" Then
                    ホーム.Sql.CommandText = "DELETE FROM outsourcers WHERE outsrcr_id=" & IDCell
                    ホーム.Sql.ExecuteNonQuery()


                End If

            Next


            ListRowCount = OutsoucersList.Rows.Count - 2

            For ListRow As Integer = 0 To ListRowCount

                If ListRow + 1 < ListRowCount Then
                    Dim IDCell As Integer = OutsoucersList(ListRow + 1, 1)
                    Dim DeleteCell As String = "False"

                    If IsNothing(OutsoucersList(ListRow + 1, 2)) = False Then
                        DeleteCell = "True"
                    End If

                    If DeleteCell = "True" Then
                        OutsoucersList.Rows.RemoveRange(ListRow + 1, 1)
                        ListRowCount = ListRowCount - 1
                    End If
                End If
            Next


            ホーム.Sql.CommandText = "SELECT Count(*) FROM cost_masters"
            Dim costmastercount As Integer = ホーム.Sql.ExecuteScalar

            If costmastercount = 0 Then
                ホーム.Sql.CommandText = "INSERT INTO cost_masters SELECT cstclss_code,cstmstr_category,cstmstr_code,cstmstr_name,cstmstr_spec,cstmstr_unit,cstmstr_costea,changecode,cstmstr_seq FROM [SVACD001].[PMS].[dbo].[cost_masters] WHERE year=" & Year.Text
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = "SELECT stexpns_id,expns_bd_no,expns_bd_name,expns_bd_spec,expns_bd_unit,expns_bd_costea INTO #expense_bd FROM [SVACD001].[PMS].[dbo].[expense_breakdowns] WHERE year=" & Year.Text
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = "ALTER TABLE #expense_bd ADD expns_bd_quanity decimal(15,2)  DEFAULT ((0)) NOT NULL"
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = "INSERT INTO expense_breakdowns SELECT stexpns_id,expns_bd_no,expns_bd_name,expns_bd_spec,expns_bd_unit,expns_bd_quanity,expns_bd_costea FROM #expense_bd"
                ホーム.Sql.ExecuteNonQuery()
            End If

            ホーム.Transaction.Commit()

            ホーム.見積.Enabled = True
            ホーム.出力.Enabled = True
            ホーム.外注管理.Enabled = True
            ホーム.Modified = "False"
            ホーム.予算内訳登録.Enabled = True


            MsgBox("登録完了", MsgBoxStyle.OkOnly, "予算総括登録")

            ホーム.Sql.CommandText = ""
            ホーム.Sql.Parameters.Clear()
            ホーム.SystemMdf.CommandText = ""
            ホーム.SystemMdf.Parameters.Clear()


        Catch ex As Exception
            ホーム.Transaction.Rollback()
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try




    End Sub

    Private Sub ProjectCode_ValueChanged(sender As Object, e As EventArgs) Handles ProjectCode.ValueChanged, TermS.ValueChanged, TermE.ValueChanged, Summary.ValueChanged, SubContractRate.ValueChanged, Staff4.ValueChanged, Staff3.ValueChanged, Staff2.ValueChanged, Staff1.ValueChanged, Remarks.ValueChanged, ProjectName.ValueChanged, ProjectAddress.ValueChanged, Manager.ValueChanged, Expert3.ValueChanged, Expert2.ValueChanged, Expert1.ValueChanged, ExpenseRate.ValueChanged, Director.ValueChanged, Department.ValueChanged, Contractee.ValueChanged, Chief.ValueChanged, Category.ValueChanged, Year.ValueChanged, Company.ValueChanged
        Try
            If FormLoad = "False" Then
                ホーム.Modified = "True"
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Try
            Me.ImeMode = ImeMode.On
            Dim CancelClick As String = ""

            Dim CancelClickLoad As New CancelClick(Me)
            CancelClick = CancelClickLoad.ModifyCheck
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub BdgtDprtmnt_SelectedItemChanged(sender As Object, e As EventArgs) Handles BdgtDprtmnt.SelectedItemChanged
        Try
            ホーム.SystemSql.CommandText = "SELECT item_value FROM name_masters WHERE class_code=2 AND item_name='" & BdgtDprtmnt.SelectedItem & "'"
            ExpenseRate.Value = ホーム.SystemSql.ExecuteScalar

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub Amount_ValueChanged(sender As Object, e As EventArgs) Handles Amount.ValueChanged

        Try
            If FormLoad = "False" Then
                ホーム.Sql.CommandText = "SELECT Count(*) FROM details WHERE budget_no=" & ホーム.BudgetNo
                Dim DetailsCount As Integer = ホーム.Sql.ExecuteScalar


                ホーム.Modified = "True"
                If IsDBNull(Amount.Value) = False AndAlso DetailsCount > 0 Then
                    ProjectAmount.Value = Amount.Value
                    ProfitAndLoss.Value = Amount.Value - ConstractionCost.Value
                    DrctCnstrctnCstRt.Value = Math.Round((DrctCnstrctnCstValue / Amount.Value) * 100, 1, MidpointRounding.AwayFromZero)
                    TmprryExpnssRate.Value = Math.Round((TmprryExpnssValue / Amount.Value) * 100, 1, MidpointRounding.AwayFromZero)
                    MtrldffrncRate.Value = Math.Round((MtrldffrncValue / Amount.Value) * 100, 1, MidpointRounding.AwayFromZero)
                    ExpectedTotalRate.Value = Math.Round((ExpectedTotalValue / Amount.Value) * 100, 1, MidpointRounding.AwayFromZero)
                    SubTotalRate.Value = Math.Round((SubTotal.Value / Amount.Value) * 100, 1, MidpointRounding.AwayFromZero)
                    SiteCostsRate.Value = Math.Round((SiteCostsValue / Amount.Value) * 100, 1, MidpointRounding.AwayFromZero)
                    ConstractionCostRate.Value = Math.Round((ConstractionCost.Value / Amount.Value) * 100, 1, MidpointRounding.AwayFromZero)
                    ProfitAndLossRate.Value = Math.Round((ProfitAndLoss.Value / Amount.Value) * 100, 1, MidpointRounding.AwayFromZero)
                End If
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub Prefecture_CheckedChanged(sender As Object, e As EventArgs) Handles Prefecture.CheckedChanged
        If Prefecture.Checked = True Then
            RatePanel.Visible = True
            Rate1.Text = "90％以上"
            Rate2.Text = "50％以上90％未満"
            Rate3.Text = "50％未満"
        End If
    End Sub

    Private Sub City_CheckedChanged(sender As Object, e As EventArgs) Handles City.CheckedChanged
        If City.Checked = True Then
            RatePanel.Visible = True
            Rate1.Text = "100％"
            Rate2.Text = "50％以上100％未満"
            Rate3.Text = "50％未満"
        End If
    End Sub

    Private Sub Others_CheckedChanged(sender As Object, e As EventArgs) Handles Others.CheckedChanged
        If Others.Checked = True Then
            RatePanel.Visible = False
        End If
    End Sub

    Private Sub Company_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Company.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub Year_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Year.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub ProjectCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ProjectCode.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub ProjectName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ProjectName.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub ProjectAddress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ProjectAddress.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub Contractee_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Contractee.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub Amount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Amount.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub Department_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Department.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub TermS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TermS.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub TermE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TermE.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub CnsdrtnDate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CnsdrtnDate.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub


    Private Sub BdgtDprtmnt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BdgtDprtmnt.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub ExpenseRate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ExpenseRate.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub Authorizer1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Authorizer1.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub Authorizer2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Authorizer2.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub Authorizer3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Authorizer3.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub Authorizer4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Authorizer4.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub Authorizer5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Authorizer5.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub Circulator1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Circulator1.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub Circulator2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Circulator2.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub Circulator3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Circulator3.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub Circulator4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Circulator4.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

End Class