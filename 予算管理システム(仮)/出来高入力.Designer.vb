<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 出来高入力
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(出来高入力))
        Me.ButtonImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.C1FlexGrid2 = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me.C1FlexGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Button4.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Button4.ImageIndex = 3
        Me.Button4.ImageList = Me.ButtonImageList
        Me.Button4.Location = New System.Drawing.Point(29, 67)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(102, 31)
        Me.Button4.TabIndex = 48
        Me.Button4.Text = "　登　録"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(13, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 18)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "<< 出来高入力"
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
        Me.C1FlexGrid2.ColumnInfo = "7,1,0,0,0,-1,Columns:"
        Me.C1FlexGrid2.Location = New System.Drawing.Point(29, 104)
        Me.C1FlexGrid2.Name = "C1FlexGrid2"
        Me.C1FlexGrid2.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange
        Me.C1FlexGrid2.Size = New System.Drawing.Size(608, 177)
        Me.C1FlexGrid2.StyleInfo = resources.GetString("C1FlexGrid2.StyleInfo")
        Me.C1FlexGrid2.TabIndex = 50
        '
        '出来高入力
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.C1FlexGrid2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "出来高入力"
        Me.Text = "出来高入力"
        CType(Me.C1FlexGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonImageList As ImageList
    Friend WithEvents Button4 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents C1FlexGrid2 As C1.Win.C1FlexGrid.C1FlexGrid
End Class
