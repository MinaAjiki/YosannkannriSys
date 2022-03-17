Imports System.Data.SqlClient
Imports C1.C1Excel

Public Class Export注文書CSV
    Private Path As String
    Private VendorCode As String
    Public Sub New(ByVal SavePath As String, ByVal VN As Integer)
        Path = SavePath
        VendorCode = 協力業者選択.SelectVendorCode(0)
    End Sub

    Public Function ExportLoad() As String
        'カーソル変更
        Cursor.Current = Cursors.WaitCursor
        進行状況.Show()
        進行状況.Refresh()

        ExportLoad = ""
        ホーム.Sql.Parameters.Clear()

        Dim xlbook As New C1XLBook
        'xlbook.Load(Application.StartupPath & "\勤怠情報テンプレート(横).xlsx")
        xlbook.Load("C:\Users\217003\source\repos\MinaAjiki\YosankanriSys\予算管理システム(仮)\テンプレート.csv")
        Dim EXSheet As XLSheet = xlbook.Sheets(0)

        ホーム.Sql.CommandText = "SELECT outsrcr_id FROM outsourcers WHERE outsrcr_code = " & VendorCode
        Dim VendorID As Integer = ホーム.Sql.ExecuteScalar

        ホーム.Sql.CommandText = "SELECT no FROM purchase_orders WHERE outsrcr_id = " & VendorID
        Dim No As Integer = ホーム.Sql.ExecuteScalar

        ホーム.Sql.CommandText = "SELECT contents FROM controldata WHERE class_code=20"
        Dim Pcode As String = ホーム.Sql.ExecuteScalar

        ホーム.Sql.CommandText = "SELECT * FROM Production_View WHERE outsrc_no = (SELECT MAX(outsrc_no) FROM OutsrcrPlan_View) AND outsrcr_id = " & VendorID
        Dim ProductionReader As SqlDataReader = ホーム.Sql.ExecuteReader
        Dim RowCount As Integer = 0
        While ProductionReader.Read
            EXSheet(RowCount, 0).Value = 1
            EXSheet(RowCount, 1).Value = Pcode
            EXSheet(RowCount, 2).Value = "001"
            EXSheet(RowCount, 3).Value = No
            EXSheet(RowCount, 4).Value = VendorCode
            EXSheet(RowCount, 5).Value = "0"
            EXSheet(RowCount, 6).Value = 8130
            EXSheet(RowCount, 8).Value = ProductionReader.Item("total_amount")
            EXSheet(RowCount, 9).Value = Math.Round(ProductionReader.Item("total_amount")) * 0.1
            EXSheet(RowCount, 10).Value = 50
            EXSheet(RowCount, 11).Value = 1
            EXSheet(RowCount, 12).Value = 10
            EXSheet(RowCount, 15).Value = Today.ToString("yyyy/mm/dd")
            EXSheet(RowCount, 16).Value = 999999

            RowCount += 1
        End While
        ProductionReader.Close()

        進行状況.Close()

        'Excel保存
        xlbook.Save(Path)
        Cursor.Current = Cursors.Default

        Return ExportLoad
    End Function
End Class
