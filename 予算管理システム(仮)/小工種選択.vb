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
            ホーム.SystemSql.CommandText = "SELECT * FROM s_worktypes WHERE l_wrktyp_code=" & ホーム.lworktypecode
            Dim SWorktypeReader As SqlDataReader = ホーム.SystemSql.ExecuteReader
            While SWorktypeReader.Read
                RowCount += 1
                S_WorkTypesList(RowCount, 1) = SWorktypeReader.Item("s_wrktyp_code")
                S_WorkTypesList(RowCount, 2) = SWorktypeReader.Item("s_wrktyp_name")

                ホーム.Sql.CommandText = "SELECT * FROM S_worktype_total WHERE budget_no=" & ホーム.BudgetNo & " AND s_worktype_code=" & S_WorkTypesList(RowCount, 1)
                Dim SWorkTypeTotalReader As SqlDataReader = ホーム.Sql.ExecuteReader
                While SWorkTypeTotalReader.Read
                    S_WorkTypesList(RowCount, 3) = SWorkTypeTotalReader.Item("amount_total")
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
                End While
                SWorkTypeTotalReader.Close()

            End While
            SWorktypeReader.Close()

            SWorkTypeTotal.Value = Total
            Labor.Value = LaborTotal
            Material.Value = MaterialTotal
            Machine.Value = MachineTotal
            Subcntrct.Value = SubcntrctTotal
            Expens.Value = ExpensTotal

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

            Me.Close()
            明細書入力.TopLevel = False
            ホーム.FormPanel.Controls.Add(明細書入力)
            明細書入力.Show()

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
        大工種選択.TopLevel = False
        ホーム.FormPanel.Controls.Add(大工種選択)
        大工種選択.Show()
    End Sub
End Class