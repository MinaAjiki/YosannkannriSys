Imports C1.Win.FlexReport
Public Class 外注計画報告書
    Public Function ReportLoad() As String

        ReportLoad = ""

        'レポートを読み込む
        レポート.C1FlexReport1.Load(ホーム.ReportPath, "外注計画報告書")
        'レポート.C1FlexReport1.Load("C:\Users\206029\Documents\Visual Studio 2008\Projects\勤怠入力支援システム\勤怠入力支援システム\勤怠入力支援システムレポート.flxr", "チェックリスト")
        レポート.C1FlexViewer1.DocumentSource = レポート.C1FlexReport1

        Dim ReportData As DataSource = New DataSource
        ReportData.ConnectionString = "Provider=MSOLEDBSQL.1;Integrated Security=SSPI;Persist Security Info=False;User ID="";Initial Catalog=D:\DD0000テスト工事.mdf;Data Source=(localdb)\MSSQLLocalDB;Initial File Name="";Server SPN="";Authentication="";Access Token="""
        ReportData.RecordSource = "SELECT * FROM  bdgt_smmry_report WHERE ((bdgt_smmry_report.budget_no) = " & ホーム.BudgetNo & ");"
        レポート.C1FlexReport1.DataSources.Add(ReportData)

        Return ReportLoad
    End Function
End Class
