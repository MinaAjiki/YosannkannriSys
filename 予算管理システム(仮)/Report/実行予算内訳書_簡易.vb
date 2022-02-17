Imports System.Data.SqlClient
Imports C1.Win.FlexReport
Public Class 実行予算内訳書_簡易
    Public Function ReportLoad() As String

        ReportLoad = ""

        レポート.C1FlexReport1.Load(ホーム.Reportpath, "実行予算内訳書(簡易)")

        ホーム.Sql.CommandText = "SELECT SUM(stexpns_amount) FROM site_expenses WHERE Budget_no=" & ホーム.BudgetNo
        Dim SiteExpense As Int64 = Math.Ceiling(ホーム.Sql.ExecuteScalar)

        Dim ReportData As DataSource = New DataSource
        ReportData.Name = "ReportDataSource"
        ReportData.DataProvider = DataProvider.OLEDB
        ReportData.ConnectionString = "Provider=MSOLEDBSQL.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=" & ホーム.UserDataPath & ホーム.UserDataName & ";Data Source=(localdb)\MSSQLLocalDB;"
        ReportData.RecordSource = "SELECT DISTINCT  S_worktype_total_alt.l_wrktyp_code,
	                                                S_worktype_total_alt.l_wrktyp_name,
	                                                S_worktype_total_alt.s_wrktyp_code,
	                                                S_worktype_total_alt.s_wrktyp_name,
	                                                SUM(S_worktype_total_alt.amout_total1) AS amout_total
                                 FROM  (SELECT  S_worktype_total.budget_no,
	                                                S_worktype_total.l_wrktyp_code,
	                                                S_worktype_total.l_wrktyp_name,
	                                                S_worktype_total.s_wrktyp_code,
	                                                S_worktype_total.s_wrktyp_name,
	                             (CASE WHEN S_worktype_total.l_wrktyp_code= 840 THEN " & SiteExpense & " ELSE S_worktype_total.amout_total END) AS amout_total1 
                                 FROM S_worktype_total) AS S_worktype_total_alt 
                                 WHERE ((S_worktype_total_alt.budget_no) =" & ホーム.BudgetNo & ") OR ((S_worktype_total_alt.budget_no) IS NULL) 
                                 GROUP BY S_worktype_total_alt.s_wrktyp_code,S_worktype_total_alt.s_wrktyp_name,S_worktype_total_alt.l_wrktyp_code,S_worktype_total_alt.l_wrktyp_name 
                                 ORDER BY S_worktype_total_alt.s_wrktyp_code;"
        レポート.C1FlexReport1.DataSources.Add(ReportData)
        レポート.C1FlexReport1.DataSourceName = ReportData.Name

        Dim LAmountField As C1.Win.FlexReport.Field
        LAmountField = CType(レポート.C1FlexReport1.Fields("l_amouttotal"), C1.Win.FlexReport.Field)
        LAmountField.Text = "SUM(amout_total)"

        Dim GrandTotalField As C1.Win.FlexReport.Field
        GrandTotalField = CType(レポート.C1FlexReport1.Fields("gland_total"), C1.Win.FlexReport.Field)
        GrandTotalField.Text = "SUM(amout_total)"

        レポート.C1FlexViewer1.DocumentSource = レポート.C1FlexReport1

        Return ReportLoad
    End Function
End Class
