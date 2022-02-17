Imports C1.Win.FlexViewer
Public Class レポート
    Private Sub レポート_Load(sender As Object, e As EventArgs) Handles Me.Load
        Cursor.Current = Cursors.WaitCursor
        Dim ReportLoad As String = ""

        If ホーム.ReportName = "出来高査定書" Then
            Dim ReportLoadRead As New 出来高査定書(出来高査定チェックフォーム.VendorNo.Text)
            ReportLoad = ReportLoadRead.ReportLoad
        ElseIf ホーム.Reportname = "出来形数量査定書(中間)" Then
            Dim ReportLoadRead As New 出来形数量査定書(出来高査定チェックフォーム.VendorNo.Text)
            ReportLoad = ReportLoadRead.ReportLoad
        ElseIf ホーム.Reportname = "外注計画" Then
            Dim ReportLoadRead As New 外注計画
            ReportLoad = ReportLoadRead.ReportLoad
        ElseIf ホーム.Reportname = "外注計画報告書" Then
            Dim ReportLoadRead As New 外注計画報告書
            ReportLoad = ReportLoadRead.ReportLoad
        End If

        If ホーム.ReportName = "予算総括表" Or ホーム.ReportName = "予算総括表_簡易" Then
            Dim ReportLoadRead As New 予算総括表
            ReportLoad = ReportLoadRead.ReportLoad
        ElseIf ホーム.ReportName = "材料表" Then
            Dim ReportLoadRead As New 基礎単価表(2)
            ReportLoad = ReportLoadRead.ReportLoad
        ElseIf ホーム.ReportName = "現場経費" Then
            Dim ReportLoadRead As New 現場経費内訳書
            ReportLoad = ReportLoadRead.ReportLoad
        ElseIf ホーム.ReportName = "実行予算大内訳書" Then
            Dim ReportLoadRead As New 実行予算大内訳書
            ReportLoad = ReportLoadRead.ReportLoad
        ElseIf ホーム.ReportName = "実行予算内訳書" Then
            Dim ReportLoadRead As New 実行予算内訳書
            ReportLoad = ReportLoadRead.ReportLoad
        ElseIf ホーム.ReportName = "実行予算内訳書_簡易" Then
            Dim ReportLoadRead As New 実行予算内訳書_簡易
            ReportLoad = ReportLoadRead.ReportLoad
        End If
    End Sub
End Class