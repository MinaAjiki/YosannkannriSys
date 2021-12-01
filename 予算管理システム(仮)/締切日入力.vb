Imports C1.Win.C1FlexGrid
Imports System.Data.SqlClient
Public Class 締切日入力
    Private Sub 締切日入力_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '管理データテーブルに登録されている締切日を取得
        ホーム.Sql.CommandText = "SELECT contents FROM controldata WHERE class_code=30"
        Deadline.Item(1, 1) = ホーム.Sql.ExecuteScalar
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
        ホーム.Transaction = ホーム.Connection.BeginTransaction
        ホーム.Sql.CommandText = ""
        ホーム.Sql.Parameters.Clear()

        ホーム.Sql.Transaction = ホーム.Transaction
        ホーム.Sql.Parameters.Add(New SqlParameter("@classcode", SqlDbType.SmallInt))
        ホーム.Sql.Parameters.Add(New SqlParameter("@contents", SqlDbType.Date))
        ホーム.Sql.CommandText = "UPDATE controldata SET contents=@contents WHERE class_code=@classcode"
        ホーム.Sql.Parameters("@classcode").Value = 30
        ホーム.Sql.Parameters("@contents").Value = Deadline.Item(1, 1)
        ホーム.Sql.ExecuteNonQuery()
        ホーム.Transaction.Commit()
        Me.Close()
    End Sub
End Class