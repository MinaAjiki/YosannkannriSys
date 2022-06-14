<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 代価一覧
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(代価一覧))
        Me.ButtonImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.SystemTheme = New C1.Win.C1Themes.C1ThemeController()
        Me.FormContainer = New C1.Win.C1SplitContainer.C1SplitContainer()
        Me.MainPanel = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.YearList = New C1.Win.C1Input.C1ComboBox()
        Me.CostList = New C1.Win.C1Input.C1ComboBox()
        Me.SearchName = New C1.Win.C1FlexGrid.C1FlexGridSearchPanel()
        Me.NameLabel = New C1.Win.C1Input.C1TextBox()
        Me.HeadLine = New System.Windows.Forms.Label()
        Me.ProjectCostList = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.FooterPanel = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.CostCreation = New System.Windows.Forms.Button()
        Me.CostModify = New System.Windows.Forms.Button()
        Me.CostCopy = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Entry = New System.Windows.Forms.Button()
        Me.右クリックメニュー = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CostCreateMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CostModifyMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CostCopyMenu = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FormContainer.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        CType(Me.YearList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NameLabel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectCostList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FooterPanel.SuspendLayout()
        Me.右クリックメニュー.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonImageList
        '
        Me.ButtonImageList.ImageStream = CType(resources.GetObject("ButtonImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ButtonImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ButtonImageList.Images.SetKeyName(0, "Default.png")
        Me.ButtonImageList.Images.SetKeyName(1, "Default_mouseenter.png")
        Me.ButtonImageList.Images.SetKeyName(2, "Default_mousedown.png")
        Me.ButtonImageList.Images.SetKeyName(3, "Entry.png")
        Me.ButtonImageList.Images.SetKeyName(4, "Entry_mouseenter.png")
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
        'SystemTheme
        '
        Me.SystemTheme.Theme = "(none)"
        '
        'FormContainer
        '
        Me.FormContainer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FormContainer.AutoSizeElement = C1.Framework.AutoSizeElement.Both
        Me.FormContainer.BackColor = System.Drawing.Color.White
        Me.FormContainer.CollapsingAreaColor = System.Drawing.Color.GhostWhite
        Me.FormContainer.CollapsingCueColor = System.Drawing.Color.White
        Me.FormContainer.FixedLineColor = System.Drawing.Color.White
        Me.FormContainer.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.FormContainer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.FormContainer.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.FormContainer.HeaderHeight = 0
        Me.FormContainer.Location = New System.Drawing.Point(0, 2)
        Me.FormContainer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FormContainer.Name = "FormContainer"
        Me.FormContainer.Panels.Add(Me.MainPanel)
        Me.FormContainer.Panels.Add(Me.FooterPanel)
        Me.FormContainer.Size = New System.Drawing.Size(949, 659)
        Me.FormContainer.SplitterColor = System.Drawing.Color.White
        Me.FormContainer.SplitterMovingColor = System.Drawing.Color.Black
        Me.FormContainer.SplitterWidth = 0
        Me.FormContainer.TabIndex = 0
        Me.SystemTheme.SetTheme(Me.FormContainer, "予算管理テーマ")
        Me.FormContainer.UseParentVisualStyle = False
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.Transparent
        Me.MainPanel.Controls.Add(Me.YearList)
        Me.MainPanel.Controls.Add(Me.CostList)
        Me.MainPanel.Controls.Add(Me.SearchName)
        Me.MainPanel.Controls.Add(Me.NameLabel)
        Me.MainPanel.Controls.Add(Me.HeadLine)
        Me.MainPanel.Controls.Add(Me.ProjectCostList)
        Me.MainPanel.Height = 619
        Me.MainPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainPanel.MinHeight = 0
        Me.MainPanel.MinWidth = 0
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(949, 619)
        Me.MainPanel.SizeRatio = 93.93R
        Me.MainPanel.TabIndex = 0
        Me.MainPanel.Text = "パネル1"
        Me.MainPanel.Width = 949
        '
        'YearList
        '
        Me.YearList.AllowSpinLoop = False
        Me.YearList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.YearList.AutoSize = False
        Me.YearList.BackColor = System.Drawing.Color.White
        Me.YearList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.YearList.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.YearList.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.YearList.GapHeight = 0
        Me.YearList.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.YearList.Location = New System.Drawing.Point(146, 52)
        Me.YearList.Name = "YearList"
        Me.YearList.Size = New System.Drawing.Size(111, 23)
        Me.YearList.Style.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.YearList.TabIndex = 66
        Me.YearList.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.YearList, "予算管理テーマ")
        Me.YearList.Visible = False
        Me.YearList.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'CostList
        '
        Me.CostList.AllowSpinLoop = False
        Me.CostList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.CostList.AutoSize = False
        Me.CostList.BackColor = System.Drawing.Color.White
        Me.CostList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CostList.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.CostList.Enabled = False
        Me.CostList.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.CostList.GapHeight = 0
        Me.CostList.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.CostList.Location = New System.Drawing.Point(29, 52)
        Me.CostList.Name = "CostList"
        Me.CostList.Size = New System.Drawing.Size(111, 23)
        Me.CostList.Style.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.CostList.TabIndex = 65
        Me.CostList.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.CostList, "予算管理テーマ")
        Me.CostList.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'SearchName
        '
        Me.SearchName.BackColor = System.Drawing.Color.Transparent
        Me.SearchName.Location = New System.Drawing.Point(649, 44)
        Me.SearchName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchName.Name = "SearchName"
        Me.SearchName.ShowClearButton = False
        Me.SearchName.Size = New System.Drawing.Size(269, 31)
        Me.SearchName.TabIndex = 64
        Me.SystemTheme.SetTheme(Me.SearchName, "予算管理テーマ")
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = False
        Me.NameLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.NameLabel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.NameLabel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NameLabel.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.NameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.NameLabel.Location = New System.Drawing.Point(591, 48)
        Me.NameLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(59, 23)
        Me.NameLabel.TabIndex = 61
        Me.NameLabel.Tag = Nothing
        Me.NameLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NameLabel.Value = "名称検索"
        Me.NameLabel.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        '
        'HeadLine
        '
        Me.HeadLine.AutoSize = True
        Me.HeadLine.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.HeadLine.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.HeadLine.Location = New System.Drawing.Point(14, 14)
        Me.HeadLine.Name = "HeadLine"
        Me.HeadLine.Size = New System.Drawing.Size(76, 18)
        Me.HeadLine.TabIndex = 58
        Me.HeadLine.Text = "<<代価一覧"
        '
        'ProjectCostList
        '
        Me.ProjectCostList.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.ProjectCostList.AllowFiltering = True
        Me.ProjectCostList.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.ProjectCostList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ProjectCostList.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.ProjectCostList.ColumnInfo = resources.GetString("ProjectCostList.ColumnInfo")
        Me.ProjectCostList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ProjectCostList.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.ProjectCostList.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.ProjectCostList.Location = New System.Drawing.Point(29, 78)
        Me.ProjectCostList.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.ProjectCostList.Name = "ProjectCostList"
        Me.ProjectCostList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ProjectCostList.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.ProjectCostList.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.ProjectCostList.ShowFilterIcon = C1.Win.C1FlexGrid.FilterIconVisibility.Always
        Me.ProjectCostList.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.ProjectCostList.Size = New System.Drawing.Size(889, 532)
        Me.ProjectCostList.StyleInfo = resources.GetString("ProjectCostList.StyleInfo")
        Me.ProjectCostList.TabIndex = 60
        Me.SystemTheme.SetTheme(Me.ProjectCostList, "予算管理テーマ")
        '
        'FooterPanel
        '
        Me.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.FooterPanel.Controls.Add(Me.CostCreation)
        Me.FooterPanel.Controls.Add(Me.CostModify)
        Me.FooterPanel.Controls.Add(Me.CostCopy)
        Me.FooterPanel.Controls.Add(Me.Cancel)
        Me.FooterPanel.Controls.Add(Me.Entry)
        Me.FooterPanel.Height = 40
        Me.FooterPanel.Location = New System.Drawing.Point(0, 619)
        Me.FooterPanel.Name = "FooterPanel"
        Me.FooterPanel.Size = New System.Drawing.Size(949, 40)
        Me.FooterPanel.TabIndex = 1
        Me.FooterPanel.Text = "パネル2"
        Me.FooterPanel.Width = 949
        '
        'CostCreation
        '
        Me.CostCreation.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CostCreation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CostCreation.FlatAppearance.BorderSize = 0
        Me.CostCreation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CostCreation.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CostCreation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.CostCreation.ImageIndex = 9
        Me.CostCreation.ImageList = Me.ButtonImageList
        Me.CostCreation.Location = New System.Drawing.Point(8, 6)
        Me.CostCreation.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.CostCreation.Name = "CostCreation"
        Me.CostCreation.Size = New System.Drawing.Size(100, 30)
        Me.CostCreation.TabIndex = 65
        Me.CostCreation.Text = "　代価作成"
        Me.CostCreation.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CostCreation.UseVisualStyleBackColor = True
        '
        'CostModify
        '
        Me.CostModify.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CostModify.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CostModify.FlatAppearance.BorderSize = 0
        Me.CostModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CostModify.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CostModify.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.CostModify.ImageIndex = 12
        Me.CostModify.ImageList = Me.ButtonImageList
        Me.CostModify.Location = New System.Drawing.Point(214, 6)
        Me.CostModify.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.CostModify.Name = "CostModify"
        Me.CostModify.Size = New System.Drawing.Size(100, 30)
        Me.CostModify.TabIndex = 64
        Me.CostModify.Text = "　代価修正"
        Me.CostModify.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CostModify.UseVisualStyleBackColor = True
        Me.CostModify.Visible = False
        '
        'CostCopy
        '
        Me.CostCopy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CostCopy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CostCopy.FlatAppearance.BorderSize = 0
        Me.CostCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CostCopy.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CostCopy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.CostCopy.ImageIndex = 15
        Me.CostCopy.ImageList = Me.ButtonImageList
        Me.CostCopy.Location = New System.Drawing.Point(111, 6)
        Me.CostCopy.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.CostCopy.Name = "CostCopy"
        Me.CostCopy.Size = New System.Drawing.Size(100, 30)
        Me.CostCopy.TabIndex = 63
        Me.CostCopy.Text = "　　代価コピー"
        Me.CostCopy.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CostCopy.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Cancel.FlatAppearance.BorderSize = 0
        Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Cancel.ImageIndex = 6
        Me.Cancel.ImageList = Me.ButtonImageList
        Me.Cancel.Location = New System.Drawing.Point(840, 6)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(0)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(100, 30)
        Me.Cancel.TabIndex = 62
        Me.Cancel.Text = "キャンセル"
        Me.Cancel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Entry
        '
        Me.Entry.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Entry.FlatAppearance.BorderSize = 0
        Me.Entry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Entry.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Entry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Entry.ImageIndex = 3
        Me.Entry.ImageList = Me.ButtonImageList
        Me.Entry.Location = New System.Drawing.Point(737, 6)
        Me.Entry.Margin = New System.Windows.Forms.Padding(0)
        Me.Entry.Name = "Entry"
        Me.Entry.Size = New System.Drawing.Size(100, 30)
        Me.Entry.TabIndex = 61
        Me.Entry.Text = "　登 録"
        Me.Entry.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Entry.UseVisualStyleBackColor = True
        '
        '右クリックメニュー
        '
        Me.右クリックメニュー.BackColor = System.Drawing.Color.White
        Me.右クリックメニュー.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.右クリックメニュー.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.右クリックメニュー.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyMenu})
        Me.右クリックメニュー.Name = "ContextMenuStrip1"
        Me.右クリックメニュー.ShowImageMargin = False
        Me.右クリックメニュー.Size = New System.Drawing.Size(160, 48)
        Me.右クリックメニュー.Text = "項目選択"
        Me.SystemTheme.SetTheme(Me.右クリックメニュー, "(default)")
        '
        'CopyMenu
        '
        Me.CopyMenu.Name = "CopyMenu"
        Me.CopyMenu.Size = New System.Drawing.Size(159, 22)
        Me.CopyMenu.Text = "コピーして貼り付け"
        '
        'CostCreateMenu
        '
        Me.CostCreateMenu.Name = "CostCreateMenu"
        Me.CostCreateMenu.Size = New System.Drawing.Size(170, 22)
        Me.CostCreateMenu.Text = "代価表作成"
        '
        'CostModifyMenu
        '
        Me.CostModifyMenu.Name = "CostModifyMenu"
        Me.CostModifyMenu.Size = New System.Drawing.Size(170, 22)
        Me.CostModifyMenu.Text = "代価表修正"
        '
        'CostCopyMenu
        '
        Me.CostCopyMenu.Name = "CostCopyMenu"
        Me.CostCopyMenu.Size = New System.Drawing.Size(170, 22)
        Me.CostCopyMenu.Text = "代価表コピー"
        '
        '代価一覧
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(948, 661)
        Me.Controls.Add(Me.FormContainer)
        Me.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "代価一覧"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "代価一覧"
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FormContainer.ResumeLayout(False)
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanel.PerformLayout()
        CType(Me.YearList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NameLabel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectCostList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FooterPanel.ResumeLayout(False)
        Me.右クリックメニュー.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents ButtonImageList As ImageList
    Friend WithEvents SystemTheme As C1.Win.C1Themes.C1ThemeController
    Friend WithEvents FormContainer As C1.Win.C1SplitContainer.C1SplitContainer
    Friend WithEvents MainPanel As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents FooterPanel As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents HeadLine As Label
    Friend WithEvents ProjectCostList As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Cancel As Button
    Friend WithEvents Entry As Button
    Friend WithEvents NameLabel As C1.Win.C1Input.C1TextBox
    Friend WithEvents SearchName As C1.Win.C1FlexGrid.C1FlexGridSearchPanel
    Friend WithEvents CostList As C1.Win.C1Input.C1ComboBox
    Friend WithEvents CostCopy As Button
    Friend WithEvents CostModify As Button
    Friend WithEvents 右クリックメニュー As ContextMenuStrip
    Friend WithEvents CopyMenu As ToolStripMenuItem
    Friend WithEvents CostCreateMenu As ToolStripMenuItem
    Friend WithEvents CostModifyMenu As ToolStripMenuItem
    Friend WithEvents CostCopyMenu As ToolStripMenuItem
    Friend WithEvents CostCreation As Button
    Friend WithEvents YearList As C1.Win.C1Input.C1ComboBox
End Class
