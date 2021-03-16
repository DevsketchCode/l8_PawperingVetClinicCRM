' Project: Pawpering Vet Clinic CRM
' Author: David Oberlander
' Purpose: (CVTC) VB.NET Final Project: Develop your own.
' Date: 03/06/2021

' This class handles all the database connections

Option Strict On
Option Explicit On

Imports System.Data.SqlClient

Public Class clsDBConnection

    Public Function OpenDBConnection() As SqlConnection
        'Create the connection string (db from the main project folder instead of the debug folder)
        Dim strPath As String = Application.StartupPath
        Dim intPathLength As Integer = strPath.Length

        ' Strip off the bin/debug folder, to point to the project folder instead
        strPath = strPath.Substring(0, intPathLength - 9)

        ' The connection String
        Dim strConnection As String = "Server=(LocalDB)\MSSQLLocalDB; Integrated Security=true;AttachDbFileName=" & strPath & "Pawpering.mdf"

        'Create a connection object
        Dim dbConnection As New SqlConnection(strConnection)

        Try
            'Open the Database
            dbConnection.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Opening DB", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return dbConnection
    End Function

    ' Handle the Customer, ByRef to allow the actual new object to be updated
    Public Sub InsertCustomer(ByRef objCustomer As clsCustomer)

        'Open the Database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create the SQL String
        Dim strSQL = "INSERT into Customer (FirstName, LastName, Address1, Address2, " &
                    "City, State, ZipCode, PhoneNumber1, PhoneNumber2, Email, CustomerSince, Active) " &
                    "VALUES (@FirstName, @LastName, @Address1, @Address2, " &
                    "@City, @State, @ZipCode, @PhoneNumber1, @PhoneNumber2, @Email, @CustomerSince, @Active)"

        'Create the Insert Command
        Dim cmdInsert As New SqlCommand(strSQL, dbConnection)

        'Populate the Parameters for the insert statement from the New/Modify Customer Form
        cmdInsert.Parameters.AddWithValue("FirstName", objCustomer.FirstName)
        cmdInsert.Parameters.AddWithValue("LastName", objCustomer.LastName)
        cmdInsert.Parameters.AddWithValue("Address1", objCustomer.Address1)
        cmdInsert.Parameters.AddWithValue("Address2", objCustomer.Address2)
        cmdInsert.Parameters.AddWithValue("City", objCustomer.City)
        cmdInsert.Parameters.AddWithValue("State", objCustomer.State)
        cmdInsert.Parameters.AddWithValue("ZipCode", objCustomer.ZipCode)
        cmdInsert.Parameters.AddWithValue("PhoneNumber1", objCustomer.PhoneNumber1)
        cmdInsert.Parameters.AddWithValue("PhoneNumber2", objCustomer.PhoneNumber2)
        cmdInsert.Parameters.AddWithValue("Email", objCustomer.Email)
        cmdInsert.Parameters.AddWithValue("CustomerSince", objCustomer.CustomerSince)
        cmdInsert.Parameters.AddWithValue("Active", objCustomer.Active)

        Try
            'Insert the row (with error catching)
            Dim intRowsAffected = cmdInsert.ExecuteNonQuery
            If intRowsAffected = 1 Then
                'Get the new customer ID and attach it
                AttachNewCustomerID(objCustomer, dbConnection)
                MessageBox.Show("ID: " & objCustomer.CustomerID & " Name: " & objCustomer.Full_Name & " was added successfully.", "Success")
            Else
                MessageBox.Show("The insert failed." & Environment.NewLine & intRowsAffected & "records added.", "Expected DB Insert Failed.")
            End If

            'Clear the command
            cmdInsert.Dispose()

        Catch ex As Exception
            MessageBox.Show("DB Insert Failed: " & Environment.NewLine & ex.Message, "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Close the database connection
        dbConnection.Close()
        dbConnection.Dispose()

    End Sub

    ' Handle the Customer, ByRef to allow the actual new object to be updated
    Private Sub AttachNewCustomerID(ByRef objCustomer As clsCustomer, ByRef dbConnection As SqlConnection)
        'Query latest new customer entry and attach to the customer customerid to the existing customer object
        'Create the SQL String
        Dim strSQL = "SELECT CustomerID FROM Customer WHERE " &
                    "FirstName = '" & objCustomer.FirstName & "' And " &
                    "LastName = '" & objCustomer.LastName & "' And " &
                    "Address1 = '" & objCustomer.Address1 & "'; "

        Dim cmdQuery As New SqlCommand(strSQL, dbConnection)

        Dim sqlReader As SqlDataReader
        sqlReader = cmdQuery.ExecuteReader()

        Try
            If sqlReader.HasRows Then
                Do While sqlReader.Read()
                    objCustomer.CustomerID = CInt(sqlReader.Item("CustomerID"))
                Loop
            End If
        Catch ex As Exception
            MessageBox.Show("CustomerID Retrieval Failed" & Environment.NewLine & ex.Message, "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Function GetSelectedCustomer(ByVal intCustomerID As Integer) As clsCustomer

        'Create Customer Object
        Dim objSelectedCustomer As New clsCustomer

        'Open the Database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        ' Create SQL Query to get all the customer data using the Customer ID
        Dim strSQL = "SELECT * FROM Customer WHERE " &
                    "CustomerID = " & intCustomerID & "; "

        ' Create the command
        Dim cmdQuery As New SqlCommand(strSQL, dbConnection)

        Try
            ' Create the reader and execute the command
            Dim sqlReader As SqlDataReader = cmdQuery.ExecuteReader()

            ' Iterate through the row and populate it to the customer object
            If sqlReader.HasRows Then
                Do While sqlReader.Read()
                    objSelectedCustomer.CustomerID = CInt(sqlReader.Item("CustomerID"))
                    objSelectedCustomer.FirstName = sqlReader.Item("FirstName").ToString
                    objSelectedCustomer.LastName = sqlReader.Item("LastName").ToString
                    objSelectedCustomer.Address1 = sqlReader.Item("Address1").ToString
                    objSelectedCustomer.Address2 = sqlReader.Item("Address2").ToString
                    objSelectedCustomer.City = sqlReader.Item("City").ToString
                    objSelectedCustomer.State = sqlReader.Item("State").ToString
                    objSelectedCustomer.ZipCode = sqlReader.Item("ZipCode").ToString
                    objSelectedCustomer.PhoneNumber1 = sqlReader.Item("PhoneNumber1").ToString
                    objSelectedCustomer.PhoneNumber2 = sqlReader.Item("PhoneNumber2").ToString
                    objSelectedCustomer.Email = sqlReader.Item("Email").ToString
                    objSelectedCustomer.CustomerSince = CDate(sqlReader.Item("CustomerSince"))
                    objSelectedCustomer.Active = CBool(sqlReader.Item("Active"))
                Loop
            End If

            'Close the sqlReader
            sqlReader.Close()

            'Clear the Command
            cmdQuery.Dispose()

        Catch ex As Exception
            MessageBox.Show("Customer Retrieval Failed" & Environment.NewLine & ex.Message, "Get Customer Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Close database
        dbConnection.Close()
        dbConnection.Dispose()

        Return objSelectedCustomer
    End Function

    Public Sub UpdateCustomer(ByVal objSelectedCustomer As clsCustomer)

        'Instantiate Object
        Dim objStoredCustomer As clsCustomer
        objStoredCustomer = objSelectedCustomer

        'Open the Database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create the SQL String
        Dim strSQL = "UPDATE Customer SET " &
                    "FirstName ='" & objStoredCustomer.FirstName & "', " &
                    "LastName ='" & objStoredCustomer.LastName & "', " &
                    "Address1 ='" & objStoredCustomer.Address1 & "', " &
                    "Address2 ='" & objStoredCustomer.Address2 & "', " &
                    "City ='" & objStoredCustomer.City & "', " &
                    "State ='" & objStoredCustomer.State & "', " &
                    "ZipCode ='" & objStoredCustomer.ZipCode & "', " &
                    "PhoneNumber1 ='" & objStoredCustomer.PhoneNumber1 & "', " &
                    "PhoneNumber2 ='" & objStoredCustomer.PhoneNumber2 & "', " &
                    "Email ='" & objStoredCustomer.Email & "', " &
                    "CustomerSince ='" & objStoredCustomer.CustomerSince & "', " &
                    "Active = '" & objStoredCustomer.Active & "' " &
                    "WHERE CustomerID = " & objSelectedCustomer.CustomerID & ";"

        'Create the Update Command
        Dim cmdUpdate As New SqlCommand(strSQL, dbConnection)


        Try
            'Update the row (with error catching)
            Dim intRowsAffected = cmdUpdate.ExecuteNonQuery
            If intRowsAffected = 1 Then
                MessageBox.Show(objStoredCustomer.Full_Name & " was updated successfully.", "Success")
            Else
                MessageBox.Show("The update failed." & Environment.NewLine & intRowsAffected & "records updated.", "Expected DB Update Failed.")
            End If

            'Clear the command
            cmdUpdate.Dispose()

        Catch ex As Exception
            MessageBox.Show("DB Update Failed: " & Environment.NewLine & ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Close database
        dbConnection.Close()
        dbConnection.Dispose()

    End Sub

    Public Sub DeleteCustomer(ByVal objSelectedCustomer As clsCustomer)

        'Instantiate Object
        Dim objStoredCustomer As clsCustomer
        objStoredCustomer = objSelectedCustomer

        'Open Database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create SQL String
        'Can't insert into an autonumbered field, so leaving it out.  Left e-mail out due to it not being on the form
        Dim strSQL = "Delete FROM Customer " &
                                            "WHERE CustomerID = '" & objStoredCustomer.CustomerID &
                                            "';"

        'Create Command
        Dim cmdDelete As New SqlCommand(strSQL, dbConnection)

        Try
            Dim intRowsAffected = cmdDelete.ExecuteNonQuery() 'Not a query, it's an Delete statement, returns 0 or 1 if Deleted
            If intRowsAffected = 1 Then
                MessageBox.Show(objStoredCustomer.Full_Name & " was deleted.", "Success")
            Else
                MessageBox.Show("The deletion failed." & vbCrLf & "0 records added.", "Delete Failed")
            End If

            'Clear the command
            cmdDelete.Dispose()

        Catch ex As Exception
            MessageBox.Show("DB Deletion Failed" & ex.Message, "Delete Error")
        End Try

        'Close database
        dbConnection.Close()
        dbConnection.Dispose()

        ' Delete Customer from the ownership table
        DeleteOwnership(objStoredCustomer.CustomerID, "Customer")

    End Sub

    Public Function GetSearchTable(ByVal strSearchQuerySQL As String) As DataTable

        'Open Database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        Dim command As New SqlCommand(strSearchQuerySQL, dbConnection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        Try
            ' Fill the table with the results
            adapter.Fill(table)
        Catch ex As Exception
            MessageBox.Show("Filling the DataTable Failed: " & Environment.NewLine & ex.Message & Environment.NewLine &
                            "SQL: " & strSearchQuerySQL, "Filling DataTable Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Close database
        dbConnection.Close()
        dbConnection.Dispose()

        Return table
    End Function

    'Handle the Pet, ByRef to allow the actual new object to be updated
    Public Sub InsertPet(ByRef objPet As clsPet)
        'Initialize Variables
        Dim strDeceased As String = ""
        Dim strDeceasedValue As String = ""


        'Open the Database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        ' If Status is deceased, include in the SQL
        If objPet.Status = "Deceased" Then
            strDeceased = "DeceasedDate, "
            strDeceasedValue = "'" & objPet.DeceasedDate.ToString & "', "
        End If

        'Create the SQL String
        Dim strSQL = "INSERT into Pet (Name, SpeciesID, BreedID, " &
                    "Color, BirthDate, Status, " & strDeceased & "Photo, Active) " &
                    "VALUES (@Name, @SpeciesID, @BreedID, " &
                    "@Color, @BirthDate, @Status, " & strDeceasedValue & "@Photo, @Active)"

        'Create the Insert Command
        Dim cmdInsert As New SqlCommand(strSQL, dbConnection)

        'Populate the Parameters for the insert statement from the New/Modify Pet Form
        cmdInsert.Parameters.AddWithValue("Name", objPet.Name)
        cmdInsert.Parameters.AddWithValue("SpeciesID", objPet.SpeciesID)
        cmdInsert.Parameters.AddWithValue("BreedID", objPet.BreedID)
        cmdInsert.Parameters.AddWithValue("Color", objPet.Color)
        cmdInsert.Parameters.AddWithValue("BirthDate", objPet.BirthDate)
        cmdInsert.Parameters.AddWithValue("Status", objPet.Status)

        cmdInsert.Parameters.AddWithValue("Photo", objPet.Photo)
        cmdInsert.Parameters.AddWithValue("Active", objPet.Active)


        Try
            'Insert the row (with error catching)
            Dim intRowsAffected = cmdInsert.ExecuteNonQuery
            If intRowsAffected = 1 Then
                'Get the new customer ID and attach it
                AttachNewPetID(objPet, dbConnection)

                ' Insert all the owners into the Ownership table
                InsertOwnership(objPet, dbConnection)
                MessageBox.Show("ID: " & objPet.PetID & " Name: " & objPet.Name & " was added successfully.", "Success")
            Else
                MessageBox.Show("The insert failed." & Environment.NewLine & intRowsAffected & "records added.", "Expected DB Insert Failed.")
            End If

            'Clear the command
            cmdInsert.Dispose()

        Catch ex As Exception
            MessageBox.Show("DB Insert Failed: " & Environment.NewLine & ex.Message, "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Close the database connection
        dbConnection.Close()
        dbConnection.Dispose()

    End Sub

    'Handle the Pet, ByRef to allow the actual new object to be updated
    Private Sub AttachNewPetID(ByRef objPet As clsPet, ByRef dbConnection As SqlConnection)
        'Query latest new customer entry and attach to the customer customerid to the existing customer object
        'Create the SQL String
        Dim strSQL = "SELECT Max(PetID) As PetID FROM Pet WHERE " &
                    "Name = '" & objPet.Name & "' And " &
                    "BirthDate = '" & objPet.BirthDate & "'; "

        Dim cmdQuery As New SqlCommand(strSQL, dbConnection)

        Dim sqlReader As SqlDataReader
        sqlReader = cmdQuery.ExecuteReader()

        Try
            If sqlReader.HasRows Then
                Do While sqlReader.Read()
                    objPet.PetID = CInt(sqlReader.Item("PetID"))
                Loop
            End If

            ' Close the reader
            sqlReader.Close()
            cmdQuery.Dispose()

        Catch ex As Exception
            MessageBox.Show("PetID Retrieval Failed" & Environment.NewLine & ex.Message, "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Handle the Pet, ByRef to allow the actual new object to be updated
    Public Sub InsertOwnership(ByRef objPet As clsPet, ByRef dbConnection As SqlConnection)

        'Insert the pet id and owner ids into the ownership field
        Dim strSQL As String

        Try
            ' Insert a record for each owner of the pet
            For i As Integer = 0 To objPet.Owners.Count - 1

                'Create the SQL String
                strSQL = "INSERT into Ownership (CustomerID, PetID) " &
                    "VALUES (@CustomerID, @PetID)"

                'Create the Insert Command
                Dim cmdInsertOwner As New SqlCommand(strSQL, dbConnection)

                cmdInsertOwner.Parameters.AddWithValue("CustomerID", objPet.Owners.Keys(i))
                cmdInsertOwner.Parameters.AddWithValue("PetID", objPet.PetID)

                ' Run the insert statement
                cmdInsertOwner.ExecuteNonQuery()

                ' Clear command to be set for the next loop
                cmdInsertOwner.Dispose()

            Next

        Catch ex As Exception
            MessageBox.Show("Inserting the Owners has Failed." & Environment.NewLine & "Error: " & ex.Message, "Expected DB Ownership Insert Failed.")
        End Try

    End Sub

    Public Function GetSpeciesName(ByVal strSpeciesID As Integer) As String
        'Initialize variable
        Dim strSpeciesName As String = ""

        'Open the Database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create the SQL String
        Dim strSQL = "SELECT * FROM Species WHERE " &
                    "SpeciesID = " & strSpeciesID & "; "

        Dim cmdQuery As New SqlCommand(strSQL, dbConnection)

        Try
            Dim sqlReader As SqlDataReader = cmdQuery.ExecuteReader()

            If sqlReader.HasRows Then
                Do While sqlReader.Read()
                    strSpeciesName = sqlReader.Item("Name").ToString
                Loop
            End If

            'Close the sqlReader
            sqlReader.Close()

            'Clear the Command
            cmdQuery.Dispose()

        Catch ex As Exception
            MessageBox.Show("Species Name Retrieval Failed" & Environment.NewLine & ex.Message, "Get Species Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Close database
        dbConnection.Close()
        dbConnection.Dispose()

        Return strSpeciesName
    End Function

    Public Function GetBreedName(ByVal strBreedID As Integer) As String
        'Initialize variable
        Dim strBreedName As String = ""

        'Open the Database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create the SQL String
        Dim strSQL = "SELECT * FROM Breed WHERE " &
                    "BreedID = " & strBreedID & "; "

        ' Create the command
        Dim cmdQuery As New SqlCommand(strSQL, dbConnection)

        Try
            ' Create the reader and execute the command
            Dim sqlReader As SqlDataReader = cmdQuery.ExecuteReader()

            If sqlReader.HasRows Then
                Do While sqlReader.Read()
                    strBreedName = sqlReader.Item("Name").ToString
                Loop
            End If

            'Close the sqlReader
            sqlReader.Close()

            'Clear the Command
            cmdQuery.Dispose()

        Catch ex As Exception
            MessageBox.Show("Breed Name Retrieval Failed" & Environment.NewLine & ex.Message, "Get Breed Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Close database
        dbConnection.Close()
        dbConnection.Dispose()

        Return strBreedName
    End Function

    Public Function GetSelectedPet(ByVal intPetID As Integer) As clsPet

        ' Create Customer Object
        Dim objSelectedPet As New clsPet()

        ' Open the database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        ' Create SQL Query to get all the customer data using the Customer ID
        Dim strSQL As String
        strSQL = " SELECT * FROM Pet WHERE PetID = " & intPetID & ";"

        ' Create the command
        Dim cmdQuery As New SqlCommand(strSQL, dbConnection)

        Try
            ' Create the reader and execute the command
            Dim sqlReader As SqlDataReader = cmdQuery.ExecuteReader()

            ' Iterate through the row and populate it to the customer object
            If sqlReader.HasRows Then
                Do While sqlReader.Read()

                    objSelectedPet.PetID = CInt(sqlReader.Item("PetID"))
                    objSelectedPet.Name = sqlReader.Item("Name").ToString
                    objSelectedPet.SpeciesID = CInt(sqlReader.Item("SpeciesID"))
                    objSelectedPet.BreedID = CInt(sqlReader.Item("BreedID"))
                    objSelectedPet.Color = sqlReader.Item("Color").ToString
                    objSelectedPet.BirthDate = CDate(sqlReader.Item("BirthDate"))
                    objSelectedPet.Status = sqlReader.Item("Status").ToString
                    If objSelectedPet.Status = "Deceased" Then
                        objSelectedPet.DeceasedDate = CDate(sqlReader.Item("DeceasedDate"))
                    Else
                        objSelectedPet.DeceasedDate = Nothing
                    End If
                    objSelectedPet.Photo = sqlReader.Item("Photo").ToString
                    objSelectedPet.Active = CBool(sqlReader.Item("Active"))

                Loop
            End If

            'Close the sqlReader
            sqlReader.Close()

            'Clear the Command
            cmdQuery.Dispose()

        Catch ex As Exception
            MessageBox.Show("Pet Retrieval Failed" & Environment.NewLine & ex.Message, "Get Pet Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Close database
        dbConnection.Close()
        dbConnection.Dispose()

        Return objSelectedPet
    End Function

    Public Sub UpdatePet(ByVal objSelectedPet As clsPet, ByVal dtOwners As DataTable)

        'Instantiate Object
        Dim objStoredPet As clsPet
        objStoredPet = objSelectedPet

        'Open the Database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        Dim strDeceased As String
        'If the pet is alive, set Null for deceasedDate
        If objStoredPet.Status = "Deceased" Then
            strDeceased = "DeceasedDate = NULL, "
        Else
            strDeceased = "DeceasedDate ='" & objStoredPet.DeceasedDate & "', "
        End If

        'Create the SQL String
        Dim strSQL = "UPDATE Pet SET " &
                    "Name ='" & objStoredPet.Name & "', " &
                    "SpeciesID ='" & objStoredPet.SpeciesID & "', " &
                    "BreedID ='" & objStoredPet.BreedID & "', " &
                    "Color ='" & objStoredPet.Color & "', " &
                    "BirthDate ='" & objStoredPet.BirthDate & "', " &
                    "Status ='" & objStoredPet.Status & "', " &
                    strDeceased &
                    "Photo ='" & objStoredPet.Photo & "', " &
                    "Active ='" & objStoredPet.Active & "' " &
                    "WHERE PetID = " & objStoredPet.PetID & ";"


        'Create the Update Command
        Dim cmdUpdate As New SqlCommand(strSQL, dbConnection)

        ' Execute the update to the database
        Try
            'Update the row (with error catching)
            Dim intRowsAffected = cmdUpdate.ExecuteNonQuery
            If intRowsAffected = 1 Then
                MessageBox.Show(objStoredPet.Name & " was updated successfully.", "Success")
            Else
                MessageBox.Show("The Pet update failed." & Environment.NewLine & intRowsAffected & "records updated.", "Expected DB Pet Update Failed.")
            End If

            'Clear the command
            cmdUpdate.Dispose()

        Catch ex As Exception
            MessageBox.Show("DB Pet Update Failed: " & Environment.NewLine & ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Close database
        dbConnection.Close()
        dbConnection.Dispose()

    End Sub

    Public Sub DeletePet(ByVal objSelectedPet As clsPet)

        'Instantiate Object
        Dim objStoredPet As clsPet
        objStoredPet = objSelectedPet

        'Open Database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create SQL String
        Dim strSQL = "Delete FROM Pet " &
                    "WHERE PetID = '" & objStoredPet.PetID &
                    "';"

        'Create Command
        Dim cmdDelete As New SqlCommand(strSQL, dbConnection)

        Try
            Dim intRowsAffected = cmdDelete.ExecuteNonQuery() 'Not a query, it's an Delete statement, returns 0 or 1 if Deleted
            If intRowsAffected = 1 Then
                MessageBox.Show("Pet ID: " & objStoredPet.PetID & ": """ & objStoredPet.Name & """ was deleted successfully.", "Success")
            Else
                MessageBox.Show("The pet deletion failed." & vbCrLf & intRowsAffected & " records deleted.", "Delete Pet Failed")
            End If

            'Clear the command
            cmdDelete.Dispose()

        Catch ex As Exception
            MessageBox.Show("DB Pet Deletion Failed" & ex.Message, "Delete Pet Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Close database
        dbConnection.Close()
        dbConnection.Dispose()

        ' Delete pet from the ownership table
        DeleteOwnership(objStoredPet.PetID, "Pet")

        ' Delete the pets history records (True = All records)
        DeletePetHistory(objStoredPet.PetID, True)

    End Sub

    ' Deletes either the specified customer or the pet from the ownership table
    Public Sub DeleteOwnership(ByVal intID As Integer, ByVal strCustOrPet As String)

        'Open Database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create SQL String
        Dim strSQL = "Delete FROM Ownership " &
                    "WHERE " & strCustOrPet & "ID = '" & intID & "';"

        'Create Command
        Dim cmdDelete As New SqlCommand(strSQL, dbConnection)

        Try
            Dim intRowsAffected = cmdDelete.ExecuteNonQuery() 'Not a query, it's an Delete statement, returns 0 or 1 if Deleted
            If intRowsAffected > 0 Then
                MessageBox.Show(strCustOrPet & " ID " & intID & "'s " & intRowsAffected & " ownership records have been successfully deleted.", "Success")
            Else
                MessageBox.Show("The " & strCustOrPet & " deletion failed." & vbCrLf & intRowsAffected & " records deleted.", "Delete Ownership " & strCustOrPet & " Ownership Failed")
            End If

            'Clear the command
            cmdDelete.Dispose()

        Catch ex As Exception
            MessageBox.Show("DB " & strCustOrPet & " Deletion Failed" & ex.Message, "Delete Ownership " & strCustOrPet & " Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Close database
        dbConnection.Close()
        dbConnection.Dispose()

    End Sub


    Public Sub InsertPetHistory(ByVal strPetID As String, ByVal dteHistoryDate As DateTime, ByVal strVisitReason As String, ByVal strTreatment As String)

        'Open the Database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create the SQL String
        Dim strSQL = "INSERT into PetHistory (Date, PetID, VisitReason, Treatment) " &
                    "VALUES (@Date, @PetID, @VisitReason, @Treatment)"

        'Create the Insert Command
        Dim cmdInsert As New SqlCommand(strSQL, dbConnection)

        'Populate the Parameters for the insert statement from the New/Modify Pet Form
        cmdInsert.Parameters.AddWithValue("Date", dteHistoryDate)
        cmdInsert.Parameters.AddWithValue("PetID", CInt(strPetID))
        cmdInsert.Parameters.AddWithValue("VisitReason", strVisitReason)
        cmdInsert.Parameters.AddWithValue("Treatment", strTreatment)


        Try
            'Insert the row (with error catching)
            Dim intRowsAffected = cmdInsert.ExecuteNonQuery
            If intRowsAffected = 1 Then
                MessageBox.Show("The history record for Pet #: " & strPetID & " was added successfully.", "Success")
            Else
                MessageBox.Show("The insert failed." & Environment.NewLine & intRowsAffected & "records added.", "Expected DB Insert History Record Failed.")
            End If

            'Clear the command
            cmdInsert.Dispose()

        Catch ex As Exception
            MessageBox.Show("DB Inserting History Record Failed: " & Environment.NewLine & ex.Message, "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Close the database connection
        dbConnection.Close()
        dbConnection.Dispose()

    End Sub

    Public Sub EditPetHistory(ByVal strHistoryID As String, ByVal strPetID As String, ByVal dteHistoryDate As DateTime, ByVal strVisitReason As String, ByVal strTreatment As String, ByVal blnActive As Boolean)

        ' Edit only if there is a history record id
        If CInt(strHistoryID) > 0 Then

            'Open the Database
            Dim dbConnection As SqlConnection = OpenDBConnection()

            'Create the SQL String
            Dim strSQL = "UPDATE PetHistory SET " &
                    "Date ='" & dteHistoryDate & "', " &
                    "PetId = '" & CInt(strPetID) & "', " &
                    "VisitReason ='" & strVisitReason & "', " &
                    "Treatment ='" & strTreatment & "', " &
                    "Active ='" & blnActive & "', " &
                    "WHERE HistoryID = " & strHistoryID & ";"


            'Create the Update Command
            Dim cmdUpdate As New SqlCommand(strSQL, dbConnection)

            ' Execute the update to the database
            Try
                'Update the row (with error catching)
                Dim intRowsAffected = cmdUpdate.ExecuteNonQuery
                If intRowsAffected = 1 Then
                    MessageBox.Show("Pet ID: " & strPetID & " was updated successfully.", "Success")
                Else
                    MessageBox.Show("Updating the pet history record failed." & Environment.NewLine & intRowsAffected & "records updated.", "Expected DB Pet History Update Failed.")
                End If

                'Clear the command
                cmdUpdate.Dispose()

            Catch ex As Exception
                MessageBox.Show("DB Pet Update Failed: " & Environment.NewLine & ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            'Close database
            dbConnection.Close()
            dbConnection.Dispose()

        End If

    End Sub

    Public Sub DeletePetHistory(ByVal intID As Integer, ByVal blnAllPetsHistoryRecords As Boolean)

        'Open Database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create SQL String
        Dim strSQL As String
        Dim strPetOrHistory As String

        ' Check if all the pet history records need to be deleted or just one
        If blnAllPetsHistoryRecords Then
            'Create SQL String
            strSQL = "Delete FROM PetHistory " &
                    "WHERE PetID = '" & intID & "';"

            strPetOrHistory = "Pet History"
        Else
            ' Only delete the selected History ID
            strSQL = "Delete FROM PetHistory " &
                    "WHERE HistoryID = '" & intID & "';"

            strPetOrHistory = "History Record"
        End If


        'Create Command
        Dim cmdDelete As New SqlCommand(strSQL, dbConnection)

        Try
            Dim intRowsAffected = cmdDelete.ExecuteNonQuery() 'Not a query, it's an Delete statement, returns 0 or 1 if Deleted
            If intRowsAffected > 0 Then
                MessageBox.Show(strPetOrHistory & " ID " & intID & "'s " & intRowsAffected & " history records have been successfully deleted.", "Success")
            Else
                MessageBox.Show("The " & strPetOrHistory & " deletion failed." & vbCrLf & intRowsAffected & " records deleted.", "Delete " & strPetOrHistory & " Failed")
            End If

            'Clear the command
            cmdDelete.Dispose()

        Catch ex As Exception
            MessageBox.Show("DB " & strPetOrHistory & " Deletion Failed" & ex.Message, "Delete " & strPetOrHistory & " Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Close database
        dbConnection.Close()
        dbConnection.Dispose()

    End Sub

End Class
