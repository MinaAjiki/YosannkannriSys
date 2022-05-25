Imports System.Data.SqlClient
Public Class Reference_Details
    Private BudgetNo As Integer
    Private Year_New As Integer
    Private Year_Old As Integer
    Public Sub New(ByVal BdgNo As Integer, ByVal Year_N As Integer, ByVal Year_O As Integer)
        BudgetNo = BdgNo
        Year_New = Year_N
        Year_Old = Year_O
    End Sub
    Public Function Missingnumber_Details() As String

        Missingnumber_Details = ""

        ホーム.Transaction = ホーム.Connection.BeginTransaction
        ホーム.Sql.Transaction = ホーム.Transaction





        ホーム.Transaction.Commit()


        Return Missingnumber_Details
    End Function
End Class
