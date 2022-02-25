Imports C1.Win.FlexReport
Public Class 外注計画
    Public Sub New()

    End Sub

    Public Function ReportLoad() As String

        ReportLoad = ""

        'レポートを読み込む
        レポート.C1FlexReport1.Load(ホーム.ReportPath, "外注計画")
        'レポート.C1FlexReport1.Load("C:\Users\206029\Documents\Visual Studio 2008\Projects\勤怠入力支援システム\勤怠入力支援システム\勤怠入力支援システムレポート.flxr", "チェックリスト")

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
        DT.Columns.Add("T_amount")
        For SelectCountLoop As Integer = 0 To 協力業者選択.SelectVendorcount - 1
            DT.Columns.Add("outsrcr_quanity" & SelectCountLoop)
            DT.Columns.Add("outsrcr_costea" & SelectCountLoop)
            DT.Columns.Add("outsrcr_amount" & SelectCountLoop)
        Next


        レポート.C1FlexViewer1.DocumentSource = レポート.C1FlexReport1
        'Dim code0 As Integer = レポート.C1FlexReport1.Parameters("prmOutsrcr").Value
        'ホーム.Sql.CommandText = "SELECT outsrcr_name FROM outsourcers WHERE outsrcr_code=" & code0
        'Dim outsrcrName As String = ホーム.Sql.ExecuteScalar
        'Dim outsrcrName0 As TextField
        'outsrcrName0 = CType(レポート.C1FlexReport1.Fields("Gy1"), TextField)
        'outsrcrName0.Text = outsrcrName

        Return ReportLoad
    End Function
End Class
