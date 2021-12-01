Imports System.Data.SqlClient
Imports System.Deployment.Application
Imports System.IO.DirectoryInfo
Imports System.ComponentModel
Imports System.Deployment.Application.ApplicationDeployment
Imports System.Windows.Forms.Form
Imports C1.Win.C1FlexGrid

Public Class 協力業者入力
    Private Sub 協力業者入力_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'ホーム.SystemSql.CommandText = "SELECT item_name FROM name_masters"
        'Dim Namemaster As SqlDataReader = ホーム.Sql.ExecuteReader
        'While Namemaster.Read
        '    CoopVendorList.Cols(5).ComboList = Namemaster.Item("item_name")
        'End While

        ホーム.Sql.CommandText = "SELECT count(outsrcr_code) FROM outsourcers"
        Dim Outsrcrcount As Integer = ホーム.Sql.ExecuteScalar

        ホーム.Sql.CommandText = "SELECT * FROM outsourcers"
        Dim datacount As Integer = 1
        Dim Coopreader As SqlDataReader = ホーム.Sql.ExecuteReader
        While Coopreader.Read
            Me.CoopVendorList.Rows.Add()
            CoopVendorList(datacount, 1) = Coopreader.Item("outsrcr_code")
            CoopVendorList(datacount, 2) = Coopreader.Item("outsrcr_name")
            CoopVendorList(datacount, 3) = Coopreader.Item("outsrcr_term_s")
            CoopVendorList(datacount, 4) = Coopreader.Item("outsrcr_term_e")
            Dim ordr As String = Coopreader.Item("ordrfrm")
            If ordr = 11 Then
                CoopVendorList(datacount, 5) = "工務課発注"
            ElseIf ordr = 12 Then
                CoopVendorList(datacount, 5) = "購買発注"
            End If
            Dim ecn As String = Coopreader.Item("e_cntrct")
            If ecn = "true" Then
                CoopVendorList.SetCellCheck(datacount, 6, CheckEnum.Checked)
            Else
                CoopVendorList.SetCellCheck(datacount, 6, CheckEnum.Unchecked)
            End If

            datacount += 1

        End While
        Coopreader.Close()
        'Dim RowIndex As Integer = CoopVendorList.Rows.Count - 1
        'CoopVendorList.StartEditing(RowIndex, 3)

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
            Dim Coopterms As CellRange = CoopVendorList.GetCellRange(Vendorloop, 3)
            Dim Coopterme As CellRange = CoopVendorList.GetCellRange(Vendorloop, 4)
            Dim Coopordr As CellRange = CoopVendorList.GetCellRange(Vendorloop, 5)
            Dim Coopcntrct As CellRange = CoopVendorList.GetCellRange(Vendorloop, 6)
            Dim CoopDeleteF As CellRange = CoopVendorList.GetCellRange(Vendorloop, 7)
            ホーム.Sql.CommandText = ""
            ホーム.Sql.Parameters.Clear()
            ホーム.Sql.CommandText = "Select count(*) from Outsourcers where outsrcr_code = " & CoopID.Data
            Dim CoopIDcount As Integer = ホーム.Sql.ExecuteScalar
            If Coopterme.Data = Nothing Then
                MsgBox("実施工期を入力してください。", MsgBoxStyle.OkOnly, "エラー")
                Exit Sub
            End If
            If CoopVendorList(Vendorloop, 3) >= CoopVendorList(Vendorloop, 4) Then
                MsgBox("実施工期が適切ではありません。", MsgBoxStyle.OkOnly, "エラー")
                Exit Sub
            End If
            If CoopDeleteF.Data = True Then
                If MsgBox("削除される項目があります。このまま登録しますか？", MsgBoxStyle.OkCancel, "確認") = MsgBoxResult.Cancel Then
                    Exit Sub
                End If
            End If
            If CoopIDcount = 0 Then
                ホーム.Sql.CommandText = ""
                ホーム.Sql.Parameters.Clear()
                ホーム.Sql.CommandText = "INSERT INTO Outsourcers (outsrcr_code,outsrcr_name,outsrcr_term_s,outsrcr_term_e,ordrfrm,e_cntrct) VALUES (@outsrcr_code,@outsrcr_name,@outsrcr_term_s,@outsrcr_term_e,@ordrfrm,@e_cntrct)"
            Else
                ホーム.Sql.CommandText = ""
                ホーム.Sql.Parameters.Clear()
                ホーム.Sql.CommandText = "UPDATE Outsourcers SET outsrcr_name=@outsrcr_name,outsrcr_term_s=@outsrcr_term_s,outsrcr_term_e=@outsrcr_term_e,ordrfrm=@ordrfrm,e_cntrct=@e_cntrct where outsrcr_code=@outsrcr_code"
            End If
            ホーム.Sql.Parameters.Add(New SqlParameter("@outsrcr_code", SqlDbType.Int))
            ホーム.Sql.Parameters.Add(New SqlParameter("@outsrcr_name", SqlDbType.NVarChar))
            ホーム.Sql.Parameters.Add(New SqlParameter("@outsrcr_term_s", SqlDbType.DateTime))
            ホーム.Sql.Parameters.Add(New SqlParameter("@outsrcr_term_e", SqlDbType.DateTime))
            ホーム.Sql.Parameters.Add(New SqlParameter("@ordrfrm", SqlDbType.SmallInt))
            ホーム.Sql.Parameters.Add(New SqlParameter("@e_cntrct", SqlDbType.NVarChar))
            ホーム.Sql.Parameters("@outsrcr_code").Value = CoopID.Data
            ホーム.Sql.Parameters("@outsrcr_name").Value = CoopName.Data
            ホーム.Sql.Parameters("@outsrcr_term_s").Value = Coopterms.Data
            ホーム.Sql.Parameters("@outsrcr_term_e").Value = Coopterme.Data
            If Coopordr.Data = "工務課発注" Then
                ホーム.Sql.Parameters("@ordrfrm").Value = 11
            ElseIf Coopordr.Data = "購買発注" Then
                ホーム.Sql.Parameters("@ordrfrm").Value = 12
            End If
            If Coopcntrct.Data = True Then
                ホーム.Sql.Parameters("@e_cntrct").Value = "true"
            Else
                ホーム.Sql.Parameters("@e_cntrct").Value = "false"
            End If

            If CoopDeleteF.Data = True Then
                ホーム.Sql.Parameters.Clear()
                ホーム.Sql.CommandText = "DELETE FROM Outsourcers WHERE outsrcr_code=" & CoopID.Data
                ホーム.Sql.ExecuteNonQuery()
            End If


            ホーム.Sql.ExecuteNonQuery()
        Next

        Me.Close()
    End Sub
End Class