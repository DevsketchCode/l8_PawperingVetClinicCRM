' Project: Pawpering Vet Clinic CRM
' Author: David Oberlander
' Purpose: (CVTC) VB.NET Final Project: Develop your own.
' Date: 03/11/2021
' Pet Form class, used for creating new pets, editing them, or deleting them

Option Strict On
Option Explicit On
Public Class frmPet

    ' Module Level Objects
    Public objPet As New clsPet()

    ' Customer used for owners of the pet
    Public objSelectedCustomer As New clsCustomer()
    Public dctOwners As New Dictionary(Of Integer, String)
    Public dtOwners As New DataTable
    Private Sub frmPet_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Populate Species ComboBox
        PopulateSpecies()

        ' Populate Breeds ComboBox
        PopulateBreeds()

        ' Select Other initially for the breed
        cboBreed.Text = "Other"

        ' Populate Colors ComboBox
        cboColor.DataSource = GetColors()

        ' Populate Status Combobox with a Status list
        Dim lstStatus = New List(Of String)
        lstStatus.Add("Alive")
        lstStatus.Add("Deceased")
        lstStatus.Add("Missing")
        cboStatus.DataSource = lstStatus

        ' Populate Gender Combobox
        Dim lstGender = New List(Of String)
        lstGender.Add("Male")
        lstGender.Add("Female")
        lstGender.Add("Unknown")
        cboGender.DataSource = lstGender

    End Sub

    Private Sub PopulateSpecies()
        Dim dbConn As clsDBConnection = New clsDBConnection
        Dim dtSpecies As DataTable = dbConn.GetSearchTable("Select * From Species Where Active = 1 Order By Name Asc;")

        cboSpecies.DisplayMember = "Name"
        cboSpecies.ValueMember = "SpeciesID"
        cboSpecies.DataSource = dtSpecies

    End Sub

    Private Sub PopulateBreeds()
        Dim dbConn As clsDBConnection = New clsDBConnection
        Dim strSQL As String
        strSQL = "Select * From Breed Where SpeciesID = " & cboSpecies.SelectedValue.ToString & " And Active = 1" &
            "Order By Name Asc"
        Dim dtBreed As DataTable = dbConn.GetSearchTable(strSQL)

        cboBreed.DisplayMember = "Name"
        cboBreed.ValueMember = "BreedID"
        cboBreed.DataSource = dtBreed

    End Sub

    Private Sub cboSpecies_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSpecies.SelectedIndexChanged
        'Update the Breeds ComboBox for the selected Species
        PopulateBreeds()

        ' Manually Select Other initially for the breed
        cboBreed.Text = "Other"

    End Sub

    Private Function GetColors() As String()
        ' Create an array for use to populate Colors
        Dim strColors() As String = {"Other", "Mixed", "Blue", "Black", "Brown", "Chocolate", "Cream", "Golden", "Gray", "Green", "Orange", "Purple", "Red", "Tan", "White", "Yellow"}
        Return strColors
    End Function


    Private Sub cboStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStatus.SelectedIndexChanged

        ' If Deceased is selected, enable the Deceased Date field
        If cboStatus.SelectedItem.ToString = "Deceased" Then
            'Show Deceased fields
            lblDeceasedDate.Visible = True
            dtpDeceasedDate.Visible = True
        Else
            'Hide Deceased fields
            lblDeceasedDate.Visible = False
            dtpDeceasedDate.Visible = False
        End If
    End Sub

    Private Sub btnSelectImage_Click(sender As Object, e As EventArgs) Handles btnSelectImage.Click

        ' Declare filename variable
        Dim strNewImageLocation As String
        Dim strNewImageFileName As String
        Dim strSelectedImageLocation As String

        ' Get the application file path
        Dim strAppPath As String = Application.StartupPath
        Dim intPathLength As Integer = strAppPath.Length

        ' Strip off the bin/debug folder, to point to the project folder instead
        strAppPath = strAppPath.Substring(0, intPathLength - 9)

        ' Set to designated images folder
        strNewImageLocation = strAppPath & "Images\"


        ' Create File Dialog Box
        Dim selectImageFile As OpenFileDialog = New OpenFileDialog()
        selectImageFile.Title = "Select Image"
        selectImageFile.InitialDirectory = strNewImageLocation
        ' Filter the files
        selectImageFile.Filter = "Image Files (*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png|All files (*.*)|*.*"
        ' Set the filter
        selectImageFile.FilterIndex = 1
        ' Restores the directory to Initial after closing
        selectImageFile.RestoreDirectory = True

        If selectImageFile.ShowDialog() = DialogResult.OK Then

            ' initialize the filename variable
            strNewImageFileName = selectImageFile.SafeFileName

            ' get only the original path of the selected image
            ' This will be used to check if the user selected an image in the
            ' designated image folder, or if it needs to be copied over to it.
            strSelectedImageLocation = selectImageFile.FileName.Substring(0, (selectImageFile.FileName.Length - selectImageFile.SafeFileName.Length))

            Try
                If Not (strNewImageLocation = strSelectedImageLocation) Then
                    'Rename to avoid overwriting other pet images
                    strNewImageFileName = DateTime.Now.ToString("MM-dd-yyyy-hhmmss") & "_" & selectImageFile.SafeFileName

                    ' Copy the image that was selected to the designated image folder
                    My.Computer.FileSystem.CopyFile(selectImageFile.FileName, strNewImageLocation & strNewImageFileName, Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
                End If

            Catch ex As Exception
                MessageBox.Show("Error copying the image file." & Environment.NewLine & "Error: " & ex.Message)
            End Try

            picPetPhoto.ImageLocation = strNewImageLocation & strNewImageFileName
            txtPhoto.Text = strNewImageFileName
        End If
    End Sub

    Private Sub btnAddOwner_Click(sender As Object, e As EventArgs) Handles btnAddOwner.Click

        'Load the Customer Search Form to Select an Owner of the pet
        OpenForm(frmCustomerSearch)
        frmCustomerSearch.btnLoadSelectedCustomer.Text = "Load as Pet Owner"
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

    Private Sub btnRemoveOwner_Click(sender As Object, e As EventArgs) Handles btnRemoveOwner.Click

        'dctOwners.Add(objCustomer.CustomerID, objCustomer.Full_Name)
        dctOwners.Remove(CInt(lbxPetOwners.SelectedValue))

        'Reset the ListBox with the Updated Dictionary File
        UpdateOwnerDictionary()

        If dctOwners.Count < 1 Then
            btnRemoveOwner.Enabled = False
        End If
    End Sub


    Public Sub LoadCustomerAsOwner(ByVal objCustomer As clsCustomer)

        ' Load the customer data into the form as an Owner
        objSelectedCustomer = objCustomer

        ' Only add a customer as an owner if one is actually selected
        If objSelectedCustomer.CustomerID > 0 Then

            ' Add Customer as Pet Owner
            Try
                'Add a Customer as an owner to the Dictionary file
                dctOwners.Add(objCustomer.CustomerID, objCustomer.Full_Name)
                UpdateOwnerDictionary()
            Catch e As Exception
                MessageBox.Show("This Customer has already been added." & Environment.NewLine & "Error: " & e.Message)
            End Try

            btnRemoveOwner.Enabled = True

        End If

    End Sub

    Private Sub UpdateOwnerDictionary()

        ' Setup the list box if there is at least one entry
        If dctOwners.Count > 0 Then
            ' Set the Owners Dictionary binded to the ListBox
            lbxPetOwners.DataSource = New BindingSource(dctOwners, Nothing)
            lbxPetOwners.DisplayMember = "Value"
            lbxPetOwners.ValueMember = "Key"
        Else
            'Clear the owners listbox
            lbxPetOwners.DataSource = Nothing
        End If
    End Sub

    Private Sub btnSaveAndLoad_Click(sender As Object, e As EventArgs) Handles btnSaveAndLoad.Click

        'Only continue if a owner exists
        If lbxPetOwners.Items.Count > 0 Then

            'Populate the Pet Object with data from the user
            objPet = PopulatePet()

            'Create object to connect to the database
            Dim newConnection As clsDBConnection = New clsDBConnection

            If objPet.PetID = 0 Then
                'Insert the data from the form into the database
                newConnection.InsertPet(objPet)
            Else
                'Update the new pet data from the form into the database
                newConnection.UpdatePet(objPet, dtOwners)
            End If

            'Load the Main Pawpering Form with the new Pet Data
            Dim frmPawperingMain = DirectCast(Me.Owner, frmPawperingMain)
            frmPawperingMain.LoadPet(objPet)
            frmPawperingMain.LoadPetsList()
            frmPawperingMain.LoadOwners()

            'Close this form
            Me.Close()

        Else
            MessageBox.Show("An Owner Must Be Selected, please select one.", "No Owner", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If


    End Sub

    Private Function PopulatePet() As clsPet

        ' Populate the Pet Object from the form controls

        'If the pet has not been given a name yet, label it as such
        If Not txtName.Text.Equals("") Then
            objPet.Name = txtName.Text
        Else
            objPet.Name = "[No Name]"
        End If

        objPet.Owners = dctOwners
        Integer.TryParse(cboSpecies.SelectedValue.ToString, objPet.SpeciesID)
        Integer.TryParse(cboBreed.SelectedValue.ToString, objPet.BreedID)
        objPet.Color = cboColor.SelectedItem.ToString
        objPet.BirthDate = dtpBirthDate.Value
        objPet.Gender = cboGender.SelectedItem.ToString
        objPet.Status = cboStatus.SelectedItem.ToString

        ' Do not add a deceased date if the pet has not deceased
        If cboStatus.SelectedItem.ToString = "Deceased" Then
            objPet.DeceasedDate = dtpDeceasedDate.Value
        Else
            objPet.DeceasedDate = Nothing
        End If

        objPet.Photo = txtPhoto.Text
        objPet.Active = chkActive.Checked

        Return objPet
    End Function

    Public Sub FillFormWithSelectedPet(ByVal objSelectedPet As clsPet, ByVal strAction As String)

        'Set the customer forms object with the current selected customer
        objPet = objSelectedPet

        ' Only make the edit adjustmetns if a customer is selected
        If objPet.PetID > 0 Then


            If strAction = "Delete" Then

                'Disable Entry Fields on Pet Form
                txtName.Enabled = False
                cboSpecies.Enabled = False
                cboBreed.Enabled = False
                cboColor.Enabled = False
                dtpBirthDate.Enabled = False
                cboGender.Enabled = False
                cboStatus.Enabled = False
                dtpDeceasedDate.Enabled = False
                txtPhoto.Enabled = False
                chkActive.Enabled = False
                picPetPhoto.Enabled = False
                btnSelectImage.Enabled = False
                lbxPetOwners.Enabled = False

                ' Hide all buttons except the Delete button where it stands out.
                btnAddOwner.Enabled = False
                btnRemoveOwner.Enabled = False
                btnClearForm.Visible = False
                btnSaveAndLoad.Visible = False
                btnDeletePet.Visible = True

            ElseIf strAction = "Edit" Then

                'Enable Entry Fields on Pet Form
                txtName.Enabled = True
                cboSpecies.Enabled = True
                cboBreed.Enabled = True
                cboColor.Enabled = True
                dtpBirthDate.Enabled = True
                cboGender.Enabled = True
                cboStatus.Enabled = True
                dtpDeceasedDate.Enabled = True
                txtPhoto.Enabled = True
                chkActive.Enabled = True
                picPetPhoto.Enabled = True
                btnSelectImage.Enabled = True
                ' Editing owners is not a current feature
                lbxPetOwners.Enabled = False

                ' Show all buttons except the Delete button where it stands out.
                btnAddOwner.Enabled = False
                btnRemoveOwner.Enabled = False
                btnClearForm.Visible = True
                btnSaveAndLoad.Visible = True
                btnDeletePet.Visible = False
            End If


            'Populate fields to edit customer
            grpPet.Text = "Pet: " & objPet.PetID.ToString & " " & objPet.Name
            txtPetID.Text = objPet.PetID.ToString
            txtName.Text = objPet.Name
            cboSpecies.SelectedValue = objPet.SpeciesID
            cboBreed.SelectedValue = objPet.BreedID
            cboColor.SelectedItem = objPet.Color
            dtpBirthDate.Value = objPet.BirthDate
            cboGender.SelectedItem = objPet.Gender
            cboStatus.SelectedItem = objPet.Status
            If objPet.Status = "Deceased" Then
                dtpDeceasedDate.Value = objPet.DeceasedDate
            Else
                dtpDeceasedDate.Value = Today()
            End If

            txtPhoto.Text = objPet.Photo
            chkActive.Checked = objPet.Active

            ' Retrieve the image

            ' Get the application file path
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


            'Get Owners for pet in datatable to put it into the listbox
            Dim dbConnection As New clsDBConnection
            Dim strQuery As String

            strQuery = " SELECT [Ownership].OwnershipID, [Ownership].CustomerID, CONCAT(Customer.FirstName, ' ', Customer.LastName) As FullName " &
                    "FROM [Ownership] INNER JOIN Customer ON [Ownership].CustomerID = Customer.CustomerID " &
                    "WHERE [Ownership].PetID = " & objSelectedPet.PetID & " " &
                    "ORDER BY [Ownership].CustomerID;"

            ' Get all the owners for the pet from the results of the Query
            dtOwners = dbConnection.GetSearchTable(strQuery)

            ' Populate the owners from the datatable into the listbox
            If dtOwners.Rows.Count > 0 Then
                lbxPetOwners.DataSource = New BindingSource(dtOwners, Nothing)
                lbxPetOwners.DisplayMember = "FullName"
                lbxPetOwners.ValueMember = "CustomerID"
            Else
                lbxPetOwners.DataSource = Nothing
            End If

            ' DeSelect all owners
            lbxPetOwners.SelectedIndex = -1

        Else
            MessageBox.Show("No Pet selected.  Loading New Pet Form.", "No Pet Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub


    Private Sub btnDeletePet_Click(sender As Object, e As EventArgs) Handles btnDeletePet.Click

        'Populate customer object with data from user
        objPet = PopulatePet()

        'Create object to connect to the database
        Dim newConnection As clsDBConnection = New clsDBConnection

        ' Validate that a pet ID has been entered
        If objPet.PetID > 0 Then
            'Prompt User to Confirm
            Dim diaResult As DialogResult = MessageBox.Show("Are you sure you want to delete this Pet? " & Environment.NewLine & Environment.NewLine &
                                                            "Pet #: " & objPet.PetID & " - " &
                                                            objPet.Name, "DELETE PET", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If diaResult = DialogResult.Yes Then
                ' Insert the data from the form into the database
                newConnection.DeletePet(objPet)

                'Clear just the pet data on the main form
                Dim frmPawperingMain = DirectCast(Me.Owner, frmPawperingMain)
                frmPawperingMain.ClearForm("Pet")

                ' Close this form
                Me.Close()
            Else
                MessageBox.Show("Deletion Cancelled. No changes have been made.")
            End If

        Else
            MessageBox.Show("No Pet ID Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        frmPawperingMain.LoadPetsList()
    End Sub

    Private Sub btnClearForm_Click(sender As Object, e As EventArgs) Handles btnClearForm.Click

        ' Clear the pet form
        txtName.Text = String.Empty
        cboSpecies.SelectedIndex = 0
        cboBreed.SelectedIndex = 0
        cboColor.SelectedIndex = 0
        dtpBirthDate.Value = Today()
        cboGender.SelectedItem = "Male"
        cboStatus.SelectedItem = "Alive"
        dtpDeceasedDate.Value = Today()
        dtpDeceasedDate.Visible = False
        txtPhoto.Text = String.Empty
        picPetPhoto.ImageLocation = String.Empty
        lbxPetOwners.DataSource = Nothing

    End Sub
End Class