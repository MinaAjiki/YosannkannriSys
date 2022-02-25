Imports System.Data.SqlClient
Imports C1.Win.FlexReport
Public Class 明細内訳書
    Public Function ReportLoad() As String

        ReportLoad = ""

        レポート.C1FlexReport1.Load(ホーム.Reportpath, "明細内訳書")

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

        Dim GrandTotalField As C1.Win.FlexReport.Field
        GrandTotalField = CType(レポート.C1FlexReport1.Fields("amount_total"), C1.Win.FlexReport.Field)
        GrandTotalField.Text = "SUM(dtl_amount)"


        Dim LaborTotalField As C1.Win.FlexReport.Field
        LaborTotalField = CType(レポート.C1FlexReport1.Fields("labor_total"), C1.Win.FlexReport.Field)
        LaborTotalField.Text = "SUM(dtl_labor)"


        Dim MaterialTotalField As C1.Win.FlexReport.Field
        MaterialTotalField = CType(レポート.C1FlexReport1.Fields("material_total"), C1.Win.FlexReport.Field)
        MaterialTotalField.Text = "SUM(dtl_material)"


        Dim MachineTotalField As C1.Win.FlexReport.Field
        MachineTotalField = CType(レポート.C1FlexReport1.Fields("machine_total"), C1.Win.FlexReport.Field)
        MachineTotalField.Text = "SUM(dtl_machine)"


        Dim SubcntrctTotalField As C1.Win.FlexReport.Field
        SubcntrctTotalField = CType(レポート.C1FlexReport1.Fields("subcntrct_total"), C1.Win.FlexReport.Field)
        SubcntrctTotalField.Text = "SUM(dtl_subcntrct)"


        Dim ExpensTotalField As C1.Win.FlexReport.Field
        ExpensTotalField = CType(レポート.C1FlexReport1.Fields("expens_total"), C1.Win.FlexReport.Field)
        ExpensTotalField.Text = "SUM(dtl_expens)"

        レポート.C1FlexViewer1.DocumentSource = レポート.C1FlexReport1

        Return ReportLoad
    End Function
End Class
