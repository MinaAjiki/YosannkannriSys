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
        Me.L_WorkType = New C1.Win.C1Input.C1TextBox()
        Me.SWorkTypeTotal = New C1.Win.C1Input.C1NumericEdit()
        Me.Labor = New C1.Win.C1Input.C1NumericEdit()
        Me.Material = New C1.Win.C1Input.C1NumericEdit()
        Me.Machine = New C1.Win.C1Input.C1NumericEdit()
        Me.Subcntrct = New C1.Win.C1Input.C1NumericEdit()
        Me.Expens = New C1.Win.C1Input.C1NumericEdit()
        Me.FormSplitContainer = New C1.Win.C1SplitContainer.C1SplitContainer()
        Me.C1SplitterPanel1 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.C1SplitterPanel2 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Entry = New System.Windows.Forms.Button()
        CType(Me.S_WorkTypesList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.L_WorkType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SWorkTypeTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Labor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Material, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Machine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Subcntrct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Expens, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.S_WorkTypesList.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.S_WorkTypesList.AllowEditing = False
        Me.S_WorkTypesList.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.S_WorkTypesList.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.S_WorkTypesList.ColumnInfo = resources.GetString("S_WorkTypesList.ColumnInfo")
        Me.S_WorkTypesList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.S_WorkTypesList.Location = New System.Drawing.Point(37, 75)
        Me.S_WorkTypesList.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.S_WorkTypesList.Name = "S_WorkTypesList"
        Me.S_WorkTypesList.Rows.Count = 21
        Me.S_WorkTypesList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.S_WorkTypesList.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.S_WorkTypesList.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.S_WorkTypesList.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.S_WorkTypesList.Size = New System.Drawing.Size(918, 505)
        Me.S_WorkTypesList.StyleInfo = resources.GetString("S_WorkTypesList.StyleInfo")
        Me.S_WorkTypesList.TabIndex = 43
        Me.SystemTheme.SetTheme(Me.S_WorkTypesList, "予算管理テーマ")
        '
        'L_WorkType
        '
        Me.L_WorkType.AutoSize = False
        Me.L_WorkType.BackColor = System.Drawing.Color.White
        Me.L_WorkType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_WorkType.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.L_WorkType.Enabled = False
        Me.L_WorkType.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.L_WorkType.Location = New System.Drawing.Point(101, 53)
        Me.L_WorkType.Name = "L_WorkType"
        Me.L_WorkType.Size = New System.Drawing.Size(173, 20)
        Me.L_WorkType.TabIndex = 45
        Me.L_WorkType.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.L_WorkType, "予算管理テーマ")
        Me.L_WorkType.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'SWorkTypeTotal
        '
        Me.SWorkTypeTotal.AutoSize = False
        Me.SWorkTypeTotal.BackColor = System.Drawing.Color.White
        Me.SWorkTypeTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.SWorkTypeTotal.Calculator.BackColor = System.Drawing.Color.White
        Me.SWorkTypeTotal.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.SWorkTypeTotal.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.SWorkTypeTotal.DataType = GetType(Long)
        Me.SWorkTypeTotal.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.SWorkTypeTotal.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.SWorkTypeTotal.DisplayFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.SWorkTypeTotal.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.SWorkTypeTotal.GapHeight = 0
        Me.SWorkTypeTotal.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.SWorkTypeTotal.Location = New System.Drawing.Point(275, 583)
        Me.SWorkTypeTotal.Name = "SWorkTypeTotal"
        Me.SWorkTypeTotal.Size = New System.Drawing.Size(110, 20)
        Me.SWorkTypeTotal.TabIndex = 47
        Me.SWorkTypeTotal.Tag = Nothing
        Me.SWorkTypeTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SystemTheme.SetTheme(Me.SWorkTypeTotal, "予算管理テーマ")
        Me.SWorkTypeTotal.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.SWorkTypeTotal.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Labor
        '
        Me.Labor.AutoSize = False
        Me.Labor.BackColor = System.Drawing.Color.White
        Me.Labor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.Labor.Calculator.BackColor = System.Drawing.Color.White
        Me.Labor.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.Labor.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.Labor.DataType = GetType(Long)
        Me.Labor.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.Labor.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.Labor.DisplayFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.Labor.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Labor.GapHeight = 0
        Me.Labor.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.Labor.Location = New System.Drawing.Point(385, 583)
        Me.Labor.Name = "Labor"
        Me.Labor.Size = New System.Drawing.Size(110, 20)
        Me.Labor.TabIndex = 48
        Me.Labor.Tag = Nothing
        Me.Labor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SystemTheme.SetTheme(Me.Labor, "予算管理テーマ")
        Me.Labor.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.Labor.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Material
        '
        Me.Material.AutoSize = False
        Me.Material.BackColor = System.Drawing.Color.White
        Me.Material.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.Material.Calculator.BackColor = System.Drawing.Color.White
        Me.Material.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.Material.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.Material.DataType = GetType(Long)
        Me.Material.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.Material.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.Material.DisplayFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.Material.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Material.GapHeight = 0
        Me.Material.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.Material.Location = New System.Drawing.Point(495, 583)
        Me.Material.Name = "Material"
        Me.Material.Size = New System.Drawing.Size(110, 20)
        Me.Material.TabIndex = 49
        Me.Material.Tag = Nothing
        Me.Material.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SystemTheme.SetTheme(Me.Material, "(default)")
        Me.Material.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.Material.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Machine
        '
        Me.Machine.AutoSize = False
        Me.Machine.BackColor = System.Drawing.Color.White
        Me.Machine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.Machine.Calculator.BackColor = System.Drawing.Color.White
        Me.Machine.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.Machine.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.Machine.DataType = GetType(Long)
        Me.Machine.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.Machine.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.Machine.DisplayFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.Machine.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Machine.GapHeight = 0
        Me.Machine.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.Machine.Location = New System.Drawing.Point(605, 583)
        Me.Machine.Name = "Machine"
        Me.Machine.Size = New System.Drawing.Size(110, 20)
        Me.Machine.TabIndex = 50
        Me.Machine.Tag = Nothing
        Me.Machine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SystemTheme.SetTheme(Me.Machine, "予算管理テーマ")
        Me.Machine.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.Machine.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Subcntrct
        '
        Me.Subcntrct.AutoSize = False
        Me.Subcntrct.BackColor = System.Drawing.Color.White
        Me.Subcntrct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.Subcntrct.Calculator.BackColor = System.Drawing.Color.White
        Me.Subcntrct.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.Subcntrct.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.Subcntrct.DataType = GetType(Long)
        Me.Subcntrct.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.Subcntrct.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.Subcntrct.DisplayFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.Subcntrct.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Subcntrct.GapHeight = 0
        Me.Subcntrct.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.Subcntrct.Location = New System.Drawing.Point(715, 583)
        Me.Subcntrct.Name = "Subcntrct"
        Me.Subcntrct.Size = New System.Drawing.Size(110, 20)
        Me.Subcntrct.TabIndex = 51
        Me.Subcntrct.Tag = Nothing
        Me.Subcntrct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SystemTheme.SetTheme(Me.Subcntrct, "予算管理テーマ")
        Me.Subcntrct.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.Subcntrct.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Expens
        '
        Me.Expens.AutoSize = False
        Me.Expens.BackColor = System.Drawing.Color.White
        Me.Expens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.Expens.Calculator.BackColor = System.Drawing.Color.White
        Me.Expens.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.Expens.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.Expens.DataType = GetType(Long)
        Me.Expens.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.Expens.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.Expens.DisplayFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.Expens.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Expens.GapHeight = 0
        Me.Expens.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.Expens.Location = New System.Drawing.Point(825, 583)
        Me.Expens.Name = "Expens"
        Me.Expens.Size = New System.Drawing.Size(110, 20)
        Me.Expens.TabIndex = 52
        Me.Expens.Tag = Nothing
        Me.Expens.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SystemTheme.SetTheme(Me.Expens, "予算管理テーマ")
        Me.Expens.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.Expens.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
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
        Me.C1SplitterPanel1.Controls.Add(Me.Expens)
        Me.C1SplitterPanel1.Controls.Add(Me.Subcntrct)
        Me.C1SplitterPanel1.Controls.Add(Me.Machine)
        Me.C1SplitterPanel1.Controls.Add(Me.Material)
        Me.C1SplitterPanel1.Controls.Add(Me.Labor)
        Me.C1SplitterPanel1.Controls.Add(Me.SWorkTypeTotal)
        Me.C1SplitterPanel1.Controls.Add(Me.Label2)
        Me.C1SplitterPanel1.Controls.Add(Me.L_WorkType)
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
        CType(Me.L_WorkType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SWorkTypeTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Labor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Material, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Machine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Subcntrct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Expens, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents L_WorkType As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Expens As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Subcntrct As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Machine As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Material As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Labor As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents SWorkTypeTotal As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label2 As Label
End Class
