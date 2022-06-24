Imports System.Data.SqlClient
Public Class Recalculation_cst
    Private ClssCode As Integer
    Private maxcode As Integer
    Public Sub New(ByVal ClassCode As Integer, ByVal max As Integer)
        ClssCode = ClassCode
        maxcode = max
    End Sub
    Public Function Recalculation() As String

        Recalculation = ""
        Cursor.Current = Cursors.WaitCursor


        ホーム.Transaction = ホーム.Connection.BeginTransaction
        ホーム.Sql.Transaction = ホーム.Transaction

        ホーム.Sql.CommandText = "CREATE TABLE ##bd_data (prjctcst_id INT DEFAULT (0) NOT NULL,
                                                                 cstclss_code INT DEFAULT (0) NOT NULL,
                                                                 costea MONEY DEFAULT (0) NOT NULL,
                                                                 laborea MONEY DEFAULT (0) NOT NULL,
                                                                 materialea MONEY DEFAULT (0) NOT NULL,
                                                                 machineea MONEY DEFAULT (0) NOT NULL,
                                                                 subcntrctea MONEY DEFAULT (0) NOT NULL,
                                                                 expenseea MONEY DEFAULT (0) NOT NULL)"
        ホーム.Sql.ExecuteNonQuery()

        Dim text As String = ""

        If ClssCode = 1 Then
            text = "project_cost_breakdowns.prjctcst_bd_labor=#update_data.costea"
        ElseIf ClssCode = 2 Or ClssCode = 6 Or ClssCode = 7 Then
            text = "project_cost_breakdowns.prjctcst_bd_material=#update_data.costea"
        ElseIf ClssCode = 3 Then
            text = "project_cost_breakdowns.prjctcst_bd_machine=#update_data.costea"
        ElseIf ClssCode = 4 Then
            text = "project_cost_breakdowns.prjctcst_bd_subcntrct=#update_data.costea"
        ElseIf ClssCode = 5 Then
            text = "project_cost_breakdowns.prjctcst_bd_expense=#update_data.costea"
        End If


        ホーム.Sql.CommandText = "UPDATE project_cost_breakdowns SET project_cost_breakdowns.prjctcst_bd_name=#update_data.name,project_cost_breakdowns.prjctcst_bd_spec=#update_data.spec,
                                         project_cost_breakdowns.prjctcst_bd_unit=#update_data.unit,project_cost_breakdowns.prjctcst_bd_costea=#update_data.costea," & text &
                                  " OUTPUT inserted.prjctcst_id INTO ##bd_data(prjctcst_id)
                                  FROM #update_data WHERE project_cost_breakdowns.cstclss_code=" & ClssCode & " AND project_cost_breakdowns.cstmstr_id=#update_data.cstmstr_id"
        ホーム.Sql.ExecuteNonQuery()

        Dim CostLists(25) As String
        Dim CodeLists(25) As Integer
        CostLists(25) = "A"
        CostLists(24) = "B"
        CostLists(23) = "C"
        CostLists(22) = "D"
        CostLists(21) = "E"
        CostLists(20) = "F"
        CostLists(19) = "G"
        CostLists(18) = "H"
        CostLists(17) = "I"
        CostLists(16) = "J"
        CostLists(15) = "K"
        CostLists(14) = "L"
        CostLists(13) = "M"
        CostLists(12) = "N"
        CostLists(11) = "O"
        CostLists(10) = "P"
        CostLists(9) = "Q"
        CostLists(8) = "R"
        CostLists(7) = "S"
        CostLists(6) = "T"
        CostLists(5) = "U"
        CostLists(4) = "V"
        CostLists(3) = "W"
        CostLists(2) = "X"
        CostLists(1) = "Y"
        CostLists(0) = "Z"

        CodeLists(25) = "12"
        CodeLists(24) = "13"
        CodeLists(23) = "14"
        CodeLists(22) = "15"
        CodeLists(21) = "16"
        CodeLists(20) = "17"
        CodeLists(19) = "18"
        CodeLists(18) = "19"
        CodeLists(17) = "20"
        CodeLists(16) = "21"
        CodeLists(15) = "22"
        CodeLists(14) = "23"
        CodeLists(13) = "24"
        CodeLists(12) = "25"
        CodeLists(11) = "26"
        CodeLists(10) = "27"
        CodeLists(9) = "28"
        CodeLists(8) = "29"
        CodeLists(7) = "30"
        CodeLists(6) = "31"
        CodeLists(5) = "32"
        CodeLists(4) = "33"
        CodeLists(3) = "34"
        CodeLists(2) = "35"
        CodeLists(1) = "36"
        CodeLists(0) = "37"

        ホーム.Sql.CommandText = "CREATE TABLE #prjct_update_data (id INT DEFAULT (0) NOT NULL,
                                                              cstclss_code INT DEFAULT (0) NOT NULL, 
                                                              name NVARCHAR(50) DEFAULT ('') NOT NULL,
                                                              spec NVARCHAR(50) DEFAULT ('') NOT NULL,
                                                              unit NVARCHAR(6) DEFAULT ('') NOT NULL,
                                                              costea MONEY DEFAULT (0) NOT NULL,
                                                              labor MONEY DEFAULT (0) NOT NULL,
                                                              material MONEY DEFAULT (0) NOT NULL,
                                                              machine MONEY DEFAULT (0) NOT NULL,
                                                              subcntrct MONEY DEFAULT (0) NOT NULL,
                                                              expense MONEY DEFAULT (0) NOT NULL)"
        ホーム.Sql.ExecuteNonQuery()


        Dim StartClass As Integer = Array.IndexOf(CodeLists, maxcode)

        For ClassLoop As Integer = StartClass To 25
            ホーム.Sql.CommandText = "DELETE FROM #prjct_update_data"
            ホーム.Sql.ExecuteNonQuery()


            ホーム.Sql.CommandText = "UPDATE ##bd_data SET ##bd_data.cstclss_code=projectcst_bd_total.cstclss_code,
                                                               ##bd_data.costea=projectcst_bd_total.costea,##bd_data.laborea=projectcst_bd_total.laborea,
                                                               ##bd_data.materialea=projectcst_bd_total.materialea,##bd_data.machineea=projectcst_bd_total.machineea,
                                                               ##bd_data.subcntrctea=projectcst_bd_total.subcntrctea,##bd_data.expenseea=projectcst_bd_total.expenseea
                                        FROM projectcst_bd_total WHERE ##bd_data.prjctcst_id=projectcst_bd_total.prjctcst_id"
            ホーム.Sql.ExecuteNonQuery()


            ホーム.Sql.CommandText = "UPDATE project_costs SET project_costs.prjctcst_costea=##bd_data.costea,project_costs.prjctcst_laborea=##bd_data.laborea,
                                                               project_costs.prjctcst_materialea=##bd_data.materialea,project_costs.prjctcst_machineea=##bd_data.machineea,
                                                               project_costs.prjctcst_subcntrctea=##bd_data.subcntrctea,project_costs.prjctcst_expenseea=##bd_data.expenseea 
                                     OUTPUT inserted.prjctcst_id,inserted.cstclss_code,inserted.prjctcst_name,inserted.prjctcst_spec,inserted.prjctcst_unit,inserted.prjctcst_costea,
                                            inserted.prjctcst_laborea,inserted.prjctcst_materialea,inserted.prjctcst_machineea,inserted.prjctcst_subcntrctea,inserted.prjctcst_expenseea 
                                     INTO #prjct_update_data(id,cstclss_code,name,spec,unit,costea,labor,material,machine,subcntrct,expense)
                                     FROM ##bd_data  WHERE project_costs.prjctcst_id=##bd_data.prjctcst_id"
            ホーム.Sql.ExecuteNonQuery()

            ホーム.Sql.CommandText = "UPDATE details SET details.dtl_name=#prjct_update_data.name,details.dtl_spec=#prjct_update_data.spec,details.dtl_unit=#prjct_update_data.unit,
                                                         details.dtl_costea=#prjct_update_data.costea,details.dtl_labor=#prjct_update_data.labor,details.dtl_material=#prjct_update_data.material,
                                                         details.dtl_machine=#prjct_update_data.machine,details.dtl_subcntrct=#prjct_update_data.subcntrct,details.dtl_expens=#prjct_update_data.expense 
                                      FROM #prjct_update_data WHERE details.cstmstr_id=#prjct_update_data.id AND details.cstclss_code=#prjct_update_data.cstclss_code"
            ホーム.Sql.ExecuteNonQuery()

            ホーム.Sql.CommandText = "DELETE FROM ##bd_data"
            ホーム.Sql.ExecuteNonQuery()

            If ClassLoop < 25 Then
                ホーム.Sql.CommandText = "UPDATE project_cost_breakdowns SET project_cost_breakdowns.prjctcst_bd_name=#prjct_update_data.name,project_cost_breakdowns.prjctcst_bd_spec=#prjct_update_data.spec,
                                                  project_cost_breakdowns.prjctcst_bd_unit=#prjct_update_data.unit,project_cost_breakdowns.prjctcst_bd_costea=#prjct_update_data.costea,
                                                  project_cost_breakdowns.prjctcst_bd_labor=#prjct_update_data.labor,project_cost_breakdowns.prjctcst_bd_material=#prjct_update_data.material,
                                                  project_cost_breakdowns.prjctcst_bd_machine=#prjct_update_data.machine,project_cost_breakdowns.prjctcst_bd_subcntrct=#prjct_update_data.subcntrct,
                                                  project_cost_breakdowns.prjctcst_bd_expense=#prjct_update_data.expense 
                                      OUTPUT inserted.prjctcst_id INTO ##bd_data(prjctcst_id)
                                      FROM #prjct_update_data WHERE project_cost_breakdowns.cstclss_code=#prjct_update_data.cstclss_code AND project_cost_breakdowns.cstmstr_id=#prjct_update_data.id"
                ホーム.Sql.ExecuteNonQuery()
            End If
        Next

        ホーム.Sql.CommandText = "DROP TABLE ##bd_data"
        ホーム.Sql.ExecuteNonQuery()


        ホーム.Sql.CommandText = "DROP TABLE #prjct_update_data"
        ホーム.Sql.ExecuteNonQuery()



        ホーム.Transaction.Commit()


        Return Recalculation
    End Function
End Class
