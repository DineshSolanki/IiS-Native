Imports System.Data.SqlClient
Imports DevExpress.XtraEditors

Public Class PromoteStu
    Dim _db As New FMIDATADataContext
    Public Rdr As SqlDataReader = Nothing
    Private Sub PromoteStu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listView1.Items.Clear()
        Dim session = From p In _db.Students
                       Select p Order By p.Name Ascending Distinct
        If Session.Count <> 0 Then
            For j = 1 To Session.Count
                'TextEdit1.Properties.Items.Add(Session.ToList(j - 1).Session)
                TextEdit2.Properties.Items.Add(Session.ToList(j - 1).CurrentClass)
            Next
        End If
        Dim list = From p In _db.Sessions
                  Select p

        If list.Count <> 0 Then
            For j = 1 To list.Count
                TextEdit4.Properties.Items.Add(list.ToList(j - 1).Session)
                TextEdit1.Properties.Items.Add(list.ToList(j - 1).Session)
            Next
        End If
        Dim classes = From p In _db.FeeStructures
                   Select p
        If classes.Count <> 0 Then
            For j = 1 To list.Count
                ComboBoxEdit1.Properties.Items.Add(classes.ToList(j - 1).Class)
            Next
        End If
    End Sub

    Private Sub CheckButton2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckButton2.CheckedChanged
        If CheckButton2.Checked = True Then
            For Each i As ListViewItem In listView1.Items
                i.Checked = True
            Next
        Else

            For Each i As ListViewItem In listView1.Items
                i.Checked = False
            Next
        End If
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        listView1.Items.Clear()
        Try
            con = New SqlConnection(My.Settings.FMIDATAConnectionString)
            con.Open()
            cmd = New SqlCommand("select [SR no],Name from Students where session=@ses AND currentClass=@class  order by Name", con)
            cmd.Parameters.AddWithValue("ses", TextEdit1.Text)
            cmd.Parameters.AddWithValue("class", TextEdit2.Text)
            rdr = cmd.ExecuteReader()
            While rdr.Read()
                Dim item = New ListViewItem()
                item.Text = rdr(0).ToString().Trim()
                item.SubItems.Add(rdr(1).ToString().Trim())
                listView1.Items.Add(item)
            End While
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim nextsr As String = GenerateSr(ComboBoxEdit1.Text)
        Dim flag As Boolean = False
        For Each i As ListViewItem In listView1.Items
            If i.Checked = True Then
                flag = True
                con = New SqlConnection(My.Settings.FMIDATAConnectionString)
                Dim cd As String = "update students set Session=@d1,currentClass=@d3,[SR no]=@d4 where [SR no]=@d2"
                cmd = New SqlCommand(cd)
                cmd.Parameters.AddWithValue("@d1", TextEdit4.Text)
                cmd.Parameters.AddWithValue("@d2", i.SubItems(0).Text)
                cmd.Parameters.AddWithValue("@d3", ComboBoxEdit1.Text)
                cmd.Parameters.AddWithValue("@d4", nextsr)
                cmd.Connection = con
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End If

        Next
        If flag Then
            Dim st As String = "Transfered Students"
            LogFunc(mainfrm.BarStaticItem5.Caption, st)
            XtraMessageBox.Show("Success", "Transfered")
        End If

    End Sub
    Public Sub UpdateFeeData()
        con = New SqlConnection(My.Settings.FMIDATAConnectionString)
        query = "Select fees_id from FeeStructure where Class=@Class"
        cmd = New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("Class", ComboBoxEdit1.Text)
        con.Open()
        Dim feeid As Integer = cmd.ExecuteScalar()
        query = "Select [Fee] from FeeStructure where Class=@Class"
        cmd = New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("Class", ComboBoxEdit1.Text)
        Dim fee As Integer = cmd.ExecuteScalar()
        con.Close()
        query = "update FeeData set [Total Fee]=@totalFee, Due=@Due,Fee_id=@Fee_id,[SR no]=@Stu_Id)"
        cmd = New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("totalFee", fee)
        cmd.Parameters.AddWithValue("Due", fee)
        cmd.Parameters.AddWithValue("Fee_id", feeid)
        cmd.Parameters.AddWithValue("Stu_Id", GenerateSR(ComboBoxEdit1.Text))
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
End Class