<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetailedFeeData
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
        Me.components = New System.ComponentModel.Container()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FnameCombo = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.SnameCombo = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.SrCombo = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SnameText = New DevExpress.XtraEditors.TextEdit()
        Me.FNameText = New DevExpress.XtraEditors.TextEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TotalFeeText = New DevExpress.XtraEditors.TextEdit()
        Me.TotalPaidText = New DevExpress.XtraEditors.TextEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DueText = New DevExpress.XtraEditors.TextEdit()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.MnameCombo = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.MnameText = New DevExpress.XtraEditors.TextEdit()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FnameCombo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SnameCombo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SrCombo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SnameText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FNameText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalFeeText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalPaidText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DueText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MnameCombo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MnameText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(286, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(407, 43)
        Me.Label16.TabIndex = 36
        Me.Label16.Text = "Detailed Fee Data Of Students"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(13, 112)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(338, 317)
        Me.GridControl1.TabIndex = 37
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsFind.AlwaysVisible = True
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Date "
        Me.GridColumn1.FieldName = "DateOfDeposit"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 92
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Depositor"
        Me.GridColumn2.FieldName = "Depositor"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Amount Paid"
        Me.GridColumn3.FieldName = "AmountPaid"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Month"
        Me.GridColumn4.FieldName = "Month"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        '
        'FnameCombo
        '
        Me.FnameCombo.EnterMoveNextControl = True
        Me.FnameCombo.Location = New System.Drawing.Point(492, 66)
        Me.FnameCombo.Name = "FnameCombo"
        Me.FnameCombo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FnameCombo.Size = New System.Drawing.Size(113, 20)
        Me.FnameCombo.TabIndex = 3
        '
        'SnameCombo
        '
        Me.SnameCombo.EnterMoveNextControl = True
        Me.SnameCombo.Location = New System.Drawing.Point(287, 65)
        Me.SnameCombo.Name = "SnameCombo"
        Me.SnameCombo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SnameCombo.Size = New System.Drawing.Size(113, 20)
        Me.SnameCombo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(202, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Student Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(11, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "SR Number:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(175, 64)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(21, 18)
        Me.LabelControl1.TabIndex = 40
        Me.LabelControl1.Text = "OR"
        '
        'SrCombo
        '
        Me.SrCombo.EnterMoveNextControl = True
        Me.SrCombo.Location = New System.Drawing.Point(81, 65)
        Me.SrCombo.Name = "SrCombo"
        Me.SrCombo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SrCombo.Size = New System.Drawing.Size(88, 20)
        Me.SrCombo.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(379, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Father's Name:"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(880, 64)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 5
        Me.SimpleButton1.Text = "Get Data"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(379, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Student Name:"
        '
        'SnameText
        '
        Me.SnameText.Location = New System.Drawing.Point(492, 128)
        Me.SnameText.Name = "SnameText"
        Me.SnameText.Properties.ReadOnly = True
        Me.SnameText.Size = New System.Drawing.Size(262, 20)
        Me.SnameText.TabIndex = 47
        '
        'FNameText
        '
        Me.FNameText.Location = New System.Drawing.Point(492, 163)
        Me.FNameText.Name = "FNameText"
        Me.FNameText.Properties.ReadOnly = True
        Me.FNameText.Size = New System.Drawing.Size(262, 20)
        Me.FNameText.TabIndex = 48
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(379, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Total Course Fees:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(406, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Father's Name:"
        '
        'TotalFeeText
        '
        Me.TotalFeeText.Location = New System.Drawing.Point(492, 233)
        Me.TotalFeeText.Name = "TotalFeeText"
        Me.TotalFeeText.Properties.Mask.EditMask = "c0"
        Me.TotalFeeText.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TotalFeeText.Properties.ReadOnly = True
        Me.TotalFeeText.Size = New System.Drawing.Size(262, 20)
        Me.TotalFeeText.TabIndex = 51
        '
        'TotalPaidText
        '
        Me.TotalPaidText.Location = New System.Drawing.Point(492, 273)
        Me.TotalPaidText.Name = "TotalPaidText"
        Me.TotalPaidText.Properties.Mask.EditMask = "c0"
        Me.TotalPaidText.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TotalPaidText.Properties.ReadOnly = True
        Me.TotalPaidText.Size = New System.Drawing.Size(262, 20)
        Me.TotalPaidText.TabIndex = 57
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(379, 282)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Total Paid:"
        '
        'DueText
        '
        Me.DueText.Location = New System.Drawing.Point(492, 308)
        Me.DueText.Name = "DueText"
        Me.DueText.Properties.Mask.EditMask = "c0"
        Me.DueText.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.DueText.Properties.ReadOnly = True
        Me.DueText.Size = New System.Drawing.Size(262, 20)
        Me.DueText.TabIndex = 59
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(379, 315)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 13)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "Due:"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureEdit1.Location = New System.Drawing.Point(808, 107)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.OptionsMask.MaskType = DevExpress.XtraEditors.Controls.PictureEditMaskType.RoundedRect
        Me.PictureEdit1.Properties.ReadOnly = True
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Properties.ZoomAccelerationFactor = 1.0R
        Me.PictureEdit1.Size = New System.Drawing.Size(134, 128)
        Me.PictureEdit1.TabIndex = 60
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(611, 69)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 13)
        Me.Label11.TabIndex = 61
        Me.Label11.Text = "Mother's Name:"
        '
        'MnameCombo
        '
        Me.MnameCombo.EnterMoveNextControl = True
        Me.MnameCombo.Location = New System.Drawing.Point(699, 66)
        Me.MnameCombo.Name = "MnameCombo"
        Me.MnameCombo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.MnameCombo.Size = New System.Drawing.Size(139, 20)
        Me.MnameCombo.TabIndex = 4
        '
        'MnameText
        '
        Me.MnameText.Location = New System.Drawing.Point(492, 198)
        Me.MnameText.Name = "MnameText"
        Me.MnameText.Properties.ReadOnly = True
        Me.MnameText.Size = New System.Drawing.Size(262, 20)
        Me.MnameText.TabIndex = 64
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(379, 205)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 13)
        Me.Label12.TabIndex = 63
        Me.Label12.Text = "Mother's Name:"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Location = New System.Drawing.Point(880, 35)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton5.TabIndex = 65
        Me.SimpleButton5.Text = "Print Data"
        '
        'DetailedFeeData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 432)
        Me.Controls.Add(Me.SimpleButton5)
        Me.Controls.Add(Me.MnameText)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.MnameCombo)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.DueText)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TotalPaidText)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TotalFeeText)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.FNameText)
        Me.Controls.Add(Me.SnameText)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SrCombo)
        Me.Controls.Add(Me.FnameCombo)
        Me.Controls.Add(Me.SnameCombo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.Label16)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(975, 462)
        Me.Name = "DetailedFeeData"
        Me.Text = "Detailed Fee Data"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FnameCombo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SnameCombo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SrCombo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SnameText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FNameText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalFeeText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalPaidText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DueText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MnameCombo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MnameText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents FnameCombo As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents SnameCombo As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Public WithEvents SrCombo As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SnameText As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FNameText As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TotalFeeText As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TotalPaidText As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DueText As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents MnameCombo As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents MnameText As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
End Class
