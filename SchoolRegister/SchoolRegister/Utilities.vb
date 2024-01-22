Public MustInherit Class Utilities
    Friend Shared Function SortStudentsByID(ToSort As Students) As Students
        Dim SwapsMade As Boolean
        Dim TempStudent As Student
        Do
            SwapsMade = False
            For CompLoop = 0 To ToSort.GetNoOfStudents - 1
                If ToSort.GetAStudent(CompLoop).GetID > ToSort.GetAStudent(CompLoop + 1).GetID Then
                    TempStudent = ToSort.GetAStudent(CompLoop)
                    ToSort.SwapStudent(ToSort.GetAStudent(CompLoop + 1), CompLoop)
                    ToSort.SwapStudent(TempStudent, CompLoop + 1)
                    SwapsMade = True
                End If
            Next
        Loop Until SwapsMade = False

        Return ToSort
    End Function

    Friend Shared Function LinearSearch(Type As String, Students As Students, Text As String) As Students
        Dim NewListOfStudents As Students = New Students(False)
        Dim TempString As String = ""

        For Looper = 0 To Students.GetNoOfStudents
            Select Case Type
                Case "Name"
                    TempString = UCase(Mid(Students.GetAStudent(Looper).GetName, 1, Text.Length))
                Case "Surname"
                    TempString = UCase(Mid(Students.GetAStudent(Looper).GetSurname, 1, Text.Length))
            End Select

            If TempString = UCase(Text) Then
                NewListOfStudents.AddAStudent(Students.GetAStudent(Looper))
            End If
        Next

        Return NewListOfStudents
    End Function

    Friend Shared Function BinarySearch(Target As String, ListofStudents As Students, High As Integer, Mid As Integer, Low As Integer) As Integer
        Dim Found As Boolean

        Do
            Mid = (High + Low) \ 2
            If Target = ListofStudents.GetAStudent(Mid).GetID Then
                Found = True
            End If

            If Val(Target) > Val(ListofStudents.GetAStudent(Mid).GetID) Then
                Low = Mid + 1
            End If

            If Val(Target) < Val(ListofStudents.GetAStudent(Mid).GetID) Then
                High = Mid - 1
            End If
        Loop Until Found = True Or Low > High

        If Found = False Then
            Mid = -1
        End If

        Return Mid
    End Function

    'the Function below will return the current date in a string format
    Friend Shared Function GetCurrentDate() As String
        Dim CurrentDate As String
        'the function Date.Now return the date and time in the following format: 00/00/00 00:00:00
        'i only want the date rather than the time so I'm turning the data to a string and splitting it on the ' ' character
        Dim TempDate() As String = Split(Date.Now.ToString.ToString, " ")
        Dim DDMMYY() As String = Split(TempDate(0), "/")
        CurrentDate = DDMMYY(0) & "-" & DDMMYY(1) & "-" & DDMMYY(2)

        Return CurrentDate
    End Function
    Friend Shared Function GetTimeOfDay() As String
        Dim Time As String = ""
        Dim NewTimeAsString() As String = Split(TimeOfDay.ToString, " ")

        For looper = 0 To NewTimeAsString(1).Length - 1
            If NewTimeAsString(1)(looper) <> ":" Then
                Time &= NewTimeAsString(1)(looper)
            Else
                Time &= "-"
            End If
        Next
        Time = "Time " & Time
        Return Time
    End Function
End Class
