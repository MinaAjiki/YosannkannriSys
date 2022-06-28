Imports System.Data.SqlClient
Imports C1.Win.FlexReport
Public Class 現場経費内訳書
    Public Function ReportLoad() As String

        ReportLoad = ""

        レポート.C1FlexReport1.Load(ホーム.Reportpath, "現場経費内訳書")

        'レポートを読み込む

        Dim ReportData As DataSource = New DataSource
        ReportData.Name = "ReportDataSource"
        ReportData.DataProvider = DataProvider.OLEDB
        ReportData.ConnectionString = "Provider=MSOLEDBSQL.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=" & ホーム.UserDataPath & ホーム.UserDataName & ";Data Source=(localdb)\MSSQLLocalDB;"
        ReportData.RecordSource = "SELECT DISTINCT expens_bd.budget_no,
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
                                   WHERE ((expens_bd.budget_no) =" & ホーム.BudgetNo & ") AND NOT expens_bd.expns_bd_quanity=0 ORDER BY expens_bd.stexpns_code,expens_bd.expns_bd_no;"
        レポート.C1FlexReport1.DataSources.Add(ReportData)
        レポート.C1FlexReport1.DataSourceName = ReportData.Name


        Dim BudgetField As C1.Win.FlexReport.Field
        BudgetField = CType(レポート.C1FlexReport1.Fields("expns_bd_total"), C1.Win.FlexReport.Field)
        BudgetField.Text = "SUM(expns_bd_amount)"

        Dim BudgetField1 As C1.Win.FlexReport.Field
        BudgetField1 = CType(レポート.C1FlexReport1.Fields("expns_total"), C1.Win.FlexReport.Field)
        BudgetField1.Text = "Sum(expns_bd_amount)"

        レポート.C1FlexViewer1.DocumentSource = レポート.C1FlexReport1



        Return ReportLoad
    End Function
End Class
