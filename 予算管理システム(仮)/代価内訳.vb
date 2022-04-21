Imports C1.Win.C1FlexGrid
Public Class 代価内訳

    Private Sub 代価内訳_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'DetailsList.Rows(1).AllowMerging = True
        DetailsList(0, 2) = "削除"
        DetailsList(1, 2) = "削除"
        DetailsList(2, 2) = "削除"
        DetailsList(0, 3) = "順"
        DetailsList(1, 3) = "順"
        DetailsList(2, 3) = "順"
        DetailsList(0, 4) = "名称"
        DetailsList(0, 5) = "名称"
        DetailsList(1, 4) = "規格"
        DetailsList(1, 5) = "規格"
        DetailsList(2, 4) = "摘要"
        DetailsList(2, 5) = "単位"
        DetailsList(1, 6) = "単価"
        DetailsList(2, 6) = "金額"

        DetailsList.MergedRanges.Add(0, 2, 2, 2)
        DetailsList.MergedRanges.Add(0, 3, 2, 3)
        DetailsList.MergedRanges.Add(0, 4, 0, 5)
        DetailsList.MergedRanges.Add(1, 4, 1, 5)
        DetailsList.MergedRanges.Add(0, 7, 2, 7)
        DetailsList.MergedRanges.Add(0, 8, 2, 8)
        DetailsList.MergedRanges.Add(0, 9, 2, 9)
        DetailsList.MergedRanges.Add(0, 10, 2, 10)
        DetailsList.MergedRanges.Add(0, 11, 2, 11)

        DetailsList.Rows(0).Height = 17
        DetailsList.Rows(1).Height = 17
        DetailsList.Rows(2).Height = 17


        Me.Anchor = AnchorStyles.Top
        Me.Anchor = AnchorStyles.Left
        Me.Anchor = AnchorStyles.Bottom

    End Sub

    Private Sub Cancel_MouseDown(sender As Object, e As MouseEventArgs) Handles Cancel.MouseDown
        Cancel.ImageIndex = 8
    End Sub

    Private Sub Cancel_MouseEnter(sender As Object, e As EventArgs) Handles Cancel.MouseEnter
        Cancel.Cursor = Cursors.Hand
        Cancel.ImageIndex = 7
    End Sub

    Private Sub Cancel_MouseLeave(sender As Object, e As EventArgs) Handles Cancel.MouseLeave
        Cancel.ImageIndex = 6
    End Sub

    Private Sub Cancel_MouseUp(sender As Object, e As MouseEventArgs) Handles Cancel.MouseUp
        Cancel.ImageIndex = 6
    End Sub

    Private Sub Entry_MouseUp(sender As Object, e As MouseEventArgs) Handles Entry.MouseUp
        Entry.ImageIndex = 3
    End Sub
    Private Sub Entry_MouseDown(sender As Object, e As MouseEventArgs) Handles Entry.MouseDown
        Entry.ImageIndex = 5
    End Sub

    Private Sub Entry_MouseEnter(sender As Object, e As EventArgs) Handles Entry.MouseEnter
        Entry.Cursor = Cursors.Hand
        Entry.ImageIndex = 4
    End Sub

    Private Sub Entry_MouseLeave(sender As Object, e As EventArgs) Handles Entry.MouseLeave
        Entry.ImageIndex = 3
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        代価一覧.Show()
        Me.Close()
    End Sub

    Private Sub Entry_Click(sender As Object, e As EventArgs) Handles Entry.Click
        Me.Close()
    End Sub
End Class