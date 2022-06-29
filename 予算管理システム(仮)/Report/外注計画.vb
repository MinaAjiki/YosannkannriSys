Imports C1.Win.FlexReport
Imports System.Data.SqlClient
Public Class 外注計画
    Public Sub New()

    End Sub

    Public Function ReportLoad() As String
        'カーソル変更
        Cursor.Current = Cursors.WaitCursor
        進行状況.Show()
        進行状況.Refresh()

        Dim Connection As New SqlConnection
        Dim Sql As New SqlCommand
        Connection.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & ホーム.UserDataPath & ホーム.UserDataName & ";Integrated Security=True"
        Connection.Open()
        Sql.Connection = Connection

        Dim ds As New C1.Win.FlexReport.DataSource()
        ds.Name = "MyDataName"
        ReportLoad = ""

        'レポートを読み込む
        レポート.C1FlexReport1.Load(ホーム.Reportpath, "外注計画")
        'レポート.C1FlexReport1.Load("C:\Users\206029\Documents\Visual Studio 2008\Projects\勤怠入力支援システム\勤怠入力支援システム\勤怠入力支援システムレポート.flxr", "チェックリスト")
        レポート.C1FlexViewer1.DocumentSource = レポート.C1FlexReport1

        Dim ReportData As DataSource = New DataSource
        ReportData.Name = "ReportDataSource"
        ReportData.DataProvider = DataProvider.OLEDB
        ReportData.ConnectionString = "Provider=MSOLEDBSQL.1;Integrated Security=SSPI;Persist Security Info=False;User ID="";Initial Catalog=" & ホーム.UserDataPath & ホーム.UserDataName & ";Data Source=(localdb)\MSSQLLocalDB;Initial File Name="";Server SPN="";Authentication="";Access Token="""
        '        ReportData.RecordSource = "SELECT DISTINCT outsourcing_plans.outsrc_no,
        '	outsourcing_plans.dtl_id,
        '	outsourcing_plans.outsrcng_quanity,
        '	outsourcing_plans.outsrcng_costea,
        '	outsourcing_plans.budget_no,
        '	outsourcing_plans.outsrcr_id
        'FROM  outsourcing_plans
        'WHERE ((outsourcing_plans.outsrc_no) =(SELECT MAX(outsrc_no) FROM OutsrcrPlan_View)) AND
        '	((outsourcing_plans.budget_no) = (SELECT MAX(budget_no) FROM budget_summary);"
        '        レポート.C1FlexReport1.DataSources.Add(ReportData)
        '        レポート.C1FlexReport1.DataSourceName = ReportData.Name

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
        field9 = CType(レポート.C1FlexReport1.Fields("完成日"), TextField)
        field9.Text = Pterme

        '選択業者名セット
        Dim SelectVendorlist(協力業者選択.SelectVendorcount - 1) As String
        Dim datacount As Integer = 0
        For Listinsert As Integer = 0 To 4
            If Listinsert > 協力業者選択.SelectVendorcount - 1 Then
                Exit For
            End If
            SelectVendorlist(Listinsert) = 協力業者選択.SelectVendorName(Listinsert)
        Next
        'レポート.C1FlexReport1.Parameters("prmOutsrcr").Value = SelectVendorlist

        Dim VendorIDList As New List(Of Integer)

        '業者数ループ ヘッダ作成
        For listcountloop As Integer = 0 To SelectVendorlist.Count - 1
            Dim name As String = SelectVendorlist(listcountloop)
            Dim field0 As TextField
            field0 = CType(レポート.C1FlexReport1.Fields("outsrcr_name" & listcountloop), TextField)
            field0.Text = name

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
        DT.Columns.Add("s_worktype_code")
        DT.Columns.Add("s_wrktyp_name")
        DT.Columns.Add("dtl_name")
        DT.Columns.Add("dtl_spec")
        DT.Columns.Add("dtl_unit")
        DT.Columns.Add("dtl_quanity")
        DT.Columns.Add("dtl_costea")
        DT.Columns.Add("dtl_amount")
        DT.Columns.Add("outsrcng_quanity0")
        DT.Columns.Add("outsrcng_costea0")
        DT.Columns.Add("outsrcng_amount0")
        DT.Columns.Add("outsrcng_quanity1")
        DT.Columns.Add("outsrcng_costea1")
        DT.Columns.Add("outsrcng_amount1")
        DT.Columns.Add("outsrcng_quanity2")
        DT.Columns.Add("outsrcng_costea2")
        DT.Columns.Add("outsrcng_amount2")
        DT.Columns.Add("outsrcng_quanity3")
        DT.Columns.Add("outsrcng_costea3")
        DT.Columns.Add("outsrcng_amount3")
        DT.Columns.Add("outsrcng_quanity4")
        DT.Columns.Add("outsrcng_costea4")
        DT.Columns.Add("outsrcng_amount4")
        'For SelectCountLoop As Integer = 0 To 協力業者選択.SelectVendorcount - 1
        '    DT.Columns.Add("outsrcr_quanity" & SelectCountLoop)
        '    DT.Columns.Add("outsrcr_costea" & SelectCountLoop)
        '    DT.Columns.Add("outsrcr_amount" & SelectCountLoop)
        'Next


        '工種数カウント
        ホーム.Sql.CommandText = "SELECT COUNT(DISTINCT s_worktype_code) FROM OutsrcrPlan_View WHERE (outsrc_no IS NULL OR outsrc_no = (SELECT MAX(outsrc_no) FROM OutsrcrPlan_View))"
        Dim SwrktypCount As Integer = ホーム.Sql.ExecuteScalar

        '工種リスト作成
        Dim s_wrktyp_codeList As New List(Of Integer)
        Dim s_wrktyp_nameList As New List(Of String)
        ホーム.Sql.CommandText = "SELECT DISTINCT s_worktype_code,s_wrktyp_name FROM OutsrcrPlan_View WHERE (outsrc_no IS NULL OR outsrc_no = (SELECT MAX(outsrc_no) FROM OutsrcrPlan_View)) ORDER BY s_worktype_code ASC"
        Dim SwrktypReader As SqlDataReader = ホーム.Sql.ExecuteReader
        While SwrktypReader.Read
            s_wrktyp_codeList.Add(SwrktypReader.Item("s_worktype_code"))
            s_wrktyp_nameList.Add(SwrktypReader.Item("s_wrktyp_name"))
        End While
        SwrktypReader.Close()

        Dim quanity As Decimal
        Dim costea As Decimal
        Dim amount As Decimal

        '工種数ループ
        For SwrktypLoop As Integer = 0 To SwrktypCount - 1
            Dim s_worktype_code As Integer = s_wrktyp_codeList(SwrktypLoop)
            Dim s_wrktyp_name As String = s_wrktyp_nameList(SwrktypLoop)
            Dim dtl_id As String
            Dim dtl_name As String = ""
            Dim dtl_spec As String = ""
            Dim dtl_unit As String = ""
            Dim dtl_quanity As Decimal = 0
            Dim dtl_costea As Decimal = 0
            Dim dtl_amount As Decimal = 0


            '明細数カウント
            'ホーム.Sql.CommandText = "SELECT COUNT(DISTINCT dtl_id) FROM OutsrcrPlan_View WHERE (outsrc_no IS NULL OR outsrc_no = (SELECT MAX(outsrc_no) FROM OutsrcrPlan_View)) AND s_worktype_code = " & s_worktype_code
            'Dim DtlCount As Integer = ホーム.Sql.ExecuteScalar

            '明細データを取得

            ホーム.Sql.CommandText = "SELECT dtl_id,dtl_no,s_wrktyp_code,s_wrktyp_name,dtl_name,dtl_spec,dtl_unit,dtl_quanity,dtl_costea,dtl_amount FROM details_bd WHERE budget_no = " & ホーム.BudgetNo & " AND s_wrktyp_code =  " & s_worktype_code & "  ORDER BY s_wrktyp_code,dtl_no ASC"
            'ホーム.Sql.CommandText = "SELECT DISTINCT outsrc_no,dtl_id,dtl_no,s_worktype_code,s_wrktyp_name,dtl_name,dtl_spec,dtl_unit,dtl_quanity,dtl_costea,dtl_amount FROM OutsrcrPlan_View WHERE (outsrc_no IS NULL OR outsrc_no = (SELECT MAX(outsrc_no) FROM OutsrcrPlan_View)) AND s_worktype_code =  " & s_worktype_code & "  ORDER BY s_worktype_code,dtl_no ASC"
            Dim DtlReader As SqlDataReader = ホーム.Sql.ExecuteReader
            While DtlReader.Read
                'If IsDBNull(DtlReader.Item("outsrc_no")) Then
                '    outsrc_no = 99
                'Else
                '    outsrc_no = DtlReader.Item("outsrc_no")
                'End If
                dtl_id = DtlReader.Item("dtl_id")
                dtl_name = DtlReader.Item("dtl_name")
                dtl_spec = DtlReader.Item("dtl_spec")
                dtl_unit = DtlReader.Item("dtl_unit")
                dtl_quanity = DtlReader.Item("dtl_quanity")
                dtl_costea = DtlReader.Item("dtl_costea")
                dtl_amount = DtlReader.Item("dtl_amount")

                Dim QuanityList As New List(Of Decimal) From {0, 0, 0, 0, 0}
                Dim CosteaList As New List(Of Decimal) From {0, 0, 0, 0, 0}
                Dim AmountList As New List(Of Decimal) From {0, 0, 0, 0, 0}
                '業者数ループ
                For VendorLoop As Integer = 0 To 協力業者選択.SelectVendorcount - 1
                    '外注計画データ取得
                    'Sql.CommandText = "SELECT ISNULL(outsrcng_quanity,0) FROM OutsrcrPlan_View WHERE (outsrc_no IS NULL OR outsrc_no = (SELECT MAX(outsrc_no) FROM OutsrcrPlan_View)) AND s_worktype_code =  " & s_worktype_code & " AND (outsrcr_id IS NULL OR outsrcr_id = " & VendorIDList(VendorLoop) & ") AND dtl_id = " & dtl_id & " ORDER BY s_worktype_code,dtl_no ASC"
                    'Dim quanity As Decimal = Sql.ExecuteScalar
                    'QuanityList(VendorLoop) = quanity
                    'Sql.CommandText = "SELECT ISNULL(outsrcng_costea,0) FROM OutsrcrPlan_View WHERE (outsrc_no IS NULL OR outsrc_no = (SELECT MAX(outsrc_no) FROM OutsrcrPlan_View)) AND s_worktype_code =  " & s_worktype_code & " AND (outsrcr_id IS NULL OR outsrcr_id = " & VendorIDList(VendorLoop) & ") AND dtl_id = " & dtl_id & " ORDER BY s_worktype_code,dtl_no ASC"
                    'Dim costea As Decimal = Sql.ExecuteScalar
                    'CosteaList(VendorLoop) = costea
                    'Sql.CommandText = "SELECT ISNULL(outsrcng_amount,0) FROM OutsrcrPlan_View WHERE (outsrc_no IS NULL OR outsrc_no = (SELECT MAX(outsrc_no) FROM OutsrcrPlan_View)) AND s_worktype_code =  " & s_worktype_code & " AND (outsrcr_id IS NULL OR outsrcr_id = " & VendorIDList(VendorLoop) & ") AND dtl_id = " & dtl_id & " ORDER BY s_worktype_code,dtl_no ASC"
                    'Dim amount As Decimal = Sql.ExecuteScalar
                    'AmountList(VendorLoop) = amount

                    Sql.CommandText = "SELECT outsrcng_quanity, outsrcng_costea, outsrcng_amount FROM OutsrcrPlan_View WHERE (outsrc_no IS NULL OR outsrc_no = (SELECT MAX(outsrc_no) FROM OutsrcrPlan_View)) AND s_worktype_code =  " & s_worktype_code & " AND (outsrcr_id IS NULL OR outsrcr_id = " & VendorIDList(VendorLoop) & ") AND dtl_id = " & dtl_id & " ORDER BY s_worktype_code,dtl_no ASC"
                    Dim vendorcst As SqlDataReader = Sql.ExecuteReader
                    While vendorcst.Read
                        If IsDBNull(vendorcst.Item("outsrcng_quanity")) = True Then
                            vendorcst.Close()
                            Exit For
                        Else
                            quanity = vendorcst.Item("outsrcng_quanity")
                            If quanity = 0 Then
                                vendorcst.Close()
                                Exit For
                            End If
                            QuanityList(VendorLoop) = quanity
                        End If
                        If IsDBNull(vendorcst.Item("outsrcng_costea")) = True Then
                            CosteaList(VendorLoop) = 0
                        Else
                            costea = vendorcst.Item("outsrcng_costea")
                            CosteaList(VendorLoop) = costea
                        End If
                        If IsDBNull(vendorcst.Item("outsrcng_amount")) = True Then
                            AmountList(VendorLoop) = 0
                        Else
                            amount = vendorcst.Item("outsrcng_amount")
                            AmountList(VendorLoop) = amount
                        End If
                    End While
                    vendorcst.Close()
                Next
                'テーブルに行を追加
                DT.Rows.Add(s_worktype_code, s_wrktyp_name, dtl_name, dtl_spec, dtl_unit, dtl_quanity, dtl_costea, dtl_amount, QuanityList(0), CosteaList(0), AmountList(0), QuanityList(1), CosteaList(1), AmountList(1), QuanityList(2), CosteaList(2), AmountList(2), QuanityList(3), CosteaList(3), AmountList(3), QuanityList(4), CosteaList(4), AmountList(4))
            End While
            DtlReader.Close()
        Next

        進行状況.Close()


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
