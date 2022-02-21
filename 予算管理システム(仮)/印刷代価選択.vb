Imports System.Data.SqlClient
Public Class 印刷代価選択
    Public ClassCode As Integer
    Public ClassName As String
    Private Sub 印刷代価選択_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ホーム.Sql.Parameters.Clear()
            CostsList.Items.Clear()
            ホーム.Sql.CommandText = "SELECT * FROM cost_classes WHERE cstclss_code>11 ORDER BY cstclss_code ASC"
            Dim CostClassReader As SqlDataReader = ホーム.Sql.ExecuteReader
            While CostClassReader.Read
                CostsList.Items.Add(CostClassReader.Item("cstclss_name"))
            End While
            CostClassReader.Close()
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub CostsList_DoubleClick(sender As Object, e As EventArgs) Handles CostsList.DoubleClick
        Try
            Cursor.Current = Cursors.WaitCursor
            Dim ReportLoad As String = ""


            ホーム.Sql.Parameters.Clear()
            ホーム.Sql.CommandText = "SELECT cstclss_code FROM cost_classes WHERE cstclss_name=@cstclssname"
            ホーム.Sql.Parameters.Add(New SqlParameter("@cstclssname", SqlDbType.NVarChar))
            ホーム.Sql.Parameters("@cstclssname").Value = CostsList.SelectedItem
            ClassCode = ホーム.Sql.ExecuteScalar
            ClassName = CostsList.SelectedItem

            ホーム.Sql.CommandText = "SELECT Count(*) FROM project_costs WHERE budget_no=" & ホーム.BudgetNo & " AND cstclss_code=" & ClassCode
            Dim PrjctCstCount As Integer = ホーム.Sql.ExecuteScalar

            If PrjctCstCount = 0 Then
                MsgBox("代価表が登録されていません。", MsgBoxStyle.Exclamation, "印刷代価選択")
                Exit Sub
            End If


        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try

        レポート.Show()

    End Sub
End Class