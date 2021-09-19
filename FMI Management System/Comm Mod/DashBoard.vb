Imports System.Data.SqlClient
Imports System.IO

Public Class DashBoard
    ReadOnly _db As New FMIDATADataContext

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        BackgroundImage = Nothing
        Dim frmins As New InstituteDetail
        frmins.ShowDialog()
        DashBoard_Load(sender, e)
    End Sub

    Private Sub DashBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection(My.Settings.FMIDATAConnectionString)
        query = "Select * from InstituteInfo Where Id=1"
        cmd = New SqlCommand(query, con)
        con.Open()
        If cmd.ExecuteScalar() <> 0 Then
            con.Close()
            con = New SqlConnection(My.Settings.FMIDATAConnectionString)
            query = "Select Logo from InstituteInfo Where Id=1"
            cmd = New SqlCommand(query, con)
            con.Open()
            Dim arrayByte1 As Byte() = cmd.ExecuteScalar()
            con.Close()
            Dim logo As Image
            Dim ms1 = New MemoryStream(arrayByte1)
            logo = Image.FromStream(ms1)
            PictureEdit1.Image = logo
        End If
        If File.Exists(Application.StartupPath + "\BGIMAGE.jpg") Then
            BackgroundImage = Image.FromFile(Application.StartupPath + "\BGIMAGE.jpg")
            BackgroundImageLayout = ImageLayout.Stretch
        End If
        Dim isalready = From p In _db.InstituteInfos
                Select p Where p.Id = 1
        If isalready.Count <> 0 Then
            SchoolName.Text = isalready.FirstOrDefault.Institute_Name
        End If
        Dim totalStudents = From p In _db.Students
                Select p
        Totalstu.Text = totalStudents.Count
        Dim nursury = From p In _db.Students
                Where p.CurrentClass = "Nursury"
        If nursury.Count <> 0 Then
            NururyCount.Text = nursury.Count
        End If
        ' ReSharper disable once InconsistentNaming
        Dim KG = From p In _db.Students
                Where p.CurrentClass = "KG"
        If KG.Count <> 0 Then
            KGCount.Text = KG.Count
        End If
        Dim prep = From p In _db.Students
                Where p.CurrentClass = "PREP"
        If prep.Count <> 0 Then
            PrepCount.Text = prep.Count
        End If
        ' ReSharper disable once InconsistentNaming
        Dim Ist = From p In _db.Students
                Where p.CurrentClass = "1"
        If Ist.Count <> 0 Then
            IstCount.Text = Ist.Count
        End If
        ' ReSharper disable once InconsistentNaming
        Dim IInd = From p In _db.Students
                Where p.CurrentClass = "2"
        If IInd.Count <> 0 Then
            IIndCount.Text = IInd.Count
        End If
        Dim third = From p In _db.Students
                Where p.CurrentClass = "3"
        If third.Count <> 0 Then
            ThirdCount.Text = third.Count
        End If
        Dim fourth = From p In _db.Students
                Where p.CurrentClass = "4"
        If fourth.Count <> 0 Then
            FourthCount.Text = fourth.Count
        End If
        Dim fifth = From p In _db.Students
                Where p.CurrentClass = "5"
        If fifth.Count <> 0 Then
            FifthCount.Text = fifth.Count
        End If
        Dim six = From p In _db.Students
                Where p.CurrentClass = "6"
        If six.Count <> 0 Then
            SixthCount.Text = six.Count
        End If
        Dim seven = From p In _db.Students
                Where p.CurrentClass = "7"
        If seven.Count <> 0 Then
            SevnthCount.Text = seven.Count
        End If
        Dim eigth = From p In _db.Students
                Where p.CurrentClass = "8"
        If eigth.Count <> 0 Then
            EigthCount.Text = eigth.Count
        End If
        Dim nine = From p In _db.Students
                Where p.CurrentClass = "9"
        If nine.Count <> 0 Then
            NineCount.Text = nine.Count
        End If
        Dim ten = From p In _db.Students
                Where p.CurrentClass = "10"
        If ten.Count <> 0 Then
            TenthCount.Text = ten.Count
        End If

        Dim eleven = From p In _db.Students
                Where p.CurrentClass = "11"
        If eleven.Count <> 0 Then
            elevencount.Text = eleven.Count
        End If
        Dim twel = From p In _db.Students
                Where p.CurrentClass = "12"
        If twel.Count <> 0 Then
            twelcount.Text = twel.Count
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim frm As New FeeStruct
        frm.ShowDialog()
        DashBoard_Load(sender, e)
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim frm As New SessionEntry
        frm.ShowDialog()
        DashBoard_Load(sender, e)
    End Sub
End Class