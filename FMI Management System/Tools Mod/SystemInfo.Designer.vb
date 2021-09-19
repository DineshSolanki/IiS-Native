<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SystemInfo
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.Processor = New DevExpress.XtraTab.XtraTabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.y = New System.Windows.Forms.Label()
        Me.pid = New System.Windows.Forms.Label()
        Me.pname = New System.Windows.Forms.Label()
        Me.txtProcessorExtClock = New DevExpress.XtraEditors.TextEdit()
        Me.txtProcessorL2CacheSize = New DevExpress.XtraEditors.TextEdit()
        Me.DataWidth = New DevExpress.XtraEditors.TextEdit()
        Me.PF = New DevExpress.XtraEditors.TextEdit()
        Me.txtProcessorManufacturer = New DevExpress.XtraEditors.TextEdit()
        Me.txtProcessorClockSpeed = New DevExpress.XtraEditors.TextEdit()
        Me.txtProcessorID = New DevExpress.XtraEditors.TextEdit()
        Me.txtProcessorDescription = New DevExpress.XtraEditors.TextEdit()
        Me.txtProcessorName = New DevExpress.XtraEditors.TextEdit()
        Me.Motherboard = New DevExpress.XtraTab.XtraTabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBoardSerialNumber = New DevExpress.XtraEditors.TextEdit()
        Me.txtBoardName = New DevExpress.XtraEditors.TextEdit()
        Me.txtBoardManufacturer = New DevExpress.XtraEditors.TextEdit()
        Me.txtBoardDescription = New DevExpress.XtraEditors.TextEdit()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.Processor.SuspendLayout()
        CType(Me.txtProcessorExtClock.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProcessorL2CacheSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataWidth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProcessorManufacturer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProcessorClockSpeed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProcessorID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProcessorDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProcessorName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Motherboard.SuspendLayout()
        CType(Me.txtBoardSerialNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBoardName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBoardManufacturer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBoardDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(394, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToFileToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SaveToFileToolStripMenuItem
        '
        Me.SaveToFileToolStripMenuItem.Name = "SaveToFileToolStripMenuItem"
        Me.SaveToFileToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.SaveToFileToolStripMenuItem.Text = "Save to File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(13, 28)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.Processor
        Me.XtraTabControl1.Size = New System.Drawing.Size(369, 332)
        Me.XtraTabControl1.TabIndex = 1
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.Processor, Me.Motherboard})
        '
        'Processor
        '
        Me.Processor.Controls.Add(Me.Label9)
        Me.Processor.Controls.Add(Me.Label8)
        Me.Processor.Controls.Add(Me.Label7)
        Me.Processor.Controls.Add(Me.Label6)
        Me.Processor.Controls.Add(Me.Label5)
        Me.Processor.Controls.Add(Me.Label4)
        Me.Processor.Controls.Add(Me.y)
        Me.Processor.Controls.Add(Me.pid)
        Me.Processor.Controls.Add(Me.pname)
        Me.Processor.Controls.Add(Me.txtProcessorExtClock)
        Me.Processor.Controls.Add(Me.txtProcessorL2CacheSize)
        Me.Processor.Controls.Add(Me.DataWidth)
        Me.Processor.Controls.Add(Me.PF)
        Me.Processor.Controls.Add(Me.txtProcessorManufacturer)
        Me.Processor.Controls.Add(Me.txtProcessorClockSpeed)
        Me.Processor.Controls.Add(Me.txtProcessorID)
        Me.Processor.Controls.Add(Me.txtProcessorDescription)
        Me.Processor.Controls.Add(Me.txtProcessorName)
        Me.Processor.Name = "Processor"
        Me.Processor.Size = New System.Drawing.Size(362, 304)
        Me.Processor.Text = "Processor"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(196, 254)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Family"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(196, 208)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Data Width"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(196, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "L2 Cache Size"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 254)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Ext Clock"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Clock Speed"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Manufacturer"
        '
        'y
        '
        Me.y.AutoSize = True
        Me.y.Location = New System.Drawing.Point(20, 112)
        Me.y.Name = "y"
        Me.y.Size = New System.Drawing.Size(60, 13)
        Me.y.TabIndex = 10
        Me.y.Text = "Description"
        '
        'pid
        '
        Me.pid.AutoSize = True
        Me.pid.Location = New System.Drawing.Point(20, 73)
        Me.pid.Name = "pid"
        Me.pid.Size = New System.Drawing.Size(68, 13)
        Me.pid.TabIndex = 9
        Me.pid.Text = "Processor ID"
        '
        'pname
        '
        Me.pname.AutoSize = True
        Me.pname.Location = New System.Drawing.Point(20, 20)
        Me.pname.Name = "pname"
        Me.pname.Size = New System.Drawing.Size(84, 13)
        Me.pname.TabIndex = 2
        Me.pname.Text = "Processor Name"
        '
        'txtProcessorExtClock
        '
        Me.txtProcessorExtClock.Location = New System.Drawing.Point(12, 270)
        Me.txtProcessorExtClock.Name = "txtProcessorExtClock"
        Me.txtProcessorExtClock.Size = New System.Drawing.Size(142, 20)
        Me.txtProcessorExtClock.TabIndex = 8
        '
        'txtProcessorL2CacheSize
        '
        Me.txtProcessorL2CacheSize.Location = New System.Drawing.Point(199, 173)
        Me.txtProcessorL2CacheSize.Name = "txtProcessorL2CacheSize"
        Me.txtProcessorL2CacheSize.Size = New System.Drawing.Size(150, 20)
        Me.txtProcessorL2CacheSize.TabIndex = 7
        '
        'DataWidth
        '
        Me.DataWidth.Location = New System.Drawing.Point(199, 224)
        Me.DataWidth.Name = "DataWidth"
        Me.DataWidth.Size = New System.Drawing.Size(150, 20)
        Me.DataWidth.TabIndex = 6
        '
        'PF
        '
        Me.PF.Location = New System.Drawing.Point(199, 270)
        Me.PF.Name = "PF"
        Me.PF.Size = New System.Drawing.Size(150, 20)
        Me.PF.TabIndex = 5
        '
        'txtProcessorManufacturer
        '
        Me.txtProcessorManufacturer.Location = New System.Drawing.Point(12, 173)
        Me.txtProcessorManufacturer.Name = "txtProcessorManufacturer"
        Me.txtProcessorManufacturer.Size = New System.Drawing.Size(142, 20)
        Me.txtProcessorManufacturer.TabIndex = 4
        '
        'txtProcessorClockSpeed
        '
        Me.txtProcessorClockSpeed.Location = New System.Drawing.Point(12, 224)
        Me.txtProcessorClockSpeed.Name = "txtProcessorClockSpeed"
        Me.txtProcessorClockSpeed.Size = New System.Drawing.Size(142, 20)
        Me.txtProcessorClockSpeed.TabIndex = 3
        '
        'txtProcessorID
        '
        Me.txtProcessorID.Location = New System.Drawing.Point(12, 89)
        Me.txtProcessorID.Name = "txtProcessorID"
        Me.txtProcessorID.Size = New System.Drawing.Size(348, 20)
        Me.txtProcessorID.TabIndex = 2
        '
        'txtProcessorDescription
        '
        Me.txtProcessorDescription.Location = New System.Drawing.Point(12, 132)
        Me.txtProcessorDescription.Name = "txtProcessorDescription"
        Me.txtProcessorDescription.Size = New System.Drawing.Size(348, 20)
        Me.txtProcessorDescription.TabIndex = 1
        '
        'txtProcessorName
        '
        Me.txtProcessorName.Location = New System.Drawing.Point(12, 46)
        Me.txtProcessorName.Name = "txtProcessorName"
        Me.txtProcessorName.Size = New System.Drawing.Size(348, 20)
        Me.txtProcessorName.TabIndex = 0
        '
        'Motherboard
        '
        Me.Motherboard.Controls.Add(Me.Label10)
        Me.Motherboard.Controls.Add(Me.Label3)
        Me.Motherboard.Controls.Add(Me.Label2)
        Me.Motherboard.Controls.Add(Me.Label1)
        Me.Motherboard.Controls.Add(Me.txtBoardSerialNumber)
        Me.Motherboard.Controls.Add(Me.txtBoardName)
        Me.Motherboard.Controls.Add(Me.txtBoardManufacturer)
        Me.Motherboard.Controls.Add(Me.txtBoardDescription)
        Me.Motherboard.Name = "Motherboard"
        Me.Motherboard.Size = New System.Drawing.Size(362, 304)
        Me.Motherboard.Text = "Motherboard"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 182)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Serial Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Manufacturer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Description"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Motherboard Name"
        '
        'txtBoardSerialNumber
        '
        Me.txtBoardSerialNumber.Location = New System.Drawing.Point(12, 195)
        Me.txtBoardSerialNumber.Name = "txtBoardSerialNumber"
        Me.txtBoardSerialNumber.Size = New System.Drawing.Size(348, 20)
        Me.txtBoardSerialNumber.TabIndex = 4
        '
        'txtBoardName
        '
        Me.txtBoardName.Location = New System.Drawing.Point(12, 145)
        Me.txtBoardName.Name = "txtBoardName"
        Me.txtBoardName.Size = New System.Drawing.Size(348, 20)
        Me.txtBoardName.TabIndex = 3
        '
        'txtBoardManufacturer
        '
        Me.txtBoardManufacturer.Location = New System.Drawing.Point(12, 95)
        Me.txtBoardManufacturer.Name = "txtBoardManufacturer"
        Me.txtBoardManufacturer.Size = New System.Drawing.Size(348, 20)
        Me.txtBoardManufacturer.TabIndex = 2
        '
        'txtBoardDescription
        '
        Me.txtBoardDescription.Location = New System.Drawing.Point(12, 45)
        Me.txtBoardDescription.Name = "txtBoardDescription"
        Me.txtBoardDescription.Size = New System.Drawing.Size(348, 20)
        Me.txtBoardDescription.TabIndex = 1
        '
        'SystemInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 372)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "SystemInfo"
        Me.Text = "System Information"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.Processor.ResumeLayout(False)
        Me.Processor.PerformLayout()
        CType(Me.txtProcessorExtClock.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProcessorL2CacheSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataWidth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProcessorManufacturer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProcessorClockSpeed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProcessorID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProcessorDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProcessorName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Motherboard.ResumeLayout(False)
        Me.Motherboard.PerformLayout()
        CType(Me.txtBoardSerialNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBoardName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBoardManufacturer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBoardDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents Processor As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents y As System.Windows.Forms.Label
    Friend WithEvents pid As System.Windows.Forms.Label
    Friend WithEvents pname As System.Windows.Forms.Label
    Friend WithEvents txtProcessorExtClock As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtProcessorL2CacheSize As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DataWidth As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PF As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtProcessorManufacturer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtProcessorClockSpeed As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtProcessorID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtProcessorDescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtProcessorName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Motherboard As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBoardSerialNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtBoardName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtBoardManufacturer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtBoardDescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
