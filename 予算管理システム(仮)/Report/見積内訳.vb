Imports System.Data.SqlClient
Imports C1.Win.FlexReport

Public Class 見積内訳_金抜き
    Public Function ReportLoad() As String

        ReportLoad = ""

        'レポートを読み込む
        レポート.C1FlexReport1.Load(ホーム.Reportpath, "見積内訳(金抜き)")


        Dim ReportData As DataSource = New DataSource
        ReportData.Name = "ReportDataSource"
        ReportData.DataProvider = DataProvider.OLEDB
        ReportData.ConnectionString = "Provider=MSOLEDBSQL.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=" & ホーム.UserDataPath & ホーム.UserDataName & ";Data Source=(localdb)\MSSQLLocalDB;"
        ReportData.RecordSource = "SELECT DISTINCT details_bd.s_wrktyp_code,
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
        レポート.C1FlexReport1.DataSources.Add(ReportData)
        レポート.C1FlexReport1.DataSourceName = ReportData.Name



        レポート.C1FlexViewer1.DocumentSource = レポート.C1FlexReport1



        Return ReportLoad
    End Function
End Class
