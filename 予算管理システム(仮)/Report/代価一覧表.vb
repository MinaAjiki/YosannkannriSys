Imports System.Data.SqlClient
Imports C1.Win.FlexReport
Public Class 代価一覧表
	Private CstClssCode As Integer
	Private CstClssName As String
	Public Sub New(ByVal CostClass_Code As Integer, ByVal CostClass_Name As String)
		CstClssCode = CostClass_Code
		CstClssName = CostClass_Name
	End Sub
	Public Function ReportLoad() As String

		ReportLoad = ""

		レポート.C1FlexReport1.Load(ホーム.Reportpath, "代価一覧表")

		Dim ReportData As DataSource = New DataSource
		ReportData.Name = "ReportDataSource"
		ReportData.DataProvider = DataProvider.OLEDB

		Dim TitleField As C1.Win.FlexReport.Field
		TitleField = CType(レポート.C1FlexReport1.Fields("ReportTitle"), C1.Win.FlexReport.Field)
		TitleField.Text = "工事代価表　" & CstClssName.Last

		ReportData.ConnectionString = "Provider=MSOLEDBSQL.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=" & ホーム.UserDataPath & ホーム.UserDataName & ";Data Source=(localdb)\MSSQLLocalDB;"
		ReportData.RecordSource = "SELECT DISTINCT projectcst_bd.budget_no,
                                                   projectcst_bd.cstclss_code,
	                                               projectcst_bd.prjctcst_no,
	                                               projectcst_bd.prjctcst_name,
	                                               projectcst_bd.prjctcst_spec,
	                                               projectcst_bd.prjctcst_unit,
	                                               projectcst_bd.prjctcst_costea,
	                                               projectcst_bd.prjctcst_laborea,
	                                               projectcst_bd.prjctcst_materialea,
	                                               projectcst_bd.prjctcst_machineea,
	                                               projectcst_bd.prjctcst_subcntrctea,
	                                               projectcst_bd.prjctcst_expenseea
	                                FROM  projectcst_bd
                                    WHERE ((projectcst_bd.budget_no) =" & ホーム.BudgetNo & ") AND ((projectcst_bd.cstclss_code) =" & CstClssCode & ") 
									GROUP BY projectcst_bd.budget_no,
                                                   projectcst_bd.cstclss_code,
	                                               projectcst_bd.prjctcst_no,
	                                               projectcst_bd.prjctcst_name,
	                                               projectcst_bd.prjctcst_spec,
	                                               projectcst_bd.prjctcst_unit,
	                                               projectcst_bd.prjctcst_costea,
	                                               projectcst_bd.prjctcst_laborea,
	                                               projectcst_bd.prjctcst_materialea,
	                                               projectcst_bd.prjctcst_machineea,
	                                               projectcst_bd.prjctcst_subcntrctea,
	                                               projectcst_bd.prjctcst_expenseea
                                    ORDER BY projectcst_bd.prjctcst_no;"
		レポート.C1FlexReport1.DataSources.Add(ReportData)


		レポート.C1FlexReport1.DataSourceName = ReportData.Name

		レポート.C1FlexViewer1.DocumentSource = レポート.C1FlexReport1

		Return ReportLoad
	End Function
End Class
