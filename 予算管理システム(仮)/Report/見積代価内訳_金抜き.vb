Imports System.Data.SqlClient
Imports C1.Win.FlexReport
Public Class 見積代価内訳_金抜き
    Public Function ReportLoad() As String

        ReportLoad = ""

        レポート.C1FlexReport1.Load(ホーム.Reportpath, "見積代価内訳(金抜き)")

        Dim ReportData As DataSource = New DataSource
        ReportData.Name = "ReportDataSource"
        ReportData.DataProvider = DataProvider.OLEDB
        ReportData.ConnectionString = "Provider=MSOLEDBSQL.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=" & ホーム.UserDataPath & ホーム.UserDataName & ";Data Source=(localdb)\MSSQLLocalDB;"
        ReportData.RecordSource = "SELECT DISTINCT projectcst_bd.budget_no,
                                                   projectcst_bd.cstclss_code,
	                                               projectcst_bd.prjctcst_no,
	                                               projectcst_bd.prjctcst_name,
	                                               projectcst_bd.prjctcst_spec,
	                                               projectcst_bd.prjctcst_unit,
	                                               projectcst_bd.prjctcst_quanity,
	                                               projectcst_bd.prjctcst_costea,
	                                         	   projectcst_bd.prjctcst_amount,
	                                               projectcst_bd.prjctcst_bd_no,
	                                               projectcst_bd.prjctcst_bd_name,
	                                               projectcst_bd.prjctcst_bd_spec,
	                                               projectcst_bd.prjctcst_bd_unit,
	                                               projectcst_bd.prjctcst_bd_remarks,
	                                               projectcst_bd.prjctcst_bd_costea,
	                                               projectcst_bd.prjctcst_bd_quanity,
	                                               projectcst_bd.prjctcst_bd_amount
	                                FROM  projectcst_bd
                                    WHERE ((projectcst_bd.budget_no) =" & ホーム.BudgetNo & ") AND ((projectcst_bd.cstclss_code) =12) 
                                    ORDER BY projectcst_bd.prjctcst_no,projectcst_bd.prjctcst_bd_no;"
        レポート.C1FlexReport1.DataSources.Add(ReportData)
        レポート.C1FlexReport1.DataSourceName = ReportData.Name

        レポート.C1FlexViewer1.DocumentSource = レポート.C1FlexReport1

        Return ReportLoad
    End Function
End Class
