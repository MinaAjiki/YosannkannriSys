Imports C1.Win.FlexReport
Imports System.Data.SqlClient
Public Class 外注計画
    Public Sub New()

    End Sub

    Public Function ReportLoad() As String
        Dim ds As New C1.Win.FlexReport.DataSource()
        ds.Name = "MyDataName"
        ReportLoad = ""

        'レポートを読み込む
        レポート.C1FlexReport1.Load(ホーム.ReportPath, "外注計画")
        'レポート.C1FlexReport1.Load("C:\Users\206029\Documents\Visual Studio 2008\Projects\勤怠入力支援システム\勤怠入力支援システム\勤怠入力支援システムレポート.flxr", "チェックリスト")
        レポート.C1FlexViewer1.DocumentSource = レポート.C1FlexReport1

        Dim ReportData As DataSource = New DataSource
        ReportData.Name = "ReportDataSource"
        ReportData.DataProvider = DataProvider.OLEDB
        ReportData.ConnectionString = "Provider=MSOLEDBSQL.1;Integrated Security=SSPI;Persist Security Info=False;User ID="";Initial Catalog=D:\DD0000テスト工事.mdf;Data Source=(localdb)\MSSQLLocalDB;Initial File Name="";Server SPN="";Authentication="";Access Token="""
        ReportData.RecordSource = "SELECT * FROM  bdgt_smmry_report WHERE ((bdgt_smmry_report.budget_no) = " & ホーム.BudgetNo & ");"
        レポート.C1FlexReport1.DataSources.Add(ReportData)
        レポート.C1FlexReport1.DataSourceName = ReportData.Name

        ホーム.Sql.CommandText = "SELECT contents FROM controldata WHERE class_code=20"
        Dim Pcode As String = ホーム.Sql.ExecuteScalar
        ホーム.Sql.CommandText = "SELECT contents FROM controldata WHERE class_code=21"
        Dim Pname As String = ホーム.Sql.ExecuteScalar
        ホーム.Sql.CommandText = "SELECT created_date FROM outsourcing_reports WHERE outsrc_no = (SELECT MAX(outsrc_no) FROM outsourcing_reports)"
        Dim Pdate As Date = ホーム.Sql.ExecuteScalar
        ホーム.Sql.CommandText = "SELECT prjct_term_s FROM budget_summary WHERE budget_no = (SELECT MAX(budget_no) FROM budget_summary)"
        Dim Pterms As Date = ホーム.Sql.ExecuteScalar
        ホーム.Sql.CommandText = "SELECT prjct_term_e FROM budget_summary WHERE budget_no = (SELECT MAX(budget_no) FROM budget_summary)"
        Dim Pterme As Date = ホーム.Sql.ExecuteScalar

        Dim field2 As TextField
        field2 = CType(レポート.C1FlexReport1.Fields("工事コード"), TextField)
        field2.Text = Pcode

        Dim field3 As TextField
        field3 = CType(レポート.C1FlexReport1.Fields("工事名"), TextField)
        field3.Text = Pname

        Dim field4 As Field
        field4 = CType(レポート.C1FlexReport1.Fields("外注計画作成日"), Field)
        field4.Value = Pdate

        Dim field8 As TextField
        field8 = CType(レポート.C1FlexReport1.Fields("着工日"), TextField)
        field8.Text = Pterms

        Dim field9 As TextField
        field9 = CType(レポート.C1FlexReport1.Fields("完成日"), textField)
        field9.Text = Pterme

        '選択業者パラメータセット
        Dim SelectVendorlist(協力業者選択.SelectVendorcount - 1) As String
        Dim datacount As Integer = 0
        For Listinsert As Integer = 0 To 4
            If Listinsert > 協力業者選択.SelectVendorcount - 1 Then
                Exit For
            End If
            SelectVendorlist(Listinsert) = 協力業者選択.SelectVendorName(Listinsert)
        Next
        レポート.C1FlexReport1.Parameters("prmOutsrcr").Value = SelectVendorlist

        Dim VendorIDList As New List(Of Integer)

        '業者数ループ
        For listcountloop As Integer = 0 To SelectVendorlist.Count - 1
            Dim code As String = 協力業者選択.SelectVendorCode(listcountloop)
            Dim field As TextField
            field = CType(レポート.C1FlexReport1.Fields("outsrcr_code" & listcountloop), TextField)
            field.Text = code

            ホーム.Sql.CommandText = "SELECT outsrcr_term_s FROM outsourcers WHERE outsrcr_code = " & 協力業者選択.SelectVendorCode(listcountloop)
            Dim terms As Date = ホーム.Sql.ExecuteScalar
            Dim field5 As TextField
            field5 = CType(レポート.C1FlexReport1.Fields("term_s" & listcountloop), TextField)
            field5.Value = terms

            ホーム.Sql.CommandText = "SELECT outsrcr_term_e FROM outsourcers WHERE outsrcr_code = " & 協力業者選択.SelectVendorCode(listcountloop)
            Dim terme As Date = ホーム.Sql.ExecuteScalar
            Dim field6 As TextField
            field6 = CType(レポート.C1FlexReport1.Fields("term_e" & listcountloop), TextField)
            field6.Value = terme

            ホーム.Sql.CommandText = "SELECT ordrfrm FROM outsourcers WHERE outsrcr_code = " & 協力業者選択.SelectVendorCode(listcountloop)
            Dim ordr As Integer = ホーム.Sql.ExecuteScalar
            Dim ordrfrm As String = ""
            If ordr = 11 Then
                ordrfrm = "工事課発注"
            ElseIf ordr = 12 Then
                ordrfrm = "購買発注"
            End If
            Dim field7 As TextField
            field7 = CType(レポート.C1FlexReport1.Fields("ordrfrm" & listcountloop), TextField)
            field7.Value = ordrfrm

            '業者IDリスト作成
            ホーム.Sql.CommandText = "SELECT outsrcr_id FROM Outsourcers WHERE outsrcr_code = " & 協力業者選択.SelectVendorCode(listcountloop)
            Dim VendorIDReader As SqlDataReader = ホーム.Sql.ExecuteReader
            While VendorIDReader.Read
                VendorIDList.Add(VendorIDReader.Item("outsrcr_id"))
            End While
            VendorIDReader.Close()

        Next

        'テーブル作成
        Dim DT As New DataTable
        DT.Columns.Add("s_wrktyp_code")
        DT.Columns.Add("s_wrktyp_name")
        DT.Columns.Add("dtl_name")
        DT.Columns.Add("dtl_unit")
        DT.Columns.Add("dtl_quanity")
        DT.Columns.Add("dtl_costea")
        DT.Columns.Add("dtl_amount")
        DT.Columns.Add("outsrcr_quanity0")
        DT.Columns.Add("outsrcr_costea0")
        DT.Columns.Add("outsrcr_amount0")
        DT.Columns.Add("outsrcr_quanity1")
        DT.Columns.Add("outsrcr_costea1")
        DT.Columns.Add("outsrcr_amount1")
        DT.Columns.Add("outsrcr_quanity2")
        DT.Columns.Add("outsrcr_costea2")
        DT.Columns.Add("outsrcr_amount2")
        DT.Columns.Add("outsrcr_quanity3")
        DT.Columns.Add("outsrcr_costea3")
        DT.Columns.Add("outsrcr_amount3")
        DT.Columns.Add("outsrcr_quanity4")
        DT.Columns.Add("outsrcr_costea4")
        DT.Columns.Add("outsrcr_amount4")
        'For SelectCountLoop As Integer = 0 To 協力業者選択.SelectVendorcount - 1
        '    DT.Columns.Add("outsrcr_quanity" & SelectCountLoop)
        '    DT.Columns.Add("outsrcr_costea" & SelectCountLoop)
        '    DT.Columns.Add("outsrcr_amount" & SelectCountLoop)
        'Next


        '工種数カウント
        ホーム.Sql.CommandText = "SELECT COUNT(DISTINCT s_worktype_code) FROM OutsrcrPlan_View WHERE (outsrc_no IS NULL OR outsrc_no = (SELECT MAX(outsrc_no) FROM OutsrcrPlan_View))"
        Dim SwrktypCount As Integer = ホーム.Sql.ExecuteScalar

        Dim s_wrktyp_codeList As New List(Of Integer)
        Dim s_wrktyp_nameList As New List(Of String)
        ホーム.Sql.CommandText = "SELECT DISTINCT s_worktype_code,s_wrktyp_name FROM OutsrcrPlan_View WHERE (outsrc_no IS NULL OR outsrc_no = (SELECT MAX(outsrc_no) FROM OutsrcrPlan_View)) ORDER BY s_worktype_code ASC"
        Dim SwrktypReader As SqlDataReader = ホーム.Sql.ExecuteReader
        While SwrktypReader.Read
            s_wrktyp_codeList.Add(SwrktypReader.Item("s_worktype_code"))
            s_wrktyp_nameList.Add(SwrktypReader.Item("s_wrktyp_name"))
        End While
        SwrktypReader.Close()

        '工種数ループ
        For SwrktypLoop As Integer = 0 To SwrktypCount - 1
            Dim s_wrktyp_code As Integer = s_wrktyp_codeList(SwrktypLoop)
            Dim s_wrktyp_name As String = s_wrktyp_nameList(SwrktypLoop)
            Dim dtl_name As String = ""
            Dim dtl_unit As String = ""
            Dim dtl_quanity As Decimal = 0
            Dim dtl_costea As Decimal = 0
            Dim dtl_amount As Decimal = 0
            Dim outsrcr_quanity0 As Decimal = 0
            Dim outsrcr_costea0 As Decimal = 0
            Dim outsrcr_amount0 As Decimal = 0
            Dim outsrcr_quanity1 As Decimal = 0
            Dim outsrcr_costea1 As Decimal = 0
            Dim outsrcr_amount1 As Decimal = 0
            Dim outsrcr_quanity2 As Decimal = 0
            Dim outsrcr_costea2 As Decimal = 0
            Dim outsrcr_amount2 As Decimal = 0
            Dim outsrcr_quanity3 As Decimal = 0
            Dim outsrcr_costea3 As Decimal = 0
            Dim outsrcr_amount3 As Decimal = 0
            Dim outsrcr_quanity4 As Decimal = 0
            Dim outsrcr_costea4 As Decimal = 0
            Dim outsrcr_amount4 As Decimal = 0

            '明細数カウント
            ホーム.Sql.CommandText = "SELECT COUNT(DISTINCT dtl_id) FROM OutsrcrPlan_View WHERE (outsrc_no IS NULL OR outsrc_no = (SELECT MAX(outsrc_no) FROM OutsrcrPlan_View)) AND s_worktype_code = " & s_wrktyp_code
            Dim DtlCount As Integer = ホーム.Sql.ExecuteScalar

            ホーム.Sql.CommandText = "SELECT DISTINCT outsrc_no,dtl_id,dtl_no,s_worktype_code,s_wrktyp_name,dtl_name,dtl_spec,dtl_unit,dtl_quanity,dtl_costea,dtl_amount FROM OutsrcrPlan_View WHERE (outsrc_no IS NULL OR outsrc_no = (SELECT MAX(outsrc_no) FROM OutsrcrPlan_View)) AND s_worktype_code =  " & s_wrktyp_code & "  ORDER BY s_worktype_code,dtl_no ASC"
            Dim DtlReader As SqlDataReader = ホーム.Sql.ExecuteReader
            While DtlReader.Read
                dtl_name = DtlReader.Item("dtl_name")
                dtl_unit = DtlReader.Item("dtl_unit")
                dtl_quanity = DtlReader.Item("dtl_quanity")
                dtl_costea = DtlReader.Item("dtl_costea")
                dtl_amount = DtlReader.Item("dtl_amount")

                '業者数ループ
                For VendorLoop As Integer = 0 To 協力業者選択.SelectVendorcount - 1



                Next
                DT.Rows.Add(s_wrktyp_code, s_wrktyp_name, dtl_name, dtl_unit, dtl_quanity, dtl_costea, dtl_amount, outsrcr_quanity0, outsrcr_costea0, outsrcr_amount0, outsrcr_quanity1, outsrcr_costea1, outsrcr_amount1, outsrcr_quanity2, outsrcr_costea2, outsrcr_amount2, outsrcr_quanity3, outsrcr_costea3, outsrcr_amount3, outsrcr_quanity4, outsrcr_costea4, outsrcr_amount4)
            End While
            DtlReader.Close()




        Next

        ds.Recordset = DT
        レポート.C1FlexReport1.DataSources.Add(ds)
        レポート.C1FlexReport1.DataSourceName = ds.Name
        'Dim code0 As Integer = レポート.C1FlexReport1.Parameters("prmOutsrcr").Value
        'ホーム.Sql.CommandText = "SELECT outsrcr_name FROM outsourcers WHERE outsrcr_code=" & code0
        'Dim outsrcrName As String = ホーム.Sql.ExecuteScalar
        'Dim outsrcrName0 As TextField
        'outsrcrName0 = CType(レポート.C1FlexReport1.Fields("Gy1"), TextField)
        'outsrcrName0.Text = outsrcrName

        Return ReportLoad
    End Function
End Class
