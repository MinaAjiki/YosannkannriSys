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
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FormSplitContainer = New C1.Win.C1SplitContainer.C1SplitContainer()
        Me.FormPanel = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.Total = New C1.Win.C1Input.C1NumericEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TotalList = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.DetailsList2 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DetailsList = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ChangeDetails = New C1.Win.C1Input.C1TextBox()
        Me.Contract_No = New System.Windows.Forms.Label()
        Me.SearchSelect = New C1.Win.C1Input.C1ComboBox()
        Me.FooterPanel = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.cancel = New System.Windows.Forms.Button()
        Me.SystemTheme = New C1.Win.C1Themes.C1ThemeController()
        Me.C1NumericEdit2 = New C1.Win.C1Input.C1NumericEdit()
        CType(Me.FormSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FormSplitContainer.SuspendLayout()
        Me.FormPanel.SuspendLayout()
        CType(Me.Total, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailsList2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailsList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChangeDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchSelect, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Button4.ImageIndex = 3
        Me.Button4.ImageList = Me.ButtonImageList
        Me.Button4.Location = New System.Drawing.Point(1046, 6)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 30)
        Me.Button4.TabIndex = 49
        Me.Button4.Text = "　登　録"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = True
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
        Me.FormPanel.Controls.Add(Me.Total)
        Me.FormPanel.Controls.Add(Me.Label4)
        Me.FormPanel.Controls.Add(Me.Label3)
        Me.FormPanel.Controls.Add(Me.TotalList)
        Me.FormPanel.Controls.Add(Me.DetailsList2)
        Me.FormPanel.Controls.Add(Me.Label1)
        Me.FormPanel.Controls.Add(Me.DetailsList)
        Me.FormPanel.Controls.Add(Me.ChangeDetails)
        Me.FormPanel.Controls.Add(Me.Contract_No)
        Me.FormPanel.Controls.Add(Me.SearchSelect)
        Me.FormPanel.Height = 643
        Me.FormPanel.Location = New System.Drawing.Point(0, 0)
        Me.FormPanel.Name = "FormPanel"
        Me.FormPanel.Size = New System.Drawing.Size(1264, 643)
        Me.FormPanel.SizeRatio = 94.46R
        Me.FormPanel.TabIndex = 0
        Me.FormPanel.Text = "パネル1"
        '
        'Total
        '
        Me.Total.AutoSize = False
        Me.Total.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Total.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.Total.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Total.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.Total.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.Total.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Total.GapHeight = 0
        Me.Total.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.Total.Location = New System.Drawing.Point(379, 594)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(95, 25)
        Me.Total.TabIndex = 79
        Me.Total.Tag = Nothing
        Me.Total.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.Total.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(341, 594)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 25)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "合計"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(1237, 594)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 18)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "　　"
        Me.SystemTheme.SetTheme(Me.Label3, "(default)")
        '
        'TotalList
        '
        Me.TotalList.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.TotalList.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.TotalList.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.TotalList.ColumnInfo = "10,0,0,0,0,-1,Columns:0{Width:95;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:95;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:95;}" & Global.Microsoft.VisualBasic.ChrW(9) & "3{Width:95;}" & Global.Microsoft.VisualBasic.ChrW(9) & "4{Width" &
    ":95;}" & Global.Microsoft.VisualBasic.ChrW(9) & "5{Width:95;}" & Global.Microsoft.VisualBasic.ChrW(9) & "6{Width:95;}" & Global.Microsoft.VisualBasic.ChrW(9) & "7{Width:95;}" & Global.Microsoft.VisualBasic.ChrW(9) & "8{Width:95;}" & Global.Microsoft.VisualBasic.ChrW(9) & "9{Width:95;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.TotalList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.TotalList.Location = New System.Drawing.Point(474, 593)
        Me.TotalList.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.TotalList.Name = "TotalList"
        Me.TotalList.Rows.Count = 1
        Me.TotalList.Rows.Fixed = 0
        Me.TotalList.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.TotalList.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.TotalList.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.TotalList.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.TotalList.Size = New System.Drawing.Size(763, 26)
        Me.TotalList.StyleInfo = resources.GetString("TotalList.StyleInfo")
        Me.TotalList.TabIndex = 76
        Me.SystemTheme.SetTheme(Me.TotalList, "(default)")
        '
        'DetailsList2
        '
        Me.DetailsList2.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.DetailsList2.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.DetailsList2.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.DetailsList2.ColumnInfo = resources.GetString("DetailsList2.ColumnInfo")
        Me.DetailsList2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.DetailsList2.Location = New System.Drawing.Point(474, 64)
        Me.DetailsList2.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.DetailsList2.Name = "DetailsList2"
        Me.DetailsList2.Rows.Count = 30
        Me.DetailsList2.Rows.Fixed = 3
        Me.DetailsList2.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.DetailsList2.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.DetailsList2.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.DetailsList2.Size = New System.Drawing.Size(782, 548)
        Me.DetailsList2.StyleInfo = resources.GetString("DetailsList2.StyleInfo")
        Me.DetailsList2.TabIndex = 75
        Me.SystemTheme.SetTheme(Me.DetailsList2, "(default)")
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(834, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "変更内容"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.DetailsList.Location = New System.Drawing.Point(12, 64)
        Me.DetailsList.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.DetailsList.Name = "DetailsList"
        Me.DetailsList.Rows.Count = 25
        Me.DetailsList.Rows.Fixed = 3
        Me.DetailsList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DetailsList.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.DetailsList.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.DetailsList.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.DetailsList.Size = New System.Drawing.Size(481, 530)
        Me.DetailsList.StyleInfo = resources.GetString("DetailsList.StyleInfo")
        Me.DetailsList.TabIndex = 71
        Me.SystemTheme.SetTheme(Me.DetailsList, "予算管理テーマ")
        '
        'ChangeDetails
        '
        Me.ChangeDetails.BackColor = System.Drawing.Color.White
        Me.ChangeDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ChangeDetails.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.ChangeDetails.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.ChangeDetails.Location = New System.Drawing.Point(894, 3)
        Me.ChangeDetails.Multiline = True
        Me.ChangeDetails.Name = "ChangeDetails"
        Me.ChangeDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ChangeDetails.Size = New System.Drawing.Size(362, 60)
        Me.ChangeDetails.TabIndex = 70
        Me.ChangeDetails.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.ChangeDetails, "予算管理テーマ")
        Me.ChangeDetails.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Contract_No
        '
        Me.Contract_No.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Contract_No.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Contract_No.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Contract_No.Location = New System.Drawing.Point(12, 45)
        Me.Contract_No.Name = "Contract_No"
        Me.Contract_No.Size = New System.Drawing.Size(60, 20)
        Me.Contract_No.TabIndex = 52
        Me.Contract_No.Text = "契約回数"
        Me.Contract_No.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.SearchSelect.Items.Add("カナ名称で検索")
        Me.SearchSelect.Location = New System.Drawing.Point(68, 45)
        Me.SearchSelect.Name = "SearchSelect"
        Me.SearchSelect.Size = New System.Drawing.Size(147, 20)
        Me.SearchSelect.Style.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.SearchSelect.TabIndex = 68
        Me.SearchSelect.Tag = Nothing
        Me.SearchSelect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SystemTheme.SetTheme(Me.SearchSelect, "予算管理テーマ")
        Me.SearchSelect.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'FooterPanel
        '
        Me.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.FooterPanel.Controls.Add(Me.cancel)
        Me.FooterPanel.Controls.Add(Me.Button4)
        Me.FooterPanel.Height = 40
        Me.FooterPanel.Location = New System.Drawing.Point(0, 644)
        Me.FooterPanel.Name = "FooterPanel"
        Me.FooterPanel.Size = New System.Drawing.Size(1264, 40)
        Me.FooterPanel.TabIndex = 1
        Me.FooterPanel.Text = "パネル2"
        '
        'cancel
        '
        Me.cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancel.FlatAppearance.BorderSize = 0
        Me.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancel.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.cancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.cancel.ImageIndex = 6
        Me.cancel.ImageList = Me.ButtonImageList
        Me.cancel.Location = New System.Drawing.Point(1152, 6)
        Me.cancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(100, 30)
        Me.cancel.TabIndex = 50
        Me.cancel.Text = "キャンセル"
        Me.cancel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.cancel.UseVisualStyleBackColor = True
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
        Me.FormPanel.PerformLayout()
        CType(Me.Total, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailsList2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailsList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChangeDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchSelect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FooterPanel.ResumeLayout(False)
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonImageList As ImageList
    Friend WithEvents Button4 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents FormSplitContainer As C1.Win.C1SplitContainer.C1SplitContainer
    Friend WithEvents FormPanel As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents FooterPanel As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents SearchSelect As C1.Win.C1Input.C1ComboBox
    Friend WithEvents SystemTheme As C1.Win.C1Themes.C1ThemeController
    Friend WithEvents Contract_No As Label
    Friend WithEvents ChangeDetails As C1.Win.C1Input.C1TextBox
    Friend WithEvents DetailsList As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label1 As Label
    Friend WithEvents cancel As Button
    Friend WithEvents Total As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TotalList As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents DetailsList2 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1NumericEdit2 As C1.Win.C1Input.C1NumericEdit
End Class
