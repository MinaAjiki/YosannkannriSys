Public Class 締切日入力
    Private Sub 締切日入力_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Deadline.Rows.Count = 2
        Deadline.SetCellImage(1, 2, Image.FromFile(Application.StartupPath & "\Edit_source.png"))
    End Sub
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

    Private Sub Deadline_Click(sender As Object, e As EventArgs) Handles Deadline.Click

    End Sub
End Class