Imports DevExpress.XtraEditors

Public Class FrmAbout

    Private Function GetProcessName(ByVal e As DevExpress.Utils.HyperlinkClickEventArgs) As String
        Return e.Link
    End Function



    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Close()
    End Sub

    Private Sub HyperlinkLabelControl3_HyperlinkClick(sender As Object, e As DevExpress.Utils.HyperlinkClickEventArgs) Handles HyperlinkLabelControl3.HyperlinkClick
    End Sub

    Private Sub HyperlinkLabelControl2_Click(sender As Object, e As EventArgs) Handles HyperlinkLabelControl2.Click
        XtraMessageBox.Show("Call or WhatsApp: 9530056455" & vbCrLf & "Sitaram Solanki")
    End Sub

    Private Sub HyperlinkLabelControl1_Click(sender As Object, e As EventArgs) Handles HyperlinkLabelControl1.Click
        Dim name As String = "https://m.me/iamDineshSolanki"
        If (Not Equals(name, Nothing)) Then
            ShowWebSite(name)
        End If
    End Sub

    Private Sub HyperlinkLabelControl3_Click(sender As Object, e As EventArgs) Handles HyperlinkLabelControl3.Click
        Const name As String = "https://fmi.neocities.org"
        If (Not Equals(name, Nothing)) Then
            ShowWebSite(name)
        End If
    End Sub

    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class