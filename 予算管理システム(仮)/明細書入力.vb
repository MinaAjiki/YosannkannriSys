Imports C1.Win.C1FlexGrid
Imports System.Windows.Forms.Form
Imports C1.Win.C1Command
Imports System.Data.SqlClient
Imports System.Windows.Input.Keyboard
Public Class 明細書入力
    Public SelectRow As Integer = 0
    Public CopyRow As Integer = 0
    Dim outsrcr_x As Integer = 0
    Dim outsrcr_y As Integer = 0
    Public Command As String
    Dim Key As String
    Public EntryCommand As String
    Dim OutsrcrCount As Integer = 0


    Private Sub 明細書入力_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Command = "Load"
            Me.TopMost = False
            Cursor.Current = Cursors.WaitCursor
            Me.KeyPreview = True

            SWorkType.Value = ホーム.sworktypecode & " " & ホーム.sworktypename
            DetailsList(0, 2) = "削除"
            DetailsList(1, 2) = "削除"
            DetailsList(2, 2) = "削除"
            DetailsList(0, 3) = "順"
            DetailsList(1, 3) = "順"
            DetailsList(2, 3) = "順"
            DetailsList(0, 4) = "名称"
            DetailsList(0, 5) = "名称"
            DetailsList(1, 4) = "規格"
            DetailsList(1, 5) = "規格"
            DetailsList(2, 4) = "摘要"
            DetailsList(2, 5) = "単位"
            DetailsList(1, 6) = "単価"
            DetailsList(2, 6) = "金額"

            DetailsList.MergedRanges.Add(0, 0, 2, 0)
            DetailsList.MergedRanges.Add(0, 1, 2, 1)
            DetailsList.MergedRanges.Add(0, 2, 2, 2)
            DetailsList.MergedRanges.Add(0, 3, 2, 3)
            DetailsList.MergedRanges.Add(0, 4, 0, 5)
            DetailsList.MergedRanges.Add(1, 4, 1, 5)

            CategoryList.MergedRanges.Add(0, 2, 2, 2)
            CategoryList.MergedRanges.Add(0, 3, 2, 3)
            CategoryList.MergedRanges.Add(0, 4, 2, 4)
            CategoryList.MergedRanges.Add(0, 5, 2, 5)
            CategoryList.MergedRanges.Add(0, 6, 2, 6)

            OutsoucerList.Visible = False
            PastingMenu.Enabled = False

            CategoryTotalList.Rows(0).Height = 20
            OutsoucerTotalList.Rows(0).Height = 20

            Category.Checked = True

            If ホーム.BeforeForm = "見積" Then
                ItemSelect.Visible = False
                CostCreation.Visible = False
                CostModify.Visible = False
                CostCopy.Visible = False
                Reference.Visible = False
            End If

            Me.Anchor = AnchorStyles.Top
            Me.Anchor = AnchorStyles.Left
            Me.Anchor = AnchorStyles.Bottom

            ホーム.Sql.CommandText = "SELECT Count(*) FROM details WHERE budget_no=" & ホーム.BudgetNo & " AND s_worktype_code=" & ホーム.sworktypecode
            Dim DetailsCount As Integer = ホーム.Sql.ExecuteScalar

            If DetailsCount > 5 Then
                DetailsList.Rows.Count = (DetailsCount * 3) + 6
                CategoryList.Rows.Count = (DetailsCount * 3) + 6
                OutsoucerList.Rows.Count = (DetailsCount * 3) + 6
            Else
                DetailsList.Rows.Count = 21
                CategoryList.Rows.Count = 21
                OutsoucerList.Rows.Count = 21
            End If
            Dim RowCount As Integer = 0
            Dim RowNo As Integer = 0

            If DetailsCount > 0 Then

                ホーム.Sql.CommandText = "SELECT * FROM details WHERE budget_no=" & ホーム.BudgetNo & " AND s_worktype_code=" & ホーム.sworktypecode & " ORDER BY dtl_no ASC"
                Dim DetailsReader As SqlDataReader = ホーム.Sql.ExecuteReader
                While DetailsReader.Read
                    RowCount += 1
                    RowNo += 1
                    DetailsList(RowCount * 3, 1) = DetailsReader.Item("dtl_id")
                    DetailsList(RowCount * 3, 8) = DetailsReader.Item("cstclss_code")
                    DetailsList(RowCount * 3, 9) = DetailsReader.Item("cstmstr_id")
                    DetailsList(RowCount * 3, 3) = DetailsReader.Item("dtl_no")
                    DetailsList(RowCount * 3, 4) = DetailsReader.Item("dtl_name")
                    DetailsList((RowCount * 3) + 1, 4) = DetailsReader.Item("dtl_spec")
                    DetailsList((RowCount * 3) + 2, 4) = DetailsReader.Item("dtl_remarks")
                    DetailsList((RowCount * 3) + 2, 5) = DetailsReader.Item("dtl_unit")
                    DetailsList(RowCount * 3, 6) = DetailsReader.Item("dtl_quanity")
                    Dim Quanity As CellRange = DetailsList.GetCellRange(RowCount * 3, 6)
                    Quanity.StyleNew.Format = "N1"
                    DetailsList((RowCount * 3) + 1, 6) = DetailsReader.Item("dtl_costea")
                    Dim Costea As CellRange = DetailsList.GetCellRange(RowCount * 3 + 1, 6)
                    Costea.StyleNew.Format = "N0"
                    DetailsList((RowCount * 3) + 2, 6) = Math.Floor((DetailsReader.Item("dtl_quanity") * DetailsReader.Item("dtl_costea")))
                    Dim Amount As CellRange = DetailsList.GetCellRange(RowCount * 3 + 2, 6)
                    Amount.StyleNew.Format = "N0"

                    DetailsList(RowCount * 3, 7) = RowNo * RowNo
                    DetailsList(RowCount * 3 + 1, 7) = (RowNo * RowNo) + 1
                    DetailsList(RowCount * 3 + 2, 7) = (RowNo * RowNo) + 2
                    If (RowNo * RowNo) + 2 = 6 Then
                        RowNo = 0
                    End If

                    If RowCount Mod 2 = 0 Then
                        DetailsList.Rows(RowCount * 3).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        DetailsList.Rows((RowCount * 3) + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        DetailsList.Rows((RowCount * 3) + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)

                        CategoryList.Rows(RowCount * 3).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)

                        CategoryList.Rows((RowCount * 3) + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)

                        CategoryList.Rows((RowCount * 3) + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)

                        OutsoucerList.Rows(RowCount * 3).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        OutsoucerList.Rows((RowCount * 3) + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        OutsoucerList.Rows((RowCount * 3) + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                    End If
                    DetailsList.MergedRanges.Add(RowCount * 3, 0, (RowCount * 3) + 2, 0)
                    DetailsList.MergedRanges.Add(RowCount * 3, 2, (RowCount * 3) + 2, 2)
                    DetailsList.MergedRanges.Add(RowCount * 3, 3, (RowCount * 3) + 2, 3)
                    DetailsList.MergedRanges.Add(RowCount * 3, 4, RowCount * 3, 5)
                    DetailsList.MergedRanges.Add((RowCount * 3) + 1, 4, (RowCount * 3) + 1, 5)

                    CategoryList((RowCount * 3) + 1, 2) = DetailsReader.Item("dtl_labor")
                    CategoryList((RowCount * 3) + 1, 3) = DetailsReader.Item("dtl_material")
                    CategoryList((RowCount * 3) + 1, 4) = DetailsReader.Item("dtl_machine")
                    CategoryList((RowCount * 3) + 1, 5) = DetailsReader.Item("dtl_subcntrct")
                    CategoryList((RowCount * 3) + 1, 6) = DetailsReader.Item("dtl_expens")
                    CategoryList((RowCount * 3) + 2, 2) = Math.Floor(DetailsReader.Item("dtl_quanity") * DetailsReader.Item("dtl_labor"))
                    CategoryList((RowCount * 3) + 2, 3) = Math.Floor(DetailsReader.Item("dtl_quanity") * DetailsReader.Item("dtl_material"))
                    CategoryList((RowCount * 3) + 2, 4) = Math.Floor(DetailsReader.Item("dtl_quanity") * DetailsReader.Item("dtl_machine"))
                    CategoryList((RowCount * 3) + 2, 5) = Math.Floor(DetailsReader.Item("dtl_quanity") * DetailsReader.Item("dtl_subcntrct"))
                    CategoryList((RowCount * 3) + 2, 6) = Math.Floor(DetailsReader.Item("dtl_quanity") * DetailsReader.Item("dtl_expens"))

                End While
                DetailsReader.Close()

                Dim DataRowCount As Integer = RowCount * 3
                Dim BlankRow As Integer = ((DetailsList.Rows.Count - 3) - DataRowCount) / 3
                For BlankLoop As Integer = 0 To BlankRow - 1
                    RowCount += 1
                    RowNo = 1
                    DetailsList((RowCount * 3), 7) = (RowNo * RowNo)
                    DetailsList((RowCount * 3) + 1, 7) = (RowNo * RowNo) + 1
                    DetailsList((RowCount * 3) + 2, 7) = (RowNo * RowNo) + 2

                    If RowCount Mod 2 = 0 Then
                        DetailsList.Rows(RowCount * 3).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        DetailsList.Rows((RowCount * 3) + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        DetailsList.Rows((RowCount * 3) + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        CategoryList.Rows(RowCount * 3).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        CategoryList.Rows((RowCount * 3) + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        CategoryList.Rows((RowCount * 3) + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        OutsoucerList.Rows(RowCount * 3).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        OutsoucerList.Rows((RowCount * 3) + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        OutsoucerList.Rows((RowCount * 3) + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)

                    End If

                    Dim LastQuanity As CellRange = DetailsList.GetCellRange(RowCount * 3, 6)
                    LastQuanity.StyleNew.Format = "N1"
                    Dim LastCostea As CellRange = DetailsList.GetCellRange(RowCount * 3 + 1, 6)
                    LastCostea.StyleNew.Format = "N0"
                    Dim LastAmount As CellRange = DetailsList.GetCellRange(RowCount * 3 + 2, 6)
                    LastAmount.StyleNew.Format = "N0"

                    DetailsList.MergedRanges.Add(RowCount * 3, 0, (RowCount * 3) + 2, 0)
                    DetailsList.MergedRanges.Add(RowCount * 3, 2, (RowCount * 3) + 2, 2)
                    DetailsList.MergedRanges.Add(RowCount * 3, 3, (RowCount * 3) + 2, 3)
                    DetailsList.MergedRanges.Add(RowCount * 3, 4, RowCount * 3, 5)
                    DetailsList.MergedRanges.Add((RowCount * 3) + 1, 4, (RowCount * 3) + 1, 5)
                Next

                ホーム.Sql.CommandText = "SELECT * FROM S_worktype_total WHERE budget_no=" & ホーム.BudgetNo & " AND s_wrktyp_code=" & ホーム.sworktypecode
                Dim TotalReader As SqlDataReader = ホーム.Sql.ExecuteReader
                While TotalReader.Read
                    DetailTotal.Value = TotalReader.Item("amout_total")
                    CategoryTotalList(0, 2) = TotalReader.Item("labor")
                    CategoryTotalList(0, 3) = TotalReader.Item("material")
                    CategoryTotalList(0, 4) = TotalReader.Item("machine")
                    CategoryTotalList(0, 5) = TotalReader.Item("subcntrct")
                    CategoryTotalList(0, 6) = TotalReader.Item("expens")

                End While
                TotalReader.Close()
            Else

                For RowCount = 1 To 6
                    RowNo += 1

                    Dim Quanity As CellRange = DetailsList.GetCellRange(RowCount * 3, 6)
                    Quanity.StyleNew.Format = "N1"
                    Dim Costea As CellRange = DetailsList.GetCellRange(RowCount * 3 + 1, 6)
                    Costea.StyleNew.Format = "N0"
                    Dim Amount As CellRange = DetailsList.GetCellRange(RowCount * 3 + 2, 6)
                    Amount.StyleNew.Format = "N0"

                    If RowCount Mod 2 = 0 Then
                        DetailsList.Rows(RowCount * 3).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        DetailsList.Rows((RowCount * 3) + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        DetailsList.Rows((RowCount * 3) + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)

                        CategoryList.Rows(RowCount * 3).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)

                        CategoryList.Rows((RowCount * 3) + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)

                        CategoryList.Rows((RowCount * 3) + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)

                        OutsoucerList.Rows(RowCount * 3).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        OutsoucerList.Rows((RowCount * 3) + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        OutsoucerList.Rows((RowCount * 3) + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        OutsoucerList.Rows((RowCount * 3) + 2).AllowEditing = False
                    End If

                    DetailsList(RowCount * 3, 7) = RowNo * RowNo
                    DetailsList(RowCount * 3 + 1, 7) = (RowNo * RowNo) + 1
                    DetailsList(RowCount * 3 + 2, 7) = (RowNo * RowNo) + 2
                    If (RowNo * RowNo) + 2 = 6 Then
                        RowNo = 0
                    End If

                    DetailsList.MergedRanges.Add(RowCount * 3, 0, (RowCount * 3) + 2, 0)
                    DetailsList.MergedRanges.Add(RowCount * 3, 2, (RowCount * 3) + 2, 2)
                    DetailsList.MergedRanges.Add(RowCount * 3, 3, (RowCount * 3) + 2, 3)
                    DetailsList.MergedRanges.Add(RowCount * 3, 4, RowCount * 3, 5)
                    DetailsList.MergedRanges.Add((RowCount * 3) + 1, 4, (RowCount * 3) + 1, 5)
                Next

                CategoryTotalList(1, 2) = 0
                CategoryTotalList(1, 3) = 0
                CategoryTotalList(1, 4) = 0
                CategoryTotalList(1, 5) = 0
                CategoryTotalList(1, 6) = 0

            End If


            DetailsList.Focus()
            DetailsList.Select(3, 4)

            ホーム.Modified = "False"
            Command = ""
            Cursor.Current = Cursors.Default

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try

    End Sub

    Private Sub Cancel_MouseDown(sender As Object, e As MouseEventArgs) Handles Cancel.MouseDown
        Cancel.ImageIndex = 8
    End Sub

    Private Sub Cancel_MouseEnter(sender As Object, e As EventArgs) Handles Cancel.MouseEnter
        Cancel.Cursor = Cursors.Hand
        Cancel.ImageIndex = 7
    End Sub

    Private Sub Cancel_MouseLeave(sender As Object, e As EventArgs) Handles Cancel.MouseLeave
        Cancel.ImageIndex = 6
    End Sub

    Private Sub Cancel_MouseUp(sender As Object, e As MouseEventArgs) Handles Cancel.MouseUp
        Cancel.ImageIndex = 6
    End Sub

    Private Sub Entry_MouseUp(sender As Object, e As MouseEventArgs) Handles Entry.MouseUp
        Entry.ImageIndex = 3
    End Sub
    Private Sub Entry_MouseDown(sender As Object, e As MouseEventArgs) Handles Entry.MouseDown
        Entry.ImageIndex = 5
    End Sub

    Private Sub Entry_MouseEnter(sender As Object, e As EventArgs) Handles Entry.MouseEnter
        Entry.Cursor = Cursors.Hand
        Entry.ImageIndex = 4
    End Sub

    Private Sub Entry_MouseLeave(sender As Object, e As EventArgs) Handles Entry.MouseLeave
        Entry.ImageIndex = 3
    End Sub


    Private Sub Outsoucing_CheckedChanged(sender As Object, e As EventArgs) Handles Outsoucing.CheckedChanged
        Try
            If Outsoucing.Checked = True Then
                CategoryList.Visible = False
                CategoryTotalList.Visible = False
                OutsoucerList.Visible = True
                OutsoucerTotalList.Visible = True


                ホーム.Sql.CommandText = "SELECT Count(*) FROM outsourcers"
                Dim OutsourcersCount As Integer = ホーム.Sql.ExecuteScalar

                OutsoucerList.MergedRanges.Add(1, 6, 2, 6)
                OutsoucerList.MergedRanges.Add(1, 2, 2, 2)
                OutsoucerList.MergedRanges.Add(1, 3, 2, 3)
                OutsoucerList.MergedRanges.Add(1, 4, 2, 4)
                OutsoucerList.MergedRanges.Add(1, 5, 2, 5)

                If OutsourcersCount > 0 Then
                    Dim ColsCount As Integer = OutsoucerList.Cols.Count - 2

                    If OutsourcersCount > ColsCount Then
                        OutsoucerList.Cols.Count = OutsourcersCount + 2
                        OutsoucerTotalList.Cols.Count = OutsourcersCount + 2
                    End If

                    OutsrcrCount = OutsoucerList.Cols.Count
                    Dim DataCount As Integer = 1

                    ホーム.Sql.CommandText = "SELECT * FROM outsourcers"
                    Dim OutsourcersReader As SqlDataReader = ホーム.Sql.ExecuteReader
                    While OutsourcersReader.Read
                        DataCount += 1

                        OutsoucerList.MergedRanges.Add(1, DataCount, 2, DataCount)
                        OutsoucerList(0, DataCount) = OutsourcersReader.Item("outsrcr_code")
                        OutsoucerList(1, DataCount) = OutsourcersReader.Item("outsrcr_name")
                        OutsoucerList.Cols(DataCount).StyleFixedNew.WordWrap = True
                        OutsoucerList.Cols(DataCount).Width = 95
                        OutsoucerTotalList.Cols(DataCount).Width = 95
                        OutsoucerList.Cols(DataCount).StyleFixedNew.Font = New Font("メイリオ", 8, FontStyle.Regular)
                        OutsoucerList.Cols(DataCount).StyleFixedNew.TextAlign = TextAlignEnum.LeftCenter
                        OutsoucerList.Cols(DataCount).StyleNew.Font = New Font("Arial", 9, FontStyle.Regular)
                        OutsoucerList.Cols(DataCount).StyleNew.TextAlign = TextAlignEnum.RightCenter
                        OutsoucerList.Cols(DataCount).StyleNew.TextAlign = TextAlignEnum.RightCenter
                        OutsoucerList.Cols(DataCount).StyleNew.DataType = GetType(Decimal)

                    End While
                    OutsourcersReader.Close()
                End If

                ホーム.Sql.CommandText = "SELECT Count(*) FROM outsourcing_plans WHERE budget_no=" & ホーム.BudgetNo
                Dim TableDataCount As Integer = ホーム.Sql.ExecuteScalar

                If TableDataCount > 0 Then
                    ホーム.Sql.CommandText = "SELECT MAX(outsrc_no) FROM outsourcing_plans WHERE budget_no=" & ホーム.BudgetNo
                    Dim MaxNo As Integer = ホーム.Sql.ExecuteScalar

                    Dim ColCount As Integer = OutsoucerList.Cols.Count - 1
                    Dim DataCount As Integer = 0
                    For OutsrcrCount As Integer = 1 To ColCount
                        ホーム.Sql.Parameters.Clear()
                        If IsNothing(OutsoucerList(0, OutsrcrCount + 1)) = False Then
                            ホーム.Sql.CommandText = "SELECT outsrcr_id FROM outsourcers WHERE outsrcr_code=" & OutsoucerList(0, OutsrcrCount + 1)
                            Dim outsrcrid As Integer = ホーム.Sql.ExecuteScalar

                            ホーム.Sql.CommandText = "SELECT outsrcr_id FROM outsourcing_plans WHERE budget_no=" & ホーム.BudgetNo & " AND outsrc_no=" & MaxNo & " AND outsrcr_id=" & outsrcrid
                            Dim PlanCount As Integer = ホーム.Sql.ExecuteScalar

                            If PlanCount > 0 Then
                                Dim Total As Int64 = 0
                                DataCount += 1
                                For RowCount As Integer = 1 To ((DetailsList.Rows.Count - 3) / 3)
                                    Dim dtlid As Integer = DetailsList(RowCount * 3, 1)
                                    ホーム.Sql.CommandText = "SELECT * FROM outsourcing_plans WHERE budget_no=" & ホーム.BudgetNo & " AND outsrc_no=" & MaxNo & " AND outsrcr_id=" & outsrcrid & " AND dtl_id=" & dtlid
                                    Dim PlanReader As SqlDataReader = ホーム.Sql.ExecuteReader
                                    While PlanReader.Read
                                        OutsoucerList((RowCount * 3), OutsrcrCount + 1) = PlanReader.Item("outsrcng_quanity")
                                        Dim Quanity As CellRange = OutsoucerList.GetCellRange(RowCount * 3, OutsrcrCount + 1)
                                        Quanity.StyleNew.Format = "N1"
                                        OutsoucerList((RowCount * 3) + 1, OutsrcrCount + 1) = PlanReader.Item("outsrcng_costea")
                                        Dim Costea As CellRange = OutsoucerList.GetCellRange((RowCount * 3) + 1, OutsrcrCount + 1)
                                        Costea.StyleNew.Format = "N0"
                                        OutsoucerList((RowCount * 3) + 2, OutsrcrCount + 1) = Math.Floor((PlanReader.Item("outsrcng_quanity") * PlanReader.Item("outsrcng_costea")))
                                        Dim Amount As CellRange = OutsoucerList.GetCellRange((RowCount * 3) + 2, OutsrcrCount + 1)
                                        Amount.StyleNew.Format = "N0"
                                        Total += OutsoucerList((RowCount * 3) + 2, OutsrcrCount + 1)
                                    End While
                                    PlanReader.Close()
                                Next

                                OutsoucerTotalList(0, OutsrcrCount + 1) = Total
                            End If
                        End If
                    Next


                    Dim BlankCol As Integer = ((OutsoucerList.Cols.Count) - DataCount) - 2
                    For BlankLoop As Integer = 1 To BlankCol
                        DataCount += 1
                        For RowCount As Integer = 1 To ((DetailsList.Rows.Count - 3) / 3)
                            Dim Quanity As CellRange = OutsoucerList.GetCellRange(RowCount * 3, DataCount + 1)
                            Quanity.StyleNew.Format = "N1"

                            Dim Costea As CellRange = OutsoucerList.GetCellRange((RowCount * 3) + 1, DataCount + 1)
                            Costea.StyleNew.Format = "N0"
                            Dim Amount As CellRange = OutsoucerList.GetCellRange((RowCount * 3) + 2, DataCount + 1)
                            Amount.StyleNew.Format = "N0"
                        Next
                    Next
                End If
            End If

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub Category_CheckedChanged(sender As Object, e As EventArgs) Handles Category.CheckedChanged
        If Category.Checked = True Then
            OutsoucerList.Visible = False
            OutsoucerTotalList.Visible = False
            CategoryList.Visible = True
            CategoryTotalList.Visible = True
        End If
    End Sub

    Private Sub CostCreation_MouseDown(sender As Object, e As MouseEventArgs) Handles CostCreation.MouseDown
        CostCreation.ImageIndex = 11
    End Sub

    Private Sub CostCreation_MouseEnter(sender As Object, e As EventArgs) Handles CostCreation.MouseEnter
        CostCreation.Cursor = Cursors.Hand
        CostCreation.ImageIndex = 10
    End Sub

    Private Sub CostCreation_MouseLeave(sender As Object, e As EventArgs) Handles CostCreation.MouseLeave
        CostCreation.ImageIndex = 9
    End Sub

    Private Sub CostCreation_MouseUp(sender As Object, e As MouseEventArgs) Handles CostCreation.MouseUp
        CostCreation.ImageIndex = 9
    End Sub
    Private Sub CostModify_MouseDown(sender As Object, e As MouseEventArgs) Handles CostModify.MouseDown
        CostModify.ImageIndex = 14
    End Sub

    Private Sub CostModify_MouseEnter(sender As Object, e As EventArgs) Handles CostModify.MouseEnter
        CostModify.Cursor = Cursors.Hand
        CostModify.ImageIndex = 13
    End Sub

    Private Sub CostModify_MouseLeave(sender As Object, e As EventArgs) Handles CostModify.MouseLeave
        CostModify.ImageIndex = 12
    End Sub

    Private Sub CostModify_MouseUp(sender As Object, e As MouseEventArgs) Handles CostModify.MouseUp
        CostModify.ImageIndex = 12
    End Sub
    Private Sub CostCopy_MouseDown(sender As Object, e As MouseEventArgs) Handles CostCopy.MouseDown
        CostCopy.ImageIndex = 17
    End Sub

    Private Sub CostCopy_MouseEnter(sender As Object, e As EventArgs) Handles CostCopy.MouseEnter
        CostCopy.Cursor = Cursors.Hand
        CostCopy.ImageIndex = 16
    End Sub

    Private Sub CostCopy_MouseLeave(sender As Object, e As EventArgs) Handles CostCopy.MouseLeave
        CostCopy.ImageIndex = 15
    End Sub

    Private Sub CostCopy_MouseUp(sender As Object, e As MouseEventArgs) Handles CostCopy.MouseUp
        CostCopy.ImageIndex = 15
    End Sub

    Private Sub DetailsList_AfterScroll(sender As Object, e As RangeEventArgs) Handles DetailsList.AfterScroll
        CategoryList.ScrollPosition = DetailsList.ScrollPosition
        OutsoucerList.ScrollPosition = DetailsList.ScrollPosition
    End Sub

    Private Sub CategoryList_AfterScroll(sender As Object, e As RangeEventArgs) Handles CategoryList.AfterScroll
        DetailsList.ScrollPosition = CategoryList.ScrollPosition

    End Sub

    Private Sub OutsoucerList_AfterScroll(sender As Object, e As RangeEventArgs) Handles OutsoucerList.AfterScroll
        DetailsList.ScrollPosition = OutsoucerList.ScrollPosition

        If Not outsrcr_y = OutsoucerList.ScrollPosition.Y Then
            outsrcr_y = OutsoucerList.ScrollPosition.Y
        End If
        OutsoucerList.ScrollPosition = New Point(outsrcr_x, outsrcr_y)
    End Sub

    Private Sub DetailsList_AfterRowColChange(sender As Object, e As RangeEventArgs) Handles DetailsList.AfterRowColChange

        Try
            If Key = "" Then
                Dim Col As Integer = DetailsList.Selection.LeftCol
                Dim Row As Integer = DetailsList.Selection.TopRow

                For DetailsRowCount As Integer = 0 To DetailsList.Rows.Count - 1
                    If DetailsRowCount < DetailsList.Rows.Count - 3 Then
                        DetailsList.Rows(DetailsRowCount + 2).Caption = ""
                    Else
                        Exit For
                    End If
                Next

                Dim RowNo As Integer = DetailsList(Row, 7)
                If RowNo = 1 Or RowNo = 4 Then
                    DetailsList.Rows(Row).Caption = "▶"
                ElseIf RowNo = 2 Or RowNo = 5 Then
                    DetailsList.Rows(Row - 1).Caption = "▶"
                Else
                    DetailsList.Rows(Row - 2).Caption = "▶"
                End If

                If Col = 6 Then
                    DetailsList.ImeMode = ImeMode.Disable
                Else
                    DetailsList.ImeMode = ImeMode.On
                End If
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub CategoryList_AfterRowColChange(sender As Object, e As RangeEventArgs) Handles CategoryList.AfterRowColChange
        Try
            If Key = "" Then
                Dim Col As Integer = CategoryList.Selection.LeftCol
                Dim Row As Integer = CategoryList.Selection.TopRow

                For DetailsRowCount As Integer = 0 To DetailsList.Rows.Count - 1
                    If DetailsRowCount < DetailsList.Rows.Count - 3 Then
                        DetailsList.Rows(DetailsRowCount + 2).Caption = ""
                    Else
                        Exit For
                    End If
                Next

                Dim RowNo As Integer = DetailsList(Row, 7)
                If RowNo = 1 Or RowNo = 4 Then
                    DetailsList.Rows(Row).Caption = "▶"
                ElseIf RowNo = 2 Or RowNo = 5 Then
                    DetailsList.Rows(Row - 1).Caption = "▶"
                Else
                    DetailsList.Rows(Row - 2).Caption = "▶"
                End If
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub OutsoucerList_AfterRowColChange(sender As Object, e As RangeEventArgs) Handles OutsoucerList.AfterRowColChange

        Try
            Dim Col As Integer = OutsoucerList.Selection.LeftCol
            Dim Row As Integer = OutsoucerList.Selection.TopRow

            For DetailsRowCount As Integer = 0 To DetailsList.Rows.Count - 1
                If DetailsRowCount < DetailsList.Rows.Count - 3 Then
                    DetailsList.Rows(DetailsRowCount + 2).Caption = ""
                Else
                    Exit For
                End If
            Next

            Dim RowNo As Integer = DetailsList(Row, 7)
            If RowNo = 1 Or RowNo = 4 Then
                DetailsList.Rows(Row).Caption = "▶"
            ElseIf RowNo = 2 Or RowNo = 5 Then
                DetailsList.Rows(Row - 1).Caption = "▶"
            Else
                DetailsList.Rows(Row - 2).Caption = "▶"
            End If

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub ItemSelect_Click_1(sender As Object, e As EventArgs) Handles ItemSelectMenu.Click

        Try
            For DetailsRowCount As Integer = 0 To DetailsList.Rows.Count - 1
                If DetailsRowCount < DetailsList.Rows.Count - 3 AndAlso DetailsList.Rows(DetailsRowCount + 2).Caption = "▶" Then
                    SelectRow = DetailsRowCount + 2
                    Exit For
                End If
            Next

            If SelectRow = 0 Then
                MsgBox("行が選択されていません。", MsgBoxStyle.Exclamation, "明細書")
            Else

                項目選択.TopMost = True
                項目選択.Show()
                項目選択.TopMost = False

            End If

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try


    End Sub

    Private Sub CategoryList_AfterEdit(sender As Object, e As RowColEventArgs) Handles CategoryList.AfterEdit
        Try
            Dim Row As Integer = e.Row
            Dim Col As Integer = e.Col


            If IsNumeric(CategoryList(Row, Col)) = True Then
                CategoryList(Row + 1, Col) = Math.Floor((DetailsList(Row - 1, 6) * CategoryList(Row, Col)))

                Dim RowNo As Integer = 0
                Dim EditRow As Integer = e.Row + 1
                Dim ColTotal As Int64 = 0
                For RowCount = EditRow To ((DetailsList.Rows.Count - 3) / 3)

                    RowNo += 1
                    ColTotal += CategoryList(EditRow * 3, Col)
                Next

                CategoryTotalList(1, Col) = ColTotal
            End If

            Dim RowIndex As Integer = DetailsList(Row, 7)




            If IsKeyDown(Windows.Input.Key.Enter) = True Then
                If DetailsList.Rows.Count - 1 > Row + (3 - RowIndex) Then
                    If Col = 6 Then
                        DetailsList.Focus()
                        DetailsList.Select(Row + 2, 4)
                        DetailsList.Rows(Row - 1).Caption = ""
                        DetailsList.Rows(Row + 2).Caption = "▶"

                    End If
                End If
            End If

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub CategoryList_BeforeEdit(sender As Object, e As RowColEventArgs) Handles CategoryList.BeforeEdit

        If DetailsList(e.Row, 7) = 1 Or DetailsList(e.Row, 7) = 4 Then
            CategoryList.Rows(e.Row).AllowEditing = False
            CategoryList.Rows(e.Row + 2).AllowEditing = False
        ElseIf DetailsList(e.Row, 7) = 2 Or DetailsList(e.Row, 7) = 5 Then
            CategoryList.Rows(e.Row - 1).AllowEditing = False
            CategoryList.Rows(e.Row + 1).AllowEditing = False
        Else
            CategoryList.Rows(e.Row - 2).AllowEditing = False
            CategoryList.Rows(e.Row).AllowEditing = False
        End If


    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Try

            Dim CancelClick As String = ""

            EntryCommand = ""
            Dim CancelClickLoad As New CancelClick(Me)
            CancelClick = CancelClickLoad.ModifyCheck

            If ホーム.lworktypecode = 0 Then
                ホーム.BeforeForm = "予算"
                大工種選択.TopLevel = False
                ホーム.FormPanel.Controls.Add(大工種選択)
                大工種選択.Show()
            Else
                小工種選択.TopLevel = False
                ホーム.FormPanel.Controls.Add(小工種選択)
                小工種選択.Show()

                If ホーム.SelectNodeList.Count > 1 Then
                    If ホーム.SelectNodeList(1).Nodes.Count > 0 Then
                        ホーム.SelectNodeList(1).Collapse()
                        ホーム.SelectNodeList.RemoveAt(1)
                    End If
                End If
            End If

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub
    Private Sub Insert_Click(sender As Object, e As EventArgs) Handles InsertMenu.Click
        Try
            For DetailsRowCount As Integer = 0 To DetailsList.Rows.Count - 1
                If DetailsRowCount < DetailsList.Rows.Count - 3 AndAlso DetailsList.Rows(DetailsRowCount + 2).Caption = "▶" Then
                    SelectRow = DetailsRowCount + 2
                    Exit For
                End If
            Next

            If SelectRow = 0 Then
                MsgBox("行が選択されていません。", MsgBoxStyle.Exclamation, "明細書")
            Else
                ホーム.Modified = "True"

                DetailsList.Rows.Insert(SelectRow)
                DetailsList.Rows.Insert(SelectRow + 1)
                DetailsList.Rows.Insert(SelectRow + 2)
                CategoryList.Rows.Insert(SelectRow)
                CategoryList.Rows.Insert(SelectRow + 1)
                CategoryList.Rows.Insert(SelectRow + 2)
                OutsoucerList.Rows.Insert(SelectRow)
                OutsoucerList.Rows.Insert(SelectRow + 1)
                OutsoucerList.Rows.Insert(SelectRow + 2)
                DetailsList(SelectRow, 8) = 0
                DetailsList(SelectRow, 9) = 0
                DetailsList(SelectRow, 1) = 0
                DetailsList(SelectRow, 6) = 0
                DetailsList(SelectRow + 1, 6) = 0
                DetailsList(SelectRow + 2, 6) = 0
                For Category As Integer = 2 To 6
                    CategoryList(SelectRow + 1, Category) = 0
                    CategoryList(SelectRow + 2, Category) = 0
                Next

                Dim RowNo As Integer = 0
                For RowCount As Integer = 1 To ((DetailsList.Rows.Count - 3) / 3)
                    RowNo += 1

                    Dim Quanity As CellRange = DetailsList.GetCellRange(RowCount * 3, 6)
                    Quanity.StyleNew.Format = "N1"
                    Dim Costea As CellRange = DetailsList.GetCellRange(RowCount * 3 + 1, 6)
                    Costea.StyleNew.Format = "N0"
                    Dim Amount As CellRange = DetailsList.GetCellRange(RowCount * 3 + 2, 6)
                    Amount.StyleNew.Format = "N0"

                    If RowCount Mod 2 = 0 Then
                        DetailsList.Rows(RowCount * 3).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        DetailsList.Rows((RowCount * 3) + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        DetailsList.Rows((RowCount * 3) + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)

                        CategoryList.Rows(RowCount * 3).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        CategoryList.Rows((RowCount * 3) + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        CategoryList.Rows((RowCount * 3) + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)

                        OutsoucerList.Rows(RowCount * 3).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        OutsoucerList.Rows((RowCount * 3) + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        OutsoucerList.Rows((RowCount * 3) + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                    Else
                        DetailsList.Rows(RowCount * 3).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        DetailsList.Rows((RowCount * 3) + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        DetailsList.Rows((RowCount * 3) + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)

                        CategoryList.Rows(RowCount * 3).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        CategoryList.Rows((RowCount * 3) + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        CategoryList.Rows((RowCount * 3) + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)

                        OutsoucerList.Rows(RowCount * 3).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        OutsoucerList.Rows((RowCount * 3) + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        OutsoucerList.Rows((RowCount * 3) + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                    End If

                    DetailsList(RowCount * 3, 7) = RowNo * RowNo
                    DetailsList(RowCount * 3 + 1, 7) = (RowNo * RowNo) + 1
                    DetailsList(RowCount * 3 + 2, 7) = (RowNo * RowNo) + 2
                    If (RowNo * RowNo) + 2 = 6 Then
                        RowNo = 0
                    End If

                    DetailsList.MergedRanges.Add(RowCount * 3, 0, (RowCount * 3) + 2, 0)
                    DetailsList.MergedRanges.Add(RowCount * 3, 2, (RowCount * 3) + 2, 2)
                    DetailsList.MergedRanges.Add(RowCount * 3, 3, (RowCount * 3) + 2, 3)
                    DetailsList.MergedRanges.Add(RowCount * 3, 4, RowCount * 3, 5)
                    DetailsList.MergedRanges.Add((RowCount * 3) + 1, 4, (RowCount * 3) + 1, 5)
                Next

            End If

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub Copy_Click(sender As Object, e As EventArgs) Handles CopyMenu.Click
        Try
            For DetailsRowCount As Integer = 0 To DetailsList.Rows.Count - 1
                If DetailsRowCount < DetailsList.Rows.Count - 3 Then
                    If DetailsList.Rows(DetailsRowCount + 2).Caption = "▶" Then
                        SelectRow = DetailsRowCount + 2
                    End If
                    DetailsList.Rows(DetailsRowCount + 2).StyleFixedNew.BackColor = Color.FromArgb(213, 234, 216)

                End If
            Next

            If SelectRow = 0 Then
                MsgBox("行が選択されていません。", MsgBoxStyle.Exclamation, "明細書")
            Else
                If Command = "Cut" Or Command = "Copy" Then
                    Dim Row As Integer = DetailsList(CopyRow, 3)
                    If Row Mod 2 = 0 Then
                        DetailsList.Rows(CopyRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        DetailsList.Rows(CopyRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        DetailsList.Rows(CopyRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)

                        CategoryList.Rows(CopyRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        CategoryList.Rows(CopyRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        CategoryList.Rows(CopyRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)

                        OutsoucerList.Rows(CopyRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        OutsoucerList.Rows(CopyRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        OutsoucerList.Rows(CopyRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                    Else
                        DetailsList.Rows(CopyRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        DetailsList.Rows(CopyRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        DetailsList.Rows(CopyRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)

                        CategoryList.Rows(CopyRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        CategoryList.Rows(CopyRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        CategoryList.Rows(CopyRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)

                        OutsoucerList.Rows(CopyRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        OutsoucerList.Rows(CopyRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        OutsoucerList.Rows(CopyRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                    End If
                End If
                Command = "Copy"
                DetailsList.Rows(SelectRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(221, 236, 253)
                DetailsList.Rows(SelectRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(221, 236, 253)
                DetailsList.Rows(SelectRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(221, 236, 253)
                CategoryList.Rows(SelectRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(221, 236, 253)
                CategoryList.Rows(SelectRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(221, 236, 253)
                CategoryList.Rows(SelectRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(221, 236, 253)
                OutsoucerList.Rows(SelectRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(221, 236, 253)
                OutsoucerList.Rows(SelectRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(221, 236, 253)
                OutsoucerList.Rows(SelectRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(221, 236, 253)

                CopyRow = SelectRow
                PastingMenu.Enabled = True

            End If

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try

    End Sub

    Private Sub Pasting_Click(sender As Object, e As EventArgs) Handles PastingMenu.Click
        Try

            For DetailsRowCount As Integer = 0 To DetailsList.Rows.Count - 1
                If DetailsRowCount < DetailsList.Rows.Count - 3 AndAlso DetailsList.Rows(DetailsRowCount + 2).Caption = "▶" Then
                    SelectRow = DetailsRowCount + 2
                    Exit For
                End If
            Next

            If SelectRow = 0 Then
                MsgBox("行が選択されていません。", MsgBoxStyle.Exclamation, "明細書")
            Else

                ホーム.Modified = "True"
                If SelectRow < CopyRow Then
                    CopyRow += 3
                End If

                DetailsList.Rows.Insert(SelectRow)
                DetailsList.Rows.Insert(SelectRow + 1)
                DetailsList.Rows.Insert(SelectRow + 2)
                CategoryList.Rows.Insert(SelectRow)
                CategoryList.Rows.Insert(SelectRow + 1)
                CategoryList.Rows.Insert(SelectRow + 2)
                OutsoucerList.Rows.Insert(SelectRow)
                OutsoucerList.Rows.Insert(SelectRow + 1)
                OutsoucerList.Rows.Insert(SelectRow + 2)
                DetailsList(SelectRow, 1) = DetailsList(CopyRow, 1)
                DetailsList(SelectRow, 3) = DetailsList(CopyRow, 3)
                DetailsList(SelectRow, 4) = DetailsList(CopyRow, 4)
                DetailsList(SelectRow + 1, 4) = DetailsList(CopyRow + 1, 4)
                DetailsList(SelectRow + 2, 4) = DetailsList(CopyRow + 2, 4)
                DetailsList(SelectRow + 2, 5) = DetailsList(CopyRow + 2, 5)
                DetailsList(SelectRow, 6) = DetailsList(CopyRow, 6)
                DetailsList(SelectRow + 1, 6) = DetailsList(CopyRow + 1, 6)
                DetailsList(SelectRow + 2, 6) = DetailsList(CopyRow + 2, 6)
                DetailsList(SelectRow, 8) = DetailsList(CopyRow, 8)
                DetailsList(SelectRow, 9) = DetailsList(CopyRow, 9)
                For categoryloop As Integer = 2 To 6
                    CategoryList(SelectRow + 1, categoryloop) = CategoryList(CopyRow + 1, categoryloop)
                    CategoryList(SelectRow + 2, categoryloop) = CategoryList(CopyRow + 2, categoryloop)
                Next

                If Command = "Cut" Then
                    DetailsList.Rows.RemoveRange(CopyRow, 3)
                    CategoryList.Rows.RemoveRange(CopyRow, 3)
                    OutsoucerList.Rows.RemoveRange(CopyRow, 3)
                End If

                Dim RowNo As Integer = 0
                For RowCount As Integer = 1 To ((DetailsList.Rows.Count - 3) / 3)

                    RowNo += 1

                    If RowCount <= ((DetailsList.Rows.Count - 3) / 3) Then
                        DetailsList(RowCount * 3, 3) = RowCount
                    End If

                    Dim Quanity As CellRange = DetailsList.GetCellRange(RowCount * 3, 6)
                    Quanity.StyleNew.Format = "N1"
                    Dim Costea As CellRange = DetailsList.GetCellRange(RowCount * 3 + 1, 6)
                    Costea.StyleNew.Format = "N0"
                    Dim Amount As CellRange = DetailsList.GetCellRange(RowCount * 3 + 2, 6)
                    Amount.StyleNew.Format = "N0"
                    'DetailsList.Rows(RowCount * 3).StyleFixedNew.BackColor = Color.FromArgb(213, 234, 216)


                    If RowCount Mod 2 = 0 Then
                        DetailsList.Rows(RowCount * 3).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        DetailsList.Rows((RowCount * 3) + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        DetailsList.Rows((RowCount * 3) + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)

                        CategoryList.Rows(RowCount * 3).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        CategoryList.Rows((RowCount * 3) + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        CategoryList.Rows((RowCount * 3) + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)

                        OutsoucerList.Rows(RowCount * 3).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        OutsoucerList.Rows((RowCount * 3) + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        OutsoucerList.Rows((RowCount * 3) + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                    Else
                        DetailsList.Rows(RowCount * 3).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        DetailsList.Rows((RowCount * 3) + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        DetailsList.Rows((RowCount * 3) + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)

                        CategoryList.Rows(RowCount * 3).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        CategoryList.Rows((RowCount * 3) + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        CategoryList.Rows((RowCount * 3) + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)

                        OutsoucerList.Rows(RowCount * 3).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        OutsoucerList.Rows((RowCount * 3) + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        OutsoucerList.Rows((RowCount * 3) + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                    End If

                    DetailsList(RowCount * 3, 7) = RowNo * RowNo
                    DetailsList(RowCount * 3 + 1, 7) = (RowNo * RowNo) + 1
                    DetailsList(RowCount * 3 + 2, 7) = (RowNo * RowNo) + 2
                    If (RowNo * RowNo) + 2 = 6 Then
                        RowNo = 0
                    End If

                    DetailsList.MergedRanges.Add(RowCount * 3, 0, (RowCount * 3) + 2, 0)
                    DetailsList.MergedRanges.Add(RowCount * 3, 2, (RowCount * 3) + 2, 2)
                    DetailsList.MergedRanges.Add(RowCount * 3, 3, (RowCount * 3) + 2, 3)
                    DetailsList.MergedRanges.Add(RowCount * 3, 4, RowCount * 3, 5)
                    DetailsList.MergedRanges.Add((RowCount * 3) + 1, 4, (RowCount * 3) + 1, 5)
                Next
            End If

            Command = ""
            CopyRow = 0
            PastingMenu.Enabled = False

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub Cut_Click(sender As Object, e As EventArgs) Handles CutMenu.Click
        Try
            For DetailsRowCount As Integer = 0 To DetailsList.Rows.Count - 1
                If DetailsRowCount < DetailsList.Rows.Count - 3 AndAlso DetailsList.Rows(DetailsRowCount + 2).Caption = "▶" Then
                    SelectRow = DetailsRowCount + 2
                    Exit For
                End If
            Next

            If SelectRow = 0 Then
                MsgBox("行が選択されていません。", MsgBoxStyle.Exclamation, "明細書")
            Else
                If Command = "Cut" Or Command = "Copy" Then
                    Dim Row As Integer = DetailsList(CopyRow, 3)
                    If Row Mod 2 = 0 Then
                        DetailsList.Rows(CopyRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        DetailsList.Rows(CopyRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        DetailsList.Rows(CopyRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)

                        CategoryList.Rows(CopyRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        CategoryList.Rows(CopyRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        CategoryList.Rows(CopyRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)

                        OutsoucerList.Rows(CopyRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        OutsoucerList.Rows(CopyRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        OutsoucerList.Rows(CopyRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                    Else
                        DetailsList.Rows(CopyRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        DetailsList.Rows(CopyRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        DetailsList.Rows(CopyRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)

                        CategoryList.Rows(CopyRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        CategoryList.Rows(CopyRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        CategoryList.Rows(CopyRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)

                        OutsoucerList.Rows(CopyRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        OutsoucerList.Rows(CopyRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        OutsoucerList.Rows(CopyRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                    End If
                End If
                ホーム.Modified = "True"

                Command = "Cut"
                CopyRow = SelectRow
                PastingMenu.Enabled = True


                DetailsList.Rows(SelectRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(221, 236, 253)
                DetailsList.Rows(SelectRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(221, 236, 253)
                DetailsList.Rows(SelectRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(221, 236, 253)
                CategoryList.Rows(SelectRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(221, 236, 253)
                CategoryList.Rows(SelectRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(221, 236, 253)
                CategoryList.Rows(SelectRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(221, 236, 253)
                OutsoucerList.Rows(SelectRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(221, 236, 253)
                OutsoucerList.Rows(SelectRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(221, 236, 253)
                OutsoucerList.Rows(SelectRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(221, 236, 253)

            End If

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub CostCreate_Click(sender As Object, e As EventArgs) Handles CostCreateMenu.Click
        Try
            For DetailsRowCount As Integer = 0 To DetailsList.Rows.Count - 1
                If DetailsRowCount < DetailsList.Rows.Count - 3 AndAlso DetailsList.Rows(DetailsRowCount + 2).Caption = "▶" Then
                    SelectRow = DetailsRowCount + 2
                    Exit For
                End If
            Next

            If SelectRow = 0 Then
                MsgBox("行が選択されていません。", MsgBoxStyle.Exclamation, "明細書")

            Else
                Try
                    For DetailsRowCount As Integer = 0 To DetailsList.Rows.Count - 1
                        If DetailsRowCount < DetailsList.Rows.Count - 3 AndAlso DetailsList.Rows(DetailsRowCount + 2).Caption = "▶" Then
                            SelectRow = DetailsRowCount + 2
                            Exit For
                        End If
                    Next

                    If SelectRow = 0 Then
                        MsgBox("行が選択されていません。", MsgBoxStyle.Exclamation, "明細書")
                    Else

                        If SelectRow = DetailsList.Rows.Count - 3 Then
                            Call Insert_Click(sender, e)
                        End If

                        EntryCommand = "INSERT"
                        作成代価選択.SelectRow = SelectRow
                        作成代価選択.HeadLine.Text = "<<作成代価選択"
                        作成代価選択.Text = "作成代価選択"
                        作成代価選択.ShowDialog()
                        作成代価選択.TopMost = True
                        作成代価選択.TopMost = False

                    End If

                Catch ex As Exception
                    ホーム.ErrorMessage = ex.Message
                    ホーム.StackTrace = ex.StackTrace
                    エラー.Show()
                    Exit Sub
                End Try

            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub CostCreation_Click(sender As Object, e As EventArgs) Handles CostCreation.Click
        Try
            For DetailsRowCount As Integer = 0 To DetailsList.Rows.Count - 1
                If DetailsRowCount < DetailsList.Rows.Count - 3 AndAlso DetailsList.Rows(DetailsRowCount + 2).Caption = "▶" Then
                    SelectRow = DetailsRowCount + 2
                    Exit For
                End If
            Next

            If SelectRow = 0 Then
                MsgBox("行が選択されていません。", MsgBoxStyle.Exclamation, "明細書")

            Else
                Try
                    For DetailsRowCount As Integer = 0 To DetailsList.Rows.Count - 1
                        If DetailsRowCount < DetailsList.Rows.Count - 3 AndAlso DetailsList.Rows(DetailsRowCount + 2).Caption = "▶" Then
                            SelectRow = DetailsRowCount + 2
                            Exit For
                        End If
                    Next

                    If SelectRow = 0 Then
                        MsgBox("行が選択されていません。", MsgBoxStyle.Exclamation, "明細書")
                    Else
                        EntryCommand = "INSERT"

                        If SelectRow = DetailsList.Rows.Count - 3 Then
                            Call Insert_Click(sender, e)
                        End If

                        作成代価選択.SelectRow = SelectRow
                        DetailsList(SelectRow, 3) = SelectRow / 3
                        作成代価選択.HeadLine.Text = "<<作成代価選択"
                        作成代価選択.Text = "作成代価選択"
                        作成代価選択.ShowDialog()
                        作成代価選択.TopMost = True
                        作成代価選択.TopMost = False

                    End If

                Catch ex As Exception
                    ホーム.ErrorMessage = ex.Message
                    ホーム.StackTrace = ex.StackTrace
                    エラー.Show()
                    Exit Sub
                End Try

            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub
    Private Sub ItemSelect_MouseLeave(sender As Object, e As EventArgs) Handles ItemSelect.MouseLeave
        ItemSelect.ImageIndex = 0
    End Sub

    Private Sub ItemSelect_MouseUp(sender As Object, e As MouseEventArgs) Handles ItemSelect.MouseUp
        ItemSelect.ImageIndex = 0
    End Sub

    Private Sub ItemSelect_MouseEnter(sender As Object, e As EventArgs) Handles ItemSelect.MouseEnter
        ItemSelect.Cursor = Cursors.Hand
        ItemSelect.ImageIndex = 1
    End Sub

    Private Sub ItemSelect_MouseDown(sender As Object, e As MouseEventArgs) Handles ItemSelect.MouseDown
        ItemSelect.ImageIndex = 2
    End Sub
    Private Sub Reference_MouseLeave(sender As Object, e As EventArgs) Handles Reference.MouseLeave
        Reference.ImageIndex = 0
    End Sub

    Private Sub Reference_MouseUp(sender As Object, e As MouseEventArgs) Handles Reference.MouseUp
        Reference.ImageIndex = 0
    End Sub

    Private Sub Reference_MouseEnter(sender As Object, e As EventArgs) Handles Reference.MouseEnter
        Reference.Cursor = Cursors.Hand
        Reference.ImageIndex = 1
    End Sub

    Private Sub Reference_MouseDown(sender As Object, e As MouseEventArgs) Handles Reference.MouseDown
        Reference.ImageIndex = 2
    End Sub

    Private Sub ItemSelect_Click(sender As Object, e As EventArgs) Handles ItemSelect.Click
        Try
            For DetailsRowCount As Integer = 0 To DetailsList.Rows.Count - 1
                If DetailsRowCount < DetailsList.Rows.Count - 3 AndAlso DetailsList.Rows(DetailsRowCount + 2).Caption = "▶" Then
                    SelectRow = DetailsRowCount + 2
                    Exit For
                End If
            Next

            If SelectRow = 0 Then
                MsgBox("行が選択されていません。", MsgBoxStyle.Exclamation, "明細書")
            Else
                項目選択.Show()
                項目選択.TopMost = True
                項目選択.TopMost = False

            End If

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try

    End Sub

    Private Sub CostModify_Click(sender As Object, e As EventArgs) Handles CostModify.Click
        Try
            For DetailsRowCount As Integer = 0 To DetailsList.Rows.Count - 1
                If DetailsRowCount < DetailsList.Rows.Count - 3 AndAlso DetailsList.Rows(DetailsRowCount + 2).Caption = "▶" Then
                    SelectRow = DetailsRowCount + 2
                    Exit For
                End If
            Next

            If DetailsList(SelectRow, 8) >= 12 Then

                ホーム.ProjectCostForm.Add(New 代価表入力)
                ホーム.ProjectCostForm(0).TopLevel = False
                ホーム.FormPanel.Controls.Add(ホーム.ProjectCostForm(0))
                ホーム.ProjectCostSelectRow.Add(SelectRow)
                ホーム.ProjectCostID.Add(DetailsList(SelectRow, 9))
                ホーム.PrjctCstClassCode.Add(DetailsList(SelectRow, 8))
                ホーム.PrjctCstList.Add(DetailsList)
                Dim count As Integer = ホーム.PrjctCstList.Count
                ホーム.ProjectCostForm(0).Show()
                Me.Visible = False


                Dim NodeExpand As String = ""

                Dim remarks As String = DetailsList(SelectRow + 2, 4)
                remarks = remarks.Replace("第", "")
                remarks = remarks.Replace("号", "")

                If ホーム.SelectNodeList.Count > 0 Then
                    Dim NodeExpandLoad As New TreeNode_ChildExpand(ホーム.SelectNodeList(1), DetailsList(SelectRow, 3) & " " & DetailsList(SelectRow, 4) & "(" & remarks & ")")
                    NodeExpand = NodeExpandLoad.NodeExpand
                End If
            Else
                MsgBox("選択された行には工事代価が登録されていません。", MsgBoxStyle.Exclamation, "明細書")
            End If
        Catch ex As Exception
        ホーム.ErrorMessage = ex.Message
        ホーム.StackTrace = ex.StackTrace
        エラー.Show()
        Exit Sub
        End Try
    End Sub

    Private Sub CostModifyMenu_Click(sender As Object, e As EventArgs) Handles CostModifyMenu.Click
        Try
            For DetailsRowCount As Integer = 0 To DetailsList.Rows.Count - 1
                If DetailsRowCount < DetailsList.Rows.Count - 3 AndAlso DetailsList.Rows(DetailsRowCount + 2).Caption = "▶" Then
                    SelectRow = DetailsRowCount + 2
                    Exit For
                End If
            Next

            If DetailsList(SelectRow, 8) >= 12 Then
                ホーム.ProjectCostForm.Add(New 代価表入力)
                ホーム.ProjectCostForm(0).TopLevel = False
                ホーム.FormPanel.Controls.Add(ホーム.ProjectCostForm(0))
                ホーム.ProjectCostSelectRow.Add(SelectRow)
                ホーム.ProjectCostID.Add(DetailsList(SelectRow, 9))
                ホーム.PrjctCstClassCode.Add(DetailsList(SelectRow, 8))
                ホーム.PrjctCstList.Add(DetailsList)
                ホーム.ProjectCostForm(0).Show()
                Me.Visible = False

                Dim NodeExpand As String = ""

                Dim remarks As String = DetailsList(SelectRow + 2, 4)
                remarks = remarks.Replace("第", "")
                remarks = remarks.Replace("号", "")
                EntryCommand = "INSERT"

                If ホーム.SelectNodeList.Count > 0 Then
                    Dim NodeExpandLoad As New TreeNode_ChildExpand(ホーム.SelectNodeList(1), DetailsList(SelectRow, 3) & " " & DetailsList(SelectRow, 4) & "(" & remarks & ")")
                    NodeExpand = NodeExpandLoad.NodeExpand
                End If

            Else
                    MsgBox("選択された行には工事代価が登録されていません。", MsgBoxStyle.Exclamation, "明細書")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub CostCopy_Click(sender As Object, e As EventArgs) Handles CostCopy.Click
        Try
            For DetailsRowCount As Integer = 0 To DetailsList.Rows.Count - 1
                If DetailsRowCount < DetailsList.Rows.Count - 3 AndAlso DetailsList.Rows(DetailsRowCount + 2).Caption = "▶" Then
                    SelectRow = DetailsRowCount + 2
                    Exit For
                End If
            Next

            If SelectRow = 0 Then
                MsgBox("行が選択されていません。", MsgBoxStyle.Exclamation, "明細書")
            Else

                Command = "CostCopy"
                If DetailsList(SelectRow, 8) >= 12 Then

                    作成代価選択.HeadLine.Text = "<<コピー代価選択"
                    作成代価選択.Text = "コピー代価選択"
                    作成代価選択.SelectRow = SelectRow

                    作成代価選択.ShowDialog()
                    作成代価選択.TopMost = True
                    作成代価選択.TopMost = False
                Else
                    MsgBox("選択された行には工事代価が登録されていません。", MsgBoxStyle.Exclamation, "明細書")
                End If

            End If

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub CostCopyMenu_Click(sender As Object, e As EventArgs) Handles CostCopyMenu.Click
        Try
            For DetailsRowCount As Integer = 0 To DetailsList.Rows.Count - 1
                If DetailsRowCount < DetailsList.Rows.Count - 3 AndAlso DetailsList.Rows(DetailsRowCount + 2).Caption = "▶" Then
                    SelectRow = DetailsRowCount + 2
                    Exit For
                End If
            Next

            If SelectRow = 0 Then
                MsgBox("行が選択されていません。", MsgBoxStyle.Exclamation, "明細書")
            Else
                Command = "CostCopy"

                If DetailsList(SelectRow, 8) >= 12 Then

                    作成代価選択.HeadLine.Text = "<<コピー代価選択"
                    作成代価選択.Text = "コピー代価選択"
                    作成代価選択.SelectRow = SelectRow

                    作成代価選択.ShowDialog()
                    作成代価選択.TopMost = True
                    作成代価選択.TopMost = False
                Else
                    MsgBox("選択された行には工事代価が登録されていません。", MsgBoxStyle.Exclamation, "明細書")
                End If

            End If

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub Reference_Click(sender As Object, e As EventArgs) Handles Reference.Click
        Try
            For DetailsRowCount As Integer = 0 To DetailsList.Rows.Count - 1
                If DetailsRowCount < DetailsList.Rows.Count - 3 AndAlso DetailsList.Rows(DetailsRowCount + 2).Caption = "▶" Then
                    SelectRow = DetailsRowCount + 2
                    Exit For
                End If
            Next

            If SelectRow = 0 Then
                MsgBox("行が選択されていません。", MsgBoxStyle.Exclamation, "明細書")

            Else
                If DetailsList(SelectRow, 8) >= 12 Then
                    代価表入力.SelectRow = SelectRow
                    代価表入力.CostID = DetailsList(SelectRow, 9)
                    代価表入力.ClassCode = DetailsList(SelectRow, 8)
                    Dim ClassLoad As String = ""
                    Dim ReferenceLoad As New Reference
                    ClassLoad = ReferenceLoad.ReferenceStyle

                Else
                    MsgBox("選択された行には工事代価が登録されていません。", MsgBoxStyle.Exclamation, "明細書")
                End If
            End If
        Catch ex As Exception
            ホーム.Transaction.Rollback()
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub ReferenceMenu_Click(sender As Object, e As EventArgs) Handles ReferenceMenu.Click
        Try
            For DetailsRowCount As Integer = 0 To DetailsList.Rows.Count - 1
                If DetailsRowCount < DetailsList.Rows.Count - 3 AndAlso DetailsList.Rows(DetailsRowCount + 2).Caption = "▶" Then
                    SelectRow = DetailsRowCount + 2
                    Exit For
                End If
            Next

            If DetailsList(SelectRow, 8) >= 12 Then
                代価表入力.SelectRow = SelectRow
                代価表入力.CostID = DetailsList(SelectRow, 9)
                代価表入力.ClassCode = DetailsList(SelectRow, 8)
                Dim ClassLoad As String = ""
                Dim ReferenceLoad As New Reference
                ClassLoad = ReferenceLoad.ReferenceStyle

            Else
                MsgBox("選択された行には工事代価が登録されていません。", MsgBoxStyle.Exclamation, "明細書")
            End If
        Catch ex As Exception
            ホーム.Transaction.Rollback()
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub Entry_Click(sender As Object, e As EventArgs) Handles Entry.Click

        Try

            Dim ErrorRow As String = ""
            Dim ErrorCount As Integer = 0
            For RowCount As Integer = 1 To ((DetailsList.Rows.Count - 3) / 3)
                If IsNothing(DetailsList(RowCount, 2)) = False Then
                    Dim Name As String = DetailsList(RowCount * 3, 4)
                    If Not (RowCount * 3) = DetailsList.Rows.Count - 3 Then
                        If IsNothing(Name) = True AndAlso IsNothing(DetailsList(RowCount * 3, 3)) = False Then
                            If Name.Length = 0 Then
                                ErrorCount += 1
                                DetailsList.Rows(RowCount * 3).StyleFixedNew.BackColor = Color.FromArgb(255, 192, 192)
                            End If
                        End If
                    Else
                        If IsNothing(Name) = True AndAlso IsNothing(DetailsList(RowCount * 3, 3)) = False Then
                            ErrorCount += 1
                            DetailsList.Rows(RowCount * 3).StyleFixedNew.BackColor = Color.FromArgb(255, 192, 192)
                        End If
                    End If
                End If
            Next

            If ErrorCount >= 1 Then
                MsgBox("名称が入力されていない行があります。", MsgBoxStyle.Exclamation, "明細書入力")
                Exit Sub
            End If


            ホーム.Transaction = ホーム.Connection.BeginTransaction

            ホーム.Sql.Transaction = ホーム.Transaction


            For RowCount As Integer = 1 To ((DetailsList.Rows.Count - 3) / 3)
                ホーム.Sql.CommandText = ""
                ホーム.Sql.Parameters.Clear()
                If IsNothing(DetailsList(RowCount * 3, 4)) = False AndAlso IsNothing(DetailsList(RowCount * 3, 3)) = False Then
                    If DetailsList(RowCount * 3, 2) = "False" Or IsNothing(DetailsList(RowCount * 3, 2)) = True Then
                        ホーム.Sql.Parameters.Add(New SqlParameter("@dtlno", SqlDbType.SmallInt)).Value = DetailsList(RowCount * 3, 3)
                        If IsNothing(DetailsList(RowCount * 3, 8)) = True Then
                            ホーム.Sql.Parameters.Add(New SqlParameter("@cstclsscode", SqlDbType.SmallInt)).Value = 0
                            ホーム.Sql.Parameters.Add(New SqlParameter("@cstmstrid", SqlDbType.SmallInt)).Value = 0
                        Else
                            ホーム.Sql.Parameters.Add(New SqlParameter("@cstclsscode", SqlDbType.SmallInt)).Value = DetailsList(RowCount * 3, 8)
                            ホーム.Sql.Parameters.Add(New SqlParameter("@cstmstrid", SqlDbType.SmallInt)).Value = DetailsList(RowCount * 3, 9)
                        End If
                        ホーム.Sql.Parameters.Add(New SqlParameter("@name", SqlDbType.NVarChar)).Value = DetailsList(RowCount * 3, 4)
                        If IsNothing(DetailsList(RowCount * 3 + 1, 4)) = True Then
                            ホーム.Sql.Parameters.Add(New SqlParameter("@spec", SqlDbType.NVarChar)).Value = ""
                        Else
                            ホーム.Sql.Parameters.Add(New SqlParameter("@spec", SqlDbType.NVarChar)).Value = DetailsList(RowCount * 3 + 1, 4)
                        End If
                        If IsNothing(DetailsList(RowCount * 3 + 2, 5)) = True Then
                            ホーム.Sql.Parameters.Add(New SqlParameter("@unit", SqlDbType.NVarChar)).Value = ""
                        Else
                            ホーム.Sql.Parameters.Add(New SqlParameter("@unit", SqlDbType.NVarChar)).Value = DetailsList(RowCount * 3 + 2, 5)
                        End If
                        If IsNothing(DetailsList(RowCount * 3, 6)) = True Then
                            ホーム.Sql.Parameters.Add(New SqlParameter("@quanity", SqlDbType.Decimal)).Value = 0
                        Else
                            ホーム.Sql.Parameters.Add(New SqlParameter("@quanity", SqlDbType.Decimal)).Value = DetailsList(RowCount * 3, 6)
                        End If
                        If IsNothing(DetailsList(RowCount * 3 + 1, 6)) = True Then
                            ホーム.Sql.Parameters.Add(New SqlParameter("@costea", SqlDbType.Money)).Value = 0
                        Else
                            ホーム.Sql.Parameters.Add(New SqlParameter("@costea", SqlDbType.Money)).Value = DetailsList(RowCount * 3 + 1, 6)
                        End If
                        If IsNothing(CategoryList(RowCount * 3 + 1, 2)) = True Then
                            ホーム.Sql.Parameters.Add(New SqlParameter("@labor", SqlDbType.Money)).Value = 0
                        Else
                            ホーム.Sql.Parameters.Add(New SqlParameter("@labor", SqlDbType.Money)).Value = CategoryList(RowCount * 3 + 1, 2)
                        End If
                        If IsNothing(CategoryList(RowCount * 3 + 1, 3)) = True Then
                            ホーム.Sql.Parameters.Add(New SqlParameter("@material", SqlDbType.Money)).Value = 0
                        Else
                            ホーム.Sql.Parameters.Add(New SqlParameter("@material", SqlDbType.Money)).Value = CategoryList(RowCount * 3 + 1, 3)
                        End If
                        If IsNothing(CategoryList(RowCount * 3 + 1, 4)) = True Then
                            ホーム.Sql.Parameters.Add(New SqlParameter("@machine", SqlDbType.Money)).Value = 0
                        Else
                            ホーム.Sql.Parameters.Add(New SqlParameter("@machine", SqlDbType.Money)).Value = CategoryList(RowCount * 3 + 1, 4)
                        End If
                        If IsNothing(CategoryList(RowCount * 3 + 1, 5)) = True Then
                            ホーム.Sql.Parameters.Add(New SqlParameter("@subcntrct", SqlDbType.Money)).Value = 0
                        Else
                            ホーム.Sql.Parameters.Add(New SqlParameter("@subcntrct", SqlDbType.Money)).Value = CategoryList(RowCount * 3 + 1, 5)
                        End If
                        If IsNothing(CategoryList(RowCount * 3 + 1, 6)) = True Then
                            ホーム.Sql.Parameters.Add(New SqlParameter("@expens", SqlDbType.Money)).Value = 0
                        Else
                            ホーム.Sql.Parameters.Add(New SqlParameter("@expens", SqlDbType.Money)).Value = CategoryList(RowCount * 3 + 1, 6)
                        End If
                        ホーム.Sql.Parameters.Add(New SqlParameter("@fraction", SqlDbType.Money)).Value = 0
                        If IsNothing(DetailsList(RowCount * 3 + 2, 4)) = True Then
                            ホーム.Sql.Parameters.Add(New SqlParameter("@remarks", SqlDbType.NVarChar)).Value = ""
                        Else
                            ホーム.Sql.Parameters.Add(New SqlParameter("@remarks", SqlDbType.NVarChar)).Value = DetailsList(RowCount * 3 + 2, 4)
                        End If

                        If DetailsList(RowCount * 3, 1) = 0 Then
                            ホーム.Sql.Parameters.Add(New SqlParameter("@budgetno", SqlDbType.SmallInt)).Value = ホーム.BudgetNo
                            ホーム.Sql.Parameters.Add(New SqlParameter("@sworktypecode", SqlDbType.SmallInt)).Value = ホーム.sworktypecode
                            ホーム.Sql.CommandText = "INSERT INTO details (budget_no,dtl_no,s_worktype_code,cstclss_code,cstmstr_id,dtl_name,dtl_spec
                                                                   ,dtl_unit,dtl_quanity,dtl_costea,dtl_labor,dtl_material,dtl_machine,dtl_subcntrct,dtl_expens
                                                                    ,dtl_fraction,dtl_remarks) 
                                                  VALUES (@budgetno,@dtlno,@sworktypecode,@cstclsscode,@cstmstrid,@name,@spec,@unit,@quanity,@costea,
                                                  @labor,@material,@machine,@subcntrct,@expens,@fraction,@remarks)"
                        Else
                            ホーム.Sql.CommandText = "UPDATE details SET dtl_no=@dtlno,cstclss_code=@cstclsscode,cstmstr_id=@cstmstrid,dtl_name=@name 
                                        ,dtl_spec=@spec,dtl_unit=@unit,dtl_quanity=@quanity,dtl_costea=@costea,dtl_labor=@labor,dtl_material=@material
                                        ,dtl_machine=@machine,dtl_subcntrct=@subcntrct,dtl_expens=@expens,dtl_fraction=@fraction,dtl_remarks=@remarks WHERE dtl_id=" & DetailsList(RowCount * 3, 1)
                        End If
                        ホーム.Sql.ExecuteNonQuery()
                    Else
                        If Not DetailsList(RowCount * 3, 1) = 0 Then
                            ホーム.Sql.CommandText = "DELETE FROM details WHERE dtl_id=" & DetailsList(RowCount * 3, 1)
                            ホーム.Sql.ExecuteNonQuery()
                            ホーム.Sql.CommandText = "DELETE FROM outsourcing_plans WHERE dtl_id=" & DetailsList(RowCount * 3, 1)
                            ホーム.Sql.ExecuteNonQuery()
                            ホーム.Sql.CommandText = "DELETE FROM productions WHERE dtl_id=" & DetailsList(RowCount * 3, 1)
                            ホーム.Sql.ExecuteNonQuery()
                        End If
                    End If
                End If

                If IsNothing(DetailsList(RowCount * 3, 4)) = False AndAlso IsNothing(DetailsList(RowCount * 3, 3)) = False Then
                    ホーム.Sql.CommandText = "SELECT dtl_id FROM details WHERE budget_no=" & ホーム.BudgetNo & " AND s_worktype_code=" & ホーム.sworktypecode & " AND dtl_no=" & DetailsList(RowCount * 3, 3)
                    Dim detailid As Integer = ホーム.Sql.ExecuteScalar

                    ホーム.Sql.CommandText = "SELECT Count(*) FROM outsourcing_plans WHERE budget_no=" & ホーム.BudgetNo
                    Dim TableDataCount As Integer = ホーム.Sql.ExecuteScalar

                    Dim MaxNo As Integer = 0
                    If TableDataCount > 0 Then
                        ホーム.Sql.CommandText = "SELECT MAX(outsrc_no) FROM outsourcing_plans WHERE budget_no=" & ホーム.BudgetNo
                        MaxNo = ホーム.Sql.ExecuteScalar
                    End If

                    Dim ColCount As Integer = OutsoucerList.Cols.Count - 1
                    Dim DataCount As Integer = 0
                    For OutsrcrCount As Integer = 1 To ColCount
                        ホーム.Sql.CommandText = ""
                        ホーム.Sql.Parameters.Clear()
                        If IsNothing(OutsoucerList(0, OutsrcrCount + 1)) = False Then
                            ホーム.Sql.CommandText = "SELECT outsrcr_id FROM outsourcers WHERE outsrcr_code=" & OutsoucerList(0, OutsrcrCount + 1)
                            Dim outsrcrid As Integer = ホーム.Sql.ExecuteScalar

                            ホーム.Sql.CommandText = "SELECT Count(*) FROM outsourcing_plans WHERE budget_no=" & ホーム.BudgetNo & " AND outsrc_no=" & MaxNo & " AND outsrcr_id=" & outsrcrid & " AND dtl_id=" & detailid
                            Dim PlanCount As Integer = ホーム.Sql.ExecuteScalar

                            If IsNothing(DetailsList(RowCount * 3, 8)) = True Then
                                ホーム.Sql.Parameters.Add(New SqlParameter("@cstclsscode", SqlDbType.SmallInt)).Value = 0
                            Else
                                ホーム.Sql.Parameters.Add(New SqlParameter("@cstclsscode", SqlDbType.SmallInt)).Value = DetailsList(RowCount * 3, 8)
                            End If
                            If IsNothing(OutsoucerList(RowCount * 3, OutsrcrCount + 1)) = True Then
                                ホーム.Sql.Parameters.Add(New SqlParameter("@quanity", SqlDbType.Decimal)).Value = 0
                            Else
                                ホーム.Sql.Parameters.Add(New SqlParameter("@quanity", SqlDbType.Decimal)).Value = OutsoucerList(RowCount * 3, OutsrcrCount + 1)
                            End If
                            If IsNothing(OutsoucerList((RowCount * 3) + 1, OutsrcrCount + 1)) = True Then
                                ホーム.Sql.Parameters.Add(New SqlParameter("@costea", SqlDbType.Money)).Value = 0
                            Else
                                ホーム.Sql.Parameters.Add(New SqlParameter("@costea", SqlDbType.Money)).Value = OutsoucerList((RowCount * 3) + 1, OutsrcrCount + 1)
                            End If
                            If PlanCount = 0 Then
                                ホーム.Sql.Parameters.Add(New SqlParameter("@budgetno", SqlDbType.SmallInt)).Value = ホーム.BudgetNo
                                ホーム.Sql.Parameters.Add(New SqlParameter("@outsrcno", SqlDbType.SmallInt)).Value = MaxNo
                                ホーム.Sql.Parameters.Add(New SqlParameter("@dtlid", SqlDbType.SmallInt)).Value = detailid
                                ホーム.Sql.Parameters.Add(New SqlParameter("@outsrcrid", SqlDbType.SmallInt)).Value = outsrcrid
                                ホーム.Sql.Parameters.Add(New SqlParameter("@createddate", SqlDbType.DateTime)).Value = Today

                                ホーム.Sql.CommandText = "INSERT INTO outsourcing_plans (budget_no,outsrc_no,cstclss_code,outsrcr_id,dtl_id,outsrcng_quanity
                                                                   ,outsrcng_costea,created_date) 
                                                  VALUES (@budgetno,@outsrcno,@cstclsscode,@outsrcrid,@dtlid,@quanity,@costea,@createddate)"
                            Else
                                ホーム.Sql.CommandText = "UPDATE outsourcing_plans SET cstclss_code=@cstclsscode,outsrcng_quanity=@quanity,outsrcng_costea=@costea 
                                                     WHERE budget_no=" & ホーム.BudgetNo & " AND outsrc_no=" & MaxNo & " AND outsrcr_id=" & outsrcrid & " AND dtl_id=" & detailid
                            End If
                            ホーム.Sql.ExecuteNonQuery()

                        End If
                    Next
                End If
            Next

            ホーム.Transaction.Commit()

            For RowCount As Integer = 1 To ((DetailsList.Rows.Count - 3) / 3)
                If RowCount * 3 <= (DetailsList.Rows.Count - 3) Then
                    If DetailsList(RowCount * 3, 2) = "True" Then
                        DetailsList.Rows.RemoveRange(RowCount * 3, 3)
                        CategoryList.Rows.RemoveRange(RowCount * 3, 3)
                        OutsoucerList.Rows.RemoveRange(RowCount * 3, 3)
                        RowCount = RowCount - 1
                    End If
                    If RowCount * 3 = (DetailsList.Rows.Count - 3) Then
                        Dim Name As String = DetailsList(RowCount * 3, 4)
                        If IsNothing(Name) = False Then
                            If Name.Length > 0 Or IsNothing(DetailsList((RowCount * 3), 3)) = False Then
                                DetailsList.Rows.Insert(RowCount * 3)
                                DetailsList.Rows.Insert((RowCount * 3) + 1)
                                DetailsList.Rows.Insert((RowCount * 3) + 2)
                                CategoryList.Rows.Insert(RowCount * 3)
                                CategoryList.Rows.Insert((RowCount * 3) + 1)
                                CategoryList.Rows.Insert((RowCount * 3) + 2)
                                OutsoucerList.Rows.Insert(RowCount * 3)
                                OutsoucerList.Rows.Insert((RowCount * 3) + 1)
                                OutsoucerList.Rows.Insert((RowCount * 3) + 2)
                            End If
                        End If
                    End If
                End If
            Next


            Dim RowNo As Integer = 0
            For RowCount As Integer = 1 To ((DetailsList.Rows.Count - 3) / 3)
                RowNo += 1

                Dim Quanity As CellRange = DetailsList.GetCellRange(RowCount * 3, 6)
                Quanity.StyleNew.Format = "N1"
                Dim Costea As CellRange = DetailsList.GetCellRange(RowCount * 3 + 1, 6)
                Costea.StyleNew.Format = "N0"
                Dim Amount As CellRange = DetailsList.GetCellRange(RowCount * 3 + 2, 6)
                Amount.StyleNew.Format = "N0"
                DetailsList.Rows(RowCount * 3).StyleFixedNew.BackColor = Color.FromArgb(213, 234, 216)


                If RowCount Mod 2 = 0 Then
                    DetailsList.Rows(RowCount * 3).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                    DetailsList.Rows((RowCount * 3) + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                    DetailsList.Rows((RowCount * 3) + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)

                    CategoryList.Rows(RowCount * 3).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                    CategoryList.Rows((RowCount * 3) + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                    CategoryList.Rows((RowCount * 3) + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)

                    OutsoucerList.Rows(RowCount * 3).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                    OutsoucerList.Rows((RowCount * 3) + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                    OutsoucerList.Rows((RowCount * 3) + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                Else
                    DetailsList.Rows(RowCount * 3).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                    DetailsList.Rows((RowCount * 3) + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                    DetailsList.Rows((RowCount * 3) + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)

                    CategoryList.Rows(RowCount * 3).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                    CategoryList.Rows((RowCount * 3) + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                    CategoryList.Rows((RowCount * 3) + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)

                    OutsoucerList.Rows(RowCount * 3).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                    OutsoucerList.Rows((RowCount * 3) + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                    OutsoucerList.Rows((RowCount * 3) + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                End If

                DetailsList(RowCount * 3, 7) = RowNo * RowNo
                DetailsList(RowCount * 3 + 1, 7) = (RowNo * RowNo) + 1
                DetailsList(RowCount * 3 + 2, 7) = (RowNo * RowNo) + 2
                If (RowNo * RowNo) + 2 = 6 Then
                    RowNo = 0
                End If

                DetailsList.MergedRanges.Add(RowCount * 3, 0, (RowCount * 3) + 2, 0)
                DetailsList.MergedRanges.Add(RowCount * 3, 2, (RowCount * 3) + 2, 2)
                DetailsList.MergedRanges.Add(RowCount * 3, 3, (RowCount * 3) + 2, 3)
                DetailsList.MergedRanges.Add(RowCount * 3, 4, RowCount * 3, 5)
                DetailsList.MergedRanges.Add((RowCount * 3) + 1, 4, (RowCount * 3) + 1, 5)
            Next

        ホーム.Modified = "False"
        EntryCommand = ""


            If ホーム.HomeTreeView.Nodes.Count > 0 Then
                ホーム.HomeTreeView.CollapseAll()
                ホーム.SelectNodeList(0).Expand()
            End If

            MsgBox("登録完了", MsgBoxStyle.OkOnly, "明細書入力")

            ホーム.Sql.CommandText = ""
            ホーム.Sql.Parameters.Clear()

            Me.Close()
            小工種選択.TopLevel = False
            ホーム.FormPanel.Controls.Add(小工種選択)
            小工種選択.Show()

        Catch ex As Exception
            'ホーム.Transaction.Rollback()
            ホーム.ErrorMessage = ex.Message
        ホーム.StackTrace = ex.StackTrace
        エラー.Show()
        Exit Sub
        End Try

    End Sub

    Private Sub DetailsList_AfterEdit(sender As Object, e As RowColEventArgs) Handles DetailsList.AfterEdit
        Try

            ホーム.Modified = "True"

            Dim Row As Integer = e.Row
            Dim Col As Integer = e.Col


            If Col = 6 Then
                If IsNumeric(DetailsList(Row, 6)) = True Then
                    If DetailsList(Row, 7) = 1 Or DetailsList(Row, 7) = 4 Then
                        DetailsList(Row + 2, 6) = Math.Floor((DetailsList(Row, 6) * DetailsList(Row + 1, 6)))
                        CategoryList(Row + 2, 2) = Math.Floor((DetailsList(Row, 6) * CategoryList(Row + 1, 2)))
                        CategoryList(Row + 2, 3) = Math.Floor((DetailsList(Row, 6) * CategoryList(Row + 1, 3)))
                        CategoryList(Row + 2, 4) = Math.Floor((DetailsList(Row, 6) * CategoryList(Row + 1, 4)))
                        CategoryList(Row + 2, 5) = Math.Floor((DetailsList(Row, 6) * CategoryList(Row + 1, 5)))
                        CategoryList(Row + 2, 6) = Math.Floor((DetailsList(Row, 6) * CategoryList(Row + 1, 6)))

                    ElseIf DetailsList(Row, 7) = 2 Or DetailsList(Row, 7) = 5 Then
                        DetailsList(Row + 1, 6) = Math.Floor((DetailsList(Row, 6) * DetailsList(Row - 1, 6)))
                    End If

                    Dim RowNo As Integer = 0
                    Dim ColTotal As Int64 = 0
                    Dim LaborColTotal As Int64 = 0
                    Dim MaterialColTotal As Int64 = 0
                    Dim MachineColTotal As Int64 = 0
                    Dim SubcntrctColTotal As Int64 = 0
                    Dim ExpenseColTotal As Int64 = 0


                    For RowCount As Integer = 1 To ((DetailsList.Rows.Count - 3) / 3)


                        ColTotal += DetailsList((RowCount * 3) + 2, 6)
                        LaborColTotal += CategoryList((RowCount * 3) + 2, 2)
                        MaterialColTotal += CategoryList((RowCount * 3) + 2, 3)
                        MachineColTotal += CategoryList((RowCount * 3) + 2, 4)
                        SubcntrctColTotal += CategoryList((RowCount * 3) + 2, 5)
                        ExpenseColTotal += CategoryList((RowCount * 3) + 2, 6)

                    Next

                    DetailTotal.Value = ColTotal
                    CategoryTotalList(0, 2) = LaborColTotal
                    CategoryTotalList(0, 3) = MaterialColTotal
                    CategoryTotalList(0, 4) = MachineColTotal
                    CategoryTotalList(0, 5) = SubcntrctColTotal
                    CategoryTotalList(0, 6) = ExpenseColTotal

                End If

                Dim RowIndex As Integer = DetailsList(Row, 7)

                If IsKeyDown(Windows.Input.Key.Enter) = True Then
                    If RowIndex = 2 Or RowIndex = 5 Then
                        CategoryList.Focus()
                        CategoryList.Select(Row, 2)


                    ElseIf RowIndex = 1 Or RowIndex = 4 Then
                        If ホーム.ItemSelect = "true" Then
                            DetailsList.Select(Row + 2, 4)
                            ホーム.ItemSelect = ""
                        End If
                    End If

                End If

            ElseIf Col = 4 Then

                If Row + 3 = DetailsList.Rows.Count Then
                    DetailsList.Rows.Add(3)
                    CategoryList.Rows.Add(3)
                    OutsoucerList.Rows.Add(3)
                    Dim NewRow As Integer = Row + 3

                    Dim Quanity As CellRange = DetailsList.GetCellRange(NewRow, 6)
                    Quanity.StyleNew.Format = "N1"
                    Dim Costea As CellRange = DetailsList.GetCellRange(NewRow + 1, 6)
                    Costea.StyleNew.Format = "N0"
                    Dim Amount As CellRange = DetailsList.GetCellRange(NewRow + 2, 6)
                    Amount.StyleNew.Format = "N0"
                    DetailsList.Rows(NewRow).StyleFixedNew.BackColor = Color.FromArgb(213, 234, 216)


                    If NewRow Mod 2 = 0 Then
                        DetailsList.Rows(NewRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        DetailsList.Rows(NewRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        DetailsList.Rows(NewRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)

                        CategoryList.Rows(NewRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        CategoryList.Rows(NewRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        CategoryList.Rows(NewRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)

                        OutsoucerList.Rows(NewRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        OutsoucerList.Rows(NewRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        OutsoucerList.Rows(NewRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)

                        DetailsList(NewRow, 7) = 4
                        DetailsList(NewRow + 1, 7) = 5
                        DetailsList(NewRow + 2, 7) = 6

                    Else
                        DetailsList.Rows(NewRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        DetailsList.Rows(NewRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        DetailsList.Rows(NewRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)

                        CategoryList.Rows(NewRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        CategoryList.Rows(NewRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        CategoryList.Rows(NewRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)

                        OutsoucerList.Rows(NewRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        OutsoucerList.Rows(NewRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        OutsoucerList.Rows(NewRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)


                        DetailsList(NewRow, 7) = 1
                        DetailsList(NewRow + 1, 7) = 2
                        DetailsList(NewRow + 2, 7) = 3

                    End If

                    DetailsList.MergedRanges.Add(NewRow, 0, NewRow + 2, 0)
                    DetailsList.MergedRanges.Add(NewRow, 2, NewRow + 2, 2)
                    DetailsList.MergedRanges.Add(NewRow, 3, NewRow + 2, 3)
                    DetailsList.MergedRanges.Add(NewRow, 4, NewRow, 5)
                    DetailsList.MergedRanges.Add(NewRow + 1, 4, NewRow + 1, 5)

                End If



                If IsKeyDown(Windows.Input.Key.Enter) = True AndAlso Key = "" Then
                    Key = "enter"
                    Dim RowIndex As Integer = DetailsList(Row, 7)
                    If RowIndex = 3 Or RowIndex = 6 Then
                        If DetailsList(Row, 4) <> "" Then
                            SendKeys.Send("{UP}")
                            SendKeys.Send("{RIGHT}")
                        End If
                    End If
                End If
            ElseIf Col = 5 Then
                If IsKeyDown(Windows.Input.Key.Enter) = True Then
                    Dim RowIndex As Integer = DetailsList(Row, 7)

                    If RowIndex = 3 Or RowIndex = 6 Then
                        DetailsList.Select(Row - 3, 6)
                    End If
                End If
            End If

            Dim DeleteRow As Integer = 0
            For RowCount As Integer = 1 To ((DetailsList.Rows.Count - 3) / 3)
                If IsNothing(DetailsList(RowCount * 3, 2)) = True Then
                    If RowCount <= ((DetailsList.Rows.Count - 3) / 3) Then
                        If IsNothing(DetailsList(RowCount * 3, 4)) = False Then
                            DetailsList(RowCount * 3, 3) = RowCount - DeleteRow
                        End If
                    End If
                Else
                    If DetailsList(RowCount * 3, 2) = False Then
                        If RowCount <= ((DetailsList.Rows.Count - 3) / 3) Then
                            If IsNothing(DetailsList(RowCount * 3, 4)) = False Then
                                DetailsList(RowCount * 3, 3) = RowCount - DeleteRow
                            End If
                        End If
                    Else
                        DeleteRow += 1
                    End If
                End If
            Next

        Catch ex As Exception
            ホーム.Transaction.Rollback()
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try

    End Sub

    Private Sub 明細書入力_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        Try
            If Me.Visible = True Then

                Dim RowNo As Integer = 0
                Dim ColTotal As Int64 = 0
                Dim LaborColTotal As Int64 = 0
                Dim MaterialColTotal As Int64 = 0
                Dim MachineColTotal As Int64 = 0
                Dim SubcntrctColTotal As Int64 = 0
                Dim ExpenseColTotal As Int64 = 0

                For RowCount As Integer = 1 To ((DetailsList.Rows.Count - 3) / 3)

                    ColTotal += DetailsList((RowCount * 3) + 2, 6)
                    LaborColTotal += CategoryList((RowCount * 3) + 2, 2)
                    MaterialColTotal += CategoryList((RowCount * 3) + 2, 3)
                    MachineColTotal += CategoryList((RowCount * 3) + 2, 4)
                    SubcntrctColTotal += CategoryList((RowCount * 3) + 2, 5)
                    ExpenseColTotal += CategoryList((RowCount * 3) + 2, 6)

                Next

                DetailTotal.Value = ColTotal
                CategoryTotalList(0, 2) = LaborColTotal
                CategoryTotalList(0, 3) = MaterialColTotal
                CategoryTotalList(0, 4) = MachineColTotal
                CategoryTotalList(0, 5) = SubcntrctColTotal
                CategoryTotalList(0, 6) = ExpenseColTotal

            End If

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub DetailsList_DoubleClick(sender As Object, e As EventArgs) Handles DetailsList.DoubleClick
        Try
            Dim range As CellRange = DetailsList.CursorCell

            Dim row As Integer = range.TopRow
            Dim col As Integer = range.LeftCol

            If DetailsList(row, 7) = 1 Or DetailsList(row, 7) = 4 Then
                DetailsList.Rows(row + 2).AllowEditing = False
            ElseIf DetailsList(Row, 7) = 2 Or DetailsList(Row, 7) = 5 Then
                DetailsList.Rows(row + 1).AllowEditing = False
            ElseIf DetailsList(Row, 7) = 3 Or DetailsList(Row, 7) = 6 Then
                If col = 4 Or col = 5 Then
                    DetailsList.Rows(row).AllowEditing = True
                Else
                    DetailsList.Rows(row).AllowEditing = False
                End If
            End If


        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub CategoryList_CellChanged(sender As Object, e As RowColEventArgs) Handles CategoryList.CellChanged
        Try
            If Not Command = "Load" Then
                Dim RowNo As Integer = 0
                Dim ColTotal As Int64 = 0
                Dim LaborColTotal As Int64 = 0
                Dim MaterialColTotal As Int64 = 0
                Dim MachineColTotal As Int64 = 0
                Dim SubcntrctColTotal As Int64 = 0
                Dim ExpenseColTotal As Int64 = 0


                For RowCount As Integer = 1 To ((DetailsList.Rows.Count - 3) / 3)

                    ColTotal += DetailsList((RowCount * 3) + 2, 6)
                    LaborColTotal += CategoryList((RowCount * 3) + 2, 2)
                    MaterialColTotal += CategoryList((RowCount * 3) + 2, 3)
                    MachineColTotal += CategoryList((RowCount * 3) + 2, 4)
                    SubcntrctColTotal += CategoryList((RowCount * 3) + 2, 5)
                    ExpenseColTotal += CategoryList((RowCount * 3) + 2, 6)

                Next

                DetailTotal.Value = ColTotal
                CategoryTotalList(0, 2) = LaborColTotal
                CategoryTotalList(0, 3) = MaterialColTotal
                CategoryTotalList(0, 4) = MachineColTotal
                CategoryTotalList(0, 5) = SubcntrctColTotal
                CategoryTotalList(0, 6) = ExpenseColTotal
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try

    End Sub

    Private Sub DetailsList_CellChanged(sender As Object, e As RowColEventArgs) Handles DetailsList.CellChanged
        Try

            If Not Command = "Load" Then
                If DetailsList.Rows.Count = CategoryList.Rows.Count Then
                    Dim RowNo As Integer = 0
                    Dim ColTotal As Int64 = 0
                    Dim LaborColTotal As Int64 = 0
                    Dim MaterialColTotal As Int64 = 0
                    Dim MachineColTotal As Int64 = 0
                    Dim SubcntrctColTotal As Int64 = 0
                    Dim ExpenseColTotal As Int64 = 0


                    For RowCount As Integer = 1 To ((DetailsList.Rows.Count - 3) / 3)
                        Dim Quanity As Decimal = 0
                        If IsDBNull(DetailsList(RowCount * 3, 6)) = False Then
                            Quanity = DetailsList(RowCount * 3, 6)
                            DetailsList((RowCount * 3) + 2, 6) = Math.Floor(DetailsList((RowCount * 3) + 1, 6) * Quanity)
                            CategoryList((RowCount * 3) + 2, 2) = Math.Floor(CategoryList((RowCount * 3) + 1, 2) * Quanity)
                            CategoryList((RowCount * 3) + 2, 3) = Math.Floor(CategoryList((RowCount * 3) + 1, 3) * Quanity)
                            CategoryList((RowCount * 3) + 2, 4) = Math.Floor(CategoryList((RowCount * 3) + 1, 4) * Quanity)
                            CategoryList((RowCount * 3) + 2, 5) = Math.Floor(CategoryList((RowCount * 3) + 1, 5) * Quanity)
                            CategoryList((RowCount * 3) + 2, 6) = Math.Floor(CategoryList((RowCount * 3) + 1, 6) * Quanity)
                        End If

                        ColTotal += DetailsList((RowCount * 3) + 2, 6)
                        LaborColTotal += CategoryList((RowCount * 3) + 2, 2)
                        MaterialColTotal += CategoryList((RowCount * 3) + 2, 3)
                        MachineColTotal += CategoryList((RowCount * 3) + 2, 4)
                        SubcntrctColTotal += CategoryList((RowCount * 3) + 2, 5)
                        ExpenseColTotal += CategoryList((RowCount * 3) + 2, 6)

                    Next

                    DetailTotal.Value = ColTotal
                    CategoryTotalList(0, 2) = LaborColTotal
                    CategoryTotalList(0, 3) = MaterialColTotal
                    CategoryTotalList(0, 4) = MachineColTotal
                    CategoryTotalList(0, 5) = SubcntrctColTotal
                    CategoryTotalList(0, 6) = ExpenseColTotal
                End If

            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub OutsoucerTotalList_AfterScroll(sender As Object, e As RangeEventArgs) Handles OutsoucerTotalList.AfterScroll

        If Not outsrcr_x = OutsoucerTotalList.ScrollPosition.X Then
            outsrcr_x = OutsoucerTotalList.ScrollPosition.X
        End If
        If Not outsrcr_y = OutsoucerList.ScrollPosition.Y Then
            outsrcr_y = OutsoucerList.ScrollPosition.Y
        End If
        OutsoucerList.ScrollPosition = New Point(outsrcr_x, outsrcr_y)
    End Sub
    Private Sub OutsoucerList_BeforeEdit(sender As Object, e As RowColEventArgs) Handles OutsoucerList.BeforeEdit
        If DetailsList(e.Row, 7) = 1 Or DetailsList(e.Row, 7) = 4 Then
            OutsoucerList.Rows(e.Row + 2).AllowEditing = False
        ElseIf DetailsList(e.Row, 7) = 2 Or DetailsList(e.Row, 7) = 5 Then
            OutsoucerList.Rows(e.Row + 1).AllowEditing = False
        Else
            OutsoucerList.Rows(e.Row).AllowEditing = False
        End If
    End Sub

    Private Sub OutsoucerList_AfterEdit(sender As Object, e As RowColEventArgs) Handles OutsoucerList.AfterEdit
        Try
            Dim Row As Integer = e.Row
            Dim Col As Integer = e.Col


            If IsNumeric(OutsoucerList(Row, Col)) = True Then
                Dim ColTotal As Int64
                If DetailsList(Row, 7) = 1 Or DetailsList(Row, 7) = 4 Then
                    OutsoucerList(Row + 2, Col) = Math.Floor((OutsoucerList(Row, Col) * OutsoucerList(Row + 1, Col)))

                ElseIf DetailsList(Row, 7) = 2 Or DetailsList(Row, 7) = 5 Then
                    OutsoucerList(Row + 1, Col) = Math.Floor((OutsoucerList(Row - 1, Col) * OutsoucerList(Row, Col)))
                    If Col = OutsrcrCount - 1 Then
                        OutsoucerList.Select(Row + 1, 2)
                    ElseIf Col < OutsrcrCount - 1 Then
                        OutsoucerList.Select(Row - 2, Col + 1)
                    End If
                End If

                For RowCount As Integer = 1 To ((OutsoucerList.Rows.Count - 3) / 3)

                    ColTotal += OutsoucerList((RowCount * 3) + 2, Col)
                Next

                OutsoucerTotalList(0, Col) = ColTotal

            End If

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub DetailsList_Click(sender As Object, e As EventArgs) Handles DetailsList.Click
        Try


            Dim SelectionRow As Integer = DetailsList.Selection.TopRow
            Dim SelectionCol As Integer = DetailsList.Selection.LeftCol

            For DetailsRowCount As Integer = 0 To DetailsList.Rows.Count - 1
                If DetailsRowCount < DetailsList.Rows.Count - 3 Then
                    DetailsList.Rows(DetailsRowCount + 2).Caption = ""
                Else
                    Exit For
                End If
            Next

            Dim RowNo As Integer = DetailsList(SelectionRow, 7)
            If RowNo = 1 Or RowNo = 4 Then
                DetailsList.Rows(SelectionRow).Caption = "▶"
            ElseIf RowNo = 2 Or RowNo = 5 Then
                DetailsList.Rows(SelectionRow - 1).Caption = "▶"
            Else
                DetailsList.Rows(SelectionRow - 2).Caption = "▶"
            End If

            If DetailsList(SelectionRow, 7) = 1 Or DetailsList(SelectionRow, 7) = 4 Then

                If SelectionCol = 4 Or SelectionCol = 5 Then
                    DetailsList.Rows(SelectionRow + 2).AllowEditing = True
                Else
                    DetailsList.Rows(SelectionRow + 2).AllowEditing = False
                End If
            ElseIf DetailsList(SelectionRow, 7) = 2 Or DetailsList(SelectionRow, 7) = 5 Then
                If SelectionCol = 4 Or SelectionCol = 5 Then
                    DetailsList.Rows(SelectionRow + 1).AllowEditing = True
                Else
                    DetailsList.Rows(SelectionRow + 1).AllowEditing = False
                End If
            ElseIf DetailsList(SelectionRow, 7) = 3 Or DetailsList(SelectionRow, 7) = 6 Then
                If SelectionCol = 4 Or SelectionCol = 5 Then
                    DetailsList.Rows(SelectionRow).AllowEditing = True
                Else
                    DetailsList.Rows(SelectionRow).AllowEditing = False
                End If
            End If

            If SelectionCol = 6 Then
                DetailsList.ImeMode = ImeMode.Disable
            Else
                DetailsList.ImeMode = ImeMode.On
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Try

            Dim SelectionRow As Integer = DetailsList.Selection.TopRow
            Dim SelectionCol As Integer = DetailsList.Selection.LeftCol

            DetailsList(SelectionRow, SelectionCol) = ""

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub DetailsList_StartEdit(sender As Object, e As RowColEventArgs) Handles DetailsList.StartEdit
        Try
            Key = ""


            Dim SelectionCol As Integer = DetailsList.Selection.LeftCol

            If SelectionCol = 6 Then
                DetailsList.ImeMode = ImeMode.Disable
            Else
                DetailsList.ImeMode = ImeMode.On
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub DetailsList_KeyDown(sender As Object, e As KeyEventArgs) Handles DetailsList.KeyDown

        Try

            Dim SelectionCol As Integer = DetailsList.Selection.LeftCol
            Dim SelectionRow As Integer = DetailsList.Selection.TopRow

            Dim RowIndex As Integer = DetailsList(SelectionRow, 7)
            If e.KeyCode = Keys.Enter Then

                SendKeys.Send("{ENTER}")
                If RowIndex = 3 Or RowIndex = 6 Then
                    If SelectionCol = 4 Then
                        Key = "enter"

                        DetailsList.Select(SelectionRow - 1, 5)

                    ElseIf SelectionCol = 5 Then
                        Key = "enter"

                        DetailsList.Select(SelectionRow - 3, 6)
                    End If
                End If
            ElseIf e.KeyCode = Keys.Escape Then
                If Command = "Cut" Or Command = "Copy" Then

                    Dim Row As Integer = DetailsList(CopyRow, 3)
                    If Row Mod 2 = 0 Then
                        DetailsList.Rows(CopyRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        DetailsList.Rows(CopyRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        DetailsList.Rows(CopyRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)

                        CategoryList.Rows(CopyRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        CategoryList.Rows(CopyRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        CategoryList.Rows(CopyRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)

                        OutsoucerList.Rows(CopyRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        OutsoucerList.Rows(CopyRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        OutsoucerList.Rows(CopyRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                    Else
                        DetailsList.Rows(CopyRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        DetailsList.Rows(CopyRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        DetailsList.Rows(CopyRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)

                        CategoryList.Rows(CopyRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        CategoryList.Rows(CopyRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        CategoryList.Rows(CopyRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)

                        OutsoucerList.Rows(CopyRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        OutsoucerList.Rows(CopyRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        OutsoucerList.Rows(CopyRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                    End If

                End If
            ElseIf e.KeyCode = Keys.Right Then

                If SelectionCol = 6 Then
                    If Category.Checked = True Then
                        CategoryList.Focus()
                        CategoryList.Select(SelectionRow, 2)
                    Else
                        OutsoucerList.Focus()
                        OutsoucerList.Select(SelectionRow, 2)
                    End If

                End If
            End If

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try

    End Sub


    Private Sub CategoryList_KeyDown(sender As Object, e As KeyEventArgs) Handles CategoryList.KeyDown
        Try

            Dim SelectionCol As Integer = CategoryList.Selection.LeftCol
            Dim SelectionRow As Integer = CategoryList.Selection.TopRow

            Dim RowIndex As Integer = DetailsList(SelectionRow, 7)

            If DetailsList.Rows.Count - 1 > SelectionRow + (3 - RowIndex) AndAlso Not Key = "enter" Then

                If RowIndex = 2 Or RowIndex = 5 Then
                    If e.KeyCode = Keys.Enter Then
                        SendKeys.Send("{ENTER}")

                        If SelectionCol = 6 Then

                            Key = "enter"

                            DetailsList.Focus()
                            DetailsList.Select(SelectionRow + 2, 4)
                            DetailsList.Rows(SelectionRow - 1).Caption = ""
                            DetailsList.Rows(SelectionRow + 2).Caption = "▶"
                            If SelectionRow + 3 = DetailsList.Rows.Count Then
                                DetailsList.Rows.Add(3)
                                CategoryList.Rows.Add(3)
                                OutsoucerList.Rows.Add(3)
                                Dim NewRow As Integer = SelectionRow + 3

                                Dim Quanity As CellRange = DetailsList.GetCellRange(NewRow, 6)
                                Quanity.StyleNew.Format = "N1"
                                Dim Costea As CellRange = DetailsList.GetCellRange(NewRow + 1, 6)
                                Costea.StyleNew.Format = "N0"
                                Dim Amount As CellRange = DetailsList.GetCellRange(NewRow + 2, 6)
                                Amount.StyleNew.Format = "N0"
                                DetailsList.Rows(NewRow).StyleFixedNew.BackColor = Color.FromArgb(213, 234, 216)


                                If NewRow Mod 2 = 0 Then
                                    DetailsList.Rows(NewRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                                    DetailsList.Rows(NewRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                                    DetailsList.Rows(NewRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)

                                    CategoryList.Rows(NewRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                                    CategoryList.Rows(NewRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                                    CategoryList.Rows(NewRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)

                                    OutsoucerList.Rows(NewRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                                    OutsoucerList.Rows(NewRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                                    OutsoucerList.Rows(NewRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)

                                    DetailsList(NewRow, 7) = 4
                                    DetailsList(NewRow + 1, 7) = 5
                                    DetailsList(NewRow + 2, 7) = 6

                                Else
                                    DetailsList.Rows(NewRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                                    DetailsList.Rows(NewRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                                    DetailsList.Rows(NewRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)

                                    CategoryList.Rows(NewRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                                    CategoryList.Rows(NewRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                                    CategoryList.Rows(NewRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)

                                    OutsoucerList.Rows(NewRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                                    OutsoucerList.Rows(NewRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                                    OutsoucerList.Rows(NewRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)


                                    DetailsList(NewRow, 7) = 1
                                    DetailsList(NewRow + 1, 7) = 2
                                    DetailsList(NewRow + 2, 7) = 3

                                End If

                                DetailsList.MergedRanges.Add(NewRow, 0, NewRow + 2, 0)
                                DetailsList.MergedRanges.Add(NewRow, 2, NewRow + 2, 2)
                                DetailsList.MergedRanges.Add(NewRow, 3, NewRow + 2, 3)
                                DetailsList.MergedRanges.Add(NewRow, 4, NewRow, 5)
                                DetailsList.MergedRanges.Add(NewRow + 1, 4, NewRow + 1, 5)

                            End If
                        End If
                    ElseIf e.KeyCode = Keys.Left Then
                        If SelectionCol = 2 Then
                            DetailsList.Focus()
                            DetailsList.Select(SelectionRow, 6)
                        End If
                    End If
                End If
            End If

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub CategoryList_Click(sender As Object, e As EventArgs) Handles CategoryList.Click
        Try
            Dim SelectionRow As Integer = CategoryList.Selection.TopRow
            Dim SelectionCol As Integer = CategoryList.Selection.LeftCol

            For DetailsRowCount As Integer = 0 To DetailsList.Rows.Count - 1
                If DetailsRowCount < DetailsList.Rows.Count - 3 Then
                    DetailsList.Rows(DetailsRowCount + 2).Caption = ""
                Else
                    Exit For
                End If
            Next

            Dim RowNo As Integer = DetailsList(SelectionRow, 7)
            If RowNo = 1 Or RowNo = 4 Then
                DetailsList.Rows(SelectionRow).Caption = "▶"
            ElseIf RowNo = 2 Or RowNo = 5 Then
                DetailsList.Rows(SelectionRow - 1).Caption = "▶"
            Else
                DetailsList.Rows(SelectionRow - 2).Caption = "▶"
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub OutsoucerList_Click(sender As Object, e As EventArgs) Handles OutsoucerList.Click
        Try
            Dim SelectionRow As Integer = OutsoucerList.Selection.TopRow
            Dim SelectionCol As Integer = OutsoucerList.Selection.LeftCol

            For DetailsRowCount As Integer = 0 To DetailsList.Rows.Count - 1
                If DetailsRowCount < DetailsList.Rows.Count - 3 Then
                    DetailsList.Rows(DetailsRowCount + 2).Caption = ""
                Else
                    Exit For
                End If
            Next

            Dim RowNo As Integer = DetailsList(SelectionRow, 7)
            If RowNo = 1 Or RowNo = 4 Then
                DetailsList.Rows(SelectionRow).Caption = "▶"
            ElseIf RowNo = 2 Or RowNo = 5 Then
                DetailsList.Rows(SelectionRow - 1).Caption = "▶"
            Else
                DetailsList.Rows(SelectionRow - 2).Caption = "▶"
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub OutsoucerList_KeyDown(sender As Object, e As KeyEventArgs) Handles OutsoucerList.KeyDown
        Try

            Dim SelectionCol As Integer = OutsoucerList.Selection.LeftCol
            Dim SelectionRow As Integer = OutsoucerList.Selection.TopRow

            Dim RowIndex As Integer = DetailsList(SelectionRow, 7)


            If e.KeyCode = Keys.Enter Then

                If DetailsList.Rows.Count - 1 > SelectionRow + (3 - RowIndex) Then

                    If RowIndex = 2 AndAlso SelectionCol = OutsrcrCount - 1 Or RowIndex = 5 AndAlso SelectionCol = OutsrcrCount - 1 Then
                        Key = "enter"

                        OutsoucerList.Select(SelectionRow + 2, 2)
                        SendKeys.Send("{ENTER}")
                        SendKeys.Send("{UP}")

                        DetailsList.Rows(SelectionRow - 1).Caption = ""
                        DetailsList.Rows(SelectionRow + 2).Caption = "▶"
                        If SelectionRow + 3 = DetailsList.Rows.Count Then
                            DetailsList.Rows.Add(3)
                            CategoryList.Rows.Add(3)
                            OutsoucerList.Rows.Add(3)
                            Dim NewRow As Integer = SelectionRow + 3

                            Dim Quanity As CellRange = DetailsList.GetCellRange(NewRow, 6)
                            Quanity.StyleNew.Format = "N1"
                            Dim Costea As CellRange = DetailsList.GetCellRange(NewRow + 1, 6)
                            Costea.StyleNew.Format = "N0"
                            Dim Amount As CellRange = DetailsList.GetCellRange(NewRow + 2, 6)
                            Amount.StyleNew.Format = "N0"
                            DetailsList.Rows(NewRow).StyleFixedNew.BackColor = Color.FromArgb(213, 234, 216)


                            If NewRow Mod 2 = 0 Then
                                DetailsList.Rows(NewRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                                DetailsList.Rows(NewRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                                DetailsList.Rows(NewRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)

                                CategoryList.Rows(NewRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                                CategoryList.Rows(NewRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                                CategoryList.Rows(NewRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)

                                OutsoucerList.Rows(NewRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                                OutsoucerList.Rows(NewRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                                OutsoucerList.Rows(NewRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)

                                DetailsList(NewRow, 7) = 4
                                DetailsList(NewRow + 1, 7) = 5
                                DetailsList(NewRow + 2, 7) = 6

                            Else
                                DetailsList.Rows(NewRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                                DetailsList.Rows(NewRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                                DetailsList.Rows(NewRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)

                                CategoryList.Rows(NewRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                                CategoryList.Rows(NewRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                                CategoryList.Rows(NewRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)

                                OutsoucerList.Rows(NewRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                                OutsoucerList.Rows(NewRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                                OutsoucerList.Rows(NewRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)


                                DetailsList(NewRow, 7) = 1
                                DetailsList(NewRow + 1, 7) = 2
                                DetailsList(NewRow + 2, 7) = 3

                            End If

                            DetailsList.MergedRanges.Add(NewRow, 0, NewRow + 2, 0)
                            DetailsList.MergedRanges.Add(NewRow, 2, NewRow + 2, 2)
                            DetailsList.MergedRanges.Add(NewRow, 3, NewRow + 2, 3)
                            DetailsList.MergedRanges.Add(NewRow, 4, NewRow, 5)
                            DetailsList.MergedRanges.Add(NewRow + 1, 4, NewRow + 1, 5)
                        End If


                    ElseIf RowIndex = 2 AndAlso SelectionCol < OutsrcrCount - 1 Or RowIndex = 5 AndAlso SelectionCol < OutsrcrCount - 1 Then
                        Key = "enter"

                        OutsoucerList.Select(SelectionRow - 1, SelectionCol + 1)
                        SendKeys.Send("{ENTER}")
                        SendKeys.Send("{UP}")


                    Else


                        SendKeys.Send("{ENTER}")

                    End If
                ElseIf e.KeyCode = Keys.Left Then
                    If SelectionCol = 2 Then
                        DetailsList.Focus()
                        DetailsList.Select(SelectionRow, 6)
                    End If

                End If
            End If

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub
End Class