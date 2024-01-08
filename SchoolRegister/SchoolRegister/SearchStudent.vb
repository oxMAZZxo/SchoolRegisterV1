Public Class SearchStudent
    Private Students As Students

    Private Sub FindButton_Click(sender As Object, e As EventArgs) Handles FindButton.Click
        Dim ValidChars = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm"
        Dim ValidDigits = "1234567890"
        Dim Invalid As Boolean
        Dim CurrentStudent As Student
        Dim High As Integer
        Dim Position As Integer
        Dim ListOfStudents As Students = Utilities.LinearSearch(ComboBox.Text, Students, SearchBox.Text)


        For looper = 0 To SearchBox.Text.Length - 1
            If ComboBox.Text = "ID" And InStr(ValidDigits, SearchBox.Text(looper)) < 1 Then
                InvalidLabel.Text = "Please type digits only when searching by ID"
                InvalidLabel.Font = New Font("Microsoft Sans Serif", 48, FontStyle.Regular)
                Invalid = True
                Exit For
            ElseIf InStr(ValidChars, SearchBox.Text(looper)) < 1 And ComboBox.Text <> "ID" Then
                InvalidLabel.Text = "Please type in alphabetic characters only when searching by Name or Surname"
                InvalidLabel.Font = New Font("Microsoft Sans Serif", 40, FontStyle.Regular)
                Invalid = True
                Exit For
            End If
        Next

        If Invalid = True Then
            DisableAll()
            InvalidLabel.Visible = True
            Return
        End If


        If ComboBox.Text = "ID" Then
            Students = Utilities.SortStudentsByID(Students)
            High = Students.GetNoOfStudents
            Position = Utilities.BinarySearch(SearchBox.Text, Students, High, 0, 0)

            If Position = -1 Then
                DisableAll()
                NotFoundLabel.Visible = True
                ComboBox.Text = ""
            Else
                CurrentStudent = Students.GetAStudent(Position)
                TextBox1.Text = CurrentStudent.GetID
                TextBox2.Text = CurrentStudent.GetName
                TextBox3.Text = CurrentStudent.GetSurname
                TextBox4.Text = CurrentStudent.GetForm
                TextBox5.Text = CurrentStudent.GetTimeSignedIn.ToString
                TextBox6.Text = CurrentStudent.GetCurrentHub
                TextBox7.Text = CurrentStudent.GetStatus
            End If
        Else

            If ListOfStudents.GetNoOfStudents > -1 Then
                StudentGrid.Rows.Clear()
                For looper = 0 To ListOfStudents.GetNoOfStudents
                    StudentGrid.Rows.Add()
                    StudentGrid.Item(0, looper).Value = ListOfStudents.GetAStudent(looper).GetID.ToString
                    StudentGrid.Item(1, looper).Value = ListOfStudents.GetAStudent(looper).GetName
                    StudentGrid.Item(2, looper).Value = ListOfStudents.GetAStudent(looper).GetSurname
                    StudentGrid.Item(3, looper).Value = ListOfStudents.GetAStudent(looper).GetForm
                    StudentGrid.Item(4, looper).Value = ListOfStudents.GetAStudent(looper).GetTimeSignedIn
                    StudentGrid.Item(5, looper).Value = ListOfStudents.GetAStudent(looper).GetCurrentHub
                Next
            Else
                DisableAll()
                NotFoundLabel.Visible = True
                StudentGrid.Rows.Clear()
                ComboBox.Text = ""
            End If
        End If
    End Sub

    Friend Sub SetStudents(ByVal NewValue As Students)
        Me.Students = NewValue
    End Sub

    Private Sub DisableAll()
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        TextBox1.Visible = False
        TextBox2.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = False
        TextBox5.Visible = False
        TextBox6.Visible = False
        TextBox7.Visible = False
        StudentGrid.Visible = False
        SearchBox.Visible = False
        SearchBox.Text = ""
        NotFoundLabel.Visible = False
        FindButton.Visible = False
        InvalidLabel.Visible = False
    End Sub

    Private Sub ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox.SelectedIndexChanged
        DisableAll()
        If ComboBox.Text <> "" Then
            If ComboBox.Text = "ID" Then
                Label2.Visible = True
                Label3.Visible = True
                Label4.Visible = True
                Label5.Visible = True
                Label6.Visible = True
                Label7.Visible = True
                Label8.Visible = True
                TextBox1.Visible = True
                TextBox2.Visible = True
                TextBox3.Visible = True
                TextBox4.Visible = True
                TextBox5.Visible = True
                TextBox6.Visible = True
                TextBox7.Visible = True
                StudentGrid.Visible = False
                SearchBox.Visible = True
                FindButton.Visible = True
            Else
                SearchBox.Visible = True
                Label2.Visible = False
                Label3.Visible = False
                Label4.Visible = False
                Label5.Visible = False
                Label6.Visible = False
                Label7.Visible = False
                Label8.Visible = False
                TextBox1.Visible = False
                TextBox2.Visible = False
                TextBox3.Visible = False
                TextBox4.Visible = False
                TextBox5.Visible = False
                TextBox6.Visible = False
                TextBox7.Visible = False
                FindButton.Visible = True
                StudentGrid.Visible = True
            End If
        End If
    End Sub

    Private Sub SearchStudent_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        DisableAll()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        AdminForm.SetSearching(False)
        AdminForm.RefreshGrid(False)
        AdminForm.Focus()
        Me.Close()
    End Sub
End Class