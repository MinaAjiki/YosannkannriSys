Imports C1.Win.C1FlexGrid
Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class 出来高査定チェックフォーム
    Public VN As Integer
    Public ParentFormName As String
    Private Sub Cancel_MouseLeave(sender As Object, e As EventArgs) Handles Cancel.MouseLeave
        Cancel.ImageIndex = 6
    End Sub

    Private Sub Cancel_MouseEnter(sender As Object, e As EventArgs) Handles Cancel.MouseEnter
        Cancel.Cursor = Cursors.Hand
        Cancel.ImageIndex = 7
    End Sub

    Private Sub Cancel_MouseDown(sender As Object, e As MouseEventArgs) Handles Cancel.MouseDown
        Cancel.ImageIndex = 8
    End Sub
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
    Private Sub 出来高査定チェックフォーム_Load(sender As Object, e As EventArgs) Handles Me.Load
        VendorList.Focus()
        DetailsList.Visible = False

        Dim dt As DataTable
        dt = New DataTable
        dt.Columns.Add("ID", GetType(System.Int32))
        dt.Columns.Add("Code", GetType(System.Int32))
        dt.Columns.Add("Name", GetType(System.String))
        Dim id As Int32
        Dim code As Int32
        Dim name As String

        ホーム.Sql.CommandText = "SELECT * FROM outsourcers"
        Dim Coopreader As SqlDataReader = ホーム.Sql.ExecuteReader
        While Coopreader.Read
            id = Coopreader("outsrcr_id")
            code = Coopreader("outsrcr_code")
            name = Coopreader("outsrcr_name")
            dt.Rows.Add(id, code, name)
        End While
        Coopreader.Close()

        VendorList.TextDetached = True
        VendorList.ItemsDataSource = dt.DefaultView
        VendorList.ItemsDisplayMember = "Name"
        VendorList.ItemsValueMember = "Code"
        VendorList.ItemsImageMember = "ID"
        VendorList.ItemMode = C1.Win.C1Input.ComboItemMode.HtmlPattern
        VendorList.HtmlPattern = "<table><tr><td width=30>{Code}</td><td width=270>{Name}</td></tr></table>"
        VendorList.SelectedIndex = -1
        VendorList.Text = "協力業者を選択"
        VendorNo.Text = Nothing
    End Sub

    Private Sub VendorList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles VendorList.SelectedIndexChanged
        DetailsList.Rows.Count = 1
        DetailsList.Clear(ClearFlags.Content)
        DetailsList.Visible = True
        DetailsList(0, 1) = "工種ｺｰﾄﾞ"
        DetailsList(0, 2) = "工種名"
        DetailsList(0, 3) = "発注金額"
        DetailsList(0, 4) = "出来高"
        DetailsList(0, 5) = "残高"

        If VendorList.SelectedIndex >= 0 Then
            VendorNo.Text = VendorList.SelectedItem
        End If

        ホーム.Sql.CommandText = "SELECT outsrcr_id FROM outsourcers WHERE outsrcr_code = " & VendorNo.Text
        Dim VendorID As Integer = ホーム.Sql.ExecuteScalar
        Dim Datacount As Integer = 1
        ホーム.Sql.CommandText = "SELECT * FROM Production_Check WHERE outsrcr_id = " & VendorID & " AND outsrc_no = (SELECT MAX(outsrc_no) FROM Production_Check) ORDER BY s_worktype_code ASC"
        Dim PCReader As SqlDataReader = ホーム.Sql.ExecuteReader
        While PCReader.Read
            DetailsList.Rows.Add()
            DetailsList(Datacount, 1) = PCReader.Item("s_worktype_code")
            DetailsList(Datacount, 2) = PCReader.Item("s_wrktyp_name")
            DetailsList(Datacount, 3) = PCReader.Item("outsrcng_sum")
            DetailsList(Datacount, 4) = PCReader.Item("production_sum")
            DetailsList(Datacount, 5) = (DetailsList(Datacount, 3)) - (DetailsList(Datacount, 4))
            Datacount += 1
        End While
        PCReader.Close()
        While DetailsList.Rows.Count < 19
            DetailsList.Rows.Add()
        End While

    End Sub

    Private Sub Asses_Click(sender As Object, e As EventArgs) Handles Asses.Click
        Try

            '値がTrueの場合、変数に帳票名を代入する
            ホーム.ReportName = "出来高査定書"
            ParentFormName = "出来高査定書"
            'レポートのデザインが格納されているファイルのパスを変数に代入する
            'ReportPath = Application.StartupPath & "\予算管理システムレポート.flxr"
            'ホーム.Reportpath = "C:\Users\217003\source\repos\MinaAjiki\YosankanriSys\予算管理システム(仮)\予算管理システムレポート.flxr"
            レポート.Show()

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub AssesComp_Click(sender As Object, e As EventArgs) Handles AssesComp.Click
        Try

            '値がTrueの場合、変数に帳票名を代入する
            ホーム.ReportName = "出来高査定書(完成)"
            ParentFormName = "出来高査定書(完成)"
            'レポートのデザインが格納されているファイルのパスを変数に代入する
            'ReportPath = Application.StartupPath & "\予算管理システムレポート.flxr"
            'ホーム.Reportpath = "C:\Users\217003\source\repos\MinaAjiki\YosankanriSys\予算管理システム(仮)\予算管理システムレポート.flxr"
            レポート.Show()

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub QAsses_Click(sender As Object, e As EventArgs) Handles QAsses.Click
        Try

            '値がTrueの場合、変数に帳票名を代入する
            ホーム.ReportName = "出来形数量査定書(中間)"
            ParentFormName = "出来形数量査定書(中間)"
            'レポートのデザインが格納されているファイルのパスを変数に代入する
            'ReportPath = Application.StartupPath & "\予算管理システムレポート.flxr"
            'ホーム.Reportpath = "C:\Users\217003\source\repos\MinaAjiki\YosankanriSys\予算管理システム(仮)\予算管理システムレポート.flxr"
            レポート.Show()

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub QAssesComp_Click(sender As Object, e As EventArgs) Handles QAssesComp.Click
        Try

            '値がTrueの場合、変数に帳票名を代入する
            ホーム.ReportName = "出来形数量査定書(完成)"
            ParentFormName = "出来形数量査定書(完成)"
            'レポートのデザインが格納されているファイルのパスを変数に代入する
            'ReportPath = Application.StartupPath & "\予算管理システムレポート.flxr"
            'ホーム.Reportpath = "C:\Users\217003\source\repos\MinaAjiki\YosankanriSys\予算管理システム(仮)\予算管理システムレポート.flxr"
            レポート.Show()

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub QAssesEx_Click(sender As Object, e As EventArgs) Handles QAssesEx.Click
        Try
            If VendorNo.Text = Nothing Then
                MsgBox("出力する業者を選択してください。", MsgBoxStyle.OkOnly, "エラー")
                Exit Sub
            End If
            VN = VendorNo.Text
            SaveFileDialog1.ShowDialog()
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
        End Try
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As CancelEventArgs) Handles SaveFileDialog1.FileOk
        '保存するファイル名を変数に代入する
        Dim SavePath As String = SaveFileDialog1.FileName
        Dim ReportLoad As String = ""
        Dim ExportXLoadRead As New Export出来高(SavePath, VN)
        ReportLoad = ExportXLoadRead.ExportLoad
        'メッセージを表示する
        MsgBox("エクスポート完了", MsgBoxStyle.OkOnly, "エクスポート")
    End Sub
End Class