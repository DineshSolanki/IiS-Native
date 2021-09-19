Imports System.Data.SqlClient


Public Class LoginForm1
    Inherits DevExpress.XtraEditors.XtraForm
    Dim _cmd As SqlCommand
    Dim _con As SqlConnection
    Dim _main As New mainfrm

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        'Try
        '    con = New SqlConnection(My.Settings.FMIDATAConnectionString)
        '    query = "Select @@VERSION"
        '    cmd = New SqlCommand(query, con)
        '    con.Open()
        '    MessageBox.Show(cmd.ExecuteScalar())
        '    con.Close()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
        _con = New SqlConnection(My.Settings.FMIDATAConnectionString)
        _cmd = New SqlCommand("login", _con)
        _cmd.Parameters.AddWithValue("UserName", UsernameTextBox.Text)
        _cmd.Parameters.AddWithValue("Password", PasswordTextBox.Text)
        Dim resultParam = _cmd.Parameters.Add("@responseMessage", SqlDbType.NVarChar, 250)
        _cmd.CommandType = CommandType.StoredProcedure
        resultParam.Direction = ParameterDirection.Output
        _con.Open()
        _cmd.ExecuteScalar()
        _con.Close()
        Dim res = resultParam.Value.ToString()
        If res <> "User successfully logged in" Then
            MsgBox(res, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        Else
            _main.BarStaticItem5.Caption = UsernameTextBox.Text
            Dim st As String = "Successfully logged in"
            LogFunc(UsernameTextBox.Text, st)
            _main.Show()
            Close()

        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Application.Exit()
    End Sub

    Private Sub LoginForm1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MessageBox.Show(IsFormOpen(SplashScreen1))
        'For Each form In Application.OpenForms
        '    If (form.Name = SplashScreen1.Name) Then
        '        MessageBox.Show("open " & form.Name)
        '        SplashScreen1.Close()
        'SplashScreen1.Close()
        'If form.Visible Then
        '    'do work when visible
        'End If

        '    End If
        'Next
    End Sub
End Class
