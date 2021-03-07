' Project: Pawpering Vet Clinic CRM
' Author: David Oberlander
' Purpose: (CVTC) VB.NET Final Project: Develop your own.
' Date: 03/06/2021

Option Strict On
Option Explicit On

Public Class frmCustomer
    Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
End Class