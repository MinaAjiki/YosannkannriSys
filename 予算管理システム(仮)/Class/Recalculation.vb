Imports System.Data.SqlClient
Public Class Recalculation
    Private ClssCode As Integer
    Public Sub New(ByVal ClassCode As Integer)
        ClssCode = ClassCode
    End Sub
    Public Function Recalculation() As String

        Recalculation = ""
        Cursor.Current = Cursors.WaitCursor

        Dim ClassCount As Integer = ClssCode - 12
        Dim StartClass As Integer = ClssCode - 1


        ホーム.Transaction = ホーム.Connection.BeginTransaction
        ホーム.Sql.Transaction = ホーム.Transaction

        Dim ProcessCommand As New SqlCommand
        Dim ProcessConnection As New SqlConnection
        ProcessConnection.ConnectionString = ホーム.Connection.ConnectionString
        ProcessConnection.Open()
        ProcessCommand.Connection = ProcessConnection


        For ClassLoop As Integer = StartClass To ClassCount

            ホーム.Sql.CommandText = "SELECT * FROM #UpdateID"
            Dim UpdateReader As SqlDataReader = ホーム.Sql.ExecuteReader
            While UpdateReader.Read

                ProcessCommand.CommandText = "SELECT (*) FROM project_cost_breakdowns WHERE cstclss_code=" & ClassLoop & " AND cstmstr_id=" & UpdateReader.Item("prjctcstid")
                Dim DataCount_bd As Integer = ホーム.Sql.ExecuteScalar

                If DataCount_bd > 0 Then

                    ProcessCommand.CommandText = "CREATE TABLE #UpdateID_bd (prjctcst_bd_id INT)"
                    ProcessCommand.ExecuteNonQuery()

                    ProcessCommand.CommandText = "UPDATE "



                End If



            End While
            UpdateReader.Close()






        Next





        ホーム.Transaction.Commit()

        MsgBox("インポート完了", MsgBoxStyle.OkOnly, "材料表インポート")
        Return Recalculation
    End Function
End Class
