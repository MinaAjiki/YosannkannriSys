Imports C1.Win.C1FlexGrid
Imports System.Windows.Forms.Form
Imports C1.Win.C1Command
Imports System.Data.SqlClient
Public Class 代価一覧
    Public ParentFormName As String
    Public CostClassCode As Integer
    Public CostClassName As String
    Public SelectRow As Integer = 0
    Public AddFlag As Integer = 0
    Private Sub 代価一覧_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If CostClassName = "基礎代価" Then
                CostClassCode = 11

                Dim Year As Integer
                ホーム.Sql.CommandText = "SELECT contents FROM controldata WHERE class_code=12"
                If IsNumeric(ホーム.Sql.ExecuteScalar) = True Then
                    Year = Integer.Parse(ホーム.Sql.ExecuteScalar)
                Else
                    If ホーム.AdminChk = "True" Then
                        ホーム.SystemSql.CommandText = "SELECT MAX(year) FROM years"
                        Year = Integer.Parse(ホーム.SystemSql.ExecuteScalar)
                    Else
                        MsgBox("予算総括を登録して下さい。", MsgBoxStyle.Exclamation, "代価一覧")
                    End If
                End If

                ホーム.SystemSql.Parameters.Clear()
                ホーム.SystemSql.CommandText = ""
                ホーム.SystemSql.CommandText = "SELECT Count(*) FROM basis_costs WHERE deleted = 0 AND cstclss_code=" & CostClassCode & " AND year=" & Year & "AND deleted = 0"
                Dim BasicCostsCount As Integer = ホーム.SystemSql.ExecuteScalar

                If BasicCostsCount > 21 Then
                    ProjectCostList.Rows.Count = BasicCostsCount + 1
                Else
                    ProjectCostList.Rows.Count = 22
                End If

                CostList.Text = CostClassName

                ProjectCostList.Rows.Count = BasicCostsCount + 1

                Dim RowCount As Integer = 0

                ホーム.SystemSql.CommandText = "SELECT * FROM basis_costs WHERE cstclss_code=" & CostClassCode & " AND year=" & Year & "AND deleted = 0 ORDER BY bsscst_no ASC"
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

                Dim dt2 As DataTable
                dt2 = New DataTable
                dt2.Columns.Add("year", GetType(System.Int32))
                Dim years As Int32

                ホーム.SystemSql.Parameters.Clear()
                YearList.Items.Clear()
                ホーム.SystemSql.CommandText = "SELECT DISTINCT year FROM basis_costs ORDER BY year ASC"
                Dim YearReader As SqlDataReader = ホーム.SystemSql.ExecuteReader
                While YearReader.Read
                    years = YearReader("year")
                    dt2.Rows.Add(years)
                End While
                YearReader.Close()

                YearList.TextDetached = True
                YearList.ItemsDataSource = dt2.DefaultView
                YearList.ItemsDisplayMember = "year"
                YearList.ItemsValueMember = "year"
                YearList.ItemMode = C1.Win.C1Input.ComboItemMode.HtmlPattern
                If ホーム.AdminChk = "True" Then
                    YearList.Visible = True
                End If
                YearList.Text = Year
                ProjectCostList.Cols(2).AllowEditing = True

            ElseIf CostClassName = "工事代価" Then
                ProjectCostList.ContextMenuStrip = 右クリックメニュー



                Dim dt As DataTable
                dt = New DataTable
                dt.Columns.Add("code", GetType(System.Int32))
                dt.Columns.Add("name", GetType(System.String))
                Dim code As Int32
                Dim name As String


                ホーム.Sql.Parameters.Clear()
                CostList.Items.Clear()
                ホーム.Sql.CommandText = "SELECT * FROM cost_classes WHERE cstclss_code>11 ORDER BY cstclss_code ASC"
                Dim CostClassReader As SqlDataReader = ホーム.Sql.ExecuteReader
                While CostClassReader.Read
                    code = CostClassReader("cstclss_code")
                    name = CostClassReader("cstclss_name")
                    dt.Rows.Add(code, name)
                End While
                dt.Rows.Add(0, "階層追加")
                CostClassReader.Close()

                CostList.TextDetached = True
                CostList.ItemsDataSource = dt.DefaultView
                CostList.ItemsDisplayMember = "name"
                CostList.ItemsValueMember = "code"
                CostList.ItemMode = C1.Win.C1Input.ComboItemMode.HtmlPattern
                'CostList.HtmlPattern = "<table><tr><td width=30>{Code}</td><td width=270>{Name}</td></tr></table>"
                CostList.SelectedIndex = 0
                'CostList.Text = "工事代価を選択"

                ProjectCostList.Cols(2).AllowEditing = True

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
                ホーム.Sql.CommandText = "SELECT * FROM project_costs WHERE budget_no=" & ホーム.BudgetNo & " AND  cstclss_code=" & CostClassCode & " ORDER BY prjctcst_no ASC"
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
                YearList.Visible = False
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
            ホーム.ItemSelect = "true"

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
                Me.Visible = False

                明細書入力.DetailsList.Focus()
                明細書入力.DetailsList.Select(明細書入力.SelectRow, 6)

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
                ProjectCostList.Focus()
                ProjectCostList.Select(ProjectCostRow, 6)
                ホーム.ProjectCostSelectRow.RemoveAt(Count - 1)
                ホーム.PrjctCstList.RemoveAt(Count - 1)
                Me.Close()

            ElseIf CostClassName = "基礎代価" Or 0 <= CostClassName.IndexOf("工事代価") Then
                If CostList.Text = "工事代価を選択" Then
                    MsgBox("工事代価を選択して下さい。", MsgBoxStyle.Exclamation, "代価一覧")
                    Exit Sub
                End If
                SelectRow = ProjectCostList.Selection.TopRow
                代価内訳.CostID = ProjectCostList(SelectRow, 1)


                代価内訳.ClassCode = CostClassCode

                If CostClassCode = 11 Then
                    ホーム.BeforeForm = "基礎代価一覧"
                ElseIf CostClassCode > 11 Then
                    ホーム.BeforeForm = "工事代価一覧"
                End If

                代価内訳.Show()
                Me.Visible = False
            End If


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

    Private Sub CostList_SelectedItemChanged(sender As Object, e As EventArgs) Handles CostList.SelectedItemChanged

    End Sub

    Private Sub CostList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CostList.SelectedIndexChanged
        Try
            CostClassName = CostList.Text
            CostClassCode = CostList.Value


            If CostList.Text = "階層追加" And AddFlag = 0 Then
                Dim CostLists(22) As String
                CostLists(0) = "D"
                CostLists(1) = "E"
                CostLists(2) = "F"
                CostLists(3) = "G"
                CostLists(4) = "H"
                CostLists(5) = "I"
                CostLists(6) = "J"
                CostLists(7) = "K"
                CostLists(8) = "L"
                CostLists(9) = "M"
                CostLists(10) = "N"
                CostLists(11) = "O"
                CostLists(12) = "P"
                CostLists(13) = "Q"
                CostLists(14) = "R"
                CostLists(15) = "S"
                CostLists(16) = "T"
                CostLists(17) = "U"
                CostLists(18) = "V"
                CostLists(19) = "W"
                CostLists(20) = "X"
                CostLists(21) = "Y"
                CostLists(22) = "Z"



                ホーム.Sql.Parameters.Clear()
                ホーム.Sql.CommandText = "SELECT MAX(cstclss_code) FROM cost_classes"
                Dim MaxCode As Integer = ホーム.Sql.ExecuteScalar

                If CostLists((MaxCode + 1) - 15) = "Z" Then
                    MsgBox("工事代価 Z 以上の階層は追加できません。", MsgBoxStyle.Exclamation, "作成代価選択")
                    Me.Visible = False
                    Exit Sub
                End If

                If MsgBox("工事代価" & CostLists((MaxCode + 1) - 15) & "を作成します。" & vbCrLf & "よろしいですか？", MsgBoxStyle.OkCancel, "代価階層追加") = MsgBoxResult.Ok Then
                    ホーム.Sql.Parameters.Clear()
                    ホーム.Sql.CommandText = ""
                    ホーム.Sql.CommandText = "INSERT INTO cost_classes (cstclss_code,cstclss_name) VALUES (@cstclsscode,@cstclssname)"
                    ホーム.Sql.Parameters.Add(New SqlParameter("@cstclsscode", SqlDbType.SmallInt))
                    ホーム.Sql.Parameters.Add(New SqlParameter("@cstclssname", SqlDbType.NVarChar))
                    ホーム.Sql.Parameters("@cstclsscode").Value = MaxCode + 1
                    ホーム.Sql.Parameters("@cstclssname").Value = "工事代価" & CostLists((MaxCode + 1) - 15)
                    ホーム.Sql.ExecuteNonQuery()

                    Dim dt As DataTable
                    dt = New DataTable
                    dt.Columns.Add("code", GetType(System.Int32))
                    dt.Columns.Add("name", GetType(System.String))
                    Dim code As Int32
                    Dim name As String

                    ホーム.Sql.Parameters.Clear()
                    CostList.Items.Clear()
                    ホーム.Sql.CommandText = "SELECT * FROM cost_classes WHERE cstclss_code>11 ORDER BY cstclss_code ASC"
                    Dim CostClassReader As SqlDataReader = ホーム.Sql.ExecuteReader
                    While CostClassReader.Read
                        code = CostClassReader("cstclss_code")
                        name = CostClassReader("cstclss_name")
                        dt.Rows.Add(code, name)
                    End While
                    dt.Rows.Add(0, "階層追加")
                    CostClassReader.Close()

                    AddFlag = 1
                    CostList.TextDetached = True
                    CostList.ItemsDataSource = dt.DefaultView
                    CostList.ItemsDisplayMember = "name"
                    CostList.ItemsValueMember = "code"
                    CostList.ItemMode = C1.Win.C1Input.ComboItemMode.HtmlPattern
                    'CostList.HtmlPattern = "<table><tr><td width=30>{Code}</td><td width=270>{Name}</td></tr></table>"
                    CostList.SelectedIndex = (MaxCode + 1) - 12


                End If

                '階層追加以外を選択
            Else
                ProjectCostList.Clear(ClearFlags.Content)
                ProjectCostList(0, 2) = "削除"
                ProjectCostList(0, 3) = "No"
                ProjectCostList(0, 4) = "名称"
                ProjectCostList(0, 5) = "規格"
                ProjectCostList(0, 6) = "単位"
                ProjectCostList(0, 7) = "数量"
                ProjectCostList(0, 8) = "単価"
                ProjectCostList(0, 9) = "代価計"
                ホーム.Sql.Parameters.Clear()
                ホーム.Sql.CommandText = ""
                ホーム.Sql.CommandText = "SELECT Count(*) FROM project_costs WHERE cstclss_code=" & CostClassCode & " AND budget_no=" & ホーム.BudgetNo
                Dim ProjectCostsCount As Integer = ホーム.Sql.ExecuteScalar

                If ProjectCostsCount > 21 Then
                    ProjectCostList.Rows.Count = ProjectCostsCount + 1
                Else
                    ProjectCostList.Rows.Count = 22
                End If


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
                If AddFlag = 1 Then
                    ホーム.Sql.Parameters.Clear()
                    ホーム.Sql.CommandText = "SELECT MAX(cstclss_code) FROM cost_classes"
                    Dim MaxCode As Integer = ホーム.Sql.ExecuteScalar
                    AddFlag = 0
                    CostList.SelectedIndex = (MaxCode + 1) - 15
                End If
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
            If CostList.SelectedIndex = -1 And CostClassName = "工事代価" Then
                MsgBox("代価表を選択して下さい。", MsgBoxStyle.Exclamation, "代価一覧")
                Exit Sub
            End If

            If CostClassCode = 11 Then

                ホーム.SystemSql.CommandText = ""
                ホーム.SystemSql.Parameters.Clear()
                ホーム.SystemSql.CommandText = "SELECT Count(*) FROM basis_costs WHERE deleted = 0 AND cstclss_code=" & CostClassCode & " AND year=" & YearList.Text
                Dim BasicCostsCount As Integer = ホーム.SystemSql.ExecuteScalar
                ホーム.SystemSql.Parameters.Add(New SqlParameter("@deleted", SqlDbType.NVarChar)).Value = 1
                For DeleteBasic As Integer = 1 To BasicCostsCount
                    If ProjectCostList(DeleteBasic, 2) = True Then
                        ホーム.SystemSql.CommandText = "UPDATE basis_costs SET deleted=@deleted WHERE bsscst_id=" & ProjectCostList(DeleteBasic, 1)
                        ホーム.SystemSql.ExecuteNonQuery()
                        'ホーム.SystemSql.CommandText = "UPDATE basis_cost_breakdown SET deleted=@deleted WHERE bsscst_id=" & ProjectCostList(DeleteBasic, 1)
                        'ホーム.SystemSql.ExecuteNonQuery()
                    End If
                Next
            ElseIf CostClassCode >= 12 Then
                Dim RowCount As Integer = ProjectCostList.Rows.Count - 1
                ホーム.Transaction = ホーム.Connection.BeginTransaction
                ホーム.Sql.Transaction = ホーム.Transaction
                For prjctloop As Integer = 1 To RowCount
                    Dim prjctID As CellRange = ProjectCostList.GetCellRange(prjctloop, 1)
                    If ProjectCostList(prjctloop, 2) = True Then
                        If prjctID.Data <> Nothing Then
                            ホーム.Sql.CommandText = ""
                            ホーム.Sql.Parameters.Clear()
                            ホーム.Sql.CommandText = "SELECT COUNT(cstmstr_id) FROM details WHERE cstmstr_id = " & prjctID.Data & "AND cstclss_code = " & CostClassCode
                            Dim usecount As Integer = ホーム.Sql.ExecuteScalar
                            ホーム.Sql.Parameters.Clear()
                            ホーム.Sql.CommandText = "SELECT COUNT(cstmstr_id) FROM project_cost_breakdowns WHERE cstmstr_id = " & prjctID.Data & "AND cstclss_code = " & CostClassCode
                            Dim usescount As Integer = usecount + ホーム.Sql.ExecuteScalar
                            If usescount = 0 Then
                                ホーム.Sql.CommandText = ""
                                ホーム.Sql.Parameters.Clear()
                                ホーム.Sql.CommandText = "DELETE FROM project_costs WHERE prjctcst_id = " & prjctID.Data & "AND budget_no =" & ホーム.BudgetNo
                                ホーム.Sql.ExecuteNonQuery()
                                ホーム.Sql.CommandText = ""
                                ホーム.Sql.Parameters.Clear()
                                ホーム.Sql.CommandText = "DELETE FROM project_cost_breakdowns WHERE prjctcst_id = " & prjctID.Data
                                ホーム.Sql.ExecuteNonQuery()
                            Else
                                MsgBox(ProjectCostList(prjctloop, 4) & " は使用されている代価のため削除されませんでした。", MsgBoxStyle.Exclamation, "代価一覧")
                            End If

                        End If
                    End If
                Next
                ホーム.Transaction.Commit()
            End If

            MsgBox(" 登録完了", MsgBoxStyle.OkOnly, "代価表入力")
            Me.Close()

        Catch ex As Exception
            ホーム.Transaction.Rollback()
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub CostCreation_Click(sender As Object, e As EventArgs) Handles CostCreation.Click
        Try
            代価内訳.ClassCode = CostClassCode

            If CostList.Text = "工事代価を選択" Then
                MsgBox("工事代価を選択して下さい。", MsgBoxStyle.Exclamation, "代価一覧")
                Exit Sub
            End If
            If CostClassCode = 11 Then
                ホーム.BeforeForm = "基礎代価一覧"
            ElseIf CostClassCode > 11 Then
                ホーム.BeforeForm = "工事代価一覧"
            End If

            代価内訳.Show()
            Me.Visible = False
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub CostModify_Click(sender As Object, e As EventArgs) Handles CostModify.Click
        Try
            If CostList.Text = "工事代価を選択" Then
                MsgBox("工事代価を選択して下さい。", MsgBoxStyle.Exclamation, "代価一覧")
                Exit Sub
            End If
            SelectRow = ProjectCostList.Selection.TopRow
            代価内訳.CostID = ProjectCostList(SelectRow, 1)
            代価内訳.ClassCode = CostClassCode

            If CostClassCode = 11 Then
                ホーム.BeforeForm = "基礎代価一覧"
            ElseIf CostClassCode > 11 Then
                ホーム.BeforeForm = "工事代価一覧"
            End If

            代価内訳.Show()
            Me.Visible = False
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub CostCopy_Click(sender As Object, e As EventArgs) Handles CostCopy.Click
        Try
            SelectRow = ProjectCostList.Selection.TopRow
            If SelectRow = 0 Then
                MsgBox("行が選択されていません。", MsgBoxStyle.Exclamation, "代価表入力")
            Else
                ホーム.ProjectCommand = "CostCopy"
                ホーム.BeforeForm = "代価一覧"
                'If BreakDownList(SelectRow, 8) >= 12 Then

                作成代価選択.HeadLine.Text = "<<コピー代価選択"
                作成代価選択.Text = "コピー代価選択"
                作成代価選択.SelectRow = SelectRow
                '作成代価選択.CopyList = ProjectCostList


                作成代価選択.ShowDialog()
                作成代価選択.TopMost = True
                作成代価選択.TopMost = False
                'Else
                '    MsgBox("選択された行には工事代価が登録されていません。", MsgBoxStyle.Exclamation, "代価表入力")
                'End If

            End If

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub YearList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles YearList.SelectedIndexChanged
        ProjectCostList.Clear(ClearFlags.Content)
        ProjectCostList(0, 2) = "削除"
        ProjectCostList(0, 3) = "No"
        ProjectCostList(0, 4) = "名称"
        ProjectCostList(0, 5) = "規格"
        ProjectCostList(0, 6) = "単位"
        ProjectCostList(0, 7) = "数量"
        ProjectCostList(0, 8) = "単価"
        ProjectCostList(0, 9) = "代価計"
        ホーム.SystemSql.Parameters.Clear()
        ホーム.SystemSql.CommandText = ""
        ホーム.SystemSql.CommandText = "SELECT Count(*) FROM basis_costs WHERE deleted = 0 AND year = " & YearList.Text & " AND cstclss_code=" & CostClassCode
        Dim BasicCostsCount As Integer = ホーム.SystemSql.ExecuteScalar

        If BasicCostsCount > 21 Then
            ProjectCostList.Rows.Count = BasicCostsCount + 1
        Else
            ProjectCostList.Rows.Count = 22
        End If

        CostList.Text = CostClassName

        ProjectCostList.Rows.Count = BasicCostsCount + 1

        Dim Year As Integer
        'If ホーム.AdminChk = "True" Then
        ホーム.SystemSql.CommandText = "SELECT MAX(year) FROM years"
        Year = Integer.Parse(ホーム.SystemSql.ExecuteScalar)
        'ElseIf ホーム.AdminChk = "False" Then
        '    ホーム.Sql.CommandText = "SELECT ISNULL(contents,0) FROM controldata WHERE class_code=12"
        '    Year = Integer.Parse(ホーム.Sql.ExecuteScalar)
        '    If Year = 0 Then
        '        MsgBox("予算総括を登録して下さい。", MsgBoxStyle.Exclamation, "代価一覧")
        '        Exit Sub
        '    End If
        'End If

        Dim RowCount As Integer = 0

        ホーム.SystemSql.CommandText = "SELECT * FROM basis_costs WHERE cstclss_code=" & CostClassCode & " AND year=" & YearList.Text & "AND deleted = 0 ORDER BY bsscst_no ASC"
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
    End Sub

    Private Sub ProjectCostList_CellChecked(sender As Object, e As RowColEventArgs) Handles ProjectCostList.CellChecked
        If ProjectCostList(e.Row, 2) = True Then
            ProjectCostList.Rows(e.Row).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 230, 230)
        Else
            ProjectCostList.Rows(e.Row).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
        End If
    End Sub

    Private Sub CopyMenu_Click(sender As Object, e As EventArgs) Handles CopyMenu.Click
        Try

            SelectRow = ProjectCostList.Selection.TopRow
            If ProjectCostList(SelectRow, 1) = Nothing Then

            Else
                If SelectRow = 0 Then
                    MsgBox("行が選択されていません。", MsgBoxStyle.Exclamation, "代価表入力")
                Else
                    Dim CopyID As Integer = ProjectCostList(SelectRow, 1)
                    ホーム.Sql.Parameters.Clear()
                    ホーム.Sql.CommandText = ""
                    ホーム.Sql.CommandText = "SELECT Count(*) FROM project_costs WHERE cstclss_code=" & CostClassCode & " AND budget_no=" & ホーム.BudgetNo
                    Dim ProjectCostsCount As Integer = ホーム.Sql.ExecuteScalar
                    If ProjectCostsCount > 21 Then
                        ProjectCostList.Rows.Count += 1
                    End If
                    Dim PasteRow As Integer = ProjectCostsCount + 1
                    '代価一覧新規行作成
                    ホーム.Sql.CommandText = "SELECT MAX(prjctcst_no) FROM project_costs WHERE cstclss_code=" & CostClassCode & " AND budget_no=" & ホーム.BudgetNo
                    Dim PrjctNo As Integer = ホーム.Sql.ExecuteScalar
                    ProjectCostList(PasteRow, 3) = PrjctNo + 1
                    ProjectCostList(PasteRow, 4) = ProjectCostList(SelectRow, 4)
                    ProjectCostList(PasteRow, 5) = ProjectCostList(SelectRow, 5)
                    ProjectCostList(PasteRow, 6) = ProjectCostList(SelectRow, 6)
                    ProjectCostList(PasteRow, 7) = ProjectCostList(SelectRow, 7)
                    ProjectCostList(PasteRow, 8) = ProjectCostList(SelectRow, 8)
                    ProjectCostList(PasteRow, 9) = ProjectCostList(SelectRow, 9)

                    ホーム.Transaction = ホーム.Connection.BeginTransaction
                    ホーム.Sql.Transaction = ホーム.Transaction

                    '代価を新規登録
                    ホーム.Sql.CommandText = ""
                    ホーム.Sql.Parameters.Clear()
                    ホーム.Sql.Parameters.Add(New SqlParameter("@name", SqlDbType.NVarChar)).Value = ProjectCostList(PasteRow, 4)
                    If IsNothing(ProjectCostList(PasteRow, 5)) = True Or Not ProjectCostList(PasteRow, 5) <> "" Then
                        ホーム.Sql.Parameters.Add(New SqlParameter("@spec", SqlDbType.NVarChar)).Value = ""
                    Else
                        ホーム.Sql.Parameters.Add(New SqlParameter("@spec", SqlDbType.NVarChar)).Value = ProjectCostList(PasteRow, 5)
                    End If
                    ホーム.Sql.Parameters.Add(New SqlParameter("@unit", SqlDbType.NVarChar)).Value = ProjectCostList(PasteRow, 6)
                    ホーム.Sql.Parameters.Add(New SqlParameter("@quanity", SqlDbType.Decimal)).Value = ProjectCostList(PasteRow, 7)
                    ホーム.Sql.Parameters.Add(New SqlParameter("@costea", SqlDbType.Money)).Value = ProjectCostList(PasteRow, 8)

                    ホーム.Sql.CommandText = "SELECT * FROM project_costs WHERE prjctcst_id = " & CopyID & " AND cstclss_code=" & CostClassCode & " AND budget_no=" & ホーム.BudgetNo
                    Dim prjctcstread As SqlDataReader = ホーム.Sql.ExecuteReader
                    Dim Laborcostea As Int64
                    Dim materialcostea As Int64
                    Dim machinecostea As Int64
                    Dim subcntrctcostea As Int64
                    Dim expenscostea As Int64
                    While prjctcstread.Read
                        Laborcostea = prjctcstread.Item("prjctcst_laborea")
                        materialcostea = prjctcstread.Item("prjctcst_materialea")
                        machinecostea = prjctcstread.Item("prjctcst_machineea")
                        subcntrctcostea = prjctcstread.Item("prjctcst_subcntrctea")
                        expenscostea = prjctcstread.Item("prjctcst_expenseea")
                    End While
                    prjctcstread.Close()

                    If IsNothing(Laborcostea) = True Or IsDBNull(Laborcostea) = True Then
                        ホーム.Sql.Parameters.Add(New SqlParameter("@labor", SqlDbType.Money)).Value = 0
                    Else
                        ホーム.Sql.Parameters.Add(New SqlParameter("@labor", SqlDbType.Money)).Value = Laborcostea
                    End If
                    If IsNothing(materialcostea) = True Or IsDBNull(materialcostea) = True Then
                        ホーム.Sql.Parameters.Add(New SqlParameter("@material", SqlDbType.Money)).Value = 0
                    Else
                        ホーム.Sql.Parameters.Add(New SqlParameter("@material", SqlDbType.Money)).Value = materialcostea
                    End If
                    If IsNothing(machinecostea) = True Or IsDBNull(machinecostea) = True Then
                        ホーム.Sql.Parameters.Add(New SqlParameter("@machine", SqlDbType.Money)).Value = 0
                    Else
                        ホーム.Sql.Parameters.Add(New SqlParameter("@machine", SqlDbType.Money)).Value = machinecostea
                    End If
                    If IsNothing(subcntrctcostea) = True Or IsDBNull(subcntrctcostea) = True Then
                        ホーム.Sql.Parameters.Add(New SqlParameter("@subcntrct", SqlDbType.Money)).Value = 0
                    Else
                        ホーム.Sql.Parameters.Add(New SqlParameter("@subcntrct", SqlDbType.Money)).Value = subcntrctcostea
                    End If
                    If IsNothing(expenscostea) = True Or IsDBNull(expenscostea) = True Then
                        ホーム.Sql.Parameters.Add(New SqlParameter("@expense", SqlDbType.Money)).Value = 0
                    Else
                        ホーム.Sql.Parameters.Add(New SqlParameter("@expense", SqlDbType.Money)).Value = expenscostea
                    End If
                    ホーム.Sql.Parameters.Add(New SqlParameter("@budgetno", SqlDbType.SmallInt)).Value = ホーム.BudgetNo
                    ホーム.Sql.Parameters.Add(New SqlParameter("@cstclsscode", SqlDbType.SmallInt)).Value = CostClassCode
                    ホーム.Sql.Parameters.Add(New SqlParameter("@prjctcstno", SqlDbType.SmallInt)).Value = Integer.Parse(ProjectCostList(PasteRow, 3))
                    ホーム.Sql.CommandText = "INSERT INTO project_costs (budget_no,cstclss_code,prjctcst_no,prjctcst_name,prjctcst_spec,prjctcst_unit,
                                          prjctcst_quanity,prjctcst_costea,prjctcst_laborea,prjctcst_materialea,prjctcst_machineea,prjctcst_subcntrctea,prjctcst_expenseea)
                                            VALUES (@budgetno,@cstclsscode,@prjctcstno,@name,@spec,@unit,@quanity,@costea,@labor,@material,@machine,@subcntrct,@expense)"
                    ホーム.Sql.ExecuteNonQuery()

                    '新規行の工事代価IDを取得
                    ホーム.Sql.Parameters.Clear()
                    ホーム.Sql.CommandText = ""
                    ホーム.Sql.CommandText = "SELECT prjctcst_id FROM project_costs WHERE cstclss_code=" & CostClassCode & " AND prjctcst_no=" & Integer.Parse(ProjectCostList(PasteRow, 3)) & " AND budget_no=" & ホーム.BudgetNo
                    Dim CreateCopyID = ホーム.Sql.ExecuteScalar

                    '代価内訳を新規登録
                    Dim cstclsscode As Integer
                    Dim cstmstrID As Integer
                    Dim BDname As String = ""
                    Dim BDspec As String = ""
                    Dim BDunit As String = ""
                    Dim BDquanity As Decimal
                    Dim BDcostea As Int64
                    Dim BDlabor As Int64
                    Dim BDmaterial As Int64
                    Dim BDmachine As Int64
                    Dim BDsubcntrct As Int64
                    Dim BDexpense As Int64
                    Dim BDremarks As String = ""
                    ホーム.Sql.CommandText = "SELECT Count(*) FROM project_cost_breakdowns WHERE prjctcst_id=" & CopyID
                    Dim BreakDownCount As Integer = ホーム.Sql.ExecuteScalar
                    If BreakDownCount > 0 Then
                        For BDLoop As Integer = 1 To BreakDownCount
                            ホーム.Sql.CommandText = "SELECT * FROM project_cost_breakdowns WHERE prjctcst_id=" & CopyID & " AND prjctcst_bd_no = " & BDLoop
                            Dim BreakDownReader As SqlDataReader = ホーム.Sql.ExecuteReader
                            While BreakDownReader.Read
                                cstclsscode = BreakDownReader.Item("cstclss_code")
                                cstmstrID = BreakDownReader.Item("cstmstr_id")
                                BDname = BreakDownReader.Item("prjctcst_bd_name")
                                BDspec = BreakDownReader.Item("prjctcst_bd_spec")
                                BDunit = BreakDownReader.Item("prjctcst_bd_unit")
                                BDquanity = BreakDownReader.Item("prjctcst_bd_quanity")
                                BDcostea = BreakDownReader.Item("prjctcst_bd_costea")
                                BDlabor = BreakDownReader.Item("prjctcst_bd_labor")
                                BDmaterial = BreakDownReader.Item("prjctcst_bd_material")
                                BDmachine = BreakDownReader.Item("prjctcst_bd_machine")
                                BDsubcntrct = BreakDownReader.Item("prjctcst_bd_subcntrct")
                                BDexpense = BreakDownReader.Item("prjctcst_bd_expense")
                                BDremarks = BreakDownReader.Item("prjctcst_bd_remarks")
                            End While
                            BreakDownReader.Close()

                            ホーム.Sql.Parameters.Add(New SqlParameter("@cstclsscode", SqlDbType.SmallInt)).Value = cstclsscode
                            ホーム.Sql.Parameters.Add(New SqlParameter("@cstmstrid", SqlDbType.SmallInt)).Value = cstmstrID
                            ホーム.Sql.Parameters.Add(New SqlParameter("@bdno", SqlDbType.SmallInt)).Value = BDLoop
                            ホーム.Sql.Parameters.Add(New SqlParameter("@bdname", SqlDbType.NVarChar)).Value = BDname
                            If IsNothing(BDspec) = True Then
                                ホーム.Sql.Parameters.Add(New SqlParameter("@bdspec", SqlDbType.NVarChar)).Value = ""
                            Else
                                ホーム.Sql.Parameters.Add(New SqlParameter("@bdspec", SqlDbType.NVarChar)).Value = BDspec
                            End If
                            If IsNothing(BDunit) = True Then
                                ホーム.Sql.Parameters.Add(New SqlParameter("@bdunit", SqlDbType.NVarChar)).Value = ""
                            Else
                                ホーム.Sql.Parameters.Add(New SqlParameter("@bdunit", SqlDbType.NVarChar)).Value = BDunit
                            End If
                            If IsNothing(BDquanity) = True Then
                                ホーム.Sql.Parameters.Add(New SqlParameter("@bdquanity", SqlDbType.Decimal)).Value = 0
                            Else
                                ホーム.Sql.Parameters.Add(New SqlParameter("@bdquanity", SqlDbType.Decimal)).Value = BDquanity
                            End If
                            If IsNothing(BDcostea) = True Then
                                ホーム.Sql.Parameters.Add(New SqlParameter("@bdcostea", SqlDbType.Money)).Value = 0
                            Else
                                ホーム.Sql.Parameters.Add(New SqlParameter("@bdcostea", SqlDbType.Money)).Value = BDcostea
                            End If
                            If IsNothing(BDlabor) = True Then
                                ホーム.Sql.Parameters.Add(New SqlParameter("@bdlabor", SqlDbType.Money)).Value = 0
                            Else
                                ホーム.Sql.Parameters.Add(New SqlParameter("@bdlabor", SqlDbType.Money)).Value = BDlabor
                            End If
                            If IsNothing(BDmaterial) = True Then
                                ホーム.Sql.Parameters.Add(New SqlParameter("@bdmaterial", SqlDbType.Money)).Value = 0
                            Else
                                ホーム.Sql.Parameters.Add(New SqlParameter("@bdmaterial", SqlDbType.Money)).Value = BDmaterial
                            End If
                            If IsNothing(BDmachine) = True Then
                                ホーム.Sql.Parameters.Add(New SqlParameter("@bdmachine", SqlDbType.Money)).Value = 0
                            Else
                                ホーム.Sql.Parameters.Add(New SqlParameter("@bdmachine", SqlDbType.Money)).Value = BDmachine
                            End If
                            If IsNothing(BDsubcntrct) = True Then
                                ホーム.Sql.Parameters.Add(New SqlParameter("@bdsubcntrct", SqlDbType.Money)).Value = 0
                            Else
                                ホーム.Sql.Parameters.Add(New SqlParameter("@bdsubcntrct", SqlDbType.Money)).Value = BDsubcntrct
                            End If
                            If IsNothing(BDexpense) = True Then
                                ホーム.Sql.Parameters.Add(New SqlParameter("@bdexpense", SqlDbType.Money)).Value = 0
                            Else
                                ホーム.Sql.Parameters.Add(New SqlParameter("@bdexpense", SqlDbType.Money)).Value = BDexpense
                            End If
                            If IsNothing(BDremarks) = True Then
                                ホーム.Sql.Parameters.Add(New SqlParameter("@bdremarks", SqlDbType.NVarChar)).Value = ""
                            Else
                                ホーム.Sql.Parameters.Add(New SqlParameter("@bdremarks", SqlDbType.NVarChar)).Value = BDremarks
                            End If
                            ホーム.Sql.Parameters.Add(New SqlParameter("@prjctcstid", SqlDbType.SmallInt)).Value = CreateCopyID
                            ホーム.Sql.CommandText = "INSERT project_cost_breakdowns (prjctcst_id,cstclss_code,cstmstr_id,prjctcst_bd_no,prjctcst_bd_name,prjctcst_bd_spec
                                                                   ,prjctcst_bd_unit,prjctcst_bd_quanity,prjctcst_bd_costea,prjctcst_bd_labor,prjctcst_bd_material,prjctcst_bd_machine,
                                                                    prjctcst_bd_subcntrct,prjctcst_bd_expense,prjctcst_bd_remarks) 
                                                  VALUES (@prjctcstid,@cstclsscode,@cstmstrid,@bdno,@bdname,@bdspec,@bdunit,@bdquanity,@bdcostea,
                                                  @bdlabor,@bdmaterial,@bdmachine,@bdsubcntrct,@bdexpense,@bdremarks)"
                            ホーム.Sql.ExecuteNonQuery()

                        Next

                    End If

                    '登録されたprjctcst_idを代価一覧新規行にコピー
                    ProjectCostList(PasteRow, 1) = CreateCopyID

                    ホーム.Transaction.Commit()
                    MsgBox(" 登録完了", MsgBoxStyle.OkOnly, "代価表入力")
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