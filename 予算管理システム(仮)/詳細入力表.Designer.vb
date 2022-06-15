<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 詳細入力表
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(詳細入力表))
        Me.ButtonImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.Entry = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FormSplitContainer = New C1.Win.C1SplitContainer.C1SplitContainer()
        Me.FormPanel = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.SubjectTotal9 = New C1.Win.C1Input.C1NumericEdit()
        Me.SubjectTotal8 = New C1.Win.C1Input.C1NumericEdit()
        Me.SubjectTotal7 = New C1.Win.C1Input.C1NumericEdit()
        Me.SubjectTotal6 = New C1.Win.C1Input.C1NumericEdit()
        Me.SubjectTotal5 = New C1.Win.C1Input.C1NumericEdit()
        Me.SubjectTotal4 = New C1.Win.C1Input.C1NumericEdit()
        Me.SubjectTotal3 = New C1.Win.C1Input.C1NumericEdit()
        Me.SubjectTotal2 = New C1.Win.C1Input.C1NumericEdit()
        Me.SubjectTotal1 = New C1.Win.C1Input.C1NumericEdit()
        Me.BalanceTotal = New C1.Win.C1Input.C1NumericEdit()
        Me.ManagementTotal = New C1.Win.C1Input.C1NumericEdit()
        Me.DetailTotal = New C1.Win.C1Input.C1NumericEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DetailList = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.FooterPanel = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.SystemTheme = New C1.Win.C1Themes.C1ThemeController()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.FormSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FormSplitContainer.SuspendLayout()
        Me.FormPanel.SuspendLayout()
        CType(Me.SubjectTotal9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubjectTotal8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubjectTotal7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubjectTotal6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubjectTotal5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubjectTotal4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubjectTotal3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubjectTotal2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubjectTotal1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BalanceTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ManagementTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FooterPanel.SuspendLayout()
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Entry.Location = New System.Drawing.Point(996, 6)
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
        Me.Label2.Location = New System.Drawing.Point(14, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 18)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "<< 詳細入力表"
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
        Me.FormSplitContainer.Size = New System.Drawing.Size(1212, 684)
        Me.FormSplitContainer.SplitterColor = System.Drawing.Color.White
        Me.FormSplitContainer.SplitterWidth = 1
        Me.FormSplitContainer.TabIndex = 51
        Me.FormSplitContainer.ToolTipGradient = C1.Win.C1SplitContainer.ToolTipGradient.Blue
        Me.FormSplitContainer.UseParentVisualStyle = False
        '
        'FormPanel
        '
        Me.FormPanel.BackColor = System.Drawing.Color.White
        Me.FormPanel.Controls.Add(Me.SubjectTotal9)
        Me.FormPanel.Controls.Add(Me.SubjectTotal8)
        Me.FormPanel.Controls.Add(Me.SubjectTotal7)
        Me.FormPanel.Controls.Add(Me.SubjectTotal6)
        Me.FormPanel.Controls.Add(Me.SubjectTotal5)
        Me.FormPanel.Controls.Add(Me.SubjectTotal4)
        Me.FormPanel.Controls.Add(Me.SubjectTotal3)
        Me.FormPanel.Controls.Add(Me.SubjectTotal2)
        Me.FormPanel.Controls.Add(Me.SubjectTotal1)
        Me.FormPanel.Controls.Add(Me.BalanceTotal)
        Me.FormPanel.Controls.Add(Me.ManagementTotal)
        Me.FormPanel.Controls.Add(Me.DetailTotal)
        Me.FormPanel.Controls.Add(Me.Label2)
        Me.FormPanel.Controls.Add(Me.Label1)
        Me.FormPanel.Controls.Add(Me.DetailList)
        Me.FormPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.FormPanel.Height = 643
        Me.FormPanel.Location = New System.Drawing.Point(0, 0)
        Me.FormPanel.Name = "FormPanel"
        Me.FormPanel.Size = New System.Drawing.Size(1212, 643)
        Me.FormPanel.SizeRatio = 94.46R
        Me.FormPanel.TabIndex = 0
        Me.FormPanel.Text = "パネル1"
        '
        'SubjectTotal9
        '
        Me.SubjectTotal9.AutoSize = False
        Me.SubjectTotal9.BackColor = System.Drawing.Color.White
        Me.SubjectTotal9.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.SubjectTotal9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.SubjectTotal9.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SubjectTotal9.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.SubjectTotal9.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.SubjectTotal9.DataType = GetType(Long)
        Me.SubjectTotal9.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.SubjectTotal9.DisplayFormat.CustomFormat = "#,##0"
        Me.SubjectTotal9.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.SubjectTotal9.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.SubjectTotal9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.SubjectTotal9.GapHeight = 0
        Me.SubjectTotal9.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.SubjectTotal9.Location = New System.Drawing.Point(1079, 561)
        Me.SubjectTotal9.Name = "SubjectTotal9"
        Me.SubjectTotal9.Size = New System.Drawing.Size(90, 60)
        Me.SubjectTotal9.TabIndex = 89
        Me.SubjectTotal9.Tag = Nothing
        Me.SubjectTotal9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SubjectTotal9.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.SubjectTotal9.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.SubjectTotal9.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'SubjectTotal8
        '
        Me.SubjectTotal8.AutoSize = False
        Me.SubjectTotal8.BackColor = System.Drawing.Color.White
        Me.SubjectTotal8.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.SubjectTotal8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.SubjectTotal8.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SubjectTotal8.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.SubjectTotal8.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.SubjectTotal8.DataType = GetType(Long)
        Me.SubjectTotal8.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.SubjectTotal8.DisplayFormat.CustomFormat = "#,##0"
        Me.SubjectTotal8.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.SubjectTotal8.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.SubjectTotal8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.SubjectTotal8.GapHeight = 0
        Me.SubjectTotal8.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.SubjectTotal8.Location = New System.Drawing.Point(989, 561)
        Me.SubjectTotal8.Name = "SubjectTotal8"
        Me.SubjectTotal8.Size = New System.Drawing.Size(90, 60)
        Me.SubjectTotal8.TabIndex = 88
        Me.SubjectTotal8.Tag = Nothing
        Me.SubjectTotal8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SubjectTotal8.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.SubjectTotal8.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.SubjectTotal8.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'SubjectTotal7
        '
        Me.SubjectTotal7.AutoSize = False
        Me.SubjectTotal7.BackColor = System.Drawing.Color.White
        Me.SubjectTotal7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.SubjectTotal7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.SubjectTotal7.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SubjectTotal7.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.SubjectTotal7.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.SubjectTotal7.DataType = GetType(Long)
        Me.SubjectTotal7.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.SubjectTotal7.DisplayFormat.CustomFormat = "#,##0"
        Me.SubjectTotal7.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.SubjectTotal7.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.SubjectTotal7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.SubjectTotal7.GapHeight = 0
        Me.SubjectTotal7.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.SubjectTotal7.Location = New System.Drawing.Point(899, 561)
        Me.SubjectTotal7.Name = "SubjectTotal7"
        Me.SubjectTotal7.Size = New System.Drawing.Size(90, 60)
        Me.SubjectTotal7.TabIndex = 87
        Me.SubjectTotal7.Tag = Nothing
        Me.SubjectTotal7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SubjectTotal7.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.SubjectTotal7.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.SubjectTotal7.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'SubjectTotal6
        '
        Me.SubjectTotal6.AutoSize = False
        Me.SubjectTotal6.BackColor = System.Drawing.Color.White
        Me.SubjectTotal6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.SubjectTotal6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.SubjectTotal6.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SubjectTotal6.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.SubjectTotal6.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.SubjectTotal6.DataType = GetType(Long)
        Me.SubjectTotal6.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.SubjectTotal6.DisplayFormat.CustomFormat = "#,##0"
        Me.SubjectTotal6.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.SubjectTotal6.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.SubjectTotal6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.SubjectTotal6.GapHeight = 0
        Me.SubjectTotal6.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.SubjectTotal6.Location = New System.Drawing.Point(809, 561)
        Me.SubjectTotal6.Name = "SubjectTotal6"
        Me.SubjectTotal6.Size = New System.Drawing.Size(90, 60)
        Me.SubjectTotal6.TabIndex = 86
        Me.SubjectTotal6.Tag = Nothing
        Me.SubjectTotal6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SubjectTotal6.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.SubjectTotal6.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.SubjectTotal6.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'SubjectTotal5
        '
        Me.SubjectTotal5.AutoSize = False
        Me.SubjectTotal5.BackColor = System.Drawing.Color.White
        Me.SubjectTotal5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.SubjectTotal5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.SubjectTotal5.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SubjectTotal5.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.SubjectTotal5.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.SubjectTotal5.DataType = GetType(Long)
        Me.SubjectTotal5.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.SubjectTotal5.DisplayFormat.CustomFormat = "#,##0"
        Me.SubjectTotal5.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.SubjectTotal5.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.SubjectTotal5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.SubjectTotal5.GapHeight = 0
        Me.SubjectTotal5.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.SubjectTotal5.Location = New System.Drawing.Point(719, 561)
        Me.SubjectTotal5.Name = "SubjectTotal5"
        Me.SubjectTotal5.Size = New System.Drawing.Size(90, 60)
        Me.SubjectTotal5.TabIndex = 85
        Me.SubjectTotal5.Tag = Nothing
        Me.SubjectTotal5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SubjectTotal5.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.SubjectTotal5.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.SubjectTotal5.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'SubjectTotal4
        '
        Me.SubjectTotal4.AutoSize = False
        Me.SubjectTotal4.BackColor = System.Drawing.Color.White
        Me.SubjectTotal4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.SubjectTotal4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.SubjectTotal4.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SubjectTotal4.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.SubjectTotal4.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.SubjectTotal4.DataType = GetType(Long)
        Me.SubjectTotal4.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.SubjectTotal4.DisplayFormat.CustomFormat = "#,##0"
        Me.SubjectTotal4.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.SubjectTotal4.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.SubjectTotal4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.SubjectTotal4.GapHeight = 0
        Me.SubjectTotal4.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.SubjectTotal4.Location = New System.Drawing.Point(629, 561)
        Me.SubjectTotal4.Name = "SubjectTotal4"
        Me.SubjectTotal4.Size = New System.Drawing.Size(90, 60)
        Me.SubjectTotal4.TabIndex = 84
        Me.SubjectTotal4.Tag = Nothing
        Me.SubjectTotal4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SubjectTotal4.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.SubjectTotal4.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.SubjectTotal4.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'SubjectTotal3
        '
        Me.SubjectTotal3.AutoSize = False
        Me.SubjectTotal3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.SubjectTotal3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.SubjectTotal3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.SubjectTotal3.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SubjectTotal3.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.SubjectTotal3.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.SubjectTotal3.DataType = GetType(Long)
        Me.SubjectTotal3.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.SubjectTotal3.DisplayFormat.CustomFormat = "#,##0"
        Me.SubjectTotal3.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.SubjectTotal3.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.SubjectTotal3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.SubjectTotal3.GapHeight = 0
        Me.SubjectTotal3.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.SubjectTotal3.Location = New System.Drawing.Point(539, 561)
        Me.SubjectTotal3.Name = "SubjectTotal3"
        Me.SubjectTotal3.Size = New System.Drawing.Size(90, 60)
        Me.SubjectTotal3.TabIndex = 83
        Me.SubjectTotal3.Tag = Nothing
        Me.SubjectTotal3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SubjectTotal3.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.SubjectTotal3.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.SubjectTotal3.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'SubjectTotal2
        '
        Me.SubjectTotal2.AutoSize = False
        Me.SubjectTotal2.BackColor = System.Drawing.Color.White
        Me.SubjectTotal2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.SubjectTotal2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.SubjectTotal2.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SubjectTotal2.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.SubjectTotal2.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.SubjectTotal2.DataType = GetType(Long)
        Me.SubjectTotal2.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.SubjectTotal2.DisplayFormat.CustomFormat = "#,##0"
        Me.SubjectTotal2.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.SubjectTotal2.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.SubjectTotal2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.SubjectTotal2.GapHeight = 0
        Me.SubjectTotal2.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.SubjectTotal2.Location = New System.Drawing.Point(449, 561)
        Me.SubjectTotal2.Name = "SubjectTotal2"
        Me.SubjectTotal2.Size = New System.Drawing.Size(90, 60)
        Me.SubjectTotal2.TabIndex = 82
        Me.SubjectTotal2.Tag = Nothing
        Me.SubjectTotal2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SubjectTotal2.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.SubjectTotal2.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.SubjectTotal2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'SubjectTotal1
        '
        Me.SubjectTotal1.AutoSize = False
        Me.SubjectTotal1.BackColor = System.Drawing.Color.White
        Me.SubjectTotal1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.SubjectTotal1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.SubjectTotal1.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SubjectTotal1.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.SubjectTotal1.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.SubjectTotal1.DataType = GetType(Long)
        Me.SubjectTotal1.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.SubjectTotal1.DisplayFormat.CustomFormat = "#,##0"
        Me.SubjectTotal1.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.SubjectTotal1.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.SubjectTotal1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.SubjectTotal1.GapHeight = 0
        Me.SubjectTotal1.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.SubjectTotal1.Location = New System.Drawing.Point(359, 561)
        Me.SubjectTotal1.Name = "SubjectTotal1"
        Me.SubjectTotal1.Size = New System.Drawing.Size(90, 60)
        Me.SubjectTotal1.TabIndex = 81
        Me.SubjectTotal1.Tag = Nothing
        Me.SubjectTotal1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SubjectTotal1.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.SubjectTotal1.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.SubjectTotal1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'BalanceTotal
        '
        Me.BalanceTotal.AutoSize = False
        Me.BalanceTotal.BackColor = System.Drawing.Color.White
        Me.BalanceTotal.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.BalanceTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.BalanceTotal.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BalanceTotal.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.BalanceTotal.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.BalanceTotal.DataType = GetType(Long)
        Me.BalanceTotal.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.BalanceTotal.DisplayFormat.CustomFormat = "#,##0"
        Me.BalanceTotal.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.BalanceTotal.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.BalanceTotal.ForeColor = System.Drawing.Color.Red
        Me.BalanceTotal.GapHeight = 0
        Me.BalanceTotal.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.BalanceTotal.Location = New System.Drawing.Point(269, 601)
        Me.BalanceTotal.Name = "BalanceTotal"
        Me.BalanceTotal.Size = New System.Drawing.Size(90, 20)
        Me.BalanceTotal.TabIndex = 80
        Me.BalanceTotal.Tag = Nothing
        Me.BalanceTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.BalanceTotal.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.BalanceTotal.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'ManagementTotal
        '
        Me.ManagementTotal.AutoSize = False
        Me.ManagementTotal.BackColor = System.Drawing.Color.White
        Me.ManagementTotal.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ManagementTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.ManagementTotal.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ManagementTotal.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.ManagementTotal.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.ManagementTotal.DataType = GetType(Long)
        Me.ManagementTotal.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.ManagementTotal.DisplayFormat.CustomFormat = "#,##0"
        Me.ManagementTotal.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.ManagementTotal.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.ManagementTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ManagementTotal.GapHeight = 0
        Me.ManagementTotal.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.ManagementTotal.Location = New System.Drawing.Point(269, 581)
        Me.ManagementTotal.Name = "ManagementTotal"
        Me.ManagementTotal.Size = New System.Drawing.Size(90, 20)
        Me.ManagementTotal.TabIndex = 79
        Me.ManagementTotal.Tag = Nothing
        Me.ManagementTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ManagementTotal.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.ManagementTotal.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'DetailTotal
        '
        Me.DetailTotal.AutoSize = False
        Me.DetailTotal.BackColor = System.Drawing.Color.White
        Me.DetailTotal.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.DetailTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.DetailTotal.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DetailTotal.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.DetailTotal.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.DetailTotal.DataType = GetType(Long)
        Me.DetailTotal.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.DetailTotal.DisplayFormat.CustomFormat = "#,##0"
        Me.DetailTotal.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.DetailTotal.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.DetailTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.DetailTotal.GapHeight = 0
        Me.DetailTotal.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.DetailTotal.Location = New System.Drawing.Point(269, 561)
        Me.DetailTotal.Name = "DetailTotal"
        Me.DetailTotal.Size = New System.Drawing.Size(90, 20)
        Me.DetailTotal.TabIndex = 78
        Me.DetailTotal.Tag = Nothing
        Me.DetailTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DetailTotal.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.DetailTotal.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(196, 561)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 60)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "合計"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DetailList
        '
        Me.DetailList.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.DetailList.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Custom
        Me.DetailList.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.DetailList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DetailList.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.DetailList.ColumnInfo = resources.GetString("DetailList.ColumnInfo")
        Me.DetailList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.DetailList.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.DetailList.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.DetailList.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.DetailList.Location = New System.Drawing.Point(17, 53)
        Me.DetailList.Margin = New System.Windows.Forms.Padding(0)
        Me.DetailList.Name = "DetailList"
        Me.DetailList.Rows.Count = 3
        Me.DetailList.Rows.Fixed = 3
        Me.DetailList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DetailList.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.DetailList.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.DetailList.ShowCellLabels = True
        Me.DetailList.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.DetailList.Size = New System.Drawing.Size(1170, 508)
        Me.DetailList.StyleInfo = resources.GetString("DetailList.StyleInfo")
        Me.DetailList.TabIndex = 71
        Me.SystemTheme.SetTheme(Me.DetailList, "予算管理テーマ2")
        '
        'FooterPanel
        '
        Me.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.FooterPanel.Controls.Add(Me.Cancel)
        Me.FooterPanel.Controls.Add(Me.Entry)
        Me.FooterPanel.Height = 40
        Me.FooterPanel.Location = New System.Drawing.Point(0, 644)
        Me.FooterPanel.Name = "FooterPanel"
        Me.FooterPanel.Size = New System.Drawing.Size(1212, 40)
        Me.FooterPanel.TabIndex = 1
        Me.FooterPanel.Text = "パネル2"
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
        Me.Cancel.Location = New System.Drawing.Point(1102, 6)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(100, 30)
        Me.Cancel.TabIndex = 50
        Me.Cancel.Text = "キャンセル"
        Me.Cancel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        '
        '詳細入力表
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1212, 684)
        Me.Controls.Add(Me.FormSplitContainer)
        Me.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "詳細入力表"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.FormSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FormSplitContainer.ResumeLayout(False)
        Me.FormPanel.ResumeLayout(False)
        Me.FormPanel.PerformLayout()
        CType(Me.SubjectTotal9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubjectTotal8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubjectTotal7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubjectTotal6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubjectTotal5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubjectTotal4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubjectTotal3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubjectTotal2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubjectTotal1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BalanceTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ManagementTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FooterPanel.ResumeLayout(False)
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonImageList As ImageList
    Friend WithEvents Entry As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents FormSplitContainer As C1.Win.C1SplitContainer.C1SplitContainer
    Friend WithEvents FormPanel As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents FooterPanel As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents SystemTheme As C1.Win.C1Themes.C1ThemeController
    Friend WithEvents DetailList As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Cancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BalanceTotal As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents ManagementTotal As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents DetailTotal As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents SubjectTotal1 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents SubjectTotal9 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents SubjectTotal8 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents SubjectTotal7 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents SubjectTotal6 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents SubjectTotal5 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents SubjectTotal4 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents SubjectTotal3 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents SubjectTotal2 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
