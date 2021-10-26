<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form参照作成
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form参照作成))
        Me.HeadLine = New System.Windows.Forms.Label()
        Me.SystemTheme = New C1.Win.C1Themes.C1ThemeController()
        Me.FileName = New C1.Win.C1Input.C1TextBox()
        Me.FileContens = New System.Windows.Forms.GroupBox()
        Me.CopyRange = New System.Windows.Forms.Label()
        Me.Contract_No = New System.Windows.Forms.Label()
        Me.Contract_NoList = New System.Windows.Forms.ComboBox()
        Me.CopyItem = New System.Windows.Forms.GroupBox()
        Me.ProjectCostsList = New System.Windows.Forms.CheckedListBox()
        Me.ProjectCosts = New System.Windows.Forms.CheckBox()
        Me.Details = New System.Windows.Forms.CheckBox()
        Me.BudgetsSummary = New System.Windows.Forms.CheckBox()
        Me.CopyRangePanel = New System.Windows.Forms.Panel()
        Me.PartCopy = New System.Windows.Forms.RadioButton()
        Me.AllCopy = New System.Windows.Forms.RadioButton()
        Me.ButtonImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.OK = New System.Windows.Forms.Button()
        Me.ReferenceFile = New System.Windows.Forms.Label()
        Me.FileOpen = New System.Windows.Forms.Button()
        Me.ProjectCostsCopyPanel = New System.Windows.Forms.Panel()
        Me.ProjectCostsPartCopy = New System.Windows.Forms.RadioButton()
        Me.ProjectCostsAllCopy = New System.Windows.Forms.RadioButton()
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FileContens.SuspendLayout()
        Me.CopyItem.SuspendLayout()
        Me.CopyRangePanel.SuspendLayout()
        Me.ProjectCostsCopyPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'HeadLine
        '
        Me.HeadLine.AutoSize = True
        Me.HeadLine.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.HeadLine.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.HeadLine.Location = New System.Drawing.Point(14, 14)
        Me.HeadLine.Name = "HeadLine"
        Me.HeadLine.Size = New System.Drawing.Size(76, 18)
        Me.HeadLine.TabIndex = 29
        Me.HeadLine.Text = "<<参照作成"
        '
        'FileName
        '
        Me.FileName.AutoSize = False
        Me.FileName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.FileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FileName.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.FileName.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.FileName.Location = New System.Drawing.Point(63, 64)
        Me.FileName.Name = "FileName"
        Me.FileName.ReadOnly = True
        Me.FileName.Size = New System.Drawing.Size(418, 20)
        Me.FileName.TabIndex = 49
        Me.FileName.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.FileName, "(default)")
        Me.FileName.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'FileContens
        '
        Me.FileContens.BackColor = System.Drawing.Color.White
        Me.FileContens.Controls.Add(Me.CopyRange)
        Me.FileContens.Controls.Add(Me.Contract_No)
        Me.FileContens.Controls.Add(Me.Contract_NoList)
        Me.FileContens.Controls.Add(Me.CopyItem)
        Me.FileContens.Controls.Add(Me.CopyRangePanel)
        Me.FileContens.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.FileContens.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.FileContens.Location = New System.Drawing.Point(34, 89)
        Me.FileContens.Margin = New System.Windows.Forms.Padding(0)
        Me.FileContens.Name = "FileContens"
        Me.FileContens.Padding = New System.Windows.Forms.Padding(0)
        Me.FileContens.Size = New System.Drawing.Size(550, 349)
        Me.FileContens.TabIndex = 50
        Me.FileContens.TabStop = False
        Me.FileContens.Text = "DD0000　テスト工事"
        Me.SystemTheme.SetTheme(Me.FileContens, "予算管理テーマ")
        Me.FileContens.Visible = False
        '
        'CopyRange
        '
        Me.CopyRange.AutoSize = True
        Me.CopyRange.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CopyRange.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.CopyRange.Location = New System.Drawing.Point(173, 27)
        Me.CopyRange.Name = "CopyRange"
        Me.CopyRange.Size = New System.Drawing.Size(78, 18)
        Me.CopyRange.TabIndex = 52
        Me.CopyRange.Text = "[コピー範囲]"
        Me.SystemTheme.SetTheme(Me.CopyRange, "(default)")
        '
        'Contract_No
        '
        Me.Contract_No.AutoSize = True
        Me.Contract_No.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Contract_No.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Contract_No.Location = New System.Drawing.Point(18, 27)
        Me.Contract_No.Name = "Contract_No"
        Me.Contract_No.Size = New System.Drawing.Size(66, 18)
        Me.Contract_No.TabIndex = 51
        Me.Contract_No.Text = "[契約回数]"
        Me.SystemTheme.SetTheme(Me.Contract_No, "(default)")
        '
        'Contract_NoList
        '
        Me.Contract_NoList.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Contract_NoList.FormattingEnabled = True
        Me.Contract_NoList.ItemHeight = 18
        Me.Contract_NoList.Items.AddRange(New Object() {"当初", "第１回", "第２回"})
        Me.Contract_NoList.Location = New System.Drawing.Point(25, 51)
        Me.Contract_NoList.Name = "Contract_NoList"
        Me.Contract_NoList.Size = New System.Drawing.Size(121, 26)
        Me.Contract_NoList.TabIndex = 51
        '
        'CopyItem
        '
        Me.CopyItem.BackColor = System.Drawing.Color.White
        Me.CopyItem.Controls.Add(Me.ProjectCostsList)
        Me.CopyItem.Controls.Add(Me.ProjectCosts)
        Me.CopyItem.Controls.Add(Me.Details)
        Me.CopyItem.Controls.Add(Me.BudgetsSummary)
        Me.CopyItem.Controls.Add(Me.ProjectCostsCopyPanel)
        Me.CopyItem.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.CopyItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.CopyItem.Location = New System.Drawing.Point(22, 101)
        Me.CopyItem.Name = "CopyItem"
        Me.CopyItem.Size = New System.Drawing.Size(511, 237)
        Me.CopyItem.TabIndex = 50
        Me.CopyItem.TabStop = False
        Me.CopyItem.Text = "項目を選択"
        Me.SystemTheme.SetTheme(Me.CopyItem, "(default)")
        Me.CopyItem.Visible = False
        '
        'ProjectCostsList
        '
        Me.ProjectCostsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProjectCostsList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ProjectCostsList.FormattingEnabled = True
        Me.ProjectCostsList.Items.AddRange(New Object() {"A代価", "B代価", "C代価", "D代価", "F代価"})
        Me.ProjectCostsList.Location = New System.Drawing.Point(157, 140)
        Me.ProjectCostsList.MultiColumn = True
        Me.ProjectCostsList.Name = "ProjectCostsList"
        Me.ProjectCostsList.ScrollAlwaysVisible = True
        Me.ProjectCostsList.Size = New System.Drawing.Size(339, 82)
        Me.ProjectCostsList.TabIndex = 52
        Me.SystemTheme.SetTheme(Me.ProjectCostsList, "(default)")
        Me.ProjectCostsList.Visible = False
        '
        'ProjectCosts
        '
        Me.ProjectCosts.AutoSize = True
        Me.ProjectCosts.BackColor = System.Drawing.Color.Transparent
        Me.ProjectCosts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ProjectCosts.Location = New System.Drawing.Point(17, 80)
        Me.ProjectCosts.Name = "ProjectCosts"
        Me.ProjectCosts.Size = New System.Drawing.Size(75, 22)
        Me.ProjectCosts.TabIndex = 51
        Me.ProjectCosts.Text = "工事代価"
        Me.SystemTheme.SetTheme(Me.ProjectCosts, "(default)")
        Me.ProjectCosts.UseVisualStyleBackColor = False
        '
        'Details
        '
        Me.Details.AutoSize = True
        Me.Details.BackColor = System.Drawing.Color.Transparent
        Me.Details.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Details.Location = New System.Drawing.Point(17, 52)
        Me.Details.Name = "Details"
        Me.Details.Size = New System.Drawing.Size(63, 22)
        Me.Details.TabIndex = 50
        Me.Details.Text = "明細書"
        Me.SystemTheme.SetTheme(Me.Details, "(default)")
        Me.Details.UseVisualStyleBackColor = False
        '
        'BudgetsSummary
        '
        Me.BudgetsSummary.AutoSize = True
        Me.BudgetsSummary.BackColor = System.Drawing.Color.Transparent
        Me.BudgetsSummary.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BudgetsSummary.Location = New System.Drawing.Point(17, 24)
        Me.BudgetsSummary.Name = "BudgetsSummary"
        Me.BudgetsSummary.Size = New System.Drawing.Size(87, 22)
        Me.BudgetsSummary.TabIndex = 49
        Me.BudgetsSummary.Text = "予算総括表"
        Me.SystemTheme.SetTheme(Me.BudgetsSummary, "(default)")
        Me.BudgetsSummary.UseVisualStyleBackColor = False
        '
        'CopyRangePanel
        '
        Me.CopyRangePanel.BackColor = System.Drawing.Color.White
        Me.CopyRangePanel.Controls.Add(Me.PartCopy)
        Me.CopyRangePanel.Controls.Add(Me.AllCopy)
        Me.CopyRangePanel.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.CopyRangePanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.CopyRangePanel.Location = New System.Drawing.Point(176, 47)
        Me.CopyRangePanel.Name = "CopyRangePanel"
        Me.CopyRangePanel.Size = New System.Drawing.Size(229, 48)
        Me.CopyRangePanel.TabIndex = 53
        Me.SystemTheme.SetTheme(Me.CopyRangePanel, "(default)")
        '
        'PartCopy
        '
        Me.PartCopy.AutoSize = True
        Me.PartCopy.BackColor = System.Drawing.Color.Transparent
        Me.PartCopy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PartCopy.Location = New System.Drawing.Point(118, 8)
        Me.PartCopy.Name = "PartCopy"
        Me.PartCopy.Size = New System.Drawing.Size(98, 22)
        Me.PartCopy.TabIndex = 51
        Me.PartCopy.TabStop = True
        Me.PartCopy.Text = "一部をコピー"
        Me.PartCopy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SystemTheme.SetTheme(Me.PartCopy, "(default)")
        Me.PartCopy.UseVisualStyleBackColor = False
        '
        'AllCopy
        '
        Me.AllCopy.AutoSize = True
        Me.AllCopy.BackColor = System.Drawing.Color.Transparent
        Me.AllCopy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.AllCopy.Location = New System.Drawing.Point(4, 8)
        Me.AllCopy.Name = "AllCopy"
        Me.AllCopy.Size = New System.Drawing.Size(98, 22)
        Me.AllCopy.TabIndex = 50
        Me.AllCopy.TabStop = True
        Me.AllCopy.Text = "全てをコピー"
        Me.SystemTheme.SetTheme(Me.AllCopy, "(default)")
        Me.AllCopy.UseVisualStyleBackColor = False
        '
        'ButtonImageList
        '
        Me.ButtonImageList.ImageStream = CType(resources.GetObject("ButtonImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ButtonImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ButtonImageList.Images.SetKeyName(0, "Default.png")
        Me.ButtonImageList.Images.SetKeyName(1, "Default_mouseenter.png")
        Me.ButtonImageList.Images.SetKeyName(2, "Default_mousedown.png")
        Me.ButtonImageList.Images.SetKeyName(3, "Entry.png")
        Me.ButtonImageList.Images.SetKeyName(4, "Entry_mousenter.png")
        Me.ButtonImageList.Images.SetKeyName(5, "Entry_mousedownpng.png")
        Me.ButtonImageList.Images.SetKeyName(6, "Cancel.png")
        Me.ButtonImageList.Images.SetKeyName(7, "Cancel_mouseenter.png")
        Me.ButtonImageList.Images.SetKeyName(8, "Cancel_mousedown.png")
        Me.ButtonImageList.Images.SetKeyName(9, "CreateCosts.png")
        Me.ButtonImageList.Images.SetKeyName(10, "CreateCosts_mouseenter.png")
        Me.ButtonImageList.Images.SetKeyName(11, "CreateCosts_mousedown.png")
        Me.ButtonImageList.Images.SetKeyName(12, "ModifiyCosts.png")
        Me.ButtonImageList.Images.SetKeyName(13, "ModifyCosts_mouseenter.png")
        Me.ButtonImageList.Images.SetKeyName(14, "ModifyCosts_mousedown.png")
        Me.ButtonImageList.Images.SetKeyName(15, "CopyCosts.png")
        Me.ButtonImageList.Images.SetKeyName(16, "CopyCosts_mouseenter.png")
        Me.ButtonImageList.Images.SetKeyName(17, "CopyCosts_mousedown.png")
        Me.ButtonImageList.Images.SetKeyName(18, "Recalculation.png")
        Me.ButtonImageList.Images.SetKeyName(19, "Recalculation_mousenter.png")
        Me.ButtonImageList.Images.SetKeyName(20, "Recalculation_mousedown.png")
        '
        'OK
        '
        Me.OK.FlatAppearance.BorderSize = 0
        Me.OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OK.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.OK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.OK.ImageIndex = 0
        Me.OK.ImageList = Me.ButtonImageList
        Me.OK.Location = New System.Drawing.Point(484, 61)
        Me.OK.Margin = New System.Windows.Forms.Padding(0)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(100, 30)
        Me.OK.TabIndex = 46
        Me.OK.Text = "O K"
        Me.OK.UseVisualStyleBackColor = True
        Me.OK.Visible = False
        '
        'ReferenceFile
        '
        Me.ReferenceFile.AutoSize = True
        Me.ReferenceFile.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ReferenceFile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ReferenceFile.Location = New System.Drawing.Point(31, 42)
        Me.ReferenceFile.Name = "ReferenceFile"
        Me.ReferenceFile.Size = New System.Drawing.Size(80, 18)
        Me.ReferenceFile.TabIndex = 44
        Me.ReferenceFile.Text = "参照ファイル"
        '
        'FileOpen
        '
        Me.FileOpen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.FileOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.FileOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FileOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FileOpen.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.FileOpen.Image = Global.予算管理システム_仮_.My.Resources.Resources.OpenFile
        Me.FileOpen.Location = New System.Drawing.Point(35, 64)
        Me.FileOpen.Name = "FileOpen"
        Me.FileOpen.Size = New System.Drawing.Size(25, 20)
        Me.FileOpen.TabIndex = 48
        Me.FileOpen.UseVisualStyleBackColor = False
        '
        'ProjectCostsCopyPanel
        '
        Me.ProjectCostsCopyPanel.BackColor = System.Drawing.Color.White
        Me.ProjectCostsCopyPanel.Controls.Add(Me.ProjectCostsPartCopy)
        Me.ProjectCostsCopyPanel.Controls.Add(Me.ProjectCostsAllCopy)
        Me.ProjectCostsCopyPanel.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.ProjectCostsCopyPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ProjectCostsCopyPanel.Location = New System.Drawing.Point(20, 106)
        Me.ProjectCostsCopyPanel.Name = "ProjectCostsCopyPanel"
        Me.ProjectCostsCopyPanel.Size = New System.Drawing.Size(125, 65)
        Me.ProjectCostsCopyPanel.TabIndex = 55
        Me.SystemTheme.SetTheme(Me.ProjectCostsCopyPanel, "(default)")
        Me.ProjectCostsCopyPanel.Visible = False
        '
        'ProjectCostsPartCopy
        '
        Me.ProjectCostsPartCopy.AutoSize = True
        Me.ProjectCostsPartCopy.BackColor = System.Drawing.Color.Transparent
        Me.ProjectCostsPartCopy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ProjectCostsPartCopy.Location = New System.Drawing.Point(13, 35)
        Me.ProjectCostsPartCopy.Name = "ProjectCostsPartCopy"
        Me.ProjectCostsPartCopy.Size = New System.Drawing.Size(98, 22)
        Me.ProjectCostsPartCopy.TabIndex = 56
        Me.ProjectCostsPartCopy.TabStop = True
        Me.ProjectCostsPartCopy.Text = "一部をコピー"
        Me.SystemTheme.SetTheme(Me.ProjectCostsPartCopy, "(default)")
        Me.ProjectCostsPartCopy.UseVisualStyleBackColor = False
        '
        'ProjectCostsAllCopy
        '
        Me.ProjectCostsAllCopy.AutoSize = True
        Me.ProjectCostsAllCopy.BackColor = System.Drawing.Color.Transparent
        Me.ProjectCostsAllCopy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ProjectCostsAllCopy.Location = New System.Drawing.Point(13, 7)
        Me.ProjectCostsAllCopy.Name = "ProjectCostsAllCopy"
        Me.ProjectCostsAllCopy.Size = New System.Drawing.Size(98, 22)
        Me.ProjectCostsAllCopy.TabIndex = 55
        Me.ProjectCostsAllCopy.TabStop = True
        Me.ProjectCostsAllCopy.Text = "全てをコピー"
        Me.SystemTheme.SetTheme(Me.ProjectCostsAllCopy, "(default)")
        Me.ProjectCostsAllCopy.UseVisualStyleBackColor = False
        '
        'Form参照作成
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(614, 451)
        Me.Controls.Add(Me.FileName)
        Me.Controls.Add(Me.FileOpen)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.ReferenceFile)
        Me.Controls.Add(Me.HeadLine)
        Me.Controls.Add(Me.FileContens)
        Me.Name = "Form参照作成"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "参照作成"
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FileContens.ResumeLayout(False)
        Me.FileContens.PerformLayout()
        Me.CopyItem.ResumeLayout(False)
        Me.CopyItem.PerformLayout()
        Me.CopyRangePanel.ResumeLayout(False)
        Me.CopyRangePanel.PerformLayout()
        Me.ProjectCostsCopyPanel.ResumeLayout(False)
        Me.ProjectCostsCopyPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HeadLine As Label
    Friend WithEvents SystemTheme As C1.Win.C1Themes.C1ThemeController
    Private WithEvents ButtonImageList As ImageList
    Friend WithEvents OK As Button
    Friend WithEvents ReferenceFile As Label
    Friend WithEvents FileOpen As Button
    Friend WithEvents FileName As C1.Win.C1Input.C1TextBox
    Friend WithEvents FileContens As GroupBox
    Friend WithEvents CopyItem As GroupBox
    Friend WithEvents CopyRange As Label
    Friend WithEvents Contract_No As Label
    Friend WithEvents Contract_NoList As ComboBox
    Friend WithEvents ProjectCostsList As CheckedListBox
    Friend WithEvents ProjectCosts As CheckBox
    Friend WithEvents Details As CheckBox
    Friend WithEvents BudgetsSummary As CheckBox
    Friend WithEvents CopyRangePanel As Panel
    Friend WithEvents PartCopy As RadioButton
    Friend WithEvents AllCopy As RadioButton
    Friend WithEvents ProjectCostsCopyPanel As Panel
    Friend WithEvents ProjectCostsPartCopy As RadioButton
    Friend WithEvents ProjectCostsAllCopy As RadioButton
End Class
