Public Class Form参照作成
    Private Sub Form参照作成_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Contract_NoList.Height = 20
    End Sub

    Private Sub AllCopy_CheckedChanged(sender As Object, e As EventArgs) Handles AllCopy.CheckedChanged

        If AllCopy.Checked = True Then
            CopyItem.Visible = False
        End If

    End Sub

    Private Sub PartCopy_CheckedChanged(sender As Object, e As EventArgs) Handles PartCopy.CheckedChanged

        If PartCopy.Checked = True Then
            CopyItem.Visible = True
        End If

    End Sub

    Private Sub ProjectCosts_CheckedChanged(sender As Object, e As EventArgs) Handles ProjectCosts.CheckedChanged
        If ProjectCosts.Checked = True Then
            ProjectCostsCopyPanel.Visible = True
        Else
            ProjectCostsCopyPanel.Visible = False
            ProjectCostsList.Visible = False
        End If
    End Sub

    Private Sub ProjectCostsAllCopy_CheckedChanged(sender As Object, e As EventArgs) Handles ProjectCostsAllCopy.CheckedChanged
        If ProjectCostsAllCopy.Checked = True Then
            ProjectCostsList.Visible = False
        End If
    End Sub

    Private Sub ProjectCostsPartCopy_CheckedChanged(sender As Object, e As EventArgs) Handles ProjectCostsPartCopy.CheckedChanged
        If ProjectCostsPartCopy.Checked = True Then
            ProjectCostsList.Visible = True
        End If
    End Sub

    Private Sub OK_MouseEnter(sender As Object, e As EventArgs) Handles OK.MouseEnter
        OK.Cursor = Cursors.Hand
        OK.ImageIndex = 1
    End Sub

    Private Sub OK_MouseDown(sender As Object, e As MouseEventArgs) Handles OK.MouseDown
        OK.ImageIndex = 2
    End Sub

    Private Sub OK_MouseLeave(sender As Object, e As EventArgs) Handles OK.MouseLeave
        OK.ImageIndex = 0
    End Sub

    Private Sub OK_MouseUp(sender As Object, e As MouseEventArgs) Handles OK.MouseUp
        OK.ImageIndex = 0
    End Sub

    Private Sub Cancel_MouseEnter(sender As Object, e As EventArgs) Handles Cancel.MouseEnter
        Cancel.Cursor = Cursors.Hand
        Cancel.ImageIndex = 7
    End Sub

    Private Sub Cancel_MouseDown(sender As Object, e As MouseEventArgs) Handles Cancel.MouseDown
        Cancel.ImageIndex = 8
    End Sub

    Private Sub Cancel_MouseLeave(sender As Object, e As EventArgs) Handles Cancel.MouseLeave
        Cancel.ImageIndex = 6
    End Sub

    Private Sub Cancel_MouseUp(sender As Object, e As MouseEventArgs) Handles Cancel.MouseUp
        Cancel.ImageIndex = 6
    End Sub
End Class