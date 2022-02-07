Imports System.Data.SqlClient
Imports C1.Win.FlexReport

Public Class 予算総括表
    Public Function ReportLoad() As String

        ReportLoad = ""

        'レポートを読み込む
        レポート.C1FlexReport1.Load(ホーム.Reportpath, "予算総括新レポート")
        'レポート.C1FlexReport1.Load("C:\Users\206029\Documents\Visual Studio 2008\Projects\勤怠入力支援システム\勤怠入力支援システム\勤怠入力支援システムレポート.flxr", "チェックリスト")


        Dim ReportData As DataSource = New DataSource
        ReportData.ConnectionString = "Provider=MSOLEDBSQL.1;Integrated Security=SSPI;Persist Security Info=False;User ID="";Initial Catalog=D:\DD0000テスト工事.mdf;Data Source=(localdb)\MSSQLLocalDB;Initial File Name="";Server SPN="";Authentication="";Access Token="""
        ReportData.RecordSource = "SELECT * FROM  bdgt_smmry_report WHERE ((bdgt_smmry_report.budget_no) = " & ホーム.BudgetNo & ");"
        レポート.C1FlexReport1.DataSources.Add(ReportData)

        Dim BudgetField As C1.Win.FlexReport.Field
        BudgetField = CType(レポート.C1FlexReport1.Fields("budget_no"), C1.Win.FlexReport.Field)
        BudgetField.Text = "第" & ホーム.BudgetNo & "回変更"

        ホーム.Sql.CommandText = "SELECT Count(*) FROM site_expenses WHERE budget_no=" & ホーム.BudgetNo
        Dim SiteExpenseCount As Integer = ホーム.Sql.ExecuteScalar
        If SiteExpenseCount > 0 Then
            ホーム.Sql.CommandText = "SELECT SUM(stexpns_amount) FROM site_expenses WHERE budget_no=" & ホーム.BudgetNo
            Dim SiteCostsField As C1.Win.FlexReport.TextField
            SiteCostsField = CType(レポート.C1FlexReport1.Fields("SiteCosts"), C1.Win.FlexReport.TextField)
            If IsDBNull(ホーム.Sql.ExecuteScalar) = False Then
                SiteCostsField.Text = ホーム.Sql.ExecuteScalar
            Else
                SiteCostsField.Text = 0
            End If
        End If

        ホーム.Sql.CommandText = "SELECT SUM(dtl_quanity * dtl_costea) FROM details WHERE budget_no=" & ホーム.BudgetNo & " AND s_worktype_code <200"
        Dim DrctCnstrctnCstField As C1.Win.FlexReport.Field
        DrctCnstrctnCstField = CType(レポート.C1FlexReport1.Fields("DrctCnstrctnCst"), C1.Win.FlexReport.Field)
        If IsDBNull(ホーム.Sql.ExecuteScalar) = False Then
            Dim DrctCnstrctnCst As Int64 = Math.Floor(ホーム.Sql.ExecuteScalar)
            DrctCnstrctnCstField.Text = DrctCnstrctnCst
        Else
            DrctCnstrctnCstField.Text = 0
        End If

        ホーム.Sql.CommandText = "SELECT SUM(dtl_quanity * dtl_costea) FROM details WHERE budget_no=" & ホーム.BudgetNo & " AND s_worktype_code>=200 AND s_worktype_code <800"
        Dim TmprryExpnssField As C1.Win.FlexReport.Field
        TmprryExpnssField = CType(レポート.C1FlexReport1.Fields("TmprryExpnss"), C1.Win.FlexReport.Field)
        If IsDBNull(ホーム.Sql.ExecuteScalar) = False Then
            Dim TmprryExpnss As Int64 = Math.Floor(ホーム.Sql.ExecuteScalar)
            TmprryExpnssField.Text = TmprryExpnss
        Else
            TmprryExpnssField.Text = 0
        End If

        ホーム.Sql.CommandText = "SELECT SUM(dtl_quanity * dtl_costea) FROM details WHERE budget_no=" & ホーム.BudgetNo & " AND s_worktype_code=861"
        Dim MtrldffrncField As C1.Win.FlexReport.Field
        MtrldffrncField = CType(レポート.C1FlexReport1.Fields("Mtrldffrnc"), C1.Win.FlexReport.Field)
        If IsDBNull(ホーム.Sql.ExecuteScalar) = False Then
            Dim Mtrldffrnc As Int64 = Math.Floor(ホーム.Sql.ExecuteScalar)
            MtrldffrncField.Text = Mtrldffrnc
        Else
            MtrldffrncField.Text = 0
        End If

        ホーム.Sql.CommandText = "SELECT SUM(dtl_quanity * dtl_costea) FROM details WHERE budget_no=" & ホーム.BudgetNo & " AND s_worktype_code=881"
        Dim ExpectedTotalField As C1.Win.FlexReport.Field
        ExpectedTotalField = CType(レポート.C1FlexReport1.Fields("ExpectedTotal"), C1.Win.FlexReport.Field)
        If IsDBNull(ホーム.Sql.ExecuteScalar) = False Then
            Dim ExpectedTotal As Int64 = Math.Floor(ホーム.Sql.ExecuteScalar)
            ExpectedTotalField.Text = ExpectedTotal
        Else
            ExpectedTotalField.Text = 0
        End If

        Dim DataCount As Integer = 0
        ホーム.Sql.CommandText = "SELECT TOP 10 * FROM outsourcers"
        Dim OutsrcrReader As SqlDataReader = ホーム.Sql.ExecuteReader
        While OutsrcrReader.Read
            DataCount += 1

            Dim WorkTypeField As C1.Win.FlexReport.Field
            WorkTypeField = CType(レポート.C1FlexReport1.Fields("Worktype" & DataCount), C1.Win.FlexReport.Field)
            WorkTypeField.Text = OutsrcrReader.Item("worktype")

            Dim OutsrcrNameField As C1.Win.FlexReport.Field
            OutsrcrNameField = CType(レポート.C1FlexReport1.Fields("OutsrcrName" & DataCount), C1.Win.FlexReport.Field)
            OutsrcrNameField.Text = OutsrcrReader.Item("outsrcr_name")

        End While
        OutsrcrReader.Close()

        レポート.C1FlexViewer1.DocumentSource = レポート.C1FlexReport1



        Return ReportLoad
    End Function
End Class
