Imports System.Management
Imports System.Data.SqlClient

Public Class SplashScreen1
    Sub New()
        InitializeComponent()
    End Sub

    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
    End Sub

    Public Enum SplashScreenCommand
        SomeCommandId
    End Enum

    Private Sub SplashScreen1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSystemID()
        checkActivation()
        '  LOADSTATUS()

        'Me.labelControl2.Text = "Creating MainForm..."
        'System.Threading.Thread.Sleep(1000)

        'Me.labelControl2.Text = "Loading Files..."
        'System.Threading.Thread.Sleep(1500)

        'Me.labelControl2.Text = "Loading Plug/Ins..."
        'System.Threading.Thread.Sleep(1500)

        'Me.labelControl2.Text = "Sleeping 1 second..."
        'System.Threading.Thread.Sleep(1000)

        ''Me.Close()
        ''frmActivation.ShowDialog()
    End Sub
    Public Sub LoadSystemId()
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
        End Try
    End Sub
    Public Sub CheckActivation()
        Dim st As String = (txtHardwareID.Text) + (txtSerialNo.Text)
        TextEdit1.Text = Encryption.MakePassword(st, 679)
        Try
            con = New SqlConnection(My.Settings.FMIDataConnectionString)
            con.Open()
            Dim ct As String = "select RTRIM(ActivationID) from Activation where HardwareID=@d1 and SerialNo=@d2"
            cmd = New SqlCommand(ct)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@d1", txtHardwareID.Text)
            cmd.Parameters.AddWithValue("@d2", txtSerialNo.Text)
            reader = cmd.ExecuteReader()
            If reader.Read() Then
                txtActivationID.Text = Decrypt(reader.GetValue(0))
                If Not txtActivationID.Text = TextEdit1.Text Then
                    frmActivation.Show()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")
            End
        End Try
    End Sub
   

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If txtActivationID.Text = TextEdit1.Text Then
                marqueeProgressBarControl1.Text = marqueeProgressBarControl1.Text + 2
                If (marqueeProgressBarControl1.Text = 10) Then
                    labelControl2.Text = "Reading modules.."
                ElseIf (marqueeProgressBarControl1.Text = 20) Then
                    labelControl2.Text = "Turning on modules."
                ElseIf (marqueeProgressBarControl1.Text = 40) Then
                    labelControl2.Text = "Starting modules.."
                ElseIf (marqueeProgressBarControl1.Text = 60) Then
                    labelControl2.Text = "Loading modules.."
                ElseIf (marqueeProgressBarControl1.Text = 80) Then
                    labelControl2.Text = "Done Loading modules.."
                ElseIf (marqueeProgressBarControl1.Text = 100) Then

                    Dim login As New LoginForm1

                    login.Show()
                    Timer1.Enabled = False
                    Hide()
                End If
            End If
            If txtActivationID.Text <> TextEdit1.Text Then
                marqueeProgressBarControl1.Text = marqueeProgressBarControl1.Text + 2
                If (marqueeProgressBarControl1.Text = 10) Then
                    labelControl2.Text = "Reading modules.."
                ElseIf (marqueeProgressBarControl1.Text = 20) Then
                    labelControl2.Text = "Turning on modules."
                ElseIf (marqueeProgressBarControl1.Text = 40) Then
                    labelControl2.Text = "Starting modules.."
                ElseIf (marqueeProgressBarControl1.Text = 60) Then
                    labelControl2.Text = "Loading modules.."
                ElseIf (marqueeProgressBarControl1.Text = 80) Then
                    labelControl2.Text = "Done Loading modules.."
                ElseIf (marqueeProgressBarControl1.Text = 100) Then
                    frmActivation.Show()
                    Timer1.Enabled = False
                    Hide()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")
            End
        End Try
        'Timer1.Stop()
    End Sub
End Class
