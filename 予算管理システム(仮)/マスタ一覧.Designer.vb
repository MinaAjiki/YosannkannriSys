<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class マスタ一覧
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(マスタ一覧))
        Me.HeadLine = New System.Windows.Forms.Label()
        Me.MasterContentsList = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.TableName = New System.Windows.Forms.Label()
        Me.ButtonImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.SystemTheme = New C1.Win.C1Themes.C1ThemeController()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.MasterContentsList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'MasterContentsList
        '
        Me.MasterContentsList.AllowAddNew = True
        Me.MasterContentsList.AllowDelete = True
        Me.MasterContentsList.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.MasterContentsList.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.MasterContentsList.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.MasterContentsList.ColumnInfo = resources.GetString("MasterContentsList.ColumnInfo")
        Me.MasterContentsList.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.MasterContentsList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.MasterContentsList.Location = New System.Drawing.Point(39, 71)
        Me.MasterContentsList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MasterContentsList.Name = "MasterContentsList"
        Me.MasterContentsList.Rows.Count = 12
        Me.MasterContentsList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.MasterContentsList.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.MasterContentsList.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.MasterContentsList.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.MasterContentsList.Size = New System.Drawing.Size(472, 289)
        Me.MasterContentsList.StyleInfo = resources.GetString("MasterContentsList.StyleInfo")
        Me.MasterContentsList.TabIndex = 56
        Me.SystemTheme.SetTheme(Me.MasterContentsList, "予算管理テーマ")
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
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Button1.ImageIndex = 3
        Me.Button1.ImageList = Me.ButtonImageList
        Me.Button1.Location = New System.Drawing.Point(239, 37)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 30)
        Me.Button1.TabIndex = 59
        Me.Button1.Text = "　登 録"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'マスタ一覧
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(933, 675)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TableName)
        Me.Controls.Add(Me.MasterContentsList)
        Me.Controls.Add(Me.HeadLine)
        Me.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "マスタ一覧"
        Me.Text = "マスタ一覧"
        CType(Me.MasterContentsList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HeadLine As Label
    Friend WithEvents MasterContentsList As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents TableName As Label
    Friend WithEvents SystemTheme As C1.Win.C1Themes.C1ThemeController
    Private WithEvents ButtonImageList As ImageList
    Friend WithEvents Button1 As Button
End Class
