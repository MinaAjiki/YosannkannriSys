Imports C1.Win.FlexReport
Imports System.Data.SqlClient
Public Class 出来高査定書

    Public Sub New(ByVal VendorN As Integer)
        出来高査定チェックフォーム.VN = VendorN '
    End Sub
    Public Function ReportLoad() As String

        ReportLoad = ""

        'レポートを読み込む
        レポート.C1FlexReport1.Load(ホーム.Reportpath, "出来高査定書")

        ホーム.Sql.CommandText = "SELECT outsrcr_id FROM outsourcers WHERE outsrcr_code = " & 出来高査定チェックフォーム.VN
        Dim outsrcrid As Integer = ホーム.Sql.ExecuteScalar

        Dim ReportData As DataSource = New DataSource
        ReportData.Name = "ReportDataSource"
        ReportData.DataProvider = DataProvider.OLEDB
        ReportData.ConnectionString = "Provider=MSOLEDBSQL.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=" & ホーム.UserDataPath & ホーム.UserDataName & ";Data Source=(localdb)\MSSQLLocalDB;"
        'ReportData.ConnectionString = "Provider=MSOLEDBSQL;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=D:\DD0000テスト工事.MDF;Data Source=(localdb)\MSSQLLocalDB;"
        ReportData.RecordSource = "Select DISTINCT Production_View.budget_no,
        	Production_View.outsrc_no,
            Production_View.outsrcr_id,
            Production_View.no,
            Production_View.s_worktype_code,
            Production_View.s_wrktyp_name,
            Production_View.dtl_id,
            Production_View.dtl_name,
            Production_View.dtl_spec,
            Production_View.dtl_unit,
            Production_View.outsrcng_quanity,
            Production_View.outsrcng_costea,
            Production_View.outsrcng_amount,
            Production_View.last_quanity,
            Production_View.last_amount,
            Production_View.total_quanity,
            Production_View.total_amount,
            Production_View.now_quanity,
            Production_View.now_amount
        From Production_View
        Where 
            ((Production_View.outsrc_no) = (SELECT MAX(outsrc_no) FROM Production_View)) And
            ((Production_View.outsrcr_id) = " & outsrcrid & ");"
        レポート.C1FlexReport1.DataSources.Add(ReportData)
        レポート.C1FlexReport1.DataSourceName = ReportData.Name

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
        field.Text = "[" & 出来高査定チェックフォーム.VN & "]"

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
        field4.Text = Dline.Replace("-", "/")

        'レポート.C1FlexReport1.DataSources.Add(ds)
        'レポート.C1FlexReport1.DataSourceName = ds.Name
        レポート.C1FlexViewer1.DocumentSource = レポート.C1FlexReport1
        Return ReportLoad
    End Function

End Class
