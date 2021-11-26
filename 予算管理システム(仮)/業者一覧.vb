Imports System.Data.SqlClient
Imports C1.Win.C1Command
Imports C1.Win.C1FlexGrid
Imports System.Windows.Forms.Form
Public Class 業者一覧
    Public ParentFormName As String '親フォーム 予算総括or 協力業者入力
    Public SelectRowIndex As Integer '親フォームで選択された行インデックス

    Private Sub 業者一覧_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: このコード行はデータを '広小路建設.M_TOR' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.M_TORTableAdapter4.Fill(Me.広小路建設.M_TOR)
        'TODO: このコード行はデータを '飛高建設DB.M_TOR' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.M_TORTableAdapter3.Fill(Me.飛高建設DB.M_TOR)
        'TODO: このコード行はデータを '岐阜アイシーDB.M_TOR' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.M_TORTableAdapter2.Fill(Me.岐阜アイシーDB.M_TOR)
        'TODO: このコード行はデータを 'DataSet2.M_TOR' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.M_TORTableAdapter1.Fill(Me.DataSet2.M_TOR)
        'TODO: このコード行はデータを 'DataSet1.M_TOR' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.M_TORTableAdapter.Fill(Me.DataSet1.M_TOR)

        'ホーム.Connection.Close()
        'ホーム.Connection.Dispose()
        'ホーム.Connection.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & ホーム.UserDataPath & "" & ホーム.UserDataName & ";Integrated Security=True"
        'ホーム.Connection.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\217003\source\repos\MinaAjiki\YosankanriSys\予算管理システム(仮)\現場データ.mdf;Integrated Security=True"
        'ホーム.Connection.Open()
        'ホーム.SystemSql.Connection = ホーム.Connection

        ホーム.Sql.CommandText = "SELECT contents FROM controldata where class_code=11"
        Dim Outsrcrcount As String = ホーム.Sql.ExecuteScalar
        If Outsrcrcount = Nothing Then
            VendorList.DataSource = Nothing
            MsgBox("先に予算総括入力を行ってください。", MsgBoxStyle.OkOnly, "エラー")
            Me.Close()
            If Outsrcrcount = "巴産業" Then
                VendorList.DataSource = MTORBindingSource2
            ElseIf Outsrcrcount = "岐阜アイシー" Then
                VendorList.DataSource = MTORBindingSource3
            ElseIf Outsrcrcount = "岐阜北建設" Then
                VendorList.DataSource = Nothing
                MsgBox("業者一覧を開くことができません。", MsgBoxStyle.OkOnly, "エラー")
                Me.Close()
            ElseIf Outsrcrcount = "飛高建設" Then
                VendorList.DataSource = MTORBindingSource4
            ElseIf Outsrcrcount = "広小路建設" Then
                VendorList.DataSource = MTORBindingSource5
            End If
        End If

        VendorList.Cols(1).Width = 100
        VendorList.Cols(2).Width = 270
        VendorList.Cols(3).Width = 0
        VendorList.Cols(4).Width = 170
        VendorList.Cols(5).Width = 130
        VendorList.Cols(6).Width = 100

        VendorList(0, 1) = "取引先コード"
        VendorList(0, 2) = "業者名"
        VendorList(0, 3) = ""
        VendorList(0, 4) = "住所"
        VendorList(0, 5) = ""
        VendorList(0, 6) = "電話番号"
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
        Dim r As Integer = 0
        Dim RowIndex As Integer = 0
        Dim Code As Integer = 0
        Dim Name As String = ""

        If ParentFormName = "予算総括入力" Then
            RowIndex = VendorList.Selection.TopRow

            'セルの値を変数に代入する
            Code = VendorList(RowIndex, 1)
            Name = VendorList(RowIndex, 2)

            '予算総括入力に値を代入する
            予算総括入力.OutsoucersList(SelectRowIndex, 3) = Code
            予算総括入力.OutsoucersList(SelectRowIndex, 4) = Name

        Else
            r = 協力業者入力.CoopVendorList.Rows.Count - 1
            RowIndex = VendorList.Selection.TopRow

            'セルの値を変数に代入する
            Code = VendorList(RowIndex, 1)
            Name = VendorList(RowIndex, 2)

            '協力業者入力に値を代入する
            協力業者入力.CoopVendorList(r, 1) = Code
            協力業者入力.CoopVendorList(r, 2) = Name
        End If


        '業者一覧を閉じる
        Me.Close()
        If 協力業者入力.IsDisposed = False Then
            協力業者入力.CoopVendorList.StartEditing(r, 3)
        End If
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