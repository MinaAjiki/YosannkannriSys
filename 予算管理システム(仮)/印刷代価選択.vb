Imports System.Data.SqlClient
Public Class 印刷代価選択
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

    End Sub
End Class