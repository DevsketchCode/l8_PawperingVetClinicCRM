<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPetHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPetHistory))
        Me.lblPetHistoryDate = New System.Windows.Forms.Label()
        Me.lblPetIDLabel = New System.Windows.Forms.Label()
        Me.lblHistoryIDLabel = New System.Windows.Forms.Label()
        Me.txtVisitReason = New System.Windows.Forms.TextBox()
        Me.lblVisitReason = New System.Windows.Forms.Label()
        Me.lblTreatment = New System.Windows.Forms.Label()
        Me.txtTreatment = New System.Windows.Forms.TextBox()
        Me.dtpHistoryDate = New System.Windows.Forms.DateTimePicker()
        Me.lblHistoryID = New System.Windows.Forms.Label()
        Me.lblPetID = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDeleteRecord = New System.Windows.Forms.Button()
        Me.lblPetName = New System.Windows.Forms.Label()
        Me.chkActiveRecord = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lblPetHistoryDate
        '
        Me.lblPetHistoryDate.AutoSize = True
        Me.lblPetHistoryDate.Location = New System.Drawing.Point(31, 57)
        Me.lblPetHistoryDate.Name = "lblPetHistoryDate"
        Me.lblPetHistoryDate.Size = New System.Drawing.Size(36, 13)
        Me.lblPetHistoryDate.TabIndex = 0
        Me.lblPetHistoryDate.Text = "Date: "
        '
        'lblPetIDLabel
        '
        Me.lblPetIDLabel.AutoSize = True
        Me.lblPetIDLabel.Location = New System.Drawing.Point(31, 27)
        Me.lblPetIDLabel.Name = "lblPetIDLabel"
        Me.lblPetIDLabel.Size = New System.Drawing.Size(43, 13)
        Me.lblPetIDLabel.TabIndex = 1
        Me.lblPetIDLabel.Text = "Pet ID: "
        '
        'lblHistoryIDLabel
        '
        Me.lblHistoryIDLabel.AutoSize = True
        Me.lblHistoryIDLabel.Location = New System.Drawing.Point(434, 27)
        Me.lblHistoryIDLabel.Name = "lblHistoryIDLabel"
        Me.lblHistoryIDLabel.Size = New System.Drawing.Size(59, 13)
        Me.lblHistoryIDLabel.TabIndex = 2
        Me.lblHistoryIDLabel.Text = "History ID: "
        '
        'txtVisitReason
        '
        Me.txtVisitReason.Location = New System.Drawing.Point(34, 103)
        Me.txtVisitReason.MaxLength = 500
        Me.txtVisitReason.Multiline = True
        Me.txtVisitReason.Name = "txtVisitReason"
        Me.txtVisitReason.Size = New System.Drawing.Size(500, 100)
        Me.txtVisitReason.TabIndex = 0
        '
        'lblVisitReason
        '
        Me.lblVisitReason.AutoSize = True
        Me.lblVisitReason.Location = New System.Drawing.Point(31, 87)
        Me.lblVisitReason.Name = "lblVisitReason"
        Me.lblVisitReason.Size = New System.Drawing.Size(84, 13)
        Me.lblVisitReason.TabIndex = 5
        Me.lblVisitReason.Text = "Reason for Visit:"
        '
        'lblTreatment
        '
        Me.lblTreatment.AutoSize = True
        Me.lblTreatment.Location = New System.Drawing.Point(31, 223)
        Me.lblTreatment.Name = "lblTreatment"
        Me.lblTreatment.Size = New System.Drawing.Size(58, 13)
        Me.lblTreatment.TabIndex = 6
        Me.lblTreatment.Text = "Treatment:"
        '
        'txtTreatment
        '
        Me.txtTreatment.Location = New System.Drawing.Point(34, 239)
        Me.txtTreatment.MaxLength = 500
        Me.txtTreatment.Multiline = True
        Me.txtTreatment.Name = "txtTreatment"
        Me.txtTreatment.Size = New System.Drawing.Size(500, 100)
        Me.txtTreatment.TabIndex = 1
        '
        'dtpHistoryDate
        '
        Me.dtpHistoryDate.CustomFormat = "dddd MM/dd/yyyy hh:mm"
        Me.dtpHistoryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHistoryDate.Location = New System.Drawing.Point(75, 53)
        Me.dtpHistoryDate.Name = "dtpHistoryDate"
        Me.dtpHistoryDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpHistoryDate.TabIndex = 2
        '
        'lblHistoryID
        '
        Me.lblHistoryID.AutoSize = True
        Me.lblHistoryID.Location = New System.Drawing.Point(508, 27)
        Me.lblHistoryID.Name = "lblHistoryID"
        Me.lblHistoryID.Size = New System.Drawing.Size(11, 13)
        Me.lblHistoryID.TabIndex = 9
        Me.lblHistoryID.Text = "*"
        '
        'lblPetID
        '
        Me.lblPetID.AutoSize = True
        Me.lblPetID.Location = New System.Drawing.Point(80, 27)
        Me.lblPetID.Name = "lblPetID"
        Me.lblPetID.Size = New System.Drawing.Size(11, 13)
        Me.lblPetID.TabIndex = 10
        Me.lblPetID.Text = "*"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(459, 362)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(34, 362)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDeleteRecord
        '
        Me.btnDeleteRecord.BackColor = System.Drawing.Color.Firebrick
        Me.btnDeleteRecord.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnDeleteRecord.Location = New System.Drawing.Point(229, 358)
        Me.btnDeleteRecord.Name = "btnDeleteRecord"
        Me.btnDeleteRecord.Size = New System.Drawing.Size(119, 31)
        Me.btnDeleteRecord.TabIndex = 6
        Me.btnDeleteRecord.Text = "Delete Record"
        Me.btnDeleteRecord.UseVisualStyleBackColor = False
        Me.btnDeleteRecord.Visible = False
        '
        'lblPetName
        '
        Me.lblPetName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPetName.Location = New System.Drawing.Point(187, 14)
        Me.lblPetName.Name = "lblPetName"
        Me.lblPetName.Size = New System.Drawing.Size(198, 30)
        Me.lblPetName.TabIndex = 19
        Me.lblPetName.Text = "*"
        Me.lblPetName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'chkActiveRecord
        '
        Me.chkActiveRecord.AutoSize = True
        Me.chkActiveRecord.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkActiveRecord.Checked = True
        Me.chkActiveRecord.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActiveRecord.Location = New System.Drawing.Point(437, 86)
        Me.chkActiveRecord.Name = "chkActiveRecord"
        Me.chkActiveRecord.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkActiveRecord.Size = New System.Drawing.Size(97, 17)
        Me.chkActiveRecord.TabIndex = 3
        Me.chkActiveRecord.Text = "Active Record:"
        Me.chkActiveRecord.UseVisualStyleBackColor = True
        '
        'frmPetHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 397)
        Me.Controls.Add(Me.chkActiveRecord)
        Me.Controls.Add(Me.lblPetName)
        Me.Controls.Add(Me.btnDeleteRecord)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblPetID)
        Me.Controls.Add(Me.lblHistoryID)
        Me.Controls.Add(Me.dtpHistoryDate)
        Me.Controls.Add(Me.txtTreatment)
        Me.Controls.Add(Me.lblTreatment)
        Me.Controls.Add(Me.lblVisitReason)
        Me.Controls.Add(Me.txtVisitReason)
        Me.Controls.Add(Me.lblHistoryIDLabel)
        Me.Controls.Add(Me.lblPetIDLabel)
        Me.Controls.Add(Me.lblPetHistoryDate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPetHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pet History"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPetHistoryDate As Label
    Friend WithEvents lblPetIDLabel As Label
    Friend WithEvents lblHistoryIDLabel As Label
    Friend WithEvents txtVisitReason As TextBox
    Friend WithEvents lblVisitReason As Label
    Friend WithEvents lblTreatment As Label
    Friend WithEvents txtTreatment As TextBox
    Friend WithEvents dtpHistoryDate As DateTimePicker
    Friend WithEvents lblHistoryID As Label
    Friend WithEvents lblPetID As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDeleteRecord As Button
    Friend WithEvents lblPetName As Label
    Friend WithEvents chkActiveRecord As CheckBox
End Class
