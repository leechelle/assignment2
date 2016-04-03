Public Class Class1

    Dim Membership As String
    Dim FirstName As String
    Dim Surname As String
    Dim OutFee As String
    Dim Race As String
    Dim RaceTime As String
    Dim male As String
    Dim female As String

    Public Property txtMembership() As String
        Get
            Return Membership
        End Get
        Set(ByVal value As String)
            Membership = value
        End Set
    End Property


    Public Property txtFirstName() As String
        Get
            Return FirstName
        End Get
        Set(ByVal value As String)
            FirstName = value
        End Set
    End Property


    Public Property txtSurname() As String
        Get
            Return Surname
        End Get
        Set(ByVal value As String)
            Surname = value
        End Set
    End Property

    Public Property txtOutFee() As String
        Get
            Return OutFee
        End Get
        Set(ByVal value As String)
            OutFee = value
        End Set
    End Property


    Public Property txtRace() As String
        Get
            Return Race
        End Get
        Set(ByVal value As String)
            Race = value
        End Set
    End Property


    Public Property txtRaceTime() As String
        Get
            Return RaceTime
        End Get
        Set(ByVal value As String)
            RaceTime = value
        End Set
    End Property

    Public Property txtMale() As String
        Get
            Return male
        End Get
        Set(ByVal value As String)
            male = value
        End Set
    End Property

    Public Property txtFemale() As String
        Get
            Return female
        End Get
        Set(ByVal value As String)
            female = value
        End Set
    End Property

End Class
