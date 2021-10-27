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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.C1TextBox5 = New C1.Win.C1Input.C1TextBox()
        Me.C1TextBox7 = New C1.Win.C1Input.C1TextBox()
        Me.ButtonImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.VendorList = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.SystemTheme = New C1.Win.C1Themes.C1ThemeController()
        CType(Me.C1TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(15, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "<< 業者一覧"
        '
        'C1TextBox5
        '
        Me.C1TextBox5.AutoSize = False
        Me.C1TextBox5.BackColor = System.Drawing.Color.White
        Me.C1TextBox5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.C1TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1TextBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.C1TextBox5.Location = New System.Drawing.Point(92, 75)
        Me.C1TextBox5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.C1TextBox5.Name = "C1TextBox5"
        Me.C1TextBox5.Size = New System.Drawing.Size(248, 30)
        Me.C1TextBox5.TabIndex = 49
        Me.C1TextBox5.Tag = Nothing
        Me.C1TextBox5.Value = ""
        '
        'C1TextBox7
        '
        Me.C1TextBox7.AutoSize = False
        Me.C1TextBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.C1TextBox7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.C1TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1TextBox7.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.C1TextBox7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.C1TextBox7.Location = New System.Drawing.Point(35, 75)
        Me.C1TextBox7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.C1TextBox7.Name = "C1TextBox7"
        Me.C1TextBox7.Size = New System.Drawing.Size(59, 30)
        Me.C1TextBox7.TabIndex = 48
        Me.C1TextBox7.Tag = Nothing
        Me.C1TextBox7.Value = "業者名："
        Me.C1TextBox7.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
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
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Button1.ImageIndex = 0
        Me.Button1.ImageList = Me.ButtonImageList
        Me.Button1.Location = New System.Drawing.Point(346, 75)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 30)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "検　索"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'VendorList
        '
        Me.VendorList.AllowAddNew = True
        Me.VendorList.AllowDelete = True
        Me.VendorList.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.VendorList.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.VendorList.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.VendorList.ColumnInfo = "5,1,0,0,0,-1,Columns:0{Width:1;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:100;Caption:""取引先コード"";}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:270;Capti" &
    "on:""業者名"";}" & Global.Microsoft.VisualBasic.ChrW(9) & "3{Width:300;Caption:""住所"";}" & Global.Microsoft.VisualBasic.ChrW(9) & "4{Width:100;Caption:""電話番号"";}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.VendorList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.VendorList.Location = New System.Drawing.Point(18, 115)
        Me.VendorList.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.VendorList.Name = "VendorList"
        Me.VendorList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.VendorList.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.VendorList.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.VendorList.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.VendorList.Size = New System.Drawing.Size(792, 501)
        Me.VendorList.StyleInfo = resources.GetString("VendorList.StyleInfo")
        Me.VendorList.TabIndex = 51
        Me.SystemTheme.SetTheme(Me.VendorList, "予算管理テーマ")
        '
        '業者一覧
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(830, 662)
        Me.Controls.Add(Me.VendorList)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.C1TextBox5)
        Me.Controls.Add(Me.C1TextBox7)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "業者一覧"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "業者一覧"
        CType(Me.C1TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents C1TextBox5 As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1TextBox7 As C1.Win.C1Input.C1TextBox
    Friend WithEvents ButtonImageList As ImageList
    Friend WithEvents Button1 As Button
    Friend WithEvents VendorList As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents SystemTheme As C1.Win.C1Themes.C1ThemeController
End Class
