Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports System.Data.SqlClient
Imports System.Windows.Input.Keyboard

Public Class 詳細入力表
    Dim ChangeFlag As Integer
    Dim ChangeValue As Integer
    Dim outsrcr_x As Integer = 0
    Dim outsrcr_y As Integer = 0
    Dim DtlIDList As New List(Of Integer)

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
    Private Sub cancel_MouseLeave(sender As Object, e As EventArgs) Handles Cancel.MouseLeave
        Cancel.ImageIndex = 6
    End Sub

    Private Sub cancel_MouseEnter(sender As Object, e As EventArgs) Handles Cancel.MouseEnter
        Cancel.Cursor = Cursors.Hand
        Cancel.ImageIndex = 7
    End Sub

    Private Sub cancel_MouseDown(sender As Object, e As MouseEventArgs) Handles Cancel.MouseDown
        Cancel.ImageIndex = 8
    End Sub

    Private Sub 詳細入力表_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Try

            進行状況.Show()
            進行状況.Refresh()

            Cursor.Current = Cursors.WaitCursor

            'Me.Visible = True

            DetailList(0, 2) = "工種"
            DetailList(1, 2) = "工種"
            DetailList(2, 2) = "工種"
            DetailList(0, 3) = "工種名"
            DetailList(1, 3) = "名称"
            DetailList(1, 4) = "名称"
            DetailList(2, 3) = "規格"
            DetailList(2, 4) = "規格"
            DetailList(0, 4) = "単位"
            DetailList(0, 5) = "明細金額"
            DetailList(1, 5) = "直営金額"
            DetailList(2, 5) = "直営残高"

            DetailList.MergedRanges.Add(0, 2, 2, 2)
            DetailList.MergedRanges.Add(1, 3, 1, 4)
            DetailList.MergedRanges.Add(2, 3, 2, 4)
            Dim CellRange As CellRange = DetailList.GetCellRange(2, 5)
            CellRange.StyleNew.ForeColor = Color.Red


            Dim ItemCount As Integer = 0
            ホーム.SystemSql.CommandText = "SELECT item_name FROM name_masters WHERE class_code=5 ORDER BY detail_code ASC"
            Dim ItemReader As SqlDataReader = ホーム.SystemSql.ExecuteReader
            While ItemReader.Read

                DetailList(1, 6 + ItemCount) = ItemReader.Item("item_name")
                DetailList(2, 6 + ItemCount) = ItemReader.Item("item_name")
                DetailList.MergedRanges.Add(1, 6 + ItemCount, 2, 6 + ItemCount)
                ItemCount += 1
            End While
            ItemReader.Close()

            ホーム.Sql.CommandText = "SELECT Count(*) FROM subject_details WHERE budget_no=" & ホーム.BudgetNo
            Dim DetailsCount As Integer = ホーム.Sql.ExecuteScalar

            If DetailsCount > 5 Then
                DetailList.Rows.Count = (DetailsCount * 3) + 3

            Else
                DetailList.Rows.Count = 21
            End If

            Dim RowCount As Integer = 0
            Dim RowNo As Integer = 0
            Dim DtlTotal As Int64 = 0
            Dim DtlIDList As New List(Of Integer)
            Dim MngmntTotal As Int64 = 0
            Dim BlncTotal As Int64 = 0
            Dim SubjectTotal(9) As Int64

        ホーム.Sql.CommandText = "SELECT * FROM subject_details WHERE budget_no=" & ホーム.BudgetNo & " ORDER BY s_wrktyp_code,dtl_no ASC"
        Dim DetailsReader As SqlDataReader = ホーム.Sql.ExecuteReader
        While DetailsReader.Read
                    RowCount += 1
                    RowNo += 1

                DetailList(RowCount * 3, 1) = DetailsReader.Item("dtl_id")
                DtlIDList.Add(DetailsReader.Item("dtl_id"))
                DetailList(RowCount * 3, 2) = DetailsReader.Item("s_wrktyp_code")
                DetailList(RowCount * 3 + 1, 2) = DetailList(RowCount * 3, 2)
                DetailList(RowCount * 3 + 2, 2) = DetailList(RowCount * 3, 2)
                DetailList.MergedRanges.Add((RowCount * 3), 2, (RowCount * 3) + 2, 2)
                DetailList(RowCount * 3, 3) = DetailsReader.Item("s_wrktyp_name")

                Dim OutsrcngAmount As Int64 = 0

                For subjectLoop As Integer = 1 To 9
                    DetailList(RowCount * 3, 5 + subjectLoop) = " "
                    DetailList((RowCount * 3) + 1, 5 + subjectLoop) = " "
                    If IsDBNull(DetailsReader.Item("amount" & subjectLoop)) = False Then
                        DetailList((RowCount * 3) + 2, 5 + subjectLoop) = DetailsReader.Item("amount" & subjectLoop)
                    Else
                        DetailList((RowCount * 3) + 2, 5 + subjectLoop) = 0
                    End If
                    DetailList.MergedRanges.Add((RowCount * 3), 5 + subjectLoop, (RowCount * 3) + 1, 5 + subjectLoop)

                    SubjectTotal(subjectLoop) += DetailList((RowCount * 3) + 2, 5 + subjectLoop)

                    If Not subjectLoop = 3 Then
                        OutsrcngAmount += DetailList((RowCount * 3) + 2, 5 + subjectLoop)
                    End If
                Next

                DetailList((RowCount * 3) + 1, 3) = DetailsReader.Item("dtl_name")
                DetailList((RowCount * 3) + 1, 4) = DetailList((RowCount * 3) + 1, 3)
                DetailList((RowCount * 3) + 2, 3) = DetailsReader.Item("dtl_spec")
                DetailList((RowCount * 3) + 2, 4) = DetailList((RowCount * 3) + 2, 3)
                DetailList.MergedRanges.Add((RowCount * 3) + 1, 3, (RowCount * 3) + 1, 4)
                DetailList.MergedRanges.Add((RowCount * 3) + 2, 3, (RowCount * 3) + 2, 4)
                DetailList(RowCount * 3, 4) = DetailsReader.Item("dtl_unit")
                DetailList((RowCount * 3), 5) = DetailsReader.Item("dtl_amount")
                DetailList((RowCount * 3) + 1, 5) = OutsrcngAmount
                Dim total As Int64 = DetailList((RowCount * 3) + 1, 5) + DetailList((RowCount * 3) + 2, 8)
                DetailList((RowCount * 3) + 2, 5) = DetailList((RowCount * 3), 5) - total

                    DtlTotal += DetailList((RowCount * 3), 5)

                Dim DrctlyMngmntTotalRange As CellRange = DetailList.GetCellRange((RowCount * 3) + 2, 5)
                DrctlyMngmntTotalRange.StyleNew.ForeColor = Color.Red

                If RowCount Mod 2 = 0 Then
                    DetailList.Rows(RowCount * 3).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                    DetailList.Rows((RowCount * 3) + 1).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                    DetailList.Rows((RowCount * 3) + 2).StyleNew.BackColor = System.Drawing.Color.FromArgb(255, 255, 214)
                End If

                MngmntTotal += OutsrcngAmount
                BlncTotal += DetailList((RowCount * 3) + 2, 5)
            End While
            DetailsReader.Close()

            DetailTotal.Value = DtlTotal

            ManagementTotal.Value = MngmntTotal
            BalanceTotal.Value = BlncTotal
            SubjectTotal1.Value = SubjectTotal(1)
            SubjectTotal2.Value = SubjectTotal(2)
            SubjectTotal3.Value = SubjectTotal(3)
            SubjectTotal4.Value = SubjectTotal(4)
            SubjectTotal5.Value = SubjectTotal(5)
            SubjectTotal6.Value = SubjectTotal(6)
            SubjectTotal7.Value = SubjectTotal(7)
            SubjectTotal8.Value = SubjectTotal(8)
            SubjectTotal9.Value = SubjectTotal(9)



            Cursor.Current = Cursors.Default
            進行状況.Close()

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

    Private Sub DetailList_DoubleClick(sender As Object, e As EventArgs) Handles DetailList.DoubleClick
        Try
            Dim range As CellRange = DetailList.CursorCell

            Dim row As Integer = range.TopRow
            Dim col As Integer = range.LeftCol

            If col = 8 Then
                DetailList.Rows(row).AllowEditing = False
                Exit Sub
            End If

            Dim Text As String = DetailList(row, col)

            If IsNothing(Text) = True Then
                DetailList.Rows(row).AllowEditing = False
            Else
                DetailList.Rows(row).AllowEditing = True
            End If
            ホーム.Modified = "True"


        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub
    Private Sub DetailList_BeforeEdit(sender As Object, e As RowColEventArgs) Handles DetailList.BeforeEdit
        Try
            Dim range As CellRange = DetailList.CursorCell

            Dim row As Integer = range.TopRow
            Dim col As Integer = range.LeftCol

            If col = 8 Then
                DetailList.Rows(row).AllowEditing = False
                Exit Sub
            End If

            Dim Text As String = DetailList(row, col)

            If IsNothing(Text) = True Then
                DetailList.Rows(row).AllowEditing = False
            Else
                DetailList.Rows(row).AllowEditing = True
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub
    Private Sub Entry_Click(sender As Object, e As EventArgs) Handles Entry.Click

        Try

            ホーム.Transaction = ホーム.Connection.BeginTransaction

            ホーム.Sql.Transaction = ホーム.Transaction

            For RowCount As Integer = 1 To ((DetailList.Rows.Count - 3) / 3)

                For subjectloop As Integer = 6 To 14
                    If Not subjectloop = 8 Then
                        ホーム.Sql.CommandText = ""
                        ホーム.Sql.Parameters.Clear()
                        If IsNothing(DetailList(RowCount * 3, 1)) = False Then
                            ホーム.Sql.CommandText = "SELECT Count(*) FROM subjects WHERE budget_no=" & ホーム.BudgetNo & " AND dtl_id=" & DetailList(RowCount * 3, 1) & " AND sbjct_code=" & DetailList(0, subjectloop)
                            Dim SubjectCount As Integer = ホーム.Sql.ExecuteScalar

                            ホーム.Sql.Parameters.Add(New SqlParameter("@sbjct_code", SqlDbType.SmallInt)).Value = DetailList(0, subjectloop)
                            ホーム.Sql.Parameters.Add(New SqlParameter("@sbjct_amount", SqlDbType.Money)).Value = DetailList((RowCount * 3) + 2, subjectloop)

                            If SubjectCount = 0 Then
                                If Not DetailList((RowCount * 3) + 2, subjectloop) = 0 Then
                                    ホーム.Sql.Parameters.Add(New SqlParameter("@dtl_id", SqlDbType.Int)).Value = DetailList(RowCount * 3, 1)
                                    ホーム.Sql.Parameters.Add(New SqlParameter("@budget_no", SqlDbType.SmallInt)).Value = ホーム.BudgetNo
                                    ホーム.Sql.CommandText = "INSERT INTO subjects (dtl_id,budget_no,sbjct_code,sbjct_amount) VALUES (@dtl_id,@budget_no,@sbjct_code,@sbjct_amount)"
                                End If
                            Else
                                ホーム.Sql.CommandText = "UPDATE subjects SET sbjct_amount=@sbjct_amount WHERE budget_no=" & ホーム.BudgetNo & " AND dtl_id=" & DetailList(RowCount * 3, 1) _
                                                           & " AND sbjct_code=@sbjct_code"

                            End If
                            ホーム.Sql.ExecuteNonQuery()
                        End If
                    End If
                Next

            Next

            ホーム.Transaction.Commit()

            ホーム.Modified = "False"


            MsgBox("登録完了", MsgBoxStyle.OkOnly, "詳細入力表")

            ホーム.Sql.CommandText = ""
            ホーム.Sql.Parameters.Clear()

        Catch ex As Exception
            ホーム.Transaction.Rollback()
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try

    End Sub

    Private Sub DetailList_AfterEdit(sender As Object, e As RowColEventArgs) Handles DetailList.AfterEdit
        Try
            ホーム.Modified = "True"


            Dim MngmntTotal As Int64 = 0
            Dim BlncTotal As Int64 = 0
            Dim SubjectTotal(14) As Int64

            For RowCount As Integer = 1 To ((DetailList.Rows.Count - 3) / 3)

                Dim subjectsum As Int64 = 0
                For subjectLoop As Integer = 6 To 14

                    If Not subjectLoop = 8 Then
                        SubjectTotal(subjectLoop) += DetailList((RowCount * 3) + 2, subjectLoop)
                        subjectsum += DetailList((RowCount * 3) + 2, subjectLoop)
                    End If
                Next

                DetailList((RowCount * 3) + 1, 5) = subjectsum
                Dim total As Int64 = DetailList((RowCount * 3) + 1, 5) + DetailList((RowCount * 3) + 2, 8)
                DetailList((RowCount * 3) + 2, 5) = DetailList((RowCount * 3), 5) - total

                MngmntTotal += DetailList((RowCount * 3), 5) - DetailList((RowCount * 3) + 2, 8)
                BlncTotal += DetailList((RowCount * 3) + 1, 5) - subjectsum

            Next


            ManagementTotal.Value = MngmntTotal
            BalanceTotal.Value = BlncTotal
            SubjectTotal1.Value = SubjectTotal(6)
            SubjectTotal2.Value = SubjectTotal(7)
            SubjectTotal4.Value = SubjectTotal(9)
            SubjectTotal5.Value = SubjectTotal(10)
            SubjectTotal6.Value = SubjectTotal(11)
            SubjectTotal7.Value = SubjectTotal(12)
            SubjectTotal8.Value = SubjectTotal(13)
            SubjectTotal9.Value = SubjectTotal(14)

            If IsKeyDown(Windows.Input.Key.Enter) = True Then

                Dim SelectionCol As Integer = DetailList.Selection.LeftCol
                Dim SelectionRow As Integer = DetailList.Selection.TopRow



                If SelectionCol = 14 Then

                    DetailList.Select(SelectionRow + 3, 6)
                    SendKeys.Send("{LEFT}")

                ElseIf SelectionCol = 7 Then
                    DetailList.Select(SelectionRow, 9)
                    SendKeys.Send("{LEFT}")
                End If
            End If


        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Me.BackgroundWorker1.ReportProgress(10)
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        進行状況.Close()
    End Sub

    Private Sub DetailList_KeyDown(sender As Object, e As KeyEventArgs) Handles DetailList.KeyDown
        Try



            If e.KeyCode = Keys.Enter Then

                Dim SelectionCol As Integer = DetailList.Selection.LeftCol
                Dim SelectionRow As Integer = DetailList.Selection.TopRow



                If SelectionCol = 14 Then

                    DetailList.Select(SelectionRow + 3, 6)
                    SendKeys.Send("{ENTER}")
                    SendKeys.Send("{LEFT}")


                ElseIf SelectionCol = 7 Then
                    DetailList.Select(SelectionRow, 9)
                    SendKeys.Send("{ENTER}")
                    SendKeys.Send("{LEFT}")

                Else
                    SendKeys.Send("{ENTER}")

                End If

            End If


        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub
End Class