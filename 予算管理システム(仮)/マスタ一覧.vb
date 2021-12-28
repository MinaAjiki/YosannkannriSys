﻿Imports C1.Win.C1FlexGrid
Imports System.Data.SqlClient

Public Class マスタ一覧
    Private Sub マスタ一覧_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If マスタメンテナンス.ClickButton = "Salaries" Then
            TableName.Text = "給与マスタ"
            MasterContentsList.Clear(ClearFlags.Content)
            MasterContentsList(0, 1) = "等級"
            MasterContentsList(0, 2) = "給与(円)"
            MasterContentsList(0, 3) = "日給(円)"
            MasterContentsList(0, 4) = "時給(円)"
            MasterContentsList(0, 5) = "削除"
            MasterContentsList(0, 6) = "変更"
            MasterContentsList.Cols(1).Width = 100
            MasterContentsList.Cols(2).Width = 100
            MasterContentsList.Cols(3).Width = 100
            MasterContentsList.Cols(4).Width = 100

            Dim dt As DataTable
            dt = New DataTable
            dt.Columns.Add("year", GetType(System.Int32))
            Dim year As Int32

            ホーム.SystemSql.CommandText = "SELECT year FROM years ORDER BY year DESC"
            Dim Yearreader As SqlDataReader = ホーム.SystemSql.ExecuteReader
            While Yearreader.Read
                year = Yearreader("year")
                dt.Rows.Add(year)
            End While
            Yearreader.Close()

            SelectYear.TextDetached = True
            SelectYear.ItemsDataSource = dt.DefaultView
            SelectYear.ItemsDisplayMember = "year"
            SelectYear.ItemsValueMember = "year"
            SelectYear.ItemMode = C1.Win.C1Input.ComboItemMode.HtmlPattern
            SelectYear.HtmlPattern = "<table><tr><td width=30>{year}</td></tr></table>"
            SelectYear.SelectedIndex = 0

        ElseIf マスタメンテナンス.ClickButton = "BranchCosts" Then
            TableName.Text = "部門費マスタ"
            MasterContentsList.Clear(ClearFlags.Content)
            MasterContentsList(0, 1) = "部署"
            MasterContentsList(0, 2) = "割合(％)"
            MasterContentsList(0, 5) = "削除"
            MasterContentsList(0, 6) = "変更"
            MasterContentsList.Cols(1).Width = 300
            MasterContentsList.Cols(2).Width = 100
            MasterContentsList.Cols(3).Width = 0
            MasterContentsList.Cols(4).Width = 0

            Dim dt As DataTable
            dt = New DataTable
            dt.Columns.Add("year", GetType(System.Int32))
            Dim year As Int32

            ホーム.SystemSql.CommandText = "SELECT year FROM years ORDER BY year DESC"
            Dim Yearreader As SqlDataReader = ホーム.SystemSql.ExecuteReader
            While Yearreader.Read
                year = Yearreader("year")
                dt.Rows.Add(year)
            End While
            Yearreader.Close()

            SelectYear.TextDetached = True
            SelectYear.ItemsDataSource = dt.DefaultView
            SelectYear.ItemsDisplayMember = "year"
            SelectYear.ItemsValueMember = "year"
            SelectYear.ItemMode = C1.Win.C1Input.ComboItemMode.HtmlPattern
            SelectYear.HtmlPattern = "<table><tr><td width=30>{year}</td></tr></table>"
            SelectYear.SelectedIndex = 0

        ElseIf マスタメンテナンス.ClickButton = "LevyCosts" Then
            TableName.Text = "賦課金マスタ"
            MasterContentsList.Clear(ClearFlags.Content)
            MasterContentsList(0, 1) = "地区"
            MasterContentsList(0, 2) = "賦課率(％)"
            MasterContentsList(0, 5) = "削除"
            MasterContentsList(0, 6) = "変更"
            MasterContentsList.Cols(1).Width = 300
            MasterContentsList.Cols(2).Width = 100
            MasterContentsList.Cols(3).Width = 0
            MasterContentsList.Cols(4).Width = 0

            Dim dt As DataTable
            dt = New DataTable
            dt.Columns.Add("year", GetType(System.Int32))
            Dim year As Int32

            ホーム.SystemSql.CommandText = "SELECT year FROM years ORDER BY year DESC"
            Dim Yearreader As SqlDataReader = ホーム.SystemSql.ExecuteReader
            While Yearreader.Read
                year = Yearreader("year")
                dt.Rows.Add(year)
            End While
            Yearreader.Close()

            SelectYear.TextDetached = True
            SelectYear.ItemsDataSource = dt.DefaultView
            SelectYear.ItemsDisplayMember = "year"
            SelectYear.ItemsValueMember = "year"
            SelectYear.ItemMode = C1.Win.C1Input.ComboItemMode.HtmlPattern
            SelectYear.HtmlPattern = "<table><tr><td width=30>{year}</td></tr></table>"
            SelectYear.SelectedIndex = 0

        ElseIf マスタメンテナンス.ClickButton = "Insurances" Then
            YearLabel.Visible = False
            SelectYear.Visible = False
            TableName.Text = "労災保険マスタ"
            MasterContentsList.Clear(ClearFlags.Content)
            MasterContentsList(0, 1) = "工種"
            MasterContentsList(0, 2) = "労務費率(％)"
            MasterContentsList(0, 3) = "保険率(％)"
            MasterContentsList(0, 4) = "保険料(円)"
            MasterContentsList(0, 5) = "削除"
            MasterContentsList(0, 6) = "変更"
            MasterContentsList.Cols(1).Width = 100
            MasterContentsList.Cols(2).Width = 100
            MasterContentsList.Cols(3).Width = 100
            MasterContentsList.Cols(4).Width = 100

            ホーム.SystemSql.CommandText = "SELECT * FROM industriall_injury_insurances"
            Dim Insurancereader As SqlDataReader = ホーム.SystemSql.ExecuteReader
            Dim datacount As Integer = 1
            While Insurancereader.Read
                Me.MasterContentsList.Rows.Add()
                MasterContentsList(datacount, 1) = Insurancereader.Item("insrnc_type")
                MasterContentsList(datacount, 2) = Insurancereader.Item("labor_rate")
                MasterContentsList(datacount, 3) = Insurancereader.Item("insrnc_rate")
                MasterContentsList(datacount, 4) = Insurancereader.Item("insrnc_cost")
                datacount += 1
            End While
            Insurancereader.Close()
            MasterContentsList.Cols(2).DataType = GetType(Decimal)
            MasterContentsList.Cols(3).DataType = GetType(Decimal)

        ElseIf マスタメンテナンス.ClickButton = "StampTaxes" Then
            YearLabel.Visible = False
            SelectYear.Visible = False
            TableName.Text = "印紙税マスタ"
            MasterContentsList.Clear(ClearFlags.Content)
            MasterContentsList(0, 1) = "請負金額(円)"
            MasterContentsList(0, 2) = "印紙税(円)"
            MasterContentsList(0, 5) = "削除"
            MasterContentsList(0, 6) = "変更"
            MasterContentsList.Cols(1).Width = 250
            MasterContentsList.Cols(2).Width = 150
            MasterContentsList.Cols(3).Width = 0
            MasterContentsList.Cols(4).Width = 0

            ホーム.SystemSql.CommandText = "SELECT * FROM stamp_taxes"
            Dim Stamptaxreader As SqlDataReader = ホーム.SystemSql.ExecuteReader
            Dim datacount As Integer = 1
            While Stamptaxreader.Read
                Me.MasterContentsList.Rows.Add()
                MasterContentsList(datacount, 1) = Stamptaxreader.Item("cntrct_amount")
                MasterContentsList(datacount, 2) = Stamptaxreader.Item("amount")
                datacount += 1
            End While
            Stamptaxreader.Close()
        End If
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

    Private Sub 管理者マスタ一覧_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ホーム.Enabled = True
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

    Private Sub MasterContentsList_AfterEdit(sender As Object, e As RowColEventArgs) Handles MasterContentsList.AfterEdit
        Dim SetImageRow As Integer = e.Row
        MasterContentsList.SetCellImage(SetImageRow, 6, Image.FromFile(Application.StartupPath & "\Edit_source.png"))
    End Sub

    Private Sub SelectYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SelectYear.SelectedIndexChanged
        If マスタメンテナンス.ClickButton = "Salaries" Then
            TableName.Text = "給与マスタ"
            MasterContentsList.Clear(ClearFlags.Content)
            MasterContentsList(0, 1) = "等級"
            MasterContentsList(0, 2) = "給与(円)"
            MasterContentsList(0, 3) = "日給(円)"
            MasterContentsList(0, 4) = "時給(円)"
            MasterContentsList(0, 5) = "削除"
            MasterContentsList(0, 6) = "変更"
            MasterContentsList.Cols(1).Width = 100
            MasterContentsList.Cols(2).Width = 100
            MasterContentsList.Cols(3).Width = 100
            MasterContentsList.Cols(4).Width = 100

            ホーム.SystemSql.CommandText = "SELECT * FROM salaries WHERE year = " & SelectYear.Value & "ORDER BY slry_cost DESC"
            Dim Salaryreader As SqlDataReader = ホーム.SystemSql.ExecuteReader
            Dim datacount As Integer = 1
            While Salaryreader.Read
                Me.MasterContentsList.Rows.Add()
                MasterContentsList(datacount, 1) = Salaryreader.Item("slry_rank")
                Dim slrycost As Int64 = Salaryreader.Item("slry_cost")
                MasterContentsList(datacount, 2) = slrycost
                Dim slrycostd As Int64 = Salaryreader.Item("slry_cost_d")
                MasterContentsList(datacount, 3) = slrycostd
                Dim slrycosth As Int64 = Salaryreader.Item("slry_cost_h")
                MasterContentsList(datacount, 4) = slrycosth
                datacount += 1
            End While
            Salaryreader.Close()

        ElseIf マスタメンテナンス.ClickButton = "BranchCosts" Then
            TableName.Text = "部門費マスタ"
            MasterContentsList.Clear(ClearFlags.Content)
            MasterContentsList(0, 1) = "部署"
            MasterContentsList(0, 2) = "割合(％)"
            MasterContentsList(0, 5) = "削除"
            MasterContentsList(0, 6) = "変更"

            ホーム.SystemSql.CommandText = "SELECT * FROM branch_costs WHERE year = " & SelectYear.Value
            Dim Branchreader As SqlDataReader = ホーム.SystemSql.ExecuteReader
            Dim datacount As Integer = 1
            While Branchreader.Read
                Me.MasterContentsList.Rows.Add()
                MasterContentsList(datacount, 1) = Branchreader.Item("brnch_name")
                MasterContentsList(datacount, 2) = Branchreader.Item("brnchcst_rate")
                datacount += 1
            End While
            Branchreader.Close()

        ElseIf マスタメンテナンス.ClickButton = "LevyCosts" Then
            TableName.Text = "賦課金マスタ"
            MasterContentsList.Clear(ClearFlags.Content)
            MasterContentsList(0, 1) = "地区"
            MasterContentsList(0, 2) = "賦課率(％)"
            MasterContentsList(0, 5) = "削除"
            MasterContentsList(0, 6) = "変更"

            ホーム.SystemSql.CommandText = "SELECT * FROM levy_costs WHERE year = " & SelectYear.Value
            Dim levyreader As SqlDataReader = ホーム.SystemSql.ExecuteReader
            Dim datacount As Integer = 1
            While levyreader.Read
                Me.MasterContentsList.Rows.Add()
                MasterContentsList(datacount, 1) = levyreader.Item("lvycst_area")
                MasterContentsList(datacount, 2) = levyreader.Item("lvycst_rate")
                datacount += 1
            End While
            levyreader.Close()
        End If
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Entry_Click(sender As Object, e As EventArgs) Handles Entry.Click
        Dim RowIndex As Integer = MasterContentsList.Rows.Count - 1
        If マスタメンテナンス.ClickButton = "Salaries" Then
            Dim year As Integer = SelectYear.Value
            For MasterLoop As Integer = 1 To RowIndex - 1
                Dim rank As CellRange = MasterContentsList.GetCellRange(MasterLoop, 1)
                Dim cost As CellRange = MasterContentsList.GetCellRange(MasterLoop, 2)
                Dim costd As CellRange = MasterContentsList.GetCellRange(MasterLoop, 3)
                Dim costh As CellRange = MasterContentsList.GetCellRange(MasterLoop, 4)
                Dim DelF As CellRange = MasterContentsList.GetCellRange(MasterLoop, 5)
                If RowIndex <= 0 Then
                    Me.Close()
                    MsgBox("登録完了", MsgBoxStyle.OkOnly, "マスタ登録")
                    Exit Sub
                End If

                If DelF.Data = True Then
                    If MsgBox("" & MasterContentsList(MasterLoop, 1) & "が削除されます。", MsgBoxStyle.OkCancel, "確認") = MsgBoxResult.Cancel Then
                        Exit Sub
                    End If

                    If rank.Data <> Nothing Then
                        ホーム.SystemSql.Parameters.Clear()
                        ホーム.SystemSql.CommandText = "DELETE FROM salaries WHERE slry_rank = '" & rank.Data & "' AND year =" & year
                        ホーム.SystemSql.ExecuteNonQuery()
                        MasterContentsList.Rows.Remove(MasterLoop)
                        MasterLoop -= 1
                        RowIndex -= 1
                        Continue For
                    Else
                        MasterContentsList.Rows.Remove(MasterLoop)
                        MasterLoop -= 1
                        RowIndex -= 1
                        Continue For
                    End If
                End If

                If rank.Data = Nothing Then
                    MasterContentsList.Rows.Remove(MasterLoop)
                    MasterLoop -= 1
                    RowIndex -= 1
                    Continue For
                End If

                If rank.Data <> Nothing Then
                    ホーム.SystemSql.Parameters.Clear()
                    ホーム.SystemSql.CommandText = "SELECT COUNT(slry_rank) FROM salaries WHERE slry_rank = '" & rank.Data & "' And year =" & year
                    Dim rankCount As Integer = ホーム.SystemSql.ExecuteScalar
                    If rankCount = 0 Then
                        ホーム.SystemSql.CommandText = ""
                        ホーム.SystemSql.Parameters.Clear()
                        ホーム.SystemSql.CommandText = "INSERT INTO salaries (slry_rank,slry_cost,slry_cost_d,slry_cost_h,year) VALUES (@slry_rank,@slry_cost,@slry_cost_d,@slry_cost_h,@year)"
                    Else
                        ホーム.SystemSql.CommandText = ""
                        ホーム.SystemSql.Parameters.Clear()
                        ホーム.SystemSql.CommandText = "UPDATE salaries SET slry_cost=@slry_cost,slry_cost_d=@slry_cost_d,slry_cost_h=@slry_cost_h,year=@year where slry_rank=@slry_rank"
                    End If
                    ホーム.SystemSql.Parameters.Add(New SqlParameter("@slry_rank", SqlDbType.NVarChar))
                    ホーム.SystemSql.Parameters.Add(New SqlParameter("@slry_cost", SqlDbType.Money))
                    ホーム.SystemSql.Parameters.Add(New SqlParameter("@slry_cost_d", SqlDbType.Money))
                    ホーム.SystemSql.Parameters.Add(New SqlParameter("@slry_cost_h", SqlDbType.Money))
                    ホーム.SystemSql.Parameters.Add(New SqlParameter("@year", SqlDbType.SmallInt))
                    ホーム.SystemSql.Parameters("@slry_rank").Value = rank.Data
                    ホーム.SystemSql.Parameters("@slry_cost").Value = cost.Data
                    ホーム.SystemSql.Parameters("@slry_cost_d").Value = costd.Data
                    ホーム.SystemSql.Parameters("@slry_cost_h").Value = costh.Data
                    ホーム.SystemSql.Parameters("@year").Value = year
                    ホーム.SystemSql.ExecuteNonQuery()
                End If
            Next

            Me.Close()
            MsgBox("登録完了", MsgBoxStyle.OkOnly, "マスタ登録")

        ElseIf マスタメンテナンス.ClickButton = "BranchCosts" Then
            Dim year As Integer = SelectYear.Value
            For MasterLoop As Integer = 1 To RowIndex - 1
                Dim name As CellRange = MasterContentsList.GetCellRange(MasterLoop, 1)
                Dim rate As CellRange = MasterContentsList.GetCellRange(MasterLoop, 2)
                Dim DelF As CellRange = MasterContentsList.GetCellRange(MasterLoop, 5)
                If RowIndex <= 0 Then
                    Me.Close()
                    MsgBox("登録完了", MsgBoxStyle.OkOnly, "マスタ登録")
                    Exit Sub
                End If

                If DelF.Data = True Then
                    If MsgBox("" & MasterContentsList(MasterLoop, 1) & "が削除されます。", MsgBoxStyle.OkCancel, "確認") = MsgBoxResult.Cancel Then
                        Exit Sub
                    End If

                    If name.Data <> Nothing Then
                        ホーム.SystemSql.Parameters.Clear()
                        ホーム.SystemSql.CommandText = "DELETE FROM branch_costs WHERE brnch_name ='" & name.Data & "' AND year =" & year
                        ホーム.SystemSql.ExecuteNonQuery()
                        MasterContentsList.Rows.Remove(MasterLoop)
                        MasterLoop -= 1
                        RowIndex -= 1
                        Continue For
                    Else
                        MasterContentsList.Rows.Remove(MasterLoop)
                        MasterLoop -= 1
                        RowIndex -= 1
                        Continue For
                    End If
                End If

                If name.Data = Nothing Then
                    MasterContentsList.Rows.Remove(MasterLoop)
                    MasterLoop -= 1
                    RowIndex -= 1
                    Continue For
                End If

                If name.Data <> Nothing Then
                    ホーム.SystemSql.Parameters.Clear()
                    ホーム.SystemSql.CommandText = "SELECT COUNT(brnch_name) FROM branch_costs WHERE brnch_name = '" & name.Data & "' And year =" & year
                    Dim rankCount As Integer = ホーム.SystemSql.ExecuteScalar
                    If rankCount = 0 Then
                        ホーム.SystemSql.CommandText = ""
                        ホーム.SystemSql.Parameters.Clear()
                        ホーム.SystemSql.CommandText = "INSERT INTO branch_costs (brnch_name,brnchcst_rate,year) VALUES (@brnch_name,@brnchcst_rate,@year)"
                    Else
                        ホーム.SystemSql.CommandText = ""
                        ホーム.SystemSql.Parameters.Clear()
                        ホーム.SystemSql.CommandText = "UPDATE branch_costs SET brnchcst_rate=@brnchcst_rate,year=@year where brnch_name=@brnch_name"
                    End If
                    ホーム.SystemSql.Parameters.Add(New SqlParameter("@brnch_name", SqlDbType.NVarChar))
                    ホーム.SystemSql.Parameters.Add(New SqlParameter("@brnchcst_rate", SqlDbType.SmallInt))
                    ホーム.SystemSql.Parameters.Add(New SqlParameter("@year", SqlDbType.SmallInt))
                    ホーム.SystemSql.Parameters("@brnch_name").Value = name.Data
                    ホーム.SystemSql.Parameters("@brnchcst_rate").Value = rate.Data
                    ホーム.SystemSql.Parameters("@year").Value = year
                    ホーム.SystemSql.ExecuteNonQuery()
                End If
            Next
            Me.Close()
            MsgBox("登録完了", MsgBoxStyle.OkOnly, "マスタ登録")

        ElseIf マスタメンテナンス.ClickButton = "LevyCosts" Then
            Dim year As Integer = SelectYear.Value
            For MasterLoop As Integer = 1 To RowIndex - 1
                Dim area As CellRange = MasterContentsList.GetCellRange(MasterLoop, 1)
                Dim rate As CellRange = MasterContentsList.GetCellRange(MasterLoop, 2)
                Dim DelF As CellRange = MasterContentsList.GetCellRange(MasterLoop, 5)
                If RowIndex <= 0 Then
                    Me.Close()
                    MsgBox("登録完了", MsgBoxStyle.OkOnly, "マスタ登録")
                    Exit Sub
                End If
                If DelF.Data = True Then
                    If MsgBox("" & MasterContentsList(MasterLoop, 1) & "が削除されます。", MsgBoxStyle.OkCancel, "確認") = MsgBoxResult.Cancel Then
                        Exit Sub
                    End If

                    If area.Data <> Nothing Then
                        ホーム.SystemSql.Parameters.Clear()
                        ホーム.SystemSql.CommandText = "DELETE FROM levy_costs WHERE lvycst_area = '" & area.Data & "' AND year =" & year
                        ホーム.SystemSql.ExecuteNonQuery()
                        MasterContentsList.Rows.Remove(MasterLoop)
                        MasterLoop -= 1
                        RowIndex -= 1
                        Continue For
                    Else
                        MasterContentsList.Rows.Remove(MasterLoop)
                        MasterLoop -= 1
                        RowIndex -= 1
                        Continue For
                    End If
                End If

                If area.Data = Nothing Then
                    MasterContentsList.Rows.Remove(MasterLoop)
                    MasterLoop -= 1
                    RowIndex -= 1
                    Continue For
                End If

                If area.Data <> Nothing Then
                    ホーム.SystemSql.Parameters.Clear()
                    ホーム.SystemSql.CommandText = "SELECT COUNT(lvycst_area) FROM levy_costs WHERE lvycst_area = '" & area.Data & "' And year =" & year
                    Dim rankCount As Integer = ホーム.SystemSql.ExecuteScalar
                    If rankCount = 0 Then
                        ホーム.SystemSql.CommandText = ""
                        ホーム.SystemSql.Parameters.Clear()
                        ホーム.SystemSql.CommandText = "INSERT INTO levy_costs (lvycst_area,lvycst_rate,year) VALUES (@lvycst_area,@lvycst_rate,@year)"
                    Else
                        ホーム.SystemSql.CommandText = ""
                        ホーム.SystemSql.Parameters.Clear()
                        ホーム.SystemSql.CommandText = "UPDATE levy_costs SET lvycst_rate=@lvycst_rate,year=@year where lvycst_area=@lvycst_area"
                    End If
                    ホーム.SystemSql.Parameters.Add(New SqlParameter("@lvycst_area", SqlDbType.NVarChar))
                    ホーム.SystemSql.Parameters.Add(New SqlParameter("@lvycst_rate", SqlDbType.SmallInt))
                    ホーム.SystemSql.Parameters.Add(New SqlParameter("@year", SqlDbType.SmallInt))
                    ホーム.SystemSql.Parameters("@lvycst_area").Value = area.Data
                    ホーム.SystemSql.Parameters("@lvycst_rate").Value = rate.Data
                    ホーム.SystemSql.Parameters("@year").Value = year
                    ホーム.SystemSql.ExecuteNonQuery()
                End If
            Next
            Me.Close()
            MsgBox("登録完了", MsgBoxStyle.OkOnly, "マスタ登録")

        ElseIf マスタメンテナンス.ClickButton = "Insurances" Then
            For MasterLoop As Integer = 1 To RowIndex - 1
                Dim type As CellRange = MasterContentsList.GetCellRange(MasterLoop, 1)
                Dim Lrate As CellRange = MasterContentsList.GetCellRange(MasterLoop, 2)
                Dim Irate As CellRange = MasterContentsList.GetCellRange(MasterLoop, 3)
                Dim cost As CellRange = MasterContentsList.GetCellRange(MasterLoop, 4)
                Dim DelF As CellRange = MasterContentsList.GetCellRange(MasterLoop, 5)
                If RowIndex <= 0 Then
                    Me.Close()
                    MsgBox("登録完了", MsgBoxStyle.OkOnly, "マスタ登録")
                    Exit Sub
                End If
                If DelF.Data = True Then
                    If MsgBox("" & MasterContentsList(MasterLoop, 1) & "が削除されます。", MsgBoxStyle.OkCancel, "確認") = MsgBoxResult.Cancel Then
                        Exit Sub
                    End If

                    If type.Data <> Nothing Then
                        ホーム.SystemSql.Parameters.Clear()
                        ホーム.SystemSql.CommandText = "DELETE FROM industriall_injury_insurances WHERE insrnc_type = '" & type.Data & "'"
                        ホーム.SystemSql.ExecuteNonQuery()
                        MasterContentsList.Rows.Remove(MasterLoop)
                        MasterLoop -= 1
                        RowIndex -= 1
                        Continue For
                    Else
                        MasterContentsList.Rows.Remove(MasterLoop)
                        MasterLoop -= 1
                        RowIndex -= 1
                        Continue For
                    End If
                End If

                If type.Data = Nothing Then
                    MasterContentsList.Rows.Remove(MasterLoop)
                    MasterLoop -= 1
                    RowIndex -= 1
                    Continue For
                End If

                If type.Data <> Nothing Then
                    ホーム.SystemSql.Parameters.Clear()
                    ホーム.SystemSql.CommandText = "SELECT COUNT(insrnc_type) FROM industriall_injury_insurances WHERE insrnc_type = '" & type.Data & "'"
                    Dim rankCount As Integer = ホーム.SystemSql.ExecuteScalar
                    If rankCount = 0 Then
                        ホーム.SystemSql.CommandText = ""
                        ホーム.SystemSql.Parameters.Clear()
                        ホーム.SystemSql.CommandText = "INSERT INTO industriall_injury_insurances (insrnc_type,labor_rate,insrnc_rate,insrnc_cost) VALUES (@insrnc_type,@labor_rate,@insrnc_rate,@insrnc_cost)"
                    Else
                        ホーム.SystemSql.CommandText = ""
                        ホーム.SystemSql.Parameters.Clear()
                        ホーム.SystemSql.CommandText = "UPDATE industriall_injury_insurances SET labor_rate=@labor_rate,insrnc_rate=@insrnc_rate,insrnc_cost=@insrnc_cost where insrnc_type=@insrnc_type"
                    End If
                    ホーム.SystemSql.Parameters.Add(New SqlParameter("@insrnc_type", SqlDbType.NVarChar))
                    ホーム.SystemSql.Parameters.Add(New SqlParameter("@labor_rate", SqlDbType.SmallInt))
                    ホーム.SystemSql.Parameters.Add(New SqlParameter("@insrnc_rate", SqlDbType.SmallInt))
                    ホーム.SystemSql.Parameters.Add(New SqlParameter("@insrnc_cost", SqlDbType.Money))
                    ホーム.SystemSql.Parameters("@insrnc_type").Value = type.Data
                    ホーム.SystemSql.Parameters("@labor_rate").Value = Lrate.Data
                    ホーム.SystemSql.Parameters("@insrnc_rate").Value = Irate.Data
                    ホーム.SystemSql.Parameters("@insrnc_cost").Value = cost.Data
                    ホーム.SystemSql.ExecuteNonQuery()
                End If
            Next
            Me.Close()
            MsgBox("登録完了", MsgBoxStyle.OkOnly, "マスタ登録")

        ElseIf マスタメンテナンス.ClickButton = "StampTaxes" Then
            For MasterLoop As Integer = 1 To RowIndex - 1
                Dim cntrct As CellRange = MasterContentsList.GetCellRange(MasterLoop, 1)
                Dim amount As CellRange = MasterContentsList.GetCellRange(MasterLoop, 2)
                Dim DelF As CellRange = MasterContentsList.GetCellRange(MasterLoop, 5)
                If RowIndex <= 0 Then
                    Me.Close()
                    MsgBox("登録完了", MsgBoxStyle.OkOnly, "マスタ登録")
                    Exit Sub
                End If
                If DelF.Data = True Then
                    If MsgBox("" & MasterContentsList(MasterLoop, 1) & "が削除されます。", MsgBoxStyle.OkCancel, "確認") = MsgBoxResult.Cancel Then
                        Exit Sub
                    End If

                    If cntrct.Data <> Nothing Then
                        ホーム.SystemSql.Parameters.Clear()
                        ホーム.SystemSql.CommandText = "DELETE FROM stamp_taxes WHERE cntrct_amount = '" & cntrct.Data & "'"
                        ホーム.SystemSql.ExecuteNonQuery()
                        MasterContentsList.Rows.Remove(MasterLoop)
                        MasterLoop -= 1
                        RowIndex -= 1
                        Continue For
                    Else
                        MasterContentsList.Rows.Remove(MasterLoop)
                        MasterLoop -= 1
                        RowIndex -= 1
                        Continue For
                    End If
                End If

                If cntrct.Data = Nothing Then
                    MasterContentsList.Rows.Remove(MasterLoop)
                    MasterLoop -= 1
                    RowIndex -= 1
                    Continue For
                End If

                If cntrct.Data <> Nothing Then
                    ホーム.SystemSql.Parameters.Clear()
                    ホーム.SystemSql.CommandText = "SELECT COUNT(cntrct_amount) FROM stamp_taxes WHERE cntrct_amount = '" & cntrct.Data & "'"
                    Dim rankCount As Integer = ホーム.SystemSql.ExecuteScalar
                    If rankCount = 0 Then
                        ホーム.SystemSql.CommandText = ""
                        ホーム.SystemSql.Parameters.Clear()
                        ホーム.SystemSql.CommandText = "INSERT INTO stamp_taxes (cntrct_amount,amount) VALUES (@cntrct_amount,@amount)"
                    Else
                        ホーム.SystemSql.CommandText = ""
                        ホーム.SystemSql.Parameters.Clear()
                        ホーム.SystemSql.CommandText = "UPDATE stamp_taxes SET amount=@amount where cntrct_amount=@cntrct_amount"
                    End If
                    ホーム.SystemSql.Parameters.Add(New SqlParameter("@cntrct_amount", SqlDbType.NVarChar))
                    ホーム.SystemSql.Parameters.Add(New SqlParameter("@amount", SqlDbType.Money))
                    ホーム.SystemSql.Parameters("@cntrct_amount").Value = cntrct.Data
                    ホーム.SystemSql.Parameters("@amount").Value = amount.Data
                    ホーム.SystemSql.ExecuteNonQuery()
                End If
            Next
            Me.Close()
            MsgBox("登録完了", MsgBoxStyle.OkOnly, "マスタ登録")
        End If
    End Sub
End Class