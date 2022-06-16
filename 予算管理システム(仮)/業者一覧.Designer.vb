<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 業者一覧
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(業者一覧))
        Me.HeadLine = New System.Windows.Forms.Label()
        Me.ButtonImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.VendorList = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.MTORICHKAKWABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.M_TOR_ICHIKAWA = New 予算管理システム_仮_.M_TOR_ICHIKAWA()
        Me.SystemTheme = New C1.Win.C1Themes.C1ThemeController()
        Me.C1FlexGridSearchPanel1 = New C1.Win.C1FlexGrid.C1FlexGridSearchPanel()
        Me.C1ComboBox1 = New C1.Win.C1Input.C1ComboBox()
        Me.C1ComboBox2 = New C1.Win.C1Input.C1ComboBox()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.FormSplitContainer = New C1.Win.C1SplitContainer.C1SplitContainer()
        Me.C1SplitterPanel1 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.C1SplitterPanel2 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.M_TOR_ICHKAKWATableAdapter = New 予算管理システム_仮_.M_TOR_ICHIKAWATableAdapters.M_TOR_ICHKAKWATableAdapter()
        Me.M_TOR_TOMOE = New 予算管理システム_仮_.M_TOR_TOMOE()
        Me.MTORTOMOEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.M_TOR_TOMOETableAdapter = New 予算管理システム_仮_.M_TOR_TOMOETableAdapters.M_TOR_TOMOETableAdapter()
        Me.M_TOR_GIFUIC = New 予算管理システム_仮_.M_TOR_GIFUIC()
        Me.MTORGIFUICBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.M_TOR_GIFUICTableAdapter = New 予算管理システム_仮_.M_TOR_GIFUICTableAdapters.M_TOR_GIFUICTableAdapter()
        Me.M_TOR_HIDAKA = New 予算管理システム_仮_.M_TOR_HIDAKA()
        Me.MTORHIDAKABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.M_TOR_HIDAKATableAdapter = New 予算管理システム_仮_.M_TOR_HIDAKATableAdapters.M_TOR_HIDAKATableAdapter()
        Me.M_TOR_HIROKOJI = New 予算管理システム_仮_.M_TOR_HIROKOJI()
        Me.MTORHIROKOJIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.M_TOR_HIROKOJITableAdapter = New 予算管理システム_仮_.M_TOR_HIROKOJITableAdapters.M_TOR_HIROKOJITableAdapter()
        CType(Me.VendorList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MTORICHKAKWABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.M_TOR_ICHIKAWA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1ComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1ComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FormSplitContainer.SuspendLayout()
        Me.C1SplitterPanel1.SuspendLayout()
        Me.C1SplitterPanel2.SuspendLayout()
        CType(Me.M_TOR_TOMOE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MTORTOMOEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.M_TOR_GIFUIC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MTORGIFUICBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.M_TOR_HIDAKA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MTORHIDAKABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.M_TOR_HIROKOJI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MTORHIROKOJIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HeadLine
        '
        Me.HeadLine.AutoSize = True
        Me.HeadLine.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.HeadLine.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.HeadLine.Location = New System.Drawing.Point(15, 22)
        Me.HeadLine.Name = "HeadLine"
        Me.HeadLine.Size = New System.Drawing.Size(80, 18)
        Me.HeadLine.TabIndex = 27
        Me.HeadLine.Text = "<< 業者一覧"
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
        'VendorList
        '
        Me.VendorList.AllowAddNew = True
        Me.VendorList.AllowDelete = True
        Me.VendorList.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.VendorList.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.VendorList.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.VendorList.ColumnInfo = "9,1,0,0,0,-1,Columns:0{Width:1;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.VendorList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.VendorList.Location = New System.Drawing.Point(18, 115)
        Me.VendorList.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.VendorList.Name = "VendorList"
        Me.VendorList.Rows.Count = 1
        Me.VendorList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.VendorList.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.VendorList.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.VendorList.ShowCellLabels = True
        Me.VendorList.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.VendorList.Size = New System.Drawing.Size(1153, 486)
        Me.VendorList.StyleInfo = resources.GetString("VendorList.StyleInfo")
        Me.VendorList.TabIndex = 51
        Me.SystemTheme.SetTheme(Me.VendorList, "予算管理テーマ")
        '
        'MTORICHKAKWABindingSource
        '
        Me.MTORICHKAKWABindingSource.DataMember = "M_TOR_ICHKAKWA"
        Me.MTORICHKAKWABindingSource.DataSource = Me.M_TOR_ICHIKAWA
        '
        'M_TOR_ICHIKAWA
        '
        Me.M_TOR_ICHIKAWA.DataSetName = "namikou"
        Me.M_TOR_ICHIKAWA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'C1FlexGridSearchPanel1
        '
        Me.C1FlexGridSearchPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.C1FlexGridSearchPanel1.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.C1FlexGridSearchPanel1.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.C1FlexGridSearchPanel1.Location = New System.Drawing.Point(15, 82)
        Me.C1FlexGridSearchPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.C1FlexGridSearchPanel1.Name = "C1FlexGridSearchPanel1"
        Me.C1FlexGridSearchPanel1.Size = New System.Drawing.Size(274, 31)
        Me.C1FlexGridSearchPanel1.TabIndex = 68
        Me.SystemTheme.SetTheme(Me.C1FlexGridSearchPanel1, "予算管理テーマ")
        '
        'C1ComboBox1
        '
        Me.C1ComboBox1.AllowSpinLoop = False
        Me.C1ComboBox1.GapHeight = 0
        Me.C1ComboBox1.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1ComboBox1.Location = New System.Drawing.Point(0, 0)
        Me.C1ComboBox1.Name = "C1ComboBox1"
        Me.C1ComboBox1.Size = New System.Drawing.Size(200, 17)
        Me.C1ComboBox1.TabIndex = 0
        Me.C1ComboBox1.Tag = Nothing
        '
        'C1ComboBox2
        '
        Me.C1ComboBox2.AllowSpinLoop = False
        Me.C1ComboBox2.GapHeight = 0
        Me.C1ComboBox2.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1ComboBox2.Location = New System.Drawing.Point(0, 0)
        Me.C1ComboBox2.Name = "C1ComboBox2"
        Me.C1ComboBox2.Size = New System.Drawing.Size(200, 17)
        Me.C1ComboBox2.TabIndex = 0
        Me.C1ComboBox2.Tag = Nothing
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cancel.FlatAppearance.BorderSize = 0
        Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Cancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Cancel.ImageIndex = 6
        Me.Cancel.ImageList = Me.ButtonImageList
        Me.Cancel.Location = New System.Drawing.Point(1083, 6)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(100, 30)
        Me.Cancel.TabIndex = 52
        Me.Cancel.Text = "キャンセル"
        Me.Cancel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'FormSplitContainer
        '
        Me.FormSplitContainer.AutoSizeElement = C1.Framework.AutoSizeElement.Both
        Me.FormSplitContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.FormSplitContainer.CollapsingAreaColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.FormSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSplitContainer.FixedLineColor = System.Drawing.Color.White
        Me.FormSplitContainer.Font = New System.Drawing.Font("メイリオ", 10.0!)
        Me.FormSplitContainer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.FormSplitContainer.HeaderHeight = 0
        Me.FormSplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.FormSplitContainer.Name = "FormSplitContainer"
        Me.FormSplitContainer.Panels.Add(Me.C1SplitterPanel1)
        Me.FormSplitContainer.Panels.Add(Me.C1SplitterPanel2)
        Me.FormSplitContainer.Size = New System.Drawing.Size(1195, 661)
        Me.FormSplitContainer.SplitterColor = System.Drawing.Color.White
        Me.FormSplitContainer.SplitterWidth = 1
        Me.FormSplitContainer.TabIndex = 53
        Me.FormSplitContainer.ToolTipGradient = C1.Win.C1SplitContainer.ToolTipGradient.Blue
        Me.FormSplitContainer.UseParentVisualStyle = False
        '
        'C1SplitterPanel1
        '
        Me.C1SplitterPanel1.BackColor = System.Drawing.Color.White
        Me.C1SplitterPanel1.Controls.Add(Me.C1FlexGridSearchPanel1)
        Me.C1SplitterPanel1.Height = 619
        Me.C1SplitterPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1SplitterPanel1.Name = "C1SplitterPanel1"
        Me.C1SplitterPanel1.ResizeWhileDragging = True
        Me.C1SplitterPanel1.Size = New System.Drawing.Size(1195, 619)
        Me.C1SplitterPanel1.SizeRatio = 93.797R
        Me.C1SplitterPanel1.TabIndex = 0
        Me.C1SplitterPanel1.Text = "パネル1"
        '
        'C1SplitterPanel2
        '
        Me.C1SplitterPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.C1SplitterPanel2.Controls.Add(Me.Cancel)
        Me.C1SplitterPanel2.Height = 41
        Me.C1SplitterPanel2.Location = New System.Drawing.Point(0, 620)
        Me.C1SplitterPanel2.Name = "C1SplitterPanel2"
        Me.C1SplitterPanel2.Size = New System.Drawing.Size(1195, 41)
        Me.C1SplitterPanel2.TabIndex = 1
        Me.C1SplitterPanel2.Text = "パネル2"
        '
        'M_TOR_ICHKAKWATableAdapter
        '
        Me.M_TOR_ICHKAKWATableAdapter.ClearBeforeFill = True
        '
        'M_TOR_TOMOE
        '
        Me.M_TOR_TOMOE.DataSetName = "M_TOR_TOMOE"
        Me.M_TOR_TOMOE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MTORTOMOEBindingSource
        '
        Me.MTORTOMOEBindingSource.DataMember = "M_TOR_TOMOE"
        Me.MTORTOMOEBindingSource.DataSource = Me.M_TOR_TOMOE
        '
        'M_TOR_TOMOETableAdapter
        '
        Me.M_TOR_TOMOETableAdapter.ClearBeforeFill = True
        '
        'M_TOR_GIFUIC
        '
        Me.M_TOR_GIFUIC.DataSetName = "M_TOR_GIFUIC"
        Me.M_TOR_GIFUIC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MTORGIFUICBindingSource
        '
        Me.MTORGIFUICBindingSource.DataMember = "M_TOR_GIFUIC"
        Me.MTORGIFUICBindingSource.DataSource = Me.M_TOR_GIFUIC
        '
        'M_TOR_GIFUICTableAdapter
        '
        Me.M_TOR_GIFUICTableAdapter.ClearBeforeFill = True
        '
        'M_TOR_HIDAKA
        '
        Me.M_TOR_HIDAKA.DataSetName = "M_TOR_HIDAKA"
        Me.M_TOR_HIDAKA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MTORHIDAKABindingSource
        '
        Me.MTORHIDAKABindingSource.DataMember = "M_TOR_HIDAKA"
        Me.MTORHIDAKABindingSource.DataSource = Me.M_TOR_HIDAKA
        '
        'M_TOR_HIDAKATableAdapter
        '
        Me.M_TOR_HIDAKATableAdapter.ClearBeforeFill = True
        '
        'M_TOR_HIROKOJI
        '
        Me.M_TOR_HIROKOJI.DataSetName = "M_TOR_HIROKOJI"
        Me.M_TOR_HIROKOJI.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MTORHIROKOJIBindingSource
        '
        Me.MTORHIROKOJIBindingSource.DataMember = "M_TOR_HIROKOJI"
        Me.MTORHIROKOJIBindingSource.DataSource = Me.M_TOR_HIROKOJI
        '
        'M_TOR_HIROKOJITableAdapter
        '
        Me.M_TOR_HIROKOJITableAdapter.ClearBeforeFill = True
        '
        '業者一覧
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1195, 661)
        Me.Controls.Add(Me.VendorList)
        Me.Controls.Add(Me.HeadLine)
        Me.Controls.Add(Me.FormSplitContainer)
        Me.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "業者一覧"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "業者一覧"
        CType(Me.VendorList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MTORICHKAKWABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.M_TOR_ICHIKAWA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1ComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1ComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FormSplitContainer.ResumeLayout(False)
        Me.C1SplitterPanel1.ResumeLayout(False)
        Me.C1SplitterPanel2.ResumeLayout(False)
        CType(Me.M_TOR_TOMOE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MTORTOMOEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.M_TOR_GIFUIC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MTORGIFUICBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.M_TOR_HIDAKA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MTORHIDAKABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.M_TOR_HIROKOJI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MTORHIROKOJIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HeadLine As Label
    Friend WithEvents ButtonImageList As ImageList
    Friend WithEvents VendorList As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents SystemTheme As C1.Win.C1Themes.C1ThemeController
    Friend WithEvents Cancel As Button
    Friend WithEvents FormSplitContainer As C1.Win.C1SplitContainer.C1SplitContainer
    Friend WithEvents C1SplitterPanel1 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents C1SplitterPanel2 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents C1ComboBox1 As C1.Win.C1Input.C1ComboBox
    Friend WithEvents C1ComboBox2 As C1.Win.C1Input.C1ComboBox
    Friend WithEvents C1FlexGridSearchPanel1 As C1.Win.C1FlexGrid.C1FlexGridSearchPanel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents M_TOR_ICHIKAWA As M_TOR_ICHIKAWA
    Friend WithEvents MTORICHKAKWABindingSource As BindingSource
    Friend WithEvents M_TOR_ICHKAKWATableAdapter As M_TOR_ICHIKAWATableAdapters.M_TOR_ICHKAKWATableAdapter
    Friend WithEvents M_TOR_TOMOE As M_TOR_TOMOE
    Friend WithEvents MTORTOMOEBindingSource As BindingSource
    Friend WithEvents M_TOR_TOMOETableAdapter As M_TOR_TOMOETableAdapters.M_TOR_TOMOETableAdapter
    Friend WithEvents M_TOR_GIFUIC As M_TOR_GIFUIC
    Friend WithEvents MTORGIFUICBindingSource As BindingSource
    Friend WithEvents M_TOR_GIFUICTableAdapter As M_TOR_GIFUICTableAdapters.M_TOR_GIFUICTableAdapter
    Friend WithEvents M_TOR_HIDAKA As M_TOR_HIDAKA
    Friend WithEvents MTORHIDAKABindingSource As BindingSource
    Friend WithEvents M_TOR_HIDAKATableAdapter As M_TOR_HIDAKATableAdapters.M_TOR_HIDAKATableAdapter
    Friend WithEvents M_TOR_HIROKOJI As M_TOR_HIROKOJI
    Friend WithEvents MTORHIROKOJIBindingSource As BindingSource
    Friend WithEvents M_TOR_HIROKOJITableAdapter As M_TOR_HIROKOJITableAdapters.M_TOR_HIROKOJITableAdapter
End Class
