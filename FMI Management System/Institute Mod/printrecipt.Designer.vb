<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Printrecipt
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
        Dim ConditionValidationRule4 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule1 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim ConditionValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule = New DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Printrecipt))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.DxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        Me.SnameCombo = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.FnameCombo = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.SrCombo = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SnameCombo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FnameCombo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SrCombo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(544, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Student Name:"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(552, 372)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 9
        Me.SimpleButton1.Text = "Print"
        '
        'DxValidationProvider1
        '
        Me.DxValidationProvider1.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.[Auto]
        '
        'SnameCombo
        '
        Me.SnameCombo.EnterMoveNextControl = True
        Me.SnameCombo.Location = New System.Drawing.Point(628, 64)
        Me.SnameCombo.Name = "SnameCombo"
        Me.SnameCombo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SnameCombo.Size = New System.Drawing.Size(113, 20)
        Me.SnameCombo.TabIndex = 19
        ConditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.AnyOf
        ConditionValidationRule4.ErrorText = "Please enter Class Of Admission"
        ConditionValidationRule4.Values.Add("Nursury")
        ConditionValidationRule4.Values.Add("KG")
        ConditionValidationRule4.Values.Add("PREP")
        ConditionValidationRule4.Values.Add("1")
        ConditionValidationRule4.Values.Add("2")
        ConditionValidationRule4.Values.Add("3")
        ConditionValidationRule4.Values.Add("4")
        ConditionValidationRule4.Values.Add("5")
        ConditionValidationRule4.Values.Add("6")
        ConditionValidationRule4.Values.Add("7")
        ConditionValidationRule4.Values.Add("8")
        ConditionValidationRule4.Values.Add("9")
        ConditionValidationRule4.Values.Add("10")
        Me.DxValidationProvider1.SetValidationRule(Me.SnameCombo, ConditionValidationRule4)
        '
        'FnameCombo
        '
        Me.FnameCombo.EnterMoveNextControl = True
        Me.FnameCombo.Location = New System.Drawing.Point(833, 64)
        Me.FnameCombo.Name = "FnameCombo"
        Me.FnameCombo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FnameCombo.Size = New System.Drawing.Size(113, 20)
        Me.FnameCombo.TabIndex = 20
        ConditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.AnyOf
        ConditionValidationRule1.ErrorText = "Please enter Class Of Admission"
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
        Me.DxValidationProvider1.SetValidationRule(Me.FnameCombo, ConditionValidationRule1)
        '
        'SrCombo
        '
        Me.SrCombo.EnterMoveNextControl = True
        Me.SrCombo.Location = New System.Drawing.Point(358, 64)
        Me.SrCombo.Name = "SrCombo"
        Me.SrCombo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SrCombo.Size = New System.Drawing.Size(113, 20)
        Me.SrCombo.TabIndex = 21
        ConditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.AnyOf
        ConditionValidationRule2.ErrorText = "Please enter Class Of Admission"
        ConditionValidationRule2.Values.Add("Nursury")
        ConditionValidationRule2.Values.Add("KG")
        ConditionValidationRule2.Values.Add("PREP")
        ConditionValidationRule2.Values.Add("1")
        ConditionValidationRule2.Values.Add("2")
        ConditionValidationRule2.Values.Add("3")
        ConditionValidationRule2.Values.Add("4")
        ConditionValidationRule2.Values.Add("5")
        ConditionValidationRule2.Values.Add("6")
        ConditionValidationRule2.Values.Add("7")
        ConditionValidationRule2.Values.Add("8")
        ConditionValidationRule2.Values.Add("9")
        ConditionValidationRule2.Values.Add("10")
        Me.DxValidationProvider1.SetValidationRule(Me.SrCombo, ConditionValidationRule2)
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(488, 63)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(21, 18)
        Me.LabelControl1.TabIndex = 10
        Me.LabelControl1.Text = "OR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(747, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Father's Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(288, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "SR Number:"
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(324, 222)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(100, 20)
        Me.TextEdit1.TabIndex = 11
        '
        'TextEdit2
        '
        Me.TextEdit2.Location = New System.Drawing.Point(536, 222)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Size = New System.Drawing.Size(100, 20)
        Me.TextEdit2.TabIndex = 12
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(222, 223)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(84, 18)
        Me.LabelControl2.TabIndex = 13
        Me.LabelControl2.Text = "Depositor :"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(662, 223)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(40, 18)
        Me.LabelControl3.TabIndex = 14
        Me.LabelControl3.Text = "Due :"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(450, 223)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(68, 18)
        Me.LabelControl4.TabIndex = 15
        Me.LabelControl4.Text = "Deposit :"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(719, 223)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(42, 18)
        Me.LabelControl5.TabIndex = 16
        Me.LabelControl5.Text = """      """
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(854, 223)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(80, 18)
        Me.LabelControl6.TabIndex = 17
        Me.LabelControl6.Text = "Total Fee :"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.BehaviorManager1.SetBehaviors(Me.LabelControl7, New DevExpress.Utils.Behaviors.Behavior() {CType(DevExpress.Utils.Behaviors.Common.FileIconBehavior.Create(GetType(DevExpress.XtraEditors.Behaviors.FileIconBehaviorSourceForLabelControl), DevExpress.Utils.Behaviors.Common.FileIconSize.Small, Global.Institute_Information_System.My.Resources.Resources.Cash_Register_512px, Nothing), DevExpress.Utils.Behaviors.Behavior)})
        Me.LabelControl7.Location = New System.Drawing.Point(951, 223)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(46, 18)
        Me.LabelControl7.TabIndex = 18
        Me.LabelControl7.Text = """       """
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.SrCombo)
        Me.GroupControl1.Controls.Add(Me.FnameCombo)
        Me.GroupControl1.Controls.Add(Me.SnameCombo)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.TextEdit2)
        Me.GroupControl1.Controls.Add(Me.TextEdit1)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 77)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1221, 278)
        Me.GroupControl1.TabIndex = 19
        Me.GroupControl1.Text = "Deposit Fee"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton3.Appearance.Options.UseFont = True
        Me.SimpleButton3.AutoSize = True
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(674, 361)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 38)
        Me.SimpleButton3.TabIndex = 121
        Me.SimpleButton3.Text = "Close"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(443, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(387, 43)
        Me.Label16.TabIndex = 122
        Me.Label16.Text = "Deposit Fee And Print Recipt"
        Me.Label16.Visible = False
        '
        'printrecipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1245, 407)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1253, 437)
        Me.Name = "printrecipt"
        Me.Text = "Deposit Fee"
        CType(Me.DxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SnameCombo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FnameCombo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SrCombo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Public WithEvents SnameCombo As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents FnameCombo As DevExpress.XtraEditors.ComboBoxEdit
    Public WithEvents SrCombo As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
