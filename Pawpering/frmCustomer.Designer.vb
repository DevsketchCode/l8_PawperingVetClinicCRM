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
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.dteCustomerSince = New System.Windows.Forms.DateTimePicker()
        Me.cboState = New System.Windows.Forms.ComboBox()
        Me.grpCustomer = New System.Windows.Forms.GroupBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.grpCustomer.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(37, 35)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(63, 13)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "First Name: "
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(36, 67)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(64, 13)
        Me.lblLastName.TabIndex = 1
        Me.lblLastName.Text = "Last Name: "
        '
        'lblAddress1
        '
        Me.lblAddress1.AutoSize = True
        Me.lblAddress1.Location = New System.Drawing.Point(43, 99)
        Me.lblAddress1.Name = "lblAddress1"
        Me.lblAddress1.Size = New System.Drawing.Size(57, 13)
        Me.lblAddress1.TabIndex = 2
        Me.lblAddress1.Text = "Address1: "
        '
        'lblAddress2
        '
        Me.lblAddress2.AutoSize = True
        Me.lblAddress2.Location = New System.Drawing.Point(43, 131)
        Me.lblAddress2.Name = "lblAddress2"
        Me.lblAddress2.Size = New System.Drawing.Size(57, 13)
        Me.lblAddress2.TabIndex = 3
        Me.lblAddress2.Text = "Address2: "
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(70, 163)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(30, 13)
        Me.lblCity.TabIndex = 4
        Me.lblCity.Text = "City: "
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(62, 195)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(38, 13)
        Me.lblState.TabIndex = 5
        Me.lblState.Text = "State: "
        '
        'lblZipCode
        '
        Me.lblZipCode.AutoSize = True
        Me.lblZipCode.Location = New System.Drawing.Point(291, 195)
        Me.lblZipCode.Name = "lblZipCode"
        Me.lblZipCode.Size = New System.Drawing.Size(56, 13)
        Me.lblZipCode.TabIndex = 6
        Me.lblZipCode.Text = "Zip Code: "
        '
        'lblPhone1
        '
        Me.lblPhone1.AutoSize = True
        Me.lblPhone1.Location = New System.Drawing.Point(16, 227)
        Me.lblPhone1.Name = "lblPhone1"
        Me.lblPhone1.Size = New System.Drawing.Size(84, 13)
        Me.lblPhone1.TabIndex = 7
        Me.lblPhone1.Text = "Phone Number: "
        '
        'lblPhone2
        '
        Me.lblPhone2.AutoSize = True
        Me.lblPhone2.Location = New System.Drawing.Point(252, 227)
        Me.lblPhone2.Name = "lblPhone2"
        Me.lblPhone2.Size = New System.Drawing.Size(95, 13)
        Me.lblPhone2.TabIndex = 8
        Me.lblPhone2.Text = "Alternate Number: "
        '
        'lblCustomerSince
        '
        Me.lblCustomerSince.AutoSize = True
        Me.lblCustomerSince.Location = New System.Drawing.Point(13, 259)
        Me.lblCustomerSince.Name = "lblCustomerSince"
        Me.lblCustomerSince.Size = New System.Drawing.Size(87, 13)
        Me.lblCustomerSince.TabIndex = 9
        Me.lblCustomerSince.Text = "Customer Since: "
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(120, 32)
        Me.txtFirstName.MaxLength = 55
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(343, 20)
        Me.txtFirstName.TabIndex = 1
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(120, 64)
        Me.txtLastName.MaxLength = 55
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(343, 20)
        Me.txtLastName.TabIndex = 2
        '
        'txtAddress1
        '
        Me.txtAddress1.Location = New System.Drawing.Point(120, 96)
        Me.txtAddress1.MaxLength = 55
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(343, 20)
        Me.txtAddress1.TabIndex = 3
        '
        'txtAddress2
        '
        Me.txtAddress2.Location = New System.Drawing.Point(120, 128)
        Me.txtAddress2.MaxLength = 55
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(343, 20)
        Me.txtAddress2.TabIndex = 4
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(120, 160)
        Me.txtCity.MaxLength = 55
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(343, 20)
        Me.txtCity.TabIndex = 5
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(353, 192)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(110, 20)
        Me.TextBox6.TabIndex = 7
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(120, 224)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(110, 20)
        Me.TextBox7.TabIndex = 8
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(353, 224)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(110, 20)
        Me.TextBox8.TabIndex = 9
        '
        'dteCustomerSince
        '
        Me.dteCustomerSince.Location = New System.Drawing.Point(120, 256)
        Me.dteCustomerSince.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dteCustomerSince.Name = "dteCustomerSince"
        Me.dteCustomerSince.Size = New System.Drawing.Size(200, 20)
        Me.dteCustomerSince.TabIndex = 10
        Me.dteCustomerSince.Value = New Date(2021, 3, 6, 21, 33, 23, 0)
        '
        'cboState
        '
        Me.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboState.FormattingEnabled = True
        Me.cboState.Location = New System.Drawing.Point(120, 192)
        Me.cboState.Name = "cboState"
        Me.cboState.Size = New System.Drawing.Size(146, 21)
        Me.cboState.TabIndex = 6
        '
        'grpCustomer
        '
        Me.grpCustomer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCustomer.Controls.Add(Me.cboState)
        Me.grpCustomer.Controls.Add(Me.lblFirstName)
        Me.grpCustomer.Controls.Add(Me.dteCustomerSince)
        Me.grpCustomer.Controls.Add(Me.lblLastName)
        Me.grpCustomer.Controls.Add(Me.TextBox8)
        Me.grpCustomer.Controls.Add(Me.lblAddress1)
        Me.grpCustomer.Controls.Add(Me.TextBox7)
        Me.grpCustomer.Controls.Add(Me.lblAddress2)
        Me.grpCustomer.Controls.Add(Me.TextBox6)
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
        Me.grpCustomer.Size = New System.Drawing.Size(492, 290)
        Me.grpCustomer.TabIndex = 11
        Me.grpCustomer.TabStop = False
        Me.grpCustomer.Text = "New Customer"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(411, 314)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(93, 23)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 349)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.grpCustomer)
        Me.Name = "frmCustomer"
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
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents dteCustomerSince As DateTimePicker
    Friend WithEvents cboState As ComboBox
    Friend WithEvents grpCustomer As GroupBox
    Friend WithEvents btnSave As Button
End Class
