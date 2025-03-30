Imports System.Data.SqlClient


Module AuditModules

    Public Sub LogAudit(userID As String, action As String, tableName As String, recordID As String, oldValue As String, newValue As String)
        Dim query As String = "INSERT INTO AuditLog (UserID, Action, TableName, RecordID, OldValue, NewValue) VALUES (@UserID, @Action, @TableName, @RecordID, @OldValue, @NewValue)"

        Using conn As New SqlConnection("Data Source=TECHQUINA\SQLNEWINSTANCE;Initial Catalog=JimbospharmaDB;User ID=sa;Password=salinas")
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@UserID", userID)
                cmd.Parameters.AddWithValue("@Action", action)
                cmd.Parameters.AddWithValue("@TableName", tableName)
                cmd.Parameters.AddWithValue("@RecordID", recordID)
                cmd.Parameters.AddWithValue("@OldValue", oldValue)
                cmd.Parameters.AddWithValue("@NewValue", newValue)

                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Module
