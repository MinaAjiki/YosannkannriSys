Imports System.Data.SqlClient
Imports System.Deployment.Application
Imports System.IO.DirectoryInfo
Imports System.ComponentModel
Imports System.Deployment.Application.ApplicationDeployment
Imports System.Windows.Forms.Form
Public Class DB選択

    Private Sub DB選択_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileList.Rows(0).Height = 20

        ホーム.SystmCnnctn.Open()
        ホーム.SystemSql.Connection = ホーム.SystmCnnctn

        Dim DataCount As Integer = 1

        ホーム.SystemSql.CommandText = "SELECT TOP 5 * FROM userfiles ORDER BY updatedate ASC"
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


            ホーム.SystemSql.CommandText = "SELECT Count(filename) FROM userfiles WHERE filename=" & OpenFileName
            Dim Filecount As Integer = ホーム.SystemSql.ExecuteScalar

            If Filecount >= 1 Then
                ホーム.SystemSql.CommandText = "UPDATE userfiles SET updatedate=" & Today & " WHERE filename=" & OpenFileName
                ホーム.SystemSql.ExecuteNonQuery()
            Else
                ホーム.SystemSql.CommandText = "INSERT INTO userfiles (filename,filepath,updatedate) VALLUES (@filename,@failepath,@updatedate)"
                ホーム.SystemSql.Parameters.Add(New SqlParameter("@filename", SqlDbType.NVarChar))
                ホーム.SystemSql.Parameters.Add(New SqlParameter("@filepath", SqlDbType.NVarChar))
                ホーム.SystemSql.Parameters.Add(New SqlParameter("@updatedate", SqlDbType.Date))
                ホーム.SystemSql.Parameters("@filename").Value = OpenFileName
                ホーム.SystemSql.Parameters("@filepath").Value = OpenFilePath
                ホーム.SystemSql.Parameters("@updatedate").Value = Today
                ホーム.SystemSql.ExecuteNonQuery()
            End If
        End If

        ホーム.Connection.Close()
        ホーム.Connection.Dispose()

        ホーム.Connection.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & OpenFileName & ";Integrated Security=True"
        ホーム.Connection.Open()
        ホーム.SQL.Connection = ホーム.Connection

    End Sub
End Class