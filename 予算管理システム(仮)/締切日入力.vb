﻿Imports C1.Win.C1FlexGrid
Imports System.Data.SqlClient
Public Class 締切日入力
    Private Sub 締切日入力_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '管理データテーブルに登録されている締切日を取得
        Try
            ホーム.Sql.CommandText = "SELECT contents FROM controldata WHERE class_code=30"
            Deadline.Item(1, 1) = ホーム.Sql.ExecuteScalar
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub
    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs) Handles Button4.MouseLeave
        Button4.ImageIndex = 3
    End Sub

    Private Sub Button4_MouseEnter(sender As Object, e As EventArgs) Handles Button4.MouseEnter
        Button4.Cursor = Cursors.Hand
        Button4.ImageIndex = 4
    End Sub

    Private Sub Button4_MouseDown(sender As Object, e As MouseEventArgs) Handles Button4.MouseDown
        Button4.ImageIndex = 5
    End Sub

    Private Sub Deadline_Click(sender As Object, e As EventArgs) Handles Deadline.Click

    End Sub
    Private Sub Deadline_BeforeEdit(sender As Object, e As RowColEventArgs) Handles Deadline.BeforeEdit
        Dim SetImageRow As Integer = e.Row
        Dim d As DateTime = Deadline.GetData(SetImageRow, 1)
    End Sub

    Private Sub Deadline_AfterEdit(sender As Object, e As RowColEventArgs) Handles Deadline.AfterEdit
        Dim SetImageRow As Integer = e.Row
        Deadline.SetCellImage(SetImageRow, 2, Image.FromFile(Application.StartupPath & "\Edit_source.png"))
    End Sub

    Private Sub Entry_Click(sender As Object, e As EventArgs) Handles Entry.Click
        Try
            ホーム.Sql.CommandText = "SELECT contents FROM controldata WHERE class_code=30"
            Dim BeforeDeadline As String = ホーム.Sql.ExecuteScalar
            If BeforeDeadline = "" Then
                BeforeDeadline = "1900/01/01"
            End If
            Dim ProID As Integer
            Dim Costea As Integer
            Dim Quanity As Integer
            Dim Amount As Integer

            'Dim Coopid As Integer = ホーム.Sql.ExecuteScalar
            Dim AfterDeadline As String = Deadline(1, 1)
            Dim ReBeforeDeadline As String = BeforeDeadline.Replace("-", "/")
            If ReBeforeDeadline >= AfterDeadline Then
                MsgBox("実施工期が適切ではありません。", MsgBoxStyle.OkOnly, "エラー")
                Exit Sub
            End If

            Dim ProductList As New List(Of Integer)
            ホーム.Sql.Parameters.Clear()
            ホーム.Sql.CommandText = "SELECT dtl_id FROM productions WHERE closing_date = @BDDATE"
            ホーム.Sql.Parameters.Add(New SqlParameter("@BDDATE", SqlDbType.Date))
            ホーム.Sql.Parameters("@BDDATE").Value = ReBeforeDeadline
            Dim Productcount As SqlDataReader = ホーム.Sql.ExecuteReader
            While Productcount.Read
                ProductList.Add(Productcount.Item("dtl_id"))
            End While
            Productcount.Close()

            If ProductList.Count > 0 Then
                If MsgBox("現在登録されている出来高を繰り越します。よろしいですか？", MsgBoxStyle.OkCancel, "確認") = MsgBoxResult.Cancel Then
                    Exit Sub
                End If
            End If

            For Proloop As Integer = 0 To ProductList.Count - 1
                ホーム.Sql.Parameters.Clear()
                ホーム.Sql.CommandText = "SELECT * FROM productions WHERE closing_date = @BDDATE AND dtl_id = " & ProductList.Item(Proloop)
                ホーム.Sql.Parameters.Add(New SqlParameter("@BDDATE", SqlDbType.Date))
                ホーム.Sql.Parameters("@BDDATE").Value = ReBeforeDeadline
                Dim Productreader As SqlDataReader = ホーム.Sql.ExecuteReader
                While Productreader.Read
                    ProID = Productreader.Item("dtl_id")
                    Costea = Productreader.Item("total_costea")
                    Quanity = Productreader.Item("total_quanity")
                    Amount = Productreader.Item("total_amount")
                End While
                Productreader.Close()

                ホーム.Sql.CommandText = ""
                ホーム.Sql.Parameters.Clear()
                ホーム.Sql.CommandText = "INSERT INTO productions (closing_date,dtl_id,last_costea,last_quanity,last_amount,total_costea,total_quanity,total_amount)VALUES(@closing_date,@dtl_id,@last_costea,@last_quanity,@last_amount,@total_costea,@total_quanity,@total_amount)"
                ホーム.Sql.Parameters.Add(New SqlParameter("@closing_date", SqlDbType.Date))
                ホーム.Sql.Parameters.Add(New SqlParameter("@dtl_id", SqlDbType.Int))
                ホーム.Sql.Parameters.Add(New SqlParameter("@last_costea", SqlDbType.Money))
                ホーム.Sql.Parameters.Add(New SqlParameter("@last_quanity", SqlDbType.Decimal))
                ホーム.Sql.Parameters.Add(New SqlParameter("@last_amount", SqlDbType.Money))
                ホーム.Sql.Parameters.Add(New SqlParameter("@total_costea", SqlDbType.Money))
                ホーム.Sql.Parameters.Add(New SqlParameter("@total_quanity", SqlDbType.Decimal))
                ホーム.Sql.Parameters.Add(New SqlParameter("@total_amount", SqlDbType.Money))
                ホーム.Sql.Parameters("@closing_date").Value = AfterDeadline
                ホーム.Sql.Parameters("@dtl_id").Value = ProID
                ホーム.Sql.Parameters("@last_costea").Value = Costea
                ホーム.Sql.Parameters("@last_quanity").Value = Quanity
                ホーム.Sql.Parameters("@last_amount").Value = Amount
                ホーム.Sql.Parameters("@total_costea").Value = Costea
                ホーム.Sql.Parameters("@total_quanity").Value = Quanity
                ホーム.Sql.Parameters("@total_amount").Value = Amount
                ホーム.Sql.ExecuteNonQuery()
                Productreader.Close()

            Next


            ホーム.Transaction = ホーム.Connection.BeginTransaction
            ホーム.Sql.CommandText = ""
            ホーム.Sql.Parameters.Clear()

            ホーム.Sql.Transaction = ホーム.Transaction
            ホーム.Sql.Parameters.Add(New SqlParameter("@classcode", SqlDbType.SmallInt))
            ホーム.Sql.Parameters.Add(New SqlParameter("@contents", SqlDbType.Date))
            ホーム.Sql.CommandText = "UPDATE controldata SET contents=@contents WHERE class_code=@classcode"
            ホーム.Sql.Parameters("@classcode").Value = 30
            ホーム.Sql.Parameters("@contents").Value = Date.Parse(Deadline.Item(1, 1))
            ホーム.Sql.ExecuteNonQuery()



            ホーム.Transaction.Commit()
            MsgBox("登録完了", MsgBoxStyle.OkOnly, "締切日")
            Me.Close()
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub
End Class