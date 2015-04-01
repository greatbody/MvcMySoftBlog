Public Class UserBase
    Private _userName As String
    Public Property UserName() As String
        Get
            Return _userName
        End Get
        Set(ByVal value As String)
            _userName = value
        End Set
    End Property

    Private _userCode As String
    Public Property UserCode() As String
        Get
            Return _userCode
        End Get
        Set(ByVal value As String)
            _userCode = value
        End Set
    End Property


    Private _role As UserRole
    Public Property Role() As UserRole
        Get
            Return _role
        End Get
        Set(ByVal value As UserRole)
            _role = value
        End Set
    End Property

    Public Enum UserRole
        Admin = 1
        User = 2
        Leader = 4
        Manager = 8
        CompanyManager = 16
        HumanResource = 32
    End Enum

End Class
