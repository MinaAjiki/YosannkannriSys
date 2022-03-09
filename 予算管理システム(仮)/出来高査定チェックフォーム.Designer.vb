<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 出来高査定チェックフォーム
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(出来高査定チェックフォーム))
        Me.FormSplitContainer = New C1.Win.C1SplitContainer.C1SplitContainer()
        Me.FormPanel = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.QAssesEx = New System.Windows.Forms.Button()
        Me.QAssesComp = New System.Windows.Forms.Button()
        Me.QAsses = New System.Windows.Forms.Button()
        Me.AssesComp = New System.Windows.Forms.Button()
        Me.Asses = New System.Windows.Forms.Button()
        Me.DetailsList = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.VendorList = New C1.Win.C1Input.C1ComboBox()
        Me.VendorNo = New C1.Win.C1Input.C1TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FooterPanel = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.ButtonImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.SystemTheme = New C1.Win.C1Themes.C1ThemeController()
        Me.C1XLBook1 = New C1.C1Excel.C1XLBook()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.FormSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FormSplitContainer.SuspendLayout()
        Me.FormPanel.SuspendLayout()
        CType(Me.DetailsList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorNo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FooterPanel.SuspendLayout()
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.FormSplitContainer.TabIndex = 0
        Me.FormSplitContainer.ToolTipGradient = C1.Win.C1SplitContainer.ToolTipGradient.Blue
        Me.FormSplitContainer.UseParentVisualStyle = False
        '
        'FormPanel
        '
        Me.FormPanel.BackColor = System.Drawing.Color.White
        Me.FormPanel.Controls.Add(Me.QAssesEx)
        Me.FormPanel.Controls.Add(Me.QAssesComp)
        Me.FormPanel.Controls.Add(Me.QAsses)
        Me.FormPanel.Controls.Add(Me.AssesComp)
        Me.FormPanel.Controls.Add(Me.Asses)
        Me.FormPanel.Controls.Add(Me.DetailsList)
        Me.FormPanel.Controls.Add(Me.VendorList)
        Me.FormPanel.Controls.Add(Me.VendorNo)
        Me.FormPanel.Controls.Add(Me.Label1)
        Me.FormPanel.Height = 621
        Me.FormPanel.Location = New System.Drawing.Point(0, 0)
        Me.FormPanel.Name = "FormPanel"
        Me.FormPanel.ResizeWhileDragging = True
        Me.FormPanel.Size = New System.Drawing.Size(990, 621)
        Me.FormPanel.SizeRatio = 93.949R
        Me.FormPanel.TabIndex = 0
        Me.FormPanel.Text = "パネル1"
        '
        'QAssesEx
        '
        Me.QAssesEx.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.QAssesEx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.QAssesEx.Location = New System.Drawing.Point(521, 562)
        Me.QAssesEx.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.QAssesEx.Name = "QAssesEx"
        Me.QAssesEx.Size = New System.Drawing.Size(120, 55)
        Me.QAssesEx.TabIndex = 8
        Me.QAssesEx.Text = "出来高数量査定書" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Excel出力)"
        Me.QAssesEx.UseVisualStyleBackColor = False
        '
        'QAssesComp
        '
        Me.QAssesComp.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.QAssesComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.QAssesComp.Location = New System.Drawing.Point(395, 562)
        Me.QAssesComp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.QAssesComp.Name = "QAssesComp"
        Me.QAssesComp.Size = New System.Drawing.Size(120, 55)
        Me.QAssesComp.TabIndex = 7
        Me.QAssesComp.Text = "出来高数量査定書" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(完成)"
        Me.QAssesComp.UseVisualStyleBackColor = False
        '
        'QAsses
        '
        Me.QAsses.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.QAsses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.QAsses.Location = New System.Drawing.Point(269, 562)
        Me.QAsses.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.QAsses.Name = "QAsses"
        Me.QAsses.Size = New System.Drawing.Size(120, 55)
        Me.QAsses.TabIndex = 6
        Me.QAsses.Text = "出来高数量査定書" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(中間)"
        Me.QAsses.UseVisualStyleBackColor = False
        '
        'AssesComp
        '
        Me.AssesComp.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.AssesComp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AssesComp.Location = New System.Drawing.Point(143, 562)
        Me.AssesComp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AssesComp.Name = "AssesComp"
        Me.AssesComp.Size = New System.Drawing.Size(120, 55)
        Me.AssesComp.TabIndex = 5
        Me.AssesComp.Text = "完成出来高印刷"
        Me.AssesComp.UseVisualStyleBackColor = False
        '
        'Asses
        '
        Me.Asses.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Asses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Asses.Location = New System.Drawing.Point(17, 562)
        Me.Asses.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Asses.Name = "Asses"
        Me.Asses.Size = New System.Drawing.Size(120, 55)
        Me.Asses.TabIndex = 4
        Me.Asses.Text = "出来高査定書印刷"
        Me.Asses.UseVisualStyleBackColor = False
        '
        'DetailsList
        '
        Me.DetailsList.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.DetailsList.AllowEditing = False
        Me.DetailsList.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.Custom
        Me.DetailsList.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.DetailsList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DetailsList.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.DetailsList.ColumnInfo = resources.GetString("DetailsList.ColumnInfo")
        Me.DetailsList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.DetailsList.HighLight = C1.Win.C1FlexGrid.HighLightEnum.Never
        Me.DetailsList.Location = New System.Drawing.Point(17, 83)
        Me.DetailsList.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.DetailsList.Name = "DetailsList"
        Me.DetailsList.Rows.Count = 20
        Me.DetailsList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DetailsList.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.DetailsList.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.DetailsList.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.DetailsList.Size = New System.Drawing.Size(839, 473)
        Me.DetailsList.StyleInfo = resources.GetString("DetailsList.StyleInfo")
        Me.DetailsList.TabIndex = 3
        Me.SystemTheme.SetTheme(Me.DetailsList, "予算管理テーマ2")
        '
        'VendorList
        '
        Me.VendorList.AllowSpinLoop = False
        Me.VendorList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.VendorList.AutoSize = False
        Me.VendorList.BackColor = System.Drawing.Color.White
        Me.VendorList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VendorList.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.VendorList.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.VendorList.GapHeight = 0
        Me.VendorList.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.VendorList.Items.Add("㈱市川工務店")
        Me.VendorList.Location = New System.Drawing.Point(112, 54)
        Me.VendorList.Name = "VendorList"
        Me.VendorList.Size = New System.Drawing.Size(295, 23)
        Me.VendorList.Style.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.VendorList.TabIndex = 2
        Me.VendorList.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.VendorList, "予算管理テーマ")
        Me.VendorList.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'VendorNo
        '
        Me.VendorNo.BorderColor = System.Drawing.Color.Silver
        Me.VendorNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VendorNo.DataType = GetType(Integer)
        Me.VendorNo.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.VendorNo.Enabled = False
        Me.VendorNo.Location = New System.Drawing.Point(17, 54)
        Me.VendorNo.Name = "VendorNo"
        Me.VendorNo.Size = New System.Drawing.Size(89, 23)
        Me.VendorNo.TabIndex = 1
        Me.VendorNo.Tag = Nothing
        Me.VendorNo.TextDetached = True
        Me.VendorNo.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(14, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "<< 出来高査定チェックフォーム"
        '
        'FooterPanel
        '
        Me.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.FooterPanel.Controls.Add(Me.Cancel)
        Me.FooterPanel.Height = 40
        Me.FooterPanel.Location = New System.Drawing.Point(0, 622)
        Me.FooterPanel.Name = "FooterPanel"
        Me.FooterPanel.Size = New System.Drawing.Size(990, 40)
        Me.FooterPanel.TabIndex = 1
        Me.FooterPanel.Text = "パネル2"
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel.FlatAppearance.BorderSize = 0
        Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Cancel.ImageIndex = 6
        Me.Cancel.ImageList = Me.ButtonImageList
        Me.Cancel.Location = New System.Drawing.Point(881, 5)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(0)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(100, 30)
        Me.Cancel.TabIndex = 61
        Me.Cancel.Text = "キャンセル"
        Me.Cancel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'ButtonImageList
        '
        Me.ButtonImageList.ImageStream = CType(resources.GetObject("ButtonImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ButtonImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ButtonImageList.Images.SetKeyName(0, "Default.png")
        Me.ButtonImageList.Images.SetKeyName(1, "Default_mouseenter.png")
        Me.ButtonImageList.Images.SetKeyName(2, "Default_mousedown.png")
        Me.ButtonImageList.Images.SetKeyName(3, "Entry.png")
        Me.ButtonImageList.Images.SetKeyName(4, "Entry_mouseenter.png")
        Me.ButtonImageList.Images.SetKeyName(5, "Entry_mousedownpng.png")
        Me.ButtonImageList.Images.SetKeyName(6, "Cancel.png")
        Me.ButtonImageList.Images.SetKeyName(7, "Cancel_mouseenter.png")
        Me.ButtonImageList.Images.SetKeyName(8, "Cancel_mousedown.png")
        Me.ButtonImageList.Images.SetKeyName(9, "CreateCosts.png")
        Me.ButtonImageList.Images.SetKeyName(10, "CreateCosts_mouseenter.png")
        Me.ButtonImageList.Images.SetKeyName(11, "CreateCosts_mousedown.png")
        Me.ButtonImageList.Images.SetKeyName(12, "ModifiyCosts.png")
        Me.ButtonImageList.Images.SetKeyName(13, "ModifyCosts_mouseenter.png")
        Me.ButtonImageList.Images.SetKeyName(14, "ModifyCosts_mousedown.png")
        Me.ButtonImageList.Images.SetKeyName(15, "CopyCosts.png")
        Me.ButtonImageList.Images.SetKeyName(16, "CopyCosts_mouseenter.png")
        Me.ButtonImageList.Images.SetKeyName(17, "CopyCosts_mousedown.png")
        Me.ButtonImageList.Images.SetKeyName(18, "Recalculation.png")
        Me.ButtonImageList.Images.SetKeyName(19, "Recalculation_mousenter.png")
        Me.ButtonImageList.Images.SetKeyName(20, "Recalculation_mousedown.png")
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "EXCELファイル|*.xlsx|すべて|*.*"
        '
        '出来高査定チェックフォーム
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(990, 662)
        Me.Controls.Add(Me.FormSplitContainer)
        Me.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "出来高査定チェックフォーム"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "出来高査定チェックフォーム"
        CType(Me.FormSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FormSplitContainer.ResumeLayout(False)
        Me.FormPanel.ResumeLayout(False)
        Me.FormPanel.PerformLayout()
        CType(Me.DetailsList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorNo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FooterPanel.ResumeLayout(False)
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormSplitContainer As C1.Win.C1SplitContainer.C1SplitContainer
    Friend WithEvents FormPanel As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents SystemTheme As C1.Win.C1Themes.C1ThemeController
    Friend WithEvents FooterPanel As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents VendorNo As C1.Win.C1Input.C1TextBox
    Friend WithEvents VendorList As C1.Win.C1Input.C1ComboBox
    Friend WithEvents DetailsList As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents QAsses As Button
    Friend WithEvents AssesComp As Button
    Friend WithEvents Asses As Button
    Friend WithEvents QAssesEx As Button
    Friend WithEvents QAssesComp As Button
    Friend WithEvents Cancel As Button
    Private WithEvents ButtonImageList As ImageList
    Friend WithEvents C1XLBook1 As C1.C1Excel.C1XLBook
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
