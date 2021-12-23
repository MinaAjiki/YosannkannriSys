Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports System.Data.SqlClient

Public Class 管理者マスタ一覧
    Public RowCount As Integer = 0
    Private Sub 管理者マスタ一覧_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            AdminList.Rows(0).Height = 20

            ホーム.SystemSql.CommandText = "SELECT COUNT(admn_no) FROM administrators"
            Dim AdminCount As Integer = ホーム.SystemSql.ExecuteScalar

            ホーム.SystemSql.CommandText = "SELECT admn_no FROM administrators"
            Dim AdminReader As SqlDataReader = ホーム.SystemSql.ExecuteReader

            Dim datacount As Integer = 1
            While AdminReader.Read
                Me.AdminList.Rows.Add()
                AdminList(datacount, 1) = AdminReader.Item("admn_no")
                ホーム.CAP21CommandText.CommandText = "SELECT NAME FROM M_TANT WHERE NON_SEARCH=0 AND TANTO_KB=0 AND CODE =" & AdminList(datacount, 1)
                AdminList(datacount, 2) = ホーム.CAP21CommandText.ExecuteScalar
                datacount += 1
            End While
            AdminReader.Close()

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

    Private Sub AdminList_AfterEdit(sender As Object, e As RowColEventArgs) Handles AdminList.AfterEdit
        Try
            If AdminList(e.Row, 1) <> Nothing Then
                ホーム.CAP21CommandText.CommandText = "SELECT NAME FROM M_TANT WHERE NON_SEARCH=0 AND TANTO_KB=0 AND CODE =" & AdminList(e.Row, 1)
                AdminList(e.Row, 2) = ホーム.CAP21CommandText.ExecuteScalar
                If AdminList(e.Row, 2) = Nothing Then
                    MsgBox("登録できない番号です。", MsgBoxStyle.OkOnly, "エラー")
                    AdminList(e.Row, 1) = Nothing
                End If
            End If

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Entry_Click(sender As Object, e As EventArgs) Handles Entry.Click
        Try
            Dim AdminCount As Integer = AdminList.Rows.Count - 2
            For Adminloop As Integer = 1 To AdminCount
                Dim AdminNo As CellRange = AdminList.GetCellRange(Adminloop, 1)
                Dim AdminDflag As CellRange = AdminList.GetCellRange(Adminloop, 3)
                If AdminDflag.Data = True Then
                    If MsgBox("削除される項目があります。このまま登録しますか？", MsgBoxStyle.OkCancel, "確認") = MsgBoxResult.Cancel Then
                        Exit Sub
                    End If
                End If
                If AdminList(Adminloop, 1) <> Nothing Then
                    ホーム.SystemSql.Parameters.Clear()
                    ホーム.SystemSql.CommandText = "Select count(admn_no) from  administrators where admn_no = " & AdminNo.Data
                    Dim AdminNoCount As Integer = ホーム.SystemSql.ExecuteScalar
                    If AdminNoCount = 0 Then
                        ホーム.SystemSql.CommandText = ""
                        ホーム.SystemSql.Parameters.Clear()
                        ホーム.SystemSql.CommandText = "INSERT INTO administrators (admn_no) VALUES (@admn_no)"
                        ホーム.SystemSql.Parameters.Add(New SqlParameter("@admn_no", SqlDbType.NVarChar))
                        ホーム.SystemSql.Parameters("@admn_no").Value = AdminNo.Data
                        ホーム.SystemSql.ExecuteNonQuery()
                    End If

                    If AdminDflag.Data = True Then
                        ホーム.SystemSql.Parameters.Clear()
                        ホーム.SystemSql.CommandText = "DELETE FROM Administrators WHERE admn_no=" & AdminNo.Data
                        ホーム.SystemSql.ExecuteNonQuery()
                    End If
                End If
            Next
            Me.Close()
            MsgBox("登録完了", MsgBoxStyle.OkOnly, "管理者マスタ一覧")

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub
End Class