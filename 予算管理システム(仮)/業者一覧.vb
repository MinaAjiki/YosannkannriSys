Imports C1.Win.C1Command
Imports C1.Win.C1FlexGrid
Imports System.Windows.Forms.Form
Imports System.Data.SqlClient
Public Class 業者一覧
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs)
        Search.ImageIndex = 0
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs)
        Search.Cursor = Cursors.Hand
        Search.ImageIndex = 1
    End Sub

    Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs)
        Search.ImageIndex = 2
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
        Dim RowIndex As Integer = VendorList.Selection.TopRow

        'セルの値を変数に代入する
        Dim Code As Integer = VendorList(RowIndex, 1)
        Dim Name As String = VendorList(RowIndex, 2)

        '【協力業者選択】の入力項目に値を代入する
        協力業者入力.CoopVendorList(1, 1) = Code
        協力業者入力.CoopVendorList(1, 2) = Name
        '【協力業者選択】の工期(自)にフォーカスを入れる
        協力業者入力.Focus()

        '【業者一覧】を閉じる
        Me.Close()
    End Sub
    Private Sub 業者一覧_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: このコード行はデータを 'DataSet1.M_TOR' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.M_TORTableAdapter.Fill(Me.DataSet1.M_TOR)

        'For i As Integer = VendorList.Rows.Fixed To VendorList.Rows.Count - 1
        For i As Integer = 0 To 10
            VendorList.Rows(i).UserData = "Employee: " & VendorList(i, 2) & " " + VendorList(i, 3)
        Next
    End Sub

    Private Sub VendorList_MouseEnterCell(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs)
        If e.Row >= VendorList.Rows.Fixed Then
            Dim tip As String
            tip = VendorList.Rows(e.Row).UserData.ToString()
            ' Display the tooltip
            ToolTip1.SetToolTip(VendorList, tip)
        End If
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

    Private Sub SearchName_TextChanged(sender As Object, e As EventArgs) Handles SearchName.TextChanged

    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click

    End Sub

    Private Sub VendorList_MouseLeaveCell(sender As Object, e As RowColEventArgs) Handles VendorList.MouseLeaveCell
        'ToolTip1.SetToolTip(VendorList, "")
    End Sub

    Private Sub C1FlexGridSearchPanel1_Load(sender As Object, e As EventArgs) Handles C1FlexGridSearchPanel1.Load
        C1FlexGridSearchPanel1.SetC1FlexGridSearchPanel(VendorList, C1FlexGridSearchPanel1)
    End Sub
End Class