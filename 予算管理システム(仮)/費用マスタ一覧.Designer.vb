<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 費用マスタ一覧
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(費用マスタ一覧))
        Me.ButtonImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.SystemTheme = New C1.Win.C1Themes.C1ThemeController()
        Me.FormContainer = New C1.Win.C1SplitContainer.C1SplitContainer()
        Me.MainPanel = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.SearchName = New C1.Win.C1FlexGrid.C1FlexGridSearchPanel()
        Me.TableName = New System.Windows.Forms.Label()
        Me.NameLabel = New C1.Win.C1Input.C1TextBox()
        Me.HeadLine = New System.Windows.Forms.Label()
        Me.MasterContentsList = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.右クリックメニュー = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.InsertMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.PastingMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.FooterPanel = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Entry = New System.Windows.Forms.Button()
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FormContainer.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        CType(Me.NameLabel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterContentsList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.右クリックメニュー.SuspendLayout()
        Me.FooterPanel.SuspendLayout()
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
        'SystemTheme
        '
        Me.SystemTheme.Theme = "(none)"
        '
        'FormContainer
        '
        Me.FormContainer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FormContainer.AutoSizeElement = C1.Framework.AutoSizeElement.Both
        Me.FormContainer.BackColor = System.Drawing.Color.White
        Me.FormContainer.CollapsingAreaColor = System.Drawing.Color.GhostWhite
        Me.FormContainer.CollapsingCueColor = System.Drawing.Color.White
        Me.FormContainer.FixedLineColor = System.Drawing.Color.White
        Me.FormContainer.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.FormContainer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.FormContainer.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.FormContainer.HeaderHeight = 0
        Me.FormContainer.Location = New System.Drawing.Point(0, 2)
        Me.FormContainer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FormContainer.Name = "FormContainer"
        Me.FormContainer.Panels.Add(Me.MainPanel)
        Me.FormContainer.Panels.Add(Me.FooterPanel)
        Me.FormContainer.Size = New System.Drawing.Size(1195, 659)
        Me.FormContainer.SplitterColor = System.Drawing.Color.White
        Me.FormContainer.SplitterMovingColor = System.Drawing.Color.Black
        Me.FormContainer.SplitterWidth = 0
        Me.FormContainer.TabIndex = 0
        Me.SystemTheme.SetTheme(Me.FormContainer, "予算管理テーマ")
        Me.FormContainer.UseParentVisualStyle = False
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.Transparent
        Me.MainPanel.Controls.Add(Me.SearchName)
        Me.MainPanel.Controls.Add(Me.TableName)
        Me.MainPanel.Controls.Add(Me.NameLabel)
        Me.MainPanel.Controls.Add(Me.HeadLine)
        Me.MainPanel.Controls.Add(Me.MasterContentsList)
        Me.MainPanel.Height = 619
        Me.MainPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainPanel.MinHeight = 0
        Me.MainPanel.MinWidth = 0
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1195, 619)
        Me.MainPanel.SizeRatio = 93.93R
        Me.MainPanel.TabIndex = 0
        Me.MainPanel.Text = "パネル1"
        Me.MainPanel.Width = 1195
        '
        'SearchName
        '
        Me.SearchName.BackColor = System.Drawing.Color.Transparent
        Me.SearchName.Location = New System.Drawing.Point(915, 46)
        Me.SearchName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SearchName.Name = "SearchName"
        Me.SearchName.ShowClearButton = False
        Me.SearchName.Size = New System.Drawing.Size(269, 31)
        Me.SearchName.TabIndex = 64
        Me.SystemTheme.SetTheme(Me.SearchName, "予算管理テーマ")
        '
        'TableName
        '
        Me.TableName.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.TableName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TableName.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TableName.Location = New System.Drawing.Point(29, 42)
        Me.TableName.Name = "TableName"
        Me.TableName.Size = New System.Drawing.Size(82, 35)
        Me.TableName.TabIndex = 59
        Me.TableName.Text = "労務費マスタ"
        Me.TableName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = False
        Me.NameLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.NameLabel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.NameLabel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NameLabel.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.NameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.NameLabel.Location = New System.Drawing.Point(857, 50)
        Me.NameLabel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(59, 23)
        Me.NameLabel.TabIndex = 61
        Me.NameLabel.Tag = Nothing
        Me.NameLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NameLabel.Value = "名称検索"
        Me.NameLabel.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        '
        'HeadLine
        '
        Me.HeadLine.AutoSize = True
        Me.HeadLine.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.HeadLine.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.HeadLine.Location = New System.Drawing.Point(14, 14)
        Me.HeadLine.Name = "HeadLine"
        Me.HeadLine.Size = New System.Drawing.Size(112, 18)
        Me.HeadLine.TabIndex = 58
        Me.HeadLine.Text = "<<費用マスタ一覧"
        '
        'MasterContentsList
        '
        Me.MasterContentsList.AllowAddNew = True
        Me.MasterContentsList.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.MasterContentsList.AllowFiltering = True
        Me.MasterContentsList.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.MasterContentsList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MasterContentsList.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.MasterContentsList.ColumnInfo = resources.GetString("MasterContentsList.ColumnInfo")
        Me.MasterContentsList.ContextMenuStrip = Me.右クリックメニュー
        Me.MasterContentsList.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.MasterContentsList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.MasterContentsList.Location = New System.Drawing.Point(29, 78)
        Me.MasterContentsList.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.MasterContentsList.Name = "MasterContentsList"
        Me.MasterContentsList.Rows.Count = 22
        Me.MasterContentsList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.MasterContentsList.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.MasterContentsList.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell
        Me.MasterContentsList.ShowFilterIcon = C1.Win.C1FlexGrid.FilterIconVisibility.Always
        Me.MasterContentsList.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.MasterContentsList.Size = New System.Drawing.Size(1152, 532)
        Me.MasterContentsList.StyleInfo = resources.GetString("MasterContentsList.StyleInfo")
        Me.MasterContentsList.TabIndex = 60
        Me.SystemTheme.SetTheme(Me.MasterContentsList, "予算管理テーマ")
        '
        '右クリックメニュー
        '
        Me.右クリックメニュー.BackColor = System.Drawing.Color.White
        Me.右クリックメニュー.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.右クリックメニュー.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertMenu, Me.CutMenu, Me.CopyMenu, Me.PastingMenu})
        Me.右クリックメニュー.Name = "ContextMenuStrip1"
        Me.右クリックメニュー.ShowImageMargin = False
        Me.右クリックメニュー.Size = New System.Drawing.Size(171, 92)
        Me.右クリックメニュー.Text = "項目選択"
        Me.SystemTheme.SetTheme(Me.右クリックメニュー, "(default)")
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
        'FooterPanel
        '
        Me.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.FooterPanel.Controls.Add(Me.Cancel)
        Me.FooterPanel.Controls.Add(Me.Entry)
        Me.FooterPanel.Height = 40
        Me.FooterPanel.Location = New System.Drawing.Point(0, 619)
        Me.FooterPanel.Name = "FooterPanel"
        Me.FooterPanel.Size = New System.Drawing.Size(1195, 40)
        Me.FooterPanel.TabIndex = 1
        Me.FooterPanel.Text = "パネル2"
        Me.FooterPanel.Width = 1195
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
        Me.Cancel.Location = New System.Drawing.Point(1057, 6)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(0)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(100, 30)
        Me.Cancel.TabIndex = 62
        Me.Cancel.Text = "キャンセル"
        Me.Cancel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'Entry
        '
        Me.Entry.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Entry.FlatAppearance.BorderSize = 0
        Me.Entry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Entry.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Entry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Entry.ImageIndex = 3
        Me.Entry.ImageList = Me.ButtonImageList
        Me.Entry.Location = New System.Drawing.Point(957, 6)
        Me.Entry.Margin = New System.Windows.Forms.Padding(0)
        Me.Entry.Name = "Entry"
        Me.Entry.Size = New System.Drawing.Size(100, 30)
        Me.Entry.TabIndex = 61
        Me.Entry.Text = "　登 録"
        Me.Entry.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Entry.UseVisualStyleBackColor = True
        '
        '費用マスタ一覧
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1195, 661)
        Me.Controls.Add(Me.FormContainer)
        Me.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "費用マスタ一覧"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "費用マスタ一覧"
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FormContainer.ResumeLayout(False)
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanel.PerformLayout()
        CType(Me.NameLabel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterContentsList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.右クリックメニュー.ResumeLayout(False)
        Me.FooterPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents ButtonImageList As ImageList
    Friend WithEvents SystemTheme As C1.Win.C1Themes.C1ThemeController
    Friend WithEvents FormContainer As C1.Win.C1SplitContainer.C1SplitContainer
    Friend WithEvents MainPanel As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents FooterPanel As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents TableName As Label
    Friend WithEvents HeadLine As Label
    Friend WithEvents MasterContentsList As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Cancel As Button
    Friend WithEvents Entry As Button
    Friend WithEvents NameLabel As C1.Win.C1Input.C1TextBox
    Friend WithEvents SearchName As C1.Win.C1FlexGrid.C1FlexGridSearchPanel
    Friend WithEvents 右クリックメニュー As ContextMenuStrip
    Friend WithEvents InsertMenu As ToolStripMenuItem
    Friend WithEvents CutMenu As ToolStripMenuItem
    Friend WithEvents CopyMenu As ToolStripMenuItem
    Friend WithEvents PastingMenu As ToolStripMenuItem
End Class
