Imports C1.Win.C1FlexGrid
Imports System.Windows.Forms.Form
Imports C1.Win.C1Command
Imports System.Data.SqlClient
Imports C1.Win.C1Input
Imports System.Windows.Input.Keyboard
Imports System.ComponentModel

Public Class 代価内訳
    Public SelectRow As Integer = 1
    'Public CopyList(10) As String
    Public CopyRow As Integer = 0
    Public CostID As Integer = 0
    Public ClassCode As Integer
    Public Command As String
    Public Command1 As String
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



        If ホーム.BeforeForm = "基礎代価一覧" Or ホーム.BeforeForm = "基礎代価" Then
            'ログインユーザが管理者でない時、編集を無効にする
            If ホーム.AdminChk = "False" Then
                BreakDownList.AllowEditing = False
                Entry.Visible = False
            End If

            '基礎代価　新規
            If CostID = 0 Then
                ホーム.SystemSql.CommandText = "SELECT Count(*) FROM basis_costs WHERE cstclss_code=" & ClassCode
                Dim CostCount As Integer = ホーム.SystemSql.ExecuteScalar

                Dim MaxNo As Integer = 0
                Dim RowNo As Integer = 0
                BreakDownList.Rows.Count = 21

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

                '基礎代価　編集
            Else
                Dim CreateCostID As Integer = CostID

                ホーム.SystemSql.CommandText = "SELECT * FROM basis_costs WHERE bsscst_id=" & CreateCostID
                Dim ProjectCostsReader As SqlDataReader = ホーム.SystemSql.ExecuteReader
                Dim No As String = ""
                While ProjectCostsReader.Read
                    No = ProjectCostsReader.Item("bsscst_no")
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

                ホーム.SystemSql.CommandText = "SELECT MAX(bsscst_no) FROM basis_costs WHERE cstclss_code=" & ClassCode
                Dim PrjctNo As Integer = ホーム.SystemSql.ExecuteScalar

                'Dim No As String = PrjctNo.ToString
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

                If 作成代価選択.Visible = True AndAlso 作成代価選択.Text = "コピー代価選択" Then
                    BreakDownList.AllowEditing = True
                    Entry.Visible = True
                    ClassCode = 作成代価選択.CopyClassCode
                    ホーム.Sql.CommandText = "SELECT Count(*) FROM project_costs WHERE cstclss_code=" & ClassCode
                    Dim CostCount As Integer = ホーム.Sql.ExecuteScalar

                    Dim MaxNo As Integer = 0

                    If CostCount > 0 Then
                        ホーム.Sql.CommandText = "SELECT MAX(prjctcst_no) FROM project_costs WHERE cstclss_code=" & ClassCode
                        MaxNo = ホーム.Sql.ExecuteScalar
                    End If

                    No = MaxNo + 1
                    If No.Length = 1 Then
                        No = "0000" & No
                    ElseIf No.Length = 2 Then
                        No = "000" & No
                    ElseIf No.Length = 3 Then
                        No = "00" & No
                    ElseIf No.Length = 4 Then
                        No = "0" & No
                    End If
                    CostNo.Text = "第" & 代価一覧.CostClassName.Last & "-" & No & "号"
                    CostID = 0
                    CostCopy.Visible = False
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



        ElseIf ホーム.BeforeForm = "工事代価一覧" Or ホーム.BeforeForm = "工事代価" Then
            CostCopy.Visible = False '------------------------------------------------------------------------------------------------------delete
            '工事代価　新規
            If CostID = 0 Then
                ホーム.Sql.CommandText = "SELECT Count(*) FROM project_costs WHERE cstclss_code=" & ClassCode
                Dim CostCount As Integer = ホーム.Sql.ExecuteScalar

                Dim MaxNo As Integer = 0
                Dim RowNo As Integer = 0
                BreakDownList.Rows.Count = 21

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


                '工事代価　編集
            Else
                Dim CreateCostID As Integer = CostID

                ホーム.Sql.CommandText = "SELECT * FROM project_costs WHERE prjctcst_id=" & CreateCostID
                Dim ProjectCostsReader As SqlDataReader = ホーム.Sql.ExecuteReader
                Dim No As String = ""
                While ProjectCostsReader.Read
                    No = ProjectCostsReader.Item("prjctcst_no")
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

                ホーム.Sql.CommandText = "SELECT MAX(prjctcst_no) FROM project_costs WHERE cstclss_code=" & ClassCode
                Dim PrjctNo As Integer = ホーム.Sql.ExecuteScalar
                'Dim No As String = PrjctNo.ToString
                If No.Length = 1 Then
                    No = "0000" & No
                ElseIf No.Length = 2 Then
                    No = "000" & No
                ElseIf No.Length = 3 Then
                    No = "00" & No
                ElseIf No.Length = 4 Then
                    No = "0" & No
                End If
                If 作成代価選択.CopyClassCode = 11 Then
                    CostNo.Text = "第K" & "-" & No & "号"
                Else
                    CostNo.Text = "第" & ClassName.Last & "-" & No & "号"
                End If

                If 作成代価選択.Visible = True AndAlso 作成代価選択.Text = "コピー代価選択" Then
                    ClassCode = 作成代価選択.CopyClassCode
                    ホーム.Sql.CommandText = "SELECT Count(*) FROM project_costs WHERE cstclss_code=" & ClassCode
                    Dim CostCount As Integer = ホーム.Sql.ExecuteScalar

                    Dim MaxNo As Integer = 0

                    If CostCount > 0 Then
                        ホーム.Sql.CommandText = "SELECT MAX(prjctcst_no) FROM project_costs WHERE cstclss_code=" & ClassCode
                        MaxNo = ホーム.Sql.ExecuteScalar
                    End If

                    No = MaxNo + 1
                    If No.Length = 1 Then
                        No = "0000" & No
                    ElseIf No.Length = 2 Then
                        No = "000" & No
                    ElseIf No.Length = 3 Then
                        No = "00" & No
                    ElseIf No.Length = 4 Then
                        No = "0" & No
                    End If
                    CostNo.Value = "第" & 代価一覧.CostClassName.Last & "-" & No & "号"
                    CostID = 0
                    CostCopy.Visible = False
                End If
                If IsDBNull(代価一覧.ProjectCostList(代価一覧.SelectRow, 4)) = True Then
                    CostName.Text = ""
                Else
                    CostName.Text = 代価一覧.ProjectCostList(代価一覧.SelectRow, 4)
                End If
                If IsDBNull(代価一覧.ProjectCostList(代価一覧.SelectRow, 5)) = True Then
                    CostSpec.Text = ""
                Else
                    CostSpec.Text = 代価一覧.ProjectCostList(代価一覧.SelectRow, 5)
                End If
                If IsDBNull(代価一覧.ProjectCostList(代価一覧.SelectRow, 6)) = True Then
                    CostUnit.Text = ""
                Else
                    CostUnit.Text = 代価一覧.ProjectCostList(代価一覧.SelectRow, 6)
                End If
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
            If CostQuanity.Text <> "" Then

                BreakDownList.AllowEditing = True
                BreakDownList.ContextMenuStrip.Visible = True
            Else

                BreakDownList.AllowEditing = False
                BreakDownList.ContextMenuStrip.Visible = False
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
        'If ClassCode = 11 Then
        '    代価一覧.CostClassName = "基礎代価"
        'ElseIf ClassCode > 11 Then
        '    代価一覧.CostClassName = "工事代価"
        'End If
        代価一覧.Show()
        代価一覧.Visible = True
        Me.Close()
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


            Dim No As String = CostNo.Text.Remove(0, 3)
            No = No.Replace("号", "")

            Dim CreateCostID As Integer = CostID

            '基礎代価登録
            If ClassCode = 11 Then

                ホーム.Transaction = ホーム.SystemSqlCnnctn.BeginTransaction

                ホーム.SystemSql.Transaction = ホーム.Transaction

                ホーム.SystemSql.CommandText = ""
                ホーム.SystemSql.Parameters.Clear()
                ホーム.SystemSql.Parameters.Add(New SqlParameter("@name", SqlDbType.NVarChar)).Value = CostName.Value
                If IsNothing(CostSpec.Value) = True Or Not CostSpec.Text <> "" Then
                    ホーム.SystemSql.Parameters.Add(New SqlParameter("@spec", SqlDbType.NVarChar)).Value = ""
                Else
                    ホーム.SystemSql.Parameters.Add(New SqlParameter("@spec", SqlDbType.NVarChar)).Value = CostSpec.Value
                End If
                ホーム.SystemSql.Parameters.Add(New SqlParameter("@unit", SqlDbType.NVarChar)).Value = CostUnit.Value
                ホーム.SystemSql.Parameters.Add(New SqlParameter("@quanity", SqlDbType.Decimal)).Value = CostQuanity.Value
                ホーム.SystemSql.Parameters.Add(New SqlParameter("@costea", SqlDbType.Money)).Value = CostCostea.Value
                If IsNothing(LaborCostea.Value) = True Or IsDBNull(LaborCostea.Value) = True Then
                    ホーム.SystemSql.Parameters.Add(New SqlParameter("@labor", SqlDbType.Money)).Value = 0
                Else
                    ホーム.SystemSql.Parameters.Add(New SqlParameter("@labor", SqlDbType.Money)).Value = LaborCostea.Value
                End If
                If IsNothing(MaterialCostea.Value) = True Or IsDBNull(MaterialCostea.Value) = True Then
                    ホーム.SystemSql.Parameters.Add(New SqlParameter("@material", SqlDbType.Money)).Value = 0
                Else
                    ホーム.SystemSql.Parameters.Add(New SqlParameter("@material", SqlDbType.Money)).Value = MaterialCostea.Value
                End If
                If IsNothing(MachineCostea.Value) = True Or IsDBNull(MachineCostea.Value) = True Then
                    ホーム.SystemSql.Parameters.Add(New SqlParameter("@machine", SqlDbType.Money)).Value = 0
                Else
                    ホーム.SystemSql.Parameters.Add(New SqlParameter("@machine", SqlDbType.Money)).Value = MachineCostea.Value
                End If
                If IsNothing(SubcntrctCostea.Value) = True Or IsDBNull(SubcntrctCostea.Value) = True Then
                    ホーム.SystemSql.Parameters.Add(New SqlParameter("@subcntrct", SqlDbType.Money)).Value = 0
                Else
                    ホーム.SystemSql.Parameters.Add(New SqlParameter("@subcntrct", SqlDbType.Money)).Value = SubcntrctCostea.Value
                End If
                If IsNothing(ExpensCostea.Value) = True Or IsDBNull(ExpensCostea.Value) = True Then
                    ホーム.SystemSql.Parameters.Add(New SqlParameter("@expense", SqlDbType.Money)).Value = 0
                Else
                    ホーム.SystemSql.Parameters.Add(New SqlParameter("@expense", SqlDbType.Money)).Value = ExpensCostea.Value
                End If

                If CostID = 0 Then
                    ホーム.SystemSql.Parameters.Add(New SqlParameter("@budgetno", SqlDbType.SmallInt)).Value = ホーム.BudgetNo
                    ホーム.SystemSql.Parameters.Add(New SqlParameter("@cstclsscode", SqlDbType.SmallInt)).Value = ClassCode
                    ホーム.SystemSql.Parameters.Add(New SqlParameter("@bsscstno", SqlDbType.SmallInt)).Value = Integer.Parse(No)
                    ホーム.SystemSql.Parameters.Add(New SqlParameter("@year", SqlDbType.SmallInt)).Value = 代価一覧.YearList.Text

                    ホーム.SystemSql.CommandText = "INSERT INTO basis_costs (year,cstclss_code,bsscst_no,bsscst_name,bsscst_spec,bsscst_unit,
                                          bsscst_quanity,bsscst_costea,bsscst_laborea,bsscst_materialea,bsscst_machineea,bsscst_subcnstrctea,bsscst_expnseea)
                                            VALUES (@year,@cstclsscode,@bsscstno,@name,@spec,@unit,@quanity,@costea,@labor,@material,@machine,@subcntrct,@expense)"
                    ホーム.SystemSql.ExecuteNonQuery()

                    ホーム.SystemSql.Parameters.Clear()
                    ホーム.SystemSql.CommandText = ""
                    ホーム.SystemSql.CommandText = "SELECT bsscst_id FROM basis_costs WHERE cstclss_code=" & ClassCode & " AND bsscst_no=" & Integer.Parse(No)
                    CreateCostID = ホーム.SystemSql.ExecuteScalar

                Else
                    ホーム.SystemSql.CommandText = "UPDATE basis_costs SET bsscst_name=@name,bsscst_spec=@spec,bsscst_unit=@unit,bsscst_quanity=@quanity,
                                          bsscst_costea=@costea,bsscst_laborea=@labor,bsscst_materialea=@material,bsscst_machineea=@machine,
                                          bsscst_subcnstrctea=@subcntrct,bsscst_expnseea=@expense WHERE bsscst_id=" & CreateCostID
                    ホーム.SystemSql.ExecuteNonQuery()

                End If

                '基礎代価内訳登録
                For RowCount As Integer = 1 To ((BreakDownList.Rows.Count - 3) / 3)
                    ホーム.SystemSql.CommandText = ""
                    ホーム.SystemSql.Parameters.Clear()
                    If IsNothing(BreakDownList(RowCount * 3, 4)) = False AndAlso IsNothing(BreakDownList(RowCount * 3, 3)) = False Then
                        If BreakDownList(RowCount * 3, 2) = "False" Or IsNothing(BreakDownList(RowCount * 3, 2)) = True Then
                            If IsNothing(BreakDownList(RowCount * 3, 8)) = True Then
                                ホーム.SystemSql.Parameters.Add(New SqlParameter("@cstclsscode", SqlDbType.SmallInt)).Value = 0
                                ホーム.SystemSql.Parameters.Add(New SqlParameter("@cstmstrid", SqlDbType.SmallInt)).Value = 0
                            Else
                                ホーム.SystemSql.Parameters.Add(New SqlParameter("@cstclsscode", SqlDbType.SmallInt)).Value = BreakDownList(RowCount * 3, 8)
                                ホーム.SystemSql.Parameters.Add(New SqlParameter("@cstmstrid", SqlDbType.SmallInt)).Value = BreakDownList(RowCount * 3, 9)
                            End If
                            ホーム.SystemSql.Parameters.Add(New SqlParameter("@bdno", SqlDbType.SmallInt)).Value = BreakDownList(RowCount * 3, 3)
                            ホーム.SystemSql.Parameters.Add(New SqlParameter("@bdname", SqlDbType.NVarChar)).Value = BreakDownList(RowCount * 3, 4)
                            If IsNothing(BreakDownList(RowCount * 3 + 1, 4)) = True Then
                                ホーム.SystemSql.Parameters.Add(New SqlParameter("@bdspec", SqlDbType.NVarChar)).Value = ""
                            Else
                                ホーム.SystemSql.Parameters.Add(New SqlParameter("@bdspec", SqlDbType.NVarChar)).Value = BreakDownList(RowCount * 3 + 1, 4)
                            End If
                            If IsNothing(BreakDownList(RowCount * 3 + 2, 5)) = True Then
                                ホーム.SystemSql.Parameters.Add(New SqlParameter("@bdunit", SqlDbType.NVarChar)).Value = ""
                            Else
                                ホーム.SystemSql.Parameters.Add(New SqlParameter("@bdunit", SqlDbType.NVarChar)).Value = BreakDownList(RowCount * 3 + 2, 5)
                            End If
                            If IsNothing(BreakDownList(RowCount * 3, 6)) = True Then
                                ホーム.SystemSql.Parameters.Add(New SqlParameter("@bdquanity", SqlDbType.Decimal)).Value = 0
                            Else
                                ホーム.SystemSql.Parameters.Add(New SqlParameter("@bdquanity", SqlDbType.Decimal)).Value = BreakDownList(RowCount * 3, 6)
                            End If
                            If IsNothing(BreakDownList(RowCount * 3 + 1, 6)) = True Then
                                ホーム.SystemSql.Parameters.Add(New SqlParameter("@bdcostea", SqlDbType.Money)).Value = 0
                            Else
                                ホーム.SystemSql.Parameters.Add(New SqlParameter("@bdcostea", SqlDbType.Money)).Value = BreakDownList(RowCount * 3 + 1, 6)
                            End If
                            If IsNothing(BreakDownList(RowCount * 3 + 1, 10)) = True Then
                                ホーム.SystemSql.Parameters.Add(New SqlParameter("@bdlabor", SqlDbType.Money)).Value = 0
                            Else
                                ホーム.SystemSql.Parameters.Add(New SqlParameter("@bdlabor", SqlDbType.Money)).Value = BreakDownList(RowCount * 3 + 1, 10)
                            End If
                            If IsNothing(BreakDownList(RowCount * 3 + 1, 11)) = True Then
                                ホーム.SystemSql.Parameters.Add(New SqlParameter("@bdmaterial", SqlDbType.Money)).Value = 0
                            Else
                                ホーム.SystemSql.Parameters.Add(New SqlParameter("@bdmaterial", SqlDbType.Money)).Value = BreakDownList(RowCount * 3 + 1, 11)
                            End If
                            If IsNothing(BreakDownList(RowCount * 3 + 1, 12)) = True Then
                                ホーム.SystemSql.Parameters.Add(New SqlParameter("@bdmachine", SqlDbType.Money)).Value = 0
                            Else
                                ホーム.SystemSql.Parameters.Add(New SqlParameter("@bdmachine", SqlDbType.Money)).Value = BreakDownList(RowCount * 3 + 1, 12)
                            End If
                            If IsNothing(BreakDownList(RowCount * 3 + 1, 13)) = True Then
                                ホーム.SystemSql.Parameters.Add(New SqlParameter("@bdsubcntrct", SqlDbType.Money)).Value = 0
                            Else
                                ホーム.SystemSql.Parameters.Add(New SqlParameter("@bdsubcntrct", SqlDbType.Money)).Value = BreakDownList(RowCount * 3 + 1, 13)
                            End If
                            If IsNothing(BreakDownList(RowCount * 3 + 1, 14)) = True Then
                                ホーム.SystemSql.Parameters.Add(New SqlParameter("@bdexpense", SqlDbType.Money)).Value = 0
                            Else
                                ホーム.SystemSql.Parameters.Add(New SqlParameter("@bdexpense", SqlDbType.Money)).Value = BreakDownList(RowCount * 3 + 1, 14)
                            End If
                            If IsNothing(BreakDownList(RowCount * 3 + 2, 4)) = True Then
                                ホーム.SystemSql.Parameters.Add(New SqlParameter("@bdremarks", SqlDbType.NVarChar)).Value = ""
                            Else
                                ホーム.SystemSql.Parameters.Add(New SqlParameter("@bdremarks", SqlDbType.NVarChar)).Value = BreakDownList(RowCount * 3 + 2, 4)
                            End If

                            If BreakDownList(RowCount * 3, 1) = 0 Then
                                ホーム.SystemSql.Parameters.Add(New SqlParameter("@bsscstid", SqlDbType.SmallInt)).Value = CreateCostID
                                ホーム.SystemSql.CommandText = "INSERT basis_cost_breakdowns (bsscst_id,cstclss_code,cstmstr_id,bsscst_bd_no,bsscst_bd_name,bsscst_bd_spec
                                                                   ,bsscst_bd_unit,bsscst_bd_quanity,bsscst_bd_costea,bsscst_bd_labor,bsscst_bd_material,bsscst_bd_machine,
                                                                    bsscst_bd_subcntrct,bsscst_bd_expense,bsscst_bd_remarks) 
                                                  VALUES (@bsscstid,@cstclsscode,@cstmstrid,@bdno,@bdname,@bdspec,@bdunit,@bdquanity,@bdcostea,
                                                  @bdlabor,@bdmaterial,@bdmachine,@bdsubcntrct,@bdexpense,@bdremarks)"
                            Else
                                ホーム.SystemSql.CommandText = "UPDATE basis_cost_breakdowns SET cstclss_code=@cstclsscode,cstmstr_id=@cstmstrid,bsscst_bd_no=@bdno,
                                                      bsscst_bd_name=@bdname,bsscst_bd_spec=@bdspec,bsscst_bd_unit=@bdunit,bsscst_bd_quanity=@bdquanity,bsscst_bd_costea=@bdcostea,
                                                      bsscst_bd_labor=@bdlabor,bsscst_bd_material=@bdmaterial,bsscst_bd_machine=@bdmachine,bsscst_bd_subcntrct=@bdsubcntrct,
                                                      bsscst_bd_expense=@bdexpense,bsscst_bd_remarks=@bdremarks WHERE bsscst_bd_id=" & BreakDownList(RowCount * 3, 1)
                            End If
                            ホーム.SystemSql.ExecuteNonQuery()
                        Else
                            If Not BreakDownList(RowCount * 3, 1) = 0 Then
                                ホーム.SystemSql.CommandText = "DELETE FROM basis_cost_breakdowns WHERE bsscst_bd_id=" & BreakDownList(RowCount * 3, 1)
                                ホーム.SystemSql.ExecuteNonQuery()
                            End If
                        End If
                    End If
                Next

                ホーム.Transaction.Commit()
                代価一覧.CostClassName = "基礎代価"

                '工事代価登録
            ElseIf ClassCode > 11 Then

                ホーム.Transaction = ホーム.Connection.BeginTransaction

                ホーム.Sql.Transaction = ホーム.Transaction

                ホーム.Sql.CommandText = ""
                ホーム.Sql.Parameters.Clear()

                ホーム.Sql.CommandText = "CREATE TABLE #update_data (id INT DEFAULT (0) NOT NULL,
                                                              cstclss_code INT DEFAULT (0) NOT NULL, 
                                                              name NVARCHAR(50) DEFAULT ('') NOT NULL,
                                                              spec NVARCHAR(50) DEFAULT ('') NOT NULL,
                                                              unit NVARCHAR(6) DEFAULT ('') NOT NULL,
                                                              costea MONEY DEFAULT (0) NOT NULL,
                                                              labor MONEY DEFAULT (0) NOT NULL,
                                                              material MONEY DEFAULT (0) NOT NULL,
                                                              machine MONEY DEFAULT (0) NOT NULL,
                                                              subcntrct MONEY DEFAULT (0) NOT NULL,
                                                              expense MONEY DEFAULT (0) NOT NULL)"
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = ""
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

                If CostID = 0 Then
                    ホーム.Sql.Parameters.Add(New SqlParameter("@budgetno", SqlDbType.SmallInt)).Value = ホーム.BudgetNo
                    ホーム.Sql.Parameters.Add(New SqlParameter("@cstclsscode", SqlDbType.SmallInt)).Value = ClassCode
                    ホーム.Sql.Parameters.Add(New SqlParameter("@prjctcstno", SqlDbType.SmallInt)).Value = Integer.Parse(No)

                    ホーム.Sql.CommandText = "INSERT INTO project_costs (budget_no,cstclss_code,prjctcst_no,prjctcst_name,prjctcst_spec,prjctcst_unit,
                                                          prjctcst_quanity,prjctcst_costea,prjctcst_laborea,prjctcst_materialea,prjctcst_machineea,prjctcst_subcntrctea,prjctcst_expenseea)
                                              OUTPUT inserted.prjctcst_id,inserted.cstclss_code,inserted.prjctcst_name,inserted.prjctcst_spec,inserted.prjctcst_unit,
                                                     inserted.prjctcst_costea,inserted.prjctcst_laborea,inserted.prjctcst_materialea,inserted.prjctcst_machineea,
                                                     inserted.prjctcst_subcntrctea,inserted.prjctcst_expenseea
                                              INTO #update_data (id,cstclss_code,name,spec,unit,costea,labor,material,machine,subcntrct,expense) 
                                              VALUES (@budgetno,@cstclsscode,@prjctcstno,@name,@spec,@unit,@quanity,@costea,@labor,@material,@machine,@subcntrct,@expense)"
                    ホーム.Sql.ExecuteNonQuery()

                    ホーム.Sql.Parameters.Clear()
                    ホーム.Sql.CommandText = ""
                    ホーム.Sql.CommandText = "SELECT prjctcst_id FROM project_costs WHERE cstclss_code=" & ClassCode & " AND prjctcst_no=" & Integer.Parse(No)
                    CreateCostID = ホーム.Sql.ExecuteScalar

                Else
                    ホーム.Sql.CommandText = "UPDATE project_costs SET prjctcst_name=@name,prjctcst_spec=@spec,prjctcst_unit=@unit,prjctcst_quanity=@quanity,
                                                          prjctcst_costea=@costea,prjctcst_laborea=@labor,prjctcst_materialea=@material,prjctcst_machineea=@machine,
                                                          prjctcst_subcntrctea=@subcntrct,prjctcst_expenseea=@expense 
                                              OUTPUT inserted.prjctcst_id,inserted.cstclss_code,inserted.prjctcst_name,inserted.prjctcst_spec,inserted.prjctcst_unit,
                                                     inserted.prjctcst_costea,inserted.prjctcst_laborea,inserted.prjctcst_materialea,inserted.prjctcst_machineea,
                                                     inserted.prjctcst_subcntrctea,inserted.prjctcst_expenseea
                                              INTO #update_data (id,cstclss_code,name,spec,unit,costea,labor,material,machine,subcntrct,expense) WHERE prjctcst_id=" & CreateCostID
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
                                ホーム.Sql.Parameters.Add(New SqlParameter("@prjctcstid", SqlDbType.SmallInt)).Value = CreateCostID
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
                代価一覧.CostClassName = "工事代価"

                ホーム.Sql.Parameters.Clear()
                ホーム.Sql.CommandText = ""

                Dim Recalculation As String = ""

                Dim RecalculationLoad As New Recalculation_prjctcst(ClassCode)
                Recalculation = RecalculationLoad.Recalculation
            End If



            MsgBox(CostNo.Text & " 登録完了", MsgBoxStyle.OkOnly, "代価表入力")

            If CostID = 0 Then
                Dim rowscount As Integer
                Dim NewCreateID As Integer
                If ClassCode = 11 Then
                    ホーム.SystemSql.CommandText = "SELECT Count(*) FROM basis_costs WHERE cstclss_code=" & ClassCode & " AND year=" & 代価一覧.YearList.Text
                    Dim BasisCostsCount As Integer = ホーム.SystemSql.ExecuteScalar
                    If BasisCostsCount > 50 Then
                        rowscount = 代価一覧.ProjectCostList.Rows.Count + 1
                    Else
                        rowscount = BasisCostsCount
                    End If
                    ホーム.SystemSql.CommandText = "SELECT MAX(bsscst_id) FROM basis_costs WHERE cstclss_code=" & ClassCode & " AND year=" & 代価一覧.YearList.Text
                    NewCreateID = ホーム.SystemSql.ExecuteScalar
                ElseIf ClassCode > 11 Then
                    ホーム.Sql.CommandText = "SELECT Count(*) FROM project_costs WHERE cstclss_code=" & ClassCode & " AND budget_no=" & ホーム.BudgetNo
                    Dim ProjectCostsCount As Integer = ホーム.Sql.ExecuteScalar
                    If ProjectCostsCount > 50 Then
                        rowscount = 代価一覧.ProjectCostList.Rows.Count + 1
                    Else
                        rowscount = ProjectCostsCount
                    End If
                    ホーム.Sql.CommandText = "SELECT MAX(prjctcst_id) FROM project_costs WHERE cstclss_code=" & ClassCode & " AND budget_no=" & ホーム.BudgetNo
                    NewCreateID = ホーム.Sql.ExecuteScalar
                End If
                代価一覧.ProjectCostList(rowscount, 1) = NewCreateID
                代価一覧.ProjectCostList(rowscount, 3) = Integer.Parse(No)
                代価一覧.ProjectCostList(rowscount, 4) = CostName.Value
                代価一覧.ProjectCostList(rowscount, 5) = CostSpec.Value
                代価一覧.ProjectCostList(rowscount, 6) = CostUnit.Value
                代価一覧.ProjectCostList(rowscount, 7) = CostQuanity.Value
                代価一覧.ProjectCostList(rowscount, 8) = CostCostea.Value
                代価一覧.ProjectCostList(rowscount, 9) = CostQuanity.Value * CostCostea.Value

            Else
                代価一覧.ProjectCostList(代価一覧.SelectRow, 4) = CostName.Value
                代価一覧.ProjectCostList(代価一覧.SelectRow, 5) = CostSpec.Value
                代価一覧.ProjectCostList(代価一覧.SelectRow, 6) = CostUnit.Value
                代価一覧.ProjectCostList(代価一覧.SelectRow, 7) = CostQuanity.Value
                代価一覧.ProjectCostList(代価一覧.SelectRow, 8) = CostCostea.Value
                代価一覧.ProjectCostList(代価一覧.SelectRow, 9) = CostQuanity.Value * CostCostea.Value
            End If
            '代価一覧.Refresh()
            '代価一覧.ProjectCostList.Refresh()
            代価一覧.Show()
            If ClassCode > 11 Then
                代価一覧.CostList.Enabled = True
            End If
            代価一覧.Visible = True
            Me.Close()
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
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
                If ClassCode = 11 Then
                    ホーム.BeforeForm = "基礎代価内訳"
                End If

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

                If Command1 = "Cut" Or Command1 = "Copy" Then
                    Dim Row As Integer = BreakDownList(CopyRow, 3)
                    If Row Mod 2 = 0 Then
                        BreakDownList.Rows(CopyRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        BreakDownList.Rows(CopyRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        BreakDownList.Rows(CopyRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)

                    Else
                        BreakDownList.Rows(CopyRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        BreakDownList.Rows(CopyRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        BreakDownList.Rows(CopyRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                    End If
                End If

                Command = "Copy"
                Command1 = "Copy"
                BreakDownList.Rows(SelectRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(221, 236, 253)
                BreakDownList.Rows(SelectRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(221, 236, 253)
                BreakDownList.Rows(SelectRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(221, 236, 253)

                CopyRow = SelectRow
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
                BreakDownList(SelectRow, 1) = BreakDownList(CopyRow, 1)
                BreakDownList(SelectRow, 3) = BreakDownList(CopyRow, 3)
                BreakDownList(SelectRow, 4) = BreakDownList(CopyRow, 4)
                BreakDownList(SelectRow + 1, 4) = BreakDownList(CopyRow + 1, 4)
                BreakDownList(SelectRow + 2, 4) = BreakDownList(CopyRow + 2, 4)
                BreakDownList(SelectRow + 2, 5) = BreakDownList(CopyRow + 2, 5)
                BreakDownList(SelectRow, 6) = BreakDownList(CopyRow, 6)
                BreakDownList(SelectRow + 1, 6) = BreakDownList(CopyRow + 1, 6)
                BreakDownList(SelectRow + 2, 6) = BreakDownList(CopyRow + 2, 6)
                BreakDownList(SelectRow, 8) = BreakDownList(CopyRow, 8)
                BreakDownList(SelectRow, 9) = BreakDownList(CopyRow, 9)
                If Command1 = "Cut" Then
                    BreakDownList.Rows.RemoveRange(CopyRow, 3)
                End If

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

            Command1 = ""
            Command = ""
            CopyRow = 0

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
                If Command1 = "Cut" Or Command1 = "Copy" Then
                    Dim Row As Integer = BreakDownList(CopyRow, 3)
                    If Row Mod 2 = 0 Then
                        BreakDownList.Rows(CopyRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        BreakDownList.Rows(CopyRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        BreakDownList.Rows(CopyRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)

                    Else
                        BreakDownList.Rows(CopyRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        BreakDownList.Rows(CopyRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        BreakDownList.Rows(CopyRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                    End If
                End If

                ホーム.Modified = "True"
                Command = "Cut"
                Command1 = "Cut"
                CopyRow = SelectRow


                BreakDownList.Rows(SelectRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(221, 236, 253)
                BreakDownList.Rows(SelectRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(221, 236, 253)
                BreakDownList.Rows(SelectRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(221, 236, 253)
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
                        BreakDownList.Select(SelectionRow - 1, 10)
                    ElseIf SelectionCol = 10 Then
                        SendKeys.Send("{ENTER}")
                        BreakDownList.Select(SelectionRow - 1, 11)
                    ElseIf SelectionCol = 11 Then
                        SendKeys.Send("{ENTER}")
                        BreakDownList.Select(SelectionRow - 1, 12)
                    ElseIf SelectionCol = 12 Then
                        SendKeys.Send("{ENTER}")
                        BreakDownList.Select(SelectionRow - 1, 13)
                    ElseIf SelectionCol = 13 Then
                        SendKeys.Send("{ENTER}")
                        BreakDownList.Select(SelectionRow - 1, 14)
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
            ElseIf e.KeyCode = Keys.Escape Then
                If Command = "Cut" Or Command = "Copy" Then

                    Dim Row As Integer = BreakDownList(CopyRow, 3)
                    If Row Mod 2 = 0 Then
                        BreakDownList.Rows(CopyRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        BreakDownList.Rows(CopyRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                        BreakDownList.Rows(CopyRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)

                    Else
                        BreakDownList.Rows(CopyRow).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        BreakDownList.Rows(CopyRow + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
                        BreakDownList.Rows(CopyRow + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 255)
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

    Private Sub CostCopy_Click(sender As Object, e As EventArgs) Handles CostCopy.Click
        Try
            If ホーム.BeforeForm = "基礎代価一覧" Or ホーム.BeforeForm = "基礎代価" Then
                ホーム.ProjectCommand = "CostCopy"
                ホーム.BeforeForm = "代価内訳"
                作成代価選択.HeadLine.Text = "<<コピー代価選択"
                作成代価選択.Text = "コピー代価選択"
                作成代価選択.SelectRow = 代価一覧.SelectRow
                作成代価選択.ShowDialog()
                作成代価選択.TopMost = True
                作成代価選択.TopMost = False
            ElseIf ホーム.BeforeForm = "工事代価一覧" Or ホーム.BeforeForm = "工事代価" Then

            End If

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub 代価内訳_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If ClassCode = 11 Then
            代価一覧.CostClassName = "基礎代価"
        ElseIf ClassCode > 11 Then
            代価一覧.CostClassName = "工事代価"
        End If
        代価一覧.Visible = True
    End Sub
End Class