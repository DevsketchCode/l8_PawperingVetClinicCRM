' Project: Pawpering Vet Clinic CRM
' Author: David Oberlander
' Purpose: (CVTC) VB.NET Final Project: Develop your own.
' Date: 03/06/2021

Option Strict On
Option Explicit On
Public Class frmCustomer

    ' Module Level Objects
    Public objCustomer As New clsCustomer()
    Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Populate the US States combo box binding a Dictionary object
        cboState.DisplayMember = "Key"
        cboState.ValueMember = "Value"
        cboState.DataSource = New BindingSource(PopulateStates(), Nothing)
    End Sub

    Private Function PopulateStates() As Dictionary(Of String, String)
        ' Create collection of all the states of the U.S.
        Dim dctStates As New Dictionary(Of String, String)
        dctStates.Add("Alabama", "AL")
        dctStates.Add("Alaska", "AK")
        dctStates.Add("Arizona", "AZ")
        dctStates.Add("Arkansas", "AR")
        dctStates.Add("California", "CA")
        dctStates.Add("Colorado", "CO")
        dctStates.Add("Connecticut", "CT")
        dctStates.Add("Delaware", "DE")
        dctStates.Add("Florida", "FL")
        dctStates.Add("Georgia", "GA")
        dctStates.Add("Hawaii", "HI")
        dctStates.Add("Idaho", "ID")
        dctStates.Add("Illinois", "IL")
        dctStates.Add("Indiana", " IN")
        dctStates.Add("Iowa", "IA")
        dctStates.Add("Kansas", "KS")
        dctStates.Add("Kentucky", "KY")
        dctStates.Add("Louisiana", "LA")
        dctStates.Add("Maine", "Me")
        dctStates.Add("Maryland", "MD")
        dctStates.Add("Massachusetts", "MA")
        dctStates.Add("Michigan", "MI")
        dctStates.Add("Minnesota", "MN")
        dctStates.Add("Mississippi", "MS")
        dctStates.Add("Missouri", "MO")
        dctStates.Add("Montana", "MT")
        dctStates.Add("Nebraska", "NE")
        dctStates.Add("Nevada", "NV")
        dctStates.Add("New Hampshire", " NH")
        dctStates.Add("New Jersey", " NJ")
        dctStates.Add("New Mexico", " NM")
        dctStates.Add("New York", " NY")
        dctStates.Add("North Carolina", " NC")
        dctStates.Add("North Dakota", " ND")
        dctStates.Add("Ohio", "OH")
        dctStates.Add("Oklahoma", "OK")
        dctStates.Add("Oregon", " Or")
        dctStates.Add("Pennsylvania", " PA")
        dctStates.Add("Rhode Island", " RI")
        dctStates.Add("South Carolina", " SC")
        dctStates.Add("South Dakota", " SD")
        dctStates.Add("Tennessee", "TN")
        dctStates.Add("Texas", "TX")
        dctStates.Add("Utah", "UT")
        dctStates.Add("Vermont", "VT")
        dctStates.Add("Virginia", "VA")
        dctStates.Add("Washington", "WA")
        dctStates.Add("West Virginia", " WV")
        dctStates.Add("Wisconsin", "WI")
        dctStates.Add("Wyoming", "WY")

        Return dctStates
    End Function

    Private Sub btnSaveAndLoad_Click(sender As Object, e As EventArgs) Handles btnSaveAndLoad.Click

        'Validate text fields to make sure they have data
        If ValidateTextBoxes() Then
            'Populate customer object with data from user
            objCustomer = PopulateCustomer()

            'Create object to connect to the database
            Dim newConnection As clsDBConnection = New clsDBConnection

            If objCustomer.CustomerID = 0 Then
                ' Insert the data from the form into the database
                newConnection.InsertCustomer(objCustomer)
            Else
                ' Update the new customer data from the form into the database
                newConnection.UpdateCustomer(objCustomer)
            End If

            'Load the Main Pawpering Form with the new customer data
            Dim frmPawperingMain = DirectCast(Me.Owner, frmPawperingMain)
            frmPawperingMain.LoadCustomer(objCustomer)

            ' Close this form
            Me.Close()

        Else
            MessageBox.Show("Please fill out every field." & Environment.NewLine & Environment.NewLine & "Address2 and Alternate Number are not required.", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Function ValidateTextBoxes() As Boolean
        Dim isValid As Boolean = True

        ' Check to see if all the text boxes have data
        For Each tb In grpCustomer.Controls.OfType(Of TextBox)

            ' Excludes the CustomerID, Address2, and PhoneNumber 2 fields
            If tb.Text.Equals("") And Not (tb.Name.Equals("txtCustomerID") Or tb.Name.Equals("txtAddress2") Or tb.Name.Equals("txtPhoneNumber2")) Then
                isValid = False
            End If

            ' Basic validation of the e-mail address text field
            If tb.Name = "txtEmail" AndAlso Not tb.Text.Contains("@") Then
                isValid = False
                MessageBox.Show("Please enter a valid e-mail address", "Invalid E-mail Address")
            End If

        Next

        Return isValid
    End Function

    Private Function PopulateCustomer() As clsCustomer

        'Populate the data into the Module level Customer Object
        objCustomer.FirstName = txtFirstName.Text
        objCustomer.LastName = txtLastName.Text
        objCustomer.Address1 = txtAddress1.Text
        objCustomer.Address2 = txtAddress2.Text
        objCustomer.City = txtCity.Text
        objCustomer.State = cboState.SelectedValue.ToString
        objCustomer.ZipCode = txtZipCode.Text
        objCustomer.PhoneNumber1 = txtPhoneNumber1.Text
        objCustomer.PhoneNumber2 = txtPhoneNumber2.Text
        objCustomer.Email = txtEmail.Text.ToLower()
        objCustomer.CustomerSince = dteCustomerSince.Value
        objCustomer.Active = chkActive.Checked

        Return objCustomer
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Clear Customer Form
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtAddress1.Text = ""
        txtAddress2.Text = ""
        txtCity.Text = ""
        cboState.SelectedIndex = 0
        txtZipCode.Text = ""
        txtPhoneNumber1.Text = ""
        txtPhoneNumber2.Text = ""
        txtEmail.Text = ""
        dteCustomerSince.Value = Now()
        chkActive.Checked = True

    End Sub

    Public Sub FillFormWithSelectedCustomer(ByVal objSelectedCustomer As clsCustomer, ByVal strAction As String)

        'Set the customer forms object with the current selected customer
        objCustomer = objSelectedCustomer

        ' Only make the edit adjustmetns if a customer is selected
        If objCustomer.CustomerID > 0 Then

            'Populate fields to edit customer
            grpCustomer.Text = "Customer: " & objCustomer.Full_Name
            txtCustomerID.Text = objCustomer.CustomerID.ToString
            txtFirstName.Text = objCustomer.FirstName
            txtLastName.Text = objCustomer.LastName
            txtAddress1.Text = objCustomer.Address1
            txtAddress2.Text = objCustomer.Address2
            txtCity.Text = objCustomer.City
            cboState.SelectedItem = objCustomer.State
            txtZipCode.Text = objCustomer.ZipCode
            txtPhoneNumber1.Text = objCustomer.PhoneNumber1
            txtPhoneNumber2.Text = objCustomer.PhoneNumber2
            txtEmail.Text = objCustomer.Email
            dteCustomerSince.Value = objCustomer.CustomerSince
            chkActive.Checked = objCustomer.Active

            chkActive.Enabled = True

            If strAction = "Delete" Then

                'Disable Entry Fields on Customer Form
                txtFirstName.Enabled = False
                txtLastName.Enabled = False
                txtAddress1.Enabled = False
                txtAddress2.Enabled = False
                txtCity.Enabled = False
                cboState.Enabled = False
                txtZipCode.Enabled = False
                txtPhoneNumber1.Enabled = False
                txtPhoneNumber2.Enabled = False
                txtEmail.Enabled = False
                dteCustomerSince.Enabled = False
                chkActive.Enabled = False

                ' Hide all buttons except the Delete button where it stands out.
                btnClear.Visible = False
                btnSaveAndLoad.Visible = False
                btnDeleteCustomer.Visible = True

            ElseIf strAction = "Edit" Then

                'Enable Entry Fields on Customer Form
                txtFirstName.Enabled = True
                txtLastName.Enabled = True
                txtAddress1.Enabled = True
                txtAddress2.Enabled = True
                txtCity.Enabled = True
                cboState.Enabled = True
                txtZipCode.Enabled = True
                txtPhoneNumber1.Enabled = True
                txtPhoneNumber2.Enabled = True
                txtEmail.Enabled = True
                dteCustomerSince.Enabled = True
                chkActive.Enabled = True

                ' Show the clear and save button, but hide the delete button
                btnClear.Visible = True
                btnSaveAndLoad.Visible = True
                btnDeleteCustomer.Visible = False

            End If
        Else
            MessageBox.Show("No Customer selected.  Loading New Customer Form.", "No Customer Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub btnDeleteCustomer_Click(sender As Object, e As EventArgs) Handles btnDeleteCustomer.Click

        'Populate customer object with data from user
        objCustomer = PopulateCustomer()

        'Create object to connect to the database
        Dim newConnection As clsDBConnection = New clsDBConnection

        ' Validate that a customer ID has been entered
        If objCustomer.CustomerID > 0 Then
            'Prompt User to Confirm
            Dim diaResult As DialogResult = MessageBox.Show("Are you sure you want to delete this Customer? " & Environment.NewLine & Environment.NewLine &
                                                            "Customer #: " & objCustomer.CustomerID & " - " &
                                                            objCustomer.Full_Name, "DELETE CUSTOMER", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If diaResult = DialogResult.Yes Then
                ' Insert the data from the form into the database
                newConnection.DeleteCustomer(objCustomer)

                'Clear the main form
                Dim frmPawperingMain = DirectCast(Me.Owner, frmPawperingMain)
                frmPawperingMain.ClearForm("All")

                ' Close this form
                Me.Close()
            Else
                MessageBox.Show("Deletion Cancelled. No changes have been made.")
            End If

        Else
            MessageBox.Show("No Customer ID Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        frmPawperingMain.LoadPetsList()
        frmPawperingMain.LoadOwners()

        frmPawperingMain.ClearForm("All")

    End Sub
End Class