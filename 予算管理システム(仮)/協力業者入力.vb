Imports System.Data.SqlClient
Imports System.Deployment.Application
Imports System.IO.DirectoryInfo
Imports System.ComponentModel
Imports System.Deployment.Application.ApplicationDeployment
Imports System.Windows.Forms.Form
Imports C1.Win.C1FlexGrid

Public Class 協力業者入力
    Private Sub 協力業者入力_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ホーム.Connection.Close()
        ホーム.Connection.Dispose()
        'ホーム.Connection.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & ホーム.UserDataPath & "" & ホーム.UserDataName & ";Integrated Security=True"
        ホーム.Connection.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\217003\source\repos\MinaAjiki\YosankanriSys\予算管理システム(仮)\現場データ.mdf;Integrated Security=True"
        ホーム.Connection.Open()
        ホーム.SystemSql.Connection = ホーム.Connection

        ホーム.SystemSql.CommandText = "SELECT count(outsrcr_code) FROM outsourcers"
        Dim Outsrcrcount As Integer = ホーム.SystemSql.ExecuteScalar

        ホーム.SystemSql.CommandText = "SELECT * FROM outsourcers"
        Dim datacount As Integer = 1
        Dim Coopreader As SqlDataReader = ホーム.SystemSql.ExecuteReader
        While Coopreader.Read
            Me.CoopVendorList.Rows.Add()
            CoopVendorList(datacount, 1) = Coopreader.Item("outsrcr_code")
            CoopVendorList(datacount, 2) = Coopreader.Item("outsrcr_name")
            CoopVendorList(datacount, 3) = Coopreader.Item("outsrcr_trm_s")
            CoopVendorList(datacount, 4) = Coopreader.Item("outsrcr_trm_e")
            Dim ecn As String = Coopreader.Item("ecntrct")
            If ecn = "true" Then
                CoopVendorList.SetCellCheck(datacount, 6, CheckEnum.Checked)
            Else
                CoopVendorList.SetCellCheck(datacount, 6, CheckEnum.Unchecked)
            End If

            datacount += 1

        End While
        Coopreader.Close()

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles VendorSelect.Click
        業者一覧.Show()
    End Sub

    Private Sub CoopVendorList_CellChanged(sender As Object, e As RowColEventArgs) Handles CoopVendorList.AfterEdit
        Dim SetImageRow As Integer = e.Row
        CoopVendorList.SetCellImage(SetImageRow, 8, Image.FromFile(Application.StartupPath & "\Edit_source.png"))
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Entry.Click
        Dim RowIndex As Integer = CoopVendorList.Rows.Count - 1
        For Vendorloop As Integer = 1 To RowIndex - 1
            Dim CoopID As CellRange = CoopVendorList.GetCellRange(Vendorloop, 1)
            Dim CoopName As CellRange = CoopVendorList.GetCellRange(Vendorloop, 2)
            Dim Cooptrms As CellRange = CoopVendorList.GetCellRange(Vendorloop, 3)
            Dim Cooptrme As CellRange = CoopVendorList.GetCellRange(Vendorloop, 4)
            'Dim Coopordr As CellRange = CoopVendorList.GetCellRange(Vendorloop, 5)
            Dim Coopcntrct As CellRange = CoopVendorList.GetCellRange(Vendorloop, 6)
            Dim CoopDeleteF As CellRange = CoopVendorList.GetCellRange(Vendorloop, 7)
            ホーム.SystemSql.CommandText = ""
            ホーム.SystemSql.Parameters.Clear()
            ホーム.SystemSql.CommandText = "Select count(*) from Outsourcers where outsrcr_code = " & CoopID.Data
            Dim CoopIDcount As Integer = ホーム.SystemSql.ExecuteScalar
            If Cooptrme.Data = Nothing Then
                MsgBox("実施工期を入力してください。", MsgBoxStyle.OkOnly, "エラー")
                Exit Sub
            End If
            If CoopIDcount = 0 Then
                ホーム.SystemSql.CommandText = ""
                ホーム.SystemSql.Parameters.Clear()
                ホーム.SystemSql.CommandText = "INSERT INTO Outsourcers (outsrcr_code,outsrcr_name,outsrcr_trm_s,outsrcr_trm_e,ordrfrm,ecntrct) VALUES (@outsrcr_code,@outsrcr_name,@outsrcr_trm_s,@outsrcr_trm_e,@ordrfrm,@ecntrct)"
            Else
                ホーム.SystemSql.CommandText = ""
                ホーム.SystemSql.Parameters.Clear()
                ホーム.SystemSql.CommandText = "UPDATE Outsourcers SET outsrcr_name=@outsrcr_name,outsrcr_trm_s=@outsrcr_trm_s,outsrcr_trm_e=@outsrcr_trm_e,ordrfrm=@ordrfrm,ecntrct=@ecntrct where outsrcr_code=@outsrcr_code"
            End If
            ホーム.SystemSql.Parameters.Add(New SqlParameter("@outsrcr_code", SqlDbType.Int))
            ホーム.SystemSql.Parameters.Add(New SqlParameter("@outsrcr_name", SqlDbType.NVarChar))
            ホーム.SystemSql.Parameters.Add(New SqlParameter("@outsrcr_trm_s", SqlDbType.DateTime))
            ホーム.SystemSql.Parameters.Add(New SqlParameter("@outsrcr_trm_e", SqlDbType.DateTime))
            ホーム.SystemSql.Parameters.Add(New SqlParameter("@ordrfrm", SqlDbType.SmallInt))
            ホーム.SystemSql.Parameters.Add(New SqlParameter("@ecntrct", SqlDbType.NVarChar))
            ホーム.SystemSql.Parameters("@outsrcr_code").Value = CoopID.Data
            ホーム.SystemSql.Parameters("@outsrcr_name").Value = CoopName.Data
            ホーム.SystemSql.Parameters("@outsrcr_trm_s").Value = Cooptrms.Data
            ホーム.SystemSql.Parameters("@outsrcr_trm_e").Value = Cooptrme.Data
            ホーム.SystemSql.Parameters("@ordrfrm").Value = 1
            If Coopcntrct.Data = True Then
                ホーム.SystemSql.Parameters("@ecntrct").Value = "true"
            Else
                ホーム.SystemSql.Parameters("@ecntrct").Value = "false"
            End If

            If CoopDeleteF.Data = True Then
                ホーム.Sql.Parameters.Clear()
                ホーム.Sql.CommandText = "DELETE FROM Outsourcers WHERE outsrcr_code=" & CoopID.Data
                ホーム.Sql.ExecuteNonQuery()
            End If


            ホーム.SystemSql.ExecuteNonQuery()
        Next

        Me.Close()
    End Sub
End Class