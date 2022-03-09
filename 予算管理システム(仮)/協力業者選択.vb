Imports System.Data.SqlClient
Imports System.Deployment.Application
Imports System.IO.DirectoryInfo
Imports System.ComponentModel
Imports System.Deployment.Application.ApplicationDeployment
Imports System.Windows.Forms.Form
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Command


Public Class 協力業者選択
    Public SelectVendorName As New List(Of String)
    Public SelectVendorCode As New List(Of Integer)
    Public SelectVendorcount As Integer = 0
    Public ParentFormName As String
    Private Sub 協力業者選択_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            ホーム.Sql.CommandText = "SELECT count(outsrcr_code) FROM outsourcers"
            Dim Outsrcrcount As Integer = ホーム.Sql.ExecuteScalar

            ホーム.Sql.CommandText = "SELECT * FROM outsourcers"
            Dim datacount As Integer = 1
            Dim Coopreader As SqlDataReader = ホーム.Sql.ExecuteReader
            While Coopreader.Read
                Me.CoopVendorList.Rows.Add()
                CoopVendorList(datacount, 0) = Coopreader.Item("outsrcr_id")
                CoopVendorList(datacount, 2) = Coopreader.Item("outsrcr_code")
                CoopVendorList(datacount, 3) = Coopreader.Item("outsrcr_name")
                CoopVendorList(datacount, 4) = Coopreader.Item("outsrcr_term_s")
                CoopVendorList(datacount, 5) = Coopreader.Item("outsrcr_term_e")
                Dim ordr As String = Coopreader.Item("ordrfrm")
                If ordr = 11 Then
                    CoopVendorList(datacount, 6) = "工務課発注"
                ElseIf ordr = 12 Then
                    CoopVendorList(datacount, 6) = "購買発注"
                End If
                Dim ecn As String = Coopreader.Item("e_cntrct")
                If ecn = "true" Then
                    CoopVendorList.SetCellCheck(datacount, 7, CheckEnum.Checked)
                Else
                    CoopVendorList.SetCellCheck(datacount, 7, CheckEnum.Unchecked)
                End If

                datacount += 1

            End While
            Coopreader.Close()

            If ParentFormName = "注文書" OrElse ParentFormName = "注文書金抜" OrElse ParentFormName = "注文書折衝" OrElse ParentFormName = "注文書Excel" Then
                CoopVendorList.Cols(1).Width = 0
                CoopVendorList.Cols(3).Width = 390
                VendorSelect.Visible = False
            End If

            ホーム.Modified = "false"

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub C1FlexGrid1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles VendorSelect.MouseLeave
        VendorSelect.ImageIndex = 0
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles VendorSelect.MouseEnter
        VendorSelect.Cursor = Cursors.Hand
        VendorSelect.ImageIndex = 1
    End Sub

    Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs) Handles VendorSelect.MouseDown
        VendorSelect.ImageIndex = 2
    End Sub

    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs) Handles Entry.MouseLeave
        Entry.ImageIndex = 6
    End Sub

    Private Sub Button4_MouseEnter(sender As Object, e As EventArgs) Handles Entry.MouseEnter
        Entry.Cursor = Cursors.Hand
        Entry.ImageIndex = 7
    End Sub

    Private Sub Button4_MouseDown(sender As Object, e As MouseEventArgs) Handles Entry.MouseDown
        Entry.ImageIndex = 8
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles VendorSelect.Click
        Try
            If ParentFormName = "外注計画" Then
                Dim RowIndex As Integer = CoopVendorList.Rows.Count - 1
                Dim datacount As Integer = -1
                SelectVendorName = New List(Of String) From {Nothing, Nothing, Nothing, Nothing, Nothing}
                SelectVendorCode = New List(Of Integer) From {Nothing, Nothing, Nothing, Nothing, Nothing}
                SelectVendorcount = 0
                For Vendorloop As Integer = 1 To RowIndex
                    Dim VendorCheck As CellRange = CoopVendorList.GetCellRange(Vendorloop, 1)
                    Dim C As CellRange = CoopVendorList.GetCellRange(Vendorloop, 2)
                    Dim Code As Integer = C.Data
                    Dim N As CellRange = CoopVendorList.GetCellRange(Vendorloop, 3)
                    Dim Name As String = N.Data

                    If VendorCheck.Data = True Then
                        'SelectVendorCode(datacount) = Code
                        datacount += 1
                        If datacount >= 5 Then
                            MsgBox("一度の出力で選択できるのは５社までです。", MsgBoxStyle.Exclamation, "協力業者選択")
                            Exit Sub
                        End If
                        SelectVendorName(datacount) = Name
                        SelectVendorCode(datacount) = Code
                        SelectVendorcount += 1
                    End If

                Next
                '値がTrueの場合、変数に帳票名を代入する
                ホーム.ReportName = "外注計画"
                'レポートのデザインが格納されているファイルのパスを変数に代入する
                'ホーム.ReportPath = Application.StartupPath & "\予算管理システムレポート.flxr"
                ホーム.Reportpath = "C:\Users\217003\source\repos\MinaAjiki\YosankanriSys\予算管理システム(仮)\予算管理システムレポート.flxr"
                レポート.Show()

            End If

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try

    End Sub

    Private Sub CoopVendorList_CellChanged(sender As Object, e As RowColEventArgs) Handles CoopVendorList.AfterEdit

    End Sub

    Private Sub Entry_Click(sender As Object, e As EventArgs) Handles Entry.Click
        Try
            Me.ImeMode = ImeMode.On
            Dim CancelClick As String = ""

            Dim CancelClickLoad As New CancelClick(Me)
            CancelClick = CancelClickLoad.ModifyCheck

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub CoopVendorList_DoubleClick(sender As Object, e As EventArgs) Handles CoopVendorList.DoubleClick
        Try
            If ParentFormName = "注文書" OrElse ParentFormName = "注文書金抜" OrElse ParentFormName = "注文書折衝" OrElse ParentFormName = "注文書Excel" Then
                Dim RowIndex As Integer = CoopVendorList.Selection.TopRow
                SelectVendorName = New List(Of String) From {Nothing}
                SelectVendorCode = New List(Of Integer) From {Nothing}
                Dim n As CellRange = CoopVendorList.GetCellRange(RowIndex, 3)
                Dim c As CellRange = CoopVendorList.GetCellRange(RowIndex, 2)
                SelectVendorName(0) = n.Data
                SelectVendorCode(0) = c.Data
                If ParentFormName = "注文書" Then
                    ホーム.ReportName = "注文書"
                ElseIf ParentFormName = "注文書金抜" Then
                    ホーム.ReportName = "注文書金抜"
                ElseIf ParentFormName = "注文書折衝" Then
                    ホーム.ReportName = "注文書折衝"
                ElseIf ParentFormName = "注文書Excel" Then
                    ホーム.ReportName = "注文書Excel"
                    SaveFileDialog1.ShowDialog()
                End If
                'レポートのデザインが格納されているファイルのパスを変数に代入する
                'ホーム.ReportPath = Application.StartupPath & "\予算管理システムレポート.flxr"
                ホーム.Reportpath = "C:\Users\217003\source\repos\MinaAjiki\YosankanriSys\予算管理システム(仮)\予算管理システムレポート.flxr"
                レポート.Show()

            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try

    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As CancelEventArgs) Handles SaveFileDialog1.FileOk
        Dim SavePath As String = SaveFileDialog1.FileName
        Dim ReportLoad As String = ""
        Dim ExportXLoadRead As New Export注文書内訳(SavePath, SelectVendorCode(0))
        ReportLoad = ExportXLoadRead.ExportLoad
        'メッセージを表示する
        MsgBox("エクスポート完了", MsgBoxStyle.OkOnly, "エクスポート")
    End Sub
End Class