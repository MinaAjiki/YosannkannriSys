Imports C1.Win.C1FlexGrid
Imports System.Data.SqlClient
Public Class 現場経費内訳
    Dim TExpns As Int64
    Dim quanity As Decimal
    Dim costea As Int64
    Dim amount As Int64
    Public SelectRow As Integer
    Private Sub Entry_MouseLeave(sender As Object, e As EventArgs) Handles Entry.MouseLeave
        Entry.ImageIndex = 3
    End Sub

    Private Sub Entry_MouseEnter(sender As Object, e As EventArgs) Handles Entry.MouseEnter
        Entry.Cursor = Cursors.Hand
        Entry.ImageIndex = 4
    End Sub

    Private Sub Entry_MouseDown(sender As Object, e As MouseEventArgs) Handles Entry.MouseDown
        Entry.ImageIndex = 5
    End Sub
    Private Sub Reference_MouseLeave(sender As Object, e As EventArgs) Handles Reference.MouseLeave
        Reference.ImageIndex = 0
    End Sub

    Private Sub Reference_MouseEnter(sender As Object, e As EventArgs) Handles Reference.MouseEnter
        Reference.Cursor = Cursors.Hand
        Reference.ImageIndex = 1
    End Sub

    Private Sub Reference_MouseDown(sender As Object, e As MouseEventArgs) Handles Reference.MouseDown
        Reference.ImageIndex = 2
    End Sub

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
        Try
            Dim CancelClick As String = ""

            Dim CancelClickLoad As New CancelClick(Me)
            CancelClick = CancelClickLoad.ModifyCheck

            現場経費作成.TopLevel = False
            ホーム.FormPanel.Controls.Add(現場経費作成)
            現場経費作成.Show()

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try

    End Sub

    Private Sub 現場経費内訳_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            CodeLabel.Text = ホーム.ExpnsbdCode
            ExpenceLabel.Text = ホーム.ExpnsbdName
            ホーム.Sql.CommandText = "SELECT stexpns_amount FROM site_expenses WHERE stexpns_id = " & ホーム.ExpnsbdID & " AND budget_no=" & ホーム.BudgetNo
            TExpns = ホーム.Sql.ExecuteScalar
            TotalExpense.Text = TExpns

            ホーム.Sql.CommandText = "SELECT * FROM expense_breakdowns WHERE stexpns_id = " & ホーム.ExpnsbdID & "ORDER BY expns_bd_id ASC"
            Dim expnsbd As SqlDataReader = ホーム.Sql.ExecuteReader
            Dim datacount As Integer = 1
            While expnsbd.Read
                DetailsList.Rows.Add()
                DetailsList(datacount, 1) = expnsbd.Item("expns_bd_id")
                DetailsList(datacount, 3) = ホーム.ExpnsbdCode
                DetailsList(datacount, 4) = expnsbd.Item("expns_bd_name")
                DetailsList(datacount, 5) = expnsbd.Item("expns_bd_spec")
                DetailsList(datacount, 6) = expnsbd.Item("expns_bd_unit")
                DetailsList(datacount, 7) = expnsbd.Item("expns_bd_quanity")
                quanity = DetailsList(datacount, 7)
                DetailsList(datacount, 8) = expnsbd.Item("expns_bd_costea")
                costea = DetailsList(datacount, 8)
                DetailsList(datacount, 9) = Math.Floor(quanity * costea)
                datacount += 1
            End While
            expnsbd.Close()

            Select Case ホーム.ExpnsbdCode
                Case 8147 '社内試験費
                    Reference.Visible = True
                Case 8151 '租税公課
                    Reference.Visible = True
                Case 8157 '法定福利
                    Reference.Visible = True
                Case 8177 '賦課金
                    Reference.Visible = True
                Case 8184 '人件費配賦
                    Reference.Visible = True
            End Select

            'ホーム.ExpnsbdID = 1 Then '設計費
            'ホーム.ExpnsbdID = 2 Then '社内試験費
            'ホーム.ExpnsbdID = 3 Then '品質管理費
            'ホーム.ExpnsbdID = 4 Then '労務管理費
            'ホーム.ExpnsbdID = 5 Then '租税公課
            'ホーム.ExpnsbdID = 6 Then '地代家賃
            'ホーム.ExpnsbdID = 7 Then '保険料
            'ホーム.ExpnsbdID = 8 Then '従業員給与手当
            'ホーム.ExpnsbdID = 9 Then '福利厚生費
            'ホーム.ExpnsbdID = 10 Then '法定福利費
            'ホーム.ExpnsbdID = 11 Then '事務用品費
            'ホーム.ExpnsbdID = 12 Then '会議費
            'ホーム.ExpnsbdID = 13 Then '通信費
            'ホーム.ExpnsbdID = 14 Then '旅費交通費
            'ホーム.ExpnsbdID = 15 Then '車両費(社用車維持費)
            'ホーム.ExpnsbdID = 16 Then '交際費
            'ホーム.ExpnsbdID = 17 Then '補償費
            'ホーム.ExpnsbdID = 18 Then '賦課金
            'ホーム.ExpnsbdID = 19 Then '広告宣伝費
            'ホーム.ExpnsbdID = 20 Then '雑費
            'ホーム.ExpnsbdID = 21 Then '人件費配賦
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
        ホーム.StackTrace = ex.StackTrace
        エラー.Show()
        Exit Sub
        End Try

    End Sub

    Private Sub DetailsList_DoubleClick(sender As Object, e As EventArgs) Handles DetailsList.DoubleClick

    End Sub

    Private Sub Entry_Click(sender As Object, e As EventArgs) Handles Entry.Click
        Try
            Dim ErrorCount As Integer = 0

            For DelChk As Integer = 1 To DetailsList.Rows.Count - 1
                If DetailsList(DelChk, 2) = True Then
                    ErrorCount += 1
                End If
            Next

            If ErrorCount > 0 Then
                If MsgBox("削除される項目があります。このまま登録しますか？", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
                    Exit Sub
                End If
            End If

            Dim RowIndex As Integer = DetailsList.Rows.Count - 1
            For RowsLoop As Integer = 1 To RowIndex - 1
                Dim Dflag As CellRange = DetailsList.GetCellRange(RowsLoop, 2)
                Dim ExpnsID As CellRange = DetailsList.GetCellRange(RowsLoop, 1)
                Dim ExpnsName As CellRange = DetailsList.GetCellRange(RowsLoop, 4)
                Dim ExpnsSpec As CellRange = DetailsList.GetCellRange(RowsLoop, 5)
                Dim ExpnsUnit As CellRange = DetailsList.GetCellRange(RowsLoop, 6)
                Dim ExpnsQuanity As CellRange = DetailsList.GetCellRange(RowsLoop, 7)
                Dim ExpnsCostea As CellRange = DetailsList.GetCellRange(RowsLoop, 8)
                If Dflag.Data = False And ExpnsName.Data <> Nothing Then
                    If ExpnsID.Data = Nothing Then
                        ホーム.Sql.CommandText = ""
                        ホーム.Sql.Parameters.Clear()
                        ホーム.Sql.CommandText = "INSERT INTO expense_breakdowns (stexpns_id,expns_bd_name,expns_bd_spec,expns_bd_unit,expns_bd_quanity,expns_bd_costea) VALUES (@stexpns_id,@expns_bd_name,@expns_bd_spec,@expns_bd_unit,@expns_bd_quanity,@expns_bd_costea)"
                    Else
                        ホーム.Sql.CommandText = ""
                        ホーム.Sql.Parameters.Clear()
                        ホーム.Sql.CommandText = "UPDATE expense_breakdowns SET stexpns_id=@stexpns_id,expns_bd_name=@expns_bd_name,expns_bd_spec=@expns_bd_spec,expns_bd_unit=@expns_bd_unit,expns_bd_quanity=@expns_bd_quanity,expns_bd_costea=@expns_bd_costea WHERE expns_bd_id=@expns_bd_id"
                        ホーム.Sql.Parameters.Add(New SqlParameter("@expns_bd_id", SqlDbType.Int))
                        ホーム.Sql.Parameters("@expns_bd_id").Value = ExpnsID.Data
                    End If
                    ホーム.Sql.Parameters.Add(New SqlParameter("@stexpns_id", SqlDbType.Int))
                    ホーム.Sql.Parameters.Add(New SqlParameter("@expns_bd_name", SqlDbType.NVarChar))
                    ホーム.Sql.Parameters.Add(New SqlParameter("@expns_bd_spec", SqlDbType.NVarChar))
                    ホーム.Sql.Parameters.Add(New SqlParameter("@expns_bd_unit", SqlDbType.NVarChar))
                    ホーム.Sql.Parameters.Add(New SqlParameter("@expns_bd_quanity", SqlDbType.Decimal))
                    ホーム.Sql.Parameters.Add(New SqlParameter("@expns_bd_costea", SqlDbType.Money))
                    ホーム.Sql.Parameters("@stexpns_id").Value = ホーム.ExpnsbdID
                    If ExpnsName.Data = Nothing Then
                        ExpnsName.Data = " "
                    End If
                    ホーム.Sql.Parameters("@expns_bd_name").Value = ExpnsName.Data
                    If ExpnsSpec.Data = Nothing Then
                        ExpnsSpec.Data = " "
                    End If
                    ホーム.Sql.Parameters("@expns_bd_spec").Value = ExpnsSpec.Data
                    If ExpnsUnit.Data = Nothing Then
                        ExpnsUnit.Data = " "
                    End If
                    ホーム.Sql.Parameters("@expns_bd_unit").Value = ExpnsUnit.Data

                    ホーム.Sql.Parameters("@expns_bd_quanity").Value = ExpnsQuanity.Data
                    ホーム.Sql.Parameters("@expns_bd_costea").Value = ExpnsCostea.Data
                    ホーム.Sql.ExecuteNonQuery()
                ElseIf Dflag.Data = True Then

                    If ExpnsID.Data <> Nothing Then
                        quanity = ExpnsQuanity.Data
                        costea = ExpnsCostea.Data
                        amount = Math.Floor(quanity * costea)
                        TExpns -= amount
                        ホーム.Sql.Parameters.Clear()
                        ホーム.Sql.CommandText = "DELETE FROM expense_breakdowns WHERE expns_bd_id=" & ExpnsID.Data
                        ホーム.Sql.ExecuteNonQuery()
                    End If
                End If
            Next

            '合計金額を登録
            ホーム.Sql.CommandText = ""
            ホーム.Sql.Parameters.Clear()
            ホーム.Sql.CommandText = "UPDATE site_expenses SET stexpns_amount=@stexpns_amount WHERE stexpns_id=@stexpns_id"
            ホーム.Sql.Parameters.Add(New SqlParameter("@stexpns_amount", SqlDbType.Int))
            ホーム.Sql.Parameters.Add(New SqlParameter("@stexpns_id", SqlDbType.Int))
            ホーム.Sql.Parameters("@stexpns_id").Value = ホーム.ExpnsbdID
            ホーム.Sql.Parameters("@stexpns_amount").Value = TExpns
            ホーム.Sql.ExecuteNonQuery()


            For RowsLoop As Integer = 1 To RowIndex - 1
                Dim ExpnsID As CellRange = DetailsList.GetCellRange(RowsLoop, 1)
                Dim Dflag As CellRange = DetailsList.GetCellRange(RowsLoop, 2)
                If Dflag.IsValid = True Then
                    '削除チェック
                    If Dflag.Data = True Then
                        DetailsList.Rows.Remove(RowsLoop)
                        RowsLoop = RowsLoop - 1
                    End If
                End If
            Next

            MsgBox("登録完了", MsgBoxStyle.OkOnly, "現場経費内訳")
            ホーム.Modified = "false"
            Me.Close()
            現場経費作成.TopLevel = False
            ホーム.FormPanel.Controls.Add(現場経費作成)
            現場経費作成.Show()

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try

    End Sub

    Private Sub Reference_Click(sender As Object, e As EventArgs) Handles Reference.Click
        Try
            For DetailsRowCount As Integer = 1 To DetailsList.Rows.Count - 1
                If DetailsList.Rows(DetailsRowCount).Caption = "▶" Then
                    SelectRow = DetailsRowCount
                End If
            Next
            'If SelectRow = Nothing Then
            Select Case ホーム.ExpnsbdCode
                Case 8147
                    費用マスタ一覧.ParentFormName = "現場経費"
                    費用マスタ一覧.CostClassCode = 8
                    費用マスタ一覧.CostClassName = "試験費"
                    費用マスタ一覧.Show()
                Case 8151
                    マスタ一覧.ClickButton = "StampTaxes"
                    マスタ一覧.Show()
                Case 8157
                    マスタ一覧.ClickButton = "Insurances"
                    マスタ一覧.Show()
                Case 8177
                    マスタ一覧.ClickButton = "LevyCosts"
                    マスタ一覧.Show()
                Case 8184
                    マスタ一覧.ClickButton = "Salaries"
                    マスタ一覧.Show()
            End Select
            マスタ一覧.Entry.Visible = False
            マスタ一覧.MasterContentsList.AllowEditing = False
            マスタ一覧.MasterContentsList.Cols(5).Width = 0
            マスタ一覧.MasterContentsList.Cols(6).Width = 0
            マスタ一覧.MasterContentsList.Width = 421

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try

    End Sub

    Private Sub DetailsList_AfterEdit(sender As Object, e As RowColEventArgs) Handles DetailsList.AfterEdit
        Try
            If DetailsList(e.Row, 7) = Nothing Then
                DetailsList(e.Row, 7) = 0
            End If
            If DetailsList(e.Row, 8) = Nothing Then
                DetailsList(e.Row, 8) = 0
            End If
            If e.Col = 7 Or 8 Then
                quanity = DetailsList(e.Row, 7)
                costea = DetailsList(e.Row, 8)
                amount = Math.Floor(quanity * costea)
                DetailsList(e.Row, 9) = amount

                Dim RowCount As Integer = DetailsList.Rows.Count
                TExpns = 0
                For AmountDemand As Integer = 1 To RowCount - 1
                    Dim amount As Int64 = DetailsList(AmountDemand, 9)
                    TExpns += amount
                Next
                TotalExpense.Text = TExpns
            End If
            ホーム.Modified = "True"

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try

    End Sub

    Private Sub DetailsList_AfterRowColChange(sender As Object, e As RangeEventArgs) Handles DetailsList.AfterRowColChange
        Try
            Dim Col As Integer = DetailsList.Selection.LeftCol
            Dim Row As Integer = DetailsList.Selection.TopRow

            For DetailsRowCount As Integer = 0 To DetailsList.Rows.Count - 1
                DetailsList.Rows(DetailsRowCount).Caption = ""
            Next
            DetailsList.Rows(Row).Caption = "▶"

            If Col = 7 Or Col = 8 Then
                DetailsList.ImeMode = ImeMode.Disable
            Else
                DetailsList.ImeMode = ImeMode.On
            End If

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try

    End Sub

    Private Sub DetailsList_BeforeRowColChange(sender As Object, e As RangeEventArgs) Handles DetailsList.BeforeRowColChange
        'Dim Col As Integer = DetailsList.Selection.LeftCol
        'If Col = 7 Or Col = 8 Then
        '    DetailsList.ImeMode = ImeMode.Disable
        'Else
        '    DetailsList.ImeMode = ImeMode.On
        'End If
    End Sub

    Private Sub DetailsList_Click(sender As Object, e As EventArgs) Handles DetailsList.Click
        Try
            Dim Col As Integer = DetailsList.Selection.LeftCol
            If Col = 7 Or Col = 8 Then
                DetailsList.ImeMode = ImeMode.Disable
            Else
                DetailsList.ImeMode = ImeMode.On
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub DetailsList_StartEdit(sender As Object, e As RowColEventArgs) Handles DetailsList.StartEdit
        Try
            Dim Col As Integer = DetailsList.Selection.LeftCol
            If Col = 7 Or Col = 8 Then
                DetailsList.ImeMode = ImeMode.Disable
            Else
                DetailsList.ImeMode = ImeMode.On
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub
End Class