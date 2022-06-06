Imports System.Data.SqlClient
Imports C1.Win.FlexReport

Public Class 予算総括表
    Public Function ReportLoad() As String

        ReportLoad = ""

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

        レポート.C1FlexViewer1.DocumentSource = レポート.C1FlexReport1



        Return ReportLoad
    End Function
End Class
