Imports System.Data.SqlClient
Imports C1.C1Excel

Public Class Export外注計画
    Private Path As String

    Public Sub New(ByVal SavePath As String)
        Path = SavePath

    End Sub

    Public Function ExportLoad() As String
        'カーソル変更
        Cursor.Current = Cursors.WaitCursor
        進行状況.Show()
        進行状況.Refresh()

        Dim Connection As New SqlConnection
        Dim Sql As New SqlCommand
        Connection.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & ホーム.UserDataPath & ホーム.UserDataName & ";Integrated Security=True"
        Connection.Open()
        Sql.Connection = Connection

        ExportLoad = ""
        ホーム.Sql.Parameters.Clear()

        Dim xlbook As New C1XLBook
        xlbook.Load(Application.StartupPath & "\外注計画テンプレート.xlsx")
        'xlbook.Load("C:\Users\217003\source\repos\MinaAjiki\YosankanriSys\予算管理システム(仮)\外注計画テンプレート.xlsx")
        Dim EXSheet As XLSheet = xlbook.Sheets(0)


        '業者IDリスト作成
        ホーム.Sql.CommandText = "SELECT outsrcr_id FROM outsourcers"
        Dim VendorIDReader As SqlDataReader = ホーム.Sql.ExecuteReader
        Dim VendorIDList As New List(Of Integer)
        While VendorIDReader.Read
            VendorIDList.Add(VendorIDReader.Item("outsrcr_id"))
        End While
        VendorIDReader.Close()

        'ヘッダー作成
        For headerloop As Integer = 0 To VendorIDList.Count - 1
            EXSheet(0, 21 + (headerloop * 3)).Value = "数量" & (headerloop + 1)
            EXSheet(0, 22 + (headerloop * 3)).Value = "単価" & (headerloop + 1)
            EXSheet(0, 23 + (headerloop * 3)).Value = "金額" & (headerloop + 1)
        Next


        '工種数カウント
        ホーム.Sql.CommandText = "SELECT COUNT(s_worktype_code) FROM OutsrcrPlan_View WHERE (outsrc_no IS NULL OR outsrc_no = (SELECT MAX(outsrc_no) FROM OutsrcrPlan_View))"
        Dim SwrktypCount As Integer = ホーム.Sql.ExecuteScalar

        '工種リスト作成
        Dim s_wrktyp_codeList As New List(Of Integer)
        Dim s_wrktyp_nameList As New List(Of String)

        ホーム.Sql.CommandText = "SELECT DISTINCT(dtl_id),outsrc_no,s_worktype_code,dtl_no,s_wrktyp_name,dtl_name,dtl_spec,dtl_unit,dtl_quanity,dtl_costea,dtl_amount FROM OutsrcrPlan_View WHERE (outsrc_no IS NULL OR outsrc_no = (SELECT MAX(outsrc_no) FROM OutsrcrPlan_View)) ORDER BY s_worktype_code,dtl_no ASC"
        Dim SwrktypReader As SqlDataReader = ホーム.Sql.ExecuteReader
        Dim RowCount As Integer = 1
        While SwrktypReader.Read
            Dim DtlID = SwrktypReader.Item("dtl_id")
            Sql.CommandText = "SELECT COUNT(dtl_id) FROM details WHERE budget_no = (SELECT MAX(budget_no) FROM details) AND dtl_id = " & DtlID
            Dim DtlCount As Integer = Sql.ExecuteScalar
            If DtlCount = 0 Then
                Continue While
            End If
            EXSheet(RowCount, 3).Value = DtlID
            EXSheet(RowCount, 0).Value = SwrktypReader.Item("s_worktype_code")
            EXSheet(RowCount, 1).Value = SwrktypReader.Item("dtl_no")
            EXSheet(RowCount, 2).Value = SwrktypReader.Item("s_wrktyp_name")
            EXSheet(RowCount, 4).Value = SwrktypReader.Item("dtl_name")
            EXSheet(RowCount, 5).Value = SwrktypReader.Item("dtl_spec")
            EXSheet(RowCount, 6).Value = SwrktypReader.Item("dtl_unit")
            EXSheet(RowCount, 7).Value = SwrktypReader.Item("dtl_quanity")
            EXSheet(RowCount, 8).Value = SwrktypReader.Item("dtl_costea")
            EXSheet(RowCount, 9).Value = SwrktypReader.Item("dtl_amount")

            '直営取得
            Sql.CommandText = "SELECT ISNULL(inhouse_amount,dtl_amount) FROM DirectManagement_View WHERE (outsrc_no IS NULL OR outsrc_no = (SELECT MAX(outsrc_no) FROM OutsrcrPlan_View)) AND dtl_id = " & EXSheet(RowCount, 3).Value
            Dim dm_amount As Decimal = Sql.ExecuteScalar
            EXSheet(RowCount, 10).Value = dm_amount

            ''材料費
            'Sql.CommandText = "SELECT ISNULL(dtl_material,0) FROM details WHERE budget_no = (SELECT MAX(budget_no) FROM details) AND dtl_id = " & EXSheet(RowCount, 3).Value
            'Dim material As Decimal = Sql.ExecuteScalar
            'EXSheet(RowCount, 11).Value = material

            ''機械費
            'Sql.CommandText = "SELECT ISNULL(dtl_machine,0) FROM details WHERE budget_no = (SELECT MAX(budget_no) FROM details) AND dtl_id = " & EXSheet(RowCount, 3).Value
            'Dim machine As Decimal = Sql.ExecuteScalar
            'EXSheet(RowCount, 12).Value = material

            ''外注費
            'Sql.CommandText = "SELECT ISNULL(dtl_subcntrct,0) FROM details WHERE budget_no = (SELECT MAX(budget_no) FROM details) AND dtl_id = " & EXSheet(RowCount, 3).Value
            'Dim subcntrct As Decimal = Sql.ExecuteScalar
            'EXSheet(RowCount, 13).Value = material

            ''機械費
            'Sql.CommandText = "SELECT ISNULL(dtl_labor,0) FROM details WHERE budget_no = (SELECT MAX(budget_no) FROM details) AND dtl_id = " & EXSheet(RowCount, 3).Value
            'Dim labor As Decimal = Sql.ExecuteScalar
            'EXSheet(RowCount, 14).Value = material

            '詳細入力表内容
            Sql.CommandText = "SELECT amount1,amount2,amount3,amount4,amount5,amount6,amount7,amount8,amount9 FROM subject_details WHERE budget_no = (SELECT MAX(budget_no) FROM details) AND dtl_id = " & EXSheet(RowCount, 3).Value
            Dim SubjectReader As SqlDataReader = Sql.ExecuteReader
            While SubjectReader.Read
                If IsDBNull(SubjectReader.Item("amount1")) = True Then
                    EXSheet(RowCount, 11).Value = 0
                Else
                    EXSheet(RowCount, 11).Value = SubjectReader.Item("amount1")
                End If
                If IsDBNull(SubjectReader.Item("amount2")) = True Then
                    EXSheet(RowCount, 12).Value = 0
                Else
                    EXSheet(RowCount, 12).Value = SubjectReader.Item("amount2")
                End If
                If IsDBNull(SubjectReader.Item("amount3")) = True Then
                    EXSheet(RowCount, 13).Value = 0
                Else
                    EXSheet(RowCount, 13).Value = SubjectReader.Item("amount3")
                End If
                If IsDBNull(SubjectReader.Item("amount4")) = True Then
                    EXSheet(RowCount, 14).Value = 0
                Else
                    EXSheet(RowCount, 14).Value = SubjectReader.Item("amount4")
                End If
                If IsDBNull(SubjectReader.Item("amount5")) = True Then
                    EXSheet(RowCount, 15).Value = 0
                Else
                    EXSheet(RowCount, 15).Value = SubjectReader.Item("amount5")
                End If
                If IsDBNull(SubjectReader.Item("amount6")) = True Then
                    EXSheet(RowCount, 16).Value = 0
                Else
                    EXSheet(RowCount, 16).Value = SubjectReader.Item("amount6")
                End If
                If IsDBNull(SubjectReader.Item("amount7")) = True Then
                    EXSheet(RowCount, 17).Value = 0
                Else
                    EXSheet(RowCount, 17).Value = SubjectReader.Item("amount7")
                End If
                If IsDBNull(SubjectReader.Item("amount8")) = True Then
                    EXSheet(RowCount, 18).Value = 0
                Else
                    EXSheet(RowCount, 18).Value = SubjectReader.Item("amount8")
                End If
                If IsDBNull(SubjectReader.Item("amount9")) = True Then
                    EXSheet(RowCount, 19).Value = 0
                Else
                    EXSheet(RowCount, 19).Value = SubjectReader.Item("amount9")
                End If
            End While
            SubjectReader.Close()

            Dim quanity As Decimal
            Dim costea As Decimal
            Dim amount As Decimal
            '業者数ループ
            For VendorLoop As Integer = 0 To VendorIDList.Count - 1
                '変更回数がNULLでない場合
                If Not IsDBNull(SwrktypReader.Item("outsrc_no")) Then
                    '外注計画データ取得
                    'Sql.CommandText = "SELECT ISNULL(outsrcng_quanity,0) FROM OutsrcrPlan_View WHERE (outsrc_no IS NULL OR outsrc_no = (SELECT MAX(outsrc_no) FROM OutsrcrPlan_View)) AND s_worktype_code =  " & EXSheet(RowCount, 0).Value & " AND (outsrcr_id IS NULL OR outsrcr_id = " & VendorIDList(VendorLoop) & ") AND dtl_id = " & EXSheet(RowCount, 3).Value & " ORDER BY s_worktype_code,dtl_no ASC"
                    'Dim quanity As Decimal = Sql.ExecuteScalar
                    'If Not IsDBNull(quanity) OrElse quanity = 0 Then
                    '    EXSheet(RowCount, 21 + (VendorLoop * 3)).Value = quanity

                    '    Sql.CommandText = "SELECT ISNULL(outsrcng_costea,0) FROM OutsrcrPlan_View WHERE (outsrc_no IS NULL OR outsrc_no = (SELECT MAX(outsrc_no) FROM OutsrcrPlan_View)) AND s_worktype_code =  " & EXSheet(RowCount, 0).Value & " AND (outsrcr_id IS NULL OR outsrcr_id = " & VendorIDList(VendorLoop) & ") AND dtl_id = " & EXSheet(RowCount, 3).Value & " ORDER BY s_worktype_code,dtl_no ASC"
                    '    Dim costea As Decimal = Sql.ExecuteScalar
                    '    EXSheet(RowCount, 22 + (VendorLoop * 3)).Value = costea

                    '    Sql.CommandText = "SELECT ISNULL(outsrcng_amount,0) FROM OutsrcrPlan_View WHERE (outsrc_no IS NULL OR outsrc_no = (SELECT MAX(outsrc_no) FROM OutsrcrPlan_View)) AND s_worktype_code =  " & EXSheet(RowCount, 0).Value & " AND (outsrcr_id IS NULL OR outsrcr_id = " & VendorIDList(VendorLoop) & ") AND dtl_id = " & EXSheet(RowCount, 3).Value & " ORDER BY s_worktype_code,dtl_no ASC"
                    '    Dim amount As Decimal = Sql.ExecuteScalar
                    '    EXSheet(RowCount, 23 + (VendorLoop * 3)).Value = amount
                    'End If
                    Sql.CommandText = "SELECT outsrcng_quanity,outsrcng_costea,outsrcng_amount FROM OutsrcrPlan_View WHERE (outsrc_no IS NULL OR outsrc_no = (SELECT MAX(outsrc_no) FROM OutsrcrPlan_View)) AND s_worktype_code =  " & EXSheet(RowCount, 0).Value & " AND (outsrcr_id IS NULL OR outsrcr_id = " & VendorIDList(VendorLoop) & ") AND dtl_id = " & EXSheet(RowCount, 3).Value & " ORDER BY s_worktype_code,dtl_no ASC"
                    Dim vendorcst As SqlDataReader = Sql.ExecuteReader
                    While vendorcst.Read
                        If IsDBNull(vendorcst.Item("outsrcng_quanity")) = True Then
                            vendorcst.Close()
                            Exit For
                        Else
                            quanity = vendorcst.Item("outsrcng_quanity")
                            If quanity = 0 Then
                                vendorcst.Close()
                                Exit For
                            End If
                            EXSheet(RowCount, 21 + (VendorLoop * 3)).Value = quanity
                        End If
                        If IsDBNull(vendorcst.Item("outsrcng_costea")) = True Then
                            EXSheet(RowCount, 22 + (VendorLoop * 3)).Value = 0
                        Else
                            costea = vendorcst.Item("outsrcng_costea")
                            EXSheet(RowCount, 22 + (VendorLoop * 3)).Value = costea
                        End If
                        If IsDBNull(vendorcst.Item("outsrcng_amount")) = True Then
                            EXSheet(RowCount, 23 + (VendorLoop * 3)).Value = 0
                        Else
                            amount = vendorcst.Item("outsrcng_amount")
                            EXSheet(RowCount, 23 + (VendorLoop * 3)).Value = amount
                        End If
                    End While
                    vendorcst.Close()
                End If
            Next
            RowCount += 1
        End While
        SwrktypReader.Close()
        進行状況.Close()

        'Excel保存
        xlbook.Save(Path)
        Cursor.Current = Cursors.Default

        MsgBox("ファイルを出力しました。" & vbCrLf & Path, MsgBoxStyle.OkOnly, "外注計画(EXCEL)")

        Return ExportLoad
    End Function
End Class
