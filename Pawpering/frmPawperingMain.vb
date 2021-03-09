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
End Class
