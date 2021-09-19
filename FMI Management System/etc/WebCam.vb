Imports System.Drawing.Imaging
Imports System.IO
Imports TouchlessLib

Public Class WebCam
    Public CamMgr As TouchlessMgr

    Private Sub WebCam_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            Timer1.Enabled = False
            CamMgr.CurrentCamera.Dispose()
            CamMgr.Cameras.Item(ComboBoxEdit1.SelectedIndex).Dispose()
            CamMgr.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub WebCam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CamMgr = New TouchlessMgr
        TempFileNames2 = ""

        For i = 0 To CamMgr.Cameras.Count - 1
            ComboBoxEdit1.Properties.Items.Add(CamMgr.Cameras(i).ToString)
        Next
        If ComboBoxEdit1.Properties.Items.Count > 0 Then
            ComboBoxEdit1.SelectedIndex = 0
            Timer1.Enabled = True
        Else
            MsgBox("There are no Camera ...")
            Close()
        End If
    End Sub

    Private Sub ComboBoxEdit1_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles ComboBoxEdit1.SelectedIndexChanged
        CamMgr.CurrentCamera = CamMgr.Cameras.ElementAt(ComboBoxEdit1.SelectedIndex)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureEdit2.Image = CamMgr.CurrentCamera.GetCurrentImage()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        PictureEdit1.Image = CamMgr.CurrentCamera.GetCurrentImage()
        SimpleButton2.Enabled = True
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim sTempFileName As String = Path.GetTempFileName()
        TempFileNames2 = sTempFileName
        Dim b As Bitmap = PictureEdit1.Image
        b.Save(sTempFileName, ImageFormat.Jpeg)
        Timer1.Enabled = False
        CamMgr.CurrentCamera.Dispose()
        CamMgr.Cameras.Item(ComboBoxEdit1.SelectedIndex).Dispose()
        CamMgr.Dispose()

        Close()
    End Sub
End Class