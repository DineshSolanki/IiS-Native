Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraWizard

Public Class Setup
    Dim finish As Boolean = False
    Dim cancel As Boolean = False
    Private Sub wizardControl1_FinishClick(ByVal sender As Object, ByVal e As CancelEventArgs) Handles WizardControl1.FinishClick
        finish = True
        XtraMessageBox.Show("Welcome To IMS " & PName.Text)

        Me.Close()
       
    End Sub
    Private Sub setup_CancelClick(ByVal sender As Object, ByVal e As CancelEventArgs) Handles WizardControl1.CancelClick
        cancel = True
        XtraMessageBox.Show("Sorry, You can't use this software without creating a database")
        Me.Close()
    End Sub
    Private Sub wizardControl1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        If finish = True Then
            My.Forms.Form1.Show()
            Return
        End If
        If XtraMessageBox.Show(Me, "Do you want to exit the XtraWizard feature tour?", "XtraWizard", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class