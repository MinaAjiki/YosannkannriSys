<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class エラー
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
        Me.StackTrace = New System.Windows.Forms.TextBox()
        Me.StackTrace_Label = New System.Windows.Forms.Label()
        Me.ErrorMessage = New System.Windows.Forms.TextBox()
        Me.ErrorMessage_Label = New System.Windows.Forms.Label()
        Me.Message3 = New System.Windows.Forms.Label()
        Me.Message2 = New System.Windows.Forms.Label()
        Me.Message1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'StackTrace
        '
        Me.StackTrace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StackTrace.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.StackTrace.Location = New System.Drawing.Point(140, 232)
        Me.StackTrace.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.StackTrace.Multiline = True
        Me.StackTrace.Name = "StackTrace"
        Me.StackTrace.ReadOnly = True
        Me.StackTrace.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.StackTrace.Size = New System.Drawing.Size(380, 212)
        Me.StackTrace.TabIndex = 13
        '
        'StackTrace_Label
        '
        Me.StackTrace_Label.AutoSize = True
        Me.StackTrace_Label.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.StackTrace_Label.Location = New System.Drawing.Point(29, 232)
        Me.StackTrace_Label.Name = "StackTrace_Label"
        Me.StackTrace_Label.Size = New System.Drawing.Size(116, 18)
        Me.StackTrace_Label.TabIndex = 12
        Me.StackTrace_Label.Text = "スタックトレース："
        '
        'ErrorMessage
        '
        Me.ErrorMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ErrorMessage.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ErrorMessage.Location = New System.Drawing.Point(140, 153)
        Me.ErrorMessage.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ErrorMessage.Multiline = True
        Me.ErrorMessage.Name = "ErrorMessage"
        Me.ErrorMessage.ReadOnly = True
        Me.ErrorMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ErrorMessage.Size = New System.Drawing.Size(380, 58)
        Me.ErrorMessage.TabIndex = 11
        '
        'ErrorMessage_Label
        '
        Me.ErrorMessage_Label.AutoSize = True
        Me.ErrorMessage_Label.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ErrorMessage_Label.Location = New System.Drawing.Point(29, 153)
        Me.ErrorMessage_Label.Name = "ErrorMessage_Label"
        Me.ErrorMessage_Label.Size = New System.Drawing.Size(116, 18)
        Me.ErrorMessage_Label.TabIndex = 10
        Me.ErrorMessage_Label.Text = "エラーメッセージ："
        '
        'Message3
        '
        Me.Message3.AutoSize = True
        Me.Message3.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Message3.Location = New System.Drawing.Point(72, 101)
        Me.Message3.Name = "Message3"
        Me.Message3.Size = New System.Drawing.Size(428, 18)
        Me.Message3.TabIndex = 9
        Me.Message3.Text = "なお、下記の情報が必要になりますのでこの画面を開いたままご連絡下さい。"
        '
        'Message2
        '
        Me.Message2.AutoSize = True
        Me.Message2.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Message2.Location = New System.Drawing.Point(137, 73)
        Me.Message2.Name = "Message2"
        Me.Message2.Size = New System.Drawing.Size(284, 18)
        Me.Message2.TabIndex = 8
        Me.Message2.Text = "お手数ですがシステム課までお問い合わせ下さい。"
        '
        'Message1
        '
        Me.Message1.AutoSize = True
        Me.Message1.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Message1.Location = New System.Drawing.Point(202, 46)
        Me.Message1.Name = "Message1"
        Me.Message1.Size = New System.Drawing.Size(140, 18)
        Me.Message1.TabIndex = 7
        Me.Message1.Text = "エラーが発生しました。"
        '
        'エラー
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(565, 484)
        Me.Controls.Add(Me.StackTrace)
        Me.Controls.Add(Me.StackTrace_Label)
        Me.Controls.Add(Me.ErrorMessage)
        Me.Controls.Add(Me.ErrorMessage_Label)
        Me.Controls.Add(Me.Message3)
        Me.Controls.Add(Me.Message2)
        Me.Controls.Add(Me.Message1)
        Me.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "エラー"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "エラー"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StackTrace As TextBox
    Friend WithEvents StackTrace_Label As Label
    Friend WithEvents ErrorMessage As TextBox
    Friend WithEvents ErrorMessage_Label As Label
    Friend WithEvents Message3 As Label
    Friend WithEvents Message2 As Label
    Friend WithEvents Message1 As Label
End Class
