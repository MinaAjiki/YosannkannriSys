Imports System.Data.SqlClient
Imports System.Deployment.Application
Imports System.IO.DirectoryInfo
Imports System.ComponentModel
Imports System.Deployment.Application.ApplicationDeployment
Imports System.Windows.Forms.Form
Public Class 協力業者入力
    Private Sub 協力業者入力_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ホーム.Connection.Close()
        ホーム.Connection.Dispose()
        ホーム.Connection.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\現場データ.mdf;Integrated Security=True"
        ホーム.Connection.Open()
        ホーム.SystemSql.Connection = ホーム.Connection
        ホーム.SystemSql.CommandText = "SELECT * FROM outsourcers"
        Dim datacount As Integer = 1
        Dim Coopreader As SqlDataReader = ホーム.SystemSql.ExecuteReader
        While Coopreader.Read
            CoopVendorList(datacount, 1) = Coopreader.Item("outsrcr_code")
            CoopVendorList(datacount, 2) = Coopreader.Item("outsrcr_name")
            CoopVendorList(datacount, 3) = Coopreader.Item("outsrcr_trm_s")
            CoopVendorList(datacount, 4) = Coopreader.Item("outsrcr_trm_e")
            datacount += 1
        End While
        Coopreader.Close()

        ホーム.SystemSql.CommandText = "SELECT count(outsrcr_code) FROM outsourcers"
        Dim Outsrcrcount As Integer = ホーム.Sql.ExecuteScalar

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
        Entry.ImageIndex = 3
    End Sub

    Private Sub Button4_MouseEnter(sender As Object, e As EventArgs) Handles Entry.MouseEnter
        Entry.Cursor = Cursors.Hand
        Entry.ImageIndex = 4
    End Sub

    Private Sub Button4_MouseDown(sender As Object, e As MouseEventArgs) Handles Entry.MouseDown
        Entry.ImageIndex = 5
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Entry.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles VendorSelect.Click
        業者一覧.Show()
    End Sub
End Class