Imports C1.Win.C1FlexGrid
Imports System.Windows.Forms.Form
Imports C1.Win.C1Command
Imports System.Data.SqlClient
Public Class 作成代価選択
    Private Sub AddLevel_MouseLeave(sender As Object, e As EventArgs) Handles AddLevel.MouseLeave
        AddLevel.ImageIndex = 0
    End Sub

    Private Sub AddLevel_MouseUp(sender As Object, e As MouseEventArgs) Handles AddLevel.MouseUp
        AddLevel.ImageIndex = 0
    End Sub

    Private Sub AddLevel_MouseEnter(sender As Object, e As EventArgs) Handles AddLevel.MouseEnter
        AddLevel.Cursor = Cursors.Hand
        AddLevel.ImageIndex = 1
    End Sub

    Private Sub AddLevel_MouseDown(sender As Object, e As MouseEventArgs) Handles AddLevel.MouseDown
        AddLevel.ImageIndex = 2
    End Sub

    Private Sub 作成代価選択_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ホーム.Sql.Parameters.Clear()
            ホーム.Sql.CommandText = "SELECT * FROM cost_classes WHERE cstclss_code>=15 ORDER BY cstclss_code ASC"
            Dim CostClassReader As SqlDataReader = ホーム.Sql.ExecuteReader
            While CostClassReader.Read
                CostsList.Items.Add(CostClassReader.Item("cstclss_name"))
            End While
            CostClassReader.Close()
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try

    End Sub

    Private Sub AddLevel_Click(sender As Object, e As EventArgs) Handles AddLevel.Click
        Try
            Dim CostList(22) As String
            CostList(0) = "D"
            CostList(1) = "E"
            CostList(2) = "F"
            CostList(3) = "G"
            CostList(4) = "H"
            CostList(5) = "I"
            CostList(6) = "J"
            CostList(7) = "K"
            CostList(8) = "L"
            CostList(9) = "M"
            CostList(10) = "N"
            CostList(11) = "O"
            CostList(12) = "P"
            CostList(13) = "Q"
            CostList(14) = "R"
            CostList(15) = "S"
            CostList(16) = "T"
            CostList(17) = "U"
            CostList(18) = "V"
            CostList(19) = "W"
            CostList(20) = "X"
            CostList(21) = "Y"
            CostList(22) = "Z"



            ホーム.Sql.Parameters.Clear()
            ホーム.Sql.CommandText = "SELECT MAX(cstclss_code) FROM cost_classes"
            Dim MaxCode As Integer = ホーム.Sql.ExecuteScalar

            ホーム.CostClassCode = MaxCode + 1
            ホーム.CostClassName = CostList((MaxCode + 1) - 15)

            For DetailsRowCount As Integer = 0 To 明細書入力.DetailsList.Rows.Count - 1
                If DetailsRowCount < 明細書入力.DetailsList.Rows.Count - 3 AndAlso 明細書入力.DetailsList.Rows(DetailsRowCount + 2).Caption = "▶" Then
                    明細書入力.SelectRow = DetailsRowCount + 2
                    Exit For
                End If
            Next

            If MsgBox("工事代価" & CostList((MaxCode + 1) - 15) & "を作成します。" & vbCrLf & "よろしいですか？", MsgBoxStyle.OkCancel, "代価階層追加") = MsgBoxResult.Ok Then
                Me.Close()
                代価表入力.TopLevel = False
                明細書入力.Visible = False
                ホーム.FormPanel.Controls.Add(代価表入力)
                代価表入力.SelectRow = 明細書入力.SelectRow
                代価表入力.Show()
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try


    End Sub
End Class