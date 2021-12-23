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
            If 明細書入力.Visible = True Then
                費用マスタ一覧.ParentFormName = "明細書"
            Else
                費用マスタ一覧.ParentFormName = "代価表"

            End If



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

    Private Sub 項目選択_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            If CostMasterList.SelectedItems.Count = 0 AndAlso CostsList.SelectedItems.Count = 0 Then
                If 費用マスタ一覧.ParentFormName = "" AndAlso 代価一覧.ParentFormName = "" Then
                    Dim Count As Integer = ホーム.ProjectCostSelectRow.Count
                    If (Count - 1) > 0 Then
                        ホーム.ProjectCostSelectRow.RemoveAt(Count - 1)
                        ホーム.PrjctCstList.RemoveAt(Count - 1)
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

    Private Sub CostsList_DoubleClick(sender As Object, e As EventArgs) Handles CostsList.DoubleClick
        Try
            ホーム.Sql.CommandText = ""
            ホーム.Sql.Parameters.Clear()


            ホーム.Sql.CommandText = "SELECT cstclss_code FROM cost_classes WHERE cstclss_name=@cstclssname"
            ホーム.Sql.Parameters.Add(New SqlParameter("@cstclssname", SqlDbType.NVarChar))
            ホーム.Sql.Parameters("@cstclssname").Value = CostsList.SelectedItem
            代価一覧.CostClassCode = ホーム.Sql.ExecuteScalar
            代価一覧.CostClassName = CostsList.SelectedItem

            If Not CostsList.SelectedItem = "基礎代価" Then
                ホーム.Sql.CommandText = "SELECT Count(*) FROM project_costs WHERE cstclss_code=" & 代価一覧.CostClassCode
                Dim CostCount As Integer = ホーム.Sql.ExecuteScalar

                If CostCount = 0 Then
                    MsgBox(CostsList.SelectedItem & "：登録されている代価がありません。", MsgBoxStyle.Exclamation, "項目選択")
                    Exit Sub
                End If

            End If

            代価一覧.TopMost = True

        If 明細書入力.Visible = True Then
            代価一覧.ParentFormName = "明細書"
        Else
            代価一覧.ParentFormName = "代価表"
        End If

        代価一覧.Show()
        代価一覧.TopMost = False
            Me.Close()

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub 項目選択_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ホーム.Sql.CommandText = ""
            ホーム.Sql.Parameters.Clear()

            ホーム.Sql.CommandText = "SELECT cstclss_name FROM cost_classes WHERE cstclss_code>14"
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
End Class