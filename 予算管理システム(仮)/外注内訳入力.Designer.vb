<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 外注内訳入力
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(外注内訳入力))
        Me.ButtonImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FormSplitContainer = New C1.Win.C1SplitContainer.C1SplitContainer()
        Me.FormPanel = New C1.Win.C1SplitContainer.C1SplitterPanel()

        Me.Grid = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Contract_No = New System.Windows.Forms.Label()
        Me.SearchSelect = New C1.Win.C1Input.C1ComboBox()
       me.ChangeDetails = New C1.Win.C1Input.C1TextBox()
        CType(Me.FormSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FormSplitContainer.SuspendLayout()
        Me.FormPanel.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FooterPanel.SuspendLayout()
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChangeDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FooterPanel = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.SystemTheme = New C1.Win.C1Themes.C1ThemeController()
      
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
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Button4.ImageIndex = 3
        Me.Button4.ImageList = Me.ButtonImageList
        Me.Button4.Location = New System.Drawing.Point(878, 6)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 30)
        Me.Button4.TabIndex = 49
        Me.Button4.Text = "　登　録"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(14, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 18)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "<< 外注内訳入力"
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
        Me.FormSplitContainer.TabIndex = 51
        Me.FormSplitContainer.ToolTipGradient = C1.Win.C1SplitContainer.ToolTipGradient.Blue
        Me.FormSplitContainer.UseParentVisualStyle = False
        '
        'FormPanel
        '
        Me.FormPanel.BackColor = System.Drawing.Color.White

        Me.FormPanel.Controls.Add(Me.ChangeDetails)
        Me.FormPanel.Controls.Add(Me.Grid)

        Me.FormPanel.Controls.Add(Me.Contract_No)
        Me.FormPanel.Controls.Add(Me.SearchSelect)
        Me.FormPanel.Height = 621
        Me.FormPanel.Location = New System.Drawing.Point(0, 0)
        Me.FormPanel.Name = "FormPanel"
        Me.FormPanel.Size = New System.Drawing.Size(990, 621)
        Me.FormPanel.SizeRatio = 93.949R
        Me.FormPanel.TabIndex = 0
        Me.FormPanel.Text = "パネル1"
        '

        'Grid
        '
        Me.Grid.AllowAddNew = True
        Me.Grid.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.Grid.AllowFiltering = True
        Me.Grid.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.Grid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Grid.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.Grid.ColumnInfo = resources.GetString("Grid.ColumnInfo")
        Me.Grid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Grid.Location = New System.Drawing.Point(17, 93)
        Me.Grid.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.Grid.Name = "Grid"
        Me.Grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Grid.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.Grid.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.Grid.ShowFilterIcon = C1.Win.C1FlexGrid.FilterIconVisibility.Always
        Me.Grid.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.Grid.Size = New System.Drawing.Size(1152, 436)
        Me.Grid.StyleInfo = resources.GetString("Grid.StyleInfo")
        Me.Grid.TabIndex = 69
        Me.SystemTheme.SetTheme(Me.Grid, "予算管理テーマ")
        '
        'Contract_No
        '
        Me.Contract_No.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Contract_No.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Contract_No.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Contract_No.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Contract_No.Location = New System.Drawing.Point(28, 42)
        Me.Contract_No.Name = "Contract_No"
        Me.Contract_No.Size = New System.Drawing.Size(120, 20)
        Me.Contract_No.TabIndex = 52
        Me.Contract_No.Text = "契約回数"
        Me.Contract_No.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SystemTheme.SetTheme(Me.Contract_No, "(default)")
=======
        'FooterPanel
        '
        Me.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.FooterPanel.Controls.Add(Me.Button4)
        Me.FooterPanel.Height = 40
        Me.FooterPanel.Location = New System.Drawing.Point(0, 622)
        Me.FooterPanel.Name = "FooterPanel"
        Me.FooterPanel.Size = New System.Drawing.Size(990, 40)
        Me.FooterPanel.TabIndex = 1
        Me.FooterPanel.Text = "パネル2"

        'SearchSelect
        '
        Me.SearchSelect.AllowSpinLoop = False
        Me.SearchSelect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.SearchSelect.AutoSize = False
        Me.SearchSelect.BackColor = System.Drawing.Color.White
        Me.SearchSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SearchSelect.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.SearchSelect.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.SearchSelect.GapHeight = 0
        Me.SearchSelect.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.SearchSelect.Items.Add("正式名称で検索")
        Me.SearchSelect.Items.Add("カナ名称で検索")
        Me.SearchSelect.Location = New System.Drawing.Point(145, 42)
        Me.SearchSelect.Name = "SearchSelect"
        Me.SearchSelect.Size = New System.Drawing.Size(147, 20)
        Me.SearchSelect.Style.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.SearchSelect.TabIndex = 68
        Me.SearchSelect.Tag = Nothing
        Me.SearchSelect.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '

        '
        'ChangeDetails
        '
        Me.ChangeDetails.BackColor = System.Drawing.Color.White
        Me.ChangeDetails.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ChangeDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ChangeDetails.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.ChangeDetails.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.ChangeDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ChangeDetails.Location = New System.Drawing.Point(596, 14)
        Me.ChangeDetails.Multiline = True
        Me.ChangeDetails.Name = "ChangeDetails"
        Me.ChangeDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ChangeDetails.Size = New System.Drawing.Size(362, 50)
        Me.ChangeDetails.TabIndex = 70
        Me.ChangeDetails.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.ChangeDetails, "予算管理テーマ")
        Me.ChangeDetails.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue

        '外注内訳入力
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(990, 662)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FormSplitContainer)
        Me.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "外注内訳入力"
        Me.Text = "外注内訳入力"
        CType(Me.FormSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FormSplitContainer.ResumeLayout(False)
        Me.FormPanel.ResumeLayout(False)

        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
              Me.FooterPanel.ResumeLayout(False)
        CType(Me.SearchSelect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).EndInit()

        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonImageList As ImageList
    Friend WithEvents Button4 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents FormSplitContainer As C1.Win.C1SplitContainer.C1SplitContainer
    Friend WithEvents FormPanel As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents FooterPanel As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents SearchSelect As C1.Win.C1Input.C1ComboBox
    Friend WithEvents SystemTheme As C1.Win.C1Themes.C1ThemeController
    Friend WithEvents Contract_No As Label
    Friend WithEvents Grid As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents ChangeDetails As C1.Win.C1Input.C1TextBox

End Class
