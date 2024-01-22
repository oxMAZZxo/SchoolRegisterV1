Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO
Public Class AdminForm
    Private Students As Students
    Private Initiated As Boolean = False
    Private CurrentAdmin As Admin
    Private StudentForms() As StudentForm
    Private FormsOpened As Boolean
    Private IsSearching As Boolean
    Private Data As String
    Private Path As String = Application.StartupPath & "\Old Data\StudentData " & Utilities.GetCurrentDate & ".csv"
    Private Key As Byte = 128
    Private LoadOld As Boolean

    Private Sub AdminForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Label1.Text = "Current Admin: " & CurrentAdmin.GetName & " " & CurrentAdmin.GetSurname
        FormsOpened = False
        FormSort.SelectedIndex = 0
        StatusSort.SelectedIndex = 0
        MsgBox(Utilities.GetTimeOfDay)

    End Sub

    Private Sub LogOutButton_Click(sender As Object, e As EventArgs) Handles LogOutButton.Click
        Me.Hide()
        AdminLogIn.SetLabel3Text("Enter your details and click the log in button")
        AdminLogIn.Show()
    End Sub

    Private Sub StudentSignInButton_Click(sender As System.Object, e As System.EventArgs) Handles StudentSignInButton.Click
        If FormsOpened Then
            MsgBox("THE STUDENT FORMS HAVE ALREADY BEEN OPENED!")
            Return
        End If

        If IsSearching Then
            MsgBox("YOU MUST CLOSE THE SEARCH WINDOW")
            Return
        End If

        Me.Hide()
        HubChooser.Show()
        HubChooser.Focus()

    End Sub

    Private Sub StudentComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FormSort.SelectedIndexChanged
        If Initiated Then SortStudents()
    End Sub

    Private Sub AdminForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If Initiated = False Then
            Students = New Students(True)
            FormSort.Items.AddRange(Students.GetForms)
            Initiated = True
        End If
        RefreshGrid(False)
    End Sub

    Friend Sub CloseStudentForms()
        For looper = 0 To StudentForms.Length - 1
            StudentForms(looper).Close()
        Next
        FormSort.Text = ""
        StatusSort.Text = ""
    End Sub

    Friend Sub RefreshGrid(Status As Boolean)
        If Status Then
            Dim IfCount As Integer = 0
            StudentGrid.Rows.Clear()
            For looper = 0 To Students.GetNoOfStudents
                If Students.GetAStudent(looper).GetStatusIndex = StatusSort.SelectedIndex - 1 Then
                    StudentGrid.Rows.Add()
                    StudentGrid.Item(0, IfCount).Value = Students.GetAStudent(looper).GetID
                    StudentGrid.Item(1, IfCount).Value = Students.GetAStudent(looper).GetName
                    StudentGrid.Item(2, IfCount).Value = Students.GetAStudent(looper).GetSurname
                    StudentGrid.Item(3, IfCount).Value = Students.GetAStudent(looper).GetForm
                    StudentGrid.Item(4, IfCount).Value = Students.GetAStudent(looper).GetStatus
                    StudentGrid.Item(5, IfCount).Value = Students.GetAStudent(looper).GetCurrentHub
                    IfCount += 1
                End If
            Next
        Else
            StudentGrid.Rows.Clear()
            For looper = 0 To Students.GetNoOfStudents
                StudentGrid.Rows.Add()
                StudentGrid.Item(0, looper).Value = Students.GetAStudent(looper).GetID
                StudentGrid.Item(1, looper).Value = Students.GetAStudent(looper).GetName
                StudentGrid.Item(2, looper).Value = Students.GetAStudent(looper).GetSurname
                StudentGrid.Item(3, looper).Value = Students.GetAStudent(looper).GetForm
                StudentGrid.Item(4, looper).Value = Students.GetAStudent(looper).GetStatus
                StudentGrid.Item(5, looper).Value = Students.GetAStudent(looper).GetCurrentHub
            Next
        End If
    End Sub

    Private Sub ShowForm(Status As Boolean)

        If Status Then
            Dim IfCount As Integer = 0
            StudentGrid.Rows.Clear()
            For looper = 0 To Students.GetFormLength
                If Students.GetAStudentFromForm(looper).GetStatusIndex = StatusSort.SelectedIndex - 1 Then
                    StudentGrid.Rows.Add()
                    StudentGrid.Item(0, IfCount).Value = Students.GetAStudentFromForm(looper).GetID
                    StudentGrid.Item(1, IfCount).Value = Students.GetAStudentFromForm(looper).GetName
                    StudentGrid.Item(2, IfCount).Value = Students.GetAStudentFromForm(looper).GetSurname
                    StudentGrid.Item(3, IfCount).Value = Students.GetAStudentFromForm(looper).GetForm
                    StudentGrid.Item(4, IfCount).Value = Students.GetAStudentFromForm(looper).GetStatus
                    StudentGrid.Item(5, IfCount).Value = Students.GetAStudentFromForm(looper).GetCurrentHub
                    IfCount += 1
                End If
            Next
        Else
            Me.StudentGrid.Rows.Clear()
            For looper = 0 To Students.GetFormLength
                StudentGrid.Rows.Add()
                StudentGrid.Item(0, looper).Value = Students.GetAStudentFromForm(looper).GetID
                StudentGrid.Item(1, looper).Value = Students.GetAStudentFromForm(looper).GetName
                StudentGrid.Item(2, looper).Value = Students.GetAStudentFromForm(looper).GetSurname
                StudentGrid.Item(3, looper).Value = Students.GetAStudentFromForm(looper).GetForm
                StudentGrid.Item(4, looper).Value = Students.GetAStudentFromForm(looper).GetStatus
                StudentGrid.Item(5, looper).Value = Students.GetAStudentFromForm(looper).GetCurrentHub
            Next
        End If

    End Sub

    Friend Sub ShowStudentForms(HubAmount As Integer)
        ReDim StudentForms(HubAmount - 1)
        GC.Collect()

        For looper = 0 To StudentForms.Length - 1
            StudentForms(looper) = New StudentForm
            StudentForms(looper).HubLabel.Text = "Hub " & looper + 1
            StudentForms(looper).SetCurrentHub(looper + 1)
            StudentForms(looper).Show()
        Next
        FormsOpened = True
        HubChooser.Close()
        Me.Hide()
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        EncryptData()
        FileOpen(1, Path, OpenMode.Output)
        Print(1, Data)
        FileClose(1)
    End Sub

    Private Sub EncryptData()
        Dim temp As String = "ID, Name, Surname,Form,CurrentHub,TimeSignedIn"
        Data &= temp & vbCrLf
        Dim CurrentStudent As String
        Dim EncryptedStudent As String = ""
        For looper = 0 To Students.GetNoOfStudents
            CurrentStudent = Students.GetAStudent(looper).GetID & "," & Students.GetAStudent(looper).GetName & "," _
            & Students.GetAStudent(looper).GetSurname & "," & Students.GetAStudent(looper).GetForm & "," & Students.GetAStudent(looper).GetCurrentHub & "," & Students.GetAStudent(looper).GetTimeSignedIn
            For encrloop = 0 To CurrentStudent.Length - 1
                If CurrentStudent(encrloop) <> "," Then
                    EncryptedStudent &= Convert.ToChar(Asc(CurrentStudent(encrloop)) + Key)
                Else
                    EncryptedStudent &= ","
                End If
            Next
            Data &= EncryptedStudent & vbCrLf
            EncryptedStudent = ""
        Next
    End Sub

    Private Sub LoadOldData_Click(sender As Object, e As EventArgs) Handles LoadOldData.Click
        If LoadOld = False Then
            FindOldData.Show()
            LoadOld = True
        Else
            MsgBox("That window is already opened")
        End If
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        If IsSearching = False Then
            IsSearching = True
            SearchStudent.Show()
            SearchStudent.SetStudents(Students)
        Else
            MsgBox("That window is already opened")
        End If

    End Sub

    Private Sub StatusSort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StatusSort.SelectedIndexChanged
        If Initiated Then SortStudents()
    End Sub

    Private Sub SortStudents()

        If FormSort.SelectedItem = "All" And StatusSort.SelectedItem = "All" Then
            RefreshGrid(False)
        End If
        If FormSort.SelectedItem <> "All" Then
            Students.AssignForm(FormSort.SelectedItem)
            If StatusSort.SelectedItem = "All" Then
                ShowForm(False)
            Else
                ShowForm(True)
            End If
        End If
        If StatusSort.SelectedItem <> "All" Then
            If FormSort.SelectedItem <> "All" Then
                Students.AssignForm(FormSort.SelectedItem)
                ShowForm(True)
            Else
                RefreshGrid(True)
            End If
        End If

    End Sub
#Region "Getters & Setters"
    Friend Function GetStudents() As Students
        Return Me.Students
    End Function

    Friend Sub SetNewAdmin(newValue As Admin)
        Me.CurrentAdmin = newValue
    End Sub

    Friend Function GetStudentsFormActivated() As Boolean
        Return Me.FormsOpened
    End Function
    Friend Function GetStudentForms() As StudentForm()
        Return Me.StudentForms
    End Function

    Friend Function GetKey() As Integer
        Return Me.Key
    End Function

    Friend Sub SetSearching(NewValue As Boolean)
        Me.IsSearching = NewValue
    End Sub

    Friend Sub SetOldDataWindow(newValue As Boolean)
        Me.LoadOld = newValue
    End Sub
#End Region
End Class