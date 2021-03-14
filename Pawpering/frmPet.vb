' Project: Pawpering Vet Clinic CRM
' Author: David Oberlander
' Purpose: (CVTC) VB.NET Final Project: Develop your own.
' Date: 03/11/2021
' Pet Form class, used for creating new pets, editing them, or deleting them

Option Strict On
Option Explicit On
Public Class frmPet

    ' TODO: Figure out how you want to attach an owner to a pet
    ' Do you want to make them select an owner first? 
    ' Or do you want to bring up the owner search to load the customer, 
    ' then focus on the pet window again and populate the selected owner

    ' Module Level Objects
    Public objPet As New clsPet()
    Public objSelectedCustomer As New clsCustomer()
    Public dctOwners As New Dictionary(Of Integer, String)
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

        ' Select Other initially for the breed
        cboBreed.Text = "Other"

    End Sub

    Private Function GetColors() As String()
        Dim strColors() As String = {"Blue", "Black", "Brown", "Golden", "Green", "Gray", "Mixed", "Orange", "Other", "Purple", "Red", "White", "Yellow"}
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
                    strNewImageFileName = DateTime.Now.ToString("dd-MM-yyyy-hhmmss") & "_" & selectImageFile.SafeFileName

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

    Private Sub btnRemoveOwner_Click(sender As Object, e As EventArgs) Handles btnRemoveOwner.Click

        'dctOwners.Add(objCustomer.CustomerID, objCustomer.Full_Name)
        dctOwners.Remove(CInt(lbxPetOwners.SelectedValue))

        'Reset the ListBox with the Updated Dictionary File
        UpdateOwnerDictionary()

        If dctOwners.Count < 1 Then
            btnRemoveOwner.Enabled = False
        End If
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

    Public Sub LoadCustomer(ByVal objCustomer As clsCustomer)

        ' Load the customer data into the form as an Owner
        objSelectedCustomer = objCustomer

        ' Add Customer as Pet Owner
        Try
            'Add a Customer as an owner to the Dictionary file
            dctOwners.Add(objCustomer.CustomerID, objCustomer.Full_Name)
            UpdateOwnerDictionary()
        Catch e As Exception
            MessageBox.Show("This Customer has already been added." & Environment.NewLine & "Error: " & e.Message)
        End Try

        btnRemoveOwner.Enabled = True

    End Sub

    Private Sub UpdateOwnerDictionary()
        If dctOwners.Count > 0 Then
            ' Set the Owners Dictionary binded to the ListBox
            lbxPetOwners.DataSource = New BindingSource(dctOwners, Nothing)
            lbxPetOwners.DisplayMember = "Value"
            lbxPetOwners.ValueMember = "Key"
        Else
            lbxPetOwners.DataSource = Nothing
        End If
    End Sub

    Private Sub btnSaveAndLoad_Click(sender As Object, e As EventArgs) Handles btnSaveAndLoad.Click

        'Populate the Pet Object with data from the user
        objPet = PopulatePet()

        'Create object to connect to the database
        Dim newConnection As clsDBConnection = New clsDBConnection

        If objPet.PetID = 0 Then
            'Insert the data from the form into the database
            newConnection.InsertPet(objPet)
        Else
            'Update the new pet data from the form into the database
        End If

        'Load the Main Pawpering Form with the new Pet Data
        Dim frmPawperingMain = DirectCast(Me.Owner, frmPawperingMain)
        frmPawperingMain.LoadPet(objPet)
        frmPawperingMain.LoadOwners()

        'Close this form
        Me.Close()

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

End Class