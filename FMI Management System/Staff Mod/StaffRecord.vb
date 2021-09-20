Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Data.SqlClient
Imports DevExpress.XtraEditors

Public Class StaffRecord
    Dim _con As SqlConnection
    Dim _adapter As New SqlDataAdapter()

    Private Sub StaffRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridView1.OptionsBehavior.Editable = False
        _con = New SqlConnection(My.Settings.FMIDataConnectionString)

        Dim adapter As New SqlDataAdapter()
        adapter.SelectCommand = New SqlCommand("SELECT * FROM staff", _con)
        _con.Open()
        Dim myTable As DataTable = New DataTable
        adapter.Fill(myTable)
        GridControl1.DataSource = myTable
        GridView1.BestFitColumns()

        MaximizeBox = False
        TextEdit1.Text = GridControl1.Font.Size
    End Sub

    Sub SetGridFont(view As GridView, font As Font)
        Dim ap As AppearanceObject
        For Each ap In view.Appearance
            ap.Font = font
        Next
    End Sub

    Private Sub CheckButton2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckButton2.CheckedChanged
        If GridView1.OptionsBehavior.Editable = True Then
            GridView1.OptionsBehavior.Editable = False
            CheckButton2.Text = "Edit Data"
        ElseIf GridView1.OptionsBehavior.Editable = False Then
            GridView1.OptionsBehavior.Editable = True
            CheckButton2.Text = "View Data"
        End If
    End Sub

    Private Sub mor_Click(sender As Object, e As EventArgs) Handles mor.Click
        TextEdit1.Text += 1
        If TextEdit1.Text <= 8.25 Then
            TextEdit1.Text = 8.25

        End If
        If (TextEdit1.Text > 37.25) Then
            TextEdit1.Text = 37.25
        End If


        SetGridFont(GridView1, New Font("Courier New", TextEdit1.Text))
        GridView1.BestFitColumns()
    End Sub

    Private Sub Les_Click(sender As Object, e As EventArgs) Handles Les.Click
        TextEdit1.Text -= 1
        If (TextEdit1.Text <= 8.25) Then
            TextEdit1.Text = 8.25
        End If
        If (TextEdit1.Text > 37.25) Then
            TextEdit1.Text = 37.25
        End If
        SetGridFont(GridView1, New Font("Courier New", TextEdit1.Text))
        GridView1.BestFitColumns()
    End Sub

    Private Sub TextEdit1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextEdit1.KeyDown
        If (e.KeyValue = Keys.Enter) Then
            If TextEdit1.Text = "" Then
                Exit Sub
            Else
                If (TextEdit1.Text < 8.25) Then
                    TextEdit1.Text = 8.25
                End If
                If (TextEdit1.Text > 37.25) Then
                    TextEdit1.Text = 37.25
                End If
                SetGridFont(GridView1, New Font("Courier New", TextEdit1.Text))
                GridView1.BestFitColumns()
            End If
        End If
    End Sub

    Private Sub CheckButton1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckButton1.CheckedChanged
        If CheckButton1.Checked = True Then
            GridView1.RowHeight = 114

        Else
            GridView1.RowHeight = -1

        End If
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click

        Try
            _adapter.SelectCommand = New SqlCommand("SELECT * FROM staff", _con)
            Dim myTable = CType(GridControl1.DataSource, DataTable)
            _adapter.Update(myTable)
            XtraMessageBox.Show("Saved")
            Dim st As String = "Edited Staff Record"
            LogFunc(mainfrm.BarStaticItem5.Caption, st)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        If Not GridControl1.IsPrintingAvailable Then
            MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error")
            Return
        End If

        ' Opens the Preview window.
        GridControl1.ShowPrintPreview()
    End Sub
End Class