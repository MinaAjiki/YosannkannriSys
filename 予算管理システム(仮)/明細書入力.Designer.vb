<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 明細書入力
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(明細書入力))
        Me.HeadLine = New System.Windows.Forms.Label()
        Me.ButtonImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.DetailsList = New C1.Win.C1FlexGrid.C1FlexGrid()
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
        Me.Delete = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemTheme = New C1.Win.C1Themes.C1ThemeController()
        Me.SWorkType = New C1.Win.C1Input.C1TextBox()
        Me.Category = New System.Windows.Forms.RadioButton()
        Me.Outsoucing = New System.Windows.Forms.RadioButton()
        Me.CategoryList = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.CategoryTotalList = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OutsoucerList = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.OutsoucerTotalList = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DetailTotal = New C1.Win.C1Input.C1NumericEdit()
        Me.FormSplitContainer = New C1.Win.C1SplitContainer.C1SplitContainer()
        Me.C1SplitterPanel1 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.SwitchingPanel = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.C1SplitterPanel2 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.Reference = New System.Windows.Forms.Button()
        Me.ItemSelect = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Entry = New System.Windows.Forms.Button()
        Me.CostCopy = New System.Windows.Forms.Button()
        Me.CostCreation = New System.Windows.Forms.Button()
        Me.CostModify = New System.Windows.Forms.Button()
        CType(Me.DetailsList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.右クリックメニュー.SuspendLayout()
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SWorkType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryTotalList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OutsoucerList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OutsoucerTotalList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.DetailTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FormSplitContainer.SuspendLayout()
        Me.C1SplitterPanel1.SuspendLayout()
        Me.SwitchingPanel.SuspendLayout()
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
        Me.HeadLine.Text = "<< 明細書入力"
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
        'DetailsList
        '
        Me.DetailsList.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.DetailsList.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Custom
        Me.DetailsList.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.DetailsList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DetailsList.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.DetailsList.ColumnInfo = resources.GetString("DetailsList.ColumnInfo")
        Me.DetailsList.ContextMenuStrip = Me.右クリックメニュー
        Me.DetailsList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.DetailsList.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.DetailsList.Location = New System.Drawing.Point(10, 65)
        Me.DetailsList.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.DetailsList.Name = "DetailsList"
        Me.DetailsList.Rows.Count = 21
        Me.DetailsList.Rows.Fixed = 3
        Me.DetailsList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DetailsList.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.DetailsList.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.DetailsList.ShowCellLabels = True
        Me.DetailsList.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.DetailsList.Size = New System.Drawing.Size(483, 506)
        Me.DetailsList.StyleInfo = resources.GetString("DetailsList.StyleInfo")
        Me.DetailsList.TabIndex = 43
        Me.SystemTheme.SetTheme(Me.DetailsList, "予算管理テーマ2")
        '
        '右クリックメニュー
        '
        Me.右クリックメニュー.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.右クリックメニュー.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItemSelectMenu, Me.InsertMenu, Me.CutMenu, Me.CopyMenu, Me.PastingMenu, Me.CostCreateMenu, Me.CostModifyMenu, Me.CostCopyMenu, Me.ReferenceMenu, Me.Delete})
        Me.右クリックメニュー.Name = "ContextMenuStrip1"
        Me.右クリックメニュー.ShowImageMargin = False
        Me.右クリックメニュー.Size = New System.Drawing.Size(198, 224)
        Me.右クリックメニュー.Text = "項目選択"
        '
        'ItemSelectMenu
        '
        Me.ItemSelectMenu.Name = "ItemSelectMenu"
        Me.ItemSelectMenu.Size = New System.Drawing.Size(197, 22)
        Me.ItemSelectMenu.Text = "項目選択"
        '
        'InsertMenu
        '
        Me.InsertMenu.Name = "InsertMenu"
        Me.InsertMenu.Size = New System.Drawing.Size(197, 22)
        Me.InsertMenu.Text = "行の挿入"
        '
        'CutMenu
        '
        Me.CutMenu.Name = "CutMenu"
        Me.CutMenu.Size = New System.Drawing.Size(197, 22)
        Me.CutMenu.Text = "行の切り取り"
        '
        'CopyMenu
        '
        Me.CopyMenu.Name = "CopyMenu"
        Me.CopyMenu.Size = New System.Drawing.Size(197, 22)
        Me.CopyMenu.Text = "行のコピー"
        '
        'PastingMenu
        '
        Me.PastingMenu.Name = "PastingMenu"
        Me.PastingMenu.Size = New System.Drawing.Size(197, 22)
        Me.PastingMenu.Text = "行の貼り付け"
        '
        'CostCreateMenu
        '
        Me.CostCreateMenu.Name = "CostCreateMenu"
        Me.CostCreateMenu.Size = New System.Drawing.Size(197, 22)
        Me.CostCreateMenu.Text = "代価表作成"
        '
        'CostModifyMenu
        '
        Me.CostModifyMenu.Name = "CostModifyMenu"
        Me.CostModifyMenu.Size = New System.Drawing.Size(197, 22)
        Me.CostModifyMenu.Text = "代価表修正"
        '
        'CostCopyMenu
        '
        Me.CostCopyMenu.Name = "CostCopyMenu"
        Me.CostCopyMenu.Size = New System.Drawing.Size(197, 22)
        Me.CostCopyMenu.Text = "代価表コピー"
        '
        'ReferenceMenu
        '
        Me.ReferenceMenu.Name = "ReferenceMenu"
        Me.ReferenceMenu.Size = New System.Drawing.Size(197, 22)
        Me.ReferenceMenu.Text = "代価表参照"
        '
        'Delete
        '
        Me.Delete.Name = "Delete"
        Me.Delete.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.Delete.Size = New System.Drawing.Size(197, 22)
        Me.Delete.Text = "ToolStripMenuItem1"
        Me.Delete.Visible = False
        '
        'SWorkType
        '
        Me.SWorkType.AutoSize = False
        Me.SWorkType.BackColor = System.Drawing.Color.White
        Me.SWorkType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SWorkType.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.SWorkType.Enabled = False
        Me.SWorkType.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.SWorkType.Location = New System.Drawing.Point(72, 40)
        Me.SWorkType.Name = "SWorkType"
        Me.SWorkType.Size = New System.Drawing.Size(173, 20)
        Me.SWorkType.TabIndex = 45
        Me.SWorkType.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.SWorkType, "予算管理テーマ")
        Me.SWorkType.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Category
        '
        Me.Category.BackColor = System.Drawing.Color.Transparent
        Me.Category.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Category.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Category.Location = New System.Drawing.Point(3, 7)
        Me.Category.Name = "Category"
        Me.Category.Size = New System.Drawing.Size(58, 20)
        Me.Category.TabIndex = 94
        Me.Category.TabStop = True
        Me.Category.Text = "費目"
        Me.SystemTheme.SetTheme(Me.Category, "(default)")
        Me.Category.UseVisualStyleBackColor = False
        '
        'Outsoucing
        '
        Me.Outsoucing.BackColor = System.Drawing.Color.Transparent
        Me.Outsoucing.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Outsoucing.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Outsoucing.Location = New System.Drawing.Point(67, 7)
        Me.Outsoucing.Name = "Outsoucing"
        Me.Outsoucing.Size = New System.Drawing.Size(57, 20)
        Me.Outsoucing.TabIndex = 95
        Me.Outsoucing.TabStop = True
        Me.Outsoucing.Text = "外注"
        Me.SystemTheme.SetTheme(Me.Outsoucing, "(default)")
        Me.Outsoucing.UseVisualStyleBackColor = False
        '
        'CategoryList
        '
        Me.CategoryList.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.Rows
        Me.CategoryList.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Custom
        Me.CategoryList.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.CategoryList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CategoryList.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.CategoryList.ColumnInfo = resources.GetString("CategoryList.ColumnInfo")
        Me.CategoryList.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CategoryList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.CategoryList.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.CategoryList.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.CategoryList.Location = New System.Drawing.Point(0, 0)
        Me.CategoryList.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.CategoryList.Name = "CategoryList"
        Me.CategoryList.Rows.Count = 22
        Me.CategoryList.Rows.Fixed = 3
        Me.CategoryList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.CategoryList.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.CategoryList.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.CategoryList.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.CategoryList.Size = New System.Drawing.Size(496, 506)
        Me.CategoryList.StyleInfo = resources.GetString("CategoryList.StyleInfo")
        Me.CategoryList.TabIndex = 96
        Me.SystemTheme.SetTheme(Me.CategoryList, "予算管理テーマ2")
        '
        'CategoryTotalList
        '
        Me.CategoryTotalList.AllowDelete = True
        Me.CategoryTotalList.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.CategoryTotalList.AllowEditing = False
        Me.CategoryTotalList.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Custom
        Me.CategoryTotalList.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.CategoryTotalList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CategoryTotalList.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.CategoryTotalList.ColumnInfo = resources.GetString("CategoryTotalList.ColumnInfo")
        Me.CategoryTotalList.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CategoryTotalList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.CategoryTotalList.Location = New System.Drawing.Point(0, 506)
        Me.CategoryTotalList.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.CategoryTotalList.Name = "CategoryTotalList"
        Me.CategoryTotalList.Rows.Count = 1
        Me.CategoryTotalList.Rows.Fixed = 0
        Me.CategoryTotalList.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.CategoryTotalList.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.CategoryTotalList.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.CategoryTotalList.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.CategoryTotalList.Size = New System.Drawing.Size(478, 21)
        Me.CategoryTotalList.StyleInfo = resources.GetString("CategoryTotalList.StyleInfo")
        Me.CategoryTotalList.TabIndex = 99
        Me.SystemTheme.SetTheme(Me.CategoryTotalList, "予算管理テーマ")
        '
        'Label3
        '
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(944, 571)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 21)
        Me.Label3.TabIndex = 100
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SystemTheme.SetTheme(Me.Label3, "(default)")
        '
        'OutsoucerList
        '
        Me.OutsoucerList.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.OutsoucerList.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Custom
        Me.OutsoucerList.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.OutsoucerList.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.OutsoucerList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.OutsoucerList.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.OutsoucerList.ColumnInfo = resources.GetString("OutsoucerList.ColumnInfo")
        Me.OutsoucerList.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.OutsoucerList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.OutsoucerList.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.OutsoucerList.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.OutsoucerList.Location = New System.Drawing.Point(0, 0)
        Me.OutsoucerList.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.OutsoucerList.Name = "OutsoucerList"
        Me.OutsoucerList.Rows.Count = 60
        Me.OutsoucerList.Rows.Fixed = 3
        Me.OutsoucerList.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.OutsoucerList.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.OutsoucerList.ShowCellLabels = True
        Me.OutsoucerList.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.OutsoucerList.Size = New System.Drawing.Size(496, 526)
        Me.OutsoucerList.StyleInfo = resources.GetString("OutsoucerList.StyleInfo")
        Me.OutsoucerList.TabIndex = 97
        Me.SystemTheme.SetTheme(Me.OutsoucerList, "予算管理テーマ2")
        '
        'OutsoucerTotalList
        '
        Me.OutsoucerTotalList.AllowDelete = True
        Me.OutsoucerTotalList.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.OutsoucerTotalList.AllowEditing = False
        Me.OutsoucerTotalList.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Custom
        Me.OutsoucerTotalList.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.OutsoucerTotalList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.OutsoucerTotalList.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.OutsoucerTotalList.ColumnInfo = resources.GetString("OutsoucerTotalList.ColumnInfo")
        Me.OutsoucerTotalList.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.OutsoucerTotalList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.OutsoucerTotalList.Location = New System.Drawing.Point(0, 506)
        Me.OutsoucerTotalList.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.OutsoucerTotalList.Name = "OutsoucerTotalList"
        Me.OutsoucerTotalList.Rows.Count = 1
        Me.OutsoucerTotalList.Rows.Fixed = 0
        Me.OutsoucerTotalList.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.OutsoucerTotalList.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.OutsoucerTotalList.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.OutsoucerTotalList.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.OutsoucerTotalList.Size = New System.Drawing.Size(478, 42)
        Me.OutsoucerTotalList.StyleInfo = resources.GetString("OutsoucerTotalList.StyleInfo")
        Me.OutsoucerTotalList.TabIndex = 102
        Me.SystemTheme.SetTheme(Me.OutsoucerTotalList, "予算管理テーマ")
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.OutsoucerTotalList)
        Me.Panel3.Controls.Add(Me.CategoryTotalList)
        Me.Panel3.Controls.Add(Me.CategoryList)
        Me.Panel3.Controls.Add(Me.OutsoucerList)
        Me.Panel3.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.Panel3.Location = New System.Drawing.Point(466, 65)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(507, 554)
        Me.Panel3.TabIndex = 97
        '
        'DetailTotal
        '
        Me.DetailTotal.AutoSize = False
        Me.DetailTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.DetailTotal.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DetailTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.DetailTotal.Calculator.BackColor = System.Drawing.Color.White
        Me.DetailTotal.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.DetailTotal.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.System
        Me.DetailTotal.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.DetailTotal.DataType = GetType(Long)
        Me.DetailTotal.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.DetailTotal.DisplayFormat.CustomFormat = "#,###"
        Me.DetailTotal.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.DetailTotal.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.DetailTotal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailTotal.GapHeight = 0
        Me.DetailTotal.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.DetailTotal.Location = New System.Drawing.Point(355, 571)
        Me.DetailTotal.Name = "DetailTotal"
        Me.DetailTotal.ReadOnly = True
        Me.DetailTotal.Size = New System.Drawing.Size(111, 20)
        Me.DetailTotal.TabIndex = 48
        Me.DetailTotal.Tag = Nothing
        Me.DetailTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DetailTotal.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.DetailTotal.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
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
        Me.C1SplitterPanel1.Controls.Add(Me.SwitchingPanel)
        Me.C1SplitterPanel1.Controls.Add(Me.DetailTotal)
        Me.C1SplitterPanel1.Controls.Add(Me.Label3)
        Me.C1SplitterPanel1.Controls.Add(Me.Label2)
        Me.C1SplitterPanel1.Controls.Add(Me.SWorkType)
        Me.C1SplitterPanel1.Controls.Add(Me.Label1)
        Me.C1SplitterPanel1.Controls.Add(Me.Panel3)
        Me.C1SplitterPanel1.Controls.Add(Me.DetailsList)
        Me.C1SplitterPanel1.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
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
        'SwitchingPanel
        '
        Me.SwitchingPanel.Controls.Add(Me.Outsoucing)
        Me.SwitchingPanel.Controls.Add(Me.Category)
        Me.SwitchingPanel.Location = New System.Drawing.Point(827, 33)
        Me.SwitchingPanel.Name = "SwitchingPanel"
        Me.SwitchingPanel.Size = New System.Drawing.Size(127, 28)
        Me.SwitchingPanel.TabIndex = 95
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(282, 571)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
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
        Me.Label1.Location = New System.Drawing.Point(11, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "小工種名"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'Reference
        '
        Me.Reference.FlatAppearance.BorderSize = 0
        Me.Reference.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Reference.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Reference.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Reference.ImageIndex = 0
        Me.Reference.ImageList = Me.ButtonImageList
        Me.Reference.Location = New System.Drawing.Point(412, 5)
        Me.Reference.Margin = New System.Windows.Forms.Padding(0)
        Me.Reference.Name = "Reference"
        Me.Reference.Size = New System.Drawing.Size(100, 30)
        Me.Reference.TabIndex = 102
        Me.Reference.Text = "代価表参照"
        Me.Reference.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Reference.UseVisualStyleBackColor = True
        '
        'ItemSelect
        '
        Me.ItemSelect.FlatAppearance.BorderSize = 0
        Me.ItemSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ItemSelect.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ItemSelect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ItemSelect.ImageIndex = 0
        Me.ItemSelect.ImageList = Me.ButtonImageList
        Me.ItemSelect.Location = New System.Drawing.Point(8, 5)
        Me.ItemSelect.Margin = New System.Windows.Forms.Padding(0)
        Me.ItemSelect.Name = "ItemSelect"
        Me.ItemSelect.Size = New System.Drawing.Size(100, 30)
        Me.ItemSelect.TabIndex = 101
        Me.ItemSelect.Text = "項目選択"
        Me.ItemSelect.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ItemSelect.UseVisualStyleBackColor = True
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
        Me.CostCopy.Location = New System.Drawing.Point(311, 5)
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
        Me.CostCreation.Location = New System.Drawing.Point(109, 5)
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
        Me.CostModify.Location = New System.Drawing.Point(210, 5)
        Me.CostModify.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.CostModify.Name = "CostModify"
        Me.CostModify.Size = New System.Drawing.Size(100, 30)
        Me.CostModify.TabIndex = 54
        Me.CostModify.Text = "　代価修正"
        Me.CostModify.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CostModify.UseVisualStyleBackColor = True
        '
        '明細書入力
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(990, 662)
        Me.Controls.Add(Me.HeadLine)
        Me.Controls.Add(Me.FormSplitContainer)
        Me.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "明細書入力"
        Me.Opacity = 0.2R
        Me.Text = "協力業者入力"
        CType(Me.DetailsList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.右クリックメニュー.ResumeLayout(False)
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SWorkType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryTotalList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OutsoucerList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OutsoucerTotalList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.DetailTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FormSplitContainer.ResumeLayout(False)
        Me.C1SplitterPanel1.ResumeLayout(False)
        Me.SwitchingPanel.ResumeLayout(False)
        Me.C1SplitterPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HeadLine As Label
    Friend WithEvents ButtonImageList As ImageList
    Friend WithEvents Entry As Button
    Friend WithEvents DetailsList As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents SystemTheme As C1.Win.C1Themes.C1ThemeController
    Friend WithEvents FormSplitContainer As C1.Win.C1SplitContainer.C1SplitContainer
    Friend WithEvents C1SplitterPanel1 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents C1SplitterPanel2 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents Cancel As Button
    Friend WithEvents SWorkType As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DetailTotal As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label2 As Label
    Friend WithEvents CostCopy As Button
    Friend WithEvents CostModify As Button
    Friend WithEvents CostCreation As Button
    Friend WithEvents SwitchingPanel As Panel
    Friend WithEvents Outsoucing As RadioButton
    Friend WithEvents Category As RadioButton
    Friend WithEvents CategoryList As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Panel3 As Panel
    Friend WithEvents OutsoucerList As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents CategoryTotalList As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label3 As Label
    Friend WithEvents 右クリックメニュー As ContextMenuStrip
    Friend WithEvents CostCreateMenu As ToolStripMenuItem
    Friend WithEvents ItemSelectMenu As ToolStripMenuItem
    Friend WithEvents InsertMenu As ToolStripMenuItem
    Friend WithEvents CopyMenu As ToolStripMenuItem
    Friend WithEvents PastingMenu As ToolStripMenuItem
    Friend WithEvents CutMenu As ToolStripMenuItem
    Friend WithEvents CostModifyMenu As ToolStripMenuItem
    Friend WithEvents CostCopyMenu As ToolStripMenuItem
    Friend WithEvents ReferenceMenu As ToolStripMenuItem
    Friend WithEvents ItemSelect As Button
    Friend WithEvents Reference As Button

    Friend WithEvents OutsoucerTotalList As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Delete As ToolStripMenuItem
End Class
