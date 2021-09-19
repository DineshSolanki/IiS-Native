Imports System.Data.SqlClient
Imports DevExpress.XtraEditors

Public Class Tc
    ReadOnly _db As New FMIDATADataContext

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        listView1.Items.Clear()
        Try
            con = New SqlConnection(My.Settings.FMIDATAConnectionString)
            con.Open()
            cmd =
                New SqlCommand(
                    "select [SR no],Name,status from Students where session=@ses AND currentClass=@class  order by Name",
                    con)
            cmd.Parameters.AddWithValue("ses", TextEdit1.Text)
            cmd.Parameters.AddWithValue("class", TextEdit2.Text)
            reader = cmd.ExecuteReader()
            While reader.Read()
                Dim item = New ListViewItem()
                item.Text = reader(0).ToString().Trim()
                item.SubItems.Add(reader(1).ToString().Trim())
                item.SubItems.Add(reader(2).ToString().Trim())
                listView1.Items.Add(item)
            End While
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If srcombo.Text = Nothing And Snamecombo.Text = Nothing And FnameCombo.Text = Nothing Then
            XtraMessageBox.Show("Please Fill Either SR No. Or Student Name AND FATHER NAME AND MOTHER NAME",
                                "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        listView1.Items.Clear()
        Try
            con = New SqlConnection(My.Settings.FMIDATAConnectionString)
            con.Open()
            cmd =
                New SqlCommand(
                    "select [SR no],Name,status from Students where [SR no]=@sr or Name=@name AND FName=@Fname order by Name",
                    con)
            cmd.Parameters.AddWithValue("sr", srcombo.Text)
            cmd.Parameters.AddWithValue("name", Snamecombo.Text)
            cmd.Parameters.AddWithValue("Fname", FnameCombo.Text)
            reader = cmd.ExecuteReader()
            While reader.Read()
                Dim item = New ListViewItem()
                item.Text = reader(0).ToString().Trim()
                item.SubItems.Add(reader(1).ToString().Trim())
                item.SubItems.Add(reader(2).ToString().Trim())
                listView1.Items.Add(item)
            End While
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim usersList = From p In _db.Students
                Select p Order By p.Name Ascending

        Snamecombo.Properties.Items.Clear()
        FnameCombo.Properties.Items.Clear()
        srcombo.Properties.Items.Clear()
        If usersList.Count <> 0 Then
            For j = 1 To usersList.Count
                Snamecombo.Properties.Items.Add(usersList.ToList(j - 1).Name)
                FnameCombo.Properties.Items.Add(usersList.ToList(j - 1).FName)
                srcombo.Properties.Items.Add(usersList.ToList(j - 1).SR_no)
            Next
        End If
    End Sub

    Private Sub srcombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles srcombo.SelectedIndexChanged
        Dim ind As Integer
        ind = srcombo.SelectedIndex
        Snamecombo.SelectedIndex = ind
        FnameCombo.SelectedIndex = ind
    End Sub

    Private Sub Snamecombo_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles Snamecombo.SelectedIndexChanged
        Dim ind As Integer
        ind = Snamecombo.SelectedIndex
        FnameCombo.SelectedIndex = ind
        srcombo.SelectedIndex = ind
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If txtReason.Text = Nothing Or txtTCNo.Text = Nothing Then
            XtraMessageBox.Show("Please Fill TC Number And Reason !")
            txtTCNo.Focus()
            Exit Sub
        End If
        con = New SqlConnection(My.Settings.FMIDATAConnectionString)
        Dim cd = "update students set status=@st,[TC No]=@tc,Reason=@Reason where [SR no]=@d2"
        cmd = New SqlCommand(cd)
        cmd.Parameters.AddWithValue("st", "InActive")
        cmd.Parameters.AddWithValue("tc", txtTCNo.Text)
        cmd.Parameters.AddWithValue("@d2", listView1.FocusedItem.SubItems(0).Text)
        cmd.Parameters.AddWithValue("Reason", txtReason.Text)
        cmd.Connection = con
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
End Class