Imports System.Windows.Forms

Public Class FeeDiscount
    Inherits DevExpress.XtraEditors.NativeDialogForm



    Private Sub OK_Button_Click_1(sender As Object, e As EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub FeeDiscount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f As StudentAdd
        f = CType(Me.Owner, StudentAdd)
        Dim db As New FMIDATADataContext
        Dim fee As Integer
        Dim adfee As Integer
        Dim TotalFees = From p In db.FeeStructures
                        Select p Where p.Class = "Nursury"

        'My.Forms.StudentAdd.txtAddClass.Text
        If TotalFees.Count <> 0 Then
            For j = 1 To TotalFees.Count
                fee = TotalFees.ToList(j - 1).Total_Fee
                adfee = TotalFees.ToList(j - 1).Admision_Fee
            Next
        End If
        Label2.Text = fee
        Label2.ToolTip = "Including Admission Fee Of " & adfee
    End Sub
End Class
