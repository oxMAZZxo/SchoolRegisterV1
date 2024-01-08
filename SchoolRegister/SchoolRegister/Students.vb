Public Class Students
    'the same principles as apply to this class as the Admins Class,
    'in terms of loading studednts, storing them etc.
    Private Students() As Student
    Private Forms() As String
    Private AllStudentInfo() As String
    Private SelectedForm() As Student
    Private NoOfStudents As Integer
    Private TempArray() As String

    Friend Sub New(LoadFromFile As Boolean)
        If LoadFromFile Then
            Me.LoadForms()
            Me.LoadStudents()
            ReDim Students(NoOfStudents - 1)
            For Student = 0 To Students.Length - 1
                Students(Student) = New Student
            Next
            For Looper = 0 To NoOfStudents - 1
                TempArray = Split(AllStudentInfo(Looper), ",")
                Me.Students(Looper).SetID(TempArray(0))
                Me.Students(Looper).SetName(TempArray(1))
                Me.Students(Looper).SetSurname(TempArray(2))
                Me.Students(Looper).SetForm(TempArray(3))
            Next

        End If
    End Sub
    Private Sub LoadForms()
        Dim counter = 0
        Dim Read As Boolean
        Try
            Read = True
            FileOpen(1, Application.StartupPath & "/Required Data/Forms.csv", OpenMode.Input)
        Catch ex As Exception
            MsgBox("The file named 'Forms' cannot be found in the 'Required Data' folder, on the installation folder of the application." _
                   & vbCrLf & "Make sure you place the file of type '.csv' and name it 'Forms'." & vbCrLf &
                   "Refer to the manual if not sure how to proceed")
            Read = False
        End Try
        If Read Then
            Do While Not EOF(1)
                ReDim Preserve Forms(counter)
                Forms(counter) = LineInput(1)
                counter += 1
            Loop
            FileClose()
        Else
            Application.Exit()
        End If
    End Sub
    Private Sub LoadStudents()
        Dim Counter As Integer = 0
        Dim Read As Boolean
        Try
            Read = True
            FileOpen(1, Application.StartupPath & "/Required Data/Students.csv", OpenMode.Input)
        Catch ex As Exception
            MsgBox("The file named 'Students' cannot be found in the 'Required Data' folder, on the installation folder of the application." _
                   & vbCrLf & "Make sure you place the a file of type '.csv' and name it 'Students'." & vbCrLf &
                   "Refer to the manual if not sure how to proceed")
            Read = False
        End Try
        If Read Then
            Do While Not EOF(1)
                ReDim Preserve AllStudentInfo(Counter)
                Me.AllStudentInfo(Counter) = LineInput(1)
                Me.NoOfStudents += 1
                Counter += 1
            Loop
            FileClose(1)
        Else
            Application.Exit()
        End If
    End Sub
    Friend Sub AssignForm(Form As String)
        Dim Counter As Integer
        SelectedForm = Nothing
        GC.Collect()

        For looper = 0 To Students.Length - 1
            If Students(looper).GetForm = Form Then
                ReDim Preserve SelectedForm(Counter)
                SelectedForm(Counter) = Students(looper)
                Counter += 1
            End If
        Next

    End Sub
#Region "Getter"
    Friend Function GetNoOfStudents()
        Return Me.NoOfStudents - 1
    End Function
    Friend Function GetAStudent(Pos As Integer) As Student
        Return Me.Students(Pos)
    End Function
    Friend Function GetAStudentFromForm(Pos) As Student
        Return Me.SelectedForm(Pos)
    End Function
    Friend Function GetFormLength() As Byte
        Return Me.SelectedForm.Length - 1
    End Function
    Friend Function GetNoOfForms() As Integer
        Return Me.Forms.Length - 1
    End Function
    Friend Function GetForms() As String()
        Return Forms
    End Function
#End Region
#Region "Setters"
    Friend Sub SwapStudent(NewStudent As Student, Pos As Integer)
        Me.Students(Pos) = NewStudent
    End Sub
    Friend Sub AddAStudent(Student As Student)
        NoOfStudents += 1
        ReDim Preserve Me.Students(NoOfStudents - 1)
        Me.Students(NoOfStudents - 1) = Student
    End Sub
#End Region
End Class