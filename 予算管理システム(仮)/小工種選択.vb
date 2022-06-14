Imports C1.Win.C1Command
Imports System.Data.SqlClient
Imports System.Windows.Forms.Form
Public Class 小工種選択

    Private Sub 小工種選択_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        L_WorkType.Value = ホーム.lworktypecode & " " & ホーム.lworktypename

        Try
            Dim Total As Int64 = 0
            Dim LaborTotal As Int64 = 0
            Dim MaterialTotal As Int64 = 0
            Dim MachineTotal As Int64 = 0
            Dim SubcntrctTotal As Int64 = 0
            Dim ExpensTotal As Int64 = 0

            ホーム.SystemSql.CommandText = "SELECT Count(*) FROM s_worktypes WHERE l_wrktyp_code=" & ホーム.lworktypecode
            Dim Count As Integer = ホーム.SystemSql.ExecuteScalar

            If Count < 21 Then
                S_WorkTypesList.Rows.Count = Count + (21 - Count)
            Else
                S_WorkTypesList.Rows.Count = Count + 1
            End If

            Dim RowCount As Integer = 0

            ホーム.Sql.CommandText = "SELECT Count(s_wrktyp_code) FROM S_worktype_total WHERE l_wrktyp_code=" & ホーム.lworktypecode & " AND budget_no=" & ホーム.BudgetNo & " OR l_wrktyp_code=" _
                                        & ホーム.lworktypecode & " AND budget_no IS NULL GROUP BY s_wrktyp_code"
            Dim sworktypeCount As Integer = ホーム.Sql.ExecuteScalar

            Dim SiteCost As Int64 = 0
            If ホーム.lworktypecode = 840 Then
                ホーム.Sql.CommandText = "SELECT Count(*) FROM site_expenses WHERE budget_no=" & ホーム.BudgetNo
                Dim SiteExpenseCount As Integer = ホーム.Sql.ExecuteScalar
                If SiteExpenseCount > 0 Then
                    ホーム.Sql.CommandText = "SELECT SUM(stexpns_amount) FROM site_expenses WHERE budget_no=" & ホーム.BudgetNo
                    If IsDBNull(ホーム.Sql.ExecuteScalar) = False Then
                        SiteCost = ホーム.Sql.ExecuteScalar
                    End If
                End If
            End If

            If sworktypecount > 0 Then
                ホーム.Sql.CommandText = "SELECT s_wrktyp_code,s_wrktyp_name,SUM(amout_total) AS amout_total,SUM(labor) AS labor,SUM(material) AS material,SUM(machine) AS machine,
                                        SUM(subcntrct) AS subcntrct,SUM(expens) AS expens FROM S_worktype_total WHERE l_wrktyp_code=" & ホーム.lworktypecode &
                                        " AND budget_no=" & ホーム.BudgetNo & "OR l_wrktyp_code=" & ホーム.lworktypecode & " AND budget_no IS NULL GROUP BY s_wrktyp_code,s_wrktyp_name  
                                        ORDER BY s_wrktyp_code ASC"
                Dim SWorkTypeTotalReader As SqlDataReader = ホーム.Sql.ExecuteReader
                While SWorkTypeTotalReader.Read

                    If Not RowCount = Count Then
                        RowCount += 1

                        If Not SWorkTypeTotalReader.Item("s_wrktyp_code") = 841 Then
                            S_WorkTypesList(RowCount, 1) = SWorkTypeTotalReader.Item("s_wrktyp_code")
                            S_WorkTypesList(RowCount, 2) = SWorkTypeTotalReader.Item("s_wrktyp_name")
                            S_WorkTypesList(RowCount, 3) = SWorkTypeTotalReader.Item("amout_total")
                            S_WorkTypesList(RowCount, 4) = SWorkTypeTotalReader.Item("labor")
                            S_WorkTypesList(RowCount, 5) = SWorkTypeTotalReader.Item("material")
                            S_WorkTypesList(RowCount, 6) = SWorkTypeTotalReader.Item("machine")
                            S_WorkTypesList(RowCount, 7) = SWorkTypeTotalReader.Item("subcntrct")
                            S_WorkTypesList(RowCount, 8) = SWorkTypeTotalReader.Item("expens")


                            Total += S_WorkTypesList(RowCount, 3)
                            LaborTotal += S_WorkTypesList(RowCount, 4)
                            MaterialTotal += S_WorkTypesList(RowCount, 5)
                            MachineTotal += S_WorkTypesList(RowCount, 6)
                            SubcntrctTotal += S_WorkTypesList(RowCount, 7)
                            ExpensTotal += S_WorkTypesList(RowCount, 8)
                        Else

                            S_WorkTypesList(RowCount, 1) = 841
                            S_WorkTypesList(RowCount, 2) = "現場経費"
                            S_WorkTypesList(RowCount, 3) = SiteCost

                            Total += S_WorkTypesList(RowCount, 3)
                        End If
                    End If
                End While
                SWorkTypeTotalReader.Close()


                SWorkTypeTotal.Value = Total
                Labor.Value = LaborTotal
                Material.Value = MaterialTotal
                Machine.Value = MachineTotal
                Subcntrct.Value = SubcntrctTotal
                Expens.Value = ExpensTotal
            Else

                ホーム.SystemSql.CommandText = "SELECT * FROM s_worktypes WHERE l_wrktyp_code=" & ホーム.lworktypecode
                Dim SworktypeReader As SqlDataReader = ホーム.SystemSql.ExecuteReader
                While SworktypeReader.Read
                    If Not RowCount = Count Then
                        RowCount += 1
                        S_WorkTypesList(RowCount, 1) = SworktypeReader.Item("s_wrktyp_code")
                        S_WorkTypesList(RowCount, 2) = SworktypeReader.Item("s_wrktyp_name")
                    End If
                End While
                SworktypeReader.Close()

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

    Private Sub S_WorkTypesList_DoubleClick(sender As Object, e As EventArgs) Handles S_WorkTypesList.DoubleClick

        Try
            Dim ClickRow As Integer = S_WorkTypesList.Selection.TopRow
            ホーム.sworktypecode = S_WorkTypesList(ClickRow, 1)
            ホーム.sworktypename = S_WorkTypesList(ClickRow, 2)

            If ホーム.sworktypename = "現場経費" Then
                Me.Close()
                現場経費作成.TopLevel = False
                ホーム.FormPanel.Controls.Add(現場経費作成)
                現場経費作成.Show()
            Else
                Me.Close()
                明細書入力.TopLevel = False
                ホーム.FormPanel.Controls.Add(明細書入力)
                明細書入力.Show()

                Dim NodeExpand As String = ""

                If ホーム.HomeTreeView.Nodes.Count > 0 Then
                    Dim maxindex As Integer = ホーム.SelectNodeList.Count - 1
                    Dim NodeExpandLoad As New TreeNode_ChildExpand(ホーム.SelectNodeList(0), S_WorkTypesList(ClickRow, 1) & " " & S_WorkTypesList(ClickRow, 2))
                    NodeExpand = NodeExpandLoad.NodeExpand
                End If
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
            Me.Close()
            大工種選択.TopLevel = False
            ホーム.FormPanel.Controls.Add(大工種選択)
            大工種選択.Show()

            If ホーム.SelectNodeList.Count > 0 Then
                ホーム.SelectNodeList(0).Collapse()
                ホーム.SelectNodeList.RemoveAt(0)
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub
End Class