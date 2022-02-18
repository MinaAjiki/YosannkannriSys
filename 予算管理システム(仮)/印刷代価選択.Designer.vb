<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 印刷代価選択
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
        Me.HeadLine = New System.Windows.Forms.Label()
        Me.SystemTheme = New C1.Win.C1Themes.C1ThemeController()
        Me.CostsList = New System.Windows.Forms.ListBox()
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
        Me.HeadLine.Size = New System.Drawing.Size(104, 18)
        Me.HeadLine.TabIndex = 27
        Me.HeadLine.Text = "<< 印刷代価選択"
        '
        'SystemTheme
        '
        Me.SystemTheme.Theme = "予算管理テーマ"
        '
        'CostsList
        '
        Me.CostsList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.CostsList.FormattingEnabled = True
        Me.CostsList.ItemHeight = 18
        Me.CostsList.Location = New System.Drawing.Point(42, 53)
        Me.CostsList.Margin = New System.Windows.Forms.Padding(0)
        Me.CostsList.Name = "CostsList"
        Me.CostsList.ScrollAlwaysVisible = True
        Me.CostsList.Size = New System.Drawing.Size(100, 94)
        Me.CostsList.TabIndex = 35
        Me.SystemTheme.SetTheme(Me.CostsList, "(default)")
        '
        '印刷代価選択
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(184, 190)
        Me.Controls.Add(Me.CostsList)
        Me.Controls.Add(Me.HeadLine)
        Me.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "印刷代価選択"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HeadLine As Label
    Friend WithEvents SystemTheme As C1.Win.C1Themes.C1ThemeController
    Friend WithEvents CostsList As ListBox
End Class
