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

        'frmCustomer = DirectCast(Me.Owner, frmCustomer)
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
        End If


        ' Get the application file path for the image
        Dim strAppPath As String = Application.StartupPath
        Dim intPathLength As Integer = strAppPath.Length

        ' Strip off the bin/debug folder, to point to the project folder instead
        strAppPath = strAppPath.Substring(0, intPathLength - 9)

        ' Load the pet picture if there is one
        If Not objPet.Photo = Nothing Then
            Try
                picPetPhoto.ImageLocation = strAppPath & "Images\" & objPet.Photo
            Catch e As Exception
                MessageBox.Show("Unable to load the pet image." & Environment.NewLine & e.Message)
            End Try
        End If

    End Sub

    ' TODO: Upload Pets and Owners into list boxes from SQL
    Public Sub LoadOwners()
        'Loads all the owners for the Pet
        'If One of the owners is already selected, then select it in the listbox
        'If no owners are selected, load it
        'If owners is selected, prompt before load over it
        'Get Owners for pet in datatable

        Dim dbConnection As New clsDBConnection
            Dim strQuery As String
        Dim dtOwners As DataTable

        strQuery = " SELECT [Ownership].CustomerID, CONCAT(Customer.FirstName, ' ', Customer.LastName) As FullName " &
                    "FROM [Ownership] INNER JOIN Customer ON [Ownership].CustomerID = Customer.CustomerID " &
                    "WHERE [Ownership].PetID = " & objSelectedPet.PetID & " " &
                    "ORDER BY [Ownership].CustomerID;"

        dtOwners = dbConnection.GetSearchTable(strQuery)
        Dim selectedRow As DataRow = dtOwners.Rows.Item(lbxPOwners.SelectedIndex + 1)

        'TODO: Finish filling in the objSelectedCustomer - might need to get rid of this
        'objSelectedCustomer.CustomerID = CInt(selectedRow.Item("CustomerID"))



        If dtOwners.Rows.Count > 0 Then
            lbxPOwners.DataSource = New BindingSource(dtOwners, Nothing)
            lbxPOwners.DisplayMember = "FullName"
            lbxPOwners.ValueMember = "CustomerID"
        Else
            lbxPOwners.DataSource = Nothing
        End If

    End Sub

    ' TODO: Possibly Create a Recently Search List using Stacks

    Private Sub frmPawperingMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Clear the form
        ClearForm()
    End Sub

    Public Sub ClearForm()
        'Clear the form
        lblCustomerID.Text = ""
        lblCustomerName.Text = ""
        lblAddress1.Text = ""
        lblAddress2.Text = ""
        lblCity.Text = ""
        lblState.Text = ""
        lblZipCode.Text = ""
        lblPhoneNumber1.Text = ""
        lblPhoneNumber2.Text = ""
        lblEmail.Text = ""
        lblCustomerSince.Text = ""
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

        'frmCustomer = DirectCast(Me.Owner, frmCustomer)
        frmCustomer.FillFormWithSelectedCustomer(objSelectedCustomer, "Delete")

    End Sub

    Private Sub btnNewPet_Click(sender As Object, e As EventArgs) Handles btnNewPet.Click

        'Open New Pet Form
        OpenForm(frmPet)

    End Sub

    Private Sub lbxPOwners_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxPOwners.SelectedIndexChanged

    End Sub

    Private Function GetCustomer(ByVal selectedOwnerID As Integer) As clsCustomer
        ' TODO: get the customer data using the customerid

        Dim dbConnection As New clsDBConnection
        Dim strQuery As String
        Dim dtOwners As DataTable

        strQuery = " SELECT * FROM Customer WHERE CustomerID" & selectedOwnerID & ";"

        dtOwners = dbConnection.GetSearchTable(strQuery)
        Dim selectedRow As DataRow = dtOwners.Rows.Item(lbxPOwners.SelectedIndex)
        'TODO: Has Error
        'TODO: Make customer in dbConnection instead and return the object.

        objSelectedCustomer.CustomerID = CInt(selectedRow.Item("CustomerID"))
        objSelectedCustomer.FirstName = selectedRow.Item("FirstName").ToString
        objSelectedCustomer.LastName = selectedRow.Item("LastName").ToString
        objSelectedCustomer.Address1 = selectedRow.Item("Address1").ToString
        objSelectedCustomer.Address2 = selectedRow.Item("Address2").ToString
        objSelectedCustomer.City = selectedRow.Item("City").ToString
        objSelectedCustomer.State = selectedRow.Item("State").ToString
        objSelectedCustomer.ZipCode = selectedRow.Item("ZipCode").ToString
        objSelectedCustomer.PhoneNumber1 = selectedRow.Item("PhoneNumber1").ToString
        objSelectedCustomer.PhoneNumber2 = selectedRow.Item("PhoneNumber2").ToString
        objSelectedCustomer.Email = selectedRow.Item("Email").ToString
        objSelectedCustomer.CustomerSince = CDate(selectedRow.Item("CustomerSince"))
        objSelectedCustomer.Active = CBool(selectedRow.Item("Active"))

        Return objSelectedCustomer
    End Function

    Private Sub lbxPOwners_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lbxPOwners.MouseDoubleClick

        'Send the customer that was selected
        GetCustomer(lbxPOwners.SelectedIndex)

    End Sub
End Class
