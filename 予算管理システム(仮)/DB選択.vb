Imports System.Data.SqlClient
Imports System.Deployment.Application
Imports System.IO.DirectoryInfo
Imports System.ComponentModel
Imports System.Deployment.Application.ApplicationDeployment
Imports System.Windows.Forms.Form
Public Class DB選択
    Dim systmcnnctn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & Application.StartupPath & "\予算管理システム(system_sql).mdf;Integrated Security=True")
    Dim systemsql As New SqlCommand

    Private Sub DB選択_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileList.Rows(0).Height = 20

        systmcnnctn.Open()
        systemsql.Connection = systmcnnctn
        Dim datacount As Integer = 1
        systemsql.CommandText = "SELECT TOP 5 * FROM userfiles ORDER BY updatedate ASC"
        Dim filereader As SqlDataReader = systemsql.ExecuteReader
        While filereader.Read
            FileList(datacount, 1) = filereader.Item("filename")
            FileList(datacount, 2) = filereader.Item("filepath")
            datacount += 1
        End While
        filereader.Close()

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

        Dim openfilename As String = OtherFileOpenDialog.FileName

        If openfilename.Contains(".mdf") = False Then
            MsgBox("mdfファイルを選択してください。", MsgBoxStyle.Exclamation, "エラー")
            Exit Sub

        Else

            ホーム.Connection.Close()
            ホーム.Connection.Dispose()

            ホーム.Connection.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & openfilename & ";Integrated Security=True"
            ホーム.Connection.Open()
            ホーム.SQL.Connection = ホーム.Connection

            Dim lastindex As Integer = openfilename.LastIndexOf("\")
            Dim length As Integer = openfilename.Length

            Dim filename As String = openfilename.Remove(0, lastindex + 1)

            systemsql.CommandText = "SELECT Count(filename) FROM userfiles WHERE filename=" & filename
            Dim filecount As Integer = systemsql.ExecuteScalar

            If filecount >= 1 Then
                systemsql.CommandText = "UPDATE userfiles SET updatedate=" & Today & " WHERE filename=" & filename
                systemsql.ExecuteNonQuery()
            Else
                systemsql.CommandText = "INSERT INTO userfiles (filename,filepath,updatedate) VALLUES (@filename,@failepath,@updatedate)"
                systemsql.Parameters.Add(New SqlParameter("@filename", SqlDbType.NVarChar))
                systemsql.Parameters.Add(New SqlParameter("@filepath", SqlDbType.NVarChar))
                systemsql.Parameters.Add(New SqlParameter("@updatedate", SqlDbType.Date))
                systemsql.Parameters("@filename").Value = filename
                systemsql.Parameters("@filepath").Value = openfilename
                systemsql.Parameters("@updatedate").Value = Today
                systemsql.ExecuteNonQuery()
            End If
        End If

    End Sub
End Class