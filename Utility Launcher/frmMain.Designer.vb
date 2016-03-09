<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabutilities = New System.Windows.Forms.TabPage()
        Me.tabConfiguration = New System.Windows.Forms.TabPage()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.grtpDetails = New System.Windows.Forms.GroupBox()
        Me.txtDisplayName = New System.Windows.Forms.TextBox()
        Me.lblDisplayName = New System.Windows.Forms.Label()
        Me.btnColor = New System.Windows.Forms.Button()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.lblPath = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.cboUtilities = New System.Windows.Forms.ComboBox()
        Me.lblUtility = New System.Windows.Forms.Label()
        Me.dlgColor = New System.Windows.Forms.ColorDialog()
        Me.icnLaunch = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.mnuLauncher = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuLaunch = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConfigure = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuShow = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrAbout = New System.Windows.Forms.Timer(Me.components)
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStartOnLogon = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRunInSystem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1.SuspendLayout()
        Me.tabConfiguration.SuspendLayout()
        Me.grtpDetails.SuspendLayout()
        Me.mnuLauncher.SuspendLayout()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tabutilities)
        Me.TabControl1.Controls.Add(Me.tabConfiguration)
        Me.TabControl1.Location = New System.Drawing.Point(0, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(956, 285)
        Me.TabControl1.TabIndex = 0
        '
        'tabutilities
        '
        Me.tabutilities.Location = New System.Drawing.Point(4, 22)
        Me.tabutilities.Name = "tabutilities"
        Me.tabutilities.Padding = New System.Windows.Forms.Padding(3)
        Me.tabutilities.Size = New System.Drawing.Size(948, 259)
        Me.tabutilities.TabIndex = 0
        Me.tabutilities.Text = "Utilities"
        Me.tabutilities.UseVisualStyleBackColor = True
        '
        'tabConfiguration
        '
        Me.tabConfiguration.Controls.Add(Me.btnDelete)
        Me.tabConfiguration.Controls.Add(Me.btnUpdate)
        Me.tabConfiguration.Controls.Add(Me.grtpDetails)
        Me.tabConfiguration.Controls.Add(Me.btnNew)
        Me.tabConfiguration.Controls.Add(Me.cboUtilities)
        Me.tabConfiguration.Controls.Add(Me.lblUtility)
        Me.tabConfiguration.Location = New System.Drawing.Point(4, 22)
        Me.tabConfiguration.Name = "tabConfiguration"
        Me.tabConfiguration.Padding = New System.Windows.Forms.Padding(3)
        Me.tabConfiguration.Size = New System.Drawing.Size(948, 259)
        Me.tabConfiguration.TabIndex = 1
        Me.tabConfiguration.Text = "Configuration"
        Me.tabConfiguration.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Location = New System.Drawing.Point(848, 218)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        Me.btnDelete.Visible = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdate.Location = New System.Drawing.Point(753, 218)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 4
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        Me.btnUpdate.Visible = False
        '
        'grtpDetails
        '
        Me.grtpDetails.Controls.Add(Me.txtDisplayName)
        Me.grtpDetails.Controls.Add(Me.lblDisplayName)
        Me.grtpDetails.Controls.Add(Me.btnColor)
        Me.grtpDetails.Controls.Add(Me.txtColor)
        Me.grtpDetails.Controls.Add(Me.lblColor)
        Me.grtpDetails.Controls.Add(Me.txtDescription)
        Me.grtpDetails.Controls.Add(Me.lblDescription)
        Me.grtpDetails.Controls.Add(Me.txtPath)
        Me.grtpDetails.Controls.Add(Me.lblPath)
        Me.grtpDetails.Controls.Add(Me.txtName)
        Me.grtpDetails.Controls.Add(Me.lblName)
        Me.grtpDetails.Location = New System.Drawing.Point(8, 81)
        Me.grtpDetails.Name = "grtpDetails"
        Me.grtpDetails.Size = New System.Drawing.Size(738, 172)
        Me.grtpDetails.TabIndex = 3
        Me.grtpDetails.TabStop = False
        Me.grtpDetails.Text = "Utility"
        '
        'txtDisplayName
        '
        Me.txtDisplayName.Location = New System.Drawing.Point(131, 45)
        Me.txtDisplayName.Name = "txtDisplayName"
        Me.txtDisplayName.ReadOnly = True
        Me.txtDisplayName.Size = New System.Drawing.Size(509, 20)
        Me.txtDisplayName.TabIndex = 11
        '
        'lblDisplayName
        '
        Me.lblDisplayName.Location = New System.Drawing.Point(5, 42)
        Me.lblDisplayName.Name = "lblDisplayName"
        Me.lblDisplayName.Size = New System.Drawing.Size(100, 23)
        Me.lblDisplayName.TabIndex = 10
        Me.lblDisplayName.Text = "Display Name:"
        Me.lblDisplayName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnColor
        '
        Me.btnColor.Location = New System.Drawing.Point(646, 130)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(75, 23)
        Me.btnColor.TabIndex = 9
        Me.btnColor.Text = "Browse"
        Me.btnColor.UseVisualStyleBackColor = True
        '
        'txtColor
        '
        Me.txtColor.Location = New System.Drawing.Point(131, 136)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.ReadOnly = True
        Me.txtColor.Size = New System.Drawing.Size(509, 20)
        Me.txtColor.TabIndex = 8
        '
        'lblColor
        '
        Me.lblColor.Location = New System.Drawing.Point(5, 130)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(100, 23)
        Me.lblColor.TabIndex = 7
        Me.lblColor.Text = "Background Color:"
        Me.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(131, 100)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(509, 20)
        Me.txtDescription.TabIndex = 6
        '
        'lblDescription
        '
        Me.lblDescription.Location = New System.Drawing.Point(5, 97)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(100, 23)
        Me.lblDescription.TabIndex = 5
        Me.lblDescription.Text = "Description:"
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(131, 71)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.ReadOnly = True
        Me.txtPath.Size = New System.Drawing.Size(509, 20)
        Me.txtPath.TabIndex = 4
        '
        'lblPath
        '
        Me.lblPath.Location = New System.Drawing.Point(5, 68)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(100, 23)
        Me.lblPath.TabIndex = 3
        Me.lblPath.Text = "Path:"
        Me.lblPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(131, 19)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(509, 20)
        Me.txtName.TabIndex = 2
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(5, 16)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(100, 23)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name:"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(630, 33)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 2
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'cboUtilities
        '
        Me.cboUtilities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUtilities.FormattingEnabled = True
        Me.cboUtilities.Location = New System.Drawing.Point(115, 35)
        Me.cboUtilities.Name = "cboUtilities"
        Me.cboUtilities.Size = New System.Drawing.Size(509, 21)
        Me.cboUtilities.Sorted = True
        Me.cboUtilities.TabIndex = 1
        '
        'lblUtility
        '
        Me.lblUtility.Location = New System.Drawing.Point(38, 37)
        Me.lblUtility.Name = "lblUtility"
        Me.lblUtility.Size = New System.Drawing.Size(62, 23)
        Me.lblUtility.TabIndex = 0
        Me.lblUtility.Text = "Utility"
        Me.lblUtility.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'icnLaunch
        '
        Me.icnLaunch.ContextMenuStrip = Me.mnuLauncher
        Me.icnLaunch.Icon = CType(resources.GetObject("icnLaunch.Icon"), System.Drawing.Icon)
        Me.icnLaunch.Text = "Utilities Launcher"
        '
        'mnuLauncher
        '
        Me.mnuLauncher.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLaunch, Me.mnuConfigure, Me.mnuShow, Me.mnuAbout, Me.ToolStripSeparator1, Me.mnuExit})
        Me.mnuLauncher.Name = "mnuLauncher"
        Me.mnuLauncher.Size = New System.Drawing.Size(140, 120)
        '
        'mnuLaunch
        '
        Me.mnuLaunch.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.mnuLaunch.Name = "mnuLaunch"
        Me.mnuLaunch.Size = New System.Drawing.Size(139, 22)
        Me.mnuLaunch.Text = "Launch"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(134, 22)
        Me.ToolStripMenuItem1.Text = "mnuLaunch1"
        '
        'mnuConfigure
        '
        Me.mnuConfigure.Name = "mnuConfigure"
        Me.mnuConfigure.Size = New System.Drawing.Size(139, 22)
        Me.mnuConfigure.Text = "Configure"
        '
        'mnuShow
        '
        Me.mnuShow.Name = "mnuShow"
        Me.mnuShow.Size = New System.Drawing.Size(139, 22)
        Me.mnuShow.Text = "Show"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(139, 22)
        Me.mnuAbout.Text = "About"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(136, 6)
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(139, 22)
        Me.mnuExit.Text = "Exit Launcher"
        '
        'tmrAbout
        '
        Me.tmrAbout.Interval = 5000
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuOptions, Me.mnuHelp})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(968, 24)
        Me.mnuMain.TabIndex = 1
        Me.mnuMain.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(35, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(92, 22)
        Me.mnuFileExit.Text = "Exit"
        '
        'mnuOptions
        '
        Me.mnuOptions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuStartOnLogon, Me.mnuRunInSystem})
        Me.mnuOptions.Name = "mnuOptions"
        Me.mnuOptions.Size = New System.Drawing.Size(56, 20)
        Me.mnuOptions.Text = "Options"
        '
        'mnuStartOnLogon
        '
        Me.mnuStartOnLogon.Name = "mnuStartOnLogon"
        Me.mnuStartOnLogon.Size = New System.Drawing.Size(167, 22)
        Me.mnuStartOnLogon.Text = "Start on Logon"
        Me.mnuStartOnLogon.Visible = False
        '
        'mnuRunInSystem
        '
        Me.mnuRunInSystem.Name = "mnuRunInSystem"
        Me.mnuRunInSystem.Size = New System.Drawing.Size(167, 22)
        Me.mnuRunInSystem.Text = "Run in System Tray"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(40, 20)
        Me.mnuHelp.Text = "Help"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.Size = New System.Drawing.Size(103, 22)
        Me.mnuHelpAbout.Text = "About"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 335)
        Me.Controls.Add(Me.mnuMain)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.tabConfiguration.ResumeLayout(False)
        Me.grtpDetails.ResumeLayout(False)
        Me.grtpDetails.PerformLayout()
        Me.mnuLauncher.ResumeLayout(False)
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabutilities As TabPage
    Friend WithEvents tabConfiguration As TabPage
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents grtpDetails As GroupBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents txtPath As TextBox
    Friend WithEvents lblPath As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents btnNew As Button
    Friend WithEvents cboUtilities As ComboBox
    Friend WithEvents lblUtility As Label
    Friend WithEvents btnColor As Button
    Friend WithEvents txtColor As TextBox
    Friend WithEvents lblColor As Label
    Friend WithEvents dlgColor As ColorDialog
    Friend WithEvents txtDisplayName As TextBox
    Friend WithEvents lblDisplayName As Label
    Friend WithEvents icnLaunch As NotifyIcon
    Friend WithEvents mnuLauncher As ContextMenuStrip
    Friend WithEvents mnuLaunch As ToolStripMenuItem
    Friend WithEvents mnuConfigure As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem
    Friend WithEvents tmrAbout As Timer
    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuOptions As ToolStripMenuItem
    Friend WithEvents mnuStartOnLogon As ToolStripMenuItem
    Friend WithEvents mnuRunInSystem As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As ToolStripMenuItem
    Friend WithEvents mnuShow As ToolStripMenuItem
End Class
