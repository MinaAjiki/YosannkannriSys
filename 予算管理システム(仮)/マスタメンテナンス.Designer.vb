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
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Cost = New System.Windows.Forms.Button()
        Me.SubContract = New System.Windows.Forms.Button()
        Me.Machine = New System.Windows.Forms.Button()
        Me.Material = New System.Windows.Forms.Button()
        Me.OtherMaster = New System.Windows.Forms.GroupBox()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
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
        Me.CostMaster.Controls.Add(Me.Button14)
        Me.CostMaster.Controls.Add(Me.Button13)
        Me.CostMaster.Controls.Add(Me.Button12)
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
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Button14.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.Location = New System.Drawing.Point(35, 297)
        Me.Button14.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(85, 30)
        Me.Button14.TabIndex = 8
        Me.Button14.Text = "社外機材費"
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Button13.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Location = New System.Drawing.Point(35, 221)
        Me.Button13.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(85, 30)
        Me.Button13.TabIndex = 6
        Me.Button13.Text = "試験費"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Button12.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Location = New System.Drawing.Point(35, 259)
        Me.Button12.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(85, 30)
        Me.Button12.TabIndex = 7
        Me.Button12.Text = "社内機材費"
        Me.Button12.UseVisualStyleBackColor = False
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
        Me.OtherMaster.Controls.Add(Me.Button16)
        Me.OtherMaster.Controls.Add(Me.Button15)
        Me.OtherMaster.Controls.Add(Me.Button4)
        Me.OtherMaster.Controls.Add(Me.Button5)
        Me.OtherMaster.Controls.Add(Me.Button6)
        Me.OtherMaster.Location = New System.Drawing.Point(220, 44)
        Me.OtherMaster.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OtherMaster.Name = "OtherMaster"
        Me.OtherMaster.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OtherMaster.Size = New System.Drawing.Size(150, 340)
        Me.OtherMaster.TabIndex = 55
        Me.OtherMaster.TabStop = False
        Me.OtherMaster.Text = "その他マスタ"
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button16.Location = New System.Drawing.Point(33, 183)
        Me.Button16.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(85, 30)
        Me.Button16.TabIndex = 13
        Me.Button16.Text = "印紙税"
        Me.Button16.UseVisualStyleBackColor = False
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.Location = New System.Drawing.Point(33, 145)
        Me.Button15.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(85, 30)
        Me.Button15.TabIndex = 12
        Me.Button15.Text = "労災保険"
        Me.Button15.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(33, 107)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(85, 30)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "賦課金"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(33, 69)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(85, 30)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "部門費"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(33, 31)
        Me.Button6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(85, 30)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "給与"
        Me.Button6.UseVisualStyleBackColor = False
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
    Friend WithEvents Button12 As Button
    Friend WithEvents Cost As Button
    Friend WithEvents SubContract As Button
    Friend WithEvents Machine As Button
    Friend WithEvents Material As Button
    Friend WithEvents OtherMaster As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Costs As GroupBox
    Friend WithEvents Labor As Button
    Friend WithEvents ProjectCosts As Button
    Friend WithEvents BasicCosts As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button15 As Button
End Class
