Imports System.Data.SqlClient
Imports C1.Win.FlexReport
Public Class 実行予算大内訳書
    Public Function ReportLoad() As String

        ReportLoad = ""

        レポート.C1FlexReport1.Load(ホーム.Reportpath, "実行予算大内訳書")

        ホーム.Sql.CommandText = "SELECT SUM(stexpns_amount) FROM site_expenses WHERE Budget_no=" & ホーム.BudgetNo
        Dim SiteExpense As Int64 = Math.Ceiling(ホーム.Sql.ExecuteScalar)

        Dim ReportData As DataSource = New DataSource
        ReportData.Name = "ReportDataSource"
        ReportData.DataProvider = DataProvider.OLEDB
        ReportData.ConnectionString = "Provider=MSOLEDBSQL.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=" & ホーム.UserDataPath & ホーム.UserDataName & ";Data Source=(localdb)\MSSQLLocalDB;"
        ReportData.RecordSource = "SELECT DISTINCT L_worktype_total_alt.l_wrktyp_code,
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
        レポート.C1FlexReport1.DataSources.Add(ReportData)
        レポート.C1FlexReport1.DataSourceName = ReportData.Name

        Dim BudgetField As C1.Win.FlexReport.Field
        BudgetField = CType(レポート.C1FlexReport1.Fields("amouttotal"), C1.Win.FlexReport.Field)
        BudgetField.Text = "SUM(amout_total)"

        レポート.C1FlexViewer1.DocumentSource = レポート.C1FlexReport1

        Return ReportLoad
    End Function
End Class
