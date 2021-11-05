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
        Me.SelectPriceList = New C1.Win.C1Input.C1ComboBox()
        Me.SystemTheme = New C1.Win.C1Themes.C1ThemeController()
        CType(Me.SelectPriceList, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'SelectPriceList
        '
        Me.SelectPriceList.AllowSpinLoop = False
        Me.SelectPriceList.AutoSize = False
        Me.SelectPriceList.BackColor = System.Drawing.Color.White
        Me.SelectPriceList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SelectPriceList.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.SelectPriceList.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.SelectPriceList.GapHeight = 0
        Me.SelectPriceList.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.SelectPriceList.Items.Add("工事代価表A")
        Me.SelectPriceList.Items.Add("工事代価表B")
        Me.SelectPriceList.Items.Add("工事代価表C")
        Me.SelectPriceList.Location = New System.Drawing.Point(17, 82)
        Me.SelectPriceList.Name = "SelectPriceList"
        Me.SelectPriceList.Size = New System.Drawing.Size(192, 23)
        Me.SelectPriceList.Style.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.SelectPriceList.TabIndex = 28
        Me.SelectPriceList.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.SelectPriceList, "予算管理テーマ")
        Me.SelectPriceList.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'SystemTheme
        '
        Me.SystemTheme.Theme = "予算管理テーマ"
        '
        '印刷代価選択
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(221, 206)
        Me.Controls.Add(Me.SelectPriceList)
        Me.Controls.Add(Me.HeadLine)
        Me.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "印刷代価選択"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.SelectPriceList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HeadLine As Label
    Friend WithEvents SelectPriceList As C1.Win.C1Input.C1ComboBox
    Friend WithEvents SystemTheme As C1.Win.C1Themes.C1ThemeController
End Class
