Imports System.Data.SqlClient

Module Variables
    Public Cmd As SqlCommand
    Public Query As String
    Public Con As New SqlConnection '(My.Settings.FMIDATAConnectionString)
    Public Reader As SqlDataReader = Nothing
    Public TempFileNames2 As String
End Module
