Imports System.Data.SqlClient
Imports C1.Win.FlexReport
Public Class 基礎代価内訳書_簡易
    Private CstClssCode As Integer
    Private CstClssName As String
    Public Sub New(ByVal CostClass_Code As Integer, ByVal CostClass_Name As String)
        CstClssCode = CostClass_Code
        CstClssName = CostClass_Name
    End Sub
    Public Function ReportLoad() As String

        ReportLoad = ""

        レポート.C1FlexReport1.Load(ホーム.Reportpath, "基礎代価内訳書(簡易)")

        Dim ReportData As DataSource = New DataSource
        ReportData.Name = "ReportDataSource"
        ReportData.DataProvider = DataProvider.OLEDB
        ReportData.ConnectionString = "Provider=MSOLEDBSQL.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=PMS;Data Source=SVACD001;"

        ホーム.Sql.CommandText = "SELECT contents FROM controldata WHERE class_code=12"
        Dim Year As Integer = ホーム.Sql.ExecuteScalar

        ReportData.RecordSource = "SELECT DISTINCT basis_costs_view.year,
	basis_costs_view.cstclss_code,
	basis_costs_view.bsscst_no,
	basis_costs_view.bsscst_name,
	basis_costs_view.bsscst_spec,
	basis_costs_view.bsscst_unit,
	basis_costs_view.bsscst_quanity,
	basis_costs_view.bsscst_costea,
	basis_costs_view.bsscst_amount,
basis_costs_view.bsscst_bd_no,
	basis_costs_view.bsscst_bd_name,
	basis_costs_view.bsscst_bd_spec,
	basis_costs_view.bsscst_bd_unit,
	basis_costs_view.bsscst_bd_amount,
	basis_costs_view.bsscst_bd_costea,
	basis_costs_view.bsscst_bd_remarks,
    basis_costs_view.bsscst_bd_quanity
FROM  basis_costs_view
WHERE ((basis_costs_view.year) =" & Year & ") 
ORDER BY basis_costs_view.bsscst_no,basis_costs_view.bsscst_bd_no;"
        レポート.C1FlexReport1.DataSources.Add(ReportData)
        レポート.C1FlexReport1.DataSourceName = ReportData.Name

        レポート.C1FlexViewer1.DocumentSource = レポート.C1FlexReport1

        Return ReportLoad
    End Function
End Class
