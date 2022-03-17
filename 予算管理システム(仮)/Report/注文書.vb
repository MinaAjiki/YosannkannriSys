Imports C1.Win.FlexReport
Imports System.Data.SqlClient
Public Class 注文書

    Public Sub New(ByVal VendorN As Integer)
        協力業者選択.SelectVendorCode(0) = VendorN '
    End Sub
    Public Function ReportLoad() As String

        進行状況.Show()
        進行状況.Refresh()

        ReportLoad = ""

        'レポートを読み込む
        If 協力業者選択.ParentFormName = "注文書" Then
            レポート.C1FlexReport1.Load(ホーム.Reportpath, "注文書")
        ElseIf 協力業者選択.ParentFormName = "注文書金抜" Then
            レポート.C1FlexReport1.Load(ホーム.Reportpath, "注文書金抜")
        ElseIf 協力業者選択.ParentFormName = "注文書折衝" Then
            レポート.C1FlexReport1.Load(ホーム.Reportpath, "注文書折衝")
        End If

        ホーム.Sql.CommandText = "SELECT outsrcr_id FROM outsourcers WHERE outsrcr_code = " & 協力業者選択.SelectVendorCode(0)
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

        Dim vendorcode As Integer = 協力業者選択.SelectVendorCode(0)
        ホーム.Sql.CommandText = "SELECT outsrcr_name FROM outsourcers WHERE outsrcr_code = " & 協力業者選択.SelectVendorCode(0)
        Dim vendorname As String = ホーム.Sql.ExecuteScalar
        ホーム.Sql.CommandText = "SELECT outsrcr_id FROM outsourcers WHERE outsrcr_code = " & 協力業者選択.SelectVendorCode(0)
        Dim vendorid As String = ホーム.Sql.ExecuteScalar
        ホーム.Sql.CommandText = "SELECT contents FROM controldata WHERE class_code=20"
        Dim Pcode As String = ホーム.Sql.ExecuteScalar
        ホーム.Sql.CommandText = "SELECT contents FROM controldata WHERE class_code=21"
        Dim Pname As String = ホーム.Sql.ExecuteScalar

        Dim field As Field
        field = CType(レポート.C1FlexReport1.Fields("業者コード"), Field)
        field.Text = "[" & 協力業者選択.SelectVendorCode(0) & "]"

        Dim field1 As Field
        field1 = CType(レポート.C1FlexReport1.Fields("会社名"), Field)
        field1.Text = vendorname

        Dim field2 As TextField
        field2 = CType(レポート.C1FlexReport1.Fields("工事コード"), TextField)
        field2.Text = Pcode

        Dim field3 As TextField
        field3 = CType(レポート.C1FlexReport1.Fields("工事名"), TextField)
        field3.Text = Pname

        進行状況.Close()

        レポート.C1FlexViewer1.DocumentSource = レポート.C1FlexReport1
        Return ReportLoad
    End Function

End Class
