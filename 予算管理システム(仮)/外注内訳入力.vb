Imports C1.Win.C1FlexGrid
Public Class 外注内訳入力
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

    Private Sub 外注内訳入力_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'グリッドの行・列で、同じ内容の隣接するセルを結合するかどうかを設定する
        Grid.Rows(0).AllowMerging = True
        Grid.Rows(1).AllowMerging = True
        Grid.Rows(2).AllowMerging = True
        Grid.Rows(4).AllowMerging = True
        Grid.Rows(0).AllowMerging = True
        Grid.Cols(0).AllowMerging = True
        Grid.Cols(1).AllowMerging = True
        Grid.Cols(2).AllowMerging = True
        Grid.Cols(3).AllowMerging = True

        'グリッドのセルに値を代入する
        Grid(0, 0) = "工種"
        Grid(0, 1) = "単位"

        'グリッドのセルに値を代入する
        Dim rng As CellRange = Grid.GetCellRange(1, 0, 1, 1)
        rng.Data = "名称"

        rng = Grid.GetCellRange(2, 0, 2, 1)
        rng.Data = "規格"

        Grid(3, 0) = "合計"
        'グリッドの固定行の背景色を設定する
        Grid.Rows(3).StyleFixedNew.BackColor = Color.LightGray
        'グリッドの行の背景色を設定する
        Grid.Rows(3).StyleNew.BackColor = Color.LightGray
        Grid.Rows(3).Format = "#,##0"

        '行と行の間の太線のためのセル　空白を代入する
        rng = Grid.GetCellRange(4, 0, 4, 1)
        rng.Data = " "

        rng = Grid.GetCellRange(0, 2, 2, 2)
        rng.Data = "予算"

        rng = Grid.GetCellRange(0, 3, 2, 3)
        rng.Data = "直営金額"

        '列と列の間の太線のためのセル　空白を代入する
        rng = Grid.GetCellRange(0, 4, 2, 4)
        rng.Data = "  "

    End Sub

    Private Sub C1FlexGrid2_Click(sender As Object, e As EventArgs) Handles Grid.Click

    End Sub
End Class