<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPawperingMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPawperingMain))
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mstNewCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mstNewPetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mstSearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mstFileToolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.mstFileAboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mstFileToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mstExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mstEditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mstEditCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mstEditPetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblCNameLabel = New System.Windows.Forms.Label()
        Me.grpCustomer = New System.Windows.Forms.GroupBox()
        Me.chkCustomerActive = New System.Windows.Forms.CheckBox()
        Me.lblCustomerSince = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhoneNumber2 = New System.Windows.Forms.Label()
        Me.lblPhoneNumber1 = New System.Windows.Forms.Label()
        Me.lblZipCode = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblAddress2 = New System.Windows.Forms.Label()
        Me.lblCustomerID = New System.Windows.Forms.Label()
        Me.lblCID = New System.Windows.Forms.Label()
        Me.lblAddress1 = New System.Windows.Forms.Label()
        Me.lblCCustomerSinceLabel = New System.Windows.Forms.Label()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.lblCEmailLabel = New System.Windows.Forms.Label()
        Me.lblCAddress2Label = New System.Windows.Forms.Label()
        Me.lblCPhone2Label = New System.Windows.Forms.Label()
        Me.lblCZipCodeLabel = New System.Windows.Forms.Label()
        Me.lblCStateLabel = New System.Windows.Forms.Label()
        Me.lblCCityLabel = New System.Windows.Forms.Label()
        Me.lblCPhone1Label = New System.Windows.Forms.Label()
        Me.lblCAddress1Label = New System.Windows.Forms.Label()
        Me.grpPetInfo = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grpPetsList = New System.Windows.Forms.GroupBox()
        Me.lbxPetsList = New System.Windows.Forms.ListBox()
        Me.btnNewCustomer = New System.Windows.Forms.Button()
        Me.btnSearchCustomers = New System.Windows.Forms.Button()
        Me.btnEditCustomer = New System.Windows.Forms.Button()
        Me.btnEditPet = New System.Windows.Forms.Button()
        Me.btnSearchPets = New System.Windows.Forms.Button()
        Me.btnNewPet = New System.Windows.Forms.Button()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMain.SuspendLayout()
        Me.grpCustomer.SuspendLayout()
        Me.grpPetInfo.SuspendLayout()
        Me.grpPetsList.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.mstEditToolStripMenuItem, Me.AdminToolStripMenuItem})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(1042, 24)
        Me.mnuMain.TabIndex = 0
        Me.mnuMain.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mstNewCustomerToolStripMenuItem, Me.mstNewPetToolStripMenuItem, Me.mstSearchToolStripMenuItem, Me.mstFileToolStripSeparator, Me.mstFileAboutToolStripMenuItem, Me.mstFileToolStripSeparator2, Me.mstExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
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
        'mstFileToolStripSeparator
        '
        Me.mstFileToolStripSeparator.Name = "mstFileToolStripSeparator"
        Me.mstFileToolStripSeparator.Size = New System.Drawing.Size(183, 6)
        '
        'mstFileAboutToolStripMenuItem
        '
        Me.mstFileAboutToolStripMenuItem.Name = "mstFileAboutToolStripMenuItem"
        Me.mstFileAboutToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.mstFileAboutToolStripMenuItem.Text = "About"
        '
        'mstFileToolStripSeparator2
        '
        Me.mstFileToolStripSeparator2.Name = "mstFileToolStripSeparator2"
        Me.mstFileToolStripSeparator2.Size = New System.Drawing.Size(183, 6)
        '
        'mstExitToolStripMenuItem
        '
        Me.mstExitToolStripMenuItem.Name = "mstExitToolStripMenuItem"
        Me.mstExitToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.mstExitToolStripMenuItem.Text = "E&xit"
        '
        'mstEditToolStripMenuItem
        '
        Me.mstEditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mstEditCustomerToolStripMenuItem, Me.mstEditPetToolStripMenuItem})
        Me.mstEditToolStripMenuItem.Name = "mstEditToolStripMenuItem"
        Me.mstEditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.mstEditToolStripMenuItem.Text = "&Edit"
        '
        'mstEditCustomerToolStripMenuItem
        '
        Me.mstEditCustomerToolStripMenuItem.Name = "mstEditCustomerToolStripMenuItem"
        Me.mstEditCustomerToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.mstEditCustomerToolStripMenuItem.Text = "Edit &Customer"
        '
        'mstEditPetToolStripMenuItem
        '
        Me.mstEditPetToolStripMenuItem.Name = "mstEditPetToolStripMenuItem"
        Me.mstEditPetToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.mstEditPetToolStripMenuItem.Text = "Edit &Pet"
        '
        'lblCNameLabel
        '
        Me.lblCNameLabel.AutoSize = True
        Me.lblCNameLabel.Location = New System.Drawing.Point(34, 43)
        Me.lblCNameLabel.Name = "lblCNameLabel"
        Me.lblCNameLabel.Size = New System.Drawing.Size(38, 13)
        Me.lblCNameLabel.TabIndex = 1
        Me.lblCNameLabel.Text = "Name:"
        '
        'grpCustomer
        '
        Me.grpCustomer.Controls.Add(Me.chkCustomerActive)
        Me.grpCustomer.Controls.Add(Me.lblCustomerSince)
        Me.grpCustomer.Controls.Add(Me.lblEmail)
        Me.grpCustomer.Controls.Add(Me.lblPhoneNumber2)
        Me.grpCustomer.Controls.Add(Me.lblPhoneNumber1)
        Me.grpCustomer.Controls.Add(Me.lblZipCode)
        Me.grpCustomer.Controls.Add(Me.lblState)
        Me.grpCustomer.Controls.Add(Me.lblCity)
        Me.grpCustomer.Controls.Add(Me.lblAddress2)
        Me.grpCustomer.Controls.Add(Me.lblCustomerID)
        Me.grpCustomer.Controls.Add(Me.lblCID)
        Me.grpCustomer.Controls.Add(Me.lblAddress1)
        Me.grpCustomer.Controls.Add(Me.lblCCustomerSinceLabel)
        Me.grpCustomer.Controls.Add(Me.lblCustomerName)
        Me.grpCustomer.Controls.Add(Me.lblCEmailLabel)
        Me.grpCustomer.Controls.Add(Me.lblCAddress2Label)
        Me.grpCustomer.Controls.Add(Me.lblCPhone2Label)
        Me.grpCustomer.Controls.Add(Me.lblCZipCodeLabel)
        Me.grpCustomer.Controls.Add(Me.lblCStateLabel)
        Me.grpCustomer.Controls.Add(Me.lblCCityLabel)
        Me.grpCustomer.Controls.Add(Me.lblCPhone1Label)
        Me.grpCustomer.Controls.Add(Me.lblCAddress1Label)
        Me.grpCustomer.Controls.Add(Me.lblCNameLabel)
        Me.grpCustomer.Location = New System.Drawing.Point(12, 60)
        Me.grpCustomer.Name = "grpCustomer"
        Me.grpCustomer.Size = New System.Drawing.Size(389, 193)
        Me.grpCustomer.TabIndex = 2
        Me.grpCustomer.TabStop = False
        Me.grpCustomer.Text = "Customer Info"
        '
        'chkCustomerActive
        '
        Me.chkCustomerActive.AutoSize = True
        Me.chkCustomerActive.Enabled = False
        Me.chkCustomerActive.Location = New System.Drawing.Point(327, 168)
        Me.chkCustomerActive.Name = "chkCustomerActive"
        Me.chkCustomerActive.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkCustomerActive.Size = New System.Drawing.Size(56, 17)
        Me.chkCustomerActive.TabIndex = 24
        Me.chkCustomerActive.TabStop = False
        Me.chkCustomerActive.Text = "Active"
        Me.chkCustomerActive.UseVisualStyleBackColor = True
        '
        'lblCustomerSince
        '
        Me.lblCustomerSince.AutoSize = True
        Me.lblCustomerSince.Location = New System.Drawing.Point(108, 169)
        Me.lblCustomerSince.Name = "lblCustomerSince"
        Me.lblCustomerSince.Size = New System.Drawing.Size(11, 13)
        Me.lblCustomerSince.TabIndex = 23
        Me.lblCustomerSince.Text = "*"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(78, 148)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(11, 13)
        Me.lblEmail.TabIndex = 22
        Me.lblEmail.Text = "*"
        '
        'lblPhoneNumber2
        '
        Me.lblPhoneNumber2.AutoSize = True
        Me.lblPhoneNumber2.Location = New System.Drawing.Point(270, 127)
        Me.lblPhoneNumber2.Name = "lblPhoneNumber2"
        Me.lblPhoneNumber2.Size = New System.Drawing.Size(11, 13)
        Me.lblPhoneNumber2.TabIndex = 21
        Me.lblPhoneNumber2.Text = "*"
        '
        'lblPhoneNumber1
        '
        Me.lblPhoneNumber1.AutoSize = True
        Me.lblPhoneNumber1.Location = New System.Drawing.Point(78, 127)
        Me.lblPhoneNumber1.Name = "lblPhoneNumber1"
        Me.lblPhoneNumber1.Size = New System.Drawing.Size(11, 13)
        Me.lblPhoneNumber1.TabIndex = 20
        Me.lblPhoneNumber1.Text = "*"
        '
        'lblZipCode
        '
        Me.lblZipCode.AutoSize = True
        Me.lblZipCode.Location = New System.Drawing.Point(301, 106)
        Me.lblZipCode.Name = "lblZipCode"
        Me.lblZipCode.Size = New System.Drawing.Size(11, 13)
        Me.lblZipCode.TabIndex = 19
        Me.lblZipCode.Text = "*"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(229, 106)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(11, 13)
        Me.lblState.TabIndex = 18
        Me.lblState.Text = "*"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(78, 106)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(11, 13)
        Me.lblCity.TabIndex = 17
        Me.lblCity.Text = "*"
        '
        'lblAddress2
        '
        Me.lblAddress2.AutoSize = True
        Me.lblAddress2.Location = New System.Drawing.Point(78, 85)
        Me.lblAddress2.Name = "lblAddress2"
        Me.lblAddress2.Size = New System.Drawing.Size(11, 13)
        Me.lblAddress2.TabIndex = 16
        Me.lblAddress2.Text = "*"
        '
        'lblCustomerID
        '
        Me.lblCustomerID.AutoSize = True
        Me.lblCustomerID.Location = New System.Drawing.Point(78, 22)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New System.Drawing.Size(11, 13)
        Me.lblCustomerID.TabIndex = 15
        Me.lblCustomerID.Text = "*"
        '
        'lblCID
        '
        Me.lblCID.AutoSize = True
        Me.lblCID.Location = New System.Drawing.Point(51, 22)
        Me.lblCID.Name = "lblCID"
        Me.lblCID.Size = New System.Drawing.Size(21, 13)
        Me.lblCID.TabIndex = 14
        Me.lblCID.Text = "ID:"
        '
        'lblAddress1
        '
        Me.lblAddress1.AutoSize = True
        Me.lblAddress1.Location = New System.Drawing.Point(78, 64)
        Me.lblAddress1.Name = "lblAddress1"
        Me.lblAddress1.Size = New System.Drawing.Size(11, 13)
        Me.lblAddress1.TabIndex = 13
        Me.lblAddress1.Text = "*"
        '
        'lblCCustomerSinceLabel
        '
        Me.lblCCustomerSinceLabel.AutoSize = True
        Me.lblCCustomerSinceLabel.Location = New System.Drawing.Point(15, 169)
        Me.lblCCustomerSinceLabel.Name = "lblCCustomerSinceLabel"
        Me.lblCCustomerSinceLabel.Size = New System.Drawing.Size(87, 13)
        Me.lblCCustomerSinceLabel.TabIndex = 12
        Me.lblCCustomerSinceLabel.Text = "Customer Since: "
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Location = New System.Drawing.Point(78, 43)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(11, 13)
        Me.lblCustomerName.TabIndex = 11
        Me.lblCustomerName.Text = "*"
        '
        'lblCEmailLabel
        '
        Me.lblCEmailLabel.AutoSize = True
        Me.lblCEmailLabel.Location = New System.Drawing.Point(31, 148)
        Me.lblCEmailLabel.Name = "lblCEmailLabel"
        Me.lblCEmailLabel.Size = New System.Drawing.Size(41, 13)
        Me.lblCEmailLabel.TabIndex = 10
        Me.lblCEmailLabel.Text = "E-mail: "
        '
        'lblCAddress2Label
        '
        Me.lblCAddress2Label.AutoSize = True
        Me.lblCAddress2Label.Location = New System.Drawing.Point(15, 85)
        Me.lblCAddress2Label.Name = "lblCAddress2Label"
        Me.lblCAddress2Label.Size = New System.Drawing.Size(57, 13)
        Me.lblCAddress2Label.TabIndex = 9
        Me.lblCAddress2Label.Text = "Address 2:"
        '
        'lblCPhone2Label
        '
        Me.lblCPhone2Label.AutoSize = True
        Me.lblCPhone2Label.Location = New System.Drawing.Point(208, 127)
        Me.lblCPhone2Label.Name = "lblCPhone2Label"
        Me.lblCPhone2Label.Size = New System.Drawing.Size(56, 13)
        Me.lblCPhone2Label.TabIndex = 8
        Me.lblCPhone2Label.Text = "Alt Phone:"
        '
        'lblCZipCodeLabel
        '
        Me.lblCZipCodeLabel.AutoSize = True
        Me.lblCZipCodeLabel.Location = New System.Drawing.Point(270, 106)
        Me.lblCZipCodeLabel.Name = "lblCZipCodeLabel"
        Me.lblCZipCodeLabel.Size = New System.Drawing.Size(25, 13)
        Me.lblCZipCodeLabel.TabIndex = 7
        Me.lblCZipCodeLabel.Text = "Zip:"
        '
        'lblCStateLabel
        '
        Me.lblCStateLabel.AutoSize = True
        Me.lblCStateLabel.Location = New System.Drawing.Point(188, 106)
        Me.lblCStateLabel.Name = "lblCStateLabel"
        Me.lblCStateLabel.Size = New System.Drawing.Size(35, 13)
        Me.lblCStateLabel.TabIndex = 6
        Me.lblCStateLabel.Text = "State:"
        '
        'lblCCityLabel
        '
        Me.lblCCityLabel.AutoSize = True
        Me.lblCCityLabel.Location = New System.Drawing.Point(45, 106)
        Me.lblCCityLabel.Name = "lblCCityLabel"
        Me.lblCCityLabel.Size = New System.Drawing.Size(27, 13)
        Me.lblCCityLabel.TabIndex = 5
        Me.lblCCityLabel.Text = "City:"
        '
        'lblCPhone1Label
        '
        Me.lblCPhone1Label.AutoSize = True
        Me.lblCPhone1Label.Location = New System.Drawing.Point(31, 127)
        Me.lblCPhone1Label.Name = "lblCPhone1Label"
        Me.lblCPhone1Label.Size = New System.Drawing.Size(41, 13)
        Me.lblCPhone1Label.TabIndex = 4
        Me.lblCPhone1Label.Text = "Phone:"
        '
        'lblCAddress1Label
        '
        Me.lblCAddress1Label.AutoSize = True
        Me.lblCAddress1Label.Location = New System.Drawing.Point(24, 64)
        Me.lblCAddress1Label.Name = "lblCAddress1Label"
        Me.lblCAddress1Label.Size = New System.Drawing.Size(48, 13)
        Me.lblCAddress1Label.TabIndex = 2
        Me.lblCAddress1Label.Text = "Address:"
        '
        'grpPetInfo
        '
        Me.grpPetInfo.Controls.Add(Me.Label1)
        Me.grpPetInfo.Controls.Add(Me.Label2)
        Me.grpPetInfo.Controls.Add(Me.Label4)
        Me.grpPetInfo.Controls.Add(Me.Label3)
        Me.grpPetInfo.Location = New System.Drawing.Point(613, 60)
        Me.grpPetInfo.Name = "grpPetInfo"
        Me.grpPetInfo.Size = New System.Drawing.Size(417, 193)
        Me.grpPetInfo.TabIndex = 3
        Me.grpPetInfo.TabStop = False
        Me.grpPetInfo.Text = "Pet Info"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "ID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(76, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(11, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "*"
        '
        'grpPetsList
        '
        Me.grpPetsList.Controls.Add(Me.lbxPetsList)
        Me.grpPetsList.Location = New System.Drawing.Point(407, 60)
        Me.grpPetsList.Name = "grpPetsList"
        Me.grpPetsList.Size = New System.Drawing.Size(200, 193)
        Me.grpPetsList.TabIndex = 4
        Me.grpPetsList.TabStop = False
        Me.grpPetsList.Text = "Pets"
        '
        'lbxPetsList
        '
        Me.lbxPetsList.FormattingEnabled = True
        Me.lbxPetsList.Location = New System.Drawing.Point(0, 20)
        Me.lbxPetsList.Name = "lbxPetsList"
        Me.lbxPetsList.Size = New System.Drawing.Size(200, 173)
        Me.lbxPetsList.TabIndex = 0
        '
        'btnNewCustomer
        '
        Me.btnNewCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewCustomer.Location = New System.Drawing.Point(12, 27)
        Me.btnNewCustomer.Name = "btnNewCustomer"
        Me.btnNewCustomer.Size = New System.Drawing.Size(88, 23)
        Me.btnNewCustomer.TabIndex = 5
        Me.btnNewCustomer.Text = "New Customer"
        Me.btnNewCustomer.UseVisualStyleBackColor = True
        '
        'btnSearchCustomers
        '
        Me.btnSearchCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchCustomers.Location = New System.Drawing.Point(200, 27)
        Me.btnSearchCustomers.Name = "btnSearchCustomers"
        Me.btnSearchCustomers.Size = New System.Drawing.Size(118, 23)
        Me.btnSearchCustomers.TabIndex = 6
        Me.btnSearchCustomers.Text = "Search Customers"
        Me.btnSearchCustomers.UseVisualStyleBackColor = True
        '
        'btnEditCustomer
        '
        Me.btnEditCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditCustomer.Location = New System.Drawing.Point(106, 27)
        Me.btnEditCustomer.Name = "btnEditCustomer"
        Me.btnEditCustomer.Size = New System.Drawing.Size(88, 23)
        Me.btnEditCustomer.TabIndex = 7
        Me.btnEditCustomer.Text = "Edit Customer"
        Me.btnEditCustomer.UseVisualStyleBackColor = True
        '
        'btnEditPet
        '
        Me.btnEditPet.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditPet.Location = New System.Drawing.Point(707, 27)
        Me.btnEditPet.Name = "btnEditPet"
        Me.btnEditPet.Size = New System.Drawing.Size(88, 23)
        Me.btnEditPet.TabIndex = 10
        Me.btnEditPet.Text = "Edit Pet"
        Me.btnEditPet.UseVisualStyleBackColor = True
        '
        'btnSearchPets
        '
        Me.btnSearchPets.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchPets.Location = New System.Drawing.Point(801, 27)
        Me.btnSearchPets.Name = "btnSearchPets"
        Me.btnSearchPets.Size = New System.Drawing.Size(118, 23)
        Me.btnSearchPets.TabIndex = 9
        Me.btnSearchPets.Text = "Search Pets"
        Me.btnSearchPets.UseVisualStyleBackColor = True
        '
        'btnNewPet
        '
        Me.btnNewPet.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewPet.Location = New System.Drawing.Point(613, 27)
        Me.btnNewPet.Name = "btnNewPet"
        Me.btnNewPet.Size = New System.Drawing.Size(88, 23)
        Me.btnNewPet.TabIndex = 8
        Me.btnNewPet.Text = "New Pet"
        Me.btnNewPet.UseVisualStyleBackColor = True
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteCustomerToolStripMenuItem})
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'DeleteCustomerToolStripMenuItem
        '
        Me.DeleteCustomerToolStripMenuItem.Name = "DeleteCustomerToolStripMenuItem"
        Me.DeleteCustomerToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DeleteCustomerToolStripMenuItem.Text = "Delete Customer"
        '
        'frmPawperingMain
        '
        Me.AcceptButton = Me.btnSearchCustomers
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1042, 538)
        Me.Controls.Add(Me.btnEditPet)
        Me.Controls.Add(Me.btnSearchPets)
        Me.Controls.Add(Me.btnNewPet)
        Me.Controls.Add(Me.btnEditCustomer)
        Me.Controls.Add(Me.btnSearchCustomers)
        Me.Controls.Add(Me.btnNewCustomer)
        Me.Controls.Add(Me.grpPetsList)
        Me.Controls.Add(Me.grpPetInfo)
        Me.Controls.Add(Me.grpCustomer)
        Me.Controls.Add(Me.mnuMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "frmPawperingMain"
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
    Friend WithEvents lblCNameLabel As Label
    Friend WithEvents grpCustomer As GroupBox
    Friend WithEvents lblCPhone2Label As Label
    Friend WithEvents lblCZipCodeLabel As Label
    Friend WithEvents lblCStateLabel As Label
    Friend WithEvents lblCCityLabel As Label
    Friend WithEvents lblCPhone1Label As Label
    Friend WithEvents lblCAddress1Label As Label
    Friend WithEvents grpPetInfo As GroupBox
    Friend WithEvents grpPetsList As GroupBox
    Friend WithEvents lbxPetsList As ListBox
    Friend WithEvents lblCAddress2Label As Label
    Friend WithEvents lblCEmailLabel As Label
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents lblCCustomerSinceLabel As Label
    Friend WithEvents lblAddress1 As Label
    Friend WithEvents lblCustomerSince As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhoneNumber2 As Label
    Friend WithEvents lblPhoneNumber1 As Label
    Friend WithEvents lblZipCode As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents lblAddress2 As Label
    Friend WithEvents lblCustomerID As Label
    Friend WithEvents lblCID As Label
    Friend WithEvents mstExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnNewCustomer As Button
    Friend WithEvents btnSearchCustomers As Button
    Friend WithEvents mstFileToolStripSeparator As ToolStripSeparator
    Friend WithEvents mstEditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mstEditCustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mstEditPetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnEditCustomer As Button
    Friend WithEvents btnEditPet As Button
    Friend WithEvents btnSearchPets As Button
    Friend WithEvents btnNewPet As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents chkCustomerActive As CheckBox
    Friend WithEvents mstFileAboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mstFileToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteCustomerToolStripMenuItem As ToolStripMenuItem
End Class
