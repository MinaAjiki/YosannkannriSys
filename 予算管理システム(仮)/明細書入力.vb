﻿Imports C1.Win.C1FlexGrid
Public Class 明細書入力

    Private Sub 明細書入力_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'DetailsList.Rows(1).AllowMerging = True
        DetailsList(0, 2) = "削除"
        DetailsList(1, 2) = "削除"
        DetailsList(2, 2) = "削除"
        DetailsList(0, 3) = "順"
        DetailsList(1, 3) = "順"
        DetailsList(2, 3) = "順"
        DetailsList(0, 4) = "名称"
        DetailsList(0, 5) = "名称"
        DetailsList(1, 4) = "規格"
        DetailsList(1, 5) = "規格"
        DetailsList(2, 4) = "摘要"
        DetailsList(2, 5) = "単位"
        DetailsList(1, 6) = "単価"
        DetailsList(2, 6) = "金額"

        OutsoucerList(0, 2) = "8256950"
        OutsoucerList(1, 2) = "(株)岐阜造園"
        OutsoucerList(0, 3) = "8197780"
        OutsoucerList(1, 3) = "(株)川田電機工務店"
        OutsoucerList(0, 4) = "8876310"
        OutsoucerList(1, 4) = "岐阜北建設(株)"
        OutsoucerList(0, 5) = "8772020"
        OutsoucerList(1, 5) = "(株)丸徳鉄工"
        OutsoucerList(0, 6) = "8330210"
        OutsoucerList(1, 6) = "(有)宏春工業"

        DetailsList.MergedRanges.Add(0, 2, 2, 2)
        DetailsList.MergedRanges.Add(0, 3, 2, 3)
        DetailsList.MergedRanges.Add(0, 4, 0, 5)
        DetailsList.MergedRanges.Add(1, 4, 1, 5)

        CategoryList.MergedRanges.Add(0, 2, 2, 2)
        CategoryList.MergedRanges.Add(0, 3, 2, 3)
        CategoryList.MergedRanges.Add(0, 4, 2, 4)
        CategoryList.MergedRanges.Add(0, 5, 2, 5)
        CategoryList.MergedRanges.Add(0, 6, 2, 6)

        OutsoucerList.MergedRanges.Add(1, 2, 2, 2)
        OutsoucerList.MergedRanges.Add(1, 3, 2, 3)
        OutsoucerList.MergedRanges.Add(1, 4, 2, 4)
        OutsoucerList.MergedRanges.Add(1, 5, 2, 5)
        OutsoucerList.MergedRanges.Add(1, 6, 2, 6)
        OutsoucerList.Visible = False

        DetailsList.Rows(0).Height = 17
        DetailsList.Rows(1).Height = 17
        DetailsList.Rows(2).Height = 17
        CategoryList.Rows(0).Height = 17
        CategoryList.Rows(1).Height = 17
        CategoryList.Rows(2).Height = 17
        OutsoucerList.Rows(0).Height = 17
        OutsoucerList.Rows(1).Height = 17
        OutsoucerList.Rows(2).Height = 17

        CategoryTotalList.Rows(0).Height = 20
        OutsoucerTotalList.Rows(0).Height = 20


        Category.Checked = True

        Me.Anchor = AnchorStyles.Top
        Me.Anchor = AnchorStyles.Left
        Me.Anchor = AnchorStyles.Bottom

    End Sub

    Private Sub Cancel_MouseDown(sender As Object, e As MouseEventArgs) Handles Cancel.MouseDown
        Cancel.ImageIndex = 8
    End Sub

    Private Sub Cancel_MouseEnter(sender As Object, e As EventArgs) Handles Cancel.MouseEnter
        Cancel.Cursor = Cursors.Hand
        Cancel.ImageIndex = 7
    End Sub

    Private Sub Cancel_MouseLeave(sender As Object, e As EventArgs) Handles Cancel.MouseLeave
        Cancel.ImageIndex = 6
    End Sub

    Private Sub Cancel_MouseUp(sender As Object, e As MouseEventArgs) Handles Cancel.MouseUp
        Cancel.ImageIndex = 6
    End Sub

    Private Sub Entry_MouseUp(sender As Object, e As MouseEventArgs) Handles Entry.MouseUp
        Entry.ImageIndex = 3
    End Sub
    Private Sub Entry_MouseDown(sender As Object, e As MouseEventArgs) Handles Entry.MouseDown
        Entry.ImageIndex = 5
    End Sub

    Private Sub Entry_MouseEnter(sender As Object, e As EventArgs) Handles Entry.MouseEnter
        Entry.Cursor = Cursors.Hand
        Entry.ImageIndex = 4
    End Sub

    Private Sub Entry_MouseLeave(sender As Object, e As EventArgs) Handles Entry.MouseLeave
        Entry.ImageIndex = 3
    End Sub


    Private Sub Outsoucing_CheckedChanged(sender As Object, e As EventArgs) Handles Outsoucing.CheckedChanged
        If Outsoucing.Checked = True Then
            CategoryList.Visible = False
            CategoryTotalList.Visible = False
            OutsoucerList.Visible = True
            OutsoucerTotalList.Visible = True
        End If
    End Sub

    Private Sub Category_CheckedChanged(sender As Object, e As EventArgs) Handles Category.CheckedChanged
        If Category.Checked = True Then
            OutsoucerList.Visible = False
            OutsoucerTotalList.Visible = False
            CategoryList.Visible = True
            CategoryTotalList.Visible = True
        End If
    End Sub

    Private Sub CostCreation_MouseDown(sender As Object, e As MouseEventArgs) Handles CostCreation.MouseDown
        CostCreation.ImageIndex = 11
    End Sub

    Private Sub CostCreation_MouseEnter(sender As Object, e As EventArgs) Handles CostCreation.MouseEnter
        CostCreation.Cursor = Cursors.Hand
        CostCreation.ImageIndex = 10
    End Sub

    Private Sub CostCreation_MouseLeave(sender As Object, e As EventArgs) Handles CostCreation.MouseLeave
        CostCreation.ImageIndex = 9
    End Sub

    Private Sub CostCreation_MouseUp(sender As Object, e As MouseEventArgs) Handles CostCreation.MouseUp
        CostCreation.ImageIndex = 9
    End Sub
    Private Sub CostModify_MouseDown(sender As Object, e As MouseEventArgs) Handles CostModify.MouseDown
        CostModify.ImageIndex = 14
    End Sub

    Private Sub CostModify_MouseEnter(sender As Object, e As EventArgs) Handles CostModify.MouseEnter
        CostModify.Cursor = Cursors.Hand
        CostModify.ImageIndex = 13
    End Sub

    Private Sub CostModify_MouseLeave(sender As Object, e As EventArgs) Handles CostModify.MouseLeave
        CostModify.ImageIndex = 12
    End Sub

    Private Sub CostModify_MouseUp(sender As Object, e As MouseEventArgs) Handles CostModify.MouseUp
        CostModify.ImageIndex = 12
    End Sub
    Private Sub CostCopy_MouseDown(sender As Object, e As MouseEventArgs) Handles CostCopy.MouseDown
        CostCopy.ImageIndex = 17
    End Sub

    Private Sub CostCopy_MouseEnter(sender As Object, e As EventArgs) Handles CostCopy.MouseEnter
        CostCopy.Cursor = Cursors.Hand
        CostCopy.ImageIndex = 16
    End Sub

    Private Sub CostCopy_MouseLeave(sender As Object, e As EventArgs) Handles CostCopy.MouseLeave
        CostCopy.ImageIndex = 15
    End Sub

    Private Sub CostCopy_MouseUp(sender As Object, e As MouseEventArgs) Handles CostCopy.MouseUp
        CostCopy.ImageIndex = 15
    End Sub

    Private Sub DetailsList_DoubleClick(sender As Object, e As EventArgs) Handles DetailsList.DoubleClick
        Me.Close()
        代価表入力.TopLevel = False
        ホーム.FormPanel.Controls.Add(代価表入力)
        代価表入力.Show()
    End Sub

    Private Sub ContextMenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ContextMenuStrip1.ItemClicked
        項目選択.Show()
    End Sub
End Class