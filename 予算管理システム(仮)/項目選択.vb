Public Class 項目選択
    Private Sub 項目選択_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        ListBox1.SelectedItems.Clear()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ListBox2.SelectedItems.Clear()
    End Sub
End Class