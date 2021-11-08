Imports System.Data.SqlClient
Imports System.Deployment.Application
Imports System.IO.DirectoryInfo
Imports System.ComponentModel
Imports System.Deployment.Application.ApplicationDeployment
Imports System.Windows.Forms.Form
Public Class 予算選択
    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        ホーム.Connection.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & FilePath.Text & ";Integrated Security=True"
        ホーム.Connection.Open()
        ホーム.SQL.Connection = ホーム.Connection

        ホーム.Enabled = True
        Me.Close()
    End Sub

    Private Sub 予算選択_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim path As String = ""
        ホーム.systemsql.CommandText = "SELECT MAX(updatedate),filepath FROM userfiles GROUP BY filepath"
        Dim filereader As SqlDataReader = ホーム.systemsql.ExecuteReader
        While filereader.Read
            path = filereader.Item("filepath")
        End While
        filereader.Close()

        If path <> "" Then
            Dim latestcnnctn As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & path & ";Integrated Security=True")
            Dim latestsql As New SqlCommand
            latestcnnctn.Open()
            latestsql.Connection = latestcnnctn
            Dim prjct_name As String = ""
            Dim prjct_code As String = ""
            Dim cntrct_no As Integer = 0
            latestsql.CommandText = "select max(cntrct_no),prjct_code,prjct_name from budgetsummary"
            Dim latestreader As SqlDataReader = latestsql.ExecuteReader
            While latestreader.Read
                prjct_code = latestreader.Item("prjct_code")
                prjct_name = latestreader.Item("prjct_name")
                cntrct_no = latestreader.Item("contract_no")
            End While
            latestreader.Close()

            Contract_NoList.Items.Add("当初")

            For contrctno As Integer = 1 To cntrct_no
                Contract_NoList.Items.Add("第" & contrctno & "回変更")
            Next

            Contract_NoList.Items.Add("変更予算作成")

            Project.Value = prjct_code & " " & prjct_name
            FilePath.Value = path
            Contract_NoList.SelectedItem = cntrct_no

        Else

            ホーム.Enabled = True
            Me.Close()
        End If

    End Sub
    Private Sub OK_MouseEnter(sender As Object, e As EventArgs) Handles OK.MouseEnter
        OK.Cursor = Cursors.Hand
        OK.ImageIndex = 1
    End Sub

    Private Sub OK_MouseDown(sender As Object, e As MouseEventArgs) Handles OK.MouseDown
        OK.ImageIndex = 2
    End Sub

    Private Sub OK_MouseLeave(sender As Object, e As EventArgs) Handles OK.MouseLeave
        OK.ImageIndex = 0
    End Sub

    Private Sub OK_MouseUp(sender As Object, e As MouseEventArgs) Handles OK.MouseUp
        OK.ImageIndex = 0
    End Sub
End Class