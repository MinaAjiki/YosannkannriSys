Imports System.ComponentModel
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.FileIO
Imports System.Data.OleDb
Imports C1.C1Excel
Public Class ImportMaterial
    Private Path As String
    Public Sub New(ByVal SavePath As String)
        Path = SavePath '保存先パス
    End Sub
    Public Function ImportMaterial() As String
        ImportMaterial = ""
        Cursor.Current = Cursors.WaitCursor


        Dim ConnectionString As String =
        "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path + ";Extended Properties=""Excel 12.0;HDR=Yes"""
        Dim Connection As New System.Data.OleDb.OleDbConnection(ConnectionString)
        Connection.Open()

        'ファイルの値を取得する
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = Connection
        cmd.CommandText = "SELECT * FROM [材料表$] "

        Dim Adapter As New OleDbDataAdapter
        Dim DT As New DataTable
        Adapter.SelectCommand = cmd
        Adapter.Fill(DT)
        Dim DataCount As Integer = DT.Rows.Count

        Dim DataRow As DataRow

        ホーム.Transaction = ホーム.Connection.BeginTransaction
        ホーム.Sql.Transaction = ホーム.Transaction

        For RowLoop As Integer = 0 To DataCount - 1
            DataRow = DT.Rows(RowLoop)
            If IsDBNull(DataRow.Item(3)) = False Then
                Dim Name As String = DataRow.Item(3)
                If IsNumeric(DataRow.Item(1)) = False AndAlso Name.Contains("合計") = False Then
                    ホーム.Sql.CommandText = ""
                    ホーム.Sql.Parameters.Clear()
                    ホーム.Sql.Parameters.Add(New SqlParameter("@cstclsscode", SqlDbType.SmallInt)).Value = 2
                    If IsDBNull(DataRow.Item(1)) = False Then
                        Dim Category As String = DataRow.Item(1)
                        Category = Category.Replace(vbCrLf, " ")
                        Category = Category.Replace(vbLf, " ")
                        ホーム.Sql.Parameters.Add(New SqlParameter("@cstmstr_category", SqlDbType.NVarChar)).Value = Category
                    Else
                        ホーム.Sql.Parameters.Add(New SqlParameter("@cstmstr_category", SqlDbType.NVarChar)).Value = ""
                    End If
                    ホーム.Sql.Parameters.Add(New SqlParameter("@cstmstr_code", SqlDbType.SmallInt)).Value = DataRow.Item(2)
                    Name = Name.Replace(vbCrLf, " ")
                    Name = Name.Replace(vbLf, " ")
                    ホーム.Sql.Parameters.Add(New SqlParameter("@name", SqlDbType.NVarChar)).Value = Name
                    If IsDBNull(DataRow.Item(4)) = False Then
                        Dim Spec As String = DataRow.Item(4)
                        Spec = Spec.Replace(vbCrLf, " ")
                        Spec = Spec.Replace(vbLf, " ")
                        ホーム.Sql.Parameters.Add(New SqlParameter("@spec", SqlDbType.NVarChar)).Value = Spec
                    Else
                        ホーム.Sql.Parameters.Add(New SqlParameter("@spec", SqlDbType.NVarChar)).Value = ""

                    End If
                    ホーム.Sql.Parameters.Add(New SqlParameter("@unit", SqlDbType.NVarChar)).Value = DataRow.Item(5)
                    If IsNumeric(DataRow.Item(6)) = True Then
                        ホーム.Sql.Parameters.Add(New SqlParameter("@costea", SqlDbType.Money)).Value = DataRow.Item(6)
                    Else
                        ホーム.Sql.Parameters.Add(New SqlParameter("@costea", SqlDbType.Money)).Value = 0
                    End If
                    ホーム.Sql.Parameters.Add(New SqlParameter("@change_code", SqlDbType.SmallInt)).Value = 0
                    ホーム.Sql.Parameters.Add(New SqlParameter("@cstmstr_seq", SqlDbType.SmallInt)).Value = RowLoop + 1

                    ホーム.Sql.CommandText = "INSERT INTO cost_masters (cstclss_code,cstmstr_category,cstmstr_code,cstmstr_name,cstmstr_spec
                                                                   ,cstmstr_unit,cstmstr_costea,changecode,cstmstr_seq) 
                                                  VALUES (@cstclsscode,@cstmstr_category,@cstmstr_code,@name,@spec,@unit,@costea,@change_code,@cstmstr_seq)"

                    ホーム.Sql.ExecuteNonQuery()

                End If
            End If
        Next

        ホーム.Transaction.Commit()

        MsgBox("インポート完了", MsgBoxStyle.OkOnly, "材料表インポート")

        Return ImportMaterial
    End Function
End Class
