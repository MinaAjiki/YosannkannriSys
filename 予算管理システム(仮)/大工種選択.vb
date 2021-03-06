Imports C1.Win.C1Command
Imports System.Data.SqlClient
Imports System.Windows.Forms.Form
Public Class 大工種選択
    Private Sub 大工種選択_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim Total As Int64 = 0

            ホーム.SystemSql.CommandText = "SELECT  Count(*) FROM l_worktypes"
            Dim Count As Integer = ホーム.SystemSql.ExecuteScalar

            L_WorkTypesList.Rows.Count = Count + 1

            ホーム.Sql.Parameters.Clear()
            ホーム.Sql.CommandText = ""

            If ホーム.BeforeForm = "予算" Then

                Dim RowCount As Integer = 1
                ホーム.SystemSql.CommandText = "SELECT  * FROM l_worktypes WHERE NOT l_wrktyp_code=890 ORDER BY l_wrktyp_code ASC"
                Dim LWorkTypeReader As SqlDataReader = ホーム.SystemSql.ExecuteReader
                While LWorkTypeReader.Read

                    L_WorkTypesList(RowCount, 1) = LWorkTypeReader.Item("l_wrktyp_code")
                    L_WorkTypesList(RowCount, 2) = LWorkTypeReader.Item("l_wrktyp_name")

                    If Not LWorkTypeReader.Item("l_wrktyp_code") = 840 Then
                        ホーム.Sql.CommandText = "SELECT Count(*) FROM details WHERE budget_no=" & ホーム.BudgetNo
                        Dim DetailsCount As Integer = ホーム.Sql.ExecuteScalar

                        If DetailsCount > 0 Then
                            ホーム.Sql.CommandText = "SELECT SUM(amout_total) FROM L_worktype_total WHERE budget_no=" & ホーム.BudgetNo & " AND l_wrktyp_code=" _
                                                    & LWorkTypeReader.Item("l_wrktyp_code")
                            L_WorkTypesList(RowCount, 3) = ホーム.Sql.ExecuteScalar

                            Total += L_WorkTypesList(RowCount, 3)

                        End If
                    ElseIf LWorkTypeReader.Item("l_wrktyp_code") = 840 Then
                        ホーム.Sql.CommandText = "SELECT Count(*) FROM site_expenses WHERE budget_no=" & ホーム.BudgetNo
                        Dim SiteExpenseCount As Integer = ホーム.Sql.ExecuteScalar
                        If SiteExpenseCount > 0 Then
                            ホーム.Sql.CommandText = "SELECT SUM(stexpns_amount) FROM site_expenses WHERE budget_no=" & ホーム.BudgetNo
                            If IsDBNull(ホーム.Sql.ExecuteScalar) = False Then

                                If ホーム.Sql.ExecuteScalar > 0 Then
                                    L_WorkTypesList(RowCount, 3) = ホーム.Sql.ExecuteScalar
                                End If
                                Total += L_WorkTypesList(RowCount, 3)
                            End If
                        End If

                    End If
                    RowCount += 1

                End While
                LWorkTypeReader.Close()

            Else

                Dim RowCount As Integer = 1
                ホーム.SystemSql.CommandText = "SELECT  * FROM l_worktypes ORDER BY l_wrktyp_code ASC"
                Dim LWorkTypeReader As SqlDataReader = ホーム.SystemSql.ExecuteReader
                While LWorkTypeReader.Read

                    L_WorkTypesList(RowCount, 1) = LWorkTypeReader.Item("l_wrktyp_code")
                    L_WorkTypesList(RowCount, 2) = LWorkTypeReader.Item("l_wrktyp_name")

                    If Not LWorkTypeReader.Item("l_wrktyp_code") = 840 Then
                        ホーム.Sql.CommandText = "SELECT Count(*) FROM details WHERE budget_no=" & ホーム.BudgetNo
                        Dim DetailsCount As Integer = ホーム.Sql.ExecuteScalar

                        If DetailsCount > 0 Then
                            ホーム.Sql.CommandText = "SELECT SUM(amout_total) FROM L_worktype_total WHERE budget_no=" & ホーム.BudgetNo & " AND l_wrktyp_code=" _
                                                    & LWorkTypeReader.Item("l_wrktyp_code")
                            L_WorkTypesList(RowCount, 3) = ホーム.Sql.ExecuteScalar

                            Total += L_WorkTypesList(RowCount, 3)

                        End If
                    ElseIf LWorkTypeReader.Item("l_wrktyp_code") = 840 Then
                        ホーム.Sql.CommandText = "SELECT Count(*) FROM site_expenses WHERE budget_no=" & ホーム.BudgetNo
                        Dim SiteExpenseCount As Integer = ホーム.Sql.ExecuteScalar
                        If SiteExpenseCount > 0 Then
                            ホーム.Sql.CommandText = "SELECT SUM(stexpns_amount) FROM site_expenses WHERE budget_no=" & ホーム.BudgetNo
                            If IsDBNull(ホーム.Sql.ExecuteScalar) = False Then
                                If ホーム.Sql.ExecuteScalar > 0 Then
                                    L_WorkTypesList(RowCount, 3) = ホーム.Sql.ExecuteScalar
                                End If
                                Total += L_WorkTypesList(RowCount, 3)
                            End If
                        End If

                    End If
                    RowCount += 1

                End While
                LWorkTypeReader.Close()

            End If


            LWorktypeTotal.Text = Total

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

    Private Sub L_WorkTypesList_DoubleClick(sender As Object, e As EventArgs) Handles L_WorkTypesList.DoubleClick
        Try
            Dim ClickRow As Integer = L_WorkTypesList.Selection.TopRow
            ホーム.lworktypecode = L_WorkTypesList(ClickRow, 1)
            ホーム.lworktypename = L_WorkTypesList(ClickRow, 2)

            Me.Close()
            小工種選択.TopLevel = False
            ホーム.FormPanel.Controls.Add(小工種選択)
            小工種選択.Show()


            'If ホーム.HomeTreeView.Nodes.Count > 0 Then
            '    ホーム.HomeTreeView.Nodes(ClickRow - 1).Expand()
            '    ホーム.SelectNodeList.Add(ホーム.HomeTreeView.Nodes(ClickRow - 1))
            'End If
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
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

End Class