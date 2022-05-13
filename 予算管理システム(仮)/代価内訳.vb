Imports C1.Win.C1FlexGrid
Imports System.Windows.Forms.Form
Imports C1.Win.C1Command
Imports System.Data.SqlClient
Imports C1.Win.C1Input
Imports System.Windows.Input.Keyboard
Public Class 代価内訳
    Public SelectRow As Integer = 1
    Public CopyList(10) As String
    Public CostID As Integer = 0
    Public ClassCode As Integer
    Public Command As String
    Dim Key As String
    Private Sub 代価内訳_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        BreakDownList.Rows(0).Height = 17
        BreakDownList.Rows(1).Height = 17
        BreakDownList.Rows(2).Height = 17


        Me.Anchor = AnchorStyles.Top
        Me.Anchor = AnchorStyles.Left
        Me.Anchor = AnchorStyles.Bottom

        If CostQuanity.Text <> "" Then

            BreakDownList.AllowEditing = True
            BreakDownList.ContextMenuStrip.Visible = True
        Else

            BreakDownList.AllowEditing = False
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

        If ホーム.BeforeForm = "基礎代価一覧" Then
            '基礎代価　新規
            If CostID = 0 Then
                ホーム.SystemSql.CommandText = "SELECT Count(*) FROM basis_costs WHERE cstclss_code=" & ClassCode
                Dim CostCount As Integer = ホーム.SystemSql.ExecuteScalar

                Dim MaxNo As Integer = 0

                If CostCount > 0 Then
                    ホーム.SystemSql.CommandText = "SELECT MAX(bsscst_no) FROM basis_costs WHERE cstclss_code=" & ClassCode
                    MaxNo = ホーム.SystemSql.ExecuteScalar
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
                If ClassName = "基礎代価" Then
                    CostNo.Text = "第K" & "-" & No & "号"
                Else
                    CostNo.Text = "第" & ClassName.Last & "-" & No & "号"
                End If

                '基礎代価　編集
            Else
                Dim CreateCostID As Integer = CostID

                ホーム.SystemSql.CommandText = "SELECT * FROM basis_costs WHERE bsscst_id=" & CreateCostID
                Dim ProjectCostsReader As SqlDataReader = ホーム.SystemSql.ExecuteReader
                While ProjectCostsReader.Read
                    CostCostea.Text = ProjectCostsReader.Item("bsscst_costea")
                    BreakDownList.AllowEditing = True
                    Dim labor As Int64 = ProjectCostsReader.Item("bsscst_laborea")
                    LaborCostea.Value = labor
                    Dim material As Int64 = ProjectCostsReader.Item("bsscst_materialea")
                    MaterialCostea.Value = material
                    Dim machine As Int64 = ProjectCostsReader.Item("bsscst_machineea")
                    MachineCostea.Value = machine
                    Dim subcntrct As Int64 = ProjectCostsReader.Item("bsscst_subcnstrctea")
                    SubcntrctCostea.Value = subcntrct
                    Dim expense As Int64 = ProjectCostsReader.Item("bsscst_expnseea")
                    ExpensCostea.Value = expense
                End While
                ProjectCostsReader.Close()

                Dim No As String = CostID.ToString
                If No.Length = 1 Then
                    No = "0000" & No
                ElseIf No.Length = 2 Then
                    No = "000" & No
                ElseIf No.Length = 3 Then
                    No = "00" & No
                ElseIf No.Length = 4 Then
                    No = "0" & No
                End If
                If ClassName = "基礎代価" Then
                    CostNo.Text = "第K" & "-" & No & "号"
                Else
                    CostNo.Text = "第" & ClassName.Last & "-" & No & "号"
                End If
                CostName.Text = 代価一覧.ProjectCostList(代価一覧.SelectRow, 4)
                CostSpec.Text = 代価一覧.ProjectCostList(代価一覧.SelectRow, 5)
                CostUnit.Text = 代価一覧.ProjectCostList(代価一覧.SelectRow, 6)
                CostQuanity.Text = 代価一覧.ProjectCostList(代価一覧.SelectRow, 7)

                ホーム.SystemSql.CommandText = "SELECT bsscst_amount FROM basis_costs_view WHERE bsscst_id=" & CreateCostID
                CostUnitPrice.Value = ホーム.SystemSql.ExecuteScalar

                '内訳数取得？
                ホーム.SystemSql.CommandText = "SELECT Count(*) FROM basis_cost_breakdowns WHERE bsscst_id=" & CreateCostID
                Dim BreakDownCount As Integer = ホーム.SystemSql.ExecuteScalar

                '内訳数によって行数を指定
                If BreakDownCount > 5 Then
                    BreakDownList.Rows.Count = (BreakDownCount * 3) + 6
                Else
                    BreakDownList.Rows.Count = 21
                End If

                Dim RowCount As Integer = 0
                Dim RowNo As Integer = 0

                'Dim OutsrcngSql As New SqlCommand
                'OutsrcngSql.Connection = ホーム.Connection

                '内訳があるとき
                If BreakDownCount > 0 Then
                    'IDを指定して基礎代価内訳テーブルから取得
                    ホーム.SystemSql.CommandText = "SELECT * FROM basis_cost_breakdowns WHERE bsscst_id=" & CreateCostID & " ORDER BY bsscst_bd_no ASC "
                    Dim BreakDownReader As SqlDataReader = ホーム.SystemSql.ExecuteReader
                    While BreakDownReader.Read
                        RowCount += 1
                        RowNo += 1
                        If 作成代価選択.Visible = True AndAlso 作成代価選択.Text = "コピー代価選択" Then
                            BreakDownList(RowCount * 3, 1) = 0
                        Else
                            BreakDownList(RowCount * 3, 1) = BreakDownReader.Item("bsscst_bd_id")
                        End If
                        BreakDownList(RowCount * 3, 9) = BreakDownReader.Item("cstmstr_id")
                        BreakDownList(RowCount * 3, 8) = BreakDownReader.Item("cstclss_code")
                        BreakDownList(RowCount * 3, 3) = BreakDownReader.Item("bsscst_bd_no")
                        BreakDownList(RowCount * 3, 4) = BreakDownReader.Item("bsscst_bd_name")

                        BreakDownList((RowCount * 3) + 1, 4) = BreakDownReader.Item("bsscst_bd_spec")
                        BreakDownList((RowCount * 3) + 2, 4) = BreakDownReader.Item("bsscst_bd_remarks")
                        BreakDownList((RowCount * 3) + 2, 5) = BreakDownReader.Item("bsscst_bd_unit")
                        BreakDownList(RowCount * 3, 6) = BreakDownReader.Item("bsscst_bd_quanity")
                        Dim Quanity As CellRange = BreakDownList.GetCellRange(RowCount * 3, 6)
                        Quanity.StyleNew.Format = "N1"
                        BreakDownList((RowCount * 3) + 1, 6) = BreakDownReader.Item("bsscst_bd_costea")
                        Dim Costea As CellRange = BreakDownList.GetCellRange(RowCount * 3 + 1, 6)
                        Costea.StyleNew.Format = "N0"
                        BreakDownList((RowCount * 3) + 2, 6) = Math.Floor((BreakDownReader.Item("bsscst_bd_quanity") * BreakDownReader.Item("bsscst_bd_costea")))
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

                        BreakDownList((RowCount * 3) + 1, 10) = BreakDownReader.Item("bsscst_bd_labor")
                        BreakDownList((RowCount * 3) + 1, 11) = BreakDownReader.Item("bsscst_bd_material")
                        BreakDownList((RowCount * 3) + 1, 12) = BreakDownReader.Item("bsscst_bd_machine")
                        BreakDownList((RowCount * 3) + 1, 13) = BreakDownReader.Item("bsscst_bd_subcntrct")
                        BreakDownList((RowCount * 3) + 1, 14) = BreakDownReader.Item("bsscst_bd_expense")
                        BreakDownList((RowCount * 3) + 2, 10) = Math.Floor(BreakDownReader.Item("bsscst_bd_quanity") * BreakDownReader.Item("bsscst_bd_labor"))
                        BreakDownList((RowCount * 3) + 2, 11) = Math.Floor(BreakDownReader.Item("bsscst_bd_quanity") * BreakDownReader.Item("bsscst_bd_material"))
                        BreakDownList((RowCount * 3) + 2, 12) = Math.Floor(BreakDownReader.Item("bsscst_bd_quanity") * BreakDownReader.Item("bsscst_bd_machine"))
                        BreakDownList((RowCount * 3) + 2, 13) = Math.Floor(BreakDownReader.Item("bsscst_bd_quanity") * BreakDownReader.Item("bsscst_bd_subcntrct"))
                        BreakDownList((RowCount * 3) + 2, 14) = Math.Floor(BreakDownReader.Item("bsscst_bd_quanity") * BreakDownReader.Item("bsscst_bd_expense"))

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

                    ホーム.SystemSql.CommandText = "SELECT * FROM basiscst_bd_total WHERE bsscst_id=" & CreateCostID
                    Dim TotalReader As SqlDataReader = ホーム.SystemSql.ExecuteReader
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

            End If



        ElseIf ホーム.BeforeForm = "工事代価一覧" Then

            '工事代価　新規
            If CostID = 0 Then
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
                If ClassName = "基礎代価" Then
                    CostNo.Text = "第K" & "-" & No & "号"
                Else
                    CostNo.Text = "第" & ClassName.Last & "-" & No & "号"
                End If

                '工事代価　編集
            Else
                Dim CreateCostID As Integer = CostID

                ホーム.Sql.CommandText = "SELECT * FROM project_costs WHERE prjctcst_id=" & CreateCostID
                Dim ProjectCostsReader As SqlDataReader = ホーム.Sql.ExecuteReader
                While ProjectCostsReader.Read
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

                Dim No As String = CostID.ToString
                If No.Length = 1 Then
                    No = "0000" & No
                ElseIf No.Length = 2 Then
                    No = "000" & No
                ElseIf No.Length = 3 Then
                    No = "00" & No
                ElseIf No.Length = 4 Then
                    No = "0" & No
                End If
                If ClassName = "基礎代価" Then
                    CostNo.Text = "第K" & "-" & No & "号"
                Else
                    CostNo.Text = "第" & ClassName.Last & "-" & No & "号"
                End If
                CostName.Text = 代価一覧.ProjectCostList(代価一覧.SelectRow, 4)
                CostSpec.Text = 代価一覧.ProjectCostList(代価一覧.SelectRow, 5)
                CostUnit.Text = 代価一覧.ProjectCostList(代価一覧.SelectRow, 6)
                CostQuanity.Text = 代価一覧.ProjectCostList(代価一覧.SelectRow, 7)

                ホーム.Sql.CommandText = "SELECT prjctcst_costea FROM project_costs WHERE prjctcst_id=" & CreateCostID
                CostUnitPrice.Value = ホーム.Sql.ExecuteScalar

                '内訳数取得？
                ホーム.Sql.CommandText = "SELECT Count(*) FROM project_cost_breakdowns WHERE prjctcst_id=" & CreateCostID
                Dim BreakDownCount As Integer = ホーム.Sql.ExecuteScalar

                '内訳数によって行数を指定
                If BreakDownCount > 5 Then
                    BreakDownList.Rows.Count = (BreakDownCount * 3) + 6
                Else
                    BreakDownList.Rows.Count = 21
                End If

                Dim RowCount As Integer = 0
                Dim RowNo As Integer = 0

                'Dim OutsrcngSql As New SqlCommand
                'OutsrcngSql.Connection = ホーム.Connection

                '内訳があるとき
                If BreakDownCount > 0 Then
                    'IDを指定して工事代価内訳テーブルから取得
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
                        ExpenseTotal.Text = TotalReader.Item("expens")
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

            End If
        End If



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

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        代価一覧.Visible = True
        Me.Close()
    End Sub

    Private Sub Entry_Click(sender As Object, e As EventArgs) Handles Entry.Click
        Me.Close()
    End Sub

    Private Sub ItemSelect_Click(sender As Object, e As EventArgs) Handles ItemSelect.Click
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

    Private Sub ItemSelectMenu_Click(sender As Object, e As EventArgs) Handles ItemSelectMenu.Click
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

    Private Sub InsertMenu_Click(sender As Object, e As EventArgs) Handles InsertMenu.Click
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

    Private Sub CopyMenu_Click(sender As Object, e As EventArgs) Handles CopyMenu.Click
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

    Private Sub PastingMenu_Click(sender As Object, e As EventArgs) Handles PastingMenu.Click
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

    Private Sub CutMenu_Click(sender As Object, e As EventArgs) Handles CutMenu.Click
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

    Private Sub BreakDownList_AfterFilter(sender As Object, e As EventArgs) Handles BreakDownList.AfterFilter
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

    Private Sub 代価内訳_Closed(sender As Object, e As EventArgs) Handles Me.Closed
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
End Class