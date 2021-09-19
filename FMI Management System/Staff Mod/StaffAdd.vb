Imports System.Globalization
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors

Public Class StaffAdd
    ReadOnly _culture = CultureInfo.CreateSpecificCulture("en-IN")
    Dim _cmd As SqlCommand
    Dim _query As String
    Dim _con As SqlConnection


    Private Sub StaffAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Salary.Properties.Mask.Culture = _culture
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        If (ValueCheck() = False) Then
            XtraMessageBox.Show("Please Fill all Information")
        Else
            Try
                _con = New SqlConnection(My.Settings.FMIDATAConnectionString)
                _con.Open()
                _query = "insert into Staff([Name],[Father's Name],[Join Date],[Salary],[Designation],[Extra Notes],[Mobile],[image]) values(@Name,@fname,@JDate,@salary,@desig,@ENotes,@mobile,@image)"
                _cmd = New SqlCommand(_query, _con)
                _cmd.Parameters.AddWithValue("fname", FatherName.Text)
                _cmd.Parameters.AddWithValue("JDate", Jdate.Text)
                _cmd.Parameters.AddWithValue("salary", Salary.Text)
                _cmd.Parameters.AddWithValue("desig", Designation.Text)
                _cmd.Parameters.AddWithValue("ENotes", ENotes.Text)
                _cmd.Parameters.AddWithValue("Name", StaffName.Text)
                _cmd.Parameters.AddWithValue("image", My.Forms.StudentAdd.ImageToByte2(image.Image))
                _cmd.Parameters.AddWithValue("Mobile", Mobile.Text)
                _cmd.ExecuteNonQuery()
                XtraMessageBox.Show("success")
                _con.Close()
                Dim st As String = "Added New Staff"
                LogFunc(mainfrm.BarStaticItem5.Caption, st)
            Catch ex As Exception
                XtraMessageBox.Show("failed " & ex.Message)
            End Try
        End If
    End Sub
    Private Function ValueCheck() As Boolean
        Dim array As Object() = {StaffName, FatherName, Designation, Salary, Jdate}
        Dim flag As Boolean = False
        For Each item As Control In array
            If String.IsNullOrEmpty(item.Text) Then
                item.BackColor = Color.YellowGreen
                ' item.ForeColor = Color.White
                flag = True
                'item.Focus()

            Else
                item.BackColor = Color.White
            End If
        Next
        If flag = False Then
            Return True
        End If
        Return False

    End Function

    Private Sub SetImage_Click(sender As Object, e As EventArgs) Handles SetImage.Click
        OpenFileDialog1.ShowDialog()
        If DialogResult.OK Then
            image.ImageLocation = OpenFileDialog1.FileName
        Else

        End If
    End Sub

    Private Sub Designation_EditValueChanged(sender As Object, e As EventArgs) Handles Designation.EditValueChanged
        SimpleButton2.ToolTip = "Add " & Designation.Text
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Close()
    End Sub
End Class