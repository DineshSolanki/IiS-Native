<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FeeStruct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FeeStruct))
        Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txttufee = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.TotalFee = New DevExpress.XtraEditors.TextEdit()
        Me.Adfee = New DevExpress.XtraEditors.TextEdit()
        Me.txtAddClass = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txttufee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalFee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Adfee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddClass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(396, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(271, 43)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "Create Fee Structure"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.PanelControl1)
        Me.GroupControl1.Controls.Add(Me.txttufee)
        Me.GroupControl1.Controls.Add(Me.SimpleButton1)
        Me.GroupControl1.Controls.Add(Me.TotalFee)
        Me.GroupControl1.Controls.Add(Me.Adfee)
        Me.GroupControl1.Controls.Add(Me.txtAddClass)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 87)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1178, 471)
        Me.GroupControl1.TabIndex = 116
        Me.GroupControl1.Text = "Fee Structure"
        '
        'txttufee
        '
        Me.txttufee.EnterMoveNextControl = True
        Me.txttufee.Location = New System.Drawing.Point(196, 149)
        Me.txttufee.Name = "txttufee"
        Me.txttufee.Properties.Mask.EditMask = "c0"
        Me.txttufee.Properties.Mask.IgnoreMaskBlank = False
        Me.txttufee.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txttufee.Size = New System.Drawing.Size(590, 20)
        Me.txttufee.TabIndex = 119
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic)
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(392, 270)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(291, 97)
        Me.SimpleButton1.TabIndex = 120
        Me.SimpleButton1.Text = "Save"
        '
        'TotalFee
        '
        Me.TotalFee.EnterMoveNextControl = True
        Me.TotalFee.Location = New System.Drawing.Point(129, 199)
        Me.TotalFee.Name = "TotalFee"
        Me.TotalFee.Properties.Mask.EditMask = "c0"
        Me.TotalFee.Properties.Mask.IgnoreMaskBlank = False
        Me.TotalFee.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TotalFee.Properties.ReadOnly = True
        Me.TotalFee.Size = New System.Drawing.Size(657, 20)
        Me.TotalFee.TabIndex = 119
        '
        'Adfee
        '
        Me.Adfee.EnterMoveNextControl = True
        Me.Adfee.Location = New System.Drawing.Point(196, 101)
        Me.Adfee.Name = "Adfee"
        Me.Adfee.Properties.Mask.EditMask = "c0"
        Me.Adfee.Properties.Mask.IgnoreMaskBlank = False
        Me.Adfee.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.Adfee.Size = New System.Drawing.Size(590, 20)
        Me.Adfee.TabIndex = 118
        '
        'txtAddClass
        '
        Me.txtAddClass.EnterMoveNextControl = True
        Me.txtAddClass.Location = New System.Drawing.Point(129, 44)
        Me.txtAddClass.Name = "txtAddClass"
        Me.txtAddClass.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtAddClass.Properties.Items.AddRange(New Object() {"Playgroup", "Nursury", "KG", "PREP", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.txtAddClass.Size = New System.Drawing.Size(657, 20)
        Me.txtAddClass.TabIndex = 116
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.AnyOf
        ConditionValidationRule1.ErrorText = "Please Enter valid Class"
        ConditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Information
        ConditionValidationRule1.Values.Add("Nursury")
        ConditionValidationRule1.Values.Add("KG")
        ConditionValidationRule1.Values.Add("PREP")
        ConditionValidationRule1.Values.Add("1")
        ConditionValidationRule1.Values.Add("2")
        ConditionValidationRule1.Values.Add("3")
        ConditionValidationRule1.Values.Add("4")
        ConditionValidationRule1.Values.Add("5")
        ConditionValidationRule1.Values.Add("6")
        ConditionValidationRule1.Values.Add("7")
        ConditionValidationRule1.Values.Add("8")
        ConditionValidationRule1.Values.Add("9")
        ConditionValidationRule1.Values.Add("10")
        ConditionValidationRule1.Values.Add("11")
        ConditionValidationRule1.Values.Add("12")
        Me.DxValidationProvider1.SetValidationRule(Me.txtAddClass, ConditionValidationRule1)
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Controls.Add(Me.SimpleButton5)
        Me.PanelControl1.Controls.Add(Me.SimpleButton2)
        Me.PanelControl1.Controls.Add(Me.GridControl1)
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1178, 511)
        Me.PanelControl1.TabIndex = 118
        Me.PanelControl1.Visible = False
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Location = New System.Drawing.Point(1016, 15)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(132, 23)
        Me.SimpleButton5.TabIndex = 15
        Me.SimpleButton5.Text = "Print Data"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(857, 15)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(134, 23)
        Me.SimpleButton2.TabIndex = 2
        Me.SimpleButton2.Text = "Save"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(6, 44)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1167, 462)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Class"
        Me.GridColumn2.FieldName = "Class"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Admision Fee"
        Me.GridColumn3.FieldName = "Admision Fee"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Fee"
        Me.GridColumn4.FieldName = "Fee"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Total Fee"
        Me.GridColumn5.FieldName = "Total Fee"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(735, 59)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Edit/View Fee Structure"
        Me.CheckEdit1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.CheckEdit1.Size = New System.Drawing.Size(145, 22)
        Me.CheckEdit1.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(16, 35)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(56, 24)
        Me.LabelControl1.TabIndex = 122
        Me.LabelControl1.Text = "Class"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(16, 92)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(149, 24)
        Me.LabelControl2.TabIndex = 123
        Me.LabelControl2.Text = "Admission Fee"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(16, 140)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(37, 24)
        Me.LabelControl3.TabIndex = 124
        Me.LabelControl3.Text = "Fee"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(16, 190)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(93, 24)
        Me.LabelControl4.TabIndex = 125
        Me.LabelControl4.Text = "Total Fee"
        '
        'FeeStruct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1202, 607)
        Me.Controls.Add(Me.CheckEdit1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.Label16)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1222, 650)
        Me.Name = "FeeStruct"
        Me.Text = "Fee Structure"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txttufee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalFee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Adfee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddClass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtAddClass As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TotalFee As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Adfee As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txttufee As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
End Class
