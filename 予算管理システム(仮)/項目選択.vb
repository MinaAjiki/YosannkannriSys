Imports C1.Win.C1FlexGrid
Imports System.Windows.Forms.Form
Imports C1.Win.C1Command
Imports System.Data.SqlClient
Public Class 項目選択

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CostsList.SelectedIndexChanged
        CostMasterList.SelectedItems.Clear()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CostMasterList.SelectedIndexChanged
        CostsList.SelectedItems.Clear()
    End Sub

    Private Sub CostMasterList_DoubleClick(sender As Object, e As EventArgs) Handles CostMasterList.DoubleClick
        Try
            ホーム.Sql.CommandText = ""
            ホーム.Sql.Parameters.Clear()
            ホーム.Sql.CommandText = "SELECT cstclss_code FROM cost_classes WHERE cstclss_name=@cstclssname"
            ホーム.Sql.Parameters.Add(New SqlParameter("@cstclssname", SqlDbType.NVarChar))
            ホーム.Sql.Parameters("@cstclssname").Value = CostMasterList.SelectedItem
            費用マスタ一覧.CostClassCode = ホーム.Sql.ExecuteScalar
            費用マスタ一覧.CostClassName = CostMasterList.SelectedItem

            費用マスタ一覧.TopMost = True
            費用マスタ一覧.ParentFormName = "明細書"
            費用マスタ一覧.Show()
            費用マスタ一覧.TopMost = False
            Me.Close()

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try

    End Sub
End Class