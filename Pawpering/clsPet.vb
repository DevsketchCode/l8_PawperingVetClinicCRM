' Project: Pawpering Vet Clinic CRM
' Author: David Oberlander
' Purpose: (CVTC) VB.NET Final Project: Develop your own.
' Date: 03/08/2021

' The Pet Class

Option Strict On
Option Explicit On
Public Class clsPet

    'Declare Variables
    Private mstrPetID As Integer
    Private mstrName As String
    Private mstrOwners As Dictionary(Of Integer, String)
    Private mstrSpeciesID As Integer
    Private mstrBreedID As Integer
    Private mstrColor As String
    Private mstrBirthDate As Date
    Private mstrGender As String
    Private mstrStatus As String
    Private mstrDeceasedDate As Date
    Private mstrPhoto As String
    Private mstrActive As Boolean

    'Generate a default constructor
    Public Sub New()
        mstrPetID = 0
        mstrName = "[No Name]"
        mstrOwners = Nothing
        mstrSpeciesID = 1
        mstrBreedID = 1
        mstrColor = "Other"
        mstrBirthDate = Date.Now()
        mstrGender = "Unknown"
        mstrStatus = "Alive"
        mstrDeceasedDate = Date.Now()
        mstrPhoto = String.Empty
        mstrActive = True
    End Sub

    ' Generate an Overloaded Constructor
    Public Sub New(mstrPetID As Integer, mstrName As String, mstrOwners As Dictionary(Of Integer, String),
                   mstrSpeciesID As Integer, mstrBreedID As Integer, mstrColor As String,
                   mstrBirthDate As Date, mstrGender As String, mstrStatus As String, mstrDeceasedDate As Date, mstrPhoto As String,
                   mstrActive As Boolean)
        Me.mstrPetID = mstrPetID
        Me.mstrName = mstrName
        Me.mstrOwners = mstrOwners
        Me.mstrSpeciesID = mstrSpeciesID
        Me.mstrBreedID = mstrBreedID
        Me.mstrColor = mstrColor
        Me.mstrBirthDate = mstrBirthDate
        Me.mstrGender = mstrGender
        Me.mstrStatus = mstrStatus
        Me.mstrDeceasedDate = mstrDeceasedDate
        Me.mstrPhoto = mstrPhoto
        Me.mstrActive = mstrActive
    End Sub

    'Getter and Setter Methods
    Public Property PetID As Integer
        Get
            Return mstrPetID
        End Get
        Set(value As Integer)
            mstrPetID = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return mstrName
        End Get
        Set(value As String)
            mstrName = value
        End Set
    End Property

    Public Property Owners As Dictionary(Of Integer, String)
        Get
            Return mstrOwners
        End Get
        Set(value As Dictionary(Of Integer, String))
            mstrOwners = value
        End Set
    End Property

    Public Property SpeciesID As Integer
        Get
            Return mstrSpeciesID
        End Get
        Set(value As Integer)
            mstrSpeciesID = value
        End Set
    End Property

    Public Property BreedID As Integer
        Get
            Return mstrBreedID
        End Get
        Set(value As Integer)
            mstrBreedID = value
        End Set
    End Property

    Public Property Color As String
        Get
            Return mstrColor
        End Get
        Set(value As String)
            mstrColor = value
        End Set
    End Property

    Public Property Gender As String
        Get
            Return mstrGender
        End Get
        Set(value As String)
            mstrGender = value
        End Set
    End Property

    Public Property BirthDate As Date
        Get
            Return mstrBirthDate
        End Get
        Set(value As Date)
            mstrBirthDate = value
        End Set
    End Property

    Public Property Status As String
        Get
            Return mstrStatus
        End Get
        Set(value As String)
            mstrStatus = value
        End Set
    End Property

    Public Property DeceasedDate As Date
        Get
            Return mstrDeceasedDate
        End Get
        Set(value As Date)
            mstrDeceasedDate = value
        End Set
    End Property

    Public Property Photo As String
        Get
            Return mstrPhoto
        End Get
        Set(value As String)
            mstrPhoto = value
        End Set
    End Property

    Public Property Active As Boolean
        Get
            Return mstrActive
        End Get
        Set(value As Boolean)
            mstrActive = value
        End Set
    End Property

    ' Calculate the Age of the pet
    Public Function CalculatePetAge(ByVal strPetBirthDate As Date) As Integer

        Dim intYears As Integer = CInt(DateDiff(DateInterval.Year, CDate(strPetBirthDate), Date.Now))

        Return intYears
    End Function
End Class
