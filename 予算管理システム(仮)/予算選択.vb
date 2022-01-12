Imports System.Data.SqlClient
Imports System.Deployment.Application
Imports System.IO.DirectoryInfo
Imports System.ComponentModel
Imports System.Deployment.Application.ApplicationDeployment
Imports System.Windows.Forms.Form
Public Class 予算選択
    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        'Try
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
            ホーム.Transaction = ホーム.Connection.BeginTransaction

            ホーム.Sql.Transaction = ホーム.Transaction

            ホーム.Sql.CommandText = "SELECT MAX(budget_no) FROM budget_summary"
                Dim MaxNo As Integer = ホーム.Sql.ExecuteScalar

                ホーム.Sql.CommandText = "SELECT * INTO #tmp_item FROM budget_summary WHERE budget_no=" & MaxNo
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = "UPDATE #tmp_item SET budget_no =" & MaxNo + 1
                ホーム.Sql.ExecuteNonQuery()

                ホーム.Sql.CommandText = "INSERT INTO budget_summary SELECT * FROM #tmp_item"
                ホーム.Sql.ExecuteNonQuery()

            ホーム.Sql.CommandText = "SELECT budget_no,cstclss_code,prjctcst_no,prjctcst_name,prjctcst_spec,prjctcst_unit,prjctcst_quanity,
                                        prjctcst_costea,prjctcst_laborea,prjctcst_materialea,prjctcst_machineea,prjctcst_subcntrctea,prjctcst_expenseea 
                                        INTO #projectcost_item FROM project_costs WHERE budget_no=" & MaxNo
            ホーム.Sql.ExecuteNonQuery()

            ホーム.Sql.CommandText = "SELECT prjctcst_id,prjctcst_no INTO #old_item FROM project_costs WHERE budget_no=" & MaxNo
            ホーム.Sql.ExecuteNonQuery()

            ホーム.Sql.CommandText = "UPDATE #projectcost_item SET budget_no =" & MaxNo + 1
                ホーム.Sql.ExecuteNonQuery()

            ホーム.Sql.CommandText = "CREATE TABLE #OutputTbl (new_id INT,no INT,classcode INT)"
            ホーム.Sql.ExecuteNonQuery()

            ホーム.Sql.CommandText = "INSERT INTO project_costs OUTPUT inserted.prjctcst_id,inserted.prjctcst_no INTO #OutputTbl(new_id,no,classcode) SELECT * FROM #projectcost_item"
            ホーム.Sql.ExecuteNonQuery()


            'ホーム.Sql.CommandText = "UPDATE #OutputTbl SET #OutputTbl.old_id = ( SELECT prjctcst_id FROM #old_item WHERE #OutputTbl.no=#old_item.prjctcst_no)"
            'ホーム.Sql.ExecuteNonQuery()

            Dim ProcessCommand As New SqlCommand
            Dim ProcessConnection As New SqlConnection
            ProcessConnection.ConnectionString = ホーム.Connection.ConnectionString
            ProcessConnection.Open()
            ProcessCommand.Connection = ProcessConnection

            ホーム.Sql.CommandText = "SELECT * FROM #OutputTbl"
            Dim OldIDSelect As SqlDataReader = ホーム.Sql.ExecuteReader
            While OldIDSelect.Read

                'ProcessCommand.CommandText = "SELECT prjctcst_id FROM project_costs WHERE budget_no=" & MaxNo & " AND prjctcst_no=" & OldIDSelect.Item("no")
                'Dim OldID As Integer = ProcessCommand.ExecuteScalar

                'ProcessCommand.CommandText = "SELECT * INTO #prjctcst_bd FROM project_cost_breakdowns WHERE prjctcst_id=" & PrjctCstUpdt.Item("prjctcst_id")
                'ProcessCommand.ExecuteNonQuery()

                'ProcessCommand.CommandText = "UPDATE #prjctcst_bd SET prjctcst_id=" & PrjctCstUpdt.Item("new_id")
                ProcessCommand.ExecuteNonQuery()

                ProcessCommand.CommandText = "INSERT INTO project_cost_breakdowns SELECT * FROM #prjctcst_bd"
                ProcessCommand.ExecuteNonQuery()

            End While
            OldIDSelect.Close()

            ホーム.Sql.CommandText = "SELECT * FROM #OutputTbl"
            Dim PrjctCstUpdt As SqlDataReader = ホーム.Sql.ExecuteReader
                While PrjctCstUpdt.Read



            End While
                PrjctCstUpdt.Close()


            ホーム.Transaction.Commit()



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

        'Catch ex As Exception
        '    ホーム.ErrorMessage = ex.Message
        '    ホーム.StackTrace = ex.StackTrace
        '    エラー.Show()
        '    Exit Sub
        'End Try
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