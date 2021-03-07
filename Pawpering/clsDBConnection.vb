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


    Public Sub InsertCustomer(ByVal objCustomer As clsCustomer)

        'Instantiate Object
        Dim objStoredCustomer As clsCustomer
        objStoredCustomer = objCustomer

        'Open the Database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create the SQL String
        Dim strSQL = "INSERT into Customer (FirstName, LastName, Address1, Address2, " &
                    "City, State, ZipCode, PhoneNumber1, PhoneNumber2, Email, CustomerSince) " &
                    "VALUES (@FirstName, @LastName, @Address1, @Address2, " &
                    "@City, @State, @ZipCode, @PhoneNumber1, @PhoneNumber2, @Email, @CustomerSince)"

        'Create the Insert Command
        Dim cmdInsert As New SqlCommand(strSQL, dbConnection)

        'Populate the Parameters for the insert statement from the New/Modify Customer Form
        cmdInsert.Parameters.AddWithValue("FirstName", objStoredCustomer.FirstName)
        cmdInsert.Parameters.AddWithValue("LastName", objStoredCustomer.LastName)
        cmdInsert.Parameters.AddWithValue("Address1", objStoredCustomer.Address1)
        cmdInsert.Parameters.AddWithValue("Address2", objStoredCustomer.Address2)
        cmdInsert.Parameters.AddWithValue("City", objStoredCustomer.City)
        cmdInsert.Parameters.AddWithValue("State", objStoredCustomer.State)
        cmdInsert.Parameters.AddWithValue("ZipCode", objStoredCustomer.ZipCode)
        cmdInsert.Parameters.AddWithValue("PhoneNumber1", objStoredCustomer.PhoneNumber1)
        cmdInsert.Parameters.AddWithValue("PhoneNumber2", objStoredCustomer.PhoneNumber2)
        cmdInsert.Parameters.AddWithValue("Email", objStoredCustomer.Email)
        cmdInsert.Parameters.AddWithValue("CustomerSince", objStoredCustomer.CustomerSince)

        Try
            'Insert the row (with error catching)
            Dim intRowsAffected = cmdInsert.ExecuteNonQuery
            If intRowsAffected = 1 Then
                MessageBox.Show(objStoredCustomer.Full_Name & " was added successfully.", "Success")
            Else
                MessageBox.Show("The insert failed." & Environment.NewLine & intRowsAffected & "records added.", "Expected DB Insert Failed.")
            End If
        Catch ex As Exception
            MessageBox.Show("DB Insert Failed: " & Environment.NewLine & ex.Message, "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub UpdateCustomer(ByVal objCustomer As clsCustomer)

        'Instantiate Object
        Dim objStoredCustomer As clsCustomer
        objStoredCustomer = objCustomer

        'Open the Database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create the SQL String
        Dim strSQL = "UPDATE Customer SET" &
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
                    "CustomerSince ='" & objStoredCustomer.CustomerSince & "';"

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

    End Sub

    Public Sub DeleteCustomer(ByVal objCustomer As clsCustomer)

        'Instantiate Object
        Dim objStoredCustomer As clsCustomer
        objStoredCustomer = objCustomer

        'Open Database
        Dim dbConnection As SqlConnection = OpenDBConnection()

        'Create SQL String
        'Can't insert into an autonumbered field, so leaving it out.  Left e-mail out due to it not being on the form
        Dim strSQL = "Delete FROM Customer " &
                                            "WHERE Customer_ID = '" & objStoredCustomer.CustomerID &
                                            "';"
        MessageBox.Show(strSQL) 'For Testing

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

    End Sub
End Class
