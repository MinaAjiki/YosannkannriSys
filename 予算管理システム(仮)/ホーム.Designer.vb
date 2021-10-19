<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ホーム
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("", New System.Windows.Forms.TreeNode() {TreeNode1})
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ホーム))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ファイルToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.予算ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.外注ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.出来高ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.見積ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.マスタToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ヘルプToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.C1SplitContainer1 = New C1.Win.C1SplitContainer.C1SplitContainer()
        Me.C1SplitterPanel1 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.C1SplitterPanel2 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.C1TextBox4 = New C1.Win.C1Input.C1TextBox()
        Me.C1TextBox3 = New C1.Win.C1Input.C1TextBox()
        Me.C1TextBox2 = New C1.Win.C1Input.C1TextBox()
        Me.C1TextBox1 = New C1.Win.C1Input.C1TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.C1SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1SplitContainer1.SuspendLayout()
        Me.C1SplitterPanel1.SuspendLayout()
        Me.C1SplitterPanel2.SuspendLayout()
        CType(Me.C1TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ファイルToolStripMenuItem, Me.予算ToolStripMenuItem, Me.外注ToolStripMenuItem, Me.出来高ToolStripMenuItem, Me.見積ToolStripMenuItem, Me.マスタToolStripMenuItem, Me.ヘルプToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(1269, 26)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ファイルToolStripMenuItem
        '
        Me.ファイルToolStripMenuItem.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ファイルToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem"
        Me.ファイルToolStripMenuItem.Size = New System.Drawing.Size(68, 22)
        Me.ファイルToolStripMenuItem.Text = "ファイル"
        '
        '予算ToolStripMenuItem
        '
        Me.予算ToolStripMenuItem.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.予算ToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.予算ToolStripMenuItem.Name = "予算ToolStripMenuItem"
        Me.予算ToolStripMenuItem.Size = New System.Drawing.Size(44, 22)
        Me.予算ToolStripMenuItem.Text = "予算"
        '
        '外注ToolStripMenuItem
        '
        Me.外注ToolStripMenuItem.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.外注ToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.外注ToolStripMenuItem.Name = "外注ToolStripMenuItem"
        Me.外注ToolStripMenuItem.Size = New System.Drawing.Size(44, 22)
        Me.外注ToolStripMenuItem.Text = "見積"
        '
        '出来高ToolStripMenuItem
        '
        Me.出来高ToolStripMenuItem.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.出来高ToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.出来高ToolStripMenuItem.Name = "出来高ToolStripMenuItem"
        Me.出来高ToolStripMenuItem.Size = New System.Drawing.Size(68, 22)
        Me.出来高ToolStripMenuItem.Text = "外注計画"
        '
        '見積ToolStripMenuItem
        '
        Me.見積ToolStripMenuItem.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.見積ToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.見積ToolStripMenuItem.Name = "見積ToolStripMenuItem"
        Me.見積ToolStripMenuItem.Size = New System.Drawing.Size(44, 22)
        Me.見積ToolStripMenuItem.Text = "出力"
        '
        'マスタToolStripMenuItem
        '
        Me.マスタToolStripMenuItem.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.マスタToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.マスタToolStripMenuItem.Name = "マスタToolStripMenuItem"
        Me.マスタToolStripMenuItem.Size = New System.Drawing.Size(56, 22)
        Me.マスタToolStripMenuItem.Text = "マスタ"
        '
        'ヘルプToolStripMenuItem
        '
        Me.ヘルプToolStripMenuItem.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ヘルプToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ヘルプToolStripMenuItem.Name = "ヘルプToolStripMenuItem"
        Me.ヘルプToolStripMenuItem.Size = New System.Drawing.Size(56, 22)
        Me.ヘルプToolStripMenuItem.Text = "ヘルプ"
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TreeView1.Location = New System.Drawing.Point(0, 3)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "ノード2"
        TreeNode1.Text = ""
        TreeNode2.Name = "ノード0"
        TreeNode2.Text = ""
        TreeNode3.Name = "ノード1"
        TreeNode3.Text = ""
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode3})
        Me.TreeView1.Size = New System.Drawing.Size(269, 655)
        Me.TreeView1.TabIndex = 20
        '
        'C1SplitContainer1
        '
        Me.C1SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1SplitContainer1.AutoSizeElement = C1.Framework.AutoSizeElement.Both
        Me.C1SplitContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.C1SplitContainer1.CollapsingAreaColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.C1SplitContainer1.FixedLineColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.C1SplitContainer1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.C1SplitContainer1.HeaderHeight = 0
        Me.C1SplitContainer1.LineBelowHeader = False
        Me.C1SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.C1SplitContainer1.Name = "C1SplitContainer1"
        Me.C1SplitContainer1.Panels.Add(Me.C1SplitterPanel1)
        Me.C1SplitContainer1.Panels.Add(Me.C1SplitterPanel2)
        Me.C1SplitContainer1.Size = New System.Drawing.Size(1269, 659)
        Me.C1SplitContainer1.SplitterColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.C1SplitContainer1.SplitterWidth = 2
        Me.C1SplitContainer1.TabIndex = 28
        Me.C1SplitContainer1.ToolTipGradient = C1.Win.C1SplitContainer.ToolTipGradient.Blue
        Me.C1SplitContainer1.UseParentVisualStyle = False
        '
        'C1SplitterPanel1
        '
        Me.C1SplitterPanel1.BackColor = System.Drawing.Color.White
        Me.C1SplitterPanel1.Controls.Add(Me.TreeView1)
        Me.C1SplitterPanel1.Dock = C1.Win.C1SplitContainer.PanelDockStyle.Left
        Me.C1SplitterPanel1.Height = 659
        Me.C1SplitterPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1SplitterPanel1.Name = "C1SplitterPanel1"
        Me.C1SplitterPanel1.Size = New System.Drawing.Size(269, 659)
        Me.C1SplitterPanel1.SizeRatio = 21.231R
        Me.C1SplitterPanel1.TabIndex = 0
        Me.C1SplitterPanel1.Text = "パネル1"
        Me.C1SplitterPanel1.Width = 269
        '
        'C1SplitterPanel2
        '
        Me.C1SplitterPanel2.BackColor = System.Drawing.Color.White
        Me.C1SplitterPanel2.Controls.Add(Me.Button2)
        Me.C1SplitterPanel2.Controls.Add(Me.C1TextBox4)
        Me.C1SplitterPanel2.Controls.Add(Me.C1TextBox3)
        Me.C1SplitterPanel2.Controls.Add(Me.C1TextBox2)
        Me.C1SplitterPanel2.Controls.Add(Me.C1TextBox1)
        Me.C1SplitterPanel2.Controls.Add(Me.Label2)
        Me.C1SplitterPanel2.Controls.Add(Me.Button1)
        Me.C1SplitterPanel2.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.C1SplitterPanel2.ForeColor = System.Drawing.Color.White
        Me.C1SplitterPanel2.HeaderTextAlign = C1.Win.C1SplitContainer.PanelTextAlign.Right
        Me.C1SplitterPanel2.Height = 659
        Me.C1SplitterPanel2.Location = New System.Drawing.Point(271, 0)
        Me.C1SplitterPanel2.Name = "C1SplitterPanel2"
        Me.C1SplitterPanel2.Size = New System.Drawing.Size(998, 659)
        Me.C1SplitterPanel2.TabIndex = 1
        Me.C1SplitterPanel2.Text = "パネル2"
        '
        'Button2
        '
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(110, 43)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 30)
        Me.Button2.TabIndex = 29
        Me.Button2.UseVisualStyleBackColor = False
        '
        'C1TextBox4
        '
        Me.C1TextBox4.AutoSize = False
        Me.C1TextBox4.BackColor = System.Drawing.Color.White
        Me.C1TextBox4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.C1TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1TextBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.C1TextBox4.Location = New System.Drawing.Point(117, 108)
        Me.C1TextBox4.Name = "C1TextBox4"
        Me.C1TextBox4.Size = New System.Drawing.Size(213, 20)
        Me.C1TextBox4.TabIndex = 28
        Me.C1TextBox4.Tag = Nothing
        Me.C1TextBox4.Value = ""
        '
        'C1TextBox3
        '
        Me.C1TextBox3.AutoSize = False
        Me.C1TextBox3.BackColor = System.Drawing.Color.White
        Me.C1TextBox3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.C1TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1TextBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.C1TextBox3.Location = New System.Drawing.Point(117, 87)
        Me.C1TextBox3.Name = "C1TextBox3"
        Me.C1TextBox3.Size = New System.Drawing.Size(213, 20)
        Me.C1TextBox3.TabIndex = 27
        Me.C1TextBox3.Tag = Nothing
        Me.C1TextBox3.Value = ""
        '
        'C1TextBox2
        '
        Me.C1TextBox2.AutoSize = False
        Me.C1TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.C1TextBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.C1TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1TextBox2.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.C1TextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.C1TextBox2.Location = New System.Drawing.Point(16, 108)
        Me.C1TextBox2.Name = "C1TextBox2"
        Me.C1TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.C1TextBox2.TabIndex = 26
        Me.C1TextBox2.Tag = Nothing
        Me.C1TextBox2.Value = "工事名"
        Me.C1TextBox2.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        '
        'C1TextBox1
        '
        Me.C1TextBox1.AutoSize = False
        Me.C1TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.C1TextBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.C1TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1TextBox1.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.C1TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.C1TextBox1.Location = New System.Drawing.Point(16, 87)
        Me.C1TextBox1.Name = "C1TextBox1"
        Me.C1TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.C1TextBox1.TabIndex = 25
        Me.C1TextBox1.Tag = Nothing
        Me.C1TextBox1.Value = "工事コード"
        Me.C1TextBox1.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(13, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 18)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "<< 予算総括表"
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(15, 43)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 30)
        Me.Button1.TabIndex = 23
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ホーム
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1264, 684)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.C1SplitContainer1)
        Me.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Name = "ホーム"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.C1SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1SplitContainer1.ResumeLayout(False)
        Me.C1SplitterPanel1.ResumeLayout(False)
        Me.C1SplitterPanel2.ResumeLayout(False)
        Me.C1SplitterPanel2.PerformLayout()
        CType(Me.C1TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ファイルToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 予算ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 外注ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 出来高ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 見積ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents C1SplitContainer1 As C1.Win.C1SplitContainer.C1SplitContainer
    Friend WithEvents C1SplitterPanel1 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents C1SplitterPanel2 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents Button2 As Button
    Friend WithEvents C1TextBox4 As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1TextBox3 As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1TextBox2 As C1.Win.C1Input.C1TextBox
    Friend WithEvents C1TextBox1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents マスタToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ヘルプToolStripMenuItem As ToolStripMenuItem
End Class
