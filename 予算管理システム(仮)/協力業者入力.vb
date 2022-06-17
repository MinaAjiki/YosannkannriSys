Imports System.Data.SqlClient
Imports System.Deployment.Application
Imports System.IO.DirectoryInfo
Imports System.ComponentModel
Imports System.Deployment.Application.ApplicationDeployment
Imports System.Windows.Forms.Form
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Command


Public Class 協力業者入力
    Private Sub 協力業者入力_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ''namemasterからデータを取得
            'ホーム.SystemSql.CommandText = "SELECT item_name FROM name_masters"
            'Dim Namemaster As SqlDataReader = ホーム.Sql.ExecuteReader
            'While Namemaster.Read
            '    CoopVendorList.Cols(5).ComboList = Namemaster.Item("item_name")
            'End While
            CoopVendorList.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Custom
            C1SplitterPanel1.Anchor = AnchorStyles.Top & Bottom
            C1SplitterPanel2.Anchor = AnchorStyles.Bottom

            ホーム.Sql.CommandText = "SELECT count(outsrcr_code) FROM outsourcers"
            Dim Outsrcrcount As Integer = ホーム.Sql.ExecuteScalar

            ホーム.Sql.CommandText = "SELECT * FROM outsourcers"
            Dim datacount As Integer = 1
            Dim Coopreader As SqlDataReader = ホーム.Sql.ExecuteReader
            While Coopreader.Read
                Me.CoopVendorList.Rows.Add()
                CoopVendorList(datacount, 0) = Coopreader.Item("outsrcr_id")
                CoopVendorList(datacount, 1) = Coopreader.Item("outsrcr_code")
                CoopVendorList(datacount, 2) = Coopreader.Item("outsrcr_name")
                CoopVendorList(datacount, 3) = Coopreader.Item("outsrcr_term_s")
                CoopVendorList(datacount, 4) = Coopreader.Item("outsrcr_term_e")
                CoopVendorList(datacount, 9) = Coopreader.Item("outsrcr_name_ryaku")
                'Dim dt As DataTable
                'dt = New DataTable
                'dt.Columns.Add("orderno", GetType(System.Int32))
                'dt.Columns.Add("ordername", GetType(System.String))
                'Dim OrderNo As Integer
                'Dim OrderName As String

                'ホーム.SystemSql.Parameters.Clear()
                'ホーム.SystemSql.CommandText = ""
                'Dim OrderReader As SqlDataReader = ホーム.SystemSql.ExecuteReader
                'While OrderReader.Read
                '    OrderNo = OrderReader.Item("ordrfrm")
                'End While

                Dim ordr As String = Coopreader.Item("ordrfrm")
                If ordr = 11 Then
                    CoopVendorList(datacount, 5) = "工事課発注"
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

            ホーム.Modified = "false"

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
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
        Try
            Dim SetImageRow As Integer = e.Row
            CoopVendorList.SetCellImage(SetImageRow, 8, Image.FromFile(Application.StartupPath & "\Resources\Edit_source.png"))
            ホーム.Modified = "True"

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub Entry_Click(sender As Object, e As EventArgs) Handles Entry.Click
        Try
            '行数ループ
            Dim RowIndex As Integer = CoopVendorList.Rows.Count - 1
            For Vendorloop As Integer = 1 To RowIndex - 1
                Dim CoopID As CellRange = CoopVendorList.GetCellRange(Vendorloop, 0)
                Dim CoopCode As CellRange = CoopVendorList.GetCellRange(Vendorloop, 1)
                Dim CoopName As CellRange = CoopVendorList.GetCellRange(Vendorloop, 2)
                Dim Coopterms As CellRange = CoopVendorList.GetCellRange(Vendorloop, 3)
                Dim Coopterme As CellRange = CoopVendorList.GetCellRange(Vendorloop, 4)
                Dim Coopordr As CellRange = CoopVendorList.GetCellRange(Vendorloop, 5)
                Dim Coopcntrct As CellRange = CoopVendorList.GetCellRange(Vendorloop, 6)
                Dim CoopDeleteF As CellRange = CoopVendorList.GetCellRange(Vendorloop, 7)
                Dim CoopRyaku As CellRange = CoopVendorList.GetCellRange(Vendorloop, 9)

                '業者ｺｰﾄﾞ入力時、工期、発注形態入力チェック
                If CoopCode.Data <> Nothing Then
                    If CoopDeleteF.Data = False Then
                        If Coopterme.Data = Nothing Then
                            MsgBox("実施工期を入力してください。", MsgBoxStyle.OkOnly, "エラー")
                            Exit Sub
                        End If
                        If Coopordr.Data = Nothing Then
                            MsgBox("発注形態を選択してください。", MsgBoxStyle.OkOnly, "エラー")
                            Exit Sub
                        End If
                        If CoopVendorList(Vendorloop, 3) >= CoopVendorList(Vendorloop, 4) Then
                            MsgBox("" & CoopVendorList(Vendorloop, 2) & "の実施工期が適切ではありません。", MsgBoxStyle.OkOnly, "エラー")
                            Exit Sub
                        End If
                    End If
                Else
                    '業者ｺｰﾄﾞ未入力時、その行を削除し次のループへ
                    CoopVendorList.Rows.Remove(Vendorloop)
                    Vendorloop -= 1
                    RowIndex -= 1
                    '最後の行の場合、登録を終了する
                    If RowIndex <= 0 Then
                        MsgBox("登録完了", MsgBoxStyle.OkOnly, "協力業者登録")
                        Me.Close()
                        Exit Sub
                    End If
                    Continue For
                End If
                '削除チェック
                If CoopDeleteF.Data = True Then
                    If MsgBox("" & CoopVendorList(Vendorloop, 2) & "の登録された内容が全て削除されます。よろしいですか？", MsgBoxStyle.OkCancel, "確認") = MsgBoxResult.Cancel Then
                        Me.Close()
                        Exit Sub
                    End If
                    '削除したい行が登録済みか新規か判定し削除
                    If CoopID.Data <> Nothing Then
                        ホーム.Sql.Parameters.Clear()
                        ホーム.Sql.CommandText = "DELETE FROM Outsourcing_plans WHERE outsrcr_id = " & CoopID.Data
                        ホーム.Sql.ExecuteNonQuery()
                        ホーム.Sql.Parameters.Clear()
                        ホーム.Sql.CommandText = "DELETE FROM Outsourcers WHERE outsrcr_code=" & CoopCode.Data & "AND outsrcr_id =" & CoopID.Data
                        ホーム.Sql.ExecuteNonQuery()
                        CoopVendorList.Rows.Remove(Vendorloop)
                        Vendorloop -= 1
                        RowIndex -= 1
                        Continue For
                    Else
                        CoopVendorList.Rows.Remove(Vendorloop)
                        Vendorloop -= 1
                        RowIndex -= 1
                        Continue For
                    End If
                End If
                '登録
                If CoopCode.Data <> Nothing Then
                    If CoopID.Data = Nothing Then
                        ホーム.Sql.CommandText = ""
                        ホーム.Sql.Parameters.Clear()
                        ホーム.Sql.CommandText = "INSERT INTO Outsourcers (outsrcr_code,outsrcr_name,outsrcr_term_s,outsrcr_term_e,ordrfrm,e_cntrct,outsrcr_name_ryaku) VALUES (@outsrcr_code,@outsrcr_name,@outsrcr_term_s,@outsrcr_term_e,@ordrfrm,@e_cntrct,@outsrcr_name_ryaku)"
                    Else
                        ホーム.Sql.CommandText = ""
                        ホーム.Sql.Parameters.Clear()
                        ホーム.Sql.CommandText = "UPDATE Outsourcers SET outsrcr_code=@outsrcr_code,outsrcr_name=@outsrcr_name,outsrcr_term_s=@outsrcr_term_s,outsrcr_term_e=@outsrcr_term_e,ordrfrm=@ordrfrm,e_cntrct=@e_cntrct,outsrcr_name_ryaku=@outsrcr_name_ryaku where outsrcr_id=@outsrcr_id"
                        ホーム.Sql.Parameters.Add(New SqlParameter("@outsrcr_id", SqlDbType.Int))
                        ホーム.Sql.Parameters("@outsrcr_id").Value = CoopID.Data
                    End If
                    ホーム.Sql.Parameters.Add(New SqlParameter("@outsrcr_code", SqlDbType.Int))
                    ホーム.Sql.Parameters.Add(New SqlParameter("@outsrcr_name", SqlDbType.NVarChar))
                    ホーム.Sql.Parameters.Add(New SqlParameter("@outsrcr_name_ryaku", SqlDbType.NVarChar))
                    ホーム.Sql.Parameters.Add(New SqlParameter("@outsrcr_term_s", SqlDbType.DateTime))
                    ホーム.Sql.Parameters.Add(New SqlParameter("@outsrcr_term_e", SqlDbType.DateTime))
                    ホーム.Sql.Parameters.Add(New SqlParameter("@ordrfrm", SqlDbType.SmallInt))
                    ホーム.Sql.Parameters.Add(New SqlParameter("@e_cntrct", SqlDbType.NVarChar))
                    ホーム.Sql.Parameters("@outsrcr_code").Value = CoopCode.Data
                    ホーム.Sql.Parameters("@outsrcr_name").Value = CoopName.Data
                    'If IsNothing(CoopRyaku.Data) = True Then
                    '    ホーム.Sql.Parameters("@outsrcr_name_ryaku").Value = ""
                    'Else
                    ホーム.Sql.Parameters("@outsrcr_name_ryaku").Value = CoopRyaku.Data
                    'End If
                    ホーム.Sql.Parameters("@outsrcr_term_s").Value = Coopterms.Data
                    ホーム.Sql.Parameters("@outsrcr_term_e").Value = Coopterme.Data
                    If Coopordr.Data = "工事課発注" Then
                        ホーム.Sql.Parameters("@ordrfrm").Value = 11
                    ElseIf Coopordr.Data = "購買発注" Then
                        ホーム.Sql.Parameters("@ordrfrm").Value = 12
                    End If
                    If Coopcntrct.Data = True Then
                        ホーム.Sql.Parameters("@e_cntrct").Value = "true"
                    Else
                        ホーム.Sql.Parameters("@e_cntrct").Value = "false"
                    End If

                    ホーム.Sql.ExecuteNonQuery()
                End If
            Next
            ホーム.Modified = "false"
            Me.Close()
            MsgBox("登録完了", MsgBoxStyle.OkOnly, "協力業者登録")
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub
End Class