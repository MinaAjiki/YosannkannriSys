﻿Public Class 管理者マスタ一覧
    Private Sub 管理者マスタ一覧_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AdminList.Rows(0).Height = 20
        AdminList(1, 1) = "195015"
        AdminList(1, 2) = "早川 彰彦"
        AdminList(2, 1) = "206029"
        AdminList(2, 2) = "安食 未菜"
        AdminList(3, 1) = "217003"
        AdminList(3, 2) = "鈴木 一将"

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

    Private Sub Entry_Click(sender As Object, e As EventArgs) Handles Entry.Click
        Me.Close()
    End Sub
End Class