<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 参照作成
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(参照作成))
        Me.HeadLine = New System.Windows.Forms.Label()
        Me.SystemTheme = New C1.Win.C1Themes.C1ThemeController()
        Me.FileName = New C1.Win.C1Input.C1TextBox()
        Me.FileContens = New System.Windows.Forms.GroupBox()
        Me.CopyRange = New System.Windows.Forms.Label()
        Me.Contract_No = New System.Windows.Forms.Label()
        Me.BudgetNoList = New System.Windows.Forms.ComboBox()
        Me.CopyItem = New System.Windows.Forms.GroupBox()
        Me.ProjectCostsList = New System.Windows.Forms.CheckedListBox()
        Me.ProjectCosts = New System.Windows.Forms.CheckBox()
        Me.Details = New System.Windows.Forms.CheckBox()
        Me.ProjectCostsCopyPanel = New System.Windows.Forms.Panel()
        Me.ProjectCostsPartCopy = New System.Windows.Forms.RadioButton()
        Me.ProjectCostsAllCopy = New System.Windows.Forms.RadioButton()
        Me.CopyRangePanel = New System.Windows.Forms.Panel()
        Me.PartCopy = New System.Windows.Forms.RadioButton()
        Me.AllCopy = New System.Windows.Forms.RadioButton()
        Me.FormSplitContainer = New C1.Win.C1SplitContainer.C1SplitContainer()
        Me.MainPanel = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.FooterPanel = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.ButtonImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.OK = New System.Windows.Forms.Button()
        Me.ReferenceFile = New System.Windows.Forms.Label()
        Me.FileOpen = New System.Windows.Forms.Button()
        Me.FileOpenDialog = New System.Windows.Forms.OpenFileDialog()
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FileContens.SuspendLayout()
        Me.CopyItem.SuspendLayout()
        Me.ProjectCostsCopyPanel.SuspendLayout()
        Me.CopyRangePanel.SuspendLayout()
        CType(Me.FormSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FormSplitContainer.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        Me.FooterPanel.SuspendLayout()
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
        Me.FileName.BackColor = System.Drawing.Color.White
        Me.FileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FileName.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.FileName.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.FileName.Location = New System.Drawing.Point(56, 76)
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
        Me.FileContens.Controls.Add(Me.BudgetNoList)
        Me.FileContens.Controls.Add(Me.CopyItem)
        Me.FileContens.Controls.Add(Me.CopyRangePanel)
        Me.FileContens.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.FileContens.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.FileContens.Location = New System.Drawing.Point(27, 99)
        Me.FileContens.Margin = New System.Windows.Forms.Padding(0)
        Me.FileContens.Name = "FileContens"
        Me.FileContens.Padding = New System.Windows.Forms.Padding(0)
        Me.FileContens.Size = New System.Drawing.Size(550, 335)
        Me.FileContens.TabIndex = 50
        Me.FileContens.TabStop = False
        Me.SystemTheme.SetTheme(Me.FileContens, "予算管理テーマ")
        '
        'CopyRange
        '
        Me.CopyRange.AutoSize = True
        Me.CopyRange.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CopyRange.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.CopyRange.Location = New System.Drawing.Point(173, 24)
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
        Me.Contract_No.Location = New System.Drawing.Point(18, 37)
        Me.Contract_No.Name = "Contract_No"
        Me.Contract_No.Size = New System.Drawing.Size(66, 18)
        Me.Contract_No.TabIndex = 51
        Me.Contract_No.Text = "[変更回数]"
        Me.SystemTheme.SetTheme(Me.Contract_No, "(default)")
        '
        'BudgetNoList
        '
        Me.BudgetNoList.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BudgetNoList.FormattingEnabled = True
        Me.BudgetNoList.ItemHeight = 18
        Me.BudgetNoList.Location = New System.Drawing.Point(25, 61)
        Me.BudgetNoList.Name = "BudgetNoList"
        Me.BudgetNoList.Size = New System.Drawing.Size(121, 26)
        Me.BudgetNoList.TabIndex = 51
        '
        'CopyItem
        '
        Me.CopyItem.BackColor = System.Drawing.Color.White
        Me.CopyItem.Controls.Add(Me.ProjectCostsList)
        Me.CopyItem.Controls.Add(Me.ProjectCosts)
        Me.CopyItem.Controls.Add(Me.Details)
        Me.CopyItem.Controls.Add(Me.ProjectCostsCopyPanel)
        Me.CopyItem.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.CopyItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.CopyItem.Location = New System.Drawing.Point(19, 106)
        Me.CopyItem.Name = "CopyItem"
        Me.CopyItem.Size = New System.Drawing.Size(511, 214)
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
        Me.ProjectCostsList.Location = New System.Drawing.Point(157, 113)
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
        Me.ProjectCosts.Location = New System.Drawing.Point(17, 53)
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
        Me.Details.Location = New System.Drawing.Point(17, 25)
        Me.Details.Name = "Details"
        Me.Details.Size = New System.Drawing.Size(63, 22)
        Me.Details.TabIndex = 50
        Me.Details.Text = "明細書"
        Me.SystemTheme.SetTheme(Me.Details, "(default)")
        Me.Details.UseVisualStyleBackColor = False
        '
        'ProjectCostsCopyPanel
        '
        Me.ProjectCostsCopyPanel.BackColor = System.Drawing.Color.White
        Me.ProjectCostsCopyPanel.Controls.Add(Me.ProjectCostsPartCopy)
        Me.ProjectCostsCopyPanel.Controls.Add(Me.ProjectCostsAllCopy)
        Me.ProjectCostsCopyPanel.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.ProjectCostsCopyPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ProjectCostsCopyPanel.Location = New System.Drawing.Point(20, 79)
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
        'CopyRangePanel
        '
        Me.CopyRangePanel.BackColor = System.Drawing.Color.White
        Me.CopyRangePanel.Controls.Add(Me.PartCopy)
        Me.CopyRangePanel.Controls.Add(Me.AllCopy)
        Me.CopyRangePanel.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.CopyRangePanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.CopyRangePanel.Location = New System.Drawing.Point(176, 44)
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
        'FormSplitContainer
        '
        Me.FormSplitContainer.AutoSizeElement = C1.Framework.AutoSizeElement.Both
        Me.FormSplitContainer.BackColor = System.Drawing.Color.White
        Me.FormSplitContainer.CollapsingAreaColor = System.Drawing.Color.GhostWhite
        Me.FormSplitContainer.CollapsingCueColor = System.Drawing.Color.White
        Me.FormSplitContainer.FixedLineColor = System.Drawing.Color.White
        Me.FormSplitContainer.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.FormSplitContainer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.FormSplitContainer.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.FormSplitContainer.HeaderHeight = 0
        Me.FormSplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.FormSplitContainer.Name = "FormSplitContainer"
        Me.FormSplitContainer.Panels.Add(Me.MainPanel)
        Me.FormSplitContainer.Panels.Add(Me.FooterPanel)
        Me.FormSplitContainer.Size = New System.Drawing.Size(605, 503)
        Me.FormSplitContainer.SplitterColor = System.Drawing.Color.White
        Me.FormSplitContainer.SplitterMovingColor = System.Drawing.Color.Black
        Me.FormSplitContainer.SplitterWidth = 0
        Me.FormSplitContainer.TabIndex = 51
        Me.SystemTheme.SetTheme(Me.FormSplitContainer, "(default)")
        Me.FormSplitContainer.UseParentVisualStyle = False
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.White
        Me.MainPanel.Controls.Add(Me.FileContens)
        Me.MainPanel.Height = 463
        Me.MainPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(605, 463)
        Me.MainPanel.SizeRatio = 92.048R
        Me.MainPanel.TabIndex = 0
        Me.MainPanel.Text = "パネル1"
        '
        'FooterPanel
        '
        Me.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.FooterPanel.Controls.Add(Me.Cancel)
        Me.FooterPanel.Controls.Add(Me.OK)
        Me.FooterPanel.Height = 40
        Me.FooterPanel.Location = New System.Drawing.Point(0, 463)
        Me.FooterPanel.Name = "FooterPanel"
        Me.FooterPanel.Size = New System.Drawing.Size(605, 40)
        Me.FooterPanel.TabIndex = 1
        '
        'Cancel
        '
        Me.Cancel.FlatAppearance.BorderSize = 0
        Me.Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Cancel.ImageIndex = 6
        Me.Cancel.ImageList = Me.ButtonImageList
        Me.Cancel.Location = New System.Drawing.Point(497, 5)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(0)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(100, 30)
        Me.Cancel.TabIndex = 57
        Me.Cancel.Text = "キャンセル"
        Me.Cancel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Cancel.UseVisualStyleBackColor = True
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
        Me.OK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.OK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OK.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.OK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.OK.ImageIndex = 0
        Me.OK.ImageList = Me.ButtonImageList
        Me.OK.Location = New System.Drawing.Point(392, 5)
        Me.OK.Margin = New System.Windows.Forms.Padding(0)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(100, 30)
        Me.OK.TabIndex = 46
        Me.OK.Text = "O K"
        Me.OK.UseVisualStyleBackColor = True
        '
        'ReferenceFile
        '
        Me.ReferenceFile.AutoSize = True
        Me.ReferenceFile.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ReferenceFile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ReferenceFile.Location = New System.Drawing.Point(24, 54)
        Me.ReferenceFile.Name = "ReferenceFile"
        Me.ReferenceFile.Size = New System.Drawing.Size(80, 18)
        Me.ReferenceFile.TabIndex = 44
        Me.ReferenceFile.Text = "参照ファイル"
        '
        'FileOpen
        '
        Me.FileOpen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.FileOpen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.FileOpen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.FileOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FileOpen.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.FileOpen.Image = Global.予算管理システム_仮_.My.Resources.Resources.OpenFile
        Me.FileOpen.Location = New System.Drawing.Point(28, 76)
        Me.FileOpen.Name = "FileOpen"
        Me.FileOpen.Size = New System.Drawing.Size(25, 20)
        Me.FileOpen.TabIndex = 48
        Me.FileOpen.UseVisualStyleBackColor = False
        '
        'FileOpenDialog
        '
        Me.FileOpenDialog.Filter = "MDFファイル|*.mdf|すべて|*.*"
        Me.FileOpenDialog.InitialDirectory = "D:\"
        '
        '参照作成
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(605, 501)
        Me.Controls.Add(Me.FileName)
        Me.Controls.Add(Me.FileOpen)
        Me.Controls.Add(Me.ReferenceFile)
        Me.Controls.Add(Me.HeadLine)
        Me.Controls.Add(Me.FormSplitContainer)
        Me.Name = "参照作成"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "参照作成"
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FileContens.ResumeLayout(False)
        Me.FileContens.PerformLayout()
        Me.CopyItem.ResumeLayout(False)
        Me.CopyItem.PerformLayout()
        Me.ProjectCostsCopyPanel.ResumeLayout(False)
        Me.ProjectCostsCopyPanel.PerformLayout()
        Me.CopyRangePanel.ResumeLayout(False)
        Me.CopyRangePanel.PerformLayout()
        CType(Me.FormSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FormSplitContainer.ResumeLayout(False)
        Me.MainPanel.ResumeLayout(False)
        Me.FooterPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HeadLine As Label
    Friend WithEvents SystemTheme As C1.Win.C1Themes.C1ThemeController
    Private WithEvents ButtonImageList As ImageList
    Friend WithEvents ReferenceFile As Label
    Friend WithEvents FileOpen As Button
    Friend WithEvents FileName As C1.Win.C1Input.C1TextBox
    Friend WithEvents FileContens As GroupBox
    Friend WithEvents CopyItem As GroupBox
    Friend WithEvents CopyRange As Label
    Friend WithEvents Contract_No As Label
    Friend WithEvents BudgetNoList As ComboBox
    Friend WithEvents ProjectCostsList As CheckedListBox
    Friend WithEvents ProjectCosts As CheckBox
    Friend WithEvents Details As CheckBox
    Friend WithEvents CopyRangePanel As Panel
    Friend WithEvents PartCopy As RadioButton
    Friend WithEvents AllCopy As RadioButton
    Friend WithEvents ProjectCostsCopyPanel As Panel
    Friend WithEvents ProjectCostsPartCopy As RadioButton
    Friend WithEvents ProjectCostsAllCopy As RadioButton
    Friend WithEvents FormSplitContainer As C1.Win.C1SplitContainer.C1SplitContainer
    Friend WithEvents MainPanel As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents FooterPanel As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents OK As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents FileOpenDialog As OpenFileDialog
End Class
