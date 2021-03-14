<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPet))
        Me.grpPet = New System.Windows.Forms.GroupBox()
        Me.btnSelectImage = New System.Windows.Forms.Button()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnRemoveOwner = New System.Windows.Forms.Button()
        Me.btnAddOwner = New System.Windows.Forms.Button()
        Me.cboBreed = New System.Windows.Forms.ComboBox()
        Me.cboColor = New System.Windows.Forms.ComboBox()
        Me.dtpBirthDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpDeceasedDate = New System.Windows.Forms.DateTimePicker()
        Me.lbxPetOwners = New System.Windows.Forms.ListBox()
        Me.cboSpecies = New System.Windows.Forms.ComboBox()
        Me.txtPhoto = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPetID = New System.Windows.Forms.TextBox()
        Me.picPetPhoto = New System.Windows.Forms.PictureBox()
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.lblPhoto = New System.Windows.Forms.Label()
        Me.lblDeceasedDate = New System.Windows.Forms.Label()
        Me.lblBirthDate = New System.Windows.Forms.Label()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.lblBreed = New System.Windows.Forms.Label()
        Me.lblSpecies = New System.Windows.Forms.Label()
        Me.lblOwner = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPetID = New System.Windows.Forms.Label()
        Me.btnSaveAndLoad = New System.Windows.Forms.Button()
        Me.btnClearForm = New System.Windows.Forms.Button()
        Me.ofdOpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.btnDeletePet = New System.Windows.Forms.Button()
        Me.grpPet.SuspendLayout()
        CType(Me.picPetPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpPet
        '
        Me.grpPet.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpPet.Controls.Add(Me.btnSelectImage)
        Me.grpPet.Controls.Add(Me.cboStatus)
        Me.grpPet.Controls.Add(Me.lblStatus)
        Me.grpPet.Controls.Add(Me.btnRemoveOwner)
        Me.grpPet.Controls.Add(Me.btnAddOwner)
        Me.grpPet.Controls.Add(Me.cboBreed)
        Me.grpPet.Controls.Add(Me.cboColor)
        Me.grpPet.Controls.Add(Me.dtpBirthDate)
        Me.grpPet.Controls.Add(Me.dtpDeceasedDate)
        Me.grpPet.Controls.Add(Me.lbxPetOwners)
        Me.grpPet.Controls.Add(Me.cboSpecies)
        Me.grpPet.Controls.Add(Me.txtPhoto)
        Me.grpPet.Controls.Add(Me.txtName)
        Me.grpPet.Controls.Add(Me.txtPetID)
        Me.grpPet.Controls.Add(Me.picPetPhoto)
        Me.grpPet.Controls.Add(Me.chkActive)
        Me.grpPet.Controls.Add(Me.lblPhoto)
        Me.grpPet.Controls.Add(Me.lblDeceasedDate)
        Me.grpPet.Controls.Add(Me.lblBirthDate)
        Me.grpPet.Controls.Add(Me.lblColor)
        Me.grpPet.Controls.Add(Me.lblBreed)
        Me.grpPet.Controls.Add(Me.lblSpecies)
        Me.grpPet.Controls.Add(Me.lblOwner)
        Me.grpPet.Controls.Add(Me.lblName)
        Me.grpPet.Controls.Add(Me.lblPetID)
        Me.grpPet.Location = New System.Drawing.Point(12, 12)
        Me.grpPet.Name = "grpPet"
        Me.grpPet.Size = New System.Drawing.Size(620, 434)
        Me.grpPet.TabIndex = 0
        Me.grpPet.TabStop = False
        Me.grpPet.Text = "New Pet"
        '
        'btnSelectImage
        '
        Me.btnSelectImage.Location = New System.Drawing.Point(580, 291)
        Me.btnSelectImage.Name = "btnSelectImage"
        Me.btnSelectImage.Size = New System.Drawing.Size(26, 23)
        Me.btnSelectImage.TabIndex = 16
        Me.btnSelectImage.Text = "..."
        Me.btnSelectImage.UseVisualStyleBackColor = True
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Location = New System.Drawing.Point(118, 256)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(113, 21)
        Me.cboStatus.TabIndex = 15
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(61, 259)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(37, 13)
        Me.lblStatus.TabIndex = 14
        Me.lblStatus.Text = "Status"
        '
        'btnRemoveOwner
        '
        Me.btnRemoveOwner.Enabled = False
        Me.btnRemoveOwner.Location = New System.Drawing.Point(223, 328)
        Me.btnRemoveOwner.Name = "btnRemoveOwner"
        Me.btnRemoveOwner.Size = New System.Drawing.Size(95, 23)
        Me.btnRemoveOwner.TabIndex = 12
        Me.btnRemoveOwner.Text = "Remove Owner"
        Me.btnRemoveOwner.UseVisualStyleBackColor = True
        '
        'btnAddOwner
        '
        Me.btnAddOwner.Location = New System.Drawing.Point(118, 328)
        Me.btnAddOwner.Name = "btnAddOwner"
        Me.btnAddOwner.Size = New System.Drawing.Size(95, 23)
        Me.btnAddOwner.TabIndex = 11
        Me.btnAddOwner.Text = "Add Owner"
        Me.btnAddOwner.UseVisualStyleBackColor = True
        '
        'cboBreed
        '
        Me.cboBreed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBreed.FormattingEnabled = True
        Me.cboBreed.Location = New System.Drawing.Point(118, 145)
        Me.cboBreed.Name = "cboBreed"
        Me.cboBreed.Size = New System.Drawing.Size(200, 21)
        Me.cboBreed.TabIndex = 3
        '
        'cboColor
        '
        Me.cboColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboColor.FormattingEnabled = True
        Me.cboColor.Location = New System.Drawing.Point(118, 182)
        Me.cboColor.Name = "cboColor"
        Me.cboColor.Size = New System.Drawing.Size(200, 21)
        Me.cboColor.TabIndex = 4
        '
        'dtpBirthDate
        '
        Me.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBirthDate.Location = New System.Drawing.Point(118, 217)
        Me.dtpBirthDate.Name = "dtpBirthDate"
        Me.dtpBirthDate.Size = New System.Drawing.Size(113, 20)
        Me.dtpBirthDate.TabIndex = 5
        Me.dtpBirthDate.Value = New Date(2021, 3, 12, 12, 58, 8, 0)
        '
        'dtpDeceasedDate
        '
        Me.dtpDeceasedDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDeceasedDate.Location = New System.Drawing.Point(118, 292)
        Me.dtpDeceasedDate.Name = "dtpDeceasedDate"
        Me.dtpDeceasedDate.Size = New System.Drawing.Size(113, 20)
        Me.dtpDeceasedDate.TabIndex = 6
        Me.dtpDeceasedDate.Value = New Date(2021, 3, 12, 0, 0, 0, 0)
        Me.dtpDeceasedDate.Visible = False
        '
        'lbxPetOwners
        '
        Me.lbxPetOwners.FormattingEnabled = True
        Me.lbxPetOwners.Location = New System.Drawing.Point(118, 356)
        Me.lbxPetOwners.Name = "lbxPetOwners"
        Me.lbxPetOwners.Size = New System.Drawing.Size(200, 56)
        Me.lbxPetOwners.TabIndex = 7
        '
        'cboSpecies
        '
        Me.cboSpecies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSpecies.FormattingEnabled = True
        Me.cboSpecies.Location = New System.Drawing.Point(118, 108)
        Me.cboSpecies.Name = "cboSpecies"
        Me.cboSpecies.Size = New System.Drawing.Size(200, 21)
        Me.cboSpecies.TabIndex = 2
        '
        'txtPhoto
        '
        Me.txtPhoto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPhoto.Location = New System.Drawing.Point(400, 293)
        Me.txtPhoto.MaxLength = 300
        Me.txtPhoto.Name = "txtPhoto"
        Me.txtPhoto.ReadOnly = True
        Me.txtPhoto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPhoto.Size = New System.Drawing.Size(174, 20)
        Me.txtPhoto.TabIndex = 8
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(118, 71)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(200, 20)
        Me.txtName.TabIndex = 1
        '
        'txtPetID
        '
        Me.txtPetID.Enabled = False
        Me.txtPetID.Location = New System.Drawing.Point(118, 34)
        Me.txtPetID.MaxLength = 20
        Me.txtPetID.Name = "txtPetID"
        Me.txtPetID.Size = New System.Drawing.Size(100, 20)
        Me.txtPetID.TabIndex = 0
        '
        'picPetPhoto
        '
        Me.picPetPhoto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picPetPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picPetPhoto.InitialImage = CType(resources.GetObject("picPetPhoto.InitialImage"), System.Drawing.Image)
        Me.picPetPhoto.Location = New System.Drawing.Point(356, 34)
        Me.picPetPhoto.Name = "picPetPhoto"
        Me.picPetPhoto.Size = New System.Drawing.Size(250, 250)
        Me.picPetPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPetPhoto.TabIndex = 10
        Me.picPetPhoto.TabStop = False
        '
        'chkActive
        '
        Me.chkActive.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkActive.AutoSize = True
        Me.chkActive.Checked = True
        Me.chkActive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActive.Location = New System.Drawing.Point(558, 411)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(56, 17)
        Me.chkActive.TabIndex = 9
        Me.chkActive.Text = "Active"
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'lblPhoto
        '
        Me.lblPhoto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPhoto.AutoSize = True
        Me.lblPhoto.Location = New System.Drawing.Point(353, 296)
        Me.lblPhoto.Name = "lblPhoto"
        Me.lblPhoto.Size = New System.Drawing.Size(41, 13)
        Me.lblPhoto.TabIndex = 8
        Me.lblPhoto.Text = "Photo: "
        '
        'lblDeceasedDate
        '
        Me.lblDeceasedDate.AutoSize = True
        Me.lblDeceasedDate.Location = New System.Drawing.Point(24, 296)
        Me.lblDeceasedDate.Name = "lblDeceasedDate"
        Me.lblDeceasedDate.Size = New System.Drawing.Size(88, 13)
        Me.lblDeceasedDate.TabIndex = 7
        Me.lblDeceasedDate.Text = "Deceased Date: "
        Me.lblDeceasedDate.Visible = False
        '
        'lblBirthDate
        '
        Me.lblBirthDate.AutoSize = True
        Me.lblBirthDate.Location = New System.Drawing.Point(52, 222)
        Me.lblBirthDate.Name = "lblBirthDate"
        Me.lblBirthDate.Size = New System.Drawing.Size(60, 13)
        Me.lblBirthDate.TabIndex = 6
        Me.lblBirthDate.Text = "Birth Date: "
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Location = New System.Drawing.Point(75, 185)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(37, 13)
        Me.lblColor.TabIndex = 5
        Me.lblColor.Text = "Color: "
        '
        'lblBreed
        '
        Me.lblBreed.AutoSize = True
        Me.lblBreed.Location = New System.Drawing.Point(71, 148)
        Me.lblBreed.Name = "lblBreed"
        Me.lblBreed.Size = New System.Drawing.Size(41, 13)
        Me.lblBreed.TabIndex = 4
        Me.lblBreed.Text = "Breed: "
        '
        'lblSpecies
        '
        Me.lblSpecies.AutoSize = True
        Me.lblSpecies.Location = New System.Drawing.Point(61, 111)
        Me.lblSpecies.Name = "lblSpecies"
        Me.lblSpecies.Size = New System.Drawing.Size(51, 13)
        Me.lblSpecies.TabIndex = 3
        Me.lblSpecies.Text = "Species: "
        '
        'lblOwner
        '
        Me.lblOwner.AutoSize = True
        Me.lblOwner.Location = New System.Drawing.Point(57, 333)
        Me.lblOwner.Name = "lblOwner"
        Me.lblOwner.Size = New System.Drawing.Size(55, 13)
        Me.lblOwner.TabIndex = 2
        Me.lblOwner.Text = "Owner(s): "
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(71, 74)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(41, 13)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name: "
        '
        'lblPetID
        '
        Me.lblPetID.AutoSize = True
        Me.lblPetID.Enabled = False
        Me.lblPetID.Location = New System.Drawing.Point(69, 37)
        Me.lblPetID.Name = "lblPetID"
        Me.lblPetID.Size = New System.Drawing.Size(43, 13)
        Me.lblPetID.TabIndex = 0
        Me.lblPetID.Text = "Pet ID: "
        '
        'btnSaveAndLoad
        '
        Me.btnSaveAndLoad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveAndLoad.Location = New System.Drawing.Point(492, 457)
        Me.btnSaveAndLoad.Name = "btnSaveAndLoad"
        Me.btnSaveAndLoad.Size = New System.Drawing.Size(140, 23)
        Me.btnSaveAndLoad.TabIndex = 1
        Me.btnSaveAndLoad.Text = "Save And Load Pet"
        Me.btnSaveAndLoad.UseVisualStyleBackColor = True
        '
        'btnClearForm
        '
        Me.btnClearForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClearForm.Location = New System.Drawing.Point(12, 457)
        Me.btnClearForm.Name = "btnClearForm"
        Me.btnClearForm.Size = New System.Drawing.Size(75, 23)
        Me.btnClearForm.TabIndex = 2
        Me.btnClearForm.Text = "Clear Form"
        Me.btnClearForm.UseVisualStyleBackColor = True
        '
        'ofdOpenFileDialog
        '
        Me.ofdOpenFileDialog.FileName = "OpenFileDialog"
        '
        'btnDeletePet
        '
        Me.btnDeletePet.BackColor = System.Drawing.Color.Firebrick
        Me.btnDeletePet.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnDeletePet.Location = New System.Drawing.Point(263, 453)
        Me.btnDeletePet.Name = "btnDeletePet"
        Me.btnDeletePet.Size = New System.Drawing.Size(119, 31)
        Me.btnDeletePet.TabIndex = 16
        Me.btnDeletePet.Text = "Delete Pet"
        Me.btnDeletePet.UseVisualStyleBackColor = False
        Me.btnDeletePet.Visible = False
        '
        'frmPet
        '
        Me.AcceptButton = Me.btnSaveAndLoad
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 492)
        Me.Controls.Add(Me.btnDeletePet)
        Me.Controls.Add(Me.btnClearForm)
        Me.Controls.Add(Me.btnSaveAndLoad)
        Me.Controls.Add(Me.grpPet)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmPet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pet"
        Me.grpPet.ResumeLayout(False)
        Me.grpPet.PerformLayout()
        CType(Me.picPetPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpPet As GroupBox
    Friend WithEvents chkActive As CheckBox
    Friend WithEvents lblPhoto As Label
    Friend WithEvents lblDeceasedDate As Label
    Friend WithEvents lblBirthDate As Label
    Friend WithEvents lblColor As Label
    Friend WithEvents lblBreed As Label
    Friend WithEvents lblSpecies As Label
    Friend WithEvents lblOwner As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblPetID As Label
    Friend WithEvents txtPetID As TextBox
    Friend WithEvents picPetPhoto As PictureBox
    Friend WithEvents cboSpecies As ComboBox
    Friend WithEvents txtPhoto As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lbxPetOwners As ListBox
    Friend WithEvents cboColor As ComboBox
    Friend WithEvents dtpBirthDate As DateTimePicker
    Friend WithEvents dtpDeceasedDate As DateTimePicker
    Friend WithEvents cboBreed As ComboBox
    Friend WithEvents btnSaveAndLoad As Button
    Friend WithEvents btnClearForm As Button
    Friend WithEvents btnRemoveOwner As Button
    Friend WithEvents btnAddOwner As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents btnSelectImage As Button
    Friend WithEvents ofdOpenFileDialog As OpenFileDialog
    Friend WithEvents btnDeletePet As Button
End Class
