Imports C1.Win.C1Command
Imports C1.Win.C1FlexGrid
Imports System.Windows.Forms.Form
Imports System.Data.SqlClient
Public Class 業者一覧
    Private Sub 業者一覧_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: このコード行はデータを 'DataSet1.M_TOR' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.M_TORTableAdapter.Fill(Me.DataSet1.M_TOR)

        'カスタムツールチップ
        'For i As Integer = VendorList.Rows.Fixed To VendorList.Rows.Count - 1
        'VendorList.Rows(i).UserData = "Employee: " & VendorList(i, 2) & " " + VendorList(i, 3)
        'Next
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
        Me.Close()
    End Sub

    Private Sub VendorList_BeforeDoubleClick(sender As Object, e As BeforeMouseDownEventArgs) Handles VendorList.BeforeDoubleClick
        '' デフォルトのダブルクリックを無効にします
        'e.Cancel = True
        '' 編集モードに入ります
        'VendorList.StartEditing()
        '' TextBoxクラスに変換し、SelectAllメソッドを使用して選択します
        'Dim tb As TextBox = CType(VendorList.Editor, TextBox)
        'tb.SelectAll()
    End Sub

    Private Sub VendorList_DoubleClick(sender As Object, e As EventArgs) Handles VendorList.DoubleClick
        '協力業者テーブルのレコード数取得
        'ホーム.SystemSql.CommandText = "SELECT count(outsrcr_code) FROM outsourcers"
        'Dim Outsrcrcount As Integer = ホーム.SystemSql.ExecuteScalar
        Dim r As Integer = 協力業者入力.CoopVendorList.Rows.Count - 1
        Dim RowIndex As Integer = VendorList.Selection.TopRow

        'セルの値を変数に代入する
        Dim Code As Integer = VendorList(RowIndex, 1)
        Dim Name As String = VendorList(RowIndex, 2)

        '協力業者入力に値を代入する
        協力業者入力.CoopVendorList(r, 1) = Code
        協力業者入力.CoopVendorList(r, 2) = Name

        '業者一覧を閉じる
        Me.Close()
        協力業者入力.CoopVendorList.StartEditing(r, 3)
    End Sub

    Private Sub VendorList_MouseEnterCell(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs)
        'カスタムツールチップ
        'If e.Row >= VendorList.Rows.Fixed Then
        '    Dim tip As String
        '    tip = VendorList.Rows(e.Row).UserData.ToString()
        '    ' Display the tooltip
        '    ToolTip1.SetToolTip(VendorList, tip)
        'End If

        'ホーム.Connection.Close()
        'ホーム.Connection.Dispose()
        'ホーム.Connection.ConnectionString = "Data Source=CAP21;Persist Security Info=True;User ID=CAP21_ICK_01;Password=CAP21_ICK_01"
        'ホーム.Connection.Open()
        'ホーム.SystemSql.Connection = ホーム.Connection
        'ホーム.SystemSql.CommandText = "SELECT * FROM M_TOR"
        'Dim datacount As Integer = 1
        'Dim Vendorreader As SqlDataReader = ホーム.SystemSql.ExecuteReader
        'While Vendorreader.Read
        '    VendorList(datacount, 1) = Vendorreader.Item("CODE")
        '    VendorList(datacount, 2) = Vendorreader.Item("NAME")
        '    datacount += 1
        'End While
        'Vendorreader.Close()
    End Sub

    Private Sub SearchName_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub VendorList_MouseLeaveCell(sender As Object, e As RowColEventArgs) Handles VendorList.MouseLeaveCell
        'カスタムツールチップ
        'ToolTip1.SetToolTip(VendorList, "")
    End Sub

    Private Sub C1FlexGridSearchPanel1_Load(sender As Object, e As EventArgs) Handles C1FlexGridSearchPanel1.Load
        C1FlexGridSearchPanel1.SetC1FlexGridSearchPanel(VendorList, C1FlexGridSearchPanel1)
    End Sub
End Class