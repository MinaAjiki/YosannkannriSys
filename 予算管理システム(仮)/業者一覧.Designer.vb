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
        Me.C1FlexGrid1 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.C1TextBox5 = New C1.Win.C1Input.C1TextBox()
        Me.C1TextBox7 = New C1.Win.C1Input.C1TextBox()
        Me.ButtonImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.C1FlexGrid2 = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1FlexGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(13, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "<< 業者一覧"
        '
        'C1FlexGrid1
        '
        Me.C1FlexGrid1.AllowAddNew = True
        Me.C1FlexGrid1.AllowDelete = True
        Me.C1FlexGrid1.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.Both
        Me.C1FlexGrid1.AllowFiltering = True
        Me.C1FlexGrid1.ColumnContextMenuEnabled = True
        Me.C1FlexGrid1.ColumnInfo = "6,1,0,0,0,-1,Columns:1{Caption:""業者ｺｰﾄﾞ"";}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Caption:""業者名"";}" & Global.Microsoft.VisualBasic.ChrW(9) & "3{Caption:""住所"";Style:" &
    """TextAlign:GeneralCenter;"";}" & Global.Microsoft.VisualBasic.ChrW(9) & "4{Caption:""電話番号"";Style:""TextAlign:GeneralCenter;"";}" &
    "" & Global.Microsoft.VisualBasic.ChrW(9) & "5{Caption:""取引品目"";}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.C1FlexGrid1.Location = New System.Drawing.Point(16, 445)
        Me.C1FlexGrid1.Name = "C1FlexGrid1"
        Me.C1FlexGrid1.Size = New System.Drawing.Size(502, 150)
        Me.C1FlexGrid1.TabIndex = 26
        '
        'C1TextBox5
        '
        Me.C1TextBox5.AutoSize = False
        Me.C1TextBox5.BackColor = System.Drawing.Color.White
        Me.C1TextBox5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.C1TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1TextBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.C1TextBox5.Location = New System.Drawing.Point(132, 49)
        Me.C1TextBox5.Name = "C1TextBox5"
        Me.C1TextBox5.Size = New System.Drawing.Size(213, 20)
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
        Me.C1TextBox7.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.C1TextBox7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.C1TextBox7.Location = New System.Drawing.Point(31, 49)
        Me.C1TextBox7.Name = "C1TextBox7"
        Me.C1TextBox7.Size = New System.Drawing.Size(100, 20)
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
        Me.Button1.Location = New System.Drawing.Point(351, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 31)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "検　索"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'C1FlexGrid2
        '
        Me.C1FlexGrid2.AllowAddNew = True
        Me.C1FlexGrid2.AllowDelete = True
        Me.C1FlexGrid2.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.Rows
        Me.C1FlexGrid2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1FlexGrid2.AutoClipboard = True
        Me.C1FlexGrid2.BackColor = System.Drawing.Color.White
        Me.C1FlexGrid2.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.C1FlexGrid2.ColumnInfo = "6,1,0,0,0,-1,Columns:"
        Me.C1FlexGrid2.Location = New System.Drawing.Point(31, 87)
        Me.C1FlexGrid2.Name = "C1FlexGrid2"
        Me.C1FlexGrid2.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange
        Me.C1FlexGrid2.Size = New System.Drawing.Size(544, 177)
        Me.C1FlexGrid2.StyleInfo = resources.GetString("C1FlexGrid2.StyleInfo")
        Me.C1FlexGrid2.TabIndex = 51
        '
        '業者一覧
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 620)
        Me.Controls.Add(Me.C1FlexGrid2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.C1TextBox5)
        Me.Controls.Add(Me.C1TextBox7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.C1FlexGrid1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "業者一覧"
        Me.Text = "業者一覧"
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1FlexGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents C1FlexGrid1 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents C1TextBox5 As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1TextBox7 As C1.Win.C1Input.C1TextBox
    Friend WithEvents ButtonImageList As ImageList
    Friend WithEvents Button1 As Button
    Friend WithEvents C1FlexGrid2 As C1.Win.C1FlexGrid.C1FlexGrid
End Class
