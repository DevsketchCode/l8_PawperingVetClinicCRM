' Project: Pawpering Vet Clinic CRM
' Author: David Oberlander
' Purpose: (CVTC) VB.NET Final Project: Develop your own.
' Date: 03/06/2021

' This class handles all the database connections

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
        Catch ex As Exception
            MessageBox.Show("DB Insert Failed: " & Environment.NewLine & ex.Message, "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Close the database connection
        dbConnection.Close()
        dbConnection.Dispose()

    End Sub

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
                    objCustomer.CustomerID = sqlReader.Item("CustomerID")
                Loop
            End If
        Catch ex As Exception
            MessageBox.Show("CustomerID Retrieval Failed" & Environment.NewLine & ex.Message, "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Function GetSelectedCustomer(ByVal intCustomerID As Integer) As clsCustomer
        'Initialize variable
        Dim selectedCustomerID As Integer = intCustomerID

        'Create Customer Object
        Dim objSelectedCustomer As clsCustomer
        objSelectedCustomer = New clsCustomer

        'Open the Database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Query latest new customer entry and attach to the customer customerid to the existing customer object
        'Create the SQL String
        Dim strSQL = "SELECT * FROM Customer WHERE " &
                    "CustomerID = " & intCustomerID & "; "

        Dim cmdQuery As New SqlCommand(strSQL, dbConnection)

        Dim sqlReader As SqlDataReader = cmdQuery.ExecuteReader()

        Try
            If sqlReader.HasRows Then
                Do While sqlReader.Read()
                    objSelectedCustomer.CustomerID = sqlReader.Item("CustomerID")
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
                    objSelectedCustomer.CustomerSince = sqlReader.Item("CustomerSince")
                    objSelectedCustomer.Active = sqlReader.Item("Active")
                Loop
            End If
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
                MessageBox.Show(objStoredCustomer.Full_Name & " was deleted.", "Success") ' Use message box for testing
            Else
                MessageBox.Show("The deletion failed." & vbCrLf & "0 records added.", "Delete Failed")
            End If
        Catch ex As Exception
            MessageBox.Show("DB Deletion Failed" & ex.Message, "Delete Error")
        End Try

        'Close database
        dbConnection.Close()
        dbConnection.Dispose()

    End Sub

    Public Function GetSearchTable(ByVal strSearchQuerySQL As String) As DataTable

        'Open Database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        Dim command As New SqlCommand(strSearchQuerySQL, dbConnection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        ' Fill the table with the results
        adapter.Fill(table)

        'Close database
        dbConnection.Close()
        dbConnection.Dispose()

        Return table
    End Function
End Class
