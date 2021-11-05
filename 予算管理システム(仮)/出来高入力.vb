Imports C1.Win.C1FlexGrid
Public Class 出来高入力
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

    Private Sub 出来高入力_Load(sender As Object, e As EventArgs) Handles Me.Load
        DetailsList(0, 2) = "工種ｺｰﾄﾞ"
        DetailsList(0, 3) = "工種"
        DetailsList(0, 4) = "単位"
        DetailsList(1, 2) = "名称"
        DetailsList(2, 2) = "規格"

        DetailsList.MergedRanges.Add(1, 2, 1, 4)
        DetailsList.MergedRanges.Add(2, 2, 2, 4)
        DetailsList.MergedRanges.Add(0, 5, 2, 5)
        DetailsList.MergedRanges.Add(0, 6, 2, 6)
        DetailsList.MergedRanges.Add(0, 7, 2, 7)
        DetailsList.MergedRanges.Add(0, 8, 2, 8)
    End Sub
End Class