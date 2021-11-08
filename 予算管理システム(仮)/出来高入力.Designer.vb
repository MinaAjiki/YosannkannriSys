<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 出来高入力
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(出来高入力))
        Me.ButtonImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.Entry = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SystemTheme = New C1.Win.C1Themes.C1ThemeController()
        Me.Deadline = New C1.Win.C1Input.C1TextBox()
        Me.DetailsList = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Total = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.SearchSelect = New C1.Win.C1Input.C1ComboBox()
        Me.C1ComboBox1 = New C1.Win.C1Input.C1ComboBox()
        Me.VendorList = New C1.Win.C1Input.C1ComboBox()
        Me.DeadlineLabel = New System.Windows.Forms.Label()
        Me.FormSplitContainer = New C1.Win.C1SplitContainer.C1SplitContainer()
        Me.FormPanel = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.VendorNo = New C1.Win.C1Input.C1TextBox()
        Me.Unit3 = New System.Windows.Forms.Label()
        Me.Unit2 = New System.Windows.Forms.Label()
        Me.Unit1 = New System.Windows.Forms.Label()
        Me.FooterPanel = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.Cancel = New System.Windows.Forms.Button()
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Deadline, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailsList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Total, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1ComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FormSplitContainer.SuspendLayout()
        Me.FormPanel.SuspendLayout()
        CType(Me.VendorNo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FooterPanel.SuspendLayout()
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
        Me.ButtonImageList.Images.SetKeyName(4, "Entry_mousenter.png")
        Me.ButtonImageList.Images.SetKeyName(5, "Entry_mousedownpng.png")
        Me.ButtonImageList.Images.SetKeyName(6, "Cancel.png")
        Me.ButtonImageList.Images.SetKeyName(7, "Cancel_mouseenter.png")
        Me.ButtonImageList.Images.SetKeyName(8, "Cancel_mousedown.png")
        Me.ButtonImageList.Images.SetKeyName(9, "CreateCosts.png")
        Me.ButtonImageList.Images.SetKeyName(10, "CreateCosts_mouseenter.png")
        Me.ButtonImageList.Images.SetKeyName(11, "CreateCosts_mousedown.png")
        Me.ButtonImageList.Images.SetKeyName(12, "RevisionCosts.png")
        Me.ButtonImageList.Images.SetKeyName(13, "RevisionCosts_mouseenter.png")
        Me.ButtonImageList.Images.SetKeyName(14, "RevisionCosts_mousedown.png")
        Me.ButtonImageList.Images.SetKeyName(15, "CopyCosts.png")
        Me.ButtonImageList.Images.SetKeyName(16, "CopyCosts_mouseenter.png")
        Me.ButtonImageList.Images.SetKeyName(17, "CopyCosts_mousedown.png")
        Me.ButtonImageList.Images.SetKeyName(18, "Recalculation.png")
        Me.ButtonImageList.Images.SetKeyName(19, "Recalculation_mousenter.png")
        Me.ButtonImageList.Images.SetKeyName(20, "Recalculation_mousedown.png")
        '
        'Entry
        '
        Me.Entry.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Entry.FlatAppearance.BorderSize = 0
        Me.Entry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Entry.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Entry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Entry.ImageIndex = 3
        Me.Entry.ImageList = Me.ButtonImageList
        Me.Entry.Location = New System.Drawing.Point(772, 6)
        Me.Entry.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Entry.Name = "Entry"
        Me.Entry.Size = New System.Drawing.Size(100, 30)
        Me.Entry.TabIndex = 48
        Me.Entry.Text = "　登　録"
        Me.Entry.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Entry.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(14, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 18)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "<< 出来高入力"
        '
        'Deadline
        '
        Me.Deadline.BackColor = System.Drawing.Color.White
        Me.Deadline.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Deadline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Deadline.DataType = GetType(Long)
        Me.Deadline.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.Deadline.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.Deadline.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Deadline.Location = New System.Drawing.Point(807, 12)
        Me.Deadline.Name = "Deadline"
        Me.Deadline.Size = New System.Drawing.Size(171, 23)
        Me.Deadline.TabIndex = 65
        Me.Deadline.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.Deadline, "(default)")
        Me.Deadline.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'DetailsList
        '
        Me.DetailsList.AllowDelete = True
        Me.DetailsList.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.DetailsList.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Custom
        Me.DetailsList.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.DetailsList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DetailsList.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.DetailsList.ColumnInfo = resources.GetString("DetailsList.ColumnInfo")
        Me.DetailsList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.DetailsList.Location = New System.Drawing.Point(17, 83)
        Me.DetailsList.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.DetailsList.Name = "DetailsList"
        Me.DetailsList.Rows.Count = 25
        Me.DetailsList.Rows.Fixed = 3
        Me.DetailsList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DetailsList.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.DetailsList.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.DetailsList.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.DetailsList.Size = New System.Drawing.Size(841, 506)
        Me.DetailsList.StyleInfo = resources.GetString("DetailsList.StyleInfo")
        Me.DetailsList.TabIndex = 66
        Me.SystemTheme.SetTheme(Me.DetailsList, "予算管理テーマ")
        '
        'Total
        '
        Me.Total.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.Total.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.Total.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.Total.ColumnInfo = resources.GetString("Total.ColumnInfo")
        Me.Total.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Total.Location = New System.Drawing.Point(237, 594)
        Me.Total.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.Total.Name = "Total"
        Me.Total.Rows.Count = 1
        Me.Total.Rows.Fixed = 0
        Me.Total.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Total.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.Total.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.Total.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.Total.Size = New System.Drawing.Size(602, 25)
        Me.Total.StyleInfo = resources.GetString("Total.StyleInfo")
        Me.Total.TabIndex = 67
        Me.SystemTheme.SetTheme(Me.Total, "(default)")
        '
        'TotalLabel
        '
        Me.TotalLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.TotalLabel.Location = New System.Drawing.Point(198, 594)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(39, 25)
        Me.TotalLabel.TabIndex = 68
        Me.TotalLabel.Text = "合計"
        Me.TotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SystemTheme.SetTheme(Me.TotalLabel, "(default)")
        '
        'SearchSelect
        '
        Me.SearchSelect.AllowSpinLoop = False
        Me.SearchSelect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.SearchSelect.AutoSize = False
        Me.SearchSelect.BackColor = System.Drawing.Color.White
        Me.SearchSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SearchSelect.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.SearchSelect.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.SearchSelect.GapHeight = 0
        Me.SearchSelect.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.SearchSelect.Items.Add("正式名称で検索")
        Me.SearchSelect.Location = New System.Drawing.Point(0, 0)
        Me.SearchSelect.Name = "SearchSelect"
        Me.SearchSelect.Size = New System.Drawing.Size(200, 23)
        Me.SearchSelect.Style.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.SearchSelect.TabIndex = 0
        Me.SearchSelect.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.SearchSelect, "(default)")
        Me.SearchSelect.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'C1ComboBox1
        '
        Me.C1ComboBox1.AllowSpinLoop = False
        Me.C1ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.C1ComboBox1.AutoSize = False
        Me.C1ComboBox1.BackColor = System.Drawing.Color.White
        Me.C1ComboBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1ComboBox1.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.C1ComboBox1.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1ComboBox1.GapHeight = 0
        Me.C1ComboBox1.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1ComboBox1.Items.Add("正式名称で検索")
        Me.C1ComboBox1.Location = New System.Drawing.Point(0, 0)
        Me.C1ComboBox1.Name = "C1ComboBox1"
        Me.C1ComboBox1.Size = New System.Drawing.Size(200, 23)
        Me.C1ComboBox1.Style.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1ComboBox1.TabIndex = 0
        Me.C1ComboBox1.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.C1ComboBox1, "(default)")
        Me.C1ComboBox1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'VendorList
        '
        Me.VendorList.AllowSpinLoop = False
        Me.VendorList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.VendorList.AutoSize = False
        Me.VendorList.BackColor = System.Drawing.Color.White
        Me.VendorList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VendorList.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.VendorList.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.VendorList.GapHeight = 0
        Me.VendorList.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.VendorList.Items.Add("㈱市川工務店")
        Me.VendorList.Location = New System.Drawing.Point(112, 54)
        Me.VendorList.Name = "VendorList"
        Me.VendorList.Size = New System.Drawing.Size(200, 23)
        Me.VendorList.Style.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.VendorList.TabIndex = 72
        Me.VendorList.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.VendorList, "予算管理テーマ")
        Me.VendorList.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'DeadlineLabel
        '
        Me.DeadlineLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DeadlineLabel.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DeadlineLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DeadlineLabel.Location = New System.Drawing.Point(764, 12)
        Me.DeadlineLabel.Name = "DeadlineLabel"
        Me.DeadlineLabel.Size = New System.Drawing.Size(48, 23)
        Me.DeadlineLabel.TabIndex = 64
        Me.DeadlineLabel.Text = "締切日"
        Me.DeadlineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FormSplitContainer
        '
        Me.FormSplitContainer.AutoSizeElement = C1.Framework.AutoSizeElement.Both
        Me.FormSplitContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.FormSplitContainer.CollapsingAreaColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.FormSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSplitContainer.FixedLineColor = System.Drawing.Color.White
        Me.FormSplitContainer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.FormSplitContainer.HeaderHeight = 0
        Me.FormSplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.FormSplitContainer.Name = "FormSplitContainer"
        Me.FormSplitContainer.Panels.Add(Me.FormPanel)
        Me.FormSplitContainer.Panels.Add(Me.FooterPanel)
        Me.FormSplitContainer.Size = New System.Drawing.Size(990, 662)
        Me.FormSplitContainer.SplitterColor = System.Drawing.Color.White
        Me.FormSplitContainer.SplitterWidth = 1
        Me.FormSplitContainer.TabIndex = 50
        Me.FormSplitContainer.ToolTipGradient = C1.Win.C1SplitContainer.ToolTipGradient.Blue
        Me.FormSplitContainer.UseParentVisualStyle = False
        '
        'FormPanel
        '
        Me.FormPanel.BackColor = System.Drawing.Color.White
        Me.FormPanel.Controls.Add(Me.VendorNo)
        Me.FormPanel.Controls.Add(Me.VendorList)
        Me.FormPanel.Controls.Add(Me.Unit3)
        Me.FormPanel.Controls.Add(Me.Unit2)
        Me.FormPanel.Controls.Add(Me.Unit1)
        Me.FormPanel.Controls.Add(Me.TotalLabel)
        Me.FormPanel.Controls.Add(Me.Total)
        Me.FormPanel.Controls.Add(Me.DetailsList)
        Me.FormPanel.Controls.Add(Me.Deadline)
        Me.FormPanel.Controls.Add(Me.DeadlineLabel)
        Me.FormPanel.Height = 621
        Me.FormPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.FormPanel.Location = New System.Drawing.Point(0, 0)
        Me.FormPanel.Name = "FormPanel"
        Me.FormPanel.ResizeWhileDragging = True
        Me.FormPanel.Size = New System.Drawing.Size(990, 621)
        Me.FormPanel.SizeRatio = 93.949R
        Me.FormPanel.TabIndex = 0
        Me.FormPanel.Text = "パネル1"
        '
        'VendorNo
        '
        Me.VendorNo.BorderColor = System.Drawing.Color.Silver
        Me.VendorNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VendorNo.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.VendorNo.Location = New System.Drawing.Point(17, 54)
        Me.VendorNo.Name = "VendorNo"
        Me.VendorNo.Size = New System.Drawing.Size(89, 23)
        Me.VendorNo.TabIndex = 73
        Me.VendorNo.Tag = Nothing
        Me.VendorNo.Text = "9999999"
        Me.VendorNo.TextDetached = True
        Me.VendorNo.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Unit3
        '
        Me.Unit3.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Unit3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Unit3.Location = New System.Drawing.Point(876, 204)
        Me.Unit3.Name = "Unit3"
        Me.Unit3.Size = New System.Drawing.Size(38, 25)
        Me.Unit3.TabIndex = 71
        Me.Unit3.Text = "金額"
        Me.Unit3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Unit2
        '
        Me.Unit2.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Unit2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Unit2.Location = New System.Drawing.Point(876, 180)
        Me.Unit2.Name = "Unit2"
        Me.Unit2.Size = New System.Drawing.Size(38, 25)
        Me.Unit2.TabIndex = 70
        Me.Unit2.Text = "数量"
        Me.Unit2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Unit1
        '
        Me.Unit1.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Unit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Unit1.Location = New System.Drawing.Point(876, 156)
        Me.Unit1.Name = "Unit1"
        Me.Unit1.Size = New System.Drawing.Size(38, 25)
        Me.Unit1.TabIndex = 69
        Me.Unit1.Text = "単価"
        Me.Unit1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FooterPanel
        '
        Me.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.FooterPanel.Controls.Add(Me.Cancel)
        Me.FooterPanel.Controls.Add(Me.Entry)
        Me.FooterPanel.Height = 40
        Me.FooterPanel.Location = New System.Drawing.Point(0, 622)
        Me.FooterPanel.Name = "FooterPanel"
        Me.FooterPanel.Size = New System.Drawing.Size(990, 40)
        Me.FooterPanel.TabIndex = 1
        Me.FooterPanel.Text = "パネル2"
        '
        'Cancel
        '
        Me.Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancel.FlatAppearance.BorderSize = 0
        Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cancel.ImageIndex = 6
        Me.Cancel.ImageList = Me.ButtonImageList
        Me.Cancel.Location = New System.Drawing.Point(878, 6)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(100, 30)
        Me.Cancel.TabIndex = 49
        Me.Cancel.Text = "キャンセル"
        Me.Cancel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Cancel.UseVisualStyleBackColor = True
        '
        '出来高入力
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(990, 662)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FormSplitContainer)
        Me.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "出来高入力"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "出来高入力"
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Deadline, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailsList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Total, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1ComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FormSplitContainer.ResumeLayout(False)
        Me.FormPanel.ResumeLayout(False)
        CType(Me.VendorNo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FooterPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonImageList As ImageList
    Friend WithEvents Entry As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents SystemTheme As C1.Win.C1Themes.C1ThemeController
    Friend WithEvents FormSplitContainer As C1.Win.C1SplitContainer.C1SplitContainer
    Friend WithEvents FormPanel As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents FooterPanel As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents DeadlineLabel As Label
    Friend WithEvents Deadline As C1.Win.C1Input.C1TextBox
    Friend WithEvents DetailsList As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Total As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents TotalLabel As Label
    Friend WithEvents Unit3 As Label
    Friend WithEvents Unit2 As Label
    Friend WithEvents Unit1 As Label
    Friend WithEvents VendorList As C1.Win.C1Input.C1ComboBox
    Friend WithEvents SearchSelect As C1.Win.C1Input.C1ComboBox
    Friend WithEvents C1ComboBox1 As C1.Win.C1Input.C1ComboBox
    Friend WithEvents Cancel As Button
    Friend WithEvents VendorNo As C1.Win.C1Input.C1TextBox
End Class
