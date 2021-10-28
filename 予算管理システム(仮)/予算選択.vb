Public Class 予算選択
    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        ホーム.Enabled = True
        Me.Close()
    End Sub

    Private Sub 予算選択_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Project.Value = "DD0000 テスト工事"
        FilePath.Value = "C:\Users\206029\デスクトップ\現場データ\DH0000テスト舗装.mdf"
    End Sub
    Private Sub OK_MouseEnter(sender As Object, e As EventArgs) Handles OK.MouseEnter
        OK.Cursor = Cursors.Hand
        OK.ImageIndex = 1
    End Sub

    Private Sub OK_MouseDown(sender As Object, e As MouseEventArgs) Handles OK.MouseDown
        OK.ImageIndex = 2
    End Sub

    Private Sub OK_MouseLeave(sender As Object, e As EventArgs) Handles OK.MouseLeave
        OK.ImageIndex = 0
    End Sub

    Private Sub OK_MouseUp(sender As Object, e As MouseEventArgs) Handles OK.MouseUp
        OK.ImageIndex = 0
    End Sub
End Class