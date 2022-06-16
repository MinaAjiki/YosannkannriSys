Imports System.Data.SqlClient
Public Class Recalculation_prjctcst
    Private ClssCode As Integer
    Public Sub New(ByVal ClassCode As Integer)
        ClssCode = ClassCode
    End Sub
    Public Function Recalculation() As String

        Recalculation = ""
        Cursor.Current = Cursors.WaitCursor

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

        Dim StartClass As Integer = Array.IndexOf(CodeLists, ClssCode)

        ホーム.Transaction = ホーム.Connection.BeginTransaction
        ホーム.Sql.Transaction = ホーム.Transaction

        For ClassLoop As Integer = StartClass To 25

            ホーム.Sql.CommandText = "CREATE TABLE ##bd (prjctcst_id INT DEFAULT (0) NOT NULL,
                                                                 cstclss_code INT DEFAULT (0) NOT NULL,
                                                                 costea MONEY DEFAULT (0) NOT NULL,
                                                                 laborea MONEY DEFAULT (0) NOT NULL,
                                                                 materialea MONEY DEFAULT (0) NOT NULL,
                                                                 machineea MONEY DEFAULT (0) NOT NULL,
                                                                 subcntrctea MONEY DEFAULT (0) NOT NULL,
                                                                 expenseea MONEY DEFAULT (0) NOT NULL)"
            ホーム.Sql.ExecuteNonQuery()

            ホーム.Sql.CommandText = "UPDATE project_cost_breakdowns SET project_cost_breakdowns.prjctcst_bd_name=#UpdateID.name,project_cost_breakdowns.prjctcst_bd_spec=#UpdateID.spec,
                                                  project_cost_breakdowns.prjctcst_bd_unit=#UpdateID.unit,project_cost_breakdowns.prjctcst_bd_costea=#UpdateID.costea,
                                                  project_cost_breakdowns.prjctcst_bd_labor=#UpdateID.labor,project_cost_breakdowns.prjctcst_bd_material=#UpdateID.material,
                                                  project_cost_breakdowns.prjctcst_bd_machine=#UpdateID.machine,project_cost_breakdowns.prjctcst_bd_subcntrct=#UpdateID.subcntrct,
                                                  project_cost_breakdowns.prjctcst_bd_expense=#UpdateID.expense 
                                      OUTPUT inserted.prjctcst_id INTO ##bd(prjctcst_id)
                                      FROM #UpdateID WHERE project_cost_breakdowns.cstclss_code=" & CodeLists(ClassLoop) & " AND project_cost_breakdowns.cstmstr_id=#UpdateID.id"
            ホーム.Sql.ExecuteNonQuery()

            ホーム.Sql.CommandText = "DELETE FROM #UpdateID"
            ホーム.Sql.ExecuteNonQuery()

            ホーム.Sql.CommandText = "UPDATE ##bd SET ##bd.cstclss_code=projectcst_bd_total.cstclss_code,
                                                               ##bd.costea=projectcst_bd_total.costea,##bd.laborea=projectcst_bd_total.laborea,
                                                               ##bd.materialea=projectcst_bd_total.materialea,##bd.machineea=projectcst_bd_total.machineea,
                                                               ##bd.subcntrctea=projectcst_bd_total.subcntrctea,##bd.expenseea=projectcst_bd_total.expenseea
                                        FROM projectcst_bd_total WHERE ##bd.prjctcst_id=projectcst_bd_total.prjctcst_id"
            ホーム.Sql.ExecuteNonQuery()


            ホーム.Sql.CommandText = "UPDATE project_costs SET project_costs.prjctcst_costea=##bd.costea,project_costs.prjctcst_laborea=##bd.laborea,
                                                               project_costs.prjctcst_materialea=##bd.materialea,project_costs.prjctcst_machineea=##bd.machineea,
                                                               project_costs.prjctcst_subcntrctea=##bd.subcntrctea,project_costs.prjctcst_expenseea=##bd.expenseea 
                                     OUTPUT inserted.prjctcst_id,inserted.cstclss_code,inserted.prjctcst_name,inserted.prjctcst_spec,inserted.prjctcst_unit,inserted.prjctcst_costea,
                                            inserted.prjctcst_laborea,inserted.prjctcst_materialea,inserted.prjctcst_machineea,inserted.prjctcst_subcntrctea,inserted.prjctcst_expenseea 
                                     INTO #UpdateID(id,cstclss_code,name,spec,unit,costea,labor,material,machine,subcntrct,expense)
                                     FROM ##bd  WHERE project_costs.prjctcst_id=##bd.prjctcst_id"
            ホーム.Sql.ExecuteNonQuery()

            ホーム.Sql.CommandText = "DROP TABLE ##bd"
            ホーム.Sql.ExecuteNonQuery()

            ホーム.Sql.CommandText = "UPDATE details SET details.dtl_name=#UpdateID.name,details.dtl_spec=#UpdateID.spec,details.dtl_unit=#UpdateID.unit,details.dtl_costea=#UpdateID.costea,
                                  details.dtl_labor=#UpdateID.labor,details.dtl_material=#UpdateID.material,details.dtl_machine=#UpdateID.machine,details.dtl_subcntrct=#UpdateID.subcntrct,
                                  details.dtl_expens=#UpdateID.expense FROM #UpdateID WHERE details.cstmstr_id=#UpdateID.id AND details.cstclss_code=#UpdateID.cstclss_code"
            ホーム.Sql.ExecuteNonQuery()
        Next




        ホーム.Sql.CommandText = "DROP TABLE #UpdateID"
        ホーム.Sql.ExecuteNonQuery()



        ホーム.Transaction.Commit()


        Return Recalculation
    End Function
End Class
