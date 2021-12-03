Imports C1.Win.C1FlexGrid
Imports System.Windows.Forms.Form
Imports C1.Win.C1Command
Imports System.Data.SqlClient
Public Class 費用マスタ一覧
    Public ParentFormName As String
    Public CostClassCode As Integer
    Public CostClassName As String
    Private Sub 費用マスタ一覧_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MasterContentsList.SetCellImage(1, 9, Image.FromFile(Application.StartupPath & "\Edit_source.png"))

            ホーム.Sql.CommandText = "SELECT Count(*) FROM cost_masters WHERE cstclss_code=" & CostClassCode
            Dim CostMasterCount As Integer = ホーム.Sql.ExecuteScalar

            TableName.Text = CostClassName

            MasterContentsList.Rows.Count = CostMasterCount + 1

            Dim RowCount As Integer = 0
            ホーム.Sql.CommandText = "SELECT * FROM cost_masters WHERE cstclss_code=" & CostClassCode & " ORDER BY cstmstr_seq ASC"
            Dim CostMasterReader As SqlDataReader = ホーム.Sql.ExecuteReader
            While CostMasterReader.Read
                RowCount += 1
                MasterContentsList(RowCount, 1) = CostMasterReader.Item("cstmstr_id")
                MasterContentsList(RowCount, 2) = CostMasterReader.Item("cstmstr_seq")
                MasterContentsList(RowCount, 3) = CostMasterReader.Item("cstmstr_category")
                MasterContentsList(RowCount, 4) = CostMasterReader.Item("cstmstr_code")
                MasterContentsList(RowCount, 5) = CostMasterReader.Item("cstmstr_name")
                MasterContentsList(RowCount, 6) = CostMasterReader.Item("cstmstr_spec")
                MasterContentsList(RowCount, 7) = CostMasterReader.Item("cstmstr_unit")
                MasterContentsList(RowCount, 8) = CostMasterReader.Item("cstmstr_costea")
            End While
            CostMasterReader.Close()

            If ParentFormName = "明細書" Then
                MasterContentsList.Cols(9).Visible = False
                MasterContentsList.Cols(10).Visible = False
                MasterContentsList.AllowEditing = False
                Entry.Visible = False
            End If

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try

    End Sub
    Private Sub Entry_MouseDown(sender As Object, e As MouseEventArgs) Handles Entry.MouseDown
        Entry.ImageIndex = 5
    End Sub

    Private Sub Entry_MouseEnter(sender As Object, e As EventArgs) Handles Entry.MouseEnter
        Entry.Cursor = Cursors.Hand
        Entry.ImageIndex = 4
    End Sub

    Private Sub Entry_MouseLeave(sender As Object, e As EventArgs) Handles Entry.MouseLeave
        Entry.ImageIndex = 3
    End Sub

    Private Sub 管理者マスタ一覧_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ホーム.Enabled = True
    End Sub

    Private Sub Cancel_MouseDown(sender As Object, e As MouseEventArgs) Handles Cancel.MouseDown
        Cancel.ImageIndex = 8
    End Sub

    Private Sub Cancel_MouseEnter(sender As Object, e As EventArgs) Handles Cancel.MouseEnter
        Cancel.Cursor = Cursors.Hand
        Cancel.ImageIndex = 7
    End Sub

    Private Sub Cancel_MouseLeave(sender As Object, e As EventArgs) Handles Cancel.MouseLeave
        Cancel.ImageIndex = 6
    End Sub

    Private Sub Cancel_MouseUp(sender As Object, e As MouseEventArgs) Handles Cancel.MouseUp
        Cancel.ImageIndex = 6
    End Sub

    Private Sub Entry_MouseUp(sender As Object, e As MouseEventArgs) Handles Entry.MouseUp
        Entry.ImageIndex = 3
    End Sub
    'Private Sub Search_MouseEnter(sender As Object, e As EventArgs)
    '    Search.Cursor = Cursors.Hand
    '    Search.ImageIndex = 1
    'End Sub

    'Private Sub Search_MouseDown(sender As Object, e As MouseEventArgs)
    '    Search.ImageIndex = 2
    'End Sub

    'Private Sub Search_MouseLeave(sender As Object, e As EventArgs)
    '    Search.ImageIndex = 0
    'End Sub

    'Private Sub Search_MouseUp(sender As Object, e As MouseEventArgs)
    '    Search.ImageIndex = 0
    'End Sub

    Private Sub SearchName_Load(sender As Object, e As EventArgs) Handles SearchName.Load
        SearchName.SetC1FlexGridSearchPanel(MasterContentsList, SearchName)
    End Sub

    Private Sub MasterContentsList_DoubleClick(sender As Object, e As EventArgs) Handles MasterContentsList.DoubleClick
        Dim Row As Integer = MasterContentsList.Selection.TopRow

        If ParentFormName = "明細書" Then
            明細書入力.DetailsList(明細書入力.SelectRow, 9) = MasterContentsList(Row, 1)
            明細書入力.DetailsList(明細書入力.SelectRow, 8) = CostClassCode
            明細書入力.DetailsList(明細書入力.SelectRow, 4) = MasterContentsList(Row, 5)
            明細書入力.DetailsList(明細書入力.SelectRow + 1, 4) = MasterContentsList(Row, 6)
            明細書入力.DetailsList(明細書入力.SelectRow + 2, 5) = MasterContentsList(Row, 7)
            明細書入力.DetailsList(明細書入力.SelectRow + 1, 6) = MasterContentsList(Row, 8)
            If IsNothing(明細書入力.DetailsList(明細書入力.SelectRow, 6)) = False Then
                明細書入力.DetailsList(明細書入力.SelectRow + 2, 6) = Math.Round((明細書入力.DetailsList(明細書入力.SelectRow, 6) * MasterContentsList(Row, 8)), 0, MidpointRounding.AwayFromZero)
            End If

        End If

        Me.Close()

    End Sub

End Class