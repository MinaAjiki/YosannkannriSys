<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 予算選択
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(予算選択))
        Me.Contract_No = New System.Windows.Forms.Label()
        Me.Contract_NoList = New System.Windows.Forms.ComboBox()
        Me.ButtonImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.FilePathLabel = New System.Windows.Forms.Label()
        Me.ProjectLabel = New System.Windows.Forms.Label()
        Me.FilePath = New C1.Win.C1Input.C1TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.Project = New C1.Win.C1Input.C1TextBox()
        CType(Me.FilePath, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Project, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Contract_No
        '
        Me.Contract_No.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Contract_No.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Contract_No.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Contract_No.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Contract_No.Location = New System.Drawing.Point(35, 101)
        Me.Contract_No.Name = "Contract_No"
        Me.Contract_No.Size = New System.Drawing.Size(120, 20)
        Me.Contract_No.TabIndex = 50
        Me.Contract_No.Text = "変更回数"
        Me.Contract_No.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Contract_NoList
        '
        Me.Contract_NoList.FormattingEnabled = True
        Me.Contract_NoList.Location = New System.Drawing.Point(156, 101)
        Me.Contract_NoList.Name = "Contract_NoList"
        Me.Contract_NoList.Size = New System.Drawing.Size(101, 20)
        Me.Contract_NoList.TabIndex = 51
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
        'FilePathLabel
        '
        Me.FilePathLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.FilePathLabel.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.FilePathLabel.Location = New System.Drawing.Point(35, 43)
        Me.FilePathLabel.Name = "FilePathLabel"
        Me.FilePathLabel.Size = New System.Drawing.Size(120, 42)
        Me.FilePathLabel.TabIndex = 55
        Me.FilePathLabel.Text = "ファイルの場所"
        Me.FilePathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ProjectLabel
        '
        Me.ProjectLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ProjectLabel.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ProjectLabel.Location = New System.Drawing.Point(35, 22)
        Me.ProjectLabel.Name = "ProjectLabel"
        Me.ProjectLabel.Size = New System.Drawing.Size(120, 20)
        Me.ProjectLabel.TabIndex = 58
        Me.ProjectLabel.Text = "工事コード/工事名"
        '
        'FilePath
        '
        Me.FilePath.BackColor = System.Drawing.Color.WhiteSmoke
        Me.FilePath.BorderColor = System.Drawing.Color.Gray
        Me.FilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FilePath.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.FilePath.Location = New System.Drawing.Point(156, 43)
        Me.FilePath.Multiline = True
        Me.FilePath.Name = "FilePath"
        Me.FilePath.ReadOnly = True
        Me.FilePath.Size = New System.Drawing.Size(220, 42)
        Me.FilePath.TabIndex = 59
        Me.FilePath.Tag = Nothing
        Me.FilePath.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'OK
        '
        Me.OK.FlatAppearance.BorderSize = 0
        Me.OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OK.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.OK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.OK.ImageIndex = 0
        Me.OK.ImageList = Me.ButtonImageList
        Me.OK.Location = New System.Drawing.Point(276, 95)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(100, 30)
        Me.OK.TabIndex = 52
        Me.OK.Text = "OK"
        Me.OK.UseVisualStyleBackColor = True
        '
        'Project
        '
        Me.Project.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Project.BorderColor = System.Drawing.Color.Gray
        Me.Project.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Project.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.Project.Location = New System.Drawing.Point(156, 22)
        Me.Project.Multiline = True
        Me.Project.Name = "Project"
        Me.Project.ReadOnly = True
        Me.Project.Size = New System.Drawing.Size(220, 20)
        Me.Project.TabIndex = 61
        Me.Project.Tag = Nothing
        Me.Project.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.Project.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        '予算選択
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(393, 139)
        Me.ControlBox = False
        Me.Controls.Add(Me.Project)
        Me.Controls.Add(Me.FilePath)
        Me.Controls.Add(Me.ProjectLabel)
        Me.Controls.Add(Me.FilePathLabel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.Contract_NoList)
        Me.Controls.Add(Me.Contract_No)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "予算選択"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "予算選択"
        Me.TopMost = True
        CType(Me.FilePath, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Project, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Contract_No As Label
    Friend WithEvents Contract_NoList As ComboBox
    Friend WithEvents OK As Button
    Private WithEvents ButtonImageList As ImageList
    Friend WithEvents FilePathLabel As Label
    Friend WithEvents ProjectLabel As Label
    Friend WithEvents FilePath As C1.Win.C1Input.C1TextBox
    Friend WithEvents Project As C1.Win.C1Input.C1TextBox
End Class
