Imports System.Data.SqlClient
Imports System.Deployment.Application
Imports System.IO.DirectoryInfo
Imports System.ComponentModel
Imports System.Deployment.Application.ApplicationDeployment
Imports System.Windows.Forms.Form
Imports C1.Win.C1FlexGrid
Public Class DB選択

    Private Sub DB選択_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FileList.Rows(0).Height = 20

        Dim DataCount As Integer = 1

        ホーム.SystemSql.CommandText = "SELECT TOP 5 * FROM userfiles ORDER BY filedate DESC"
        Dim FileReader As SqlDataReader = ホーム.SystemSql.ExecuteReader
        While FileReader.Read
            FileList(DataCount, 1) = FileReader.Item("filename")
            FileList(DataCount, 2) = FileReader.Item("filepath")
            DataCount += 1
        End While
        FileReader.Close()

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

        Dim OpenFileName As String = IO.Path.GetFileName(OtherFileOpenDialog.FileName)
        Dim OpenFilePath As String = IO.Path.GetDirectoryName(OtherFileOpenDialog.FileName)

        If OpenFileName.Contains(".mdf") = False Then
            MsgBox("mdfファイルを選択してください。", MsgBoxStyle.Exclamation, "エラー")
            Exit Sub

        Else

            ホーム.SystemSql.CommandText = ""
            ホーム.SystemSql.Parameters.Clear()

            ホーム.SystemSql.CommandText = "SELECT Count(*) FROM userfiles WHERE filename=@filename"
            ホーム.SystemSql.Parameters.Add(New SqlParameter("@filename", SqlDbType.NVarChar))
            ホーム.SystemSql.Parameters("@filename").Value = OpenFileName
            Dim Filecount As Integer = ホーム.SystemSql.ExecuteScalar

            If Filecount >= 1 Then
                ホーム.SystemSql.CommandText = "UPDATE userfiles SET filedate='" & Now & "' WHERE filename=@filename"
                ホーム.SystemSql.ExecuteNonQuery()
            Else
                ホーム.SystemSql.CommandText = "INSERT INTO userfiles (filename,filepath,filedate) VALUES (@filename,@filepath,@filedate)"
                ホーム.SystemSql.Parameters.Add(New SqlParameter("@filepath", SqlDbType.NVarChar))
                ホーム.SystemSql.Parameters.Add(New SqlParameter("@filedate", SqlDbType.DateTime))
                ホーム.SystemSql.Parameters("@filepath").Value = OpenFilePath
                ホーム.SystemSql.Parameters("@filedate").Value = Now
                ホーム.SystemSql.ExecuteNonQuery()
            End If
        End If



        ホーム.Connection.Close()
        ホーム.Connection.Dispose()

        ホーム.Connection.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & OtherFileOpenDialog.FileName & ";Integrated Security=True"
        ホーム.Connection.Open()
        ホーム.Sql.Connection = ホーム.Connection
        ホーム.Text = "予算管理システム　(" & OpenFilePath & "\" & OpenFileName & ")"


        Me.Close()

        ホーム.Sql.CommandText = "SELECT Count(budget_no) FROM budget_summary"
        Dim DataCount As Integer = ホーム.Sql.ExecuteScalar


        If DataCount >= 1 Then
            予算選択.Show()

            予算選択.TopMost = True
            予算選択.TopMost = False

        Else
            ホーム.Enabled = True
            ホーム.BudgetNo = 0
        End If



    End Sub

    Private Sub Open_Click(sender As Object, e As EventArgs) Handles Open.Click

        Dim SelectRow As Integer = FileList.Row
        Dim OpenFileName As CellRange = FileList.GetCellRange(SelectRow, 1)
        Dim OpenFilePath As CellRange = FileList.GetCellRange(SelectRow, 2)


        ホーム.SystemSql.CommandText = ""
        ホーム.SystemSql.Parameters.Clear()
        ホーム.SystemSql.CommandText = "UPDATE userfiles SET filedate=@filedate WHERE filename=@filename"
        ホーム.SystemSql.Parameters.Add(New SqlParameter("@filedate", SqlDbType.DateTime))
        ホーム.SystemSql.Parameters.Add(New SqlParameter("@filename", SqlDbType.NVarChar))
        ホーム.SystemSql.Parameters("@filedate").Value = Now
        ホーム.SystemSql.Parameters("@filename").Value = OpenFileName.Data
        ホーム.SystemSql.ExecuteNonQuery()

        ホーム.Connection.Close()
        ホーム.Connection.Dispose()

        ホーム.Connection.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & OpenFilePath.Data & OpenFileName.Data & ";Integrated Security=True"
        ホーム.Connection.Open()
        ホーム.Sql.Connection = ホーム.Connection
        ホーム.Text = "予算管理システム　(" & OpenFilePath.Data & "\" & OpenFileName.Data & ")"


        ホーム.Sql.CommandText = "SELECT Count(budget_no) FROM budget_summary"
        Dim DataCount As Integer = ホーム.Sql.ExecuteScalar

        Me.Close()

        If DataCount >= 1 Then
            予算選択.Show()

            予算選択.TopMost = True
            予算選択.TopMost = False

        Else
            ホーム.Enabled = True
            ホーム.BudgetNo = 0
        End If



    End Sub
End Class