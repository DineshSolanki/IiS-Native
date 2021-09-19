Imports System.Data.SqlClient
Imports DevExpress.XtraEditors

Public Class Reset_Database
    Dim cmd As SqlCommand
    Dim query As String
    Dim con As SqlConnection

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        Try
            query = "Truncate Table Students"
            con = New SqlConnection(My.Settings.FMIDATAConnectionString)
            cmd = New SqlCommand(query, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Try
            query = "Truncate Table Staff"
            con = New SqlConnection(My.Settings.FMIDATAConnectionString)
            cmd = New SqlCommand(query, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Try
            query = "Truncate Table FeeStructure"
            con = New SqlConnection(My.Settings.FMIDATAConnectionString)
            cmd = New SqlCommand(query, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Try
            query = "Truncate Table FeeData"
            con = New SqlConnection(My.Settings.FMIDATAConnectionString)
            cmd = New SqlCommand(query, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            query = "Truncate Table Activation"
            con = New SqlConnection(My.Settings.FMIDATAConnectionString)
            cmd = New SqlCommand(query, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        Try
            query = "Truncate Table Logs"
            con = New SqlConnection(My.Settings.FMIDATAConnectionString)
            cmd = New SqlCommand(query, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        Try
            query = "Truncate Table Sessions"
            con = New SqlConnection(My.Settings.FMIDATAConnectionString)
            cmd = New SqlCommand(query, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton8_Click(sender As Object, e As EventArgs) Handles SimpleButton8.Click
        Try
            query = "Truncate Table Transact"
            con = New SqlConnection(My.Settings.FMIDATAConnectionString)
            cmd = New SqlCommand(query, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub
End Class