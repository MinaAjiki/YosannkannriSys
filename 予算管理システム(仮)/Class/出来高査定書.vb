Imports C1.Win.FlexReport
Imports System.Data.SqlClient
Public Class 出来高査定書
    Private VN As Integer
    Public Sub New(ByVal VendorN As Integer)
        VN = VendorN '処理年月
    End Sub
    Public Function ReportLoad() As String
        Dim ds As New C1.Win.FlexReport.DataSource()
        ds.Name = "MyDataName"

        ReportLoad = ""

        'レポートを読み込む
        Dim report As New C1FlexReport
        レポート.C1FlexReport1.Load(出来高査定チェックフォーム.ReportPath, "出来高査定書")

        Dim DT As New DataTable
        DT.Columns.Add("OutsourcersCode")
        DT.Columns.Add("OutsourcersName")
        DT.Columns.Add("ManagedDate")
        DT.Columns.Add("OrderNo")
        DT.Columns.Add("Code")
        DT.Columns.Add("Worktype")
        DT.Columns.Add("TotalAmount")
        DT.Columns.Add("Name")
        DT.Columns.Add("Spec")
        DT.Columns.Add("Unit")
        DT.Columns.Add("ConQuanity")
        DT.Columns.Add("ConCostea")
        DT.Columns.Add("ConAmount")
        DT.Columns.Add("LaQuanity")
        DT.Columns.Add("LaAmount")
        DT.Columns.Add("ToQuanity")
        DT.Columns.Add("ToAmount")
        DT.Columns.Add("CuQuanity")
        DT.Columns.Add("CuAmount")

        ホーム.Sql.Parameters.Clear()

        Dim vendorid As Integer = VN
        ホーム.Sql.CommandText = "SELECT outsrcr_name FROM outsourcers WHERE outsrcr_code = " & VN
        Dim vendorname As String = ホーム.Sql.ExecuteScalar
        ホーム.Sql.CommandText = "SELECT no FROM purchase_orders WHERE outsrcr_id = (SELECT outsrcr_id FROM outsourcers WHERE outsrcr_code = " & VN & ")"
        Dim orderno As Integer = ホーム.Sql.ExecuteScalar

        Dim DTRow As DataRow = DT.NewRow

        DTRow("OutsourcersCode") = vendorid
        DTRow("OutsourcersName") = vendorname
        DTRow("OrderNo") = orderno
        DT.Rows.Add(DTRow)

        ds.Recordset = DT
        レポート.C1FlexReport1.DataSources.Add(ds)
        レポート.C1FlexReport1.DataSourceName = ds.Name
        レポート.C1FlexViewer1.DocumentSource = レポート.C1FlexReport1
    End Function

End Class
