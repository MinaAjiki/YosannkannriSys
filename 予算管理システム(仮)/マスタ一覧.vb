Public Class マスタ一覧
    Private Sub マスタ一覧_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MasterContentsList.Rows(0).Height = 20

        MasterContentsList.SetCellImage(1, 6, Image.FromFile(Application.StartupPath & "\Edit_source.png"))
    End Sub
End Class