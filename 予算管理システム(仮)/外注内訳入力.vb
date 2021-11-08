Imports C1.Win.C1FlexGrid
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
        'DetailsList(0, 4) = "工種名"
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
        Breakdown(0, 1) = "9999999"
        Breakdown(1, 1) = "㈱市川工務店"

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

    End Sub

    Private Sub C1FlexGrid2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ChangeDetails_TextChanged(sender As Object, e As EventArgs) Handles ChangeDetail.TextChanged

    End Sub
End Class