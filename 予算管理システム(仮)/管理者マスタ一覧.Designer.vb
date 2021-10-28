<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 管理者マスタ一覧
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(管理者マスタ一覧))
        Me.HeadLine = New System.Windows.Forms.Label()
        Me.SystemTheme = New C1.Win.C1Themes.C1ThemeController()
        Me.TableName = New System.Windows.Forms.Label()
        Me.AdminList = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ButtonImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.FormSplitContainer = New C1.Win.C1SplitContainer.C1SplitContainer()
        Me.MainPanel = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.FooterPanel = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Entry = New System.Windows.Forms.Button()
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FormSplitContainer.SuspendLayout()
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
        Me.HeadLine.TabIndex = 30
        Me.HeadLine.Text = "<<管理者登録"
        '
        'TableName
        '
        Me.TableName.AutoSize = True
        Me.TableName.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TableName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.TableName.Location = New System.Drawing.Point(37, 53)
        Me.TableName.Name = "TableName"
        Me.TableName.Size = New System.Drawing.Size(68, 18)
        Me.TableName.TabIndex = 52
        Me.TableName.Text = "管理者一覧"
        Me.SystemTheme.SetTheme(Me.TableName, "(default)")
        '
        'AdminList
        '
        Me.AdminList.AllowAddNew = True
        Me.AdminList.AllowDelete = True
        Me.AdminList.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.AdminList.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.AdminList.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.AdminList.ColumnInfo = resources.GetString("AdminList.ColumnInfo")
        Me.AdminList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.AdminList.Location = New System.Drawing.Point(40, 75)
        Me.AdminList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AdminList.Name = "AdminList"
        Me.AdminList.Rows.Count = 12
        Me.AdminList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.AdminList.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.AdminList.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.AdminList.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.AdminList.Size = New System.Drawing.Size(301, 289)
        Me.AdminList.StyleInfo = resources.GetString("AdminList.StyleInfo")
        Me.AdminList.TabIndex = 55
        Me.SystemTheme.SetTheme(Me.AdminList, "予算管理テーマ")
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
        'FormSplitContainer
        '
        Me.FormSplitContainer.AutoSizeElement = C1.Framework.AutoSizeElement.Both
        Me.FormSplitContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.FormSplitContainer.CollapsingAreaColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.FormSplitContainer.FixedLineColor = System.Drawing.Color.White
        Me.FormSplitContainer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.FormSplitContainer.HeaderHeight = 0
        Me.FormSplitContainer.LineBelowHeader = False
        Me.FormSplitContainer.Location = New System.Drawing.Point(0, 1)
        Me.FormSplitContainer.Name = "FormSplitContainer"
        Me.FormSplitContainer.Panels.Add(Me.MainPanel)
        Me.FormSplitContainer.Panels.Add(Me.FooterPanel)
        Me.FormSplitContainer.Size = New System.Drawing.Size(387, 445)
        Me.FormSplitContainer.SplitterColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.FormSplitContainer.SplitterWidth = 0
        Me.FormSplitContainer.TabIndex = 56
        Me.FormSplitContainer.ToolTipGradient = C1.Win.C1SplitContainer.ToolTipGradient.Blue
        Me.FormSplitContainer.UseParentVisualStyle = False
        '
        'MainPanel
        '
        Me.MainPanel.AutoScroll = True
        Me.MainPanel.BackColor = System.Drawing.Color.White
        Me.MainPanel.BorderWidth = 1
        Me.MainPanel.Height = 405
        Me.MainPanel.Location = New System.Drawing.Point(1, 1)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.ResizeWhileDragging = True
        Me.MainPanel.Size = New System.Drawing.Size(385, 403)
        Me.MainPanel.SizeRatio = 91.011R
        Me.MainPanel.TabIndex = 0
        Me.MainPanel.Text = "パネル1"
        '
        'FooterPanel
        '
        Me.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.FooterPanel.Controls.Add(Me.Button1)
        Me.FooterPanel.Controls.Add(Me.Entry)
        Me.FooterPanel.Height = 40
        Me.FooterPanel.Location = New System.Drawing.Point(0, 405)
        Me.FooterPanel.MinHeight = 30
        Me.FooterPanel.Name = "FooterPanel"
        Me.FooterPanel.Size = New System.Drawing.Size(387, 40)
        Me.FooterPanel.TabIndex = 1
        Me.FooterPanel.Text = "パネル2"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button1.ImageIndex = 6
        Me.Button1.ImageList = Me.ButtonImageList
        Me.Button1.Location = New System.Drawing.Point(280, 4)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 30)
        Me.Button1.TabIndex = 56
        Me.Button1.Text = "キャンセル"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Entry
        '
        Me.Entry.FlatAppearance.BorderSize = 0
        Me.Entry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Entry.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Entry.ImageIndex = 3
        Me.Entry.ImageList = Me.ButtonImageList
        Me.Entry.Location = New System.Drawing.Point(176, 4)
        Me.Entry.Margin = New System.Windows.Forms.Padding(0)
        Me.Entry.Name = "Entry"
        Me.Entry.Size = New System.Drawing.Size(100, 30)
        Me.Entry.TabIndex = 55
        Me.Entry.Text = "　登 録"
        Me.Entry.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Entry.UseVisualStyleBackColor = True
        '
        '管理者マスタ一覧
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(387, 444)
        Me.Controls.Add(Me.AdminList)
        Me.Controls.Add(Me.TableName)
        Me.Controls.Add(Me.HeadLine)
        Me.Controls.Add(Me.FormSplitContainer)
        Me.MaximizeBox = False
        Me.Name = "管理者マスタ一覧"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "管理者登録"
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FormSplitContainer.ResumeLayout(False)
        Me.FooterPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HeadLine As Label
    Friend WithEvents SystemTheme As C1.Win.C1Themes.C1ThemeController
    Private WithEvents ButtonImageList As ImageList
    Friend WithEvents TableName As Label
    Friend WithEvents AdminList As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents FormSplitContainer As C1.Win.C1SplitContainer.C1SplitContainer
    Friend WithEvents MainPanel As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents FooterPanel As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents Entry As Button
End Class
