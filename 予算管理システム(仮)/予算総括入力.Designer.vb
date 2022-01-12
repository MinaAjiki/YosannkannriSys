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
        Me.Company = New C1.Win.C1Input.C1ComboBox()
        Me.ProjectCode = New C1.Win.C1Input.C1TextBox()
        Me.ProjectName = New C1.Win.C1Input.C1TextBox()
        Me.ProjectAddress = New C1.Win.C1Input.C1TextBox()
        Me.Contractee = New C1.Win.C1Input.C1TextBox()
        Me.TermS = New C1.Win.C1Input.C1DateEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TermE = New C1.Win.C1Input.C1DateEdit()
        Me.Category = New C1.Win.C1Input.C1TextBox()
        Me.Amount = New C1.Win.C1Input.C1NumericEdit()
        Me.Summary = New C1.Win.C1Input.C1TextBox()
        Me.Remarks = New C1.Win.C1Input.C1TextBox()
        Me.SubContractRate = New C1.Win.C1Input.C1TextBox()
        Me.OutsoucersList = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Department = New C1.Win.C1Input.C1TextBox()
        Me.Director = New C1.Win.C1Input.C1TextBox()
        Me.Chief = New C1.Win.C1Input.C1TextBox()
        Me.Expert2 = New C1.Win.C1Input.C1TextBox()
        Me.Staff1 = New C1.Win.C1Input.C1TextBox()
        Me.Staff2 = New C1.Win.C1Input.C1TextBox()
        Me.Manager = New C1.Win.C1Input.C1TextBox()
        Me.Expert1 = New C1.Win.C1Input.C1TextBox()
        Me.Expert3 = New C1.Win.C1Input.C1TextBox()
        Me.Staff3 = New C1.Win.C1Input.C1TextBox()
        Me.Staff4 = New C1.Win.C1Input.C1TextBox()
        Me.C1ComboBox2 = New C1.Win.C1Input.C1ComboBox()
        Me.BdgtDprtmnt = New C1.Win.C1Input.C1ComboBox()
        Me.ExpenseRate = New C1.Win.C1Input.C1TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.BudgetBreakDown = New System.Windows.Forms.GroupBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.ProfitAndLossRate = New C1.Win.C1Input.C1NumericEdit()
        Me.ProfitAndLoss = New C1.Win.C1Input.C1NumericEdit()
        Me.ProfitAndLossLabel = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.ConstractionCostRate = New C1.Win.C1Input.C1NumericEdit()
        Me.ConstractionCostLabel = New System.Windows.Forms.Label()
        Me.ConstractionCost = New C1.Win.C1Input.C1NumericEdit()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.SiteCostsRate = New C1.Win.C1Input.C1NumericEdit()
        Me.SiteCosts = New C1.Win.C1Input.C1NumericEdit()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.SiteCostsLabel = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.SubTotalRate = New C1.Win.C1Input.C1NumericEdit()
        Me.SubTotal = New C1.Win.C1Input.C1NumericEdit()
        Me.SubTotalLabel = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.ProjectAmount = New C1.Win.C1Input.C1NumericEdit()
        Me.ProjectAmountLabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.ExpectedTotal = New C1.Win.C1Input.C1NumericEdit()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Mtrldffrnc = New C1.Win.C1Input.C1TextBox()
        Me.ExpectedTotalLabel = New System.Windows.Forms.Label()
        Me.DrctCnstrctnCst = New C1.Win.C1Input.C1NumericEdit()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.MtrldffrncLabel = New System.Windows.Forms.Label()
        Me.ExpectedTotalRate = New C1.Win.C1Input.C1NumericEdit()
        Me.TmprryExpnssLabel = New System.Windows.Forms.Label()
        Me.TmprryExpnss = New C1.Win.C1Input.C1NumericEdit()
        Me.MtrldffrncRate = New C1.Win.C1Input.C1NumericEdit()
        Me.DrctCnstrctnCstLabel = New System.Windows.Forms.Label()
        Me.TmprryExpnssRate = New C1.Win.C1Input.C1NumericEdit()
        Me.DrctCnstrctnCstRt = New C1.Win.C1Input.C1NumericEdit()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.AuthorizerPanel = New System.Windows.Forms.Panel()
        Me.Authorizer5 = New C1.Win.C1Input.C1TextBox()
        Me.Authorizer4 = New C1.Win.C1Input.C1TextBox()
        Me.Authorizer3 = New C1.Win.C1Input.C1TextBox()
        Me.Authorizer2 = New C1.Win.C1Input.C1TextBox()
        Me.Authorizer1 = New C1.Win.C1Input.C1TextBox()
        Me.AuthorizerLabel5 = New System.Windows.Forms.Label()
        Me.AuthorizerLabel4 = New System.Windows.Forms.Label()
        Me.AuthorizerLabel3 = New System.Windows.Forms.Label()
        Me.AuthorizerLabel2 = New System.Windows.Forms.Label()
        Me.AuthorizerLabel1 = New System.Windows.Forms.Label()
        Me.CirculatorPanel = New System.Windows.Forms.Panel()
        Me.Circulator3 = New C1.Win.C1Input.C1TextBox()
        Me.Circulator5 = New C1.Win.C1Input.C1TextBox()
        Me.CirculatorLabel1 = New System.Windows.Forms.Label()
        Me.Circulator4 = New C1.Win.C1Input.C1TextBox()
        Me.CirculatorLabel2 = New System.Windows.Forms.Label()
        Me.CirculatorLabel3 = New System.Windows.Forms.Label()
        Me.Circulator2 = New C1.Win.C1Input.C1TextBox()
        Me.CirculatorLabel4 = New System.Windows.Forms.Label()
        Me.Circulator1 = New C1.Win.C1Input.C1TextBox()
        Me.CirculatorLabel5 = New System.Windows.Forms.Label()
        Me.C1ComboBox1 = New C1.Win.C1Input.C1ComboBox()
        Me.Year = New C1.Win.C1Input.C1ComboBox()
        Me.CnsdrtnDate = New C1.Win.C1Input.C1DateEdit()
        Me.RemarksLabel = New System.Windows.Forms.Label()
        Me.SubContractRateLabel = New System.Windows.Forms.Label()
        Me.OutsourcersLabel = New System.Windows.Forms.Label()
        Me.FormSplitContainer = New C1.Win.C1SplitContainer.C1SplitContainer()
        Me.FormPanel = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CostRateLabel = New System.Windows.Forms.Label()
        Me.BdgtDprtmntLabel = New System.Windows.Forms.Label()
        Me.Staff4Label = New System.Windows.Forms.Label()
        Me.Staff3Label = New System.Windows.Forms.Label()
        Me.Staff2Label = New System.Windows.Forms.Label()
        Me.Staff1Label = New System.Windows.Forms.Label()
        Me.Expert3Label = New System.Windows.Forms.Label()
        Me.Expert1Label = New System.Windows.Forms.Label()
        Me.ChiefLabel = New System.Windows.Forms.Label()
        Me.ManagerLabel = New System.Windows.Forms.Label()
        Me.Expert2Label = New System.Windows.Forms.Label()
        Me.DirectorLabel = New System.Windows.Forms.Label()
        Me.DepartmentLabel = New System.Windows.Forms.Label()
        Me.SummaryLabel = New System.Windows.Forms.Label()
        Me.CnsdrtnDateLabel = New System.Windows.Forms.Label()
        Me.CategoryLabel = New System.Windows.Forms.Label()
        Me.AmountLabel = New System.Windows.Forms.Label()
        Me.TermLabel = New System.Windows.Forms.Label()
        Me.ContracteeLabel = New System.Windows.Forms.Label()
        Me.ProjectAddressLabel = New System.Windows.Forms.Label()
        Me.ProjectNameLabel = New System.Windows.Forms.Label()
        Me.ProjectCodeLabel = New System.Windows.Forms.Label()
        Me.CompanyLabel = New System.Windows.Forms.Label()
        Me.FooterPanel = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Entry = New System.Windows.Forms.Button()
        Me.OutsrcrToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Company, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Contractee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TermS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TermE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Category, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Amount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Summary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Remarks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubContractRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OutsoucersList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Department, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Director, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chief, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Expert2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Staff1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Staff2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Manager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Expert1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Expert3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Staff3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Staff4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1ComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdgtDprtmnt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpenseRate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BudgetBreakDown.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.ProfitAndLossRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfitAndLoss, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConstractionCostRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConstractionCost, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.SiteCostsRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SiteCosts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.SubTotalRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjectAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ExpectedTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mtrldffrnc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrctCnstrctnCst, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpectedTotalRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TmprryExpnss, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MtrldffrncRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TmprryExpnssRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrctCnstrctnCstRt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.AuthorizerPanel.SuspendLayout()
        CType(Me.Authorizer5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Authorizer4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Authorizer3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Authorizer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Authorizer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CirculatorPanel.SuspendLayout()
        CType(Me.Circulator3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Circulator5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Circulator4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Circulator2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Circulator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1ComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Year, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CnsdrtnDate, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Company
        '
        Me.Company.AllowSpinLoop = False
        Me.Company.AutoCompleteCustomSource.AddRange(New String() {"10", "11", "12", "13", "14", "15"})
        Me.Company.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Company.AutoSize = False
        Me.Company.BackColor = System.Drawing.Color.White
        Me.Company.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Company.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.Company.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.Company.GapHeight = 0
        Me.Company.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.Company.Location = New System.Drawing.Point(101, 40)
        Me.Company.Name = "Company"
        Me.Company.Size = New System.Drawing.Size(150, 20)
        Me.Company.Style.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.Company.TabIndex = 1
        Me.Company.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.Company, "予算管理テーマ")
        Me.Company.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'ProjectCode
        '
        Me.ProjectCode.AutoSize = False
        Me.ProjectCode.BackColor = System.Drawing.Color.White
        Me.ProjectCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProjectCode.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.ProjectCode.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.ProjectCode.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.ProjectCode.Location = New System.Drawing.Point(101, 61)
        Me.ProjectCode.MaxLength = 6
        Me.ProjectCode.Name = "ProjectCode"
        Me.ProjectCode.Size = New System.Drawing.Size(150, 20)
        Me.ProjectCode.TabIndex = 3
        Me.ProjectCode.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.ProjectCode, "予算管理テーマ")
        Me.ProjectCode.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'ProjectName
        '
        Me.ProjectName.AutoSize = False
        Me.ProjectName.BackColor = System.Drawing.Color.White
        Me.ProjectName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProjectName.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.ProjectName.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.ProjectName.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.ProjectName.Location = New System.Drawing.Point(323, 61)
        Me.ProjectName.Name = "ProjectName"
        Me.ProjectName.Size = New System.Drawing.Size(150, 20)
        Me.ProjectName.TabIndex = 4
        Me.ProjectName.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.ProjectName, "予算管理テーマ")
        Me.ProjectName.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'ProjectAddress
        '
        Me.ProjectAddress.AutoSize = False
        Me.ProjectAddress.BackColor = System.Drawing.Color.White
        Me.ProjectAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProjectAddress.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.ProjectAddress.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.ProjectAddress.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.ProjectAddress.Location = New System.Drawing.Point(101, 82)
        Me.ProjectAddress.Name = "ProjectAddress"
        Me.ProjectAddress.Size = New System.Drawing.Size(372, 20)
        Me.ProjectAddress.TabIndex = 5
        Me.ProjectAddress.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.ProjectAddress, "予算管理テーマ")
        Me.ProjectAddress.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Contractee
        '
        Me.Contractee.AutoSize = False
        Me.Contractee.BackColor = System.Drawing.Color.White
        Me.Contractee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Contractee.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.Contractee.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.Contractee.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.Contractee.Location = New System.Drawing.Point(101, 103)
        Me.Contractee.Name = "Contractee"
        Me.Contractee.Size = New System.Drawing.Size(372, 20)
        Me.Contractee.TabIndex = 6
        Me.Contractee.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.Contractee, "予算管理テーマ")
        Me.Contractee.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'TermS
        '
        Me.TermS.AutoSize = False
        Me.TermS.BackColor = System.Drawing.Color.White
        Me.TermS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.TermS.Calendar.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.TermS.Calendar.BackColor = System.Drawing.Color.White
        Me.TermS.Calendar.DayNamesColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.TermS.Calendar.DayNamesFont = New System.Drawing.Font("メイリオ", 9.0!)
        Me.TermS.Calendar.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.TermS.Calendar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.TermS.Calendar.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.TermS.Calendar.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.TermS.Calendar.ShowClearButton = False
        Me.TermS.Calendar.ShowTodayButton = False
        Me.TermS.Calendar.TitleBackColor = System.Drawing.Color.White
        Me.TermS.Calendar.TitleFont = New System.Drawing.Font("メイリオ", 9.0!)
        Me.TermS.Calendar.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.TermS.Calendar.TodayBorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.TermS.Calendar.TrailingForeColor = System.Drawing.SystemColors.GrayText
        Me.TermS.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.TermS.Culture = 1041
        Me.TermS.CustomFormat = "yyyy/MM/dd"
        Me.TermS.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.TermS.DisplayFormat.CustomFormat = "yyyy/MM/dd"
        Me.TermS.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.TermS.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.TermS.EditFormat.CustomFormat = "yyyy/MM/dd"
        Me.TermS.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.TermS.EditFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.TermS.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.TermS.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.TermS.GapHeight = 0
        Me.TermS.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.TermS.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.TermS.Location = New System.Drawing.Point(101, 145)
        Me.TermS.Name = "TermS"
        Me.TermS.Size = New System.Drawing.Size(150, 20)
        Me.TermS.TabIndex = 9
        Me.TermS.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.TermS, "予算管理テーマ")
        Me.TermS.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        Me.TermS.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(1, Byte), True)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(163, 168)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 20)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "～"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SystemTheme.SetTheme(Me.Label7, "(default)")
        '
        'TermE
        '
        Me.TermE.AutoSize = False
        Me.TermE.BackColor = System.Drawing.Color.White
        Me.TermE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.TermE.Calendar.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.TermE.Calendar.BackColor = System.Drawing.Color.White
        Me.TermE.Calendar.DayNamesColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.TermE.Calendar.DayNamesFont = New System.Drawing.Font("メイリオ", 9.0!)
        Me.TermE.Calendar.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.TermE.Calendar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.TermE.Calendar.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.TermE.Calendar.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.TermE.Calendar.ShowClearButton = False
        Me.TermE.Calendar.ShowTodayButton = False
        Me.TermE.Calendar.TitleBackColor = System.Drawing.Color.White
        Me.TermE.Calendar.TitleFont = New System.Drawing.Font("メイリオ", 9.0!)
        Me.TermE.Calendar.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.TermE.Calendar.TodayBorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.TermE.Calendar.TrailingForeColor = System.Drawing.SystemColors.GrayText
        Me.TermE.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.TermE.CustomFormat = "yyyy/MM/dd"
        Me.TermE.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.TermE.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.TermE.DisplayFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.TermE.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.TermE.EditFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.TermE.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.TermE.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.TermE.GapHeight = 0
        Me.TermE.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.TermE.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.TermE.Location = New System.Drawing.Point(101, 187)
        Me.TermE.Name = "TermE"
        Me.TermE.Size = New System.Drawing.Size(150, 20)
        Me.TermE.TabIndex = 10
        Me.TermE.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.TermE, "予算管理テーマ")
        Me.TermE.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        Me.TermE.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Category
        '
        Me.Category.BackColor = System.Drawing.Color.White
        Me.Category.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Category.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.Category.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.Category.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.Category.Location = New System.Drawing.Point(323, 166)
        Me.Category.Multiline = True
        Me.Category.Name = "Category"
        Me.Category.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Category.Size = New System.Drawing.Size(150, 41)
        Me.Category.TabIndex = 12
        Me.Category.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.Category, "予算管理テーマ")
        Me.Category.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Amount
        '
        Me.Amount.AutoSize = False
        Me.Amount.BackColor = System.Drawing.Color.White
        Me.Amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.Amount.Calculator.BackColor = System.Drawing.Color.White
        Me.Amount.Calculator.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.Amount.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.Amount.DataType = GetType(Single)
        Me.Amount.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.Amount.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.Amount.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.Amount.EditFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.Amount.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Amount.GapHeight = 0
        Me.Amount.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.Amount.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Amount.Location = New System.Drawing.Point(101, 124)
        Me.Amount.Name = "Amount"
        Me.Amount.Size = New System.Drawing.Size(150, 20)
        Me.Amount.TabIndex = 7
        Me.Amount.Tag = Nothing
        Me.Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SystemTheme.SetTheme(Me.Amount, "予算管理テーマ")
        Me.Amount.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.Amount.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Summary
        '
        Me.Summary.BackColor = System.Drawing.Color.White
        Me.Summary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Summary.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.Summary.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.Summary.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.Summary.Location = New System.Drawing.Point(101, 313)
        Me.Summary.Multiline = True
        Me.Summary.Name = "Summary"
        Me.Summary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Summary.Size = New System.Drawing.Size(372, 60)
        Me.Summary.TabIndex = 23
        Me.Summary.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.Summary, "予算管理テーマ")
        Me.Summary.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Remarks
        '
        Me.Remarks.AutoSize = False
        Me.Remarks.BackColor = System.Drawing.Color.White
        Me.Remarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Remarks.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.Remarks.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.Remarks.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.Remarks.Location = New System.Drawing.Point(101, 435)
        Me.Remarks.Multiline = True
        Me.Remarks.Name = "Remarks"
        Me.Remarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Remarks.Size = New System.Drawing.Size(372, 60)
        Me.Remarks.TabIndex = 25
        Me.Remarks.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.Remarks, "予算管理テーマ")
        Me.Remarks.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'SubContractRate
        '
        Me.SubContractRate.AutoSize = False
        Me.SubContractRate.BackColor = System.Drawing.Color.White
        Me.SubContractRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SubContractRate.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.SubContractRate.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.SubContractRate.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.SubContractRate.Location = New System.Drawing.Point(101, 374)
        Me.SubContractRate.Multiline = True
        Me.SubContractRate.Name = "SubContractRate"
        Me.SubContractRate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.SubContractRate.Size = New System.Drawing.Size(372, 60)
        Me.SubContractRate.TabIndex = 24
        Me.SubContractRate.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.SubContractRate, "予算管理テーマ")
        Me.SubContractRate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'OutsoucersList
        '
        Me.OutsoucersList.AllowAddNew = True
        Me.OutsoucersList.AllowDelete = True
        Me.OutsoucersList.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.OutsoucersList.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.OutsoucersList.ColumnInfo = resources.GetString("OutsoucersList.ColumnInfo")
        Me.OutsoucersList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.OutsoucersList.Location = New System.Drawing.Point(101, 496)
        Me.OutsoucersList.Name = "OutsoucersList"
        Me.OutsoucersList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.OutsoucersList.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.OutsoucersList.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.OutsoucersList.ShowCellLabels = True
        Me.OutsoucersList.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.OutsoucersList.Size = New System.Drawing.Size(372, 122)
        Me.OutsoucersList.StyleInfo = resources.GetString("OutsoucersList.StyleInfo")
        Me.OutsoucersList.TabIndex = 25
        Me.SystemTheme.SetTheme(Me.OutsoucersList, "予算管理テーマ")
        '
        'Department
        '
        Me.Department.AutoSize = False
        Me.Department.BackColor = System.Drawing.Color.White
        Me.Department.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Department.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.Department.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.Department.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.Department.Location = New System.Drawing.Point(323, 124)
        Me.Department.Name = "Department"
        Me.Department.Size = New System.Drawing.Size(150, 20)
        Me.Department.TabIndex = 8
        Me.Department.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.Department, "予算管理テーマ")
        Me.Department.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Director
        '
        Me.Director.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Director.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Director.AutoSize = False
        Me.Director.BackColor = System.Drawing.Color.White
        Me.Director.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Director.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.Director.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.Director.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.Director.Location = New System.Drawing.Point(101, 208)
        Me.Director.Name = "Director"
        Me.Director.Size = New System.Drawing.Size(150, 20)
        Me.Director.TabIndex = 13
        Me.Director.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.Director, "予算管理テーマ")
        Me.Director.Value = ""
        Me.Director.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Chief
        '
        Me.Chief.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Chief.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Chief.AutoSize = False
        Me.Chief.BackColor = System.Drawing.Color.White
        Me.Chief.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Chief.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.Chief.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.Chief.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.Chief.Location = New System.Drawing.Point(101, 229)
        Me.Chief.Name = "Chief"
        Me.Chief.Size = New System.Drawing.Size(150, 20)
        Me.Chief.TabIndex = 15
        Me.Chief.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.Chief, "予算管理テーマ")
        Me.Chief.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Expert2
        '
        Me.Expert2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Expert2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Expert2.AutoSize = False
        Me.Expert2.BackColor = System.Drawing.Color.White
        Me.Expert2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Expert2.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.Expert2.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.Expert2.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.Expert2.Location = New System.Drawing.Point(101, 250)
        Me.Expert2.Name = "Expert2"
        Me.Expert2.Size = New System.Drawing.Size(150, 20)
        Me.Expert2.TabIndex = 17
        Me.Expert2.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.Expert2, "予算管理テーマ")
        Me.Expert2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Staff1
        '
        Me.Staff1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Staff1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Staff1.AutoSize = False
        Me.Staff1.BackColor = System.Drawing.Color.White
        Me.Staff1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Staff1.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.Staff1.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.Staff1.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.Staff1.Location = New System.Drawing.Point(101, 271)
        Me.Staff1.Name = "Staff1"
        Me.Staff1.Size = New System.Drawing.Size(150, 20)
        Me.Staff1.TabIndex = 19
        Me.Staff1.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.Staff1, "予算管理テーマ")
        Me.Staff1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Staff2
        '
        Me.Staff2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Staff2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Staff2.AutoSize = False
        Me.Staff2.BackColor = System.Drawing.Color.White
        Me.Staff2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Staff2.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.Staff2.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.Staff2.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.Staff2.Location = New System.Drawing.Point(101, 292)
        Me.Staff2.Name = "Staff2"
        Me.Staff2.Size = New System.Drawing.Size(150, 20)
        Me.Staff2.TabIndex = 21
        Me.Staff2.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.Staff2, "予算管理テーマ")
        Me.Staff2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Manager
        '
        Me.Manager.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Manager.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Manager.AutoSize = False
        Me.Manager.BackColor = System.Drawing.Color.White
        Me.Manager.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Manager.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.Manager.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.Manager.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.Manager.Location = New System.Drawing.Point(323, 208)
        Me.Manager.Name = "Manager"
        Me.Manager.Size = New System.Drawing.Size(150, 20)
        Me.Manager.TabIndex = 14
        Me.Manager.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.Manager, "予算管理テーマ")
        Me.Manager.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Expert1
        '
        Me.Expert1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Expert1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Expert1.AutoSize = False
        Me.Expert1.BackColor = System.Drawing.Color.White
        Me.Expert1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Expert1.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.Expert1.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.Expert1.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.Expert1.Location = New System.Drawing.Point(323, 229)
        Me.Expert1.Name = "Expert1"
        Me.Expert1.Size = New System.Drawing.Size(150, 20)
        Me.Expert1.TabIndex = 16
        Me.Expert1.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.Expert1, "予算管理テーマ")
        Me.Expert1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Expert3
        '
        Me.Expert3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Expert3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Expert3.AutoSize = False
        Me.Expert3.BackColor = System.Drawing.Color.White
        Me.Expert3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Expert3.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.Expert3.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.Expert3.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.Expert3.Location = New System.Drawing.Point(323, 250)
        Me.Expert3.Name = "Expert3"
        Me.Expert3.Size = New System.Drawing.Size(150, 20)
        Me.Expert3.TabIndex = 18
        Me.Expert3.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.Expert3, "予算管理テーマ")
        Me.Expert3.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Staff3
        '
        Me.Staff3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Staff3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Staff3.AutoSize = False
        Me.Staff3.BackColor = System.Drawing.Color.White
        Me.Staff3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Staff3.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.Staff3.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.Staff3.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.Staff3.Location = New System.Drawing.Point(323, 271)
        Me.Staff3.Name = "Staff3"
        Me.Staff3.Size = New System.Drawing.Size(150, 20)
        Me.Staff3.TabIndex = 20
        Me.Staff3.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.Staff3, "予算管理テーマ")
        Me.Staff3.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Staff4
        '
        Me.Staff4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Staff4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Staff4.AutoSize = False
        Me.Staff4.BackColor = System.Drawing.Color.White
        Me.Staff4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Staff4.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.Staff4.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.Staff4.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.Staff4.Location = New System.Drawing.Point(323, 292)
        Me.Staff4.Name = "Staff4"
        Me.Staff4.Size = New System.Drawing.Size(150, 20)
        Me.Staff4.TabIndex = 22
        Me.Staff4.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.Staff4, "予算管理テーマ")
        Me.Staff4.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'C1ComboBox2
        '
        Me.C1ComboBox2.AllowSpinLoop = False
        Me.C1ComboBox2.AutoCompleteCustomSource.AddRange(New String() {"10", "11", "12", "13", "14", "15"})
        Me.C1ComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.C1ComboBox2.AutoSize = False
        Me.C1ComboBox2.BackColor = System.Drawing.Color.White
        Me.C1ComboBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1ComboBox2.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.C1ComboBox2.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1ComboBox2.GapHeight = 0
        Me.C1ComboBox2.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1ComboBox2.Items.Add("市川工務店")
        Me.C1ComboBox2.Items.Add("巴産業")
        Me.C1ComboBox2.Items.Add("岐阜アイシー")
        Me.C1ComboBox2.Items.Add("岐阜北建設")
        Me.C1ComboBox2.Items.Add("飛高建設")
        Me.C1ComboBox2.Location = New System.Drawing.Point(0, 0)
        Me.C1ComboBox2.Name = "C1ComboBox2"
        Me.C1ComboBox2.Size = New System.Drawing.Size(200, 23)
        Me.C1ComboBox2.Style.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1ComboBox2.TabIndex = 0
        Me.C1ComboBox2.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.C1ComboBox2, "(default)")
        Me.C1ComboBox2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'BdgtDprtmnt
        '
        Me.BdgtDprtmnt.AllowSpinLoop = False
        Me.BdgtDprtmnt.AutoSize = False
        Me.BdgtDprtmnt.BackColor = System.Drawing.Color.White
        Me.BdgtDprtmnt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BdgtDprtmnt.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.BdgtDprtmnt.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.BdgtDprtmnt.GapHeight = 0
        Me.BdgtDprtmnt.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.BdgtDprtmnt.Location = New System.Drawing.Point(612, 40)
        Me.BdgtDprtmnt.Name = "BdgtDprtmnt"
        Me.BdgtDprtmnt.Size = New System.Drawing.Size(114, 20)
        Me.BdgtDprtmnt.Style.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.BdgtDprtmnt.TabIndex = 26
        Me.BdgtDprtmnt.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.BdgtDprtmnt, "予算管理テーマ")
        Me.BdgtDprtmnt.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'ExpenseRate
        '
        Me.ExpenseRate.AutoSize = False
        Me.ExpenseRate.BackColor = System.Drawing.Color.White
        Me.ExpenseRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ExpenseRate.CustomFormat = "##.##"
        Me.ExpenseRate.DataType = GetType(Object)
        Me.ExpenseRate.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.ExpenseRate.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.ExpenseRate.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.ExpenseRate.Location = New System.Drawing.Point(798, 40)
        Me.ExpenseRate.Name = "ExpenseRate"
        Me.ExpenseRate.NullText = "0.00"
        Me.ExpenseRate.Size = New System.Drawing.Size(61, 20)
        Me.ExpenseRate.TabIndex = 27
        Me.ExpenseRate.Tag = Nothing
        Me.ExpenseRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SystemTheme.SetTheme(Me.ExpenseRate, "予算管理テーマ")
        Me.ExpenseRate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Label28
        '
        Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label28.Location = New System.Drawing.Point(860, 40)
        Me.Label28.Margin = New System.Windows.Forms.Padding(0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(17, 20)
        Me.Label28.TabIndex = 85
        Me.Label28.Text = "%"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SystemTheme.SetTheme(Me.Label28, "(default)")
        '
        'BudgetBreakDown
        '
        Me.BudgetBreakDown.BackColor = System.Drawing.Color.White
        Me.BudgetBreakDown.Controls.Add(Me.Panel5)
        Me.BudgetBreakDown.Controls.Add(Me.Panel4)
        Me.BudgetBreakDown.Controls.Add(Me.Panel3)
        Me.BudgetBreakDown.Controls.Add(Me.ProjectAmount)
        Me.BudgetBreakDown.Controls.Add(Me.ProjectAmountLabel)
        Me.BudgetBreakDown.Controls.Add(Me.Panel1)
        Me.BudgetBreakDown.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.BudgetBreakDown.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BudgetBreakDown.Location = New System.Drawing.Point(542, 66)
        Me.BudgetBreakDown.Name = "BudgetBreakDown"
        Me.BudgetBreakDown.Size = New System.Drawing.Size(336, 290)
        Me.BudgetBreakDown.TabIndex = 86
        Me.BudgetBreakDown.TabStop = False
        Me.BudgetBreakDown.Text = "予算内訳"
        Me.SystemTheme.SetTheme(Me.BudgetBreakDown, "(default)")
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label43)
        Me.Panel5.Controls.Add(Me.ProfitAndLossRate)
        Me.Panel5.Controls.Add(Me.ProfitAndLoss)
        Me.Panel5.Controls.Add(Me.ProfitAndLossLabel)
        Me.Panel5.Controls.Add(Me.Label40)
        Me.Panel5.Controls.Add(Me.ConstractionCostRate)
        Me.Panel5.Controls.Add(Me.ConstractionCostLabel)
        Me.Panel5.Controls.Add(Me.ConstractionCost)
        Me.Panel5.Location = New System.Drawing.Point(8, 226)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(319, 55)
        Me.Panel5.TabIndex = 109
        '
        'Label43
        '
        Me.Label43.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label43.Location = New System.Drawing.Point(295, 28)
        Me.Label43.Margin = New System.Windows.Forms.Padding(0)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(17, 20)
        Me.Label43.TabIndex = 112
        Me.Label43.Text = "%"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SystemTheme.SetTheme(Me.Label43, "(default)")
        '
        'ProfitAndLossRate
        '
        Me.ProfitAndLossRate.AutoSize = False
        Me.ProfitAndLossRate.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ProfitAndLossRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.ProfitAndLossRate.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProfitAndLossRate.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.System
        Me.ProfitAndLossRate.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.ProfitAndLossRate.CustomFormat = "0.0"
        Me.ProfitAndLossRate.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ProfitAndLossRate.DisplayFormat.CustomFormat = "0.0"
        Me.ProfitAndLossRate.DisplayFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.ProfitAndLossRate.EditFormat.CustomFormat = "0.0"
        Me.ProfitAndLossRate.EditFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.ProfitAndLossRate.Enabled = False
        Me.ProfitAndLossRate.GapHeight = 0
        Me.ProfitAndLossRate.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.ProfitAndLossRate.Location = New System.Drawing.Point(250, 28)
        Me.ProfitAndLossRate.Name = "ProfitAndLossRate"
        Me.ProfitAndLossRate.NullText = "0.0"
        Me.ProfitAndLossRate.Size = New System.Drawing.Size(44, 20)
        Me.ProfitAndLossRate.TabIndex = 111
        Me.ProfitAndLossRate.Tag = Nothing
        Me.ProfitAndLossRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ProfitAndLossRate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.ProfitAndLossRate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'ProfitAndLoss
        '
        Me.ProfitAndLoss.AutoSize = False
        Me.ProfitAndLoss.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ProfitAndLoss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.ProfitAndLoss.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProfitAndLoss.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.System
        Me.ProfitAndLoss.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.ProfitAndLoss.DataType = GetType(Single)
        Me.ProfitAndLoss.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ProfitAndLoss.Enabled = False
        Me.ProfitAndLoss.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.ProfitAndLoss.GapHeight = 0
        Me.ProfitAndLoss.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.ProfitAndLoss.Location = New System.Drawing.Point(121, 28)
        Me.ProfitAndLoss.Name = "ProfitAndLoss"
        Me.ProfitAndLoss.NullText = "0"
        Me.ProfitAndLoss.Size = New System.Drawing.Size(120, 20)
        Me.ProfitAndLoss.TabIndex = 110
        Me.ProfitAndLoss.Tag = Nothing
        Me.ProfitAndLoss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ProfitAndLoss.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.ProfitAndLoss.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'ProfitAndLossLabel
        '
        Me.ProfitAndLossLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ProfitAndLossLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProfitAndLossLabel.Location = New System.Drawing.Point(12, 28)
        Me.ProfitAndLossLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.ProfitAndLossLabel.Name = "ProfitAndLossLabel"
        Me.ProfitAndLossLabel.Size = New System.Drawing.Size(107, 20)
        Me.ProfitAndLossLabel.TabIndex = 109
        Me.ProfitAndLossLabel.Text = "工事損益"
        Me.ProfitAndLossLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label40
        '
        Me.Label40.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label40.Location = New System.Drawing.Point(295, 6)
        Me.Label40.Margin = New System.Windows.Forms.Padding(0)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(17, 20)
        Me.Label40.TabIndex = 87
        Me.Label40.Text = "%"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SystemTheme.SetTheme(Me.Label40, "(default)")
        '
        'ConstractionCostRate
        '
        Me.ConstractionCostRate.AutoSize = False
        Me.ConstractionCostRate.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ConstractionCostRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.ConstractionCostRate.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ConstractionCostRate.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.System
        Me.ConstractionCostRate.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.ConstractionCostRate.CustomFormat = "0.0"
        Me.ConstractionCostRate.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ConstractionCostRate.DisplayFormat.CustomFormat = "0.0"
        Me.ConstractionCostRate.DisplayFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.ConstractionCostRate.EditFormat.CustomFormat = "0.0"
        Me.ConstractionCostRate.EditFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.ConstractionCostRate.Enabled = False
        Me.ConstractionCostRate.GapHeight = 0
        Me.ConstractionCostRate.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.ConstractionCostRate.Location = New System.Drawing.Point(250, 5)
        Me.ConstractionCostRate.Name = "ConstractionCostRate"
        Me.ConstractionCostRate.NullText = "0.0"
        Me.ConstractionCostRate.Size = New System.Drawing.Size(44, 20)
        Me.ConstractionCostRate.TabIndex = 108
        Me.ConstractionCostRate.Tag = Nothing
        Me.ConstractionCostRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ConstractionCostRate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.ConstractionCostRate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'ConstractionCostLabel
        '
        Me.ConstractionCostLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ConstractionCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ConstractionCostLabel.Location = New System.Drawing.Point(12, 5)
        Me.ConstractionCostLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.ConstractionCostLabel.Name = "ConstractionCostLabel"
        Me.ConstractionCostLabel.Size = New System.Drawing.Size(107, 20)
        Me.ConstractionCostLabel.TabIndex = 89
        Me.ConstractionCostLabel.Text = "工事原価 合計"
        Me.ConstractionCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ConstractionCost
        '
        Me.ConstractionCost.AutoSize = False
        Me.ConstractionCost.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ConstractionCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.ConstractionCost.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ConstractionCost.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.System
        Me.ConstractionCost.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.ConstractionCost.DataType = GetType(Single)
        Me.ConstractionCost.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ConstractionCost.Enabled = False
        Me.ConstractionCost.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.ConstractionCost.GapHeight = 0
        Me.ConstractionCost.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.ConstractionCost.Location = New System.Drawing.Point(121, 5)
        Me.ConstractionCost.Name = "ConstractionCost"
        Me.ConstractionCost.NullText = "0"
        Me.ConstractionCost.Size = New System.Drawing.Size(120, 20)
        Me.ConstractionCost.TabIndex = 107
        Me.ConstractionCost.Tag = Nothing
        Me.ConstractionCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ConstractionCost.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.ConstractionCost.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Panel4.Controls.Add(Me.SiteCostsRate)
        Me.Panel4.Controls.Add(Me.SiteCosts)
        Me.Panel4.Controls.Add(Me.Label44)
        Me.Panel4.Controls.Add(Me.SiteCostsLabel)
        Me.Panel4.Location = New System.Drawing.Point(8, 192)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(319, 31)
        Me.Panel4.TabIndex = 106
        '
        'SiteCostsRate
        '
        Me.SiteCostsRate.AutoSize = False
        Me.SiteCostsRate.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.SiteCostsRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.SiteCostsRate.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiteCostsRate.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.System
        Me.SiteCostsRate.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.SiteCostsRate.CustomFormat = "0.0"
        Me.SiteCostsRate.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.SiteCostsRate.DisplayFormat.CustomFormat = "0.0"
        Me.SiteCostsRate.DisplayFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.SiteCostsRate.EditFormat.CustomFormat = "0.0"
        Me.SiteCostsRate.EditFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.SiteCostsRate.Enabled = False
        Me.SiteCostsRate.GapHeight = 0
        Me.SiteCostsRate.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.SiteCostsRate.Location = New System.Drawing.Point(250, 5)
        Me.SiteCostsRate.Name = "SiteCostsRate"
        Me.SiteCostsRate.NullText = "0.0"
        Me.SiteCostsRate.Size = New System.Drawing.Size(44, 20)
        Me.SiteCostsRate.TabIndex = 91
        Me.SiteCostsRate.Tag = Nothing
        Me.SiteCostsRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SiteCostsRate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.SiteCostsRate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'SiteCosts
        '
        Me.SiteCosts.AutoSize = False
        Me.SiteCosts.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.SiteCosts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.SiteCosts.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SiteCosts.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.System
        Me.SiteCosts.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.SiteCosts.DataType = GetType(Single)
        Me.SiteCosts.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.SiteCosts.Enabled = False
        Me.SiteCosts.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.SiteCosts.GapHeight = 0
        Me.SiteCosts.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.SiteCosts.Location = New System.Drawing.Point(121, 5)
        Me.SiteCosts.Name = "SiteCosts"
        Me.SiteCosts.NullText = "0"
        Me.SiteCosts.Size = New System.Drawing.Size(120, 20)
        Me.SiteCosts.TabIndex = 90
        Me.SiteCosts.Tag = Nothing
        Me.SiteCosts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SiteCosts.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.SiteCosts.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Label44
        '
        Me.Label44.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label44.Location = New System.Drawing.Point(295, 6)
        Me.Label44.Margin = New System.Windows.Forms.Padding(0)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(17, 20)
        Me.Label44.TabIndex = 87
        Me.Label44.Text = "%"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SystemTheme.SetTheme(Me.Label44, "(default)")
        '
        'SiteCostsLabel
        '
        Me.SiteCostsLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.SiteCostsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SiteCostsLabel.Location = New System.Drawing.Point(12, 5)
        Me.SiteCostsLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.SiteCostsLabel.Name = "SiteCostsLabel"
        Me.SiteCostsLabel.Size = New System.Drawing.Size(107, 20)
        Me.SiteCostsLabel.TabIndex = 89
        Me.SiteCostsLabel.Text = "現場経費"
        Me.SiteCostsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Panel3.Controls.Add(Me.SubTotalRate)
        Me.Panel3.Controls.Add(Me.SubTotal)
        Me.Panel3.Controls.Add(Me.SubTotalLabel)
        Me.Panel3.Controls.Add(Me.Label38)
        Me.Panel3.Location = New System.Drawing.Point(7, 159)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(320, 30)
        Me.Panel3.TabIndex = 103
        '
        'SubTotalRate
        '
        Me.SubTotalRate.AutoSize = False
        Me.SubTotalRate.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.SubTotalRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.SubTotalRate.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SubTotalRate.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.System
        Me.SubTotalRate.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.SubTotalRate.CustomFormat = "0.0"
        Me.SubTotalRate.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.SubTotalRate.DisplayFormat.CustomFormat = "0.0"
        Me.SubTotalRate.DisplayFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.SubTotalRate.EditFormat.CustomFormat = "0.0"
        Me.SubTotalRate.EditFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.SubTotalRate.Enabled = False
        Me.SubTotalRate.GapHeight = 0
        Me.SubTotalRate.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.SubTotalRate.Location = New System.Drawing.Point(251, 5)
        Me.SubTotalRate.Name = "SubTotalRate"
        Me.SubTotalRate.NullText = "0.0"
        Me.SubTotalRate.Size = New System.Drawing.Size(44, 20)
        Me.SubTotalRate.TabIndex = 106
        Me.SubTotalRate.Tag = Nothing
        Me.SubTotalRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SubTotalRate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.SubTotalRate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'SubTotal
        '
        Me.SubTotal.AutoSize = False
        Me.SubTotal.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.SubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.SubTotal.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SubTotal.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.System
        Me.SubTotal.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.SubTotal.DataType = GetType(Single)
        Me.SubTotal.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.SubTotal.Enabled = False
        Me.SubTotal.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.SubTotal.GapHeight = 0
        Me.SubTotal.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.SubTotal.Location = New System.Drawing.Point(122, 5)
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.NullText = "0"
        Me.SubTotal.Size = New System.Drawing.Size(120, 20)
        Me.SubTotal.TabIndex = 105
        Me.SubTotal.Tag = Nothing
        Me.SubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SubTotal.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.SubTotal.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'SubTotalLabel
        '
        Me.SubTotalLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.SubTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SubTotalLabel.Location = New System.Drawing.Point(13, 5)
        Me.SubTotalLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.SubTotalLabel.Name = "SubTotalLabel"
        Me.SubTotalLabel.Size = New System.Drawing.Size(107, 20)
        Me.SubTotalLabel.TabIndex = 104
        Me.SubTotalLabel.Text = "直接工事費 計"
        Me.SubTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label38
        '
        Me.Label38.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label38.Location = New System.Drawing.Point(296, 5)
        Me.Label38.Margin = New System.Windows.Forms.Padding(0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(17, 20)
        Me.Label38.TabIndex = 93
        Me.Label38.Text = "%"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SystemTheme.SetTheme(Me.Label38, "(default)")
        '
        'ProjectAmount
        '
        Me.ProjectAmount.AutoSize = False
        Me.ProjectAmount.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ProjectAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.ProjectAmount.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProjectAmount.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.System
        Me.ProjectAmount.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.ProjectAmount.DataType = GetType(Single)
        Me.ProjectAmount.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ProjectAmount.Enabled = False
        Me.ProjectAmount.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.ProjectAmount.GapHeight = 0
        Me.ProjectAmount.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.ProjectAmount.Location = New System.Drawing.Point(136, 24)
        Me.ProjectAmount.Name = "ProjectAmount"
        Me.ProjectAmount.NullText = "0"
        Me.ProjectAmount.Size = New System.Drawing.Size(120, 20)
        Me.ProjectAmount.TabIndex = 88
        Me.ProjectAmount.Tag = Nothing
        Me.ProjectAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ProjectAmount.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.ProjectAmount.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'ProjectAmountLabel
        '
        Me.ProjectAmountLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ProjectAmountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProjectAmountLabel.Location = New System.Drawing.Point(65, 24)
        Me.ProjectAmountLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.ProjectAmountLabel.Name = "ProjectAmountLabel"
        Me.ProjectAmountLabel.Size = New System.Drawing.Size(70, 20)
        Me.ProjectAmountLabel.TabIndex = 87
        Me.ProjectAmountLabel.Text = "請負金額"
        Me.ProjectAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label37)
        Me.Panel1.Controls.Add(Me.ExpectedTotal)
        Me.Panel1.Controls.Add(Me.Label36)
        Me.Panel1.Controls.Add(Me.Mtrldffrnc)
        Me.Panel1.Controls.Add(Me.ExpectedTotalLabel)
        Me.Panel1.Controls.Add(Me.DrctCnstrctnCst)
        Me.Panel1.Controls.Add(Me.Label35)
        Me.Panel1.Controls.Add(Me.Label34)
        Me.Panel1.Controls.Add(Me.MtrldffrncLabel)
        Me.Panel1.Controls.Add(Me.ExpectedTotalRate)
        Me.Panel1.Controls.Add(Me.TmprryExpnssLabel)
        Me.Panel1.Controls.Add(Me.TmprryExpnss)
        Me.Panel1.Controls.Add(Me.MtrldffrncRate)
        Me.Panel1.Controls.Add(Me.DrctCnstrctnCstLabel)
        Me.Panel1.Controls.Add(Me.TmprryExpnssRate)
        Me.Panel1.Controls.Add(Me.DrctCnstrctnCstRt)
        Me.Panel1.Location = New System.Drawing.Point(8, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(319, 106)
        Me.Panel1.TabIndex = 97
        '
        'Label37
        '
        Me.Label37.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label37.Location = New System.Drawing.Point(295, 77)
        Me.Label37.Margin = New System.Windows.Forms.Padding(0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(17, 20)
        Me.Label37.TabIndex = 93
        Me.Label37.Text = "%"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SystemTheme.SetTheme(Me.Label37, "(default)")
        '
        'ExpectedTotal
        '
        Me.ExpectedTotal.AutoSize = False
        Me.ExpectedTotal.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ExpectedTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.ExpectedTotal.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExpectedTotal.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.System
        Me.ExpectedTotal.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.ExpectedTotal.DataType = GetType(Single)
        Me.ExpectedTotal.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ExpectedTotal.Enabled = False
        Me.ExpectedTotal.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.ExpectedTotal.GapHeight = 0
        Me.ExpectedTotal.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.ExpectedTotal.Location = New System.Drawing.Point(121, 77)
        Me.ExpectedTotal.Name = "ExpectedTotal"
        Me.ExpectedTotal.NullText = "0"
        Me.ExpectedTotal.Size = New System.Drawing.Size(120, 20)
        Me.ExpectedTotal.TabIndex = 96
        Me.ExpectedTotal.Tag = Nothing
        Me.ExpectedTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ExpectedTotal.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.ExpectedTotal.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Label36
        '
        Me.Label36.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label36.Location = New System.Drawing.Point(295, 56)
        Me.Label36.Margin = New System.Windows.Forms.Padding(0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(17, 20)
        Me.Label36.TabIndex = 89
        Me.Label36.Text = "%"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SystemTheme.SetTheme(Me.Label36, "(default)")
        '
        'Mtrldffrnc
        '
        Me.Mtrldffrnc.AutoSize = False
        Me.Mtrldffrnc.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Mtrldffrnc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Mtrldffrnc.DataType = GetType(Single)
        Me.Mtrldffrnc.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Mtrldffrnc.Enabled = False
        Me.Mtrldffrnc.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.Mtrldffrnc.Location = New System.Drawing.Point(121, 55)
        Me.Mtrldffrnc.Name = "Mtrldffrnc"
        Me.Mtrldffrnc.NullText = "0"
        Me.Mtrldffrnc.Size = New System.Drawing.Size(120, 20)
        Me.Mtrldffrnc.TabIndex = 94
        Me.Mtrldffrnc.Tag = Nothing
        Me.Mtrldffrnc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Mtrldffrnc.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'ExpectedTotalLabel
        '
        Me.ExpectedTotalLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ExpectedTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ExpectedTotalLabel.Location = New System.Drawing.Point(12, 77)
        Me.ExpectedTotalLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.ExpectedTotalLabel.Name = "ExpectedTotalLabel"
        Me.ExpectedTotalLabel.Size = New System.Drawing.Size(107, 20)
        Me.ExpectedTotalLabel.TabIndex = 95
        Me.ExpectedTotalLabel.Text = "合算見込"
        Me.ExpectedTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DrctCnstrctnCst
        '
        Me.DrctCnstrctnCst.AutoSize = False
        Me.DrctCnstrctnCst.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.DrctCnstrctnCst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.DrctCnstrctnCst.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DrctCnstrctnCst.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.System
        Me.DrctCnstrctnCst.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.DrctCnstrctnCst.DataType = GetType(Single)
        Me.DrctCnstrctnCst.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.DrctCnstrctnCst.Enabled = False
        Me.DrctCnstrctnCst.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.DrctCnstrctnCst.GapHeight = 0
        Me.DrctCnstrctnCst.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.DrctCnstrctnCst.Location = New System.Drawing.Point(121, 11)
        Me.DrctCnstrctnCst.Name = "DrctCnstrctnCst"
        Me.DrctCnstrctnCst.NullText = "0"
        Me.DrctCnstrctnCst.Size = New System.Drawing.Size(120, 20)
        Me.DrctCnstrctnCst.TabIndex = 90
        Me.DrctCnstrctnCst.Tag = Nothing
        Me.DrctCnstrctnCst.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DrctCnstrctnCst.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.DrctCnstrctnCst.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Label35
        '
        Me.Label35.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label35.Location = New System.Drawing.Point(295, 33)
        Me.Label35.Margin = New System.Windows.Forms.Padding(0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(17, 20)
        Me.Label35.TabIndex = 88
        Me.Label35.Text = "%"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SystemTheme.SetTheme(Me.Label35, "(default)")
        '
        'Label34
        '
        Me.Label34.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label34.Location = New System.Drawing.Point(295, 11)
        Me.Label34.Margin = New System.Windows.Forms.Padding(0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(17, 20)
        Me.Label34.TabIndex = 87
        Me.Label34.Text = "%"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SystemTheme.SetTheme(Me.Label34, "(default)")
        '
        'MtrldffrncLabel
        '
        Me.MtrldffrncLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.MtrldffrncLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MtrldffrncLabel.Location = New System.Drawing.Point(12, 55)
        Me.MtrldffrncLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.MtrldffrncLabel.Name = "MtrldffrncLabel"
        Me.MtrldffrncLabel.Size = New System.Drawing.Size(107, 20)
        Me.MtrldffrncLabel.TabIndex = 93
        Me.MtrldffrncLabel.Text = "材料差額"
        Me.MtrldffrncLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ExpectedTotalRate
        '
        Me.ExpectedTotalRate.AutoSize = False
        Me.ExpectedTotalRate.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ExpectedTotalRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.ExpectedTotalRate.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExpectedTotalRate.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.System
        Me.ExpectedTotalRate.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.ExpectedTotalRate.CustomFormat = "0.0"
        Me.ExpectedTotalRate.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ExpectedTotalRate.DisplayFormat.CustomFormat = "0.0"
        Me.ExpectedTotalRate.DisplayFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.ExpectedTotalRate.EditFormat.CustomFormat = "0.0"
        Me.ExpectedTotalRate.EditFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.ExpectedTotalRate.Enabled = False
        Me.ExpectedTotalRate.GapHeight = 0
        Me.ExpectedTotalRate.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.ExpectedTotalRate.Location = New System.Drawing.Point(250, 76)
        Me.ExpectedTotalRate.Name = "ExpectedTotalRate"
        Me.ExpectedTotalRate.NullText = "0.0"
        Me.ExpectedTotalRate.Size = New System.Drawing.Size(44, 20)
        Me.ExpectedTotalRate.TabIndex = 3
        Me.ExpectedTotalRate.Tag = Nothing
        Me.ExpectedTotalRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ExpectedTotalRate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.ExpectedTotalRate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'TmprryExpnssLabel
        '
        Me.TmprryExpnssLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.TmprryExpnssLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TmprryExpnssLabel.Location = New System.Drawing.Point(12, 33)
        Me.TmprryExpnssLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.TmprryExpnssLabel.Name = "TmprryExpnssLabel"
        Me.TmprryExpnssLabel.Size = New System.Drawing.Size(107, 20)
        Me.TmprryExpnssLabel.TabIndex = 91
        Me.TmprryExpnssLabel.Text = "仮設費"
        Me.TmprryExpnssLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TmprryExpnss
        '
        Me.TmprryExpnss.AutoSize = False
        Me.TmprryExpnss.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.TmprryExpnss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.TmprryExpnss.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TmprryExpnss.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.System
        Me.TmprryExpnss.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.TmprryExpnss.DataType = GetType(Single)
        Me.TmprryExpnss.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.TmprryExpnss.Enabled = False
        Me.TmprryExpnss.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.TmprryExpnss.GapHeight = 0
        Me.TmprryExpnss.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.TmprryExpnss.Location = New System.Drawing.Point(121, 33)
        Me.TmprryExpnss.Name = "TmprryExpnss"
        Me.TmprryExpnss.NullText = "0"
        Me.TmprryExpnss.Size = New System.Drawing.Size(120, 20)
        Me.TmprryExpnss.TabIndex = 92
        Me.TmprryExpnss.Tag = Nothing
        Me.TmprryExpnss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TmprryExpnss.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.TmprryExpnss.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'MtrldffrncRate
        '
        Me.MtrldffrncRate.AutoSize = False
        Me.MtrldffrncRate.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.MtrldffrncRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.MtrldffrncRate.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MtrldffrncRate.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.System
        Me.MtrldffrncRate.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.MtrldffrncRate.CustomFormat = "0.0"
        Me.MtrldffrncRate.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.MtrldffrncRate.DisplayFormat.CustomFormat = "0.0"
        Me.MtrldffrncRate.DisplayFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.MtrldffrncRate.EditFormat.CustomFormat = "0.0"
        Me.MtrldffrncRate.EditFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.MtrldffrncRate.Enabled = False
        Me.MtrldffrncRate.GapHeight = 0
        Me.MtrldffrncRate.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.MtrldffrncRate.Location = New System.Drawing.Point(250, 54)
        Me.MtrldffrncRate.Name = "MtrldffrncRate"
        Me.MtrldffrncRate.NullText = "0.0"
        Me.MtrldffrncRate.Size = New System.Drawing.Size(44, 20)
        Me.MtrldffrncRate.TabIndex = 2
        Me.MtrldffrncRate.Tag = Nothing
        Me.MtrldffrncRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MtrldffrncRate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.MtrldffrncRate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'DrctCnstrctnCstLabel
        '
        Me.DrctCnstrctnCstLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DrctCnstrctnCstLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DrctCnstrctnCstLabel.Location = New System.Drawing.Point(12, 11)
        Me.DrctCnstrctnCstLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.DrctCnstrctnCstLabel.Name = "DrctCnstrctnCstLabel"
        Me.DrctCnstrctnCstLabel.Size = New System.Drawing.Size(107, 20)
        Me.DrctCnstrctnCstLabel.TabIndex = 89
        Me.DrctCnstrctnCstLabel.Text = "直工"
        Me.DrctCnstrctnCstLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TmprryExpnssRate
        '
        Me.TmprryExpnssRate.AutoSize = False
        Me.TmprryExpnssRate.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.TmprryExpnssRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.TmprryExpnssRate.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TmprryExpnssRate.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.System
        Me.TmprryExpnssRate.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.TmprryExpnssRate.CustomFormat = "0.0"
        Me.TmprryExpnssRate.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.TmprryExpnssRate.DisplayFormat.CustomFormat = "0.0"
        Me.TmprryExpnssRate.DisplayFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.TmprryExpnssRate.EditFormat.CustomFormat = "0.0"
        Me.TmprryExpnssRate.EditFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.TmprryExpnssRate.Enabled = False
        Me.TmprryExpnssRate.GapHeight = 0
        Me.TmprryExpnssRate.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.TmprryExpnssRate.Location = New System.Drawing.Point(250, 32)
        Me.TmprryExpnssRate.Name = "TmprryExpnssRate"
        Me.TmprryExpnssRate.NullText = "0.0"
        Me.TmprryExpnssRate.Size = New System.Drawing.Size(44, 20)
        Me.TmprryExpnssRate.TabIndex = 1
        Me.TmprryExpnssRate.Tag = Nothing
        Me.TmprryExpnssRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TmprryExpnssRate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.TmprryExpnssRate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'DrctCnstrctnCstRt
        '
        Me.DrctCnstrctnCstRt.AutoSize = False
        Me.DrctCnstrctnCstRt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.DrctCnstrctnCstRt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.DrctCnstrctnCstRt.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DrctCnstrctnCstRt.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.System
        Me.DrctCnstrctnCstRt.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.DrctCnstrctnCstRt.CustomFormat = "0.0"
        Me.DrctCnstrctnCstRt.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.DrctCnstrctnCstRt.DisplayFormat.CustomFormat = "0.0"
        Me.DrctCnstrctnCstRt.DisplayFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.DrctCnstrctnCstRt.EditFormat.CustomFormat = "0.0"
        Me.DrctCnstrctnCstRt.EditFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.DrctCnstrctnCstRt.Enabled = False
        Me.DrctCnstrctnCstRt.GapHeight = 0
        Me.DrctCnstrctnCstRt.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.DrctCnstrctnCstRt.Location = New System.Drawing.Point(250, 10)
        Me.DrctCnstrctnCstRt.Name = "DrctCnstrctnCstRt"
        Me.DrctCnstrctnCstRt.NullText = "0.0"
        Me.DrctCnstrctnCstRt.Size = New System.Drawing.Size(44, 20)
        Me.DrctCnstrctnCstRt.TabIndex = 0
        Me.DrctCnstrctnCstRt.Tag = Nothing
        Me.DrctCnstrctnCstRt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DrctCnstrctnCstRt.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.DrctCnstrctnCstRt.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.AuthorizerPanel)
        Me.GroupBox2.Controls.Add(Me.CirculatorPanel)
        Me.GroupBox2.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(542, 362)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(270, 257)
        Me.GroupBox2.TabIndex = 87
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "[決裁・回覧] 役職名"
        Me.SystemTheme.SetTheme(Me.GroupBox2, "(default)")
        '
        'AuthorizerPanel
        '
        Me.AuthorizerPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.AuthorizerPanel.Controls.Add(Me.Authorizer5)
        Me.AuthorizerPanel.Controls.Add(Me.Authorizer4)
        Me.AuthorizerPanel.Controls.Add(Me.Authorizer3)
        Me.AuthorizerPanel.Controls.Add(Me.Authorizer2)
        Me.AuthorizerPanel.Controls.Add(Me.Authorizer1)
        Me.AuthorizerPanel.Controls.Add(Me.AuthorizerLabel5)
        Me.AuthorizerPanel.Controls.Add(Me.AuthorizerLabel4)
        Me.AuthorizerPanel.Controls.Add(Me.AuthorizerLabel3)
        Me.AuthorizerPanel.Controls.Add(Me.AuthorizerLabel2)
        Me.AuthorizerPanel.Controls.Add(Me.AuthorizerLabel1)
        Me.AuthorizerPanel.Location = New System.Drawing.Point(9, 18)
        Me.AuthorizerPanel.Name = "AuthorizerPanel"
        Me.AuthorizerPanel.Size = New System.Drawing.Size(248, 115)
        Me.AuthorizerPanel.TabIndex = 109
        '
        'Authorizer5
        '
        Me.Authorizer5.AutoSize = False
        Me.Authorizer5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Authorizer5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Authorizer5.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Authorizer5.Location = New System.Drawing.Point(121, 88)
        Me.Authorizer5.Name = "Authorizer5"
        Me.Authorizer5.Size = New System.Drawing.Size(110, 20)
        Me.Authorizer5.TabIndex = 97
        Me.Authorizer5.Tag = Nothing
        Me.Authorizer5.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Authorizer4
        '
        Me.Authorizer4.AutoSize = False
        Me.Authorizer4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Authorizer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Authorizer4.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Authorizer4.Location = New System.Drawing.Point(121, 67)
        Me.Authorizer4.Name = "Authorizer4"
        Me.Authorizer4.Size = New System.Drawing.Size(110, 20)
        Me.Authorizer4.TabIndex = 96
        Me.Authorizer4.Tag = Nothing
        Me.Authorizer4.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Authorizer3
        '
        Me.Authorizer3.AutoSize = False
        Me.Authorizer3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Authorizer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Authorizer3.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Authorizer3.Location = New System.Drawing.Point(121, 46)
        Me.Authorizer3.Name = "Authorizer3"
        Me.Authorizer3.Size = New System.Drawing.Size(110, 20)
        Me.Authorizer3.TabIndex = 95
        Me.Authorizer3.Tag = Nothing
        Me.Authorizer3.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Authorizer2
        '
        Me.Authorizer2.AutoSize = False
        Me.Authorizer2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Authorizer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Authorizer2.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Authorizer2.Location = New System.Drawing.Point(121, 25)
        Me.Authorizer2.Name = "Authorizer2"
        Me.Authorizer2.Size = New System.Drawing.Size(110, 20)
        Me.Authorizer2.TabIndex = 94
        Me.Authorizer2.Tag = Nothing
        Me.Authorizer2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Authorizer1
        '
        Me.Authorizer1.AutoSize = False
        Me.Authorizer1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Authorizer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Authorizer1.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Authorizer1.Location = New System.Drawing.Point(121, 4)
        Me.Authorizer1.Name = "Authorizer1"
        Me.Authorizer1.Size = New System.Drawing.Size(110, 20)
        Me.Authorizer1.TabIndex = 93
        Me.Authorizer1.Tag = Nothing
        Me.Authorizer1.Value = ""
        Me.Authorizer1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'AuthorizerLabel5
        '
        Me.AuthorizerLabel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.AuthorizerLabel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AuthorizerLabel5.Location = New System.Drawing.Point(10, 88)
        Me.AuthorizerLabel5.Margin = New System.Windows.Forms.Padding(0)
        Me.AuthorizerLabel5.Name = "AuthorizerLabel5"
        Me.AuthorizerLabel5.Size = New System.Drawing.Size(109, 20)
        Me.AuthorizerLabel5.TabIndex = 92
        Me.AuthorizerLabel5.Text = "決裁者 5"
        Me.AuthorizerLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AuthorizerLabel4
        '
        Me.AuthorizerLabel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.AuthorizerLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AuthorizerLabel4.Location = New System.Drawing.Point(10, 67)
        Me.AuthorizerLabel4.Margin = New System.Windows.Forms.Padding(0)
        Me.AuthorizerLabel4.Name = "AuthorizerLabel4"
        Me.AuthorizerLabel4.Size = New System.Drawing.Size(109, 20)
        Me.AuthorizerLabel4.TabIndex = 91
        Me.AuthorizerLabel4.Text = "決裁者 4"
        Me.AuthorizerLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AuthorizerLabel3
        '
        Me.AuthorizerLabel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.AuthorizerLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AuthorizerLabel3.Location = New System.Drawing.Point(10, 46)
        Me.AuthorizerLabel3.Margin = New System.Windows.Forms.Padding(0)
        Me.AuthorizerLabel3.Name = "AuthorizerLabel3"
        Me.AuthorizerLabel3.Size = New System.Drawing.Size(109, 20)
        Me.AuthorizerLabel3.TabIndex = 90
        Me.AuthorizerLabel3.Text = "決裁者 3"
        Me.AuthorizerLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AuthorizerLabel2
        '
        Me.AuthorizerLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.AuthorizerLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AuthorizerLabel2.Location = New System.Drawing.Point(10, 25)
        Me.AuthorizerLabel2.Margin = New System.Windows.Forms.Padding(0)
        Me.AuthorizerLabel2.Name = "AuthorizerLabel2"
        Me.AuthorizerLabel2.Size = New System.Drawing.Size(109, 20)
        Me.AuthorizerLabel2.TabIndex = 89
        Me.AuthorizerLabel2.Text = "決裁者 2"
        Me.AuthorizerLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AuthorizerLabel1
        '
        Me.AuthorizerLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.AuthorizerLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AuthorizerLabel1.Location = New System.Drawing.Point(10, 4)
        Me.AuthorizerLabel1.Margin = New System.Windows.Forms.Padding(0)
        Me.AuthorizerLabel1.Name = "AuthorizerLabel1"
        Me.AuthorizerLabel1.Size = New System.Drawing.Size(109, 20)
        Me.AuthorizerLabel1.TabIndex = 88
        Me.AuthorizerLabel1.Text = "決裁者 1"
        Me.AuthorizerLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CirculatorPanel
        '
        Me.CirculatorPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.CirculatorPanel.Controls.Add(Me.Circulator3)
        Me.CirculatorPanel.Controls.Add(Me.Circulator5)
        Me.CirculatorPanel.Controls.Add(Me.CirculatorLabel1)
        Me.CirculatorPanel.Controls.Add(Me.Circulator4)
        Me.CirculatorPanel.Controls.Add(Me.CirculatorLabel2)
        Me.CirculatorPanel.Controls.Add(Me.CirculatorLabel3)
        Me.CirculatorPanel.Controls.Add(Me.Circulator2)
        Me.CirculatorPanel.Controls.Add(Me.CirculatorLabel4)
        Me.CirculatorPanel.Controls.Add(Me.Circulator1)
        Me.CirculatorPanel.Controls.Add(Me.CirculatorLabel5)
        Me.CirculatorPanel.Location = New System.Drawing.Point(9, 137)
        Me.CirculatorPanel.Name = "CirculatorPanel"
        Me.CirculatorPanel.Size = New System.Drawing.Size(248, 117)
        Me.CirculatorPanel.TabIndex = 108
        '
        'Circulator3
        '
        Me.Circulator3.AutoSize = False
        Me.Circulator3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Circulator3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Circulator3.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Circulator3.Location = New System.Drawing.Point(121, 49)
        Me.Circulator3.Name = "Circulator3"
        Me.Circulator3.Size = New System.Drawing.Size(110, 20)
        Me.Circulator3.TabIndex = 105
        Me.Circulator3.Tag = Nothing
        Me.Circulator3.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Circulator5
        '
        Me.Circulator5.AutoSize = False
        Me.Circulator5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Circulator5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Circulator5.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Circulator5.Location = New System.Drawing.Point(121, 91)
        Me.Circulator5.Name = "Circulator5"
        Me.Circulator5.Size = New System.Drawing.Size(110, 20)
        Me.Circulator5.TabIndex = 107
        Me.Circulator5.Tag = Nothing
        Me.Circulator5.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'CirculatorLabel1
        '
        Me.CirculatorLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.CirculatorLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CirculatorLabel1.Location = New System.Drawing.Point(12, 7)
        Me.CirculatorLabel1.Margin = New System.Windows.Forms.Padding(0)
        Me.CirculatorLabel1.Name = "CirculatorLabel1"
        Me.CirculatorLabel1.Size = New System.Drawing.Size(107, 20)
        Me.CirculatorLabel1.TabIndex = 98
        Me.CirculatorLabel1.Text = "回覧者 1"
        Me.CirculatorLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Circulator4
        '
        Me.Circulator4.AutoSize = False
        Me.Circulator4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Circulator4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Circulator4.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Circulator4.Location = New System.Drawing.Point(121, 70)
        Me.Circulator4.Name = "Circulator4"
        Me.Circulator4.Size = New System.Drawing.Size(110, 20)
        Me.Circulator4.TabIndex = 106
        Me.Circulator4.Tag = Nothing
        Me.Circulator4.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'CirculatorLabel2
        '
        Me.CirculatorLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.CirculatorLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CirculatorLabel2.Location = New System.Drawing.Point(12, 28)
        Me.CirculatorLabel2.Margin = New System.Windows.Forms.Padding(0)
        Me.CirculatorLabel2.Name = "CirculatorLabel2"
        Me.CirculatorLabel2.Size = New System.Drawing.Size(107, 20)
        Me.CirculatorLabel2.TabIndex = 99
        Me.CirculatorLabel2.Text = "回覧者 2"
        Me.CirculatorLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CirculatorLabel3
        '
        Me.CirculatorLabel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.CirculatorLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CirculatorLabel3.Location = New System.Drawing.Point(12, 49)
        Me.CirculatorLabel3.Margin = New System.Windows.Forms.Padding(0)
        Me.CirculatorLabel3.Name = "CirculatorLabel3"
        Me.CirculatorLabel3.Size = New System.Drawing.Size(107, 20)
        Me.CirculatorLabel3.TabIndex = 100
        Me.CirculatorLabel3.Text = "回覧者 3"
        Me.CirculatorLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Circulator2
        '
        Me.Circulator2.AutoSize = False
        Me.Circulator2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Circulator2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Circulator2.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Circulator2.Location = New System.Drawing.Point(121, 28)
        Me.Circulator2.Name = "Circulator2"
        Me.Circulator2.Size = New System.Drawing.Size(110, 20)
        Me.Circulator2.TabIndex = 104
        Me.Circulator2.Tag = Nothing
        Me.Circulator2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'CirculatorLabel4
        '
        Me.CirculatorLabel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.CirculatorLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CirculatorLabel4.Location = New System.Drawing.Point(12, 70)
        Me.CirculatorLabel4.Margin = New System.Windows.Forms.Padding(0)
        Me.CirculatorLabel4.Name = "CirculatorLabel4"
        Me.CirculatorLabel4.Size = New System.Drawing.Size(107, 20)
        Me.CirculatorLabel4.TabIndex = 101
        Me.CirculatorLabel4.Text = "回覧者 4"
        Me.CirculatorLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Circulator1
        '
        Me.Circulator1.AutoSize = False
        Me.Circulator1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Circulator1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Circulator1.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Circulator1.Location = New System.Drawing.Point(121, 7)
        Me.Circulator1.Name = "Circulator1"
        Me.Circulator1.Size = New System.Drawing.Size(110, 20)
        Me.Circulator1.TabIndex = 103
        Me.Circulator1.Tag = Nothing
        Me.Circulator1.Value = ""
        Me.Circulator1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'CirculatorLabel5
        '
        Me.CirculatorLabel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.CirculatorLabel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CirculatorLabel5.Location = New System.Drawing.Point(12, 91)
        Me.CirculatorLabel5.Margin = New System.Windows.Forms.Padding(0)
        Me.CirculatorLabel5.Name = "CirculatorLabel5"
        Me.CirculatorLabel5.Size = New System.Drawing.Size(107, 20)
        Me.CirculatorLabel5.TabIndex = 102
        Me.CirculatorLabel5.Text = "回覧者 5"
        Me.CirculatorLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.C1ComboBox1.Location = New System.Drawing.Point(0, 0)
        Me.C1ComboBox1.Name = "C1ComboBox1"
        Me.C1ComboBox1.Size = New System.Drawing.Size(200, 23)
        Me.C1ComboBox1.Style.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1ComboBox1.TabIndex = 0
        Me.C1ComboBox1.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.C1ComboBox1, "(default)")
        Me.C1ComboBox1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Year
        '
        Me.Year.AllowSpinLoop = False
        Me.Year.AutoSize = False
        Me.Year.BackColor = System.Drawing.Color.White
        Me.Year.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Year.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.Year.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.Year.GapHeight = 0
        Me.Year.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.Year.Location = New System.Drawing.Point(323, 40)
        Me.Year.Name = "Year"
        Me.Year.Size = New System.Drawing.Size(150, 20)
        Me.Year.Style.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.Year.TabIndex = 2
        Me.Year.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.Year, "予算管理テーマ")
        Me.Year.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'CnsdrtnDate
        '
        Me.CnsdrtnDate.AutoSize = False
        Me.CnsdrtnDate.BackColor = System.Drawing.Color.White
        Me.CnsdrtnDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.CnsdrtnDate.Calendar.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.CnsdrtnDate.Calendar.BackColor = System.Drawing.Color.White
        Me.CnsdrtnDate.Calendar.DayNamesColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.CnsdrtnDate.Calendar.DayNamesFont = New System.Drawing.Font("メイリオ", 9.0!)
        Me.CnsdrtnDate.Calendar.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.CnsdrtnDate.Calendar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.CnsdrtnDate.Calendar.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.CnsdrtnDate.Calendar.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.CnsdrtnDate.Calendar.TitleBackColor = System.Drawing.Color.White
        Me.CnsdrtnDate.Calendar.TitleFont = New System.Drawing.Font("メイリオ", 9.0!)
        Me.CnsdrtnDate.Calendar.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.CnsdrtnDate.Calendar.TodayBorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.CnsdrtnDate.Calendar.TrailingForeColor = System.Drawing.SystemColors.GrayText
        Me.CnsdrtnDate.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.CnsdrtnDate.CustomFormat = "yyyy/MM/dd"
        Me.CnsdrtnDate.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.CnsdrtnDate.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.CnsdrtnDate.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.CnsdrtnDate.GapHeight = 0
        Me.CnsdrtnDate.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.CnsdrtnDate.Location = New System.Drawing.Point(323, 145)
        Me.CnsdrtnDate.Name = "CnsdrtnDate"
        Me.CnsdrtnDate.Size = New System.Drawing.Size(150, 20)
        Me.CnsdrtnDate.TabIndex = 89
        Me.CnsdrtnDate.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.CnsdrtnDate, "予算管理テーマ")
        Me.CnsdrtnDate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
        Me.CnsdrtnDate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'RemarksLabel
        '
        Me.RemarksLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.RemarksLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.RemarksLabel.Location = New System.Drawing.Point(30, 435)
        Me.RemarksLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.RemarksLabel.Name = "RemarksLabel"
        Me.RemarksLabel.Size = New System.Drawing.Size(70, 60)
        Me.RemarksLabel.TabIndex = 51
        Me.RemarksLabel.Text = "特記事項"
        Me.RemarksLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SubContractRateLabel
        '
        Me.SubContractRateLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.SubContractRateLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.SubContractRateLabel.Location = New System.Drawing.Point(30, 374)
        Me.SubContractRateLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.SubContractRateLabel.Name = "SubContractRateLabel"
        Me.SubContractRateLabel.Size = New System.Drawing.Size(70, 60)
        Me.SubContractRateLabel.TabIndex = 53
        Me.SubContractRateLabel.Text = "県内・市内" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "業者への" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "下請率"
        Me.SubContractRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OutsourcersLabel
        '
        Me.OutsourcersLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.OutsourcersLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.OutsourcersLabel.Location = New System.Drawing.Point(30, 496)
        Me.OutsourcersLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.OutsourcersLabel.Name = "OutsourcersLabel"
        Me.OutsourcersLabel.Size = New System.Drawing.Size(70, 122)
        Me.OutsourcersLabel.TabIndex = 55
        Me.OutsourcersLabel.Text = "協力会社" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "予定"
        Me.OutsourcersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.FormPanel.Controls.Add(Me.CnsdrtnDate)
        Me.FormPanel.Controls.Add(Me.Year)
        Me.FormPanel.Controls.Add(Me.Label1)
        Me.FormPanel.Controls.Add(Me.GroupBox2)
        Me.FormPanel.Controls.Add(Me.Label28)
        Me.FormPanel.Controls.Add(Me.ExpenseRate)
        Me.FormPanel.Controls.Add(Me.CostRateLabel)
        Me.FormPanel.Controls.Add(Me.BdgtDprtmnt)
        Me.FormPanel.Controls.Add(Me.BdgtDprtmntLabel)
        Me.FormPanel.Controls.Add(Me.Staff4)
        Me.FormPanel.Controls.Add(Me.Staff3)
        Me.FormPanel.Controls.Add(Me.Expert3)
        Me.FormPanel.Controls.Add(Me.Expert1)
        Me.FormPanel.Controls.Add(Me.Manager)
        Me.FormPanel.Controls.Add(Me.Staff2)
        Me.FormPanel.Controls.Add(Me.Staff1)
        Me.FormPanel.Controls.Add(Me.Expert2)
        Me.FormPanel.Controls.Add(Me.Chief)
        Me.FormPanel.Controls.Add(Me.Staff4Label)
        Me.FormPanel.Controls.Add(Me.Staff3Label)
        Me.FormPanel.Controls.Add(Me.Staff2Label)
        Me.FormPanel.Controls.Add(Me.Staff1Label)
        Me.FormPanel.Controls.Add(Me.Expert3Label)
        Me.FormPanel.Controls.Add(Me.Expert1Label)
        Me.FormPanel.Controls.Add(Me.ChiefLabel)
        Me.FormPanel.Controls.Add(Me.ManagerLabel)
        Me.FormPanel.Controls.Add(Me.Expert2Label)
        Me.FormPanel.Controls.Add(Me.Director)
        Me.FormPanel.Controls.Add(Me.DirectorLabel)
        Me.FormPanel.Controls.Add(Me.Department)
        Me.FormPanel.Controls.Add(Me.DepartmentLabel)
        Me.FormPanel.Controls.Add(Me.OutsoucersList)
        Me.FormPanel.Controls.Add(Me.OutsourcersLabel)
        Me.FormPanel.Controls.Add(Me.SubContractRate)
        Me.FormPanel.Controls.Add(Me.SubContractRateLabel)
        Me.FormPanel.Controls.Add(Me.Remarks)
        Me.FormPanel.Controls.Add(Me.RemarksLabel)
        Me.FormPanel.Controls.Add(Me.Summary)
        Me.FormPanel.Controls.Add(Me.SummaryLabel)
        Me.FormPanel.Controls.Add(Me.CnsdrtnDateLabel)
        Me.FormPanel.Controls.Add(Me.Amount)
        Me.FormPanel.Controls.Add(Me.Category)
        Me.FormPanel.Controls.Add(Me.CategoryLabel)
        Me.FormPanel.Controls.Add(Me.AmountLabel)
        Me.FormPanel.Controls.Add(Me.TermE)
        Me.FormPanel.Controls.Add(Me.Label7)
        Me.FormPanel.Controls.Add(Me.TermS)
        Me.FormPanel.Controls.Add(Me.TermLabel)
        Me.FormPanel.Controls.Add(Me.Contractee)
        Me.FormPanel.Controls.Add(Me.ContracteeLabel)
        Me.FormPanel.Controls.Add(Me.ProjectAddress)
        Me.FormPanel.Controls.Add(Me.ProjectAddressLabel)
        Me.FormPanel.Controls.Add(Me.ProjectName)
        Me.FormPanel.Controls.Add(Me.ProjectNameLabel)
        Me.FormPanel.Controls.Add(Me.ProjectCode)
        Me.FormPanel.Controls.Add(Me.ProjectCodeLabel)
        Me.FormPanel.Controls.Add(Me.Company)
        Me.FormPanel.Controls.Add(Me.CompanyLabel)
        Me.FormPanel.Controls.Add(Me.HeadLine)
        Me.FormPanel.Controls.Add(Me.BudgetBreakDown)
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
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(252, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "単価年度"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CostRateLabel
        '
        Me.CostRateLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.CostRateLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.CostRateLabel.Location = New System.Drawing.Point(727, 40)
        Me.CostRateLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.CostRateLabel.Name = "CostRateLabel"
        Me.CostRateLabel.Size = New System.Drawing.Size(70, 20)
        Me.CostRateLabel.TabIndex = 83
        Me.CostRateLabel.Text = "経費率"
        Me.CostRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BdgtDprtmntLabel
        '
        Me.BdgtDprtmntLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.BdgtDprtmntLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BdgtDprtmntLabel.Location = New System.Drawing.Point(541, 40)
        Me.BdgtDprtmntLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.BdgtDprtmntLabel.Name = "BdgtDprtmntLabel"
        Me.BdgtDprtmntLabel.Size = New System.Drawing.Size(70, 20)
        Me.BdgtDprtmntLabel.TabIndex = 81
        Me.BdgtDprtmntLabel.Text = "予算部門"
        Me.BdgtDprtmntLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Staff4Label
        '
        Me.Staff4Label.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Staff4Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Staff4Label.Location = New System.Drawing.Point(252, 292)
        Me.Staff4Label.Margin = New System.Windows.Forms.Padding(0)
        Me.Staff4Label.Name = "Staff4Label"
        Me.Staff4Label.Size = New System.Drawing.Size(70, 20)
        Me.Staff4Label.TabIndex = 69
        Me.Staff4Label.Text = "現場担当員"
        Me.Staff4Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Staff3Label
        '
        Me.Staff3Label.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Staff3Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Staff3Label.Location = New System.Drawing.Point(252, 271)
        Me.Staff3Label.Margin = New System.Windows.Forms.Padding(0)
        Me.Staff3Label.Name = "Staff3Label"
        Me.Staff3Label.Size = New System.Drawing.Size(70, 20)
        Me.Staff3Label.TabIndex = 68
        Me.Staff3Label.Text = "現場担当員"
        Me.Staff3Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Staff2Label
        '
        Me.Staff2Label.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Staff2Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Staff2Label.Location = New System.Drawing.Point(30, 292)
        Me.Staff2Label.Margin = New System.Windows.Forms.Padding(0)
        Me.Staff2Label.Name = "Staff2Label"
        Me.Staff2Label.Size = New System.Drawing.Size(70, 20)
        Me.Staff2Label.TabIndex = 67
        Me.Staff2Label.Text = "現場担当員"
        Me.Staff2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Staff1Label
        '
        Me.Staff1Label.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Staff1Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Staff1Label.Location = New System.Drawing.Point(30, 271)
        Me.Staff1Label.Margin = New System.Windows.Forms.Padding(0)
        Me.Staff1Label.Name = "Staff1Label"
        Me.Staff1Label.Size = New System.Drawing.Size(70, 20)
        Me.Staff1Label.TabIndex = 66
        Me.Staff1Label.Text = "現場担当員"
        Me.Staff1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Expert3Label
        '
        Me.Expert3Label.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Expert3Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Expert3Label.Location = New System.Drawing.Point(252, 250)
        Me.Expert3Label.Margin = New System.Windows.Forms.Padding(0)
        Me.Expert3Label.Name = "Expert3Label"
        Me.Expert3Label.Size = New System.Drawing.Size(70, 20)
        Me.Expert3Label.TabIndex = 65
        Me.Expert3Label.Text = "主任技術者"
        Me.Expert3Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Expert1Label
        '
        Me.Expert1Label.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Expert1Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Expert1Label.Location = New System.Drawing.Point(252, 229)
        Me.Expert1Label.Margin = New System.Windows.Forms.Padding(0)
        Me.Expert1Label.Name = "Expert1Label"
        Me.Expert1Label.Size = New System.Drawing.Size(70, 20)
        Me.Expert1Label.TabIndex = 64
        Me.Expert1Label.Text = "現場代理人"
        Me.Expert1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ChiefLabel
        '
        Me.ChiefLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ChiefLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ChiefLabel.Location = New System.Drawing.Point(30, 229)
        Me.ChiefLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.ChiefLabel.Name = "ChiefLabel"
        Me.ChiefLabel.Size = New System.Drawing.Size(70, 20)
        Me.ChiefLabel.TabIndex = 63
        Me.ChiefLabel.Text = "作業所長"
        Me.ChiefLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ManagerLabel
        '
        Me.ManagerLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ManagerLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ManagerLabel.Location = New System.Drawing.Point(252, 208)
        Me.ManagerLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.ManagerLabel.Name = "ManagerLabel"
        Me.ManagerLabel.Size = New System.Drawing.Size(70, 20)
        Me.ManagerLabel.TabIndex = 62
        Me.ManagerLabel.Text = "課長"
        Me.ManagerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Expert2Label
        '
        Me.Expert2Label.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Expert2Label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Expert2Label.Location = New System.Drawing.Point(30, 250)
        Me.Expert2Label.Margin = New System.Windows.Forms.Padding(0)
        Me.Expert2Label.Name = "Expert2Label"
        Me.Expert2Label.Size = New System.Drawing.Size(70, 20)
        Me.Expert2Label.TabIndex = 61
        Me.Expert2Label.Text = "監理技術者"
        Me.Expert2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DirectorLabel
        '
        Me.DirectorLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DirectorLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.DirectorLabel.Location = New System.Drawing.Point(30, 208)
        Me.DirectorLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.DirectorLabel.Name = "DirectorLabel"
        Me.DirectorLabel.Size = New System.Drawing.Size(70, 20)
        Me.DirectorLabel.TabIndex = 59
        Me.DirectorLabel.Text = "部長"
        Me.DirectorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DepartmentLabel
        '
        Me.DepartmentLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DepartmentLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.DepartmentLabel.Location = New System.Drawing.Point(252, 124)
        Me.DepartmentLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.DepartmentLabel.Name = "DepartmentLabel"
        Me.DepartmentLabel.Size = New System.Drawing.Size(70, 20)
        Me.DepartmentLabel.TabIndex = 57
        Me.DepartmentLabel.Text = "担当部署"
        Me.DepartmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SummaryLabel
        '
        Me.SummaryLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.SummaryLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.SummaryLabel.Location = New System.Drawing.Point(30, 313)
        Me.SummaryLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.SummaryLabel.Name = "SummaryLabel"
        Me.SummaryLabel.Size = New System.Drawing.Size(70, 60)
        Me.SummaryLabel.TabIndex = 49
        Me.SummaryLabel.Text = "工事概要"
        Me.SummaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CnsdrtnDateLabel
        '
        Me.CnsdrtnDateLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.CnsdrtnDateLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.CnsdrtnDateLabel.Location = New System.Drawing.Point(252, 145)
        Me.CnsdrtnDateLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.CnsdrtnDateLabel.Name = "CnsdrtnDateLabel"
        Me.CnsdrtnDateLabel.Size = New System.Drawing.Size(70, 20)
        Me.CnsdrtnDateLabel.TabIndex = 47
        Me.CnsdrtnDateLabel.Text = "検討年月日"
        Me.CnsdrtnDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CategoryLabel
        '
        Me.CategoryLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.CategoryLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.CategoryLabel.Location = New System.Drawing.Point(252, 166)
        Me.CategoryLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.CategoryLabel.Name = "CategoryLabel"
        Me.CategoryLabel.Size = New System.Drawing.Size(70, 41)
        Me.CategoryLabel.TabIndex = 44
        Me.CategoryLabel.Text = "工事種類"
        Me.CategoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AmountLabel
        '
        Me.AmountLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.AmountLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.AmountLabel.Location = New System.Drawing.Point(30, 124)
        Me.AmountLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.AmountLabel.Name = "AmountLabel"
        Me.AmountLabel.Size = New System.Drawing.Size(70, 20)
        Me.AmountLabel.TabIndex = 42
        Me.AmountLabel.Text = "請負金額"
        Me.AmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TermLabel
        '
        Me.TermLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.TermLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.TermLabel.Location = New System.Drawing.Point(30, 145)
        Me.TermLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.TermLabel.Name = "TermLabel"
        Me.TermLabel.Size = New System.Drawing.Size(70, 62)
        Me.TermLabel.TabIndex = 37
        Me.TermLabel.Text = "契約工期"
        Me.TermLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ContracteeLabel
        '
        Me.ContracteeLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ContracteeLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ContracteeLabel.Location = New System.Drawing.Point(30, 103)
        Me.ContracteeLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.ContracteeLabel.Name = "ContracteeLabel"
        Me.ContracteeLabel.Size = New System.Drawing.Size(70, 20)
        Me.ContracteeLabel.TabIndex = 35
        Me.ContracteeLabel.Text = "発注者"
        Me.ContracteeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ProjectAddressLabel
        '
        Me.ProjectAddressLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ProjectAddressLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ProjectAddressLabel.Location = New System.Drawing.Point(30, 82)
        Me.ProjectAddressLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.ProjectAddressLabel.Name = "ProjectAddressLabel"
        Me.ProjectAddressLabel.Size = New System.Drawing.Size(70, 20)
        Me.ProjectAddressLabel.TabIndex = 33
        Me.ProjectAddressLabel.Text = "工事場所"
        Me.ProjectAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ProjectNameLabel
        '
        Me.ProjectNameLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ProjectNameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ProjectNameLabel.Location = New System.Drawing.Point(252, 61)
        Me.ProjectNameLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.ProjectNameLabel.Name = "ProjectNameLabel"
        Me.ProjectNameLabel.Size = New System.Drawing.Size(70, 20)
        Me.ProjectNameLabel.TabIndex = 31
        Me.ProjectNameLabel.Text = "工事名"
        Me.ProjectNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ProjectCodeLabel
        '
        Me.ProjectCodeLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ProjectCodeLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ProjectCodeLabel.Location = New System.Drawing.Point(30, 61)
        Me.ProjectCodeLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.ProjectCodeLabel.Name = "ProjectCodeLabel"
        Me.ProjectCodeLabel.Size = New System.Drawing.Size(70, 20)
        Me.ProjectCodeLabel.TabIndex = 29
        Me.ProjectCodeLabel.Text = "工事コード"
        Me.ProjectCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CompanyLabel
        '
        Me.CompanyLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.CompanyLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.CompanyLabel.Location = New System.Drawing.Point(30, 40)
        Me.CompanyLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.CompanyLabel.Name = "CompanyLabel"
        Me.CompanyLabel.Size = New System.Drawing.Size(70, 20)
        Me.CompanyLabel.TabIndex = 26
        Me.CompanyLabel.Text = "会社名"
        Me.CompanyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FooterPanel
        '
        Me.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.FooterPanel.Controls.Add(Me.Cancel)
        Me.FooterPanel.Controls.Add(Me.Entry)
        Me.FooterPanel.Dock = C1.Win.C1SplitContainer.PanelDockStyle.Bottom
        Me.FooterPanel.Height = 40
        Me.FooterPanel.Location = New System.Drawing.Point(0, 622)
        Me.FooterPanel.Name = "FooterPanel"
        Me.FooterPanel.Size = New System.Drawing.Size(990, 40)
        Me.FooterPanel.TabIndex = 1
        Me.FooterPanel.Text = "パネル2"
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
        Me.Cancel.TabIndex = 63
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
        Me.Entry.Location = New System.Drawing.Point(775, 5)
        Me.Entry.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.Entry.Name = "Entry"
        Me.Entry.Size = New System.Drawing.Size(100, 30)
        Me.Entry.TabIndex = 41
        Me.Entry.Text = "　登 録"
        Me.Entry.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Entry.UseVisualStyleBackColor = True
        '
        'OutsrcrToolTip
        '
        Me.OutsrcrToolTip.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.OutsrcrToolTip.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
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
        CType(Me.Company, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Contractee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TermS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TermE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Category, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Amount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Summary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Remarks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubContractRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OutsoucersList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Department, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Director, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chief, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Expert2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Staff1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Staff2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Manager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Expert1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Expert3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Staff3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Staff4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1ComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdgtDprtmnt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpenseRate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BudgetBreakDown.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.ProfitAndLossRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfitAndLoss, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConstractionCostRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConstractionCost, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.SiteCostsRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SiteCosts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.SubTotalRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjectAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.ExpectedTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mtrldffrnc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrctCnstrctnCst, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpectedTotalRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TmprryExpnss, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MtrldffrncRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TmprryExpnssRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrctCnstrctnCstRt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.AuthorizerPanel.ResumeLayout(False)
        CType(Me.Authorizer5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Authorizer4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Authorizer3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Authorizer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Authorizer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CirculatorPanel.ResumeLayout(False)
        CType(Me.Circulator3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Circulator5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Circulator4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Circulator2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Circulator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1ComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Year, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CnsdrtnDate, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Company As C1.Win.C1Input.C1ComboBox
    Friend WithEvents CompanyLabel As Label
    Friend WithEvents TermLabel As Label
    Friend WithEvents Contractee As C1.Win.C1Input.C1TextBox
    Friend WithEvents ContracteeLabel As Label
    Friend WithEvents ProjectAddress As C1.Win.C1Input.C1TextBox
    Friend WithEvents ProjectAddressLabel As Label
    Friend WithEvents ProjectName As C1.Win.C1Input.C1TextBox
    Friend WithEvents ProjectNameLabel As Label
    Friend WithEvents ProjectCode As C1.Win.C1Input.C1TextBox
    Friend WithEvents ProjectCodeLabel As Label
    Friend WithEvents TermS As C1.Win.C1Input.C1DateEdit
    Friend WithEvents TermE As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label7 As Label
    Friend WithEvents AmountLabel As Label
    Friend WithEvents Category As C1.Win.C1Input.C1TextBox
    Friend WithEvents CategoryLabel As Label
    Friend WithEvents Amount As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Summary As C1.Win.C1Input.C1TextBox
    Friend WithEvents SummaryLabel As Label
    Friend WithEvents CnsdrtnDateLabel As Label
    Friend WithEvents SubContractRate As C1.Win.C1Input.C1TextBox
    Friend WithEvents SubContractRateLabel As Label
    Friend WithEvents Remarks As C1.Win.C1Input.C1TextBox
    Friend WithEvents RemarksLabel As Label
    Friend WithEvents OutsoucersList As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents OutsourcersLabel As Label
    Friend WithEvents Cancel As Button
    Friend WithEvents Staff4Label As Label
    Friend WithEvents Staff3Label As Label
    Friend WithEvents Staff2Label As Label
    Friend WithEvents Staff1Label As Label
    Friend WithEvents Expert3Label As Label
    Friend WithEvents Expert1Label As Label
    Friend WithEvents ChiefLabel As Label
    Friend WithEvents ManagerLabel As Label
    Friend WithEvents Expert2Label As Label
    Friend WithEvents Director As C1.Win.C1Input.C1TextBox
    Friend WithEvents DirectorLabel As Label
    Friend WithEvents Department As C1.Win.C1Input.C1TextBox
    Friend WithEvents DepartmentLabel As Label
    Friend WithEvents Staff4 As C1.Win.C1Input.C1TextBox
    Friend WithEvents Staff3 As C1.Win.C1Input.C1TextBox
    Friend WithEvents Expert3 As C1.Win.C1Input.C1TextBox
    Friend WithEvents Expert1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents Manager As C1.Win.C1Input.C1TextBox
    Friend WithEvents Staff2 As C1.Win.C1Input.C1TextBox
    Friend WithEvents Staff1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents Expert2 As C1.Win.C1Input.C1TextBox
    Friend WithEvents Chief As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents ExpenseRate As C1.Win.C1Input.C1TextBox
    Friend WithEvents CostRateLabel As Label
    Friend WithEvents BdgtDprtmnt As C1.Win.C1Input.C1ComboBox
    Friend WithEvents BdgtDprtmntLabel As Label
    Friend WithEvents C1ComboBox2 As C1.Win.C1Input.C1ComboBox
    Friend WithEvents BudgetBreakDown As GroupBox
    Friend WithEvents ProjectAmountLabel As Label
    Friend WithEvents ExpectedTotal As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents ExpectedTotalLabel As Label
    Friend WithEvents Mtrldffrnc As C1.Win.C1Input.C1TextBox
    Friend WithEvents MtrldffrncLabel As Label
    Friend WithEvents TmprryExpnss As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents TmprryExpnssLabel As Label
    Friend WithEvents DrctCnstrctnCst As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents DrctCnstrctnCstLabel As Label
    Friend WithEvents ProjectAmount As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label37 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents ExpectedTotalRate As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents MtrldffrncRate As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents TmprryExpnssRate As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents DrctCnstrctnCstRt As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label44 As Label
    Friend WithEvents SiteCostsLabel As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents SubTotalRate As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents SubTotal As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents SubTotalLabel As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Authorizer5 As C1.Win.C1Input.C1TextBox
    Friend WithEvents Authorizer4 As C1.Win.C1Input.C1TextBox
    Friend WithEvents Authorizer3 As C1.Win.C1Input.C1TextBox
    Friend WithEvents Authorizer2 As C1.Win.C1Input.C1TextBox
    Friend WithEvents Authorizer1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents AuthorizerLabel5 As Label
    Friend WithEvents AuthorizerLabel4 As Label
    Friend WithEvents AuthorizerLabel3 As Label
    Friend WithEvents AuthorizerLabel2 As Label
    Friend WithEvents AuthorizerLabel1 As Label
    Friend WithEvents CirculatorPanel As Panel
    Friend WithEvents Circulator3 As C1.Win.C1Input.C1TextBox
    Friend WithEvents Circulator5 As C1.Win.C1Input.C1TextBox
    Friend WithEvents CirculatorLabel1 As Label
    Friend WithEvents Circulator4 As C1.Win.C1Input.C1TextBox
    Friend WithEvents CirculatorLabel2 As Label
    Friend WithEvents CirculatorLabel3 As Label
    Friend WithEvents Circulator2 As C1.Win.C1Input.C1TextBox
    Friend WithEvents CirculatorLabel4 As Label
    Friend WithEvents Circulator1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents CirculatorLabel5 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label43 As Label
    Friend WithEvents ProfitAndLossRate As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents ProfitAndLoss As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents ProfitAndLossLabel As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents ConstractionCostRate As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents ConstractionCostLabel As Label
    Friend WithEvents ConstractionCost As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents SiteCostsRate As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents SiteCosts As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents AuthorizerPanel As Panel
    Friend WithEvents Year As C1.Win.C1Input.C1ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents C1ComboBox1 As C1.Win.C1Input.C1ComboBox
    Friend WithEvents OutsrcrToolTip As ToolTip
    Friend WithEvents CnsdrtnDate As C1.Win.C1Input.C1DateEdit
End Class
