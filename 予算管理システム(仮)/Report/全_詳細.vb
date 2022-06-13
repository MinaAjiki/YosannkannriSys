Imports System.Data.SqlClient
Imports C1.Win.FlexReport

Public Class 全_詳細
    Public Function ReportLoad() As String

        ReportLoad = ""

        Dim pDlg As New PrintDialog
        Dim pDoc As New System.Drawing.Printing.PrintDocument
        pDoc.DefaultPageSettings.Landscape = True
        pDlg.Document = pDoc
        If pDlg.ShowDialog = DialogResult.OK Then


            進行状況.Show()

            '予算総括表
            'レポートを読み込む
            レポート.C1FlexReport1.Load(ホーム.Reportpath, "予算総括新レポート")
            Dim ReportData As DataSource = New DataSource
            ReportData.Name = "ReportDataSource"
            ReportData.DataProvider = DataProvider.OLEDB
            ReportData.ConnectionString = "Provider=MSOLEDBSQL.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=" & ホーム.UserDataPath & ホーム.UserDataName & ";Data Source=(localdb)\MSSQLLocalDB;"
            ReportData.RecordSource = "SELECT DISTINCT bdgt_smmry_report.project_code,
	                                               bdgt_smmry_report.project_name,
	                                               bdgt_smmry_report.budget_no,
	                                               bdgt_smmry_report.contractee,
	                                               bdgt_smmry_report.prjct_address,
	                                               bdgt_smmry_report.prjct_term_s,
	                                               bdgt_smmry_report.prjct_term_e,
	                                               bdgt_smmry_report.cntrct_amount,
	                                               bdgt_smmry_report.prjct_category,
	                                               bdgt_smmry_report.cnsdrtn_date,
	                                               bdgt_smmry_report.prjct_summary,
	                                               bdgt_smmry_report.sbcntrct_rate_code,
	                                               bdgt_smmry_report.remarks,
	                                               bdgt_smmry_report.department,
                                                   bdgt_smmry_report.director,
	                                               bdgt_smmry_report.manager,
	                                               bdgt_smmry_report.chief,
	                                               bdgt_smmry_report.expert_1,
	                                               bdgt_smmry_report.expert_2,
	                                               bdgt_smmry_report.expert_3,
	                                               bdgt_smmry_report.staff_1,
	                                               bdgt_smmry_report.staff_2,
	                                               bdgt_smmry_report.staff_3,
	                                               bdgt_smmry_report.staff_4,
	                                               bdgt_smmry_report.bdgt_dprtmnt,
	                                               bdgt_smmry_report.expense_rate,
	                                               bdgt_smmry_report.authorizer1,
	                                               bdgt_smmry_report.authorizer2,
	                                               bdgt_smmry_report.authorizer3,
	                                               bdgt_smmry_report.authorizer4,
	                                               bdgt_smmry_report.authorizer5,
	                                               bdgt_smmry_report.circulator1,
	                                               bdgt_smmry_report.circulator2,
	                                               bdgt_smmry_report.circulator3,
	                                               bdgt_smmry_report.circulator4,
	                                               bdgt_smmry_report.circulator5
                                    FROM  bdgt_smmry_report
                                    WHERE ((bdgt_smmry_report.budget_no) =" & ホーム.BudgetNo & ");"
            レポート.C1FlexReport1.DataSources.Add(ReportData)
            レポート.C1FlexReport1.DataSourceName = ReportData.Name

            Dim BudgetField As C1.Win.FlexReport.Field
            BudgetField = CType(レポート.C1FlexReport1.Fields("budget_no"), C1.Win.FlexReport.Field)
            BudgetField.Text = "第" & ホーム.BudgetNo & "回変更"

            ホーム.Sql.CommandText = "SELECT Count(*) FROM site_expenses WHERE budget_no=" & ホーム.BudgetNo
            Dim SiteExpenseCount As Integer = ホーム.Sql.ExecuteScalar
            If SiteExpenseCount > 0 Then
                ホーム.Sql.CommandText = "SELECT SUM(stexpns_amount) FROM site_expenses WHERE budget_no=" & ホーム.BudgetNo
                Dim SiteCostsField As C1.Win.FlexReport.Field
                SiteCostsField = CType(レポート.C1FlexReport1.Fields("SiteCosts"), C1.Win.FlexReport.Field)
                If IsDBNull(ホーム.Sql.ExecuteScalar) = False Then
                    SiteCostsField.Text = ホーム.Sql.ExecuteScalar
                Else
                    SiteCostsField.Text = 0
                End If
            End If

            ホーム.Sql.CommandText = "SELECT SUM(dtl_quanity * dtl_costea) FROM details WHERE budget_no=" & ホーム.BudgetNo & " AND s_worktype_code <200"
            Dim DrctCnstrctnCstField As C1.Win.FlexReport.Field
            DrctCnstrctnCstField = CType(レポート.C1FlexReport1.Fields("DrctCnstrctnCst"), C1.Win.FlexReport.Field)
            If IsDBNull(ホーム.Sql.ExecuteScalar) = False Then
                Dim DrctCnstrctnCst As Int64 = Math.Floor(ホーム.Sql.ExecuteScalar)
                DrctCnstrctnCstField.Text = DrctCnstrctnCst
            Else
                DrctCnstrctnCstField.Text = 0
            End If

            ホーム.Sql.CommandText = "SELECT SUM(dtl_quanity * dtl_costea) FROM details WHERE budget_no=" & ホーム.BudgetNo & " AND s_worktype_code>=200 AND s_worktype_code <800"
            Dim TmprryExpnssField As C1.Win.FlexReport.Field
            TmprryExpnssField = CType(レポート.C1FlexReport1.Fields("TmprryExpnss"), C1.Win.FlexReport.Field)
            If IsDBNull(ホーム.Sql.ExecuteScalar) = False Then
                Dim TmprryExpnss As Int64 = Math.Floor(ホーム.Sql.ExecuteScalar)
                TmprryExpnssField.Text = TmprryExpnss
            Else
                TmprryExpnssField.Text = 0
            End If

            ホーム.Sql.CommandText = "SELECT SUM(dtl_quanity * dtl_costea) FROM details WHERE budget_no=" & ホーム.BudgetNo & " AND s_worktype_code=861"
            Dim MtrldffrncField As C1.Win.FlexReport.Field
            MtrldffrncField = CType(レポート.C1FlexReport1.Fields("Mtrldffrnc"), C1.Win.FlexReport.Field)
            If IsDBNull(ホーム.Sql.ExecuteScalar) = False Then
                Dim Mtrldffrnc As Int64 = Math.Floor(ホーム.Sql.ExecuteScalar)
                MtrldffrncField.Text = Mtrldffrnc
            Else
                MtrldffrncField.Text = 0
            End If

            ホーム.Sql.CommandText = "SELECT SUM(dtl_quanity * dtl_costea) FROM details WHERE budget_no=" & ホーム.BudgetNo & " AND s_worktype_code=881"
            Dim ExpectedTotalField As C1.Win.FlexReport.Field
            ExpectedTotalField = CType(レポート.C1FlexReport1.Fields("ExpectedTotal"), C1.Win.FlexReport.Field)
            If IsDBNull(ホーム.Sql.ExecuteScalar) = False Then
                Dim ExpectedTotal As Int64 = Math.Floor(ホーム.Sql.ExecuteScalar)
                ExpectedTotalField.Text = ExpectedTotal
            Else
                ExpectedTotalField.Text = 0
            End If

            Dim DataCount As Integer = 0
            ホーム.Sql.CommandText = "SELECT TOP 10 * FROM outsourcers"
            Dim OutsrcrReader As SqlDataReader = ホーム.Sql.ExecuteReader
            While OutsrcrReader.Read
                DataCount += 1

                Dim WorkTypeField As C1.Win.FlexReport.Field
                WorkTypeField = CType(レポート.C1FlexReport1.Fields("Worktype" & DataCount), C1.Win.FlexReport.Field)
                WorkTypeField.Text = OutsrcrReader.Item("worktype")

                Dim OutsrcrNameField As C1.Win.FlexReport.Field
                OutsrcrNameField = CType(レポート.C1FlexReport1.Fields("OutsrcrName" & DataCount), C1.Win.FlexReport.Field)
                OutsrcrNameField.Text = OutsrcrReader.Item("outsrcr_name")

            End While
            OutsrcrReader.Close()

            レポート.C1FlexReport1.Render()




            '材料表
            Dim report2 As New C1.Win.FlexReport.C1FlexReport
            report2.Load(ホーム.Reportpath, "基礎単価表")

            Dim ReportData1 As DataSource = New DataSource
            ReportData1.Name = "ReportDataSource"
            ReportData1.DataProvider = DataProvider.OLEDB
            ReportData1.ConnectionString = "Provider=MSOLEDBSQL.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=" & ホーム.UserDataPath & ホーム.UserDataName & ";Data Source=(localdb)\MSSQLLocalDB;"
            ReportData1.RecordSource = "SELECT DISTINCT cost_masters.cstclss_code,
                                                	cost_masters.cstmstr_category,
	                                                cost_masters.cstmstr_code,
                                                    cost_masters.cstmstr_name,
                                	                cost_masters.cstmstr_spec,
                                	                cost_masters.cstmstr_unit,
                                                 	cost_masters.cstmstr_costea
                                    FROM  cost_masters WHERE ((cost_masters.cstclss_code) =2) ORDER BY cost_masters.cstmstr_code;"
            report2.DataSources.Add(ReportData1)
            report2.DataSourceName = ReportData1.Name

            Dim ReportNameField As C1.Win.FlexReport.Field
            ReportNameField = CType(report2.Fields("ReportName"), C1.Win.FlexReport.Field)
            ReportNameField.Text = "材料単価表"

            report2.Render()




            '現場経費
            Dim report3 As New C1.Win.FlexReport.C1FlexReport
            report3.Load(ホーム.Reportpath, "現場経費内訳書")

            Dim ReportData2 As DataSource = New DataSource
            ReportData2.Name = "ReportDataSource"
            ReportData2.DataProvider = DataProvider.OLEDB
            ReportData2.ConnectionString = "Provider=MSOLEDBSQL.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=" & ホーム.UserDataPath & ホーム.UserDataName & ";Data Source=(localdb)\MSSQLLocalDB;"
            ReportData2.RecordSource = "SELECT DISTINCT expens_bd.budget_no,
	                                                expens_bd.stexpns_code,
                                                	expens_bd.stexpns_name,
                                                	expens_bd.expns_bd_name,
                                                	expens_bd.expns_bd_spec,
                                                	expens_bd.expns_bd_unit,
	                                                expens_bd.expns_bd_quanity,
                                                	expens_bd.expns_bd_costea,
                                                	expens_bd.expns_bd_no,
                                                	expens_bd.expns_bd_amount
                                                    FROM  expens_bd
                                   WHERE ((expens_bd.budget_no) =" & ホーム.BudgetNo & ") ORDER BY expens_bd.stexpns_code,expens_bd.expns_bd_no;"
            report3.DataSources.Add(ReportData2)
            report3.DataSourceName = ReportData2.Name


            Dim ExpensebdField As C1.Win.FlexReport.Field
            ExpensebdField = CType(report3.Fields("expns_bd_total"), C1.Win.FlexReport.Field)
            ExpensebdField.Text = "SUM(expns_bd_amount)"

            Dim ExpenseField As C1.Win.FlexReport.Field
            ExpenseField = CType(report3.Fields("expns_total"), C1.Win.FlexReport.Field)
            ExpenseField.Text = "Sum(expns_bd_amount)"

            report3.Render()



            '予算大内訳
            Dim report4 As New C1.Win.FlexReport.C1FlexReport
            report4.Load(ホーム.Reportpath, "実行予算大内訳書")

            ホーム.Sql.CommandText = "SELECT SUM(stexpns_amount) FROM site_expenses WHERE Budget_no=" & ホーム.BudgetNo
            Dim SiteExpense As Int64 = Math.Floor(ホーム.Sql.ExecuteScalar)

            Dim ReportData3 As DataSource = New DataSource
            ReportData3.Name = "ReportDataSource"
            ReportData3.DataProvider = DataProvider.OLEDB
            ReportData3.ConnectionString = "Provider=MSOLEDBSQL.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=" & ホーム.UserDataPath & ホーム.UserDataName & ";Data Source=(localdb)\MSSQLLocalDB;"
            ReportData3.RecordSource = "SELECT DISTINCT L_worktype_total_alt.l_wrktyp_code,
                                                   L_worktype_total_alt.l_wrktyp_name,
                                                   SUM(L_worktype_total_alt.amout_total) AS amout_total
                                   FROM (SELECT DISTINCT l_worktype_total.budget_no,
                                                   l_worktype_total.l_wrktyp_code,
                                                   l_worktype_total.l_wrktyp_name,
                                                   l_worktype_total.s_wrktyp_code,
                                                   l_worktype_total.s_wrktyp_name,
                                 (CASE WHEN L_worktype_total.l_wrktyp_code= 840 THEN " & SiteExpense & " ELSE L_worktype_total.amout_total END) AS amout_total
                                 FROM    L_worktype_total) as l_worktype_total_alt
                                 WHERE ((L_worktype_total_alt.budget_no) =" & ホーム.BudgetNo & ") OR ((L_worktype_total_alt.budget_no) IS NULL)
                                 GROUP BY L_worktype_total_alt.l_wrktyp_code,L_worktype_total_alt.l_wrktyp_name
                                 ORDER BY L_worktype_total_alt.l_wrktyp_code;"
            report4.DataSources.Add(ReportData3)
            report4.DataSourceName = ReportData3.Name

            Dim AmountTotalField As C1.Win.FlexReport.Field
            AmountTotalField = CType(report4.Fields("amouttotal"), C1.Win.FlexReport.Field)
            AmountTotalField.Text = "SUM(amout_total)"

            report4.Render()



            '予算内訳
            Dim report5 As New C1.Win.FlexReport.C1FlexReport
            report5.Load(ホーム.Reportpath, "実行予算内訳書")

            Dim ReportData4 As DataSource = New DataSource
            ReportData4.Name = "ReportDataSource"
            ReportData4.DataProvider = DataProvider.OLEDB
            ReportData4.ConnectionString = "Provider=MSOLEDBSQL.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=" & ホーム.UserDataPath & ホーム.UserDataName & ";Data Source=(localdb)\MSSQLLocalDB;"
            ReportData4.RecordSource = "SELECT DISTINCT  S_worktype_total_alt.l_wrktyp_code,
	                                                S_worktype_total_alt.l_wrktyp_name,
	                                                S_worktype_total_alt.s_wrktyp_code,
	                                                S_worktype_total_alt.s_wrktyp_name,
	                                                SUM(S_worktype_total_alt.amout_total1) AS amout_total,
	                                                SUM(S_worktype_total_alt.labor1) AS labor,
	                                                SUM(S_worktype_total_alt.material1) AS material,
	                                                SUM(S_worktype_total_alt.machine1) AS machine,
	                                                SUM(S_worktype_total_alt.subcntrct1) AS subcntrct,
	                                                SUM(S_worktype_total_alt.expens1) AS expens
                                 FROM  (SELECT  S_worktype_total.budget_no,
	                                                S_worktype_total.l_wrktyp_code,
	                                                S_worktype_total.l_wrktyp_name,
	                                                S_worktype_total.s_wrktyp_code,
	                                                S_worktype_total.s_wrktyp_name,
	                                                S_worktype_total.labor AS labor1,
	                                                S_worktype_total.material AS material1,
	                                                S_worktype_total.machine AS machine1,
	                                                S_worktype_total.subcntrct AS subcntrct1,
	                                                S_worktype_total.expens AS expens1,
	                             (CASE WHEN S_worktype_total.l_wrktyp_code= 840 THEN " & SiteExpense & " ELSE S_worktype_total.amout_total END) AS amout_total1 
                                 FROM S_worktype_total) AS S_worktype_total_alt 
                                 WHERE ((S_worktype_total_alt.budget_no) =" & ホーム.BudgetNo & ") OR ((S_worktype_total_alt.budget_no) IS NULL) 
                                 GROUP BY S_worktype_total_alt.s_wrktyp_code,S_worktype_total_alt.s_wrktyp_name,S_worktype_total_alt.l_wrktyp_code,S_worktype_total_alt.l_wrktyp_name 
                                 ORDER BY S_worktype_total_alt.s_wrktyp_code;"
            report5.DataSources.Add(ReportData4)
            report5.DataSourceName = ReportData4.Name

            Dim LAmountField As C1.Win.FlexReport.Field
            LAmountField = CType(report5.Fields("l_amouttotal"), C1.Win.FlexReport.Field)
            LAmountField.Text = "SUM(amout_total)"

            Dim GrandTotalField As C1.Win.FlexReport.Field
            GrandTotalField = CType(report5.Fields("gland_total"), C1.Win.FlexReport.Field)
            GrandTotalField.Text = "SUM(amout_total)"


            Dim LaborTotalField As C1.Win.FlexReport.Field
            LaborTotalField = CType(report5.Fields("labor_total"), C1.Win.FlexReport.Field)
            LaborTotalField.Text = "SUM(labor)"


            Dim MaterialTotalField As C1.Win.FlexReport.Field
            MaterialTotalField = CType(report5.Fields("material_total"), C1.Win.FlexReport.Field)
            MaterialTotalField.Text = "SUM(material)"


            Dim MachineTotalField As C1.Win.FlexReport.Field
            MachineTotalField = CType(report5.Fields("machine_total"), C1.Win.FlexReport.Field)
            MachineTotalField.Text = "SUM(machine)"


            Dim SubcntrctTotalField As C1.Win.FlexReport.Field
            SubcntrctTotalField = CType(report5.Fields("subcntrct_total"), C1.Win.FlexReport.Field)
            SubcntrctTotalField.Text = "SUM(subcntrct)"


            Dim ExpensTotalField As C1.Win.FlexReport.Field
            ExpensTotalField = CType(report5.Fields("expens_total"), C1.Win.FlexReport.Field)
            ExpensTotalField.Text = "SUM(expens)"

            report5.Render()



            '明細内訳
            Dim report6 As New C1.Win.FlexReport.C1FlexReport
            report6.Load(ホーム.Reportpath, "明細内訳書")

            Dim ReportData5 As DataSource = New DataSource
            ReportData5.Name = "ReportDataSource"
            ReportData5.DataProvider = DataProvider.OLEDB
            ReportData5.ConnectionString = "Provider=MSOLEDBSQL.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=" & ホーム.UserDataPath & ホーム.UserDataName & ";Data Source=(localdb)\MSSQLLocalDB;"
            ReportData5.RecordSource = "SELECT DISTINCT details_bd.s_wrktyp_code,
	                                                details_bd.s_wrktyp_name,
	                                                details_bd.budget_no,
	                                                details_bd.dtl_no,
	                                                details_bd.dtl_name,
	                                                details_bd.dtl_spec,
	                                                details_bd.dtl_unit,
	                                                details_bd.dtl_quanity,
                                                	details_bd.dtl_costea,
                                                	details_bd.dtl_remarks,
	                                                details_bd.dtl_amount,
                                                   	details_bd.dtl_labor,
                                                	details_bd.dtl_material,
                                                	details_bd.dtl_machine,
	                                                details_bd.dtl_subcntrct,
	                                                details_bd.dtl_expens
                                    FROM  details_bd
                                    WHERE ((details_bd.budget_no) =" & ホーム.BudgetNo & ") 
                                    ORDER BY details_bd.dtl_no;"
            report6.DataSources.Add(ReportData5)
            report6.DataSourceName = ReportData5.Name

            Dim GrandTotalField1 As C1.Win.FlexReport.Field
            GrandTotalField1 = CType(report6.Fields("amount_total"), C1.Win.FlexReport.Field)
            GrandTotalField1.Text = "SUM(dtl_amount)"


            Dim LaborTotalField1 As C1.Win.FlexReport.Field
            LaborTotalField1 = CType(report6.Fields("labor_total"), C1.Win.FlexReport.Field)
            LaborTotalField1.Text = "SUM(dtl_labor)"


            Dim MaterialTotalField1 As C1.Win.FlexReport.Field
            MaterialTotalField1 = CType(report6.Fields("material_total"), C1.Win.FlexReport.Field)
            MaterialTotalField1.Text = "SUM(dtl_material)"


            Dim MachineTotalField1 As C1.Win.FlexReport.Field
            MachineTotalField1 = CType(report6.Fields("machine_total"), C1.Win.FlexReport.Field)
            MachineTotalField1.Text = "SUM(dtl_machine)"


            Dim SubcntrctTotalField1 As C1.Win.FlexReport.Field
            SubcntrctTotalField1 = CType(report6.Fields("subcntrct_total"), C1.Win.FlexReport.Field)
            SubcntrctTotalField1.Text = "SUM(dtl_subcntrct)"


            Dim ExpensTotalField1 As C1.Win.FlexReport.Field
            ExpensTotalField1 = CType(report6.Fields("expens_total"), C1.Win.FlexReport.Field)
            ExpensTotalField1.Text = "SUM(dtl_expens)"

            report6.Render()



            '代価表

            Dim ClassCode As New List(Of Integer)
            Dim ClassName As New List(Of String)
            ホーム.Sql.CommandText = "SELECT * FROM cost_classes WHERE cstclss_code > 11"
            Dim CostClassReader As SqlDataReader = ホーム.Sql.ExecuteReader
            While CostClassReader.Read
                ClassCode.Add(CostClassReader.Item("cstclss_code"))
                ClassName.Add(CostClassReader.Item("cstclss_name"))
            End While
            CostClassReader.Close()

            Dim prjctcstlist_reportdata(ClassCode.Count - 1) As DataSource
            Dim prjctcstlist_report(ClassCode.Count - 1) As C1.Win.FlexReport.C1FlexReport
            Dim prjctcst_reportdata(ClassCode.Count - 1) As DataSource
            Dim prjctcst_report(ClassCode.Count - 1) As C1.Win.FlexReport.C1FlexReport

            For ClassLoop As Integer = 0 To ClassCode.Count - 1

                prjctcstlist_report(ClassLoop) = New C1.Win.FlexReport.C1FlexReport
                prjctcstlist_report(ClassLoop).Load(ホーム.Reportpath, "代価一覧表")

                prjctcstlist_reportdata(ClassLoop) = New DataSource
                prjctcstlist_reportdata(ClassLoop).Name = "reportdataSource"
                prjctcstlist_reportdata(ClassLoop).DataProvider = DataProvider.OLEDB
                prjctcstlist_reportdata(ClassLoop).ConnectionString = "Provider=MSOLEDBSQL.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=" & ホーム.UserDataPath & ホーム.UserDataName & ";Data Source=(localdb)\MSSQLLocalDB;"
                prjctcstlist_reportdata(ClassLoop).RecordSource = "SELECT DISTINCT projectcst_bd.budget_no,
                                                   projectcst_bd.cstclss_code,
	                                               projectcst_bd.prjctcst_no,
	                                               projectcst_bd.prjctcst_name,
	                                               projectcst_bd.prjctcst_spec,
	                                               projectcst_bd.prjctcst_unit,
	                                               projectcst_bd.prjctcst_costea,
	                                               projectcst_bd.prjctcst_laborea,
	                                               projectcst_bd.prjctcst_materialea,
	                                               projectcst_bd.prjctcst_machineea,
	                                               projectcst_bd.prjctcst_subcntrctea,
	                                               projectcst_bd.prjctcst_expenseea
	                                FROM  projectcst_bd
                                    WHERE ((projectcst_bd.budget_no) =" & ホーム.BudgetNo & ") AND ((projectcst_bd.cstclss_code) =" & ClassCode.Item(ClassLoop) & ") 
									GROUP BY projectcst_bd.budget_no,
                                                   projectcst_bd.cstclss_code,
	                                               projectcst_bd.prjctcst_no,
	                                               projectcst_bd.prjctcst_name,
	                                               projectcst_bd.prjctcst_spec,
	                                               projectcst_bd.prjctcst_unit,
	                                               projectcst_bd.prjctcst_costea,
	                                               projectcst_bd.prjctcst_laborea,
	                                               projectcst_bd.prjctcst_materialea,
	                                               projectcst_bd.prjctcst_machineea,
	                                               projectcst_bd.prjctcst_subcntrctea,
	                                               projectcst_bd.prjctcst_expenseea
                                    ORDER BY projectcst_bd.prjctcst_no;"
                prjctcstlist_report(ClassLoop).DataSources.Add(prjctcstlist_reportdata(ClassLoop))
                prjctcstlist_report(ClassLoop).DataSourceName = prjctcstlist_reportdata(ClassLoop).Name

                Dim TitleField1 As C1.Win.FlexReport.Field
                TitleField1 = CType(prjctcstlist_report(ClassLoop).Fields("ReportTitle"), C1.Win.FlexReport.Field)
                TitleField1.Text = "工事代価表　" & ClassName.Item(ClassLoop).Last

                prjctcstlist_report(ClassLoop).Render()



                ホーム.Sql.CommandText = "SELECT Count(*) FROM  projectcst_bd WHERE projectcst_bd.cstclss_code=" & ClassCode.Item(ClassLoop)
                Dim bdCount As Integer = ホーム.Sql.ExecuteScalar

                If bdCount > 0 Then
                    prjctcst_report(ClassLoop) = New C1.Win.FlexReport.C1FlexReport
                    prjctcst_report(ClassLoop).Load(ホーム.Reportpath, "代価内訳書")


                    prjctcst_reportdata(ClassLoop) = New DataSource
                    prjctcst_reportdata(ClassLoop).Name = "reportdataSource"
                    prjctcst_reportdata(ClassLoop).DataProvider = DataProvider.OLEDB
                    prjctcst_reportdata(ClassLoop).ConnectionString = "Provider=MSOLEDBSQL.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=" & ホーム.UserDataPath & ホーム.UserDataName & ";Data Source=(localdb)\MSSQLLocalDB;"
                    prjctcst_reportdata(ClassLoop).RecordSource = "SELECT DISTINCT projectcst_bd.budget_no,
                                                   projectcst_bd.cstclss_code,
	                                               projectcst_bd.prjctcst_no,
	                                               projectcst_bd.prjctcst_name,
	                                               projectcst_bd.prjctcst_spec,
	                                               projectcst_bd.prjctcst_unit,
	                                               projectcst_bd.prjctcst_quanity,
	                                               projectcst_bd.prjctcst_costea,
	                                               projectcst_bd.prjctcst_laborea,
	                                               projectcst_bd.prjctcst_materialea,
	                                               projectcst_bd.prjctcst_machineea,
	                                               projectcst_bd.prjctcst_subcntrctea,
	                                               projectcst_bd.prjctcst_expenseea,
	                                               projectcst_bd.prjctcst_amount,
	                                               projectcst_bd.prjctcst_bd_no,
	                                               projectcst_bd.prjctcst_bd_name,
	                                               projectcst_bd.prjctcst_bd_spec,
	                                               projectcst_bd.prjctcst_bd_unit,
	                                               projectcst_bd.prjctcst_bd_remarks,
	                                               projectcst_bd.prjctcst_bd_costea,
	                                               projectcst_bd.prjctcst_bd_quanity,
	                                               projectcst_bd.prjctcst_bd_amount,
	                                               projectcst_bd.prjctcst_bd_labor,
	                                               projectcst_bd.prjctcst_bd_material,
	                                               projectcst_bd.prjctcst_bd_machine,
	                                               projectcst_bd.prjctcst_bd_subcntrct,
	                                               projectcst_bd.prjctcst_bd_expense
                                    FROM  projectcst_bd
                                    WHERE ((projectcst_bd.budget_no) =" & ホーム.BudgetNo & ") AND ((projectcst_bd.cstclss_code) =" & ClassCode.Item(ClassLoop) & ") 
                                    ORDER BY projectcst_bd.prjctcst_no,projectcst_bd.prjctcst_bd_no;"
                    prjctcst_report(ClassLoop).DataSources.Add(prjctcst_reportdata(ClassLoop))
                    prjctcst_report(ClassLoop).DataSourceName = prjctcst_reportdata(ClassLoop).Name


                    Dim TitleField As C1.Win.FlexReport.Field
                    TitleField = CType(prjctcst_report(ClassLoop).Fields("ReportTitle"), C1.Win.FlexReport.Field)
                    TitleField.Text = "工事代価表"

                    Dim CostNoField1 As C1.Win.FlexReport.TextField
                    CostNoField1 = CType(prjctcst_report(ClassLoop).Fields("cstclssname"), C1.Win.FlexReport.TextField)
                    CostNoField1.Text = ClassName.Item(ClassLoop).Last

                    Dim GrandTotalField2 As C1.Win.FlexReport.Field
                    GrandTotalField2 = CType(prjctcst_report(ClassLoop).Fields("amount_total"), C1.Win.FlexReport.Field)
                    GrandTotalField2.Text = "SUM(prjctcst_bd_amount)"


                    Dim LaborTotalField2 As C1.Win.FlexReport.Field
                    LaborTotalField2 = CType(prjctcst_report(ClassLoop).Fields("labor_total"), C1.Win.FlexReport.Field)
                    LaborTotalField2.Text = "SUM(prjctcst_bd_labor)"


                    Dim MaterialTotalField2 As C1.Win.FlexReport.Field
                    MaterialTotalField2 = CType(prjctcst_report(ClassLoop).Fields("material_total"), C1.Win.FlexReport.Field)
                    MaterialTotalField2.Text = "SUM(prjctcst_bd_material)"


                    Dim MachineTotalField2 As C1.Win.FlexReport.Field
                    MachineTotalField2 = CType(prjctcst_report(ClassLoop).Fields("machine_total"), C1.Win.FlexReport.Field)
                    MachineTotalField2.Text = "SUM(prjctcst_bd_machine)"


                    Dim SubcntrctTotalField2 As C1.Win.FlexReport.Field
                    SubcntrctTotalField2 = CType(prjctcst_report(ClassLoop).Fields("subcntrct_total"), C1.Win.FlexReport.Field)
                    SubcntrctTotalField2.Text = "SUM(prjctcst_bd_subcntrct)"


                    Dim ExpensTotalField2 As C1.Win.FlexReport.Field
                    ExpensTotalField2 = CType(prjctcst_report(ClassLoop).Fields("expens_total"), C1.Win.FlexReport.Field)
                    ExpensTotalField2.Text = "SUM(prjctcst_bd_expense)"

                    prjctcst_report(ClassLoop).Render()

                End If

            Next

            ' 印刷実行
            レポート.C1FlexReport1.Print(pDlg.PrinterSettings)
            report2.Print(pDlg.PrinterSettings)
            report3.Print(pDlg.PrinterSettings)
            report4.Print(pDlg.PrinterSettings)
            report5.Print(pDlg.PrinterSettings)
            report6.Print(pDlg.PrinterSettings)
            For ClassLoop As Integer = 0 To ClassCode.Count - 1
                If IsNothing(prjctcstlist_report(ClassLoop)) = False Then
                    prjctcstlist_report(ClassLoop).Print(pDlg.PrinterSettings)
                End If
                If IsNothing(prjctcst_report(ClassLoop)) = False Then
                    prjctcst_report(ClassLoop).Print(pDlg.PrinterSettings)
                End If
            Next

            進行状況.Close()
            MsgBox("印刷が完了しました。", MsgBoxStyle.OkOnly, "予算　全印刷")

        End If




        Return ReportLoad
    End Function
End Class
