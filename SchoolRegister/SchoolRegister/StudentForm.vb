Public Class StudentForm
    Private WithEvents Timer As Timer = New Timer
    Private CurrentHub As Integer

    Private Sub StudentForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Timer.Interval = 3000
    End Sub

    Private Sub StudentForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'the form will be indicated as active
        'and the labels in the form will be set to nothing
        Label1.Text = "Type in your ID and press the ENTER key"
        Label2.Text = ""
        TextBox1.Text = ""
    End Sub

    Private Sub AdminFormButton_Click(sender As Object, e As EventArgs) Handles AdminFormButton.Click
        AdminForm.RefreshGrid(False)
        AdminLogIn.SetLabel3Text("Enter your details and click the log in button")
        AdminLogIn.Show()
    End Sub

    'the following method activates when a student presses a key in the textbox that sits on the StudentForm
    Private Sub TextBox1_KeyDown1(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        Dim StudentFound As Boolean
        Dim AlreadySignedIn As Boolean
        Dim CurrentStudent As Student
        Dim Position As Integer

        If e.KeyCode = Keys.Enter Then
            'will only run following code if the ENTER key has been pressed.
            Try
                'exception handling has been used, in order to detect if a student has entered only numbers in the textbox in the StudentForm
                'because all Student IDs are made up of only numbers
                Int32.Parse(TextBox1.Text)
                GC.Collect()
                If Me.TextBox1.Text.Length = 4 Then
                    'all student IDs are 4 characters long, a student must only enter four characters only
                    StudentFound = True
                    Position = Utilities.BinarySearch(TextBox1.Text, AdminForm.GetStudents, AdminForm.GetStudents.GetNoOfStudents, 0, 0)
                    If Position = -1 Then
                        StudentFound = False
                    Else
                        CurrentStudent = AdminForm.GetStudents.GetAStudent(Position)
                        If CurrentStudent.GetSignedIn = True Then
                            AlreadySignedIn = True
                        Else
                            CurrentStudent.SetSignedIn(True)
                            CurrentStudent.SetTimeSignedIn(TimeOfDay)
                            CurrentStudent.SetCurrentHub("Hub " & Me.CurrentHub)
                            Label1.Text = "Good Morning " & CurrentStudent.GetName
                            'displays time where the current student singed in
                            Me.Label2.Text = "Time signed in: " & TimeOfDay.TimeOfDay.ToString()
                            AdminForm.GetStudents.SwapStudent(CurrentStudent, Position)
                        End If
                    End If
                    TextBox1.Text = ""
                Else
                    'if more or less than four numbers have been entered the string below will be displayed.
                    Me.Label1.Text = "Please only enter 4 digits"
                    Label2.Text = ""
                End If
                If StudentFound = False Then
                    Me.Label1.Text = "A student with the ID entered cannot be found!"
                    Label2.Text = ""
                End If
                If StudentFound And AlreadySignedIn Then
                    Label1.Text = "Student already signed in!!"
                    Label2.Text = ""
                End If
            Catch ex As FormatException
                'if any other characters but numbers have been entered
                'a Format exception will be thrown and the string below will be displayed
                Me.Label1.Text = "Please type in digits only"
                Label2.Text = ""
            End Try
        End If

    End Sub

    'erases the text from a label when the timer ticks
    Private Sub OnTimerTick() Handles Timer.Tick
        Label1.Text = "Type in your ID and press the ENTER key"
        Label2.Text = ""
        TextBox1.Text = ""
        Timer.Enabled = False
    End Sub

#Region "Getters & Setters"
    Friend Sub SetCurrentHub(NewValue As Byte)
        Me.CurrentHub = NewValue
    End Sub

#End Region
End Class