Imports C1.Win.C1FlexGrid
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
        注文書番号入力.ChangeHistory = Deadline(1, 1)
    End Sub

    Private Sub Deadline_AfterEdit(sender As Object, e As RowColEventArgs) Handles Deadline.AfterEdit
        Dim SetImageRow As Integer = e.Row
        If 注文書番号入力.ChangeHistory <> Deadline(1, 1) Then
            Deadline.SetCellImage(SetImageRow, 2, Image.FromFile(Application.StartupPath & "\Resources\Edit_source.png"))
        End If
    End Sub

    Private Sub Entry_Click(sender As Object, e As EventArgs) Handles Entry.Click
        Try
            'ホーム.Sql.CommandText = "SELECT contents FROM controldata WHERE class_code=30"
            ホーム.Sql.CommandText = "SELECT MAX(closing_date) FROM productions"
            Dim BeforeDeadline As String = ホーム.Sql.ExecuteScalar
            If BeforeDeadline = "" Then
                BeforeDeadline = "1900/01/01"
            End If
            Dim OutsrcrID As Integer
            Dim ProID As Integer
            Dim Costea As Int64
            Dim Quanity As Decimal
            Dim Amount As Int64

            Dim AfterDeadline As String = Deadline(1, 1)
            Dim ReBeforeDeadline As String = BeforeDeadline.Replace("-", "/")
            If ReBeforeDeadline >= AfterDeadline Then
                If MsgBox("最新の出来高締切日より前の日付です。", MsgBoxStyle.OkOnly, "エラー") Then
                    Exit Sub
                End If
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

            ホーム.Transaction = ホーム.Connection.BeginTransaction
            ホーム.Sql.Transaction = ホーム.Transaction

            ホーム.Sql.CommandText = ""
            ホーム.Sql.Parameters.Clear()
            ホーム.Sql.CommandText = "SELECT * FROM productions WHERE closing_date = @BDDATE"
            ホーム.Sql.Parameters.Add(New SqlParameter("@BDDATE", SqlDbType.Date))
            ホーム.Sql.Parameters("@BDDATE").Value = ReBeforeDeadline
            Dim Productreader As SqlDataReader = ホーム.Sql.ExecuteReader
            While Productreader.Read
                OutsrcrID = Productreader.Item("outsrcr_id")
                ProID = Productreader.Item("dtl_id")
                Costea = Productreader.Item("total_costea")
                Quanity = Productreader.Item("total_quanity")
                Amount = Productreader.Item("total_amount")

                Dim Connection As New SqlConnection
                Dim Sql As New SqlCommand
                Connection.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & ホーム.UserDataPath & ホーム.UserDataName & ";Integrated Security=True"
                Connection.Open()
                Sql.Connection = Connection

                Sql.CommandText = ""
                Sql.Parameters.Clear()

                Sql.Parameters.Add(New SqlParameter("@closing_date", SqlDbType.Date))
                Sql.Parameters.Add(New SqlParameter("@dtl_id", SqlDbType.Int))
                Sql.Parameters.Add(New SqlParameter("@outsrcr_id", SqlDbType.Int))
                Sql.Parameters.Add(New SqlParameter("@last_costea", SqlDbType.Money))
                Sql.Parameters.Add(New SqlParameter("@last_quanity", SqlDbType.Decimal))
                Sql.Parameters.Add(New SqlParameter("@last_amount", SqlDbType.Money))
                Sql.Parameters.Add(New SqlParameter("@total_costea", SqlDbType.Money))
                Sql.Parameters.Add(New SqlParameter("@total_quanity", SqlDbType.Decimal))
                Sql.Parameters.Add(New SqlParameter("@total_amount", SqlDbType.Money))
                Sql.Parameters("@closing_date").Value = AfterDeadline
                Sql.Parameters("@dtl_id").Value = ProID
                Sql.Parameters("@outsrcr_id").Value = OutsrcrID
                Sql.Parameters("@last_costea").Value = Costea
                Sql.Parameters("@last_quanity").Value = Quanity
                Sql.Parameters("@last_amount").Value = Amount
                Sql.Parameters("@total_costea").Value = Costea
                Sql.Parameters("@total_quanity").Value = Quanity
                Sql.Parameters("@total_amount").Value = Amount
                Sql.CommandText = "INSERT INTO productions (closing_date,dtl_id,outsrcr_id,last_costea,last_quanity,last_amount,total_costea,total_quanity,total_amount)
                                    VALUES(@closing_date,@dtl_id,@outsrcr_id,@last_costea,@last_quanity,@last_amount,@total_costea,@total_quanity,@total_amount)"
                Sql.ExecuteNonQuery()
            End While
            Productreader.Close()

            ホーム.Sql.CommandText = ""
            ホーム.Sql.Parameters.Clear()
            ホーム.Sql.Parameters.Add(New SqlParameter("@classcode", SqlDbType.SmallInt))
            ホーム.Sql.Parameters.Add(New SqlParameter("@contents", SqlDbType.Date))
            ホーム.Sql.CommandText = "UPDATE controldata SET contents=@contents WHERE class_code=@classcode"
            ホーム.Sql.Parameters("@classcode").Value = 30
            ホーム.Sql.Parameters("@contents").Value = Date.Parse(Deadline.Item(1, 1))
            ホーム.Sql.ExecuteNonQuery()



            ホーム.Transaction.Commit()
            Me.Close()
            MsgBox("登録完了", MsgBoxStyle.OkOnly, "締切日")

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub
End Class