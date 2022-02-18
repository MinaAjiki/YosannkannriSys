Imports C1.Win.C1FlexGrid
Imports System.Windows.Forms.Form
Imports C1.Win.C1Command
Imports System.Data.SqlClient
Public Class 代価一覧
    Public ParentFormName As String
    Public CostClassCode As Integer
    Public CostClassName As String
    Private Sub 代価一覧_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If CostClassName = "基礎代価" Then
                ホーム.SystemSql.Parameters.Clear()
                ホーム.SystemSql.CommandText = ""
                ホーム.SystemSql.CommandText = "SELECT Count(*) FROM basis_costs WHERE cstclss_code=" & CostClassCode
                Dim BasicCostsCount As Integer = ホーム.SystemSql.ExecuteScalar

                If BasicCostsCount > 21 Then
                    ProjectCostList.Rows.Count = BasicCostsCount + 1
                Else
                    ProjectCostList.Rows.Count = 22
                End If

                CostList.Text = CostClassName

                ProjectCostList.Rows.Count = BasicCostsCount + 1

                ホーム.Sql.CommandText = "SELECT contents FROM controldata WHERE class_code=12"
                Dim Year As Integer = Integer.Parse(ホーム.Sql.ExecuteScalar)

                Dim RowCount As Integer = 0
                ホーム.SystemSql.CommandText = "SELECT * FROM basis_costs WHERE cstclss_code=" & CostClassCode & " AND year=" & Year & " ORDER BY bsscst_no ASC"
                Dim BasicCostsReader As SqlDataReader = ホーム.SystemSql.ExecuteReader
                While BasicCostsReader.Read
                    RowCount += 1
                    ProjectCostList(RowCount, 1) = BasicCostsReader.Item("bsscst_id")
                    ProjectCostList(RowCount, 3) = BasicCostsReader.Item("bsscst_no")
                    ProjectCostList(RowCount, 4) = BasicCostsReader.Item("bsscst_name")
                    ProjectCostList(RowCount, 5) = BasicCostsReader.Item("bsscst_spec")
                    ProjectCostList(RowCount, 6) = BasicCostsReader.Item("bsscst_unit")
                    ProjectCostList(RowCount, 7) = BasicCostsReader.Item("bsscst_quanity")
                    ProjectCostList(RowCount, 8) = BasicCostsReader.Item("bsscst_costea")
                    ProjectCostList(RowCount, 9) = Math.Floor(BasicCostsReader.Item("bsscst_costea") * BasicCostsReader.Item("bsscst_quanity"))
                    ProjectCostList(RowCount, 10) = BasicCostsReader.Item("bsscst_laborea")
                    ProjectCostList(RowCount, 11) = BasicCostsReader.Item("bsscst_materialea")
                    ProjectCostList(RowCount, 12) = BasicCostsReader.Item("bsscst_machineea")
                    ProjectCostList(RowCount, 13) = BasicCostsReader.Item("bsscst_subcnstrctea")
                    ProjectCostList(RowCount, 14) = BasicCostsReader.Item("bsscst_expnseea")

                End While
                BasicCostsReader.Close()

            Else

                ホーム.Sql.Parameters.Clear()
                ホーム.Sql.CommandText = ""
                ホーム.Sql.CommandText = "SELECT Count(*) FROM project_costs WHERE cstclss_code=" & CostClassCode
                Dim ProjectCostsCount As Integer = ホーム.Sql.ExecuteScalar

                If ProjectCostsCount > 21 Then
                    ProjectCostList.Rows.Count = ProjectCostsCount + 1
                Else
                    ProjectCostList.Rows.Count = 22
                End If

                CostList.Text = CostClassName


                Dim RowCount As Integer = 0
                ホーム.Sql.CommandText = "SELECT * FROM project_costs WHERE cstclss_code=" & CostClassCode & " AND budget_no=" & ホーム.BudgetNo & " ORDER BY prjctcst_no ASC"
                Dim ProjectCostsReader As SqlDataReader = ホーム.Sql.ExecuteReader
                While ProjectCostsReader.Read
                    RowCount += 1
                    ProjectCostList(RowCount, 1) = ProjectCostsReader.Item("prjctcst_id")
                    ProjectCostList(RowCount, 3) = ProjectCostsReader.Item("prjctcst_no")
                    ProjectCostList(RowCount, 4) = ProjectCostsReader.Item("prjctcst_name")
                    ProjectCostList(RowCount, 5) = ProjectCostsReader.Item("prjctcst_spec")
                    ProjectCostList(RowCount, 6) = ProjectCostsReader.Item("prjctcst_unit")
                    ProjectCostList(RowCount, 7) = ProjectCostsReader.Item("prjctcst_quanity")
                    ProjectCostList(RowCount, 8) = ProjectCostsReader.Item("prjctcst_costea")
                    ProjectCostList(RowCount, 9) = Math.Floor(ProjectCostsReader.Item("prjctcst_costea") * ProjectCostsReader.Item("prjctcst_quanity"))
                    ProjectCostList(RowCount, 10) = ProjectCostsReader.Item("prjctcst_laborea")
                    ProjectCostList(RowCount, 11) = ProjectCostsReader.Item("prjctcst_materialea")
                    ProjectCostList(RowCount, 12) = ProjectCostsReader.Item("prjctcst_machineea")
                    ProjectCostList(RowCount, 13) = ProjectCostsReader.Item("prjctcst_subcntrctea")
                    ProjectCostList(RowCount, 14) = ProjectCostsReader.Item("prjctcst_expenseea")

                End While
                ProjectCostsReader.Close()

            End If


            If ParentFormName = "明細書" Or ParentFormName = "代価表" Then
                ProjectCostList.Cols(2).Visible = False
                ProjectCostList.AllowEditing = False
                Entry.Visible = False
                CostCreation.Visible = False
                CostModify.Visible = False
                CostCopy.Visible = False
                右クリックメニュー.Visible = False
            End If

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try

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

    Private Sub 代価一覧_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ホーム.Enabled = True
        ParentFormName = ""
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
    Private Sub SearchName_Load(sender As Object, e As EventArgs) Handles SearchName.Load
        SearchName.SetC1FlexGridSearchPanel(ProjectCostList, SearchName)
    End Sub

    Private Sub MasterContentsList_DoubleClick(sender As Object, e As EventArgs) Handles ProjectCostList.DoubleClick

        Try
            Dim Row As Integer = ProjectCostList.Selection.TopRow

            If ParentFormName = "明細書" Then
                明細書入力.DetailsList(明細書入力.SelectRow, 9) = ProjectCostList(Row, 1)
                明細書入力.DetailsList(明細書入力.SelectRow, 8) = CostClassCode
                明細書入力.DetailsList(明細書入力.SelectRow, 3) = 明細書入力.SelectRow / 3
                明細書入力.DetailsList(明細書入力.SelectRow, 4) = ProjectCostList(Row, 4)
                明細書入力.DetailsList(明細書入力.SelectRow + 1, 4) = ProjectCostList(Row, 5)
                明細書入力.DetailsList(明細書入力.SelectRow + 2, 5) = ProjectCostList(Row, 6)
                明細書入力.DetailsList(明細書入力.SelectRow + 1, 6) = ProjectCostList(Row, 8)
                If IsNothing(明細書入力.DetailsList(明細書入力.SelectRow, 6)) = False Then
                    明細書入力.DetailsList(明細書入力.SelectRow + 2, 6) = Math.Floor((明細書入力.DetailsList(明細書入力.SelectRow, 6) * ProjectCostList(Row, 8)))
                End If
                明細書入力.CategoryList(明細書入力.SelectRow + 1, 2) = ProjectCostList(Row, 10)
                明細書入力.CategoryList(明細書入力.SelectRow + 1, 3) = ProjectCostList(Row, 11)
                明細書入力.CategoryList(明細書入力.SelectRow + 1, 4) = ProjectCostList(Row, 12)
                明細書入力.CategoryList(明細書入力.SelectRow + 1, 5) = ProjectCostList(Row, 13)
                明細書入力.CategoryList(明細書入力.SelectRow + 1, 6) = ProjectCostList(Row, 14)


                Dim No As String = ProjectCostList(Row, 3)
                If No.Length = 1 Then
                    No = "0000" & No
                ElseIf No.Length = 2 Then
                    No = "000" & No
                ElseIf No.Length = 3 Then
                    No = "00" & No
                ElseIf No.Length = 4 Then
                    No = "0" & No
                End If

                Dim ClassName As String = ""
                If CostClassName = "基礎代価" Then
                    ClassName = "K"
                Else
                    ClassName = CostClassName.Last
                End If

                明細書入力.DetailsList(明細書入力.SelectRow + 2, 4) = "第" & ClassName & "-" & No & "号"

                If 明細書入力.SelectRow + 3 = 明細書入力.DetailsList.Rows.Count Then
                    明細書入力.DetailsList.Rows.Add(3)
                    明細書入力.CategoryList.Rows.Add(3)
                    明細書入力.OutsoucerList.Rows.Add(3)
                    Dim NewRow As Integer = 明細書入力.SelectRow + 3

                    Dim Quanity As CellRange = 明細書入力.DetailsList.GetCellRange(NewRow, 6)
                    Quanity.StyleNew.Format = "N1"
                    Dim Costea As CellRange = 明細書入力.DetailsList.GetCellRange(NewRow + 1, 6)
                    Costea.StyleNew.Format = "N0"
                    Dim Amount As CellRange = 明細書入力.DetailsList.GetCellRange(NewRow + 2, 6)
                    Amount.StyleNew.Format = "N0"
                    明細書入力.DetailsList.Rows(NewRow).StyleFixedNew.BackColor = Color.FromArgb(213, 234, 216)


                    If NewRow Mod 2 = 0 Then
                        明細書入力.DetailsList.Rows(NewRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        明細書入力.DetailsList.Rows(NewRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        明細書入力.DetailsList.Rows(NewRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)

                        明細書入力.CategoryList.Rows(NewRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        明細書入力.CategoryList.Rows(NewRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        明細書入力.CategoryList.Rows(NewRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)

                        明細書入力.OutsoucerList.Rows(NewRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        明細書入力.OutsoucerList.Rows(NewRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        明細書入力.OutsoucerList.Rows(NewRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)

                        明細書入力.DetailsList(NewRow, 7) = 4
                        明細書入力.DetailsList(NewRow + 1, 7) = 5
                        明細書入力.DetailsList(NewRow + 2, 7) = 6

                    Else
                        明細書入力.DetailsList.Rows(NewRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        明細書入力.DetailsList.Rows(NewRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        明細書入力.DetailsList.Rows(NewRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)

                        明細書入力.CategoryList.Rows(NewRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        明細書入力.CategoryList.Rows(NewRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        明細書入力.CategoryList.Rows(NewRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)

                        明細書入力.OutsoucerList.Rows(NewRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        明細書入力.OutsoucerList.Rows(NewRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        明細書入力.OutsoucerList.Rows(NewRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)


                        明細書入力.DetailsList(NewRow, 7) = 1
                        明細書入力.DetailsList(NewRow + 1, 7) = 2
                        明細書入力.DetailsList(NewRow + 2, 7) = 3

                    End If

                    明細書入力.DetailsList.MergedRanges.Add(NewRow, 0, NewRow + 2, 0)
                    明細書入力.DetailsList.MergedRanges.Add(NewRow, 2, NewRow + 2, 2)
                    明細書入力.DetailsList.MergedRanges.Add(NewRow, 3, NewRow + 2, 3)
                    明細書入力.DetailsList.MergedRanges.Add(NewRow, 4, NewRow, 5)
                    明細書入力.DetailsList.MergedRanges.Add(NewRow + 1, 4, NewRow + 1, 5)

                End If

            ElseIf ParentFormName = "代価表" Then

                Dim Count As Integer = ホーム.ProjectCostSelectRow.Count
                Dim ProjectCostRow As Integer = ホーム.ProjectCostSelectRow(Count - 1)
                Dim ProjectCostList As C1FlexGrid = ホーム.PrjctCstList(Count - 1)

                ProjectCostList(ProjectCostRow, 9) = Me.ProjectCostList(Row, 1)
                ProjectCostList(ProjectCostRow, 8) = CostClassCode
                ProjectCostList(ProjectCostRow, 3) = ProjectCostRow / 3
                ProjectCostList(ProjectCostRow, 4) = Me.ProjectCostList(Row, 4)
                ProjectCostList(ProjectCostRow + 1, 4) = Me.ProjectCostList(Row, 5)
                ProjectCostList(ProjectCostRow + 2, 5) = Me.ProjectCostList(Row, 6)
                ProjectCostList(ProjectCostRow + 1, 6) = Me.ProjectCostList(Row, 8)
                If IsNothing(ProjectCostList(ProjectCostRow, 6)) = False Then
                    ProjectCostList(ProjectCostRow + 2, 6) = Math.Floor((ProjectCostList(ProjectCostRow, 6) * Me.ProjectCostList(Row, 8)))
                End If
                ProjectCostList(ProjectCostRow + 1, 10) = Me.ProjectCostList(Row, 10)
                ProjectCostList(ProjectCostRow + 1, 11) = Me.ProjectCostList(Row, 11)
                ProjectCostList(ProjectCostRow + 1, 12) = Me.ProjectCostList(Row, 12)
                ProjectCostList(ProjectCostRow + 1, 13) = Me.ProjectCostList(Row, 13)
                ProjectCostList(ProjectCostRow + 1, 14) = Me.ProjectCostList(Row, 14)

                Dim No As String = Me.ProjectCostList(Row, 3)
                If No.Length = 1 Then
                    No = "0000" & No
                ElseIf No.Length = 2 Then
                    No = "000" & No
                ElseIf No.Length = 3 Then
                    No = "00" & No
                ElseIf No.Length = 4 Then
                    No = "0" & No
                End If

                Dim ClassName As String = ""
                If CostClassName = "基礎代価" Then
                    ClassName = "K"
                Else
                    ClassName = CostClassName.Last
                End If

                ProjectCostList(ProjectCostRow + 2, 4) = "第" & ClassName & "-" & No & "号"


                If ProjectCostRow + 3 = ProjectCostList.Rows.Count Then
                    ProjectCostList.Rows.Add(3)
                    Dim NewRow As Integer = ProjectCostRow + 3

                    Dim Quanity As CellRange = ProjectCostList.GetCellRange(NewRow, 6)
                    Quanity.StyleNew.Format = "N1"
                    Dim Costea As CellRange = ProjectCostList.GetCellRange(NewRow + 1, 6)
                    Costea.StyleNew.Format = "N0"
                    Dim Amount As CellRange = ProjectCostList.GetCellRange(NewRow + 2, 6)
                    Amount.StyleNew.Format = "N0"
                    ProjectCostList.Rows(NewRow).StyleFixedNew.BackColor = Color.FromArgb(213, 234, 216)


                    If NewRow Mod 2 = 0 Then
                        ProjectCostList.Rows(NewRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        ProjectCostList.Rows(NewRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        ProjectCostList.Rows(NewRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)

                        ProjectCostList(NewRow, 7) = 4
                        ProjectCostList(NewRow + 1, 7) = 5
                        ProjectCostList(NewRow + 2, 7) = 6

                    Else
                        ProjectCostList.Rows(NewRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        ProjectCostList.Rows(NewRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        ProjectCostList.Rows(NewRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)

                        ProjectCostList(NewRow, 7) = 1
                        ProjectCostList(NewRow + 1, 7) = 2
                        ProjectCostList(NewRow + 2, 7) = 3

                    End If

                    ProjectCostList.MergedRanges.Add(NewRow, 0, NewRow + 2, 0)
                    ProjectCostList.MergedRanges.Add(NewRow, 2, NewRow + 2, 2)
                    ProjectCostList.MergedRanges.Add(NewRow, 3, NewRow + 2, 3)
                    ProjectCostList.MergedRanges.Add(NewRow, 4, NewRow, 5)
                    ProjectCostList.MergedRanges.Add(NewRow + 1, 4, NewRow + 1, 5)

                End If

                ホーム.ProjectCostSelectRow.RemoveAt(Count - 1)
                ホーム.PrjctCstList.RemoveAt(Count - 1)

            End If

            Me.Close()

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
End Class