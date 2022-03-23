Imports System.Data.SqlClient
Imports C1.Win.FlexReport
Public Class 入力表_工務課用
    Public Function ReportLoad() As String

        ReportLoad = ""

        レポート.C1FlexReport1.Load(ホーム.Reportpath, "入力表(工務課用)")

        Dim ReportData As DataSource = New DataSource
        ReportData.Name = "ReportDataSource"
        ReportData.DataProvider = DataProvider.OLEDB
        ReportData.ConnectionString = "Provider=MSOLEDBSQL.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=" & ホーム.UserDataPath & ホーム.UserDataName & ";Data Source=(localdb)\MSSQLLocalDB;"
        ReportData.RecordSource = "SELECT DISTINCT subject_details.s_wrktyp_code,
	subject_details.s_wrktyp_name,
    subject_details.budget_no,
	subject_details.dtl_id,
	subject_details.dtl_name,
	subject_details.dtl_spec,
	subject_details.dtl_unit,
	subject_details.dtl_quanity,
	subject_details.dtl_costea,
	subject_details.dtl_amount,
	subject_details.amount1,
	subject_details.amount2,
	subject_details.amount3,
	subject_details.amount4,
	subject_details.amount5,
	subject_details.amount6,
	subject_details.amount7,
	subject_details.amount8,
	subject_details.amount9
FROM  subject_details
WHERE ((subject_details.budget_no) =" & ホーム.BudgetNo & ") 
ORDER BY subject_details.s_wrktyp_code;"
        レポート.C1FlexReport1.DataSources.Add(ReportData)
        レポート.C1FlexReport1.DataSourceName = ReportData.Name

        ホーム.Sql.CommandText = "SELECT contents FROM controldata WHERE class_code=20"
        Dim ProjectCode As String = ホーム.Sql.ExecuteScalar

        ホーム.Sql.CommandText = "SELECT contents FROM controldata WHERE class_code=21"
        Dim ProjectName As String = ホーム.Sql.ExecuteScalar

        Dim ProjectCodeField As C1.Win.FlexReport.Field
        ProjectCodeField = CType(レポート.C1FlexReport1.Fields("ProjectCode"), C1.Win.FlexReport.Field)
        ProjectCodeField.Text = ProjectCode

        Dim ProjectNameField As C1.Win.FlexReport.Field
        ProjectNameField = CType(レポート.C1FlexReport1.Fields("ProjectName"), C1.Win.FlexReport.Field)
        ProjectNameField.Text = ProjectName

        レポート.C1FlexViewer1.DocumentSource = レポート.C1FlexReport1

        Return ReportLoad
    End Function
End Class
