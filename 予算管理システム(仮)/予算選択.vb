Imports System.Data.SqlClient
Imports System.Deployment.Application
Imports System.IO.DirectoryInfo
Imports System.ComponentModel
Imports System.Deployment.Application.ApplicationDeployment
Imports System.Windows.Forms.Form
Public Class 予算選択
    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Try
            If ホーム.Connection.State = ConnectionState.Open Then
                ホーム.Connection.Close()
            End If

            ホーム.Connection.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & FilePath.Text & ";Integrated Security=True"
            ホーム.Connection.Open()
            ホーム.Sql.Connection = ホーム.Connection

            ホーム.Enabled = True

            If Contract_NoList.SelectedItem = "当初" Then
                ホーム.Text = "予算管理システム(当初)" & FilePath.Text
                ホーム.BudgetNo = 0
            ElseIf Contract_NoList.SelectedItem = "変更予算作成" Then

            Else
                ホーム.Text = "予算管理システム" & "(" & Contract_NoList.SelectedItem & ")" & FilePath.Text
                Dim BudgetNo As String = Contract_NoList.SelectedItem
                BudgetNo = BudgetNo.Replace("第", "")
                BudgetNo = BudgetNo.Replace("回変更", "")
                ホーム.BudgetNo = BudgetNo
            End If

            ホーム.Sql.CommandText = "SELECT Count(budget_no) FROM budget_summary"
            Dim DataCount As Integer = ホーム.Sql.ExecuteScalar

            If DataCount = 0 Then
                ホーム.見積.Enabled = False
                ホーム.外注管理.Enabled = False
            Else
                ホーム.見積.Enabled = True
                ホーム.外注管理.Enabled = True

            End If

            Me.Close()

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub 予算選択_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            If ホーム.UserDataName <> "" Then

                Dim Prjct_Name As String
                Dim Prjct_Code As String
                Dim budget_no As Integer = 0

                ホーム.Sql.CommandText = "select max(budget_no) from budget_summary"
                ホーム.BudgetNo = ホーム.Sql.ExecuteScalar

                ホーム.Sql.CommandText = "SELECT contents FROM controldata WHERE class_code=20"
                Prjct_Code = ホーム.Sql.ExecuteScalar

                ホーム.Sql.CommandText = "SELECT contents FROM controldata WHERE class_code=21"
                Prjct_Name = ホーム.Sql.ExecuteScalar

                Contract_NoList.Items.Add("当初")

                For No As Integer = 1 To budget_no
                    Contract_NoList.Items.Add("第" & No & "回変更")
                Next

                Contract_NoList.Items.Add("変更予算作成")

                If ホーム.BudgetNo = 0 Then
                    Contract_NoList.SelectedItem = "当初"
                Else
                    Contract_NoList.SelectedItem = "第" & ホーム.BudgetNo & "回変更"
                End If

                Project.Value = Prjct_Code & " " & Prjct_Name
                FilePath.Value = ホーム.UserDataPath & ホーム.UserDataName

            Else

                ホーム.Enabled = True
                Me.Close()
            End If

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
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
End Class