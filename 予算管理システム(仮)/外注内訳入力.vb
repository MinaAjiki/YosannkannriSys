Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports System.Data.SqlClient
Public Class 外注内訳入力
    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs) Handles Entry.MouseLeave
        Entry.ImageIndex = 3
    End Sub

    Private Sub Button4_MouseEnter(sender As Object, e As EventArgs) Handles Entry.MouseEnter
        Entry.Cursor = Cursors.Hand
        Entry.ImageIndex = 4
    End Sub

    Private Sub Button4_MouseDown(sender As Object, e As MouseEventArgs) Handles Entry.MouseDown
        Entry.ImageIndex = 5
    End Sub
    Private Sub cancel_MouseLeave(sender As Object, e As EventArgs) Handles Cancel.MouseLeave
        Cancel.ImageIndex = 6
    End Sub

    Private Sub cancel_MouseEnter(sender As Object, e As EventArgs) Handles Cancel.MouseEnter
        Cancel.Cursor = Cursors.Hand
        Cancel.ImageIndex = 7
    End Sub

    Private Sub cancel_MouseDown(sender As Object, e As MouseEventArgs) Handles Cancel.MouseDown
        Cancel.ImageIndex = 8
    End Sub
    Private Sub create_MouseLeave(sender As Object, e As EventArgs) Handles Create.MouseLeave
        Create.ImageIndex = 0
    End Sub

    Private Sub create_MouseEnter(sender As Object, e As EventArgs) Handles Create.MouseEnter
        Create.Cursor = Cursors.Hand
        Create.ImageIndex = 1
    End Sub

    Private Sub create_MouseDown(sender As Object, e As MouseEventArgs) Handles Create.MouseDown
        Create.ImageIndex = 2
    End Sub

    Private Sub 外注内訳入力_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DetailList(0, 2) = "工種"
        DetailList(1, 2) = "工種"
        DetailList(2, 2) = "工種"
        DetailList(0, 3) = "工種名"
        DetailList(0, 5) = "数量"
        DetailList(1, 3) = "名称"
        DetailList(1, 4) = "名称"
        DetailList(2, 3) = "規格"
        DetailList(2, 4) = "規格"
        DetailList(0, 4) = "単位"
        DetailList(1, 5) = "単価"
        DetailList(2, 5) = "金額"
        DetailList(0, 6) = "直営分"
        DetailList(2, 6) = "金額"

        DetailList.MergedRanges.Add(0, 2, 2, 2)
        DetailList.MergedRanges.Add(1, 3, 1, 4)
        DetailList.MergedRanges.Add(2, 3, 2, 4)
        DetailList.MergedRanges.Add(0, 6, 1, 6)

        DetailList.Rows(0).Height = 17
        DetailList.Rows(1).Height = 17
        DetailList.Rows(2).Height = 17
        Breakdown.Rows(0).Height = 17
        Breakdown.Rows(1).Height = 17
        Breakdown.Rows(2).Height = 17

        'Breakdown.Footers.Descriptions.Add(New FooterDescription())
        'Breakdown.Footers.Fixed = True

        TotalBreakdown.ScrollBars = ScrollBars.None

        '協力業者テーブルからレコード数を取得
        ホーム.Sql.Parameters.Clear()
        ホーム.Sql.CommandText = "SELECT count(outsrcr_id) from Outsourcers"
        Dim Vendorcount As Integer = ホーム.Sql.ExecuteScalar

        ホーム.Sql.Parameters.Clear()
        ホーム.Sql.CommandText = "SELECT * FROM outsourcers"

        Dim Coopcount As Integer = 1
        Dim Coopreader As SqlDataReader = ホーム.Sql.ExecuteReader
        While Coopreader.Read
            Breakdown(0, Coopcount) = Coopreader.Item("outsrcr_id")
            Breakdown(1, Coopcount) = Coopreader.Item("outsrcr_code")
            Breakdown(2, Coopcount) = Coopreader.Item("outsrcr_name")
            Coopcount += 1
        End While
        Coopreader.Close()

        Dim Drow1 As Integer = 3
        Dim Drow2 As Integer = 4
        Dim Drow3 As Integer = 5
        Dim quanity As Integer
        Dim costea As Integer
        ホーム.Sql.Parameters.Clear()
        ホーム.Sql.CommandText = "SELECT * FROM details WHERE budget_no=" & ホーム.BudgetNo & "ORDER BY dtl_id ASC"
        Dim Detailreader As SqlDataReader = ホーム.Sql.ExecuteReader
        While Detailreader.Read
            Me.DetailList.Rows.Add()
            Me.DetailList.Rows.Add()
            Me.DetailList.Rows.Add()
            Me.Breakdown.Rows.Add()
            Me.Breakdown.Rows.Add()
            Me.Breakdown.Rows.Add()

            DetailList(Drow1, 0) = Detailreader.Item("dtl_id")
            DetailList(Drow1, 1) = Detailreader.Item("dtl_no")
            DetailList(Drow1, 2) = Detailreader.Item("s_worktype_code")
            DetailList(Drow1, 4) = Detailreader.Item("dtl_unit")
            DetailList(Drow1, 5) = Detailreader.Item("dtl_quanity")
            Dim Dtlquanity As CellRange = DetailList.GetCellRange(Drow1, 5)
            Dtlquanity.StyleNew.Format = "N1"
            DetailList(Drow2, 3) = Detailreader.Item("dtl_name")
            DetailList.MergedRanges.Add(Drow2, 3, Drow2, 4)
            DetailList(Drow2, 5) = Detailreader.Item("dtl_costea")
            Dim Dtlcostea As CellRange = DetailList.GetCellRange(Drow2, 5)
            Dtlcostea.StyleNew.Format = "N0"
            DetailList(Drow3, 3) = Detailreader.Item("dtl_spec")
            DetailList.MergedRanges.Add(Drow3, 3, Drow3, 4)
            quanity = DetailList(Drow1, 5)
            costea = DetailList(Drow2, 5)
            DetailList(Drow3, 5) = quanity * costea
            Dim Dtlamount As CellRange = DetailList.GetCellRange(Drow3, 5)
            Dtlamount.StyleNew.Format = "N0"

            If Drow1 Mod 2 = 0 Then
                DetailList.Rows(Drow1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                DetailList.Rows(Drow1 + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                DetailList.Rows(Drow1 + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                Breakdown.Rows(Drow1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                Breakdown.Rows(Drow1 + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                Breakdown.Rows(Drow1 + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
            End If

            Drow1 += 3
            Drow2 += 3
            Drow3 += 3

        End While
        Detailreader.Close()

        '工種名を取得
        ホーム.Sql.Parameters.Clear()
        ホーム.Sql.CommandText = "SELECT COUNT(dtl_id) FROM details WHERE budget_no=" & ホーム.BudgetNo
        Dim Detailscount As Integer = ホーム.Sql.ExecuteScalar

        For SWORKTYPEloop As Integer = 1 To Detailscount
            ホーム.SystemSql.CommandText = "SELECT s_worktype FROM s_worktype WHERE s_worktype_code=" & DetailList(SWORKTYPEloop * 3, 2)
            Dim SwrktypName As String = ホーム.SystemSql.ExecuteScalar
            DetailList(SWORKTYPEloop * 3, 3) = SwrktypName
        Next

        '一番大きい変更回数を取得し、変更回数の上限下限をセット
        ホーム.Sql.CommandText = "SELECT ISNULL(MAX(outsrc_no),0) from Outsourcing_plans"
        Dim Maxoutsrc As Integer = ホーム.Sql.ExecuteScalar

        ContractNo.PostValidation.Validation = PostValidationTypeEnum.ValuesAndIntervals
        Dim valInteval_1 As ValueInterval = New ValueInterval(0, Maxoutsrc, True, True)
        ContractNo.PostValidation.Intervals.Add(valInteval_1)
        ContractNo.Value = Maxoutsrc

    End Sub

    Private Sub C1FlexGrid2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ChangeDetails_TextChanged(sender As Object, e As EventArgs) Handles ChangeDetail.TextChanged

    End Sub

    Private Sub DetailList_AfterScroll(sender As Object, e As RangeEventArgs) Handles DetailList.AfterScroll
        Breakdown.ScrollPosition = DetailList.ScrollPosition

    End Sub

    Private Sub Breakdown_AfterScroll(sender As Object, e As RangeEventArgs) Handles Breakdown.AfterScroll
        DetailList.ScrollPosition = Breakdown.ScrollPosition
        TotalBreakdown.ScrollPosition = Breakdown.ScrollPosition
    End Sub
    Private Sub TotalBreakdown_AfterScroll(sender As Object, e As RangeEventArgs) Handles TotalBreakdown.AfterScroll
        Breakdown.ScrollPosition = TotalBreakdown.ScrollPosition
    End Sub
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub ContractNo_ValueChanged(sender As Object, e As EventArgs) Handles ContractNo.ValueChanged
        Breakdown.Clear(ClearFlags.Content)

        '協力業者テーブルから業者数を取得
        ホーム.Sql.Parameters.Clear()
        ホーム.Sql.CommandText = "SELECT count(outsrcr_id) from Outsourcers"
        Dim Vendorcount As Integer = ホーム.Sql.ExecuteScalar

        ホーム.Sql.Parameters.Clear()
        ホーム.Sql.CommandText = "SELECT * FROM outsourcers"

        Dim Coopcount As Integer = 1
        Dim Coopreader As SqlDataReader = ホーム.Sql.ExecuteReader
        While Coopreader.Read
            If Vendorcount >= 8 Then
                Me.Breakdown.Cols.Count = Vendorcount + 1
                Me.TotalBreakdown.Cols.Count = Vendorcount + 1
            End If
            Breakdown(0, Coopcount) = Coopreader.Item("outsrcr_id")
            Breakdown(1, Coopcount) = Coopreader.Item("outsrcr_code")
            Breakdown(2, Coopcount) = Coopreader.Item("outsrcr_name")
            Coopcount += 1
        End While
        Coopreader.Close()

        ホーム.Sql.Parameters.Clear()
        ホーム.Sql.CommandText = "SELECT COUNT(dtl_id) FROM details WHERE budget_no=" & ホーム.BudgetNo
        Dim Detailscount As Integer = ホーム.Sql.ExecuteScalar

        For vendorloop As Integer = 1 To Vendorcount
            Dim total As Integer = 0
            For BDloop As Integer = 1 To Detailscount
                ホーム.Sql.Parameters.Clear()
                ホーム.Sql.CommandText = "SELECT ISNULL(outsrcng_quanity,0) from Outsourcing_plans WHERE dtl_id = " & DetailList(BDloop * 3, 0) & "AND outsrcr_id=" & Breakdown(0, vendorloop) & "AND outsrc_no=" & ContractNo.Value
                Dim Oquanity As Integer = ホーム.Sql.ExecuteScalar
                If Oquanity = 0 Then
                    Breakdown(BDloop * 3, vendorloop) = 0
                    Breakdown.Rows(BDloop * 3).StyleNew.Format = "N1"
                Else
                    Breakdown(BDloop * 3, vendorloop) = Oquanity
                    Breakdown.Rows(BDloop * 3).StyleNew.Format = "N1"
                End If
                Breakdown.Rows(BDloop * 3).AllowEditing = True

                ホーム.Sql.Parameters.Clear()
                ホーム.Sql.CommandText = "SELECT ISNULL(outsrcng_costea,0) from Outsourcing_plans WHERE dtl_id = " & DetailList(BDloop * 3, 0) & "AND outsrcr_id=" & Breakdown(0, vendorloop) & "AND outsrc_no=" & ContractNo.Value
                Dim Ocostea As Integer = ホーム.Sql.ExecuteScalar
                If Ocostea = 0 Then
                    Breakdown(BDloop * 3 + 1, vendorloop) = 0
                    Breakdown.Rows(BDloop * 3 + 1).StyleNew.Format = "N0"
                Else
                    Breakdown(BDloop * 3 + 1, vendorloop) = Ocostea
                    Breakdown.Rows(BDloop * 3 + 1).StyleNew.Format = "N0"
                End If
                Breakdown.Rows(BDloop * 3 + 1).AllowEditing = True

                Dim Amount As Integer = 0
                Amount = Oquanity * Ocostea
                Breakdown(BDloop * 3 + 2, vendorloop) = Amount
                Breakdown.Rows(BDloop * 3 + 2).StyleNew.Format = "N0"
                total += Amount
                TotalBreakdown(0, vendorloop) = total
                TotalBreakdown.Rows(0).StyleNew.Format = "N0"

            Next
        Next

        ホーム.Sql.Parameters.Clear()
        ホーム.Sql.CommandText = "SELECT created_date FROM outsourcing_plans WHERE budget_no=" & ホーム.BudgetNo & "AND outsrc_no=" & ContractNo.Value
        Dim CreateDate As Date = ホーム.Sql.ExecuteScalar
        CreatedDateBox.Value = CreateDate.ToString("D")

        '外注計画報告書テーブルから変更内容を取得
        ホーム.Sql.Parameters.Clear()
        ホーム.Sql.CommandText = "SELECT changes FROM Outsourcing_reports WHERE outsrc_no=" & ContractNo.Value
        Dim change As String = ホーム.Sql.ExecuteScalar
        ChangeDetail.Value = change

        '直営計算
        Dim Gtotal As Int64 '直営合計
        Dim DMtotal As Int64 '直営金額
        For DTloop As Integer = 1 To Detailscount
            Dim DM As Int64 = 0
            For DMloop As Integer = 1 To Vendorcount
                DM += Breakdown(DTloop * 3 + 2, DMloop)
            Next
            Dim CoTotal As Int64 = DetailList(DTloop * 3 + 2, 5)
            DMtotal = CoTotal - DM
            DetailList(DTloop * 3 + 2, 6) = DMtotal
            Gtotal += DMtotal
        Next
        Total.Value = Gtotal

    End Sub

    Private Sub Breakdown_AfterEdit(sender As Object, e As RowColEventArgs) Handles Breakdown.AfterEdit

        Dim quanity As Integer
        Dim costea As Integer
        Dim total As Integer

        If e.Row Mod 2 = 0 Then
            quanity = Breakdown(e.Row - 1, e.Col)
            costea = Breakdown(e.Row, e.Col)
            total = quanity * costea
            Breakdown(e.Row + 1, e.Col) = total
        Else
            quanity = Breakdown(e.Row, e.Col)
            costea = Breakdown(e.Row + 1, e.Col)
            total = quanity * costea
            Breakdown(e.Row + 2, e.Col) = total
        End If

        quanity = 0
        costea = 0
        total = 0

        '直営計算
        Dim Gtotal As Int64 '直営合計
        Dim DMtotal As Int64 '直営金額
        Dim DM As Int64 '外注合計
        Dim CoTotal As Int64
        Dim Vendorcount As Integer = Breakdown.Cols.Count - 1

        If e.Row Mod 2 = 0 Then
            For Vendorloop As Integer = 1 To Vendorcount
                DM += Breakdown(e.Row + 1, Vendorloop)
            Next
            CoTotal = DetailList(e.Row + 1, 5)
            DMtotal = CoTotal - DM
            DetailList(e.Row + 1, 6) = DMtotal
        Else
            For Vendorloop As Integer = 1 To Vendorcount
                DM += Breakdown(e.Row + 2, Vendorloop)
            Next
            CoTotal = DetailList(e.Row + 2, 5)
            DMtotal = CoTotal - DM
            DetailList(e.Row + 2, 6) = DMtotal
        End If

    End Sub

    Private Sub Create_Click(sender As Object, e As EventArgs) Handles Create.Click
        ホーム.Sql.Parameters.Clear()
        ホーム.Sql.CommandText = "SELECT ISNULL(MAX(outsrc_no),0) from Outsourcing_plans"
        Dim Maxoutsrc As Integer = ホーム.Sql.ExecuteScalar

        If MsgBox("第" & ホーム.BudgetNo & "回予算計画の最新の変更計画をもとに、新しい変更計画を作成します。", MsgBoxStyle.OkCancel, "新規作成") = MsgBoxResult.Ok Then
            ContractNo.Value = Maxoutsrc + 1

            ホーム.Sql.Parameters.Clear()
            ホーム.Sql.CommandText = "SELECT created_date FROM Outsourcing_plans WHERE outsrc_no=" & ContractNo.Value - 1
            Dim CreatedDate As String = ホーム.Sql.ExecuteScalar
            CreatedDateBox.Value = CreatedDate


            '協力業者テーブルからレコード数を取得
            ホーム.Sql.Parameters.Clear()
            ホーム.Sql.CommandText = "SELECT count(outsrcr_id) from Outsourcers"
            Dim Vendorcount As Integer = ホーム.Sql.ExecuteScalar

            '外注計画報告書テーブルから変更内容を取得
            ホーム.Sql.Parameters.Clear()
            ホーム.Sql.CommandText = "SELECT changes FROM Outsourcing_reports WHERE outsrc_no=" & ContractNo.Value - 1
            Dim change As String = ホーム.Sql.ExecuteScalar
            ChangeDetail.Value = change

            ホーム.Sql.Parameters.Clear()
            ホーム.Sql.CommandText = "SELECT * FROM outsourcers"
            Dim Coopcount As Integer = 1
            Dim Coopreader As SqlDataReader = ホーム.Sql.ExecuteReader
            While Coopreader.Read
                Breakdown(0, Coopcount) = Coopreader.Item("outsrcr_id")
                Breakdown(1, Coopcount) = Coopreader.Item("outsrcr_code")
                Breakdown(2, Coopcount) = Coopreader.Item("outsrcr_name")
                Coopcount += 1
            End While
            Coopreader.Close()

        End If
    End Sub

End Class