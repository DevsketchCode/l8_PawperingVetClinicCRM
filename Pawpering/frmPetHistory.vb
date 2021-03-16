' Project: Pawpering Vet Clinic CRM
' Author: David Oberlander
' Purpose: (CVTC) VB.NET Final Project: Develop your own.
' Date: 03/11/2021
' Pet History Form class, used for creating new pets history records, editing them, or deleting them

Option Strict On
Option Explicit On
Public Class frmPetHistory
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'IDs are populated from the Main Form

        'Create object to connect to the database
        Dim newConnection As clsDBConnection = New clsDBConnection
        If btnSave.Text = "Save" Then
            'Insert the data from the form into the database
            newConnection.InsertPetHistory(lblPetID.Text, dtpHistoryDate.Value, txtVisitReason.Text, txtTreatment.Text)
        ElseIf btnSave.Text = "Update" Then
            newConnection.EditPetHistory(lblHistoryID.Text, lblPetID.Text, dtpHistoryDate.Value, txtVisitReason.Text, txtTreatment.Text, chkActiveRecord.Checked)
        End If

        'Load the Main Pawpering Form with the pet history
        frmPawperingMain.LoadPetHistory()
        'Close this form
        Me.Close()

    End Sub

    Public Sub PopulateFields(ByVal strAction As String, ByVal intPetID As Integer, ByVal strPetName As String, ByVal dgsSelectedRow As DataGridViewSelectedRowCollection)

        'Set Selected Pet ID and Name for all actions
        lblPetID.Text = intPetID.ToString
        lblPetName.Text = strPetName

        ' Edit Action was prompted
        If strAction = "Edit" Then
            ' Edit the selected pet
            Try
                If (dgsSelectedRow.Count = 1) Then
                    ' Populate the form fields from the selected row
                    lblHistoryID.Text = dgsSelectedRow(0).Cells("HxID").Value.ToString
                    dtpHistoryDate.Value = CDate(dgsSelectedRow(0).Cells("Date").Value)
                    txtVisitReason.Text = dgsSelectedRow(0).Cells("VisitReason").Value.ToString
                    txtTreatment.Text = dgsSelectedRow(0).Cells("Treatment").Value.ToString
                    chkActiveRecord.Checked = CBool(dgsSelectedRow(0).Cells("Active").Value)

                    ' Enable fields if disabled
                    dtpHistoryDate.Enabled = True
                    txtVisitReason.Enabled = True
                    txtTreatment.Enabled = True
                    chkActiveRecord.Enabled = True

                    ' Adjust Buttons
                    btnClear.Visible = True
                    btnDeleteRecord.Visible = False
                    btnSave.Visible = True
                    btnSave.Text = "Update"

                    'Adjust Form Title
                    Me.Text = "Pet History: UPDATE Record"
                End If
            Catch ex As Exception
                MessageBox.Show("Error getting selected row to edit." & Environment.NewLine & "Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        ElseIf strAction = "Delete" Then
            ' Delete the selected pet
            Try
                If (dgsSelectedRow.Count = 1) Then
                    ' Populate the form fields from the selected row
                    lblHistoryID.Text = dgsSelectedRow(0).Cells("HxID").Value.ToString
                    dtpHistoryDate.Value = CDate(dgsSelectedRow(0).Cells("Date").Value)
                    txtVisitReason.Text = dgsSelectedRow(0).Cells("VisitReason").Value.ToString
                    txtTreatment.Text = dgsSelectedRow(0).Cells("Treatment").Value.ToString
                    chkActiveRecord.Checked = CBool(dgsSelectedRow(0).Cells("Active").Value)

                    ' Enable fields if disabled
                    chkActiveRecord.Enabled = False
                    dtpHistoryDate.Enabled = False
                    txtVisitReason.Enabled = False
                    txtTreatment.Enabled = False

                    ' Adjust Buttons
                    btnClear.Visible = False
                    btnDeleteRecord.Visible = True
                    btnSave.Visible = False

                    'Adjust Form Title
                    Me.Text = "Pet History: DELETE Record"
                End If
            Catch ex As Exception
                MessageBox.Show("Error getting selected row to delete." & Environment.NewLine & "Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            ' Clear fields for new entry for the selected pet
            ClearFields()
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ' Clear fields except for the selected pet id and name
        ClearFields()

    End Sub

    Private Sub ClearFields()

        ' Clear fields for new entry for the selected pet
        lblHistoryID.Text = "*"
        dtpHistoryDate.Value = Now()
        txtVisitReason.Text = String.Empty
        txtTreatment.Text = String.Empty
        chkActiveRecord.Checked = True
        chkActiveRecord.Enabled = False

        ' Adjust Buttons
        btnClear.Visible = True
        btnDeleteRecord.Visible = False
        btnSave.Visible = True
        btnSave.Text = "Save"

        'Adjust Form Title
        Me.Text = "Pet History: ADD Record"
    End Sub

    Private Sub btnDeleteRecord_Click(sender As Object, e As EventArgs) Handles btnDeleteRecord.Click

        'Create object to connect to the database
        Dim newConnection As clsDBConnection = New clsDBConnection

        ' Validate that a customer ID has been entered
        If CInt(lblHistoryID.Text) > 0 Then
            'Prompt User to Confirm
            Dim diaResult As DialogResult = MessageBox.Show("Are you sure you want to delete this Record? " & Environment.NewLine & Environment.NewLine &
                                                            "Pet #: " & lblPetID.Text & " - " & lblPetName.Text & Environment.NewLine &
                                                            txtVisitReason.Text, "DELETE RECORD", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If diaResult = DialogResult.Yes Then
                ' Delete the Pet History Record (False = Just one record)
                newConnection.DeletePetHistory(CInt(lblHistoryID.Text), False)

                'Release the History DataGridView on the Main Form
                frmPawperingMain.LoadPetHistory()

                ' Close this form
                Me.Close()
            Else
                MessageBox.Show("Deletion Cancelled. No changes have been made.")
            End If

        Else
            MessageBox.Show("No History ID Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        'Update the pet history datagridview
        frmPawperingMain.LoadPetHistory()

    End Sub
End Class