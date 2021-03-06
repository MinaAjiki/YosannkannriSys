Imports C1.Win.C1FlexGrid
Imports System.Windows.Forms.Form
Imports C1.Win.C1Command
Imports System.Data.SqlClient
Public Class 作成代価選択
    Public CopyClassCode As Integer = 0
    Public CopyCostID As Integer = 0
    Public SelectRow As Integer = 0
    Public CopyList As C1FlexGrid
    Public BeforeClass As Integer = 0
    Private Sub AddLevel_MouseLeave(sender As Object, e As EventArgs) Handles AddLevel.MouseLeave
        AddLevel.ImageIndex = 0
    End Sub

    Private Sub AddLevel_MouseUp(sender As Object, e As MouseEventArgs) Handles AddLevel.MouseUp
        AddLevel.ImageIndex = 0
    End Sub

    Private Sub AddLevel_MouseEnter(sender As Object, e As EventArgs) Handles AddLevel.MouseEnter
        AddLevel.Cursor = Cursors.Hand
        AddLevel.ImageIndex = 1
    End Sub

    Private Sub AddLevel_MouseDown(sender As Object, e As MouseEventArgs) Handles AddLevel.MouseDown
        AddLevel.ImageIndex = 2
    End Sub

    Private Sub 作成代価選択_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim ClassCode As Integer = 0
            If 明細書入力.Visible = True Then
                ClassCode = 11
            ElseIf ホーム.BeforeForm = "代価一覧" Then
                If 代価一覧.CostClassName = "基礎代価" Then
                    ClassCode = 11
                ElseIf 代価一覧.CostClasscode >= 12 Then
                    ClassCode = 代価一覧.CostClassCode
                End If
            ElseIf ホーム.BeforeForm = "代価内訳" Then
                ClassCode = 代価内訳.ClassCode
            Else

                'Dim FormCount As Integer = ホーム.ProjectCostForm.Count
                'Dim ProjectCostRow As Integer = ホーム.ProjectCostSelectRow(FormCount - 1)
                'Dim ProjectCostList As C1FlexGrid = ホーム.PrjctCstList(FormCount - 1)

                ClassCode = BeforeClass

            End If

            ホーム.Sql.Parameters.Clear()
            CostsList.Items.Clear()
            ホーム.Sql.CommandText = "SELECT * FROM cost_classes WHERE cstclss_code>" & ClassCode & " ORDER BY cstclss_code ASC"
            Dim CostClassReader As SqlDataReader = ホーム.Sql.ExecuteReader
            While CostClassReader.Read
                CostsList.Items.Add(CostClassReader.Item("cstclss_name"))
            End While
            CostClassReader.Close()
            'If ClassCode = 11 Then
            '    CostsList.Items.Add("基礎代価")
            'End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try

    End Sub

    Private Sub AddLevel_Click(sender As Object, e As EventArgs) Handles AddLevel.Click
        Try
            Dim CostList(22) As String
            CostList(0) = "D"
            CostList(1) = "E"
            CostList(2) = "F"
            CostList(3) = "G"
            CostList(4) = "H"
            CostList(5) = "I"
            CostList(6) = "J"
            CostList(7) = "K"
            CostList(8) = "L"
            CostList(9) = "M"
            CostList(10) = "N"
            CostList(11) = "O"
            CostList(12) = "P"
            CostList(13) = "Q"
            CostList(14) = "R"
            CostList(15) = "S"
            CostList(16) = "T"
            CostList(17) = "U"
            CostList(18) = "V"
            CostList(19) = "W"
            CostList(20) = "X"
            CostList(21) = "Y"
            CostList(22) = "Z"



            ホーム.Sql.Parameters.Clear()
            ホーム.Sql.CommandText = "SELECT MAX(cstclss_code) FROM cost_classes"
            Dim MaxCode As Integer = ホーム.Sql.ExecuteScalar

            If CostList((MaxCode + 1) - 15) = "Z" Then
                MsgBox("工事代価 Z 以上の階層は追加できません。", MsgBoxStyle.Exclamation, "作成代価選択")
                Me.Visible = False
                Exit Sub
            End If

            If MsgBox("工事代価" & CostList((MaxCode + 1) - 15) & "を作成します。" & vbCrLf & "よろしいですか？", MsgBoxStyle.OkCancel, "代価階層追加") = MsgBoxResult.Ok Then

                ホーム.Sql.Parameters.Clear()
                ホーム.Sql.CommandText = ""
                ホーム.Sql.CommandText = "INSERT INTO cost_classes (cstclss_code,cstclss_name) VALUES (@cstclsscode,@cstclssname)"
                ホーム.Sql.Parameters.Add(New SqlParameter("@cstclsscode", SqlDbType.SmallInt))
                ホーム.Sql.Parameters.Add(New SqlParameter("@cstclssname", SqlDbType.NVarChar))
                ホーム.Sql.Parameters("@cstclsscode").Value = MaxCode + 1
                ホーム.Sql.Parameters("@cstclssname").Value = "工事代価" & CostList((MaxCode + 1) - 15)
                ホーム.Sql.ExecuteNonQuery()

                If 明細書入力.Visible = True Then

                    ホーム.ProjectCostForm.Add(New 代価表入力)
                    ホーム.ProjectCostForm(0).TopLevel = False
                    ホーム.FormPanel.Controls.Add(ホーム.ProjectCostForm(0))
                    ホーム.ProjectCostSelectRow.Add(SelectRow)
                    ホーム.ProjectCostID.Add(0)
                    ホーム.PrjctCstClassCode.Add(MaxCode + 1)
                    ホーム.PrjctCstList.Add(明細書入力.DetailsList)
                    CopyClassCode = 明細書入力.DetailsList(SelectRow, 8)
                    CopyCostID = 明細書入力.DetailsList(SelectRow, 9)
                    ホーム.ProjectCostForm(0).Show()
                    明細書入力.Visible = False
                Else

                    Dim FormCount As Integer = ホーム.ProjectCostForm.Count

                    ホーム.ProjectCostForm.Add(New 代価表入力)
                    ホーム.ProjectCostForm(FormCount).TopLevel = False
                    ホーム.FormPanel.Controls.Add(ホーム.ProjectCostForm(FormCount))
                    ホーム.ProjectCostSelectRow.Add(SelectRow)
                    ホーム.ProjectCostID.Add(0)
                    ホーム.PrjctCstClassCode.Add(MaxCode + 1)
                    ホーム.PrjctCstList.Add(CopyList)
                    CopyClassCode = CopyList(SelectRow, 8)
                    CopyCostID = CopyList(SelectRow, 9)
                    ホーム.ProjectCostForm(FormCount).Show()
                    ホーム.ProjectCostForm(FormCount - 1).Visible = False
                End If

                Me.Close()
            End If
            ホーム.Modified = "True"


        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try


    End Sub

    Private Sub CostsList_DoubleClick(sender As Object, e As EventArgs) Handles CostsList.DoubleClick
        Try
            '選択したコピー先代価コードを取得
            ホーム.Sql.Parameters.Clear()
            ホーム.Sql.CommandText = "SELECT cstclss_code FROM cost_classes WHERE cstclss_name=@cstclssname"
            ホーム.Sql.Parameters.Add(New SqlParameter("@cstclssname", SqlDbType.NVarChar))
            ホーム.Sql.Parameters("@cstclssname").Value = CostsList.SelectedItem
            Dim ClassCode As Integer = ホーム.Sql.ExecuteScalar

            ホーム.Sql.CommandText = "SELECT Count(*) FROM project_costs WHERE cstclss_code=" & ClassCode & " AND budget_no=" & ホーム.BudgetNo
            Dim CostCount As Integer = ホーム.Sql.ExecuteScalar

            Dim MaxNo As Integer = 0

            If CostCount > 0 Then
                ホーム.Sql.CommandText = "SELECT MAX(prjctcst_no) FROM project_costs WHERE cstclss_code=" & ClassCode & " AND budget_no=" & ホーム.BudgetNo
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
            Dim ClassName As String = CostsList.SelectedItem

            If 明細書入力.Visible = True Then
                If Not ホーム.ProjectCommand = "CostCopy" Then
                    ホーム.ProjectCostForm.Add(New 代価表入力)
                    ホーム.ProjectCostForm(0).TopLevel = False
                    ホーム.FormPanel.Controls.Add(ホーム.ProjectCostForm(0))
                    ホーム.ProjectCostSelectRow.Add(SelectRow)
                    ホーム.ProjectCostID.Add(0)
                    ホーム.PrjctCstClassCode.Add(ClassCode)
                    ホーム.PrjctCstList.Add(明細書入力.DetailsList)
                    CopyClassCode = 明細書入力.DetailsList(SelectRow, 8)
                    CopyCostID = 明細書入力.DetailsList(SelectRow, 9)
                    ホーム.ProjectCostForm(0).Show()
                    明細書入力.Visible = False
                Else

                    If MsgBox(明細書入力.DetailsList(SelectRow + 2, 4) & " を " & "第" & ClassName.Last & "-" & No & "号 にコピーします。", MsgBoxStyle.OkCancel, "代価コピー") = MsgBoxResult.Ok Then
                        Dim costcopy As String = ""
                        Dim CostCopyLoad As New CostCopy(ClassCode, 明細書入力.DetailsList(SelectRow, 9), No)
                        costcopy = CostCopyLoad.CostCopy
                    End If
                    ホーム.ProjectCommand = ""
                End If

            ElseIf ホーム.BeforeForm = "代価一覧" Then

                If 代価一覧.CostClassCode = 11 Then
                    ホーム.BeforeForm = "基礎代価一覧"
                ElseIf 代価一覧.CostClassCode > 11 Then
                    ホーム.BeforeForm = "工事代価一覧"
                End If
                代価内訳.ClassCode = 代価一覧.CostClassCode
                CopyCostID = 代価一覧.ProjectCostList(SelectRow, 1)
                代価内訳.CostID = 代価一覧.ProjectCostList(SelectRow, 1)
                CopyClassCode = ClassCode
                代価一覧.CostClassName = CostsList.Text
                代価内訳.Show()
                代価一覧.Close()
                '代価一覧.Visible = False

            ElseIf ホーム.BeforeForm = "代価内訳" Then
                If 代価一覧.CostClassCode = 11 Then
                    ホーム.BeforeForm = "基礎代価一覧"
                ElseIf 代価一覧.CostClassCode > 11 Then
                    ホーム.BeforeForm = "工事代価一覧"
                End If
                Dim DaikaForm As New 代価内訳
                DaikaForm.ClassCode = 代価一覧.CostClassCode
                DaikaForm.CostID = 代価内訳.CostID
                CopyCostID = 代価内訳.CostID
                CopyClassCode = ClassCode
                代価一覧.CostClassName = CostsList.Text

                DaikaForm.Show()
                代価内訳.Close()
            Else

                If Not ホーム.ProjectCommand = "CostCopy" Then
                    Dim FormCount As Integer = ホーム.ProjectCostForm.Count

                    ホーム.ProjectCostForm.Add(New 代価表入力)
                    ホーム.ProjectCostForm(FormCount).TopLevel = False
                    ホーム.FormPanel.Controls.Add(ホーム.ProjectCostForm(FormCount))
                    ホーム.ProjectCostSelectRow.Add(SelectRow)
                    ホーム.ProjectCostID.Add(0)
                    ホーム.PrjctCstClassCode.Add(ClassCode)
                    ホーム.PrjctCstList.Add(CopyList)
                    CopyClassCode = CopyList(SelectRow, 8)
                    CopyCostID = CopyList(SelectRow, 9)
                    ホーム.ProjectCostForm(FormCount).Show()
                    ホーム.ProjectCostForm(FormCount - 1).Visible = False
                Else

                    If MsgBox(CopyList((SelectRow) + 2, 4) & " を " & "第" & ClassName.Last & "-" & No & "号 にコピーします。", MsgBoxStyle.OkCancel, "代価コピー") = MsgBoxResult.Ok Then
                        Dim costcopy As String = ""
                        Dim CostCopyLoad As New CostCopy(ClassCode, CopyList(SelectRow, 9), No)
                        costcopy = CostCopyLoad.CostCopy
                    End If
                    ホーム.ProjectCommand = ""
                End If

            End If


            ホーム.Modified = "True"

            Me.Close()
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub
End Class