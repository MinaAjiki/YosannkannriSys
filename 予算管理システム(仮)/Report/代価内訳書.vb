Imports System.Data.SqlClient
Imports C1.Win.FlexReport
Public Class 代価内訳書
    Private CstClssCode As Integer
    Private CstClssName As String
    Public Sub New(ByVal CostClass_Code As Integer, ByVal CostClass_Name As String)
        CstClssCode = CostClass_Code
        CstClssName = CostClass_Name
    End Sub
    Public Function ReportLoad() As String

        ReportLoad = ""

        レポート.C1FlexReport1.Load(ホーム.Reportpath, "代価内訳書")

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
	                                               projectcst_bd.prjctcst_laborea,
	                                               projectcst_bd.prjctcst_materialea,
	                                               projectcst_bd.prjctcst_machineea,
	                                               projectcst_bd.prjctcst_subcntrctea,
	                                               projectcst_bd.prjctcst_expenseea,
	                                               projectcst_bd.prjctcst_amount,
	                                               projectcst_bd.prjctcst_bd_no,
	                                               projectcst_bd.prjctcst_bd_name,
	                                               projectcst_bd.prjctcst_bd_spec,
	                                               projectcst_bd.prjctcst_bd_unit,
	                                               projectcst_bd.prjctcst_bd_remarks,
	                                               projectcst_bd.prjctcst_bd_costea,
	                                               projectcst_bd.prjctcst_bd_quanity,
	                                               projectcst_bd.prjctcst_bd_amount,
	                                               projectcst_bd.prjctcst_bd_labor,
	                                               projectcst_bd.prjctcst_bd_material,
	                                               projectcst_bd.prjctcst_bd_machine,
	                                               projectcst_bd.prjctcst_bd_subcntrct,
	                                               projectcst_bd.prjctcst_bd_expense
                                    FROM  projectcst_bd
                                    WHERE ((projectcst_bd.budget_no) =" & ホーム.BudgetNo & ") AND ((projectcst_bd.cstclss_code) =" & CstClssCode & ") 
                                    ORDER BY projectcst_bd.prjctcst_no,projectcst_bd.prjctcst_bd_no;"
        レポート.C1FlexReport1.DataSources.Add(ReportData)
        レポート.C1FlexReport1.DataSourceName = ReportData.Name


        Dim TitleField As C1.Win.FlexReport.Field
        TitleField = CType(レポート.C1FlexReport1.Fields("ReportTitle"), C1.Win.FlexReport.Field)
        TitleField.Text = "工事代価表"

        Dim CostNoField As C1.Win.FlexReport.TextField
        CostNoField = CType(レポート.C1FlexReport1.Fields("cstclssname"), C1.Win.FlexReport.TextField)
        CostNoField.Text = CstClssName.Last

        Dim GrandTotalField As C1.Win.FlexReport.Field
        GrandTotalField = CType(レポート.C1FlexReport1.Fields("amount_total"), C1.Win.FlexReport.Field)
        GrandTotalField.Text = "SUM(prjctcst_bd_amount)"


        Dim LaborTotalField As C1.Win.FlexReport.Field
        LaborTotalField = CType(レポート.C1FlexReport1.Fields("labor_total"), C1.Win.FlexReport.Field)
        LaborTotalField.Text = "SUM(prjctcst_bd_labor)"


        Dim MaterialTotalField As C1.Win.FlexReport.Field
        MaterialTotalField = CType(レポート.C1FlexReport1.Fields("material_total"), C1.Win.FlexReport.Field)
        MaterialTotalField.Text = "SUM(prjctcst_bd_material)"


        Dim MachineTotalField As C1.Win.FlexReport.Field
        MachineTotalField = CType(レポート.C1FlexReport1.Fields("machine_total"), C1.Win.FlexReport.Field)
        MachineTotalField.Text = "SUM(prjctcst_bd_machine)"


        Dim SubcntrctTotalField As C1.Win.FlexReport.Field
        SubcntrctTotalField = CType(レポート.C1FlexReport1.Fields("subcntrct_total"), C1.Win.FlexReport.Field)
        SubcntrctTotalField.Text = "SUM(prjctcst_bd_subcntrct)"


        Dim ExpensTotalField As C1.Win.FlexReport.Field
        ExpensTotalField = CType(レポート.C1FlexReport1.Fields("expens_total"), C1.Win.FlexReport.Field)
        ExpensTotalField.Text = "SUM(prjctcst_bd_expense)"

        レポート.C1FlexViewer1.DocumentSource = レポート.C1FlexReport1

        Return ReportLoad
    End Function
End Class
