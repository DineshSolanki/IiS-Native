Imports System.Data.SqlClient
Imports DevExpress.XtraEditors

Public Class ManageUser
    Dim _cmd As SqlCommand
    Dim _con As SqlConnection
    Private Sub ManageUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New FMIDATADataContext
        Dim usersList = From p In db.USERs
                        Select p Order By p.UserName Ascending Where Not p.UserName = "Nakashtra"

        lstexistingusers.Items.Clear()
        If usersList.Count <> 0 Then
            For j = 1 To usersList.Count
                lstexistingusers.Items.Add(usersList.ToList(j - 1).Full_Name)
            Next
        End If
    End Sub




    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        Dim check = False
        For Each item As Control In GroupControl2.Controls
            If (String.IsNullOrEmpty(item.Text)) Then
                check = True
            End If
        Next
        If check Then
            MsgBox("All fields are required! Please complete all information to proceed!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        Else
            Try
                _con = New SqlConnection(My.Settings.FMIDATAConnectionString)
                _cmd = New SqlCommand("ADDUSER", _con)
                _cmd.Parameters.AddWithValue("FullName", FullN.Text)
                _cmd.Parameters.AddWithValue("UserName", UserName.Text)
                _cmd.Parameters.AddWithValue("Password", Password.Text)
                _cmd.Parameters.AddWithValue("ResponseMessage", "OUTPUT")
                _cmd.CommandType = CommandType.StoredProcedure
                _con.Open()
                _cmd.ExecuteNonQuery()
                _con.Close()
                XtraMessageBox.Show("User Created")
                Dim st As String = "Created New User"
                LogFunc(mainfrm.BarStaticItem5.Caption, st)
            Catch ex As Exception
                XtraMessageBox.Show(ex.Message)
            End Try
        End If
        ManageUser_Load(sender, e)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If lstexistingusers.Text = "" Then
            MsgBox("Please select an existing user first!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        If lstexistingusers.Items.Count = 1 Then
            MsgBox("You cannot remove all users, one account must be left so that the software can be accessible", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Dim db As New FMIDATADataContext
        Dim selectedUser = From p In db.USERs
                           Where p.Full_Name = lstexistingusers.Text
                           Select p

        db.USERs.DeleteOnSubmit(selectedUser.FirstOrDefault)
        db.SubmitChanges()
        MsgBox("Selected User Successfully Removed!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        Dim st As String = "Deleted a User"
        LogFunc(mainfrm.BarStaticItem5.Caption, st)
        ManageUser_Load(sender, e)
        Exit Sub
    End Sub
End Class