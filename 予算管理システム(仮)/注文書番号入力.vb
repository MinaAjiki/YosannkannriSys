Imports C1.Win.C1FlexGrid
Imports System.Data.SqlClient

Public Class 注文書番号入力
    Public ChangeHistory As String
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

    Private Sub C1SplitterPanel1_Click(sender As Object, e As EventArgs) Handles C1SplitterPanel1.Click

    End Sub

    Private Sub 注文書番号入力_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            '行数取得のため協力業者数カウント
            ホーム.Sql.Parameters.Clear()
            ホーム.Sql.CommandText = "SELECT count(outsrcr_id) FROM outsourcers"
            Dim Outsrcrcount As Integer = ホーム.Sql.ExecuteScalar

            If Outsrcrcount = 0 Then
                MsgBox("外注業者を登録してください。", MsgBoxStyle.OkOnly, "エラー")
                Exit Sub
            End If

            '協力業者テーブルからデータを取得
            Dim datacount As Integer = 1
            ホーム.Sql.CommandText = "SELECT * FROM outsourcers"
            Dim Coopreader As SqlDataReader = ホーム.Sql.ExecuteReader

            While Coopreader.Read
                OrderNoList(datacount, 0) = Coopreader.Item("outsrcr_id")
                OrderNoList(datacount, 2) = Coopreader.Item("outsrcr_code")
                OrderNoList(datacount, 3) = Coopreader.Item("outsrcr_name")

                datacount += 1

            End While
            Coopreader.Close()

            datacount = 1

            '合計注文金額を計算
            For Vendorloop As Integer = 1 To Outsrcrcount
                ホーム.Sql.Parameters.Clear()
                ホーム.Sql.CommandText = "SELECT ISNULL(SUM(outsrcng_quanity*outsrcng_costea),0) FROM outsourcing_plans WHERE outsrcr_id = " & OrderNoList(datacount, 0) & "AND outsrc_no = (SELECT MAX(outsrc_no) FROM outsourcing_plans)"
                Dim Amount As Integer = ホーム.Sql.ExecuteScalar
                OrderNoList(datacount, 4) = Amount
                datacount += 1
            Next

            datacount = 1

            '注文書テーブルから注文番号を取得
            For OrderNo As Integer = 1 To Outsrcrcount
                ホーム.Sql.Parameters.Clear()
                ホーム.Sql.CommandText = "SELECT no FROM purchase_orders WHERE outsrcr_id =" & OrderNoList(OrderNo, 0)
                Dim OrderNoRead As String = ホーム.Sql.ExecuteScalar
                If OrderNoRead = Nothing Then
                    OrderNoList(OrderNo, 1) = ""
                Else
                    OrderNoList(OrderNo, 1) = OrderNoRead
                End If
            Next

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub OrderNoList_AfterEdit(sender As Object, e As RowColEventArgs) Handles OrderNoList.AfterEdit
        If ChangeHistory <> OrderNoList(e.Row, e.Col) Then
            Dim SetImageRow As Integer = e.Row
            OrderNoList.SetCellImage(SetImageRow, 5, Image.FromFile(Application.StartupPath & "\Resources\Edit_source.png"))
        End If
    End Sub

    Private Sub Entry_Click(sender As Object, e As EventArgs) Handles Entry.Click
        Try
            ホーム.Sql.Parameters.Clear()
            ホーム.Sql.CommandText = "SELECT count(outsrcr_id) FROM outsourcers"
            Dim Outsrcrcount As Integer = ホーム.Sql.ExecuteScalar
            For Vendorloop As Integer = 1 To Outsrcrcount
                Dim CoopID As CellRange = OrderNoList.GetCellRange(Vendorloop, 0)
                Dim OrderNo As CellRange = OrderNoList.GetCellRange(Vendorloop, 1)
                Dim d As String = OrderNo.Data
                Dim length As Integer = d.Length
                If OrderNo.Data <> "" Then
                    If length <> 6 Then
                        MsgBox("注文番号の桁数が正しくありません。", MsgBoxStyle.OkOnly, "エラー")
                        Exit Sub
                    End If
                End If
                ホーム.Sql.Parameters.Clear()
                ホーム.Sql.CommandText = "Select count(outsrcr_id) from purchase_orders where outsrcr_id =" & CoopID.Data
                Dim CoopIDcount As Integer = ホーム.Sql.ExecuteScalar
                If CoopIDcount = 0 Then
                    ホーム.Sql.CommandText = ""
                    ホーム.Sql.Parameters.Clear()
                    ホーム.Sql.CommandText = "INSERT INTO purchase_orders (outsrcr_id,no) VALUES (@outsrcr_id,@no)"
                Else
                    ホーム.Sql.CommandText = ""
                    ホーム.Sql.Parameters.Clear()
                    ホーム.Sql.CommandText = "UPDATE purchase_orders SET no=@no where outsrcr_id=@outsrcr_id"
                End If
                ホーム.Sql.Parameters.Add(New SqlParameter("@outsrcr_id", SqlDbType.Int))
                ホーム.Sql.Parameters.Add(New SqlParameter("@no", SqlDbType.NVarChar))
                ホーム.Sql.Parameters("@outsrcr_id").Value = CoopID.Data
                ホーム.Sql.Parameters("@no").Value = OrderNo.Data
                ホーム.Sql.ExecuteNonQuery()
            Next
            Me.Close()
        MsgBox("登録完了", MsgBoxStyle.OkOnly, "注文書番号登録")

        Catch ex As Exception
        ホーム.ErrorMessage = ex.Message
        ホーム.StackTrace = ex.StackTrace
        エラー.Show()
        Exit Sub
        End Try
    End Sub

    Private Sub OrderNoList_BeforeEdit(sender As Object, e As RowColEventArgs) Handles OrderNoList.BeforeEdit
        ChangeHistory = OrderNoList(e.Row, e.Col)
    End Sub
End Class