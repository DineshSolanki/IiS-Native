Imports System.Data.SqlClient
Imports DevExpress.XtraEditors

Public Class SessionEntry
    ReadOnly _db As New FMIDATADataContext
    Private Sub SessionEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextEdit1.Text = Date.Now.ToString("yyyy") & "-" & Date.Now.ToString("yyyy") + 1
        LoadSessions()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If TextEdit1.Text = Nothing Or TextEdit1.Text = "    -    " Then
            XtraMessageBox.Show("Please Enter A Value For Session")
            Exit Sub
        End If
        con = New SqlConnection(My.Settings.FMIDATAConnectionString)
        query = "Insert into Sessions(Session) values(@session)"
        cmd = New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("session", TextEdit1.Text)
        Try
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            XtraMessageBox.Show("Session Already Exist!")
        End Try
        Dim st As String = "Created New Session"
        LogFunc(mainfrm.BarStaticItem5.Caption, st)
        LoadSessions()
    End Sub
    Private Sub LoadSessions()
        ListBoxControl1.Items.Clear()
        Dim list = From p In _db.Sessions
                   Select p
        If list.Count <> 0 Then
            For j = 1 To list.Count
                ListBoxControl1.Items.Add(list.ToList(j - 1).Session)
            Next

        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If ListBoxControl1.Text = "" Then
            MsgBox("Please select a Existing Session First!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        con = New SqlConnection(My.Settings.FMIDATAConnectionString)
        query = "Select Session from students where Session=@d1"
        cmd = New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("d1", ListBoxControl1.Text)
        con.Open()
        reader = cmd.ExecuteReader()

        If reader.Read Then
            XtraMessageBox.Show("Unable to delete..Already in use in Student Entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If Not reader Is Nothing Then
                reader.Close()
            End If
            con.Close()
            Exit Sub

        End If
        Dim selectedUser = From p In _db.Sessions
                          Where p.Session = ListBoxControl1.Text
                          Select p

        _db.Sessions.DeleteOnSubmit(selectedUser.FirstOrDefault)
        _db.SubmitChanges()
        MsgBox("Selected session Successfully Removed!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        SessionEntry_Load(sender, e)
        Exit Sub
    End Sub
End Class