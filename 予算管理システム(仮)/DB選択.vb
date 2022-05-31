Imports System.Data.SqlClient
Imports System.Deployment.Application
Imports System.IO.DirectoryInfo
Imports System.ComponentModel
Imports System.Deployment.Application.ApplicationDeployment
Imports System.Windows.Forms.Form
Imports C1.Win.C1FlexGrid
Public Class DB選択

    Private Sub DB選択_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            FileList.Rows(0).Height = 20

            Dim DataCount As Integer = 1
            ホーム.SystemMdf.Parameters.Clear()
            ホーム.SystemMdf.CommandText = ""
            ホーム.SystemMdf.CommandText = "SELECT TOP 5 * FROM userfiles ORDER BY filedate DESC"
            Dim FileReader As SqlDataReader = ホーム.SystemMdf.ExecuteReader
            While FileReader.Read
                FileList(DataCount, 1) = FileReader.Item("filename")
                FileList(DataCount, 2) = FileReader.Item("filepath")
                DataCount += 1
            End While
            FileReader.Close()
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub Open_MouseEnter(sender As Object, e As EventArgs) Handles Open.MouseEnter
        Open.Cursor = Cursors.Hand
        Open.ImageIndex = 1
    End Sub

    Private Sub Open_MouseDown(sender As Object, e As MouseEventArgs) Handles Open.MouseDown
        Open.ImageIndex = 2
    End Sub

    Private Sub OtherFile_MouseEnter(sender As Object, e As EventArgs) Handles OtherFile.MouseEnter
        OtherFile.Cursor = Cursors.Hand
        OtherFile.ImageIndex = 1
    End Sub

    Private Sub OtherFile_MouseDown(sender As Object, e As MouseEventArgs) Handles OtherFile.MouseDown
        OtherFile.ImageIndex = 2
    End Sub

    Private Sub Open_MouseLeave(sender As Object, e As EventArgs) Handles Open.MouseLeave
        Open.ImageIndex = 0
    End Sub

    Private Sub Open_MouseUp(sender As Object, e As MouseEventArgs) Handles Open.MouseUp
        Open.ImageIndex = 0
    End Sub

    Private Sub OtherFile_MouseLeave(sender As Object, e As EventArgs) Handles OtherFile.MouseLeave
        OtherFile.ImageIndex = 0
    End Sub

    Private Sub OtherFile_MouseUp(sender As Object, e As MouseEventArgs) Handles OtherFile.MouseUp
        OtherFile.ImageIndex = 0
    End Sub

    Private Sub OtherFile_Click(sender As Object, e As EventArgs) Handles OtherFile.Click
        OtherFileOpenDialog.ShowDialog()
    End Sub

    Private Sub OtherFileOpenDialog_FileOk(sender As Object, e As CancelEventArgs) Handles OtherFileOpenDialog.FileOk
        Try
            Dim OpenFileName As String = IO.Path.GetFileName(OtherFileOpenDialog.FileName)
            Dim OpenFilePath As String = IO.Path.GetDirectoryName(OtherFileOpenDialog.FileName)

            If Not OpenFilePath.Last = "\" Then
                OpenFilePath += "\"
            End If

            Cursor.Current = Cursors.WaitCursor

            If OpenFileName.Contains(".mdf") = False Then
                MsgBox("mdfファイルを選択してください。", MsgBoxStyle.Exclamation, "エラー")
                Cursor.Current = Cursors.Default
                Exit Sub

            Else

                ホーム.SystemMdf.CommandText = ""
                ホーム.SystemMdf.Parameters.Clear()

                ホーム.SystemMdf.CommandText = "SELECT Count(*) FROM userfiles WHERE filename=@filename AND filepath=@filepath"
                ホーム.SystemMdf.Parameters.Add(New SqlParameter("@filename", SqlDbType.NVarChar))
                ホーム.SystemMdf.Parameters.Add(New SqlParameter("@filepath", SqlDbType.NVarChar))
                ホーム.SystemMdf.Parameters("@filename").Value = OpenFileName
                ホーム.SystemMdf.Parameters("@filepath").Value = OpenFilePath
                Dim Filecount As Integer = ホーム.SystemMdf.ExecuteScalar

                If Filecount >= 1 Then
                    ホーム.SystemMdf.CommandText = "UPDATE userfiles SET filedate='" & Now & "' WHERE filename=@filename AND filepath=@filepath"
                    ホーム.SystemMdf.ExecuteNonQuery()
                Else
                    ホーム.SystemMdf.CommandText = "INSERT INTO userfiles (filename,filepath,filedate) VALUES (@filename,@filepath,@filedate)"
                    ホーム.SystemMdf.Parameters.Add(New SqlParameter("@filedate", SqlDbType.DateTime))
                    ホーム.SystemMdf.Parameters("@filedate").Value = Now
                    ホーム.SystemMdf.ExecuteNonQuery()
                End If
            End If

            ホーム.SystemMdf.Parameters.Clear()

            ホーム.Connection.Close()
            ホーム.Connection.Dispose()

            ホーム.Connection.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & OtherFileOpenDialog.FileName & ";Integrated Security=True"
            ホーム.Connection.Open()
            ホーム.Sql.Connection = ホーム.Connection
            ホーム.Text = "予算管理システム　(" & OpenFilePath & OpenFileName & ")"


            Me.Close()

            ホーム.Sql.CommandText = "SELECT Count(budget_no) FROM budget_summary"
            Dim DataCount As Integer = ホーム.Sql.ExecuteScalar

            ホーム.UserDataPath = OpenFilePath
            ホーム.UserDataName = OpenFileName

            ホーム.HomeTreeView.Nodes.Clear()

            If DataCount >= 1 Then
                予算選択.Show()

                予算選択.TopMost = True
                予算選択.TopMost = False
                ホーム.見積.Enabled = True
                ホーム.外注管理.Enabled = True
                ホーム.出力.Enabled = True
                ホーム.予算内訳登録.Enabled = True
                ホーム.参照作成command.Enabled = True

            Else
                ホーム.HomeTreeView.Columns(0).HeaderText = ""
                ホーム.HomeTreeView.Nodes.Clear()
                ホーム.Enabled = True
                ホーム.BudgetNo = 0
                ホーム.予算内訳登録.Enabled = False
                ホーム.見積.Enabled = False
                ホーム.外注管理.Enabled = False
                ホーム.出力.Enabled = False
                ホーム.参照作成command.Enabled = False

            End If

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try

    End Sub

    Private Sub Open_Click(sender As Object, e As EventArgs) Handles Open.Click
        Try
            Cursor.Current = Cursors.WaitCursor

            Dim SelectRow As Integer = FileList.Selection.TopRow
            Dim OpenFileName As CellRange = FileList.GetCellRange(SelectRow, 1)
            Dim OpenFilePath As CellRange = FileList.GetCellRange(SelectRow, 2)

            If System.IO.File.Exists(OpenFilePath.Data & OpenFileName.Data) = True Then
                ホーム.HomeTreeView.Nodes.Clear()


                ホーム.SystemMdf.CommandText = ""
                ホーム.SystemMdf.Parameters.Clear()
                ホーム.SystemMdf.CommandText = "UPDATE userfiles SET filedate=@filedate WHERE filename=@filename"
                ホーム.SystemMdf.Parameters.Add(New SqlParameter("@filedate", SqlDbType.DateTime))
                ホーム.SystemMdf.Parameters.Add(New SqlParameter("@filename", SqlDbType.NVarChar))
                ホーム.SystemMdf.Parameters("@filedate").Value = Now
                ホーム.SystemMdf.Parameters("@filename").Value = OpenFileName.Data
                ホーム.SystemMdf.ExecuteNonQuery()

                ホーム.Connection.Close()
                ホーム.Connection.Dispose()

                ホーム.Connection.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & OpenFilePath.Data & OpenFileName.Data & ";Integrated Security=True"
                ホーム.Connection.Open()
                ホーム.Sql.Connection = ホーム.Connection
                ホーム.Text = "予算管理システム　(" & OpenFilePath.Data & OpenFileName.Data & ")"
                ホーム.UserDataPath = OpenFilePath.Data
                ホーム.UserDataName = OpenFileName.Data

                ホーム.Sql.CommandText = "SELECT Count(budget_no) FROM budget_summary"
                Dim DataCount As Integer = ホーム.Sql.ExecuteScalar

                Me.Close()


                If DataCount >= 1 Then
                    予算選択.Show()

                    予算選択.TopMost = True
                    予算選択.TopMost = False
                    ホーム.見積.Enabled = True
                    ホーム.外注管理.Enabled = True
                    ホーム.出力.Enabled = True
                    ホーム.予算内訳登録.Enabled = True
                    ホーム.参照作成command.Enabled = True


                Else
                    ホーム.HomeTreeView.Columns(0).HeaderText = ""
                    ホーム.HomeTreeView.Nodes.Clear()
                    ホーム.Enabled = True
                    ホーム.BudgetNo = 0
                    ホーム.見積.Enabled = False
                    ホーム.外注管理.Enabled = False
                    ホーム.出力.Enabled = False
                    ホーム.予算内訳登録.Enabled = False
                    ホーム.参照作成command.Enabled = False

                End If
            Else
                MsgBox("選択されたファイルが存在しません。" & vbCrLf & OpenFilePath.Data & OpenFileName.Data & vbCrLf & vbCrLf & "他のファイルを選択して下さい。")


                ホーム.SystemMdf.CommandText = "DELETE FROM userfiles WHERE filename=@name AND filepath=@path"
                ホーム.SystemMdf.Parameters.Add(New SqlParameter("@name", SqlDbType.NVarChar)).Value = OpenFileName.Data
                ホーム.SystemMdf.Parameters.Add(New SqlParameter("@path", SqlDbType.NVarChar)).Value = OpenFilePath.Data
                ホーム.SystemMdf.ExecuteNonQuery()

                FileList.Rows.Remove(SelectRow)

            End If
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try

    End Sub

    Private Sub DB選択_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        If ホーム.Text.Contains("(") = False Then
            MsgBox("ファイル選択されていません。")
        End If

    End Sub
End Class