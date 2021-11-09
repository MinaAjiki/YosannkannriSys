Imports C1.Win.C1Command
Imports C1.Win.C1FlexGrid
Imports System.Windows.Forms.Form
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
        VendorList(1, 1) = "9999999"
        VendorList(1, 2) = "市川工務店"
    End Sub
End Class