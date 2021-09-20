﻿Imports System.Data.SqlClient
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid

Public Class StuRecord
    
    Dim _con As SqlConnection
    ReadOnly _adapter As New SqlDataAdapter()
    ReadOnly _db As New FMIDATADataContext
    ' Dim _mystudents As IQueryable(Of Student)

    Sub New()

        InitializeComponent()
        ' This line of code is generated by Data Source Configuration Wizard
        ' This line of code is generated by Data Source Configuration Wizard
        'StudentsTableAdapter1.Fill(DataBase1.Students)
    End Sub

    Private Sub LoadSessions()
        Dim list = From p In _db.Sessions
                Select p
        If list.Count <> 0 Then
            For j = 1 To list.Count
                YearSession.Properties.Items.Add(list.ToList(j - 1).Session)
            Next

        End If
    End Sub

    Private Sub StuRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSessions()
        GridView1.OptionsBehavior.Editable = False
        GridView2.OptionsBehavior.Editable = False
        _con = New SqlConnection(My.Settings.FMIDataConnectionString)
        'TODO: This line of code loads data into the 'DataBase.Students' table. You can move, or remove it, as needed.
        _adapter.SelectCommand =
            New SqlCommand(
                "SELECT * FROM students where Session=(select session from sessions where Id=(select max(Id) from Sessions))",
                _con)

        'Try
        _con.Open()
        Dim myTable = New DataTable
        _adapter.Fill(myTable)
        GridControl1.DataSource = myTable
        _con.Close()
        'Catch ex As Exception
        'MessageBox.Show(ex.Message)
        'End Try
        'Me.StudentsTableAdapter.Fill(Me.DataBase.Students)
        GridView1.BestFitColumns()
        GridView2.BestFitColumns()
        MaximizeBox = False
        TextEdit1.Text = GridControl1.Font.Size
    End Sub

    Sub SetGridFont(view As GridView, font1 As Font)
        Dim ap As AppearanceObject
        For Each ap In view.Appearance
            ap.Font = font1
        Next
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        TextEdit1.Text += 1
        If TextEdit1.Text <= 8.25 Then
            TextEdit1.Text = 8.25

        End If
        If (TextEdit1.Text > 37.25) Then
            TextEdit1.Text = 37.25
        End If


        SetGridFont(GridView1, New Font("Courier New", TextEdit1.Text))
        SetGridFont(GridView2, New Font("Courier New", TextEdit1.Text))
        GridView1.BestFitColumns()
        GridView2.BestFitColumns()
    End Sub

    Private Sub CheckButton1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckButton1.CheckedChanged
        If CheckButton1.Checked = True Then
            GridView1.RowHeight = 114
            GridView2.RowHeight = 114
        Else
            GridView1.RowHeight = -1
            GridView2.RowHeight = -1
        End If
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
                GridView2.BestFitColumns()
            End If
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        TextEdit1.Text -= 1
        If (TextEdit1.Text <= 8.25) Then
            TextEdit1.Text = 8.25
        End If
        If (TextEdit1.Text > 37.25) Then
            TextEdit1.Text = 37.25
        End If
        SetGridFont(GridView1, New Font("Courier New", TextEdit1.Text))
        SetGridFont(GridView2, New Font("Courier New", TextEdit1.Text))
        GridView1.BestFitColumns()
        GridView2.BestFitColumns()
    End Sub

    Private Sub CheckButton2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckButton2.CheckedChanged


        If GridView1.OptionsBehavior.Editable = True Then
            GridView1.OptionsBehavior.Editable = False
            GridView2.OptionsBehavior.Editable = False
            CheckButton2.Text = "Edit Data"
        ElseIf GridView1.OptionsBehavior.Editable = False Then
            GridView1.OptionsBehavior.Editable = True
            GridView2.OptionsBehavior.Editable = False
            CheckButton2.Text = "View Data"
        End If
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click

        Try
            _adapter.SelectCommand = New SqlCommand("SELECT * FROM students", _con)
            Dim myTable = CType(GridControl1.DataSource, DataTable)
            _adapter.Update(myTable)
            XtraMessageBox.Show("Edited Student Record")
            Dim st = "Sucessfully performed the restore"
            LogFunc(mainfrm.BarStaticItem5.Caption, st)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ToggleSwitch1_Toggled(sender As Object, e As EventArgs) Handles ToggleSwitch1.Toggled
        If ToggleSwitch1.IsOn Then
            GridControl1.MainView = GridView2
            CheckButton1.Visible = False
            GridView2.BestFitColumns()
        Else
            GridControl1.MainView = GridView1
            GridView1.BestFitColumns()
            CheckButton1.Visible = True
        End If
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        If YearSession.Text = Nothing Then
            XtraMessageBox.Show("Please Specify Session")
            YearSession.Focus()
            Exit Sub
        End If
        _adapter.SelectCommand = New SqlCommand("SELECT * FROM students where Session=@session AND status=@status", _con)
        _adapter.SelectCommand.Parameters.AddWithValue("session", YearSession.Text)
        If ToggleSwitch2.IsOn Then
            
            _adapter.SelectCommand.Parameters.AddWithValue("status", "Active")
        Else
            _adapter.SelectCommand.Parameters.AddWithValue("status", "InActive")
        End If
        _con.Open()
        Dim myTable = New DataTable
        _adapter.Fill(myTable)
        GridControl1.DataSource = myTable
        _con.Close()

    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        If Not GridControl1.IsPrintingAvailable Then
            MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error")
            Return
        End If

        ' Opens the Preview window.
        GridControl1.ShowPrintPreview()
    End Sub

    Private Sub ToggleSwitch2_Toggled(sender As Object, e As EventArgs) Handles ToggleSwitch2.Toggled

        _adapter.SelectCommand = New SqlCommand("SELECT * FROM students where status=@status", _con)
        If ToggleSwitch2.IsOn Then

            _adapter.SelectCommand.Parameters.AddWithValue("status", "Active")

        Else
            _adapter.SelectCommand.Parameters.AddWithValue("status", "InActive")

        End If
        Dim myTable = New DataTable
        _con.Open()
        _adapter.Fill(myTable)
        GridControl1.DataSource = myTable
        _con.Close()
    End Sub
End Class