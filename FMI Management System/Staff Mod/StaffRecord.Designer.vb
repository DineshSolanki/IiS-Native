<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffRecord
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
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CheckButton2 = New DevExpress.XtraEditors.CheckButton()
        Me.CheckButton1 = New DevExpress.XtraEditors.CheckButton()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.Les = New DevExpress.XtraEditors.SimpleButton()
        Me.mor = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(4, 74)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1195, 530)
        Me.GridControl1.TabIndex = 16
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsPrint.AutoWidth = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        '
        'CheckButton2
        '
        Me.CheckButton2.Location = New System.Drawing.Point(751, 30)
        Me.CheckButton2.Name = "CheckButton2"
        Me.CheckButton2.Size = New System.Drawing.Size(75, 23)
        Me.CheckButton2.TabIndex = 22
        Me.CheckButton2.Text = "Edit Data"
        '
        'CheckButton1
        '
        Me.CheckButton1.Location = New System.Drawing.Point(272, 29)
        Me.CheckButton1.Name = "CheckButton1"
        Me.CheckButton1.Size = New System.Drawing.Size(75, 23)
        Me.CheckButton1.TabIndex = 21
        Me.CheckButton1.Text = "Show Pic"
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(58, 30)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(124, 20)
        Me.TextEdit1.TabIndex = 20
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Location = New System.Drawing.Point(1005, 29)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton4.TabIndex = 19
        Me.SimpleButton4.Text = "Save Data"
        '
        'Les
        '
        Me.Les.Location = New System.Drawing.Point(32, 29)
        Me.Les.Name = "Les"
        Me.Les.Size = New System.Drawing.Size(20, 22)
        Me.Les.TabIndex = 18
        Me.Les.Text = "-"
        '
        'mor
        '
        Me.mor.Location = New System.Drawing.Point(188, 28)
        Me.mor.Name = "mor"
        Me.mor.Size = New System.Drawing.Size(20, 22)
        Me.mor.TabIndex = 17
        Me.mor.Text = "+"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Location = New System.Drawing.Point(1115, 28)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton5.TabIndex = 23
        Me.SimpleButton5.Text = "Print Data"
        '
        'StaffRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1202, 607)
        Me.Controls.Add(Me.SimpleButton5)
        Me.Controls.Add(Me.CheckButton2)
        Me.Controls.Add(Me.CheckButton1)
        Me.Controls.Add(Me.TextEdit1)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.Les)
        Me.Controls.Add(Me.mor)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "StaffRecord"
        Me.Text = "Staff Record"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CheckButton2 As DevExpress.XtraEditors.CheckButton
    Friend WithEvents CheckButton1 As DevExpress.XtraEditors.CheckButton
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Les As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents mor As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
End Class
