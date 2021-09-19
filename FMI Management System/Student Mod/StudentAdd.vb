Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.Globalization
Imports System.IO
Imports DevExpress.XtraEditors

Public Class StudentAdd
    Inherits XtraForm
    ReadOnly _culture = CultureInfo.CreateSpecificCulture("hi-IN")
    ReadOnly _db As New FMIDATADataContext

    Public Function ImageToByte2(img As Image) As Byte()
        Dim byteArray = New Byte() {}
        Try

            Using stream As New MemoryStream()
                img.Save(stream, ImageFormat.Png)
                stream.Close()
                byteArray = stream.ToArray()
            End Using
        Catch ex As Exception
            XtraMessageBox.Show("Picture Can't Be Empty")
        End Try

        Return byteArray
    End Function

    Private Sub Students_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Fmi_DataDataSet1.FeeData' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'Fmi_DataDataSet1.Students' table. You can move, or remove it, as needed.
        intFPay.Properties.Mask.Culture = _culture
        intMPay.Properties.Mask.Culture = _culture

        Last()
        '//Shows CustomValidationRule USe
        'Dim customValidationRule As New CustomValidationRule()
        'customValidationRule.ErrorText = "Enter a Valid Rule"
        'DxValidationProvider1.SetValidationRule(txtSRNo, customValidationRule)
        '//Custom validation End

        Bounds = Screen.GetWorkingArea(Me)
        'Label16.BringToFront()
        'Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
        'Me.WindowState = FormWindowState.Maximized
        'Me.MaximumSize = Me.Size
        'Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Panel7.AutoScroll = True
        MaximizeBox = False
        DateAdm.Text = Date.Now.ToString("dd/MM/yyyy")
        con = New SqlConnection(My.Settings.FMIDATAConnectionString)
        LoadSessions()
        query = "Select Session from Sessions where Id=(select max(Id) from Sessions) "
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        cmd = New SqlCommand(query, con)
        Dim session As String = cmd.ExecuteScalar
        con.Close()
        yearSession.Text = session 'Date.Now.ToString("yyyy") & "-" & Date.Now.ToString("yyyy") + 1
    End Sub

    Private Sub LoadSessions()
        Dim list = From p In _db.Sessions
                Select p
        If list.Count <> 0 Then
            For j = 1 To list.Count
                yearSession.Properties.Items.Add(list.ToList(j - 1).Session)
            Next

        End If
    End Sub

    Private Sub SetImage_Click(sender As Object, e As EventArgs) Handles SetImage.Click
        'OpenFileDialog1.ShowDialog()
        'If Windows.Forms.DialogResult.OK Then
        '    ProfilePic.ImageLocation = OpenFileDialog1.FileName
        ProfilePic.LoadImage()
        'Else
        'Exit Sub
        'End If
    End Sub

    Private Sub DOB_EditValueChanged(sender As Object, e As EventArgs) Handles DOB.EditValueChanged
        Dim d1 As Date
        Dim d2 As Date
        d2 = Now
        d1 = DOB.DateTime
        intAge.Text = DateDiff(DateInterval.Year, d1, d2)
        'Dim age As Integer = Today.Year - DateTimePicker1.Value.Year
        'If (DateTimePicker1.Value > Today.AddYears(-age)) Then
        '    age -= 1
        '    Label12.Text = age
        'End If
        'Label12.Text = Date.Now.ToString("yyyy") - DateTimePicker1.Value.ToString("yyyy")
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        'Dim db As New Fmi_DataDataSet1
        'Dim select=From p In db.Students Where p.Id=
        If (ValueCheck() = False Or Checksr() = False Or IsAlready() = False) Then
            If Not ValueCheck() Then
                XtraMessageBox.Show("please fill all fields marked with *")
                Exit Sub
            ElseIf Not Checksr() Then
                XtraMessageBox.Show("SR no. Already Registered")
                txtSRNo.Text = ""
                txtSRNo.Focus()
                Exit Sub
            ElseIf Not IsAlready() Then
                XtraMessageBox.Show("Possibly Duplicate of Student Named " & txtStuName.Text & "Father Name:" & txtFName.Text)
                Exit Sub
            End If

            'ElseIf NameCheck() = False Then
            '    MessageBox.Show("Please Enter at least one Name From Father,Mother or Gurdian")
        Else
            query = "Select fees_id from FeeStructure where Class=@Class"
            cmd = New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("Class", txtAddClass.Text)
            con.Open()
            Dim feeid As Integer = cmd.ExecuteScalar()
            query = "Select [Total Fee] from FeeStructure where Class=@Class"
            cmd = New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("Class", txtAddClass.Text)
            Dim fee As String = Nothing
            Try
                fee = cmd.ExecuteScalar()
                con.Close()
            Catch ex As Exception
                XtraMessageBox.Show(ex.Message)
            End Try
            If Not fee = Nothing Then
                query = "insert into Students([Name],[FName],[MName],[DOB],[Cast],[Subcast],[Religion],[SR no],[SNo],[Fno],[MNo],[PreClass],[adClass],[Address],[Gaddress],[GNo],[PreSchool],[GName],[ProfilePic],[Section],[Session],[DOA],[Medium],[Bplace],[Gender],[BGroup],[HStay],[Handicap],[Mproblem],[Fpay],[FDesig],[MPay],[MDesig],[Board1],[RollNo1],[Year1],[BName1],[Grade1],[per1],[Board2],[RollNo2],[Year2],[BName2],[Grade2],[per2],[Sib1],[Class1],[Sib2],[Class2],[Sib3],[Class3],[Sib4],[Class4],[CurrentClass],status) values(@Name,@FName,@MName,@DOB,@Cast,@Subcast,@Religion,@SRNo,@SNo,@Fno,@MNo,@PreClass,@adClass,@Address,@Gaddress,@GNo,@PreSchool,@GName,@image,@Section,@session,@DOA,@Medium,@Bplace,@Gender,@BGroup,@HStay,@Handicap,@Mproblem,@Fpay,@FDesig,@MPay,@MDesig,@Board1,@RollNo1,@Year1,@BName1,@Grade1,@per1,@Board2,@RollNo2,@Year2,@BName2,@Grade2,@per2,@Sib1,@Class1,@Sib2,@Class2,@Sib3,@Class3,@Sib4,@Class4,@CurrentClass,@status)"
                cmd = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("Name", txtStuName.Text)
                cmd.Parameters.AddWithValue("FName", txtFName.Text)
                cmd.Parameters.AddWithValue("MName", txtMName.Text)
                cmd.Parameters.AddWithValue("DOB", DOB.Text)
                cmd.Parameters.AddWithValue("Cast", txtCast.Text)
                cmd.Parameters.AddWithValue("Subcast", txtSCast.Text)
                cmd.Parameters.AddWithValue("Religion", txtRelg.Text)
                cmd.Parameters.AddWithValue("SRNo", txtSRNo.Text)
                cmd.Parameters.AddWithValue("SNo", intMNo.Text)
                cmd.Parameters.AddWithValue("Fno", intFMNo.Text)
                cmd.Parameters.AddWithValue("MNo", intMMNo.Text)
                cmd.Parameters.AddWithValue("PreClass", PreClass.Text)
                cmd.Parameters.AddWithValue("adClass", txtAddClass.Text)
                cmd.Parameters.AddWithValue("Address", txtAddr.Text)
                cmd.Parameters.AddWithValue("Gaddress", txtGAddr.Text)
                cmd.Parameters.AddWithValue("GNo", intGMNo.Text)
                cmd.Parameters.AddWithValue("PreSchool", PreSchool.Text)
                cmd.Parameters.AddWithValue("GName", txtGName.Text)
                cmd.Parameters.AddWithValue("image", ImageToByte2(ProfilePic.Image))
                cmd.Parameters.AddWithValue("Section", txtSection.Text)
                cmd.Parameters.AddWithValue("Session", yearSession.Text)
                cmd.Parameters.AddWithValue("DOA", DateAdm.Text)
                cmd.Parameters.AddWithValue("Medium", txtMedium.Text)
                cmd.Parameters.AddWithValue("Bplace", txtBPlace.Text)
                cmd.Parameters.AddWithValue("Gender", txtGender.Text)
                cmd.Parameters.AddWithValue("BGroup", txtBGroup.Text)
                cmd.Parameters.AddWithValue("HStay", txtHStay.Text)
                cmd.Parameters.AddWithValue("Handicap", txtHandicap.Text)
                cmd.Parameters.AddWithValue("Mproblem", txtMProb.Text)
                cmd.Parameters.AddWithValue("Fpay", intFPay.Text)
                cmd.Parameters.AddWithValue("FDesig", txtFDesg.Text)
                cmd.Parameters.AddWithValue("MPay", intMPay.Text)
                cmd.Parameters.AddWithValue("MDesig", txtMDesg.Text)
                cmd.Parameters.AddWithValue("Board1", Board1.Text)
                cmd.Parameters.AddWithValue("RollNo1", RollNo1.Text)
                cmd.Parameters.AddWithValue("Year1", Year1.Text)
                cmd.Parameters.AddWithValue("BName1", BName1.Text)
                cmd.Parameters.AddWithValue("Grade1", Grade1.Text)
                cmd.Parameters.AddWithValue("per1", per1.Text)
                cmd.Parameters.AddWithValue("Board2", Board2.Text)
                cmd.Parameters.AddWithValue("RollNo2", RollNo2.Text)
                cmd.Parameters.AddWithValue("Year2", Year2.Text)
                cmd.Parameters.AddWithValue("BName2", BName2.Text)
                cmd.Parameters.AddWithValue("Grade2", Grade2.Text)
                cmd.Parameters.AddWithValue("per2", per2.Text)
                cmd.Parameters.AddWithValue("Sib1", Sib1.Text)
                cmd.Parameters.AddWithValue("Class1", Class1.Text)
                cmd.Parameters.AddWithValue("Sib2", Sib2.Text)
                cmd.Parameters.AddWithValue("Class2", Class2.Text)
                cmd.Parameters.AddWithValue("Sib3", Sib3.Text)
                cmd.Parameters.AddWithValue("Class3", Class3.Text)
                cmd.Parameters.AddWithValue("Sib4", Sib4.Text)
                cmd.Parameters.AddWithValue("Class4", class4.Text)
                cmd.Parameters.AddWithValue("CurrentClass", txtAddClass.Text)
                cmd.Parameters.AddWithValue("status", "Active")
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                query = "insert into FeeData([Total Fee],Due,Fee_id,[SR no])values (@totalFee,@Due,@Fee_id,@Stu_Id)"
                cmd = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("totalFee", fee)
                cmd.Parameters.AddWithValue("Due", fee)
                cmd.Parameters.AddWithValue("Fee_id", feeid)
                cmd.Parameters.AddWithValue("Stu_Id", txtSRNo.Text)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

                XtraMessageBox.Show("Student Successfully Registered")
                Dim st = "Registered New Student"
                LogFunc(mainfrm.BarStaticItem5.Caption, st)
                Last()
                'Feee
                ' Try
            Else
                XtraMessageBox.Show("please Make sure Fee Structure Exist For Class " & txtAddClass.Text)
            End If

            'Catch ex As Exception
            '  MessageBox.Show(ex.Message)
            ' End Try

        End If
        'For Each item As Control In Panel4.Controls
        '    If String.IsNullOrEmpty(item.Text) Then
        '        MsgBox("Please fill All values Marked with *")
        '        item.Focus()
        '        Exit Sub
        '    End If
        'Next
        '---------------------------------------------------------------------------
    End Sub

    Private Function ValueCheck() As Boolean
        Dim array As TextEdit() = {txtSRNo, txtAddClass, txtFName, txtMName, txtGName, yearSession, intFMNo, DateAdm, txtStuName, DOB, txtRelg, txtGender, txtAddr}
        Dim flag = False
        For Each item As Control In array
            If String.IsNullOrEmpty(item.Text) Then
                item.BackColor = Color.YellowGreen
                ' item.ForeColor = Color.White
                flag = True
                'item.Focus()

            Else
                item.BackColor = Color.Transparent
            End If
        Next
        If flag = False Then
            Return True
        End If
        Return False
    End Function
    'Private Function NameCheck() As Boolean
    '    If (String.IsNullOrEmpty(txtFName.Text) And String.IsNullOrEmpty(txtMName.Text)) Then
    '        Return False
    '        Exit Function
    '    End If
    '    Return True
    'End Function

    Private Sub Last()
        Dim lastid As Integer
        Try
            con = New SqlConnection(My.Settings.FMIDATAConnectionString)
            query = "select count(Student_ID) from Students "
            cmd = New SqlCommand(query, con)
            con.Open()
            lastid = cmd.ExecuteScalar()
            con.Close()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
        Label6.Text = lastid
    End Sub

    Private Function Checksr() As Boolean
        Try
            con.Open()
            query = "select count([SR no]) from Students where [SR no]=@sr"
            cmd = New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("sr", txtSRNo.Text)
            Dim exists As Integer = cmd.ExecuteScalar().ToString
            con.Close()
            If exists > 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
        Return False
    End Function

    Private Function IsAlready() As Boolean
        Try
            con.Open()
            query = "select count([SR no]) from Students where [SR no]=@sr or Name=@name AND Fname=@fname AND Mname=@mname AND DOB=@dob"
            cmd = New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("sr", txtSRNo.Text)
            cmd.Parameters.AddWithValue("name", txtStuName.Text)
            cmd.Parameters.AddWithValue("fname", txtFName.Text)
            cmd.Parameters.AddWithValue("mname", txtMName.Text)
            cmd.Parameters.AddWithValue("dob", DOB.Text)
            Dim exists As Integer = cmd.ExecuteScalar().ToString
            con.Close()
            If exists > 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
        Return False
    End Function

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim k As New WebCam
        k.ShowDialog()
        If TempFileNames2.Length > 0 Then

            ProfilePic.Image = Image.FromFile(TempFileNames2)
        End If
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Close()
    End Sub

    Private Sub txtAddClass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtAddClass.SelectedIndexChanged
        Dim lastSrPrimary As String = Nothing
        Dim lastSrSecondary As String = Nothing
        Try
            con = New SqlConnection(My.Settings.FMIDATAConnectionString)
            query = "select [SR no] from Students where [student_id]=(select max(student_id) from students) AND [SR no] Like @likep"
            cmd = New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("likep", "P%")
            con.Open()
            lastSrPrimary = cmd.ExecuteScalar()
            con.Close()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
        Try
            con = New SqlConnection(My.Settings.FMIDATAConnectionString)
            query = "select [SR no] from Students where [student_id]=(select max(student_id) from students) AND [SR no] Like @like"
            cmd = New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("like", "S%")
            con.Open()
            lastSrSecondary = cmd.ExecuteScalar()
            con.Close()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
        Dim resp As String = Nothing
        If Not lastSrPrimary = Nothing Then

            For Each c As Char In lastSrPrimary
                If IsNumeric(c) Then
                    resp = resp & c
                End If

            Next
            If txtAddClass.Text.Contains("Playgroup") OrElse txtAddClass.Text.Contains("Nursury") OrElse txtAddClass.Text.Contains("KG") OrElse txtAddClass.Text.Contains("PREP") OrElse txtAddClass.Text.ToString <= 5 Then
                txtSRNo.Text = "P" & CInt(resp) + 1
                Exit Sub
            End If
        Else
            If txtAddClass.Text.Contains("Playgroup") OrElse txtAddClass.Text.Contains("Nursury") OrElse txtAddClass.Text.Contains("KG") OrElse txtAddClass.Text.Contains("PREP") OrElse txtAddClass.Text.ToString <= 5 Then
                ' ReSharper disable once LocalizableElement
                txtSRNo.Text = "P1"
                Exit Sub
            End If
        End If
       
        If Not lastSrSecondary = Nothing Then
            Dim resS As String = Nothing
            For Each c As Char In lastSrSecondary
                If IsNumeric(c) Then
                    resS = resS & c
                End If
            Next
            If txtAddClass.Text > 5 AndAlso txtAddClass.Text <= 12 Then
                txtSRNo.Text = "S" & CInt(resS + 1)
            End If
        Else
            If Not txtAddClass.Text.Contains("Playgroup") OrElse Not txtAddClass.Text.Contains("Nursury") OrElse Not txtAddClass.Text.Contains("KG") OrElse Not txtAddClass.Text.Contains("PREP") OrElse txtAddClass.Text > 5 AndAlso txtAddClass.Text <= 12 Then
                txtSRNo.Text = "S1"
            End If
        End If
        'If lastSrPrimary = Nothing Or lastSrSecondary = Nothing Then
        '    If lastSrPrimary = Nothing Then

        '    End If
        '    If lastSrSecondary = Nothing Then

        '    End If

        'End If
    End Sub
End Class

'Custom Validation Rule Region 
'Public Class CustomValidationRule
'    Inherits ValidationRule

'Public Overrides Function Validate(ByVal control As Control, ByVal value As Object) As Boolean
'    Dim str As String = CStr(value)
'    Dim values() As String = {"Dr.", "Mr.", "Mrs.", "Miss", "Ms."}
'    Dim res As Boolean = False
'    For Each val As String In values
'        If ValidationHelper.Validate(str, ConditionOperator.BeginsWith, val, Nothing, Nothing, False) Then
'            Dim name As String = str.Substring(val.Length)
'            If name.Trim().Length > 0 Then
'                res = True
'            End If
'        End If
'    Next val
'    Return res
'End Function


'End Class