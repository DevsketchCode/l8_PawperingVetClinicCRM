Option Strict On
Option Explicit On
' Project: Pawpering Vet Clinic CRM
' Author: David Oberlander
' Purpose: (CVTC) VB.NET Final Project: Develop your own.
' Date: 03/06/2021

Public Class frmCustomer

    ' Module Level Objects
    Public objCustomer As New clsCustomer()
    Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToParent()

        ' Populate the US States combo box
        cboState.DataSource = PopulateStates()
    End Sub

    Private Function PopulateStates() As Collection
        ' Create collection of all the states of the U.S.
        Dim colStates As Collection
        colStates = New Collection
        colStates.Add("Alabama", "AL")
        colStates.Add("Alaska", "AK")
        colStates.Add("Arizona", "AZ")
        colStates.Add("Arkansas", "AR")
        colStates.Add("California", "CA")
        colStates.Add("Colorado", "CO")
        colStates.Add("Connecticut", "CT")
        colStates.Add("Delaware", "DE")
        colStates.Add("Florida", "FL")
        colStates.Add("Georgia", "GA")
        colStates.Add("Hawaii", "HI")
        colStates.Add("Idaho", "ID")
        colStates.Add("Illinois", "IL")
        colStates.Add("Indiana", " IN")
        colStates.Add("Iowa", "IA")
        colStates.Add("Kansas", "KS")
        colStates.Add("Kentucky", "KY")
        colStates.Add("Louisiana", "LA")
        colStates.Add("Maine", "Me")
        colStates.Add("Maryland", "MD")
        colStates.Add("Massachusetts", "MA")
        colStates.Add("Michigan", "MI")
        colStates.Add("Minnesota", "MN")
        colStates.Add("Mississippi", "MS")
        colStates.Add("Missouri", "MO")
        colStates.Add("Montana", "MT")
        colStates.Add("Nebraska", "NE")
        colStates.Add("Nevada", "NV")
        colStates.Add("New Hampshire", " NH")
        colStates.Add("New Jersey", " NJ")
        colStates.Add("New Mexico", " NM")
        colStates.Add("New York", " NY")
        colStates.Add("North Carolina", " NC")
        colStates.Add("North Dakota", " ND")
        colStates.Add("Ohio", "OH")
        colStates.Add("Oklahoma", "OK")
        colStates.Add("Oregon", " Or")
        colStates.Add("Pennsylvania", " PA")
        colStates.Add("Rhode Island", " RI")
        colStates.Add("South Carolina", " SC")
        colStates.Add("South Dakota", " SD")
        colStates.Add("Tennessee", "TN")
        colStates.Add("Texas", "TX")
        colStates.Add("Utah", "UT")
        colStates.Add("Vermont", "VT")
        colStates.Add("Virginia", "VA")
        colStates.Add("Washington", "WA")
        colStates.Add("West Virginia", " WV")
        colStates.Add("Wisconsin", "WI")
        colStates.Add("Wyoming", "WY")

        Return colStates
    End Function

    Private Sub btnSaveAndLoad_Click(sender As Object, e As EventArgs) Handles btnSaveAndLoad.Click

        'Validate text fields to make sure they have data
        If ValidateTextBoxes() Then
            'Populate customer object with data from user
            Dim newCustomer As clsCustomer = PopulateCustomer()

            MessageBox.Show(PopulateCustomer().Full_Name)

            'Create object to connect tot he database
            Dim newConnection As clsDBConnection
            newConnection = New clsDBConnection

            ' Open the db connection
            Dim dbConn = newConnection.OpenDBConnection()

            ' Insert the data from the form into the database
            newConnection.InsertCustomer(newCustomer)

            ' Close the database
            dbConn.Close()

        Else
            MessageBox.Show("Please fill out every field." & Environment.NewLine & "Address2 and Alternate Number are not required.", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


    End Sub


    Private Function ValidateTextBoxes() As Boolean
        Dim isValid As Boolean = True

        ' Check to see if all the text boxes have data
        For Each tb In grpCustomer.Controls.OfType(Of TextBox)
            If tb.Text.Equals("") And Not (tb.Name.Equals("txtAddress2") Or tb.Name.Equals("txtPhoneNumber2")) Then
                isValid = False
            End If
        Next

        Return isValid
    End Function

    Private Function PopulateCustomer() As clsCustomer

        objCustomer.FirstName = txtFirstName.Text
        objCustomer.LastName = txtLastName.Text
        objCustomer.Address1 = txtAddress1.Text
        objCustomer.Address2 = txtAddress2.Text
        objCustomer.City = txtCity.Text
        objCustomer.State = cboState.SelectedItem.ToString
        objCustomer.ZipCode = txtZipCode.Text
        objCustomer.PhoneNumber1 = txtPhoneNumber1.Text
        objCustomer.PhoneNumber2 = txtPhoneNumber2.Text
        objCustomer.Email = txtEmail.Text
        objCustomer.CustomerSince = dteCustomerSince.Value

        Return objCustomer
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Clear Customer Form
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtAddress1.Text = ""
        txtAddress2.Text = ""
        txtCity.Text = ""
        cboState.SelectedIndex = 0
        txtZipCode.Text = ""
        txtPhoneNumber1.Text = ""
        txtPhoneNumber2.Text = ""
        txtEmail.Text = ""
        dteCustomerSince.Value = Now()

    End Sub
End Class