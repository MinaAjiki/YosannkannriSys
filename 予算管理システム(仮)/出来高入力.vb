Imports C1.Win.C1FlexGrid
Imports System.Data.SqlClient
Public Class 出来高入力
    Public DtlIDlist As New List(Of Integer) '指定業者の明細書IDリスト

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

    Private Sub 出来高入力_Load(sender As Object, e As EventArgs) Handles Me.Load
        DetailsList(0, 2) = "工種ｺｰﾄﾞ"
        DetailsList(0, 3) = "工種"
        DetailsList(0, 4) = "単位"
        DetailsList(1, 2) = "名称"
        DetailsList(2, 2) = "規格"

        DetailsList.MergedRanges.Add(1, 2, 1, 4)
        DetailsList.MergedRanges.Add(2, 2, 2, 4)
        DetailsList.MergedRanges.Add(0, 5, 2, 5)
        DetailsList.MergedRanges.Add(0, 6, 2, 6)
        DetailsList.MergedRanges.Add(0, 7, 2, 7)
        DetailsList.MergedRanges.Add(0, 8, 2, 8)

        ホーム.Sql.CommandText = "SELECT contents FROM controldata WHERE class_code=30"
        Deadline.Text = ホーム.Sql.ExecuteScalar

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
        VendorList.HtmlPattern = "<table><tr><td width=30>{ID}</td><tr><td width=30>{Code}</td><td width=270>{Name}</td></tr></table>"
        VendorList.SelectedIndex = -1
        VendorList.Text = "協力業者を選択"
        VendorNo.Text = Nothing

    End Sub
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

    Private Sub VendorList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles VendorList.SelectedIndexChanged
        DetailsList.Clear(ClearFlags.Content)
        DetailsList(0, 2) = "工種ｺｰﾄﾞ"
        DetailsList(0, 3) = "工種"
        DetailsList(0, 4) = "単位"
        DetailsList(0, 5) = "契約"
        DetailsList(0, 6) = "前回出来高"
        DetailsList(0, 7) = "累計出来高"
        DetailsList(0, 8) = "当月出来高"
        DetailsList(1, 2) = "名称"
        DetailsList(2, 2) = "規格"

        DetailsList.MergedRanges.Add(1, 2, 1, 4)
        DetailsList.MergedRanges.Add(2, 2, 2, 4)
        DetailsList.MergedRanges.Add(0, 5, 2, 5)
        DetailsList.MergedRanges.Add(0, 6, 2, 6)
        DetailsList.MergedRanges.Add(0, 7, 2, 7)
        DetailsList.MergedRanges.Add(0, 8, 2, 8)

        '管理データから締切日を取得
        ホーム.Sql.CommandText = "SELECT contents FROM controldata WHERE class_code=30"
        Deadline.Text = ホーム.Sql.ExecuteScalar

        '外注業者テーブルからデータを取得し、コンボボックスに入れる
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

        '選択した業者の業者IDを取得
        If VendorList.SelectedIndex >= 0 Then
            VendorNo.Text = VendorList.SelectedItem
        End If
        ホーム.Sql.Parameters.Clear()
        ホーム.Sql.CommandText = "SELECT outsrcr_id FROM outsourcers WHERE outsrcr_code = " & VendorList.Value
        Dim Coopid As Integer = ホーム.Sql.ExecuteScalar

        '明細テーブルから外注業者IDで明細書IDを取得しリストに入れる
        ホーム.Sql.Parameters.Clear()
        ホーム.Sql.CommandText = "SELECT dtl_id FROM details WHERE outsrcr_id = " & Coopid
        Dim DtlID As SqlDataReader = ホーム.Sql.ExecuteReader
        While DtlID.Read
            DtlIDlist.Add(DtlID.Item("dtl_id"))
        End While
        DtlID.Close()

        '明細書IDで外注計画テーブルからデータを取得
        Dim Conrow1 As Integer = 3
        Dim Conrow2 As Integer = 4
        Dim Conrow3 As Integer = 5
        Dim Detarow1 As Integer = 3
        Dim Detarow2 As Integer = 4
        Dim Detarow3 As Integer = 5
        Dim quanity As Integer
        Dim costea As Integer
        Dim total As Integer
        For DtlIDloop As Integer = 0 To DtlIDlist.Count - 1
            ホーム.Sql.Parameters.Clear()
            ホーム.Sql.CommandText = "SELECT * FROM outsourcing_plans WHERE dtl_id = " & DtlIDlist.Item(DtlIDloop)
            Dim outsrcng As SqlDataReader = ホーム.Sql.ExecuteReader
            While outsrcng.Read
                Me.DetailsList.Rows.Add()
                DetailsList(Conrow1, 5) = outsrcng.Item("outsrcng_costea")
                Dim stl As C1.Win.C1FlexGrid.CellStyle = DetailsList.Styles.Add("AliceBlue")
                stl.BackColor = Color.AliceBlue
                DetailsList.SetCellStyle(Conrow2, 7, stl)
                DetailsList(Conrow2, 5) = outsrcng.Item("outsrcng_quanity")
                quanity = DetailsList(Conrow1, 5)
                costea = DetailsList(Conrow2, 5)
                total = quanity * costea
                DetailsList(Conrow3, 5) = total
                DetailsList.Rows(Conrow3).AllowEditing = False
                DetailsList.Rows(Conrow1).AllowEditing = False
            End While
            Conrow1 += 3
            Conrow2 += 3
            Conrow3 += 3
            outsrcng.Close()

            '明細書IDで明細書テーブルからデータを取得
            ホーム.Sql.Parameters.Clear()
            ホーム.Sql.CommandText = "SELECT * FROM details WHERE dtl_id =" & DtlIDlist.Item(DtlIDloop)
            Dim details As SqlDataReader = ホーム.Sql.ExecuteReader
            While details.Read
                DetailsList(Detarow1, 1) = details.Item("dtl_id")
                DetailsList(Detarow1, 2) = details.Item("s_worktype_code")
                DetailsList(Detarow1, 3) = details.Item("dtl_name")
                DetailsList(Detarow1, 4) = details.Item("dtl_unit")
                DetailsList(Detarow2, 2) = details.Item("dtl_name")
                DetailsList(Detarow2, 3) = details.Item("dtl_name")
                DetailsList(Detarow2, 4) = details.Item("dtl_name")
                DetailsList.MergedRanges.Add(Detarow2, 2, Detarow2, 4)
                DetailsList(Detarow3, 2) = details.Item("dtl_spec")
                DetailsList(Detarow3, 3) = details.Item("dtl_spec")
                DetailsList(Detarow3, 4) = details.Item("dtl_spec")
                DetailsList.MergedRanges.Add(Detarow3, 2, Detarow3, 4)
            End While
            Detarow1 += 3
            Detarow2 += 3
            Detarow3 += 3
            details.Close()
        Next

        Dim totalrow1 As Integer = 4
        Dim totalrow2 As Integer = 5
        'Dim lastrow1 As Integer = 3
        'Dim lastrow2 As Integer = 4
        'Dim lastrow3 As Integer = 5
        For DtlIDloop As Integer = 0 To DtlIDlist.Count - 1
            ホーム.Sql.Parameters.Clear()
            ホーム.Sql.CommandText = "SELECT * FROM productions WHERE dtl_id =" & DtlIDlist.Item(DtlIDloop) ' & "AND closing_date=" & Deadline.Text
            Dim production As SqlDataReader = ホーム.Sql.ExecuteReader
            While production.Read
                DetailsList(totalrow1, 7) = production.Item("total_quanity")
                DetailsList(totalrow2, 7) = production.Item("total_amount")
            End While
            production.Close()

            quanity = DetailsList(totalrow1, 7)
            total = DetailsList(totalrow2, 7)

            Dim Lquanity As Integer = DetailsList(totalrow1, 6)
            Dim Ltotal As Integer = DetailsList(totalrow2, 6)
            Dim Cuquanity As Integer
            Dim Cutotal As Integer

            Cuquanity = quanity - Lquanity
            DetailsList(totalrow1, 8) = Cuquanity

            Cutotal = total - Ltotal
            DetailsList(totalrow2, 8) = Cutotal

            totalrow1 += 3
            totalrow2 += 3
        Next

    End Sub

    Private Sub DetailsList_AfterEdit(sender As Object, e As RowColEventArgs) Handles DetailsList.AfterEdit
        Dim quanity As Integer
        Dim Concostea As Integer
        Dim total As Integer
        Dim Conquanity As Integer
        Dim Contotal As Integer
        Dim Lquanity As Integer
        Dim Ltotal As Integer
        Dim Cuquanity As Integer
        Dim Cutotal As Integer

        '累計出来高の合計と当月出来高を計算する。一式の場合は、数量１とし、金額を入力する。
        If Not DetailsList(e.Row - 2, 4) = "式" Then

            quanity = DetailsList(e.Row, e.Col)
            Concostea = DetailsList(e.Row - 1, 5)
            total = quanity * Concostea
            DetailsList(e.Row + 1, e.Col) = total

            Lquanity = DetailsList(e.Row, 6)
            Ltotal = DetailsList(e.Row + 1, 6)

            Cuquanity = quanity - Lquanity
            DetailsList(e.Row, 8) = Cuquanity

            Cutotal = total - Ltotal
            DetailsList(e.Row + 1, 8) = Cutotal
        Else
            Ltotal = DetailsList(e.Row, 6)
            total = DetailsList(e.Row, e.Col)
            Cutotal = total - Ltotal
            DetailsList(e.Row, 8) = Cutotal
        End If

    End Sub

    Private Sub DetailsList_BeforeEdit(sender As Object, e As RowColEventArgs) Handles DetailsList.BeforeEdit
        '一式の場合は、数量１とし、金額を入力する。
        If DetailsList(e.Row - 1, 4) = "式" Then
            DetailsList(e.Row, e.Col) = 1
            DetailsList(e.Row, 8) = 1
            e.Cancel = True
            DetailsList.Rows(e.Row + 1).AllowEditing = True
        End If
    End Sub
    Private Sub Entry_Click(sender As Object, e As EventArgs) Handles Entry.Click
        Dim Rowcount As Integer = 3
        For Detailsloop As Integer = 1 To DtlIDlist.Count
            Dim CoopID As Integer = VendorNo.Text
            Dim Dline As Date = Deadline.Text
            Dim DtlID As CellRange = DetailsList.GetCellRange(Rowcount, 1)
            Dim TCostea As CellRange = DetailsList.GetCellRange(Rowcount, 5)
            Dim Tquanity As CellRange = DetailsList.GetCellRange(Rowcount + 1, 7)
            Dim Tamount As CellRange = DetailsList.GetCellRange(Rowcount + 2, 7)
            ホーム.Sql.Parameters.Clear()
            ホーム.Sql.CommandText = "Select isnull(count(dtl_id),0) from productions where dtl_id = " & DtlID.Data
            Dim DtlIDcount As Integer = ホーム.Sql.ExecuteScalar
            If DtlIDcount = 0 Then
                ホーム.Sql.CommandText = ""
                ホーム.Sql.Parameters.Clear()
                ホーム.Sql.CommandText = "INSERT INTO productions (closing_date,dtl_id,total_costea,total_quanity,total_amount) VALUES (@closing_date,@dtl_id,@total_costea,@total_quanity,@total_amount)"
            Else
                ホーム.Sql.CommandText = ""
                ホーム.Sql.Parameters.Clear()
                ホーム.Sql.CommandText = "UPDATE productions SET closing_date=@closing_date,dtl_id=@dtl_id,total_costea=@total_costea,total_quanity=@total_quanity,total_amount=@total_amount where dtl_id = " & DtlID.Data
            End If
            ホーム.Sql.Parameters.Add(New SqlParameter("@closing_date", SqlDbType.Date))
            ホーム.Sql.Parameters.Add(New SqlParameter("@dtl_id", SqlDbType.Int))
            ホーム.Sql.Parameters.Add(New SqlParameter("@total_costea", SqlDbType.Money))
            ホーム.Sql.Parameters.Add(New SqlParameter("@total_quanity", SqlDbType.Decimal))
            ホーム.Sql.Parameters.Add(New SqlParameter("@total_amount", SqlDbType.Money))
            ホーム.Sql.Parameters("@closing_date").Value = Dline.Date
            ホーム.Sql.Parameters("@dtl_id").Value = DtlID.Data
            ホーム.Sql.Parameters("@total_costea").Value = TCostea.Data
            ホーム.Sql.Parameters("@total_quanity").Value = Tquanity.Data
            ホーム.Sql.Parameters("@total_amount").Value = Tamount.Data
            ホーム.Sql.ExecuteNonQuery()

            Rowcount += 3
        Next
        Me.Close()
    End Sub
End Class