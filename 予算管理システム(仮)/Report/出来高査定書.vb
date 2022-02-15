Imports C1.Win.FlexReport
Imports System.Data.SqlClient
Public Class 出来高査定書

    Public Sub New(ByVal VendorN As Integer)
        出来高査定チェックフォーム.VN = VendorN '
    End Sub
    Public Function ReportLoad() As String
        Dim ds As New C1.Win.FlexReport.DataSource()
        ds.Name = "MyDataName"

        ReportLoad = ""

        'レポートを読み込む
        Dim report As New C1FlexReport
        レポート.C1FlexReport1.Load(ホーム.ReportPath, "出来高査定書")

        'Dim DT As New DataTable
        'DT.Columns.Add("OutsourcersCode")
        'DT.Columns.Add("OutsourcersName")
        'DT.Columns.Add("ManagedDate")
        'DT.Columns.Add("OrderNo")
        'DT.Columns.Add("Code")
        'DT.Columns.Add("Worktype")
        'DT.Columns.Add("TotalAmount")
        'DT.Columns.Add("Name")
        'DT.Columns.Add("Spec")
        'DT.Columns.Add("Unit")
        'DT.Columns.Add("ConQuanity")
        'DT.Columns.Add("ConCostea")
        'DT.Columns.Add("ConAmount")
        'DT.Columns.Add("LaQuanity")
        'DT.Columns.Add("LaAmount")
        'DT.Columns.Add("ToQuanity")
        'DT.Columns.Add("ToAmount")
        'DT.Columns.Add("CuQuanity")
        'DT.Columns.Add("CuAmount")

        'ホーム.Sql.Parameters.Clear()
        'Dim DTRow As DataRow = DT.NewRow
        'DTRow("OutsourcersCode") = vendorid
        'DTRow("OrderNo") = orderno
        'DT.Rows.Add(DTRow)

        'ds.Recordset = DT
        Dim vendorcode As Integer = 出来高査定チェックフォーム.VN
        ホーム.Sql.CommandText = "SELECT outsrcr_name FROM outsourcers WHERE outsrcr_code = " & 出来高査定チェックフォーム.VN
        Dim vendorname As String = ホーム.Sql.ExecuteScalar
        ホーム.Sql.CommandText = "SELECT outsrcr_id FROM outsourcers WHERE outsrcr_code = " & 出来高査定チェックフォーム.VN
        Dim vendorid As String = ホーム.Sql.ExecuteScalar
        ホーム.Sql.CommandText = "SELECT contents FROM controldata WHERE class_code=20"
        Dim Pcode As String = ホーム.Sql.ExecuteScalar
        ホーム.Sql.CommandText = "SELECT contents FROM controldata WHERE class_code=21"
        Dim Pname As String = ホーム.Sql.ExecuteScalar
        ホーム.Sql.CommandText = "SELECT contents FROM controldata WHERE class_code=30"
        Dim Dline As String = ホーム.Sql.ExecuteScalar

        Dim field As TextField
        field = CType(レポート.C1FlexReport1.Fields("業者コード"), TextField)
        field.Text = 出来高査定チェックフォーム.VN

        Dim field1 As TextField
        field1 = CType(レポート.C1FlexReport1.Fields("会社名"), TextField)
        field1.Text = vendorname

        Dim field2 As TextField
        field2 = CType(レポート.C1FlexReport1.Fields("工事コード"), TextField)
        field2.Text = Pcode

        Dim field3 As TextField
        field3 = CType(レポート.C1FlexReport1.Fields("工事名"), TextField)
        field3.Text = Pname

        Dim field4 As TextField
        field4 = CType(レポート.C1FlexReport1.Fields("締切日"), TextField)
        field4.Text = Dline

        'レポート.C1FlexReport1.DataSources.Add(ds)
        'レポート.C1FlexReport1.DataSourceName = ds.Name
        レポート.C1FlexViewer1.DocumentSource = レポート.C1FlexReport1
    End Function

End Class
