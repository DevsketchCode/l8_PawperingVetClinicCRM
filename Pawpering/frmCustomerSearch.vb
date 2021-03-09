' Project: Pawpering Vet Clinic CRM
' Author: David Oberlander
' Purpose: (CVTC) VB.NET Final Project: Develop your own.
' Date: 03/06/2021

' This handles the customer search features

Imports System.Data.SqlClient

Public Class frmCustomerSearch

    Private Sub frmCustomerSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Select on the first search field
        Me.txtCustomerID.Select()

    End Sub

    Private Sub btnSearchCustomer_Click(sender As Object, e As EventArgs) Handles btnSearchCustomer.Click

        ' Run the Search Customers Procedure to populate the datagrid
        SearchCustomers()
        dgvCustomers.Select()

    End Sub

    Private Sub chkShowInactive_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowInactive.CheckedChanged

        ' Reload the search with the new parameter to show only inactive
        ' Run the Search Customers Procedure to populate the datagrid
        SearchCustomers()
        dgvCustomers.Select()

    End Sub

    Public Sub SearchCustomers()

        ' Check if what text fields have data
        Dim blnCustomerID As Boolean = True
        If Me.txtCustomerID.Text = String.Empty Then
            blnCustomerID = False
        End If

        Dim blnFirstName As Boolean = True
        If Me.txtFirstName.Text = String.Empty Then
            blnFirstName = False
        End If

        Dim blnLastName As Boolean = True
        If Me.txtLastName.Text = String.Empty Then
            blnLastName = False
        End If

        'Build the Select Query, depending on what data is entered in each of the text fields
        Dim sqlCustomerSearchQuery As String = "SELECT TOP(25) * FROM Customer "

        ' Check if at least one search field has data, else show all top records
        If (blnCustomerID Or blnFirstName Or blnLastName) Then
            ' Adding WHERE clause, since there was at least one search field entered
            sqlCustomerSearchQuery += "WHERE "

            ' Only add to the sql string if there is data in the CustomerID textfield
            If blnCustomerID Then
                'CUSTOMER ID Add Or tags according to what fields have data
                If (blnCustomerID And blnFirstName) OrElse (blnCustomerID And blnLastName) Then
                    sqlCustomerSearchQuery += "CustomerID = " & Me.txtCustomerID.Text & " And "
                Else
                    sqlCustomerSearchQuery += "CustomerID = " & Me.txtCustomerID.Text & " "
                End If
            End If

            ' Only add to the sql string if there is data in FirstName textfield
            If blnFirstName Then
                'FIRST NAME Add Or tags according to what fields have data
                If blnFirstName And blnLastName Then
                    sqlCustomerSearchQuery += "FirstName LIKE '%" & Me.txtFirstName.Text & "%' And "
                Else
                    sqlCustomerSearchQuery += "FirstName LIKE '%" & Me.txtFirstName.Text & "%' "
                End If
            End If

            ' Only add to the sql string if there is data in LastName textfield
            If blnLastName Then
                sqlCustomerSearchQuery += "LastName LIKE '%" & Me.txtLastName.Text & "%' "
            End If

            ' Show inactive customers
            If chkShowInactive.Checked Then
                sqlCustomerSearchQuery += " And Active = 'False' "
            End If
        Else
            ' Show inactive customers
            If chkShowInactive.Checked Then
                sqlCustomerSearchQuery += "WHERE Active = 'False' "
            End If
        End If


        'Complete the SQL Query Statement 
        sqlCustomerSearchQuery += "ORDER BY LastName, FirstName, CustomerID Desc;"

        'Create object to connect to the database
        Dim dbConn As clsDBConnection = New clsDBConnection

        'Get results from the database and apply to a DataTable
        Dim table As DataTable = dbConn.GetSearchTable(sqlCustomerSearchQuery)

        ' Show the results to the data grid view
        dgvCustomers.DataSource = table

        ' Show and Update the Status Bar with the records now in the table
        stsRecordsReturnedLabel.Visible = True
        stsRecordsReturned.Visible = True
        stsRecordsReturned.Text = table.Rows.Count

    End Sub

    Private Sub dgvCustomers_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvCustomers.MouseDoubleClick

        'Run Procedure to send selected customer to the main form
        LoadSelectedCustomerToMain()

    End Sub

    Private Sub btnLoadSelectedCustomer_Click(sender As Object, e As EventArgs) Handles btnLoadSelectedCustomer.Click

        'Run Procedure to send selected customer to the main form
        LoadSelectedCustomerToMain()

    End Sub

    Private Sub LoadSelectedCustomerToMain()

        ' Validate that there is customer data in the DataGridView in order to get selected customer
        If dgvCustomers.Rows.Count > 0 And dgvCustomers.SelectedRows.Count = 1 Then
            ' Get customerID from selected row
            Dim intSelectedCustomerID As String = dgvCustomers.SelectedRows(0).Cells(0).Value

            ' Connect to the database and retrieve the complete data as a customer object
            Dim dbConn As clsDBConnection = New clsDBConnection

            'Create customer object
            Dim objSelectedCustomer As clsCustomer = dbConn.GetSelectedCustomer(intSelectedCustomerID)

            'Load the Main Pawpering Form with the new customer data
            Dim frmPawperingMain = DirectCast(Me.Owner, frmPawperingMain)
            frmPawperingMain.LoadCustomer(objSelectedCustomer)

            ' Close this form
            Me.Close()

        Else
            MessageBox.Show("No Customer has been selected", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCustomerID.Select()
        End If

    End Sub


End Class