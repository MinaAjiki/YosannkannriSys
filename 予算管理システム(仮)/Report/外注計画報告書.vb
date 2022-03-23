Imports C1.Win.FlexReport
Imports System.Data.SqlClient
Public Class 外注計画報告書
    Public Function ReportLoad() As String
        進行状況.Show()
        進行状況.Refresh()

        Dim ds As New C1.Win.FlexReport.DataSource()
        ds.Name = "MyDataName"

        ReportLoad = ""

        'レポートを読み込む
        レポート.C1FlexReport1.Load(ホーム.Reportpath, "外注計画報告書")
        'レポート.C1FlexReport1.Load("C:\Users\206029\Documents\Visual Studio 2008\Projects\勤怠入力支援システム\勤怠入力支援システム\勤怠入力支援システムレポート.flxr", "チェックリスト")
        レポート.C1FlexViewer1.DocumentSource = レポート.C1FlexReport1

        Dim ReportData As DataSource = New DataSource
        ReportData.Name = "ReportDataSource"
        ReportData.DataProvider = DataProvider.OLEDB
        ReportData.ConnectionString = "Provider=MSOLEDBSQL.1;Integrated Security=SSPI;Persist Security Info=False;User ID="";Initial Catalog=D:\DD0000テスト工事.mdf;Data Source=(localdb)\MSSQLLocalDB;Initial File Name="";Server SPN="";Authentication="";Access Token="""
        ReportData.RecordSource = "SELECT * FROM  bdgt_smmry_report WHERE ((bdgt_smmry_report.budget_no) = " & ホーム.BudgetNo & ");"
        レポート.C1FlexReport1.DataSources.Add(ReportData)
        レポート.C1FlexReport1.DataSourceName = ReportData.Name

        '工事コード、工事名
        ホーム.Sql.CommandText = "SELECT contents FROM controldata WHERE class_code=20"
        Dim Pcode As String = ホーム.Sql.ExecuteScalar
        ホーム.Sql.CommandText = "SELECT contents FROM controldata WHERE class_code=21"
        Dim Pname As String = ホーム.Sql.ExecuteScalar
        ホーム.Sql.CommandText = "SELECT chief FROM budget_summary"
        Dim Cname As String = ホーム.Sql.ExecuteScalar
        ホーム.Sql.CommandText = "SELECT subcontract_rate FROM budget_summary"
        Dim subcontractrate As String = ホーム.Sql.ExecuteScalar
        ホーム.Sql.CommandText = "SELECT contents FROM controldata WHERE class_code=70"
        Dim name0 As String = ホーム.Sql.ExecuteScalar
        ホーム.Sql.CommandText = "SELECT contents FROM controldata WHERE class_code=71"
        Dim name1 As String = ホーム.Sql.ExecuteScalar
        ホーム.Sql.CommandText = "SELECT contents FROM controldata WHERE class_code=72"
        Dim name2 As String = ホーム.Sql.ExecuteScalar
        ホーム.Sql.CommandText = "SELECT contents FROM controldata WHERE class_code=73"
        Dim name3 As String = ホーム.Sql.ExecuteScalar
        ホーム.Sql.CommandText = "SELECT contents FROM controldata WHERE class_code=74"
        Dim name4 As String = ホーム.Sql.ExecuteScalar
        ホーム.Sql.CommandText = "SELECT contents FROM controldata WHERE class_code=75"
        Dim name5 As String = ホーム.Sql.ExecuteScalar
        ホーム.Sql.CommandText = "SELECT contents FROM controldata WHERE class_code=76"
        Dim name6 As String = ホーム.Sql.ExecuteScalar

        Dim field2 As Field
        field2 = CType(レポート.C1FlexReport1.Fields("工事コード"), Field)
        field2.Text = Pcode

        Dim field3 As Field
        field3 = CType(レポート.C1FlexReport1.Fields("工事名"), Field)
        field3.Text = Pname

        Dim field5 As Field
        field5 = CType(レポート.C1FlexReport1.Fields("作業所長"), Field)
        field5.Text = Cname

        Dim field9 As Field
        field9 = CType(レポート.C1FlexReport1.Fields("name0"), Field)
        field9.Text = name0

        Dim field10 As Field
        field10 = CType(レポート.C1FlexReport1.Fields("name1"), Field)
        field10.Text = name1

        Dim field11 As Field
        field11 = CType(レポート.C1FlexReport1.Fields("name2"), Field)
        field11.Text = name2

        Dim field12 As Field
        field12 = CType(レポート.C1FlexReport1.Fields("name3"), Field)
        field12.Text = name3

        Dim field13 As Field
        field13 = CType(レポート.C1FlexReport1.Fields("name4"), Field)
        field13.Text = name4

        Dim field14 As Field
        field14 = CType(レポート.C1FlexReport1.Fields("name5"), Field)
        field14.Text = name5

        Dim field15 As Field
        field15 = CType(レポート.C1FlexReport1.Fields("name6"), Field)
        field15.Text = name6

        Dim field16 As TextField
        field16 = CType(レポート.C1FlexReport1.Fields("特記事項"), TextField)
        field16.Text = subcontractrate


        Dim AmountList As New List(Of Decimal)

        '業者数取得
        ホーム.Sql.CommandText = "SELECT COUNT(outsrcr_id) FROM outsourcers"
        Dim VendorCount As Integer = ホーム.Sql.ExecuteScalar


        '業者IDリスト作成
        Dim VendorIDList As New List(Of String)
        ホーム.Sql.CommandText = "SELECT outsrcr_id FROM outsourcers"
        Dim VIDReader As SqlDataReader = ホーム.Sql.ExecuteReader
        While VIDReader.Read
            VendorIDList.Add(VIDReader.Item("outsrcr_id"))
        End While
        VIDReader.Close()

        '明細IDリスト作成
        Dim DtlIDList As New List(Of Integer)
        ホーム.Sql.CommandText = "SELECT DISTINCT dtl_id FROM DirectManagement_View"
        Dim DtlIDReader As SqlDataReader = ホーム.Sql.ExecuteReader
        While DtlIDReader.Read
            DtlIDList.Add(DtlIDReader.Item("dtl_id"))
        End While
        DtlIDReader.Close()

        'テーブル作成
        Dim DT As New DataTable
        DT.Columns.Add("outsrcr_code")
        DT.Columns.Add("outsrcr_name")
        For vendorloop As Integer = 0 To VendorCount - 1
            DT.Columns.Add("amount" & vendorloop)
        Next

        For vendorloop As Integer = 0 To 19
            Dim DTRow As DataRow = DT.NewRow
            DTRow("outsrcr_code") = Nothing
            DTRow("outsrcr_Name") = Nothing
            DTRow("amount0") = Nothing
            DTRow("amount1") = Nothing
            DTRow("amount2") = Nothing
            DTRow("amount3") = Nothing
            DTRow("amount4") = Nothing
            DTRow("amount5") = Nothing
            DTRow("amount6") = Nothing
            DT.Rows.Add(DTRow)
        Next

        '変更回数取得
        ホーム.Sql.CommandText = "SELECT COUNT(DISTINCT outsrc_no) FROM outsourcing_plans"
        Dim OutsrcNoCount As Integer = ホーム.Sql.ExecuteScalar
        Dim ONCount As Integer = OutsrcNoCount - 1

        '変更回数ループ
        For OutsrcNoLoop As Integer = 0 To OutsrcNoCount - 1
            Dim field4 As Field
            field4 = CType(レポート.C1FlexReport1.Fields("outsrc_no" & ONCount), Field)
            field4.Text = "第" & OutsrcNoLoop & "回変更"
            If OutsrcNoLoop = 0 Then
                field4.Text = "当初外注計画"
            End If

            ホーム.Sql.CommandText = "SELECT DISTINCT created_date FROM outsourcing_plans WHERE outsrc_no = " & OutsrcNoLoop
            Dim CreatedDate As Date = ホーム.Sql.ExecuteScalar
            Dim field6 As Field
            field6 = CType(レポート.C1FlexReport1.Fields("created_date" & ONCount), Field)
            field6.Value = CreatedDate

            ホーム.Sql.CommandText = "SELECT cntrct_amount FROM budget_summary WHERE budget_no = (SELECT DISTINCT budget_no FROM outsourcing_plans WHERE outsrc_no = " & OutsrcNoLoop & ")"
            Dim ConAmount As Integer = ホーム.Sql.ExecuteScalar
            Dim field7 As Field
            field7 = CType(レポート.C1FlexReport1.Fields("total" & ONCount), Field)
            field7.Value = ConAmount

            'SELECT  CASE WHEN EXISTS(SELECT * FROM DirectManagement_View where (dtl_id = 5)) AND outsrc_no = 1  THEN inhouse_amount
            'WHEN EXISTS(SELECT * FROM DirectManagement_View where (dtl_id = 5)) And outsrc_no = 1  THEN dtl_amount
            'End As amount
            'From DirectManagement_View Where (dtl_id = 5) And outsrc_no = 1

            'Select Case WHEN EXISTS(SELECT * FROM DirectManagement_View where outsrc_no = 0 ) THEN inhouse_amount
            'WHEN EXISTS(SELECT * FROM DirectManagement_View where dtl_id = 2) THEN dtl_amount
            'End as amount From DirectManagement_View WHERE dtl_id = 2

            '直営金額計算
            '明細数ループ
            Dim Gtotal As Int64 = 0
            Dim DtlTotal As Int64 = 0
            For DtlLoop As Integer = 0 To DtlIDList.Count - 1
                ホーム.Sql.CommandText = "SELECT DISTINCT dtl_amount FROM DirectManagement_View WHERE dtl_id = " & DtlIDList(DtlLoop)
                Dim DtlAmount As Int64 = ホーム.Sql.ExecuteScalar
                DtlTotal += DtlAmount
            Next

            ホーム.Sql.CommandText = "SELECT SUM(outsrcng_amount) FROM DirectManagement_View WHERE outsrc_no = " & OutsrcNoLoop
            Dim inhouseAmount As Int64 = ホーム.Sql.ExecuteScalar

            Gtotal = DtlTotal - inhouseAmount

            Dim field17 As Field
            field17 = CType(レポート.C1FlexReport1.Fields("DMtotal" & ONCount), Field)
            field17.Value = Gtotal

            ホーム.Sql.CommandText = "SELECT changes FROM outsourcing_reports WHERE outsrc_no = " & OutsrcNoLoop
            Dim ChangeTxt As String = ホーム.Sql.ExecuteScalar
            Dim field8 As Field
            field8 = CType(レポート.C1FlexReport1.Fields("changes" & ONCount), Field)
            field8.Value = ChangeTxt


            '業者数ループ
            For VendorLoop As Integer = 0 To VendorCount - 1
                If VendorIDList.Count > VendorLoop Then
                    ホーム.Sql.CommandText = "SELECT ISNULL(outsrcr_code,0) FROM outsourcers WHERE outsrcr_id = ISNULL(" & VendorIDList(VendorLoop) & ",0)"
                    Dim Vcode As Integer = ホーム.Sql.ExecuteScalar
                    ホーム.Sql.CommandText = "SELECT ISNULL(outsrcr_name,0) FROM outsourcers WHERE outsrcr_id = " & VendorIDList(VendorLoop)
                    Dim Vname As String = ホーム.Sql.ExecuteScalar
                    If Not Vcode = 0 Then
                        DT.Rows(VendorLoop).Item("outsrcr_code") = Vcode
                        DT.Rows(VendorLoop).Item("outsrcr_name") = Vname
                        DT.AcceptChanges()
                    End If
                    ホーム.Sql.CommandText = "SELECT isnull(SUM(outsrcng_quanity * outsrcng_costea),0) FROM outsourcing_plans WHERE outsrc_no = " & OutsrcNoLoop & "AND outsrcr_id = " & VendorIDList.Item(VendorLoop)
                    Dim AmountReader As Integer = ホーム.Sql.ExecuteScalar
                    If Not AmountReader = 0 Then
                        DT.Rows(VendorLoop).Item("amount" & ONCount) = AmountReader
                        DT.AcceptChanges()
                    Else
                        DT.Rows(VendorLoop).Item("amount" & ONCount) = 0
                        DT.AcceptChanges()
                    End If
                End If
            Next
            ONCount -= 1
        Next

        ds.Recordset = DT

        進行状況.Close()

        レポート.C1FlexReport1.DataSources.Add(ds)
        レポート.C1FlexReport1.DataSourceName = ds.Name

        Return ReportLoad
    End Function
End Class
