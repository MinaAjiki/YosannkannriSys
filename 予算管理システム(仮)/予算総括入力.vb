
Imports C1.Win.C1FlexGrid
Imports System.Data.SqlClient

Public Class 予算総括入力
    Private Sub 予算総括入力_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Director.AutoCompleteCustomSource = ホーム.AutoCmpCllctn
        Manager.AutoCompleteCustomSource = ホーム.AutoCmpCllctn
        Chief.AutoCompleteCustomSource = ホーム.AutoCmpCllctn
        Expert1.AutoCompleteCustomSource = ホーム.AutoCmpCllctn
        Expert2.AutoCompleteCustomSource = ホーム.AutoCmpCllctn
        Expert3.AutoCompleteCustomSource = ホーム.AutoCmpCllctn
        Staff1.AutoCompleteCustomSource = ホーム.AutoCmpCllctn
        Staff2.AutoCompleteCustomSource = ホーム.AutoCmpCllctn
        Staff3.AutoCompleteCustomSource = ホーム.AutoCmpCllctn
        Staff4.AutoCompleteCustomSource = ホーム.AutoCmpCllctn

        OutsoucersList.Cols(0).ShowButtons = ShowButtonsEnum.Always
        OutsoucersList(1, 1) = "8545670"

    End Sub
    Private Sub OutsoucersList_CellButtonClick(sender As Object, e As C1.Win.C1FlexGrid.RowColEventArgs) Handles OutsoucersList.CellButtonClick
        業者一覧.ParentFormName = "予算総括入力"
        業者一覧.SelectRowIndex = e.Row
        業者一覧.Show()
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

    Private Sub Entry_Click(sender As Object, e As EventArgs) Handles Entry.Click

        Dim ErrorText As String = ""

        For CntrlCnt As Integer = 0 To FormPanel.Controls.Count - 1

            If Not FormPanel.Controls.Item(CntrlCnt).Text <> "" Then
                If FormPanel.Controls.Item(CntrlCnt).Name = "Company" Or FormPanel.Controls.Item(CntrlCnt).Name = "ProjectCode" Or
                       FormPanel.Controls.Item(CntrlCnt).Name = "ProjectName" Or FormPanel.Controls.Item(CntrlCnt).Name = "Amount" Or
                       FormPanel.Controls.Item(CntrlCnt).Name = "TermS" Or FormPanel.Controls.Item(CntrlCnt).Name = "TermE" Or
                       FormPanel.Controls.Item(CntrlCnt).Name = "Year" Then

                    FormPanel.Controls.Item(CntrlCnt).BackColor = Color.FromArgb(255, 192, 192)

                    ErrorText = "必須項目が入力されていません。"

                End If
            Else
                FormPanel.Controls.Item(CntrlCnt).BackColor = Color.White
            End If
        Next

        If Not ErrorText <> "" AndAlso TermS.Text >= TermE.Text Then
            TermE.BackColor = Color.FromArgb(255, 192, 192)
            ErrorText += vbCrLf & "工期が適切ではありません。"
        ElseIf Not ErrorText <> "" AndAlso TermS.Text < TermE.Text Then
            TermE.BackColor = Color.White
        End If

        If ErrorText <> "" Then
            MsgBox(ErrorText, MsgBoxStyle.Exclamation, "入力エラー")
            Exit Sub
        End If

        ホーム.Sql.CommandText = ""
        ホーム.Sql.Parameters.Clear()

        Dim ControlData(5, 1) As String
        ControlData(0, 0) = 11
        ControlData(0, 1) = Company.Text
        ControlData(1, 0) = 12
        ControlData(1, 1) = Year.Text
        ControlData(2, 0) = 20
        ControlData(2, 1) = ProjectCode.Text
        ControlData(3, 0) = 21
        ControlData(3, 1) = ProjectName.Text
        ControlData(4, 0) = 22
        ControlData(4, 1) = Contractee.Text
        ControlData(5, 0) = 23
        ControlData(5, 1) = ProjectAddress.Text

        ホーム.Sql.Parameters.Add(New SqlParameter("@classcode", SqlDbType.SmallInt))
        ホーム.Sql.Parameters.Add(New SqlParameter("@contents", SqlDbType.VarChar))

        For ControlDataCount As Integer = 0 To 5
            ホーム.Sql.CommandText = "UPDATE ControlData SET contents=@contents WHERE class_code=@classcode"
            ホーム.Sql.Parameters("@classcode").Value = ControlData(ControlDataCount, 0)
            ホーム.Sql.Parameters("@contents").Value = ControlData(ControlDataCount, 1)
            ホーム.Sql.ExecuteNonQuery()
        Next

        ホーム.Sql.CommandText = ""
        ホーム.Sql.Parameters.Clear()

        ホーム.Sql.CommandText = "SELECT Count(cntrct_no) FROM budget_summary"
        Dim DataCount As Integer = ホーム.Sql.ExecuteScalar

        Dim Item(21) As String

        For ItemCount As Integer = 0 To 21

        Next

        ホーム.Sql.Parameters.Add(New SqlParameter("@cntrctno", SqlDbType.SmallInt)).Value = Integer.Parse(ホーム.ContractNo)
        ホーム.Sql.Parameters.Add(New SqlParameter("@terms", SqlDbType.DateTime)).Value = DateTime.Parse(TermS.Text)
        ホーム.Sql.Parameters.Add(New SqlParameter("@terme", SqlDbType.DateTime)).Value = DateTime.Parse(TermE.Text)
        ホーム.Sql.Parameters.Add(New SqlParameter("@amount", SqlDbType.Money)).Value = Amount.Value
        ホーム.Sql.Parameters.Add(New SqlParameter("@category", SqlDbType.NVarChar)).Value = Category.Text
        'ホーム.Sql.Parameters.Add(New SqlParameter("@cnsdrtndate", SqlDbType.DateTime)).Value = DateTime.Parse("")
        'ホーム.Sql.Parameters.Add(New SqlParameter("@summary", SqlDbType.NVarChar)).Value = Summary.Text
        'ホーム.Sql.Parameters.Add(New SqlParameter("@subcontractrate", SqlDbType.NVarChar)).Value = SubContractRate.Text
        'ホーム.Sql.Parameters.Add(New SqlParameter("@remarks", SqlDbType.NVarChar)).Value = Remarks.Text
        'ホーム.Sql.Parameters.Add(New SqlParameter("@department", SqlDbType.NVarChar)).Value = Department.Text
        'ホーム.Sql.Parameters.Add(New SqlParameter("@director", SqlDbType.NVarChar)).Value = Director.Text
        'ホーム.Sql.Parameters.Add(New SqlParameter("@manager", SqlDbType.NVarChar)).Value = Manager.Text
        'ホーム.Sql.Parameters.Add(New SqlParameter("@chief", SqlDbType.NVarChar)).Value = Chief.Text
        'ホーム.Sql.Parameters.Add(New SqlParameter("@expert1", SqlDbType.NVarChar)).Value = Expert1.Text
        'ホーム.Sql.Parameters.Add(New SqlParameter("@expert2", SqlDbType.NVarChar)).Value = Expert2.Text
        'ホーム.Sql.Parameters.Add(New SqlParameter("@expert3", SqlDbType.NVarChar)).Value = Expert3.Text
        'ホーム.Sql.Parameters.Add(New SqlParameter("@staff1", SqlDbType.NVarChar)).Value = Staff1.Text
        'ホーム.Sql.Parameters.Add(New SqlParameter("@staff2", SqlDbType.NVarChar)).Value = Staff2.Text
        'ホーム.Sql.Parameters.Add(New SqlParameter("@staff3", SqlDbType.NVarChar)).Value = Staff3.Text
        'ホーム.Sql.Parameters.Add(New SqlParameter("@staff4", SqlDbType.NVarChar)).Value = Staff4.Text
        'ホーム.Sql.Parameters.Add(New SqlParameter("@bdgtdprtmnt", SqlDbType.NVarChar)).Value = BdgtDprtmnt.Text
        'ホーム.Sql.Parameters.Add(New SqlParameter("@expenserate", SqlDbType.Decimal)).Value = ExpenseRate.Text

        If DataCount >= 1 Then

            ホーム.Sql.CommandText = "UPDATE budget_summary SET prjct_term_s=@terms,prjct_term_e=@terme,cntrct_amount=@amount,prjct_category=@category 
                                        ,cnsdrtn_date=@cnsdrtndate,prjct_summary=@summary,subcontract_rate=@subcontractrate,remarks=@remarks,department=@department,director=@director
                                        ,manager=@manager,chief=@chief,expert_1=@expert1,expert_2=@expert2,expert_3=@expert3,staff_1=@staff1,staff_2=@staff2
                                        ,staff_3=@staff3,staff_4=@staff4,bdgt_dprtmnt=@bdgtdprtmnt,expense_rate=@expenserate WHERE cntrct_no=@cntrctno"
        Else

            ホーム.Sql.CommandText = "INSERT INTO budget_summary (cntrct_no,prjct_term_s,prjct_term_e,cntrct_amount) 
                                      VALUES (@cntrctno,@terms,@terme,@amount)"

            'ホーム.Sql.CommandText = "INSERT INTO budget_summary (cntrct_no,prjct_term_s,prjct_term_e=,cntrct_amount,prjct_category,cnsdrtn_date,prjct_summary
            '                                                       ,subcontract_rate,remarks,department,director,manager,chief,expert_1,expert_2
            '                                                        ,expert_3,staff_1,staff_2,staff_3,staff_4,bdgt_dprtmnt,expense_rate) 
            '                          VALUES (@cntrctno,@terms,@terme,@amount,@category,@cnsdrtndate,@summary,@subcontractrate,@remarks,@department,
            '                                  @director,@manager,@chief,@expert1,@expert2,@expert3,@staff1,@staff2,@staff3,@staff4,@bdgtdprtmnt,@expenserate)"


        End If

        ホーム.Sql.ExecuteNonQuery()

    End Sub

    Private Sub FormPanel_Click(sender As Object, e As EventArgs) Handles FormPanel.Click

    End Sub
End Class