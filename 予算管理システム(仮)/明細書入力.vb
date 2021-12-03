Imports C1.Win.C1FlexGrid
Imports System.Windows.Forms.Form
Imports C1.Win.C1Command
Imports System.Data.SqlClient
Public Class 明細書入力
    Public SelectRow As Integer = 0
    Private Sub 明細書入力_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            SWorkType.Value = ホーム.sworktypecode & " " & ホーム.sworktypename
            'DetailsList.Rows(1).AllowMerging = True
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
                        OutsoucerList.Rows((RowCount * 3) + 2).AllowEditing = False
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
            End If

            DetailsList.MergedRanges.Add(DetailsList.Rows.Count - 3, 0, DetailsList.Rows.Count - 1, 0)
            DetailsList.MergedRanges.Add(DetailsList.Rows.Count - 3, 2, DetailsList.Rows.Count - 1, 2)
            DetailsList.MergedRanges.Add(DetailsList.Rows.Count - 3, 3, DetailsList.Rows.Count - 1, 3)
            DetailsList.MergedRanges.Add(DetailsList.Rows.Count - 3, 4, DetailsList.Rows.Count - 3, 5)
            DetailsList.MergedRanges.Add(DetailsList.Rows.Count - 2, 4, DetailsList.Rows.Count - 2, 5)


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
        Dim Col As Integer = 0

        ホーム.Sql.CommandText = "SELECT cstclss_name FROM cost_classes WHERE cstclss_code=" & DetailsList(Row, 8)
        Dim CostClassName As String = ホーム.Sql.ExecuteScalar
        If CostClassName = "労務費" Then
            Col = 2
        ElseIf CostClassName = "材料費" Or CostClassName = "社内機材費" Or CostClassName = "社外機材費" Then
            Col = 3
        ElseIf CostClassName = "機械費" Then
            Col = 4
        ElseIf CostClassName = "外注費" Then
            Col = 5
        ElseIf CostClassName = "諸経費" Then
            Col = 6
        End If

        If IsNumeric(CategoryList(Row, Col)) = True Then
            CategoryList(Row + 1, Col) = Math.Round((DetailsList(Row - 1, 6) * CategoryList(Row, Col)), 0, MidpointRounding.AwayFromZero)
        End If

    End Sub
End Class