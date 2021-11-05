Imports C1.Win.C1FlexGrid
Public Class 外注内訳入力
    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs) Handles Button4.MouseLeave
        Button4.ImageIndex = 3
    End Sub

    Private Sub Button4_MouseEnter(sender As Object, e As EventArgs) Handles Button4.MouseEnter
        Button4.Cursor = Cursors.Hand
        Button4.ImageIndex = 4
    End Sub

    Private Sub Button4_MouseDown(sender As Object, e As MouseEventArgs) Handles Button4.MouseDown
        Button4.ImageIndex = 5
    End Sub
    Private Sub cancel_MouseLeave(sender As Object, e As EventArgs) Handles cancel.MouseLeave
        cancel.ImageIndex = 6
    End Sub

    Private Sub cancel_MouseEnter(sender As Object, e As EventArgs) Handles cancel.MouseEnter
        cancel.Cursor = Cursors.Hand
        cancel.ImageIndex = 7
    End Sub

    Private Sub cancel_MouseDown(sender As Object, e As MouseEventArgs) Handles cancel.MouseDown
        cancel.ImageIndex = 8
    End Sub

    Private Sub 外注内訳入力_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DetailsList(0, 2) = "工種"
        DetailsList(1, 2) = "工種"
        DetailsList(2, 2) = "工種"
        DetailsList(0, 3) = "工種名"
        'DetailsList(0, 4) = "工種名"
        DetailsList(0, 5) = "数量"
        DetailsList(1, 3) = "名称"
        DetailsList(1, 4) = "名称"
        DetailsList(2, 3) = "規格"
        DetailsList(2, 4) = "規格"
        DetailsList(0, 4) = "単位"
        DetailsList(1, 5) = "単価"
        DetailsList(2, 5) = "金額"
        DetailsList(0, 6) = "直営分"
        DetailsList(2, 6) = "金額"
        DetailsList2(0, 1) = "9999999"
        DetailsList2(1, 1) = "㈱市川工務店"

        DetailsList.MergedRanges.Add(0, 2, 2, 2)
        'DetailsList.MergedRanges.Add(0, 3, 0, 4)
        DetailsList.MergedRanges.Add(1, 3, 1, 4)
        DetailsList.MergedRanges.Add(2, 3, 2, 4)
        DetailsList.MergedRanges.Add(0, 6, 1, 6)
        'DetailsList2.MergedRanges.Add(0, 1, 2, 1)
        'DetailsList2.MergedRanges.Add(0, 2, 2, 2)


        DetailsList.Rows(0).Height = 17
        DetailsList.Rows(1).Height = 17
        DetailsList.Rows(2).Height = 17
        DetailsList2.Rows(0).Height = 17
        DetailsList2.Rows(1).Height = 17
        DetailsList2.Rows(2).Height = 17

    End Sub

    Private Sub C1FlexGrid2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ChangeDetails_TextChanged(sender As Object, e As EventArgs) Handles ChangeDetails.TextChanged

    End Sub
End Class