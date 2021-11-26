Imports C1.Win.C1Command
Imports System.Data.SqlClient
Imports System.Windows.Forms.Form
Public Class 大工種選択
    Private Sub 大工種選択_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Total As Int64 = 0

        Dim RowCount As Integer = 1
        ホーム.SystemSql.CommandText = "SELECT  * FROM l_worktype ORDER BY l_worktype_code ASC"
        Dim LWorkTypeReader As SqlDataReader = ホーム.SystemSql.ExecuteReader
        While LWorkTypeReader.Read

            L_WorkTypesList(RowCount, 1) = LWorkTypeReader.Item("l_worktype_code")
            L_WorkTypesList(RowCount, 2) = LWorkTypeReader.Item("l_worktype")

            ホーム.Sql.CommandText = "SELECT SUM(amount) FROM s_worktype_total WHERE budget_no=" & ホーム.BudgetNo & " AND l_worktype_code=" _
                                            & LWorkTypeReader.Item("l_worktype_code")
            L_WorkTypesList(RowCount, 3) = ホーム.Sql.ExecuteScalar

            Total += L_WorkTypesList(RowCount, 3)

            RowCount += 1
        End While
        LWorkTypeReader.Close()

        LWorktypeTotal.Text = Total

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
        Me.Close()
        小工種選択.TopLevel = False
        ホーム.FormPanel.Controls.Add(小工種選択)
        小工種選択.Show()
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