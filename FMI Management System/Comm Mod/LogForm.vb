Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports Microsoft.Office.Interop

Public Class LogForm

    Private Sub LogForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateEdit1.EditValue.date = Date.Now()
        DateEdit2.EditValue.date = Date.Now()

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Cursor = Cursors.WaitCursor
        Try
            con = New SqlConnection(My.Settings.FMIDataConnectionString)
            con.Open()
            cmd = New SqlCommand("SELECT RTRIM(UserID),RTRIM(Date),RTRIM(Operation) from logs where Date between @date1 and @date2 order by Date", con)
            cmd.Parameters.Add("@date1", SqlDbType.DateTime, 30, "Date").Value = DateEdit1.EditValue.date
            cmd.Parameters.Add("@date2", SqlDbType.DateTime, 30, "Date").Value = DateEdit2.EditValue
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            dgw.Rows.Clear()
            While (reader.Read() = True)
                dgw.Rows.Add(reader(0), reader(1), reader(2))
            End While
            con.Close()
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Cursor = Cursors.Arrow
    End Sub


    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim rowsTotal, colsTotal As Short
        Dim I, j, iC As Short
        Cursor.Current = Cursors.WaitCursor
        Dim xlApp As New Excel.Application
        Try
            Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
            xlApp.Visible = True

            rowsTotal = dgw.RowCount
            colsTotal = dgw.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = dgw.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = dgw.Rows(I).Cells(j).Value
                    Next j
                Next I
                .Rows("1:1").Font.FontStyle = "Bold"
                .Rows("1:1").Font.Size = 12

                .Cells.Columns.AutoFit()
                .Cells.Select()
                .Cells.EntireColumn.AutoFit()
                .Cells(1, 1).Select()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'RELEASE ALLOACTED RESOURCES
            Cursor.Current = Cursors.Default
            xlApp = Nothing
        End Try
    End Sub
End Class