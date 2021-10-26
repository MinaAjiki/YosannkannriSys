<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 業者選択_Export_
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(業者選択_Export_))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.C1FlexGrid2 = New C1.Win.C1FlexGrid.C1FlexGrid()
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
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "<< 業者選択"
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
        Me.C1FlexGrid2.ColumnInfo = "4,1,0,0,0,-1,Columns:"
        Me.C1FlexGrid2.Location = New System.Drawing.Point(32, 58)
        Me.C1FlexGrid2.Name = "C1FlexGrid2"
        Me.C1FlexGrid2.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange
        Me.C1FlexGrid2.Size = New System.Drawing.Size(425, 177)
        Me.C1FlexGrid2.StyleInfo = resources.GetString("C1FlexGrid2.StyleInfo")
        Me.C1FlexGrid2.TabIndex = 53
        '
        '業者選択_Export_
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.C1FlexGrid2)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "業者選択_Export_"
        Me.Text = "業者選択_Export_"
        CType(Me.C1FlexGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents C1FlexGrid2 As C1.Win.C1FlexGrid.C1FlexGrid
End Class
