Public Class Student
    'template for a single student
    Private ID As Integer
    Private Name, Surname, Form, Status As String
    Private StatusIndex As Byte
    Private TimeSignedIn As Date
    Private CurrentHub As String
    Private SignedIn As Boolean
    Friend Sub New()
        Me.SetID(0)
        Me.SetName("")
        Me.SetSurname("")
        Me.SetForm("")
        Me.SetCurrentHub("No Hub")
        Me.Status = "Not Signed In"
    End Sub
    Friend Sub New(ID As Integer, Name As String, Surname As String, Form As String, CurrentHub As String, TimeSignedIn As Date)
        Me.SetID(ID)
        Me.SetName(Name)
        Me.SetSurname(Surname)
        Me.SetForm(Form)
        Me.SetCurrentHub(CurrentHub)
        Me.SetTimeSignedIn(TimeSignedIn)
    End Sub
#Region "Getters"
    Friend Function GetStatusIndex() As Byte
        Return Me.StatusIndex
    End Function
    Friend Function GetStatus() As String
        Return Me.Status
    End Function
    Friend Function GetID() As Integer
        Return Me.ID
    End Function
    Friend Function GetName() As String
        Return Me.Name
    End Function
    Friend Function GetSurname() As String
        Return Me.Surname
    End Function
    Friend Function GetForm() As String
        Return Me.Form
    End Function
    Friend Function GetTimeSignedIn() As String
        Dim TempArray() As String = Split(Me.TimeSignedIn.ToString, " ")

        Return TempArray(1)
    End Function
    Friend Function GetCurrentHub() As String
        Return Me.CurrentHub
    End Function
    Friend Function GetSignedIn() As Boolean
        Return Me.SignedIn
    End Function
#End Region
#Region "Setters"
    Friend Sub SetStatus(Time As String)
        If Val(Time) < 82000 Then
            Me.Status = "On Time"
            Me.StatusIndex = 1
        Else
            Me.Status = "Late"
            Me.StatusIndex = 2
        End If
    End Sub
    Friend Sub SetID(NewID As Integer)
        Me.ID = NewID
    End Sub
    Friend Sub SetName(newName As String)
        Me.Name = newName
    End Sub
    Friend Sub SetSurname(newSurname As String)
        Me.Surname = newSurname
    End Sub
    Friend Sub SetForm(NewForm As String)
        Me.Form = NewForm
    End Sub
    Friend Sub SetTimeSignedIn(NewTime As Date)
        Dim Time As String = ""
        Dim NewTimeAsString() As String = Split(NewTime.ToString, " ")
        Me.TimeSignedIn = NewTime

        For looper = 0 To NewTimeAsString(1).Length - 1
            If NewTimeAsString(1)(looper) <> ":" Then
                Time &= NewTimeAsString(1)(looper)
            End If
        Next
        SetStatus(Time)
    End Sub
    Friend Sub SetCurrentHub(NewHub As String)
        Me.CurrentHub = NewHub
    End Sub
    Friend Sub SetSignedIn(NewValue As Boolean)
        Me.SignedIn = NewValue
    End Sub
#End Region
End Class
