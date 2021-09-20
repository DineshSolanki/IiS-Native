Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars.Docking2010.Views.WindowsUI
Imports DevExpress.XtraBars.Docking2010.Customization
Imports System.IO
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Threading
Imports DevExpress.Utils
Imports DevExpress.XtraBars

Public Class Mainfrm
    ReadOnly _culture = CultureInfo.CreateSpecificCulture("en-IN")

    Private Sub mainfrm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        'CloseAllExcept(Me).Close()
        Application.Exit()
    End Sub
    Private Sub mainfrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If CloseReason.ApplicationExitCall Then

        Else
            My.Settings.Theme = UserLookAndFeel.Default.SkinName
            My.Settings.Save()
            Dim action As New FlyoutAction() With {.Caption = "Confirm", .Description = "Close the application?"}
            Dim command1 As New FlyoutCommand() With {.Text = "Close", .Result = DialogResult.Yes}
            Dim command2 As New FlyoutCommand() With {.Text = "Cancel", .Result = DialogResult.No}
            action.Commands.Add(command1)
            action.Commands.Add(command2)
            Dim properties As New FlyoutProperties()
            properties.ButtonSize = New Size(100, 40)
            properties.Style = FlyoutStyle.MessageBox
            If FlyoutDialog.Show(Me, action, properties) = DialogResult.Yes Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If

        'If e.Cancel = False Then
        '    CloseAllExcept(Me).Close()
        'End If
    End Sub

    Private Sub mainfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If LoginForm1.Visible = True Then
        '    LoginForm1.Close()
        'End If
        'If SplashScreen1.IsHandleCreated Then
        '    MessageBox.Show("it's my fault")
        '    SplashScreen1.Close()
        'End If

        If My.Settings.isFirstRun Then
            InstituteDetail.ShowDialog()
            If DialogResult.OK Then
                InstituteDetail.ShowDialog()
                If DialogResult.OK Then
                    FeeStruct.ShowDialog()
                    If DialogResult.OK Then
                        My.Settings.isFirstRun = False
                        My.Settings.Save()
                        MessageBox.Show("Please Restart IMS")
                        Application.Restart()
                        'Exit Sub
                    End If
                End If
            End If
        End If
        Text = "Institute Information System ©" & Now.ToString("yyyy")
        Thread.CurrentThread.CurrentCulture = _culture
        FormatInfo.AlwaysUseThreadFormat = True
        Try
            Dim newMdiChild As New DashBoard()
            newMdiChild.MdiParent = Me
            newMdiChild.Show()
        Catch ex As Exception
            XtraMessageBox.Show("Please Close The application And Reopen " & ex.Message)
        End Try

        'For Each i As 
        'DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Caramel"
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()


        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        Dim manage As New ManageUser
        manage.ShowDialog()
    End Sub

    Private Sub BarButtonItem9_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        Dim newMdiChild As New StuRecord()
        newMdiChild.MdiParent = Me
        newMdiChild.Show()
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Dim institute As New InstituteDetail
        institute.ShowDialog()
    End Sub

    Private Sub BarButtonItem7_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        If (Con.State = ConnectionState.Open) Then
            Con.Close()
        End If
        Dim st As String = "Successfully logged out"
        LogFunc(BarStaticItem5.Caption, st)

        Dim login As New LoginForm1
        login.Show()
        login.UsernameTextBox.Text = ""
        login.PasswordTextBox.Text = ""
        login.UsernameTextBox.Focus()
        Hide()
    End Sub

    Private Sub BarButtonItem8_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        Dim newMdiChild As New StudentAdd()
        newMdiChild.MdiParent = Me
        newMdiChild.Show()
    End Sub

    Private Sub BarButtonItem11_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        Dim newMdiChild As New StaffAdd()
        newMdiChild.MdiParent = Me
        newMdiChild.Show()
    End Sub

    Private Sub BarButtonItem12_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        Dim newMdiChild As New StaffRecord()
        newMdiChild.MdiParent = Me
        newMdiChild.Show()
    End Sub

    Private Sub BarButtonItem13_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        Dim newMdiChild As New FeeStruct()
        newMdiChild.MdiParent = Me
        newMdiChild.Show()
    End Sub

    Private Sub BarButtonItem14_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem14.ItemClick
        Dim detailfee As New DetailedFeeData
        detailfee.ShowDialog()
    End Sub

    Private Sub BarButtonItem15_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem15.ItemClick
        Dim newMdiChild As New FeeDataOneView()
        newMdiChild.MdiParent = Me
        newMdiChild.Show()
    End Sub

    Private Sub BarButtonItem16_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem16.ItemClick
        Dim printfee As New Printrecipt
        printfee.ShowDialog()
    End Sub

    Private Sub BarButtonItem17_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem17.ItemClick
        Process.Start("Calc.exe")
    End Sub

    Private Sub BarButtonItem18_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem18.ItemClick
        Process.Start("Notepad.exe")
    End Sub

    Private Sub BarButtonItem19_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem19.ItemClick
        Process.Start("WordPad.exe")
    End Sub

    Private Sub BarButtonItem20_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem20.ItemClick
        Process.Start("WinWord.exe")
    End Sub

    Private Sub BarButtonItem21_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem21.ItemClick
        Process.Start("TaskMgr.exe")
    End Sub

    Private Sub BarButtonItem22_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem22.ItemClick
        SystemInfo.ShowDialog()
    End Sub

    Private Sub BarButtonItem24_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem24.ItemClick
        Dim newMdiChild As New DashBoard()
        newMdiChild.MdiParent = Me
        newMdiChild.Show()
    End Sub

    Private Sub BarButtonItem25_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem25.ItemClick
        Dim log As New LogForm
        log.ShowDialog()
    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        Backup()
        'String.Format("BACKUP DATABASE greendb_{0} TO DISK='c:\Green_Backup\greendb_{0}.bak'"
    End Sub
    Sub Backup()
        Cursor = Cursors.WaitCursor
        Con = New SqlConnection(My.Settings.FMIDataConnectionString)
        Dim destdir As String = "D:\backupdb"
        If Not Directory.Exists(destdir) Then
            Directory.CreateDirectory("D:\backupdb")
        End If
        Try
            Con.Open()
            Cmd = New SqlCommand("backup database IMSData to disk='" + destdir + "\IMSDATA " + DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss") + ".Bak'", Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            XtraMessageBox.Show("Backup database successfully")
        Catch ex As Exception
            XtraMessageBox.Show("Error During backup database!" & ex.Message)
        End Try
        Cursor = Cursors.Arrow
    End Sub
    Sub Restore()
        Try
            With OpenFileDialog1
                .Filter = ("DB Backup File|*.bak;")
                .FilterIndex = 4
            End With
            'Clear the file name
            OpenFileDialog1.FileName = ""

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Cursor = Cursors.WaitCursor
                SqlConnection.ClearAllPools()
                Con = New SqlConnection(My.Settings.FMIDataConnectionString)
                Con.Open()
                Dim cb As String = "USE Master ALTER DATABASE IMSData SET Single_User WITH Rollback Immediate Restore database IMSData FROM disk='" & OpenFileDialog1.FileName & "' WITH REPLACE ALTER DATABASE IMSData SET Multi_User "
                Cmd = New SqlCommand(cb)
                Cmd.Connection = Con
                Cmd.ExecuteReader()
                Dim st As String = "Sucessfully performed the restore"
                LogFunc(BarStaticItem5.Caption, st)
                XtraMessageBox.Show("Successfully performed", "Database Restore", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'GetData()
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Cursor = Cursors.Arrow
    End Sub

    Private Sub BarButtonItem6_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        Restore()
    End Sub

    Private Sub BarButtonItem27_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem27.ItemClick
        FrmAbout.ShowDialog()
    End Sub

    Private Sub BarButtonItem28_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem28.ItemClick
        Dim frm As New SessionEntry
        frm.ShowDialog()
    End Sub

    Private Sub BarButtonItem29_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem29.ItemClick
        Dim tc As New Tc
        tc.ShowDialog()
    End Sub

    Private Sub BarButtonItem10_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        Dim promote As New PromoteStu
        promote.ShowDialog()
    End Sub

End Class