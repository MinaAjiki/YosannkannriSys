Public Class 予算総括入力
    Private Sub 予算総括入力_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Entry.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        業者一覧.Show()
    End Sub

    Private Sub FormPanel_Click(sender As Object, e As EventArgs) Handles FormPanel.Click

    End Sub
End Class