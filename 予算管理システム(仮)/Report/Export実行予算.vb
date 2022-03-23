Imports System.Data.SqlClient
Imports C1.Win.FlexReport
Imports Microsoft.VisualBasic.FileIO
Imports System.Data.OleDb
Imports C1.C1Excel
Public Class Export実行予算
    Private SavePath As String
    Public Sub New(ByVal Path As String)
        SavePath = Path
    End Sub
    Public Function ReportLoad() As String

		ReportLoad = ""


        Cursor.Current = Cursors.WaitCursor


        Dim CSVSheet As XLSheet = ホーム.DataBook.Sheets(0)


        ホーム.Sql.CommandText = "SELECT contents FROM controldata WHERE class_code=20"
        Dim ProjectCode As String = ホーム.Sql.ExecuteScalar

        Dim DataCount As Integer = 0

        ホーム.Sql.CommandText = "SELECT s_wrktyp_code,sbjct_code,SUM(sbjct_amount) AS amount FROM subject_details_csv WHERE budget_no=" & ホーム.BudgetNo & " AND sbjct_code IS NOT NULL 
                                GROUP BY sbjct_code,s_wrktyp_code ORDER BY sbjct_code,s_wrktyp_code ASC"
        Dim DetailReader As SqlDataReader = ホーム.Sql.ExecuteReader
        While DetailReader.Read

            CSVSheet(DataCount, 0).Value = 1
            CSVSheet(DataCount, 1).Value = ProjectCode
            CSVSheet(DataCount, 2).Value = 1
            CSVSheet(DataCount, 3).Value = DataCount + 1
            CSVSheet(DataCount, 4).Value = DetailReader.Item("sbjct_code")
            CSVSheet(DataCount, 5).Value = DetailReader.Item("s_wrktyp_code")
            CSVSheet(DataCount, 6).Value = DetailReader.Item("amount")
            CSVSheet(DataCount, 7).Value = Today.ToString("yyyy/MM/dd")
            Dim UserName As String = My.User.Name
            UserName = UserName.Remove(0, 7)
            CSVSheet(DataCount, 8).Value = UserName

            DataCount += 1
        End While
        DetailReader.Close()

        CSVSheet.SaveCsv(SavePath)
        ホーム.DataBook.Clear()

        MsgBox("ファイルを出力しました。" & vbCrLf & SavePath, MsgBoxStyle.OkOnly, "実行予算CSV")

        Return ReportLoad
	End Function
End Class
