Imports C1.Win.C1FlexGrid
Imports System.Windows.Forms.Form
Imports C1.Win.C1Command
Imports System.Data.SqlClient
Imports C1.Win.C1Input
Imports System.Windows.Input.Keyboard
Public Class 代価表入力
    Public SelectRow As Integer = 1
    Public CopyList(10) As String
    Public CostID As Integer
    Public ClassCode As Integer = 0
    Public Command As String
    Dim Key As String

    Private Sub Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
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

            BreakDownList.MergedRanges.Add(0, 0, 2, 0)
            BreakDownList.MergedRanges.Add(0, 2, 2, 2)
            BreakDownList.MergedRanges.Add(0, 3, 2, 3)
            BreakDownList.MergedRanges.Add(0, 4, 0, 5)
            BreakDownList.MergedRanges.Add(1, 4, 1, 5)
            BreakDownList.MergedRanges.Add(0, 7, 2, 7)
            BreakDownList.MergedRanges.Add(0, 8, 2, 8)
            BreakDownList.MergedRanges.Add(0, 9, 2, 9)
            BreakDownList.MergedRanges.Add(0, 10, 2, 10)
            BreakDownList.MergedRanges.Add(0, 11, 2, 11)
            BreakDownList.MergedRanges.Add(0, 12, 2, 12)
            BreakDownList.MergedRanges.Add(0, 13, 2, 13)
            BreakDownList.MergedRanges.Add(0, 14, 2, 14)

            Me.Anchor = AnchorStyles.Top
            Me.Anchor = AnchorStyles.Left
            Me.Anchor = AnchorStyles.Bottom

            If Me.FormBorderStyle = FormBorderStyle.None Then
                Dim FormCount As Integer = ホーム.ProjectCostForm.Count
                'BeforeSelectRow = ホーム.ProjectCostSelectRow(FormCount - 1)
                CostID = ホーム.ProjectCostID(FormCount - 1)
                ClassCode = ホーム.PrjctCstClassCode(FormCount - 1)

            End If

            Dim CopyCostID As Integer = 0
            Dim CopyClassCode As Integer = 0
            If 作成代価選択.Visible = True Then

                If 明細書入力.Visible = True Then
                    If 明細書入力.DetailsList(明細書入力.SelectRow, 4) <> "" Then
                        CostName.Text = 明細書入力.DetailsList(明細書入力.SelectRow, 4)
                        CostSpec.Text = 明細書入力.DetailsList(明細書入力.SelectRow + 1, 4)
                        CostUnit.Text = 明細書入力.DetailsList(明細書入力.SelectRow + 2, 5)
                        CostQuanity.Text = 明細書入力.DetailsList(明細書入力.SelectRow, 6)
                    End If
                Else

                    Dim FormCount As Integer = ホーム.ProjectCostForm.Count

                    Dim ProjectCostRow As Integer = ホーム.ProjectCostSelectRow(FormCount - 1)
                    Dim ProjectCostList As C1FlexGrid = ホーム.PrjctCstList(FormCount - 1)

                    If ProjectCostList(ProjectCostRow, 4) <> "" Then
                        CostName.Text = ProjectCostList(ProjectCostRow, 4)
                        CostSpec.Text = ProjectCostList(ProjectCostRow + 1, 4)
                        CostUnit.Text = ProjectCostList(ProjectCostRow + 2, 5)
                        CostQuanity.Text = ProjectCostList(ProjectCostRow, 6)
                    End If
                End If

                    If 作成代価選択.Text = "コピー代価選択" Then

                    CopyCostID = 作成代価選択.CopyCostID
                    CopyClassCode = 作成代価選択.CopyClassCode
                End If

            End If


            If CostQuanity.Text <> "" Then

                BreakDownList.AllowEditing = True
                BreakDownList.ContextMenuStrip.Visible = True
            Else

                BreakDownList.AllowEditing = False
                BreakDownList.ContextMenuStrip.Visible = False
            End If


            If Me.FormBorderStyle = FormBorderStyle.Sizable Then
                Me.TopMost = True
                CostNo.Enabled = False
                CostName.Enabled = False
                CostSpec.Enabled = False
                CostQuanity.Enabled = False
                CostUnit.Enabled = False
                CostUnitPrice.Enabled = False
                CostCostea.Enabled = False
                BreakDownList.AllowEditing = False
                ItemSelect.Visible = False
                CostCreation.Visible = False
                CostModify.Visible = False
                CostCopy.Visible = False
                Reference.Visible = False
                Entry.Visible = False
                BreakDownList.ContextMenuStrip.Visible = False
            End If

            LaborCostea.Text = 0
            MaterialCostea.Text = 0
            MachineCostea.Text = 0
            SubcntrctCostea.Text = 0
            ExpensCostea.Text = 0
            CostUnitPrice.Text = 0
            CostUnitPrice.Value = 0

            ホーム.Sql.Parameters.Clear()
            ホーム.Sql.CommandText = "SELECT cstclss_name FROM cost_classes WHERE cstclss_code=" & ClassCode
            Dim ClassName As String = ホーム.Sql.ExecuteScalar

            If CostID > 0 Or CopyCostID > 0 Then
                Dim CreateCostID As Integer = CostID
                If 作成代価選択.Visible = True AndAlso 作成代価選択.Text = "コピー代価選択" Then
                    CreateCostID = CopyCostID
                End If

                ホーム.Sql.CommandText = "SELECT * FROM project_costs WHERE prjctcst_id=" & CreateCostID
                Dim ProjectCostsReader As SqlDataReader = ホーム.Sql.ExecuteReader
                While ProjectCostsReader.Read
                    Dim No As String = ProjectCostsReader.Item("prjctcst_no")
                    If No.Length = 1 Then
                        No = "0000" & No
                    ElseIf No.Length = 2 Then
                        No = "000" & No
                    ElseIf No.Length = 3 Then
                        No = "00" & No
                    ElseIf No.Length = 4 Then
                        No = "0" & No
                    End If
                    CostNo.Value = "第" & ClassName.Last & "-" & No & "号"
                    CostName.Text = ProjectCostsReader.Item("prjctcst_name")
                    CostSpec.Text = ProjectCostsReader.Item("prjctcst_spec")
                    CostUnit.Text = ProjectCostsReader.Item("prjctcst_unit")
                    CostQuanity.Text = ProjectCostsReader.Item("prjctcst_quanity")
                    CostCostea.Text = ProjectCostsReader.Item("prjctcst_costea")
                    BreakDownList.AllowEditing = True
                    Dim labor As Int64 = ProjectCostsReader.Item("prjctcst_laborea")
                    LaborCostea.Value = labor
                    Dim material As Int64 = ProjectCostsReader.Item("prjctcst_materialea")
                    MaterialCostea.Value = material
                    Dim machine As Int64 = ProjectCostsReader.Item("prjctcst_machineea")
                    MachineCostea.Value = machine
                    Dim subcntrct As Int64 = ProjectCostsReader.Item("prjctcst_subcntrctea")
                    SubcntrctCostea.Value = subcntrct
                    Dim expense As Int64 = ProjectCostsReader.Item("prjctcst_expenseea")
                    ExpensCostea.Value = expense
                End While
                ProjectCostsReader.Close()


                If 作成代価選択.Visible = True AndAlso 作成代価選択.Text = "コピー代価選択" Then
                    ホーム.Sql.CommandText = "SELECT Count(*) FROM project_costs WHERE cstclss_code=" & ClassCode
                    Dim CostCount As Integer = ホーム.Sql.ExecuteScalar

                    Dim MaxNo As Integer = 0

                    If CostCount > 0 Then
                        ホーム.Sql.CommandText = "SELECT MAX(prjctcst_no) FROM project_costs WHERE cstclss_code=" & ClassCode
                        MaxNo = ホーム.Sql.ExecuteScalar
                    End If

                    Dim No As String = MaxNo + 1
                    If No.Length = 1 Then
                        No = "0000" & No
                    ElseIf No.Length = 2 Then
                        No = "000" & No
                    ElseIf No.Length = 3 Then
                        No = "00" & No
                    ElseIf No.Length = 4 Then
                        No = "0" & No
                    End If
                    CostNo.Value = "第" & ClassName.Last & "-" & No & "号"
                End If


                ホーム.Sql.CommandText = "SELECT amount FROM projectcst_bd_total WHERE prjctcst_id=" & CreateCostID
                CostUnitPrice.Value = ホーム.Sql.ExecuteScalar

                ホーム.Sql.CommandText = "SELECT Count(*) FROM project_cost_breakdowns WHERE prjctcst_id=" & CreateCostID
                Dim BreakDownCount As Integer = ホーム.Sql.ExecuteScalar

                If BreakDownCount > 5 Then
                    BreakDownList.Rows.Count = (BreakDownCount * 3) + 6
                Else
                    BreakDownList.Rows.Count = 21
                End If

                Dim RowCount As Integer = 0
                Dim RowNo As Integer = 0

                Dim OutsrcngSql As New SqlCommand
                OutsrcngSql.Connection = ホーム.Connection

                If BreakDownCount > 0 Then

                    ホーム.Sql.CommandText = "SELECT * FROM project_cost_breakdowns WHERE prjctcst_id=" & CreateCostID & " ORDER BY prjctcst_bd_no ASC "
                    Dim BreakDownReader As SqlDataReader = ホーム.Sql.ExecuteReader
                    While BreakDownReader.Read
                        RowCount += 1
                        RowNo += 1
                        If 作成代価選択.Visible = True AndAlso 作成代価選択.Text = "コピー代価選択" Then
                            BreakDownList(RowCount * 3, 1) = 0
                        Else
                            BreakDownList(RowCount * 3, 1) = BreakDownReader.Item("prjctcst_bd_id")
                        End If
                        BreakDownList(RowCount * 3, 9) = BreakDownReader.Item("cstmstr_id")
                        BreakDownList(RowCount * 3, 8) = BreakDownReader.Item("cstclss_code")
                        BreakDownList(RowCount * 3, 3) = BreakDownReader.Item("prjctcst_bd_no")
                        BreakDownList(RowCount * 3, 4) = BreakDownReader.Item("prjctcst_bd_name")

                        BreakDownList((RowCount * 3) + 1, 4) = BreakDownReader.Item("prjctcst_bd_spec")
                        BreakDownList((RowCount * 3) + 2, 4) = BreakDownReader.Item("prjctcst_bd_remarks")
                        BreakDownList((RowCount * 3) + 2, 5) = BreakDownReader.Item("prjctcst_bd_unit")
                        BreakDownList(RowCount * 3, 6) = BreakDownReader.Item("prjctcst_bd_quanity")
                        Dim Quanity As CellRange = BreakDownList.GetCellRange(RowCount * 3, 6)
                        Quanity.StyleNew.Format = "N1"
                        BreakDownList((RowCount * 3) + 1, 6) = BreakDownReader.Item("prjctcst_bd_costea")
                        Dim Costea As CellRange = BreakDownList.GetCellRange(RowCount * 3 + 1, 6)
                        Costea.StyleNew.Format = "N0"
                        BreakDownList((RowCount * 3) + 2, 6) = Math.Floor((BreakDownReader.Item("prjctcst_bd_quanity") * BreakDownReader.Item("prjctcst_bd_costea")))
                        Dim Amount As CellRange = BreakDownList.GetCellRange(RowCount * 3 + 2, 6)
                        Amount.StyleNew.Format = "N0"

                        BreakDownList(RowCount * 3, 7) = RowNo * RowNo
                        BreakDownList(RowCount * 3 + 1, 7) = (RowNo * RowNo) + 1
                        BreakDownList(RowCount * 3 + 2, 7) = (RowNo * RowNo) + 2
                        If (RowNo * RowNo) + 2 = 6 Then
                            RowNo = 0
                        End If

                        If RowCount Mod 2 = 0 Then
                            BreakDownList.Rows(RowCount * 3).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                            BreakDownList.Rows((RowCount * 3) + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                            BreakDownList.Rows((RowCount * 3) + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        End If
                        BreakDownList.MergedRanges.Add(RowCount * 3, 0, (RowCount * 3) + 2, 0)
                        BreakDownList.MergedRanges.Add(RowCount * 3, 2, (RowCount * 3) + 2, 2)
                        BreakDownList.MergedRanges.Add(RowCount * 3, 3, (RowCount * 3) + 2, 3)
                        BreakDownList.MergedRanges.Add(RowCount * 3, 4, RowCount * 3, 5)
                        BreakDownList.MergedRanges.Add((RowCount * 3) + 1, 4, (RowCount * 3) + 1, 5)

                        BreakDownList((RowCount * 3) + 1, 10) = BreakDownReader.Item("prjctcst_bd_labor")
                        BreakDownList((RowCount * 3) + 1, 11) = BreakDownReader.Item("prjctcst_bd_material")
                        BreakDownList((RowCount * 3) + 1, 12) = BreakDownReader.Item("prjctcst_bd_machine")
                        BreakDownList((RowCount * 3) + 1, 13) = BreakDownReader.Item("prjctcst_bd_subcntrct")
                        BreakDownList((RowCount * 3) + 1, 14) = BreakDownReader.Item("prjctcst_bd_expense")
                        BreakDownList((RowCount * 3) + 2, 10) = Math.Floor(BreakDownReader.Item("prjctcst_bd_quanity") * BreakDownReader.Item("prjctcst_bd_labor"))
                        BreakDownList((RowCount * 3) + 2, 11) = Math.Floor(BreakDownReader.Item("prjctcst_bd_quanity") * BreakDownReader.Item("prjctcst_bd_material"))
                        BreakDownList((RowCount * 3) + 2, 12) = Math.Floor(BreakDownReader.Item("prjctcst_bd_quanity") * BreakDownReader.Item("prjctcst_bd_machine"))
                        BreakDownList((RowCount * 3) + 2, 13) = Math.Floor(BreakDownReader.Item("prjctcst_bd_quanity") * BreakDownReader.Item("prjctcst_bd_subcntrct"))
                        BreakDownList((RowCount * 3) + 2, 14) = Math.Floor(BreakDownReader.Item("prjctcst_bd_quanity") * BreakDownReader.Item("prjctcst_bd_expense"))

                    End While
                    BreakDownReader.Close()

                    Dim DataRowCount As Integer = RowCount * 3
                    Dim BlankRow As Integer = ((BreakDownList.Rows.Count - 3) - DataRowCount) / 3
                    For BlankLoop As Integer = 0 To BlankRow - 1
                        RowCount += 1
                        RowNo = 1
                        BreakDownList((RowCount * 3), 7) = (RowNo * RowNo)
                        BreakDownList((RowCount * 3) + 1, 7) = (RowNo * RowNo) + 1
                        BreakDownList((RowCount * 3) + 2, 7) = (RowNo * RowNo) + 2

                        If RowCount Mod 2 = 0 Then
                            BreakDownList.Rows(RowCount * 3).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                            BreakDownList.Rows((RowCount * 3) + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                            BreakDownList.Rows((RowCount * 3) + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        End If

                        Dim LastQuanity As CellRange = BreakDownList.GetCellRange(RowCount * 3, 6)
                        LastQuanity.StyleNew.Format = "N1"
                        Dim LastCostea As CellRange = BreakDownList.GetCellRange(RowCount * 3 + 1, 6)
                        LastCostea.StyleNew.Format = "N0"
                        Dim LastAmount As CellRange = BreakDownList.GetCellRange(RowCount * 3 + 2, 6)
                        LastAmount.StyleNew.Format = "N0"

                        BreakDownList.MergedRanges.Add(RowCount * 3, 0, (RowCount * 3) + 2, 0)
                        BreakDownList.MergedRanges.Add(RowCount * 3, 2, (RowCount * 3) + 2, 2)
                        BreakDownList.MergedRanges.Add(RowCount * 3, 3, (RowCount * 3) + 2, 3)
                        BreakDownList.MergedRanges.Add(RowCount * 3, 4, RowCount * 3, 5)
                        BreakDownList.MergedRanges.Add((RowCount * 3) + 1, 4, (RowCount * 3) + 1, 5)
                    Next

                    ホーム.Sql.CommandText = "SELECT * FROM projectcst_bd_total WHERE prjctcst_id=" & CreateCostID
                    Dim TotalReader As SqlDataReader = ホーム.Sql.ExecuteReader
                    While TotalReader.Read
                        LaborTotal.Text = TotalReader.Item("labor")
                        MaterialTotal.Text = TotalReader.Item("material")
                        MachineTotal.Text = TotalReader.Item("machine")
                        SubcntrctTotal.Text = TotalReader.Item("subcntrct")
                        ExpenseTotal.Text = TotalReader.Item("expense")
                    End While
                    TotalReader.Close()
                Else

                    For RowCount = 1 To 6
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
            Else

                BreakDownList.Rows.Count = 21

                ホーム.Sql.CommandText = "SELECT Count(*) FROM project_costs WHERE cstclss_code=" & ClassCode
                Dim CostCount As Integer = ホーム.Sql.ExecuteScalar

                Dim MaxNo As Integer = 0

                If CostCount > 0 Then
                    ホーム.Sql.CommandText = "SELECT MAX(prjctcst_no) FROM project_costs WHERE cstclss_code=" & ClassCode
                    MaxNo = ホーム.Sql.ExecuteScalar
                End If

                Dim No As String = MaxNo + 1
                If No.Length = 1 Then
                    No = "0000" & No
                ElseIf No.Length = 2 Then
                    No = "000" & No
                ElseIf No.Length = 3 Then
                    No = "00" & No
                ElseIf No.Length = 4 Then
                    No = "0" & No
                End If
                CostNo.Value = "第" & ClassName.Last & "-" & No & "号"

                Dim RowNo As Integer = 0
                For RowCount = 1 To 6
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

            BreakDownList.Select(3, 4)




            ホーム.Modified = "False"


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
        Try
            For BreakdownRowCount As Integer = 0 To BreakDownList.Rows.Count - 1
                If BreakdownRowCount < BreakDownList.Rows.Count - 3 AndAlso BreakDownList.Rows(BreakdownRowCount + 2).Caption = "▶" Then
                    SelectRow = BreakdownRowCount + 2
                    Exit For
                End If
            Next

            If SelectRow = 0 Then
                MsgBox("行が選択されていません。", MsgBoxStyle.Exclamation, "代価表")

            Else


                If SelectRow = 0 Then
                    MsgBox("行が選択されていません。", MsgBoxStyle.Exclamation, "代価表")
                Else

                    If SelectRow = BreakDownList.Rows.Count - 3 Then
                        Call Insert_Click(sender, e)
                    End If

                    作成代価選択.SelectRow = SelectRow
                    作成代価選択.CopyList = BreakDownList
                    BreakDownList(SelectRow, 3) = SelectRow / 3

                    作成代価選択.ShowDialog()
                    作成代価選択.TopMost = True
                    作成代価選択.TopMost = False

                End If
            End If
            Command = ""

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            作成代価選択.TopMost = False
            Exit Sub
        End Try
    End Sub

    Private Sub CostCreation_Click(sender As Object, e As EventArgs) Handles CostCreation.Click
        Try
            For BreakdownRowCount As Integer = 0 To BreakDownList.Rows.Count - 1
                If BreakdownRowCount < BreakDownList.Rows.Count - 3 AndAlso BreakDownList.Rows(BreakdownRowCount + 2).Caption = "▶" Then
                    SelectRow = BreakdownRowCount + 2
                    Exit For
                End If
            Next

            If SelectRow = 0 Then
                MsgBox("行が選択されていません。", MsgBoxStyle.Exclamation, "代価表")

            Else


                If SelectRow = 0 Then
                    MsgBox("行が選択されていません。", MsgBoxStyle.Exclamation, "代価表")
                Else

                    If SelectRow = BreakDownList.Rows.Count - 3 Then
                        Call Insert_Click(sender, e)
                    End If

                    作成代価選択.SelectRow = SelectRow
                    作成代価選択.CopyList = BreakDownList
                    BreakDownList(SelectRow, 3) = SelectRow / 3

                    作成代価選択.ShowDialog()
                    作成代価選択.TopMost = True
                    作成代価選択.TopMost = False

                End If
            End If
            Command = ""

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            作成代価選択.TopMost = False
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

                ホーム.ProjectCostSelectRow.Add(SelectRow)
                ホーム.PrjctCstList.Add(BreakDownList)

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

        If BreakDownList(SelectRow, 8) >= 12 Then

            Dim count As Integer = ホーム.ProjectCostForm.Count

            ホーム.ProjectCostForm.Add(New 代価表入力)
            ホーム.ProjectCostForm(count).TopLevel = False
            ホーム.FormPanel.Controls.Add(ホーム.ProjectCostForm(count))
            ホーム.ProjectCostSelectRow.Add(SelectRow)
            ホーム.ProjectCostID.Add(BreakDownList(SelectRow, 9))
            ホーム.PrjctCstClassCode.Add(BreakDownList(SelectRow, 8))
            ホーム.PrjctCstList.Add(BreakDownList)
            ホーム.ProjectCostForm(count).Show()
            Me.Visible = False

        Else
            MsgBox("選択された行には工事代価が登録されていません。", MsgBoxStyle.Exclamation, "明細書")
        End If


    End Sub

    Private Sub CostModifyMenu_Click(sender As Object, e As EventArgs) Handles CostModifyMenu.Click
        For DetailsRowCount As Integer = 0 To BreakDownList.Rows.Count - 1
            If DetailsRowCount < BreakDownList.Rows.Count - 3 AndAlso BreakDownList.Rows(DetailsRowCount + 2).Caption = "▶" Then
                SelectRow = DetailsRowCount + 2
                Exit For
            End If
        Next

        If BreakDownList(SelectRow, 8) >= 12 Then
            Dim FormCount As Integer = ホーム.ProjectCostForm.Count

            ホーム.ProjectCostForm.Add(New 代価表入力)
            ホーム.ProjectCostForm(FormCount).TopLevel = False
            ホーム.FormPanel.Controls.Add(ホーム.ProjectCostForm(FormCount))
            ホーム.ProjectCostSelectRow.Add(SelectRow)
            ホーム.ProjectCostID.Add(BreakDownList(SelectRow, 9))
            ホーム.PrjctCstClassCode.Add(BreakDownList(SelectRow, 8))
            ホーム.PrjctCstList.Add(BreakDownList)
            ホーム.ProjectCostForm(FormCount).Show()
            Me.Visible = False

        Else
            MsgBox("選択された行には工事代価が登録されていません。", MsgBoxStyle.Exclamation, "明細書")
        End If

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
                ホーム.ProjectCommand = "CostCopy"

                If BreakDownList(SelectRow, 8) >= 12 Then

                    作成代価選択.HeadLine.Text = "<<コピー代価選択"
                    作成代価選択.Text = "コピー代価選択"
                    作成代価選択.SelectRow = SelectRow
                    作成代価選択.CopyList = BreakDownList


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
                ホーム.ProjectCommand = "CostCopy"

                If BreakDownList(SelectRow, 8) >= 12 Then

                    作成代価選択.HeadLine.Text = "<<コピー代価選択"
                    作成代価選択.Text = "コピー代価選択"
                    作成代価選択.SelectRow = SelectRow
                    作成代価選択.CopyList = BreakDownList


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
                    Dim DaikaForm As New 代価表入力
                    DaikaForm.SelectRow = SelectRow
                    DaikaForm.CostID = BreakDownList(SelectRow, 9)
                    DaikaForm.ClassCode = BreakDownList(SelectRow, 8)
                    DaikaForm.TopLevel = True
                    DaikaForm.TopMost = True
                    DaikaForm.FormBorderStyle = FormBorderStyle.Sizable
                    DaikaForm.CostNo.Enabled = False
                    DaikaForm.CostName.Enabled = False
                    DaikaForm.CostSpec.Enabled = False
                    DaikaForm.CostQuanity.Enabled = False
                    DaikaForm.CostUnit.Enabled = False
                    DaikaForm.CostUnitPrice.Enabled = False
                    DaikaForm.CostCostea.Enabled = False
                    DaikaForm.BreakDownList.AllowEditing = False
                    DaikaForm.ItemSelect.Visible = False
                    DaikaForm.CostCreation.Visible = False
                    DaikaForm.CostModify.Visible = False
                    DaikaForm.CostCopy.Visible = False
                    DaikaForm.Reference.Visible = False
                    DaikaForm.Entry.Visible = False
                    DaikaForm.BreakDownList.ContextMenuStrip.Visible = False
                    DaikaForm.Show()
                    DaikaForm.TopMost = False



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

    Private Sub ReferenceMenu_Click(sender As Object, e As EventArgs) Handles ReferenceMenu.Click
        Try
            For DetailsRowCount As Integer = 0 To BreakDownList.Rows.Count - 1
                If DetailsRowCount < BreakDownList.Rows.Count - 3 AndAlso BreakDownList.Rows(DetailsRowCount + 2).Caption = "▶" Then
                    SelectRow = DetailsRowCount + 2
                    Exit For
                End If
            Next

            If BreakDownList(SelectRow, 8) >= 12 Then
                Dim DaikaForm As New 代価表入力
                DaikaForm.SelectRow = SelectRow
                DaikaForm.CostID = BreakDownList(SelectRow, 9)
                DaikaForm.ClassCode = BreakDownList(SelectRow, 8)
                DaikaForm.TopLevel = True
                DaikaForm.TopMost = True
                DaikaForm.FormBorderStyle = FormBorderStyle.Sizable
                DaikaForm.CostNo.Enabled = False
                DaikaForm.CostName.Enabled = False
                DaikaForm.CostSpec.Enabled = False
                DaikaForm.CostQuanity.Enabled = False
                DaikaForm.CostUnit.Enabled = False
                DaikaForm.CostUnitPrice.Enabled = False
                DaikaForm.CostCostea.Enabled = False
                DaikaForm.BreakDownList.AllowEditing = False
                DaikaForm.ItemSelect.Visible = False
                DaikaForm.CostCreation.Visible = False
                DaikaForm.CostModify.Visible = False
                DaikaForm.CostCopy.Visible = False
                DaikaForm.Reference.Visible = False
                DaikaForm.Entry.Visible = False
                DaikaForm.BreakDownList.ContextMenuStrip.Visible = False
                DaikaForm.Show()
                DaikaForm.TopMost = False
            Else
                MsgBox("選択された行には工事代価が登録されていません。", MsgBoxStyle.Exclamation, "代価表入力")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub BreakDownList_AfterRowColChange(sender As Object, e As RangeEventArgs) Handles BreakDownList.AfterRowColChange

        Try
            If Key = "" Then
                Dim Col As Integer = BreakDownList.Selection.LeftCol
                Dim Row As Integer = BreakDownList.Selection.TopRow

                If Not Command = "Insert" AndAlso Not Command = "Cut" Then

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


                End If

                If Col >= 6 Then
                    BreakDownList.ImeMode = ImeMode.Disable
                Else
                    BreakDownList.ImeMode = ImeMode.On
                End If
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
                MsgBox("行が選択されていません。", MsgBoxStyle.Exclamation, "代価表入力")
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

            If Me.FormBorderStyle = FormBorderStyle.Sizable Then
                Me.Close()
                Exit Sub
            End If

            Dim FormCount As Integer = ホーム.ProjectCostForm.Count

            If FormCount - 2 < 0 Then
                ホーム.Modified = "True"

                Dim ProjectCostID As Integer = 明細書入力.DetailsList(明細書入力.SelectRow, 9)

                ホーム.Sql.CommandText = "SELECT * FROM project_costs WHERE prjctcst_id=" & ProjectCostID
                Dim ProjectCostReader As SqlDataReader = ホーム.Sql.ExecuteReader
                While ProjectCostReader.Read
                    明細書入力.DetailsList(明細書入力.SelectRow, 4) = ProjectCostReader.Item("prjctcst_name")
                    明細書入力.DetailsList(明細書入力.SelectRow + 1, 4) = ProjectCostReader.Item("prjctcst_spec")
                    明細書入力.DetailsList(明細書入力.SelectRow + 2, 5) = ProjectCostReader.Item("prjctcst_unit")
                    明細書入力.DetailsList(明細書入力.SelectRow + 1, 6) = ProjectCostReader.Item("prjctcst_costea")
                    明細書入力.DetailsList(明細書入力.SelectRow + 2, 6) = Math.Floor(明細書入力.DetailsList(明細書入力.SelectRow, 6) * 明細書入力.DetailsList(明細書入力.SelectRow + 1, 6))
                    明細書入力.CategoryList(明細書入力.SelectRow + 1, 2) = ProjectCostReader.Item("prjctcst_laborea")
                    明細書入力.CategoryList(明細書入力.SelectRow + 2, 2) = Math.Floor(明細書入力.DetailsList(明細書入力.SelectRow, 6) * 明細書入力.CategoryList(明細書入力.SelectRow + 1, 2))
                    明細書入力.CategoryList(明細書入力.SelectRow + 1, 3) = ProjectCostReader.Item("prjctcst_materialea")
                    明細書入力.CategoryList(明細書入力.SelectRow + 2, 3) = Math.Floor(明細書入力.DetailsList(明細書入力.SelectRow, 6) * 明細書入力.CategoryList(明細書入力.SelectRow + 1, 3))
                    明細書入力.CategoryList(明細書入力.SelectRow + 1, 4) = ProjectCostReader.Item("prjctcst_machineea")
                    明細書入力.CategoryList(明細書入力.SelectRow + 2, 4) = Math.Floor(明細書入力.DetailsList(明細書入力.SelectRow, 6) * 明細書入力.CategoryList(明細書入力.SelectRow + 1, 4))
                    明細書入力.CategoryList(明細書入力.SelectRow + 1, 5) = ProjectCostReader.Item("prjctcst_subcntrctea")
                    明細書入力.CategoryList(明細書入力.SelectRow + 2, 5) = Math.Floor(明細書入力.DetailsList(明細書入力.SelectRow, 6) * 明細書入力.CategoryList(明細書入力.SelectRow + 1, 5))
                    明細書入力.CategoryList(明細書入力.SelectRow + 1, 6) = ProjectCostReader.Item("prjctcst_expenseea")
                    明細書入力.CategoryList(明細書入力.SelectRow + 2, 6) = Math.Floor(明細書入力.DetailsList(明細書入力.SelectRow, 6) * 明細書入力.CategoryList(明細書入力.SelectRow + 1, 6))


                End While
                ProjectCostReader.Close()

                Dim CancelClick As String = ""
                Dim CancelClickLoad As New CancelClick(ホーム.ProjectCostForm(FormCount - 1))
                CancelClick = CancelClickLoad.ModifyCheck

                明細書入力.Visible = True

            ElseIf (FormCount - 2) >= 0 Then
                ホーム.Modified = "True"

                Dim ProjectCostID As Integer = ホーム.ProjectCostID(FormCount - 1)
                Dim ProjectCostRow As Integer = ホーム.ProjectCostSelectRow(FormCount - 1)
                Dim ProjectCostList As C1FlexGrid = ホーム.PrjctCstList(FormCount - 1)

                ホーム.Sql.CommandText = "SELECT * FROM project_costs WHERE prjctcst_id=" & ProjectCostID
                Dim ProjectCostReader As SqlDataReader = ホーム.Sql.ExecuteReader
                While ProjectCostReader.Read
                    ProjectCostList(ProjectCostRow, 4) = ProjectCostReader.Item("prjctcst_name")
                    ProjectCostList(ProjectCostRow + 1, 4) = ProjectCostReader.Item("prjctcst_spec")
                    ProjectCostList(ProjectCostRow + 2, 5) = ProjectCostReader.Item("prjctcst_unit")
                    ProjectCostList(ProjectCostRow + 1, 6) = ProjectCostReader.Item("prjctcst_costea")
                    ProjectCostList(ProjectCostRow + 2, 6) = Math.Floor(ProjectCostList(ProjectCostRow, 6) * ProjectCostList(ProjectCostRow + 1, 6))
                    ProjectCostList(ProjectCostRow + 1, 10) = ProjectCostReader.Item("prjctcst_laborea")
                    ProjectCostList(ProjectCostRow + 2, 10) = Math.Floor(ProjectCostList(ProjectCostRow, 6) * ProjectCostList(ProjectCostRow + 1, 10))
                    ProjectCostList(ProjectCostRow + 1, 11) = ProjectCostReader.Item("prjctcst_materialea")
                    ProjectCostList(ProjectCostRow + 2, 11) = Math.Floor(ProjectCostList(ProjectCostRow, 6) * ProjectCostList(ProjectCostRow + 1, 11))
                    ProjectCostList(ProjectCostRow + 1, 12) = ProjectCostReader.Item("prjctcst_machineea")
                    ProjectCostList(ProjectCostRow + 2, 12) = Math.Floor(ProjectCostList(ProjectCostRow, 6) * ProjectCostList(ProjectCostRow + 1, 12))
                    ProjectCostList(ProjectCostRow + 1, 13) = ProjectCostReader.Item("prjctcst_subcntrctea")
                    ProjectCostList(ProjectCostRow + 2, 13) = Math.Floor(ProjectCostList(ProjectCostRow, 6) * ProjectCostList(ProjectCostRow + 1, 13))
                    ProjectCostList(ProjectCostRow + 1, 14) = ProjectCostReader.Item("prjctcst_expenseea")
                    ProjectCostList(ProjectCostRow + 2, 14) = Math.Floor(ProjectCostList(ProjectCostRow, 6) * ProjectCostList(ProjectCostRow + 1, 14))
                End While
                ProjectCostReader.Close()

                Dim CancelClick As String = ""
                Dim CancelClickLoad As New CancelClick(ホーム.ProjectCostForm(FormCount - 1))
                CancelClick = CancelClickLoad.ModifyCheck

                ホーム.ProjectCostForm(FormCount - 2).Visible = True
            Else
                ホーム.Modified = "False"

            End If

            ホーム.ProjectCostForm.RemoveAt(FormCount - 1)
            ホーム.ProjectCostID.RemoveAt(FormCount - 1)
            ホーム.ProjectCostSelectRow.RemoveAt(FormCount - 1)
            ホーム.PrjctCstClassCode.RemoveAt(FormCount - 1)
            ホーム.PrjctCstList.RemoveAt(FormCount - 1)

            FormCount = ホーム.ProjectCostForm.Count

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
                MsgBox("行が選択されていません。", MsgBoxStyle.Exclamation, "代価表入力")
            Else
                ホーム.Modified = "True"
                Command = "Insert"

                BreakDownList.Rows.Insert(SelectRow)
                BreakDownList.Rows.Insert(SelectRow + 1)
                BreakDownList.Rows.Insert(SelectRow + 2)
                BreakDownList(SelectRow, 8) = 0
                BreakDownList(SelectRow, 9) = 0
                BreakDownList(SelectRow, 1) = 0
                BreakDownList(SelectRow, 6) = 0
                BreakDownList(SelectRow + 1, 6) = 0
                BreakDownList(SelectRow + 2, 6) = 0
                Command = ""

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
                MsgBox("行が選択されていません。", MsgBoxStyle.Exclamation, "代価表入力")
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
                MsgBox("行が選択されていません。", MsgBoxStyle.Exclamation, "代価表入力")
            Else

                Command = "Pasting"
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

                Command = ""

                Dim RowNo As Integer = 0
                For RowCount As Integer = 1 To ((BreakDownList.Rows.Count - 3) / 3)

                    RowNo += 1

                    If RowCount < ((BreakDownList.Rows.Count - 3) / 3) Then
                        If IsNothing(BreakDownList(RowCount * 3, 4)) = False Then
                            BreakDownList(RowCount * 3, 3) = RowCount
                        End If
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
                MsgBox("行が選択されていません。", MsgBoxStyle.Exclamation, "代価表入力")
            Else
                ホーム.Modified = "True"
                Command = "Cut"

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
                Command = ""

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

    Private Sub BreakDownList_AfterEdit(sender As Object, e As RowColEventArgs) Handles BreakDownList.AfterEdit
        Try

            ホーム.Modified = "True"

            Dim Row As Integer = e.Row
            Dim Col As Integer = e.Col


            If Col = 6 Then
                If IsNumeric(BreakDownList(Row, 6)) = True Then
                    If BreakDownList(Row, 7) = 1 Or BreakDownList(Row, 7) = 4 Then
                        BreakDownList(Row + 2, 6) = Math.Floor((BreakDownList(Row, 6) * BreakDownList(Row + 1, 6)))
                        BreakDownList(Row + 2, 10) = Math.Floor((BreakDownList(Row, 6) * BreakDownList(Row + 1, 10)))
                        BreakDownList(Row + 2, 11) = Math.Floor((BreakDownList(Row, 6) * BreakDownList(Row + 1, 11)))
                        BreakDownList(Row + 2, 12) = Math.Floor((BreakDownList(Row, 6) * BreakDownList(Row + 1, 12)))
                        BreakDownList(Row + 2, 13) = Math.Floor((BreakDownList(Row, 6) * BreakDownList(Row + 1, 13)))
                        BreakDownList(Row + 2, 14) = Math.Floor((BreakDownList(Row, 6) * BreakDownList(Row + 1, 14)))
                    ElseIf BreakDownList(Row, 7) = 2 Or BreakDownList(Row, 7) = 5 Then
                        BreakDownList(Row + 1, 6) = Math.Floor((BreakDownList(Row, 6) * BreakDownList(Row - 1, 6)))
                    End If

                    Dim RowNo As Integer = 0
                    Dim ColTotal As Int64 = 0
                    Dim LaborColTotal As Int64 = 0
                    Dim MaterialColTotal As Int64 = 0
                    Dim MachineColTotal As Int64 = 0
                    Dim SubcntrctColTotal As Int64 = 0
                    Dim ExpenseColTotal As Int64 = 0


                    For RowCount As Integer = 1 To ((BreakDownList.Rows.Count - 3) / 3)

                        ColTotal += BreakDownList((RowCount * 3) + 2, 6)
                        LaborColTotal += BreakDownList((RowCount * 3) + 2, 10)
                        MaterialColTotal += BreakDownList((RowCount * 3) + 2, 11)
                        MachineColTotal += BreakDownList((RowCount * 3) + 2, 12)
                        SubcntrctColTotal += BreakDownList((RowCount * 3) + 2, 13)
                        ExpenseColTotal += BreakDownList((RowCount * 3) + 2, 14)

                    Next

                    CostUnitPrice.Value = ColTotal
                    Dim Costea As Int64 = Math.Floor(ColTotal / CostQuanity.Value)
                    CostCostea.Value = Costea

                    LaborTotal.Value = LaborColTotal
                    Dim Laborea As Int64 = Math.Floor(LaborColTotal / CostQuanity.Value)
                    LaborCostea.Value = Laborea

                    MaterialTotal.Value = MaterialColTotal
                    Dim Materialea As Int64 = Math.Floor(MaterialColTotal / CostQuanity.Value)
                    MaterialCostea.Value = Materialea

                    MachineTotal.Value = MachineColTotal
                    Dim Machineea As Int64 = Math.Floor(MachineColTotal / CostQuanity.Value)
                    MachineCostea.Value = Machineea

                    SubcntrctTotal.Value = SubcntrctColTotal
                    Dim Subcntrctea As Int64 = Math.Floor(SubcntrctColTotal / CostQuanity.Value)
                    SubcntrctCostea.Value = Subcntrctea

                    ExpenseTotal.Value = ExpenseColTotal
                    Dim Expenseea As Int64 = Math.Floor(ExpenseColTotal / CostQuanity.Value)
                    ExpensCostea.Value = Expenseea
                End If


                If IsKeyDown(Windows.Input.Key.Enter) = True Then
                    If Key = "" Then
                        Dim RowIndex As Integer = BreakDownList(Row, 7)
                        If RowIndex = 2 Or RowIndex = 5 Then
                            BreakDownList.Select(Row - 1, 10)

                        ElseIf RowIndex = 1 Or RowIndex = 4 Then
                            If ホーム.ItemSelect = "true" Then
                                BreakDownList.Select(Row + 2, 4)
                                ホーム.ItemSelect = ""
                            End If
                        End If
                    End If
                    Key = ""
                End If

            ElseIf Col = 10 Then

                If BreakDownList(Row, 7) = 1 Or BreakDownList(Row, 7) = 4 Then
                    BreakDownList(Row + 2, 10) = Math.Floor((BreakDownList(Row, 6) * BreakDownList(Row + 1, 10)))
                ElseIf BreakDownList(Row, 7) = 2 Or BreakDownList(Row, 7) = 5 Then
                    BreakDownList(Row + 1, 10) = Math.Floor((BreakDownList(Row - 1, 6) * BreakDownList(Row, 10)))
                End If

                Dim RowNo As Integer = 0
                Dim ColTotal As Int64 = 0

                For RowCount As Integer = 1 To ((BreakDownList.Rows.Count - 3) / 3)

                    ColTotal += BreakDownList((RowCount * 3) + 2, 10)

                Next

                LaborTotal.Value = ColTotal
                Dim Laborea As Int64 = Math.Floor(ColTotal / CostQuanity.Value)
                LaborCostea.Value = Laborea


                If IsKeyDown(Windows.Input.Key.Enter) = True Then
                    If Key = "" Then
                        Dim RowIndex As Integer = BreakDownList(Row, 7)
                        If RowIndex = 2 Or RowIndex = 5 Then
                            BreakDownList.Select(Row - 1, 11)
                        End If
                    End If
                    Key = ""
                End If
            ElseIf Col = 11 Then

                If BreakDownList(Row, 7) = 1 Or BreakDownList(Row, 7) = 4 Then
                    BreakDownList(Row + 2, 11) = Math.Floor((BreakDownList(Row, 6) * BreakDownList(Row + 1, 11)))
                ElseIf BreakDownList(Row, 7) = 2 Or BreakDownList(Row, 7) = 5 Then
                    BreakDownList(Row + 1, 11) = Math.Floor((BreakDownList(Row - 1, 6) * BreakDownList(Row, 11)))
                End If

                Dim RowNo As Integer = 0
                Dim ColTotal As Int64 = 0

                For RowCount As Integer = 1 To ((BreakDownList.Rows.Count - 3) / 3)

                    ColTotal += BreakDownList((RowCount * 3) + 2, 11)

                Next

                MaterialTotal.Value = ColTotal
                Dim Materialea As Int64 = Math.Floor(ColTotal / CostQuanity.Value)
                MaterialCostea.Value = Materialea


                If IsKeyDown(Windows.Input.Key.Enter) = True Then
                    If Key = "" Then
                        Dim RowIndex As Integer = BreakDownList(Row, 7)
                        If RowIndex = 2 Or RowIndex = 5 Then
                            BreakDownList.Select(Row - 1, 12)
                        End If
                    End If
                    Key = ""
                End If
            ElseIf Col = 12 Then

                If BreakDownList(Row, 7) = 1 Or BreakDownList(Row, 7) = 4 Then
                    BreakDownList(Row + 2, 12) = Math.Floor((BreakDownList(Row, 6) * BreakDownList(Row + 1, 12)))
                ElseIf BreakDownList(Row, 7) = 2 Or BreakDownList(Row, 7) = 5 Then
                    BreakDownList(Row + 1, 12) = Math.Floor((BreakDownList(Row - 1, 6) * BreakDownList(Row, 12)))
                End If

                Dim RowNo As Integer = 0
                Dim ColTotal As Int64 = 0

                For RowCount As Integer = 1 To ((BreakDownList.Rows.Count - 3) / 3)

                    ColTotal += BreakDownList((RowCount * 3) + 2, 12)

                Next

                MachineTotal.Value = ColTotal
                Dim Machineea As Int64 = Math.Floor(ColTotal / CostQuanity.Value)
                MachineCostea.Value = Machineea


                If IsKeyDown(Windows.Input.Key.Enter) = True Then
                    If Key = "" Then
                        Dim RowIndex As Integer = BreakDownList(Row, 7)
                        If RowIndex = 2 Or RowIndex = 5 Then
                            BreakDownList.Select(Row - 1, 13)
                        End If
                    End If
                    Key = ""
                End If
            ElseIf Col = 13 Then

                If BreakDownList(Row, 7) = 1 Or BreakDownList(Row, 7) = 4 Then
                    BreakDownList(Row + 2, 13) = Math.Floor((BreakDownList(Row, 6) * BreakDownList(Row + 1, 13)))
                ElseIf BreakDownList(Row, 7) = 2 Or BreakDownList(Row, 7) = 5 Then
                    BreakDownList(Row + 1, 13) = Math.Floor((BreakDownList(Row - 1, 6) * BreakDownList(Row, 13)))
                End If

                Dim RowNo As Integer = 0
                Dim ColTotal As Int64 = 0

                For RowCount As Integer = 1 To ((BreakDownList.Rows.Count - 3) / 3)

                    ColTotal += BreakDownList((RowCount * 3) + 2, 13)

                Next

                SubcntrctTotal.Value = ColTotal
                Dim Subcntrctea As Int64 = Math.Floor(ColTotal / CostQuanity.Value)
                SubcntrctCostea.Value = Subcntrctea


                If IsKeyDown(Windows.Input.Key.Enter) = True Then
                    If Key = "" Then
                        Dim RowIndex As Integer = BreakDownList(Row, 7)
                        If RowIndex = 2 Or RowIndex = 5 Then
                            BreakDownList.Select(Row - 1, 14)
                        End If
                    End If
                    Key = ""
                End If
            ElseIf Col = 14 Then


                If BreakDownList(Row, 7) = 1 Or BreakDownList(Row, 7) = 4 Then
                    BreakDownList(Row + 2, 14) = Math.Floor((BreakDownList(Row, 6) * BreakDownList(Row + 1, 14)))
                ElseIf BreakDownList(Row, 7) = 2 Or BreakDownList(Row, 7) = 5 Then
                    BreakDownList(Row + 1, 14) = Math.Floor((BreakDownList(Row - 1, 6) * BreakDownList(Row, 14)))
                End If

                Dim RowNo As Integer = 0
                Dim ColTotal As Int64 = 0

                For RowCount As Integer = 1 To ((BreakDownList.Rows.Count - 3) / 3)

                    ColTotal += BreakDownList((RowCount * 3) + 2, 14)

                Next

                ExpenseTotal.Value = ColTotal
                Dim Expenseea As Int64 = Math.Floor(ColTotal / CostQuanity.Value)
                ExpensCostea.Value = Expenseea

                If IsKeyDown(Windows.Input.Key.Enter) = True AndAlso Key = "" Then
                    Dim RowIndex As Integer = BreakDownList(Row, 7)
                    If RowIndex = 2 Or RowIndex = 5 Then
                        BreakDownList.Select(Row + 1, 4)
                    End If
                End If

            ElseIf Col = 4 Then
                If Row + 3 = BreakDownList.Rows.Count Then
                    BreakDownList.Rows.Add(3)
                    Dim NewRow As Integer = Row + 3

                    Dim Quanity As CellRange = BreakDownList.GetCellRange(NewRow, 6)
                    Quanity.StyleNew.Format = "N1"
                    Dim Costea As CellRange = BreakDownList.GetCellRange(NewRow + 1, 6)
                    Costea.StyleNew.Format = "N0"
                    Dim Amount As CellRange = BreakDownList.GetCellRange(NewRow + 2, 6)
                    Amount.StyleNew.Format = "N0"
                    BreakDownList.Rows(NewRow).StyleFixedNew.BackColor = Color.FromArgb(213, 234, 216)


                    If NewRow Mod 2 = 0 Then
                        BreakDownList.Rows(NewRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        BreakDownList.Rows(NewRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        BreakDownList.Rows(NewRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)

                        BreakDownList(NewRow, 7) = 4
                        BreakDownList(NewRow + 1, 7) = 5
                        BreakDownList(NewRow + 2, 7) = 6

                    Else
                        BreakDownList.Rows(NewRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        BreakDownList.Rows(NewRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        BreakDownList.Rows(NewRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)

                        BreakDownList(NewRow, 7) = 1
                        BreakDownList(NewRow + 1, 7) = 2
                        BreakDownList(NewRow + 2, 7) = 3

                    End If

                    BreakDownList.MergedRanges.Add(NewRow, 0, NewRow + 2, 0)
                    BreakDownList.MergedRanges.Add(NewRow, 2, NewRow + 2, 2)
                    BreakDownList.MergedRanges.Add(NewRow, 3, NewRow + 2, 3)
                    BreakDownList.MergedRanges.Add(NewRow, 4, NewRow, 5)
                    BreakDownList.MergedRanges.Add(NewRow + 1, 4, NewRow + 1, 5)

                End If


                If IsKeyDown(Windows.Input.Key.Enter) = True Then
                    If Key = "" Then
                        Dim RowIndex As Integer = BreakDownList(Row, 7)
                        If RowIndex = 3 Or RowIndex = 6 Then
                            BreakDownList.Select(Row - 1, 5)
                        End If
                    End If
                    Key = ""
                End If
            ElseIf Col = 5 Then
                If IsKeyDown(Windows.Input.Key.Enter) = True AndAlso Key = "" Then
                    Dim RowIndex As Integer = BreakDownList(Row, 7)
                    If RowIndex = 3 Or RowIndex = 6 Then
                        BreakDownList.Select(Row - 3, 6)
                    End If
                End If
            Else
                If IsKeyDown(Windows.Input.Key.Enter) = True Then
                    Key = ""
                End If
            End If

            Dim DeleteRow As Integer = 0
            For RowCount As Integer = 1 To ((BreakDownList.Rows.Count - 3) / 3)
                If IsNothing(BreakDownList(RowCount * 3, 2)) = True Then
                    If RowCount <= ((BreakDownList.Rows.Count - 3) / 3) Then
                        If IsNothing(BreakDownList(RowCount * 3, 4)) = False Then
                            BreakDownList(RowCount * 3, 3) = RowCount - DeleteRow
                        End If
                    End If
                Else
                    If BreakDownList(RowCount * 3, 2) = False Then
                        If RowCount <= ((BreakDownList.Rows.Count - 3) / 3) Then
                            If IsNothing(BreakDownList(RowCount * 3, 4)) = False Then
                                BreakDownList(RowCount * 3, 3) = RowCount - DeleteRow
                            End If
                        End If
                    Else
                        DeleteRow += 1
                    End If
                End If
            Next

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try

    End Sub

    Private Sub Entry_Click(sender As Object, e As EventArgs) Handles Entry.Click

        Try

            Dim ErrorCount As Integer = 0

            If Not CostName.Text <> "" Then
                ErrorCount += 1
                CostName.BackColor = Color.FromArgb(255, 192, 192)
            Else
                CostName.BackColor = Color.White
            End If

            If Not CostUnit.Text <> "" Then
                ErrorCount += 1
                CostUnit.BackColor = Color.FromArgb(255, 192, 192)
            Else
                CostUnit.BackColor = Color.White
            End If

            If Not CostQuanity.Text <> "" Then
                ErrorCount += 1
                CostQuanity.BackColor = Color.FromArgb(255, 192, 192)
            Else
                CostQuanity.BackColor = Color.White
            End If

            If Not CostCostea.Text <> "" Then
                ErrorCount += 1
                CostCostea.BackColor = Color.FromArgb(255, 192, 192)
            Else
                CostCostea.BackColor = Color.White
            End If

            If ErrorCount > 0 Then
                MsgBox("入力されていない項目があります。", MsgBoxStyle.Exclamation, "代価表入力")
                Exit Sub
            End If

            Dim ErrorRow As String = ""
            ErrorCount = 0
            For RowCount As Integer = 1 To ((BreakDownList.Rows.Count - 3) / 3)

                If IsNothing(BreakDownList(RowCount, 2)) = False Then

                    Dim Name As String = BreakDownList(RowCount * 3, 4)
                    If Not (RowCount * 3) = BreakDownList.Rows.Count - 3 Then
                        If IsNothing(Name) = True AndAlso IsNothing(BreakDownList(RowCount * 3, 3)) = False Then

                            ErrorCount += 1
                            BreakDownList.Rows(RowCount * 3).StyleFixedNew.BackColor = Color.FromArgb(255, 192, 192)
                        End If
                    End If
                Else
                    If IsNothing(Name) = True AndAlso IsNothing(BreakDownList(RowCount * 3, 3)) = False Then
                        ErrorCount += 1
                        BreakDownList.Rows(RowCount * 3).StyleFixedNew.BackColor = Color.FromArgb(255, 192, 192)
                    End If
                End If
            Next

            If ErrorCount >= 1 Then
                MsgBox("名称が入力されていない行があります。", MsgBoxStyle.Exclamation, "代価表入力")
                Exit Sub
            End If



            ホーム.Transaction = ホーム.Connection.BeginTransaction

            ホーム.Sql.Transaction = ホーム.Transaction

            ホーム.Sql.CommandText = ""
            ホーム.Sql.Parameters.Clear()
            ホーム.Sql.Parameters.Add(New SqlParameter("@name", SqlDbType.NVarChar)).Value = CostName.Value
            If IsNothing(CostSpec.Value) = True Or Not CostSpec.Text <> "" Then
                ホーム.Sql.Parameters.Add(New SqlParameter("@spec", SqlDbType.NVarChar)).Value = ""
            Else
                ホーム.Sql.Parameters.Add(New SqlParameter("@spec", SqlDbType.NVarChar)).Value = CostSpec.Value
            End If
            ホーム.Sql.Parameters.Add(New SqlParameter("@unit", SqlDbType.NVarChar)).Value = CostUnit.Value
            ホーム.Sql.Parameters.Add(New SqlParameter("@quanity", SqlDbType.Decimal)).Value = CostQuanity.Value
            ホーム.Sql.Parameters.Add(New SqlParameter("@costea", SqlDbType.Money)).Value = CostCostea.Value
            If IsNothing(LaborCostea.Value) = True Or IsDBNull(LaborCostea.Value) = True Then
                ホーム.Sql.Parameters.Add(New SqlParameter("@labor", SqlDbType.Money)).Value = 0
            Else
                ホーム.Sql.Parameters.Add(New SqlParameter("@labor", SqlDbType.Money)).Value = LaborCostea.Value
            End If
            If IsNothing(MaterialCostea.Value) = True Or IsDBNull(MaterialCostea.Value) = True Then
                ホーム.Sql.Parameters.Add(New SqlParameter("@material", SqlDbType.Money)).Value = 0
            Else
                ホーム.Sql.Parameters.Add(New SqlParameter("@material", SqlDbType.Money)).Value = MaterialCostea.Value
            End If
            If IsNothing(MachineCostea.Value) = True Or IsDBNull(MachineCostea.Value) = True Then
                ホーム.Sql.Parameters.Add(New SqlParameter("@machine", SqlDbType.Money)).Value = 0
            Else
                ホーム.Sql.Parameters.Add(New SqlParameter("@machine", SqlDbType.Money)).Value = MachineCostea.Value
            End If
            If IsNothing(SubcntrctCostea.Value) = True Or IsDBNull(SubcntrctCostea.Value) = True Then
                ホーム.Sql.Parameters.Add(New SqlParameter("@subcntrct", SqlDbType.Money)).Value = 0
            Else
                ホーム.Sql.Parameters.Add(New SqlParameter("@subcntrct", SqlDbType.Money)).Value = SubcntrctCostea.Value
            End If
            If IsNothing(ExpensCostea.Value) = True Or IsDBNull(ExpensCostea.Value) = True Then
                ホーム.Sql.Parameters.Add(New SqlParameter("@expense", SqlDbType.Money)).Value = 0
            Else
                ホーム.Sql.Parameters.Add(New SqlParameter("@expense", SqlDbType.Money)).Value = ExpensCostea.Value
            End If

            Dim No As String = CostNo.Text.Remove(0, 3)
            No = No.Replace("号", "")

            If CostID = 0 Then
                ホーム.Sql.Parameters.Add(New SqlParameter("@budgetno", SqlDbType.SmallInt)).Value = ホーム.BudgetNo
                ホーム.Sql.Parameters.Add(New SqlParameter("@cstclsscode", SqlDbType.SmallInt)).Value = ClassCode
                ホーム.Sql.Parameters.Add(New SqlParameter("@prjctcstno", SqlDbType.SmallInt)).Value = Integer.Parse(No)

                ホーム.Sql.CommandText = "INSERT INTO project_costs (budget_no,cstclss_code,prjctcst_no,prjctcst_name,prjctcst_spec,prjctcst_unit,
                                          prjctcst_quanity,prjctcst_costea,prjctcst_laborea,prjctcst_materialea,prjctcst_machineea,prjctcst_subcntrctea,prjctcst_expenseea)
                                            VALUES (@budgetno,@cstclsscode,@prjctcstno,@name,@spec,@unit,@quanity,@costea,@labor,@material,@machine,@subcntrct,@expense)"
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.Parameters.Clear()
                ホーム.Sql.CommandText = ""
                ホーム.Sql.CommandText = "SELECT prjctcst_id FROM project_costs WHERE cstclss_code=" & ClassCode & " AND prjctcst_no=" & Integer.Parse(No)
                CostID = ホーム.Sql.ExecuteScalar

            Else
                ホーム.Sql.CommandText = "UPDATE project_costs SET prjctcst_name=@name,prjctcst_spec=@spec,prjctcst_unit=@unit,prjctcst_quanity=@quanity,
                                          prjctcst_costea=@costea,prjctcst_laborea=@labor,prjctcst_materialea=@material,prjctcst_machineea=@machine,
                                          prjctcst_subcntrctea=@subcntrct,prjctcst_expenseea=@expense WHERE prjctcst_id=" & CostID
                ホーム.Sql.ExecuteNonQuery()

            End If

            For RowCount As Integer = 1 To ((BreakDownList.Rows.Count - 3) / 3)
                ホーム.Sql.CommandText = ""
                ホーム.Sql.Parameters.Clear()
                If IsNothing(BreakDownList(RowCount * 3, 4)) = False AndAlso IsNothing(BreakDownList(RowCount * 3, 3)) = False Then
                    If BreakDownList(RowCount * 3, 2) = "False" Or IsNothing(BreakDownList(RowCount * 3, 2)) = True Then
                        If IsNothing(BreakDownList(RowCount * 3, 8)) = True Then
                            ホーム.Sql.Parameters.Add(New SqlParameter("@cstclsscode", SqlDbType.SmallInt)).Value = 0
                            ホーム.Sql.Parameters.Add(New SqlParameter("@cstmstrid", SqlDbType.SmallInt)).Value = 0
                        Else
                            ホーム.Sql.Parameters.Add(New SqlParameter("@cstclsscode", SqlDbType.SmallInt)).Value = BreakDownList(RowCount * 3, 8)
                            ホーム.Sql.Parameters.Add(New SqlParameter("@cstmstrid", SqlDbType.SmallInt)).Value = BreakDownList(RowCount * 3, 9)
                        End If
                        ホーム.Sql.Parameters.Add(New SqlParameter("@bdno", SqlDbType.SmallInt)).Value = BreakDownList(RowCount * 3, 3)
                        ホーム.Sql.Parameters.Add(New SqlParameter("@bdname", SqlDbType.NVarChar)).Value = BreakDownList(RowCount * 3, 4)
                        If IsNothing(BreakDownList(RowCount * 3 + 1, 4)) = True Then
                            ホーム.Sql.Parameters.Add(New SqlParameter("@bdspec", SqlDbType.NVarChar)).Value = ""
                        Else
                            ホーム.Sql.Parameters.Add(New SqlParameter("@bdspec", SqlDbType.NVarChar)).Value = BreakDownList(RowCount * 3 + 1, 4)
                        End If
                        If IsNothing(BreakDownList(RowCount * 3 + 2, 5)) = True Then
                            ホーム.Sql.Parameters.Add(New SqlParameter("@bdunit", SqlDbType.NVarChar)).Value = ""
                        Else
                            ホーム.Sql.Parameters.Add(New SqlParameter("@bdunit", SqlDbType.NVarChar)).Value = BreakDownList(RowCount * 3 + 2, 5)
                        End If
                        If IsNothing(BreakDownList(RowCount * 3, 6)) = True Then
                            ホーム.Sql.Parameters.Add(New SqlParameter("@bdquanity", SqlDbType.Decimal)).Value = 0
                        Else
                            ホーム.Sql.Parameters.Add(New SqlParameter("@bdquanity", SqlDbType.Decimal)).Value = BreakDownList(RowCount * 3, 6)
                        End If
                        If IsNothing(BreakDownList(RowCount * 3 + 1, 6)) = True Then
                            ホーム.Sql.Parameters.Add(New SqlParameter("@bdcostea", SqlDbType.Money)).Value = 0
                        Else
                            ホーム.Sql.Parameters.Add(New SqlParameter("@bdcostea", SqlDbType.Money)).Value = BreakDownList(RowCount * 3 + 1, 6)
                        End If
                        If IsNothing(BreakDownList(RowCount * 3 + 1, 10)) = True Then
                            ホーム.Sql.Parameters.Add(New SqlParameter("@bdlabor", SqlDbType.Money)).Value = 0
                        Else
                            ホーム.Sql.Parameters.Add(New SqlParameter("@bdlabor", SqlDbType.Money)).Value = BreakDownList(RowCount * 3 + 1, 10)
                        End If
                        If IsNothing(BreakDownList(RowCount * 3 + 1, 11)) = True Then
                            ホーム.Sql.Parameters.Add(New SqlParameter("@bdmaterial", SqlDbType.Money)).Value = 0
                        Else
                            ホーム.Sql.Parameters.Add(New SqlParameter("@bdmaterial", SqlDbType.Money)).Value = BreakDownList(RowCount * 3 + 1, 11)
                        End If
                        If IsNothing(BreakDownList(RowCount * 3 + 1, 12)) = True Then
                            ホーム.Sql.Parameters.Add(New SqlParameter("@bdmachine", SqlDbType.Money)).Value = 0
                        Else
                            ホーム.Sql.Parameters.Add(New SqlParameter("@bdmachine", SqlDbType.Money)).Value = BreakDownList(RowCount * 3 + 1, 12)
                        End If
                        If IsNothing(BreakDownList(RowCount * 3 + 1, 13)) = True Then
                            ホーム.Sql.Parameters.Add(New SqlParameter("@bdsubcntrct", SqlDbType.Money)).Value = 0
                        Else
                            ホーム.Sql.Parameters.Add(New SqlParameter("@bdsubcntrct", SqlDbType.Money)).Value = BreakDownList(RowCount * 3 + 1, 13)
                        End If
                        If IsNothing(BreakDownList(RowCount * 3 + 1, 14)) = True Then
                            ホーム.Sql.Parameters.Add(New SqlParameter("@bdexpense", SqlDbType.Money)).Value = 0
                        Else
                            ホーム.Sql.Parameters.Add(New SqlParameter("@bdexpense", SqlDbType.Money)).Value = BreakDownList(RowCount * 3 + 1, 14)
                        End If
                        If IsNothing(BreakDownList(RowCount * 3 + 2, 4)) = True Then
                            ホーム.Sql.Parameters.Add(New SqlParameter("@bdremarks", SqlDbType.NVarChar)).Value = ""
                        Else
                            ホーム.Sql.Parameters.Add(New SqlParameter("@bdremarks", SqlDbType.NVarChar)).Value = BreakDownList(RowCount * 3 + 2, 4)
                        End If

                        If BreakDownList(RowCount * 3, 1) = 0 Then
                            ホーム.Sql.Parameters.Add(New SqlParameter("@prjctcstid", SqlDbType.SmallInt)).Value = CostID
                            ホーム.Sql.CommandText = "INSERT project_cost_breakdowns (prjctcst_id,cstclss_code,cstmstr_id,prjctcst_bd_no,prjctcst_bd_name,prjctcst_bd_spec
                                                                   ,prjctcst_bd_unit,prjctcst_bd_quanity,prjctcst_bd_costea,prjctcst_bd_labor,prjctcst_bd_material,prjctcst_bd_machine,
                                                                    prjctcst_bd_subcntrct,prjctcst_bd_expense,prjctcst_bd_remarks) 
                                                  VALUES (@prjctcstid,@cstclsscode,@cstmstrid,@bdno,@bdname,@bdspec,@bdunit,@bdquanity,@bdcostea,
                                                  @bdlabor,@bdmaterial,@bdmachine,@bdsubcntrct,@bdexpense,@bdremarks)"
                        Else
                            ホーム.Sql.CommandText = "UPDATE project_cost_breakdowns SET cstclss_code=@cstclsscode,cstmstr_id=@cstmstrid,prjctcst_bd_no=@bdno,
                                                      prjctcst_bd_name=@bdname,prjctcst_bd_spec=@bdspec,prjctcst_bd_unit=@bdunit,prjctcst_bd_quanity=@bdquanity,prjctcst_bd_costea=@bdcostea,
                                                      prjctcst_bd_labor=@bdlabor,prjctcst_bd_material=@bdmaterial,prjctcst_bd_machine=@bdmachine,prjctcst_bd_subcntrct=@bdsubcntrct,
                                                      prjctcst_bd_expense=@bdexpense,prjctcst_bd_remarks=@bdremarks WHERE prjctcst_bd_id=" & BreakDownList(RowCount * 3, 1)
                        End If
                        ホーム.Sql.ExecuteNonQuery()
                    Else
                        If Not BreakDownList(RowCount * 3, 1) = 0 Then
                            ホーム.Sql.CommandText = "DELETE FROM project_cost_breakdowns WHERE prjctcst_bd_id=" & BreakDownList(RowCount * 3, 1)
                            ホーム.Sql.ExecuteNonQuery()
                        End If
                    End If
                End If
            Next

            ホーム.Transaction.Commit()


        Catch ex As Exception
            ホーム.Transaction.Rollback()
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try

        Try
            For RowCount As Integer = 1 To ((BreakDownList.Rows.Count - 3) / 3)
                If RowCount * 3 <= (BreakDownList.Rows.Count - 3) Then
                    If BreakDownList(RowCount * 3, 2) = "True" Then
                        BreakDownList.Rows.RemoveRange(RowCount * 3, 3)
                        RowCount = RowCount - 1
                    End If
                    If RowCount * 3 = (BreakDownList.Rows.Count - 3) Then
                        Dim Name As String = BreakDownList(RowCount * 3, 4)
                        If IsNothing(Name) = False Then
                            If Name.Length > 0 Or IsNothing(BreakDownList((RowCount * 3), 3)) = False Then
                                BreakDownList.Rows.Insert(RowCount * 3)
                                BreakDownList.Rows.Insert((RowCount * 3) + 1)
                                BreakDownList.Rows.Insert((RowCount * 3) + 2)
                            End If
                        End If
                    End If
                End If
            Next


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

            ホーム.Modified = "False"


            ホーム.Sql.Parameters.Clear()

            ホーム.Sql.CommandText = "CREATE TABLE #UpdateID (id INT DEFAULT (0) NOT NULL,
                                                              name NVARCHAR(50) DEFAULT ('') NOT NULL,
                                                              spec NVARCHAR(50) DEFAULT ('') NOT NULL,
                                                              unit NVARCHAR(5) DEFAULT ('') NOT NULL,
                                                              costea MONEY DEFAULT (0) NOT NULL,
                                                              labor MONEY DEFAULT (0) NOT NULL,
                                                              material MONEY DEFAULT (0) NOT NULL,
                                                              machine MONEY DEFAULT (0) NOT NULL,
                                                              subcntrct MONEY DEFAULT (0) NOT NULL,
                                                              expense MONEY DEFAULT (0) NOT NULL)"
            ホーム.Sql.ExecuteNonQuery()

            ホーム.Sql.CommandText = "INSERT INTO #UpdateID (id,name,spec,unit,costea,labor,material,machine,subcntrct,expense) 
                                      VALUES (@id,@name,@spec,@unit,@costea,@labor,@material,@machine,@subcntrct,@expense)"
            ホーム.Sql.Parameters.Add(New SqlParameter("@id", SqlDbType.Int)).Value = CostID
            ホーム.Sql.Parameters.Add(New SqlParameter("@name", SqlDbType.NVarChar)).Value = CostName.Value
            If IsNothing(CostSpec.Value) = True Or Not CostSpec.Text <> "" Then
                ホーム.Sql.Parameters.Add(New SqlParameter("@spec", SqlDbType.NVarChar)).Value = ""
            Else
                ホーム.Sql.Parameters.Add(New SqlParameter("@spec", SqlDbType.NVarChar)).Value = CostSpec.Value
            End If
            ホーム.Sql.Parameters.Add(New SqlParameter("@unit", SqlDbType.NVarChar)).Value = CostUnit.Value
            ホーム.Sql.Parameters.Add(New SqlParameter("@costea", SqlDbType.Money)).Value = CostCostea.Value
            If IsNothing(LaborCostea.Value) = True Or IsDBNull(LaborCostea.Value) = True Then
                ホーム.Sql.Parameters.Add(New SqlParameter("@labor", SqlDbType.Money)).Value = 0
            Else
                ホーム.Sql.Parameters.Add(New SqlParameter("@labor", SqlDbType.Money)).Value = LaborCostea.Value
            End If
            If IsNothing(MaterialCostea.Value) = True Or IsDBNull(MaterialCostea.Value) = True Then
                ホーム.Sql.Parameters.Add(New SqlParameter("@material", SqlDbType.Money)).Value = 0
            Else
                ホーム.Sql.Parameters.Add(New SqlParameter("@material", SqlDbType.Money)).Value = MaterialCostea.Value
            End If
            If IsNothing(MachineCostea.Value) = True Or IsDBNull(MachineCostea.Value) = True Then
                ホーム.Sql.Parameters.Add(New SqlParameter("@machine", SqlDbType.Money)).Value = 0
            Else
                ホーム.Sql.Parameters.Add(New SqlParameter("@machine", SqlDbType.Money)).Value = MachineCostea.Value
            End If
            If IsNothing(SubcntrctCostea.Value) = True Or IsDBNull(SubcntrctCostea.Value) = True Then
                ホーム.Sql.Parameters.Add(New SqlParameter("@subcntrct", SqlDbType.Money)).Value = 0
            Else
                ホーム.Sql.Parameters.Add(New SqlParameter("@subcntrct", SqlDbType.Money)).Value = SubcntrctCostea.Value
            End If
            If IsNothing(ExpensCostea.Value) = True Or IsDBNull(ExpensCostea.Value) = True Then
                ホーム.Sql.Parameters.Add(New SqlParameter("@expense", SqlDbType.Money)).Value = 0
            Else
                ホーム.Sql.Parameters.Add(New SqlParameter("@expense", SqlDbType.Money)).Value = ExpensCostea.Value
            End If
            ホーム.Sql.ExecuteNonQuery()

            Dim Recalculation As String = ""

            Dim RecalculationLoad As New Recalculation(ClassCode)
            Recalculation = RecalculationLoad.Recalculation

            MsgBox(CostNo.Text & " 登録完了", MsgBoxStyle.OkOnly, "代価表入力")


            Dim FormCount As Integer = ホーム.ProjectCostForm.Count

            If FormCount - 2 < 0 Then
                If Not 明細書入力.Command = "CostCopy" Then
                    明細書入力.DetailsList(明細書入力.SelectRow, 9) = CostID

                    Dim ProjectCostID As Integer = 明細書入力.DetailsList(明細書入力.SelectRow, 9)

                    ホーム.Sql.CommandText = "SELECT * FROM project_costs WHERE prjctcst_id=" & ProjectCostID
                    Dim ProjectCostReader As SqlDataReader = ホーム.Sql.ExecuteReader
                    While ProjectCostReader.Read
                        明細書入力.DetailsList(明細書入力.SelectRow, 4) = ProjectCostReader.Item("prjctcst_name")
                        明細書入力.DetailsList(明細書入力.SelectRow + 1, 4) = ProjectCostReader.Item("prjctcst_spec")
                        明細書入力.DetailsList(明細書入力.SelectRow + 2, 5) = ProjectCostReader.Item("prjctcst_unit")
                        明細書入力.DetailsList(明細書入力.SelectRow + 2, 4) = CostNo.Text
                        明細書入力.DetailsList(明細書入力.SelectRow + 1, 6) = ProjectCostReader.Item("prjctcst_costea")
                        明細書入力.DetailsList(明細書入力.SelectRow, 8) = ProjectCostReader.Item("cstclss_code")
                        明細書入力.DetailsList(明細書入力.SelectRow, 9) = ProjectCostID
                        明細書入力.DetailsList(明細書入力.SelectRow + 2, 6) = Math.Floor(明細書入力.DetailsList(明細書入力.SelectRow, 6) * 明細書入力.DetailsList(明細書入力.SelectRow + 1, 6))
                        明細書入力.CategoryList(明細書入力.SelectRow + 1, 2) = ProjectCostReader.Item("prjctcst_laborea")
                        明細書入力.CategoryList(明細書入力.SelectRow + 2, 2) = Math.Floor(明細書入力.DetailsList(明細書入力.SelectRow, 6) * 明細書入力.CategoryList(明細書入力.SelectRow + 1, 2))
                        明細書入力.CategoryList(明細書入力.SelectRow + 1, 3) = ProjectCostReader.Item("prjctcst_materialea")
                        明細書入力.CategoryList(明細書入力.SelectRow + 2, 3) = Math.Floor(明細書入力.DetailsList(明細書入力.SelectRow, 6) * 明細書入力.CategoryList(明細書入力.SelectRow + 1, 3))
                        明細書入力.CategoryList(明細書入力.SelectRow + 1, 4) = ProjectCostReader.Item("prjctcst_machineea")
                        明細書入力.CategoryList(明細書入力.SelectRow + 2, 4) = Math.Floor(明細書入力.DetailsList(明細書入力.SelectRow, 6) * 明細書入力.CategoryList(明細書入力.SelectRow + 1, 4))
                        明細書入力.CategoryList(明細書入力.SelectRow + 1, 5) = ProjectCostReader.Item("prjctcst_subcntrctea")
                        明細書入力.CategoryList(明細書入力.SelectRow + 2, 5) = Math.Floor(明細書入力.DetailsList(明細書入力.SelectRow, 6) * 明細書入力.CategoryList(明細書入力.SelectRow + 1, 5))
                        明細書入力.CategoryList(明細書入力.SelectRow + 1, 6) = ProjectCostReader.Item("prjctcst_expenseea")
                        明細書入力.CategoryList(明細書入力.SelectRow + 2, 6) = Math.Floor(明細書入力.DetailsList(明細書入力.SelectRow, 6) * 明細書入力.CategoryList(明細書入力.SelectRow + 1, 6))

                    End While
                    ProjectCostReader.Close()
                End If

                Dim CancelClick As String = ""
                Dim CancelClickLoad As New CancelClick(ホーム.ProjectCostForm(FormCount - 1))
                CancelClick = CancelClickLoad.ModifyCheck

                明細書入力.Visible = True
            ElseIf (FormCount - 2) >= 0 Then
                If Not ホーム.ProjectCommand = "CostCopy" Then
                    ホーム.ProjectCostID(FormCount - 1) = CostID

                    Dim ProjectCostID As Integer = ホーム.ProjectCostID(FormCount - 1)
                    Dim ProjectCostRow As Integer = ホーム.ProjectCostSelectRow(FormCount - 1)
                    Dim ProjectCostList As C1FlexGrid = ホーム.PrjctCstList(FormCount - 1)

                    ホーム.Sql.CommandText = "SELECT * FROM project_costs WHERE prjctcst_id=" & ProjectCostID
                    Dim ProjectCostReader As SqlDataReader = ホーム.Sql.ExecuteReader
                    While ProjectCostReader.Read
                        ProjectCostList(ProjectCostRow, 4) = ProjectCostReader.Item("prjctcst_name")
                        ProjectCostList(ProjectCostRow + 1, 4) = ProjectCostReader.Item("prjctcst_spec")
                        ProjectCostList(ProjectCostRow + 2, 4) = CostNo.Text
                        ProjectCostList(ProjectCostRow + 2, 5) = ProjectCostReader.Item("prjctcst_unit")
                        ProjectCostList(ProjectCostRow + 1, 6) = ProjectCostReader.Item("prjctcst_costea")
                        ProjectCostList(ProjectCostRow, 8) = ProjectCostReader.Item("cstclss_code")
                        ProjectCostList(ProjectCostRow, 9) = ProjectCostID
                        ProjectCostList(ProjectCostRow + 2, 6) = Math.Floor(ProjectCostList(ProjectCostRow, 6) * ProjectCostList(ProjectCostRow + 1, 6))
                        ProjectCostList(ProjectCostRow + 1, 10) = ProjectCostReader.Item("prjctcst_laborea")
                        ProjectCostList(ProjectCostRow + 2, 10) = Math.Floor(ProjectCostList(ProjectCostRow, 6) * ProjectCostList(ProjectCostRow + 1, 10))
                        ProjectCostList(ProjectCostRow + 1, 11) = ProjectCostReader.Item("prjctcst_materialea")
                        ProjectCostList(ProjectCostRow + 2, 11) = Math.Floor(ProjectCostList(ProjectCostRow, 6) * ProjectCostList(ProjectCostRow + 1, 11))
                        ProjectCostList(ProjectCostRow + 1, 12) = ProjectCostReader.Item("prjctcst_machineea")
                        ProjectCostList(ProjectCostRow + 2, 12) = Math.Floor(ProjectCostList(ProjectCostRow, 6) * ProjectCostList(ProjectCostRow + 1, 12))
                        ProjectCostList(ProjectCostRow + 1, 13) = ProjectCostReader.Item("prjctcst_subcntrctea")
                        ProjectCostList(ProjectCostRow + 2, 13) = Math.Floor(ProjectCostList(ProjectCostRow, 6) * ProjectCostList(ProjectCostRow + 1, 13))
                        ProjectCostList(ProjectCostRow + 1, 14) = ProjectCostReader.Item("prjctcst_expenseea")
                        ProjectCostList(ProjectCostRow + 2, 14) = Math.Floor(ProjectCostList(ProjectCostRow, 6) * ProjectCostList(ProjectCostRow + 1, 14))

                    End While
                    ProjectCostReader.Close()
                End If

                Dim CancelClick As String = ""
                Dim CancelClickLoad As New CancelClick(ホーム.ProjectCostForm(FormCount - 1))
                CancelClick = CancelClickLoad.ModifyCheck

                ホーム.ProjectCostForm(FormCount - 2).Visible = True
            Else
                ホーム.Modified = "False"

            End If

            ホーム.ProjectCostForm.RemoveAt(FormCount - 1)
            ホーム.ProjectCostID.RemoveAt(FormCount - 1)
            ホーム.ProjectCostSelectRow.RemoveAt(FormCount - 1)
            ホーム.PrjctCstClassCode.RemoveAt(FormCount - 1)
            ホーム.PrjctCstList.RemoveAt(FormCount - 1)

            FormCount = ホーム.ProjectCostForm.Count

            ホーム.Sql.CommandText = ""
            ホーム.Sql.Parameters.Clear()

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try

    End Sub

    Private Sub CostQuanity_ValueChanged(sender As Object, e As EventArgs) Handles CostQuanity.ValueChanged
        Try

            If CostQuanity.Text <> "" AndAlso CostQuanity.Value > 0 Then
                If CostUnitPrice.Text <> "" Then
                    Dim Costea As Int64 = Math.Floor(CostUnitPrice.Value / CostQuanity.Value)
                    CostCostea.Value = Costea
                End If

                Dim Laborea As Int64 = Math.Floor(LaborTotal.Value / CostQuanity.Value)
                LaborCostea.Value = Laborea

                Dim Materialea As Int64 = Math.Floor(MaterialTotal.Value / CostQuanity.Value)
                MaterialCostea.Value = Materialea

                Dim Machineea As Int64 = Math.Floor(MachineTotal.Value / CostQuanity.Value)
                MachineCostea.Value = Machineea

                Dim Subcntrctea As Int64 = Math.Floor(SubcntrctTotal.Value / CostQuanity.Value)
                SubcntrctCostea.Value = Subcntrctea

                Dim Expenseea As Int64 = Math.Floor(ExpenseTotal.Value / CostQuanity.Value)
                ExpensCostea.Value = Expenseea

                BreakDownList.AllowEditing = True

            ElseIf CostQuanity.Text <> "" AndAlso CostQuanity.Value = 0 Then
                CostCostea.Value = 0
                LaborCostea.Value = 0
                MaterialCostea.Value = 0
                MachineCostea.Value = 0
                SubcntrctCostea.Value = 0
                ExpensCostea.Value = 0
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub 代価表入力_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        Try

            If CostName.Text <> "" Then

                Dim RowNo As Integer = 0
                Dim ColTotal As Int64 = 0
                Dim LaborColTotal As Int64 = 0
                Dim MaterialColTotal As Int64 = 0
                Dim MachineColTotal As Int64 = 0
                Dim SubcntrctColTotal As Int64 = 0
                Dim ExpenseColTotal As Int64 = 0


                For RowCount As Integer = 1 To ((BreakDownList.Rows.Count - 3) / 3)

                    ColTotal += BreakDownList((RowCount * 3) + 2, 6)
                    LaborColTotal += BreakDownList((RowCount * 3) + 2, 10)
                    MaterialColTotal += BreakDownList((RowCount * 3) + 2, 11)
                    MachineColTotal += BreakDownList((RowCount * 3) + 2, 12)
                    SubcntrctColTotal += BreakDownList((RowCount * 3) + 2, 13)
                    ExpenseColTotal += BreakDownList((RowCount * 3) + 2, 14)

                Next

                CostUnitPrice.Value = ColTotal
                Dim Costea As Int64 = Math.Floor(ColTotal / CostQuanity.Value)
                CostCostea.Value = Costea

                LaborTotal.Value = LaborColTotal
                Dim Laborea As Int64 = Math.Floor(LaborColTotal / CostQuanity.Value)
                LaborCostea.Value = Laborea

                MaterialTotal.Value = MaterialColTotal
                Dim Materialea As Int64 = Math.Floor(MaterialColTotal / CostQuanity.Value)
                MaterialCostea.Value = Materialea

                MachineTotal.Value = MachineColTotal
                Dim Machineea As Int64 = Math.Floor(MachineColTotal / CostQuanity.Value)
                MachineCostea.Value = Machineea

                SubcntrctTotal.Value = SubcntrctColTotal
                Dim Subcntrctea As Int64 = Math.Floor(SubcntrctColTotal / CostQuanity.Value)
                SubcntrctCostea.Value = Subcntrctea

                ExpenseTotal.Value = ExpenseColTotal
                Dim Expenseea As Int64 = Math.Floor(ExpenseColTotal / CostQuanity.Value)
                ExpensCostea.Value = Expenseea


            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub BreakDownList_DoubleClick(sender As Object, e As EventArgs) Handles BreakDownList.DoubleClick

        Try
            Dim range As CellRange = BreakDownList.CursorCell

            Dim row As Integer = range.TopRow
            Dim col As Integer = range.LeftCol

            If col = 4 Or col = 5 Then
                BreakDownList.Rows(row).AllowEditing = True
            Else
                BreakDownList.Rows(row).AllowEditing = False
            End If

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub BreakDownList_CellChanged(sender As Object, e As RowColEventArgs) Handles BreakDownList.CellChanged
        Try
            If Not Command = "Insert" AndAlso Not Command = "Cut" AndAlso Not Command = "Pasting" Then
                Dim RowNo As Integer = 0
                Dim ColTotal As Int64 = 0
                Dim LaborColTotal As Int64 = 0
                Dim MaterialColTotal As Int64 = 0
                Dim MachineColTotal As Int64 = 0
                Dim SubcntrctColTotal As Int64 = 0
                Dim ExpenseColTotal As Int64 = 0


                For RowCount As Integer = 1 To ((BreakDownList.Rows.Count - 3) / 3)

                    Dim Quanity As Decimal = 0
                    If IsDBNull(BreakDownList(RowCount * 3, 6)) = False Then
                        Quanity = BreakDownList(RowCount * 3, 6)
                        BreakDownList((RowCount * 3) + 2, 6) = Math.Floor(BreakDownList((RowCount * 3) + 1, 6) * Quanity)
                        BreakDownList((RowCount * 3) + 2, 10) = Math.Floor(BreakDownList((RowCount * 3) + 1, 10) * Quanity)
                        BreakDownList((RowCount * 3) + 2, 11) = Math.Floor(BreakDownList((RowCount * 3) + 1, 11) * Quanity)
                        BreakDownList((RowCount * 3) + 2, 12) = Math.Floor(BreakDownList((RowCount * 3) + 1, 12) * Quanity)
                        BreakDownList((RowCount * 3) + 2, 13) = Math.Floor(BreakDownList((RowCount * 3) + 1, 13) * Quanity)
                        BreakDownList((RowCount * 3) + 2, 14) = Math.Floor(BreakDownList((RowCount * 3) + 1, 14) * Quanity)
                    End If

                    ColTotal += BreakDownList((RowCount * 3) + 2, 6)
                    LaborColTotal += BreakDownList((RowCount * 3) + 2, 10)
                    MaterialColTotal += BreakDownList((RowCount * 3) + 2, 11)
                    MachineColTotal += BreakDownList((RowCount * 3) + 2, 12)
                    SubcntrctColTotal += BreakDownList((RowCount * 3) + 2, 13)
                    ExpenseColTotal += BreakDownList((RowCount * 3) + 2, 14)

                Next

                If IsDBNull(CostQuanity.Value) = False Then
                    CostUnitPrice.Value = ColTotal
                    Dim Costea As Int64 = Math.Floor(ColTotal / CostQuanity.Value)
                    CostCostea.Value = Costea
                End If

                If IsDBNull(CostQuanity.Value) = False Then
                    LaborTotal.Value = LaborColTotal
                    Dim Laborea As Int64 = Math.Floor(LaborColTotal / CostQuanity.Value)
                    LaborCostea.Value = Laborea
                End If

                If IsDBNull(CostQuanity.Value) = False Then
                    MaterialTotal.Value = MaterialColTotal
                    Dim Materialea As Int64 = Math.Floor(MaterialColTotal / CostQuanity.Value)
                    MaterialCostea.Value = Materialea
                End If

                If IsDBNull(CostQuanity.Value) = False Then
                    MachineTotal.Value = MachineColTotal
                    Dim Machineea As Int64 = Math.Floor(MachineColTotal / CostQuanity.Value)
                    MachineCostea.Value = Machineea
                End If

                If IsDBNull(CostQuanity.Value) = False Then
                    SubcntrctTotal.Value = SubcntrctColTotal
                    Dim Subcntrctea As Int64 = Math.Floor(SubcntrctColTotal / CostQuanity.Value)
                    SubcntrctCostea.Value = Subcntrctea
                End If

                If IsDBNull(CostQuanity.Value) = False Then
                    ExpenseTotal.Value = ExpenseColTotal
                    Dim Expenseea As Int64 = Math.Floor(ExpenseColTotal / CostQuanity.Value)
                    ExpensCostea.Value = Expenseea
                End If
            End If

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub 代価表入力_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        ホーム.ProjectCommand = ""

    End Sub

    Private Sub BreakDownList_Click(sender As Object, e As EventArgs) Handles BreakDownList.Click
        Try

            If BreakDownList.AllowEditing = False Then

                MsgBox("代価表[数量]を入力して下さい。", MsgBoxStyle.Exclamation, "代価表入力")

            Else


                Dim SelectionRow As Integer = BreakDownList.Selection.TopRow
                Dim SelectionCol As Integer = BreakDownList.Selection.LeftCol

                If SelectionRow > 0 Then
                    If BreakDownList(SelectionRow, 7) = 1 Or BreakDownList(SelectionRow, 7) = 4 Then
                        If SelectionCol = 4 Or SelectionCol = 5 Then
                            BreakDownList.Rows(SelectionRow + 2).AllowEditing = True
                        Else
                            Dim SelectRange As CellRange = BreakDownList.GetCellRange(SelectionRow + 2, SelectionCol)
                            BreakDownList.Rows(SelectionRow + 2).AllowEditing = False
                        End If
                    ElseIf BreakDownList(SelectionRow, 7) = 2 Or BreakDownList(SelectionRow, 7) = 5 Then
                        If SelectionCol = 4 Or SelectionCol = 5 Then
                            BreakDownList.Rows(SelectionRow + 1).AllowEditing = True
                        Else
                            BreakDownList.Rows(SelectionRow + 1).AllowEditing = False
                        End If
                    ElseIf BreakDownList(SelectionRow, 7) = 3 Or BreakDownList(SelectionRow, 7) = 6 Then
                        If SelectionCol = 4 Or SelectionCol = 5 Then
                            BreakDownList.Rows(SelectionRow).AllowEditing = True
                        Else
                            BreakDownList.Rows(SelectionRow).AllowEditing = False
                        End If
                    End If
                End If

                If SelectionCol >= 6 Then
                    BreakDownList.ImeMode = ImeMode.Disable
                Else
                    BreakDownList.ImeMode = ImeMode.On
                End If
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

            Dim SelectionRow As Integer = BreakDownList.Selection.TopRow
            Dim SelectionCol As Integer = BreakDownList.Selection.LeftCol

            BreakDownList(SelectionRow, SelectionCol) = ""

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub BreakDownList_StartEdit(sender As Object, e As RowColEventArgs) Handles BreakDownList.StartEdit
        Try


            Dim SelectionCol As Integer = BreakDownList.Selection.LeftCol


            If SelectionCol >= 6 Then
                BreakDownList.ImeMode = ImeMode.Disable
            Else
                BreakDownList.ImeMode = ImeMode.On
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub BreakDownList_KeyDown(sender As Object, e As KeyEventArgs) Handles BreakDownList.KeyDown
        Try



            If e.KeyCode = Keys.Enter Then




                Key = "enter"

                Dim SelectionCol As Integer = BreakDownList.Selection.LeftCol
                Dim SelectionRow As Integer = BreakDownList.Selection.TopRow

                Dim RowIndex As Integer = BreakDownList(SelectionRow, 7)

                If RowIndex = 3 Or RowIndex = 6 Then
                    If SelectionCol = 4 Then
                        SendKeys.Send("{ENTER}")
                        BreakDownList.Select(SelectionRow - 1, 5)

                    ElseIf SelectionCol = 5 Then
                        SendKeys.Send("{ENTER}")
                        BreakDownList.Select(SelectionRow - 3, 6)
                    Else
                        SendKeys.Send("{ENTER}")
                    End If
                ElseIf RowIndex = 2 Or RowIndex = 5 Then
                    If SelectionCol = 6 Then
                        SendKeys.Send("{ENTER}")

                        SendKeys.Send("{UP}")
                        SendKeys.Send("{RIGHT}")
                    ElseIf SelectionCol = 10 Then
                        SendKeys.Send("{ENTER}")

                        SendKeys.Send("{UP}")
                        SendKeys.Send("{RIGHT}")
                    ElseIf SelectionCol = 11 Then
                        SendKeys.Send("{ENTER}")

                        SendKeys.Send("{UP}")
                        SendKeys.Send("{RIGHT}")
                    ElseIf SelectionCol = 12 Then
                        SendKeys.Send("{ENTER}")

                        SendKeys.Send("{UP}")
                        SendKeys.Send("{RIGHT}")
                    ElseIf SelectionCol = 13 Then
                        SendKeys.Send("{ENTER}")
                        SendKeys.Send("{UP}")
                        SendKeys.Send("{RIGHT}")
                    ElseIf SelectionCol = 14 Then
                        If BreakDownList(SelectionRow + 2, 7) = 1 Or BreakDownList(SelectionRow + 2, 7) = 4 Then
                            BreakDownList.Select(SelectionRow + 2, 4)
                            SendKeys.Send("{DOWN}")
                            SendKeys.Send("{UP}")

                        Else
                            BreakDownList.Select(SelectionRow + 1, 4)
                        End If
                    Else
                        SendKeys.Send("{ENTER}")
                    End If
                Else
                    SendKeys.Send("{ENTER}")
                End If
            End If


        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try

    End Sub

    Private Sub BreakDownList_RowColChange(sender As Object, e As EventArgs) Handles BreakDownList.RowColChange

        Dim SelectionCol As Integer = BreakDownList.Selection.LeftCol


        If SelectionCol >= 6 Then
            BreakDownList.ImeMode = ImeMode.Disable
        Else
            BreakDownList.ImeMode = ImeMode.On
        End If
    End Sub

    Private Sub CostName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CostName.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub CostQuanity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CostQuanity.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub CostUnit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CostUnit.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub CostUnitPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CostUnitPrice.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub CostCostea_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CostCostea.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub CostSpec_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CostSpec.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub CostNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CostNo.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub
End Class