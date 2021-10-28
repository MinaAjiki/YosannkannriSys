Public Class DB選択
    Private Sub DB選択_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileList.Rows(0).Height = 20
        FileList(1, 1) = "DD0000テスト工事"
        FileList(1, 2) = "D:\現場データ\DD0000テスト工事.mdf"
        FileList(2, 1) = "DH0000テスト舗装"
        FileList(2, 2) = "C:\Users\206029\デスクトップ\現場データ\DH0000テスト舗装.mdf"
    End Sub

    Private Sub Open_MouseEnter(sender As Object, e As EventArgs) Handles Open.MouseEnter
        Open.Cursor = Cursors.Hand
        Open.ImageIndex = 1
    End Sub

    Private Sub Open_MouseDown(sender As Object, e As MouseEventArgs) Handles Open.MouseDown
        Open.ImageIndex = 2
    End Sub

    Private Sub OtherFile_MouseEnter(sender As Object, e As EventArgs) Handles OtherFile.MouseEnter
        OtherFile.Cursor = Cursors.Hand
        OtherFile.ImageIndex = 1
    End Sub

    Private Sub OtherFile_MouseDown(sender As Object, e As MouseEventArgs) Handles OtherFile.MouseDown
        OtherFile.ImageIndex = 2
    End Sub

    Private Sub Open_MouseLeave(sender As Object, e As EventArgs) Handles Open.MouseLeave
        Open.ImageIndex = 0
    End Sub

    Private Sub Open_MouseUp(sender As Object, e As MouseEventArgs) Handles Open.MouseUp
        Open.ImageIndex = 0
    End Sub

    Private Sub OtherFile_MouseLeave(sender As Object, e As EventArgs) Handles OtherFile.MouseLeave
        OtherFile.ImageIndex = 0
    End Sub

    Private Sub OtherFile_MouseUp(sender As Object, e As MouseEventArgs) Handles OtherFile.MouseUp
        OtherFile.ImageIndex = 0
    End Sub

End Class