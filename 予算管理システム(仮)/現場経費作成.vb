Imports C1.Win.C1FlexGrid
Imports System.Data.SqlClient
Public Class 現場経費作成
    Private Sub Cancel_MouseLeave(sender As Object, e As EventArgs) Handles Cancel.MouseLeave
        Cancel.ImageIndex = 6
    End Sub

    Private Sub Cancel_MouseEnter(sender As Object, e As EventArgs) Handles Cancel.MouseEnter
        Cancel.Cursor = Cursors.Hand
        Cancel.ImageIndex = 7
    End Sub

    Private Sub Cancel_MouseDown(sender As Object, e As MouseEventArgs) Handles Cancel.MouseDown
        Cancel.ImageIndex = 8
    End Sub
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
        小工種選択.TopLevel = False
        ホーム.FormPanel.Controls.Add(小工種選択)
        小工種選択.Show()
    End Sub

    Private Sub 現場経費作成_Load(sender As Object, e As EventArgs) Handles Me.Load
        CodeLabel.Text = "841"
        ExpenceLabel.Text = "現場経費"

        ホーム.Sql.CommandText = "SELECT * FROM site_expenses WHERE budget_no=" & ホーム.BudgetNo & "ORDER BY stexpns_code ASC"
        Dim stexpns As SqlDataReader = ホーム.Sql.ExecuteReader
        Dim datacount As Integer = 1
        While stexpns.Read
            DetailsList.Rows.Add()
            DetailsList(datacount, 0) = stexpns.Item("stexpns_id")
            DetailsList(datacount, 1) = stexpns.Item("stexpns_code")
            DetailsList(datacount, 2) = stexpns.Item("stexpns_name")
            DetailsList(datacount, 3) = stexpns.Item("stexpns_amount")
            datacount += 1
        End While
        stexpns.Close()
    End Sub

    Private Sub DetailsList_DoubleClick(sender As Object, e As EventArgs) Handles DetailsList.DoubleClick
        Try
            Dim ClickRow As Integer = DetailsList.Selection.TopRow
            ホーム.ExpnsbdID = DetailsList(ClickRow, 0)
            ホーム.ExpnsbdCode = DetailsList(ClickRow, 1)
            ホーム.ExpnsbdName = DetailsList(ClickRow, 2)

            Me.Close()
            現場経費内訳.TopLevel = False
            ホーム.FormPanel.Controls.Add(現場経費内訳)
            現場経費内訳.Show()
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub
End Class