<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ホーム
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
        Dim C1TreeColumn1 As C1.Win.TreeView.C1TreeColumn = New C1.Win.TreeView.C1TreeColumn()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ホーム))
        Me.ファイルToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.予算ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.外注ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.出来高ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.見積ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.マスタToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ヘルプToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeSplitContainer = New C1.Win.C1SplitContainer.C1SplitContainer()
        Me.TreePanel = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.HomeTreeView = New C1.Win.TreeView.C1TreeView()
        Me.右クリックメニュー = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ReferenceMode = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormPanel = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.ButtonImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.MenuComｍand = New C1.Win.C1Command.C1CommandHolder()
        Me.ファイル = New C1.Win.C1Command.C1CommandMenu()
        Me.C1CommandLink3 = New C1.Win.C1Command.C1CommandLink()
        Me.新規作成 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink15 = New C1.Win.C1Command.C1CommandLink()
        Me.開く = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink16 = New C1.Win.C1Command.C1CommandLink()
        Me.材料表インポート = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink17 = New C1.Win.C1Command.C1CommandLink()
        Me.参照作成command = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink18 = New C1.Win.C1Command.C1CommandLink()
        Me.管理者登録 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink19 = New C1.Win.C1Command.C1CommandLink()
        Me.閉じる = New C1.Win.C1Command.C1Command()
        Me.予算 = New C1.Win.C1Command.C1CommandMenu()
        Me.C1CommandLink4 = New C1.Win.C1Command.C1CommandLink()
        Me.予算総括登録 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink20 = New C1.Win.C1Command.C1CommandLink()
        Me.予算内訳登録 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink22 = New C1.Win.C1Command.C1CommandLink()
        Me.入力表作成 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink23 = New C1.Win.C1Command.C1CommandLink()
        Me.予算費目集計 = New C1.Win.C1Command.C1Command()
        Me.見積 = New C1.Win.C1Command.C1CommandMenu()
        Me.C1CommandLink24 = New C1.Win.C1Command.C1CommandLink()
        Me.見積書作成 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink6 = New C1.Win.C1Command.C1CommandLink()
        Me.見積内訳登録 = New C1.Win.C1Command.C1Command()
        Me.外注管理 = New C1.Win.C1Command.C1CommandMenu()
        Me.C1CommandLink25 = New C1.Win.C1Command.C1CommandLink()
        Me.協力業者登録 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink8 = New C1.Win.C1Command.C1CommandLink()
        Me.外注計画登録 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink27 = New C1.Win.C1Command.C1CommandLink()
        Me.締切処理 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink28 = New C1.Win.C1Command.C1CommandLink()
        Me.出来高登録 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink29 = New C1.Win.C1Command.C1CommandLink()
        Me.注文書番号登録 = New C1.Win.C1Command.C1Command()
        Me.出力 = New C1.Win.C1Command.C1CommandMenu()
        Me.C1CommandLink30 = New C1.Win.C1Command.C1CommandLink()
        Me.出力_予算 = New C1.Win.C1Command.C1CommandMenu()
        Me.C1CommandLink32 = New C1.Win.C1Command.C1CommandLink()
        Me.詳細予算内訳印刷 = New C1.Win.C1Command.C1CommandMenu()
        Me.C1CommandLink35 = New C1.Win.C1Command.C1CommandLink()
        Me.全て印刷 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink47 = New C1.Win.C1Command.C1CommandLink()
        Me.予算総括表 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink48 = New C1.Win.C1Command.C1CommandLink()
        Me.材料表 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink49 = New C1.Win.C1Command.C1CommandLink()
        Me.現場経費 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink50 = New C1.Win.C1Command.C1CommandLink()
        Me.予算大内訳 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink51 = New C1.Win.C1Command.C1CommandLink()
        Me.予算内訳書 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink52 = New C1.Win.C1Command.C1CommandLink()
        Me.明細内訳書 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink53 = New C1.Win.C1Command.C1CommandLink()
        Me.代価表 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink54 = New C1.Win.C1Command.C1CommandLink()
        Me.摘要基礎代価表 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink55 = New C1.Win.C1Command.C1CommandLink()
        Me.基礎代価一覧表 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink56 = New C1.Win.C1Command.C1CommandLink()
        Me.基礎代価詳細内訳書 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink57 = New C1.Win.C1Command.C1CommandLink()
        Me.基礎代価簡易内訳書 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink36 = New C1.Win.C1Command.C1CommandLink()
        Me.簡易予算内訳印刷 = New C1.Win.C1Command.C1CommandMenu()
        Me.C1CommandLink37 = New C1.Win.C1Command.C1CommandLink()
        Me.全て印刷_簡易 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink58 = New C1.Win.C1Command.C1CommandLink()
        Me.予算総括表_簡易 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink59 = New C1.Win.C1Command.C1CommandLink()
        Me.予算書 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink60 = New C1.Win.C1Command.C1CommandLink()
        Me.明細書 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink62 = New C1.Win.C1Command.C1CommandLink()
        Me.現場経費_簡易 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink61 = New C1.Win.C1Command.C1CommandLink()
        Me.代価一覧表 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink63 = New C1.Win.C1Command.C1CommandLink()
        Me.代価内訳 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink64 = New C1.Win.C1Command.C1CommandLink()
        Me.基礎代価一覧表_簡易 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink65 = New C1.Win.C1Command.C1CommandLink()
        Me.基礎代価内訳 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink5 = New C1.Win.C1Command.C1CommandLink()
        Me.入力表 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink1 = New C1.Win.C1Command.C1CommandLink()
        Me.入力表_工務課用 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink38 = New C1.Win.C1Command.C1CommandLink()
        Me.明細書一覧_Excel = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink39 = New C1.Win.C1Command.C1CommandLink()
        Me.実行予算_csv_cap21 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink40 = New C1.Win.C1Command.C1CommandLink()
        Me.労働者集計 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink41 = New C1.Win.C1Command.C1CommandLink()
        Me.使用材料集計 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink42 = New C1.Win.C1Command.C1CommandLink()
        Me.使用機械集計 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink43 = New C1.Win.C1Command.C1CommandLink()
        Me.外注項目集計 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink44 = New C1.Win.C1Command.C1CommandLink()
        Me.社内機材集計 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink45 = New C1.Win.C1Command.C1CommandLink()
        Me.社外機材集計 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink46 = New C1.Win.C1Command.C1CommandLink()
        Me.材料集計_Excel = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink10 = New C1.Win.C1Command.C1CommandLink()
        Me.出力_見積 = New C1.Win.C1Command.C1CommandMenu()
        Me.C1CommandLink33 = New C1.Win.C1Command.C1CommandLink()
        Me.見積表紙 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink66 = New C1.Win.C1Command.C1CommandLink()
        Me.見積内訳鑑 = New C1.Win.C1Command.C1CommandMenu()
        Me.C1CommandLink67 = New C1.Win.C1Command.C1CommandLink()
        Me.値引き有 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink68 = New C1.Win.C1Command.C1CommandLink()
        Me.値引き無 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink69 = New C1.Win.C1Command.C1CommandLink()
        Me.見積条件詳細 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink70 = New C1.Win.C1Command.C1CommandLink()
        Me.見積内訳 = New C1.Win.C1Command.C1CommandMenu()
        Me.C1CommandLink71 = New C1.Win.C1Command.C1CommandLink()
        Me.金込 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink72 = New C1.Win.C1Command.C1CommandLink()
        Me.金抜 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink73 = New C1.Win.C1Command.C1CommandLink()
        Me.見積代価_Aのみ = New C1.Win.C1Command.C1CommandMenu()
        Me.C1CommandLink74 = New C1.Win.C1Command.C1CommandLink()
        Me.見積代価_金込 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink75 = New C1.Win.C1Command.C1CommandLink()
        Me.見積代価_金抜 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink76 = New C1.Win.C1Command.C1CommandLink()
        Me.代価 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink31 = New C1.Win.C1Command.C1CommandLink()
        Me.出力_外注計画 = New C1.Win.C1Command.C1CommandMenu()
        Me.C1CommandLink34 = New C1.Win.C1Command.C1CommandLink()
        Me.外注計画 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink77 = New C1.Win.C1Command.C1CommandLink()
        Me.外注計画_Excel = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink78 = New C1.Win.C1Command.C1CommandLink()
        Me.外注計画報告書 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink79 = New C1.Win.C1Command.C1CommandLink()
        Me.出来高査定 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink85 = New C1.Win.C1Command.C1CommandLink()
        Me.折衝用業者別内訳 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink86 = New C1.Win.C1Command.C1CommandLink()
        Me.注文書 = New C1.Win.C1Command.C1CommandMenu()
        Me.C1CommandLink87 = New C1.Win.C1Command.C1CommandLink()
        Me.注文書_金込 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink88 = New C1.Win.C1Command.C1CommandLink()
        Me.注文書_金抜 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink89 = New C1.Win.C1Command.C1CommandLink()
        Me.注文内訳書_Excel = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink90 = New C1.Win.C1Command.C1CommandLink()
        Me.注文書明細_CSV = New C1.Win.C1Command.C1Command()
        Me.マスタ = New C1.Win.C1Command.C1CommandMenu()
        Me.ヘルプ = New C1.Win.C1Command.C1CommandMenu()
        Me.C1CommandLink14 = New C1.Win.C1Command.C1CommandLink()
        Me.アップデート = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink12 = New C1.Win.C1Command.C1CommandLink()
        Me.バージョン情報 = New C1.Win.C1Command.C1Command()
        Me.代価表作成 = New C1.Win.C1Command.C1Command()
        Me.変更内容登録 = New C1.Win.C1Command.C1Command()
        Me.出来高査定書_完成 = New C1.Win.C1Command.C1Command()
        Me.出来形数量査定書_Excel = New C1.Win.C1Command.C1Command()
        Me.出来形数量査定書 = New C1.Win.C1Command.C1CommandMenu()
        Me.C1CommandLink83 = New C1.Win.C1Command.C1CommandLink()
        Me.中間 = New C1.Win.C1Command.C1Command()
        Me.C1CommandLink84 = New C1.Win.C1Command.C1CommandLink()
        Me.完成 = New C1.Win.C1Command.C1Command()
        Me.MainMenu = New C1.Win.C1Command.C1MainMenu()
        Me.C1CommandLink2 = New C1.Win.C1Command.C1CommandLink()
        Me.BudgetMenu = New C1.Win.C1Command.C1CommandLink()
        Me.EstimateMenu = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink7 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink9 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink11 = New C1.Win.C1Command.C1CommandLink()
        Me.C1CommandLink13 = New C1.Win.C1Command.C1CommandLink()
        Me.SystemTheme = New C1.Win.C1Themes.C1ThemeController()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.C1TextBox1 = New C1.Win.C1Input.C1TextBox()
        Me.CreateFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.ImportFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.DataBook = New C1.C1Excel.C1XLBook()
        Me.C1XLBook1 = New C1.C1Excel.C1XLBook()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.HomeSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HomeSplitContainer.SuspendLayout()
        Me.TreePanel.SuspendLayout()
        CType(Me.HomeTreeView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.右クリックメニュー.SuspendLayout()
        CType(Me.MenuComｍand, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'HomeSplitContainer
        '
        Me.HomeSplitContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HomeSplitContainer.AutoSizeElement = C1.Framework.AutoSizeElement.Both
        Me.HomeSplitContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.HomeSplitContainer.CollapsingAreaColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.HomeSplitContainer.FixedLineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.HomeSplitContainer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.HomeSplitContainer.HeaderHeight = 0
        Me.HomeSplitContainer.LineBelowHeader = False
        Me.HomeSplitContainer.Location = New System.Drawing.Point(0, 20)
        Me.HomeSplitContainer.Name = "HomeSplitContainer"
        Me.HomeSplitContainer.Panels.Add(Me.TreePanel)
        Me.HomeSplitContainer.Panels.Add(Me.FormPanel)
        Me.HomeSplitContainer.Size = New System.Drawing.Size(1263, 664)
        Me.HomeSplitContainer.SplitterColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.HomeSplitContainer.SplitterWidth = 3
        Me.HomeSplitContainer.TabIndex = 28
        Me.HomeSplitContainer.ToolTipGradient = C1.Win.C1SplitContainer.ToolTipGradient.Blue
        Me.HomeSplitContainer.UseParentVisualStyle = False
        '
        'TreePanel
        '
        Me.TreePanel.BackColor = System.Drawing.Color.White
        Me.TreePanel.Controls.Add(Me.HomeTreeView)
        Me.TreePanel.Dock = C1.Win.C1SplitContainer.PanelDockStyle.Left
        Me.TreePanel.Height = 664
        Me.TreePanel.Location = New System.Drawing.Point(0, 0)
        Me.TreePanel.Name = "TreePanel"
        Me.TreePanel.Size = New System.Drawing.Size(270, 664)
        Me.TreePanel.SizeRatio = 21.412R
        Me.TreePanel.TabIndex = 0
        Me.TreePanel.Text = "パネル1"
        Me.TreePanel.Width = 270
        '
        'HomeTreeView
        '
        Me.HomeTreeView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HomeTreeView.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.HomeTreeView.ButtonImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.HomeTreeView.ButtonImageList.ImageSize = New System.Drawing.Size(16, 16)
        '
        '
        '
        Me.HomeTreeView.CheckImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.HomeTreeView.CheckImageList.ImageSize = New System.Drawing.Size(16, 16)
        C1TreeColumn1.DisplayFieldName = Nothing
        C1TreeColumn1.HeaderText = Nothing
        C1TreeColumn1.Name = "Column1"
        Me.HomeTreeView.Columns.Add(C1TreeColumn1)
        Me.HomeTreeView.ContextMenuStrip = Me.右クリックメニュー
        Me.HomeTreeView.Location = New System.Drawing.Point(0, 0)
        Me.HomeTreeView.Name = "HomeTreeView"
        Me.HomeTreeView.Size = New System.Drawing.Size(270, 664)
        Me.HomeTreeView.Styles.Border = 0
        Me.HomeTreeView.Styles.BorderColor = System.Drawing.Color.AliceBlue
        Me.HomeTreeView.Styles.ColumnHeader.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.HomeTreeView.Styles.Default.BackColor = System.Drawing.Color.White
        Me.HomeTreeView.Styles.Disabled.BackColor = System.Drawing.Color.White
        Me.HomeTreeView.Styles.DropLineColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.HomeTreeView.Styles.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.HomeTreeView.Styles.Hot.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.HomeTreeView.Styles.UnfocusedSelected.BackColor = System.Drawing.Color.White
        Me.HomeTreeView.TabIndex = 44
        Me.SystemTheme.SetTheme(Me.HomeTreeView, "予算管理テーマ")
        '
        '右クリックメニュー
        '
        Me.右クリックメニュー.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.右クリックメニュー.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.右クリックメニュー.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReferenceMode})
        Me.右クリックメニュー.Name = "ContextMenuStrip1"
        Me.右クリックメニュー.ShowImageMargin = False
        Me.右クリックメニュー.Size = New System.Drawing.Size(148, 26)
        Me.右クリックメニュー.Text = "項目選択"
        '
        'ReferenceMode
        '
        Me.ReferenceMode.Name = "ReferenceMode"
        Me.ReferenceMode.Size = New System.Drawing.Size(147, 22)
        Me.ReferenceMode.Text = "参照モードで開く"
        '
        'FormPanel
        '
        Me.FormPanel.BackColor = System.Drawing.Color.White
        Me.FormPanel.Height = 664
        Me.FormPanel.Location = New System.Drawing.Point(273, 0)
        Me.FormPanel.Name = "FormPanel"
        Me.FormPanel.Size = New System.Drawing.Size(990, 664)
        Me.FormPanel.TabIndex = 1
        Me.FormPanel.Text = "パネル2"
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
        'MenuComｍand
        '
        Me.MenuComｍand.Commands.Add(Me.ファイル)
        Me.MenuComｍand.Commands.Add(Me.新規作成)
        Me.MenuComｍand.Commands.Add(Me.予算)
        Me.MenuComｍand.Commands.Add(Me.見積)
        Me.MenuComｍand.Commands.Add(Me.外注管理)
        Me.MenuComｍand.Commands.Add(Me.出力)
        Me.MenuComｍand.Commands.Add(Me.マスタ)
        Me.MenuComｍand.Commands.Add(Me.ヘルプ)
        Me.MenuComｍand.Commands.Add(Me.開く)
        Me.MenuComｍand.Commands.Add(Me.材料表インポート)
        Me.MenuComｍand.Commands.Add(Me.参照作成command)
        Me.MenuComｍand.Commands.Add(Me.管理者登録)
        Me.MenuComｍand.Commands.Add(Me.閉じる)
        Me.MenuComｍand.Commands.Add(Me.予算総括登録)
        Me.MenuComｍand.Commands.Add(Me.予算内訳登録)
        Me.MenuComｍand.Commands.Add(Me.代価表作成)
        Me.MenuComｍand.Commands.Add(Me.入力表作成)
        Me.MenuComｍand.Commands.Add(Me.予算費目集計)
        Me.MenuComｍand.Commands.Add(Me.見積書作成)
        Me.MenuComｍand.Commands.Add(Me.見積内訳登録)
        Me.MenuComｍand.Commands.Add(Me.協力業者登録)
        Me.MenuComｍand.Commands.Add(Me.外注計画登録)
        Me.MenuComｍand.Commands.Add(Me.変更内容登録)
        Me.MenuComｍand.Commands.Add(Me.締切処理)
        Me.MenuComｍand.Commands.Add(Me.出来高登録)
        Me.MenuComｍand.Commands.Add(Me.注文書番号登録)
        Me.MenuComｍand.Commands.Add(Me.アップデート)
        Me.MenuComｍand.Commands.Add(Me.バージョン情報)
        Me.MenuComｍand.Commands.Add(Me.出力_予算)
        Me.MenuComｍand.Commands.Add(Me.出力_見積)
        Me.MenuComｍand.Commands.Add(Me.出力_外注計画)
        Me.MenuComｍand.Commands.Add(Me.詳細予算内訳印刷)
        Me.MenuComｍand.Commands.Add(Me.簡易予算内訳印刷)
        Me.MenuComｍand.Commands.Add(Me.明細書一覧_Excel)
        Me.MenuComｍand.Commands.Add(Me.実行予算_csv_cap21)
        Me.MenuComｍand.Commands.Add(Me.労働者集計)
        Me.MenuComｍand.Commands.Add(Me.使用材料集計)
        Me.MenuComｍand.Commands.Add(Me.使用機械集計)
        Me.MenuComｍand.Commands.Add(Me.外注項目集計)
        Me.MenuComｍand.Commands.Add(Me.社内機材集計)
        Me.MenuComｍand.Commands.Add(Me.社外機材集計)
        Me.MenuComｍand.Commands.Add(Me.材料集計_Excel)
        Me.MenuComｍand.Commands.Add(Me.全て印刷)
        Me.MenuComｍand.Commands.Add(Me.予算総括表)
        Me.MenuComｍand.Commands.Add(Me.材料表)
        Me.MenuComｍand.Commands.Add(Me.現場経費)
        Me.MenuComｍand.Commands.Add(Me.予算大内訳)
        Me.MenuComｍand.Commands.Add(Me.予算内訳書)
        Me.MenuComｍand.Commands.Add(Me.明細内訳書)
        Me.MenuComｍand.Commands.Add(Me.代価表)
        Me.MenuComｍand.Commands.Add(Me.摘要基礎代価表)
        Me.MenuComｍand.Commands.Add(Me.基礎代価一覧表)
        Me.MenuComｍand.Commands.Add(Me.基礎代価詳細内訳書)
        Me.MenuComｍand.Commands.Add(Me.基礎代価簡易内訳書)
        Me.MenuComｍand.Commands.Add(Me.全て印刷_簡易)
        Me.MenuComｍand.Commands.Add(Me.予算総括表_簡易)
        Me.MenuComｍand.Commands.Add(Me.予算書)
        Me.MenuComｍand.Commands.Add(Me.明細書)
        Me.MenuComｍand.Commands.Add(Me.現場経費_簡易)
        Me.MenuComｍand.Commands.Add(Me.代価一覧表)
        Me.MenuComｍand.Commands.Add(Me.代価内訳)
        Me.MenuComｍand.Commands.Add(Me.基礎代価一覧表_簡易)
        Me.MenuComｍand.Commands.Add(Me.基礎代価内訳)
        Me.MenuComｍand.Commands.Add(Me.見積表紙)
        Me.MenuComｍand.Commands.Add(Me.見積内訳鑑)
        Me.MenuComｍand.Commands.Add(Me.値引き有)
        Me.MenuComｍand.Commands.Add(Me.値引き無)
        Me.MenuComｍand.Commands.Add(Me.見積条件詳細)
        Me.MenuComｍand.Commands.Add(Me.見積内訳)
        Me.MenuComｍand.Commands.Add(Me.金込)
        Me.MenuComｍand.Commands.Add(Me.金抜)
        Me.MenuComｍand.Commands.Add(Me.見積代価_Aのみ)
        Me.MenuComｍand.Commands.Add(Me.見積代価_金込)
        Me.MenuComｍand.Commands.Add(Me.見積代価_金抜)
        Me.MenuComｍand.Commands.Add(Me.代価)
        Me.MenuComｍand.Commands.Add(Me.外注計画)
        Me.MenuComｍand.Commands.Add(Me.外注計画_Excel)
        Me.MenuComｍand.Commands.Add(Me.外注計画報告書)
        Me.MenuComｍand.Commands.Add(Me.出来高査定)
        Me.MenuComｍand.Commands.Add(Me.出来高査定書_完成)
        Me.MenuComｍand.Commands.Add(Me.出来形数量査定書_Excel)
        Me.MenuComｍand.Commands.Add(Me.出来形数量査定書)
        Me.MenuComｍand.Commands.Add(Me.中間)
        Me.MenuComｍand.Commands.Add(Me.完成)
        Me.MenuComｍand.Commands.Add(Me.折衝用業者別内訳)
        Me.MenuComｍand.Commands.Add(Me.注文書)
        Me.MenuComｍand.Commands.Add(Me.注文書_金込)
        Me.MenuComｍand.Commands.Add(Me.注文書_金抜)
        Me.MenuComｍand.Commands.Add(Me.注文内訳書_Excel)
        Me.MenuComｍand.Commands.Add(Me.注文書明細_CSV)
        Me.MenuComｍand.Commands.Add(Me.入力表_工務課用)
        Me.MenuComｍand.Commands.Add(Me.入力表)
        Me.MenuComｍand.Owner = Me
        '
        'ファイル
        '
        Me.ファイル.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink3, Me.C1CommandLink15, Me.C1CommandLink16, Me.C1CommandLink17, Me.C1CommandLink18, Me.C1CommandLink19})
        Me.ファイル.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.ファイル.HideNonRecentLinks = False
        Me.ファイル.Name = "ファイル"
        Me.ファイル.SeparateCheckBar = True
        Me.ファイル.ShortcutText = ""
        Me.ファイル.Text = "ファイル"
        Me.ファイル.VisualStyle = C1.Win.C1Command.VisualStyle.Custom
        Me.ファイル.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2007Blue
        '
        'C1CommandLink3
        '
        Me.C1CommandLink3.Command = Me.新規作成
        '
        '新規作成
        '
        Me.新規作成.Name = "新規作成"
        Me.新規作成.ShortcutText = ""
        Me.新規作成.Text = "新規作成"
        '
        'C1CommandLink15
        '
        Me.C1CommandLink15.Command = Me.開く
        Me.C1CommandLink15.Delimiter = True
        Me.C1CommandLink15.SortOrder = 1
        '
        '開く
        '
        Me.開く.Name = "開く"
        Me.開く.ShortcutText = ""
        Me.開く.Text = "開く"
        '
        'C1CommandLink16
        '
        Me.C1CommandLink16.Command = Me.材料表インポート
        Me.C1CommandLink16.SortOrder = 2
        '
        '材料表インポート
        '
        Me.材料表インポート.Name = "材料表インポート"
        Me.材料表インポート.ShortcutText = ""
        Me.材料表インポート.Text = "材料表インポート"
        '
        'C1CommandLink17
        '
        Me.C1CommandLink17.Command = Me.参照作成command
        Me.C1CommandLink17.SortOrder = 3
        '
        '参照作成command
        '
        Me.参照作成command.Name = "参照作成command"
        Me.参照作成command.ShortcutText = ""
        Me.参照作成command.Text = "参照作成"
        '
        'C1CommandLink18
        '
        Me.C1CommandLink18.Command = Me.管理者登録
        Me.C1CommandLink18.Delimiter = True
        Me.C1CommandLink18.SortOrder = 4
        '
        '管理者登録
        '
        Me.管理者登録.Name = "管理者登録"
        Me.管理者登録.ShortcutText = ""
        Me.管理者登録.Text = "管理者登録"
        '
        'C1CommandLink19
        '
        Me.C1CommandLink19.Command = Me.閉じる
        Me.C1CommandLink19.Delimiter = True
        Me.C1CommandLink19.SortOrder = 5
        '
        '閉じる
        '
        Me.閉じる.Name = "閉じる"
        Me.閉じる.ShortcutText = ""
        Me.閉じる.Text = "閉じる"
        '
        '予算
        '
        Me.予算.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink4, Me.C1CommandLink20, Me.C1CommandLink22, Me.C1CommandLink23})
        Me.予算.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.予算.HideNonRecentLinks = False
        Me.予算.Name = "予算"
        Me.予算.ShortcutText = ""
        Me.予算.Text = "予算"
        Me.予算.VisualStyle = C1.Win.C1Command.VisualStyle.Custom
        Me.予算.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2007Blue
        '
        'C1CommandLink4
        '
        Me.C1CommandLink4.Command = Me.予算総括登録
        '
        '予算総括登録
        '
        Me.予算総括登録.Name = "予算総括登録"
        Me.予算総括登録.ShortcutText = ""
        Me.予算総括登録.Text = "予算総括登録"
        '
        'C1CommandLink20
        '
        Me.C1CommandLink20.Command = Me.予算内訳登録
        Me.C1CommandLink20.Delimiter = True
        Me.C1CommandLink20.SortOrder = 1
        '
        '予算内訳登録
        '
        Me.予算内訳登録.Name = "予算内訳登録"
        Me.予算内訳登録.ShortcutText = ""
        Me.予算内訳登録.Text = "予算内訳登録"
        '
        'C1CommandLink22
        '
        Me.C1CommandLink22.Command = Me.入力表作成
        Me.C1CommandLink22.Delimiter = True
        Me.C1CommandLink22.SortOrder = 2
        '
        '入力表作成
        '
        Me.入力表作成.Name = "入力表作成"
        Me.入力表作成.ShortcutText = ""
        Me.入力表作成.Text = "入力表作成"
        '
        'C1CommandLink23
        '
        Me.C1CommandLink23.Command = Me.予算費目集計
        Me.C1CommandLink23.Delimiter = True
        Me.C1CommandLink23.SortOrder = 3
        '
        '予算費目集計
        '
        Me.予算費目集計.Name = "予算費目集計"
        Me.予算費目集計.ShortcutText = ""
        Me.予算費目集計.Text = "予算費目集計"
        '
        '見積
        '
        Me.見積.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink24, Me.C1CommandLink6})
        Me.見積.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.見積.HideNonRecentLinks = False
        Me.見積.Name = "見積"
        Me.見積.ShortcutText = ""
        Me.見積.Text = "見積"
        Me.見積.VisualStyle = C1.Win.C1Command.VisualStyle.Custom
        Me.見積.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2007Blue
        '
        'C1CommandLink24
        '
        Me.C1CommandLink24.Command = Me.見積書作成
        '
        '見積書作成
        '
        Me.見積書作成.Name = "見積書作成"
        Me.見積書作成.ShortcutText = ""
        Me.見積書作成.Text = "見積書作成"
        '
        'C1CommandLink6
        '
        Me.C1CommandLink6.Command = Me.見積内訳登録
        Me.C1CommandLink6.SortOrder = 1
        '
        '見積内訳登録
        '
        Me.見積内訳登録.Name = "見積内訳登録"
        Me.見積内訳登録.ShortcutText = ""
        Me.見積内訳登録.Text = "見積内訳登録"
        '
        '外注管理
        '
        Me.外注管理.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink25, Me.C1CommandLink8, Me.C1CommandLink27, Me.C1CommandLink28, Me.C1CommandLink29})
        Me.外注管理.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.外注管理.HideNonRecentLinks = False
        Me.外注管理.Name = "外注管理"
        Me.外注管理.ShortcutText = ""
        Me.外注管理.Text = "外注管理"
        Me.外注管理.VisualStyle = C1.Win.C1Command.VisualStyle.Custom
        Me.外注管理.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2007Blue
        '
        'C1CommandLink25
        '
        Me.C1CommandLink25.Command = Me.協力業者登録
        '
        '協力業者登録
        '
        Me.協力業者登録.Name = "協力業者登録"
        Me.協力業者登録.ShortcutText = ""
        Me.協力業者登録.Text = "協力業者登録"
        '
        'C1CommandLink8
        '
        Me.C1CommandLink8.Command = Me.外注計画登録
        Me.C1CommandLink8.Delimiter = True
        Me.C1CommandLink8.SortOrder = 1
        '
        '外注計画登録
        '
        Me.外注計画登録.Name = "外注計画登録"
        Me.外注計画登録.ShortcutText = ""
        Me.外注計画登録.Text = "外注計画登録"
        '
        'C1CommandLink27
        '
        Me.C1CommandLink27.Command = Me.締切処理
        Me.C1CommandLink27.Delimiter = True
        Me.C1CommandLink27.SortOrder = 2
        '
        '締切処理
        '
        Me.締切処理.Name = "締切処理"
        Me.締切処理.ShortcutText = ""
        Me.締切処理.Text = "締切処理"
        '
        'C1CommandLink28
        '
        Me.C1CommandLink28.Command = Me.出来高登録
        Me.C1CommandLink28.SortOrder = 3
        '
        '出来高登録
        '
        Me.出来高登録.Name = "出来高登録"
        Me.出来高登録.ShortcutText = ""
        Me.出来高登録.Text = "出来高登録"
        '
        'C1CommandLink29
        '
        Me.C1CommandLink29.Command = Me.注文書番号登録
        Me.C1CommandLink29.Delimiter = True
        Me.C1CommandLink29.SortOrder = 4
        '
        '注文書番号登録
        '
        Me.注文書番号登録.Name = "注文書番号登録"
        Me.注文書番号登録.ShortcutText = ""
        Me.注文書番号登録.Text = "注文書番号登録"
        '
        '出力
        '
        Me.出力.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink30, Me.C1CommandLink10, Me.C1CommandLink31})
        Me.出力.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.出力.HideNonRecentLinks = False
        Me.出力.Name = "出力"
        Me.出力.ShortcutText = ""
        Me.出力.Text = "出力"
        Me.出力.VisualStyle = C1.Win.C1Command.VisualStyle.Custom
        Me.出力.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2007Blue
        '
        'C1CommandLink30
        '
        Me.C1CommandLink30.Command = Me.出力_予算
        '
        '出力_予算
        '
        Me.出力_予算.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink32, Me.C1CommandLink36, Me.C1CommandLink5, Me.C1CommandLink1, Me.C1CommandLink38, Me.C1CommandLink39, Me.C1CommandLink40, Me.C1CommandLink41, Me.C1CommandLink42, Me.C1CommandLink43, Me.C1CommandLink44, Me.C1CommandLink45, Me.C1CommandLink46})
        Me.出力_予算.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.出力_予算.HideNonRecentLinks = False
        Me.出力_予算.Name = "出力_予算"
        Me.出力_予算.ShortcutText = ""
        Me.出力_予算.Text = "予算"
        Me.SystemTheme.SetTheme(Me.出力_予算, "予算管理テーマ")
        Me.出力_予算.VisualStyle = C1.Win.C1Command.VisualStyle.Custom
        Me.出力_予算.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2007Blue
        '
        'C1CommandLink32
        '
        Me.C1CommandLink32.Command = Me.詳細予算内訳印刷
        '
        '詳細予算内訳印刷
        '
        Me.詳細予算内訳印刷.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink35, Me.C1CommandLink47, Me.C1CommandLink48, Me.C1CommandLink49, Me.C1CommandLink50, Me.C1CommandLink51, Me.C1CommandLink52, Me.C1CommandLink53, Me.C1CommandLink54, Me.C1CommandLink55, Me.C1CommandLink56, Me.C1CommandLink57})
        Me.詳細予算内訳印刷.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.詳細予算内訳印刷.HideNonRecentLinks = False
        Me.詳細予算内訳印刷.Name = "詳細予算内訳印刷"
        Me.詳細予算内訳印刷.ShortcutText = ""
        Me.詳細予算内訳印刷.Text = "詳細予算内訳印刷"
        Me.SystemTheme.SetTheme(Me.詳細予算内訳印刷, "予算管理テーマ")
        Me.詳細予算内訳印刷.VisualStyle = C1.Win.C1Command.VisualStyle.Custom
        Me.詳細予算内訳印刷.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2007Blue
        '
        'C1CommandLink35
        '
        Me.C1CommandLink35.Command = Me.全て印刷
        '
        '全て印刷
        '
        Me.全て印刷.Name = "全て印刷"
        Me.全て印刷.ShortcutText = ""
        Me.全て印刷.Text = "全て印刷"
        '
        'C1CommandLink47
        '
        Me.C1CommandLink47.Command = Me.予算総括表
        Me.C1CommandLink47.Delimiter = True
        Me.C1CommandLink47.SortOrder = 1
        '
        '予算総括表
        '
        Me.予算総括表.Name = "予算総括表"
        Me.予算総括表.ShortcutText = ""
        Me.予算総括表.Text = "予算総括表"
        '
        'C1CommandLink48
        '
        Me.C1CommandLink48.Command = Me.材料表
        Me.C1CommandLink48.SortOrder = 2
        '
        '材料表
        '
        Me.材料表.Name = "材料表"
        Me.材料表.ShortcutText = ""
        Me.材料表.Text = "材料表"
        '
        'C1CommandLink49
        '
        Me.C1CommandLink49.Command = Me.現場経費
        Me.C1CommandLink49.SortOrder = 3
        '
        '現場経費
        '
        Me.現場経費.Name = "現場経費"
        Me.現場経費.ShortcutText = ""
        Me.現場経費.Text = "現場経費"
        '
        'C1CommandLink50
        '
        Me.C1CommandLink50.Command = Me.予算大内訳
        Me.C1CommandLink50.SortOrder = 4
        '
        '予算大内訳
        '
        Me.予算大内訳.Name = "予算大内訳"
        Me.予算大内訳.ShortcutText = ""
        Me.予算大内訳.Text = "予算大内訳"
        '
        'C1CommandLink51
        '
        Me.C1CommandLink51.Command = Me.予算内訳書
        Me.C1CommandLink51.SortOrder = 5
        '
        '予算内訳書
        '
        Me.予算内訳書.Name = "予算内訳書"
        Me.予算内訳書.ShortcutText = ""
        Me.予算内訳書.Text = "予算内訳書"
        '
        'C1CommandLink52
        '
        Me.C1CommandLink52.Command = Me.明細内訳書
        Me.C1CommandLink52.SortOrder = 6
        '
        '明細内訳書
        '
        Me.明細内訳書.Name = "明細内訳書"
        Me.明細内訳書.ShortcutText = ""
        Me.明細内訳書.Text = "明細内訳書"
        '
        'C1CommandLink53
        '
        Me.C1CommandLink53.Command = Me.代価表
        Me.C1CommandLink53.SortOrder = 7
        '
        '代価表
        '
        Me.代価表.Name = "代価表"
        Me.代価表.ShortcutText = ""
        Me.代価表.Text = "代価表"
        '
        'C1CommandLink54
        '
        Me.C1CommandLink54.Command = Me.摘要基礎代価表
        Me.C1CommandLink54.Delimiter = True
        Me.C1CommandLink54.SortOrder = 8
        '
        '摘要基礎代価表
        '
        Me.摘要基礎代価表.Name = "摘要基礎代価表"
        Me.摘要基礎代価表.ShortcutText = ""
        Me.摘要基礎代価表.Text = "摘要基礎代価表"
        '
        'C1CommandLink55
        '
        Me.C1CommandLink55.Command = Me.基礎代価一覧表
        Me.C1CommandLink55.SortOrder = 9
        '
        '基礎代価一覧表
        '
        Me.基礎代価一覧表.Name = "基礎代価一覧表"
        Me.基礎代価一覧表.ShortcutText = ""
        Me.基礎代価一覧表.Text = "基礎代価一覧表"
        '
        'C1CommandLink56
        '
        Me.C1CommandLink56.Command = Me.基礎代価詳細内訳書
        Me.C1CommandLink56.SortOrder = 10
        '
        '基礎代価詳細内訳書
        '
        Me.基礎代価詳細内訳書.Name = "基礎代価詳細内訳書"
        Me.基礎代価詳細内訳書.ShortcutText = ""
        Me.基礎代価詳細内訳書.Text = "基礎代価詳細内訳書"
        '
        'C1CommandLink57
        '
        Me.C1CommandLink57.Command = Me.基礎代価簡易内訳書
        Me.C1CommandLink57.SortOrder = 11
        '
        '基礎代価簡易内訳書
        '
        Me.基礎代価簡易内訳書.Name = "基礎代価簡易内訳書"
        Me.基礎代価簡易内訳書.ShortcutText = ""
        Me.基礎代価簡易内訳書.Text = "基礎代価簡易内訳書"
        '
        'C1CommandLink36
        '
        Me.C1CommandLink36.Command = Me.簡易予算内訳印刷
        Me.C1CommandLink36.SortOrder = 1
        '
        '簡易予算内訳印刷
        '
        Me.簡易予算内訳印刷.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink37, Me.C1CommandLink58, Me.C1CommandLink59, Me.C1CommandLink60, Me.C1CommandLink62, Me.C1CommandLink61, Me.C1CommandLink63, Me.C1CommandLink64, Me.C1CommandLink65})
        Me.簡易予算内訳印刷.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.簡易予算内訳印刷.HideNonRecentLinks = False
        Me.簡易予算内訳印刷.Name = "簡易予算内訳印刷"
        Me.簡易予算内訳印刷.ShortcutText = ""
        Me.簡易予算内訳印刷.Text = "簡易予算内訳印刷"
        Me.SystemTheme.SetTheme(Me.簡易予算内訳印刷, "予算管理テーマ")
        Me.簡易予算内訳印刷.VisualStyle = C1.Win.C1Command.VisualStyle.Custom
        Me.簡易予算内訳印刷.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2007Blue
        '
        'C1CommandLink37
        '
        Me.C1CommandLink37.Command = Me.全て印刷_簡易
        '
        '全て印刷_簡易
        '
        Me.全て印刷_簡易.Name = "全て印刷_簡易"
        Me.全て印刷_簡易.ShortcutText = ""
        Me.全て印刷_簡易.Text = "全て印刷"
        '
        'C1CommandLink58
        '
        Me.C1CommandLink58.Command = Me.予算総括表_簡易
        Me.C1CommandLink58.Delimiter = True
        Me.C1CommandLink58.SortOrder = 1
        '
        '予算総括表_簡易
        '
        Me.予算総括表_簡易.Name = "予算総括表_簡易"
        Me.予算総括表_簡易.ShortcutText = ""
        Me.予算総括表_簡易.Text = "予算総括表"
        '
        'C1CommandLink59
        '
        Me.C1CommandLink59.Command = Me.予算書
        Me.C1CommandLink59.SortOrder = 2
        '
        '予算書
        '
        Me.予算書.Name = "予算書"
        Me.予算書.ShortcutText = ""
        Me.予算書.Text = "予算書"
        '
        'C1CommandLink60
        '
        Me.C1CommandLink60.Command = Me.明細書
        Me.C1CommandLink60.SortOrder = 3
        '
        '明細書
        '
        Me.明細書.Name = "明細書"
        Me.明細書.ShortcutText = ""
        Me.明細書.Text = "明細書"
        '
        'C1CommandLink62
        '
        Me.C1CommandLink62.Command = Me.現場経費_簡易
        Me.C1CommandLink62.SortOrder = 4
        '
        '現場経費_簡易
        '
        Me.現場経費_簡易.Name = "現場経費_簡易"
        Me.現場経費_簡易.ShortcutText = ""
        Me.現場経費_簡易.Text = "現場経費"
        '
        'C1CommandLink61
        '
        Me.C1CommandLink61.Command = Me.代価一覧表
        Me.C1CommandLink61.SortOrder = 5
        '
        '代価一覧表
        '
        Me.代価一覧表.Name = "代価一覧表"
        Me.代価一覧表.ShortcutText = ""
        Me.代価一覧表.Text = "代価一覧表"
        '
        'C1CommandLink63
        '
        Me.C1CommandLink63.Command = Me.代価内訳
        Me.C1CommandLink63.SortOrder = 6
        '
        '代価内訳
        '
        Me.代価内訳.Name = "代価内訳"
        Me.代価内訳.ShortcutText = ""
        Me.代価内訳.Text = "代価内訳"
        '
        'C1CommandLink64
        '
        Me.C1CommandLink64.Command = Me.基礎代価一覧表_簡易
        Me.C1CommandLink64.Delimiter = True
        Me.C1CommandLink64.SortOrder = 7
        '
        '基礎代価一覧表_簡易
        '
        Me.基礎代価一覧表_簡易.Name = "基礎代価一覧表_簡易"
        Me.基礎代価一覧表_簡易.ShortcutText = ""
        Me.基礎代価一覧表_簡易.Text = "基礎代価一覧表"
        '
        'C1CommandLink65
        '
        Me.C1CommandLink65.Command = Me.基礎代価内訳
        Me.C1CommandLink65.SortOrder = 8
        '
        '基礎代価内訳
        '
        Me.基礎代価内訳.Name = "基礎代価内訳"
        Me.基礎代価内訳.ShortcutText = ""
        Me.基礎代価内訳.Text = "基礎代価内訳"
        '
        'C1CommandLink5
        '
        Me.C1CommandLink5.Command = Me.入力表
        Me.C1CommandLink5.SortOrder = 2
        '
        '入力表
        '
        Me.入力表.Name = "入力表"
        Me.入力表.ShortcutText = ""
        Me.入力表.Text = "入力表"
        '
        'C1CommandLink1
        '
        Me.C1CommandLink1.Command = Me.入力表_工務課用
        Me.C1CommandLink1.SortOrder = 3
        '
        '入力表_工務課用
        '
        Me.入力表_工務課用.Name = "入力表_工務課用"
        Me.入力表_工務課用.ShortcutText = ""
        Me.入力表_工務課用.Text = "入力表(工務課用)"
        '
        'C1CommandLink38
        '
        Me.C1CommandLink38.Command = Me.明細書一覧_Excel
        Me.C1CommandLink38.Delimiter = True
        Me.C1CommandLink38.SortOrder = 4
        '
        '明細書一覧_Excel
        '
        Me.明細書一覧_Excel.Name = "明細書一覧_Excel"
        Me.明細書一覧_Excel.ShortcutText = ""
        Me.明細書一覧_Excel.Text = "明細書一覧(Excel)"
        '
        'C1CommandLink39
        '
        Me.C1CommandLink39.Command = Me.実行予算_csv_cap21
        Me.C1CommandLink39.SortOrder = 5
        '
        '実行予算_csv_cap21
        '
        Me.実行予算_csv_cap21.Name = "実行予算_csv_cap21"
        Me.実行予算_csv_cap21.ShortcutText = ""
        Me.実行予算_csv_cap21.Text = "実行予算(CSV,CAP21用)"
        '
        'C1CommandLink40
        '
        Me.C1CommandLink40.Command = Me.労働者集計
        Me.C1CommandLink40.Delimiter = True
        Me.C1CommandLink40.SortOrder = 6
        '
        '労働者集計
        '
        Me.労働者集計.Name = "労働者集計"
        Me.労働者集計.ShortcutText = ""
        Me.労働者集計.Text = "労働者集計"
        '
        'C1CommandLink41
        '
        Me.C1CommandLink41.Command = Me.使用材料集計
        Me.C1CommandLink41.SortOrder = 7
        '
        '使用材料集計
        '
        Me.使用材料集計.Name = "使用材料集計"
        Me.使用材料集計.ShortcutText = ""
        Me.使用材料集計.Text = "使用材料集計"
        '
        'C1CommandLink42
        '
        Me.C1CommandLink42.Command = Me.使用機械集計
        Me.C1CommandLink42.SortOrder = 8
        '
        '使用機械集計
        '
        Me.使用機械集計.Name = "使用機械集計"
        Me.使用機械集計.ShortcutText = ""
        Me.使用機械集計.Text = "使用機械集計"
        '
        'C1CommandLink43
        '
        Me.C1CommandLink43.Command = Me.外注項目集計
        Me.C1CommandLink43.SortOrder = 9
        '
        '外注項目集計
        '
        Me.外注項目集計.Name = "外注項目集計"
        Me.外注項目集計.ShortcutText = ""
        Me.外注項目集計.Text = "外注項目集計"
        '
        'C1CommandLink44
        '
        Me.C1CommandLink44.Command = Me.社内機材集計
        Me.C1CommandLink44.SortOrder = 10
        '
        '社内機材集計
        '
        Me.社内機材集計.Name = "社内機材集計"
        Me.社内機材集計.ShortcutText = ""
        Me.社内機材集計.Text = "社内機材集計"
        '
        'C1CommandLink45
        '
        Me.C1CommandLink45.Command = Me.社外機材集計
        Me.C1CommandLink45.SortOrder = 11
        '
        '社外機材集計
        '
        Me.社外機材集計.Name = "社外機材集計"
        Me.社外機材集計.ShortcutText = ""
        Me.社外機材集計.Text = "社外機材集計"
        '
        'C1CommandLink46
        '
        Me.C1CommandLink46.Command = Me.材料集計_Excel
        Me.C1CommandLink46.Delimiter = True
        Me.C1CommandLink46.SortOrder = 12
        '
        '材料集計_Excel
        '
        Me.材料集計_Excel.Name = "材料集計_Excel"
        Me.材料集計_Excel.ShortcutText = ""
        Me.材料集計_Excel.Text = "材料集計(Excel)"
        '
        'C1CommandLink10
        '
        Me.C1CommandLink10.Command = Me.出力_見積
        Me.C1CommandLink10.SortOrder = 1
        '
        '出力_見積
        '
        Me.出力_見積.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink33, Me.C1CommandLink66, Me.C1CommandLink69, Me.C1CommandLink70, Me.C1CommandLink73, Me.C1CommandLink76})
        Me.出力_見積.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.出力_見積.HideNonRecentLinks = False
        Me.出力_見積.Name = "出力_見積"
        Me.出力_見積.ShortcutText = ""
        Me.出力_見積.Text = "見積"
        Me.SystemTheme.SetTheme(Me.出力_見積, "予算管理テーマ")
        Me.出力_見積.VisualStyle = C1.Win.C1Command.VisualStyle.Custom
        Me.出力_見積.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2007Blue
        '
        'C1CommandLink33
        '
        Me.C1CommandLink33.Command = Me.見積表紙
        '
        '見積表紙
        '
        Me.見積表紙.Name = "見積表紙"
        Me.見積表紙.ShortcutText = ""
        Me.見積表紙.Text = "見積表紙"
        '
        'C1CommandLink66
        '
        Me.C1CommandLink66.Command = Me.見積内訳鑑
        Me.C1CommandLink66.SortOrder = 1
        '
        '見積内訳鑑
        '
        Me.見積内訳鑑.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink67, Me.C1CommandLink68})
        Me.見積内訳鑑.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.見積内訳鑑.HideNonRecentLinks = False
        Me.見積内訳鑑.Name = "見積内訳鑑"
        Me.見積内訳鑑.ShortcutText = ""
        Me.見積内訳鑑.Text = "見積内訳鑑"
        Me.SystemTheme.SetTheme(Me.見積内訳鑑, "予算管理テーマ")
        Me.見積内訳鑑.VisualStyle = C1.Win.C1Command.VisualStyle.Custom
        Me.見積内訳鑑.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2007Blue
        '
        'C1CommandLink67
        '
        Me.C1CommandLink67.Command = Me.値引き有
        '
        '値引き有
        '
        Me.値引き有.Name = "値引き有"
        Me.値引き有.ShortcutText = ""
        Me.値引き有.Text = "値引き有"
        '
        'C1CommandLink68
        '
        Me.C1CommandLink68.Command = Me.値引き無
        Me.C1CommandLink68.SortOrder = 1
        '
        '値引き無
        '
        Me.値引き無.Name = "値引き無"
        Me.値引き無.ShortcutText = ""
        Me.値引き無.Text = "値引き無"
        '
        'C1CommandLink69
        '
        Me.C1CommandLink69.Command = Me.見積条件詳細
        Me.C1CommandLink69.SortOrder = 2
        '
        '見積条件詳細
        '
        Me.見積条件詳細.Name = "見積条件詳細"
        Me.見積条件詳細.ShortcutText = ""
        Me.見積条件詳細.Text = "見積条件詳細"
        '
        'C1CommandLink70
        '
        Me.C1CommandLink70.Command = Me.見積内訳
        Me.C1CommandLink70.SortOrder = 3
        '
        '見積内訳
        '
        Me.見積内訳.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink71, Me.C1CommandLink72})
        Me.見積内訳.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.見積内訳.HideNonRecentLinks = False
        Me.見積内訳.Name = "見積内訳"
        Me.見積内訳.ShortcutText = ""
        Me.見積内訳.Text = "見積内訳"
        Me.SystemTheme.SetTheme(Me.見積内訳, "予算管理テーマ")
        Me.見積内訳.VisualStyle = C1.Win.C1Command.VisualStyle.Custom
        Me.見積内訳.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2007Blue
        '
        'C1CommandLink71
        '
        Me.C1CommandLink71.Command = Me.金込
        '
        '金込
        '
        Me.金込.Name = "金込"
        Me.金込.ShortcutText = ""
        Me.金込.Text = "金込"
        '
        'C1CommandLink72
        '
        Me.C1CommandLink72.Command = Me.金抜
        Me.C1CommandLink72.SortOrder = 1
        '
        '金抜
        '
        Me.金抜.Name = "金抜"
        Me.金抜.ShortcutText = ""
        Me.金抜.Text = "金抜"
        '
        'C1CommandLink73
        '
        Me.C1CommandLink73.Command = Me.見積代価_Aのみ
        Me.C1CommandLink73.SortOrder = 4
        '
        '見積代価_Aのみ
        '
        Me.見積代価_Aのみ.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink74, Me.C1CommandLink75})
        Me.見積代価_Aのみ.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.見積代価_Aのみ.HideNonRecentLinks = False
        Me.見積代価_Aのみ.Name = "見積代価_Aのみ"
        Me.見積代価_Aのみ.ShortcutText = ""
        Me.見積代価_Aのみ.Text = "見積代価(Aのみ)"
        Me.SystemTheme.SetTheme(Me.見積代価_Aのみ, "予算管理テーマ")
        Me.見積代価_Aのみ.VisualStyle = C1.Win.C1Command.VisualStyle.Custom
        Me.見積代価_Aのみ.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2007Blue
        '
        'C1CommandLink74
        '
        Me.C1CommandLink74.Command = Me.見積代価_金込
        '
        '見積代価_金込
        '
        Me.見積代価_金込.Name = "見積代価_金込"
        Me.見積代価_金込.ShortcutText = ""
        Me.見積代価_金込.Text = "金込"
        '
        'C1CommandLink75
        '
        Me.C1CommandLink75.Command = Me.見積代価_金抜
        Me.C1CommandLink75.SortOrder = 1
        '
        '見積代価_金抜
        '
        Me.見積代価_金抜.Name = "見積代価_金抜"
        Me.見積代価_金抜.ShortcutText = ""
        Me.見積代価_金抜.Text = "金抜"
        '
        'C1CommandLink76
        '
        Me.C1CommandLink76.Command = Me.代価
        Me.C1CommandLink76.SortOrder = 5
        '
        '代価
        '
        Me.代価.Name = "代価"
        Me.代価.ShortcutText = ""
        Me.代価.Text = "代価"
        '
        'C1CommandLink31
        '
        Me.C1CommandLink31.Command = Me.出力_外注計画
        Me.C1CommandLink31.SortOrder = 2
        '
        '出力_外注計画
        '
        Me.出力_外注計画.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink34, Me.C1CommandLink77, Me.C1CommandLink78, Me.C1CommandLink79, Me.C1CommandLink85, Me.C1CommandLink86, Me.C1CommandLink89, Me.C1CommandLink90})
        Me.出力_外注計画.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.出力_外注計画.HideNonRecentLinks = False
        Me.出力_外注計画.Name = "出力_外注計画"
        Me.出力_外注計画.ShortcutText = ""
        Me.出力_外注計画.Text = "外注計画"
        Me.SystemTheme.SetTheme(Me.出力_外注計画, "予算管理テーマ")
        Me.出力_外注計画.VisualStyle = C1.Win.C1Command.VisualStyle.Custom
        Me.出力_外注計画.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2007Blue
        '
        'C1CommandLink34
        '
        Me.C1CommandLink34.Command = Me.外注計画
        '
        '外注計画
        '
        Me.外注計画.Name = "外注計画"
        Me.外注計画.ShortcutText = ""
        Me.外注計画.Text = "外注計画"
        '
        'C1CommandLink77
        '
        Me.C1CommandLink77.Command = Me.外注計画_Excel
        Me.C1CommandLink77.SortOrder = 1
        '
        '外注計画_Excel
        '
        Me.外注計画_Excel.Name = "外注計画_Excel"
        Me.外注計画_Excel.ShortcutText = ""
        Me.外注計画_Excel.Text = "外注計画(Excel)"
        '
        'C1CommandLink78
        '
        Me.C1CommandLink78.Command = Me.外注計画報告書
        Me.C1CommandLink78.SortOrder = 2
        '
        '外注計画報告書
        '
        Me.外注計画報告書.Name = "外注計画報告書"
        Me.外注計画報告書.ShortcutText = ""
        Me.外注計画報告書.Text = "外注計画報告書"
        '
        'C1CommandLink79
        '
        Me.C1CommandLink79.Command = Me.出来高査定
        Me.C1CommandLink79.SortOrder = 3
        '
        '出来高査定
        '
        Me.出来高査定.Name = "出来高査定"
        Me.出来高査定.ShortcutText = ""
        Me.出来高査定.Text = "出来高査定"
        '
        'C1CommandLink85
        '
        Me.C1CommandLink85.Command = Me.折衝用業者別内訳
        Me.C1CommandLink85.SortOrder = 4
        '
        '折衝用業者別内訳
        '
        Me.折衝用業者別内訳.Name = "折衝用業者別内訳"
        Me.折衝用業者別内訳.ShortcutText = ""
        Me.折衝用業者別内訳.Text = "折衝用業者別内訳"
        '
        'C1CommandLink86
        '
        Me.C1CommandLink86.Command = Me.注文書
        Me.C1CommandLink86.SortOrder = 5
        '
        '注文書
        '
        Me.注文書.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink87, Me.C1CommandLink88})
        Me.注文書.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.注文書.HideNonRecentLinks = False
        Me.注文書.Name = "注文書"
        Me.注文書.ShortcutText = ""
        Me.注文書.Text = "注文書"
        Me.SystemTheme.SetTheme(Me.注文書, "予算管理テーマ")
        Me.注文書.VisualStyle = C1.Win.C1Command.VisualStyle.Custom
        Me.注文書.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2007Blue
        '
        'C1CommandLink87
        '
        Me.C1CommandLink87.Command = Me.注文書_金込
        '
        '注文書_金込
        '
        Me.注文書_金込.Name = "注文書_金込"
        Me.注文書_金込.ShortcutText = ""
        Me.注文書_金込.Text = "金込"
        '
        'C1CommandLink88
        '
        Me.C1CommandLink88.Command = Me.注文書_金抜
        Me.C1CommandLink88.SortOrder = 1
        '
        '注文書_金抜
        '
        Me.注文書_金抜.Name = "注文書_金抜"
        Me.注文書_金抜.ShortcutText = ""
        Me.注文書_金抜.Text = "金抜"
        '
        'C1CommandLink89
        '
        Me.C1CommandLink89.Command = Me.注文内訳書_Excel
        Me.C1CommandLink89.SortOrder = 6
        '
        '注文内訳書_Excel
        '
        Me.注文内訳書_Excel.Name = "注文内訳書_Excel"
        Me.注文内訳書_Excel.ShortcutText = ""
        Me.注文内訳書_Excel.Text = "注文内訳書(Excel)"
        '
        'C1CommandLink90
        '
        Me.C1CommandLink90.Command = Me.注文書明細_CSV
        Me.C1CommandLink90.SortOrder = 7
        '
        '注文書明細_CSV
        '
        Me.注文書明細_CSV.Name = "注文書明細_CSV"
        Me.注文書明細_CSV.ShortcutText = ""
        Me.注文書明細_CSV.Text = "注文書明細(CSV)"
        '
        'マスタ
        '
        Me.マスタ.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.マスタ.HideNonRecentLinks = False
        Me.マスタ.Name = "マスタ"
        Me.マスタ.ShortcutText = ""
        Me.マスタ.Text = "マスタ"
        Me.マスタ.VisualStyle = C1.Win.C1Command.VisualStyle.Custom
        Me.マスタ.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2007Blue
        '
        'ヘルプ
        '
        Me.ヘルプ.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink14, Me.C1CommandLink12})
        Me.ヘルプ.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.ヘルプ.HideNonRecentLinks = False
        Me.ヘルプ.Name = "ヘルプ"
        Me.ヘルプ.ShortcutText = ""
        Me.ヘルプ.Text = "ヘルプ"
        Me.ヘルプ.VisualStyle = C1.Win.C1Command.VisualStyle.Custom
        Me.ヘルプ.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2007Blue
        '
        'C1CommandLink14
        '
        Me.C1CommandLink14.Command = Me.アップデート
        '
        'アップデート
        '
        Me.アップデート.Name = "アップデート"
        Me.アップデート.ShortcutText = ""
        Me.アップデート.Text = "アップデート"
        '
        'C1CommandLink12
        '
        Me.C1CommandLink12.Command = Me.バージョン情報
        Me.C1CommandLink12.SortOrder = 1
        '
        'バージョン情報
        '
        Me.バージョン情報.Name = "バージョン情報"
        Me.バージョン情報.ShortcutText = ""
        Me.バージョン情報.Text = "バージョン情報"
        '
        '代価表作成
        '
        Me.代価表作成.Name = "代価表作成"
        Me.代価表作成.ShortcutText = ""
        Me.代価表作成.Text = "代価表作成"
        '
        '変更内容登録
        '
        Me.変更内容登録.Name = "変更内容登録"
        Me.変更内容登録.ShortcutText = ""
        Me.変更内容登録.Text = "変更内容登録"
        '
        '出来高査定書_完成
        '
        Me.出来高査定書_完成.Name = "出来高査定書_完成"
        Me.出来高査定書_完成.ShortcutText = ""
        Me.出来高査定書_完成.Text = "出来高査定書(完成)"
        '
        '出来形数量査定書_Excel
        '
        Me.出来形数量査定書_Excel.Name = "出来形数量査定書_Excel"
        Me.出来形数量査定書_Excel.ShortcutText = ""
        Me.出来形数量査定書_Excel.Text = "出来形数量査定書(Excel)"
        '
        '出来形数量査定書
        '
        Me.出来形数量査定書.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink83, Me.C1CommandLink84})
        Me.出来形数量査定書.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.出来形数量査定書.HideNonRecentLinks = False
        Me.出来形数量査定書.Name = "出来形数量査定書"
        Me.出来形数量査定書.ShortcutText = ""
        Me.出来形数量査定書.Text = "出来形数量査定書"
        Me.SystemTheme.SetTheme(Me.出来形数量査定書, "予算管理テーマ")
        Me.出来形数量査定書.VisualStyle = C1.Win.C1Command.VisualStyle.Custom
        Me.出来形数量査定書.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2007Blue
        '
        'C1CommandLink83
        '
        Me.C1CommandLink83.Command = Me.中間
        '
        '中間
        '
        Me.中間.Name = "中間"
        Me.中間.ShortcutText = ""
        Me.中間.Text = "中間"
        '
        'C1CommandLink84
        '
        Me.C1CommandLink84.Command = Me.完成
        Me.C1CommandLink84.SortOrder = 1
        '
        '完成
        '
        Me.完成.Name = "完成"
        Me.完成.ShortcutText = ""
        Me.完成.Text = "完成"
        '
        'MainMenu
        '
        Me.MainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MainMenu.CommandHolder = Me.MenuComｍand
        Me.MainMenu.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.C1CommandLink2, Me.BudgetMenu, Me.EstimateMenu, Me.C1CommandLink7, Me.C1CommandLink9, Me.C1CommandLink11, Me.C1CommandLink13})
        Me.MainMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.MainMenu.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Bold)
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Margin = New System.Windows.Forms.Padding(0)
        Me.MainMenu.MaximumSize = New System.Drawing.Size(0, 20)
        Me.MainMenu.MinimumSize = New System.Drawing.Size(0, 20)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(1264, 20)
        Me.SystemTheme.SetTheme(Me.MainMenu, "予算管理テーマ")
        '
        'C1CommandLink2
        '
        Me.C1CommandLink2.Command = Me.ファイル
        '
        'BudgetMenu
        '
        Me.BudgetMenu.Command = Me.予算
        Me.BudgetMenu.SortOrder = 1
        '
        'EstimateMenu
        '
        Me.EstimateMenu.Command = Me.見積
        Me.EstimateMenu.SortOrder = 2
        '
        'C1CommandLink7
        '
        Me.C1CommandLink7.Command = Me.外注管理
        Me.C1CommandLink7.SortOrder = 3
        '
        'C1CommandLink9
        '
        Me.C1CommandLink9.Command = Me.出力
        Me.C1CommandLink9.SortOrder = 4
        '
        'C1CommandLink11
        '
        Me.C1CommandLink11.Command = Me.マスタ
        Me.C1CommandLink11.SortOrder = 5
        '
        'C1CommandLink13
        '
        Me.C1CommandLink13.Command = Me.ヘルプ
        Me.C1CommandLink13.SortOrder = 6
        '
        'SystemTheme
        '
        Me.SystemTheme.Theme = "予算管理テーマ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 12)
        Me.Label2.TabIndex = 42
        Me.SystemTheme.SetTheme(Me.Label2, "(default)")
        '
        'C1TextBox1
        '
        Me.C1TextBox1.AutoSize = False
        Me.C1TextBox1.BackColor = System.Drawing.Color.White
        Me.C1TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1TextBox1.DisabledForeColor = System.Drawing.SystemColors.GrayText
        Me.C1TextBox1.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.C1TextBox1.Location = New System.Drawing.Point(-1523, 87)
        Me.C1TextBox1.Name = "C1TextBox1"
        Me.C1TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.C1TextBox1.TabIndex = 25
        Me.C1TextBox1.Tag = Nothing
        Me.SystemTheme.SetTheme(Me.C1TextBox1, "(default)")
        Me.C1TextBox1.Value = "工事コード"
        Me.C1TextBox1.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.C1TextBox1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'CreateFileDialog
        '
        Me.CreateFileDialog.FileName = "現場データ"
        Me.CreateFileDialog.Filter = "MDFファイル|*.mdf|すべて|*.*"
        Me.CreateFileDialog.InitialDirectory = "D:\"
        Me.CreateFileDialog.OverwritePrompt = False
        '
        'ImportFileDialog
        '
        Me.ImportFileDialog.Filter = "XLSXファイル|*.xlsx|XLSファイル|*.xls|すべて|*.*"
        '
        'SaveFileDialog
        '
        '
        'DataBook
        '
        Me.DataBook.CompatibilityMode = C1.C1Excel.CompatibilityMode.NoLimits
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "EXCELファイル|*.xlsx|すべて|*.*"
        Me.SaveFileDialog1.InitialDirectory = "D:\"
        '
        'ホーム
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1264, 684)
        Me.Controls.Add(Me.HomeSplitContainer)
        Me.Controls.Add(Me.MainMenu)
        Me.Enabled = False
        Me.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Name = "ホーム"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "予算管理システム"
        Me.SystemTheme.SetTheme(Me, "予算管理テーマ")
        CType(Me.HomeSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HomeSplitContainer.ResumeLayout(False)
        Me.TreePanel.ResumeLayout(False)
        CType(Me.HomeTreeView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.右クリックメニュー.ResumeLayout(False)
        CType(Me.MenuComｍand, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SystemTheme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ファイルToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 予算ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 外注ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 出来高ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 見積ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HomeSplitContainer As C1.Win.C1SplitContainer.C1SplitContainer
    Friend WithEvents TreePanel As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents マスタToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ヘルプToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuComｍand As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents ファイル As C1.Win.C1Command.C1CommandMenu
    Friend WithEvents C1CommandLink3 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 新規作成 As C1.Win.C1Command.C1Command
    Friend WithEvents 予算 As C1.Win.C1Command.C1CommandMenu
    Friend WithEvents C1CommandLink4 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 見積 As C1.Win.C1Command.C1CommandMenu
    Friend WithEvents C1CommandLink6 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents MainMenu As C1.Win.C1Command.C1MainMenu
    Friend WithEvents C1CommandLink2 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents BudgetMenu As C1.Win.C1Command.C1CommandLink
    Friend WithEvents EstimateMenu As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 外注管理 As C1.Win.C1Command.C1CommandMenu
    Friend WithEvents C1CommandLink8 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 出力 As C1.Win.C1Command.C1CommandMenu
    Friend WithEvents C1CommandLink10 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents マスタ As C1.Win.C1Command.C1CommandMenu
    Friend WithEvents ヘルプ As C1.Win.C1Command.C1CommandMenu
    Friend WithEvents C1CommandLink14 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink7 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink9 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink11 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink13 As C1.Win.C1Command.C1CommandLink
    Private WithEvents ButtonImageList As ImageList
    Friend WithEvents C1CommandLink15 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 開く As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink16 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 材料表インポート As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink17 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 参照作成command As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink18 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 管理者登録 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink19 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 閉じる As C1.Win.C1Command.C1Command
    Friend WithEvents SystemTheme As C1.Win.C1Themes.C1ThemeController
    Friend WithEvents 予算総括登録 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink20 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 予算内訳登録 As C1.Win.C1Command.C1Command
    Friend WithEvents 代価表作成 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink22 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 入力表作成 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink23 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 予算費目集計 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink24 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 見積書作成 As C1.Win.C1Command.C1Command
    Friend WithEvents 見積内訳登録 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink25 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 協力業者登録 As C1.Win.C1Command.C1Command
    Friend WithEvents 外注計画登録 As C1.Win.C1Command.C1Command
    Friend WithEvents 変更内容登録 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink27 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 締切処理 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink28 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 出来高登録 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink29 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 注文書番号登録 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink30 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink31 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents アップデート As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink12 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents バージョン情報 As C1.Win.C1Command.C1Command
    Friend WithEvents 出力_予算 As C1.Win.C1Command.C1CommandMenu
    Friend WithEvents C1CommandLink32 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 詳細予算内訳印刷 As C1.Win.C1Command.C1CommandMenu
    Friend WithEvents C1CommandLink35 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 全て印刷 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink47 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 予算総括表 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink48 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 材料表 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink36 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 簡易予算内訳印刷 As C1.Win.C1Command.C1CommandMenu
    Friend WithEvents C1CommandLink37 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink38 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 明細書一覧_Excel As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink39 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 実行予算_csv_cap21 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink40 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 労働者集計 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink41 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 使用材料集計 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink42 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 使用機械集計 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink43 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 外注項目集計 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink44 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 社内機材集計 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink45 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 社外機材集計 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink46 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 材料集計_Excel As C1.Win.C1Command.C1Command
    Friend WithEvents 出力_見積 As C1.Win.C1Command.C1CommandMenu
    Friend WithEvents C1CommandLink33 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 出力_外注計画 As C1.Win.C1Command.C1CommandMenu
    Friend WithEvents C1CommandLink34 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents C1CommandLink49 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 現場経費 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink50 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 予算大内訳 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink51 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 予算内訳書 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink52 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 明細内訳書 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink53 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 代価表 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink54 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 摘要基礎代価表 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink55 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 基礎代価一覧表 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink56 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 基礎代価詳細内訳書 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink57 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 基礎代価簡易内訳書 As C1.Win.C1Command.C1Command
    Friend WithEvents 全て印刷_簡易 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink58 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 予算総括表_簡易 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink59 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 予算書 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink60 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 明細書 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink62 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 現場経費_簡易 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink61 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 代価一覧表 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink63 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 代価内訳 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink64 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 基礎代価一覧表_簡易 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink65 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 基礎代価内訳 As C1.Win.C1Command.C1Command
    Friend WithEvents 見積表紙 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink66 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 見積内訳鑑 As C1.Win.C1Command.C1CommandMenu
    Friend WithEvents C1CommandLink67 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 値引き有 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink68 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 値引き無 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink69 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 見積条件詳細 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink70 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 見積内訳 As C1.Win.C1Command.C1CommandMenu
    Friend WithEvents C1CommandLink71 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 金込 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink72 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 金抜 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink73 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 見積代価_Aのみ As C1.Win.C1Command.C1CommandMenu
    Friend WithEvents C1CommandLink74 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 見積代価_金込 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink75 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 見積代価_金抜 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink76 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 代価 As C1.Win.C1Command.C1Command
    Friend WithEvents 外注計画 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink77 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 外注計画_Excel As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink78 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 外注計画報告書 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink79 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 出来高査定チェック As C1.Win.C1Command.C1Command
    Friend WithEvents 出来高査定書_完成 As C1.Win.C1Command.C1Command
    Friend WithEvents 出来形数量査定書 As C1.Win.C1Command.C1CommandMenu
    Friend WithEvents C1CommandLink83 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 中間 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink84 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 完成 As C1.Win.C1Command.C1Command
    Friend WithEvents 出来形数量査定書_Excel As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink85 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 折衝用業者別内訳 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink86 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 注文書 As C1.Win.C1Command.C1CommandMenu
    Friend WithEvents C1CommandLink87 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 注文書_金込 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink88 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 注文書_金抜 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink89 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 注文内訳書_Excel As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink90 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 注文書明細_CSV As C1.Win.C1Command.C1Command
    Friend WithEvents HomeTreeView As C1.Win.TreeView.C1TreeView
    Friend WithEvents CreateFileDialog As SaveFileDialog
    Friend WithEvents Label2 As Label
    Friend WithEvents C1TextBox1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents FormPanel As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents 出来高査定 As C1.Win.C1Command.C1Command
    Friend WithEvents ImportFileDialog As OpenFileDialog
    Friend WithEvents C1CommandLink5 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 入力表 As C1.Win.C1Command.C1Command
    Friend WithEvents C1CommandLink1 As C1.Win.C1Command.C1CommandLink
    Friend WithEvents 入力表_工務課用 As C1.Win.C1Command.C1Command

    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents DataBook As C1.C1Excel.C1XLBook

    Friend WithEvents C1XLBook1 As C1.C1Excel.C1XLBook
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents 右クリックメニュー As ContextMenuStrip
    Friend WithEvents ReferenceMode As ToolStripMenuItem
End Class
