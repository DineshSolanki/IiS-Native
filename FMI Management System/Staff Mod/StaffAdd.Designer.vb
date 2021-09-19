<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StaffAdd))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.Mobile = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SetImage = New DevExpress.XtraEditors.SimpleButton()
        Me.image = New System.Windows.Forms.PictureBox()
        Me.Designation = New DevExpress.XtraEditors.TextEdit()
        Me.Salary = New DevExpress.XtraEditors.TextEdit()
        Me.FatherName = New DevExpress.XtraEditors.TextEdit()
        Me.StaffName = New DevExpress.XtraEditors.TextEdit()
        Me.ENotes = New DevExpress.XtraEditors.MemoExEdit()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.JDate = New DevExpress.XtraEditors.DateEdit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.Mobile.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.image, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Designation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Salary.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FatherName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ENotes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.Controls.Add(Me.JDate)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Controls.Add(Me.Mobile)
        Me.GroupControl1.Controls.Add(Me.SimpleButton2)
        Me.GroupControl1.Controls.Add(Me.SetImage)
        Me.GroupControl1.Controls.Add(Me.image)
        Me.GroupControl1.Controls.Add(Me.Designation)
        Me.GroupControl1.Controls.Add(Me.Salary)
        Me.GroupControl1.Controls.Add(Me.FatherName)
        Me.GroupControl1.Controls.Add(Me.StaffName)
        Me.GroupControl1.Controls.Add(Me.ENotes)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 64)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1178, 531)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Fill Information"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton3.Appearance.Options.UseFont = True
        Me.SimpleButton3.AutoSize = True
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(1027, 429)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 38)
        Me.SimpleButton3.TabIndex = 132
        Me.SimpleButton3.Text = "Close"
        '
        'Mobile
        '
        Me.Mobile.EnterMoveNextControl = True
        Me.Mobile.Location = New System.Drawing.Point(786, 94)
        Me.Mobile.Name = "Mobile"
        Me.Mobile.Properties.Mask.EditMask = "0000000000"
        Me.Mobile.Properties.Mask.IgnoreMaskBlank = False
        Me.Mobile.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.Mobile.Size = New System.Drawing.Size(158, 20)
        Me.Mobile.TabIndex = 125
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.AutoSize = True
        Me.SimpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(1048, 385)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(40, 38)
        Me.SimpleButton2.TabIndex = 131
        Me.SimpleButton2.ToolTip = "Add Staff To Database"
        '
        'SetImage
        '
        Me.SetImage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SetImage.AutoSize = True
        Me.SetImage.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.SetImage.Image = CType(resources.GetObject("SetImage.Image"), System.Drawing.Image)
        Me.SetImage.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SetImage.Location = New System.Drawing.Point(1048, 326)
        Me.SetImage.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
        Me.SetImage.Name = "SetImage"
        Me.SetImage.Size = New System.Drawing.Size(40, 38)
        Me.SetImage.TabIndex = 130
        Me.SetImage.ToolTip = "Student Profile pic"
        '
        'image
        '
        Me.image.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.image.ErrorImage = Global.Institute_Information_System.My.Resources.Resources.no_image_50
        Me.image.Image = Global.Institute_Information_System.My.Resources.Resources.no_image_50
        Me.image.InitialImage = Global.Institute_Information_System.My.Resources.Resources.no_image_50
        Me.image.Location = New System.Drawing.Point(958, 25)
        Me.image.Name = "image"
        Me.image.Size = New System.Drawing.Size(215, 285)
        Me.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.image.TabIndex = 129
        Me.image.TabStop = False
        '
        'Designation
        '
        Me.Designation.EnterMoveNextControl = True
        Me.Designation.Location = New System.Drawing.Point(200, 149)
        Me.Designation.Name = "Designation"
        Me.Designation.Properties.Mask.EditMask = "0000-0000"
        Me.Designation.Properties.Mask.IgnoreMaskBlank = False
        Me.Designation.Size = New System.Drawing.Size(411, 20)
        Me.Designation.TabIndex = 119
        '
        'Salary
        '
        Me.Salary.EditValue = ""
        Me.Salary.EnterMoveNextControl = True
        Me.Salary.Location = New System.Drawing.Point(200, 210)
        Me.Salary.Name = "Salary"
        Me.Salary.Properties.Mask.EditMask = "c"
        Me.Salary.Properties.Mask.IgnoreMaskBlank = False
        Me.Salary.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.Salary.Size = New System.Drawing.Size(411, 20)
        Me.Salary.TabIndex = 121
        '
        'FatherName
        '
        Me.FatherName.EnterMoveNextControl = True
        Me.FatherName.Location = New System.Drawing.Point(200, 88)
        Me.FatherName.Name = "FatherName"
        Me.FatherName.Properties.Mask.EditMask = "0000-0000"
        Me.FatherName.Properties.Mask.IgnoreMaskBlank = False
        Me.FatherName.Size = New System.Drawing.Size(411, 20)
        Me.FatherName.TabIndex = 117
        '
        'StaffName
        '
        Me.StaffName.EnterMoveNextControl = True
        Me.StaffName.Location = New System.Drawing.Point(200, 41)
        Me.StaffName.Name = "StaffName"
        Me.StaffName.Properties.Mask.EditMask = "0000-0000"
        Me.StaffName.Properties.Mask.IgnoreMaskBlank = False
        Me.StaffName.Size = New System.Drawing.Size(411, 20)
        Me.StaffName.TabIndex = 113
        '
        'ENotes
        '
        Me.ENotes.Location = New System.Drawing.Point(202, 268)
        Me.ENotes.Name = "ENotes"
        Me.ENotes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ENotes.Size = New System.Drawing.Size(411, 20)
        Me.ENotes.TabIndex = 122
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(394, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(245, 43)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "Add New Staff"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(661, 91)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(84, 24)
        Me.LabelControl1.TabIndex = 133
        Me.LabelControl1.Text = "Mobile #"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(661, 32)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(96, 24)
        Me.LabelControl2.TabIndex = 134
        Me.LabelControl2.Text = "Join Date"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(23, 32)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(59, 24)
        Me.LabelControl3.TabIndex = 135
        Me.LabelControl3.Text = "Name"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(23, 79)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(146, 24)
        Me.LabelControl4.TabIndex = 136
        Me.LabelControl4.Text = "Father's Name"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(23, 201)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(64, 24)
        Me.LabelControl5.TabIndex = 137
        Me.LabelControl5.Text = "Salary"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(23, 140)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(122, 24)
        Me.LabelControl6.TabIndex = 138
        Me.LabelControl6.Text = "Designation"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!)
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(22, 259)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(117, 24)
        Me.LabelControl7.TabIndex = 139
        Me.LabelControl7.Text = "Extra Notes"
        '
        'JDate
        '
        Me.JDate.EditValue = Nothing
        Me.JDate.Location = New System.Drawing.Point(786, 40)
        Me.JDate.Name = "JDate"
        Me.JDate.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.JDate.Properties.Appearance.Options.UseFont = True
        Me.JDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.JDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.JDate.Size = New System.Drawing.Size(158, 20)
        Me.JDate.TabIndex = 140
        '
        'StaffAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1202, 607)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.GroupControl1)
        Me.DoubleBuffered = True
        Me.Name = "StaffAdd"
        Me.Text = "Add Satff"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.Mobile.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.image, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Designation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Salary.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FatherName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ENotes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Designation As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Salary As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FatherName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents StaffName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ENotes As DevExpress.XtraEditors.MemoExEdit
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SetImage As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents image As System.Windows.Forms.PictureBox
    Friend WithEvents Mobile As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents JDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
End Class
