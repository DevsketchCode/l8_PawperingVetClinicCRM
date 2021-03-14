<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomer))
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblAddress1 = New System.Windows.Forms.Label()
        Me.lblAddress2 = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblZipCode = New System.Windows.Forms.Label()
        Me.lblPhone1 = New System.Windows.Forms.Label()
        Me.lblPhone2 = New System.Windows.Forms.Label()
        Me.lblCustomerSince = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtAddress1 = New System.Windows.Forms.TextBox()
        Me.txtAddress2 = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtZipCode = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber1 = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber2 = New System.Windows.Forms.TextBox()
        Me.dteCustomerSince = New System.Windows.Forms.DateTimePicker()
        Me.cboState = New System.Windows.Forms.ComboBox()
        Me.grpCustomer = New System.Windows.Forms.GroupBox()
        Me.lblCustomerID = New System.Windows.Forms.Label()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSaveAndLoad = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDeleteCustomer = New System.Windows.Forms.Button()
        Me.grpCustomer.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(38, 61)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(63, 13)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "First Name: "
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(37, 93)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(64, 13)
        Me.lblLastName.TabIndex = 1
        Me.lblLastName.Text = "Last Name: "
        '
        'lblAddress1
        '
        Me.lblAddress1.AutoSize = True
        Me.lblAddress1.Location = New System.Drawing.Point(44, 125)
        Me.lblAddress1.Name = "lblAddress1"
        Me.lblAddress1.Size = New System.Drawing.Size(57, 13)
        Me.lblAddress1.TabIndex = 2
        Me.lblAddress1.Text = "Address1: "
        '
        'lblAddress2
        '
        Me.lblAddress2.AutoSize = True
        Me.lblAddress2.Location = New System.Drawing.Point(44, 157)
        Me.lblAddress2.Name = "lblAddress2"
        Me.lblAddress2.Size = New System.Drawing.Size(57, 13)
        Me.lblAddress2.TabIndex = 3
        Me.lblAddress2.Text = "Address2: "
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(71, 189)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(30, 13)
        Me.lblCity.TabIndex = 4
        Me.lblCity.Text = "City: "
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(63, 221)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(38, 13)
        Me.lblState.TabIndex = 5
        Me.lblState.Text = "State: "
        '
        'lblZipCode
        '
        Me.lblZipCode.AutoSize = True
        Me.lblZipCode.Location = New System.Drawing.Point(291, 221)
        Me.lblZipCode.Name = "lblZipCode"
        Me.lblZipCode.Size = New System.Drawing.Size(56, 13)
        Me.lblZipCode.TabIndex = 6
        Me.lblZipCode.Text = "Zip Code: "
        '
        'lblPhone1
        '
        Me.lblPhone1.AutoSize = True
        Me.lblPhone1.Location = New System.Drawing.Point(17, 253)
        Me.lblPhone1.Name = "lblPhone1"
        Me.lblPhone1.Size = New System.Drawing.Size(84, 13)
        Me.lblPhone1.TabIndex = 7
        Me.lblPhone1.Text = "Phone Number: "
        '
        'lblPhone2
        '
        Me.lblPhone2.AutoSize = True
        Me.lblPhone2.Location = New System.Drawing.Point(252, 253)
        Me.lblPhone2.Name = "lblPhone2"
        Me.lblPhone2.Size = New System.Drawing.Size(95, 13)
        Me.lblPhone2.TabIndex = 8
        Me.lblPhone2.Text = "Alternate Number: "
        '
        'lblCustomerSince
        '
        Me.lblCustomerSince.AutoSize = True
        Me.lblCustomerSince.Location = New System.Drawing.Point(14, 317)
        Me.lblCustomerSince.Name = "lblCustomerSince"
        Me.lblCustomerSince.Size = New System.Drawing.Size(87, 13)
        Me.lblCustomerSince.TabIndex = 9
        Me.lblCustomerSince.Text = "Customer Since: "
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(120, 58)
        Me.txtFirstName.MaxLength = 50
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(343, 20)
        Me.txtFirstName.TabIndex = 1
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(120, 90)
        Me.txtLastName.MaxLength = 50
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(343, 20)
        Me.txtLastName.TabIndex = 2
        '
        'txtAddress1
        '
        Me.txtAddress1.Location = New System.Drawing.Point(120, 122)
        Me.txtAddress1.MaxLength = 55
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(343, 20)
        Me.txtAddress1.TabIndex = 3
        '
        'txtAddress2
        '
        Me.txtAddress2.Location = New System.Drawing.Point(120, 154)
        Me.txtAddress2.MaxLength = 55
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(343, 20)
        Me.txtAddress2.TabIndex = 4
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(120, 186)
        Me.txtCity.MaxLength = 50
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(343, 20)
        Me.txtCity.TabIndex = 5
        '
        'txtZipCode
        '
        Me.txtZipCode.Location = New System.Drawing.Point(353, 218)
        Me.txtZipCode.MaxLength = 10
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(110, 20)
        Me.txtZipCode.TabIndex = 7
        '
        'txtPhoneNumber1
        '
        Me.txtPhoneNumber1.Location = New System.Drawing.Point(120, 250)
        Me.txtPhoneNumber1.MaxLength = 20
        Me.txtPhoneNumber1.Name = "txtPhoneNumber1"
        Me.txtPhoneNumber1.Size = New System.Drawing.Size(110, 20)
        Me.txtPhoneNumber1.TabIndex = 8
        '
        'txtPhoneNumber2
        '
        Me.txtPhoneNumber2.Location = New System.Drawing.Point(353, 250)
        Me.txtPhoneNumber2.MaxLength = 20
        Me.txtPhoneNumber2.Name = "txtPhoneNumber2"
        Me.txtPhoneNumber2.Size = New System.Drawing.Size(110, 20)
        Me.txtPhoneNumber2.TabIndex = 9
        '
        'dteCustomerSince
        '
        Me.dteCustomerSince.Location = New System.Drawing.Point(120, 314)
        Me.dteCustomerSince.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dteCustomerSince.Name = "dteCustomerSince"
        Me.dteCustomerSince.Size = New System.Drawing.Size(200, 20)
        Me.dteCustomerSince.TabIndex = 11
        Me.dteCustomerSince.Value = New Date(2021, 3, 6, 21, 33, 23, 0)
        '
        'cboState
        '
        Me.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboState.FormattingEnabled = True
        Me.cboState.Location = New System.Drawing.Point(120, 218)
        Me.cboState.Name = "cboState"
        Me.cboState.Size = New System.Drawing.Size(146, 21)
        Me.cboState.TabIndex = 6
        '
        'grpCustomer
        '
        Me.grpCustomer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCustomer.Controls.Add(Me.lblCustomerID)
        Me.grpCustomer.Controls.Add(Me.txtCustomerID)
        Me.grpCustomer.Controls.Add(Me.chkActive)
        Me.grpCustomer.Controls.Add(Me.txtEmail)
        Me.grpCustomer.Controls.Add(Me.Label1)
        Me.grpCustomer.Controls.Add(Me.cboState)
        Me.grpCustomer.Controls.Add(Me.lblFirstName)
        Me.grpCustomer.Controls.Add(Me.dteCustomerSince)
        Me.grpCustomer.Controls.Add(Me.lblLastName)
        Me.grpCustomer.Controls.Add(Me.txtPhoneNumber2)
        Me.grpCustomer.Controls.Add(Me.lblAddress1)
        Me.grpCustomer.Controls.Add(Me.txtPhoneNumber1)
        Me.grpCustomer.Controls.Add(Me.lblAddress2)
        Me.grpCustomer.Controls.Add(Me.txtZipCode)
        Me.grpCustomer.Controls.Add(Me.lblCity)
        Me.grpCustomer.Controls.Add(Me.txtCity)
        Me.grpCustomer.Controls.Add(Me.lblState)
        Me.grpCustomer.Controls.Add(Me.txtAddress2)
        Me.grpCustomer.Controls.Add(Me.lblZipCode)
        Me.grpCustomer.Controls.Add(Me.txtAddress1)
        Me.grpCustomer.Controls.Add(Me.lblPhone1)
        Me.grpCustomer.Controls.Add(Me.txtLastName)
        Me.grpCustomer.Controls.Add(Me.lblPhone2)
        Me.grpCustomer.Controls.Add(Me.txtFirstName)
        Me.grpCustomer.Controls.Add(Me.lblCustomerSince)
        Me.grpCustomer.Location = New System.Drawing.Point(12, 12)
        Me.grpCustomer.Name = "grpCustomer"
        Me.grpCustomer.Size = New System.Drawing.Size(492, 352)
        Me.grpCustomer.TabIndex = 11
        Me.grpCustomer.TabStop = False
        Me.grpCustomer.Text = "New Customer"
        '
        'lblCustomerID
        '
        Me.lblCustomerID.AutoSize = True
        Me.lblCustomerID.Enabled = False
        Me.lblCustomerID.Location = New System.Drawing.Point(30, 27)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New System.Drawing.Size(71, 13)
        Me.lblCustomerID.TabIndex = 14
        Me.lblCustomerID.Text = "Customer ID: "
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Enabled = False
        Me.txtCustomerID.Location = New System.Drawing.Point(120, 24)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomerID.TabIndex = 13
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.Checked = True
        Me.chkActive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActive.Enabled = False
        Me.chkActive.Location = New System.Drawing.Point(407, 316)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkActive.Size = New System.Drawing.Size(56, 17)
        Me.chkActive.TabIndex = 12
        Me.chkActive.Text = "Active"
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(120, 282)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(343, 20)
        Me.txtEmail.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 285)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "E-mail: "
        '
        'btnSaveAndLoad
        '
        Me.btnSaveAndLoad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveAndLoad.Location = New System.Drawing.Point(365, 376)
        Me.btnSaveAndLoad.Name = "btnSaveAndLoad"
        Me.btnSaveAndLoad.Size = New System.Drawing.Size(139, 23)
        Me.btnSaveAndLoad.TabIndex = 12
        Me.btnSaveAndLoad.Text = "Save And Load Customer"
        Me.btnSaveAndLoad.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Location = New System.Drawing.Point(12, 376)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDeleteCustomer
        '
        Me.btnDeleteCustomer.BackColor = System.Drawing.Color.Firebrick
        Me.btnDeleteCustomer.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnDeleteCustomer.Location = New System.Drawing.Point(191, 373)
        Me.btnDeleteCustomer.Name = "btnDeleteCustomer"
        Me.btnDeleteCustomer.Size = New System.Drawing.Size(119, 29)
        Me.btnDeleteCustomer.TabIndex = 15
        Me.btnDeleteCustomer.Text = "Delete Customer"
        Me.btnDeleteCustomer.UseVisualStyleBackColor = False
        Me.btnDeleteCustomer.Visible = False
        '
        'frmCustomer
        '
        Me.AcceptButton = Me.btnSaveAndLoad
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 411)
        Me.Controls.Add(Me.btnDeleteCustomer)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSaveAndLoad)
        Me.Controls.Add(Me.grpCustomer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer"
        Me.grpCustomer.ResumeLayout(False)
        Me.grpCustomer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblAddress1 As Label
    Friend WithEvents lblAddress2 As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblZipCode As Label
    Friend WithEvents lblPhone1 As Label
    Friend WithEvents lblPhone2 As Label
    Friend WithEvents lblCustomerSince As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtAddress1 As TextBox
    Friend WithEvents txtAddress2 As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtZipCode As TextBox
    Friend WithEvents txtPhoneNumber1 As TextBox
    Friend WithEvents txtPhoneNumber2 As TextBox
    Friend WithEvents dteCustomerSince As DateTimePicker
    Friend WithEvents cboState As ComboBox
    Friend WithEvents grpCustomer As GroupBox
    Friend WithEvents btnSaveAndLoad As Button
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents chkActive As CheckBox
    Friend WithEvents lblCustomerID As Label
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents btnDeleteCustomer As Button
End Class
