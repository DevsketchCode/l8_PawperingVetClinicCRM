<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPawpering
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
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mstNewCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mstNewPetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mstSearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Version001ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevelopedByDavidOberlanderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.grpCustomer = New System.Windows.Forms.GroupBox()
        Me.lblCustomerPhone2 = New System.Windows.Forms.Label()
        Me.lblCustomerZip = New System.Windows.Forms.Label()
        Me.lblCustomerState = New System.Windows.Forms.Label()
        Me.lblCustomerCity = New System.Windows.Forms.Label()
        Me.lblCustomerPhone1 = New System.Windows.Forms.Label()
        Me.lnkEditCustomer = New System.Windows.Forms.LinkLabel()
        Me.lblCustomerAddress = New System.Windows.Forms.Label()
        Me.grpPetInfo = New System.Windows.Forms.GroupBox()
        Me.lnkEditPet = New System.Windows.Forms.LinkLabel()
        Me.grpPetsList = New System.Windows.Forms.GroupBox()
        Me.lbxPetsList = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCustomerEmail = New System.Windows.Forms.Label()
        Me.mnuMain.SuspendLayout()
        Me.grpCustomer.SuspendLayout()
        Me.grpPetInfo.SuspendLayout()
        Me.grpPetsList.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(800, 24)
        Me.mnuMain.TabIndex = 0
        Me.mnuMain.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mstNewCustomerToolStripMenuItem, Me.mstNewPetToolStripMenuItem, Me.mstSearchToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'mstNewCustomerToolStripMenuItem
        '
        Me.mstNewCustomerToolStripMenuItem.Name = "mstNewCustomerToolStripMenuItem"
        Me.mstNewCustomerToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.mstNewCustomerToolStripMenuItem.Text = "New &Customer"
        '
        'mstNewPetToolStripMenuItem
        '
        Me.mstNewPetToolStripMenuItem.Name = "mstNewPetToolStripMenuItem"
        Me.mstNewPetToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.mstNewPetToolStripMenuItem.Text = "New &Pet"
        '
        'mstSearchToolStripMenuItem
        '
        Me.mstSearchToolStripMenuItem.Name = "mstSearchToolStripMenuItem"
        Me.mstSearchToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.mstSearchToolStripMenuItem.Text = "&Search Customer/Pet"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Version001ToolStripMenuItem, Me.DevelopedByDavidOberlanderToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Version001ToolStripMenuItem
        '
        Me.Version001ToolStripMenuItem.Name = "Version001ToolStripMenuItem"
        Me.Version001ToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.Version001ToolStripMenuItem.Text = "Version 0.01"
        '
        'DevelopedByDavidOberlanderToolStripMenuItem
        '
        Me.DevelopedByDavidOberlanderToolStripMenuItem.Name = "DevelopedByDavidOberlanderToolStripMenuItem"
        Me.DevelopedByDavidOberlanderToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.DevelopedByDavidOberlanderToolStripMenuItem.Text = "Developed by David Oberlander"
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Location = New System.Drawing.Point(15, 20)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(38, 13)
        Me.lblCustomerName.TabIndex = 1
        Me.lblCustomerName.Text = "Name:"
        '
        'grpCustomer
        '
        Me.grpCustomer.Controls.Add(Me.lblCustomerEmail)
        Me.grpCustomer.Controls.Add(Me.Label1)
        Me.grpCustomer.Controls.Add(Me.lblCustomerPhone2)
        Me.grpCustomer.Controls.Add(Me.lblCustomerZip)
        Me.grpCustomer.Controls.Add(Me.lblCustomerState)
        Me.grpCustomer.Controls.Add(Me.lblCustomerCity)
        Me.grpCustomer.Controls.Add(Me.lblCustomerPhone1)
        Me.grpCustomer.Controls.Add(Me.lnkEditCustomer)
        Me.grpCustomer.Controls.Add(Me.lblCustomerAddress)
        Me.grpCustomer.Controls.Add(Me.lblCustomerName)
        Me.grpCustomer.Location = New System.Drawing.Point(12, 36)
        Me.grpCustomer.Name = "grpCustomer"
        Me.grpCustomer.Size = New System.Drawing.Size(282, 167)
        Me.grpCustomer.TabIndex = 2
        Me.grpCustomer.TabStop = False
        Me.grpCustomer.Text = "Customer Info"
        '
        'lblCustomerPhone2
        '
        Me.lblCustomerPhone2.AutoSize = True
        Me.lblCustomerPhone2.Location = New System.Drawing.Point(129, 104)
        Me.lblCustomerPhone2.Name = "lblCustomerPhone2"
        Me.lblCustomerPhone2.Size = New System.Drawing.Size(56, 13)
        Me.lblCustomerPhone2.TabIndex = 8
        Me.lblCustomerPhone2.Text = "Alt Phone:"
        '
        'lblCustomerZip
        '
        Me.lblCustomerZip.AutoSize = True
        Me.lblCustomerZip.Location = New System.Drawing.Point(191, 83)
        Me.lblCustomerZip.Name = "lblCustomerZip"
        Me.lblCustomerZip.Size = New System.Drawing.Size(25, 13)
        Me.lblCustomerZip.TabIndex = 7
        Me.lblCustomerZip.Text = "Zip:"
        '
        'lblCustomerState
        '
        Me.lblCustomerState.AutoSize = True
        Me.lblCustomerState.Location = New System.Drawing.Point(109, 83)
        Me.lblCustomerState.Name = "lblCustomerState"
        Me.lblCustomerState.Size = New System.Drawing.Size(35, 13)
        Me.lblCustomerState.TabIndex = 6
        Me.lblCustomerState.Text = "State:"
        '
        'lblCustomerCity
        '
        Me.lblCustomerCity.AutoSize = True
        Me.lblCustomerCity.Location = New System.Drawing.Point(15, 83)
        Me.lblCustomerCity.Name = "lblCustomerCity"
        Me.lblCustomerCity.Size = New System.Drawing.Size(27, 13)
        Me.lblCustomerCity.TabIndex = 5
        Me.lblCustomerCity.Text = "City:"
        '
        'lblCustomerPhone1
        '
        Me.lblCustomerPhone1.AutoSize = True
        Me.lblCustomerPhone1.Location = New System.Drawing.Point(15, 104)
        Me.lblCustomerPhone1.Name = "lblCustomerPhone1"
        Me.lblCustomerPhone1.Size = New System.Drawing.Size(41, 13)
        Me.lblCustomerPhone1.TabIndex = 4
        Me.lblCustomerPhone1.Text = "Phone:"
        '
        'lnkEditCustomer
        '
        Me.lnkEditCustomer.AutoSize = True
        Me.lnkEditCustomer.Location = New System.Drawing.Point(204, 146)
        Me.lnkEditCustomer.Name = "lnkEditCustomer"
        Me.lnkEditCustomer.Size = New System.Drawing.Size(72, 13)
        Me.lnkEditCustomer.TabIndex = 3
        Me.lnkEditCustomer.TabStop = True
        Me.lnkEditCustomer.Text = "Edit Customer"
        '
        'lblCustomerAddress
        '
        Me.lblCustomerAddress.AutoSize = True
        Me.lblCustomerAddress.Location = New System.Drawing.Point(15, 41)
        Me.lblCustomerAddress.Name = "lblCustomerAddress"
        Me.lblCustomerAddress.Size = New System.Drawing.Size(48, 13)
        Me.lblCustomerAddress.TabIndex = 2
        Me.lblCustomerAddress.Text = "Address:"
        '
        'grpPetInfo
        '
        Me.grpPetInfo.Controls.Add(Me.lnkEditPet)
        Me.grpPetInfo.Location = New System.Drawing.Point(506, 36)
        Me.grpPetInfo.Name = "grpPetInfo"
        Me.grpPetInfo.Size = New System.Drawing.Size(282, 167)
        Me.grpPetInfo.TabIndex = 3
        Me.grpPetInfo.TabStop = False
        Me.grpPetInfo.Text = "Pet Info"
        '
        'lnkEditPet
        '
        Me.lnkEditPet.AutoSize = True
        Me.lnkEditPet.Location = New System.Drawing.Point(232, 146)
        Me.lnkEditPet.Name = "lnkEditPet"
        Me.lnkEditPet.Size = New System.Drawing.Size(44, 13)
        Me.lnkEditPet.TabIndex = 0
        Me.lnkEditPet.TabStop = True
        Me.lnkEditPet.Text = "Edit Pet"
        '
        'grpPetsList
        '
        Me.grpPetsList.Controls.Add(Me.lbxPetsList)
        Me.grpPetsList.Location = New System.Drawing.Point(300, 36)
        Me.grpPetsList.Name = "grpPetsList"
        Me.grpPetsList.Size = New System.Drawing.Size(200, 167)
        Me.grpPetsList.TabIndex = 4
        Me.grpPetsList.TabStop = False
        Me.grpPetsList.Text = "Pets"
        '
        'lbxPetsList
        '
        Me.lbxPetsList.FormattingEnabled = True
        Me.lbxPetsList.Location = New System.Drawing.Point(0, 20)
        Me.lbxPetsList.Name = "lbxPetsList"
        Me.lbxPetsList.Size = New System.Drawing.Size(200, 147)
        Me.lbxPetsList.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Address:"
        '
        'lblCustomerEmail
        '
        Me.lblCustomerEmail.AutoSize = True
        Me.lblCustomerEmail.Location = New System.Drawing.Point(15, 125)
        Me.lblCustomerEmail.Name = "lblCustomerEmail"
        Me.lblCustomerEmail.Size = New System.Drawing.Size(41, 13)
        Me.lblCustomerEmail.TabIndex = 10
        Me.lblCustomerEmail.Text = "E-mail: "
        '
        'frmPawpering
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grpPetsList)
        Me.Controls.Add(Me.grpPetInfo)
        Me.Controls.Add(Me.grpCustomer)
        Me.Controls.Add(Me.mnuMain)
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "frmPawpering"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pawpering Pet Clinic CRM"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.grpCustomer.ResumeLayout(False)
        Me.grpCustomer.PerformLayout()
        Me.grpPetInfo.ResumeLayout(False)
        Me.grpPetInfo.PerformLayout()
        Me.grpPetsList.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mstNewCustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mstNewPetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mstSearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Version001ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DevelopedByDavidOberlanderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents grpCustomer As GroupBox
    Friend WithEvents lblCustomerPhone2 As Label
    Friend WithEvents lblCustomerZip As Label
    Friend WithEvents lblCustomerState As Label
    Friend WithEvents lblCustomerCity As Label
    Friend WithEvents lblCustomerPhone1 As Label
    Friend WithEvents lnkEditCustomer As LinkLabel
    Friend WithEvents lblCustomerAddress As Label
    Friend WithEvents grpPetInfo As GroupBox
    Friend WithEvents lnkEditPet As LinkLabel
    Friend WithEvents grpPetsList As GroupBox
    Friend WithEvents lbxPetsList As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCustomerEmail As Label
End Class
