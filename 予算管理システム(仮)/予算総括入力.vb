
Imports C1.Win.C1FlexGrid

Public Class 予算総括入力
    Private Sub 予算総括入力_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        OutsoucersList.Cols(0).ShowButtons = ShowButtonsEnum.Always
        OutsoucersList(1, 1) = "8545670"

    End Sub
    Private Sub OutsoucersList_CellButtonClick(sender As Object, e As C1.Win.C1FlexGrid.RowColEventArgs) Handles OutsoucersList.CellButtonClick
        業者一覧.ParentFormName = "予算総括入力"
        業者一覧.SelectRowIndex = e.Row
        業者一覧.Show()
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

    Private Sub Entry_Click(sender As Object, e As EventArgs) Handles Entry.Click

    End Sub
End Class