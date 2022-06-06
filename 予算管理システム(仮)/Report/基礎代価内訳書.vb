Imports System.Data.SqlClient
Imports C1.Win.FlexReport
Public Class 基礎代価内訳書
    Private CstClssCode As Integer
    Private CstClssName As String
    Public Sub New(ByVal CostClass_Code As Integer, ByVal CostClass_Name As String)
        CstClssCode = CostClass_Code
        CstClssName = CostClass_Name
    End Sub
    Public Function ReportLoad() As String

        ReportLoad = ""

        レポート.C1FlexReport1.Load(ホーム.Reportpath, "基礎代価内訳書")

        Dim ReportData As DataSource = New DataSource
        ReportData.Name = "ReportDataSource"
        ReportData.DataProvider = DataProvider.OLEDB
        ReportData.ConnectionString = "Provider=MSOLEDBSQL.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=PMS;Data Source=SVACD001;"

        ホーム.Sql.CommandText = "SELECT contents FROM controldata WHERE class_code=12"
        Dim Year As Integer = ホーム.Sql.ExecuteScalar
        ReportData.RecordSource = "SELECT DISTINCT basis_costs_view.year,
	basis_costs_view.bsscst_no,
	basis_costs_view.bsscst_name,
	basis_costs_view.bsscst_spec,
	basis_costs_view.bsscst_unit,
	basis_costs_view.bsscst_quanity,
	basis_costs_view.bsscst_costea,
	basis_costs_view.bsscst_laborea,
	basis_costs_view.bsscst_materialea,
	basis_costs_view.bsscst_machineea,
	basis_costs_view.bsscst_subcnstrctea,
	basis_costs_view.bsscst_expnseea,
	basis_costs_view.bsscst_amount,
	basis_costs_view.bsscst_bd_no,
	basis_costs_view.bsscst_bd_name,
	basis_costs_view.bsscst_bd_spec,
	basis_costs_view.bsscst_bd_unit,
	basis_costs_view.bsscst_bd_amount,
	basis_costs_view.bsscst_bd_costea,
	basis_costs_view.bsscst_bd_labor,
	basis_costs_view.bsscst_bd_material,
	basis_costs_view.bsscst_bd_machine,
	basis_costs_view.bsscst_bd_subcntrct,
	basis_costs_view.bsscst_bd_expense,
	basis_costs_view.bsscst_bd_remarks,
    basis_costs_view.bsscst_bd_quanity
FROM  basis_costs_view
WHERE ((basis_costs_view.year) =" & Year & ") 
ORDER BY basis_costs_view.bsscst_no,basis_costs_view.bsscst_bd_no;"
        レポート.C1FlexReport1.DataSources.Add(ReportData)
        レポート.C1FlexReport1.DataSourceName = ReportData.Name


        Dim GrandTotalField As C1.Win.FlexReport.Field
        GrandTotalField = CType(レポート.C1FlexReport1.Fields("amount_total"), C1.Win.FlexReport.Field)
        GrandTotalField.Text = "SUM(bsscst_bd_amount)"


        Dim LaborTotalField As C1.Win.FlexReport.Field
        LaborTotalField = CType(レポート.C1FlexReport1.Fields("labor_total"), C1.Win.FlexReport.Field)
        LaborTotalField.Text = "SUM(bsscst_bd_labor)"


        Dim MaterialTotalField As C1.Win.FlexReport.Field
        MaterialTotalField = CType(レポート.C1FlexReport1.Fields("material_total"), C1.Win.FlexReport.Field)
        MaterialTotalField.Text = "SUM(bsscst_bd_material)"


        Dim MachineTotalField As C1.Win.FlexReport.Field
        MachineTotalField = CType(レポート.C1FlexReport1.Fields("machine_total"), C1.Win.FlexReport.Field)
        MachineTotalField.Text = "SUM(bsscst_bd_machine)"


        Dim SubcntrctTotalField As C1.Win.FlexReport.Field
        SubcntrctTotalField = CType(レポート.C1FlexReport1.Fields("subcntrct_total"), C1.Win.FlexReport.Field)
        SubcntrctTotalField.Text = "SUM(bsscst_bd_subcntrct)"

        Dim ExpensTotalField As C1.Win.FlexReport.Field
        ExpensTotalField = CType(レポート.C1FlexReport1.Fields("expens_total"), C1.Win.FlexReport.Field)
        ExpensTotalField.Text = "SUM(bsscst_bd_expense)"

        レポート.C1FlexViewer1.DocumentSource = レポート.C1FlexReport1

        Return ReportLoad
    End Function
End Class
