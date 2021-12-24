Imports C1.Win.C1FlexGrid
Imports System.Windows.Forms.Form
Imports C1.Win.C1Command
Imports System.Data.SqlClient
Public Class Reference
    Public Function ReferenceStyle() As String

        代価表入力.TopLevel = True
        代価表入力.TopMost = True
        代価表入力.FormBorderStyle = FormBorderStyle.Sizable
        代価表入力.CostNo.Enabled = False
        代価表入力.CostName.Enabled = False
        代価表入力.CostSpec.Enabled = False
        代価表入力.CostQuanity.Enabled = False
        代価表入力.CostUnit.Enabled = False
        代価表入力.CostUnitPrice.Enabled = False
        代価表入力.CostCostea.Enabled = False
        代価表入力.BreakDownList.AllowEditing = False
        代価表入力.ItemSelect.Visible = False
        代価表入力.CostCreation.Visible = False
        代価表入力.CostModify.Visible = False
        代価表入力.CostCopy.Visible = False
        代価表入力.Reference.Visible = False
        代価表入力.Entry.Visible = False
        代価表入力.BreakDownList.ContextMenuStrip.Visible = False
        代価表入力.Show()
        代価表入力.TopMost = False

        ReferenceStyle = ""

        Return ReferenceStyle
    End Function

End Class