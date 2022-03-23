Imports System.Data.SqlClient
Imports C1.Win.FlexReport
Imports Microsoft.VisualBasic.FileIO
Imports System.Data.OleDb
Imports C1.C1Excel
Public Class Export明細書
    Private SavePath As String
    Public Sub New(ByVal Path As String)
        SavePath = Path
    End Sub
    Public Function ReportLoad() As String

        ReportLoad = ""


        Cursor.Current = Cursors.WaitCursor


        Dim CSVSheet As XLSheet = ホーム.DataBook.Sheets(0)
        CSVSheet(0, 0).Value = "小工種ｺｰﾄﾞ"
        CSVSheet(0, 1).Value = "小工種名"
        CSVSheet(0, 2).Value = "順"
        CSVSheet(0, 3).Value = "名称"
        CSVSheet(0, 4).Value = "規格"
        CSVSheet(0, 5).Value = "単位"
        CSVSheet(0, 6).Value = "数量"
        CSVSheet(0, 7).Value = "単価"
        CSVSheet(0, 8).Value = "金額"
        CSVSheet(0, 9).Value = "摘要"
        CSVSheet(0, 10).Value = "労務費"
        CSVSheet(0, 11).Value = "材料費"
        CSVSheet(0, 12).Value = "機械費"
        CSVSheet(0, 13).Value = "外注費"
        CSVSheet(0, 14).Value = "諸経費"
        CSVSheet(0, 15).Value = "分類ｺｰﾄﾞ"
        CSVSheet(0, 16).Value = "ﾏｽﾀID"


        Dim DataCount As Integer = 1

        ホーム.Sql.CommandText = "SELECT * FROM details_bd WHERE budget_no=" & ホーム.BudgetNo & " ORDER BY s_wrktyp_code,dtl_no ASC"
        Dim DetailReader As SqlDataReader = ホーム.Sql.ExecuteReader
        While DetailReader.Read

            CSVSheet(DataCount, 0).Value = DetailReader.Item("s_wrktyp_code")
            CSVSheet(DataCount, 1).Value = DetailReader.Item("s_wrktyp_name")
            CSVSheet(DataCount, 2).Value = DetailReader.Item("dtl_no")
            CSVSheet(DataCount, 3).Value = DetailReader.Item("dtl_name")
            CSVSheet(DataCount, 4).Value = DetailReader.Item("dtl_spec")
            CSVSheet(DataCount, 5).Value = DetailReader.Item("dtl_unit")
            CSVSheet(DataCount, 6).Value = DetailReader.Item("dtl_quanity")
            CSVSheet(DataCount, 7).Value = DetailReader.Item("dtl_costea")
            CSVSheet(DataCount, 8).Value = DetailReader.Item("dtl_amount")
            CSVSheet(DataCount, 9).Value = DetailReader.Item("dtl_remarks")
            CSVSheet(DataCount, 10).Value = DetailReader.Item("dtl_labor")
            CSVSheet(DataCount, 11).Value = DetailReader.Item("dtl_material")
            CSVSheet(DataCount, 12).Value = DetailReader.Item("dtl_machine")
            CSVSheet(DataCount, 13).Value = DetailReader.Item("dtl_subcntrct")
            CSVSheet(DataCount, 14).Value = DetailReader.Item("dtl_expens")
            CSVSheet(DataCount, 15).Value = DetailReader.Item("cstclss_code")
            CSVSheet(DataCount, 16).Value = DetailReader.Item("cstmstr_id")

            DataCount += 1
        End While
        DetailReader.Close()

        ホーム.DataBook.Save(SavePath)
        ホーム.DataBook.Clear()

        MsgBox("ファイルを出力しました。" & vbCrLf & SavePath, MsgBoxStyle.OkOnly, "明細書(Excel)")

        Return ReportLoad
    End Function
End Class
