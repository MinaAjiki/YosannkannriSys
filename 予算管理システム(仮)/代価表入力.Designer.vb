<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 代価表入力
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(代価表入力))
        Me.HeadLine = New System.Windows.Forms.Label()
        Me.ButtonImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.BreakDownList = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.SystemTheme = New C1.Win.C1Themes.C1ThemeController()
        Me.CostNo = New C1.Win.C1Input.C1TextBox()
        Me.C1NumericEdit2 = New C1.Win.C1Input.C1NumericEdit()
        Me.CostName = New C1.Win.C1Input.C1TextBox()
        Me.CostSpec = New C1.Win.C1Input.C1TextBox()
        Me.CostQuanity = New C1.Win.C1Input.C1NumericEdit()
        Me.CostUnitPrice = New C1.Win.C1Input.C1NumericEdit()
        Me.CostUnit = New C1.Win.C1Input.C1NumericEdit()
        Me.CostCostea = New C1.Win.C1Input.C1NumericEdit()
        Me.LaborCostea = New C1.Win.C1Input.C1NumericEdit()
        Me.MaterialCostea = New C1.Win.C1Input.C1NumericEdit()
        Me.MachineCostea = New C1.Win.C1Input.C1NumericEdit()
        Me.SubcntrctCostea = New C1.Win.C1Input.C1NumericEdit()
        Me.ExpensCostea = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NumericEdit11 = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NumericEdit12 = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NumericEdit13 = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NumericEdit14 = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NumericEdit15 = New C1.Win.C1Input.C1NumericEdit()
        Me.右クリックメニュー = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ItemSelectMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.PastingMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CostCreateMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CostModifyMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CostCopyMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReferenceMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemSelect = New System.Windows.Forms.Button()
        Me.Reference = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.FormSplitContainer = New C1.Win.C1SplitContainer.C1SplitContainer()
        Me.C1SplitterPanel1 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.C1SplitterPanel2 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Entry = New System.Windows.Forms.Button()
        Me.CostCopy = New System.Windows.Forms.Button()
        Me.CostCreation = New System.Windows.Forms.Button()
        Me.CostModify = New System.Windows.Forms.Button()
        CType(Me.BreakDownList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostSpec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostQuanity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostUnitPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostCostea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LaborCostea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialCostea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MachineCostea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubcntrctCostea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpensCostea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEdit11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEdit12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEdit13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEdit14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEdit15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.右クリックメニュー.SuspendLayout()
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
        Me.HeadLine.Text = "<< 代価表入力"
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
        'BreakDownList
        '
        Me.BreakDownList.AllowDelete = True
        Me.BreakDownList.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.BreakDownList.AllowEditing = False
        Me.BreakDownList.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Custom
        Me.BreakDownList.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.BreakDownList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BreakDownList.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.BreakDownList.ColumnInfo = resources.GetString("BreakDownList.ColumnInfo")
        Me.BreakDownList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BreakDownList.Location = New System.Drawing.Point(28, 184)
        Me.BreakDownList.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.BreakDownList.Name = "BreakDownList"
        Me.BreakDownList.Rows.Count = 25
        Me.BreakDownList.Rows.Fixed = 3
        Me.BreakDownList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.BreakDownList.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.BreakDownList.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.BreakDownList.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.BreakDownList.Size = New System.Drawing.Size(936, 408)
        Me.BreakDownList.StyleInfo = resources.GetString("BreakDownList.StyleInfo")
        Me.BreakDownList.TabIndex = 43
        Me.SystemTheme.SetTheme(Me.BreakDownList, "予算管理テーマ")
        '
        'CostNo
        '
        Me.CostNo.AutoSize = False
        Me.CostNo.BackColor = System.Drawing.Color.White
        Me.CostNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CostNo.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.CostNo.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.CostNo.Location = New System.Drawing.Point(99, 60)
        Me.CostNo.Name = "CostNo"
        Me.CostNo.Size = New System.Drawing.Size(173, 20)
        Me.CostNo.TabIndex = 45
        Me.CostNo.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.CostNo, "予算管理テーマ")
        Me.CostNo.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
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
        Me.C1NumericEdit2.Location = New System.Drawing.Point(355, 565)
        Me.C1NumericEdit2.Name = "C1NumericEdit2"
        Me.C1NumericEdit2.Size = New System.Drawing.Size(111, 20)
        Me.C1NumericEdit2.TabIndex = 48
        Me.C1NumericEdit2.Tag = Nothing
        Me.C1NumericEdit2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SystemTheme.SetTheme(Me.C1NumericEdit2, "(default)")
        Me.C1NumericEdit2.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.C1NumericEdit2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'CostName
        '
        Me.CostName.AutoSize = False
        Me.CostName.BackColor = System.Drawing.Color.White
        Me.CostName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CostName.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.CostName.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.CostName.Location = New System.Drawing.Point(99, 81)
        Me.CostName.Name = "CostName"
        Me.CostName.Size = New System.Drawing.Size(228, 20)
        Me.CostName.TabIndex = 63
        Me.CostName.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.CostName, "予算管理テーマ")
        Me.CostName.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'CostSpec
        '
        Me.CostSpec.AutoSize = False
        Me.CostSpec.BackColor = System.Drawing.Color.White
        Me.CostSpec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CostSpec.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.CostSpec.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.CostSpec.Location = New System.Drawing.Point(402, 81)
        Me.CostSpec.Name = "CostSpec"
        Me.CostSpec.Size = New System.Drawing.Size(543, 20)
        Me.CostSpec.TabIndex = 70
        Me.CostSpec.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.CostSpec, "予算管理テーマ")
        Me.CostSpec.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'CostQuanity
        '
        Me.CostQuanity.AutoSize = False
        Me.CostQuanity.BackColor = System.Drawing.Color.White
        Me.CostQuanity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.CostQuanity.Calculator.BackColor = System.Drawing.Color.White
        Me.CostQuanity.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.CostQuanity.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.CostQuanity.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.CostQuanity.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.CostQuanity.GapHeight = 0
        Me.CostQuanity.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.CostQuanity.Location = New System.Drawing.Point(66, 102)
        Me.CostQuanity.Name = "CostQuanity"
        Me.CostQuanity.Size = New System.Drawing.Size(110, 20)
        Me.CostQuanity.TabIndex = 71
        Me.CostQuanity.Tag = Nothing
        Me.CostQuanity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SystemTheme.SetTheme(Me.CostQuanity, "予算管理テーマ")
        Me.CostQuanity.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.CostQuanity.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'CostUnitPrice
        '
        Me.CostUnitPrice.AutoSize = False
        Me.CostUnitPrice.BackColor = System.Drawing.Color.White
        Me.CostUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.CostUnitPrice.Calculator.BackColor = System.Drawing.Color.White
        Me.CostUnitPrice.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.CostUnitPrice.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.CostUnitPrice.DataType = GetType(Long)
        Me.CostUnitPrice.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.CostUnitPrice.DisplayFormat.CustomFormat = "#,###"
        Me.CostUnitPrice.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.CostUnitPrice.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.CostUnitPrice.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.CostUnitPrice.GapHeight = 0
        Me.CostUnitPrice.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.CostUnitPrice.Location = New System.Drawing.Point(370, 102)
        Me.CostUnitPrice.Name = "CostUnitPrice"
        Me.CostUnitPrice.Size = New System.Drawing.Size(110, 20)
        Me.CostUnitPrice.TabIndex = 72
        Me.CostUnitPrice.Tag = Nothing
        Me.CostUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SystemTheme.SetTheme(Me.CostUnitPrice, "予算管理テーマ")
        Me.CostUnitPrice.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.CostUnitPrice.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'CostUnit
        '
        Me.CostUnit.AutoSize = False
        Me.CostUnit.BackColor = System.Drawing.Color.White
        Me.CostUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.CostUnit.Calculator.BackColor = System.Drawing.Color.White
        Me.CostUnit.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.CostUnit.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.CostUnit.DataType = GetType(Long)
        Me.CostUnit.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.CostUnit.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.CostUnit.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.CostUnit.GapHeight = 0
        Me.CostUnit.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.CostUnit.Location = New System.Drawing.Point(218, 102)
        Me.CostUnit.Name = "CostUnit"
        Me.CostUnit.Size = New System.Drawing.Size(110, 20)
        Me.CostUnit.TabIndex = 73
        Me.CostUnit.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.CostUnit, "予算管理テーマ")
        Me.CostUnit.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.CostUnit.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'CostCostea
        '
        Me.CostCostea.AutoSize = False
        Me.CostCostea.BackColor = System.Drawing.Color.White
        Me.CostCostea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.CostCostea.Calculator.BackColor = System.Drawing.Color.White
        Me.CostCostea.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.CostCostea.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.CostCostea.DataType = GetType(Long)
        Me.CostCostea.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.CostCostea.DisplayFormat.CustomFormat = "#,###"
        Me.CostCostea.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.CostCostea.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.CostCostea.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.CostCostea.GapHeight = 0
        Me.CostCostea.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.CostCostea.Location = New System.Drawing.Point(522, 102)
        Me.CostCostea.Name = "CostCostea"
        Me.CostCostea.Size = New System.Drawing.Size(110, 20)
        Me.CostCostea.TabIndex = 74
        Me.CostCostea.Tag = Nothing
        Me.CostCostea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SystemTheme.SetTheme(Me.CostCostea, "予算管理テーマ")
        Me.CostCostea.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.CostCostea.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'LaborCostea
        '
        Me.LaborCostea.AutoSize = False
        Me.LaborCostea.BackColor = System.Drawing.Color.White
        Me.LaborCostea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.LaborCostea.Calculator.BackColor = System.Drawing.Color.White
        Me.LaborCostea.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.LaborCostea.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.LaborCostea.DataType = GetType(Long)
        Me.LaborCostea.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.LaborCostea.DisplayFormat.CustomFormat = "#,###"
        Me.LaborCostea.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.LaborCostea.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.LaborCostea.EditFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.LaborCostea.Enabled = False
        Me.LaborCostea.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.LaborCostea.GapHeight = 0
        Me.LaborCostea.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.LaborCostea.Location = New System.Drawing.Point(470, 163)
        Me.LaborCostea.Name = "LaborCostea"
        Me.LaborCostea.Size = New System.Drawing.Size(95, 20)
        Me.LaborCostea.TabIndex = 75
        Me.LaborCostea.Tag = Nothing
        Me.LaborCostea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SystemTheme.SetTheme(Me.LaborCostea, "予算管理テーマ")
        Me.LaborCostea.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.LaborCostea.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'MaterialCostea
        '
        Me.MaterialCostea.AutoSize = False
        Me.MaterialCostea.BackColor = System.Drawing.Color.White
        Me.MaterialCostea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.MaterialCostea.Calculator.BackColor = System.Drawing.Color.White
        Me.MaterialCostea.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.MaterialCostea.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.MaterialCostea.DataType = GetType(Long)
        Me.MaterialCostea.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.MaterialCostea.DisplayFormat.CustomFormat = "#,###"
        Me.MaterialCostea.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.MaterialCostea.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.MaterialCostea.EditFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.MaterialCostea.Enabled = False
        Me.MaterialCostea.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.MaterialCostea.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.MaterialCostea.GapHeight = 0
        Me.MaterialCostea.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.MaterialCostea.Location = New System.Drawing.Point(565, 163)
        Me.MaterialCostea.Name = "MaterialCostea"
        Me.MaterialCostea.Size = New System.Drawing.Size(95, 20)
        Me.MaterialCostea.TabIndex = 76
        Me.MaterialCostea.Tag = Nothing
        Me.MaterialCostea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SystemTheme.SetTheme(Me.MaterialCostea, "予算管理テーマ")
        Me.MaterialCostea.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.MaterialCostea.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'MachineCostea
        '
        Me.MachineCostea.AutoSize = False
        Me.MachineCostea.BackColor = System.Drawing.Color.White
        Me.MachineCostea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.MachineCostea.Calculator.BackColor = System.Drawing.Color.White
        Me.MachineCostea.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.MachineCostea.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.MachineCostea.DataType = GetType(Long)
        Me.MachineCostea.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.MachineCostea.DisplayFormat.CustomFormat = "#,###"
        Me.MachineCostea.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.MachineCostea.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.MachineCostea.EditFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.MachineCostea.Enabled = False
        Me.MachineCostea.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.MachineCostea.GapHeight = 0
        Me.MachineCostea.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.MachineCostea.Location = New System.Drawing.Point(660, 163)
        Me.MachineCostea.Name = "MachineCostea"
        Me.MachineCostea.Size = New System.Drawing.Size(95, 20)
        Me.MachineCostea.TabIndex = 77
        Me.MachineCostea.Tag = Nothing
        Me.MachineCostea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SystemTheme.SetTheme(Me.MachineCostea, "予算管理テーマ")
        Me.MachineCostea.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.MachineCostea.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'SubcntrctCostea
        '
        Me.SubcntrctCostea.AutoSize = False
        Me.SubcntrctCostea.BackColor = System.Drawing.Color.White
        Me.SubcntrctCostea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.SubcntrctCostea.Calculator.BackColor = System.Drawing.Color.White
        Me.SubcntrctCostea.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.SubcntrctCostea.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.SubcntrctCostea.DataType = GetType(Long)
        Me.SubcntrctCostea.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.SubcntrctCostea.DisplayFormat.CustomFormat = "#,###"
        Me.SubcntrctCostea.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.SubcntrctCostea.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.SubcntrctCostea.EditFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.SubcntrctCostea.Enabled = False
        Me.SubcntrctCostea.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.SubcntrctCostea.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.SubcntrctCostea.GapHeight = 0
        Me.SubcntrctCostea.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.SubcntrctCostea.Location = New System.Drawing.Point(755, 163)
        Me.SubcntrctCostea.Name = "SubcntrctCostea"
        Me.SubcntrctCostea.Size = New System.Drawing.Size(95, 20)
        Me.SubcntrctCostea.TabIndex = 78
        Me.SubcntrctCostea.Tag = Nothing
        Me.SubcntrctCostea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SystemTheme.SetTheme(Me.SubcntrctCostea, "予算管理テーマ")
        Me.SubcntrctCostea.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.SubcntrctCostea.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'ExpensCostea
        '
        Me.ExpensCostea.AutoSize = False
        Me.ExpensCostea.BackColor = System.Drawing.Color.White
        Me.ExpensCostea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.ExpensCostea.Calculator.BackColor = System.Drawing.Color.White
        Me.ExpensCostea.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.ExpensCostea.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.ExpensCostea.DataType = GetType(Long)
        Me.ExpensCostea.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.ExpensCostea.DisplayFormat.CustomFormat = "#,###"
        Me.ExpensCostea.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.ExpensCostea.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.ExpensCostea.EditFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.ExpensCostea.Enabled = False
        Me.ExpensCostea.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.ExpensCostea.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.ExpensCostea.GapHeight = 0
        Me.ExpensCostea.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.ExpensCostea.Location = New System.Drawing.Point(850, 163)
        Me.ExpensCostea.Name = "ExpensCostea"
        Me.ExpensCostea.Size = New System.Drawing.Size(95, 20)
        Me.ExpensCostea.TabIndex = 79
        Me.ExpensCostea.Tag = Nothing
        Me.ExpensCostea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SystemTheme.SetTheme(Me.ExpensCostea, "予算管理テーマ")
        Me.ExpensCostea.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.ExpensCostea.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'C1NumericEdit11
        '
        Me.C1NumericEdit11.AutoSize = False
        Me.C1NumericEdit11.BackColor = System.Drawing.Color.White
        Me.C1NumericEdit11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.C1NumericEdit11.Calculator.BackColor = System.Drawing.Color.White
        Me.C1NumericEdit11.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1NumericEdit11.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1NumericEdit11.DataType = GetType(Long)
        Me.C1NumericEdit11.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.C1NumericEdit11.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.C1NumericEdit11.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.C1NumericEdit11.GapHeight = 0
        Me.C1NumericEdit11.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NumericEdit11.Location = New System.Drawing.Point(470, 594)
        Me.C1NumericEdit11.Name = "C1NumericEdit11"
        Me.C1NumericEdit11.Size = New System.Drawing.Size(95, 20)
        Me.C1NumericEdit11.TabIndex = 80
        Me.C1NumericEdit11.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.C1NumericEdit11, "予算管理テーマ")
        Me.C1NumericEdit11.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.C1NumericEdit11.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'C1NumericEdit12
        '
        Me.C1NumericEdit12.AutoSize = False
        Me.C1NumericEdit12.BackColor = System.Drawing.Color.White
        Me.C1NumericEdit12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.C1NumericEdit12.Calculator.BackColor = System.Drawing.Color.White
        Me.C1NumericEdit12.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1NumericEdit12.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1NumericEdit12.DataType = GetType(Long)
        Me.C1NumericEdit12.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.C1NumericEdit12.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.C1NumericEdit12.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.C1NumericEdit12.GapHeight = 0
        Me.C1NumericEdit12.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NumericEdit12.Location = New System.Drawing.Point(850, 594)
        Me.C1NumericEdit12.Name = "C1NumericEdit12"
        Me.C1NumericEdit12.Size = New System.Drawing.Size(95, 20)
        Me.C1NumericEdit12.TabIndex = 81
        Me.C1NumericEdit12.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.C1NumericEdit12, "予算管理テーマ")
        Me.C1NumericEdit12.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.C1NumericEdit12.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'C1NumericEdit13
        '
        Me.C1NumericEdit13.AutoSize = False
        Me.C1NumericEdit13.BackColor = System.Drawing.Color.White
        Me.C1NumericEdit13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.C1NumericEdit13.Calculator.BackColor = System.Drawing.Color.White
        Me.C1NumericEdit13.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1NumericEdit13.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1NumericEdit13.DataType = GetType(Long)
        Me.C1NumericEdit13.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.C1NumericEdit13.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.C1NumericEdit13.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.C1NumericEdit13.GapHeight = 0
        Me.C1NumericEdit13.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NumericEdit13.Location = New System.Drawing.Point(565, 594)
        Me.C1NumericEdit13.Name = "C1NumericEdit13"
        Me.C1NumericEdit13.Size = New System.Drawing.Size(95, 20)
        Me.C1NumericEdit13.TabIndex = 82
        Me.C1NumericEdit13.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.C1NumericEdit13, "予算管理テーマ")
        Me.C1NumericEdit13.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.C1NumericEdit13.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'C1NumericEdit14
        '
        Me.C1NumericEdit14.AutoSize = False
        Me.C1NumericEdit14.BackColor = System.Drawing.Color.White
        Me.C1NumericEdit14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.C1NumericEdit14.Calculator.BackColor = System.Drawing.Color.White
        Me.C1NumericEdit14.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1NumericEdit14.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1NumericEdit14.DataType = GetType(Long)
        Me.C1NumericEdit14.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.C1NumericEdit14.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.C1NumericEdit14.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.C1NumericEdit14.GapHeight = 0
        Me.C1NumericEdit14.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NumericEdit14.Location = New System.Drawing.Point(660, 594)
        Me.C1NumericEdit14.Name = "C1NumericEdit14"
        Me.C1NumericEdit14.Size = New System.Drawing.Size(95, 20)
        Me.C1NumericEdit14.TabIndex = 83
        Me.C1NumericEdit14.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.C1NumericEdit14, "予算管理テーマ")
        Me.C1NumericEdit14.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.C1NumericEdit14.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'C1NumericEdit15
        '
        Me.C1NumericEdit15.AutoSize = False
        Me.C1NumericEdit15.BackColor = System.Drawing.Color.White
        Me.C1NumericEdit15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.C1NumericEdit15.Calculator.BackColor = System.Drawing.Color.White
        Me.C1NumericEdit15.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1NumericEdit15.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1NumericEdit15.DataType = GetType(Long)
        Me.C1NumericEdit15.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.C1NumericEdit15.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.C1NumericEdit15.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.C1NumericEdit15.GapHeight = 0
        Me.C1NumericEdit15.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NumericEdit15.Location = New System.Drawing.Point(755, 594)
        Me.C1NumericEdit15.Name = "C1NumericEdit15"
        Me.C1NumericEdit15.Size = New System.Drawing.Size(95, 20)
        Me.C1NumericEdit15.TabIndex = 84
        Me.C1NumericEdit15.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.C1NumericEdit15, "予算管理テーマ")
        Me.C1NumericEdit15.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.C1NumericEdit15.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        '右クリックメニュー
        '
        Me.右クリックメニュー.BackColor = System.Drawing.Color.White
        Me.右クリックメニュー.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.右クリックメニュー.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItemSelectMenu, Me.InsertMenu, Me.CutMenu, Me.CopyMenu, Me.PastingMenu, Me.CostCreateMenu, Me.CostModifyMenu, Me.CostCopyMenu, Me.ReferenceMenu})
        Me.右クリックメニュー.Name = "ContextMenuStrip1"
        Me.右クリックメニュー.ShowImageMargin = False
        Me.右クリックメニュー.Size = New System.Drawing.Size(171, 202)
        Me.右クリックメニュー.Text = "項目選択"
        Me.SystemTheme.SetTheme(Me.右クリックメニュー, "(default)")
        '
        'ItemSelectMenu
        '
        Me.ItemSelectMenu.Name = "ItemSelectMenu"
        Me.ItemSelectMenu.Size = New System.Drawing.Size(170, 22)
        Me.ItemSelectMenu.Text = "項目選択"
        '
        'InsertMenu
        '
        Me.InsertMenu.Name = "InsertMenu"
        Me.InsertMenu.Size = New System.Drawing.Size(170, 22)
        Me.InsertMenu.Text = "行の挿入"
        '
        'CutMenu
        '
        Me.CutMenu.Name = "CutMenu"
        Me.CutMenu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutMenu.Size = New System.Drawing.Size(170, 22)
        Me.CutMenu.Text = "行の切り取り"
        '
        'CopyMenu
        '
        Me.CopyMenu.Name = "CopyMenu"
        Me.CopyMenu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyMenu.Size = New System.Drawing.Size(170, 22)
        Me.CopyMenu.Text = "行のコピー"
        '
        'PastingMenu
        '
        Me.PastingMenu.Name = "PastingMenu"
        Me.PastingMenu.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PastingMenu.Size = New System.Drawing.Size(170, 22)
        Me.PastingMenu.Text = "行の貼り付け"
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
        'ReferenceMenu
        '
        Me.ReferenceMenu.Name = "ReferenceMenu"
        Me.ReferenceMenu.Size = New System.Drawing.Size(170, 22)
        Me.ReferenceMenu.Text = "代価表参照"
        '
        'ItemSelect
        '
        Me.ItemSelect.FlatAppearance.BorderSize = 0
        Me.ItemSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ItemSelect.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ItemSelect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ItemSelect.ImageIndex = 0
        Me.ItemSelect.ImageList = Me.ButtonImageList
        Me.ItemSelect.Location = New System.Drawing.Point(9, 5)
        Me.ItemSelect.Margin = New System.Windows.Forms.Padding(0)
        Me.ItemSelect.Name = "ItemSelect"
        Me.ItemSelect.Size = New System.Drawing.Size(100, 30)
        Me.ItemSelect.TabIndex = 102
        Me.ItemSelect.Text = "項目選択"
        Me.ItemSelect.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ItemSelect.UseVisualStyleBackColor = True
        '
        'Reference
        '
        Me.Reference.FlatAppearance.BorderSize = 0
        Me.Reference.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Reference.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Reference.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Reference.ImageIndex = 0
        Me.Reference.ImageList = Me.ButtonImageList
        Me.Reference.Location = New System.Drawing.Point(413, 5)
        Me.Reference.Margin = New System.Windows.Forms.Padding(0)
        Me.Reference.Name = "Reference"
        Me.Reference.Size = New System.Drawing.Size(100, 30)
        Me.Reference.TabIndex = 103
        Me.Reference.Text = "代価表参照"
        Me.Reference.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Reference.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label9.Location = New System.Drawing.Point(470, 143)
        Me.Label9.Margin = New System.Windows.Forms.Padding(0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(475, 20)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "単位当り単価"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormSplitContainer
        '
        Me.FormSplitContainer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FormSplitContainer.AutoSizeElement = C1.Framework.AutoSizeElement.Both
        Me.FormSplitContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.FormSplitContainer.CollapsingAreaColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
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
        Me.C1SplitterPanel1.Controls.Add(Me.C1NumericEdit15)
        Me.C1SplitterPanel1.Controls.Add(Me.C1NumericEdit14)
        Me.C1SplitterPanel1.Controls.Add(Me.C1NumericEdit13)
        Me.C1SplitterPanel1.Controls.Add(Me.C1NumericEdit12)
        Me.C1SplitterPanel1.Controls.Add(Me.C1NumericEdit11)
        Me.C1SplitterPanel1.Controls.Add(Me.ExpensCostea)
        Me.C1SplitterPanel1.Controls.Add(Me.SubcntrctCostea)
        Me.C1SplitterPanel1.Controls.Add(Me.MachineCostea)
        Me.C1SplitterPanel1.Controls.Add(Me.MaterialCostea)
        Me.C1SplitterPanel1.Controls.Add(Me.LaborCostea)
        Me.C1SplitterPanel1.Controls.Add(Me.CostCostea)
        Me.C1SplitterPanel1.Controls.Add(Me.CostUnit)
        Me.C1SplitterPanel1.Controls.Add(Me.CostUnitPrice)
        Me.C1SplitterPanel1.Controls.Add(Me.CostQuanity)
        Me.C1SplitterPanel1.Controls.Add(Me.CostSpec)
        Me.C1SplitterPanel1.Controls.Add(Me.Label9)
        Me.C1SplitterPanel1.Controls.Add(Me.Label8)
        Me.C1SplitterPanel1.Controls.Add(Me.Label7)
        Me.C1SplitterPanel1.Controls.Add(Me.Label6)
        Me.C1SplitterPanel1.Controls.Add(Me.Label5)
        Me.C1SplitterPanel1.Controls.Add(Me.Label4)
        Me.C1SplitterPanel1.Controls.Add(Me.CostName)
        Me.C1SplitterPanel1.Controls.Add(Me.Label3)
        Me.C1SplitterPanel1.Controls.Add(Me.Label1)
        Me.C1SplitterPanel1.Controls.Add(Me.TableName)
        Me.C1SplitterPanel1.Controls.Add(Me.Label2)
        Me.C1SplitterPanel1.Controls.Add(Me.CostNo)
        Me.C1SplitterPanel1.Controls.Add(Me.BreakDownList)
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
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Location = New System.Drawing.Point(329, 102)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 20)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "当り"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Location = New System.Drawing.Point(177, 102)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 20)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "単位"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Location = New System.Drawing.Point(328, 81)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 20)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "規格"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Location = New System.Drawing.Point(481, 102)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 20)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "単価"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(25, 102)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 20)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "数量"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(25, 81)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 20)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "代価名称"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(25, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "代価表No."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableName
        '
        Me.TableName.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.TableName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TableName.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TableName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.TableName.Location = New System.Drawing.Point(28, 163)
        Me.TableName.Name = "TableName"
        Me.TableName.Size = New System.Drawing.Size(82, 20)
        Me.TableName.TabIndex = 60
        Me.TableName.Text = "代価内訳"
        Me.TableName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(397, 594)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "合計"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'C1SplitterPanel2
        '
        Me.C1SplitterPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.C1SplitterPanel2.Controls.Add(Me.Reference)
        Me.C1SplitterPanel2.Controls.Add(Me.ItemSelect)
        Me.C1SplitterPanel2.Controls.Add(Me.Cancel)
        Me.C1SplitterPanel2.Controls.Add(Me.Entry)
        Me.C1SplitterPanel2.Controls.Add(Me.CostCopy)
        Me.C1SplitterPanel2.Controls.Add(Me.CostCreation)
        Me.C1SplitterPanel2.Controls.Add(Me.CostModify)
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
        Me.Entry.Location = New System.Drawing.Point(780, 6)
        Me.Entry.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.Entry.Name = "Entry"
        Me.Entry.Size = New System.Drawing.Size(100, 30)
        Me.Entry.TabIndex = 41
        Me.Entry.Text = "　登　録"
        Me.Entry.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Entry.UseVisualStyleBackColor = True
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
        Me.CostCopy.Location = New System.Drawing.Point(312, 5)
        Me.CostCopy.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.CostCopy.Name = "CostCopy"
        Me.CostCopy.Size = New System.Drawing.Size(100, 30)
        Me.CostCopy.TabIndex = 55
        Me.CostCopy.Text = "　　代価コピー"
        Me.CostCopy.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CostCopy.UseVisualStyleBackColor = True
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
        Me.CostCreation.Location = New System.Drawing.Point(110, 5)
        Me.CostCreation.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.CostCreation.Name = "CostCreation"
        Me.CostCreation.Size = New System.Drawing.Size(100, 30)
        Me.CostCreation.TabIndex = 53
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
        Me.CostModify.Location = New System.Drawing.Point(211, 5)
        Me.CostModify.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.CostModify.Name = "CostModify"
        Me.CostModify.Size = New System.Drawing.Size(100, 30)
        Me.CostModify.TabIndex = 54
        Me.CostModify.Text = "　代価修正"
        Me.CostModify.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CostModify.UseVisualStyleBackColor = True
        '
        '代価表入力
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(990, 662)
        Me.Controls.Add(Me.HeadLine)
        Me.Controls.Add(Me.FormSplitContainer)
        Me.Font = New System.Drawing.Font("メイリオ", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "代価表入力"
        Me.Opacity = 0.2R
        Me.Text = "協力業者入力"
        CType(Me.BreakDownList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostSpec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostQuanity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostUnitPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostCostea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LaborCostea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialCostea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MachineCostea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubcntrctCostea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpensCostea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEdit11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEdit12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEdit13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEdit14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEdit15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.右クリックメニュー.ResumeLayout(False)
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
    Friend WithEvents BreakDownList As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents SystemTheme As C1.Win.C1Themes.C1ThemeController
    Friend WithEvents FormSplitContainer As C1.Win.C1SplitContainer.C1SplitContainer
    Friend WithEvents C1SplitterPanel1 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents C1SplitterPanel2 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents Cancel As Button
    Friend WithEvents CostNo As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CostCopy As Button
    Friend WithEvents CostModify As Button
    Friend WithEvents CostCreation As Button
    Friend WithEvents C1NumericEdit2 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents ExpensCostea As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents SubcntrctCostea As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents MachineCostea As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents MaterialCostea As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents LaborCostea As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents CostCostea As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents CostUnit As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents CostUnitPrice As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents CostQuanity As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents CostSpec As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CostName As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TableName As Label
    Friend WithEvents C1NumericEdit15 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NumericEdit14 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NumericEdit13 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NumericEdit12 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NumericEdit11 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents ItemSelect As Button
    Friend WithEvents Reference As Button
    Friend WithEvents 右クリックメニュー As ContextMenuStrip
    Friend WithEvents ItemSelectMenu As ToolStripMenuItem
    Friend WithEvents InsertMenu As ToolStripMenuItem
    Friend WithEvents CutMenu As ToolStripMenuItem
    Friend WithEvents CopyMenu As ToolStripMenuItem
    Friend WithEvents PastingMenu As ToolStripMenuItem
    Friend WithEvents CostCreateMenu As ToolStripMenuItem
    Friend WithEvents CostModifyMenu As ToolStripMenuItem
    Friend WithEvents CostCopyMenu As ToolStripMenuItem
    Friend WithEvents ReferenceMenu As ToolStripMenuItem
End Class
