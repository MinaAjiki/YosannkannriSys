Imports C1.Win.C1FlexGrid

Public Class マスタ一覧
    Private Sub マスタ一覧_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If マスタメンテナンス.ClickButton = "Salaries" Then

        ElseIf マスタメンテナンス.ClickButton = "BranchCosts" Then
            TableName.Text = "部門費マスタ"
            MasterContentsList.Clear(ClearFlags.Content)
            MasterContentsList(0, 1) = "部署"
            MasterContentsList(0, 2) = "割合"
            MasterContentsList(0, 5) = "削除"
            MasterContentsList(0, 6) = "変更"
            MasterContentsList.Cols(1).Width = 300
            MasterContentsList.Cols(2).Width = 100
            MasterContentsList.Cols(3).Width = 0
            MasterContentsList.Cols(4).Width = 0
        ElseIf マスタメンテナンス.ClickButton = "LevyCosts" Then
            TableName.Text = "賦課金マスタ"
            MasterContentsList.Clear(ClearFlags.Content)
            MasterContentsList(0, 1) = "地区"
            MasterContentsList(0, 2) = "賦課率"
            MasterContentsList(0, 5) = "削除"
            MasterContentsList(0, 6) = "変更"
            MasterContentsList.Cols(1).Width = 300
            MasterContentsList.Cols(2).Width = 100
            MasterContentsList.Cols(3).Width = 0
            MasterContentsList.Cols(4).Width = 0
        ElseIf マスタメンテナンス.ClickButton = "Insurances" Then
            YearLabel.Visible = False
            SelectYear.Visible = False
            TableName.Text = "労災保険マスタ"
            MasterContentsList.Clear(ClearFlags.Content)
            MasterContentsList(0, 1) = "工種"
            MasterContentsList(0, 2) = "労務費率"
            MasterContentsList(0, 3) = "保険率"
            MasterContentsList(0, 4) = "保険料"
            MasterContentsList(0, 5) = "削除"
            MasterContentsList(0, 6) = "変更"
            MasterContentsList.Cols(1).Width = 100
            MasterContentsList.Cols(2).Width = 100
            MasterContentsList.Cols(3).Width = 100
            MasterContentsList.Cols(4).Width = 100
        ElseIf マスタメンテナンス.ClickButton = "StampTaxes" Then
            YearLabel.Visible = False
            SelectYear.Visible = False
            TableName.Text = "印紙税マスタ"
            MasterContentsList.Clear(ClearFlags.Content)
            MasterContentsList(0, 1) = "請負金額"
            MasterContentsList(0, 2) = "印紙税"
            MasterContentsList(0, 5) = "削除"
            MasterContentsList(0, 6) = "変更"
            MasterContentsList.Cols(1).Width = 200
            MasterContentsList.Cols(2).Width = 200
            MasterContentsList.Cols(3).Width = 0
            MasterContentsList.Cols(4).Width = 0

        End If
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

    Private Sub MasterContentsList_AfterEdit(sender As Object, e As RowColEventArgs) Handles MasterContentsList.AfterEdit
        Dim SetImageRow As Integer = e.Row
        MasterContentsList.SetCellImage(SetImageRow, 6, Image.FromFile(Application.StartupPath & "\Edit_source.png"))
    End Sub

    Private Sub VendorList_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class