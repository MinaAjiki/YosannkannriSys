Imports C1.Win.C1Command
Imports System.Data.SqlClient
Imports System.Deployment.Application
Imports System.IO.DirectoryInfo
Imports System.ComponentModel
Imports System.Deployment.Application.ApplicationDeployment
Imports System.Windows.Forms.Form
Public Class 参照作成

    Dim ReferenceConnection As New SqlConnection                              '参照するuser_mdf
    Dim ReferenceSql As New SqlCommand                                        '参照するuser_mdf

    Private Sub Form参照作成_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BudgetNoList.Height = 20
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

    Private Sub FileOpen_Click(sender As Object, e As EventArgs) Handles FileOpen.Click
        FileOpenDialog.ShowDialog()
    End Sub

    Private Sub FileOpenDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles FileOpenDialog.FileOk
        Try
            FileName.Value = FileOpenDialog.FileName

            ReferenceConnection.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & FileOpenDialog.FileName & ";Integrated Security=True"
            ReferenceConnection.Open()
            ReferenceSql.Connection = ReferenceConnection


            ReferenceSql.CommandText = "select max(budget_no) from budget_summary"
            Dim MaxBudgetNo As Integer = ReferenceSql.ExecuteScalar

            BudgetNoList.Items.Add("当初")

            For No As Integer = 1 To MaxBudgetNo
                BudgetNoList.Items.Add("第" & No & "回変更")
            Next


            ReferenceSql.CommandText = "SELECT cstclss_name FROM cost_classes WHERE cstclss_code > 11"
            Dim CstclssReader As SqlDataReader = ReferenceSql.ExecuteReader
            While CstclssReader.Read
                ProjectCostsList.Items.Add(CstclssReader.Item("cstclss_name"))
            End While
            CstclssReader.Close()

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Try
            Cursor.Current = Cursors.WaitCursor

            Dim BudgetNo As Integer = 0
            Dim Year_New As Integer = 0
            Dim Year_Old As Integer = 0

            ホーム.Sql.CommandText = "SELECT contents FROM controldata WHERE class_code=12"
            Year_New = ホーム.Sql.ExecuteScalar

            ReferenceSql.CommandText = "SELECT contents FROM controldata WHERE class_code=12"
            Year_Old = ReferenceSql.ExecuteScalar

            Dim Missingnumber_Details As String = ""
            Dim ReferenceDetailsLoad As New Reference_Details(BudgetNo, Year_New, Year_Old)
            Missingnumber_Details = ReferenceDetailsLoad.Missingnumber_Details



            Cursor.Current = Cursors.Default

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
End Class