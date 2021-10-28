<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class マスタメンテナンス
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.HeadLine = New System.Windows.Forms.Label()
        Me.CostMaster = New System.Windows.Forms.GroupBox()
        Me.Labor = New System.Windows.Forms.Button()
        Me.Out_EquipmentCosts = New System.Windows.Forms.Button()
        Me.ExperimentCosts = New System.Windows.Forms.Button()
        Me.In_EquipmentCosts = New System.Windows.Forms.Button()
        Me.Cost = New System.Windows.Forms.Button()
        Me.SubContract = New System.Windows.Forms.Button()
        Me.Machine = New System.Windows.Forms.Button()
        Me.Material = New System.Windows.Forms.Button()
        Me.OtherMaster = New System.Windows.Forms.GroupBox()
        Me.StampTaxes = New System.Windows.Forms.Button()
        Me.Insurances = New System.Windows.Forms.Button()
        Me.LevyCosts = New System.Windows.Forms.Button()
        Me.BranchCosts = New System.Windows.Forms.Button()
        Me.Salaries = New System.Windows.Forms.Button()
        Me.Costs = New System.Windows.Forms.GroupBox()
        Me.ProjectCosts = New System.Windows.Forms.Button()
        Me.BasicCosts = New System.Windows.Forms.Button()
        Me.CostMaster.SuspendLayout()
        Me.OtherMaster.SuspendLayout()
        Me.Costs.SuspendLayout()
        Me.SuspendLayout()
        '
        'HeadLine
        '
        Me.HeadLine.AutoSize = True
        Me.HeadLine.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.HeadLine.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.HeadLine.Location = New System.Drawing.Point(14, 14)
        Me.HeadLine.Name = "HeadLine"
        Me.HeadLine.Size = New System.Drawing.Size(136, 18)
        Me.HeadLine.TabIndex = 53
        Me.HeadLine.Text = "<<マスタメンテナンス"
        '
        'CostMaster
        '
        Me.CostMaster.Controls.Add(Me.Labor)
        Me.CostMaster.Controls.Add(Me.Out_EquipmentCosts)
        Me.CostMaster.Controls.Add(Me.ExperimentCosts)
        Me.CostMaster.Controls.Add(Me.In_EquipmentCosts)
        Me.CostMaster.Controls.Add(Me.Cost)
        Me.CostMaster.Controls.Add(Me.SubContract)
        Me.CostMaster.Controls.Add(Me.Machine)
        Me.CostMaster.Controls.Add(Me.Material)
        Me.CostMaster.Location = New System.Drawing.Point(41, 44)
        Me.CostMaster.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CostMaster.Name = "CostMaster"
        Me.CostMaster.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CostMaster.Size = New System.Drawing.Size(155, 340)
        Me.CostMaster.TabIndex = 54
        Me.CostMaster.TabStop = False
        Me.CostMaster.Text = "費用マスタ"
        '
        'Labor
        '
        Me.Labor.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Labor.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Labor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Labor.Location = New System.Drawing.Point(35, 31)
        Me.Labor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Labor.Name = "Labor"
        Me.Labor.Size = New System.Drawing.Size(85, 30)
        Me.Labor.TabIndex = 1
        Me.Labor.Text = "労務費"
        Me.Labor.UseVisualStyleBackColor = False
        '
        'Out_EquipmentCosts
        '
        Me.Out_EquipmentCosts.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Out_EquipmentCosts.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Out_EquipmentCosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Out_EquipmentCosts.Location = New System.Drawing.Point(35, 297)
        Me.Out_EquipmentCosts.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Out_EquipmentCosts.Name = "Out_EquipmentCosts"
        Me.Out_EquipmentCosts.Size = New System.Drawing.Size(85, 30)
        Me.Out_EquipmentCosts.TabIndex = 8
        Me.Out_EquipmentCosts.Text = "社外機材費"
        Me.Out_EquipmentCosts.UseVisualStyleBackColor = False
        '
        'ExperimentCosts
        '
        Me.ExperimentCosts.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ExperimentCosts.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ExperimentCosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExperimentCosts.Location = New System.Drawing.Point(35, 221)
        Me.ExperimentCosts.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ExperimentCosts.Name = "ExperimentCosts"
        Me.ExperimentCosts.Size = New System.Drawing.Size(85, 30)
        Me.ExperimentCosts.TabIndex = 6
        Me.ExperimentCosts.Text = "試験費"
        Me.ExperimentCosts.UseVisualStyleBackColor = False
        '
        'In_EquipmentCosts
        '
        Me.In_EquipmentCosts.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.In_EquipmentCosts.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.In_EquipmentCosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.In_EquipmentCosts.Location = New System.Drawing.Point(35, 259)
        Me.In_EquipmentCosts.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.In_EquipmentCosts.Name = "In_EquipmentCosts"
        Me.In_EquipmentCosts.Size = New System.Drawing.Size(85, 30)
        Me.In_EquipmentCosts.TabIndex = 7
        Me.In_EquipmentCosts.Text = "社内機材費"
        Me.In_EquipmentCosts.UseVisualStyleBackColor = False
        '
        'Cost
        '
        Me.Cost.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Cost.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Cost.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cost.Location = New System.Drawing.Point(35, 183)
        Me.Cost.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Cost.Name = "Cost"
        Me.Cost.Size = New System.Drawing.Size(85, 30)
        Me.Cost.TabIndex = 5
        Me.Cost.Text = "諸経費"
        Me.Cost.UseVisualStyleBackColor = False
        '
        'SubContract
        '
        Me.SubContract.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.SubContract.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.SubContract.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SubContract.Location = New System.Drawing.Point(35, 145)
        Me.SubContract.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SubContract.Name = "SubContract"
        Me.SubContract.Size = New System.Drawing.Size(85, 30)
        Me.SubContract.TabIndex = 4
        Me.SubContract.Text = "外注費"
        Me.SubContract.UseVisualStyleBackColor = False
        '
        'Machine
        '
        Me.Machine.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Machine.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Machine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Machine.Location = New System.Drawing.Point(35, 107)
        Me.Machine.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Machine.Name = "Machine"
        Me.Machine.Size = New System.Drawing.Size(85, 30)
        Me.Machine.TabIndex = 3
        Me.Machine.Text = "機械費"
        Me.Machine.UseVisualStyleBackColor = False
        '
        'Material
        '
        Me.Material.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Material.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Material.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Material.Location = New System.Drawing.Point(35, 69)
        Me.Material.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Material.Name = "Material"
        Me.Material.Size = New System.Drawing.Size(85, 30)
        Me.Material.TabIndex = 2
        Me.Material.Text = "材料費"
        Me.Material.UseVisualStyleBackColor = False
        '
        'OtherMaster
        '
        Me.OtherMaster.Controls.Add(Me.StampTaxes)
        Me.OtherMaster.Controls.Add(Me.Insurances)
        Me.OtherMaster.Controls.Add(Me.LevyCosts)
        Me.OtherMaster.Controls.Add(Me.BranchCosts)
        Me.OtherMaster.Controls.Add(Me.Salaries)
        Me.OtherMaster.Location = New System.Drawing.Point(220, 44)
        Me.OtherMaster.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OtherMaster.Name = "OtherMaster"
        Me.OtherMaster.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OtherMaster.Size = New System.Drawing.Size(150, 340)
        Me.OtherMaster.TabIndex = 55
        Me.OtherMaster.TabStop = False
        Me.OtherMaster.Text = "その他マスタ"
        '
        'StampTaxes
        '
        Me.StampTaxes.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.StampTaxes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StampTaxes.Location = New System.Drawing.Point(33, 183)
        Me.StampTaxes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.StampTaxes.Name = "StampTaxes"
        Me.StampTaxes.Size = New System.Drawing.Size(85, 30)
        Me.StampTaxes.TabIndex = 13
        Me.StampTaxes.Text = "印紙税"
        Me.StampTaxes.UseVisualStyleBackColor = False
        '
        'Insurances
        '
        Me.Insurances.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Insurances.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Insurances.Location = New System.Drawing.Point(33, 145)
        Me.Insurances.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Insurances.Name = "Insurances"
        Me.Insurances.Size = New System.Drawing.Size(85, 30)
        Me.Insurances.TabIndex = 12
        Me.Insurances.Text = "労災保険"
        Me.Insurances.UseVisualStyleBackColor = False
        '
        'LevyCosts
        '
        Me.LevyCosts.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.LevyCosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LevyCosts.Location = New System.Drawing.Point(33, 107)
        Me.LevyCosts.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LevyCosts.Name = "LevyCosts"
        Me.LevyCosts.Size = New System.Drawing.Size(85, 30)
        Me.LevyCosts.TabIndex = 11
        Me.LevyCosts.Text = "賦課金"
        Me.LevyCosts.UseVisualStyleBackColor = False
        '
        'BranchCosts
        '
        Me.BranchCosts.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.BranchCosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BranchCosts.Location = New System.Drawing.Point(33, 69)
        Me.BranchCosts.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BranchCosts.Name = "BranchCosts"
        Me.BranchCosts.Size = New System.Drawing.Size(85, 30)
        Me.BranchCosts.TabIndex = 10
        Me.BranchCosts.Text = "部門費"
        Me.BranchCosts.UseVisualStyleBackColor = False
        '
        'Salaries
        '
        Me.Salaries.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Salaries.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Salaries.Location = New System.Drawing.Point(33, 31)
        Me.Salaries.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Salaries.Name = "Salaries"
        Me.Salaries.Size = New System.Drawing.Size(85, 30)
        Me.Salaries.TabIndex = 9
        Me.Salaries.Text = "給与"
        Me.Salaries.UseVisualStyleBackColor = False
        '
        'Costs
        '
        Me.Costs.Controls.Add(Me.ProjectCosts)
        Me.Costs.Controls.Add(Me.BasicCosts)
        Me.Costs.Location = New System.Drawing.Point(392, 44)
        Me.Costs.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Costs.Name = "Costs"
        Me.Costs.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Costs.Size = New System.Drawing.Size(150, 340)
        Me.Costs.TabIndex = 56
        Me.Costs.TabStop = False
        Me.Costs.Text = "代価"
        '
        'ProjectCosts
        '
        Me.ProjectCosts.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.ProjectCosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProjectCosts.Location = New System.Drawing.Point(32, 69)
        Me.ProjectCosts.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ProjectCosts.Name = "ProjectCosts"
        Me.ProjectCosts.Size = New System.Drawing.Size(85, 30)
        Me.ProjectCosts.TabIndex = 1
        Me.ProjectCosts.Text = "工事代価"
        Me.ProjectCosts.UseVisualStyleBackColor = False
        '
        'BasicCosts
        '
        Me.BasicCosts.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.BasicCosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BasicCosts.Location = New System.Drawing.Point(32, 31)
        Me.BasicCosts.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BasicCosts.Name = "BasicCosts"
        Me.BasicCosts.Size = New System.Drawing.Size(85, 30)
        Me.BasicCosts.TabIndex = 0
        Me.BasicCosts.Text = "基礎代価"
        Me.BasicCosts.UseVisualStyleBackColor = False
        '
        'マスタメンテナンス
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(605, 435)
        Me.Controls.Add(Me.Costs)
        Me.Controls.Add(Me.OtherMaster)
        Me.Controls.Add(Me.CostMaster)
        Me.Controls.Add(Me.HeadLine)
        Me.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "マスタメンテナンス"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "マスタメンテナンス"
        Me.CostMaster.ResumeLayout(False)
        Me.OtherMaster.ResumeLayout(False)
        Me.Costs.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HeadLine As Label
    Friend WithEvents CostMaster As GroupBox
    Friend WithEvents In_EquipmentCosts As Button
    Friend WithEvents Cost As Button
    Friend WithEvents SubContract As Button
    Friend WithEvents Machine As Button
    Friend WithEvents Material As Button
    Friend WithEvents OtherMaster As GroupBox
    Friend WithEvents LevyCosts As Button
    Friend WithEvents BranchCosts As Button
    Friend WithEvents Salaries As Button
    Friend WithEvents Costs As GroupBox
    Friend WithEvents Labor As Button
    Friend WithEvents ProjectCosts As Button
    Friend WithEvents BasicCosts As Button
    Friend WithEvents Out_EquipmentCosts As Button
    Friend WithEvents ExperimentCosts As Button
    Friend WithEvents StampTaxes As Button
    Friend WithEvents Insurances As Button
End Class
