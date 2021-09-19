<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InstituteDetail
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
        Dim Institute_NameLabel As System.Windows.Forms.Label
        Dim Principal_NameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim Phone_NumberLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim LogoLabel As System.Windows.Forms.Label
        Dim Reg_NoLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InstituteDetail))
        Me.Institute_NameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Principal_NameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.AddressTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Phone_NumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.EmailTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LogoPictureEdit = New DevExpress.XtraEditors.PictureEdit()
        Me.Reg_NoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.SetImage = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtDName = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.BGImage = New DevExpress.XtraEditors.PictureEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.IdSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        Institute_NameLabel = New System.Windows.Forms.Label()
        Principal_NameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        Phone_NumberLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        LogoLabel = New System.Windows.Forms.Label()
        Reg_NoLabel = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.Institute_NameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Principal_NameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddressTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Phone_NumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoPictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reg_NoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtDName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BGImage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Institute_NameLabel
        '
        Institute_NameLabel.AutoSize = True
        Institute_NameLabel.BackColor = System.Drawing.Color.Transparent
        Institute_NameLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Institute_NameLabel.Location = New System.Drawing.Point(5, 39)
        Institute_NameLabel.Name = "Institute_NameLabel"
        Institute_NameLabel.Size = New System.Drawing.Size(173, 24)
        Institute_NameLabel.TabIndex = 1
        Institute_NameLabel.Text = "Institute Name*:"
        '
        'Principal_NameLabel
        '
        Principal_NameLabel.AutoSize = True
        Principal_NameLabel.BackColor = System.Drawing.Color.Transparent
        Principal_NameLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!)
        Principal_NameLabel.Location = New System.Drawing.Point(5, 138)
        Principal_NameLabel.Name = "Principal_NameLabel"
        Principal_NameLabel.Size = New System.Drawing.Size(172, 24)
        Principal_NameLabel.TabIndex = 3
        Principal_NameLabel.Text = "Principal Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.BackColor = System.Drawing.Color.Transparent
        AddressLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!)
        AddressLabel.Location = New System.Drawing.Point(5, 87)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(110, 24)
        AddressLabel.TabIndex = 5
        AddressLabel.Text = "Address*:"
        '
        'Phone_NumberLabel
        '
        Phone_NumberLabel.AutoSize = True
        Phone_NumberLabel.BackColor = System.Drawing.Color.Transparent
        Phone_NumberLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!)
        Phone_NumberLabel.Location = New System.Drawing.Point(397, 189)
        Phone_NumberLabel.Name = "Phone_NumberLabel"
        Phone_NumberLabel.Size = New System.Drawing.Size(169, 24)
        Phone_NumberLabel.TabIndex = 7
        Phone_NumberLabel.Text = "Phone Number:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.BackColor = System.Drawing.Color.Transparent
        EmailLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!)
        EmailLabel.Location = New System.Drawing.Point(783, 191)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(74, 24)
        EmailLabel.TabIndex = 9
        EmailLabel.Text = "Email:"
        '
        'LogoLabel
        '
        LogoLabel.AutoSize = True
        LogoLabel.BackColor = System.Drawing.Color.Transparent
        LogoLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!)
        LogoLabel.Location = New System.Drawing.Point(1164, 34)
        LogoLabel.Name = "LogoLabel"
        LogoLabel.Size = New System.Drawing.Size(62, 24)
        LogoLabel.TabIndex = 11
        LogoLabel.Text = "Logo"
        '
        'Reg_NoLabel
        '
        Reg_NoLabel.AutoSize = True
        Reg_NoLabel.BackColor = System.Drawing.Color.Transparent
        Reg_NoLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!)
        Reg_NoLabel.Location = New System.Drawing.Point(15, 186)
        Reg_NoLabel.Name = "Reg_NoLabel"
        Reg_NoLabel.Size = New System.Drawing.Size(100, 24)
        Reg_NoLabel.TabIndex = 15
        Reg_NoLabel.Text = "Reg No*:"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(20, 240)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(21, 13)
        IdLabel.TabIndex = 16
        IdLabel.Text = "Id:"
        IdLabel.Visible = False
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.Transparent
        Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!)
        Label1.Location = New System.Drawing.Point(650, 138)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(165, 24)
        Label1.TabIndex = 21
        Label1.Text = "Director Name:"
        '
        'Institute_NameTextEdit
        '
        Me.Institute_NameTextEdit.Location = New System.Drawing.Point(192, 36)
        Me.Institute_NameTextEdit.Name = "Institute_NameTextEdit"
        Me.Institute_NameTextEdit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Institute_NameTextEdit.Properties.Appearance.Options.UseFont = True
        Me.Institute_NameTextEdit.Size = New System.Drawing.Size(937, 24)
        Me.Institute_NameTextEdit.TabIndex = 1
        '
        'Principal_NameTextEdit
        '
        Me.Principal_NameTextEdit.Location = New System.Drawing.Point(192, 142)
        Me.Principal_NameTextEdit.Name = "Principal_NameTextEdit"
        Me.Principal_NameTextEdit.Size = New System.Drawing.Size(288, 20)
        Me.Principal_NameTextEdit.TabIndex = 3
        '
        'AddressTextEdit
        '
        Me.AddressTextEdit.Location = New System.Drawing.Point(192, 92)
        Me.AddressTextEdit.Name = "AddressTextEdit"
        Me.AddressTextEdit.Size = New System.Drawing.Size(937, 20)
        Me.AddressTextEdit.TabIndex = 2
        '
        'Phone_NumberTextEdit
        '
        Me.Phone_NumberTextEdit.Location = New System.Drawing.Point(584, 195)
        Me.Phone_NumberTextEdit.Name = "Phone_NumberTextEdit"
        Me.Phone_NumberTextEdit.Properties.Mask.BeepOnError = True
        Me.Phone_NumberTextEdit.Properties.Mask.EditMask = "0000000000"
        Me.Phone_NumberTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.Phone_NumberTextEdit.Size = New System.Drawing.Size(140, 20)
        Me.Phone_NumberTextEdit.TabIndex = 5
        '
        'EmailTextEdit
        '
        Me.EmailTextEdit.Location = New System.Drawing.Point(863, 195)
        Me.EmailTextEdit.Name = "EmailTextEdit"
        Me.EmailTextEdit.Size = New System.Drawing.Size(197, 20)
        Me.EmailTextEdit.TabIndex = 5
        '
        'LogoPictureEdit
        '
        Me.LogoPictureEdit.Cursor = System.Windows.Forms.Cursors.Default
        Me.LogoPictureEdit.EditValue = Global.Institute_Information_System.My.Resources.Resources.View_File_512px
        Me.LogoPictureEdit.Location = New System.Drawing.Point(1148, 66)
        Me.LogoPictureEdit.Name = "LogoPictureEdit"
        Me.LogoPictureEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.LogoPictureEdit.Properties.InitialImage = Global.Institute_Information_System.My.Resources.Resources.View_File_512px
        Me.LogoPictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.LogoPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.LogoPictureEdit.Properties.ZoomAccelerationFactor = 1.0R
        Me.LogoPictureEdit.Size = New System.Drawing.Size(100, 96)
        Me.LogoPictureEdit.TabIndex = 6
        '
        'Reg_NoTextEdit
        '
        Me.Reg_NoTextEdit.Location = New System.Drawing.Point(192, 192)
        Me.Reg_NoTextEdit.Name = "Reg_NoTextEdit"
        Me.Reg_NoTextEdit.Size = New System.Drawing.Size(199, 20)
        Me.Reg_NoTextEdit.TabIndex = 4
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.SetImage)
        Me.GroupControl1.Controls.Add(Me.SimpleButton3)
        Me.GroupControl1.Controls.Add(Me.txtDName)
        Me.GroupControl1.Controls.Add(Label1)
        Me.GroupControl1.Controls.Add(Me.SimpleButton2)
        Me.GroupControl1.Controls.Add(Me.BGImage)
        Me.GroupControl1.Controls.Add(Me.SimpleButton1)
        Me.GroupControl1.Controls.Add(IdLabel)
        Me.GroupControl1.Controls.Add(Me.IdSpinEdit)
        Me.GroupControl1.Controls.Add(Me.Institute_NameTextEdit)
        Me.GroupControl1.Controls.Add(Reg_NoLabel)
        Me.GroupControl1.Controls.Add(Institute_NameLabel)
        Me.GroupControl1.Controls.Add(Me.Reg_NoTextEdit)
        Me.GroupControl1.Controls.Add(Me.Principal_NameTextEdit)
        Me.GroupControl1.Controls.Add(Principal_NameLabel)
        Me.GroupControl1.Controls.Add(Me.AddressTextEdit)
        Me.GroupControl1.Controls.Add(LogoLabel)
        Me.GroupControl1.Controls.Add(AddressLabel)
        Me.GroupControl1.Controls.Add(Me.LogoPictureEdit)
        Me.GroupControl1.Controls.Add(Me.Phone_NumberTextEdit)
        Me.GroupControl1.Controls.Add(EmailLabel)
        Me.GroupControl1.Controls.Add(Phone_NumberLabel)
        Me.GroupControl1.Controls.Add(Me.EmailTextEdit)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 44)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1286, 677)
        Me.GroupControl1.TabIndex = 17
        Me.GroupControl1.Text = "Institute Detail"
        '
        'SetImage
        '
        Me.SetImage.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.SetImage.Appearance.Options.UseBackColor = True
        Me.SetImage.AutoSize = True
        Me.SetImage.Image = CType(resources.GetObject("SetImage.Image"), System.Drawing.Image)
        Me.SetImage.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SetImage.Location = New System.Drawing.Point(1148, 183)
        Me.SetImage.Name = "SetImage"
        Me.SetImage.Size = New System.Drawing.Size(87, 38)
        Me.SetImage.TabIndex = 122
        Me.SetImage.Text = "Browse.."
        Me.SetImage.ToolTip = "Browse Profile pic"
        Me.SetImage.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton3.Appearance.Options.UseFont = True
        Me.SimpleButton3.AutoSize = True
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(782, 301)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 38)
        Me.SimpleButton3.TabIndex = 121
        Me.SimpleButton3.Text = "Close"
        '
        'txtDName
        '
        Me.txtDName.Location = New System.Drawing.Point(841, 142)
        Me.txtDName.Name = "txtDName"
        Me.txtDName.Size = New System.Drawing.Size(288, 20)
        Me.txtDName.TabIndex = 20
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(163, 547)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(130, 22)
        Me.SimpleButton2.TabIndex = 8
        Me.SimpleButton2.Text = "Select Background Image"
        '
        'BGImage
        '
        Me.BGImage.Cursor = System.Windows.Forms.Cursors.Default
        Me.BGImage.Location = New System.Drawing.Point(23, 292)
        Me.BGImage.Name = "BGImage"
        Me.BGImage.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.BGImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.BGImage.Properties.ZoomAccelerationFactor = 1.0R
        Me.BGImage.Size = New System.Drawing.Size(394, 249)
        Me.BGImage.TabIndex = 19
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(609, 309)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 7
        Me.SimpleButton1.Text = "Save"
        '
        'IdSpinEdit
        '
        Me.IdSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.IdSpinEdit.Location = New System.Drawing.Point(47, 237)
        Me.IdSpinEdit.Name = "IdSpinEdit"
        Me.IdSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.IdSpinEdit.Size = New System.Drawing.Size(100, 20)
        Me.IdSpinEdit.TabIndex = 17
        Me.IdSpinEdit.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'InstituteDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1310, 733)
        Me.Controls.Add(Me.GroupControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "InstituteDetail"
        Me.Text = "Institute Detail"
        CType(Me.Institute_NameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Principal_NameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddressTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Phone_NumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoPictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reg_NoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtDName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BGImage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Institute_NameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Principal_NameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AddressTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Phone_NumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EmailTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LogoPictureEdit As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents Reg_NoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents IdSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BGImage As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Friend WithEvents txtDName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SetImage As DevExpress.XtraEditors.SimpleButton
End Class
