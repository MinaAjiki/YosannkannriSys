<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 予算総括入力
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(予算総括入力))
        Me.HeadLine = New System.Windows.Forms.Label()
        Me.ButtonImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.SystemTheme = New C1.Win.C1Themes.C1ThemeController()
        Me.C1ComboBox1 = New C1.Win.C1Input.C1ComboBox()
        Me.C1TextBox1 = New C1.Win.C1Input.C1TextBox()
        Me.C1TextBox2 = New C1.Win.C1Input.C1TextBox()
        Me.C1TextBox3 = New C1.Win.C1Input.C1TextBox()
        Me.C1TextBox4 = New C1.Win.C1Input.C1TextBox()
        Me.C1DateEdit1 = New C1.Win.C1Input.C1DateEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.C1DateEdit2 = New C1.Win.C1Input.C1DateEdit()
        Me.C1TextBox6 = New C1.Win.C1Input.C1TextBox()
        Me.C1NumericEdit1 = New C1.Win.C1Input.C1NumericEdit()
        Me.C1DateEdit3 = New C1.Win.C1Input.C1DateEdit()
        Me.C1TextBox5 = New C1.Win.C1Input.C1TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.C1TextBox7 = New C1.Win.C1Input.C1TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.C1TextBox8 = New C1.Win.C1Input.C1TextBox()
        Me.FormSplitContainer = New C1.Win.C1SplitContainer.C1SplitContainer()
        Me.FormPanel = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FooterPanel = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.Entry = New System.Windows.Forms.Button()
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1ComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1DateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1DateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NumericEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1DateEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FormSplitContainer.SuspendLayout()
        Me.FormPanel.SuspendLayout()
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
        Me.HeadLine.Size = New System.Drawing.Size(104, 18)
        Me.HeadLine.TabIndex = 25
        Me.HeadLine.Text = "<< 予算総括入力"
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
        'C1ComboBox1
        '
        Me.C1ComboBox1.AllowSpinLoop = False
        Me.C1ComboBox1.AutoCompleteCustomSource.AddRange(New String() {"10", "11", "12", "13", "14", "15"})
        Me.C1ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.C1ComboBox1.AutoSize = False
        Me.C1ComboBox1.BackColor = System.Drawing.Color.White
        Me.C1ComboBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1ComboBox1.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.C1ComboBox1.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1ComboBox1.GapHeight = 0
        Me.C1ComboBox1.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1ComboBox1.Items.Add("市川工務店")
        Me.C1ComboBox1.Items.Add("巴産業")
        Me.C1ComboBox1.Items.Add("岐阜アイシー")
        Me.C1ComboBox1.Items.Add("岐阜北建設")
        Me.C1ComboBox1.Items.Add("飛高建設")
        Me.C1ComboBox1.Items.Add("広小路建設")
        Me.C1ComboBox1.Location = New System.Drawing.Point(88, 49)
        Me.C1ComboBox1.Name = "C1ComboBox1"
        Me.C1ComboBox1.Size = New System.Drawing.Size(100, 20)
        Me.C1ComboBox1.Style.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1ComboBox1.TabIndex = 28
        Me.C1ComboBox1.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.C1ComboBox1, "予算管理テーマ")
        Me.C1ComboBox1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'C1TextBox1
        '
        Me.C1TextBox1.AutoSize = False
        Me.C1TextBox1.BackColor = System.Drawing.Color.White
        Me.C1TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1TextBox1.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.C1TextBox1.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1TextBox1.Location = New System.Drawing.Point(88, 70)
        Me.C1TextBox1.Name = "C1TextBox1"
        Me.C1TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.C1TextBox1.TabIndex = 30
        Me.C1TextBox1.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.C1TextBox1, "予算管理テーマ")
        Me.C1TextBox1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'C1TextBox2
        '
        Me.C1TextBox2.AutoSize = False
        Me.C1TextBox2.BackColor = System.Drawing.Color.White
        Me.C1TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1TextBox2.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.C1TextBox2.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1TextBox2.Location = New System.Drawing.Point(260, 70)
        Me.C1TextBox2.Name = "C1TextBox2"
        Me.C1TextBox2.Size = New System.Drawing.Size(200, 20)
        Me.C1TextBox2.TabIndex = 32
        Me.C1TextBox2.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.C1TextBox2, "予算管理テーマ")
        Me.C1TextBox2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'C1TextBox3
        '
        Me.C1TextBox3.AutoSize = False
        Me.C1TextBox3.BackColor = System.Drawing.Color.White
        Me.C1TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1TextBox3.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.C1TextBox3.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1TextBox3.Location = New System.Drawing.Point(88, 91)
        Me.C1TextBox3.Name = "C1TextBox3"
        Me.C1TextBox3.Size = New System.Drawing.Size(372, 20)
        Me.C1TextBox3.TabIndex = 34
        Me.C1TextBox3.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.C1TextBox3, "予算管理テーマ")
        Me.C1TextBox3.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'C1TextBox4
        '
        Me.C1TextBox4.AutoSize = False
        Me.C1TextBox4.BackColor = System.Drawing.Color.White
        Me.C1TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1TextBox4.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.C1TextBox4.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1TextBox4.Location = New System.Drawing.Point(88, 112)
        Me.C1TextBox4.Name = "C1TextBox4"
        Me.C1TextBox4.Size = New System.Drawing.Size(372, 20)
        Me.C1TextBox4.TabIndex = 36
        Me.C1TextBox4.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.C1TextBox4, "予算管理テーマ")
        Me.C1TextBox4.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'C1DateEdit1
        '
        Me.C1DateEdit1.AutoSize = False
        Me.C1DateEdit1.BackColor = System.Drawing.Color.White
        Me.C1DateEdit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.C1DateEdit1.Calendar.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.C1DateEdit1.Calendar.BackColor = System.Drawing.Color.White
        Me.C1DateEdit1.Calendar.DayNamesColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.C1DateEdit1.Calendar.DayNamesFont = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1DateEdit1.Calendar.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1DateEdit1.Calendar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.C1DateEdit1.Calendar.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.C1DateEdit1.Calendar.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.C1DateEdit1.Calendar.ShowClearButton = False
        Me.C1DateEdit1.Calendar.ShowTodayButton = False
        Me.C1DateEdit1.Calendar.TitleBackColor = System.Drawing.Color.White
        Me.C1DateEdit1.Calendar.TitleFont = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1DateEdit1.Calendar.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.C1DateEdit1.Calendar.TodayBorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.C1DateEdit1.Calendar.TrailingForeColor = System.Drawing.SystemColors.GrayText
        Me.C1DateEdit1.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1DateEdit1.Culture = 1041
        Me.C1DateEdit1.CustomFormat = "yyyy/MM/dd"
        Me.C1DateEdit1.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.C1DateEdit1.DisplayFormat.CustomFormat = "yyyy/MM/dd"
        Me.C1DateEdit1.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1DateEdit1.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.C1DateEdit1.EditFormat.CustomFormat = "yyyy/MM/dd"
        Me.C1DateEdit1.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1DateEdit1.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.C1DateEdit1.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1DateEdit1.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1DateEdit1.GapHeight = 0
        Me.C1DateEdit1.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1DateEdit1.Location = New System.Drawing.Point(88, 133)
        Me.C1DateEdit1.Name = "C1DateEdit1"
        Me.C1DateEdit1.Size = New System.Drawing.Size(120, 20)
        Me.C1DateEdit1.TabIndex = 39
        Me.C1DateEdit1.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.C1DateEdit1, "予算管理テーマ")
        Me.C1DateEdit1.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        Me.C1DateEdit1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(209, 133)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 20)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "～"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SystemTheme.SetTheme(Me.Label7, "(default)")
        '
        'C1DateEdit2
        '
        Me.C1DateEdit2.AutoSize = False
        Me.C1DateEdit2.BackColor = System.Drawing.Color.White
        Me.C1DateEdit2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.C1DateEdit2.Calendar.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.C1DateEdit2.Calendar.BackColor = System.Drawing.Color.White
        Me.C1DateEdit2.Calendar.DayNamesColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.C1DateEdit2.Calendar.DayNamesFont = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1DateEdit2.Calendar.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1DateEdit2.Calendar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.C1DateEdit2.Calendar.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.C1DateEdit2.Calendar.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.C1DateEdit2.Calendar.ShowClearButton = False
        Me.C1DateEdit2.Calendar.ShowTodayButton = False
        Me.C1DateEdit2.Calendar.TitleBackColor = System.Drawing.Color.White
        Me.C1DateEdit2.Calendar.TitleFont = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1DateEdit2.Calendar.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.C1DateEdit2.Calendar.TodayBorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.C1DateEdit2.Calendar.TrailingForeColor = System.Drawing.SystemColors.GrayText
        Me.C1DateEdit2.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1DateEdit2.CustomFormat = "yyyy/MM/dd"
        Me.C1DateEdit2.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.C1DateEdit2.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1DateEdit2.DisplayFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.C1DateEdit2.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1DateEdit2.EditFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.C1DateEdit2.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1DateEdit2.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1DateEdit2.GapHeight = 0
        Me.C1DateEdit2.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1DateEdit2.Location = New System.Drawing.Point(228, 133)
        Me.C1DateEdit2.Name = "C1DateEdit2"
        Me.C1DateEdit2.Size = New System.Drawing.Size(120, 20)
        Me.C1DateEdit2.TabIndex = 41
        Me.C1DateEdit2.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.C1DateEdit2, "予算管理テーマ")
        Me.C1DateEdit2.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        Me.C1DateEdit2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'C1TextBox6
        '
        Me.C1TextBox6.BackColor = System.Drawing.Color.White
        Me.C1TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1TextBox6.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.C1TextBox6.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1TextBox6.Location = New System.Drawing.Point(88, 175)
        Me.C1TextBox6.Multiline = True
        Me.C1TextBox6.Name = "C1TextBox6"
        Me.C1TextBox6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.C1TextBox6.Size = New System.Drawing.Size(120, 40)
        Me.C1TextBox6.TabIndex = 45
        Me.C1TextBox6.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.C1TextBox6, "予算管理テーマ")
        Me.C1TextBox6.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
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
        Me.C1NumericEdit1.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.C1NumericEdit1.DisplayFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.C1NumericEdit1.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.C1NumericEdit1.EditFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.C1NumericEdit1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.C1NumericEdit1.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.C1NumericEdit1.GapHeight = 0
        Me.C1NumericEdit1.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1NumericEdit1.Location = New System.Drawing.Point(88, 154)
        Me.C1NumericEdit1.Name = "C1NumericEdit1"
        Me.C1NumericEdit1.Size = New System.Drawing.Size(120, 20)
        Me.C1NumericEdit1.TabIndex = 46
        Me.C1NumericEdit1.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.C1NumericEdit1, "予算管理テーマ")
        Me.C1NumericEdit1.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.C1NumericEdit1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'C1DateEdit3
        '
        Me.C1DateEdit3.AutoSize = False
        Me.C1DateEdit3.BackColor = System.Drawing.Color.White
        Me.C1DateEdit3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.C1DateEdit3.Calendar.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.C1DateEdit3.Calendar.BackColor = System.Drawing.Color.White
        Me.C1DateEdit3.Calendar.DayNamesColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.C1DateEdit3.Calendar.DayNamesFont = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1DateEdit3.Calendar.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1DateEdit3.Calendar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.C1DateEdit3.Calendar.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.C1DateEdit3.Calendar.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.C1DateEdit3.Calendar.ShowClearButton = False
        Me.C1DateEdit3.Calendar.ShowTodayButton = False
        Me.C1DateEdit3.Calendar.TitleBackColor = System.Drawing.Color.White
        Me.C1DateEdit3.Calendar.TitleFont = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1DateEdit3.Calendar.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.C1DateEdit3.Calendar.TodayBorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.C1DateEdit3.Calendar.TrailingForeColor = System.Drawing.SystemColors.GrayText
        Me.C1DateEdit3.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1DateEdit3.CustomFormat = "yyyy/MM/dd"
        Me.C1DateEdit3.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.C1DateEdit3.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1DateEdit3.DisplayFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.C1DateEdit3.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1DateEdit3.EditFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.C1DateEdit3.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1DateEdit3.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1DateEdit3.GapHeight = 0
        Me.C1DateEdit3.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1DateEdit3.Location = New System.Drawing.Point(88, 216)
        Me.C1DateEdit3.Name = "C1DateEdit3"
        Me.C1DateEdit3.Size = New System.Drawing.Size(120, 20)
        Me.C1DateEdit3.TabIndex = 48
        Me.C1DateEdit3.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.C1DateEdit3, "予算管理テーマ")
        Me.C1DateEdit3.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.C1DateEdit3.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'C1TextBox5
        '
        Me.C1TextBox5.BackColor = System.Drawing.Color.White
        Me.C1TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1TextBox5.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.C1TextBox5.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1TextBox5.Location = New System.Drawing.Point(88, 237)
        Me.C1TextBox5.Multiline = True
        Me.C1TextBox5.Name = "C1TextBox5"
        Me.C1TextBox5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.C1TextBox5.Size = New System.Drawing.Size(372, 70)
        Me.C1TextBox5.TabIndex = 50
        Me.C1TextBox5.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.C1TextBox5, "予算管理テーマ")
        Me.C1TextBox5.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Label12
        '
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(17, 308)
        Me.Label12.Margin = New System.Windows.Forms.Padding(0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 70)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "特記事項"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SystemTheme.SetTheme(Me.Label12, "(default)")
        '
        'C1TextBox7
        '
        Me.C1TextBox7.AutoSize = False
        Me.C1TextBox7.BackColor = System.Drawing.Color.White
        Me.C1TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1TextBox7.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.C1TextBox7.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1TextBox7.Location = New System.Drawing.Point(88, 308)
        Me.C1TextBox7.Multiline = True
        Me.C1TextBox7.Name = "C1TextBox7"
        Me.C1TextBox7.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.C1TextBox7.Size = New System.Drawing.Size(372, 70)
        Me.C1TextBox7.TabIndex = 52
        Me.C1TextBox7.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.C1TextBox7, "予算管理テーマ")
        Me.C1TextBox7.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Label13
        '
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(17, 379)
        Me.Label13.Margin = New System.Windows.Forms.Padding(0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 70)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "県内・市内" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "業者への" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "下請率"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SystemTheme.SetTheme(Me.Label13, "(default)")
        '
        'C1TextBox8
        '
        Me.C1TextBox8.AutoSize = False
        Me.C1TextBox8.BackColor = System.Drawing.Color.White
        Me.C1TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1TextBox8.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.C1TextBox8.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1TextBox8.Location = New System.Drawing.Point(88, 379)
        Me.C1TextBox8.Multiline = True
        Me.C1TextBox8.Name = "C1TextBox8"
        Me.C1TextBox8.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.C1TextBox8.Size = New System.Drawing.Size(372, 70)
        Me.C1TextBox8.TabIndex = 54
        Me.C1TextBox8.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.C1TextBox8, "予算管理テーマ")
        Me.C1TextBox8.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
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
        Me.FormSplitContainer.TabIndex = 44
        Me.FormSplitContainer.ToolTipGradient = C1.Win.C1SplitContainer.ToolTipGradient.Blue
        Me.FormSplitContainer.UseParentVisualStyle = False
        '
        'FormPanel
        '
        Me.FormPanel.BackColor = System.Drawing.Color.White
        Me.FormPanel.Controls.Add(Me.C1TextBox8)
        Me.FormPanel.Controls.Add(Me.Label13)
        Me.FormPanel.Controls.Add(Me.C1TextBox7)
        Me.FormPanel.Controls.Add(Me.Label12)
        Me.FormPanel.Controls.Add(Me.C1TextBox5)
        Me.FormPanel.Controls.Add(Me.Label11)
        Me.FormPanel.Controls.Add(Me.C1DateEdit3)
        Me.FormPanel.Controls.Add(Me.Label10)
        Me.FormPanel.Controls.Add(Me.C1NumericEdit1)
        Me.FormPanel.Controls.Add(Me.C1TextBox6)
        Me.FormPanel.Controls.Add(Me.Label9)
        Me.FormPanel.Controls.Add(Me.Label8)
        Me.FormPanel.Controls.Add(Me.C1DateEdit2)
        Me.FormPanel.Controls.Add(Me.Label7)
        Me.FormPanel.Controls.Add(Me.C1DateEdit1)
        Me.FormPanel.Controls.Add(Me.Label6)
        Me.FormPanel.Controls.Add(Me.C1TextBox4)
        Me.FormPanel.Controls.Add(Me.Label5)
        Me.FormPanel.Controls.Add(Me.C1TextBox3)
        Me.FormPanel.Controls.Add(Me.Label4)
        Me.FormPanel.Controls.Add(Me.C1TextBox2)
        Me.FormPanel.Controls.Add(Me.Label3)
        Me.FormPanel.Controls.Add(Me.C1TextBox1)
        Me.FormPanel.Controls.Add(Me.Label2)
        Me.FormPanel.Controls.Add(Me.C1ComboBox1)
        Me.FormPanel.Controls.Add(Me.Label1)
        Me.FormPanel.Controls.Add(Me.HeadLine)
        Me.FormPanel.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.FormPanel.Height = 621
        Me.FormPanel.Location = New System.Drawing.Point(0, 0)
        Me.FormPanel.Name = "FormPanel"
        Me.FormPanel.ResizeWhileDragging = True
        Me.FormPanel.Size = New System.Drawing.Size(990, 621)
        Me.FormPanel.SizeRatio = 94.1R
        Me.FormPanel.TabIndex = 0
        Me.FormPanel.Text = "パネル1"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(17, 237)
        Me.Label11.Margin = New System.Windows.Forms.Padding(0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 70)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "工事概要"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(17, 216)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 20)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "検討年月日"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(17, 175)
        Me.Label9.Margin = New System.Windows.Forms.Padding(0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 40)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "工事種類"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(17, 154)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 20)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "請負金額"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(17, 133)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 20)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "契約工期"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(17, 112)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 20)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "発注者"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(17, 91)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 20)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "工事場所"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(189, 70)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "工事名"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(17, 70)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 20)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "工事コード"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(17, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "会社コード"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FooterPanel
        '
        Me.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.FooterPanel.Controls.Add(Me.Entry)
        Me.FooterPanel.Dock = C1.Win.C1SplitContainer.PanelDockStyle.Bottom
        Me.FooterPanel.Height = 40
        Me.FooterPanel.Location = New System.Drawing.Point(0, 622)
        Me.FooterPanel.Name = "FooterPanel"
        Me.FooterPanel.Size = New System.Drawing.Size(990, 40)
        Me.FooterPanel.TabIndex = 1
        Me.FooterPanel.Text = "パネル2"
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
        Me.Entry.Location = New System.Drawing.Point(878, 5)
        Me.Entry.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.Entry.Name = "Entry"
        Me.Entry.Size = New System.Drawing.Size(100, 30)
        Me.Entry.TabIndex = 41
        Me.Entry.Text = "　登　録"
        Me.Entry.UseVisualStyleBackColor = True
        '
        '予算総括入力
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(990, 662)
        Me.Controls.Add(Me.FormSplitContainer)
        Me.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "予算総括入力"
        Me.Opacity = 0.2R
        Me.Text = "予算総括入力"
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1ComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1DateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1DateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NumericEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1DateEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FormSplitContainer.ResumeLayout(False)
        Me.FormPanel.ResumeLayout(False)
        Me.FormPanel.PerformLayout()
        Me.FooterPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HeadLine As Label
    Friend WithEvents ButtonImageList As ImageList
    Friend WithEvents Entry As Button
    Friend WithEvents SystemTheme As C1.Win.C1Themes.C1ThemeController
    Friend WithEvents FormSplitContainer As C1.Win.C1SplitContainer.C1SplitContainer
    Friend WithEvents FormPanel As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents FooterPanel As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents C1ComboBox1 As C1.Win.C1Input.C1ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents C1TextBox4 As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents C1TextBox3 As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents C1TextBox2 As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents C1TextBox1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents C1DateEdit1 As C1.Win.C1Input.C1DateEdit
    Friend WithEvents C1DateEdit2 As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents C1TextBox6 As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents C1NumericEdit1 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1TextBox5 As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents C1DateEdit3 As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label10 As Label
    Friend WithEvents C1TextBox8 As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents C1TextBox7 As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label12 As Label
End Class
