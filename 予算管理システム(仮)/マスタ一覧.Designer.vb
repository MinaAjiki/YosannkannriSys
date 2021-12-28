<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class マスタ一覧
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(マスタ一覧))
        Me.HeadLine = New System.Windows.Forms.Label()
        Me.TableName = New System.Windows.Forms.Label()
        Me.ButtonImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.SystemTheme = New C1.Win.C1Themes.C1ThemeController()
        Me.FormSplitContainer1 = New C1.Win.C1SplitContainer.C1SplitContainer()
        Me.MainPanel = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.YearLabel = New System.Windows.Forms.Label()
        Me.SelectYear = New C1.Win.C1Input.C1ComboBox()
        Me.MasterContentsList = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.FooterPanel = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Entry = New System.Windows.Forms.Button()
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FormSplitContainer1.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        CType(Me.SelectYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterContentsList, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.HeadLine.Size = New System.Drawing.Size(88, 18)
        Me.HeadLine.TabIndex = 54
        Me.HeadLine.Text = "<<マスタ一覧"
        '
        'TableName
        '
        Me.TableName.AutoSize = True
        Me.TableName.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TableName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.TableName.Location = New System.Drawing.Point(37, 49)
        Me.TableName.Name = "TableName"
        Me.TableName.Size = New System.Drawing.Size(68, 18)
        Me.TableName.TabIndex = 57
        Me.TableName.Text = "給与マスタ"
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
        'FormSplitContainer1
        '
        Me.FormSplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FormSplitContainer1.AutoSizeElement = C1.Framework.AutoSizeElement.Both
        Me.FormSplitContainer1.BackColor = System.Drawing.Color.White
        Me.FormSplitContainer1.CollapsingAreaColor = System.Drawing.Color.GhostWhite
        Me.FormSplitContainer1.CollapsingCueColor = System.Drawing.Color.White
        Me.FormSplitContainer1.FixedLineColor = System.Drawing.Color.White
        Me.FormSplitContainer1.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.FormSplitContainer1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.FormSplitContainer1.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.FormSplitContainer1.HeaderHeight = 0
        Me.FormSplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.FormSplitContainer1.Name = "FormSplitContainer1"
        Me.FormSplitContainer1.Panels.Add(Me.MainPanel)
        Me.FormSplitContainer1.Panels.Add(Me.FooterPanel)
        Me.FormSplitContainer1.Size = New System.Drawing.Size(588, 478)
        Me.FormSplitContainer1.SplitterColor = System.Drawing.Color.White
        Me.FormSplitContainer1.SplitterMovingColor = System.Drawing.Color.Black
        Me.FormSplitContainer1.SplitterWidth = 0
        Me.FormSplitContainer1.TabIndex = 60
        Me.SystemTheme.SetTheme(Me.FormSplitContainer1, "予算管理テーマ")
        Me.FormSplitContainer1.UseParentVisualStyle = False
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.White
        Me.MainPanel.Controls.Add(Me.YearLabel)
        Me.MainPanel.Controls.Add(Me.SelectYear)
        Me.MainPanel.Controls.Add(Me.MasterContentsList)
        Me.MainPanel.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.MainPanel.Height = 438
        Me.MainPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(588, 438)
        Me.MainPanel.SizeRatio = 91.632R
        Me.MainPanel.TabIndex = 0
        Me.MainPanel.Text = "パネル1"
        '
        'YearLabel
        '
        Me.YearLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.YearLabel.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.YearLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.YearLabel.Location = New System.Drawing.Point(397, 48)
        Me.YearLabel.Name = "YearLabel"
        Me.YearLabel.Size = New System.Drawing.Size(43, 23)
        Me.YearLabel.TabIndex = 65
        Me.YearLabel.Text = "年度"
        Me.YearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SelectYear
        '
        Me.SelectYear.AllowSpinLoop = False
        Me.SelectYear.BackColor = System.Drawing.Color.White
        Me.SelectYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SelectYear.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.SelectYear.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.SelectYear.GapHeight = 0
        Me.SelectYear.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.SelectYear.Location = New System.Drawing.Point(439, 48)
        Me.SelectYear.Name = "SelectYear"
        Me.SelectYear.Size = New System.Drawing.Size(111, 23)
        Me.SelectYear.Style.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.SelectYear.TabIndex = 58
        Me.SelectYear.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.SelectYear, "(default)")
        Me.SelectYear.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'MasterContentsList
        '
        Me.MasterContentsList.AllowAddNew = True
        Me.MasterContentsList.AllowDelete = True
        Me.MasterContentsList.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.MasterContentsList.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.MasterContentsList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MasterContentsList.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.MasterContentsList.ColumnInfo = resources.GetString("MasterContentsList.ColumnInfo")
        Me.MasterContentsList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.MasterContentsList.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.MasterContentsList.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross
        Me.MasterContentsList.Location = New System.Drawing.Point(40, 71)
        Me.MasterContentsList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MasterContentsList.Name = "MasterContentsList"
        Me.MasterContentsList.Rows.Count = 15
        Me.MasterContentsList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.MasterContentsList.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.MasterContentsList.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.MasterContentsList.ShowCellLabels = True
        Me.MasterContentsList.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.MasterContentsList.Size = New System.Drawing.Size(511, 339)
        Me.MasterContentsList.StyleInfo = resources.GetString("MasterContentsList.StyleInfo")
        Me.MasterContentsList.TabIndex = 57
        Me.SystemTheme.SetTheme(Me.MasterContentsList, "予算管理テーマ")
        '
        'FooterPanel
        '
        Me.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.FooterPanel.Controls.Add(Me.Cancel)
        Me.FooterPanel.Controls.Add(Me.Entry)
        Me.FooterPanel.Height = 40
        Me.FooterPanel.Location = New System.Drawing.Point(0, 438)
        Me.FooterPanel.Name = "FooterPanel"
        Me.FooterPanel.Size = New System.Drawing.Size(588, 40)
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
        Me.Cancel.Location = New System.Drawing.Point(477, 3)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(0)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(100, 30)
        Me.Cancel.TabIndex = 60
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
        Me.Entry.Location = New System.Drawing.Point(372, 3)
        Me.Entry.Margin = New System.Windows.Forms.Padding(0)
        Me.Entry.Name = "Entry"
        Me.Entry.Size = New System.Drawing.Size(100, 30)
        Me.Entry.TabIndex = 59
        Me.Entry.Text = "　登 録"
        Me.Entry.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Entry.UseVisualStyleBackColor = True
        '
        'マスタ一覧
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(588, 474)
        Me.Controls.Add(Me.TableName)
        Me.Controls.Add(Me.HeadLine)
        Me.Controls.Add(Me.FormSplitContainer1)
        Me.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "マスタ一覧"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "マスタ一覧"
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FormSplitContainer1.ResumeLayout(False)
        Me.MainPanel.ResumeLayout(False)
        CType(Me.SelectYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterContentsList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FooterPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HeadLine As Label
    Friend WithEvents TableName As Label
    Friend WithEvents SystemTheme As C1.Win.C1Themes.C1ThemeController
    Private WithEvents ButtonImageList As ImageList
    Friend WithEvents Entry As Button
    Friend WithEvents FormSplitContainer1 As C1.Win.C1SplitContainer.C1SplitContainer
    Friend WithEvents MainPanel As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents FooterPanel As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents Cancel As Button
    Friend WithEvents MasterContentsList As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents SelectYear As C1.Win.C1Input.C1ComboBox
    Friend WithEvents YearLabel As Label
End Class
