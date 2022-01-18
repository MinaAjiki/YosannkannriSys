Imports C1.Win.C1FlexGrid
Imports System.Data.SqlClient
Public Class 出来高査定チェックフォーム
    Private Sub Cancel_MouseLeave(sender As Object, e As EventArgs) Handles Cancel.MouseLeave
        Cancel.ImageIndex = 6
    End Sub

    Private Sub Cancel_MouseEnter(sender As Object, e As EventArgs) Handles Cancel.MouseEnter
        Cancel.Cursor = Cursors.Hand
        Cancel.ImageIndex = 7
    End Sub

    Private Sub Cancel_MouseDown(sender As Object, e As MouseEventArgs) Handles Cancel.MouseDown
        Cancel.ImageIndex = 8
    End Sub
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
    Private Sub 出来高査定チェックフォーム_Load(sender As Object, e As EventArgs) Handles Me.Load
        VendorList.Focus()
        DetailsList.Visible = False

        Dim dt As DataTable
        dt = New DataTable
        dt.Columns.Add("ID", GetType(System.Int32))
        dt.Columns.Add("Code", GetType(System.Int32))
        dt.Columns.Add("Name", GetType(System.String))
        Dim id As Int32
        Dim code As Int32
        Dim name As String

        ホーム.Sql.CommandText = "SELECT * FROM outsourcers"
        Dim Coopreader As SqlDataReader = ホーム.Sql.ExecuteReader
        While Coopreader.Read
            id = Coopreader("outsrcr_id")
            code = Coopreader("outsrcr_code")
            name = Coopreader("outsrcr_name")
            dt.Rows.Add(id, code, name)
        End While
        Coopreader.Close()

        VendorList.TextDetached = True
        VendorList.ItemsDataSource = dt.DefaultView
        VendorList.ItemsDisplayMember = "Name"
        VendorList.ItemsValueMember = "Code"
        VendorList.ItemMode = C1.Win.C1Input.ComboItemMode.HtmlPattern
        VendorList.HtmlPattern = "<table><tr><td width=30>{Code}</td><td width=270>{Name}</td></tr></table>"
        VendorList.SelectedIndex = -1
        VendorList.Text = "協力業者を選択"
        VendorNo.Text = Nothing
    End Sub

    Private Sub VendorList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles VendorList.SelectedIndexChanged
        DetailsList.Clear(ClearFlags.Content)
        DetailsList.Visible = True
        DetailsList(0, 1) = "工種ｺｰﾄﾞ"
        DetailsList(0, 2) = "工種名"
        DetailsList(0, 3) = "発注金額"
        DetailsList(0, 4) = "出来高"
        DetailsList(0, 5) = "残高"
        If VendorList.SelectedIndex >= 0 Then
            VendorNo.Text = VendorList.SelectedItem
        End If
    End Sub
End Class