Imports System.Data.SqlClient
Imports System.Text

Imports DevExpress.XtraBars.Docking2010.Customization
Imports DevExpress.XtraBars.Docking2010.Views.WindowsUI
Imports DevExpress.XtraEditors
Imports System.Reflection

Module ModFunc
    Public Function Encrypt(password As String) As String
        Dim strmsg As String = String.Empty
        Dim encode As Byte() = New Byte(password.Length - 1) {}
        encode = Encoding.UTF8.GetBytes(password)
        strmsg = Convert.ToBase64String(encode)
        Return strmsg
    End Function
    Sub LogFunc(ByVal st1 As String, ByVal st2 As String)
        con = New SqlConnection(My.Settings.FMIDataConnectionString)
        con.Open()
        Dim cb As String = "insert into Logs(UserID,Date,Operation) VALUES (@d1,@d2,@d3)"
        cmd = New SqlCommand(cb)
        cmd.Connection = con
        cmd.Parameters.AddWithValue("@d1", st1)
        cmd.Parameters.AddWithValue("@d2", DateTime.Now)
        cmd.Parameters.AddWithValue("@d3", st2)
        cmd.ExecuteReader()
        con.Close()
    End Sub
    Function ExitConfirm(form As DevExpress.XtraEditors.XtraForm) As Boolean

        Dim action As New DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutAction() With {.Caption = "Confirm", .Description = "Close the application?"}
        Dim command1 As New FlyoutCommand() With {.Text = "Close", .Result = System.Windows.Forms.DialogResult.Yes}
        Dim command2 As New DevExpress.XtraBars.Docking2010.Views.WindowsUI.FlyoutCommand() With {.Text = "Cancel", .Result = System.Windows.Forms.DialogResult.No}
        action.Commands.Add(command1)
        action.Commands.Add(command2)
        Dim properties As New FlyoutProperties()
        properties.ButtonSize = New Size(100, 40)
        properties.Style = FlyoutStyle.MessageBox
        If FlyoutDialog.Show(form, action, properties) = System.Windows.Forms.DialogResult.Yes Then
            Return False
        Else
            Return True
        End If
    End Function

    'Public Sub Main()


    '    Application.EnableVisualStyles()
    '    Application.SetCompatibleTextRenderingDefault(False)
    '    DevExpress.UserSkins.BonusSkins.Register()
    '    Application.EnableVisualStyles()
    '    DevExpress.Skins.SkinManager.EnableMdiFormSkins()
    '    DevExpress.Skins.SkinManager.EnableFormSkins()
    '    UserLookAndFeel.Default.SetSkinStyle(My.Settings.Theme)
    '    ' UserLookAndFeel.Default.SkinName = My.Settings.Theme
    '    'UserLookAndFeel.Default.SetSkinStyle("Caramel")
    '    DevExpress.LookAndFeel.LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
    '    Application.Run(New SplashScreen1)
    '    '  XtraMessageBox.Show("Please Close The application And Reopen " & ex.Message)
    '    '  Exit Sub
    '    ' End Try

    'End Sub
    Public Function Decrypt(encryptpwd As String) As String
        Dim decryptpwd As String = String.Empty
        Dim encodepwd As New UTF8Encoding()
        Dim decode As Decoder = encodepwd.GetDecoder()
        Dim todecodeByte As Byte() = Convert.FromBase64String(encryptpwd)
        Dim charCount As Integer = Decode.GetCharCount(todecodeByte, 0, todecodeByte.Length)
        Dim decodedChar As Char() = New Char(charCount - 1) {}
        Decode.GetChars(todecodeByte, 0, todecodeByte.Length, decodedChar, 0)
        decryptpwd = New [String](decodedChar)
        Return decryptpwd
    End Function
    Public Function GenerateSr(currentclass As String) As String
        Dim lastSrPrimary As String = Nothing
        Dim lastSrSecondary As String = Nothing
        Dim generatedSr As String = Nothing
        Try
            con = New SqlConnection(My.Settings.FMIDataConnectionString)
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
            con = New SqlConnection(My.Settings.FMIDataConnectionString)
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
            If currentclass.Contains("Playgroup") OrElse currentclass.Contains("Nursury") OrElse currentclass.Contains("KG") OrElse currentclass.Contains("PREP") OrElse currentclass.ToString <= 5 Then
                generatedSr = "P" & CInt(resp) + 1
                Return generatedSr

            End If
        Else
            If currentclass.Contains("Playgroup") OrElse currentclass.Contains("Nursury") OrElse currentclass.Contains("KG") OrElse currentclass.Contains("PREP") OrElse currentclass.ToString <= 5 Then
                ' ReSharper disable once LocalizableElement
                generatedSr = "P1"
                Return generatedSr

            End If
        End If

        If Not lastSrSecondary = Nothing Then
            Dim resS As String = Nothing
            For Each c As Char In lastSrSecondary
                If IsNumeric(c) Then
                    resS = resS & c
                End If
            Next
            If currentclass > 5 AndAlso currentclass <= 12 Then
                generatedSr = "S" & CInt(resS + 1)
                Return generatedSr
            End If
        Else
            If Not currentclass.Contains("Playgroup") OrElse Not currentclass.Contains("Nursury") OrElse Not currentclass.Contains("KG") OrElse Not currentclass.Contains("PREP") OrElse currentclass > 5 AndAlso currentclass <= 12 Then
                generatedSr = "S1"
            End If
        End If
        Return generatedSr
    End Function
    Public Function IsFormOpen(ByVal frm As Form) As Boolean
        If Application.OpenForms.OfType(Of Form).Contains(frm) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function CloseAllExcept(ByVal frm As Form) As Form
        For Each form In Application.OpenForms
            If form.name <> frm.Name Then
                Return form
            End If
        Next
        Return Nothing

        'For i As Integer = Application.OpenForms.Count - 1 To 0 Step -1
        '    If Application.OpenForms.Item(i) IsNot frm Then
        '        Application.OpenForms.Item(i).Close()
        '    End If
        'Next
    End Function
    Public Sub KillAllProcesses(name As String)
        Dim processes As Process() = Process.GetProcessesByName(name)
        For Each p As Process In processes
            p.Kill()
        Next
    End Sub

    Public Function RunningInstance() As Process
        Dim current As Process = Process.GetCurrentProcess()
        Dim processes As Process() = Process.GetProcessesByName(current.ProcessName)
        For Each process As Process In processes
            If process.Id <> current.Id Then
                If Assembly.GetExecutingAssembly().Location.Replace("/", "\") = current.MainModule.FileName Then
                    Return process
                End If
            End If
        Next
        Return Nothing
    End Function

    Public Sub FindAndKill()
        Dim thisRun As Process = Process.GetCurrentProcess()
        Dim pList() As Process = Process.GetProcessesByName("Institute Information System.exe")

        For Each eachRun As Process In pList
            If (Not thisRun.Id = eachRun.Id) Then eachRun.Kill() ' Kill all other runs, but not this current one
        Next eachRun
    End Sub

    'Functions to open browser link
    'example:>
    ' Private Sub HyperlinkLabelControl1_Click(sender As Object, e As EventArgs) Handles HyperlinkLabelControl1.Click
    'Dim name As String = "https://m.me/iamDineshSolanki"
    '    If (Not Object.Equals(name, Nothing)) Then
    '        ShowWebSite(name)
    '    End If
    'End Sub
    '******Example End****
    Public Sub ShowWebSite(ByVal url As String)
        If Equals(url, Nothing) Then
            Return
        End If
        Dim processName As String = url.Replace(" ", String.Empty)
        If processName.Length = 0 Then
            Return
        End If
        Const protocol As String = "http://"
        Const protocol2 As String = "https://"
        If processName.IndexOf(protocol, StringComparison.InvariantCultureIgnoreCase) <> 0 AndAlso processName.IndexOf(protocol2, StringComparison.InvariantCultureIgnoreCase) <> 0 Then
            processName = protocol & processName
        End If
        StartProcess(processName)
    End Sub
    Public Sub StartProcess(ByVal processName As String)
        Try
            Process.Start(processName)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
