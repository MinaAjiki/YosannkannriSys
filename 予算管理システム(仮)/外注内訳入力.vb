Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports System.Data.SqlClient
Public Class 外注内訳入力
    Dim ChangeFlag As Integer
    Dim ChangeValue As Integer
    Dim outsrcr_x As Integer = 0
    Dim outsrcr_y As Integer = 0
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
    Private Sub cancel_MouseLeave(sender As Object, e As EventArgs) Handles Cancel.MouseLeave
        Cancel.ImageIndex = 6
    End Sub

    Private Sub cancel_MouseEnter(sender As Object, e As EventArgs) Handles Cancel.MouseEnter
        Cancel.Cursor = Cursors.Hand
        Cancel.ImageIndex = 7
    End Sub

    Private Sub cancel_MouseDown(sender As Object, e As MouseEventArgs) Handles Cancel.MouseDown
        Cancel.ImageIndex = 8
    End Sub
    Private Sub create_MouseLeave(sender As Object, e As EventArgs) Handles Create.MouseLeave
        Create.ImageIndex = 0
    End Sub

    Private Sub create_MouseEnter(sender As Object, e As EventArgs) Handles Create.MouseEnter
        Create.Cursor = Cursors.Hand
        Create.ImageIndex = 1
    End Sub

    Private Sub create_MouseDown(sender As Object, e As MouseEventArgs) Handles Create.MouseDown
        Create.ImageIndex = 2
    End Sub

    Private Sub 外注内訳入力_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            進行状況.Show()
            進行状況.Refresh()
            DetailList(0, 2) = "工種"
            DetailList(1, 2) = "工種"
            DetailList(2, 2) = "工種"
            DetailList(0, 3) = "工種名"
            DetailList(0, 5) = "数量"
            DetailList(1, 3) = "名称"
            DetailList(1, 4) = "名称"
            DetailList(2, 3) = "規格"
            DetailList(2, 4) = "規格"
            DetailList(0, 4) = "単位"
            DetailList(1, 5) = "単価"
            DetailList(2, 5) = "金額"
            DetailList(0, 6) = "直営分"
            DetailList(2, 6) = "金額"

            DetailList.MergedRanges.Add(0, 2, 2, 2)
            DetailList.MergedRanges.Add(1, 3, 1, 4)
            DetailList.MergedRanges.Add(2, 3, 2, 4)
            DetailList.MergedRanges.Add(0, 6, 1, 6)

            DetailList.Rows(0).Height = 17
            DetailList.Rows(1).Height = 17
            DetailList.Rows(2).Height = 17
            Breakdown.Rows(0).Height = 17
            Breakdown.Rows(1).Height = 17
            Breakdown.Rows(2).Height = 17

            TotalBreakdown.Cols.Frozen = 1

            'Breakdown.Footers.Descriptions.Add(New FooterDescription())
            'Breakdown.Footers.Fixed = True
            'Breakdown.Footers.Descriptions(0).Aggregates.Add(New AggregateDefinition())

            TotalBreakdown.ScrollBars = ScrollBars.None

            'BackgroundWorker1.RunWorkerAsync(10)

            '協力業者テーブルからレコード数を取得
            ホーム.Sql.Parameters.Clear()
            ホーム.Sql.CommandText = "SELECT count(outsrcr_id) from Outsourcers"
            Dim Vendorcount As Integer = ホーム.Sql.ExecuteScalar

            Dim Drow1 As Integer = 3
            Dim Drow2 As Integer = 4
            Dim Drow3 As Integer = 5

            ホーム.Sql.Parameters.Clear()
            ホーム.Sql.CommandText = "SELECT dtl_id,dtl_no,s_worktype_code,dtl_unit,dtl_name,dtl_quanity,dtl_costea,dtl_spec FROM details WHERE budget_no=" & ホーム.BudgetNo & "ORDER BY s_worktype_code,dtl_no ASC"
            Dim Detailreader As SqlDataReader = ホーム.Sql.ExecuteReader
            While Detailreader.Read
                Me.DetailList.Rows.Add()
                Me.DetailList.Rows.Add()
                Me.DetailList.Rows.Add()
                Me.Breakdown.Rows.Add()
                Me.Breakdown.Rows.Add()
                Me.Breakdown.Rows.Add()

                DetailList(Drow1, 0) = Detailreader.Item("dtl_id")
                DetailList(Drow1, 1) = Detailreader.Item("dtl_no")
                DetailList(Drow1, 2) = Detailreader.Item("s_worktype_code")
                DetailList(Drow1, 4) = Detailreader.Item("dtl_unit")
                DetailList(Drow2, 3) = Detailreader.Item("dtl_name")
                DetailList.MergedRanges.Add(Drow2, 3, Drow2, 4)

                Dim Dtlquanityitem As Decimal = Detailreader.Item("dtl_quanity")
                DetailList(Drow1, 5) = Dtlquanityitem
                Dim Dtlquanity As CellRange = DetailList.GetCellRange(Drow1, 5)
                Dtlquanity.StyleNew.Format = "N1"

                Dim DtlcosteaItem As Decimal = Detailreader.Item("dtl_costea")
                DetailList(Drow2, 5) = DtlcosteaItem
                Dim Dtlcostea As CellRange = DetailList.GetCellRange(Drow2, 5)
                Dtlcostea.StyleNew.Format = "N0"

                DetailList(Drow3, 3) = Detailreader.Item("dtl_spec")
                DetailList.MergedRanges.Add(Drow3, 3, Drow3, 4)

                DetailList(Drow3, 5) = Dtlquanityitem * DtlcosteaItem
                Dim Dtlamount As CellRange = DetailList.GetCellRange(Drow3, 5)
                Dtlamount.StyleNew.Format = "N0"

                If Drow1 Mod 2 = 0 Then
                    DetailList.Rows(Drow1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                    DetailList.Rows(Drow1 + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                    DetailList.Rows(Drow1 + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                    Breakdown.Rows(Drow1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                    Breakdown.Rows(Drow1 + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                    Breakdown.Rows(Drow1 + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                End If

                Drow1 += 3
                Drow2 += 3
                Drow3 += 3


            End While
            Detailreader.Close()

            Breakdown.Footers.Descriptions.Add(New FooterDescription())
            Breakdown.Footers.Fixed = True

            '工種名を取得
            ホーム.Sql.Parameters.Clear()
            ホーム.Sql.CommandText = "SELECT COUNT(dtl_id) FROM details WHERE budget_no=" & ホーム.BudgetNo
            Dim Detailscount As Integer = ホーム.Sql.ExecuteScalar

            For SWORKTYPEloop As Integer = 1 To Detailscount
                ホーム.SystemSql.CommandText = "SELECT s_wrktyp_name FROM s_worktypes WHERE s_wrktyp_code=" & DetailList(SWORKTYPEloop * 3, 2)
                Dim SwrktypName As String = ホーム.SystemSql.ExecuteScalar
                DetailList(SWORKTYPEloop * 3, 3) = SwrktypName
            Next

            '一番大きい変更回数を取得し、変更回数の上限下限をセット
            ホーム.Sql.CommandText = "SELECT ISNULL(MAX(outsrc_no),0) from Outsourcing_plans"
            Dim Maxoutsrc As Integer = ホーム.Sql.ExecuteScalar

            ContractNo.PostValidation.Validation = PostValidationTypeEnum.ValuesAndIntervals
            Dim valInteval_1 As ValueInterval = New ValueInterval(0, Maxoutsrc, True, True)
            ContractNo.PostValidation.Intervals.Add(valInteval_1)
            ContractNo.Value = Maxoutsrc

            進行状況.Close()
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub DetailList_AfterScroll(sender As Object, e As RangeEventArgs) Handles DetailList.AfterScroll
        'Breakdown.ScrollPosition = DetailList.ScrollPosition
        If Not outsrcr_x = Breakdown.ScrollPosition.X Then
            outsrcr_x = Breakdown.ScrollPosition.X
        End If
        If Not outsrcr_y = DetailList.ScrollPosition.Y Then
            outsrcr_y = DetailList.ScrollPosition.Y
        End If
        Breakdown.ScrollPosition = New Point(outsrcr_x, outsrcr_y)
    End Sub

    Private Sub Breakdown_AfterScroll(sender As Object, e As RangeEventArgs) Handles Breakdown.AfterScroll
        DetailList.ScrollPosition = Breakdown.ScrollPosition
        TotalBreakdown.ScrollPosition = Breakdown.ScrollPosition

        'If Not outsrcr_x = Breakdown.ScrollPosition.X Then
        '    outsrcr_x = Breakdown.ScrollPosition.X
        'End If
        'If Not outsrcr_y = Breakdown.ScrollPosition.Y Then
        '    outsrcr_y = Breakdown.ScrollPosition.Y
        'End If
        'TotalBreakdown.ScrollPosition = New Point(outsrcr_x, outsrcr_y)

    End Sub
    Private Sub TotalBreakdown_AfterScroll(sender As Object, e As RangeEventArgs) Handles TotalBreakdown.AfterScroll
        'Breakdown.ScrollPosition = TotalBreakdown.ScrollPosition
        'If Not outsrcr_x = TotalBreakdown.ScrollPosition.X Then
        '    outsrcr_x = TotalBreakdown.ScrollPosition.X
        'End If
        'If Not outsrcr_y = TotalBreakdown.ScrollPosition.Y Then
        '    outsrcr_y = TotalBreakdown.ScrollPosition.Y
        'End If
        'TotalBreakdown.ScrollPosition = New Point(outsrcr_x, outsrcr_y)
    End Sub
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Try
            If MsgBox("外注計画入力を閉じます。よろしいですか？", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                Me.Close()
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub ContractNo_ValueChanged(sender As Object, e As EventArgs) Handles ContractNo.ValueChanged
        Try
            'BackgroundWorker1.WorkerReportsProgress = True
            'BackgroundWorker1.WorkerSupportsCancellation = True
            'BackgroundWorker1.RunWorkerAsync(10)

            If ChangeFlag >= 1 Then
                If MsgBox("変更した内容が登録されていません。よろしいですか？", MsgBoxStyle.OkCancel, "確認") = MsgBoxResult.Cancel Then
                    ContractNo.Value = ChangeValue
                    Exit Sub
                Else
                    ChangeFlag = 0
                End If
            End If

            進行状況.Show()

            Breakdown.Clear(ClearFlags.Content)

            '協力業者テーブルから業者数を取得
            ホーム.Sql.Parameters.Clear()
            ホーム.Sql.CommandText = "SELECT count(outsrcr_id) from Outsourcers"
            Dim Vendorcount As Integer = ホーム.Sql.ExecuteScalar

            ホーム.Sql.Parameters.Clear()
            ホーム.Sql.CommandText = "SELECT outsrcr_id,outsrcr_code,outsrcr_name FROM outsourcers"

            Dim Coopcount As Integer = 1
            Dim Coopreader As SqlDataReader = ホーム.Sql.ExecuteReader
            While Coopreader.Read
                If Vendorcount >= 8 Then
                    Me.Breakdown.Cols.Count = Vendorcount + 1
                    Me.TotalBreakdown.Cols.Count = Vendorcount + 1
                End If
                Breakdown(2, Coopcount) = Coopreader.Item("outsrcr_id")
                Breakdown(0, Coopcount) = Coopreader.Item("outsrcr_code")
                Breakdown(1, Coopcount) = Coopreader.Item("outsrcr_name")
                Coopcount += 1
            End While
            Coopreader.Close()

            ホーム.Sql.Parameters.Clear()
            ホーム.Sql.CommandText = "SELECT COUNT(dtl_id) FROM details WHERE budget_no=" & ホーム.BudgetNo
            Dim Detailscount As Integer = ホーム.Sql.ExecuteScalar

            For vendorloop As Integer = 1 To Vendorcount
                Dim total As Integer = 0
                For BDloop As Integer = 1 To Detailscount
                    ホーム.Sql.Parameters.Clear()
                    ホーム.Sql.CommandText = "SELECT ISNULL(outsrcng_quanity,0) from Outsourcing_plans WHERE dtl_id = " & DetailList(BDloop * 3, 0) & "AND outsrcr_id=" & Breakdown(2, vendorloop) & "AND outsrc_no=" & ContractNo.Value
                    Dim Oquanity As Decimal = ホーム.Sql.ExecuteScalar
                    If Oquanity = 0 Then
                        Breakdown(BDloop * 3, vendorloop) = 0
                        Breakdown.Rows(BDloop * 3).StyleNew.Format = "N1"
                    Else
                        Breakdown(BDloop * 3, vendorloop) = Oquanity
                        Breakdown.Rows(BDloop * 3).StyleNew.Format = "N1"
                    End If

                    ホーム.Sql.Parameters.Clear()
                    ホーム.Sql.CommandText = "SELECT ISNULL(outsrcng_costea,0) from Outsourcing_plans WHERE dtl_id = " & DetailList(BDloop * 3, 0) & "AND outsrcr_id=" & Breakdown(2, vendorloop) & "AND outsrc_no=" & ContractNo.Value
                    Dim Ocostea As Integer = ホーム.Sql.ExecuteScalar
                    If Ocostea = 0 Then
                        Breakdown(BDloop * 3 + 1, vendorloop) = 0
                        Breakdown.Rows(BDloop * 3 + 1).StyleNew.Format = "N0"
                    Else
                        Breakdown(BDloop * 3 + 1, vendorloop) = Ocostea
                        Breakdown.Rows(BDloop * 3 + 1).StyleNew.Format = "N0"
                    End If

                    Dim Amount As Integer = Oquanity * Ocostea
                    Breakdown(BDloop * 3 + 2, vendorloop) = Amount
                    Breakdown.Rows(BDloop * 3 + 2).AllowEditing = False
                    Breakdown.Rows(BDloop * 3 + 2).StyleNew.Format = "N0"
                    total += Amount
                    TotalBreakdown(0, vendorloop) = total
                    TotalBreakdown.Rows(0).StyleNew.Format = "N0"

                Next
            Next

            '変更計画作成日を取得
            ホーム.Sql.Parameters.Clear()
            ホーム.Sql.CommandText = "SELECT created_date FROM outsourcing_plans WHERE budget_no=" & ホーム.BudgetNo & "AND outsrc_no=" & ContractNo.Value
            Dim CreateDate As Date = ホーム.Sql.ExecuteScalar
            If CreateDate = Nothing Then
                CreateDate = DateTime.Today
                CreatedDateBox.Value = CreateDate.ToString("D")
            Else
                CreatedDateBox.Value = CreateDate.ToString("D")
            End If

            '外注計画報告書テーブルから変更内容を取得
            ホーム.Sql.Parameters.Clear()
            ホーム.Sql.CommandText = "SELECT changes FROM Outsourcing_reports WHERE outsrc_no=" & ContractNo.Value
            Dim change As String = ホーム.Sql.ExecuteScalar
            ChangeDetail.Value = change

            '直営計算
            Dim Gtotal As Int64 '直営合計
            Dim DMtotal As Int64 '直営金額
            For DTloop As Integer = 1 To Detailscount
                Dim DM As Int64 = 0
                For DMloop As Integer = 1 To Vendorcount
                    DM += Breakdown(DTloop * 3 + 2, DMloop)
                Next
                Dim CoTotal As Int64 = DetailList(DTloop * 3 + 2, 5)
                DMtotal = CoTotal - DM
                DetailList(DTloop * 3 + 2, 6) = DMtotal
                Gtotal += DMtotal
            Next
            'TotalBox.Value = Gtotal
            TotalBreakdown(0, 0) = Gtotal
            進行状況.Close()

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub Breakdown_AfterEdit(sender As Object, e As RowColEventArgs) Handles Breakdown.AfterEdit
        Try
            Dim quanity As Decimal
            Dim costea As Int64
            Dim amount As Int64
            Dim total As Int64

            If Breakdown(e.Row, e.Col) = Nothing Then
                Breakdown(e.Row, e.Col) = 0
            End If

            If e.Row Mod 3 = 0 Then
                quanity = Breakdown(e.Row, e.Col)
                costea = Breakdown(e.Row + 1, e.Col)
                amount = Math.Floor(quanity * costea)
                Breakdown(e.Row + 2, e.Col) = amount
            Else
                quanity = Breakdown(e.Row - 1, e.Col)
                costea = Breakdown(e.Row, e.Col)
                amount = Math.Floor(quanity * costea)
                Breakdown(e.Row + 1, e.Col) = amount
            End If

            Dim Detailscount As Integer = Breakdown.Rows.Count / 3 - 1

            For BDloop As Integer = 1 To Detailscount
                total += Breakdown(BDloop * 3 + 2, e.Col)
            Next
            TotalBreakdown(0, e.Col) = total

            '直営計算
            Dim Gtotal As Int64 '直営合計
            Dim DMtotal As Int64 '直営金額
            Dim DM As Int64 '外注合計
            Dim CoTotal As Int64
            Dim Vendorcount As Integer = Breakdown.Cols.Count - 1

            If e.Row Mod 3 = 0 Then
                For Vendorloop As Integer = 1 To Vendorcount
                    DM += Breakdown(e.Row + 2, Vendorloop)
                Next
                CoTotal = DetailList(e.Row + 2, 5)
                DMtotal = CoTotal - DM
                DetailList(e.Row + 2, 6) = DMtotal
            Else
                For Vendorloop As Integer = 1 To Vendorcount
                    DM += Breakdown(e.Row + 1, Vendorloop)
                Next
                CoTotal = DetailList(e.Row + 1, 5)
                DMtotal = CoTotal - DM
                DetailList(e.Row + 1, 6) = DMtotal
            End If

            For DTloop As Integer = 1 To Detailscount
                Gtotal += DetailList(DTloop * 3 + 2, 6)
            Next
            'TotalBox.Value = Gtotal
            TotalBreakdown(0, 0) = Gtotal

            ChangeValue = ContractNo.Value
            ChangeFlag += 1

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub Create_Click(sender As Object, e As EventArgs) Handles Create.Click
        Try
            ホーム.Sql.Parameters.Clear()
            ホーム.Sql.CommandText = "SELECT ISNULL(MAX(outsrc_no),0) from Outsourcing_plans"
            Dim Maxoutsrc As Integer = ホーム.Sql.ExecuteScalar

            '協力業者テーブルからレコード数を取得
            ホーム.Sql.Parameters.Clear()
            ホーム.Sql.CommandText = "SELECT count(outsrcr_id) from Outsourcers"
            Dim Vendorcount As Integer = ホーム.Sql.ExecuteScalar

            If MsgBox("最新の外注計画をコピーして、新しい外注計画を作成します。", MsgBoxStyle.OkCancel, "新規作成") = MsgBoxResult.Ok Then
                Breakdown.Clear(ClearFlags.Content)
                TotalBreakdown.Clear(ClearFlags.Content)
                ChangeDetail.Clear()
                ContractNo.Value = Maxoutsrc + 1

                '今日の日付を表示
                Dim dt1 As DateTime = DateTime.Today
                CreatedDateBox.Value = dt1.ToString("D")

                '外注計画報告書テーブルから変更内容を取得
                ホーム.Sql.Parameters.Clear()
                ホーム.Sql.CommandText = "SELECT changes FROM Outsourcing_reports WHERE outsrc_no=" & ContractNo.Value - 1
                Dim change As String = ホーム.Sql.ExecuteScalar
                ChangeDetail.Value = change

                ホーム.Sql.Parameters.Clear()
                ホーム.Sql.CommandText = "SELECT * FROM outsourcers"
                Dim Coopcount As Integer = 1
                Dim Coopreader As SqlDataReader = ホーム.Sql.ExecuteReader
                While Coopreader.Read
                    Breakdown(2, Coopcount) = Coopreader.Item("outsrcr_id")
                    Breakdown(0, Coopcount) = Coopreader.Item("outsrcr_code")
                    Breakdown(1, Coopcount) = Coopreader.Item("outsrcr_name")
                    Coopcount += 1
                End While
                Coopreader.Close()

                ホーム.Sql.Parameters.Clear()
                ホーム.Sql.CommandText = "SELECT COUNT(dtl_id) FROM details WHERE budget_no=" & ホーム.BudgetNo
                Dim Detailscount As Integer = ホーム.Sql.ExecuteScalar

                For vendorloop As Integer = 1 To Vendorcount
                    Dim total As Integer = 0
                    For BDloop As Integer = 1 To Detailscount
                        ホーム.Sql.Parameters.Clear()
                        ホーム.Sql.CommandText = "SELECT ISNULL(outsrcng_quanity,0) from Outsourcing_plans WHERE dtl_id = " & DetailList(BDloop * 3, 0) & "AND outsrcr_id=" & Breakdown(2, vendorloop) & "AND outsrc_no=" & ContractNo.Value - 1
                        Dim Oquanity As Decimal = ホーム.Sql.ExecuteScalar
                        If Oquanity = 0 Then
                            Breakdown(BDloop * 3, vendorloop) = 0
                            Breakdown.Rows(BDloop * 3).StyleNew.Format = "N1"
                        Else
                            Breakdown(BDloop * 3, vendorloop) = Oquanity
                            Breakdown.Rows(BDloop * 3).StyleNew.Format = "N1"
                        End If

                        ホーム.Sql.Parameters.Clear()
                        ホーム.Sql.CommandText = "SELECT ISNULL(outsrcng_costea,0) from Outsourcing_plans WHERE dtl_id = " & DetailList(BDloop * 3, 0) & "AND outsrcr_id=" & Breakdown(2, vendorloop) & "AND outsrc_no=" & ContractNo.Value - 1
                        Dim Ocostea As Integer = ホーム.Sql.ExecuteScalar
                        If Ocostea = 0 Then
                            Breakdown(BDloop * 3 + 1, vendorloop) = 0
                            Breakdown.Rows(BDloop * 3 + 1).StyleNew.Format = "N0"
                        Else
                            Breakdown(BDloop * 3 + 1, vendorloop) = Ocostea
                            Breakdown.Rows(BDloop * 3 + 1).StyleNew.Format = "N0"
                        End If

                        Dim Amount As Integer = 0
                        Amount = Math.Floor(Oquanity * Ocostea)
                        Breakdown(BDloop * 3 + 2, vendorloop) = Amount
                        Breakdown.Rows(BDloop * 3 + 2).AllowEditing = False
                        Breakdown.Rows(BDloop * 3 + 2).StyleNew.Format = "N0"
                        total += Amount
                        TotalBreakdown(0, vendorloop) = total
                        TotalBreakdown.Rows(0).StyleNew.Format = "N0"

                    Next
                Next

                '直営計算
                Dim Gtotal As Int64 '直営合計
                Dim DMtotal As Int64 '直営金額
                For DTloop As Integer = 1 To Detailscount
                    Dim DM As Int64 = 0
                    For DMloop As Integer = 1 To Vendorcount
                        DM += Breakdown(DTloop * 3 + 2, DMloop)
                    Next
                    Dim CoTotal As Int64 = DetailList(DTloop * 3 + 2, 5)
                    DMtotal = CoTotal - DM
                    DetailList(DTloop * 3 + 2, 6) = DMtotal
                    Gtotal += DMtotal
                Next
                'TotalBox.Value = Gtotal
                TotalBreakdown(0, 0) = Gtotal

                ChangeDetail.Clear()
            End If

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub Entry_Click(sender As Object, e As EventArgs) Handles Entry.Click
        Try
            Dim Vendorcount As Integer = Breakdown.Cols.Count - 1
            Dim Detailscount As Integer = Breakdown.Rows.Count / 3 - 1
            Dim createddate As Date = CreatedDateBox.Value
            Dim outsrcno As Integer = ContractNo.Value
            Dim Changedetailtext As String = ChangeDetail.Text

            If createddate = Nothing Then
                MsgBox("変更計画作成日を入力してください。", MsgBoxStyle.OkOnly, "エラー")
                Exit Sub
            End If

            '業者数ループ
            For Vendorloop As Integer = 1 To Vendorcount
                Dim outsrcrid As Integer = Breakdown(2, Vendorloop)
                '明細数ループ
                For Detailloop As Integer = 1 To Detailscount
                    Dim dtlid As Integer = DetailList(Detailloop * 3, 0)
                    Dim Oquanity As Decimal = Breakdown(Detailloop * 3, Vendorloop)
                    Dim Ocostea As Integer = Breakdown(Detailloop * 3 + 1, Vendorloop)
                    ホーム.Sql.Parameters.Clear()
                    ホーム.Sql.CommandText = "SELECT ISNULL(COUNT(dtl_id),0) FROM outsourcing_plans WHERE outsrc_no =" & outsrcno & "AND outsrcr_id =" & outsrcrid & "AND dtl_id =" & dtlid
                    Dim OutsrcnoCount As Integer = ホーム.Sql.ExecuteScalar
                    '登録内容が新規のとき
                    If OutsrcnoCount = 0 Then
                        '個数か単価が0のとき、次のループへ。それ以外は新規登録
                        If Oquanity = 0 Or Ocostea = 0 Then
                            Continue For
                        Else
                            ホーム.Sql.CommandText = ""
                            ホーム.Sql.Parameters.Clear()
                            ホーム.Sql.CommandText = "INSERT INTO outsourcing_plans (budget_no,outsrc_no,outsrcr_id,dtl_id,outsrcng_quanity,outsrcng_costea,created_date)VALUES(@budget_no,@outsrc_no,@outsrcr_id,@dtl_id,@outsrcng_quanity,@outsrcng_costea,@created_date)"
                        End If
                    Else
                        If Oquanity = 0 Or Ocostea = 0 Then
                            ホーム.Sql.Parameters.Clear()
                            ホーム.Sql.CommandText = "DELETE FROM outsourcing_plans WHERE outsrc_no =" & outsrcno & "AND outsrcr_id =" & outsrcrid & "AND dtl_id =" & dtlid
                            ホーム.Sql.ExecuteNonQuery()
                            Continue For
                        End If
                        ホーム.Sql.CommandText = ""
                        ホーム.Sql.Parameters.Clear()
                        ホーム.Sql.CommandText = "UPDATE outsourcing_plans SET budget_no=@budget_no,outsrc_no=@outsrc_no,outsrcr_id=@outsrcr_id,dtl_id=@dtl_id,outsrcng_quanity=@outsrcng_quanity,outsrcng_costea=@outsrcng_costea,created_date=@created_date WHERE outsrc_no = " & outsrcno & "AND outsrcr_id =" & outsrcrid & "AND dtl_id =" & dtlid
                    End If

                    ホーム.Sql.Parameters.Add(New SqlParameter("@budget_no", SqlDbType.Int))
                    ホーム.Sql.Parameters.Add(New SqlParameter("@outsrc_no", SqlDbType.Int))
                    ホーム.Sql.Parameters.Add(New SqlParameter("@outsrcr_id", SqlDbType.Int))
                    ホーム.Sql.Parameters.Add(New SqlParameter("@dtl_id", SqlDbType.Int))
                    ホーム.Sql.Parameters.Add(New SqlParameter("@outsrcng_quanity", SqlDbType.Decimal))
                    ホーム.Sql.Parameters.Add(New SqlParameter("@outsrcng_costea", SqlDbType.Money))
                    ホーム.Sql.Parameters.Add(New SqlParameter("@created_date", SqlDbType.Date))
                    ホーム.Sql.Parameters("@budget_no").Value = ホーム.BudgetNo
                    ホーム.Sql.Parameters("@outsrc_no").Value = outsrcno
                    ホーム.Sql.Parameters("@outsrcr_id").Value = outsrcrid
                    ホーム.Sql.Parameters("@dtl_id").Value = dtlid
                    ホーム.Sql.Parameters("@outsrcng_quanity").Value = Oquanity
                    ホーム.Sql.Parameters("@outsrcng_costea").Value = Ocostea
                    ホーム.Sql.Parameters("@created_date").Value = createddate
                    ホーム.Sql.ExecuteNonQuery()

                Next
            Next

            ホーム.Sql.Parameters.Clear()
            ホーム.Sql.CommandText = "SELECT ISNULL(COUNT(outsrc_no),0) FROM outsourcing_reports WHERE outsrc_no = " & outsrcno
            Dim ReportCount As Integer = ホーム.Sql.ExecuteScalar
            If ReportCount = 0 Then
                ホーム.Sql.CommandText = ""
                ホーム.Sql.Parameters.Clear()
                ホーム.Sql.CommandText = "INSERT INTO outsourcing_reports (prjct_code,outsrc_no,created_date,changes)VALUES(@prjct_code,@outsrc_no,@created_date,@changes)"
            Else
                ホーム.Sql.CommandText = ""
                ホーム.Sql.Parameters.Clear()
                ホーム.Sql.CommandText = "UPDATE outsourcing_reports SET prjct_code=@prjct_code,outsrc_no=@outsrc_no,created_date=@created_date,changes=@changes WHERE outsrc_no = " & outsrcno
            End If
            ホーム.Sql.Parameters.Add(New SqlParameter("@prjct_code", SqlDbType.NVarChar))
            ホーム.Sql.Parameters.Add(New SqlParameter("@outsrc_no", SqlDbType.Int))
            ホーム.Sql.Parameters.Add(New SqlParameter("@created_date", SqlDbType.Date))
            ホーム.Sql.Parameters.Add(New SqlParameter("@changes", SqlDbType.NVarChar)).Value = ChangeDetail.Text
            ホーム.Sql.Parameters("@prjct_code").Value = "DD0000"
            ホーム.Sql.Parameters("@outsrc_no").Value = outsrcno
            ホーム.Sql.Parameters("@created_date").Value = createddate
            'ホーム.Sql.Parameters("@changes").Value = ChangeDetail.Text
            ホーム.Sql.ExecuteNonQuery()

            '一番大きい変更回数を取得し、変更回数の上限下限をセット
            ホーム.Sql.CommandText = "SELECT ISNULL(MAX(outsrc_no),0) from Outsourcing_plans"
            Dim Maxoutsrc As Integer = ホーム.Sql.ExecuteScalar

            ContractNo.PostValidation.Validation = PostValidationTypeEnum.ValuesAndIntervals
            Dim valInteval_1 As ValueInterval = New ValueInterval(0, Maxoutsrc, True, True)
            ContractNo.PostValidation.Intervals.Add(valInteval_1)
            ContractNo.Value = Maxoutsrc

            MsgBox("登録完了", MsgBoxStyle.OkOnly, "外注計画登録")

            ChangeFlag = 0

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Me.BackgroundWorker1.ReportProgress(10)

        '進行状況.Show()
        '進行状況.Refresh()
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        進行状況.Close()
    End Sub
End Class