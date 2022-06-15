Imports C1.Win.C1Command
Imports System.Data.SqlClient
Imports System.Windows.Forms.Form
Public Class 見積書表紙
    Private Sub 見積書表紙_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try


            ホーム.Sql.CommandText = ""
            ホーム.Sql.Parameters.Clear()

            estimator.AutoCompleteCustomSource = ホーム.AutoCmpCllctn
            sales_staff.AutoCompleteCustomSource = ホーム.AutoCmpCllctn

            ホーム.Sql.CommandText = "SELECT Count(*) FROM estimates"
            Dim DataCount As Integer = ホーム.Sql.ExecuteScalar

            If DataCount > 0 Then

                ホーム.Sql.CommandText = "SELECT * FROM estimates"
                Dim EstimateReader As SqlDataReader = ホーム.Sql.ExecuteReader
                While EstimateReader.Read

                    EstmtCode.Value = EstimateReader.Item("estmt_code")
                    EstmtDate.Value = EstimateReader.Item("estmt_date")
                    PrjctName.Value = EstimateReader.Item("estmt_prjct_name")
                    EstmtAmount.Value = EstimateReader.Item("estmt_amount")
                    Discount.Value = EstimateReader.Item("discount")
                    EstmtTax.Value = EstimateReader.Item("estmt_tax")
                    EstmtTaxIn.Value = EstimateReader.Item("estmt_taxin")
                    PrjctAddress.Value = EstimateReader.Item("prjct_address")
                    PymntTerms.Value = EstimateReader.Item("paymentterms")
                    expirationdate.Value = EstimateReader.Item("expirationdate")
                    Destination.Value = EstimateReader.Item("destination")
                    pblshr_cmpnyname.Value = EstimateReader.Item("pblshr_cmpnyname")
                    pblshr_address.Value = EstimateReader.Item("pblshr_address")
                    pblshr_prsdnt.Value = EstimateReader.Item("pblshr_prsdnt")
                    pblshr_tel.Value = EstimateReader.Item("pblshr_tel")
                    pblshr_fax.Value = EstimateReader.Item("pblshr_fax")
                    conditions.Value = EstimateReader.Item("conditions")
                    cndtns_dtls1.Value = EstimateReader.Item("cndtns_dtls1")
                    cndtns_dtls2.Value = EstimateReader.Item("cndtns_dtls2")
                    cndtns_dtls3.Value = EstimateReader.Item("cndtns_dtls3")
                    cndtns_dtls4.Value = EstimateReader.Item("cndtns_dtls4")
                    cndtns_dtls5.Value = EstimateReader.Item("cndtns_dtls5")
                    estimator.Value = EstimateReader.Item("estimator")
                    estmt_department.Value = EstimateReader.Item("estmt_department")
                    sales_staff.Value = EstimateReader.Item("sales_staff")
                    sales_department.Value = EstimateReader.Item("sales_department")
                End While
                EstimateReader.Close()

            Else

                EstmtAmount.Value = 0
                Discount.Value = 0
                EstmtTax.Value = 0
                EstmtTaxIn.Value = 0

                pblshr_cmpnyname.Value = "株式会社　市川工務店"
                pblshr_prsdnt.Value = "代表取締役　小川　健"
                pblshr_address.Value = "〒500-8518　岐阜市鹿島町6丁目27番地"
                pblshr_tel.Value = "058-251-2244"
                pblshr_fax.Value = "058-253-3930"

            End If



        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
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

    Private Sub EstmtAmount_ValueChanged(sender As Object, e As EventArgs) Handles EstmtAmount.ValueChanged

        Try

            If IsDBNull(EstmtAmount.Value) = False Then

                Dim Dscnt As Int64 = 0
                If IsDBNull(Discount.Value) = False Then
                    Dscnt = Discount.Value
                End If

                Dim Amount As Int64 = EstmtAmount.Value - Dscnt
                Dim Tax As Int64 = Math.Floor(Amount * 0.1)
                EstmtTax.Value = Tax
                EstmtTaxIn.Value = Amount + Tax

            End If

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub Discount_ValueChanged(sender As Object, e As EventArgs) Handles Discount.ValueChanged

        Try

            If IsDBNull(EstmtAmount.Value) = False Then

                Dim Dscnt As Int64 = 0
                If IsDBNull(Discount.Value) = False Then
                    Dscnt = Discount.Value
                End If

                Dim Amount As Int64 = EstmtAmount.Value - Dscnt
                Dim Tax As Int64 = Math.Floor(Amount * 0.1)
                EstmtTax.Value = Tax
                EstmtTaxIn.Value = Amount + Tax

            End If

        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub Cancel_Click_1(sender As Object, e As EventArgs) Handles Cancel.Click
        Try
            Dim CancelClick As String = ""

            Dim CancelClickLoad As New CancelClick(Me)
            CancelClick = CancelClickLoad.ModifyCheck
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub Entry_Click(sender As Object, e As EventArgs) Handles Entry.Click

        Try


            Me.ImeMode = ImeMode.On

            Dim ErrorText As String = ""

            For CntrlCnt As Integer = 0 To FormPanel.Controls.Count - 1

                If Not FormPanel.Controls.Item(CntrlCnt).Text <> "" Then
                    If FormPanel.Controls.Item(CntrlCnt).Name = "EstmtCode" Or FormPanel.Controls.Item(CntrlCnt).Name = "EstmtDate" Then

                        FormPanel.Controls.Item(CntrlCnt).BackColor = Color.FromArgb(255, 192, 192)

                        ErrorText = "必須項目が入力されていません。"

                    End If
                Else
                    If FormPanel.Controls.Item(CntrlCnt).Name.Contains("Label") = False Then
                        FormPanel.Controls.Item(CntrlCnt).BackColor = Color.White
                    End If
                End If

            Next


            If ErrorText <> "" Then
                ErrorText = "必須項目が入力されていません。"
                MsgBox(ErrorText, MsgBoxStyle.Exclamation, "入力エラー")
                Exit Sub
            End If

            ホーム.Transaction = ホーム.Connection.BeginTransaction
            ホーム.Sql.Transaction = ホーム.Transaction

            ホーム.Sql.CommandText = ""
            ホーム.Sql.Parameters.Clear()


            ホーム.Sql.CommandText = "SELECT Count(*) FROM estimates"
            Dim DataCount As Integer = ホーム.Sql.ExecuteScalar

            ホーム.Sql.Parameters.Add(New SqlParameter("@estmtcode", SqlDbType.NVarChar)).Value = EstmtCode.Value
            ホーム.Sql.Parameters.Add(New SqlParameter("@estmtdate", SqlDbType.DateTime)).Value = DateTime.Parse(EstmtDate.Value)
            If IsDBNull(PrjctName.Value) = False Then
                ホーム.Sql.Parameters.Add(New SqlParameter("@prjctname", SqlDbType.NVarChar)).Value = PrjctName.Value
            Else
                ホーム.Sql.Parameters.Add(New SqlParameter("@prjctname", SqlDbType.NVarChar)).Value = ""
            End If
            ホーム.Sql.Parameters.Add(New SqlParameter("@amount", SqlDbType.Money)).Value = EstmtAmount.Value
            ホーム.Sql.Parameters.Add(New SqlParameter("@discount", SqlDbType.Money)).Value = Discount.Value
            ホーム.Sql.Parameters.Add(New SqlParameter("@tax", SqlDbType.Money)).Value = EstmtTax.Value
            ホーム.Sql.Parameters.Add(New SqlParameter("@taxin", SqlDbType.Money)).Value = EstmtTaxIn.Value
            If IsDBNull(PrjctAddress.Value) = False Then
                ホーム.Sql.Parameters.Add(New SqlParameter("@prjctaddress", SqlDbType.NVarChar)).Value = PrjctAddress.Value
            Else
                ホーム.Sql.Parameters.Add(New SqlParameter("@prjctaddress", SqlDbType.NVarChar)).Value = ""
            End If
            If IsDBNull(PymntTerms.Value) = False Then
                ホーム.Sql.Parameters.Add(New SqlParameter("@paymentterms", SqlDbType.NVarChar)).Value = PymntTerms.Value
            Else
                ホーム.Sql.Parameters.Add(New SqlParameter("@paymentterms", SqlDbType.NVarChar)).Value = ""
            End If
            If IsDBNull(expirationdate.Value) = False Then
                ホーム.Sql.Parameters.Add(New SqlParameter("@expirationdate", SqlDbType.NVarChar)).Value = expirationdate.Value
            Else
                ホーム.Sql.Parameters.Add(New SqlParameter("@expirationdate", SqlDbType.NVarChar)).Value = ""
            End If
            If IsDBNull(Destination.Value) = False Then
                ホーム.Sql.Parameters.Add(New SqlParameter("@destination", SqlDbType.NVarChar)).Value = Destination.Value
            Else
                ホーム.Sql.Parameters.Add(New SqlParameter("@destination", SqlDbType.NVarChar)).Value = ""
            End If
            If IsDBNull(pblshr_address.Value) = False Then
                ホーム.Sql.Parameters.Add(New SqlParameter("@pblshraddress", SqlDbType.NVarChar)).Value = pblshr_address.Value
            Else
                ホーム.Sql.Parameters.Add(New SqlParameter("@pblshraddress", SqlDbType.NVarChar)).Value = ""
            End If
            If IsDBNull(pblshr_cmpnyname.Value) = False Then
                ホーム.Sql.Parameters.Add(New SqlParameter("@cmpnyname", SqlDbType.NVarChar)).Value = pblshr_cmpnyname.Value
            Else
                ホーム.Sql.Parameters.Add(New SqlParameter("@cmpnyname", SqlDbType.NVarChar)).Value = ""
            End If
            If IsDBNull(pblshr_prsdnt.Value) = False Then
                ホーム.Sql.Parameters.Add(New SqlParameter("@prsdnt", SqlDbType.NVarChar)).Value = pblshr_prsdnt.Value
            Else
                ホーム.Sql.Parameters.Add(New SqlParameter("@prsdnt", SqlDbType.NVarChar)).Value = ""
            End If
            If IsDBNull(pblshr_tel.Value) = False Then
                ホーム.Sql.Parameters.Add(New SqlParameter("@tel", SqlDbType.NVarChar)).Value = pblshr_tel.Value
            Else
                ホーム.Sql.Parameters.Add(New SqlParameter("@tel", SqlDbType.NVarChar)).Value = ""
            End If
            If IsDBNull(pblshr_fax.Value) = False Then
                ホーム.Sql.Parameters.Add(New SqlParameter("@fax", SqlDbType.NVarChar)).Value = pblshr_fax.Value
            Else
                ホーム.Sql.Parameters.Add(New SqlParameter("@fax", SqlDbType.NVarChar)).Value = ""
            End If
            If IsDBNull(estimator.Value) = False Then
                ホーム.Sql.Parameters.Add(New SqlParameter("@estimator", SqlDbType.NVarChar)).Value = estimator.Value
            Else
                ホーム.Sql.Parameters.Add(New SqlParameter("@estimator", SqlDbType.NVarChar)).Value = ""
            End If
            If IsDBNull(estmt_department.Value) = False Then
                ホーム.Sql.Parameters.Add(New SqlParameter("@estmt_department", SqlDbType.NVarChar)).Value = estmt_department.Value
            Else
                ホーム.Sql.Parameters.Add(New SqlParameter("@estmt_department", SqlDbType.NVarChar)).Value = ""
            End If
            If IsDBNull(sales_staff.Value) = False Then
                ホーム.Sql.Parameters.Add(New SqlParameter("@sales_staff", SqlDbType.NVarChar)).Value = sales_staff.Value
            Else
                ホーム.Sql.Parameters.Add(New SqlParameter("@sales_staff", SqlDbType.NVarChar)).Value = ""
            End If
            If IsDBNull(sales_department.Value) = False Then
                ホーム.Sql.Parameters.Add(New SqlParameter("@sales_department", SqlDbType.NVarChar)).Value = sales_department.Value
            Else
                ホーム.Sql.Parameters.Add(New SqlParameter("@sales_department", SqlDbType.NVarChar)).Value = ""
            End If
            If IsDBNull(conditions.Value) = False Then
                ホーム.Sql.Parameters.Add(New SqlParameter("@conditions", SqlDbType.NVarChar)).Value = conditions.Value
            Else
                ホーム.Sql.Parameters.Add(New SqlParameter("@conditions", SqlDbType.NVarChar)).Value = ""
            End If
            If IsDBNull(cndtns_dtls1.Value) = False Then
                ホーム.Sql.Parameters.Add(New SqlParameter("@dtls1", SqlDbType.NVarChar)).Value = cndtns_dtls1.Value
            Else
                ホーム.Sql.Parameters.Add(New SqlParameter("@dtls1", SqlDbType.NVarChar)).Value = ""

            End If
            If IsDBNull(cndtns_dtls2.Value) = False Then
                ホーム.Sql.Parameters.Add(New SqlParameter("@dtls2", SqlDbType.NVarChar)).Value = cndtns_dtls2.Value
            Else
                ホーム.Sql.Parameters.Add(New SqlParameter("@dtls2", SqlDbType.NVarChar)).Value = ""

            End If
            If IsDBNull(cndtns_dtls3.Value) = False Then
                ホーム.Sql.Parameters.Add(New SqlParameter("@dtls3", SqlDbType.NVarChar)).Value = cndtns_dtls3.Value
            Else
                ホーム.Sql.Parameters.Add(New SqlParameter("@dtls3", SqlDbType.NVarChar)).Value = ""

            End If
            If IsDBNull(cndtns_dtls4.Value) = False Then
                ホーム.Sql.Parameters.Add(New SqlParameter("@dtls4", SqlDbType.NVarChar)).Value = cndtns_dtls4.Value
            Else
                ホーム.Sql.Parameters.Add(New SqlParameter("@dtls4", SqlDbType.NVarChar)).Value = ""

            End If
            If IsDBNull(cndtns_dtls5.Value) = False Then
                ホーム.Sql.Parameters.Add(New SqlParameter("@dtls5", SqlDbType.NVarChar)).Value = cndtns_dtls5.Value
            Else
                ホーム.Sql.Parameters.Add(New SqlParameter("@dtls5", SqlDbType.NVarChar)).Value = ""

            End If

            If DataCount = 0 Then
                ホーム.Sql.CommandText = "INSERT INTO estimates (estmt_code,estmt_date,estmt_prjct_name,estmt_amount,estmt_taxin,estmt_tax,prjct_address,paymentterms,expirationdate,destination,
                                        pblshr_address,pblshr_cmpnyname,pblshr_prsdnt,pblshr_tel,pblshr_fax,conditions,estimator,estmt_department,sales_staff,sales_department,cndtns_dtls1,
                                        cndtns_dtls2,cndtns_dtls3,cndtns_dtls4,cndtns_dtls5,discount)
                                        VALUES (@estmtcode,@estmtdate,@prjctname,@amount,@taxin,@tax,@prjctaddress,@paymentterms,@expirationdate,@destination,@pblshraddress,@cmpnyname,@prsdnt,
                                        @tel,@fax,@conditions,@estimator,@estmt_department,@sales_staff,@sales_department,@dtls1,@dtls2,@dtls3,@dtls4,@dtls5,@discount)"
            Else
                ホーム.Sql.CommandText = "UPDATE estimates SET estmt_code=@estmtcode,estmt_date=@estmtdate,estmt_prjct_name=@prjctname,estmt_amount=@amount,estmt_taxin=@taxin,estmt_tax=@tax,
                                          prjct_address=@prjctaddress,paymentterms=@paymentterms,expirationdate=@expirationdate,destination=@destination,pblshr_address=@pblshraddress,pblshr_cmpnyname=@cmpnyname,
                                          pblshr_prsdnt=@prsdnt,pblshr_tel=@tel,pblshr_fax=@fax,estimator=@estimator,estmt_department=@estmt_department,sales_staff=@sales_staff,sales_department=@sales_department,
                                          conditions=@conditions,cndtns_dtls1=@dtls1,cndtns_dtls2=@dtls2,cndtns_dtls3=@dtls3,cndtns_dtls4=@dtls4,cndtns_dtls5=@dtls5,discount=@discount"
            End If
            ホーム.Sql.ExecuteNonQuery()

            ホーム.Transaction.Commit()

            ホーム.Sql.CommandText = ""
            ホーム.Sql.Parameters.Clear()

            MsgBox("登録完了", MsgBoxStyle.OkOnly, "見積書表紙")


        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try

    End Sub

    Private Sub EstmtCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EstmtCode.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub EstmtDate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EstmtDate.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub EstmtAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EstmtAmount.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub Discount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Discount.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub EstmtTax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EstmtTax.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub EstmtTaxIn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EstmtTaxIn.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub Destination_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Destination.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub PrjctName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PrjctName.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub PrjctAddress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PrjctAddress.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub PymntTerms_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PymntTerms.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub conditions_KeyPress(sender As Object, e As KeyPressEventArgs) Handles conditions.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub expirationdate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles expirationdate.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub cndtns_dtls1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cndtns_dtls1.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub cndtns_dtls2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cndtns_dtls2.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub cndtns_dtls3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cndtns_dtls3.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub cndtns_dtls4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cndtns_dtls4.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub cndtns_dtls5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cndtns_dtls5.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub pblshr_cmpnyname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles pblshr_cmpnyname.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub pblshr_prsdnt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles pblshr_prsdnt.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub pblshr_address_KeyPress(sender As Object, e As KeyPressEventArgs) Handles pblshr_address.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub pblshr_tel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles pblshr_tel.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub pblshr_fax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles pblshr_fax.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub estmt_department_KeyPress(sender As Object, e As KeyPressEventArgs) Handles estmt_department.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub sales_department_KeyPress(sender As Object, e As KeyPressEventArgs) Handles sales_department.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub sales_staff_KeyPress(sender As Object, e As KeyPressEventArgs) Handles sales_staff.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

    Private Sub estimator_KeyPress(sender As Object, e As KeyPressEventArgs) Handles estimator.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
                'Enterキーが押された場合、次の入力項目へ
                'フォーカスを移動する()
                SendKeys.Send("{TAB}")
            End If
        Catch ex As Exception
            ホーム.ErrorMessage = ex.Message
            ホーム.StackTrace = ex.StackTrace
            エラー.Show()
            Exit Sub
        End Try
    End Sub

End Class