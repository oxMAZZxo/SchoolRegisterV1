Public Class Admin
    'template for a single Admin
    Private ID, Name, Surname, Username, Password As String

    Friend Sub New(NewID As String, NewName As String, NewSurname As String, NewUsername As String, NewPassword As String)
        SetID(NewID)
        SetName(NewName)
        SetSurname(NewSurname)
        SetUsername(NewUsername)
        SetPassword(NewPassword)
    End Sub
#Region "Getters"
    Friend Function GetID() As String
        Return Me.ID
    End Function
    Friend Function GetName() As String
        Return Me.Name
    End Function
    Friend Function GetSurname() As String
        Return Me.Surname
    End Function
    Friend Function GetUsername() As String
        Return Me.Username
    End Function
    Friend Function GetPassword() As String
        Return Me.Password
    End Function
#End Region
#Region "Setters"
    Friend Sub SetID(NewValue As String)
        Me.ID = NewValue
    End Sub
    Friend Sub SetName(NewValue As String)
        Me.Name = NewValue
    End Sub
    Friend Sub SetSurname(NewValue As String)
        Me.Surname = NewValue
    End Sub
    Friend Sub SetUsername(NewValue As String)
        Me.Username = NewValue
    End Sub
    Friend Sub SetPassword(NewValue As String)
        Me.Password = NewValue
    End Sub
#End Region
End Class
