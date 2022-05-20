Imports C1.Win.C1FlexGrid
Imports System.Windows.Forms.Form
Imports C1.Win.C1Command
Imports System.Data.SqlClient
Public Class 費用マスタ一覧
    Public ParentFormName As String
    Public CostClassCode As Integer
    Public CostClassName As String
    Public CopyList(7) As String
    Private Sub 費用マスタ一覧_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ホーム.Sql.CommandText = "SELECT Count(*) FROM cost_masters WHERE cstclss_code=" & CostClassCode & " AND changecode<13"
            Dim CostMasterCount As Integer = ホーム.Sql.ExecuteScalar

            TableName.Text = CostClassName

            MasterContentsList.Rows.Count = CostMasterCount + 2

            Dim RowCount As Integer = 0
            ホーム.Sql.CommandText = "SELECT * FROM cost_masters WHERE cstclss_code=" & CostClassCode & " AND changecode<13 ORDER BY cstmstr_seq ASC"
            Dim CostMasterReader As SqlDataReader = ホーム.Sql.ExecuteReader
            While CostMasterReader.Read
                RowCount += 1
                MasterContentsList(RowCount, 1) = CostMasterReader.Item("cstmstr_id")
                MasterContentsList(RowCount, 2) = CostMasterReader.Item("cstmstr_seq")
                MasterContentsList(RowCount, 3) = CostMasterReader.Item("cstmstr_category")
                MasterContentsList(RowCount, 4) = CostMasterReader.Item("cstmstr_code")
                MasterContentsList(RowCount, 5) = CostMasterReader.Item("cstmstr_name")
                MasterContentsList(RowCount, 6) = CostMasterReader.Item("cstmstr_spec")
                MasterContentsList(RowCount, 7) = CostMasterReader.Item("cstmstr_unit")
                MasterContentsList(RowCount, 8) = CostMasterReader.Item("cstmstr_costea")
            End While
            CostMasterReader.Close()

            If ParentFormName = "明細書" Or ParentFormName = "代価表" Then
                MasterContentsList.Cols(9).Visible = False
                MasterContentsList.Cols(10).Visible = False
                MasterContentsList.AllowEditing = False
                Entry.Visible = False
                MasterContentsList.SelectionMode = SelectionModeEnum.Row
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

    Private Sub 費用マスタ一覧_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
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

    Private Sub SearchName_Load(sender As Object, e As EventArgs) Handles SearchName.Load
        SearchName.SetC1FlexGridSearchPanel(MasterContentsList, SearchName)
    End Sub

    Private Sub MasterContentsList_DoubleClick(sender As Object, e As EventArgs) Handles MasterContentsList.DoubleClick

        Try
            ホーム.ItemSelect = "true"
            Dim Row As Integer = MasterContentsList.Selection.TopRow
            If ParentFormName = "明細書" Then
                ホーム.Modified = "True"
                明細書入力.DetailsList(明細書入力.SelectRow, 9) = MasterContentsList(Row, 1)
                明細書入力.DetailsList(明細書入力.SelectRow, 8) = CostClassCode
                明細書入力.DetailsList(明細書入力.SelectRow, 3) = 明細書入力.SelectRow / 3
                明細書入力.DetailsList(明細書入力.SelectRow, 4) = MasterContentsList(Row, 5)
                明細書入力.DetailsList(明細書入力.SelectRow + 1, 4) = MasterContentsList(Row, 6)
                明細書入力.DetailsList(明細書入力.SelectRow + 2, 5) = MasterContentsList(Row, 7)
                明細書入力.DetailsList(明細書入力.SelectRow + 1, 6) = MasterContentsList(Row, 8)
                If IsNothing(明細書入力.DetailsList(明細書入力.SelectRow, 6)) = False Then
                    明細書入力.DetailsList(明細書入力.SelectRow + 2, 6) = Math.Floor((明細書入力.DetailsList(明細書入力.SelectRow, 6) * MasterContentsList(Row, 8)))
                End If
                If CostClassCode = 1 Then
                    明細書入力.CategoryList(明細書入力.SelectRow + 1, 2) = MasterContentsList(Row, 8)
                    明細書入力.CategoryList(明細書入力.SelectRow + 2, 2) = 明細書入力.DetailsList(明細書入力.SelectRow + 2, 6)
                    明細書入力.CategoryList(明細書入力.SelectRow + 1, 3) = 0
                    明細書入力.CategoryList(明細書入力.SelectRow + 2, 3) = 0
                    明細書入力.CategoryList(明細書入力.SelectRow + 1, 4) = 0
                    明細書入力.CategoryList(明細書入力.SelectRow + 2, 4) = 0
                    明細書入力.CategoryList(明細書入力.SelectRow + 1, 5) = 0
                    明細書入力.CategoryList(明細書入力.SelectRow + 2, 5) = 0
                    明細書入力.CategoryList(明細書入力.SelectRow + 1, 6) = 0
                    明細書入力.CategoryList(明細書入力.SelectRow + 2, 6) = 0
                ElseIf CostClassCode = 2 Or CostClassCode = 6 Or CostClassCode = 7 Then
                    明細書入力.CategoryList(明細書入力.SelectRow + 1, 3) = MasterContentsList(Row, 8)
                    明細書入力.CategoryList(明細書入力.SelectRow + 2, 3) = 明細書入力.DetailsList(明細書入力.SelectRow + 2, 6)
                    明細書入力.CategoryList(明細書入力.SelectRow + 1, 2) = 0
                    明細書入力.CategoryList(明細書入力.SelectRow + 2, 2) = 0
                    明細書入力.CategoryList(明細書入力.SelectRow + 1, 4) = 0
                    明細書入力.CategoryList(明細書入力.SelectRow + 2, 4) = 0
                    明細書入力.CategoryList(明細書入力.SelectRow + 1, 5) = 0
                    明細書入力.CategoryList(明細書入力.SelectRow + 2, 5) = 0
                    明細書入力.CategoryList(明細書入力.SelectRow + 1, 6) = 0
                    明細書入力.CategoryList(明細書入力.SelectRow + 2, 6) = 0
                ElseIf CostClassCode = 3 Then
                    明細書入力.CategoryList(明細書入力.SelectRow + 1, 4) = MasterContentsList(Row, 8)
                    明細書入力.CategoryList(明細書入力.SelectRow + 2, 4) = 明細書入力.DetailsList(明細書入力.SelectRow + 2, 6)
                    明細書入力.CategoryList(明細書入力.SelectRow + 1, 2) = 0
                    明細書入力.CategoryList(明細書入力.SelectRow + 2, 2) = 0
                    明細書入力.CategoryList(明細書入力.SelectRow + 1, 3) = 0
                    明細書入力.CategoryList(明細書入力.SelectRow + 2, 3) = 0
                    明細書入力.CategoryList(明細書入力.SelectRow + 1, 5) = 0
                    明細書入力.CategoryList(明細書入力.SelectRow + 2, 5) = 0
                    明細書入力.CategoryList(明細書入力.SelectRow + 1, 6) = 0
                    明細書入力.CategoryList(明細書入力.SelectRow + 2, 6) = 0
                ElseIf CostClassCode = 4 Then
                    明細書入力.CategoryList(明細書入力.SelectRow + 1, 5) = MasterContentsList(Row, 8)
                    明細書入力.CategoryList(明細書入力.SelectRow + 2, 5) = 明細書入力.DetailsList(明細書入力.SelectRow + 2, 6)
                    明細書入力.CategoryList(明細書入力.SelectRow + 1, 2) = 0
                    明細書入力.CategoryList(明細書入力.SelectRow + 2, 2) = 0
                    明細書入力.CategoryList(明細書入力.SelectRow + 1, 3) = 0
                    明細書入力.CategoryList(明細書入力.SelectRow + 2, 3) = 0
                    明細書入力.CategoryList(明細書入力.SelectRow + 1, 4) = 0
                    明細書入力.CategoryList(明細書入力.SelectRow + 2, 4) = 0
                    明細書入力.CategoryList(明細書入力.SelectRow + 1, 6) = 0
                    明細書入力.CategoryList(明細書入力.SelectRow + 2, 6) = 0
                Else
                    明細書入力.CategoryList(明細書入力.SelectRow + 1, 6) = MasterContentsList(Row, 8)
                    明細書入力.CategoryList(明細書入力.SelectRow + 2, 6) = 明細書入力.DetailsList(明細書入力.SelectRow + 2, 6)
                    明細書入力.CategoryList(明細書入力.SelectRow + 1, 2) = 0
                    明細書入力.CategoryList(明細書入力.SelectRow + 2, 2) = 0
                    明細書入力.CategoryList(明細書入力.SelectRow + 1, 3) = 0
                    明細書入力.CategoryList(明細書入力.SelectRow + 2, 3) = 0
                    明細書入力.CategoryList(明細書入力.SelectRow + 1, 4) = 0
                    明細書入力.CategoryList(明細書入力.SelectRow + 2, 4) = 0
                    明細書入力.CategoryList(明細書入力.SelectRow + 1, 5) = 0
                    明細書入力.CategoryList(明細書入力.SelectRow + 2, 5) = 0
                End If

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

                明細書入力.DetailsList.Focus()
                明細書入力.DetailsList.Select(明細書入力.SelectRow, 6)

                Me.Close()

            ElseIf ParentFormName = "代価表" Then
                ホーム.Modified = "True"

                Dim Count As Integer = ホーム.ProjectCostSelectRow.Count
                Dim ProjectCostRow As Integer = ホーム.ProjectCostSelectRow(Count - 1)
                Dim ProjectCostList As C1FlexGrid = ホーム.PrjctCstList(Count - 1)

                ProjectCostList(ProjectCostRow, 9) = MasterContentsList(Row, 1)
                ProjectCostList(ProjectCostRow, 8) = CostClassCode
                ProjectCostList(ProjectCostRow, 3) = ProjectCostRow / 3
                ProjectCostList(ProjectCostRow, 4) = MasterContentsList(Row, 5)
                ProjectCostList(ProjectCostRow + 1, 4) = MasterContentsList(Row, 6)
                ProjectCostList(ProjectCostRow + 2, 5) = MasterContentsList(Row, 7)
                ProjectCostList(ProjectCostRow + 1, 6) = MasterContentsList(Row, 8)
                If IsNothing(ProjectCostList(ProjectCostRow, 6)) = False Then
                    ProjectCostList(ProjectCostRow + 2, 6) = Math.Floor((ProjectCostList(ProjectCostRow, 6) * MasterContentsList(Row, 8)))
                End If
                If CostClassCode = 1 Then
                    ProjectCostList(ProjectCostRow + 1, 10) = MasterContentsList(Row, 8)
                    ProjectCostList(ProjectCostRow + 2, 10) = ProjectCostList(ProjectCostRow + 2, 6)
                    ProjectCostList(ProjectCostRow + 1, 11) = 0
                    ProjectCostList(ProjectCostRow + 2, 11) = 0
                    ProjectCostList(ProjectCostRow + 1, 12) = 0
                    ProjectCostList(ProjectCostRow + 2, 12) = 0
                    ProjectCostList(ProjectCostRow + 1, 13) = 0
                    ProjectCostList(ProjectCostRow + 2, 13) = 0
                    ProjectCostList(ProjectCostRow + 1, 14) = 0
                    ProjectCostList(ProjectCostRow + 2, 14) = 0
                ElseIf CostClassCode = 2 Or CostClassCode = 6 Or CostClassCode = 7 Then
                    ProjectCostList(ProjectCostRow + 1, 11) = MasterContentsList(Row, 8)
                    ProjectCostList(ProjectCostRow + 2, 11) = ProjectCostList(ProjectCostRow + 2, 6)
                    ProjectCostList(ProjectCostRow + 1, 10) = 0
                    ProjectCostList(ProjectCostRow + 2, 10) = 0
                    ProjectCostList(ProjectCostRow + 1, 12) = 0
                    ProjectCostList(ProjectCostRow + 2, 12) = 0
                    ProjectCostList(ProjectCostRow + 1, 13) = 0
                    ProjectCostList(ProjectCostRow + 2, 13) = 0
                    ProjectCostList(ProjectCostRow + 1, 14) = 0
                    ProjectCostList(ProjectCostRow + 2, 14) = 0
                ElseIf CostClassCode = 3 Then
                    ProjectCostList(ProjectCostRow + 1, 12) = MasterContentsList(Row, 8)
                    ProjectCostList(ProjectCostRow + 2, 12) = ProjectCostList(ProjectCostRow + 2, 6)
                    ProjectCostList(ProjectCostRow + 1, 10) = 0
                    ProjectCostList(ProjectCostRow + 2, 10) = 0
                    ProjectCostList(ProjectCostRow + 1, 11) = 0
                    ProjectCostList(ProjectCostRow + 2, 11) = 0
                    ProjectCostList(ProjectCostRow + 1, 13) = 0
                    ProjectCostList(ProjectCostRow + 2, 13) = 0
                    ProjectCostList(ProjectCostRow + 1, 14) = 0
                    ProjectCostList(ProjectCostRow + 2, 14) = 0
                ElseIf CostClassCode = 4 Then
                    ProjectCostList(ProjectCostRow + 1, 13) = MasterContentsList(Row, 8)
                    ProjectCostList(ProjectCostRow + 2, 13) = ProjectCostList(ProjectCostRow + 2, 6)
                    ProjectCostList(ProjectCostRow + 1, 10) = 0
                    ProjectCostList(ProjectCostRow + 2, 10) = 0
                    ProjectCostList(ProjectCostRow + 1, 11) = 0
                    ProjectCostList(ProjectCostRow + 2, 11) = 0
                    ProjectCostList(ProjectCostRow + 1, 12) = 0
                    ProjectCostList(ProjectCostRow + 2, 12) = 0
                    ProjectCostList(ProjectCostRow + 1, 14) = 0
                    ProjectCostList(ProjectCostRow + 2, 14) = 0
                Else
                    ProjectCostList(ProjectCostRow + 1, 14) = MasterContentsList(Row, 8)
                    ProjectCostList(ProjectCostRow + 2, 14) = ProjectCostList(ProjectCostRow + 2, 6)
                    ProjectCostList(ProjectCostRow + 1, 10) = 0
                    ProjectCostList(ProjectCostRow + 2, 10) = 0
                    ProjectCostList(ProjectCostRow + 1, 11) = 0
                    ProjectCostList(ProjectCostRow + 2, 11) = 0
                    ProjectCostList(ProjectCostRow + 1, 12) = 0
                    ProjectCostList(ProjectCostRow + 2, 12) = 0
                    ProjectCostList(ProjectCostRow + 1, 13) = 0
                    ProjectCostList(ProjectCostRow + 2, 13) = 0
                End If

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

            ElseIf ParentFormName = "現場経費" Then
                Dim name As String
                Dim spec As String
                Dim unit As String
                Dim costea As Int64
                name = MasterContentsList(Row, 5)
                spec = MasterContentsList(Row, 6)
                unit = MasterContentsList(Row, 7)
                costea = MasterContentsList(Row, 8)

                現場経費内訳.DetailsList(現場経費内訳.SelectRow, 4) = name
                現場経費内訳.DetailsList(現場経費内訳.SelectRow, 5) = spec
                現場経費内訳.DetailsList(現場経費内訳.SelectRow, 6) = unit
                現場経費内訳.DetailsList(現場経費内訳.SelectRow, 8) = costea

                現場経費内訳.DetailsList.StartEditing(現場経費内訳.SelectRow, 7)
                Me.Close()
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


            Dim ErrorRow As String = ""
            Dim ErrorCount As Integer = 0
            For RowCount As Integer = 1 To MasterContentsList.Rows.Count - 1
                Dim Name As String = MasterContentsList(RowCount, 5)
                If Not RowCount = MasterContentsList.Rows.Count - 1 Then
                    If IsNothing(Name) = True AndAlso IsNothing(MasterContentsList(RowCount, 9)) = False Then
                        If Name.Length = 0 Then
                            ErrorCount += 1
                            MasterContentsList.Rows(RowCount).StyleFixedNew.BackColor = Color.FromArgb(255, 192, 192)
                        End If
                    End If
                Else
                    If IsNothing(Name) = True AndAlso IsNothing(MasterContentsList(RowCount, 3)) = False Then
                        ErrorCount += 1
                        MasterContentsList.Rows(RowCount).StyleFixedNew.BackColor = Color.FromArgb(255, 192, 192)
                    End If
                End If
            Next

            If ErrorCount >= 1 Then
                MsgBox("名称が入力されていない行があります。", MsgBoxStyle.Exclamation, "費用マスタ一覧")
                Exit Sub
            End If

            For RowCount As Integer = 1 To MasterContentsList.Rows.Count - 1
                ホーム.Sql.CommandText = ""
                ホーム.Sql.Parameters.Clear()
                If IsNothing(MasterContentsList(RowCount, 1)) = False Then

                    ホーム.Sql.Parameters.Add(New SqlParameter("@cstclsscode", SqlDbType.SmallInt)).Value = CostClassCode
                    ホーム.Sql.Parameters.Add(New SqlParameter("@name", SqlDbType.NVarChar)).Value = MasterContentsList(RowCount, 5)
                    ホーム.Sql.Parameters.Add(New SqlParameter("@cstmstr_seq", SqlDbType.SmallInt)).Value = MasterContentsList(RowCount, 2)
                    If IsNothing(MasterContentsList(RowCount, 3)) = True Then
                        ホーム.Sql.Parameters.Add(New SqlParameter("@cstmstr_category", SqlDbType.NVarChar)).Value = ""
                    Else
                        ホーム.Sql.Parameters.Add(New SqlParameter("@cstmstr_category", SqlDbType.NVarChar)).Value = MasterContentsList(RowCount, 3)
                    End If
                    If IsNothing(MasterContentsList(RowCount, 4)) = True Then
                        ホーム.Sql.Parameters.Add(New SqlParameter("@cstmstr_code", SqlDbType.SmallInt)).Value = 0
                    Else
                        ホーム.Sql.Parameters.Add(New SqlParameter("@cstmstr_code", SqlDbType.SmallInt)).Value = MasterContentsList(RowCount, 4)
                    End If
                    If MasterContentsList(RowCount, 1) = 0 Then
                        ホーム.Sql.Parameters.Add(New SqlParameter("@change_code", SqlDbType.SmallInt)).Value = 11
                    ElseIf IsNothing(MasterContentsList(RowCount, 10)) = False Then
                        ホーム.Sql.Parameters.Add(New SqlParameter("@change_code", SqlDbType.SmallInt)).Value = 12

                    ElseIf MasterContentsList(RowCount, 9) = "True" Or IsNothing(MasterContentsList(RowCount, 9)) = False Then
                        ホーム.Sql.Parameters.Add(New SqlParameter("@change_code", SqlDbType.SmallInt)).Value = 13
                    Else
                        ホーム.Sql.Parameters.Add(New SqlParameter("@change_code", SqlDbType.SmallInt)).Value = 0
                    End If

                    If IsNothing(MasterContentsList(RowCount, 6)) = True Then
                        ホーム.Sql.Parameters.Add(New SqlParameter("@spec", SqlDbType.NVarChar)).Value = ""
                    Else
                        ホーム.Sql.Parameters.Add(New SqlParameter("@spec", SqlDbType.NVarChar)).Value = MasterContentsList(RowCount, 6)
                    End If
                    If IsNothing(MasterContentsList(RowCount, 7)) = True Then
                        ホーム.Sql.Parameters.Add(New SqlParameter("@unit", SqlDbType.NVarChar)).Value = ""
                    Else
                        ホーム.Sql.Parameters.Add(New SqlParameter("@unit", SqlDbType.NVarChar)).Value = MasterContentsList(RowCount, 7)
                    End If

                    If IsNothing(MasterContentsList(RowCount, 8)) = True Then
                        ホーム.Sql.Parameters.Add(New SqlParameter("@costea", SqlDbType.Money)).Value = 0
                    Else
                        ホーム.Sql.Parameters.Add(New SqlParameter("@costea", SqlDbType.Money)).Value = MasterContentsList(RowCount, 8)
                    End If


                    If MasterContentsList(RowCount, 1) = 0 Then
                        ホーム.Sql.CommandText = "INSERT INTO cost_masters (cstclss_code,cstmstr_category,cstmstr_code,cstmstr_name,cstmstr_spec
                                                                   ,cstmstr_unit,cstmstr_costea,changecode,cstmstr_seq) 
                                                  VALUES (@cstclsscode,@cstmstr_category,@cstmstr_code,@name,@spec,@unit,@costea,@change_code,@cstmstr_seq)"
                    Else
                        ホーム.Sql.CommandText = "UPDATE cost_masters SET cstmstr_category=@cstmstr_category,cstmstr_code=@cstmstr_code,cstmstr_name=@name,cstmstr_spec=@spec,
                                                cstmstr_unit=@unit,cstmstr_costea=@costea,changecode=@change_code,cstmstr_seq=@cstmstr_seq WHERE cstmstr_id=" & MasterContentsList(RowCount, 1)
                    End If
                    ホーム.Sql.ExecuteNonQuery()
                End If
            Next

            ホーム.Modified = "False"


            MsgBox("登録完了", MsgBoxStyle.OkOnly, "費用マスタ一覧")
            Me.Close()

            ホーム.Sql.CommandText = ""
            ホーム.Sql.Parameters.Clear()

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub Insert_Click(sender As Object, e As EventArgs) Handles InsertMenu.Click
        Try
            ホーム.Modified = "True"

            Dim SelectRow As Integer = MasterContentsList.Selection.TopRow

            MasterContentsList.Rows.Insert(SelectRow)
            MasterContentsList(SelectRow, 1) = 0

            For RowCount As Integer = 1 To MasterContentsList.Rows.Count - 1
                MasterContentsList(RowCount, 2) = RowCount

            Next

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub Copy_Click(sender As Object, e As EventArgs) Handles CopyMenu.Click
        Try
            Dim SelectRow As Integer = MasterContentsList.Selection.TopRow
            Dim SelectRange As CellRange = MasterContentsList.GetCellRange(MasterContentsList.Selection.TopRow, 2)
            SelectRange.StyleNew.BackColor = Color.FromArgb(105, 189, 131)
            CopyList(0) = MasterContentsList(SelectRow, 1)
            CopyList(1) = MasterContentsList(SelectRow, 2)
            CopyList(2) = MasterContentsList(SelectRow, 3)
            CopyList(3) = MasterContentsList(SelectRow, 4)
            CopyList(4) = MasterContentsList(SelectRow, 5)
            CopyList(5) = MasterContentsList(SelectRow, 6)
            CopyList(6) = MasterContentsList(SelectRow, 7)
            CopyList(7) = MasterContentsList(SelectRow, 8)

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try

    End Sub

    Private Sub Pasting_Click(sender As Object, e As EventArgs) Handles PastingMenu.Click
        Try
            Dim SelectRow As Integer = MasterContentsList.Selection.TopRow
            ホーム.Modified = "True"


            If IsNothing(CopyList(1)) = True Then
                MsgBox("行がコピーされていません。", MsgBoxStyle.Exclamation, "費用マスタ一覧")
                Exit Sub
            End If
            MasterContentsList.Rows.Insert(SelectRow)

            MasterContentsList(SelectRow, 1) = 0
            MasterContentsList(SelectRow, 2) = CopyList(1)
            MasterContentsList(SelectRow, 3) = CopyList(2)
            MasterContentsList(SelectRow, 4) = CopyList(3)
            MasterContentsList(SelectRow, 5) = CopyList(4)
            MasterContentsList(SelectRow, 6) = CopyList(5)
            MasterContentsList(SelectRow, 7) = CopyList(6)
            MasterContentsList(SelectRow, 8) = CopyList(7)

        For RowCount As Integer = 1 To MasterContentsList.Rows.Count - 1
            MasterContentsList(RowCount, 2) = RowCount
            MasterContentsList.Rows(RowCount).StyleNew.BackColor = Color.White
        Next

        Catch ex As Exception
        ホーム.ErrorMessage = ex.Message
        ホーム.StackTrace = ex.StackTrace
        エラー.Show()
        Exit Sub
        End Try
    End Sub

    Private Sub Cut_Click(sender As Object, e As EventArgs) Handles CutMenu.Click
        Try
            ホーム.Modified = "True"

            Dim SelectRow As Integer = MasterContentsList.Selection.TopRow

            CopyList(0) = MasterContentsList(SelectRow, 1)
            CopyList(1) = MasterContentsList(SelectRow, 2)
            CopyList(2) = MasterContentsList(SelectRow, 3)
            CopyList(3) = MasterContentsList(SelectRow, 4)
            CopyList(4) = MasterContentsList(SelectRow, 5)
            CopyList(5) = MasterContentsList(SelectRow, 6)
            CopyList(6) = MasterContentsList(SelectRow, 7)
            CopyList(7) = MasterContentsList(SelectRow, 8)

            MasterContentsList.Rows.RemoveRange(SelectRow, 1)


            For RowCount As Integer = 1 To MasterContentsList.Rows.Count - 1
                MasterContentsList(RowCount, 2) = RowCount

            Next

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub
    Private Sub MasterContentsList_AfterEdit(sender As Object, e As RowColEventArgs) Handles MasterContentsList.AfterEdit
        Try
            Dim SetImageRow As Integer = e.Row
            'MasterContentsList.SetCellImage(SetImageRow, 10, Image.FromFile(Application.StartupPath & "\Resources\Edit_source.png"))
            If IsNothing(MasterContentsList(SetImageRow, 2)) = True Then
                MasterContentsList(SetImageRow, 1) = 0
                MasterContentsList(SetImageRow, 2) = MasterContentsList(SetImageRow - 1, 2) + 1
            End If

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
        ホーム.StackTrace = ex.StackTrace
        エラー.Show()
        Exit Sub
        End Try
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Dim CancelClick As String = ""

        Dim CancelClickLoad As New CancelClick(Me)
        CancelClick = CancelClickLoad.ModifyCheck
    End Sub
End Class