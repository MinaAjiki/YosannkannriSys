Imports C1.Win.C1FlexGrid
Imports System.Data.SqlClient
Public Class 現場経費内訳
    Private Sub Cancel_MouseLeave(sender As Object, e As EventArgs) Handles Cancel.MouseLeave
        Cancel.ImageIndex = 6
    End Sub

    Private Sub Cancel_MouseEnter(sender As Object, e As EventArgs) Handles Cancel.MouseEnter
        Cancel.Cursor = Cursors.Hand
        Cancel.ImageIndex = 7
    End Sub

    Private Sub Cancel_MouseDown(sender As Object, e As MouseEventArgs) Handles Cancel.MouseDown
        Cancel.ImageIndex = 8
    End Sub
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
        現場経費作成.TopLevel = False
        ホーム.FormPanel.Controls.Add(現場経費作成)
        現場経費作成.Show()
    End Sub

    Private Sub 現場経費内訳_Load(sender As Object, e As EventArgs) Handles Me.Load
        CodeLabel.Text = ホーム.ExpnsbdCode
        ExpenceLabel.Text = ホーム.ExpnsbdName
        'If ホーム.ExpnsbdID = 1 Then '設計費
        ホーム.SystemSql.CommandText = "SELECT * FROM expense_breakdowns WHERE stexpns_id = " & ホーム.ExpnsbdID & " ORDER BY expns_bd_no ASC"
        Dim expnsbd As SqlDataReader = ホーム.SystemSql.ExecuteReader
            Dim datacount As Integer = 1
            While expnsbd.Read
                DetailsList.Rows.Add()
                DetailsList(datacount, 0) = expnsbd.Item("expns_bd_id")
                DetailsList(datacount, 1) = ホーム.ExpnsbdCode
                DetailsList(datacount, 2) = expnsbd.Item("expns_bd_name")
                DetailsList(datacount, 3) = expnsbd.Item("expns_bd_spec")
                DetailsList(datacount, 4) = expnsbd.Item("expns_bd_unit")
                datacount += 1
            End While
            expnsbd.Close()

        'ElseIf ホーム.ExpnsbdID = 2 Then '社内試験費
        'ElseIf ホーム.ExpnsbdID = 3 Then '品質管理費
        'ElseIf ホーム.ExpnsbdID = 4 Then '労務管理費
        'ElseIf ホーム.ExpnsbdID = 5 Then '租税公課
        'ElseIf ホーム.ExpnsbdID = 6 Then '地代家賃
        'ElseIf ホーム.ExpnsbdID = 7 Then '保険料
        'ElseIf ホーム.ExpnsbdID = 8 Then '従業員給与手当
        'ElseIf ホーム.ExpnsbdID = 9 Then '福利厚生費
        'ElseIf ホーム.ExpnsbdID = 10 Then '法定福利費
        'ElseIf ホーム.ExpnsbdID = 11 Then '事務用品費
        'ElseIf ホーム.ExpnsbdID = 12 Then '会議費
        'ElseIf ホーム.ExpnsbdID = 13 Then '通信費
        'ElseIf ホーム.ExpnsbdID = 14 Then '旅費交通費
        'ElseIf ホーム.ExpnsbdID = 15 Then '車両費(社用車維持費)
        'ElseIf ホーム.ExpnsbdID = 16 Then '交際費
        'ElseIf ホーム.ExpnsbdID = 17 Then '補償費
        'ElseIf ホーム.ExpnsbdID = 18 Then '賦課金
        'ElseIf ホーム.ExpnsbdID = 19 Then '広告宣伝費
        'ElseIf ホーム.ExpnsbdID = 20 Then '雑費
        'ElseIf ホーム.ExpnsbdID = 21 Then '人件費配賦
        'End If
    End Sub
End Class