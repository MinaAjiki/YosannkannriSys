<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 業者選択_出来高
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(業者選択_出来高))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MasterContentsList = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.SystemTheme = New C1.Win.C1Themes.C1ThemeController()
        CType(Me.MasterContentsList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(14, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "<< 業者選択"
        '
        'MasterContentsList
        '
        Me.MasterContentsList.AllowAddNew = True
        Me.MasterContentsList.AllowDelete = True
        Me.MasterContentsList.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.MasterContentsList.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.MasterContentsList.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
        Me.MasterContentsList.ColumnInfo = "3,1,0,0,0,-1,Columns:0{Visible:False;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:100;Caption:""取引先コード"";Style:""TextAl" &
    "ign:LeftCenter;"";}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:270;Caption:""業者名"";Style:""TextAlign:LeftCenter;"";}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.MasterContentsList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.MasterContentsList.Location = New System.Drawing.Point(18, 66)
        Me.MasterContentsList.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.MasterContentsList.Name = "MasterContentsList"
        Me.MasterContentsList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.MasterContentsList.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.AlwaysVisible
        Me.MasterContentsList.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.MasterContentsList.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.MasterContentsList.Size = New System.Drawing.Size(390, 509)
        Me.MasterContentsList.StyleInfo = resources.GetString("MasterContentsList.StyleInfo")
        Me.MasterContentsList.TabIndex = 58
        Me.SystemTheme.SetTheme(Me.MasterContentsList, "予算管理テーマ")
        '
        'SystemTheme
        '
        Me.SystemTheme.Theme = "予算管理テーマ"
        '
        '業者選択_出来高
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(990, 662)
        Me.Controls.Add(Me.MasterContentsList)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "業者選択_出来高"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "業者選択(出来高)"
        CType(Me.MasterContentsList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents MasterContentsList As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents SystemTheme As C1.Win.C1Themes.C1ThemeController
End Class
