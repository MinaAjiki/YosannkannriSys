Imports System.Data.SqlClient
Public Class Recalculation
    Private ClssCode As Integer
    Public Sub New(ByVal ClassCode As Integer)
        ClssCode = ClassCode
    End Sub
    Public Function Recalculation() As String

        Recalculation = ""
        Cursor.Current = Cursors.WaitCursor

        Dim ClassCount As Integer = ClssCode - 12
        Dim StartClass As Integer = ClssCode - 1


        ホーム.Transaction = ホーム.Connection.BeginTransaction
        ホーム.Sql.Transaction = ホーム.Transaction

        For ClassLoop As Integer = StartClass To ClassCount

            ホーム.Sql.CommandText = "CREATE TABLE #UpdateID_bd (prjctcst_id INT DEFAULT (0) NOT NULL,
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
                                      OUTPUT inserted.prjctcst_id INTO #UpdateID_bd.prjctcst_id
                                      FROM #UpdateID WHERE project_cost_breakdowns.cstclss_code=" & ClassLoop & " AND project_cost_breakdowns.cstmstr_id=#UpdateID.id"
            ホーム.Sql.ExecuteNonQuery()

            ホーム.Sql.CommandText = "DELETE * FROM #UpdateID"
            ホーム.Sql.ExecuteNonQuery()

            ホーム.Sql.CommandText = "UPDATE #UpdateID_bd SET #UpdateID_bd.costea=projectcst_bd_total.costea,#UpdateID_bd.laborea=projectcst_bd_total.laborea,
                                                               #UpdateID_bd.materialea=projectcst_bd_total.materialea,#UpdateID_bd.machineea=projectcst_bd_total.machineea,
                                                               #UpdateID_bd.subcntrctea=projectcst_bd_total.subcntrctea,#UpdateID_bd.expenseea=projectcst_bd_total.expenseea
                                        FROM projectcst_bd_total WHERE #UpdateID_bd.prjctcst_id=projectcst_bd_total.prjctcst_id"
            ホーム.Sql.ExecuteNonQuery()


            ホーム.Sql.CommandText = "UPDATE project_costs SET project_costs.prjctcst_costea=#UpdateID_bd.costea,project_costs.prjctcst_laborea=#UpdateID.laborea,
                                                               project_costs.prjctcst_materialea=#UpdateID_bd.materialea,project_costs.prjctcst_machineea=#UpdateID.machineea,
                                                               project_costs.prjctcst_subcntrctea=#UpdateID_bd.subcntrctea,project_costs.prjctcst_expenseea=#UpdateID.expenseea 
                                     OUTPUT inserted.prjctcst_id,inserted.prjctcst_name,inserted.prjctcst_spec,inserted.prjctcst_unit,inserted.prjctcst_costea,inserted.prjctcst_laborea,
                                            inserted.prjctcst_materialea,inserted.prjctcst_machineea,inserted.prjctcst_subcntrctea,inserted.prjctcst_expenseea 
                                     INTO #UpdateID(id,name,spec,unit,costea,laborea,materialea,machineea,subcntrctea,expenseea)
                                     FROM #UpdateID_bd  WHERE project_costs.prjctcst_id=#UpdateID_bd.prjctcst_id"
            ホーム.Sql.ExecuteNonQuery()

            ホーム.Sql.CommandText = "DROP TABLE #UpdateID_bd"
            ホーム.Sql.ExecuteNonQuery()
        Next

        ホーム.Sql.CommandText = "UPDATE details SET details.dtl_name=#UpdateID.name,details.dtl_spec=#UpdateID.spec,details.dtl_unit=#UpdateID.unit,details.dtl_costea=#UpdateID.costea,
                                  details.dtl_labor=#UpdateID.labor,details.dtl_material=#UpdateID.material,details.dtl_machine=#UpdateID.machine,details.dtl_subcntrct=#UpdateID.subcntrct,
                                  details.dtl_expens=#UpdateID.expense FROM #UpdateID WHERE details.cstmstr_id=#UpdateID.id AND details.cstclss_code=12"
        ホーム.Sql.ExecuteNonQuery()


        ホーム.Sql.CommandText = "DROP TABLE #UpdateID"
        ホーム.Sql.ExecuteNonQuery()



        ホーム.Transaction.Commit()


        Return Recalculation
    End Function
End Class
