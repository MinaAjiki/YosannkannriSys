Public Class マスタメンテナンス
    Public ClickButton As String 'どのボタンをクリックしたか
    Private Sub Salaries_Click(sender As Object, e As EventArgs) Handles Salaries.Click
        ClickButton = "Salaries"
        マスタ一覧.Show()
    End Sub

    Private Sub BranchCosts_Click(sender As Object, e As EventArgs) Handles BranchCosts.Click
        ClickButton = "BranchCosts"
        マスタ一覧.Show()
    End Sub

    Private Sub LevyCosts_Click(sender As Object, e As EventArgs) Handles LevyCosts.Click
        ClickButton = "LevyCosts"
        マスタ一覧.Show()
    End Sub

    Private Sub Insurances_Click(sender As Object, e As EventArgs) Handles Insurances.Click
        ClickButton = "Insurances"
        マスタ一覧.Show()
    End Sub

    Private Sub StampTaxes_Click(sender As Object, e As EventArgs) Handles StampTaxes.Click
        ClickButton = "StampTaxes"
        マスタ一覧.Show()
    End Sub

    Private Sub Labor_Click(sender As Object, e As EventArgs) Handles Labor.Click
        費用マスタ一覧.CostClassCode = 1
        費用マスタ一覧.CostClassName = "労務費"
        費用マスタ一覧.Show()
    End Sub

    Private Sub Material_Click(sender As Object, e As EventArgs) Handles Material.Click
        費用マスタ一覧.CostClassCode = 2
        費用マスタ一覧.CostClassName = "材料費"
        費用マスタ一覧.Show()

    End Sub

    Private Sub Machine_Click(sender As Object, e As EventArgs) Handles Machine.Click
        費用マスタ一覧.CostClassCode = 3
        費用マスタ一覧.CostClassName = "機械費"
        費用マスタ一覧.Show()

    End Sub

    Private Sub SubContract_Click(sender As Object, e As EventArgs) Handles SubContract.Click
        費用マスタ一覧.CostClassCode = 4
        費用マスタ一覧.CostClassName = "外注費"
        費用マスタ一覧.Show()

    End Sub

    Private Sub Cost_Click(sender As Object, e As EventArgs) Handles Cost.Click
        費用マスタ一覧.CostClassCode = 5
        費用マスタ一覧.CostClassName = "諸経費"
        費用マスタ一覧.Show()

    End Sub

    Private Sub ExperimentCosts_Click(sender As Object, e As EventArgs) Handles ExperimentCosts.Click
        費用マスタ一覧.CostClassCode = 8
        費用マスタ一覧.CostClassName = "試験費"
        費用マスタ一覧.Show()

    End Sub

    Private Sub In_EquipmentCosts_Click(sender As Object, e As EventArgs) Handles In_EquipmentCosts.Click
        費用マスタ一覧.CostClassCode = 6
        費用マスタ一覧.CostClassName = "社内機材費"
        費用マスタ一覧.Show()

    End Sub

    Private Sub Out_EquipmentCosts_Click(sender As Object, e As EventArgs) Handles Out_EquipmentCosts.Click
        費用マスタ一覧.CostClassCode = 7
        費用マスタ一覧.CostClassName = "社外機材費"
        費用マスタ一覧.Show()

    End Sub

    Private Sub ProjectCosts_Click(sender As Object, e As EventArgs) Handles ProjectCosts.Click
        代価一覧.Show()
    End Sub
End Class