Option Strict On
Option Explicit On
' Project: Pawpering Vet Clinic CRM
' Author: David Oberlander
' Purpose: (CVTC) VB.NET Final Project: Develop your own.
' Date: 03/06/2021

Public Class frmCustomer

    ' Module Level Objects
    Public objCustomer As New clsCustomer()
    Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToParent()

        ' Populate the US States combo box


        cboState.DisplayMember = "Key"
        cboState.ValueMember = "Value"
        cboState.DataSource = New BindingSource(PopulateStates(), Nothing)
    End Sub

    Private Function PopulateStates() As Dictionary(Of String, String)
        ' Create collection of all the states of the U.S.
        Dim colStates As New Dictionary(Of String, String)
        colStates.Add("Alabama", "AL")
        colStates.Add("Alaska", "AK")
        colStates.Add("Arizona", "AZ")
        colStates.Add("Arkansas", "AR")
        colStates.Add("California", "CA")
        colStates.Add("Colorado", "CO")
        colStates.Add("Connecticut", "CT")
        colStates.Add("Delaware", "DE")
        colStates.Add("Florida", "FL")
        colStates.Add("Georgia", "GA")
        colStates.Add("Hawaii", "HI")
        colStates.Add("Idaho", "ID")
        colStates.Add("Illinois", "IL")
        colStates.Add("Indiana", " IN")
        colStates.Add("Iowa", "IA")
        colStates.Add("Kansas", "KS")
        colStates.Add("Kentucky", "KY")
        colStates.Add("Louisiana", "LA")
        colStates.Add("Maine", "Me")
        colStates.Add("Maryland", "MD")
        colStates.Add("Massachusetts", "MA")
        colStates.Add("Michigan", "MI")
        colStates.Add("Minnesota", "MN")
        colStates.Add("Mississippi", "MS")
        colStates.Add("Missouri", "MO")
        colStates.Add("Montana", "MT")
        colStates.Add("Nebraska", "NE")
        colStates.Add("Nevada", "NV")
        colStates.Add("New Hampshire", " NH")
        colStates.Add("New Jersey", " NJ")
        colStates.Add("New Mexico", " NM")
        colStates.Add("New York", " NY")
        colStates.Add("North Carolina", " NC")
        colStates.Add("North Dakota", " ND")
        colStates.Add("Ohio", "OH")
        colStates.Add("Oklahoma", "OK")
        colStates.Add("Oregon", " Or")
        colStates.Add("Pennsylvania", " PA")
        colStates.Add("Rhode Island", " RI")
        colStates.Add("South Carolina", " SC")
        colStates.Add("South Dakota", " SD")
        colStates.Add("Tennessee", "TN")
        colStates.Add("Texas", "TX")
        colStates.Add("Utah", "UT")
        colStates.Add("Vermont", "VT")
        colStates.Add("Virginia", "VA")
        colStates.Add("Washington", "WA")
        colStates.Add("West Virginia", " WV")
        colStates.Add("Wisconsin", "WI")
        colStates.Add("Wyoming", "WY")

        Return colStates
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
            If tb.Text.Equals("") And Not (tb.Name.Equals("txtAddress2") Or tb.Name.Equals("txtPhoneNumber2")) Then
                isValid = False
            End If
        Next

        Return isValid
    End Function

    Private Function PopulateCustomer() As clsCustomer

        objCustomer.FirstName = txtFirstName.Text
        objCustomer.LastName = txtLastName.Text
        objCustomer.Address1 = txtAddress1.Text
        objCustomer.Address2 = txtAddress2.Text
        objCustomer.City = txtCity.Text
        objCustomer.State = cboState.SelectedValue.ToString
        objCustomer.ZipCode = txtZipCode.Text
        objCustomer.PhoneNumber1 = txtPhoneNumber1.Text
        objCustomer.PhoneNumber2 = txtPhoneNumber2.Text
        objCustomer.Email = txtEmail.Text
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

                'Disable Entry Fields on Customer Form
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

        If objCustomer.CustomerID > 0 Then
            'Prompt User to Confirm
            Dim diaResult As DialogResult = MessageBox.Show("Are you sure you want to delete this Customer? " & Environment.NewLine & Environment.NewLine &
                                                            "Customer #: " & objCustomer.CustomerID & " - " &
                                                            objCustomer.Full_Name, "DELETE CUSTOMER", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If diaResult = DialogResult.Yes Then
                ' Insert the data from the form into the database
                newConnection.DeleteCustomer(objCustomer)

                'Load the Main Pawpering Form with the new customer data
                Dim frmPawperingMain = DirectCast(Me.Owner, frmPawperingMain)
                frmPawperingMain.ClearForm()
            Else
                MessageBox.Show("Deletion Canceled. No changes have been made.")
            End If

        Else
            MessageBox.Show("No Customer ID Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' Close this form
        Me.Close()

    End Sub
End Class