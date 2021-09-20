Imports System.Data.SqlClient
Imports System.IO
Imports DevExpress.XtraEditors

Public Class InstituteDetail
    Dim _cmd As SqlCommand
    Dim _query As String
    Dim _con As SqlConnection
    ReadOnly _db As New FMIDATADataContext

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim isalready = From p In _db.InstituteInfos
                Select p Where p.Id = 1
        If isalready.Count <> 0 Then
            _query = "update instituteinfo set [Institute Name]=@IName,[principal Name]=@Pname,[Address]=@Addr,[Phone Number]=@Pno,[email]=@Email,[Logo]=@logo,[Reg No]=@reg,[Director Name]=@DName "
            'XtraMessageBox.Show("Already There")
        Else
            _query = "insert into instituteinfo([Institute Name],[principal Name],[Address],[Phone Number],[email],[Logo],[Reg No],[Director Name]) values(@IName,@Pname,@Addr,@Pno,@Email,@logo,@reg,@DName) "
        End If
        'Try
        _con = New SqlConnection(My.Settings.FMIDataConnectionString)
        _con.Open()

        _cmd = New SqlCommand(_query, _con)
        _cmd.Parameters.AddWithValue("IName", Institute_NameTextEdit.Text)
        _cmd.Parameters.AddWithValue("Pname", Principal_NameTextEdit.Text)
        _cmd.Parameters.AddWithValue("Addr", AddressTextEdit.Text)
        _cmd.Parameters.AddWithValue("Pno", Phone_NumberTextEdit.Text)
        _cmd.Parameters.AddWithValue("Email", EmailTextEdit.Text)
        _cmd.Parameters.AddWithValue("logo", My.Forms.StudentAdd.ImageToByte2(LogoPictureEdit.Image))
        _cmd.Parameters.AddWithValue("reg", Reg_NoTextEdit.Text)
        _cmd.Parameters.AddWithValue("DName", txtDName.Text)
        _cmd.ExecuteNonQuery()
        XtraMessageBox.Show("success")
        _con.Close()
        Dim st = "Updateded Institute Details"
        LogFunc(mainfrm.BarStaticItem5.Caption, st)
        'Catch ex As Exception
        'XtraMessageBox.Show("failed " & ex.Message)
        '  End Try
        Close()
    End Sub

    Private Sub InstituteDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim isalready = From p In _db.InstituteInfos
                Select p Where p.Id = 1
        If isalready.Count <> 0 Then
            Institute_NameTextEdit.Text = isalready.FirstOrDefault.Institute_Name
            AddressTextEdit.Text = isalready.FirstOrDefault.Address
            Principal_NameTextEdit.Text = isalready.FirstOrDefault.Principal_Name
            Reg_NoTextEdit.Text = isalready.FirstOrDefault.Reg_No
            Phone_NumberTextEdit.Text = isalready.FirstOrDefault.Phone_Number
            EmailTextEdit.Text = isalready.FirstOrDefault.Email
            txtDName.Text = isalready.FirstOrDefault.Director_Name
            _con = New SqlConnection(My.Settings.FMIDataConnectionString)
            _query = "Select Logo from InstituteInfo Where Id=1"
            _cmd = New SqlCommand(_query, _con)
            _con.Open()
            Dim arrayByte1 As Byte() = _cmd.ExecuteScalar()
            _con.Close()
            Dim logo As Image
            Dim ms1 = New MemoryStream(arrayByte1)
            logo = Image.FromStream(ms1)
            LogoPictureEdit.Image = logo
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Try
            ' OpenFileDialog1.ShowDialog()
            BGImage.LoadImage()
            If File.Exists(Application.StartupPath + "\BGIMAGE.jpg") Then
                File.Delete(Application.StartupPath + "\BGIMAGE.jpg")
            End If
            FileCopy(BGImage.GetLoadedImageLocation(), Application.StartupPath + "\BGIMAGE.jpg")
        Catch ex As Exception
            XtraMessageBox.Show("Failed !,Please Try Again")
        End Try

        ' MessageBox.Show(BGImage.GetLoadedImageLocation)
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Close()
    End Sub

    Private Sub SetImage_Click(sender As Object, e As EventArgs) Handles SetImage.Click
        LogoPictureEdit.LoadImage()
    End Sub
End Class