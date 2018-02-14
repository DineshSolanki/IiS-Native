Imports System.Data.SqlClient

Module Functions
    Sub LogFunc(ByVal st1 As String, ByVal st2 As String)
        Con = New SqlConnection(My.Settings.IiSConnectionString)
        con.Open()
        Dim cb As String = "insert into Logs(UserID,Date,Operation) VALUES (@d1,@d2,@d3)"
        cmd = New SqlCommand(cb)
        cmd.Connection = con
        cmd.Parameters.AddWithValue("@d1", st1)
        cmd.Parameters.AddWithValue("@d2", DateTime.Now)
        cmd.Parameters.AddWithValue("@d3", st2)
        cmd.ExecuteReader()
        Con.Close()
    End Sub
End Module
