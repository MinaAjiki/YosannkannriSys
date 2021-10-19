Public Class 締切日入力
    Private Sub 締切日入力_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        C1FlexGrid1(1, 0) = "1"
        C1FlexGrid1(2, 0) = "1"
        C1FlexGrid1(3, 0) = "1"
        C1FlexGrid1(4, 0) = "1"
        C1FlexGrid1.Rows(0).AllowMerging = True

        C1FlexGrid1.Cols(0).AllowMerging = True
        'C1FlexGrid1.Rows.Fixed = 1
        'C1FlexGrid1.Cols.Fixed = 1
        'C1FlexGrid1.Rows.Count = 3
    End Sub
End Class