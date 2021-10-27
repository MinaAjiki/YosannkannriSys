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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ErrorMessage = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 18)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "スタックトレース："
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "エラーメッセージ："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(72, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(428, 18)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "なお、下記の情報が必要になりますのでこの画面を開いたままご連絡下さい。"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(137, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(284, 18)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "お手数ですがシステム課までお問い合わせ下さい。"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(202, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "エラーが発生しました。"
        '
        'エラー
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(565, 484)
        Me.Controls.Add(Me.StackTrace)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ErrorMessage)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "エラー"
        Me.Text = "エラー"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StackTrace As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ErrorMessage As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
