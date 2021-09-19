Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Threading
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraReports.UI


Public Class Printrecipt
    ReadOnly _culture = CultureInfo.CreateSpecificCulture("en-IN")
    ReadOnly _db As New FMIDATADataContext()
    Dim _cmd As SqlCommand
    Dim _query As String
    Dim _con As SqlConnection
    Dim _sr As String = Nothing
    'Dim adapter As New SqlDataAdapter()
    Private Sub printrecipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Thread.CurrentThread.CurrentCulture = _culture
        FormatInfo.AlwaysUseThreadFormat = True
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
        Dim feesId As Integer
        If ValueCheck() = False Or ValueCheck2() = False Then
            XtraMessageBox.Show("Please Complete All Information !")
            Exit Sub
        Else
            _query =
                "Select Fees_Id from FeeStructure where FeeStructure.Class=(select class from students where Name=@name AND fname=@fname)"
            _con = New SqlConnection(My.Settings.FMIDATAConnectionString)
            _cmd = New SqlCommand(_query, _con)
            _cmd.Parameters.AddWithValue("name", SnameCombo.Text)
            _cmd.Parameters.AddWithValue("fname", FnameCombo.Text)
            _cmd.Parameters.AddWithValue("sr", SrCombo.Text)
            ' Try

            _con.Open()
            feesId = _cmd.ExecuteScalar()
            _con.Close()
            XtraMessageBox.Show("succes")
            ' Catch ex As Exception
            'MessageBox.Show(ex.Message)
            ' End Try
            _query =
                "update feeData set paid=@Deposit,[Date of Deposit]=@Date,Due=@Due,[Total Fee]=@tf where [SR No]=@Sr"
            _con = New SqlConnection(My.Settings.FMIDATAConnectionString)
            _cmd = New SqlCommand(_query, _con)
            _cmd.Parameters.AddWithValue("Deposit", TextEdit2.Text)
            _cmd.Parameters.AddWithValue("Date", DateTime.Now)
            _cmd.Parameters.AddWithValue("Due", LabelControl5.Text)
            _cmd.Parameters.AddWithValue("Sr", SrCombo.Text)
            _cmd.Parameters.AddWithValue("tf", LabelControl7.Text)
            'Try

            _con.Open()
            _cmd.ExecuteNonQuery()
            _con.Close()
            ' Catch ex As Exception
            'XtraMessageBox.Show(ex.Message)
            ' End Try
            _con = New SqlConnection(My.Settings.FMIDATAConnectionString)
            _query =
                "insert into Transact(DateOfDeposit,Fee_id,[SR no],AmountPaid,Depositor,Month) values(@Date,@FeeID,@SR,@Deposit,@Depositor,@Month)"
            _cmd = New SqlCommand(_query, _con)
            _cmd.Parameters.AddWithValue("Date", DateTime.Now)
            _cmd.Parameters.AddWithValue("FeeID", feesId)
            _cmd.Parameters.AddWithValue("SR", SrCombo.Text)
            _cmd.Parameters.AddWithValue("Deposit", TextEdit2.Text)
            _cmd.Parameters.AddWithValue("Depositor", TextEdit1.Text)
            _cmd.Parameters.AddWithValue("Month", DateTime.Now.Month)
            'Try

            _con.Open()
            _cmd.ExecuteReader()
            _con.Close()
            'MessageBox.Show("succes")
            '  Catch ex As Exception
            'MessageBox.Show(ex.Message)
            ' End Try
            Dim report As New XtraReport1()
            'Try
            report.Parameters("Stname").Value = SnameCombo.Text
            report.Parameters("FName").Value = FnameCombo.Text
            report.Parameters("Sr").Value = SrCombo.Text
            report.Parameters("Due").Value = LabelControl5.Text
            report.Parameters("Deposit").Value = TextEdit2.Text
            Dim st = "Invoked Fee Deposit Entery"
            LogFunc(mainfrm.BarStaticItem5.Caption, st)
            report.CreateDocument()
            Using printTool As New ReportPrintTool(report)
                printTool.ShowPreviewDialog()
            End Using
            Clear()
            ' Catch ex As Exception
            'XtraMessageBox.Show(ex.Message)
            '  End Try
            Exit Sub
        End If
    End Sub

    Private Sub TextEdit2_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit2.EditValueChanged
        DueF()
        'Dim db2 As New FMIDATADataContext
        'Dim Feeinfo = From p In db2.FeeDatas
        '                Select p Where p.SR_No
        'db.SubmitChanges()
        'If TextEdit2.Text = Nothing Then
        '    LabelControl5.Text = Nothing

        'End If
        'Try
        '    If Feeinfo.Count <> 0 And Not TextEdit2.Text = Nothing Then
        '        For j = 1 To Feeinfo.Count
        '            LabelControl5.Text = CStr(CDbl(Feeinfo.ToList(j - 1).Due_) - CDbl(TextEdit2.Text))
        '        Next

        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub

    Private Sub Clear()
        SrCombo.Text = Nothing
        SnameCombo.Text = Nothing
        FnameCombo.Text = Nothing
        TextEdit1.Text = Nothing
        TextEdit2.Text = Nothing
    End Sub

    Private Function ValueCheck() As Boolean
        Dim array As TextEdit() = {SrCombo, TextEdit1, TextEdit2}
        Dim flag = False
        For Each item As Control In array
            If String.IsNullOrEmpty(item.Text) Then
                'item.BackColor = Color.YellowGreen
                ' item.ForeColor = Color.White
                flag = True
                'item.Focus()

            Else
                flag = False
                ' item.BackColor = Color.White
            End If
        Next
        If flag = False Then
            Return True
        End If
        Return False
    End Function

    Private Function ValueCheck2() As Boolean
        Dim array As TextEdit() = {SnameCombo, FnameCombo, TextEdit1, TextEdit2}
        Dim flag = False
        For Each item As Control In array
            If String.IsNullOrEmpty(item.Text) Then
                'item.BackColor = Color.YellowGreen
                ' item.ForeColor = Color.White
                flag = True
                'item.Focus()

            Else
                flag = False
                ' item.BackColor = Color.White
            End If
        Next
        If flag = False Then
            Return True
        End If
        Return False
    End Function
    'Private Function ref()
    '    db.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues, Feeinfo)
    'End Function

    Private Sub DueF()
        LabelControl5.Text = "0"
        'Dim cls As String = Nothing
        If Not String.IsNullOrEmpty(TextEdit2.Text) Then
            Dim lastid As Integer
            Try
                _con = New SqlConnection(My.Settings.FMIDATAConnectionString)
                If Not String.IsNullOrEmpty(SrCombo.Text) Then
                    _query = "select Due from feeData where [SR No]=@sr"
                    _cmd = New SqlCommand(_query, _con)
                    _cmd.Parameters.AddWithValue("sr", SrCombo.Text)
                    _con.Open()
                    lastid = _cmd.ExecuteScalar() 'Connection close problem occuring here
                    _con.Close()
                ElseIf _
                    String.IsNullOrEmpty(SrCombo.Text) And
                    (Not String.IsNullOrEmpty(SnameCombo.Text) And Not String.IsNullOrEmpty(FnameCombo.Text)) Then
                    Dim stuinfo = From p In _db.Students
                            Select p Where p.FName = FnameCombo.Text And p.Name = SnameCombo.Text
                    If stuinfo.Count <> 0 Then
                        For j = 1 To stuinfo.Count
                            'LabelControl5.Text = CStr(CDbl(Feeinfo.ToList(j - 1).Due_) - CDbl(TextEdit2.Text))
                            _sr = CStr(stuinfo.ToList(j - 1).SR_no)
                            ' cls = CStr(stuinfo.ToList(j - 1).CurrentClass)
                        Next
                    End If
                    _query = "select Due from feeData where [SR no]=@sr"
                    _cmd = New SqlCommand(_query, _con)
                    _cmd.Parameters.AddWithValue("sr", _sr)
                End If
                _con.Open()
                lastid = _cmd.ExecuteScalar() 'Connection close problem occuring here
                _con.Close()
            Catch ex As Exception
                ' XtraMessageBox.Show(ex.Message)
            End Try
            LabelControl5.Text = CStr(CInt(lastid) - CInt(TextEdit2.Text))
        End If
    End Sub

    'Private Sub FnameCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FnameCombo.SelectedIndexChanged
    '    If Not String.IsNullOrEmpty(SnameCombo.Text) And Not String.IsNullOrEmpty(FnameCombo.Text) Then

    '    End If
    'End Sub
    Private Sub Totf()
        Dim feeinfo = From p In _db.FeeDatas
                Select p Where p.SR_no = CStr(SrCombo.Text)
        If feeinfo.Count <> 0 Then
            If feeinfo.FirstOrDefault.Student.CurrentClass = feeinfo.FirstOrDefault.Student.adClass Then
                For j = 1 To feeinfo.Count
                    LabelControl7.Text = feeinfo.ToList(j - 1).Total_Fee
                Next
            Else
                For j = 1 To feeinfo.Count
                    LabelControl7.Text = feeinfo.ToList(j - 1).Total_Fee -
                                         feeinfo.ToList(j - 1).FeeStructure.Admision_Fee
                Next
            End If

        End If
        'If Not String.IsNullOrEmpty(SrCombo.Text) Then
        '    Feeinfo = From p In db.FeeDatas
        '             Select p Where p.SR_no = SrCombo.Text
        '    Dim stuinfo = From p In db.Students
        '       Select p Where p.SR_no = SrCombo.Text
        '    If stuinfo.Count <> 0 Then 'And Not TextEdit2.Text = Nothing Then
        '        For j = 1 To stuinfo.Count
        '            SnameCombo.Text = CStr(stuinfo.ToList(j - 1).Name)
        '            FnameCombo.Text = CStr(stuinfo.ToList(j - 1).FName)
        '        Next
        '    End If
        'ElseIf String.IsNullOrEmpty(SrCombo.Text) And (Not String.IsNullOrEmpty(SnameCombo.Text) And Not String.IsNullOrEmpty(FnameCombo.Text)) Then
        'Dim stuinfo = From p In db.Students
        '            Select p Where p.FName = FnameCombo.Text And p.Name = SnameCombo.Text Or p.SR_no = SrCombo.Text
        'If stuinfo.Count <> 0 Then
        '    For j = 1 To stuinfo.Count
        '        'LabelControl5.Text = CStr(CDbl(Feeinfo.ToList(j - 1).Due_) - CDbl(TextEdit2.Text))
        '        sr = CStr(stuinfo.ToList(j - 1).SR_no)
        '    Next
        'End If
        'Feeinfo = From p In db.FeeDatas
        '        Select p Where p.SR_no = sr

        'Try
        '    If Feeinfo.Count <> 0 Then 'And Not TextEdit2.Text = Nothing Then
        '        For j = 1 To Feeinfo.Count
        '            'LabelControl5.Text = CStr(CDbl(Feeinfo.ToList(j - 1).Due_) - CDbl(TextEdit2.Text))
        '            LabelControl7.Text = CStr(Feeinfo.ToList(j - 1).Total_Fee)
        '        Next

        '    End If

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
        'End If
    End Sub

    Private Sub FnameCombo_SelectedIndexChanged_1(sender As Object, e As EventArgs) _
        Handles FnameCombo.SelectedIndexChanged
        If Not String.IsNullOrEmpty(SnameCombo.Text) Then
            DueF()
            totf()
        End If
    End Sub

    Private Sub SrCombo_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles SrCombo.SelectedIndexChanged
        Dim ind As Integer
        ind = SrCombo.SelectedIndex
        SnameCombo.SelectedIndex = ind
        FnameCombo.SelectedIndex = ind
        totf()
    End Sub

    Private Sub SnameCombo_SelectedIndexChanged_1(sender As Object, e As EventArgs) _
        Handles SnameCombo.SelectedIndexChanged
        If Not String.IsNullOrEmpty(FnameCombo.Text) Then
            DueF()
            totf()
        End If
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Close()
    End Sub
End Class