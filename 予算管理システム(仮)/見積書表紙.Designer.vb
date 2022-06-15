<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 見積書表紙
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(見積書表紙))
        Me.HeadLine = New System.Windows.Forms.Label()
        Me.ButtonImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.SystemTheme = New C1.Win.C1Themes.C1ThemeController()
        Me.EstmtDate = New C1.Win.C1Input.C1DateEdit()
        Me.EstmtTaxIn = New C1.Win.C1Input.C1NumericEdit()
        Me.EstmtTax = New C1.Win.C1Input.C1NumericEdit()
        Me.Discount = New C1.Win.C1Input.C1NumericEdit()
        Me.EstmtAmount = New C1.Win.C1Input.C1NumericEdit()
        Me.EstmtCode = New C1.Win.C1Input.C1TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Destination = New C1.Win.C1Input.C1TextBox()
        Me.PrjctName = New C1.Win.C1Input.C1TextBox()
        Me.PrjctAddress = New C1.Win.C1Input.C1TextBox()
        Me.PymntTerms = New C1.Win.C1Input.C1TextBox()
        Me.expirationdate = New C1.Win.C1Input.C1TextBox()
        Me.conditions = New C1.Win.C1Input.C1TextBox()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.cndtns_dtls1 = New C1.Win.C1Input.C1TextBox()
        Me.cndtns_dtls2 = New C1.Win.C1Input.C1TextBox()
        Me.cndtns_dtls3 = New C1.Win.C1Input.C1TextBox()
        Me.cndtns_dtls4 = New C1.Win.C1Input.C1TextBox()
        Me.cndtns_dtls5 = New C1.Win.C1Input.C1TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.EstmtCodeLabel = New System.Windows.Forms.Label()
        Me.FormSplitContainer = New C1.Win.C1SplitContainer.C1SplitContainer()
        Me.FormPanel = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.sales_staff = New C1.Win.C1Input.C1TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.sales_department = New C1.Win.C1Input.C1TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.estimator = New C1.Win.C1Input.C1TextBox()
        Me.estmt_department = New C1.Win.C1Input.C1TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PrjctNameLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrjctAddressLabel = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PymntTermsLabel = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DestinationLabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.pblshr_fax = New C1.Win.C1Input.C1TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pblshr_tel = New C1.Win.C1Input.C1TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.pblshr_address = New C1.Win.C1Input.C1TextBox()
        Me.pblshr_cmpnyname = New C1.Win.C1Input.C1TextBox()
        Me.pblshr_prsdnt = New C1.Win.C1Input.C1TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.EstmtTaxLabel = New System.Windows.Forms.Label()
        Me.DiscountLabel = New System.Windows.Forms.Label()
        Me.EstmtAmountLabel = New System.Windows.Forms.Label()
        Me.EstmtDateLabel = New System.Windows.Forms.Label()
        Me.C1SplitterPanel2 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.Entry = New System.Windows.Forms.Button()
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstmtDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstmtTaxIn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstmtTax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Discount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstmtAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstmtCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Destination, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrjctName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrjctAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PymntTerms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.expirationdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.conditions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cndtns_dtls1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cndtns_dtls2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cndtns_dtls3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cndtns_dtls4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cndtns_dtls5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FormSplitContainer.SuspendLayout()
        Me.FormPanel.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.sales_staff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sales_department, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.estimator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.estmt_department, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pblshr_fax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pblshr_tel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pblshr_address, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pblshr_cmpnyname, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pblshr_prsdnt, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.HeadLine.TabIndex = 0
        Me.HeadLine.Text = "<< 見積書作成"
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
        'EstmtDate
        '
        Me.EstmtDate.AutoSize = False
        Me.EstmtDate.BackColor = System.Drawing.Color.White
        Me.EstmtDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.EstmtDate.Calendar.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.EstmtDate.Calendar.BackColor = System.Drawing.Color.White
        Me.EstmtDate.Calendar.DayNamesColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.EstmtDate.Calendar.DayNamesFont = New System.Drawing.Font("メイリオ", 9.0!)
        Me.EstmtDate.Calendar.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.EstmtDate.Calendar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.EstmtDate.Calendar.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.EstmtDate.Calendar.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.EstmtDate.Calendar.TitleBackColor = System.Drawing.Color.White
        Me.EstmtDate.Calendar.TitleFont = New System.Drawing.Font("メイリオ", 9.0!)
        Me.EstmtDate.Calendar.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.EstmtDate.Calendar.TodayBorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.EstmtDate.Calendar.TrailingForeColor = System.Drawing.SystemColors.GrayText
        Me.EstmtDate.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.EstmtDate.Culture = 1041
        Me.EstmtDate.CustomFormat = "yyyy年MM月dd日"
        Me.EstmtDate.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.EstmtDate.DisplayFormat.CustomFormat = "yyyy年MM月dd日"
        Me.EstmtDate.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.EstmtDate.DisplayFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.EstmtDate.EditFormat.CustomFormat = "yyyy年MM月dd日"
        Me.EstmtDate.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.EstmtDate.EditFormat.Inherit = CType((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.EstmtDate.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.EstmtDate.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.EstmtDate.GapHeight = 0
        Me.EstmtDate.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.EstmtDate.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.EstmtDate.Location = New System.Drawing.Point(129, 65)
        Me.EstmtDate.Name = "EstmtDate"
        Me.EstmtDate.Size = New System.Drawing.Size(132, 20)
        Me.EstmtDate.TabIndex = 2
        Me.EstmtDate.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.EstmtDate, "予算管理テーマ")
        Me.EstmtDate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        Me.EstmtDate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'EstmtTaxIn
        '
        Me.EstmtTaxIn.AutoSize = False
        Me.EstmtTaxIn.BackColor = System.Drawing.Color.White
        Me.EstmtTaxIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.EstmtTaxIn.Calculator.BackColor = System.Drawing.Color.White
        Me.EstmtTaxIn.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.EstmtTaxIn.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.EstmtTaxIn.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.EstmtTaxIn.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.EstmtTaxIn.DisplayFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.EstmtTaxIn.Enabled = False
        Me.EstmtTaxIn.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.EstmtTaxIn.GapHeight = 0
        Me.EstmtTaxIn.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.EstmtTaxIn.Location = New System.Drawing.Point(129, 155)
        Me.EstmtTaxIn.Name = "EstmtTaxIn"
        Me.EstmtTaxIn.Size = New System.Drawing.Size(150, 20)
        Me.EstmtTaxIn.TabIndex = 6
        Me.EstmtTaxIn.Tag = Nothing
        Me.EstmtTaxIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SystemTheme.SetTheme(Me.EstmtTaxIn, "予算管理テーマ")
        Me.EstmtTaxIn.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.EstmtTaxIn.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'EstmtTax
        '
        Me.EstmtTax.AutoSize = False
        Me.EstmtTax.BackColor = System.Drawing.Color.White
        Me.EstmtTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.EstmtTax.Calculator.BackColor = System.Drawing.Color.White
        Me.EstmtTax.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.EstmtTax.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.EstmtTax.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.EstmtTax.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.EstmtTax.DisplayFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.EstmtTax.Enabled = False
        Me.EstmtTax.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.EstmtTax.GapHeight = 0
        Me.EstmtTax.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.EstmtTax.Location = New System.Drawing.Point(129, 134)
        Me.EstmtTax.Name = "EstmtTax"
        Me.EstmtTax.Size = New System.Drawing.Size(150, 20)
        Me.EstmtTax.TabIndex = 5
        Me.EstmtTax.Tag = Nothing
        Me.EstmtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SystemTheme.SetTheme(Me.EstmtTax, "予算管理テーマ")
        Me.EstmtTax.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.EstmtTax.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Discount
        '
        Me.Discount.AutoSize = False
        Me.Discount.BackColor = System.Drawing.Color.White
        Me.Discount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.Discount.Calculator.BackColor = System.Drawing.Color.White
        Me.Discount.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.Discount.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.Discount.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.Discount.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.Discount.DisplayFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.Discount.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Discount.GapHeight = 0
        Me.Discount.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.Discount.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Discount.Location = New System.Drawing.Point(129, 113)
        Me.Discount.Name = "Discount"
        Me.Discount.Size = New System.Drawing.Size(150, 20)
        Me.Discount.TabIndex = 4
        Me.Discount.Tag = Nothing
        Me.Discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SystemTheme.SetTheme(Me.Discount, "予算管理テーマ")
        Me.Discount.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.Discount.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'EstmtAmount
        '
        Me.EstmtAmount.AutoSize = False
        Me.EstmtAmount.BackColor = System.Drawing.Color.White
        Me.EstmtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.EstmtAmount.Calculator.BackColor = System.Drawing.Color.White
        Me.EstmtAmount.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.EstmtAmount.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.EstmtAmount.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.EstmtAmount.DisplayFormat.CustomFormat = "#,##0"
        Me.EstmtAmount.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.EstmtAmount.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.EstmtAmount.EditFormat.CustomFormat = "#,###"
        Me.EstmtAmount.EditFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.EstmtAmount.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.EstmtAmount.GapHeight = 0
        Me.EstmtAmount.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.EstmtAmount.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.EstmtAmount.Location = New System.Drawing.Point(129, 92)
        Me.EstmtAmount.Name = "EstmtAmount"
        Me.EstmtAmount.Size = New System.Drawing.Size(150, 20)
        Me.EstmtAmount.TabIndex = 3
        Me.EstmtAmount.Tag = Nothing
        Me.EstmtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SystemTheme.SetTheme(Me.EstmtAmount, "予算管理テーマ")
        Me.EstmtAmount.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.EstmtAmount.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'EstmtCode
        '
        Me.EstmtCode.AutoSize = False
        Me.EstmtCode.BackColor = System.Drawing.Color.White
        Me.EstmtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EstmtCode.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.EstmtCode.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.EstmtCode.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.EstmtCode.Location = New System.Drawing.Point(129, 44)
        Me.EstmtCode.Name = "EstmtCode"
        Me.EstmtCode.Size = New System.Drawing.Size(132, 20)
        Me.EstmtCode.TabIndex = 1
        Me.EstmtCode.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.EstmtCode, "(default)")
        Me.EstmtCode.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(8, 4)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(61, 20)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "担当情報"
        Me.SystemTheme.SetTheme(Me.Label23, "(default)")
        '
        'Destination
        '
        Me.Destination.AutoSize = False
        Me.Destination.BackColor = System.Drawing.Color.White
        Me.Destination.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Destination.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Destination.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Destination.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Destination.Location = New System.Drawing.Point(97, 23)
        Me.Destination.Multiline = True
        Me.Destination.Name = "Destination"
        Me.Destination.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Destination.Size = New System.Drawing.Size(250, 60)
        Me.Destination.TabIndex = 7
        Me.Destination.Tag = Nothing
        Me.Destination.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'PrjctName
        '
        Me.PrjctName.AutoSize = False
        Me.PrjctName.BackColor = System.Drawing.Color.White
        Me.PrjctName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PrjctName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PrjctName.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.PrjctName.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.PrjctName.Location = New System.Drawing.Point(97, 84)
        Me.PrjctName.MaxLength = 100
        Me.PrjctName.Multiline = True
        Me.PrjctName.Name = "PrjctName"
        Me.PrjctName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.PrjctName.Size = New System.Drawing.Size(250, 40)
        Me.PrjctName.TabIndex = 8
        Me.PrjctName.Tag = Nothing
        Me.PrjctName.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'PrjctAddress
        '
        Me.PrjctAddress.AutoSize = False
        Me.PrjctAddress.BackColor = System.Drawing.Color.White
        Me.PrjctAddress.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PrjctAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PrjctAddress.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.PrjctAddress.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.PrjctAddress.Location = New System.Drawing.Point(97, 125)
        Me.PrjctAddress.MaxLength = 100
        Me.PrjctAddress.Multiline = True
        Me.PrjctAddress.Name = "PrjctAddress"
        Me.PrjctAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.PrjctAddress.Size = New System.Drawing.Size(250, 40)
        Me.PrjctAddress.TabIndex = 9
        Me.PrjctAddress.Tag = Nothing
        Me.PrjctAddress.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'PymntTerms
        '
        Me.PymntTerms.AutoSize = False
        Me.PymntTerms.BackColor = System.Drawing.Color.White
        Me.PymntTerms.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PymntTerms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PymntTerms.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.PymntTerms.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.PymntTerms.Location = New System.Drawing.Point(97, 166)
        Me.PymntTerms.MaxLength = 100
        Me.PymntTerms.Multiline = True
        Me.PymntTerms.Name = "PymntTerms"
        Me.PymntTerms.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.PymntTerms.Size = New System.Drawing.Size(250, 40)
        Me.PymntTerms.TabIndex = 10
        Me.PymntTerms.Tag = Nothing
        Me.PymntTerms.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'expirationdate
        '
        Me.expirationdate.AutoSize = False
        Me.expirationdate.BackColor = System.Drawing.Color.White
        Me.expirationdate.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.expirationdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.expirationdate.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.expirationdate.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.expirationdate.Location = New System.Drawing.Point(97, 248)
        Me.expirationdate.MaxLength = 100
        Me.expirationdate.Multiline = True
        Me.expirationdate.Name = "expirationdate"
        Me.expirationdate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.expirationdate.Size = New System.Drawing.Size(250, 40)
        Me.expirationdate.TabIndex = 12
        Me.expirationdate.Tag = Nothing
        Me.expirationdate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'conditions
        '
        Me.conditions.AutoSize = False
        Me.conditions.BackColor = System.Drawing.Color.White
        Me.conditions.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.conditions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.conditions.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.conditions.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.conditions.Location = New System.Drawing.Point(97, 207)
        Me.conditions.Multiline = True
        Me.conditions.Name = "conditions"
        Me.conditions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.conditions.Size = New System.Drawing.Size(250, 40)
        Me.conditions.TabIndex = 11
        Me.conditions.Tag = Nothing
        Me.conditions.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
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
        Me.Cancel.Location = New System.Drawing.Point(878, 5)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(0)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(100, 30)
        Me.Cancel.TabIndex = 44
        Me.Cancel.Text = "キャンセル"
        Me.Cancel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'cndtns_dtls1
        '
        Me.cndtns_dtls1.AutoSize = False
        Me.cndtns_dtls1.BackColor = System.Drawing.Color.White
        Me.cndtns_dtls1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.cndtns_dtls1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cndtns_dtls1.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.cndtns_dtls1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.cndtns_dtls1.Location = New System.Drawing.Point(435, 84)
        Me.cndtns_dtls1.MaxLength = 500
        Me.cndtns_dtls1.Multiline = True
        Me.cndtns_dtls1.Name = "cndtns_dtls1"
        Me.cndtns_dtls1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.cndtns_dtls1.Size = New System.Drawing.Size(500, 40)
        Me.cndtns_dtls1.TabIndex = 13
        Me.cndtns_dtls1.Tag = Nothing
        Me.cndtns_dtls1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'cndtns_dtls2
        '
        Me.cndtns_dtls2.AutoSize = False
        Me.cndtns_dtls2.BackColor = System.Drawing.Color.White
        Me.cndtns_dtls2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.cndtns_dtls2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cndtns_dtls2.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.cndtns_dtls2.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.cndtns_dtls2.Location = New System.Drawing.Point(435, 125)
        Me.cndtns_dtls2.MaxLength = 500
        Me.cndtns_dtls2.Multiline = True
        Me.cndtns_dtls2.Name = "cndtns_dtls2"
        Me.cndtns_dtls2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.cndtns_dtls2.Size = New System.Drawing.Size(500, 40)
        Me.cndtns_dtls2.TabIndex = 14
        Me.cndtns_dtls2.Tag = Nothing
        Me.cndtns_dtls2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'cndtns_dtls3
        '
        Me.cndtns_dtls3.AutoSize = False
        Me.cndtns_dtls3.BackColor = System.Drawing.Color.White
        Me.cndtns_dtls3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.cndtns_dtls3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cndtns_dtls3.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.cndtns_dtls3.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.cndtns_dtls3.Location = New System.Drawing.Point(435, 166)
        Me.cndtns_dtls3.MaxLength = 500
        Me.cndtns_dtls3.Multiline = True
        Me.cndtns_dtls3.Name = "cndtns_dtls3"
        Me.cndtns_dtls3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.cndtns_dtls3.Size = New System.Drawing.Size(500, 40)
        Me.cndtns_dtls3.TabIndex = 15
        Me.cndtns_dtls3.Tag = Nothing
        Me.cndtns_dtls3.Value = ""
        Me.cndtns_dtls3.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'cndtns_dtls4
        '
        Me.cndtns_dtls4.AutoSize = False
        Me.cndtns_dtls4.BackColor = System.Drawing.Color.White
        Me.cndtns_dtls4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.cndtns_dtls4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cndtns_dtls4.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.cndtns_dtls4.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.cndtns_dtls4.Location = New System.Drawing.Point(435, 207)
        Me.cndtns_dtls4.MaxLength = 500
        Me.cndtns_dtls4.Multiline = True
        Me.cndtns_dtls4.Name = "cndtns_dtls4"
        Me.cndtns_dtls4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.cndtns_dtls4.Size = New System.Drawing.Size(500, 40)
        Me.cndtns_dtls4.TabIndex = 16
        Me.cndtns_dtls4.Tag = Nothing
        Me.cndtns_dtls4.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'cndtns_dtls5
        '
        Me.cndtns_dtls5.AutoSize = False
        Me.cndtns_dtls5.BackColor = System.Drawing.Color.White
        Me.cndtns_dtls5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.cndtns_dtls5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cndtns_dtls5.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.cndtns_dtls5.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.cndtns_dtls5.Location = New System.Drawing.Point(435, 248)
        Me.cndtns_dtls5.MaxLength = 500
        Me.cndtns_dtls5.Multiline = True
        Me.cndtns_dtls5.Name = "cndtns_dtls5"
        Me.cndtns_dtls5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.cndtns_dtls5.Size = New System.Drawing.Size(500, 40)
        Me.cndtns_dtls5.TabIndex = 17
        Me.cndtns_dtls5.Tag = Nothing
        Me.cndtns_dtls5.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(11, 248)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 40)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "見積有効期限"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(11, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 40)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "見積条件"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(12, 29)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 23)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "見積宛先"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EstmtCodeLabel
        '
        Me.EstmtCodeLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.EstmtCodeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EstmtCodeLabel.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.EstmtCodeLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.EstmtCodeLabel.Location = New System.Drawing.Point(28, 44)
        Me.EstmtCodeLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.EstmtCodeLabel.Name = "EstmtCodeLabel"
        Me.EstmtCodeLabel.Size = New System.Drawing.Size(100, 20)
        Me.EstmtCodeLabel.TabIndex = 0
        Me.EstmtCodeLabel.Text = "見積書ｺｰﾄﾞ"
        Me.EstmtCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.FormSplitContainer.Panels.Add(Me.FormPanel)
        Me.FormSplitContainer.Panels.Add(Me.C1SplitterPanel2)
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
        Me.FormPanel.Controls.Add(Me.Panel3)
        Me.FormPanel.Controls.Add(Me.EstmtCode)
        Me.FormPanel.Controls.Add(Me.Panel2)
        Me.FormPanel.Controls.Add(Me.Panel1)
        Me.FormPanel.Controls.Add(Me.EstmtTaxIn)
        Me.FormPanel.Controls.Add(Me.Label6)
        Me.FormPanel.Controls.Add(Me.EstmtTax)
        Me.FormPanel.Controls.Add(Me.EstmtTaxLabel)
        Me.FormPanel.Controls.Add(Me.Discount)
        Me.FormPanel.Controls.Add(Me.DiscountLabel)
        Me.FormPanel.Controls.Add(Me.EstmtAmount)
        Me.FormPanel.Controls.Add(Me.EstmtAmountLabel)
        Me.FormPanel.Controls.Add(Me.EstmtCodeLabel)
        Me.FormPanel.Controls.Add(Me.EstmtDateLabel)
        Me.FormPanel.Controls.Add(Me.EstmtDate)
        Me.FormPanel.Font = New System.Drawing.Font("メイリオ", 10.0!)
        Me.FormPanel.Height = 621
        Me.FormPanel.Location = New System.Drawing.Point(0, 0)
        Me.FormPanel.Name = "FormPanel"
        Me.FormPanel.ResizeWhileDragging = True
        Me.FormPanel.Size = New System.Drawing.Size(990, 621)
        Me.FormPanel.SizeRatio = 94.1R
        Me.FormPanel.TabIndex = 0
        Me.FormPanel.Text = "パネル1"
        Me.FormPanel.Width = 990
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label23)
        Me.Panel3.Controls.Add(Me.sales_staff)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.sales_department)
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Controls.Add(Me.estimator)
        Me.Panel3.Controls.Add(Me.estmt_department)
        Me.Panel3.Location = New System.Drawing.Point(626, 488)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(350, 119)
        Me.Panel3.TabIndex = 23
        '
        'sales_staff
        '
        Me.sales_staff.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.sales_staff.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.sales_staff.AutoSize = False
        Me.sales_staff.BackColor = System.Drawing.Color.White
        Me.sales_staff.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.sales_staff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sales_staff.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.sales_staff.Location = New System.Drawing.Point(98, 92)
        Me.sales_staff.Name = "sales_staff"
        Me.sales_staff.Size = New System.Drawing.Size(150, 20)
        Me.sales_staff.TabIndex = 26
        Me.sales_staff.Tag = Nothing
        Me.sales_staff.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(12, 26)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(85, 20)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "見積部署"
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label20.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(12, 47)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(85, 20)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "見積担当者"
        '
        'sales_department
        '
        Me.sales_department.AutoSize = False
        Me.sales_department.BackColor = System.Drawing.Color.White
        Me.sales_department.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.sales_department.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sales_department.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.sales_department.Location = New System.Drawing.Point(98, 71)
        Me.sales_department.Name = "sales_department"
        Me.sales_department.Size = New System.Drawing.Size(150, 20)
        Me.sales_department.TabIndex = 25
        Me.sales_department.Tag = Nothing
        Me.sales_department.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label22.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(12, 71)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(85, 20)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "営業部署"
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label21.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(12, 92)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(85, 20)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "営業担当者"
        '
        'estimator
        '
        Me.estimator.AutoSize = False
        Me.estimator.BackColor = System.Drawing.Color.White
        Me.estimator.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.estimator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.estimator.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.estimator.Location = New System.Drawing.Point(98, 47)
        Me.estimator.Name = "estimator"
        Me.estimator.Size = New System.Drawing.Size(150, 20)
        Me.estimator.TabIndex = 24
        Me.estimator.Tag = Nothing
        Me.estimator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'estmt_department
        '
        Me.estmt_department.AutoSize = False
        Me.estmt_department.BackColor = System.Drawing.Color.White
        Me.estmt_department.BorderColor = System.Drawing.Color.Black
        Me.estmt_department.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.estmt_department.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.estmt_department.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.estmt_department.Location = New System.Drawing.Point(98, 26)
        Me.estmt_department.Name = "estmt_department"
        Me.estmt_department.Size = New System.Drawing.Size(150, 20)
        Me.estmt_department.TabIndex = 23
        Me.estmt_department.Tag = Nothing
        Me.estmt_department.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.cndtns_dtls5)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.cndtns_dtls4)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Destination)
        Me.Panel2.Controls.Add(Me.conditions)
        Me.Panel2.Controls.Add(Me.PrjctNameLabel)
        Me.Panel2.Controls.Add(Me.cndtns_dtls1)
        Me.Panel2.Controls.Add(Me.PrjctName)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.cndtns_dtls3)
        Me.Panel2.Controls.Add(Me.PrjctAddressLabel)
        Me.Panel2.Controls.Add(Me.expirationdate)
        Me.Panel2.Controls.Add(Me.PrjctAddress)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.PymntTermsLabel)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.cndtns_dtls2)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.PymntTerms)
        Me.Panel2.Controls.Add(Me.DestinationLabel)
        Me.Panel2.Location = New System.Drawing.Point(27, 182)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(949, 303)
        Me.Panel2.TabIndex = 5
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(350, 63)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(356, 18)
        Me.Label18.TabIndex = 89
        Me.Label18.Text = "見積条件の詳細は「見積条件詳細1~5」に箇条書きして下さい。"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(12, 4)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 18)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "見積情報"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Font = New System.Drawing.Font("メイリオ", 8.5!)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label11.Location = New System.Drawing.Point(349, 248)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 40)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "見積条件" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "詳細 5"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("メイリオ", 8.5!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(349, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 40)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "見積条件" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "詳細 1"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("メイリオ", 8.5!)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(349, 207)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 40)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "見積条件" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "詳細 4"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PrjctNameLabel
        '
        Me.PrjctNameLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.PrjctNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PrjctNameLabel.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.PrjctNameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PrjctNameLabel.Location = New System.Drawing.Point(11, 84)
        Me.PrjctNameLabel.Name = "PrjctNameLabel"
        Me.PrjctNameLabel.Size = New System.Drawing.Size(85, 40)
        Me.PrjctNameLabel.TabIndex = 0
        Me.PrjctNameLabel.Text = "工事名称"
        Me.PrjctNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("メイリオ", 7.5!)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(12, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "※御中、様等は" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "必ず入力"
        '
        'PrjctAddressLabel
        '
        Me.PrjctAddressLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.PrjctAddressLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PrjctAddressLabel.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.PrjctAddressLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PrjctAddressLabel.Location = New System.Drawing.Point(11, 125)
        Me.PrjctAddressLabel.Name = "PrjctAddressLabel"
        Me.PrjctAddressLabel.Size = New System.Drawing.Size(85, 40)
        Me.PrjctAddressLabel.TabIndex = 0
        Me.PrjctAddressLabel.Text = "工事場所"
        Me.PrjctAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("メイリオ", 8.5!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(349, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 40)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "見積条件" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "詳細 2"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PymntTermsLabel
        '
        Me.PymntTermsLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.PymntTermsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PymntTermsLabel.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.PymntTermsLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PymntTermsLabel.Location = New System.Drawing.Point(11, 166)
        Me.PymntTermsLabel.Name = "PymntTermsLabel"
        Me.PymntTermsLabel.Size = New System.Drawing.Size(85, 40)
        Me.PymntTermsLabel.TabIndex = 0
        Me.PymntTermsLabel.Text = "支払条件"
        Me.PymntTermsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("メイリオ", 8.5!)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(349, 166)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 40)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "見積条件" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "詳細 3"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DestinationLabel
        '
        Me.DestinationLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DestinationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DestinationLabel.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DestinationLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.DestinationLabel.Location = New System.Drawing.Point(11, 23)
        Me.DestinationLabel.Name = "DestinationLabel"
        Me.DestinationLabel.Size = New System.Drawing.Size(85, 60)
        Me.DestinationLabel.TabIndex = 0
        Me.DestinationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.pblshr_fax)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.pblshr_tel)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.pblshr_address)
        Me.Panel1.Controls.Add(Me.pblshr_cmpnyname)
        Me.Panel1.Controls.Add(Me.pblshr_prsdnt)
        Me.Panel1.Location = New System.Drawing.Point(27, 488)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(597, 119)
        Me.Panel1.TabIndex = 18
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(8, 4)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(74, 20)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "発行元情報"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(10, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 20)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "会社名"
        '
        'pblshr_fax
        '
        Me.pblshr_fax.AutoSize = False
        Me.pblshr_fax.BackColor = System.Drawing.Color.White
        Me.pblshr_fax.BorderColor = System.Drawing.Color.Black
        Me.pblshr_fax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pblshr_fax.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.pblshr_fax.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.pblshr_fax.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.pblshr_fax.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.pblshr_fax.Location = New System.Drawing.Point(433, 47)
        Me.pblshr_fax.Name = "pblshr_fax"
        Me.pblshr_fax.Size = New System.Drawing.Size(150, 20)
        Me.pblshr_fax.TabIndex = 22
        Me.pblshr_fax.Tag = Nothing
        Me.pblshr_fax.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(347, 47)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(85, 20)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "FAX"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(347, 26)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 20)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "TEL"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(10, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 41)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "住所"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pblshr_tel
        '
        Me.pblshr_tel.AutoSize = False
        Me.pblshr_tel.BackColor = System.Drawing.Color.White
        Me.pblshr_tel.BorderColor = System.Drawing.Color.Black
        Me.pblshr_tel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pblshr_tel.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.pblshr_tel.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.pblshr_tel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.pblshr_tel.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.pblshr_tel.Location = New System.Drawing.Point(433, 26)
        Me.pblshr_tel.Name = "pblshr_tel"
        Me.pblshr_tel.Size = New System.Drawing.Size(150, 20)
        Me.pblshr_tel.TabIndex = 21
        Me.pblshr_tel.Tag = Nothing
        Me.pblshr_tel.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(10, 47)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 20)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "代表者名"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pblshr_address
        '
        Me.pblshr_address.AutoSize = False
        Me.pblshr_address.BackColor = System.Drawing.Color.White
        Me.pblshr_address.BorderColor = System.Drawing.Color.Black
        Me.pblshr_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pblshr_address.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.pblshr_address.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.pblshr_address.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.pblshr_address.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.pblshr_address.Location = New System.Drawing.Point(96, 68)
        Me.pblshr_address.Multiline = True
        Me.pblshr_address.Name = "pblshr_address"
        Me.pblshr_address.Size = New System.Drawing.Size(250, 41)
        Me.pblshr_address.TabIndex = 20
        Me.pblshr_address.Tag = Nothing
        Me.pblshr_address.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'pblshr_cmpnyname
        '
        Me.pblshr_cmpnyname.AutoSize = False
        Me.pblshr_cmpnyname.BackColor = System.Drawing.Color.White
        Me.pblshr_cmpnyname.BorderColor = System.Drawing.Color.Black
        Me.pblshr_cmpnyname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pblshr_cmpnyname.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.pblshr_cmpnyname.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.pblshr_cmpnyname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.pblshr_cmpnyname.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.pblshr_cmpnyname.Location = New System.Drawing.Point(96, 26)
        Me.pblshr_cmpnyname.Name = "pblshr_cmpnyname"
        Me.pblshr_cmpnyname.Size = New System.Drawing.Size(250, 20)
        Me.pblshr_cmpnyname.TabIndex = 18
        Me.pblshr_cmpnyname.Tag = Nothing
        Me.pblshr_cmpnyname.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'pblshr_prsdnt
        '
        Me.pblshr_prsdnt.AutoSize = False
        Me.pblshr_prsdnt.BackColor = System.Drawing.Color.White
        Me.pblshr_prsdnt.BorderColor = System.Drawing.Color.Black
        Me.pblshr_prsdnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pblshr_prsdnt.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.pblshr_prsdnt.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.pblshr_prsdnt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.pblshr_prsdnt.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.pblshr_prsdnt.Location = New System.Drawing.Point(96, 47)
        Me.pblshr_prsdnt.Name = "pblshr_prsdnt"
        Me.pblshr_prsdnt.Size = New System.Drawing.Size(250, 20)
        Me.pblshr_prsdnt.TabIndex = 19
        Me.pblshr_prsdnt.Tag = Nothing
        Me.pblshr_prsdnt.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(28, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "税込金額"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EstmtTaxLabel
        '
        Me.EstmtTaxLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.EstmtTaxLabel.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.EstmtTaxLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.EstmtTaxLabel.Location = New System.Drawing.Point(28, 134)
        Me.EstmtTaxLabel.Name = "EstmtTaxLabel"
        Me.EstmtTaxLabel.Size = New System.Drawing.Size(100, 20)
        Me.EstmtTaxLabel.TabIndex = 0
        Me.EstmtTaxLabel.Text = "消費税等(10%)"
        Me.EstmtTaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DiscountLabel
        '
        Me.DiscountLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DiscountLabel.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DiscountLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.DiscountLabel.Location = New System.Drawing.Point(28, 113)
        Me.DiscountLabel.Name = "DiscountLabel"
        Me.DiscountLabel.Size = New System.Drawing.Size(100, 20)
        Me.DiscountLabel.TabIndex = 0
        Me.DiscountLabel.Text = "値引き"
        Me.DiscountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EstmtAmountLabel
        '
        Me.EstmtAmountLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.EstmtAmountLabel.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.EstmtAmountLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.EstmtAmountLabel.Location = New System.Drawing.Point(28, 92)
        Me.EstmtAmountLabel.Name = "EstmtAmountLabel"
        Me.EstmtAmountLabel.Size = New System.Drawing.Size(100, 20)
        Me.EstmtAmountLabel.TabIndex = 0
        Me.EstmtAmountLabel.Text = "税抜金額"
        Me.EstmtAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EstmtDateLabel
        '
        Me.EstmtDateLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.EstmtDateLabel.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.EstmtDateLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.EstmtDateLabel.Location = New System.Drawing.Point(28, 65)
        Me.EstmtDateLabel.Name = "EstmtDateLabel"
        Me.EstmtDateLabel.Size = New System.Drawing.Size(100, 20)
        Me.EstmtDateLabel.TabIndex = 0
        Me.EstmtDateLabel.Text = "見積年月日"
        Me.EstmtDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Entry.Location = New System.Drawing.Point(775, 4)
        Me.Entry.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.Entry.Name = "Entry"
        Me.Entry.Size = New System.Drawing.Size(100, 30)
        Me.Entry.TabIndex = 43
        Me.Entry.Text = "　登 録"
        Me.Entry.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Entry.UseVisualStyleBackColor = True
        '
        '見積書表紙
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(990, 662)
        Me.Controls.Add(Me.HeadLine)
        Me.Controls.Add(Me.FormSplitContainer)
        Me.Font = New System.Drawing.Font("メイリオ", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "見積書表紙"
        Me.Opacity = 0.2R
        Me.Text = "協力業者入力"
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstmtDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstmtTaxIn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstmtTax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Discount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstmtAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstmtCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Destination, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrjctName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrjctAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PymntTerms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.expirationdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.conditions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cndtns_dtls1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cndtns_dtls2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cndtns_dtls3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cndtns_dtls4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cndtns_dtls5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FormSplitContainer.ResumeLayout(False)
        Me.FormPanel.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.sales_staff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sales_department, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.estimator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.estmt_department, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pblshr_fax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pblshr_tel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pblshr_address, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pblshr_cmpnyname, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pblshr_prsdnt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1SplitterPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HeadLine As Label
    Friend WithEvents ButtonImageList As ImageList
    Friend WithEvents SystemTheme As C1.Win.C1Themes.C1ThemeController
    Friend WithEvents FormSplitContainer As C1.Win.C1SplitContainer.C1SplitContainer
    Friend WithEvents FormPanel As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents C1SplitterPanel2 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents EstmtCodeLabel As Label
    Friend WithEvents EstmtDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents EstmtDateLabel As Label
    Friend WithEvents PrjctNameLabel As Label
    Friend WithEvents Destination As C1.Win.C1Input.C1TextBox
    Friend WithEvents DestinationLabel As Label
    Friend WithEvents PrjctName As C1.Win.C1Input.C1TextBox
    Friend WithEvents PrjctAddress As C1.Win.C1Input.C1TextBox
    Friend WithEvents PrjctAddressLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents conditions As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents expirationdate As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PymntTerms As C1.Win.C1Input.C1TextBox
    Friend WithEvents PymntTermsLabel As Label
    Friend WithEvents Discount As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents DiscountLabel As Label
    Friend WithEvents EstmtAmount As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents EstmtAmountLabel As Label
    Friend WithEvents EstmtTaxIn As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label6 As Label
    Friend WithEvents EstmtTax As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents EstmtTaxLabel As Label
    Friend WithEvents Cancel As Button
    Friend WithEvents Entry As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cndtns_dtls1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cndtns_dtls4 As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cndtns_dtls3 As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cndtns_dtls2 As C1.Win.C1Input.C1TextBox
    Friend WithEvents cndtns_dtls5 As C1.Win.C1Input.C1TextBox
    Friend WithEvents pblshr_fax As C1.Win.C1Input.C1TextBox
    Friend WithEvents pblshr_prsdnt As C1.Win.C1Input.C1TextBox
    Friend WithEvents pblshr_tel As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents pblshr_cmpnyname As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents pblshr_address As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents EstmtCode As C1.Win.C1Input.C1TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label23 As Label
    Friend WithEvents sales_staff As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents sales_department As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents estimator As C1.Win.C1Input.C1TextBox
    Friend WithEvents estmt_department As C1.Win.C1Input.C1TextBox
End Class
