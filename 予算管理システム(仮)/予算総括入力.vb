
Imports C1.Win.C1FlexGrid
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

        ホーム.SystemSql.CommandText = "SELECT year FROM years ORDER BY year ASC"
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

        SubContractRate.Value = "岐阜県〔県内企業の活用率〕" & vbCrLf & "■90％以上" & vbCrLf & "□50％以上90％未満" & vbCrLf & "□50％未満" & vbCrLf &
                                "岐阜市〔市内企業の活用率〕" & vbCrLf & "□100％" & vbCrLf & "□50％以上100％未満" & vbCrLf & "□50％未満"


        Authorizer1.Value = "常務取締役"
        Authorizer2.Value = "取締役"
        Authorizer3.Value = "部長"
        Authorizer4.Value = "工事部長"
        Authorizer5.Value = "工事課長"
        Circulator1.Value = ""
        Circulator2.Value = ""
        Circulator3.Value = "取締役工務部長"
        Circulator4.Value = "工務部長"
        Circulator5.Value = "工務課"

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

            For AuthorizerCount As Integer = 1 To 5
                ホーム.Sql.CommandText = "SELECT contents FROM controldata WHERE class_code=" & 49 + AuthorizerCount
                AuthorizerPanel.Controls.Item("Authorizer" & AuthorizerCount).Text = ホーム.Sql.ExecuteScalar
            Next

            For CirculatorCount As Integer = 1 To 5
                ホーム.Sql.CommandText = "SELECT contents FROM controldata WHERE class_code=" & 59 + CirculatorCount
                CirculatorPanel.Controls.Item("Circulator" & CirculatorCount).Text = ホーム.Sql.ExecuteScalar
            Next

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
                SubContractRate.Value = BudgetReader.Item("subcontract_rate")
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
            End While
            BudgetReader.Close()

            ProjectAmount.Value = Amount.Value

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
            業者一覧.ParentFormName = "予算総括入力"
        業者一覧.Show()
        業者一覧.SelectRowIndex = e.Row

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
                FormPanel.Controls.Item(CntrlCnt).BackColor = Color.White
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
            ControlData(0, 1) = Company.Text
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

            For ControlDataCount As Integer = 0 To 5
                ホーム.Sql.CommandText = "UPDATE controldata SET contents=@contents WHERE class_code=@classcode"
                ホーム.Sql.Parameters("@classcode").Value = ControlData(ControlDataCount, 0)
                ホーム.Sql.Parameters("@contents").Value = ControlData(ControlDataCount, 1)
                ホーム.Sql.ExecuteNonQuery()
            Next

            For AuthorizerCount As Integer = 1 To 5
                ホーム.Sql.CommandText = "UPDATE controldata SET contents=@contents WHERE class_code=@classcode"
                ホーム.Sql.Parameters("@classcode").Value = 49 + AuthorizerCount
                ホーム.Sql.Parameters("@contents").Value = AuthorizerPanel.Controls.Item("Authorizer" & AuthorizerCount).Text
                ホーム.Sql.ExecuteNonQuery()
            Next

            For CirculatorCount As Integer = 1 To 5
                ホーム.Sql.CommandText = "UPDATE controldata SET contents=@contents WHERE class_code=@classcode"
                ホーム.Sql.Parameters("@classcode").Value = 59 + CirculatorCount
                ホーム.Sql.Parameters("@contents").Value = CirculatorPanel.Controls.Item("Circulator" & CirculatorCount).Text
                ホーム.Sql.ExecuteNonQuery()
            Next

            ホーム.Sql.CommandText = ""
            ホーム.Sql.Parameters.Clear()

            ホーム.Sql.CommandText = "SELECT Count(budget_no) FROM budget_summary"
            Dim DataCount As Integer = ホーム.Sql.ExecuteScalar

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
            ホーム.Sql.Parameters.Add(New SqlParameter("@subcontractrate", SqlDbType.NVarChar)).Value = SubContractRate.Text
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
            ホーム.Sql.Parameters.Add(New SqlParameter("@expenserate", SqlDbType.Decimal)).Value = Decimal.Parse(ExpenseRate.Text)

            If DataCount >= 1 Then

                ホーム.Sql.CommandText = "UPDATE budget_summary SET prjct_term_s=@terms,prjct_term_e=@terme,cntrct_amount=@amount,prjct_category=@category 
                                        ,cnsdrtn_date=@cnsdrtndate,prjct_summary=@summary,subcontract_rate=@subcontractrate,remarks=@remarks,department=@department,director=@director
                                        ,manager=@manager,chief=@chief,expert_1=@expert1,expert_2=@expert2,expert_3=@expert3,staff_1=@staff1,staff_2=@staff2
                                        ,staff_3=@staff3,staff_4=@staff4,bdgt_dprtmnt=@bdgtdprtmnt,expense_rate=@expenserate WHERE budget_no=@budgetno"
            Else

                ホーム.Sql.CommandText = "INSERT INTO budget_summary (budget_no,prjct_term_s,prjct_term_e,cntrct_amount,prjct_category,cnsdrtn_date,prjct_summary
                                                                   ,subcontract_rate,remarks,department,director,manager,chief,expert_1,expert_2
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
                Dim WorkTypeCell As String = OutsoucersList(ListRow + 1, 5)
                If IsNothing(OutsoucersList(ListRow + 1, 5)) = True Then
                    WorkTypeCell = ""
                End If

                If Not IDCell = 0 AndAlso DeleteCell = "False" Then
                    ホーム.Sql.CommandText = "UPDATE outsourcers SET worktype=@worktype WHERE id=" & IDCell
                    ホーム.Sql.Parameters.Add(New SqlParameter("@worktype", SqlDbType.NVarChar)).Value = WorkTypeCell
                    ホーム.Sql.ExecuteNonQuery()

                ElseIf IDCell = 0 AndAlso OutsrceNameCell <> "" AndAlso DeleteCell = "False" Then
                    ホーム.Sql.CommandText = "INSERT INTO outsourcers (outsrcr_code,outsrcr_name,outsrcr_term_s,outsrcr_term_e,worktype,ordrfrm,e_cntrct) 
                                                VALUES (@code,@name,@terms,@terme,@worktype,@ordrfrm,@ecntrct)"
                    ホーム.Sql.Parameters.Add(New SqlParameter("@code", SqlDbType.Int)).Value = Integer.Parse(OutsrcrCodeCell)
                    ホーム.Sql.Parameters.Add(New SqlParameter("@name", SqlDbType.NVarChar)).Value = OutsrceNameCell
                    ホーム.Sql.Parameters.Add(New SqlParameter("@terms", SqlDbType.DateTime)).Value = DateTime.Parse("1900/01/01")
                    ホーム.Sql.Parameters.Add(New SqlParameter("@terme", SqlDbType.DateTime)).Value = DateTime.Parse("1900/01/01")
                    ホーム.Sql.Parameters.Add(New SqlParameter("@worktype", SqlDbType.NVarChar)).Value = WorkTypeCell
                    ホーム.Sql.Parameters.Add(New SqlParameter("@ordrfrm", SqlDbType.SmallInt)).Value = 0
                    ホーム.Sql.Parameters.Add(New SqlParameter("@ecntrct", SqlDbType.NVarChar)).Value = ""
                    ホーム.Sql.ExecuteNonQuery()

                ElseIf Not IDCell = 0 AndAlso DeleteCell = "True" Then
                    ホーム.Sql.CommandText = "DELETE FROM outsourcers WHERE ID=" & IDCell
                    ホーム.Sql.ExecuteNonQuery()

                End If

            Next

            ホーム.Transaction.Commit()

            ホーム.見積.Enabled = True
            ホーム.外注管理.Enabled = True
            ホーム.Modified = "False"

            MsgBox("登録完了", MsgBoxStyle.OkOnly, "予算総括登録")

            ホーム.Sql.CommandText = ""
            ホーム.Sql.Parameters.Clear()

        Catch ex As Exception
            ホーム.Transaction.Rollback()
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try




    End Sub

    Private Sub ProjectCode_ValueChanged(sender As Object, e As EventArgs) Handles ProjectCode.ValueChanged, TermS.ValueChanged, TermE.ValueChanged, Summary.ValueChanged, SubContractRate.ValueChanged, Staff4.ValueChanged, Staff3.ValueChanged, Staff2.ValueChanged, Staff1.ValueChanged, Remarks.ValueChanged, ProjectName.ValueChanged, ProjectAddress.ValueChanged, Manager.ValueChanged, Expert3.ValueChanged, Expert2.ValueChanged, Expert1.ValueChanged, ExpenseRate.ValueChanged, Director.ValueChanged, Department.ValueChanged, Contractee.ValueChanged, CnsdrtnDate.ValueChanged, Chief.ValueChanged, Category.ValueChanged, Year.ValueChanged, Company.ValueChanged
        Try
            ホーム.Modified = "True"
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Try
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
                ホーム.Modified = "True"

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
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub
End Class