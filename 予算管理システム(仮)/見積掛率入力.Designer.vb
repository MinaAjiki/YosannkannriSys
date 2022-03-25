<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 見積掛率入力

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(見積掛率入力))
        Me.Contract_No = New System.Windows.Forms.Label()
        Me.ButtonImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.OK = New System.Windows.Forms.Button()
        Me.HeadLine = New System.Windows.Forms.Label()
        Me.C1TextBox1 = New C1.Win.C1Input.C1TextBox()
        Me.C1ThemeController1 = New C1.Win.C1Themes.C1ThemeController()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.C1TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Contract_No
        '
        Me.Contract_No.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Contract_No.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Contract_No.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Contract_No.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Contract_No.Location = New System.Drawing.Point(46, 63)
        Me.Contract_No.Name = "Contract_No"
        Me.Contract_No.Size = New System.Drawing.Size(53, 20)
        Me.Contract_No.TabIndex = 50
        Me.Contract_No.Text = "掛率"
        Me.Contract_No.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.ButtonImageList.Images.SetKeyName(12, "ModifiyCosts.png")
        Me.ButtonImageList.Images.SetKeyName(13, "ModifyCosts_mouseenter.png")
        Me.ButtonImageList.Images.SetKeyName(14, "ModifyCosts_mousedown.png")
        Me.ButtonImageList.Images.SetKeyName(15, "CopyCosts.png")
        Me.ButtonImageList.Images.SetKeyName(16, "CopyCosts_mouseenter.png")
        Me.ButtonImageList.Images.SetKeyName(17, "CopyCosts_mousedown.png")
        Me.ButtonImageList.Images.SetKeyName(18, "Recalculation.png")
        Me.ButtonImageList.Images.SetKeyName(19, "Recalculation_mousenter.png")
        Me.ButtonImageList.Images.SetKeyName(20, "Recalculation_mousedown.png")
        '
        'OK
        '
        Me.OK.FlatAppearance.BorderSize = 0
        Me.OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OK.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.OK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.OK.ImageIndex = 0
        Me.OK.ImageList = Me.ButtonImageList
        Me.OK.Location = New System.Drawing.Point(124, 146)
        Me.OK.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(100, 30)
        Me.OK.TabIndex = 52
        Me.OK.Text = "OK"
        Me.OK.UseVisualStyleBackColor = True
        '
        'HeadLine
        '
        Me.HeadLine.AutoSize = True
        Me.HeadLine.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.HeadLine.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.HeadLine.Location = New System.Drawing.Point(14, 14)
        Me.HeadLine.Name = "HeadLine"
        Me.HeadLine.Size = New System.Drawing.Size(100, 18)
        Me.HeadLine.TabIndex = 53
        Me.HeadLine.Text = "<<見積掛率入力"
        '
        'C1TextBox1
        '
        Me.C1TextBox1.AutoSize = False
        Me.C1TextBox1.BackColor = System.Drawing.Color.White
        Me.C1TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1TextBox1.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.C1TextBox1.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1TextBox1.FormatType = C1.Win.C1Input.FormatTypeEnum.Percent
        Me.C1TextBox1.Location = New System.Drawing.Point(100, 63)
        Me.C1TextBox1.Name = "C1TextBox1"
        Me.C1TextBox1.Size = New System.Drawing.Size(74, 20)
        Me.C1TextBox1.TabIndex = 54
        Me.C1TextBox1.Tag = Nothing
        Me.C1ThemeController1.SetTheme(Me.C1TextBox1, "予算管理テーマ")
        Me.C1TextBox1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 17)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "( 現在の掛率"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(117, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 18)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "5"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("メイリオ", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(152, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 17)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "％ )"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(176, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 18)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "％"
        '
        '見積掛率入力
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(230, 182)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.C1TextBox1)
        Me.Controls.Add(Me.HeadLine)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.Contract_No)
        Me.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "見積掛率入力"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "見積掛率入力"
        Me.TopMost = True
        CType(Me.C1TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Contract_No As Label
    Friend WithEvents OK As Button
    Private WithEvents ButtonImageList As ImageList
    Friend WithEvents HeadLine As Label
    Friend WithEvents C1TextBox1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1ThemeController1 As C1.Win.C1Themes.C1ThemeController
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
