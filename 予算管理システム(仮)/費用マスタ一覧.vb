Public Class 費用マスタ一覧
    Private Sub 費用マスタ一覧_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MasterContentsList.SetCellImage(1, 9, Image.FromFile(Application.StartupPath & "\Edit_source.png"))

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

    Private Sub 管理者マスタ一覧_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ホーム.Enabled = True
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
    Private Sub Search_MouseEnter(sender As Object, e As EventArgs) Handles Search.MouseEnter
        Search.Cursor = Cursors.Hand
        Search.ImageIndex = 1
    End Sub

    Private Sub Search_MouseDown(sender As Object, e As MouseEventArgs) Handles Search.MouseDown
        Search.ImageIndex = 2
    End Sub

    Private Sub Search_MouseLeave(sender As Object, e As EventArgs) Handles Search.MouseLeave
        Search.ImageIndex = 0
    End Sub

    Private Sub Search_MouseUp(sender As Object, e As MouseEventArgs) Handles Search.MouseUp
        Search.ImageIndex = 0
    End Sub

End Class