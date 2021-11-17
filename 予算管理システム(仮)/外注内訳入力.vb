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

        ホーム.Connection.Close()
        ホーム.Connection.Dispose()
        ホーム.Connection.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\217003\source\repos\MinaAjiki\YosankanriSys\予算管理システム(仮)\現場データ.mdf;Integrated Security=True"

        '一番大きい変更回数を取得し、変更回数の上限下限をセット
        ホーム.Connection.Open()
        ホーム.SystemSql.Connection = ホーム.Connection
        ホーム.SystemSql.CommandText = "SELECT MAX(outsrc_no) from Outsourcing_plans"
        Dim Maxoutsrc As Integer = ホーム.SystemSql.ExecuteScalar

        ContractNo.PostValidation.Validation = PostValidationTypeEnum.ValuesAndIntervals
        Dim valInteval_1 As ValueInterval = New ValueInterval(0, Maxoutsrc + 1, True, True)
        ContractNo.PostValidation.Intervals.Add(valInteval_1)
        ContractNo.Value = Maxoutsrc

        Breakdown.Footers.Descriptions.Add(New FooterDescription())
        Breakdown.Footers.Fixed = True


        ''協力業者テーブルからレコード数を取得
        'ホーム.SystemSql.Parameters.Clear()
        'ホーム.SystemSql.CommandText = "SELECT count(outsrcr_code) from Outsourcers"
        'Dim Vendorcount As Integer = ホーム.SystemSql.ExecuteScalar

        'ホーム.SystemSql.Parameters.Clear()
        'ホーム.SystemSql.CommandText = "SELECT * FROM outsourcers"

        'Dim Coopcount As Integer = 1
        'Dim Coopreader As SqlDataReader = ホーム.SystemSql.ExecuteReader
        'While Coopreader.Read
        '    Me.Breakdown.Rows.Add()
        '    Breakdown(0, Coopcount) = Coopreader.Item("outsrcr_code")
        '    Breakdown(1, Coopcount) = Coopreader.Item("outsrcr_name")
        '    Coopcount += 1

        'End While
        'Coopreader.Close()

        'For Vendorloop As Integer = 1 To Vendorcount
        '    ホーム.SystemSql.Parameters.Clear()
        '    ホーム.SystemSql.CommandText = "SELECT * FROM outsourcing_plans where outsrcr_code =" & Breakdown(0, Vendorloop) & "AND outsrc_no=" & ContractNo.Value 'ここにDetailListから工種コード検索を追加
        '    Dim Planreader As SqlDataReader = ホーム.SystemSql.ExecuteReader
        '    Dim Planrow1 As Integer = 3
        '    Dim Planrow2 As Integer = 4
        '    Dim Planrow3 As Integer = 5
        '    Dim quanity As Integer
        '    Dim costea As Integer
        '    While Planreader.Read
        '        Me.Breakdown.Rows.Add()
        '        Breakdown(Planrow1, Vendorloop) = Planreader.Item("outsrcng_quanity")
        '        Breakdown(Planrow2, Vendorloop) = Planreader.Item("outsrcng_costea")
        '        quanity = Breakdown(Planrow1, Vendorloop)
        '        costea = Breakdown(Planrow2, Vendorloop)
        '        Breakdown(Planrow3, Vendorloop) = quanity * costea
        '        Planrow1 += 3
        '        Planrow2 += 3
        '        Planrow3 += 3

        '    End While
        '    Planreader.Close()
        'Next
    End Sub

    Private Sub C1FlexGrid2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ChangeDetails_TextChanged(sender As Object, e As EventArgs) Handles ChangeDetail.TextChanged

    End Sub

    Private Sub DetailList_AfterScroll(sender As Object, e As RangeEventArgs) Handles DetailList.AfterScroll
        DetailList.ScrollPosition = Breakdown.ScrollPosition

    End Sub

    Private Sub Breakdown_AfterScroll(sender As Object, e As RangeEventArgs) Handles Breakdown.AfterScroll
        DetailList.ScrollPosition = Breakdown.ScrollPosition
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub ContractNo_ValueChanged(sender As Object, e As EventArgs) Handles ContractNo.ValueChanged
        Breakdown.Clear(ClearFlags.Content)

        ホーム.SystemSql.Parameters.Clear()
        ホーム.SystemSql.CommandText = "SELECT created_date FROM Outsourcing_plans WHERE outsrc_no=" & ContractNo.Value
        Dim CreatedDate As String = ホーム.SystemSql.ExecuteScalar
        CreatedDateBox.Value = CreatedDate


        '協力業者テーブルからレコード数を取得
        ホーム.SystemSql.Parameters.Clear()
        ホーム.SystemSql.CommandText = "SELECT count(outsrcr_code) from Outsourcers"
        Dim Vendorcount As Integer = ホーム.SystemSql.ExecuteScalar

        ホーム.SystemSql.Parameters.Clear()
        ホーム.SystemSql.CommandText = "SELECT * FROM outsourcers"

        Dim Coopcount As Integer = 1
        Dim Coopreader As SqlDataReader = ホーム.SystemSql.ExecuteReader
        While Coopreader.Read
            Me.Breakdown.Rows.Add()
            Breakdown(0, Coopcount) = Coopreader.Item("outsrcr_code")
            Breakdown(1, Coopcount) = Coopreader.Item("outsrcr_name")
            Coopcount += 1

        End While
        Coopreader.Close()

        For Vendorloop As Integer = 1 To Vendorcount
            ホーム.SystemSql.Parameters.Clear()
            ホーム.SystemSql.CommandText = "SELECT * FROM outsourcing_plans where outsrcr_code =" & Breakdown(0, Vendorloop) & "AND outsrc_no=" & ContractNo.Value 'ここにDetailListから工種コード検索を追加
            Dim Planreader As SqlDataReader = ホーム.SystemSql.ExecuteReader
            Dim Planrow1 As Integer = 3
            Dim Planrow2 As Integer = 4
            Dim Planrow3 As Integer = 5
            Dim quanity As Integer
            Dim costea As Integer
            While Planreader.Read
                Me.Breakdown.Rows.Add()
                Breakdown(Planrow1, Vendorloop) = Planreader.Item("outsrcng_quanity")
                Breakdown(Planrow2, Vendorloop) = Planreader.Item("outsrcng_costea")
                quanity = Breakdown(Planrow1, Vendorloop)
                costea = Breakdown(Planrow2, Vendorloop)
                Breakdown(Planrow3, Vendorloop) = quanity * costea
                Breakdown(Planrow3, Vendorloop) = BackColor
                Planrow1 += 3
                Planrow2 += 3
                Planrow3 += 3

            End While
            Planreader.Close()
        Next

    End Sub

    Private Sub Breakdown_AfterEdit(sender As Object, e As RowColEventArgs) Handles Breakdown.AfterEdit
        'TotalBreakdown
    End Sub
End Class