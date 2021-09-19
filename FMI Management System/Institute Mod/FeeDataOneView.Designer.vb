<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FeeDataOneView
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
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.DataBase1 = New Institute_Information_System.DataBase()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSR_no = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClass = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPaid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FeeDataTableAdapter1 = New Institute_Information_System.DataBaseTableAdapters.FeeDataTableAdapter()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.ToggleSwitch1 = New DevExpress.XtraEditors.ToggleSwitch()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataBase1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToggleSwitch1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(433, 27)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(293, 43)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Fee Data Of Students"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataMember = "FeeData"
        Me.GridControl1.DataSource = Me.DataBase1
        Me.GridControl1.Location = New System.Drawing.Point(4, 129)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1186, 466)
        Me.GridControl1.TabIndex = 36
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'DataBase1
        '
        Me.DataBase1.DataSetName = "DataBase"
        Me.DataBase1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colDue, Me.colSR_no, Me.colName, Me.colFname, Me.colClass, Me.colPaid})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.Visible = True
        Me.colId.VisibleIndex = 0
        '
        'colDue
        '
        Me.colDue.FieldName = "Due "
        Me.colDue.Name = "colDue"
        Me.colDue.Visible = True
        Me.colDue.VisibleIndex = 5
        '
        'colSR_no
        '
        Me.colSR_no.Caption = "SR No."
        Me.colSR_no.FieldName = "SR no"
        Me.colSR_no.Name = "colSR_no"
        Me.colSR_no.Visible = True
        Me.colSR_no.VisibleIndex = 1
        '
        'colName
        '
        Me.colName.FieldName = "Name"
        Me.colName.Name = "colName"
        Me.colName.Visible = True
        Me.colName.VisibleIndex = 2
        '
        'colFname
        '
        Me.colFname.Caption = "Father's Name"
        Me.colFname.FieldName = "Fname"
        Me.colFname.Name = "colFname"
        Me.colFname.Visible = True
        Me.colFname.VisibleIndex = 3
        '
        'colClass
        '
        Me.colClass.FieldName = "Class"
        Me.colClass.Name = "colClass"
        Me.colClass.Visible = True
        Me.colClass.VisibleIndex = 4
        '
        'colPaid
        '
        Me.colPaid.Caption = "Paid Fees"
        Me.colPaid.FieldName = "Paid"
        Me.colPaid.Name = "colPaid"
        Me.colPaid.Visible = True
        Me.colPaid.VisibleIndex = 6
        '
        'FeeDataTableAdapter1
        '
        Me.FeeDataTableAdapter1.ClearBeforeFill = True
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton5.Location = New System.Drawing.Point(1106, 139)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton5.TabIndex = 37
        Me.SimpleButton5.Text = "Print Data"
        '
        'ToggleSwitch1
        '
        Me.ToggleSwitch1.Location = New System.Drawing.Point(906, 99)
        Me.ToggleSwitch1.Name = "ToggleSwitch1"
        Me.ToggleSwitch1.Properties.OffText = "All"
        Me.ToggleSwitch1.Properties.OnText = "Only Due"
        Me.ToggleSwitch1.Size = New System.Drawing.Size(128, 24)
        Me.ToggleSwitch1.TabIndex = 38
        '
        'FeeDataOneView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1202, 607)
        Me.Controls.Add(Me.ToggleSwitch1)
        Me.Controls.Add(Me.SimpleButton5)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.Label16)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.Name = "FeeDataOneView"
        Me.Text = "Fee Data"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataBase1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToggleSwitch1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents DataBase1 As Institute_Information_System.DataBase
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents FeeDataTableAdapter1 As Institute_Information_System.DataBaseTableAdapters.FeeDataTableAdapter
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPaid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSR_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClass As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ToggleSwitch1 As DevExpress.XtraEditors.ToggleSwitch
End Class
