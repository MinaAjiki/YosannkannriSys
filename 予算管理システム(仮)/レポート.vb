Imports C1.Win.FlexViewer
Public Class レポート
    Private Sub レポート_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Cursor.Current = Cursors.WaitCursor
            Dim ReportLoad As String = ""

            If ホーム.ReportName = "出来高査定書" Then
                Dim ReportLoadRead As New 出来高査定書(出来高査定チェックフォーム.VendorNo.Text)
                ReportLoad = ReportLoadRead.ReportLoad
            ElseIf ホーム.ReportName = "出来高査定書(完成)" Then
                Dim ReportLoadRead As New 出来高査定書(出来高査定チェックフォーム.VendorNo.Text)
                    ReportLoad = ReportLoadRead.ReportLoad
                ElseIf ホーム.ReportName = "出来形数量査定書(完成)" Then
                Dim ReportLoadRead As New 出来形数量査定書(出来高査定チェックフォーム.VendorNo.Text)
                ReportLoad = ReportLoadRead.ReportLoad
            ElseIf ホーム.ReportName = "出来形数量査定書(中間)" Then
                Dim ReportLoadRead As New 出来形数量査定書(出来高査定チェックフォーム.VendorNo.Text)
                ReportLoad = ReportLoadRead.ReportLoad
            ElseIf ホーム.ReportName = "外注計画" Then
                Dim ReportLoadRead As New 外注計画
                ReportLoad = ReportLoadRead.ReportLoad
            ElseIf ホーム.ReportName = "外注計画報告書" Then
                Dim ReportLoadRead As New 外注計画報告書
                ReportLoad = ReportLoadRead.ReportLoad
            ElseIf ホーム.ReportName = "注文書" Then
                Dim ReportLoadRead As New 注文書(協力業者選択.SelectVendorCode(0))
                ReportLoad = ReportLoadRead.ReportLoad
            ElseIf ホーム.ReportName = "注文書金抜" Then
                Dim ReportLoadRead As New 注文書(協力業者選択.SelectVendorCode(0))
                ReportLoad = ReportLoadRead.ReportLoad
            ElseIf ホーム.ReportName = "注文書折衝" Then
                Dim ReportLoadRead As New 注文書(協力業者選択.SelectVendorCode(0))
                ReportLoad = ReportLoadRead.ReportLoad
            End If

            If ホーム.ReportName = "予算総括表" Then
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
            ElseIf ホーム.ReportName = "明細内訳書" Then
                Dim ReportLoadRead As New 明細内訳書
                ReportLoad = ReportLoadRead.ReportLoad
            ElseIf ホーム.ReportName = "明細内訳書_簡易" Then
                Dim ReportLoadRead As New 明細内訳書_簡易
                ReportLoad = ReportLoadRead.ReportLoad
            ElseIf ホーム.ReportName = "代価内訳書" Then
                Dim ReportLoadRead As New 代価内訳書(印刷代価選択.ClassCode, 印刷代価選択.ClassName)
                ReportLoad = ReportLoadRead.ReportLoad
            ElseIf ホーム.ReportName = "代価一覧表" Then
                Dim ReportLoadRead As New 代価一覧表(印刷代価選択.ClassCode, 印刷代価選択.ClassName)
                ReportLoad = ReportLoadRead.ReportLoad
            ElseIf ホーム.ReportName = "代価内訳書_簡易" Then
                Dim ReportLoadRead As New 代価内訳書_簡易(印刷代価選択.ClassCode, 印刷代価選択.ClassName)
                ReportLoad = ReportLoadRead.ReportLoad
            ElseIf ホーム.ReportName = "基礎代価一覧表" Then
                Dim ReportLoadRead As New 基礎代価一覧表(11, "基礎代価表")
                ReportLoad = ReportLoadRead.ReportLoad
            ElseIf ホーム.ReportName = "基礎代価内訳書_簡易" Then
                Dim ReportLoadRead As New 基礎代価内訳書_簡易(11, "基礎代価表")
                ReportLoad = ReportLoadRead.ReportLoad
            ElseIf ホーム.ReportName = "基礎代価内訳書" Then
                Dim ReportLoadRead As New 基礎代価内訳書(11, "基礎代価表")
                ReportLoad = ReportLoadRead.ReportLoad
            ElseIf ホーム.ReportName = "入力表_工務課用" Then
                Dim ReportLoadRead As New 入力表_工務課用
                ReportLoad = ReportLoadRead.ReportLoad
            End If

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub
End Class