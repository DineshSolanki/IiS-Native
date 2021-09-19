<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tc
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit2 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.listView1 = New System.Windows.Forms.ListView()
        Me.columnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.FnameCombo = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.Snamecombo = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.srcombo = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtTCNo = New DevExpress.XtraEditors.TextEdit()
        Me.txtReason = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.FnameCombo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Snamecombo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.srcombo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTCNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReason.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.TextEdit2)
        Me.GroupControl1.Controls.Add(Me.TextEdit1)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(424, 93)
        Me.GroupControl1.TabIndex = 68
        Me.GroupControl1.Text = "Select Data Via Class And Session"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(256, 37)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl1.TabIndex = 38
        Me.LabelControl1.Text = "Class"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(108, 39)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl2.TabIndex = 39
        Me.LabelControl2.Text = "Session"
        '
        'TextEdit2
        '
        Me.TextEdit2.Location = New System.Drawing.Point(216, 56)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TextEdit2.Size = New System.Drawing.Size(100, 20)
        Me.TextEdit2.TabIndex = 36
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(78, 58)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TextEdit1.Size = New System.Drawing.Size(100, 20)
        Me.TextEdit1.TabIndex = 35
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Location = New System.Drawing.Point(452, 51)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton4.TabIndex = 70
        Me.SimpleButton4.Text = "Get Data"
        '
        'listView1
        '
        Me.listView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader1, Me.columnHeader3, Me.ColumnHeader2})
        Me.listView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listView1.GridLines = True
        Me.listView1.Location = New System.Drawing.Point(12, 249)
        Me.listView1.MultiSelect = False
        Me.listView1.Name = "listView1"
        Me.listView1.Size = New System.Drawing.Size(424, 234)
        Me.listView1.TabIndex = 72
        Me.listView1.UseCompatibleStateImageBehavior = False
        Me.listView1.View = System.Windows.Forms.View.Details
        '
        'columnHeader1
        '
        Me.columnHeader1.Text = "Admission No."
        Me.columnHeader1.Width = 100
        '
        'columnHeader3
        '
        Me.columnHeader3.Text = "Student Name"
        Me.columnHeader3.Width = 250
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Status"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.LabelControl6)
        Me.GroupControl2.Controls.Add(Me.FnameCombo)
        Me.GroupControl2.Controls.Add(Me.LabelControl5)
        Me.GroupControl2.Controls.Add(Me.LabelControl3)
        Me.GroupControl2.Controls.Add(Me.LabelControl4)
        Me.GroupControl2.Controls.Add(Me.Snamecombo)
        Me.GroupControl2.Controls.Add(Me.srcombo)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 131)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(424, 93)
        Me.GroupControl2.TabIndex = 73
        Me.GroupControl2.Text = "Select Data  via SR Or Student Name"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(291, 37)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl6.TabIndex = 42
        Me.LabelControl6.Text = "Father's Name"
        '
        'FnameCombo
        '
        Me.FnameCombo.EditValue = ""
        Me.FnameCombo.Location = New System.Drawing.Point(276, 56)
        Me.FnameCombo.Name = "FnameCombo"
        Me.FnameCombo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FnameCombo.Size = New System.Drawing.Size(100, 20)
        Me.FnameCombo.TabIndex = 41
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(126, 59)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(15, 13)
        Me.LabelControl5.TabIndex = 40
        Me.LabelControl5.Text = "OR"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(187, 37)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl3.TabIndex = 38
        Me.LabelControl3.Text = "Name"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(25, 37)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl4.TabIndex = 39
        Me.LabelControl4.Text = "SR No"
        '
        'Snamecombo
        '
        Me.Snamecombo.Location = New System.Drawing.Point(156, 56)
        Me.Snamecombo.Name = "Snamecombo"
        Me.Snamecombo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Snamecombo.Size = New System.Drawing.Size(100, 20)
        Me.Snamecombo.TabIndex = 36
        '
        'srcombo
        '
        Me.srcombo.Location = New System.Drawing.Point(5, 56)
        Me.srcombo.Name = "srcombo"
        Me.srcombo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.srcombo.Size = New System.Drawing.Size(100, 20)
        Me.srcombo.TabIndex = 35
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(452, 180)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 74
        Me.SimpleButton1.Text = "Get Data"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(465, 367)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton2.TabIndex = 75
        Me.SimpleButton2.Text = "UPDATE"
        '
        'txtTCNo
        '
        Me.txtTCNo.Location = New System.Drawing.Point(452, 274)
        Me.txtTCNo.Name = "txtTCNo"
        Me.txtTCNo.Size = New System.Drawing.Size(100, 20)
        Me.txtTCNo.TabIndex = 76
        '
        'txtReason
        '
        Me.txtReason.Location = New System.Drawing.Point(452, 322)
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(100, 20)
        Me.txtReason.TabIndex = 77
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(452, 255)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl7.TabIndex = 78
        Me.LabelControl7.Text = "TC No :"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(452, 303)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl8.TabIndex = 79
        Me.LabelControl8.Text = "Reason :"
        '
        'TC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 495)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.txtReason)
        Me.Controls.Add(Me.txtTCNo)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.listView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "TC"
        Me.Text = "TC"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.FnameCombo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Snamecombo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.srcombo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTCNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReason.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Private WithEvents listView1 As System.Windows.Forms.ListView
    Private WithEvents columnHeader1 As System.Windows.Forms.ColumnHeader
    Private WithEvents columnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents FnameCombo As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Snamecombo As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents srcombo As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTCNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtReason As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
End Class
