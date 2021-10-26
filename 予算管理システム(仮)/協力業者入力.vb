Public Class 協力業者入力
    Private Sub 協力業者入力_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub C1FlexGrid1_Click(sender As Object, e As EventArgs) Handles C1FlexGrid1.Click

    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.ImageIndex = 0
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.Cursor = Cursors.Hand
        Button1.ImageIndex = 1
    End Sub

    Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs) Handles Button1.MouseDown
        Button1.ImageIndex = 2
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class