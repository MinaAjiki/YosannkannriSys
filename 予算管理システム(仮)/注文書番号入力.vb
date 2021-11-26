Imports C1.Win.C1FlexGrid
Imports System.Data.SqlClient

Public Class 注文書番号入力
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
        'ホーム.Connection.Close()
        'ホーム.Connection.Dispose()
        ''ホーム.Connection.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & ホーム.UserDataPath & "" & ホーム.UserDataName & ";Integrated Security=True"
        'ホーム.Connection.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\217003\source\repos\MinaAjiki\YosankanriSys\予算管理システム(仮)\現場データ.mdf;Integrated Security=True"
        'ホーム.Connection.Open()
        'ホーム.SystemSql.Connection = ホーム.Connection

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

        Dim SystmCnnctn As New SqlConnection
        Dim SystemSql As New SqlCommand
        SystmCnnctn.Close()
        SystmCnnctn.Dispose()
        SystmCnnctn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\217003\source\repos\MinaAjiki\YosankanriSys\予算管理システム(仮)\現場データ.mdf;Integrated Security=True"
        SystmCnnctn.Open()
        SystemSql.Connection = SystmCnnctn



        datacount = 1

        '合計注文金額を計算
        For Vendorloop As Integer = 1 To Outsrcrcount
            '外注業者IDで明細書テーブルから明細書IDを取得
            ホーム.Sql.Parameters.Clear()
            ホーム.Sql.CommandText = "SELECT dtl_id FROM details WHERE outsrcr_id = " & OrderNoList(datacount, 0)
            Dim DtlID As SqlDataReader = ホーム.Sql.ExecuteReader
            '明細書IDごとに計算し合計して出力
            Dim Total As New Integer
            While DtlID.Read
                SystemSql.Parameters.Clear()
                SystemSql.CommandText = "SELECT SUM(outsrcng_quanity*outsrcng_costea) FROM outsourcing_plans WHERE dtl_id = " & DtlID.Item("dtl_id")
                Dim quacos As Integer = SystemSql.ExecuteScalar
                Total += quacos
            End While
            OrderNoList(datacount, 4) = Total
            datacount += 1
            DtlID.Close()
        Next

        datacount = 1

        '注文書テーブルから注文番号を取得
        ホーム.Sql.Parameters.Clear()
        ホーム.Sql.CommandText = "SELECT * FROM purchase_orders"
        Dim OrderNoreader As SqlDataReader = ホーム.Sql.ExecuteReader
        While OrderNoreader.Read
            If OrderNoreader.Item("outsrcr_id") = OrderNoList(datacount, 0) Then
                If OrderNoreader.Item("no") = Nothing Then
                    OrderNoList(datacount, 1) = ""
                Else
                    OrderNoList(datacount, 1) = OrderNoreader.Item("no")
                    datacount += 1
                End If
            End If
        End While
        OrderNoreader.Close()


    End Sub

    Private Sub OrderNoList_AfterEdit(sender As Object, e As RowColEventArgs) Handles OrderNoList.AfterEdit
        Dim SetImageRow As Integer = e.Row
        OrderNoList.SetCellImage(SetImageRow, 5, Image.FromFile(Application.StartupPath & "\Edit_source.png"))
    End Sub

    Private Sub Entry_Click(sender As Object, e As EventArgs) Handles Entry.Click
        ホーム.Sql.Parameters.Clear()
        ホーム.Sql.CommandText = "SELECT count(outsrcr_id) FROM outsourcers"
        Dim Outsrcrcount As Integer = ホーム.Sql.ExecuteScalar
        For Vendorloop As Integer = 1 To Outsrcrcount
            Dim CoopID As CellRange = OrderNoList.GetCellRange(Vendorloop, 0)
            Dim OrderNo As CellRange = OrderNoList.GetCellRange(Vendorloop, 1)
            If OrderNo.Data = Nothing Then
                MsgBox("注文番号を入力してください。", MsgBoxStyle.OkOnly, "エラー")
                Exit Sub
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
    End Sub
End Class