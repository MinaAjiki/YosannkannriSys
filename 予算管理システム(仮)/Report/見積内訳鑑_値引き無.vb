Imports System.Data.SqlClient
Imports C1.Win.FlexReport

Public Class 見積内訳鑑_値引き無
    Public Function ReportLoad() As String

        ReportLoad = ""

        'レポートを読み込む
        レポート.C1FlexReport1.Load(ホーム.Reportpath, "見積内訳鑑(値引き無)")


        Dim ReportData As DataSource = New DataSource
        ReportData.Name = "ReportDataSource"
        ReportData.DataProvider = DataProvider.OLEDB
        ReportData.ConnectionString = "Provider=MSOLEDBSQL.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=" & ホーム.UserDataPath & ホーム.UserDataName & ";Data Source=(localdb)\MSSQLLocalDB;"
        ReportData.RecordSource = "SELECT DISTINCT estimates.estmt_taxin,
	                                               estimates.estmt_tax,
	                                               estimates.estmt_amount,
	                                               estimates.discount
                                   FROM  estimates;"
        レポート.C1FlexReport1.DataSources.Add(ReportData)
        レポート.C1FlexReport1.DataSourceName = ReportData.Name



        レポート.C1FlexViewer1.DocumentSource = レポート.C1FlexReport1



        Return ReportLoad
    End Function
End Class
