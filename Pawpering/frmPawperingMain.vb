' Project: Pawpering Vet Clinic CRM
' Author: David Oberlander
' Purpose: (CVTC) VB.NET Final Project: Develop your own.
' Date: 03/06/2021

' The main form that holds the selected customer and their pets data

Option Strict On
Option Explicit On
Public Class frmPawperingMain

    ' Module Level Objects
    Public objSelectedCustomer As New clsCustomer()
    Public objSelectedPet As New clsPet()
    Private Sub mstNewCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mstNewCustomerToolStripMenuItem.Click

        'Open New Customer Form
        OpenForm(frmCustomer)

    End Sub

    Private Sub btnNewCustomer_Click(sender As Object, e As EventArgs) Handles btnNewCustomer.Click

        'Open New Customer Form
        OpenForm(frmCustomer)

    End Sub

    Private Sub btnSearchCustomers_Click(sender As Object, e As EventArgs) Handles btnSearchCustomers.Click

        'Open Customer Search Form
        OpenForm(frmCustomerSearch)

    End Sub

    Private Sub mstSearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mstSearchToolStripMenuItem.Click

        'Open Customer Search Form
        OpenForm(frmCustomerSearch)

    End Sub

    Private Sub OpenForm(ByVal form As Form)
        'Check if the form is created and open already
        If form.IsHandleCreated Then
            'Focus on the already opened form
            form.Focus()
        Else
            'Create and show the form
            form.Show(Me)
        End If
    End Sub

    Private Sub btnEditCustomer_Click(sender As Object, e As EventArgs) Handles btnEditCustomer.Click

        'Run the Edit Customer Procedure
        EditCustomer()

    End Sub

    Private Sub mstEditCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mstEditCustomerToolStripMenuItem.Click

        'Run the Edit Customer Procedure
        EditCustomer()

    End Sub

    Public Sub EditCustomer()
        'Check if the form is created and open already
        If frmCustomer.IsHandleCreated Then
            'Focus on the already opened form
            frmCustomer.Focus()
        Else
            'Create and show the form
            frmCustomer.Show(Me)
        End If

        ' Fill the customer form with the selected Customer, set to Edit
        frmCustomer.FillFormWithSelectedCustomer(objSelectedCustomer, "Edit")
    End Sub

    Public Sub LoadCustomer(ByVal objCustomer As clsCustomer)

        ' Load the customer data into the form
        objSelectedCustomer = objCustomer

        lblCustomerID.Text = objSelectedCustomer.CustomerID.ToString
        lblCustomerName.Text = objSelectedCustomer.Full_Name
        lblAddress1.Text = objSelectedCustomer.Address1
        lblAddress2.Text = objSelectedCustomer.Address2
        lblCity.Text = objSelectedCustomer.City
        lblState.Text = objSelectedCustomer.State
        lblZipCode.Text = objSelectedCustomer.ZipCode
        lblPhoneNumber1.Text = objSelectedCustomer.PhoneNumber1
        lblPhoneNumber2.Text = objSelectedCustomer.PhoneNumber2
        lblEmail.Text = objSelectedCustomer.Email
        lblCustomerSince.Text = objSelectedCustomer.CustomerSince.ToLongDateString & " (" & objSelectedCustomer.Calculate_Years(objSelectedCustomer.CustomerSince) & " years)"
        chkCustomerActive.Checked = objSelectedCustomer.Active

        ' Load the owners of the selected pet
        LoadPetsList()

    End Sub

    Public Sub LoadPet(ByVal objPet As clsPet)

        ' Access the dbConnection class to retrieve names instead of ids
        Dim dbConnection As New clsDBConnection

        ' Load the pet data into the form
        objSelectedPet = objPet

        lblPetID.Text = objSelectedPet.PetID.ToString
        lblPName.Text = objSelectedPet.Name

        ' Retrieve Species Name and Species Breed from the database
        lblPSpecies.Text = dbConnection.GetSpeciesName(objSelectedPet.SpeciesID)
        lblPBreed.Text = dbConnection.GetBreedName(objSelectedPet.BreedID)

        lblPColor.Text = objSelectedPet.Color
        lblPBirthDate.Text = objSelectedPet.BirthDate.ToString
        lblPStatus.Text = objSelectedPet.Status.ToString

        ' If Deceased, display the date
        If objSelectedPet.Status = "Deceased" Then
            lblPDeceasedLabel.Visible = True
            lblPDeceased.Visible = True
            lblPDeceased.Text = objSelectedPet.DeceasedDate.ToString
        Else
            lblPDeceasedLabel.Visible = False
            lblPDeceased.Visible = False
            lblPDeceased.Text = ""
        End If


        ' Get the application file path for the image
        Dim strAppPath As String = Application.StartupPath
        Dim intPathLength As Integer = strAppPath.Length

        ' Strip off the bin/debug folder, to point to the project folder instead
        strAppPath = strAppPath.Substring(0, intPathLength - 9)

        ' Load the pet picture if there is one
        If Not objPet.Photo = "" Then
            Try
                picPetPhoto.ImageLocation = strAppPath & "Images\" & objPet.Photo
            Catch e As Exception
                MessageBox.Show("Unable to load the pet image." & Environment.NewLine & e.Message)
            End Try
        Else
            ' Pet does not have a picture
            picPetPhoto.ImageLocation = strAppPath & "Images\" & "_NoImage.png"
        End If

        ' Load the owners of the selected pet
        LoadOwners()

    End Sub

    Public Sub LoadPetsList()
        Dim dbConnection As New clsDBConnection
        Dim strQuery As String
        Dim dtPets As DataTable

        strQuery = " SELECT [Ownership].PetID, CONCAT([Ownership].PetID, ' ', Pet.Name) As IdAndName " &
                    "FROM [Ownership] INNER JOIN Pet ON [Ownership].PetID = Pet.PetID " &
                    "WHERE [Ownership].CustomerID = " & objSelectedCustomer.CustomerID & " " &
                    "ORDER BY [Ownership].PetID;"

        ' Get the results form the query into a DataTable
        dtPets = dbConnection.GetSearchTable(strQuery)

        ' If the datatable has records, attach it to the listbox
        If dtPets.Rows.Count > 0 Then
            lbxPetsList.DataSource = New BindingSource(dtPets, Nothing)
            lbxPetsList.DisplayMember = "IdAndName"
            lbxPetsList.ValueMember = "PetID"
        Else
            lbxPetsList.DataSource = Nothing
        End If
    End Sub

    Public Sub LoadOwners()

        'Get Owners for pet in datatable
        Dim dbConnection As New clsDBConnection
        Dim strQuery As String
        Dim dtOwners As DataTable

        strQuery = " SELECT [Ownership].CustomerID, CONCAT(Customer.FirstName, ' ', Customer.LastName) As FullName " &
                    "FROM [Ownership] INNER JOIN Customer ON [Ownership].CustomerID = Customer.CustomerID " &
                    "WHERE [Ownership].PetID = " & objSelectedPet.PetID & " " &
                    "ORDER BY [Ownership].CustomerID;"

        ' Get all the owners for the pet from the results of the Query
        dtOwners = dbConnection.GetSearchTable(strQuery)

        ' Populate the owners from the datatable into the listbox
        If dtOwners.Rows.Count > 0 Then
            lbxPOwners.DataSource = New BindingSource(dtOwners, Nothing)
            lbxPOwners.DisplayMember = "FullName"
            lbxPOwners.ValueMember = "CustomerID"
        Else
            lbxPOwners.DataSource = Nothing
        End If

        ' Deselect all owners
        lbxPOwners.SelectedIndex = -1

    End Sub

    Private Sub frmPawperingMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Clear the form
        ClearForm("All")
    End Sub

    Public Sub ClearForm(ByVal strAllOrPet As String)

        If strAllOrPet = "Pet" Then

            'Pet Data
            lblPetID.Text = ""
            lblPName.Text = "*"
            lblPSpecies.Text = "*"
            lblPBreed.Text = "*"
            lblPColor.Text = "*"
            lblPBirthDate.Text = "*"
            lblPStatus.Text = "*"
            lblPDeceased.Text = "*"
            picPetPhoto.ImageLocation = ""

            'Clear the Pet Owners List Box
            lbxPOwners.DataSource = Nothing

        Else
            'Clear the entire form

            ' Customer data
            lblCustomerID.Text = ""
            lblCustomerName.Text = "*"
            lblAddress1.Text = "*"
            lblAddress2.Text = "*"
            lblCity.Text = "*"
            lblState.Text = "*"
            lblZipCode.Text = "*"
            lblPhoneNumber1.Text = "*"
            lblPhoneNumber2.Text = "*"
            lblEmail.Text = "*"
            lblCustomerSince.Text = "*"

            ' Clear Customer Pets
            lbxPetsList.DataSource = Nothing

            'Pet Data
            lblPetID.Text = ""
            lblPName.Text = "*"
            lblPSpecies.Text = "*"
            lblPBreed.Text = "*"
            lblPColor.Text = "*"
            lblPBirthDate.Text = "*"
            lblPStatus.Text = "*"
            lblPDeceased.Text = "*"
            picPetPhoto.ImageLocation = ""

            'Clear the Pet Owners List Box
            lbxPOwners.DataSource = Nothing

        End If

    End Sub

    Private Sub mstFileAboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mstFileAboutToolStripMenuItem.Click

        ' Show Project information in message box
        MessageBox.Show("VB.Net Module 8" & Environment.NewLine & Environment.NewLine &
                        "Developer: David Oberlander" & Environment.NewLine & "Date: 03/08/2021" & Environment.NewLine &
                        "Version: 1.0", "CVTC Final Project", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub DeleteCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteCustomerToolStripMenuItem.Click

        'Check if the form is created and open already
        If frmCustomer.IsHandleCreated Then
            'Focus on the already opened form
            frmCustomer.Focus()
        Else
            'Create and show the form
            frmCustomer.Show(Me)
        End If

        ' Fill the customer form with the selected Customer, set to Delete
        frmCustomer.FillFormWithSelectedCustomer(objSelectedCustomer, "Delete")

    End Sub

    Private Sub btnNewPet_Click(sender As Object, e As EventArgs) Handles btnNewPet.Click

        'Open New Pet Form
        OpenForm(frmPet)

        'If Customer Currently Selected, Add them to the Owners ListBox
        frmPet.LoadCustomerAsOwner(objSelectedCustomer)

    End Sub

    Private Sub mstNewPetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mstNewPetToolStripMenuItem.Click

        'Open New Pet Form
        OpenForm(frmPet)

        'If Customer Currently Selected, Add them to the Owners ListBox
        frmPet.LoadCustomerAsOwner(objSelectedCustomer)

    End Sub


    Private Sub lbxPetsList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxPetsList.SelectedIndexChanged

        ' Dim dbConnection As new clsDBConnection
        Dim dbConnection As New clsDBConnection
        Dim intSelectedPet As Integer
        Dim blnIsInteger As Boolean

        ' If the PetsList has not been loaded yet, load it.
        blnIsInteger = Integer.TryParse(lbxPetsList.SelectedValue.ToString, intSelectedPet)
        If Not blnIsInteger Then
            LoadPetsList()
        End If

        ' Get the selected Pet object from the database.
        If lbxPetsList.Items.Count > 0 And blnIsInteger Then
            ' Get the selected pet object
            Try
                objSelectedPet = dbConnection.GetSelectedPet(CInt(lbxPetsList.SelectedValue))
            Catch ex As Exception
                MessageBox.Show("Unable to load selected pet." & Environment.NewLine & "Error: " & ex.Message, "Error Loading Pet", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            ' Load the pet object into the form
            LoadPet(objSelectedPet)
        End If


    End Sub

    Private Sub btnSelectOwner_Click(sender As Object, e As EventArgs) Handles btnSelectOwner.Click

        ' Validate that there are owners listed
        If lbxPOwners.Items.Count > 0 Then
            ' Create the dbConnection Object to get the customer
            Dim dbConnection As New clsDBConnection

            ' Get the selected owner object
            objSelectedCustomer = dbConnection.GetSelectedCustomer(CInt(lbxPOwners.SelectedValue))

            ' Load the customer object into the form
            LoadCustomer(objSelectedCustomer)

        Else
            MessageBox.Show("No owner was selected.", "Owner", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub lbxPOwners_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lbxPOwners.MouseDoubleClick

        ' Validate that there are owners listed
        If lbxPOwners.Items.Count > 0 Then
            ' Create the dbConnection Object to get the customer
            Dim dbConnection As New clsDBConnection

            ' Get the selected owner object
            objSelectedCustomer = dbConnection.GetSelectedCustomer(CInt(lbxPOwners.SelectedValue))

            MessageBox.Show(lbxPOwners.SelectedValue.ToString())
            ' Load the customer object into the form
            LoadCustomer(objSelectedCustomer)

        Else
            MessageBox.Show("No owner was selected.", "Owner", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub btnEditPet_Click(sender As Object, e As EventArgs) Handles btnEditPet.Click

        EditPet()

    End Sub

    Private Sub mstEditPetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mstEditPetToolStripMenuItem.Click

        EditPet()

    End Sub

    Private Sub EditPet()
        'Check if the form is created and open already
        If frmPet.IsHandleCreated Then
            'Focus on the already opened form
            frmPet.Focus()
        Else
            'Create and show the form
            frmPet.Show(Me)
        End If

        ' Fill the Pet Form with the selected pet, set to Edit
        frmPet.FillFormWithSelectedPet(objSelectedPet, "Edit")
    End Sub

    Private Sub DeletePetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeletePetToolStripMenuItem.Click

        'Check if the form is created and open already
        If frmPet.IsHandleCreated Then
            'Focus on the already opened form
            frmPet.Focus()
        Else
            'Create and show the form
            frmPet.Show(Me)
        End If

        ' Fill the Pet Form with the selected pet, set to Delete
        frmPet.FillFormWithSelectedPet(objSelectedPet, "Delete")

    End Sub

End Class
