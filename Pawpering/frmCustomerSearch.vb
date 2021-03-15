' Project: Pawpering Vet Clinic CRM
' Author: David Oberlander
' Purpose: (CVTC) VB.NET Final Project: Develop your own.
' Date: 03/06/2021

' This handles the customer search features

Option Strict On
Option Explicit On

Public Class frmCustomerSearch

    Private Sub frmCustomerSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Set tooltip for the CustomerID field
        tipCustomerSearch.SetToolTip(lblCustomerID, "Customer ID MUST be numeric")
        tipCustomerSearch.SetToolTip(txtCustomerID, "Customer ID MUST be numeric")

        ' Run the Search Customers Procedure to populate the datagrid
        SearchCustomers()

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
        ElseIf Not IsNumeric(txtCustomerID.Text) Then
            MessageBox.Show("The customer ID that you entered was not numeric." & Environment.NewLine &
                            "That field will be excluded from the search.", "Invalid Customer ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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

        ' Check if at least one search field has valid data, else show all top records
        If (blnCustomerID Or blnFirstName Or blnLastName) Then
            ' Adding WHERE clause, since there was at least one search field entered
            sqlCustomerSearchQuery += "WHERE "

            ' Only add to the sql string if there is data in the CustomerID textfield
            If blnCustomerID And IsNumeric(Me.txtCustomerID.Text) Then
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
                    sqlCustomerSearchQuery += "FirstName Like '%" & Me.txtFirstName.Text & "%' And "
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
            Else
                sqlCustomerSearchQuery += " And Active = 'True' "
            End If
        Else
            ' Show inactive customers
            If chkShowInactive.Checked Then
                sqlCustomerSearchQuery += "WHERE Active = 'False' "
            Else
                sqlCustomerSearchQuery += "WHERE Active = 'True' "
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
        stsRecordsReturned.Text = table.Rows.Count.ToString

    End Sub

    Private Sub dgvCustomers_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvCustomers.MouseDoubleClick

        'Run Procedure to send selected customer to the main form
        LoadSelectedCustomer()

    End Sub

    Private Sub btnLoadSelectedCustomer_Click(sender As Object, e As EventArgs) Handles btnLoadSelectedCustomer.Click

        'Run Procedure to send selected customer to the main form
        LoadSelectedCustomer()

    End Sub

    Private Sub LoadSelectedCustomer()

        ' Validate that there is customer data in the DataGridView in order to get selected customer
        If dgvCustomers.Rows.Count > 0 And dgvCustomers.SelectedRows.Count = 1 Then
            ' Get customerID from selected row
            Dim intSelectedCustomerID As Integer = CInt(dgvCustomers.SelectedRows(0).Cells(0).Value)

            ' Connect to the database and retrieve the complete data as a customer object
            Dim dbConn As clsDBConnection = New clsDBConnection

            'Create customer object
            Dim objSelectedCustomer As clsCustomer = dbConn.GetSelectedCustomer(intSelectedCustomerID)

            'Load the Selected Customer into the appropriate form
            If btnLoadSelectedCustomer.Text = "Load as Pet Owner" Then
                frmPet.LoadCustomerAsOwner(objSelectedCustomer)
            Else
                frmPawperingMain.LoadCustomer(objSelectedCustomer)
            End If

            ' Close this form
            Me.Close()

        Else
            MessageBox.Show("No Customer has been selected", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCustomerID.Select()
        End If

    End Sub

    Private Sub toolInstructionsStripMenuItem_Click(sender As Object, e As EventArgs) Handles toolInstructionsStripMenuItem.Click
        MessageBox.Show("SEARCH for a customer: " & Environment.NewLine &
                        "Enter a customerID Number " & Environment.NewLine &
                        "OR a portion of a first name or last name." & Environment.NewLine &
                        "OR Leave all of them blank to show them all." & Environment.NewLine & Environment.NewLine &
                        "Only a max of 25 records will show" & Environment.NewLine & Environment.NewLine &
                        "LOAD a customer: " & Environment.NewLine &
                        "Select a customer and click Load Customer" & Environment.NewLine &
                        "OR Double click on the customer", "Search Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub toolCloseSearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles toolCloseSearchToolStripMenuItem.Click
        ' Close the search form
        Me.Close()
    End Sub
End Class