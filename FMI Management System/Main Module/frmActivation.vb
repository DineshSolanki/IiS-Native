Imports System.Data.SqlClient
Imports System.Management
Imports DevExpress.XtraEditors

Public Class FrmActivation
    Dim _db As New FMIDATADataContext
    Private Sub frmActivation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim alreadyRegister = From p In _db.Activations
        Select p
        If alreadyRegister.Count = 0 Then
            Try
                Dim qu As New SelectQuery("Win32_Processor")
                Dim i As ManagementObject
                Dim searchInfoProcessor As New ManagementObjectSearcher(qu)
                For Each i In searchInfoProcessor.Get()
                    txtHardwareID.Text = i("ProcessorID").ToString
                Next
                Dim q As New SelectQuery("Win32_bios")
                Dim searchInfoBoard As New ManagementObjectSearcher(q)
                For Each i In searchInfoBoard.Get()
                    txtSerialNo.Text = i("serialnumber").ToString
                Next
                'txtSerialNo.Text = SystemSerialNumber()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")
                End
            End Try
        Else
            LoginForm1.ShowDialog()
            Close()

            End If

    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click

        Application.Exit()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Try
            If txtActivationID.Text = "" Then
                XtraMessageBox.Show("Please enter activation id", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtActivationID.Focus()
                Exit Sub
            End If
            Dim st As String = (txtHardwareID.Text) + (txtSerialNo.Text)
            TextBox1.Text = Encryption.MakePassword(st, 679)

            If txtActivationID.Text = TextBox1.Text Then
                con = New SqlConnection(My.Settings.FMIDataConnectionString)
                con.Open()
                Dim cb1 As String = "insert into Activation(HardwareID,SerialNo,ActivationID) VALUES (@d1,@d2,@d3)"
                cmd = New SqlCommand(cb1)
                cmd.Connection = con
                cmd.Parameters.AddWithValue("@d1", txtHardwareID.Text)
                cmd.Parameters.AddWithValue("@d2", txtSerialNo.Text)
                cmd.Parameters.AddWithValue("@d3", Encrypt(txtActivationID.Text.Trim()))
                cmd.ExecuteReader()
                con.Close()
                XtraMessageBox.Show("Successfully activated", "Software", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoginForm1.Show()
                Close()
            Else
                XtraMessageBox.Show("Invalid activation id...Please contact software provider for buying full licence" & vbCrLf & "Contact us at :" & vbCrLf & "Fmi.Neocities.org" & vbCrLf & "Email-FmiJodhpur@gmail.com" & vbCrLf & "Mobile No. +919530056455", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                
            End If
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function SystemSerialNumber() As String
        Dim value As String = ""
        Dim baseBoard As ManagementClass = New ManagementClass("Win32_BaseBoard")
        Dim board As ManagementObjectCollection = baseBoard.GetInstances()
        If board.Count > 0 Then
            value = board(0)("SerialNumber")
        End If
        If value.Length < 0 Then
            value = value.Substring(2)
        End If
        Return value
    End Function
End Class