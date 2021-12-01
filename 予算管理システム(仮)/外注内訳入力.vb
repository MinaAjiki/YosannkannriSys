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
        'Breakdown(0, 1) = "9999999"
        'Breakdown(1, 1) = "㈱市川工務店"

        DetailList(3, 2) = 1
        DetailList(6, 2) = 2
        DetailList(9, 2) = 3
        DetailList(12, 2) = 4
        DetailList(15, 2) = 5
        DetailList(18, 2) = 6
        DetailList(21, 2) = 7

        DetailList.MergedRanges.Add(0, 2, 2, 2)
        'DetailsList.MergedRanges.Add(0, 3, 0, 4)
        DetailList.MergedRanges.Add(1, 3, 1, 4)
        DetailList.MergedRanges.Add(2, 3, 2, 4)
        DetailList.MergedRanges.Add(0, 6, 1, 6)
        'DetailsList2.MergedRanges.Add(0, 1, 2, 1)
        'DetailsList2.MergedRanges.Add(0, 2, 2, 2)


        DetailList.Rows(0).Height = 17
        DetailList.Rows(1).Height = 17
        DetailList.Rows(2).Height = 17
        Breakdown.Rows(0).Height = 17
        Breakdown.Rows(1).Height = 17
        Breakdown.Rows(2).Height = 17

        '一番大きい変更回数を取得し、変更回数の上限下限をセット
        ホーム.Sql.CommandText = "SELECT ISNULL(MAX(outsrc_no),0) from Outsourcing_plans"
        Dim Maxoutsrc As Integer = ホーム.Sql.ExecuteScalar

        ContractNo.PostValidation.Validation = PostValidationTypeEnum.ValuesAndIntervals
        Dim valInteval_1 As ValueInterval = New ValueInterval(0, Maxoutsrc, True, True)
        ContractNo.PostValidation.Intervals.Add(valInteval_1)
        ContractNo.Value = Maxoutsrc

        Breakdown.Footers.Descriptions.Add(New FooterDescription())
        Breakdown.Footers.Fixed = True

        '協力業者テーブルからレコード数を取得
        ホーム.Sql.Parameters.Clear()
        ホーム.Sql.CommandText = "SELECT count(outsrcr_id) from Outsourcers"
        Dim Vendorcount As Integer = ホーム.Sql.ExecuteScalar

        ホーム.Sql.Parameters.Clear()
        ホーム.Sql.CommandText = "SELECT * FROM outsourcers"

        Dim Coopcount As Integer = 1
        Dim Coopreader As SqlDataReader = ホーム.Sql.ExecuteReader
        While Coopreader.Read
            Me.Breakdown.Rows.Add()
            Breakdown(0, Coopcount) = Coopreader.Item("outsrcr_id")
            Breakdown(1, Coopcount) = Coopreader.Item("outsrcr_code")
            Breakdown(2, Coopcount) = Coopreader.Item("outsrcr_name")
            Coopcount += 1

        End While
        Coopreader.Close()

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
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub ContractNo_ValueChanged(sender As Object, e As EventArgs) Handles ContractNo.ValueChanged
        Breakdown.Clear(ClearFlags.Content)

        ''協力業者テーブルからレコード数を取得
        'ホーム.Sql.Parameters.Clear()
        'ホーム.Sql.CommandText = "SELECT count(outsrcr_id) from Outsourcers"
        'Dim Vendorcount As Integer = ホーム.Sql.ExecuteScalar

        'ホーム.Sql.Parameters.Clear()
        'ホーム.Sql.CommandText = "SELECT * FROM outsourcers"

        'Dim Coopcount As Integer = 1
        'Dim Coopreader As SqlDataReader = ホーム.Sql.ExecuteReader
        'While Coopreader.Read
        '    Me.Breakdown.Rows.Add()
        '    Breakdown(0, Coopcount) = Coopreader.Item("outsrcr_id")
        '    Breakdown(1, Coopcount) = Coopreader.Item("outsrcr_code")
        '    Breakdown(2, Coopcount) = Coopreader.Item("outsrcr_name")
        '    Coopcount += 1

        'End While
        'Coopreader.Close()

        'For Vendorloop As Integer = 1 To Vendorcount
        '    '明細書テーブルから明細書IDで取引先IDを取得
        '    Command.CommandText = "SELECT outsrcr_id FROM details where dtl_id =" & DetailList(0, Vendorloop)
        '    Dim VendorCode As Integer = ホーム.Sql.ExecuteScalar

        '    ホーム.Sql.Parameters.Clear()
        '    ホーム.Sql.CommandText = "SELECT * FROM outsourcing_plans where outsrcr_id =" & DetailList(0, Vendorloop) '& "AND outsrc_no=" & ContractNo.Value 'ここにDetailListから工種コード検索を追加
        '    Dim Planreader As SqlDataReader = ホーム.Sql.ExecuteReader
        '    'ホーム.Sql.CommandText = "SELECT  FROM details where dtl_id =" & DetailList(0, Vendorloop)
        '    Dim Planrow1 As Integer = 3
        '    Dim Planrow2 As Integer = 4
        '    Dim Planrow3 As Integer = 5
        '    Dim quanity As Integer
        '    Dim costea As Integer
        '    While Planreader.Read
        '        Me.Breakdown.Rows.Add()
        '        If DetailList(Planrow1, Vendorloop) = Planreader.Item("dtl_id") Then
        '            Breakdown(Planrow1, Vendorloop) = Planreader.Item("outsrcng_quanity")
        '            Breakdown(Planrow2, Vendorloop) = Planreader.Item("outsrcng_costea")
        '            quanity = Breakdown(Planrow1, Vendorloop)
        '            costea = Breakdown(Planrow2, Vendorloop)
        '            Breakdown(Planrow3, Vendorloop) = quanity * costea
        '            Breakdown.Rows(Planrow3).AllowEditing = False
        '            Planrow1 += 3
        '            Planrow2 += 3
        '            Planrow3 += 3
        '        End If
        '    End While
        '    Planreader.Close()
        'Next

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
                Me.Breakdown.Rows.Add()
                Breakdown(0, Coopcount) = Coopreader.Item("outsrcr_id")
                Breakdown(1, Coopcount) = Coopreader.Item("outsrcr_code")
                Breakdown(2, Coopcount) = Coopreader.Item("outsrcr_name")
                Coopcount += 1

            End While
            Coopreader.Close()

            For Vendorloop As Integer = 1 To Vendorcount
                ホーム.Sql.Parameters.Clear()
                ホーム.Sql.CommandText = "SELECT * FROM details where outsrcr_id =" & Breakdown(0, Vendorloop) ' & "AND outsrc_no=" & ContractNo.Value 'ここにDetailListから工種コード検索を追加
                Dim Planreader As SqlDataReader = ホーム.Sql.ExecuteReader
                Dim Planrow1 As Integer = 3
                Dim Planrow2 As Integer = 4
                Dim Planrow3 As Integer = 5
                Dim quanity As Integer
                Dim costea As Integer
                While Planreader.Read
                    Me.Breakdown.Rows.Add()
                    If DetailList(Planrow1, Vendorloop) = Planreader.Item("s_worktype_code") Then
                        Breakdown(Planrow1, Vendorloop) = Planreader.Item("dtl_quanity")
                        Breakdown(Planrow2, Vendorloop) = Planreader.Item("dtl_costea")
                        quanity = Breakdown(Planrow1, Vendorloop)
                        costea = Breakdown(Planrow2, Vendorloop)
                        Breakdown(Planrow3, Vendorloop) = quanity * costea
                        Breakdown.Rows(Planrow3).AllowEditing = False
                        Planrow1 += 3
                        Planrow2 += 3
                        Planrow3 += 3
                    End If
                End While
                Planreader.Close()
            Next
        End If
    End Sub


End Class