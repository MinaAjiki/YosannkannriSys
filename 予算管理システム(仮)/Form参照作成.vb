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

    Private Sub FileOpen_Click(sender As Object, e As EventArgs) Handles FileOpen.Click
        OK.Visible = True
        FileContens.Visible = True
    End Sub

End Class