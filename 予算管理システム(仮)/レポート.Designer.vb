<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class レポート
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(レポート))
        Me.C1FlexReport1 = New C1.Win.FlexReport.C1FlexReport()
        Me.C1FlexViewer1 = New C1.Win.FlexViewer.C1FlexViewer()
        CType(Me.C1FlexViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1FlexReport1
        '
        Me.C1FlexReport1.ReportDefinition = resources.GetString("C1FlexReport1.ReportDefinition")
        Me.C1FlexReport1.ReportName = "出来形数量査定書(中間)"
        '
        'C1FlexViewer1
        '
        Me.C1FlexViewer1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.C1FlexViewer1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.C1FlexViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1FlexViewer1.Location = New System.Drawing.Point(0, 0)
        Me.C1FlexViewer1.Name = "C1FlexViewer1"
        Me.C1FlexViewer1.Size = New System.Drawing.Size(1184, 661)
        Me.C1FlexViewer1.TabIndex = 0
        '
        'レポート
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 661)
        Me.Controls.Add(Me.C1FlexViewer1)
        Me.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "レポート"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "レポート"
        CType(Me.C1FlexViewer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents C1FlexReport1 As C1.Win.FlexReport.C1FlexReport
    Friend WithEvents C1FlexViewer1 As C1.Win.FlexViewer.C1FlexViewer
End Class
