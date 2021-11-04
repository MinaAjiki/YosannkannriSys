<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 小工種選択
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(小工種選択))
        Me.HeadLine = New System.Windows.Forms.Label()
        Me.ButtonImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.S_WorkTypesList = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.SystemTheme = New C1.Win.C1Themes.C1ThemeController()
        Me.C1TextBox1 = New C1.Win.C1Input.C1TextBox()
        Me.C1NumericEdit1 = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NumericEdit2 = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NumericEdit3 = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NumericEdit4 = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NumericEdit5 = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NumericEdit6 = New C1.Win.C1Input.C1NumericEdit()
        Me.FormSplitContainer = New C1.Win.C1SplitContainer.C1SplitContainer()
        Me.C1SplitterPanel1 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.C1SplitterPanel2 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Entry = New System.Windows.Forms.Button()
        CType(Me.S_WorkTypesList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FormSplitContainer.SuspendLayout()
        Me.C1SplitterPanel1.SuspendLayout()
        Me.C1SplitterPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'HeadLine
        '
        Me.HeadLine.AutoSize = True
        Me.HeadLine.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.HeadLine.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.HeadLine.Location = New System.Drawing.Point(14, 14)
        Me.HeadLine.Name = "HeadLine"
        Me.HeadLine.Size = New System.Drawing.Size(92, 18)
        Me.HeadLine.TabIndex = 25
        Me.HeadLine.Text = "<< 小工種選択"
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
        'S_WorkTypesList
        '
        Me.S_WorkTypesList.AllowAddNew = True
        Me.S_WorkTypesList.AllowDelete = True
        Me.S_WorkTypesList.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.S_WorkTypesList.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.S_WorkTypesList.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.S_WorkTypesList.ColumnInfo = resources.GetString("S_WorkTypesList.ColumnInfo")
        Me.S_WorkTypesList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.S_WorkTypesList.Location = New System.Drawing.Point(37, 75)
        Me.S_WorkTypesList.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.S_WorkTypesList.Name = "S_WorkTypesList"
        Me.S_WorkTypesList.Rows.Count = 25
        Me.S_WorkTypesList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.S_WorkTypesList.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.S_WorkTypesList.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.S_WorkTypesList.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.S_WorkTypesList.Size = New System.Drawing.Size(918, 505)
        Me.S_WorkTypesList.StyleInfo = resources.GetString("S_WorkTypesList.StyleInfo")
        Me.S_WorkTypesList.TabIndex = 43
        Me.SystemTheme.SetTheme(Me.S_WorkTypesList, "予算管理テーマ")
        '
        'C1TextBox1
        '
        Me.C1TextBox1.AutoSize = False
        Me.C1TextBox1.BackColor = System.Drawing.Color.White
        Me.C1TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1TextBox1.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.C1TextBox1.Enabled = False
        Me.C1TextBox1.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1TextBox1.Location = New System.Drawing.Point(101, 53)
        Me.C1TextBox1.Name = "C1TextBox1"
        Me.C1TextBox1.Size = New System.Drawing.Size(173, 20)
        Me.C1TextBox1.TabIndex = 45
        Me.C1TextBox1.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.C1TextBox1, "予算管理テーマ")
        Me.C1TextBox1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'C1NumericEdit1
        '
        Me.C1NumericEdit1.AutoSize = False
        Me.C1NumericEdit1.BackColor = System.Drawing.Color.White
        Me.C1NumericEdit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.C1NumericEdit1.Calculator.BackColor = System.Drawing.Color.White
        Me.C1NumericEdit1.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1NumericEdit1.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1NumericEdit1.DataType = GetType(Long)
        Me.C1NumericEdit1.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.C1NumericEdit1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.C1NumericEdit1.GapHeight = 0
        Me.C1NumericEdit1.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NumericEdit1.Location = New System.Drawing.Point(275, 583)
        Me.C1NumericEdit1.Name = "C1NumericEdit1"
        Me.C1NumericEdit1.Size = New System.Drawing.Size(110, 20)
        Me.C1NumericEdit1.TabIndex = 47
        Me.C1NumericEdit1.Tag = Nothing
        Me.C1NumericEdit1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SystemTheme.SetTheme(Me.C1NumericEdit1, "予算管理テーマ")
        Me.C1NumericEdit1.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.C1NumericEdit1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
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
        Me.C1NumericEdit2.Location = New System.Drawing.Point(385, 583)
        Me.C1NumericEdit2.Name = "C1NumericEdit2"
        Me.C1NumericEdit2.Size = New System.Drawing.Size(110, 20)
        Me.C1NumericEdit2.TabIndex = 48
        Me.C1NumericEdit2.Tag = Nothing
        Me.C1NumericEdit2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SystemTheme.SetTheme(Me.C1NumericEdit2, "予算管理テーマ")
        Me.C1NumericEdit2.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.C1NumericEdit2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'C1NumericEdit3
        '
        Me.C1NumericEdit3.AutoSize = False
        Me.C1NumericEdit3.BackColor = System.Drawing.Color.White
        Me.C1NumericEdit3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.C1NumericEdit3.Calculator.BackColor = System.Drawing.Color.White
        Me.C1NumericEdit3.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1NumericEdit3.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1NumericEdit3.DataType = GetType(Long)
        Me.C1NumericEdit3.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.C1NumericEdit3.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.C1NumericEdit3.GapHeight = 0
        Me.C1NumericEdit3.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NumericEdit3.Location = New System.Drawing.Point(495, 583)
        Me.C1NumericEdit3.Name = "C1NumericEdit3"
        Me.C1NumericEdit3.Size = New System.Drawing.Size(110, 20)
        Me.C1NumericEdit3.TabIndex = 49
        Me.C1NumericEdit3.Tag = Nothing
        Me.C1NumericEdit3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SystemTheme.SetTheme(Me.C1NumericEdit3, "(default)")
        Me.C1NumericEdit3.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.C1NumericEdit3.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'C1NumericEdit4
        '
        Me.C1NumericEdit4.AutoSize = False
        Me.C1NumericEdit4.BackColor = System.Drawing.Color.White
        Me.C1NumericEdit4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.C1NumericEdit4.Calculator.BackColor = System.Drawing.Color.White
        Me.C1NumericEdit4.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1NumericEdit4.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1NumericEdit4.DataType = GetType(Long)
        Me.C1NumericEdit4.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.C1NumericEdit4.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.C1NumericEdit4.GapHeight = 0
        Me.C1NumericEdit4.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NumericEdit4.Location = New System.Drawing.Point(605, 583)
        Me.C1NumericEdit4.Name = "C1NumericEdit4"
        Me.C1NumericEdit4.Size = New System.Drawing.Size(110, 20)
        Me.C1NumericEdit4.TabIndex = 50
        Me.C1NumericEdit4.Tag = Nothing
        Me.C1NumericEdit4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SystemTheme.SetTheme(Me.C1NumericEdit4, "予算管理テーマ")
        Me.C1NumericEdit4.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.C1NumericEdit4.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'C1NumericEdit5
        '
        Me.C1NumericEdit5.AutoSize = False
        Me.C1NumericEdit5.BackColor = System.Drawing.Color.White
        Me.C1NumericEdit5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.C1NumericEdit5.Calculator.BackColor = System.Drawing.Color.White
        Me.C1NumericEdit5.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1NumericEdit5.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1NumericEdit5.DataType = GetType(Long)
        Me.C1NumericEdit5.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.C1NumericEdit5.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.C1NumericEdit5.GapHeight = 0
        Me.C1NumericEdit5.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NumericEdit5.Location = New System.Drawing.Point(715, 583)
        Me.C1NumericEdit5.Name = "C1NumericEdit5"
        Me.C1NumericEdit5.Size = New System.Drawing.Size(110, 20)
        Me.C1NumericEdit5.TabIndex = 51
        Me.C1NumericEdit5.Tag = Nothing
        Me.C1NumericEdit5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SystemTheme.SetTheme(Me.C1NumericEdit5, "予算管理テーマ")
        Me.C1NumericEdit5.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.C1NumericEdit5.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'C1NumericEdit6
        '
        Me.C1NumericEdit6.AutoSize = False
        Me.C1NumericEdit6.BackColor = System.Drawing.Color.White
        Me.C1NumericEdit6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.C1NumericEdit6.Calculator.BackColor = System.Drawing.Color.White
        Me.C1NumericEdit6.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1NumericEdit6.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1NumericEdit6.DataType = GetType(Long)
        Me.C1NumericEdit6.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.C1NumericEdit6.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.C1NumericEdit6.GapHeight = 0
        Me.C1NumericEdit6.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NumericEdit6.Location = New System.Drawing.Point(825, 583)
        Me.C1NumericEdit6.Name = "C1NumericEdit6"
        Me.C1NumericEdit6.Size = New System.Drawing.Size(110, 20)
        Me.C1NumericEdit6.TabIndex = 52
        Me.C1NumericEdit6.Tag = Nothing
        Me.C1NumericEdit6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SystemTheme.SetTheme(Me.C1NumericEdit6, "予算管理テーマ")
        Me.C1NumericEdit6.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.C1NumericEdit6.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
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
        Me.FormSplitContainer.Margin = New System.Windows.Forms.Padding(0)
        Me.FormSplitContainer.Name = "FormSplitContainer"
        Me.FormSplitContainer.Panels.Add(Me.C1SplitterPanel1)
        Me.FormSplitContainer.Panels.Add(Me.C1SplitterPanel2)
        Me.FormSplitContainer.Size = New System.Drawing.Size(990, 662)
        Me.FormSplitContainer.SplitterColor = System.Drawing.Color.White
        Me.FormSplitContainer.SplitterWidth = 1
        Me.FormSplitContainer.TabIndex = 44
        Me.FormSplitContainer.ToolTipGradient = C1.Win.C1SplitContainer.ToolTipGradient.Blue
        Me.FormSplitContainer.UseParentVisualStyle = False
        '
        'C1SplitterPanel1
        '
        Me.C1SplitterPanel1.BackColor = System.Drawing.Color.White
        Me.C1SplitterPanel1.Controls.Add(Me.C1NumericEdit6)
        Me.C1SplitterPanel1.Controls.Add(Me.C1NumericEdit5)
        Me.C1SplitterPanel1.Controls.Add(Me.C1NumericEdit4)
        Me.C1SplitterPanel1.Controls.Add(Me.C1NumericEdit3)
        Me.C1SplitterPanel1.Controls.Add(Me.C1NumericEdit2)
        Me.C1SplitterPanel1.Controls.Add(Me.C1NumericEdit1)
        Me.C1SplitterPanel1.Controls.Add(Me.Label2)
        Me.C1SplitterPanel1.Controls.Add(Me.C1TextBox1)
        Me.C1SplitterPanel1.Controls.Add(Me.Label1)
        Me.C1SplitterPanel1.Controls.Add(Me.S_WorkTypesList)
        Me.C1SplitterPanel1.Font = New System.Drawing.Font("メイリオ", 10.0!)
        Me.C1SplitterPanel1.Height = 621
        Me.C1SplitterPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1SplitterPanel1.Name = "C1SplitterPanel1"
        Me.C1SplitterPanel1.ResizeWhileDragging = True
        Me.C1SplitterPanel1.Size = New System.Drawing.Size(990, 621)
        Me.C1SplitterPanel1.SizeRatio = 94.1R
        Me.C1SplitterPanel1.TabIndex = 0
        Me.C1SplitterPanel1.Text = "パネル1"
        Me.C1SplitterPanel1.Width = 990
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(193, 583)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "合計"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(38, 53)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 20)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "大工種名"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'C1SplitterPanel2
        '
        Me.C1SplitterPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.C1SplitterPanel2.Controls.Add(Me.Cancel)
        Me.C1SplitterPanel2.Controls.Add(Me.Entry)
        Me.C1SplitterPanel2.Dock = C1.Win.C1SplitContainer.PanelDockStyle.Bottom
        Me.C1SplitterPanel2.Height = 40
        Me.C1SplitterPanel2.Location = New System.Drawing.Point(0, 622)
        Me.C1SplitterPanel2.Name = "C1SplitterPanel2"
        Me.C1SplitterPanel2.Size = New System.Drawing.Size(990, 40)
        Me.C1SplitterPanel2.TabIndex = 1
        Me.C1SplitterPanel2.Text = "パネル2"
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
        Me.Cancel.Location = New System.Drawing.Point(881, 6)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(0)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(100, 30)
        Me.Cancel.TabIndex = 64
        Me.Cancel.Text = "キャンセル"
        Me.Cancel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Entry
        '
        Me.Entry.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Entry.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Entry.FlatAppearance.BorderSize = 0
        Me.Entry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Entry.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Entry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Entry.ImageIndex = 3
        Me.Entry.ImageList = Me.ButtonImageList
        Me.Entry.Location = New System.Drawing.Point(776, 6)
        Me.Entry.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.Entry.Name = "Entry"
        Me.Entry.Size = New System.Drawing.Size(100, 30)
        Me.Entry.TabIndex = 41
        Me.Entry.Text = "　登　録"
        Me.Entry.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Entry.UseVisualStyleBackColor = True
        '
        '小工種選択
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(990, 662)
        Me.Controls.Add(Me.HeadLine)
        Me.Controls.Add(Me.FormSplitContainer)
        Me.Font = New System.Drawing.Font("メイリオ", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "小工種選択"
        Me.Opacity = 0.2R
        Me.Text = "協力業者入力"
        CType(Me.S_WorkTypesList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FormSplitContainer.ResumeLayout(False)
        Me.C1SplitterPanel1.ResumeLayout(False)
        Me.C1SplitterPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HeadLine As Label
    Friend WithEvents ButtonImageList As ImageList
    Friend WithEvents Entry As Button
    Friend WithEvents S_WorkTypesList As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents SystemTheme As C1.Win.C1Themes.C1ThemeController
    Friend WithEvents FormSplitContainer As C1.Win.C1SplitContainer.C1SplitContainer
    Friend WithEvents C1SplitterPanel1 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents C1SplitterPanel2 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents Cancel As Button
    Friend WithEvents C1TextBox1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents C1NumericEdit6 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NumericEdit5 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NumericEdit4 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NumericEdit3 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NumericEdit2 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NumericEdit1 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label2 As Label
End Class
