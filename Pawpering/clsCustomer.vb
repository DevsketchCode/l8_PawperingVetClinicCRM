' Project: Pawpering Vet Clinic CRM
' Author: David Oberlander
' Purpose: (CVTC) VB.NET Final Project: Develop your own.
' Date: 03/06/2021

Option Strict On
Option Explicit On
Public Class clsCustomer

    ' Declare User Variables
    Private msterCustomerID As Integer
    Private mstrFirstName As String
    Private mstrLastName As String
    Private mstrAddress1 As String
    Private mstrAddress2 As String
    Private mstrCity As String
    Private mstrState As String
    Private mstrZipCode As String
    Private mstrPhoneNumber1 As String
    Private mstrPhoneNumber2 As String
    Private mstrEmail As String
    Private mstrCustomerSince As Date

    ' Generate a Default Constructor
    Public Sub New()
        msterCustomerID = 0
        mstrFirstName = String.Empty
        mstrLastName = String.Empty
        mstrAddress1 = String.Empty
        mstrAddress2 = String.Empty
        mstrCity = String.Empty
        mstrState = String.Empty
        mstrZipCode = String.Empty
        mstrPhoneNumber1 = String.Empty
        mstrPhoneNumber2 = String.Empty
        mstrEmail = String.Empty
        mstrCustomerSince = Date.Now()
    End Sub

    ' Generate an Overloaded Constructor
    Public Sub New(msterCustomerID As Integer, mstrFirstName As String, mstrLastName As String,
                   mstrAddress1 As String, mstrAddress2 As String, mstrCity As String,
                   mstrState As String, mstrZipCode As String, mstrPhoneNumber1 As String,
                   mstrPhoneNumber2 As String, mstrEmail As String, mstrCustomerSince As Date)
        Me.msterCustomerID = msterCustomerID
        Me.mstrFirstName = mstrFirstName
        Me.mstrLastName = mstrLastName
        Me.mstrAddress1 = mstrAddress1
        Me.mstrAddress2 = mstrAddress2
        Me.mstrCity = mstrCity
        Me.mstrState = mstrState
        Me.mstrZipCode = mstrZipCode
        Me.mstrPhoneNumber1 = mstrPhoneNumber1
        Me.mstrPhoneNumber2 = mstrPhoneNumber2
        Me.mstrEmail = mstrEmail
        Me.mstrCustomerSince = mstrCustomerSince
    End Sub

    ' Getter and Setter Methods
    Public Property CustomerID As Integer
        Get
            Return msterCustomerID
        End Get
        Set(value As Integer)
            msterCustomerID = value
        End Set
    End Property

    Public Property FirstName As String
        Get
            Return mstrFirstName
        End Get
        Set(value As String)
            mstrFirstName = value
        End Set
    End Property

    Public Property LastName As String
        Get
            Return mstrLastName
        End Get
        Set(value As String)
            mstrLastName = value
        End Set
    End Property

    Public Property Address1 As String
        Get
            Return mstrAddress1
        End Get
        Set(value As String)
            mstrAddress1 = value
        End Set
    End Property

    Public Property Address2 As String
        Get
            Return mstrAddress2
        End Get
        Set(value As String)
            mstrAddress2 = value
        End Set
    End Property

    Public Property City As String
        Get
            Return mstrCity
        End Get
        Set(value As String)
            mstrCity = value
        End Set
    End Property

    Public Property State As String
        Get
            Return mstrState
        End Get
        Set(value As String)
            mstrState = value
        End Set
    End Property

    Public Property ZipCode As String
        Get
            Return mstrZipCode
        End Get
        Set(value As String)
            mstrZipCode = value
        End Set
    End Property

    Public Property PhoneNumber1 As String
        Get
            Return mstrPhoneNumber1
        End Get
        Set(value As String)
            mstrPhoneNumber1 = value
        End Set
    End Property

    Public Property PhoneNumber2 As String
        Get
            Return mstrPhoneNumber2
        End Get
        Set(value As String)
            mstrPhoneNumber2 = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return mstrEmail
        End Get
        Set(value As String)
            mstrEmail = value
        End Set
    End Property

    Public Property CustomerSince As Date
        Get
            Return mstrCustomerSince
        End Get
        Set(value As Date)
            mstrCustomerSince = value
        End Set
    End Property

    ' Methods
    Public Function Full_Name() As String
        Return mstrFirstName & " " & mstrLastName
    End Function

    Public Function City_State_Zip() As String
        Return mstrCity & ", " & mstrState & " " & mstrZipCode
    End Function

    ' Calculate how many years have passed since the customer was entered in the system
    Public Sub Calculate_Years(ByVal strCustomerDate As String, ByRef intYears As Integer)
        intYears = CInt(DateDiff(DateInterval.Year, CDate(strCustomerDate), Date.Now))
    End Sub
End Class
