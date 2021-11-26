Public Class 小工種選択

    Private Sub 小工種選択_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        L_WorkType.Value = ホーム.lworktypecode & " " & ホーム.lworktypename

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

    Private Sub S_WorkTypesList_DoubleClick(sender As Object, e As EventArgs) Handles S_WorkTypesList.DoubleClick
        Me.Close()
        明細書入力.TopLevel = False
        ホーム.FormPanel.Controls.Add(明細書入力)
        明細書入力.Show()
    End Sub

    Private Sub C1SplitterPanel1_Click(sender As Object, e As EventArgs) Handles C1SplitterPanel1.Click

    End Sub
End Class