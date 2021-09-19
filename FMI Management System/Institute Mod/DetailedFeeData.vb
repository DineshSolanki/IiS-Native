Imports System.Data.SqlClient
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider

Public Class DetailedFeeData
    ReadOnly _db As New FMIDATADataContext()
    Dim _mylist As IQueryable(Of Transact)

    Private Sub DetailedFeeData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rule As New ConditionValidationRule()
        Dim rule1 As New ConditionValidationRule()
        Dim rule2 As New ConditionValidationRule()
        Dim usersList = From p In _db.Students
                Select p Order By p.Name Ascending

        SnameCombo.Properties.Items.Clear()
        FnameCombo.Properties.Items.Clear()
        SrCombo.Properties.Items.Clear()
        If usersList.Count <> 0 Then
            For j = 1 To usersList.Count
                SnameCombo.Properties.Items.Add(usersList.ToList(j - 1).Name)
                FnameCombo.Properties.Items.Add(usersList.ToList(j - 1).FName)
                SrCombo.Properties.Items.Add(usersList.ToList(j - 1).SR_no)
                MnameCombo.Properties.Items.Add(usersList.ToList(j - 1).MName)
                rule.Values.Add(usersList.ToList(j - 1).Name)
                rule1.Values.Add(usersList.ToList(j - 1).FName)
                rule2.Values.Add(usersList.ToList(j - 1).SR_no)
            Next
        End If
        'setting validation rules
        rule.ConditionOperator = ConditionOperator.AnyOf
        rule.ErrorText = "No Student is Registered With This Name"
        rule.ErrorType = ErrorType.Information
        'rule1
        rule1.ConditionOperator = ConditionOperator.AnyOf
        rule1.ErrorText = "Record Not Found"
        rule1.ErrorType = ErrorType.Information
        'rule2
        rule1.ConditionOperator = ConditionOperator.AnyOf
        rule1.ErrorText = "Record Not Found"
        rule1.ErrorType = ErrorType.Information
        DxValidationProvider1.SetValidationRule(SnameCombo, rule)
        DxValidationProvider1.SetValidationRule(FnameCombo, rule1)
        DxValidationProvider1.SetValidationRule(SrCombo, rule2)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim sclass As String = Nothing
        If _
            SrCombo.Text = Nothing And SnameCombo.Text = Nothing And FnameCombo.Text = Nothing And
            MnameCombo.Text = Nothing Then
            XtraMessageBox.Show("Please Fill Either SR No. Or Student Name AND FATHER NAME AND MOTHER NAME",
                                "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        'con = New SqlConnection(My.Settings.FMIDATAConnectionString)
        'adapter.SelectCommand = New SqlCommand("Select * from Transact where [SR no]=@sr")
        'adapter.p.Parameters.AddWithValue("sr", SrCombo.Text)
        'Dim builder As SqlCommandBuilder = New SqlCommandBuilder(adapter)

        'con.Open()
        'Dim myTable As DataTable = New DataTable
        'adapter.Fill(myTable)
        'GridControl1.DataSource = myTable
        'con.Close()
        _mylist = From p In _db.Transacts
            Select p
            Where _
                p.SR_no = SrCombo.Text OrElse
                p.Student.Name = SnameCombo.Text And p.Student.FName = FnameCombo.Text AndAlso
                p.Student.MName = MnameCombo.Text
        GridControl1.DataSource = _mylist
        'Dim myTable As New DataTable
        ''GridView1.PopulateColumns()
        '' GridView1.RestoreLayoutFromXml("C:\Users\Hackeriya Balam\Desktop\ICONS\Myl.xml")
        'con = New SqlConnection(My.Settings.FMIDATAConnectionString)
        'query = "SELECT  Transact.* FROM FeeData,Students,FeeStructure,Transact where Transact.[SR no]=@srn AND Students.[SR no]=Transact.[SR no] OR Students.Name=@name AND Students.Fname=@fname AND Students.MName=@mname AND FeeStructure.Fees_Id=Transact.Fee_id"
        ''query = "SELECT  FeeData.Due,Students.Name,Students.Fname,FeeStructure.Class,Transact.* FROM FeeData,Students,FeeStructure,Transact where Transact.[SR no]=@srn AND Students.[SR no]=Transact.[SR no] OR Students.Name=@name AND Students.Fname=@fname AND Students.MName=@mname AND FeeStructure.Fees_Id=Transact.Fee_id"
        'cmd = New SqlCommand(query, con)
        'cmd.Parameters.AddWithValue("srn", SrCombo.Text)
        'cmd.Parameters.AddWithValue("name", SnameCombo.Text)
        'cmd.Parameters.AddWithValue("fname", FnameCombo.Text)
        'cmd.Parameters.AddWithValue("mname", MnameCombo.Text)
        'con.Open()
        'dr = cmd.ExecuteReader()
        ''While dr.Read
        ''    ' ListBoxControl1.Items.Add(dr(1).ToString & "  " & dr(4).ToString)
        ''End While
        'con.Close()

        'myTable.Load(dr)
        'GridControl1.DataSource = myTable
        'con.Close()
        'GridView1.RestoreLayoutFromXml("C:\Users\Hackeriya Balam\Desktop\ICONS\Myl.xml")
        con = New SqlConnection(My.Settings.FMIDATAConnectionString)
        query = "Select ProfilePic from Students where [SR no]=@srn OR Name=@name AND Fname=@fname AND MName=@mname"
        cmd = New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("srn", SrCombo.Text)
        cmd.Parameters.AddWithValue("name", SnameCombo.Text)
        cmd.Parameters.AddWithValue("fname", FnameCombo.Text)
        cmd.Parameters.AddWithValue("mname", MnameCombo.Text)
        con.Open()
        Dim arrayByte As Byte() = cmd.ExecuteScalar()
        con.Close()
        Dim propic As Image
        Dim ms = New MemoryStream(arrayByte)
        propic = Image.FromStream(ms)
        PictureEdit1.Image = propic

        Dim usersList = From p In _db.Students
                Select p
                Where _
                p.Name = SnameCombo.Text And p.FName = FnameCombo.Text And p.MName = MnameCombo.Text Or
                p.SR_no = SrCombo.Text
        If usersList.Count <> 0 Then
            For j = 1 To usersList.Count
                SnameText.Text = usersList.FirstOrDefault.Name
                FNameText.Text = usersList.FirstOrDefault.FName
                MnameText.Text = usersList.FirstOrDefault.MName
                sclass = usersList.FirstOrDefault.CurrentClass

            Next
        End If

        Dim feeDta = From p In _db.FeeStructures
                Select p Where p.Class = sclass
        If feeDta.Count <> 0 Then
            TotalFeeText.Text = feeDta.FirstOrDefault.Total_Fee
        End If
        Dim duedata = From p In _db.FeeDatas
                Select p
                Where _
                p.Fee_id = feeDta.FirstOrDefault.Fees_Id And p.SR_no = SrCombo.Text OrElse
                p.Student.Name = SnameCombo.Text And p.Student.FName = FnameCombo.Text AndAlso
                p.Student.MName = MnameCombo.Text
        Try
            If duedata.Count <> 0 Then
                DueText.Text = duedata.FirstOrDefault.Due_
                TotalPaidText.Text = duedata.FirstOrDefault.Paid
            End If
        Catch ex As Exception
            XtraMessageBox.Show("Please Check if Fee Data exist for " & SnameCombo.Text)
        End Try
    End Sub
    'Private Sub GETSR()
    '    con = New SqlConnection(My.Settings.FMIDATAConnectionString)
    '    query = "SELECT [SR no] from Students Where Name=@Sname AND Fname=@Fname"
    '    cmd = New SqlCommand(query, con)
    '    cmd.Parameters.AddWithValue("Sname", SnameCombo.Text)
    '    cmd.Parameters.AddWithValue("Fname", FnameCombo.Text)
    '    con.Open()
    '    dr = cmd.ExecuteReader()
    '    If dr.HasRows > 1 Then
    '        Dim frm As New MultiStu
    '        frm.ListBoxControl1.Items.Add(dr.r)
    '    End If
    '    con.Close()
    'End Sub

    Private Sub SnameCombo_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles SnameCombo.SelectedIndexChanged
        Dim ind As Integer
        ind = SnameCombo.SelectedIndex
        FnameCombo.SelectedIndex = ind
        MnameCombo.SelectedIndex = ind
        SrCombo.SelectedIndex = ind
    End Sub

    '    Using rsAs SqlDataReader = cmd.ExecuteReader()
    '    While rs.Read()
    '    Dim items As Object() = {r("CustomerID"), r("Company").ToString()}
    '        listBox1.Items.Add(items)
    '    End While
    '    listBox1.DisplayMember = "Company"
    '    listBox1.ValueMember = "CustomerID"
    'End Using

    Private Sub SrCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SrCombo.SelectedIndexChanged
        Dim ind As Integer
        ind = SrCombo.SelectedIndex
        SnameCombo.SelectedIndex = ind
        FnameCombo.SelectedIndex = ind
        MnameCombo.SelectedIndex = ind
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        If Not GridControl1.IsPrintingAvailable Then
            MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error")
            Return
        End If

        ' Opens the Preview window.
        GridControl1.ShowPrintPreview()
    End Sub
End Class