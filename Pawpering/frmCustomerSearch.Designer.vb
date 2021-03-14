<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerSearch
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomerSearch))
        Me.btnSearchCustomer = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.stsRecordsReturnedLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stsRecordsReturned = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblCustomerID = New System.Windows.Forms.Label()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.dgvCustomers = New System.Windows.Forms.DataGridView()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.btnLoadSelectedCustomer = New System.Windows.Forms.Button()
        Me.chkShowInactive = New System.Windows.Forms.CheckBox()
        Me.mnu_SearchMenu = New System.Windows.Forms.MenuStrip()
        Me.toolFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolCloseSearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolInstructionsStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tipCustomerSearch = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip1.SuspendLayout()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnu_SearchMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSearchCustomer
        '
        Me.btnSearchCustomer.Location = New System.Drawing.Point(730, 38)
        Me.btnSearchCustomer.Name = "btnSearchCustomer"
        Me.btnSearchCustomer.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchCustomer.TabIndex = 4
        Me.btnSearchCustomer.Text = "Search"
        Me.btnSearchCustomer.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stsRecordsReturnedLabel, Me.stsRecordsReturned})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 355)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1034, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'stsRecordsReturnedLabel
        '
        Me.stsRecordsReturnedLabel.Name = "stsRecordsReturnedLabel"
        Me.stsRecordsReturnedLabel.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.stsRecordsReturnedLabel.Size = New System.Drawing.Size(126, 17)
        Me.stsRecordsReturnedLabel.Text = "Records Returned: "
        Me.stsRecordsReturnedLabel.Visible = False
        '
        'stsRecordsReturned
        '
        Me.stsRecordsReturned.Name = "stsRecordsReturned"
        Me.stsRecordsReturned.Size = New System.Drawing.Size(13, 17)
        Me.stsRecordsReturned.Text = "0"
        Me.stsRecordsReturned.Visible = False
        '
        'lblCustomerID
        '
        Me.lblCustomerID.AutoSize = True
        Me.lblCustomerID.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerID.Location = New System.Drawing.Point(12, 42)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New System.Drawing.Size(76, 15)
        Me.lblCustomerID.TabIndex = 4
        Me.lblCustomerID.Text = "Customer ID:"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerID.Location = New System.Drawing.Point(94, 39)
        Me.txtCustomerID.MaxLength = 15
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(100, 23)
        Me.txtCustomerID.TabIndex = 1
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(287, 38)
        Me.txtFirstName.MaxLength = 55
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(170, 23)
        Me.txtFirstName.TabIndex = 2
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(214, 42)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(67, 15)
        Me.lblFirstName.TabIndex = 6
        Me.lblFirstName.Text = "First Name:"
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(550, 38)
        Me.txtLastName.MaxLength = 55
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(170, 23)
        Me.txtLastName.TabIndex = 3
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(478, 42)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(66, 15)
        Me.lblLastName.TabIndex = 8
        Me.lblLastName.Text = "Last Name:"
        '
        'dgvCustomers
        '
        Me.dgvCustomers.AllowUserToAddRows = False
        Me.dgvCustomers.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.dgvCustomers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCustomers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCustomers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvCustomers.Location = New System.Drawing.Point(12, 75)
        Me.dgvCustomers.MultiSelect = False
        Me.dgvCustomers.Name = "dgvCustomers"
        Me.dgvCustomers.RowHeadersVisible = False
        Me.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCustomers.Size = New System.Drawing.Size(1010, 266)
        Me.dgvCustomers.StandardTab = True
        Me.dgvCustomers.TabIndex = 5
        '
        'lblInstructions
        '
        Me.lblInstructions.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(499, 359)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInstructions.Size = New System.Drawing.Size(509, 15)
        Me.lblInstructions.TabIndex = 9
        Me.lblInstructions.Text = "Friendly Tip: Enter data into any field, or leave blank and click Search to show " &
    "the top 25 records."
        Me.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnLoadSelectedCustomer
        '
        Me.btnLoadSelectedCustomer.Location = New System.Drawing.Point(811, 38)
        Me.btnLoadSelectedCustomer.Name = "btnLoadSelectedCustomer"
        Me.btnLoadSelectedCustomer.Size = New System.Drawing.Size(96, 23)
        Me.btnLoadSelectedCustomer.TabIndex = 6
        Me.btnLoadSelectedCustomer.Text = "Load Customer"
        Me.btnLoadSelectedCustomer.UseVisualStyleBackColor = True
        '
        'chkShowInactive
        '
        Me.chkShowInactive.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkShowInactive.AutoSize = True
        Me.chkShowInactive.Location = New System.Drawing.Point(928, 54)
        Me.chkShowInactive.Name = "chkShowInactive"
        Me.chkShowInactive.Size = New System.Drawing.Size(94, 17)
        Me.chkShowInactive.TabIndex = 10
        Me.chkShowInactive.Text = "Show Inactive"
        Me.chkShowInactive.UseVisualStyleBackColor = True
        '
        'mnu_SearchMenu
        '
        Me.mnu_SearchMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolFileToolStripMenuItem, Me.toolInstructionsStripMenuItem})
        Me.mnu_SearchMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnu_SearchMenu.Name = "mnu_SearchMenu"
        Me.mnu_SearchMenu.Size = New System.Drawing.Size(1034, 24)
        Me.mnu_SearchMenu.TabIndex = 11
        Me.mnu_SearchMenu.Text = "MenuStrip1"
        '
        'toolFileToolStripMenuItem
        '
        Me.toolFileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolCloseSearchToolStripMenuItem})
        Me.toolFileToolStripMenuItem.Name = "toolFileToolStripMenuItem"
        Me.toolFileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.toolFileToolStripMenuItem.Text = "File"
        '
        'toolCloseSearchToolStripMenuItem
        '
        Me.toolCloseSearchToolStripMenuItem.Name = "toolCloseSearchToolStripMenuItem"
        Me.toolCloseSearchToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.toolCloseSearchToolStripMenuItem.Text = "Close Search"
        '
        'toolInstructionsStripMenuItem
        '
        Me.toolInstructionsStripMenuItem.Name = "toolInstructionsStripMenuItem"
        Me.toolInstructionsStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.toolInstructionsStripMenuItem.Text = "Instructions"
        '
        'frmCustomerSearch
        '
        Me.AcceptButton = Me.btnSearchCustomer
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 377)
        Me.Controls.Add(Me.chkShowInactive)
        Me.Controls.Add(Me.btnLoadSelectedCustomer)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.mnu_SearchMenu)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtCustomerID)
        Me.Controls.Add(Me.lblCustomerID)
        Me.Controls.Add(Me.btnSearchCustomer)
        Me.Controls.Add(Me.dgvCustomers)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnu_SearchMenu
        Me.MinimumSize = New System.Drawing.Size(1050, 416)
        Me.Name = "frmCustomerSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Search"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnu_SearchMenu.ResumeLayout(False)
        Me.mnu_SearchMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSearchCustomer As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents stsRecordsReturnedLabel As ToolStripStatusLabel
    Friend WithEvents stsRecordsReturned As ToolStripStatusLabel
    Friend WithEvents lblCustomerID As Label
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents dgvCustomers As DataGridView
    Friend WithEvents lblInstructions As Label
    Friend WithEvents btnLoadSelectedCustomer As Button
    Friend WithEvents chkShowInactive As CheckBox
    Friend WithEvents mnu_SearchMenu As MenuStrip
    Friend WithEvents toolFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolCloseSearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolInstructionsStripMenuItem As ToolStripMenuItem
    Friend WithEvents tipCustomerSearch As ToolTip
End Class
