Imports C1.Win.FlexReport
Public Class 外注計画
    Public Sub New()

    End Sub

    Public Function ReportLoad() As String

        ReportLoad = ""

        'レポートを読み込む
        レポート.C1FlexReport1.Load(ホーム.ReportPath, "外注計画")
        'レポート.C1FlexReport1.Load("C:\Users\206029\Documents\Visual Studio 2008\Projects\勤怠入力支援システム\勤怠入力支援システム\勤怠入力支援システムレポート.flxr", "チェックリスト")
        レポート.C1FlexViewer1.DocumentSource = レポート.C1FlexReport1

        Dim code0 As Integer = レポート.C1FlexReport1.Parameters("prmOutsrcr").Value
        ホーム.Sql.CommandText = "SELECT outsrcr_name FROM outsourcers WHERE outsrcr_code=" & code0
        Dim outsrcrName As String = ホーム.Sql.ExecuteScalar
        Dim outsrcrName0 As TextField
        outsrcrName0 = CType(レポート.C1FlexReport1.Fields("Gy1"), TextField)
        outsrcrName0.Text = outsrcrName

        Return ReportLoad
    End Function
End Class
