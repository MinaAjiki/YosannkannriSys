<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DB選択
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DB選択))
        Me.HeadLine = New System.Windows.Forms.Label()
        Me.SystemTheme = New C1.Win.C1Themes.C1ThemeController()
        Me.C1TextBox1 = New C1.Win.C1Input.C1TextBox()
        Me.TableName = New System.Windows.Forms.Label()
        Me.MainSplitContainer = New C1.Win.C1SplitContainer.C1SplitContainer()
        Me.MainPanel = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.FileList = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.FooterPanel = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.Open = New System.Windows.Forms.Button()
        Me.ButtonImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.OtherFile = New System.Windows.Forms.Button()
        Me.OtherFileOpenDialog = New System.Windows.Forms.OpenFileDialog()
        Me.C1XLBook1 = New C1.C1Excel.C1XLBook()
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainSplitContainer.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        CType(Me.FileList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FooterPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'HeadLine
        '
        Me.HeadLine.AutoSize = True
        Me.HeadLine.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.HeadLine.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.HeadLine.Location = New System.Drawing.Point(18, 18)
        Me.HeadLine.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.HeadLine.Name = "HeadLine"
        Me.HeadLine.Size = New System.Drawing.Size(64, 23)
        Me.HeadLine.TabIndex = 28
        Me.HeadLine.Text = "<<開く"
        '
        'C1TextBox1
        '
        Me.C1TextBox1.BackColor = System.Drawing.Color.White
        Me.C1TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1TextBox1.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.C1TextBox1.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1TextBox1.Location = New System.Drawing.Point(74, 59)
        Me.C1TextBox1.Name = "C1TextBox1"
        Me.C1TextBox1.Size = New System.Drawing.Size(420, 28)
        Me.C1TextBox1.TabIndex = 44
        Me.C1TextBox1.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.C1TextBox1, "(default)")
        Me.C1TextBox1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'TableName
        '
        Me.TableName.AutoSize = True
        Me.TableName.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TableName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.TableName.Location = New System.Drawing.Point(40, 55)
        Me.TableName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TableName.Name = "TableName"
        Me.TableName.Size = New System.Drawing.Size(160, 23)
        Me.TableName.TabIndex = 48
        Me.TableName.Text = "最近使用したファイル"
        Me.SystemTheme.SetTheme(Me.TableName, "(default)")
        '
        'MainSplitContainer
        '
        Me.MainSplitContainer.AutoSizeElement = C1.Framework.AutoSizeElement.Both
        Me.MainSplitContainer.BackColor = System.Drawing.Color.White
        Me.MainSplitContainer.CollapsingAreaColor = System.Drawing.Color.GhostWhite
        Me.MainSplitContainer.CollapsingCueColor = System.Drawing.Color.White
        Me.MainSplitContainer.FixedLineColor = System.Drawing.Color.White
        Me.MainSplitContainer.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.MainSplitContainer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.MainSplitContainer.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.MainSplitContainer.HeaderHeight = 0
        Me.MainSplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.MainSplitContainer.Margin = New System.Windows.Forms.Padding(4)
        Me.MainSplitContainer.Name = "MainSplitContainer"
        Me.MainSplitContainer.Panels.Add(Me.MainPanel)
        Me.MainSplitContainer.Panels.Add(Me.FooterPanel)
        Me.MainSplitContainer.Size = New System.Drawing.Size(821, 351)
        Me.MainSplitContainer.SplitterColor = System.Drawing.Color.White
        Me.MainSplitContainer.SplitterMovingColor = System.Drawing.Color.Black
        Me.MainSplitContainer.SplitterWidth = 0
        Me.MainSplitContainer.TabIndex = 52
        Me.SystemTheme.SetTheme(Me.MainSplitContainer, "予算管理テーマ")
        Me.MainSplitContainer.UseParentVisualStyle = False
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.FileList)
        Me.MainPanel.Height = 301
        Me.MainPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainPanel.MinHeight = 50
        Me.MainPanel.MinWidth = 50
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(821, 301)
        Me.MainPanel.SizeRatio = 100.0R
        Me.MainPanel.TabIndex = 0
        Me.MainPanel.Text = "パネル1"
        Me.MainPanel.Width = 821
        '
        'FileList
        '
        Me.FileList.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.FileList.AllowEditing = False
        Me.FileList.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.FileList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FileList.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.FileList.ColumnInfo = resources.GetString("FileList.ColumnInfo")
        Me.FileList.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.FileList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.FileList.Location = New System.Drawing.Point(44, 82)
        Me.FileList.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FileList.Name = "FileList"
        Me.FileList.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.FileList.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.FileList.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.FileList.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.FileList.Size = New System.Drawing.Size(753, 178)
        Me.FileList.StyleInfo = resources.GetString("FileList.StyleInfo")
        Me.FileList.TabIndex = 58
        Me.SystemTheme.SetTheme(Me.FileList, "予算管理テーマ")
        '
        'FooterPanel
        '
        Me.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.FooterPanel.Controls.Add(Me.Open)
        Me.FooterPanel.Controls.Add(Me.OtherFile)
        Me.FooterPanel.Height = 50
        Me.FooterPanel.Location = New System.Drawing.Point(0, 301)
        Me.FooterPanel.MinHeight = 50
        Me.FooterPanel.MinWidth = 50
        Me.FooterPanel.Name = "FooterPanel"
        Me.FooterPanel.Size = New System.Drawing.Size(821, 50)
        Me.FooterPanel.TabIndex = 1
        Me.FooterPanel.Text = "パネル2"
        Me.FooterPanel.Width = 821
        '
        'Open
        '
        Me.Open.FlatAppearance.BorderSize = 0
        Me.Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Open.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Open.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Open.ImageIndex = 0
        Me.Open.ImageList = Me.ButtonImageList
        Me.Open.Location = New System.Drawing.Point(690, 6)
        Me.Open.Margin = New System.Windows.Forms.Padding(0)
        Me.Open.Name = "Open"
        Me.Open.Size = New System.Drawing.Size(125, 38)
        Me.Open.TabIndex = 58
        Me.Open.Text = "開く"
        Me.Open.UseVisualStyleBackColor = True
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
        'OtherFile
        '
        Me.OtherFile.FlatAppearance.BorderSize = 0
        Me.OtherFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OtherFile.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.OtherFile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.OtherFile.ImageIndex = 0
        Me.OtherFile.ImageList = Me.ButtonImageList
        Me.OtherFile.Location = New System.Drawing.Point(560, 6)
        Me.OtherFile.Margin = New System.Windows.Forms.Padding(0)
        Me.OtherFile.Name = "OtherFile"
        Me.OtherFile.Size = New System.Drawing.Size(125, 38)
        Me.OtherFile.TabIndex = 57
        Me.OtherFile.Text = "他ファイル参照"
        Me.OtherFile.UseVisualStyleBackColor = True
        '
        'OtherFileOpenDialog
        '
        Me.OtherFileOpenDialog.Filter = "MDFファイル|*.mdf|すべて|*.*"
        Me.OtherFileOpenDialog.InitialDirectory = "D:\"
        '
        'DB選択
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(821, 350)
        Me.Controls.Add(Me.TableName)
        Me.Controls.Add(Me.HeadLine)
        Me.Controls.Add(Me.MainSplitContainer)
        Me.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "DB選択"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DB選択"
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainSplitContainer.ResumeLayout(False)
        Me.MainPanel.ResumeLayout(False)
        CType(Me.FileList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FooterPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HeadLine As Label
    Friend WithEvents SystemTheme As C1.Win.C1Themes.C1ThemeController
    Friend WithEvents C1TextBox1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents TableName As Label
    Private WithEvents ButtonImageList As ImageList
    Friend WithEvents MainSplitContainer As C1.Win.C1SplitContainer.C1SplitContainer
    Friend WithEvents MainPanel As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents FooterPanel As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents Open As Button
    Friend WithEvents OtherFile As Button
    Friend WithEvents OtherFileOpenDialog As OpenFileDialog
    Friend WithEvents FileList As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1XLBook1 As C1.C1Excel.C1XLBook
End Class
