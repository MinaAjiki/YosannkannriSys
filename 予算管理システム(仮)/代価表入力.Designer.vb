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
        Me.DetailsList = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.SystemTheme = New C1.Win.C1Themes.C1ThemeController()
        Me.C1TextBox1 = New C1.Win.C1Input.C1TextBox()
        Me.C1NumericEdit2 = New C1.Win.C1Input.C1NumericEdit()
        Me.C1TextBox2 = New C1.Win.C1Input.C1TextBox()
        Me.C1TextBox3 = New C1.Win.C1Input.C1TextBox()
        Me.C1NumericEdit1 = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NumericEdit3 = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NumericEdit4 = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NumericEdit5 = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NumericEdit6 = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NumericEdit7 = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NumericEdit8 = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NumericEdit9 = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NumericEdit10 = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NumericEdit11 = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NumericEdit12 = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NumericEdit13 = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NumericEdit14 = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NumericEdit15 = New C1.Win.C1Input.C1NumericEdit()
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
        CType(Me.DetailsList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEdit8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEdit9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEdit10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEdit11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEdit12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEdit13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEdit14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEdit15, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'DetailsList
        '
        Me.DetailsList.AllowDelete = True
        Me.DetailsList.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.DetailsList.AllowEditing = False
        Me.DetailsList.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Custom
        Me.DetailsList.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.DetailsList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DetailsList.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.DetailsList.ColumnInfo = resources.GetString("DetailsList.ColumnInfo")
        Me.DetailsList.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.DetailsList.Location = New System.Drawing.Point(28, 184)
        Me.DetailsList.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.DetailsList.Name = "DetailsList"
        Me.DetailsList.Rows.Count = 25
        Me.DetailsList.Rows.Fixed = 3
        Me.DetailsList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DetailsList.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.DetailsList.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.DetailsList.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.DetailsList.Size = New System.Drawing.Size(936, 408)
        Me.DetailsList.TabIndex = 43
        Me.SystemTheme.SetTheme(Me.DetailsList, "予算管理テーマ")
        '
        'C1TextBox1
        '
        Me.C1TextBox1.AutoSize = False
        Me.C1TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.C1TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1TextBox1.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.C1TextBox1.Enabled = False
        Me.C1TextBox1.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1TextBox1.Location = New System.Drawing.Point(99, 60)
        Me.C1TextBox1.Name = "C1TextBox1"
        Me.C1TextBox1.Size = New System.Drawing.Size(173, 20)
        Me.C1TextBox1.TabIndex = 45
        Me.C1TextBox1.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.C1TextBox1, "予算管理テーマ")
        Me.C1TextBox1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
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
        'C1TextBox2
        '
        Me.C1TextBox2.AutoSize = False
        Me.C1TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.C1TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1TextBox2.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.C1TextBox2.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1TextBox2.Location = New System.Drawing.Point(99, 81)
        Me.C1TextBox2.Name = "C1TextBox2"
        Me.C1TextBox2.Size = New System.Drawing.Size(228, 20)
        Me.C1TextBox2.TabIndex = 63
        Me.C1TextBox2.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.C1TextBox2, "予算管理テーマ")
        Me.C1TextBox2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'C1TextBox3
        '
        Me.C1TextBox3.AutoSize = False
        Me.C1TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.C1TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1TextBox3.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.C1TextBox3.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1TextBox3.Location = New System.Drawing.Point(402, 81)
        Me.C1TextBox3.Name = "C1TextBox3"
        Me.C1TextBox3.Size = New System.Drawing.Size(543, 20)
        Me.C1TextBox3.TabIndex = 70
        Me.C1TextBox3.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.C1TextBox3, "予算管理テーマ")
        Me.C1TextBox3.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'C1NumericEdit1
        '
        Me.C1NumericEdit1.AutoSize = False
        Me.C1NumericEdit1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.C1NumericEdit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.C1NumericEdit1.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.C1NumericEdit1.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1NumericEdit1.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1NumericEdit1.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1NumericEdit1.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.C1NumericEdit1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.C1NumericEdit1.GapHeight = 0
        Me.C1NumericEdit1.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NumericEdit1.Location = New System.Drawing.Point(66, 102)
        Me.C1NumericEdit1.Name = "C1NumericEdit1"
        Me.C1NumericEdit1.Size = New System.Drawing.Size(110, 20)
        Me.C1NumericEdit1.TabIndex = 71
        Me.C1NumericEdit1.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.C1NumericEdit1, "予算管理テーマ")
        Me.C1NumericEdit1.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.C1NumericEdit1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'C1NumericEdit3
        '
        Me.C1NumericEdit3.AutoSize = False
        Me.C1NumericEdit3.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.C1NumericEdit3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.C1NumericEdit3.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.C1NumericEdit3.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1NumericEdit3.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1NumericEdit3.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1NumericEdit3.DataType = GetType(Long)
        Me.C1NumericEdit3.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.C1NumericEdit3.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.C1NumericEdit3.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.C1NumericEdit3.GapHeight = 0
        Me.C1NumericEdit3.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NumericEdit3.Location = New System.Drawing.Point(370, 102)
        Me.C1NumericEdit3.Name = "C1NumericEdit3"
        Me.C1NumericEdit3.Size = New System.Drawing.Size(110, 20)
        Me.C1NumericEdit3.TabIndex = 72
        Me.C1NumericEdit3.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.C1NumericEdit3, "予算管理テーマ")
        Me.C1NumericEdit3.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.C1NumericEdit3.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'C1NumericEdit4
        '
        Me.C1NumericEdit4.AutoSize = False
        Me.C1NumericEdit4.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.C1NumericEdit4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.C1NumericEdit4.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.C1NumericEdit4.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1NumericEdit4.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1NumericEdit4.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1NumericEdit4.DataType = GetType(Long)
        Me.C1NumericEdit4.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.C1NumericEdit4.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.C1NumericEdit4.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.C1NumericEdit4.GapHeight = 0
        Me.C1NumericEdit4.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NumericEdit4.Location = New System.Drawing.Point(218, 102)
        Me.C1NumericEdit4.Name = "C1NumericEdit4"
        Me.C1NumericEdit4.Size = New System.Drawing.Size(110, 20)
        Me.C1NumericEdit4.TabIndex = 73
        Me.C1NumericEdit4.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.C1NumericEdit4, "予算管理テーマ")
        Me.C1NumericEdit4.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.C1NumericEdit4.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'C1NumericEdit5
        '
        Me.C1NumericEdit5.AutoSize = False
        Me.C1NumericEdit5.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.C1NumericEdit5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.C1NumericEdit5.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.C1NumericEdit5.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1NumericEdit5.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1NumericEdit5.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1NumericEdit5.DataType = GetType(Long)
        Me.C1NumericEdit5.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.C1NumericEdit5.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.C1NumericEdit5.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.C1NumericEdit5.GapHeight = 0
        Me.C1NumericEdit5.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NumericEdit5.Location = New System.Drawing.Point(522, 102)
        Me.C1NumericEdit5.Name = "C1NumericEdit5"
        Me.C1NumericEdit5.Size = New System.Drawing.Size(110, 20)
        Me.C1NumericEdit5.TabIndex = 74
        Me.C1NumericEdit5.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.C1NumericEdit5, "予算管理テーマ")
        Me.C1NumericEdit5.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.C1NumericEdit5.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'C1NumericEdit6
        '
        Me.C1NumericEdit6.AutoSize = False
        Me.C1NumericEdit6.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.C1NumericEdit6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.C1NumericEdit6.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.C1NumericEdit6.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1NumericEdit6.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1NumericEdit6.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1NumericEdit6.DataType = GetType(Long)
        Me.C1NumericEdit6.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.C1NumericEdit6.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.C1NumericEdit6.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.C1NumericEdit6.GapHeight = 0
        Me.C1NumericEdit6.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NumericEdit6.Location = New System.Drawing.Point(470, 163)
        Me.C1NumericEdit6.Name = "C1NumericEdit6"
        Me.C1NumericEdit6.Size = New System.Drawing.Size(95, 20)
        Me.C1NumericEdit6.TabIndex = 75
        Me.C1NumericEdit6.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.C1NumericEdit6, "予算管理テーマ")
        Me.C1NumericEdit6.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.C1NumericEdit6.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'C1NumericEdit7
        '
        Me.C1NumericEdit7.AutoSize = False
        Me.C1NumericEdit7.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.C1NumericEdit7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.C1NumericEdit7.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.C1NumericEdit7.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1NumericEdit7.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1NumericEdit7.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1NumericEdit7.DataType = GetType(Long)
        Me.C1NumericEdit7.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.C1NumericEdit7.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.C1NumericEdit7.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.C1NumericEdit7.GapHeight = 0
        Me.C1NumericEdit7.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NumericEdit7.Location = New System.Drawing.Point(565, 163)
        Me.C1NumericEdit7.Name = "C1NumericEdit7"
        Me.C1NumericEdit7.Size = New System.Drawing.Size(95, 20)
        Me.C1NumericEdit7.TabIndex = 76
        Me.C1NumericEdit7.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.C1NumericEdit7, "予算管理テーマ")
        Me.C1NumericEdit7.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.C1NumericEdit7.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'C1NumericEdit8
        '
        Me.C1NumericEdit8.AutoSize = False
        Me.C1NumericEdit8.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.C1NumericEdit8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.C1NumericEdit8.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.C1NumericEdit8.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1NumericEdit8.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1NumericEdit8.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1NumericEdit8.DataType = GetType(Long)
        Me.C1NumericEdit8.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.C1NumericEdit8.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.C1NumericEdit8.GapHeight = 0
        Me.C1NumericEdit8.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NumericEdit8.Location = New System.Drawing.Point(660, 163)
        Me.C1NumericEdit8.Name = "C1NumericEdit8"
        Me.C1NumericEdit8.Size = New System.Drawing.Size(95, 20)
        Me.C1NumericEdit8.TabIndex = 77
        Me.C1NumericEdit8.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.C1NumericEdit8, "予算管理テーマ")
        Me.C1NumericEdit8.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.C1NumericEdit8.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'C1NumericEdit9
        '
        Me.C1NumericEdit9.AutoSize = False
        Me.C1NumericEdit9.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.C1NumericEdit9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.C1NumericEdit9.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.C1NumericEdit9.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1NumericEdit9.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1NumericEdit9.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1NumericEdit9.DataType = GetType(Long)
        Me.C1NumericEdit9.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.C1NumericEdit9.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.C1NumericEdit9.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.C1NumericEdit9.GapHeight = 0
        Me.C1NumericEdit9.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NumericEdit9.Location = New System.Drawing.Point(755, 163)
        Me.C1NumericEdit9.Name = "C1NumericEdit9"
        Me.C1NumericEdit9.Size = New System.Drawing.Size(95, 20)
        Me.C1NumericEdit9.TabIndex = 78
        Me.C1NumericEdit9.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.C1NumericEdit9, "予算管理テーマ")
        Me.C1NumericEdit9.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.C1NumericEdit9.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'C1NumericEdit10
        '
        Me.C1NumericEdit10.AutoSize = False
        Me.C1NumericEdit10.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.C1NumericEdit10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.C1NumericEdit10.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.C1NumericEdit10.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1NumericEdit10.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1NumericEdit10.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1NumericEdit10.DataType = GetType(Long)
        Me.C1NumericEdit10.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.C1NumericEdit10.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.C1NumericEdit10.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.C1NumericEdit10.GapHeight = 0
        Me.C1NumericEdit10.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NumericEdit10.Location = New System.Drawing.Point(850, 163)
        Me.C1NumericEdit10.Name = "C1NumericEdit10"
        Me.C1NumericEdit10.Size = New System.Drawing.Size(95, 20)
        Me.C1NumericEdit10.TabIndex = 79
        Me.C1NumericEdit10.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.C1NumericEdit10, "予算管理テーマ")
        Me.C1NumericEdit10.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.C1NumericEdit10.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'C1NumericEdit11
        '
        Me.C1NumericEdit11.AutoSize = False
        Me.C1NumericEdit11.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.C1NumericEdit11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.C1NumericEdit11.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.C1NumericEdit11.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1NumericEdit11.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1NumericEdit11.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1NumericEdit11.DataType = GetType(Long)
        Me.C1NumericEdit11.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
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
        Me.C1NumericEdit12.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.C1NumericEdit12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.C1NumericEdit12.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.C1NumericEdit12.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1NumericEdit12.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1NumericEdit12.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1NumericEdit12.DataType = GetType(Long)
        Me.C1NumericEdit12.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
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
        Me.C1NumericEdit13.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.C1NumericEdit13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.C1NumericEdit13.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.C1NumericEdit13.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1NumericEdit13.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1NumericEdit13.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1NumericEdit13.DataType = GetType(Long)
        Me.C1NumericEdit13.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
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
        Me.C1NumericEdit14.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.C1NumericEdit14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.C1NumericEdit14.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.C1NumericEdit14.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1NumericEdit14.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1NumericEdit14.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1NumericEdit14.DataType = GetType(Long)
        Me.C1NumericEdit14.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
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
        Me.C1NumericEdit15.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.C1NumericEdit15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.C1NumericEdit15.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.C1NumericEdit15.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1NumericEdit15.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1NumericEdit15.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1NumericEdit15.DataType = GetType(Long)
        Me.C1NumericEdit15.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
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
        Me.C1SplitterPanel1.Controls.Add(Me.C1NumericEdit10)
        Me.C1SplitterPanel1.Controls.Add(Me.C1NumericEdit9)
        Me.C1SplitterPanel1.Controls.Add(Me.C1NumericEdit8)
        Me.C1SplitterPanel1.Controls.Add(Me.C1NumericEdit7)
        Me.C1SplitterPanel1.Controls.Add(Me.C1NumericEdit6)
        Me.C1SplitterPanel1.Controls.Add(Me.C1NumericEdit5)
        Me.C1SplitterPanel1.Controls.Add(Me.C1NumericEdit4)
        Me.C1SplitterPanel1.Controls.Add(Me.C1NumericEdit3)
        Me.C1SplitterPanel1.Controls.Add(Me.C1NumericEdit1)
        Me.C1SplitterPanel1.Controls.Add(Me.C1TextBox3)
        Me.C1SplitterPanel1.Controls.Add(Me.Label9)
        Me.C1SplitterPanel1.Controls.Add(Me.Label8)
        Me.C1SplitterPanel1.Controls.Add(Me.Label7)
        Me.C1SplitterPanel1.Controls.Add(Me.Label6)
        Me.C1SplitterPanel1.Controls.Add(Me.Label5)
        Me.C1SplitterPanel1.Controls.Add(Me.Label4)
        Me.C1SplitterPanel1.Controls.Add(Me.C1TextBox2)
        Me.C1SplitterPanel1.Controls.Add(Me.Label3)
        Me.C1SplitterPanel1.Controls.Add(Me.Label1)
        Me.C1SplitterPanel1.Controls.Add(Me.TableName)
        Me.C1SplitterPanel1.Controls.Add(Me.Label2)
        Me.C1SplitterPanel1.Controls.Add(Me.C1TextBox1)
        Me.C1SplitterPanel1.Controls.Add(Me.DetailsList)
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
        Me.CostCopy.Location = New System.Drawing.Point(206, 5)
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
        Me.CostCreation.Location = New System.Drawing.Point(4, 5)
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
        Me.CostModify.Location = New System.Drawing.Point(105, 5)
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
        CType(Me.DetailsList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEdit8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEdit9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEdit10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEdit11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEdit12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEdit13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEdit14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEdit15, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DetailsList As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents SystemTheme As C1.Win.C1Themes.C1ThemeController
    Friend WithEvents FormSplitContainer As C1.Win.C1SplitContainer.C1SplitContainer
    Friend WithEvents C1SplitterPanel1 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents C1SplitterPanel2 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents Cancel As Button
    Friend WithEvents C1TextBox1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CostCopy As Button
    Friend WithEvents CostModify As Button
    Friend WithEvents CostCreation As Button
    Friend WithEvents C1NumericEdit2 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NumericEdit10 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NumericEdit9 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NumericEdit8 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NumericEdit7 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NumericEdit6 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NumericEdit5 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NumericEdit4 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NumericEdit3 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NumericEdit1 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1TextBox3 As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents C1TextBox2 As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TableName As Label
    Friend WithEvents C1NumericEdit15 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NumericEdit14 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NumericEdit13 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NumericEdit12 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NumericEdit11 As C1.Win.C1Input.C1NumericEdit
End Class
