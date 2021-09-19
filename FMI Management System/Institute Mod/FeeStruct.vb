Imports System.Data.SqlClient
Imports System.Globalization
Imports DevExpress.XtraEditors

Public Class FeeStruct
    Dim _cmd As SqlCommand
    Dim _query As String
    Dim _con As SqlConnection
    ReadOnly _adapter As New SqlDataAdapter()
    ReadOnly _db As New FMIDATADataContext
    ReadOnly _culture = CultureInfo.CreateSpecificCulture("en-IN")
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If IsAlready() Or ValueCheck() Then
            If IsAlready() Then
                XtraMessageBox.Show("Failed! Class Structure Already Existed, Please Go to Edit", "Data Already Exist")
            Else
                XtraMessageBox.Show("Please Fill All Values!", "Empty Fields")
            End If
        Else
            _query = "insert into feeStructure(class,[Total Fee],Fee,[Admision Fee]) values(@Class,@TotalFee,@fee,@adFee)"
            _con = New SqlConnection(My.Settings.FMIDATAConnectionString)
            _cmd = New SqlCommand(_query, _con)
            _cmd.Parameters.AddWithValue("Class", txtAddClass.Text)
            _cmd.Parameters.AddWithValue("TotalFee", TotalFee.Text)
            _cmd.Parameters.AddWithValue("fee", txttufee.Text)
            _cmd.Parameters.AddWithValue("adFee", Adfee.Text)
            Try

                _con.Open()
                _cmd.ExecuteNonQuery()
                _con.Close()
                XtraMessageBox.Show("succes")
            Catch ex As Exception
                XtraMessageBox.Show(ex.Message)
            End Try
        End If
        Try
            FeeStruct_Load(e, e)
        Catch ex As Exception
            ForceRefresh()
        End Try


    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click

        Try
            _adapter.SelectCommand = New SqlCommand("SELECT * FROM feeStructure", _con)
            Dim myTable = CType(GridControl1.DataSource, DataTable)
            _adapter.Update(myTable)
            XtraMessageBox.Show("Saved")
            Dim st As String = "Edited Fee Structure"
            LogFunc(mainfrm.BarStaticItem5.Caption, st)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FeeStruct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TotalFee.Properties.Mask.Culture = _culture
        Adfee.Properties.Mask.Culture = _culture
        _con = New SqlConnection(My.Settings.FMIDATAConnectionString)
        _adapter.SelectCommand = New SqlCommand("SELECT * FROM FeeStructure", _con)

        _con.Open()
        Dim myTable As DataTable = New DataTable
        _adapter.Fill(myTable)
        GridControl1.DataSource = myTable
        _con.Close()
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked = True Then
            GroupControl1.Hide()
            PanelControl1.Show()
        Else
            PanelControl1.Hide()
            GroupControl1.Show()
        End If
    End Sub

    Private Sub txttufee_EditValueChanged(sender As Object, e As EventArgs) Handles txttufee.EditValueChanged
        TotalFee.Text = CStr(CInt(txttufee.Text) + CInt(Adfee.Text))
    End Sub
    Private Function IsAlready() As Boolean
        Dim feelist = From p In _db.FeeStructures
                    Where p.Class = txtAddClass.Text
        If feelist.Count <> 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Function ValueCheck() As Boolean
        Dim flag As Boolean = False
        For Each Item In GroupControl1.Controls
            If Item.text = Nothing Then
                flag = True
            End If

        Next
        Return flag
    End Function

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        If Not GridControl1.IsPrintingAvailable Then
            MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error")
            Return
        End If

        ' Opens the Preview window.
        GridControl1.ShowPrintPreview()
    End Sub
End Class