Imports C1.Win.C1FlexGrid
Imports System.Data.SqlClient
Public Class 出来高入力
    Public DtlIDlist As New List(Of Integer) '指定業者の明細書IDリスト
    Dim ErrorCheck As Integer = 0

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
        Try

            DetailsList.Visible = False
            Unit1.Visible = False
            Unit2.Visible = False
            Unit3.Visible = False
            TotalList.Visible = False
            TotalLabel.Visible = False

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
            Dim deadlineDate As String = ホーム.Sql.ExecuteScalar
            If deadlineDate = "" Then
                MsgBox("先に締切日を登録してください。", MsgBoxStyle.OkOnly, "エラー")
                Me.Close()
                Exit Sub
            End If
            Deadline.Text = deadlineDate.Replace("-", "/")

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

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
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
        Try
            'If 外注内訳入力.ChangeFlag >= 1 Then
            '    If MsgBox("変更した内容が登録されていません。よろしいですか？", MsgBoxStyle.OkCancel, "確認") = MsgBoxResult.Cancel Then
            '        VendorList.Value = 外注内訳入力.ChangeValue
            '        Exit Sub
            '    Else
            '        外注内訳入力.ChangeFlag = 0
            '    End If
            'End If

            DetailsList.Clear(ClearFlags.Content)
            VendorList.Focus()
            DetailsList.Visible = True
            Unit1.Visible = True
            Unit2.Visible = True
            Unit3.Visible = True
            TotalList.Visible = True
            TotalLabel.Visible = True

            Me.DetailsList.Rows.Count = 3
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

            DetailsList.Cols（0）.Width = 0
            DetailsList.Cols（1）.Width = 0
            DetailsList.Cols（2）.Width = 60
            DetailsList.Cols（3）.Width = 120
            DetailsList.Cols（4）.Width = 40
            DetailsList.Cols（5）.Width = 150
            DetailsList.Cols（6）.Width = 150
            DetailsList.Cols（7）.Width = 150
            DetailsList.Cols（8）.Width = 150

            'DetailsList.Rows(1).

            '管理データから締切日を取得
            ホーム.Sql.CommandText = "SELECT contents FROM controldata WHERE class_code=30"
            Dim DeadlineDate As String = ホーム.Sql.ExecuteScalar
            Deadline.Text = DeadlineDate.Replace("-", "/")

            '外注業者テーブルからデータを取得し、コンボボックスに入れる
            'Dim dt As DataTable
            'dt = New DataTable
            'dt.Columns.Add("ID", GetType(System.Int32))
            'dt.Columns.Add("Code", GetType(System.Int32))
            'dt.Columns.Add("Name", GetType(System.String))
            'Dim id As Int32
            'Dim code As Int32
            'Dim name As String

            'ホーム.Sql.CommandText = "SELECT * FROM outsourcers"
            'Dim Coopreader As SqlDataReader = ホーム.Sql.ExecuteReader
            'While Coopreader.Read
            '    id = Coopreader("outsrcr_id")
            '    code = Coopreader("outsrcr_code")
            '    name = Coopreader("outsrcr_name")
            '    dt.Rows.Add(id, code, name)
            'End While
            'Coopreader.Close()

            '選択した業者の業者IDを取得
            If VendorList.SelectedIndex >= 0 Then
                VendorNo.Text = VendorList.SelectedItem
            End If
            ホーム.Sql.Parameters.Clear()
            ホーム.Sql.CommandText = "SELECT outsrcr_id FROM outsourcers WHERE outsrcr_code = " & VendorList.Value
            Dim Coopid As Integer = ホーム.Sql.ExecuteScalar

            Dim DtlIDlist As New List(Of Integer) '指定業者の明細書IDリスト
            Dim Oquanity As Decimal
            Dim Ocostea As Int64

            '外注計画テーブルから指定の外注業者IDで明細書IDを取得しリストに入れる
            ホーム.Sql.Parameters.Clear()
            ホーム.Sql.CommandText = "SELECT dtl_id,outsrcng_quanity,outsrcng_costea FROM outsourcing_plans WHERE outsrcr_id = " & Coopid & "AND outsrc_no = (SELECT MAX(outsrc_no) FROM outsourcing_plans)"
            Dim DtlID As SqlDataReader = ホーム.Sql.ExecuteReader
            While DtlID.Read
                Oquanity = DtlID.Item("outsrcng_quanity")
                Ocostea = DtlID.Item("outsrcng_costea")
                '数量０単価０で登録されている明細書IDは省く
                If Oquanity = 0 And Ocostea = 0 Then
                    Continue While
                End If
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
            Dim quanity As Decimal
            Dim costea As Int64
            Dim total As Int64
            Dim OutsourcTotal As Int64

            For DtlIDloop As Integer = 0 To DtlIDlist.Count - 1
                If DtlIDlist.Item(DtlIDloop) = 0 Then
                    Continue For
                Else
                    ホーム.Sql.Parameters.Clear()
                ホーム.Sql.CommandText = "SELECT * FROM outsourcing_plans WHERE dtl_id = " & DtlIDlist.Item(DtlIDloop) & "AND outsrc_no = (SELECT MAX(outsrc_no) FROM outsourcing_plans) AND outsrcr_id = " & Coopid
                Dim outsrcng As SqlDataReader = ホーム.Sql.ExecuteReader
                While outsrcng.Read
                    Me.DetailsList.Rows.Add()
                    Me.DetailsList.Rows.Add()
                    Me.DetailsList.Rows.Add()

                    DetailsList(Conrow1, 5) = outsrcng.Item("outsrcng_costea")
                    Dim stl1 As C1.Win.C1FlexGrid.CellStyle = DetailsList.Styles.Add("WhiteSmoke")
                    stl1.BackColor = Color.WhiteSmoke
                    DetailsList.SetCellStyle(Conrow1, 7, stl1)
                    DetailsList.SetCellStyle(Conrow1, 8, stl1)
                    Dim stl2 As C1.Win.C1FlexGrid.CellStyle = DetailsList.Styles.Add("AliceBlue")
                    stl2.BackColor = Color.AliceBlue
                    DetailsList.SetCellStyle(Conrow2, 7, stl2)
                    Dim Outcostea As CellRange = DetailsList.GetCellRange(Conrow1, 5)
                    Outcostea.StyleNew.Format = "N0"

                    DetailsList(Conrow2, 5) = outsrcng.Item("outsrcng_quanity")
                    DetailsList.Rows(Conrow2).StyleNew.Format = "N1"
                    'Dim Outquanity As CellRange = DetailsList.GetCellRange(Conrow2, 5)
                    'Outquanity.StyleNew.Format = "N1"

                    quanity = DetailsList(Conrow2, 5)
                    costea = DetailsList(Conrow1, 5)
                    total = Math.Floor(quanity * costea)
                    DetailsList(Conrow3, 5) = total
                    DetailsList.Rows(Conrow3).StyleNew.Format = "N0"
                    Dim Outtotal As CellRange = DetailsList.GetCellRange(Conrow3, 5)
                    Outtotal.StyleNew.Format = "N0"

                    DetailsList.Rows(Conrow1).AllowEditing = False
                    DetailsList.Rows(Conrow2).AllowEditing = True
                    DetailsList.Rows(Conrow3).AllowEditing = False
                    OutsourcTotal += total
                End While
                Conrow1 += 3
                Conrow2 += 3
                Conrow3 += 3
                outsrcng.Close()
                TotalList(0, 1) = OutsourcTotal

                '明細書IDで明細書テーブルからデータを取得
                ホーム.Sql.Parameters.Clear()
                    ホーム.Sql.CommandText = "SELECT * FROM details WHERE dtl_id =" & DtlIDlist.Item(DtlIDloop) & "AND budget_no = (SELECT MAX(budget_no) FROM details) ORDER BY s_worktype_code,dtl_no ASC"
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

                    If Detarow1 Mod 2 = 0 Then
                        DetailsList.Rows(Detarow1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        DetailsList.Rows(Detarow1 + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        DetailsList.Rows(Detarow1 + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                    End If

                End While
                Detarow1 += 3
                Detarow2 += 3
                Detarow3 += 3
                details.Close()
                End If
            Next

            '前月出来高を取得し、当月出来高を計算する
            Dim totalrow1 As Integer = 4
            Dim totalrow2 As Integer = 5
            Dim lastrow1 As Integer = 3
            Dim lastrow2 As Integer = 4
            Dim lastrow3 As Integer = 5
            For DtlIDloop As Integer = 0 To DtlIDlist.Count - 1
                If DtlIDlist.Item(DtlIDloop) = 0 Then
                    Continue For
                Else
                    ホーム.Sql.Parameters.Clear()
                    ホーム.Sql.Parameters.Add(New SqlParameter("@DLDATE", SqlDbType.Date))
                    ホーム.Sql.Parameters("@DLDATE").Value = Deadline.Value
                    ホーム.Sql.CommandText = "SELECT * FROM productions WHERE dtl_id =" & DtlIDlist.Item(DtlIDloop) & "AND closing_date = @DLDATE  AND outsrcr_id = " & Coopid
                    Dim production As SqlDataReader = ホーム.Sql.ExecuteReader
                    Dim LastTotal As Integer
                    Dim TotalTotal As Integer
                    While production.Read
                        Dim LastAmount As Integer
                        Dim TotalAmount As Integer
                        Dim TotalQuanity As Decimal

                        TotalQuanity = production.Item("total_quanity")
                        DetailsList(totalrow1, 7) = TotalQuanity
                        DetailsList.GetCellRange(totalrow1, 7).StyleNew.Format = "N1"

                        TotalAmount = production.Item("total_amount")
                        DetailsList(totalrow2, 7) = TotalAmount
                        Dim Totalamountstyle As CellRange = DetailsList.GetCellRange(totalrow2, 7)
                        DetailsList.GetCellRange(totalrow2, 7).StyleNew.Format = "N0"

                        DetailsList(lastrow1, 6) = production.Item("last_costea")
                        Dim lastcostea As CellRange = DetailsList.GetCellRange(lastrow1, 6)
                        lastcostea.StyleNew.Format = "N0"

                        DetailsList(lastrow2, 6) = production.Item("last_quanity")
                        DetailsList.GetCellRange(lastrow2, 6).StyleNew.Format = "N1"
                        'Dim LastQuanityStyle As CellRange = DetailsList.GetCellRange(lastrow2, 6)
                        'LastQuanityStyle.StyleNew.Format = "N1"

                        LastAmount = production.Item("last_amount")
                        DetailsList(lastrow3, 6) = LastAmount

                        LastTotal += LastAmount
                        TotalTotal += TotalAmount
                    End While
                    production.Close()
                    TotalList(0, 2) = LastTotal
                    TotalList(0, 3) = TotalTotal

                    quanity = DetailsList(totalrow1, 7)
                    total = DetailsList(totalrow2, 7)

                    Dim Lquanity As Decimal = DetailsList(totalrow1, 6)
                    Dim Ltotal As Integer = DetailsList(totalrow2, 6)
                    Dim Cuquanity As Decimal
                    Dim Cuamount As Decimal
                    Dim Cutotal As Integer

                    Cuquanity = quanity - Lquanity
                    DetailsList(totalrow1, 8) = Cuquanity
                    DetailsList.GetCellRange(totalrow1, 8).StyleNew.Format = "N1"

                    Cuamount = total - Ltotal
                    DetailsList(totalrow2, 8) = Cuamount
                    DetailsList.GetCellRange(totalrow2, 8).StyleNew.Format = "N0"

                    Cutotal += Cuamount
                    TotalList(0, 4) = Cutotal

                    DetailsList.Rows(totalrow2 - 2).AllowEditing = False

                    totalrow1 += 3
                    totalrow2 += 3
                    lastrow1 += 3
                    lastrow2 += 3
                    lastrow3 += 3
                End If
            Next
            While DetailsList.Rows.Count < 21
                DetailsList.Rows.Add()
            End While
            Me.DetailsList.Rows.Add()
            Me.DetailsList.Rows.Add()
            Me.DetailsList.Rows.Add()

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub DetailsList_AfterEdit(sender As Object, e As RowColEventArgs) Handles DetailsList.AfterEdit
        Try
            Dim quanity As Decimal
            Dim Concostea As Int64
            Dim amount As Int64
            Dim Totalamount As Int64
            Dim Lquanity As Decimal
            Dim Lamount As Int64
            Dim Cuquanity As Decimal
            Dim Cuamount As Int64
            Dim Cutotal As Int64

            '累計出来高の合計と当月出来高を計算する。一式の場合は、数量１とし、金額を入力する。
            If Not DetailsList(e.Row - 2, 4) = "式" Then
                quanity = DetailsList(e.Row, e.Col)
                Concostea = DetailsList(e.Row - 1, 5)
                If Concostea = 0 Then
                    'DetailsList.Rows(e.Row + 1).AllowEditing = True
                Else
                    Lquanity = DetailsList(e.Row, 6)
                    Lamount = DetailsList(e.Row + 1, 6)

                    Cuquanity = quanity - Lquanity
                    DetailsList(e.Row, 8) = Cuquanity

                    amount = Math.Floor(quanity * Concostea)
                    DetailsList(e.Row + 1, e.Col) = amount

                    Cuamount = amount - Lamount
                    DetailsList(e.Row + 1, 8) = Cuamount
                    If amount > DetailsList(e.Row + 1, 5) Then
                        Dim errorco As CellRange = DetailsList.GetCellRange(e.Row + 1, 7)
                        errorco.StyleNew.ForeColor = Color.Red
                        MsgBox("累計出来高の金額が、契約金額を超えています。", MsgBoxStyle.OkOnly, "エラー")
                        ErrorCheck += 1
                    Else
                        Dim errorco As CellRange = DetailsList.GetCellRange(e.Row + 1, 7)
                        errorco.StyleNew.ForeColor = Color.FromArgb(68, 68, 68)
                        ErrorCheck -= 1
                    End If

                End If
            Else
                Lamount = DetailsList(e.Row, 6)
                amount = DetailsList(e.Row, e.Col)
                Cuamount = amount - Lamount
                DetailsList(e.Row, 8) = Cuamount
                If amount > DetailsList(e.Row, 5) Then
                    Dim errorco As CellRange = DetailsList.GetCellRange(e.Row, 7)
                    errorco.StyleNew.ForeColor = Color.Red
                    MsgBox("累計出来高の金額が、契約金額を超えています。", MsgBoxStyle.OkOnly, "エラー")
                    ErrorCheck += 1
                Else
                    Dim errorco As CellRange = DetailsList.GetCellRange(e.Row, 7)
                    errorco.StyleNew.ForeColor = Color.FromArgb(68, 68, 68)
                    ErrorCheck -= 1
                End If


            End If

            Dim RowsCount As Integer = DetailsList.Rows.Count / 3 - 1
            For totalloop As Integer = 1 To RowsCount
                amount = DetailsList(totalloop * 3 + 2, 7)
                Totalamount += amount
                Cuamount = DetailsList(totalloop * 3 + 2, 8)
                Cutotal += Cuamount
            Next
            TotalList(0, 3) = Totalamount
            TotalList(0, 4) = Cutotal

            '外注内訳入力.ChangeValue = VendorList.SelectedItem
            '外注内訳入力.ChangeFlag += 1

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub DetailsList_BeforeEdit(sender As Object, e As RowColEventArgs) Handles DetailsList.BeforeEdit
        Try
            '一式の場合は、数量１とし、金額を入力させる。
            If DetailsList(e.Row - 1, 4) = "式" Then
                DetailsList(e.Row, e.Col) = 1
                DetailsList(e.Row, 8) = 1
                e.Cancel = True
                DetailsList.Rows(e.Row + 1).AllowEditing = True
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub
    Private Sub Entry_Click(sender As Object, e As EventArgs) Handles Entry.Click
        'Try
        If ErrorCheck >= 1 Then
                MsgBox("累計出来高の金額が、契約金額を超えている行があります。", MsgBoxStyle.OkOnly, "エラー")
                Exit Sub
            End If
            '選択した業者の業者IDを取得
            If VendorList.SelectedIndex >= 0 Then
                VendorNo.Text = VendorList.SelectedItem
            End If
            ホーム.Sql.Parameters.Clear()
            ホーム.Sql.CommandText = "SELECT outsrcr_id FROM outsourcers WHERE outsrcr_code = " & VendorList.Value
            Dim outsrcrID As Integer = ホーム.Sql.ExecuteScalar

            Dim DtlIDlist As New List(Of Integer) '指定業者の明細書IDリスト

            '外注計画テーブルから外注業者IDで明細書IDを取得しリストに入れる
            ホーム.Sql.Parameters.Clear()
            ホーム.Sql.CommandText = "SELECT dtl_id FROM outsourcing_plans WHERE outsrcr_id = " & outsrcrID & "AND outsrc_no = (SELECT MAX(outsrc_no) FROM outsourcing_plans)"
            Dim DtlID As SqlDataReader = ホーム.Sql.ExecuteReader
            While DtlID.Read
                'dtl_id=0 はあたまなので表示されない
                If DtlID.Item("dtl_id") = 0 Then
                    Continue While
                End If
                DtlIDlist.Add(DtlID.Item("dtl_id"))
            End While
            DtlID.Close()

            Dim Rowcount As Integer = 3
            For Detailsloop As Integer = 1 To DtlIDlist.Count
                'Dim CoopID As Integer = VendorNo.Text
                Dim Dline As Date = Deadline.Text
                Dim DetailsID As CellRange = DetailsList.GetCellRange(Rowcount, 1)
                Dim TCostea As CellRange = DetailsList.GetCellRange(Rowcount, 5)
                Dim Tquanity As CellRange = DetailsList.GetCellRange(Rowcount + 1, 7)
                Dim Tamount As CellRange = DetailsList.GetCellRange(Rowcount + 2, 7)
                ホーム.Sql.Parameters.Clear()
                ホーム.Sql.CommandText = "SELECT ISNULL(COUNT(dtl_id),0) FROM productions WHERE dtl_id = " & DetailsID.Data & " AND closing_date = @DLDATE  AND outsrcr_id = " & outsrcrID
                ホーム.Sql.Parameters.Add(New SqlParameter("@DLDATE", SqlDbType.Date))
                ホーム.Sql.Parameters("@DLDATE").Value = Deadline.Value
                Dim DtlIDcount As Integer = ホーム.Sql.ExecuteScalar
                If DtlIDcount = 0 Then
                    ホーム.Sql.CommandText = ""
                    ホーム.Sql.Parameters.Clear()
                    ホーム.Sql.CommandText = "INSERT INTO productions (closing_date,dtl_id,outsrcr_id,total_costea,total_quanity,total_amount) VALUES (@closing_date,@dtl_id,@outsrcr_id,@total_costea,@total_quanity,@total_amount)"
                Else
                    ホーム.Sql.CommandText = ""
                    ホーム.Sql.Parameters.Clear()
                    ホーム.Sql.CommandText = "UPDATE productions SET closing_date=@closing_date,dtl_id=@dtl_id,outsrcr_id=@outsrcr_id,total_costea=@total_costea,total_quanity=@total_quanity,total_amount=@total_amount where outsrcr_id = " & outsrcrID & " AND dtl_id = " & DetailsID.Data & "AND closing_date = @DLDATE"
                End If
                ホーム.Sql.Parameters.Add(New SqlParameter("@DLDATE", SqlDbType.Date))
                ホーム.Sql.Parameters("@DLDATE").Value = Deadline.Value
                ホーム.Sql.Parameters.Add(New SqlParameter("@closing_date", SqlDbType.Date))
                ホーム.Sql.Parameters.Add(New SqlParameter("@dtl_id", SqlDbType.Int))
                ホーム.Sql.Parameters.Add(New SqlParameter("@outsrcr_id", SqlDbType.Int))
                ホーム.Sql.Parameters.Add(New SqlParameter("@total_costea", SqlDbType.Money))
                ホーム.Sql.Parameters.Add(New SqlParameter("@total_quanity", SqlDbType.Decimal))
                ホーム.Sql.Parameters.Add(New SqlParameter("@total_amount", SqlDbType.Money))
                ホーム.Sql.Parameters("@closing_date").Value = Dline.Date
                ホーム.Sql.Parameters("@dtl_id").Value = DetailsID.Data
                ホーム.Sql.Parameters("@outsrcr_id").Value = outsrcrID
                If TCostea.Data = Nothing Then
                    ホーム.Sql.Parameters("@total_costea").Value = 0
                Else
                    ホーム.Sql.Parameters("@total_costea").Value = TCostea.Data
                End If
                If Tquanity.Data = Nothing Then
                    ホーム.Sql.Parameters("@total_quanity").Value = 0
                Else
                    ホーム.Sql.Parameters("@total_quanity").Value = Tquanity.Data
                End If
                If Tamount.Data = Nothing Then
                    ホーム.Sql.Parameters("@total_amount").Value = 0
                Else
                    ホーム.Sql.Parameters("@total_amount").Value = Tamount.Data
                End If

                ホーム.Sql.ExecuteNonQuery()

                Rowcount += 3
            Next

            '外注内訳入力.ChangeFlag = 0
            MsgBox("登録完了", MsgBoxStyle.OkOnly, "出来高登録")

        'Catch ex As Exception
        '    ホーム.ErrorMessage = ex.Message
        '    ホーム.StackTrace = ex.StackTrace
        '    エラー.Show()
        '    Exit Sub
        'End Try
    End Sub

End Class