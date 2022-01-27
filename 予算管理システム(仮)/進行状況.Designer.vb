<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 進行状況
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
        Me.WaitProcessPic = New System.Windows.Forms.PictureBox()
        Me.WaitProcessText = New System.Windows.Forms.Label()
        CType(Me.WaitProcessPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WaitProcessPic
        '
        Me.WaitProcessPic.Image = Global.予算管理システム_仮_.My.Resources.Resources.loader
        Me.WaitProcessPic.InitialImage = Global.予算管理システム_仮_.My.Resources.Resources.loader
        Me.WaitProcessPic.Location = New System.Drawing.Point(150, 29)
        Me.WaitProcessPic.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.WaitProcessPic.Name = "WaitProcessPic"
        Me.WaitProcessPic.Size = New System.Drawing.Size(32, 32)
        Me.WaitProcessPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.WaitProcessPic.TabIndex = 0
        Me.WaitProcessPic.TabStop = False
        '
        'WaitProcessText
        '
        Me.WaitProcessText.AutoSize = True
        Me.WaitProcessText.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.WaitProcessText.Location = New System.Drawing.Point(62, 98)
        Me.WaitProcessText.Name = "WaitProcessText"
        Me.WaitProcessText.Size = New System.Drawing.Size(224, 18)
        Me.WaitProcessText.TabIndex = 9
        Me.WaitProcessText.Text = "処理中です。しばらくお待ちください…"
        '
        '進行状況
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(334, 161)
        Me.Controls.Add(Me.WaitProcessText)
        Me.Controls.Add(Me.WaitProcessPic)
        Me.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "進行状況"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "進行状況"
        CType(Me.WaitProcessPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WaitProcessPic As PictureBox
    Friend WithEvents WaitProcessText As Label
End Class
