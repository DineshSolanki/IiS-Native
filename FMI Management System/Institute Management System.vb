Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Data.Odbc
Imports DevExpress.Skins
Imports DevExpress.Skins.SkinManager
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.RadioGroup
Imports DevExpress.XtraEditors.Controls
Imports DevExpress
Imports DevExpress.XtraReports.UI
Imports System.Deployment.Application
Imports System.Globalization
Imports DevExpress.XtraPrinting
Imports System.Configuration

Imports Microsoft.VisualBasic
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.XtraBars.Localization
Imports DevExpress.LookAndFeel

Public Class Form1
    Inherits DevExpress.XtraEditors.XtraForm
    Dim culture = CultureInfo.CreateSpecificCulture("en-IN")
    Dim cmd As SqlCommand
    Dim query As String
    Dim db As New FMIDATADataContext
    Protected Overrides Sub WndProc(ByRef m As Message)
        Const WM_NCLBUTTONDOWN As Integer = 161
        Const WM_SYSCOMMAND As Integer = 274
        Const HTCAPTION As Integer = 2
        Const SC_MOVE As Integer = 61456
        If (m.Msg = WM_SYSCOMMAND) And (m.WParam.ToInt32() = SC_MOVE) Then
            Return
        End If
        If (m.Msg = WM_NCLBUTTONDOWN) And (m.WParam.ToInt32() = HTCAPTION) Then
            Return
        End If
        MyBase.WndProc(m)
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        Dim newMdiChild As New StudentAdd()
        newMdiChild.MdiParent = Me
        newMdiChild.Show()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (Me.MdiChildren.Count = 0) Then
            PanelControl1.BringToFront()
            'SchoolName.BringToFront()
            'LabelControl1.BringToFront()
        Else
            PanelControl1.SendToBack()
            'SchoolName.SendToBack()
            'LabelControl1.SendToBack()
        End If
        lblDateTime.Text = Now.ToString("d/MM/yyyy, h:mm tt")
        ' PrintDate.Text = DateAndTime.Now.ToString()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If LoginForm1.Visible = True Then
            LoginForm1.Close()
        End If
        System.Threading.Thread.CurrentThread.CurrentCulture = culture
        DevExpress.Utils.FormatInfo.AlwaysUseThreadFormat = True
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableMdiFormSkins()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        ' UserLookAndFeel.Default.SetSkinStyle("Caramel")
        For Each skin As SkinContainer In SkinManager.Default.Skins
            Dim mySkins As New ToolStripMenuItem(skin.SkinName)
            ChangeSkinToolStripMenuItem.DropDownItems.Add(mySkins)
            mySkins.Image = SkinCollectionHelper.GetSkinIcon(skin.SkinName, SkinIconsSize.Large)
        Next
        'If My.Application.Deployment.IsFirstRun Then
        '    InstituteDetail.ShowDialog()
        '    If DialogResult.OK Then
        '        FeeStruct.ShowDialog()
        '        If DialogResult.OK Then
        '            MessageBox.Show("Please Restart IMS")
        '            Me.Close()
        '        End If
        '    End If
        'End If

        Me.MaximumSize = Me.Size
        Me.MaximizeBox = False
        Dim schoolinfo = From p In db.InstituteInfos
                       Select p.Institute_Name
        Me.Text = "Institute Management System"
        SchoolName.Text = schoolinfo.FirstOrDefault.ToString
        WindowPanel.Text = "IMS" & Date.Now.ToString("  yyyy")
        My.Forms.PrintForm.SchoolName.Text = SchoolName.Text
        AddHandler UserLookAndFeel.Default.StyleChanged, AddressOf Default_StyleChanged

    End Sub

    Private Sub PrintFeeChalanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintFeeChalanToolStripMenuItem.Click
        printrecipt.ShowDialog()
        'con = New SqlConnection(connectionString)
        'Dim adapter As New SqlDataAdapter()
        'adapter.SelectCommand = New SqlCommand("SELECT * FROM feedata", con)
        'Dim builder As SqlCommandBuilder = New SqlCommandBuilder(adapter)
        'Dim adapter2 As New SqlDataAdapter()
        'adapter2.SelectCommand = New SqlCommand("SELECT * FROM instituteinfo", con)
        'Dim builder2 As SqlCommandBuilder = New SqlCommandBuilder(adapter2)
        'con.Open()
        'Dim myTable As DataTable = New DataTable
        'Dim myTable2 As DataTable = New DataTable
        'adapter.Fill(myTable)

        'adapter.Fill(myTable2)
        'Dim persons As DetailReportBand = TryCast(report.Bands("DetailReport"), DetailReportBand)
        'persons.DataSource = myTable2

        'report.DataSource = myTable2
        ' report.ReportHeaderBand1.
        'report.DataMember = myTable2
        'report.DataAdapter = adapter
        'report.FilterString.



        'report.ShowPreview()

        'printTool.Print()
        'printTool.Print("myPrinter")

    End Sub

    Private Sub SchoolName_Click(sender As Object, e As EventArgs)
        MsgBox(My.Forms.StudentAdd.Panel1.Size.ToString())
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub ChangeSkinToolStripMenuItem_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ChangeSkinToolStripMenuItem.DropDownItemClicked
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = e.ClickedItem.Text
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub

    Private Sub ViewRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewRecordToolStripMenuItem.Click
        Dim newMdiChild As New StuRecord()
        newMdiChild.MdiParent = Me
        newMdiChild.Show()
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AddToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem1.Click
        Dim newMdiChild As New StaffAdd()
        newMdiChild.MdiParent = Me
        newMdiChild.Show()
    End Sub

    Private Sub ViewRecordToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ViewRecordToolStripMenuItem1.Click
        Dim newMdiChild As New StaffRecord()
        newMdiChild.MdiParent = Me
        newMdiChild.Show()
    End Sub

    Private Sub FeeStructureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FeeStructureToolStripMenuItem.Click
        Dim newMdiChild As New FeeStruct()
        newMdiChild.MdiParent = Me
        newMdiChild.Show()
    End Sub

    Private Sub ViewFeeDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewFeeDataToolStripMenuItem.Click
        Dim newMdiChild As New Fee_Data()
        newMdiChild.MdiParent = Me
        newMdiChild.Show()
    End Sub

    Private Sub AboutIMSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutIMSToolStripMenuItem.Click
        RadAboutBox1.ShowDialog()

    End Sub

    Private Sub LogInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogInToolStripMenuItem.Click
        ManageUser.ShowDialog()
    End Sub

    Private Sub InstituteDetailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstituteDetailToolStripMenuItem.Click
        InstituteDetail.ShowDialog()
        'Dim newMdiChild As New InstituteDetail()
        'newMdiChild.MdiParent = Me
        'newMdiChild.Show()
    End Sub

    Private Sub LogOffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOffToolStripMenuItem.Click
        'If (con.State = ConnectionState.Open) Then
        '    con.Close()
        'End If
        Dim st As String = "Successfully logged out"
        LogFunc(lblUser.Text, st)
        Me.Hide()
        LoginForm1.Show()
        LoginForm1.UsernameTextBox.Text = ""
        LoginForm1.PasswordTextBox.Text = ""
        LoginForm1.UsernameTextBox.Focus()


    End Sub

    Private Sub BackupDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackupDatabaseToolStripMenuItem.Click
        backup1()
    End Sub
    Sub Backup()
        ' Try
        Cursor = Cursors.WaitCursor
        Timer2.Enabled = True
        If (Not System.IO.Directory.Exists("C:\DBBackup")) Then
            System.IO.Directory.CreateDirectory("C:\DBBackup")
        End If
        Dim destdir As String = "C:\DBBackup\FmiData.bak " & DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss") & ".bak"
        con = New SqlConnection(My.Settings.FMIDATAConnectionString)
        con.Open()
        Dim cb As String = String.Format("backup database FmiData to disk='" & destdir & "'with init,stats=10")
        'String.Format("BACKUP DATABASE greendb_{0} TO DISK='c:\Green_Backup\greendb_{0}.bak'"
        cmd = New SqlCommand(cb)
        cmd.Connection = con
        cmd.ExecuteNonQuery()
        con.Close()
        Dim st As String = "Sucessfully performed the backup"
        LogFunc(lblUser.Text, st)
        XtraMessageBox.Show("Successfully performed", "Database Backup", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'GetData()
        '  Catch ex As Exception
        'MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '  End Try
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Cursor = Cursors.Default
        Timer2.Enabled = False
    End Sub

    Private Sub RestoreDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreDatabaseToolStripMenuItem.Click
        Try
            With OpenFileDialog1
                .Filter = ("DB Backup File|*.bak;")
                .FilterIndex = 4
            End With
            'Clear the file name
            OpenFileDialog1.FileName = ""

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Cursor = Cursors.WaitCursor
                Timer2.Enabled = True
                SqlConnection.ClearAllPools()
                con = New SqlConnection(My.Settings.FMIDATAConnectionString)
                con.Open()
                Dim cb As String = "USE Master ALTER DATABASE FmiData SET Single_User WITH Rollback Immediate Restore database FmiData FROM disk='" & OpenFileDialog1.FileName & "' WITH REPLACE ALTER DATABASE FmiData SET Multi_User "
                cmd = New SqlCommand(cb)
                cmd.Connection = con
                cmd.ExecuteReader()
                Dim st As String = "Sucessfully performed the restore"
                LogFunc(lblUser.Text, st)
                XtraMessageBox.Show("Successfully performed", "Database Restore", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'GetData()
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub backup1()
        ' Try
       
    End Sub

    Private Sub SystemInfoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SystemInfoToolStripMenuItem1.Click
        SystemInfo.ShowDialog()
    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculatorToolStripMenuItem.Click
        System.Diagnostics.Process.Start("Calc.exe")
    End Sub

    Private Sub NotepadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotepadToolStripMenuItem.Click
        System.Diagnostics.Process.Start("Notepad.exe")
    End Sub

    Private Sub WordpadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WordpadToolStripMenuItem.Click
        System.Diagnostics.Process.Start("WordPad.exe")
    End Sub

    Private Sub MSWordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MSWordToolStripMenuItem.Click
        System.Diagnostics.Process.Start("WinWord.exe")
    End Sub

    Private Sub TaskManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TaskManagerToolStripMenuItem.Click
        System.Diagnostics.Process.Start("TaskMgr.exe")
    End Sub
    Private Sub Default_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
        Me.Refresh()
    End Sub

    Private Sub DetailedFeeDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetailedFeeDataToolStripMenuItem.Click
        DetailedFeeData.ShowDialog()
    End Sub

    Private Sub PromoteStudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PromoteStudentsToolStripMenuItem.Click

    End Sub

    Private Sub CommunicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CommunicationToolStripMenuItem.Click

    End Sub
End Class
