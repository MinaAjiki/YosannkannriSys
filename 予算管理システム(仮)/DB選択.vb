Public Class DB選択
    Private Sub DB選択_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileList.Rows(0).Height = 20
        FileList(1, 1) = "DD0000テスト工事"
        FileList(1, 2) = "D:\現場データ\DD0000テスト工事.mdf"
        FileList(2, 1) = "DH0000テスト舗装"
        FileList(2, 2) = "C:\Users\206029\デスクトップ\現場データ\DH0000テスト舗装.mdf"
    End Sub

    Private Sub FileOpen_MouseEnter(sender As Object, e As EventArgs) Handles FileOpen.MouseEnter
        FileOpen.Cursor = Cursors.Hand
        FileOpen.ImageIndex = 1
    End Sub

    Private Sub FileOpen_MouseDown(sender As Object, e As MouseEventArgs) Handles FileOpen.MouseDown
        FileOpen.ImageIndex = 2
    End Sub

    Private Sub OK_MouseEnter(sender As Object, e As EventArgs) Handles OK.MouseEnter
        OK.Cursor = Cursors.Hand
        OK.ImageIndex = 1
    End Sub

    Private Sub OK_MouseDown(sender As Object, e As MouseEventArgs) Handles OK.MouseDown
        OK.ImageIndex = 2
    End Sub

    Private Sub FileOpen_MouseLeave(sender As Object, e As EventArgs) Handles FileOpen.MouseLeave
        FileOpen.ImageIndex = 0
    End Sub

    Private Sub FileOpen_MouseUp(sender As Object, e As MouseEventArgs) Handles FileOpen.MouseUp
        FileOpen.ImageIndex = 0
    End Sub

    Private Sub OK_MouseLeave(sender As Object, e As EventArgs) Handles OK.MouseLeave
        OK.ImageIndex = 0
    End Sub

    Private Sub OK_MouseUp(sender As Object, e As MouseEventArgs) Handles OK.MouseUp
        OK.ImageIndex = 0
    End Sub
End Class