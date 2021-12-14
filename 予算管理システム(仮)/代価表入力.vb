Imports C1.Win.C1FlexGrid
Imports System.Windows.Forms.Form
Imports C1.Win.C1Command
Imports System.Data.SqlClient
Public Class 代価表入力
    Public SelectRow As Integer
    Public CopyList(10) As String


    Private Sub 代価表入力_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'DetailsList.Rows(1).AllowMerging = True
        BreakDownList(0, 2) = "削除"
        BreakDownList(1, 2) = "削除"
        BreakDownList(2, 2) = "削除"
        BreakDownList(0, 3) = "順"
        BreakDownList(1, 3) = "順"
        BreakDownList(2, 3) = "順"
        BreakDownList(0, 4) = "名称"
        BreakDownList(0, 5) = "名称"
        BreakDownList(1, 4) = "規格"
        BreakDownList(1, 5) = "規格"
        BreakDownList(2, 4) = "摘要"
        BreakDownList(2, 5) = "単位"
        BreakDownList(1, 6) = "単価"
        BreakDownList(2, 6) = "金額"

        BreakDownList.MergedRanges.Add(0, 2, 2, 2)
        BreakDownList.MergedRanges.Add(0, 3, 2, 3)
        BreakDownList.MergedRanges.Add(0, 4, 0, 5)
        BreakDownList.MergedRanges.Add(1, 4, 1, 5)
        BreakDownList.MergedRanges.Add(0, 7, 2, 7)
        BreakDownList.MergedRanges.Add(0, 8, 2, 8)
        BreakDownList.MergedRanges.Add(0, 9, 2, 9)
        BreakDownList.MergedRanges.Add(0, 10, 2, 10)
        BreakDownList.MergedRanges.Add(0, 11, 2, 11)

        BreakDownList.Rows(0).Height = 17
        BreakDownList.Rows(1).Height = 17
        BreakDownList.Rows(2).Height = 17


        Me.Anchor = AnchorStyles.Top
        Me.Anchor = AnchorStyles.Left
        Me.Anchor = AnchorStyles.Bottom

        Dim a As Integer = 明細書入力.DetailsList(SelectRow, 9)

        ホーム.Sql.Parameters.Clear()
        ホーム.Sql.CommandText = "SELECT * FROM project_costs WHERE prjctcst_id=" & 明細書入力.DetailsList(SelectRow, 9)
        Dim ProjectCostsReader As SqlDataReader = ホーム.Sql.ExecuteReader
        While ProjectCostsReader.Read
            CostQuanity.Text = ProjectCostsReader.Item("prjctcst_quanity")
            CostCostea.Text = ProjectCostsReader.Item("prjctcst_costea")
            LaborCostea.Text = ProjectCostsReader.Item("prjctcst_laborea")
            MaterialCostea.Text = ProjectCostsReader.Item("prjctcst_materialea")
            MachineCostea.Text = ProjectCostsReader.Item("prjctcst_machineea")
            SubcntrctCostea.Text = ProjectCostsReader.Item("prjctcst_subcntrctea")
            ExpensCostea.Text = ProjectCostsReader.Item("prjctcst_expenseea")
        End While
        ProjectCostsReader.Close()

        ホーム.Sql.CommandText = "SELECT amount FROM projectcst_bd_total WHERE prjctcst_id=" & 明細書入力.DetailsList(SelectRow, 9)
        CostUnitPrice.Text = ホーム.Sql.ExecuteScalar

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
            For DetailsRowCount As Integer = 0 To BreakDownList.Rows.Count - 1
                If DetailsRowCount < BreakDownList.Rows.Count - 3 AndAlso BreakDownList.Rows(DetailsRowCount + 2).Caption = "▶" Then
                    SelectRow = DetailsRowCount + 2
                    Exit For
                End If
            Next

            If SelectRow = 0 Then
                MsgBox("行が選択されていません。", MsgBoxStyle.Exclamation, "代価表入力")
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

        For DetailsRowCount As Integer = 0 To BreakDownList.Rows.Count - 1
            If DetailsRowCount < BreakDownList.Rows.Count - 3 AndAlso BreakDownList.Rows(DetailsRowCount + 2).Caption = "▶" Then
                SelectRow = DetailsRowCount + 2
                Exit For
            End If
        Next

        Dim OpenForm As New 代価表入力()
        OpenForm.TopLevel = False
        ホーム.FormPanel.Controls.Add(OpenForm)
        OpenForm.SelectRow = SelectRow
        OpenForm.Show()
        Me.Visible = False

    End Sub

    Private Sub CostModifyMenu_Click(sender As Object, e As EventArgs) Handles CostModifyMenu.Click
        For DetailsRowCount As Integer = 0 To BreakDownList.Rows.Count - 1
            If DetailsRowCount < BreakDownList.Rows.Count - 3 AndAlso BreakDownList.Rows(DetailsRowCount + 2).Caption = "▶" Then
                SelectRow = DetailsRowCount + 2
                Exit For
            End If
        Next

        Dim OpenForm As New 代価表入力()
        OpenForm.TopLevel = False
        ホーム.FormPanel.Controls.Add(OpenForm)
        OpenForm.SelectRow = SelectRow
        OpenForm.Show()
        Me.Visible = False

    End Sub

    Private Sub CostCopy_Click(sender As Object, e As EventArgs) Handles CostCopy.Click
        Try
            For DetailsRowCount As Integer = 0 To BreakDownList.Rows.Count - 1
                If DetailsRowCount < BreakDownList.Rows.Count - 3 AndAlso BreakDownList.Rows(DetailsRowCount + 2).Caption = "▶" Then
                    SelectRow = DetailsRowCount + 2
                    Exit For
                End If
            Next

            If SelectRow = 0 Then
                MsgBox("行が選択されていません。", MsgBoxStyle.Exclamation, "代価表入力")
            Else

                If BreakDownList(SelectRow, 8) >= 12 Then

                    作成代価選択.HeadLine.Text = "<<コピー代価選択"
                    作成代価選択.Text = "コピー代価選択"


                    作成代価選択.ShowDialog()
                    作成代価選択.TopMost = True
                    作成代価選択.TopMost = False
                Else
                    MsgBox("選択された行には工事代価が登録されていません。", MsgBoxStyle.Exclamation, "代価表入力")
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
            For DetailsRowCount As Integer = 0 To BreakDownList.Rows.Count - 1
                If DetailsRowCount < BreakDownList.Rows.Count - 3 AndAlso BreakDownList.Rows(DetailsRowCount + 2).Caption = "▶" Then
                    SelectRow = DetailsRowCount + 2
                    Exit For
                End If
            Next

            If SelectRow = 0 Then
                MsgBox("行が選択されていません。", MsgBoxStyle.Exclamation, "代価表入力")
            Else
                If BreakDownList(SelectRow, 8) >= 12 Then

                    作成代価選択.HeadLine.Text = "<<コピー代価選択"
                    作成代価選択.Text = "コピー代価選択"


                    作成代価選択.ShowDialog()
                    作成代価選択.TopMost = True
                    作成代価選択.TopMost = False
                Else
                    MsgBox("選択された行には工事代価が登録されていません。", MsgBoxStyle.Exclamation, "代価表入力")
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
            For DetailsRowCount As Integer = 0 To BreakDownList.Rows.Count - 1
                If DetailsRowCount < BreakDownList.Rows.Count - 3 AndAlso BreakDownList.Rows(DetailsRowCount + 2).Caption = "▶" Then
                    SelectRow = DetailsRowCount + 2
                    Exit For
                End If
            Next

            If SelectRow = 0 Then
                MsgBox("行が選択されていません。", MsgBoxStyle.Exclamation, "代価表入力")

            Else
                If BreakDownList(SelectRow, 8) >= 12 Then
                    Dim OpenForm As New 代価表入力()
                    OpenForm.TopLevel = False
                    ホーム.FormPanel.Controls.Add(OpenForm)
                    OpenForm.SelectRow = SelectRow
                    OpenForm.CostNo.ReadOnly = False
                    OpenForm.CostName.Enabled = False
                    OpenForm.CostSpec.Enabled = False
                    OpenForm.CostQuanity.Enabled = False
                    OpenForm.CostUnit.Enabled = False
                    OpenForm.CostUnitPrice.Enabled = False
                    OpenForm.CostCostea.Enabled = False
                    OpenForm.BreakDownList.AllowEditing = False
                    OpenForm.Show()
                    Me.Visible = False
                Else
                    MsgBox("選択された行には工事代価が登録されていません。", MsgBoxStyle.Exclamation, "代価表入力")
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
            For DetailsRowCount As Integer = 0 To BreakDownList.Rows.Count - 1
                If DetailsRowCount < BreakDownList.Rows.Count - 3 AndAlso BreakDownList.Rows(DetailsRowCount + 2).Caption = "▶" Then
                    SelectRow = DetailsRowCount + 2
                    Exit For
                End If
            Next

            If BreakDownList(SelectRow, 8) >= 12 Then
                Dim OpenForm As New 代価表入力()
                OpenForm.TopLevel = False
                ホーム.FormPanel.Controls.Add(OpenForm)
                OpenForm.SelectRow = SelectRow
                OpenForm.Enabled = False
                OpenForm.Show()
                Me.Visible = False
            Else
                MsgBox("選択された行には工事代価が登録されていません。", MsgBoxStyle.Exclamation, "代価表入力")
            End If
        Catch ex As Exception
            ホーム.Transaction.Rollback()
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub BreakDownList_AfterRowColChange(sender As Object, e As RangeEventArgs) Handles BreakDownList.AfterRowColChange

        Try
            Dim Col As Integer = BreakDownList.Selection.LeftCol
            Dim Row As Integer = BreakDownList.Selection.TopRow

            For DetailsRowCount As Integer = 0 To BreakDownList.Rows.Count - 1
                If DetailsRowCount < BreakDownList.Rows.Count - 3 Then
                    BreakDownList.Rows(DetailsRowCount + 2).Caption = ""
                Else
                    Exit For
                End If
            Next

            Dim RowNo As Integer = BreakDownList(Row, 7)
            If RowNo = 1 Or RowNo = 4 Then
                BreakDownList.Rows(Row).Caption = "▶"
            ElseIf RowNo = 2 Or RowNo = 5 Then
                BreakDownList.Rows(Row - 1).Caption = "▶"
            Else
                BreakDownList.Rows(Row - 2).Caption = "▶"
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
            For DetailsRowCount As Integer = 0 To BreakDownList.Rows.Count - 1
                If DetailsRowCount < BreakDownList.Rows.Count - 3 AndAlso BreakDownList.Rows(DetailsRowCount + 2).Caption = "▶" Then
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
            For DetailsRowCount As Integer = 0 To BreakDownList.Rows.Count - 1
                If DetailsRowCount < BreakDownList.Rows.Count - 3 AndAlso BreakDownList.Rows(DetailsRowCount + 2).Caption = "▶" Then
                    SelectRow = DetailsRowCount + 2
                    Exit For
                End If
            Next

            If SelectRow = 0 Then
                MsgBox("行が選択されていません。", MsgBoxStyle.Exclamation, "明細書")
            Else
                BreakDownList.Rows.Insert(SelectRow)
                BreakDownList.Rows.Insert(SelectRow + 1)
                BreakDownList.Rows.Insert(SelectRow + 2)
                BreakDownList(SelectRow, 8) = 0
                BreakDownList(SelectRow, 9) = 0
                BreakDownList(SelectRow, 1) = 0
                BreakDownList(SelectRow, 6) = 0
                BreakDownList(SelectRow + 1, 6) = 0
                BreakDownList(SelectRow + 2, 6) = 0

                Dim RowNo As Integer = 0
                For RowCount As Integer = 1 To ((BreakDownList.Rows.Count - 3) / 3)
                    RowNo += 1

                    Dim Quanity As CellRange = BreakDownList.GetCellRange(RowCount * 3, 6)
                    Quanity.StyleNew.Format = "N1"
                    Dim Costea As CellRange = BreakDownList.GetCellRange(RowCount * 3 + 1, 6)
                    Costea.StyleNew.Format = "N0"
                    Dim Amount As CellRange = BreakDownList.GetCellRange(RowCount * 3 + 2, 6)
                    Amount.StyleNew.Format = "N0"

                    If RowCount Mod 2 = 0 Then
                        BreakDownList.Rows(RowCount * 3).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        BreakDownList.Rows((RowCount * 3) + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        BreakDownList.Rows((RowCount * 3) + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)

                    Else
                        BreakDownList.Rows(RowCount * 3).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        BreakDownList.Rows((RowCount * 3) + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        BreakDownList.Rows((RowCount * 3) + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)

                    End If

                    BreakDownList(RowCount * 3, 7) = RowNo * RowNo
                    BreakDownList(RowCount * 3 + 1, 7) = (RowNo * RowNo) + 1
                    BreakDownList(RowCount * 3 + 2, 7) = (RowNo * RowNo) + 2
                    If (RowNo * RowNo) + 2 = 6 Then
                        RowNo = 0
                    End If

                    BreakDownList.MergedRanges.Add(RowCount * 3, 0, (RowCount * 3) + 2, 0)
                    BreakDownList.MergedRanges.Add(RowCount * 3, 2, (RowCount * 3) + 2, 2)
                    BreakDownList.MergedRanges.Add(RowCount * 3, 3, (RowCount * 3) + 2, 3)
                    BreakDownList.MergedRanges.Add(RowCount * 3, 4, RowCount * 3, 5)
                    BreakDownList.MergedRanges.Add((RowCount * 3) + 1, 4, (RowCount * 3) + 1, 5)
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
            For DetailsRowCount As Integer = 0 To BreakDownList.Rows.Count - 1
                If DetailsRowCount < BreakDownList.Rows.Count - 3 Then
                    If BreakDownList.Rows(DetailsRowCount + 2).Caption = "▶" Then
                        SelectRow = DetailsRowCount + 2
                    End If
                    BreakDownList.Rows(DetailsRowCount + 2).StyleFixedNew.BackColor = Color.FromArgb(213, 234, 216)

                End If
            Next

            If SelectRow = 0 Then
                MsgBox("行が選択されていません。", MsgBoxStyle.Exclamation, "明細書")
            Else

                BreakDownList.Rows(SelectRow).StyleFixedNew.BackColor = Color.FromArgb(105, 189, 131)
                CopyList(0) = BreakDownList(SelectRow, 1)
                CopyList(1) = BreakDownList(SelectRow, 3)
                CopyList(2) = BreakDownList(SelectRow, 4)
                CopyList(3) = BreakDownList(SelectRow + 1, 4)
                CopyList(4) = BreakDownList(SelectRow + 2, 4)
                CopyList(5) = BreakDownList(SelectRow + 2, 5)
                CopyList(6) = BreakDownList(SelectRow, 6)
                CopyList(7) = BreakDownList(SelectRow + 1, 6)
                CopyList(8) = BreakDownList(SelectRow + 2, 6)
                CopyList(9) = BreakDownList(SelectRow, 8)
                CopyList(10) = BreakDownList(SelectRow, 9)
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
            For DetailsRowCount As Integer = 0 To BreakDownList.Rows.Count - 1
                If DetailsRowCount < BreakDownList.Rows.Count - 3 AndAlso BreakDownList.Rows(DetailsRowCount + 2).Caption = "▶" Then
                    SelectRow = DetailsRowCount + 2
                    Exit For
                End If
            Next

            If SelectRow = 0 Then
                MsgBox("行が選択されていません。", MsgBoxStyle.Exclamation, "明細書")
            Else

                BreakDownList.Rows.Insert(SelectRow)
                BreakDownList.Rows.Insert(SelectRow + 1)
                BreakDownList.Rows.Insert(SelectRow + 2)
                BreakDownList(SelectRow, 1) = CopyList(0)
                BreakDownList(SelectRow, 3) = CopyList(1)
                BreakDownList(SelectRow, 4) = CopyList(2)
                BreakDownList(SelectRow + 1, 4) = CopyList(3)
                BreakDownList(SelectRow + 2, 4) = CopyList(4)
                BreakDownList(SelectRow + 2, 5) = CopyList(5)
                BreakDownList(SelectRow, 6) = CopyList(6)
                BreakDownList(SelectRow + 1, 6) = CopyList(7)
                BreakDownList(SelectRow + 2, 6) = CopyList(8)
                BreakDownList(SelectRow, 8) = CopyList(9)
                BreakDownList(SelectRow, 9) = CopyList(10)


                Dim RowNo As Integer = 0
                For RowCount As Integer = 1 To ((BreakDownList.Rows.Count - 3) / 3)

                    RowNo += 1

                    If RowCount < ((BreakDownList.Rows.Count - 3) / 3) Then
                        BreakDownList(RowCount * 3, 3) = RowCount
                    End If

                    Dim Quanity As CellRange = BreakDownList.GetCellRange(RowCount * 3, 6)
                    Quanity.StyleNew.Format = "N1"
                    Dim Costea As CellRange = BreakDownList.GetCellRange(RowCount * 3 + 1, 6)
                    Costea.StyleNew.Format = "N0"
                    Dim Amount As CellRange = BreakDownList.GetCellRange(RowCount * 3 + 2, 6)
                    Amount.StyleNew.Format = "N0"
                    BreakDownList.Rows(RowCount * 3).StyleFixedNew.BackColor = Color.FromArgb(213, 234, 216)


                    If RowCount Mod 2 = 0 Then
                        BreakDownList.Rows(RowCount * 3).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        BreakDownList.Rows((RowCount * 3) + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        BreakDownList.Rows((RowCount * 3) + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)

                    Else
                        BreakDownList.Rows(RowCount * 3).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        BreakDownList.Rows((RowCount * 3) + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        BreakDownList.Rows((RowCount * 3) + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                    End If

                    BreakDownList(RowCount * 3, 7) = RowNo * RowNo
                    BreakDownList(RowCount * 3 + 1, 7) = (RowNo * RowNo) + 1
                    BreakDownList(RowCount * 3 + 2, 7) = (RowNo * RowNo) + 2
                    If (RowNo * RowNo) + 2 = 6 Then
                        RowNo = 0
                    End If

                    BreakDownList.MergedRanges.Add(RowCount * 3, 0, (RowCount * 3) + 2, 0)
                    BreakDownList.MergedRanges.Add(RowCount * 3, 2, (RowCount * 3) + 2, 2)
                    BreakDownList.MergedRanges.Add(RowCount * 3, 3, (RowCount * 3) + 2, 3)
                    BreakDownList.MergedRanges.Add(RowCount * 3, 4, RowCount * 3, 5)
                    BreakDownList.MergedRanges.Add((RowCount * 3) + 1, 4, (RowCount * 3) + 1, 5)
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
            For DetailsRowCount As Integer = 0 To BreakDownList.Rows.Count - 1
                If DetailsRowCount < BreakDownList.Rows.Count - 3 AndAlso BreakDownList.Rows(DetailsRowCount + 2).Caption = "▶" Then
                    SelectRow = DetailsRowCount + 2
                    Exit For
                End If
            Next

            If SelectRow = 0 Then
                MsgBox("行が選択されていません。", MsgBoxStyle.Exclamation, "明細書")
            Else
                CopyList(0) = BreakDownList(SelectRow, 1)
                CopyList(1) = BreakDownList(SelectRow, 3)
                CopyList(2) = BreakDownList(SelectRow, 4)
                CopyList(3) = BreakDownList(SelectRow + 1, 4)
                CopyList(4) = BreakDownList(SelectRow + 2, 4)
                CopyList(5) = BreakDownList(SelectRow + 2, 5)
                CopyList(6) = BreakDownList(SelectRow, 6)
                CopyList(7) = BreakDownList(SelectRow + 1, 6)
                CopyList(8) = BreakDownList(SelectRow + 2, 6)
                CopyList(9) = BreakDownList(SelectRow, 8)
                CopyList(10) = BreakDownList(SelectRow, 9)
                BreakDownList.Rows.RemoveRange(SelectRow, 3)

                Dim RowNo As Integer = 0
                For RowCount As Integer = 1 To ((BreakDownList.Rows.Count - 3) / 3)
                    RowNo += 1

                    Dim Quanity As CellRange = BreakDownList.GetCellRange(RowCount * 3, 6)
                    Quanity.StyleNew.Format = "N1"
                    Dim Costea As CellRange = BreakDownList.GetCellRange(RowCount * 3 + 1, 6)
                    Costea.StyleNew.Format = "N0"
                    Dim Amount As CellRange = BreakDownList.GetCellRange(RowCount * 3 + 2, 6)
                    Amount.StyleNew.Format = "N0"
                    BreakDownList.Rows(RowCount * 3).StyleFixedNew.BackColor = Color.FromArgb(213, 234, 216)


                    If RowCount Mod 2 = 0 Then
                        BreakDownList.Rows(RowCount * 3).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        BreakDownList.Rows((RowCount * 3) + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        BreakDownList.Rows((RowCount * 3) + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                    Else
                        BreakDownList.Rows(RowCount * 3).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        BreakDownList.Rows((RowCount * 3) + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        BreakDownList.Rows((RowCount * 3) + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                    End If

                    BreakDownList(RowCount * 3, 7) = RowNo * RowNo
                    BreakDownList(RowCount * 3 + 1, 7) = (RowNo * RowNo) + 1
                    BreakDownList(RowCount * 3 + 2, 7) = (RowNo * RowNo) + 2
                    If (RowNo * RowNo) + 2 = 6 Then
                        RowNo = 0
                    End If

                    BreakDownList.MergedRanges.Add(RowCount * 3, 0, (RowCount * 3) + 2, 0)
                    BreakDownList.MergedRanges.Add(RowCount * 3, 2, (RowCount * 3) + 2, 2)
                    BreakDownList.MergedRanges.Add(RowCount * 3, 3, (RowCount * 3) + 2, 3)
                    BreakDownList.MergedRanges.Add(RowCount * 3, 4, RowCount * 3, 5)
                    BreakDownList.MergedRanges.Add((RowCount * 3) + 1, 4, (RowCount * 3) + 1, 5)
                Next
            End If

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

End Class