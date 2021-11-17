Imports System.Data.SqlClient
Imports System.Deployment.Application
Imports System.IO.DirectoryInfo
Imports System.ComponentModel
Imports System.Deployment.Application.ApplicationDeployment
Imports System.Windows.Forms.Form
Public Class 予算選択
    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        If ホーム.Connection.State = ConnectionState.Open Then
            ホーム.Connection.Close()
        End If

        ホーム.Connection.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & FilePath.Text & ";Integrated Security=True"
        ホーム.Connection.Open()
        ホーム.Sql.Connection = ホーム.Connection

        ホーム.Enabled = True
        Me.Close()
    End Sub

    Private Sub 予算選択_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If ホーム.UserDataName <> "" Then

            Dim Prjct_Name As String
            Dim Prjct_Code As String
            Dim Cntrct_No As Integer = 0

            ホーム.Sql.CommandText = "select max(cntrct_no) from budget_summary"
            ホーム.ContractNo = ホーム.Sql.ExecuteScalar

            ホーム.Sql.CommandText = "SELECT contents FROM controldata WHERE class_code=20"
            Prjct_Code = ホーム.Sql.ExecuteScalar

            ホーム.Sql.CommandText = "SELECT contents FROM controldata WHERE class_code=21"
            Prjct_Name = ホーム.Sql.ExecuteScalar

            Contract_NoList.Items.Add("当初")

            For No As Integer = 1 To Cntrct_No
                Contract_NoList.Items.Add("第" & No & "回変更")
            Next

            Contract_NoList.Items.Add("変更予算作成")

            Project.Value = Prjct_Code & " " & Prjct_Name
            FilePath.Value = ホーム.UserDataPath & ホーム.UserDataName
            Contract_NoList.SelectedItem = Cntrct_No

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