Imports System.IO
Imports System.Management

Public Class SystemInfo

    Private Sub SystemInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim i As ManagementObject
            Dim searchInfoProcessor As New ManagementObjectSearcher("Select * from Win32_Processor")
            For Each i In searchInfoProcessor.Get()
                txtProcessorName.Text = i("Name").ToString
                txtProcessorID.Text = i("ProcessorID").ToString
                txtProcessorDescription.Text = i("Description").ToString
                txtProcessorManufacturer.Text = i("Manufacturer").ToString
                txtProcessorL2CacheSize.Text = i("L2CacheSize").ToString
                txtProcessorClockSpeed.Text = i("CurrentClockSpeed").ToString & " Mhz"
                DataWidth.Text = i("DataWidth").ToString
                txtProcessorExtClock.Text = i("ExtClock").ToString & " Mhz"
                PF.Text = i("Family").ToString
            Next
            Dim searchInfoBoard As New ManagementObjectSearcher("Select * from Win32_BaseBoard")
            For Each i In searchInfoBoard.Get()
                txtBoardDescription.Text = i("Description").ToString
                txtBoardManufacturer.Text = i("Manufacturer").ToString
                txtBoardName.Text = i("Name").ToString
                ' txtBoardSerialNumber.Text = i("SerialNumber").ToString
            Next
            Dim q As New SelectQuery("Win32_bios")
            Dim searchInfoBoard1 As New ManagementObjectSearcher(q)
            For Each i In searchInfoBoard1.Get()
                txtBoardSerialNumber.Text = i("serialnumber").ToString
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")
            End
        End Try
    End Sub

    Private Sub SaveToFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToFileToolStripMenuItem.Click
        Try
            Dim fs As New FileStream("temp.txt", FileMode.Create, FileAccess.Write)
            Dim w As New StreamWriter(fs)
            w.Write("****** Processor Information ******")
            w.WriteLine()
            w.WriteLine()
            w.WriteLine("Name")
            w.WriteLine(txtProcessorName.Text)
            w.WriteLine()
            w.WriteLine("ID")
            w.WriteLine(txtProcessorID.Text)
            w.WriteLine()
            w.WriteLine("Description")
            w.WriteLine(txtProcessorDescription.Text)
            w.WriteLine()
            w.WriteLine("Manufacturer")
            w.WriteLine(txtProcessorManufacturer.Text)
            w.WriteLine()
            w.WriteLine("L2 Cache Size")
            w.WriteLine(txtProcessorL2CacheSize.Text)
            w.WriteLine()
            w.WriteLine("Clock Speed")
            w.WriteLine(txtProcessorClockSpeed.Text)
            w.WriteLine()
            w.WriteLine("Data Width")
            w.WriteLine(DataWidth.Text)
            w.WriteLine()
            w.WriteLine("Ext Clock")
            w.WriteLine(txtProcessorExtClock.Text)
            w.WriteLine()
            w.WriteLine("Family")
            w.WriteLine(PF.Text)
            w.WriteLine()
            w.WriteLine("****** MotherBoard Information *****")
            w.WriteLine()
            w.WriteLine("Name")
            w.WriteLine(txtBoardDescription.Text)
            w.WriteLine()
            w.WriteLine("Manufacturer")
            w.WriteLine(txtBoardManufacturer.Text)
            w.WriteLine()
            w.WriteLine("Description")
            w.WriteLine(txtBoardDescription.Text)
            w.WriteLine()
            w.WriteLine("Serial Number")
            w.WriteLine(txtBoardSerialNumber.Text)
            w.Flush()
            w.Close()
            With SaveFileDialog1
                .AddExtension = True
                .OverwritePrompt = True
                .DefaultExt = "txt"
                .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                .FileName = "SystemInfo"
                .Filter = "Text files (*.txt)|*.txt|All files|*.*"
                .FilterIndex = 1
                .Title = "SystemInfo - Save file"
                If .ShowDialog() = DialogResult.OK Then
                    My.Computer.FileSystem.MoveFile("temp.txt", .FileName, True)
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub
End Class