Imports System.Data.SqlClient
Imports C1.Win.FlexReport
Public Class 基礎単価表
    Private CstClss_Code As Integer
    Public Sub New(ByVal CostClass_Code As Integer)
        CstClss_Code = CostClass_Code
    End Sub
    Public Function ReportLoad() As String

        ReportLoad = ""

        'レポートを読み込む
        レポート.C1FlexReport1.Load(ホーム.Reportpath, "基礎単価表")


        Dim ReportData As DataSource = New DataSource
        ReportData.Name = "ReportDataSource"
        ReportData.DataProvider = DataProvider.OLEDB
        ReportData.ConnectionString = "Provider=MSOLEDBSQL.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=" & ホーム.UserDataPath & ホーム.UserDataName & ";Data Source=(localdb)\MSSQLLocalDB;"
        ReportData.RecordSource = "SELECT DISTINCT cost_masters.cstclss_code,
                                                	cost_masters.cstmstr_category,
	                                                cost_masters.cstmstr_code,
                                                    cost_masters.cstmstr_name,
                                	                cost_masters.cstmstr_spec,
                                	                cost_masters.cstmstr_unit,
                                                 	cost_masters.cstmstr_costea
                                    FROM  cost_masters WHERE ((cost_masters.cstclss_code) =" & CstClss_Code & ")ORDER BY cost_masters.cstmstr_code;"
        レポート.C1FlexReport1.DataSources.Add(ReportData)
        レポート.C1FlexReport1.DataSourceName = ReportData.Name

        Dim ReportNameField As C1.Win.FlexReport.Field
        ReportNameField = CType(レポート.C1FlexReport1.Fields("ReportName"), C1.Win.FlexReport.Field)
        If CstClss_Code = 1 Then
            ReportNameField.Text = "労務単価表"
        ElseIf CstClss_Code = 2 Then
            ReportNameField.Text = "材料単価表"
        ElseIf CstClss_Code = 3 Then
            ReportNameField.Text = "機械単価表"
        ElseIf CstClss_Code = 4 Then
            ReportNameField.Text = "外注単価表"
        ElseIf CstClss_Code = 6 Then
            ReportNameField.Text = "社内機材単価表"
        ElseIf CstClss_Code = 7 Then
            ReportNameField.Text = "社外機材単価表"
        End If


        レポート.C1FlexViewer1.DocumentSource = レポート.C1FlexReport1



        Return ReportLoad
    End Function
End Class
