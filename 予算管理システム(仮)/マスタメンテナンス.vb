Public Class マスタメンテナンス
    'Public SelectUser As String = "一般"
    Private Sub Salaries_Click(sender As Object, e As EventArgs) Handles Salaries.Click
        マスタ一覧.ClickButton = "Salaries"
        If SwitchBox.Text = "一般" Then
            マスタ一覧.MasterContentsList.AllowEditing = False
            マスタ一覧.Entry.Visible = False
        ElseIf SwitchBox.Text = "管理者" Then
            マスタ一覧.HeadLine.Text = "マスタ一覧(管理モード)"
            マスタ一覧.MainPanel.BackColor = Color.FromArgb(255, 245, 245)
        End If
        マスタ一覧.Show()
    End Sub

    Private Sub BranchCosts_Click(sender As Object, e As EventArgs) Handles BranchCosts.Click
        マスタ一覧.ClickButton = "BranchCosts"
        If SwitchBox.Text = "一般" Then
            マスタ一覧.MasterContentsList.AllowEditing = False
            マスタ一覧.Entry.Visible = False
        ElseIf SwitchBox.Text = "管理者" Then
            マスタ一覧.HeadLine.Text = "マスタ一覧(管理モード)"
            マスタ一覧.MainPanel.BackColor = Color.FromArgb(255, 245, 245)
        End If
        マスタ一覧.Show()
    End Sub

    Private Sub LevyCosts_Click(sender As Object, e As EventArgs) Handles LevyCosts.Click
        マスタ一覧.ClickButton = "LevyCosts"
        If SwitchBox.Text = "一般" Then
            マスタ一覧.MasterContentsList.AllowEditing = False
            マスタ一覧.Entry.Visible = False
        ElseIf SwitchBox.Text = "管理者" Then
            マスタ一覧.HeadLine.Text = "マスタ一覧(管理モード)"
            マスタ一覧.MainPanel.BackColor = Color.FromArgb(255, 245, 245)
        End If
        マスタ一覧.Show()
    End Sub

    Private Sub Insurances_Click(sender As Object, e As EventArgs) Handles Insurances.Click
        マスタ一覧.ClickButton = "Insurances"
        If SwitchBox.Text = "一般" Then
            マスタ一覧.MasterContentsList.AllowEditing = False
            マスタ一覧.Entry.Visible = False
        ElseIf SwitchBox.Text = "管理者" Then
            マスタ一覧.HeadLine.Text = "マスタ一覧(管理モード)"
            マスタ一覧.MainPanel.BackColor = Color.FromArgb(255, 245, 245)
        End If
        マスタ一覧.Show()
    End Sub

    Private Sub StampTaxes_Click(sender As Object, e As EventArgs) Handles StampTaxes.Click
        マスタ一覧.ClickButton = "StampTaxes"
        If SwitchBox.Text = "一般" Then
            マスタ一覧.MasterContentsList.AllowEditing = False
            マスタ一覧.Entry.Visible = False
        ElseIf SwitchBox.Text = "管理者" Then
            マスタ一覧.HeadLine.Text = "マスタ一覧(管理モード)"
            マスタ一覧.MainPanel.BackColor = Color.FromArgb(255, 245, 245)
        End If
        マスタ一覧.Show()
    End Sub

    Private Sub Labor_Click(sender As Object, e As EventArgs) Handles Labor.Click
        費用マスタ一覧.CostClassCode = 1
        費用マスタ一覧.CostClassName = "労務費"
        If SwitchBox.Text = "一般" Then
            '費用マスタ一覧.MasterContentsList.AllowEditing = False
            '費用マスタ一覧.Entry.Visible = False
        ElseIf SwitchBox.Text = "管理者" Then
            費用マスタ一覧.HeadLine.Text = "費用マスタ一覧(管理モード)"
            費用マスタ一覧.MainPanel.BackColor = Color.FromArgb(255, 245, 245)
        End If
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
        If SwitchBox.Text = "一般" Then
            '費用マスタ一覧.MasterContentsList.AllowEditing = False
            '費用マスタ一覧.Entry.Visible = False
        ElseIf SwitchBox.Text = "管理者" Then
            費用マスタ一覧.HeadLine.Text = "費用マスタ一覧(管理モード)"
            費用マスタ一覧.MainPanel.BackColor = Color.FromArgb(255, 245, 245)
        End If
        費用マスタ一覧.Show()

    End Sub

    Private Sub SubContract_Click(sender As Object, e As EventArgs) Handles SubContract.Click
        費用マスタ一覧.CostClassCode = 4
        費用マスタ一覧.CostClassName = "外注費"
        If SwitchBox.Text = "一般" Then
            '費用マスタ一覧.MasterContentsList.AllowEditing = False
            '費用マスタ一覧.Entry.Visible = False
        ElseIf SwitchBox.Text = "管理者" Then
            費用マスタ一覧.HeadLine.Text = "費用マスタ一覧(管理モード)"
            費用マスタ一覧.MainPanel.BackColor = Color.FromArgb(255, 245, 245)
        End If
        費用マスタ一覧.Show()

    End Sub

    Private Sub Cost_Click(sender As Object, e As EventArgs) Handles Cost.Click
        費用マスタ一覧.CostClassCode = 5
        費用マスタ一覧.CostClassName = "諸経費"
        If SwitchBox.Text = "一般" Then
            '費用マスタ一覧.MasterContentsList.AllowEditing = False
            '費用マスタ一覧.Entry.Visible = False
        ElseIf SwitchBox.Text = "管理者" Then
            費用マスタ一覧.HeadLine.Text = "費用マスタ一覧(管理モード)"
            費用マスタ一覧.MainPanel.BackColor = Color.FromArgb(255, 245, 245)
        End If
        費用マスタ一覧.Show()

    End Sub

    Private Sub ExperimentCosts_Click(sender As Object, e As EventArgs) Handles ExperimentCosts.Click
        費用マスタ一覧.CostClassCode = 8
        費用マスタ一覧.CostClassName = "試験費"
        If SwitchBox.Text = "一般" Then
            '費用マスタ一覧.MasterContentsList.AllowEditing = False
            '費用マスタ一覧.Entry.Visible = False
        ElseIf SwitchBox.Text = "管理者" Then
            費用マスタ一覧.HeadLine.Text = "費用マスタ一覧(管理モード)"
            費用マスタ一覧.MainPanel.BackColor = Color.FromArgb(255, 245, 245)
        End If
        費用マスタ一覧.Show()

    End Sub

    Private Sub In_EquipmentCosts_Click(sender As Object, e As EventArgs) Handles In_EquipmentCosts.Click
        費用マスタ一覧.CostClassCode = 6
        費用マスタ一覧.CostClassName = "社内機材費"
        If SwitchBox.Text = "一般" Then
            '費用マスタ一覧.MasterContentsList.AllowEditing = False
            '費用マスタ一覧.Entry.Visible = False
        ElseIf SwitchBox.Text = "管理者" Then
            費用マスタ一覧.HeadLine.Text = "費用マスタ一覧(管理モード)"
            費用マスタ一覧.MainPanel.BackColor = Color.FromArgb(255, 245, 245)
        End If
        費用マスタ一覧.Show()

    End Sub

    Private Sub Out_EquipmentCosts_Click(sender As Object, e As EventArgs) Handles Out_EquipmentCosts.Click
        費用マスタ一覧.CostClassCode = 7
        費用マスタ一覧.CostClassName = "社外機材費"
        If SwitchBox.Text = "一般" Then
            '費用マスタ一覧.MasterContentsList.AllowEditing = False
            '費用マスタ一覧.Entry.Visible = False
        ElseIf SwitchBox.Text = "管理者" Then
            費用マスタ一覧.HeadLine.Text = "費用マスタ一覧(管理モード)"
            費用マスタ一覧.MainPanel.BackColor = Color.FromArgb(255, 245, 245)
        End If
        費用マスタ一覧.Show()

    End Sub

    Private Sub ProjectCosts_Click(sender As Object, e As EventArgs) Handles ProjectCosts.Click
        代価一覧.ParentFormName = "マスタメンテナンス"
        代価一覧.CostClassCode = 11
        代価一覧.CostClassName = "工事代価"
        代価一覧.Show()
    End Sub

    Private Sub BasicCosts_Click(sender As Object, e As EventArgs) Handles BasicCosts.Click
        代価一覧.ParentFormName = "マスタメンテナンス"
        代価一覧.CostList.Enabled = False
        代価一覧.CostClassCode = 11
        代価一覧.CostClassName = "基礎代価"
        If SwitchBox.Text = "一般" Then
            代価一覧.ProjectCostList.AllowEditing = False
            代価一覧.Entry.Visible = False
        ElseIf SwitchBox.Text = "管理者" Then
            代価一覧.HeadLine.Text = "代価一覧(管理モード)"
            代価一覧.MainPanel.BackColor = Color.FromArgb(255, 245, 245)
        End If
        代価一覧.Show()
    End Sub

    Private Sub マスタメンテナンス_Load(sender As Object, e As EventArgs) Handles Me.Load
        If ホーム.AdminChk = "True" Then
            SwitchBox.Visible = True
        End If
    End Sub

    Private Sub SwitchBox_SelectedItemChanged(sender As Object, e As EventArgs) Handles SwitchBox.SelectedItemChanged

    End Sub

    Private Sub SwitchBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SwitchBox.SelectedIndexChanged
        If SwitchBox.Text = "管理者" Then
            Me.Text = "マスタメンテナンス(管理モード)"
            HeadLine.Text = "マスタメンテナンス(管理モード)"
            Me.BackColor = Color.FromArgb(255, 245, 245)
            Material.ForeColor = Color.Gray
            Material.FlatAppearance.BorderColor = Color.Gray
            Material.Enabled = False
            ProjectCosts.ForeColor = Color.Gray
            ProjectCosts.FlatAppearance.BorderColor = Color.Gray
            ProjectCosts.Enabled = False
            Circulator.Enabled = False
        ElseIf SwitchBox.Text = "一般" Then
            Me.Text = "マスタメンテナンス"
            HeadLine.Text = "マスタメンテナンス"
            Me.BackColor = Color.White
            Material.Enabled = True
            Material.ForeColor = Color.Black
            Material.FlatAppearance.BorderColor = Color.Black
            ProjectCosts.Enabled = True
            ProjectCosts.ForeColor = Color.Black
            ProjectCosts.FlatAppearance.BorderColor = Color.Black
            Circulator.Enabled = True
        End If
    End Sub

    Private Sub Circulator_Click(sender As Object, e As EventArgs) Handles Circulator.Click
        マスタ一覧.ClickButton = "Circulator"
        If SwitchBox.Text = "一般" Then

        ElseIf SwitchBox.Text = "管理者" Then
            マスタ一覧.HeadLine.Text = "マスタ一覧(管理モード)"
            マスタ一覧.MainPanel.BackColor = Color.FromArgb(255, 245, 245)
        End If
        マスタ一覧.Show()
    End Sub
End Class