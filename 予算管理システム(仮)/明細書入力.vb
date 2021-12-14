﻿Imports C1.Win.C1FlexGrid
Imports System.Windows.Forms.Form
Imports C1.Win.C1Command
Imports System.Data.SqlClient
Public Class 明細書入力
    Public SelectRow As Integer = 0
    Public CopyList(10) As String
    Private Sub 明細書入力_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Me.TopMost = False

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

            CategoryTotalList.Rows(0).Height = 20
            OutsoucerTotalList.Rows(0).Height = 20

            Category.Checked = True

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

            Dim OutsrcngSql As New SqlCommand
            OutsrcngSql.Connection = ホーム.Connection

            If DetailsCount > 0 Then

                ホーム.Sql.CommandText = "SELECT * FROM details WHERE budget_no=" & ホーム.BudgetNo & " AND s_worktype_code=" & ホーム.sworktypecode
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
                    DetailsList((RowCount * 3) + 2, 6) = Math.Round((DetailsReader.Item("dtl_quanity") * DetailsReader.Item("dtl_costea")), 0, MidpointRounding.AwayFromZero)
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
                    CategoryList((RowCount * 3) + 2, 2) = Math.Round(DetailsReader.Item("dtl_quanity") * DetailsReader.Item("dtl_labor"), 0, MidpointRounding.AwayFromZero)
                    CategoryList((RowCount * 3) + 2, 3) = Math.Round(DetailsReader.Item("dtl_quanity") * DetailsReader.Item("dtl_material"), 0, MidpointRounding.AwayFromZero)
                    CategoryList((RowCount * 3) + 2, 4) = Math.Round(DetailsReader.Item("dtl_quanity") * DetailsReader.Item("dtl_machine"), 0, MidpointRounding.AwayFromZero)
                    CategoryList((RowCount * 3) + 2, 5) = Math.Round(DetailsReader.Item("dtl_quanity") * DetailsReader.Item("dtl_subcntrct"), 0, MidpointRounding.AwayFromZero)
                    CategoryList((RowCount * 3) + 2, 6) = Math.Round(DetailsReader.Item("dtl_quanity") * DetailsReader.Item("dtl_expens"), 0, MidpointRounding.AwayFromZero)

                End While
                DetailsReader.Close()

                RowCount += 1
                RowNo = 1
                DetailsList((RowCount * 3), 7) = (RowNo * RowNo)
                DetailsList((RowCount * 3) + 1, 7) = (RowNo * RowNo) + 1
                DetailsList((RowCount * 3) + 2, 7) = (RowNo * RowNo) + 2
                Dim LastQuanity As CellRange = DetailsList.GetCellRange(RowCount * 3, 6)
                LastQuanity.StyleNew.Format = "N1"
                Dim LastCostea As CellRange = DetailsList.GetCellRange(RowCount * 3 + 1, 6)
                LastCostea.StyleNew.Format = "N0"
                Dim LastAmount As CellRange = DetailsList.GetCellRange(RowCount * 3 + 2, 6)
                LastAmount.StyleNew.Format = "N0"


                DetailsList.MergedRanges.Add(DetailsList.Rows.Count - 3, 0, DetailsList.Rows.Count - 1, 0)
                DetailsList.MergedRanges.Add(DetailsList.Rows.Count - 3, 2, DetailsList.Rows.Count - 1, 2)
                DetailsList.MergedRanges.Add(DetailsList.Rows.Count - 3, 3, DetailsList.Rows.Count - 1, 3)
                DetailsList.MergedRanges.Add(DetailsList.Rows.Count - 3, 4, DetailsList.Rows.Count - 3, 5)
                DetailsList.MergedRanges.Add(DetailsList.Rows.Count - 2, 4, DetailsList.Rows.Count - 2, 5)

                ホーム.Sql.CommandText = "SELECT * FROM S_worktype_total WHERE budget_no=" & ホーム.BudgetNo & " AND s_worktype_code=" & ホーム.sworktypecode
                Dim TotalReader As SqlDataReader = ホーム.Sql.ExecuteReader
                While TotalReader.Read
                    DetailTotal.Text = TotalReader.Item("amount_total")
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




            ホーム.Sql.CommandText = "SELECT Count(*) FROM outsourcers"
            Dim OutsourcersCount As Integer = ホーム.Sql.ExecuteScalar

            OutsoucerList.MergedRanges.Add(1, 6, 2, 6)
            OutsoucerList.MergedRanges.Add(1, 2, 2, 2)
            OutsoucerList.MergedRanges.Add(1, 3, 2, 3)
            OutsoucerList.MergedRanges.Add(1, 4, 2, 4)
            OutsoucerList.MergedRanges.Add(1, 5, 2, 5)

            If OutsourcersCount > 0 Then
                Dim ColsCount As Integer = OutsoucerList.Cols.Count

                If OutsourcersCount > ColsCount Then
                    OutsoucerList.Cols.Count = OutsourcersCount + 1
                End If

                Dim DataCount As Integer = 1

                ホーム.Sql.CommandText = "SELECT * FROM outsourcers"
                Dim OutsourcersReader As SqlDataReader = ホーム.Sql.ExecuteReader
                While OutsourcersReader.Read
                    DataCount += 1

                    OutsoucerList.MergedRanges.Add(1, DataCount, 2, DataCount)
                    OutsoucerList(0, DataCount) = OutsourcersReader.Item("outsrcr_code")
                    OutsoucerList(1, DataCount) = OutsourcersReader.Item("outsrcr_name")
                    OutsoucerList.Cols(DataCount).StyleFixedNew.WordWrap = True

                End While
                OutsourcersReader.Close()
            End If

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
        If Outsoucing.Checked = True Then
            CategoryList.Visible = False
            CategoryTotalList.Visible = False
            OutsoucerList.Visible = True
            OutsoucerTotalList.Visible = True
        End If
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

    'Private Sub DetailsList_DoubleClick(sender As Object, e As EventArgs) Handles DetailsList.DoubleClick
    '    Me.Close()
    '    代価表入力.TopLevel = False
    '    ホーム.FormPanel.Controls.Add(代価表入力)
    '    代価表入力.Show()
    'End Sub

    Private Sub DetailsList_AfterScroll(sender As Object, e As RangeEventArgs) Handles DetailsList.AfterScroll
        CategoryList.ScrollPosition = DetailsList.ScrollPosition
        OutsoucerList.ScrollPosition = DetailsList.ScrollPosition
    End Sub

    Private Sub CategoryList_AfterScroll(sender As Object, e As RangeEventArgs) Handles CategoryList.AfterScroll
        DetailsList.ScrollPosition = CategoryList.ScrollPosition

    End Sub

    Private Sub OutsoucerList_AfterScroll(sender As Object, e As RangeEventArgs) Handles OutsoucerList.AfterScroll
        DetailsList.ScrollPosition = OutsoucerList.ScrollPosition
    End Sub

    Private Sub DetailsList_AfterRowColChange(sender As Object, e As RangeEventArgs) Handles DetailsList.AfterRowColChange

        Try
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

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub CategoryList_AfterRowColChange(sender As Object, e As RangeEventArgs) Handles CategoryList.AfterRowColChange
        Try
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

    Private Sub ItemSelect_Click(sender As Object, e As EventArgs) Handles ItemSelectMenu.Click

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

        Dim Row As Integer = e.Row
        Dim Col As Integer = e.Col


        If IsNumeric(CategoryList(Row, Col)) = True Then
            CategoryList(Row + 1, Col) = Math.Round((DetailsList(Row - 1, 6) * CategoryList(Row, Col)), 0, MidpointRounding.AwayFromZero)

            Dim RowNo As Integer = 0
            Dim EditRow As Integer = e.Row + 1
            Dim ColTotal As Int64 = 0
            For RowCount = EditRow To ((DetailsList.Rows.Count - 3) / 3)

                RowNo += 1
                ColTotal += CategoryList(EditRow * 3, Col)
            Next

            CategoryTotalList(1, Col) = ColTotal
        End If

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

            Dim CancelClickLoad As New CancelClick(Me)
            CancelClick = CancelClickLoad.ModifyCheck

            小工種選択.TopLevel = False
            ホーム.FormPanel.Controls.Add(小工種選択)
            小工種選択.Show()

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

                DetailsList.Rows(SelectRow).StyleFixedNew.BackColor = Color.FromArgb(105, 189, 131)
                CopyList(0) = DetailsList(SelectRow, 1)
                CopyList(1) = DetailsList(SelectRow, 3)
                CopyList(2) = DetailsList(SelectRow, 4)
                CopyList(3) = DetailsList(SelectRow + 1, 4)
                CopyList(4) = DetailsList(SelectRow + 2, 4)
                CopyList(5) = DetailsList(SelectRow + 2, 5)
                CopyList(6) = DetailsList(SelectRow, 6)
                CopyList(7) = DetailsList(SelectRow + 1, 6)
                CopyList(8) = DetailsList(SelectRow + 2, 6)
                CopyList(9) = DetailsList(SelectRow, 8)
                CopyList(10) = DetailsList(SelectRow, 9)
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

                DetailsList.Rows.Insert(SelectRow)
                DetailsList.Rows.Insert(SelectRow + 1)
                DetailsList.Rows.Insert(SelectRow + 2)
                CategoryList.Rows.Insert(SelectRow)
                CategoryList.Rows.Insert(SelectRow + 1)
                CategoryList.Rows.Insert(SelectRow + 2)
                OutsoucerList.Rows.Insert(SelectRow)
                OutsoucerList.Rows.Insert(SelectRow + 1)
                OutsoucerList.Rows.Insert(SelectRow + 2)
                DetailsList(SelectRow, 1) = CopyList(0)
                DetailsList(SelectRow, 3) = CopyList(1)
                DetailsList(SelectRow, 4) = CopyList(2)
                DetailsList(SelectRow + 1, 4) = CopyList(3)
                DetailsList(SelectRow + 2, 4) = CopyList(4)
                DetailsList(SelectRow + 2, 5) = CopyList(5)
                DetailsList(SelectRow, 6) = CopyList(6)
                DetailsList(SelectRow + 1, 6) = CopyList(7)
                DetailsList(SelectRow + 2, 6) = CopyList(8)
                DetailsList(SelectRow, 8) = CopyList(9)
                DetailsList(SelectRow, 9) = CopyList(10)


                Dim RowNo As Integer = 0
                For RowCount As Integer = 1 To ((DetailsList.Rows.Count - 3) / 3)

                    RowNo += 1

                    If RowCount < ((DetailsList.Rows.Count - 3) / 3) Then
                        DetailsList(RowCount * 3, 3) = RowCount
                    End If

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
            End If

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
                CopyList(0) = DetailsList(SelectRow, 1)
                CopyList(1) = DetailsList(SelectRow, 3)
                CopyList(2) = DetailsList(SelectRow, 4)
                CopyList(3) = DetailsList(SelectRow + 1, 4)
                CopyList(4) = DetailsList(SelectRow + 2, 4)
                CopyList(5) = DetailsList(SelectRow + 2, 5)
                CopyList(6) = DetailsList(SelectRow, 6)
                CopyList(7) = DetailsList(SelectRow + 1, 6)
                CopyList(8) = DetailsList(SelectRow + 2, 6)
                CopyList(9) = DetailsList(SelectRow, 8)
                CopyList(10) = DetailsList(SelectRow, 9)
                DetailsList.Rows.RemoveRange(SelectRow, 3)
                CategoryList.Rows.RemoveRange(SelectRow, 3)
                OutsoucerList.Rows.RemoveRange(SelectRow, 3)

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
            End If

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub CostCreate_Click(sender As Object, e As EventArgs) Handles CostCreateMenu.Click
        作成代価選択.ShowDialog()
        作成代価選択.TopMost = True
        作成代価選択.TopMost = False
    End Sub

    Private Sub CostCreation_Click(sender As Object, e As EventArgs) Handles CostCreation.Click
        作成代価選択.ShowDialog()
        作成代価選択.TopMost = True
        作成代価選択.TopMost = False
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

    Private Sub ItemSelect_Click_1(sender As Object, e As EventArgs) Handles ItemSelect.Click
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

        For DetailsRowCount As Integer = 0 To DetailsList.Rows.Count - 1
            If DetailsRowCount < DetailsList.Rows.Count - 3 AndAlso DetailsList.Rows(DetailsRowCount + 2).Caption = "▶" Then
                SelectRow = DetailsRowCount + 2
                Exit For
            End If
        Next

        代価表入力.TopLevel = False
        ホーム.FormPanel.Controls.Add(代価表入力)
        代価表入力.SelectRow = SelectRow
        代価表入力.Show()
        Me.Visible = False

    End Sub

    Private Sub CostModifyMenu_Click(sender As Object, e As EventArgs) Handles CostModifyMenu.Click
        For DetailsRowCount As Integer = 0 To DetailsList.Rows.Count - 1
            If DetailsRowCount < DetailsList.Rows.Count - 3 AndAlso DetailsList.Rows(DetailsRowCount + 2).Caption = "▶" Then
                SelectRow = DetailsRowCount + 2
                Exit For
            End If
        Next

        代価表入力.TopLevel = False
        ホーム.FormPanel.Controls.Add(代価表入力)
        代価表入力.SelectRow = SelectRow
        代価表入力.CostNo.Value = DetailsList(SelectRow + 2, 4)
        代価表入力.CostName.Value = DetailsList(SelectRow, 4)
        代価表入力.CostSpec.Value = DetailsList(SelectRow + 1, 4)
        代価表入力.CostUnit.Value = DetailsList(SelectRow + 2, 5)
        代価表入力.BreakDownList.AllowEditing = False
        代価表入力.Show()
        Me.Visible = False

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

                If DetailsList(SelectRow, 8) >= 12 Then

                    作成代価選択.HeadLine.Text = "<<コピー代価選択"
                    作成代価選択.Text = "コピー代価選択"


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
                If DetailsList(SelectRow, 8) >= 12 Then

                    作成代価選択.HeadLine.Text = "<<コピー代価選択"
                    作成代価選択.Text = "コピー代価選択"


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
                    代価表入力.TopLevel = False
                    ホーム.FormPanel.Controls.Add(代価表入力)
                    代価表入力.SelectRow = SelectRow
                    代価表入力.CostNo.ReadOnly = False
                    代価表入力.CostName.Enabled = False
                    代価表入力.CostSpec.Enabled = False
                    代価表入力.CostQuanity.Enabled = False
                    代価表入力.CostUnit.Enabled = False
                    代価表入力.CostUnitPrice.Enabled = False
                    代価表入力.CostCostea.Enabled = False
                    代価表入力.BreakDownList.AllowEditing = False
                    代価表入力.Show()
                    Me.Visible = False
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
                代価表入力.TopLevel = False
                ホーム.FormPanel.Controls.Add(代価表入力)
                代価表入力.SelectRow = SelectRow
                代価表入力.Enabled = False
                代価表入力.Show()
                Me.Visible = False
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
                Dim Name As String = DetailsList(RowCount * 3, 4)
                If Not (RowCount * 3) = DetailsList.Rows.Count - 3 Then
                    If Name.Length = 0 Or IsNothing(Name) = True Or IsNothing(DetailsList((RowCount * 3), 3)) = True Then
                        ErrorCount += 1
                        DetailsList.Rows(RowCount * 3).StyleFixedNew.BackColor = Color.FromArgb(255, 192, 192)
                    End If
                Else
                    If IsNothing(Name) = False AndAlso IsNothing(DetailsList((RowCount * 3), 3)) = True Then
                        ErrorCount += 1
                        DetailsList.Rows(RowCount * 3).StyleFixedNew.BackColor = Color.FromArgb(255, 192, 192)
                    ElseIf IsNothing(Name) = True AndAlso IsNothing(DetailsList((RowCount * 3), 3)) = False Then
                        ErrorCount += 1
                        DetailsList.Rows(RowCount * 3).StyleFixedNew.BackColor = Color.FromArgb(255, 192, 192)
                    End If
                End If
            Next

            If ErrorCount >= 1 Then
                MsgBox("順または名称が入力されていない行があります。", MsgBoxStyle.Exclamation, "明細書入力")
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
                        ホーム.Sql.Parameters.Add(New SqlParameter("@cstclsscode", SqlDbType.SmallInt)).Value = DetailsList(RowCount * 3, 8)
                        ホーム.Sql.Parameters.Add(New SqlParameter("@cstmstrid", SqlDbType.SmallInt)).Value = DetailsList(RowCount * 3, 9)
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
                        End If
                    End If
                End If
            Next

            ホーム.Transaction.Commit()

            For RowCount As Integer = 1 To ((DetailsList.Rows.Count - 3) / 3)
                If RowCount * 3 <= (DetailsList.Rows.Count - 3) Then
                    If DetailsList(RowCount * 3, 2) = "True" Then
                        DetailsList.Rows.RemoveRange(RowCount * 3, 3)
                        CategoryList.Rows.RemoveRange(RowCount * 3, 3)
                        OutsoucerList.Rows.RemoveRange(RowCount * 3, 3)
                    End If
                    If RowCount * 3 = (DetailsList.Rows.Count - 3) Then
                        Dim Name As String = DetailsList(RowCount * 3, 4)
                        If Name.Length > 0 Or IsNothing(Name) = False Or IsNothing(DetailsList((RowCount * 3), 3)) = False Then
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

            MsgBox("登録完了", MsgBoxStyle.OkOnly, "明細書入力")

            ホーム.Sql.CommandText = ""
            ホーム.Sql.Parameters.Clear()

        Catch ex As Exception
            ホーム.Transaction.Rollback()
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try

    End Sub

    Private Sub DetailsList_AfterEdit(sender As Object, e As RowColEventArgs) Handles DetailsList.AfterEdit
        Try
            Dim Row As Integer = e.Row
            Dim Col As Integer = e.Col

            If Col = 6 Then
                If IsNumeric(DetailsList(Row, 6)) = True Then
                    If DetailsList(Row, 7) = 1 Or DetailsList(Row, 7) = 4 Then
                        DetailsList(Row + 2, 6) = Math.Round((DetailsList(Row, 6) * DetailsList(Row + 1, 6)), 0, MidpointRounding.AwayFromZero)
                    ElseIf DetailsList(Row, 7) = 2 Or DetailsList(Row, 7) = 5 Then
                        DetailsList(Row + 1, 6) = Math.Round((DetailsList(Row, 6) * DetailsList(Row - 1, 6)), 0, MidpointRounding.AwayFromZero)
                    End If

                    Dim RowNo As Integer = 0
                    Dim ColTotal As Int64 = 0

                    For RowCount As Integer = 1 To ((DetailsList.Rows.Count - 3) / 3)

                        ColTotal += DetailsList((RowCount * 3) + 2, 6)

                    Next

                    DetailTotal.Text = ColTotal

                End If

            ElseIf Col = 3 Then

                Dim ErrorCount As Integer = 0

                For RowCount As Integer = 1 To ((DetailsList.Rows.Count - 3) / 3)

                    If Not e.Row = RowCount * 3 AndAlso DetailsList(e.Row, e.Col) = DetailsList(RowCount * 3, 3) Then
                        If DetailsList(e.Row, 2) = "False" Or IsNothing(DetailsList(e.Row, 2)) = True Then
                            ErrorCount += 1
                            DetailsList.Rows(RowCount * 3).StyleFixedNew.BackColor = Color.FromArgb(255, 192, 192)
                        End If
                    Else
                        DetailsList.Rows(RowCount * 3).StyleFixedNew.BackColor = Color.FromArgb(213, 234, 216)
                    End If
                Next
                If ErrorCount >= 1 Then
                    MsgBox("順：" & DetailsList(e.Row, e.Col) & " は重複しています。", MsgBoxStyle.Exclamation, "明細書入力")
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


End Class