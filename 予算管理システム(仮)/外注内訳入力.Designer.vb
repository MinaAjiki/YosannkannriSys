<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 外注内訳入力
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(外注内訳入力))
        Me.ButtonImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.Entry = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FormSplitContainer = New C1.Win.C1SplitContainer.C1SplitContainer()
        Me.FormPanel = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TotalBreakdown = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.CreatedDateBox = New C1.Win.C1Input.C1TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContractNo = New C1.Win.C1Input.C1NumericEdit()
        Me.TotalBox = New C1.Win.C1Input.C1NumericEdit()
        Me.Breakdown = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ChangeDetailLabel = New System.Windows.Forms.Label()
        Me.DetailList = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ChangeDetail = New C1.Win.C1Input.C1TextBox()
        Me.ContractNoLabel = New System.Windows.Forms.Label()
        Me.FooterPanel = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.Create = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.SystemTheme = New C1.Win.C1Themes.C1ThemeController()
        Me.C1NumericEdit2 = New C1.Win.C1Input.C1NumericEdit()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.FormSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FormSplitContainer.SuspendLayout()
        Me.FormPanel.SuspendLayout()
        CType(Me.TotalBreakdown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreatedDateBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContractNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Breakdown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChangeDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FooterPanel.SuspendLayout()
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Entry.Location = New System.Drawing.Point(1046, 6)
        Me.Entry.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Entry.Name = "Entry"
        Me.Entry.Size = New System.Drawing.Size(100, 30)
        Me.Entry.TabIndex = 49
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
        Me.Label2.Size = New System.Drawing.Size(104, 18)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "<< 外注内訳入力"
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
        Me.FormSplitContainer.Size = New System.Drawing.Size(1264, 684)
        Me.FormSplitContainer.SplitterColor = System.Drawing.Color.White
        Me.FormSplitContainer.SplitterWidth = 1
        Me.FormSplitContainer.TabIndex = 51
        Me.FormSplitContainer.ToolTipGradient = C1.Win.C1SplitContainer.ToolTipGradient.Blue
        Me.FormSplitContainer.UseParentVisualStyle = False
        '
        'FormPanel
        '
        Me.FormPanel.BackColor = System.Drawing.Color.White
        Me.FormPanel.Controls.Add(Me.Label4)
        Me.FormPanel.Controls.Add(Me.TotalBreakdown)
        Me.FormPanel.Controls.Add(Me.CreatedDateBox)
        Me.FormPanel.Controls.Add(Me.Label1)
        Me.FormPanel.Controls.Add(Me.ContractNo)
        Me.FormPanel.Controls.Add(Me.TotalBox)
        Me.FormPanel.Controls.Add(Me.Breakdown)
        Me.FormPanel.Controls.Add(Me.ChangeDetailLabel)
        Me.FormPanel.Controls.Add(Me.DetailList)
        Me.FormPanel.Controls.Add(Me.ChangeDetail)
        Me.FormPanel.Controls.Add(Me.ContractNoLabel)
        Me.FormPanel.Height = 643
        Me.FormPanel.Location = New System.Drawing.Point(0, 0)
        Me.FormPanel.Name = "FormPanel"
        Me.FormPanel.Size = New System.Drawing.Size(1264, 643)
        Me.FormPanel.SizeRatio = 94.46R
        Me.FormPanel.TabIndex = 0
        Me.FormPanel.Text = "パネル1"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(339, 595)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 26)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "合計"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TotalBreakdown
        '
        Me.TotalBreakdown.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.TotalBreakdown.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.TotalBreakdown.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.TotalBreakdown.ColumnInfo = "8,0,0,0,0,110,Columns:0{Width:95;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:110;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:110;}" & Global.Microsoft.VisualBasic.ChrW(9) & "3{Width:110;}" & Global.Microsoft.VisualBasic.ChrW(9) & "4{Wi" &
    "dth:110;}" & Global.Microsoft.VisualBasic.ChrW(9) & "5{Width:110;}" & Global.Microsoft.VisualBasic.ChrW(9) & "6{Width:110;}" & Global.Microsoft.VisualBasic.ChrW(9) & "7{Width:110;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.TotalBreakdown.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.TotalBreakdown.Location = New System.Drawing.Point(376, 595)
        Me.TotalBreakdown.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.TotalBreakdown.Name = "TotalBreakdown"
        Me.TotalBreakdown.Rows.Count = 1
        Me.TotalBreakdown.Rows.Fixed = 0
        Me.TotalBreakdown.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TotalBreakdown.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.TotalBreakdown.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.TotalBreakdown.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.TotalBreakdown.Size = New System.Drawing.Size(865, 26)
        Me.TotalBreakdown.StyleInfo = resources.GetString("TotalBreakdown.StyleInfo")
        Me.TotalBreakdown.TabIndex = 76
        Me.SystemTheme.SetTheme(Me.TotalBreakdown, "(default)")
        '
        'CreatedDateBox
        '
        Me.CreatedDateBox.AutoSize = False
        Me.CreatedDateBox.BackColor = System.Drawing.Color.White
        Me.CreatedDateBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CreatedDateBox.DataType = GetType(Object)
        Me.CreatedDateBox.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.CreatedDateBox.EditMask = "####年##月##日"
        Me.CreatedDateBox.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.CreatedDateBox.Location = New System.Drawing.Point(678, 3)
        Me.CreatedDateBox.Name = "CreatedDateBox"
        Me.CreatedDateBox.Size = New System.Drawing.Size(146, 20)
        Me.CreatedDateBox.TabIndex = 83
        Me.CreatedDateBox.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.CreatedDateBox, "予算管理テーマ")
        Me.CreatedDateBox.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(579, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 20)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "変更計画作成日"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ContractNo
        '
        Me.ContractNo.AutoSize = False
        Me.ContractNo.BackColor = System.Drawing.Color.White
        Me.ContractNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.ContractNo.Calculator.BackColor = System.Drawing.Color.White
        Me.ContractNo.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.ContractNo.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.ContractNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ContractNo.DataType = GetType(Long)
        Me.ContractNo.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.ContractNo.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.ContractNo.GapHeight = 0
        Me.ContractNo.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.ContractNo.Location = New System.Drawing.Point(72, 44)
        Me.ContractNo.Name = "ContractNo"
        Me.ContractNo.Size = New System.Drawing.Size(83, 20)
        Me.ContractNo.TabIndex = 81
        Me.ContractNo.Tag = Nothing
        Me.ContractNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SystemTheme.SetTheme(Me.ContractNo, "予算管理テーマ")
        Me.ContractNo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown
        Me.ContractNo.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'TotalBox
        '
        Me.TotalBox.AutoSize = False
        Me.TotalBox.BackColor = System.Drawing.Color.White
        Me.TotalBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.TotalBox.Calculator.BackColor = System.Drawing.Color.White
        Me.TotalBox.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.TotalBox.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.TotalBox.DataType = GetType(Long)
        Me.TotalBox.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.TotalBox.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.TotalBox.DisplayFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.TotalBox.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.TotalBox.GapHeight = 0
        Me.TotalBox.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.TotalBox.Location = New System.Drawing.Point(8, 601)
        Me.TotalBox.Name = "TotalBox"
        Me.TotalBox.ReadOnly = True
        Me.TotalBox.Size = New System.Drawing.Size(110, 20)
        Me.TotalBox.TabIndex = 79
        Me.TotalBox.Tag = Nothing
        Me.TotalBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SystemTheme.SetTheme(Me.TotalBox, "予算管理テーマ")
        Me.TotalBox.Visible = False
        Me.TotalBox.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.TotalBox.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Breakdown
        '
        Me.Breakdown.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.Breakdown.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.Breakdown.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Breakdown.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.Breakdown.ColumnInfo = resources.GetString("Breakdown.ColumnInfo")
        Me.Breakdown.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Breakdown.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.Breakdown.Location = New System.Drawing.Point(470, 64)
        Me.Breakdown.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.Breakdown.Name = "Breakdown"
        Me.Breakdown.Rows.Count = 3
        Me.Breakdown.Rows.Fixed = 3
        Me.Breakdown.ScrollOptions = CType((C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible Or C1.Win.C1FlexGrid.ScrollFlags.ScrollByRowColumn), C1.Win.C1FlexGrid.ScrollFlags)
        Me.Breakdown.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.Breakdown.ShowCellLabels = True
        Me.Breakdown.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.Breakdown.Size = New System.Drawing.Size(791, 576)
        Me.Breakdown.StyleInfo = resources.GetString("Breakdown.StyleInfo")
        Me.Breakdown.TabIndex = 75
        Me.SystemTheme.SetTheme(Me.Breakdown, "予算管理テーマ2")
        '
        'ChangeDetailLabel
        '
        Me.ChangeDetailLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ChangeDetailLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChangeDetailLabel.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ChangeDetailLabel.Location = New System.Drawing.Point(834, 3)
        Me.ChangeDetailLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.ChangeDetailLabel.Name = "ChangeDetailLabel"
        Me.ChangeDetailLabel.Size = New System.Drawing.Size(60, 20)
        Me.ChangeDetailLabel.TabIndex = 74
        Me.ChangeDetailLabel.Text = "変更内容"
        Me.ChangeDetailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DetailList
        '
        Me.DetailList.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.DetailList.AllowEditing = False
        Me.DetailList.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Custom
        Me.DetailList.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.DetailList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DetailList.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.DetailList.ColumnInfo = resources.GetString("DetailList.ColumnInfo")
        Me.DetailList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.DetailList.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.DetailList.Location = New System.Drawing.Point(12, 64)
        Me.DetailList.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.DetailList.Name = "DetailList"
        Me.DetailList.Rows.Count = 3
        Me.DetailList.Rows.Fixed = 3
        Me.DetailList.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DetailList.ScrollOptions = CType((C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible Or C1.Win.C1FlexGrid.ScrollFlags.ScrollByRowColumn), C1.Win.C1FlexGrid.ScrollFlags)
        Me.DetailList.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.DetailList.ShowCellLabels = True
        Me.DetailList.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.DetailList.Size = New System.Drawing.Size(481, 532)
        Me.DetailList.StyleInfo = resources.GetString("DetailList.StyleInfo")
        Me.DetailList.TabIndex = 71
        Me.SystemTheme.SetTheme(Me.DetailList, "予算管理テーマ2")
        '
        'ChangeDetail
        '
        Me.ChangeDetail.BackColor = System.Drawing.Color.White
        Me.ChangeDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ChangeDetail.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.ChangeDetail.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.ChangeDetail.Location = New System.Drawing.Point(894, 3)
        Me.ChangeDetail.Multiline = True
        Me.ChangeDetail.Name = "ChangeDetail"
        Me.ChangeDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ChangeDetail.Size = New System.Drawing.Size(362, 60)
        Me.ChangeDetail.TabIndex = 70
        Me.ChangeDetail.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.ChangeDetail, "予算管理テーマ")
        Me.ChangeDetail.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'ContractNoLabel
        '
        Me.ContractNoLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ContractNoLabel.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ContractNoLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ContractNoLabel.Location = New System.Drawing.Point(12, 44)
        Me.ContractNoLabel.Name = "ContractNoLabel"
        Me.ContractNoLabel.Size = New System.Drawing.Size(60, 20)
        Me.ContractNoLabel.TabIndex = 52
        Me.ContractNoLabel.Text = "変更回数"
        Me.ContractNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FooterPanel
        '
        Me.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.FooterPanel.Controls.Add(Me.Create)
        Me.FooterPanel.Controls.Add(Me.Cancel)
        Me.FooterPanel.Controls.Add(Me.Entry)
        Me.FooterPanel.Height = 40
        Me.FooterPanel.Location = New System.Drawing.Point(0, 644)
        Me.FooterPanel.Name = "FooterPanel"
        Me.FooterPanel.Size = New System.Drawing.Size(1264, 40)
        Me.FooterPanel.TabIndex = 1
        Me.FooterPanel.Text = "パネル2"
        '
        'Create
        '
        Me.Create.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Create.FlatAppearance.BorderSize = 0
        Me.Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Create.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Create.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Create.ImageIndex = 0
        Me.Create.ImageList = Me.ButtonImageList
        Me.Create.Location = New System.Drawing.Point(940, 6)
        Me.Create.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Create.Name = "Create"
        Me.Create.Size = New System.Drawing.Size(100, 30)
        Me.Create.TabIndex = 51
        Me.Create.Text = "作　成"
        Me.Create.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Create.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancel.FlatAppearance.BorderSize = 0
        Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Cancel.ImageIndex = 6
        Me.Cancel.ImageList = Me.ButtonImageList
        Me.Cancel.Location = New System.Drawing.Point(1152, 6)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(100, 30)
        Me.Cancel.TabIndex = 50
        Me.Cancel.Text = "キャンセル"
        Me.Cancel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'C1NumericEdit2
        '
        Me.C1NumericEdit2.AutoSize = False
        Me.C1NumericEdit2.BackColor = System.Drawing.Color.White
        Me.C1NumericEdit2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.C1NumericEdit2.Calculator.BackColor = System.Drawing.Color.White
        Me.C1NumericEdit2.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1NumericEdit2.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1NumericEdit2.DataType = GetType(Long)
        Me.C1NumericEdit2.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.C1NumericEdit2.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.C1NumericEdit2.GapHeight = 0
        Me.C1NumericEdit2.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NumericEdit2.Location = New System.Drawing.Point(189, 8)
        Me.C1NumericEdit2.Name = "C1NumericEdit2"
        Me.C1NumericEdit2.Size = New System.Drawing.Size(95, 20)
        Me.C1NumericEdit2.TabIndex = 75
        Me.C1NumericEdit2.Tag = Nothing
        Me.C1NumericEdit2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SystemTheme.SetTheme(Me.C1NumericEdit2, "(default)")
        Me.C1NumericEdit2.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.C1NumericEdit2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        '
        '外注内訳入力
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1264, 684)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FormSplitContainer)
        Me.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "外注内訳入力"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "外注内訳入力"
        CType(Me.FormSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FormSplitContainer.ResumeLayout(False)
        Me.FormPanel.ResumeLayout(False)
        CType(Me.TotalBreakdown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreatedDateBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContractNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Breakdown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChangeDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FooterPanel.ResumeLayout(False)
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonImageList As ImageList
    Friend WithEvents Entry As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents FormSplitContainer As C1.Win.C1SplitContainer.C1SplitContainer
    Friend WithEvents FormPanel As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents FooterPanel As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents SystemTheme As C1.Win.C1Themes.C1ThemeController
    Friend WithEvents ContractNoLabel As Label
    Friend WithEvents ChangeDetail As C1.Win.C1Input.C1TextBox
    Friend WithEvents DetailList As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents ChangeDetailLabel As Label
    Friend WithEvents Cancel As Button
    Friend WithEvents TotalBox As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label4 As Label
    Friend WithEvents TotalBreakdown As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Breakdown As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1NumericEdit2 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents ContractNo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents CreatedDateBox As C1.Win.C1Input.C1TextBox
    Friend WithEvents Create As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
