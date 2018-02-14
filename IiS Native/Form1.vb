Imports System.IO
Imports System.Data.SqlClient

Public Class MainFrm



    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        Dim newMdiChild As New StudentAdd()
        newMdiChild.MdiParent = Me
        newMdiChild.Show()
    End Sub

    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MainFrm_MdiChildActivate(sender As Object, e As EventArgs) Handles MyBase.MdiChildActivate
        If Me.ActiveMdiChild Is Nothing Then
            tabForms.Visible = False
            ' If no any child form, hide tabControl 
        Else
            Me.ActiveMdiChild.WindowState = FormWindowState.Maximized
            ' Child form always maximized 

            ' If child form is new and no has tabPage, 
            ' create new tabPage 
            If Me.ActiveMdiChild.Tag Is Nothing Then
                ' Add a tabPage to tabControl with child 
                ' form caption 
                Dim tp As New TabPage(Me.ActiveMdiChild.Text)
                tp.Tag = Me.ActiveMdiChild
                tp.Parent = tabForms
                tabForms.SelectedTab = tp

                Me.ActiveMdiChild.Tag = tp
                AddHandler ActiveMdiChild.FormClosed, AddressOf ActiveMdiChild_FormClosed
            End If

            If Not tabForms.Visible Then
                tabForms.Visible = True
            End If

        End If


    End Sub
    Private Sub ActiveMdiChild_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        TryCast((TryCast(sender, Form)).Tag, TabPage).Dispose()
    End Sub

    Private Sub tabForms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabForms.SelectedIndexChanged
        If (tabForms.SelectedTab IsNot Nothing) AndAlso (tabForms.SelectedTab.Tag IsNot Nothing) Then
            TryCast(tabForms.SelectedTab.Tag, Form).Select()
        End If

    End Sub

    Private Sub ManageUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageUsersToolStripMenuItem.Click
        Dim manage As New ManageUsers
        manage.ShowDialog()
    End Sub

    Private Sub InstituteDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstituteDetailsToolStripMenuItem.Click
        Dim institute As New InstituteDetail
        institute.ShowDialog()
    End Sub

    Private Sub VieweditRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VieweditRecordToolStripMenuItem.Click
        Dim newMdiChild As New stuRecord()
        newMdiChild.MdiParent = Me
        newMdiChild.Show()
    End Sub

    Private Sub PromoteStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PromoteStudentToolStripMenuItem.Click
        Dim promote As New PromoteStu
        promote.ShowDialog()
    End Sub

    Private Sub GiveTCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GiveTCToolStripMenuItem.Click
        Dim tc As New TC
        tc.ShowDialog()
    End Sub

    Sub Backup()
        Cursor = Cursors.WaitCursor
        Con = New SqlConnection(My.Settings.IiSConnectionString)
        Dim destdir As String = "D:\backupdb"
        If Not Directory.Exists(destdir) Then
            Directory.CreateDirectory("D:\backupdb")
        End If
        Try
            Con.Open()
            Cmd = New SqlCommand("backup database IMSData to disk='" + destdir + "\IMSDATA " + DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss") + ".Bak'", Con)
            Cmd.ExecuteNonQuery()
            Con.Close()
            MessageBox.Show("Backup database successfully")
        Catch ex As Exception
            MessageBox.Show("Error During backup database!" & ex.Message)
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
                Con = New SqlConnection(My.Settings.IiSConnectionString)
                con.Open()
                Dim cb As String = "USE Master ALTER DATABASE IMSData SET Single_User WITH Rollback Immediate Restore database IMSData FROM disk='" & OpenFileDialog1.FileName & "' WITH REPLACE ALTER DATABASE IMSData SET Multi_User "
                cmd = New SqlCommand(cb)
                cmd.Connection = con
                cmd.ExecuteReader()
                Dim st As String = "Sucessfully performed the restore"
                LogFunc(ToolStripStatusLabel3.Text, st)
                MessageBox.Show("Successfully performed", "Database Restore", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'GetData()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Cursor = Cursors.Arrow
    End Sub

    Private Sub BackupDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackupDatabaseToolStripMenuItem.Click
        Backup()
    End Sub

    Private Sub RestoreDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreDatabaseToolStripMenuItem.Click
        Restore()
    End Sub

    Private Sub LogOffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOffToolStripMenuItem.Click
        If (Con.State = ConnectionState.Open) Then
            Con.Close()
        End If
        Dim st As String = "Successfully logged out"
        LogFunc(ToolStripStatusLabel3.Text, st)

        Dim login As New LoginForm1
        login.Show()
        login.UsernameTextBox.Text = ""
        login.PasswordTextBox.Text = ""
        login.UsernameTextBox.Focus()
        Hide()
    End Sub

    Private Sub AddToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem1.Click
        Dim newMdiChild As New addStaff()
        newMdiChild.MdiParent = Me
        newMdiChild.Show()
    End Sub

    Private Sub VieweditRecordToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VieweditRecordToolStripMenuItem1.Click
        Dim newMdiChild As New viewstaff()
        newMdiChild.MdiParent = Me
        newMdiChild.Show()
    End Sub

    Private Sub FeeStructureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FeeStructureToolStripMenuItem.Click
        Dim newMdiChild As New feeStruct()
        newMdiChild.MdiParent = Me
        newMdiChild.Show()
    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculatorToolStripMenuItem.Click
        Process.Start("Calc.exe")
    End Sub

    Private Sub NotepadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotepadToolStripMenuItem.Click
        Process.Start("Notepad.exe")
    End Sub

    Private Sub WordpadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WordpadToolStripMenuItem.Click
        Process.Start("WordPad.exe")
    End Sub

    Private Sub TaskManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TaskManagerToolStripMenuItem.Click
        Process.Start("TaskMgr.exe")
    End Sub

    Private Sub SystemInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SystemInfoToolStripMenuItem.Click
        SystemInfo.ShowDialog()
    End Sub


End Class
