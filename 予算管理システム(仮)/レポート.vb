﻿Imports C1.Win.FlexViewer
Public Class レポート
    Private Sub レポート_Load(sender As Object, e As EventArgs) Handles Me.Load
        Cursor.Current = Cursors.WaitCursor
        Dim ReportLoad As String = ""

        If ホーム.Report = "出来高査定書" Then
            Dim ReportLoadRead As New 出来高査定書(出来高査定チェックフォーム.VendorNo.Text)
            ReportLoad = ReportLoadRead.ReportLoad
        ElseIf ホーム.Report = "出来形数量査定書(中間)" Then
            Dim ReportLoadRead As New 出来形数量査定書(出来高査定チェックフォーム.VendorNo.Text)
            ReportLoad = ReportLoadRead.ReportLoad
        ElseIf ホーム.Report = "外注計画" Then
            Dim ReportLoadRead As New 外注計画
            ReportLoad = ReportLoadRead.ReportLoad
        ElseIf ホーム.Report = "外注計画報告書" Then
            Dim ReportLoadRead As New 外注計画報告書
            ReportLoad = ReportLoadRead.ReportLoad
        End If
    End Sub
End Class