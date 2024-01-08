Public Class AdminLogIn
    Private Admins As Admins
    Private LogInFirstTime As Boolean
    Private CurrentAdmin As Admin
    Private FirstRun As Boolean

    Private Sub AdminLogIn_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        Dim FileText As String
        FileOpen(1, Application.StartupPath & "/firsttime.txt", OpenMode.Input)
        FileText = LineInput(1)
        FileClose(1)
        If FileText = "true" Then
            FirstRun = True
            FileOpen(1, Application.StartupPath & "/firsttime.txt", OpenMode.Output)
            Print(1, "false")
            FileClose()
        End If
        If FirstRun = True Then
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\Required Data")
            My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\Old Data")
            MsgBox("Please place the following files in the 'Required Data' folder, located in the directory of the application:" & vbCrLf _
                  & " * 'Students.csv' file which should contain all the student data required, in the neccessary format." & vbCrLf _
                  & " * 'Admins.csv' file which should contain all the administrator data required, in the neccessary format." & vbCrLf &
                   "Refer to the manual if not sure how to proceed")
            Application.Exit()
        Else
            TextBox2.PasswordChar = "*"
            Label3.Text = "Enter your details and click the log in button"
            If LogInFirstTime = False Then
                Me.Admins = New Admins
                LogInFirstTime = True
            End If
        End If
    End Sub

    'the method below actives when the LogIn button is pressed in the Admin Log In window
    Private Sub LogInButton_Click(sender As Object, e As EventArgs) Handles LogInButton.Click
        Dim AdminFound As Boolean
        Dim IncorrectPass As Boolean
        Dim Counter As Integer

        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            Label3.Text = "Both textboxes need to be filled!"
            Return
        End If

        Do
            'counter exists so that it acts as a pointer to use, in order to get a specific admin
            'but also as a base case, in order to exit the loop, in the case where there is no admin found
            If Admins.GetAdmin(Counter).GetUsername = TextBox1.Text Then
                If Admins.GetAdmin(Counter).GetPassword = TextBox2.Text Then
                    'as soon as an admin is found, the program can exit the loop without having to go through the rest of the admins
                    'makes program more effecient
                    AdminFound = True
                Else
                    'if the an admin with the username entered has been found,
                    'but the password is incorrect, the boolean IncorrectPass will be set to true
                    IncorrectPass = True
                End If
            End If
            Counter += 1
        Loop Until AdminFound Or Counter = Admins.GetNumberOfAdmins + 1
        If AdminFound And IncorrectPass = False Then
            'if the details entered are correct then the current admin will be assigned and logged in to the AdminForm
            CurrentAdmin = Admins.GetAdmin(Counter - 1)
            TextBox1.Text = ""
            TextBox2.Text = ""
            ShowAdminForm()
        ElseIf IncorrectPass = True Then
            'the following string will be displayed in the case IncorrectPass is true
            Label3.Text = "The password you have entered is incorrect!"
        Else
            'if a the username entered cannot be found the following string will be displayed
            Label3.Text = "A user with the details you entered cannot be found!"
        End If
    End Sub

    Private Sub ShowAdminForm()
        Me.Hide()

        If AdminForm.GetStudentsFormActivated Then
            For Each Form In AdminForm.GetStudentForms
                Form.Close()
            Next
        End If
        AdminForm.SetNewAdmin(CurrentAdmin)
        AdminForm.Show()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        If AdminForm.GetStudentsFormActivated Then
            Me.Hide()
            TextBox1.Text = ""
            TextBox2.Text = ""
            Label3.Text = ""
        Else
            Application.Exit()
        End If
    End Sub

    Friend Sub SetLabel3Text(NewValue As String)
        Label3.Text = NewValue
    End Sub

    Private Sub AdminLogIn_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        TextBox1.Focus()
    End Sub
End Class