Imports System.Data.SqlClient
Public Class CostCopy
    Private createclsscode As Integer
    Private prjctcstid As Integer
    Private prjctcstno As Integer
    Public Sub New(ByVal createclasscode As Integer, ByVal projectcstid As Integer, ByVal projectcostno As Integer)
        createclsscode = createclasscode
        prjctcstid = projectcstid
        prjctcstno = projectcostno
    End Sub
    Public Function CostCopy() As String

        CostCopy = ""
        Cursor.Current = Cursors.WaitCursor

        ホーム.Sql.CommandText = ""
        ホーム.Sql.Parameters.Clear()


        ホーム.Transaction = ホーム.Connection.BeginTransaction
        ホーム.Sql.Transaction = ホーム.Transaction

        ホーム.Sql.CommandText = "SELECT * INTO #project_cost FROM project_costs WHERE prjctcst_id=" & prjctcstid
        ホーム.Sql.ExecuteNonQuery()

        ホーム.Sql.CommandText = "UPDATE #project_cost SET cstclss_code=" & createclsscode & ",prjctcst_no=" & prjctcstno
        ホーム.Sql.ExecuteNonQuery()

        ホーム.Sql.CommandText = "ALTER TABLE #project_cost DROP COLUMN prjctcst_id"
        ホーム.Sql.ExecuteNonQuery()

        ホーム.Sql.CommandText = "CREATE TABLE #prjctcostid (prjctcst_id INT DEFAULT (0) NOT NULL)"
        ホーム.Sql.ExecuteNonQuery()

        ホーム.Sql.CommandText = "INSERT INTO project_costs OUTPUT inserted.prjctcst_id INTO #prjctcostid(prjctcst_id) SELECT * FROM #project_cost"
        ホーム.Sql.ExecuteNonQuery()

        ホーム.Sql.CommandText = "SELECT * INTO #project_cost_breakdown FROM project_cost_breakdowns WHERE prjctcst_id=" & prjctcstid
        ホーム.Sql.ExecuteNonQuery()

        ホーム.Sql.CommandText = "UPDATE #project_cost_breakdown SET #project_cost_breakdown.prjctcst_id=#prjctcostid.prjctcst_id FROM #prjctcostid"
        ホーム.Sql.ExecuteNonQuery()

        ホーム.Sql.CommandText = "ALTER TABLE #project_cost_breakdown DROP COLUMN prjctcst_bd_id"
        ホーム.Sql.ExecuteNonQuery()

        ホーム.Sql.CommandText = "INSERT INTO project_cost_breakdowns SELECT * FROM #project_cost_breakdown"
        ホーム.Sql.ExecuteNonQuery()

        ホーム.Sql.CommandText = "DROP TABLE #project_cost"
        ホーム.Sql.ExecuteNonQuery()

        ホーム.Sql.CommandText = "DROP TABLE #prjctcostid"
        ホーム.Sql.ExecuteNonQuery()

        ホーム.Sql.CommandText = "DROP TABLE #project_cost_breakdown"
        ホーム.Sql.ExecuteNonQuery()

        ホーム.Transaction.Commit()

        MsgBox("コピー完了", MsgBoxStyle.OkOnly, "代価コピー")


        Return CostCopy
    End Function
End Class
