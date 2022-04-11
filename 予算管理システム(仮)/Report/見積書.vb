Imports System.Data.SqlClient
Imports C1.Win.FlexReport

Public Class 見積書
    Public Function ReportLoad() As String

        ReportLoad = ""

        'レポートを読み込む
        レポート.C1FlexReport1.Load(ホーム.Reportpath, "見積書")


        Dim ReportData As DataSource = New DataSource
        ReportData.Name = "ReportDataSource"
        ReportData.DataProvider = DataProvider.OLEDB
        ReportData.ConnectionString = "Provider=MSOLEDBSQL.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=" & ホーム.UserDataPath & ホーム.UserDataName & ";Data Source=(localdb)\MSSQLLocalDB;"
        ReportData.RecordSource = "SELECT DISTINCT estimates.estmt_code,
                                	               estimates.estmt_date,
	                                               estimates.estmt_prjct_name,
                                               　　estimates.estmt_amount,
	                                               estimates.estmt_taxin,
                                               　　estimates.estmt_tax,
	                                               estimates.estmt_taxrate,
	                                               estimates.prjct_address,
	                                               estimates.deliveryplace,
	                                               estimates.paymentterms,
	                                               estimates.expirationdate,
                                               　　estimates.destination,
	                                               estimates.pblshr_address,
	                                               estimates.pblshr_cmpnyname,
	                                               estimates.pblshr_prsdnt,
                                               　　estimates.pblshr_tel,
	                                               estimates.pblshr_fax,
	                                               estimates.conditions,
	                                               estimates.cndtns_dtls1,
	                                               estimates.cndtns_dtls2,
	                                               estimates.cndtns_dtls3,
	                                               estimates.cndtns_dtls4,
	                                               estimates.cndtns_dtls5,
	                                               estimates.discount,
	                                               estimates.bdrate
                                    FROM  estimates;"
        レポート.C1FlexReport1.DataSources.Add(ReportData)
        レポート.C1FlexReport1.DataSourceName = ReportData.Name



        レポート.C1FlexViewer1.DocumentSource = レポート.C1FlexReport1



        Return ReportLoad
    End Function
End Class
