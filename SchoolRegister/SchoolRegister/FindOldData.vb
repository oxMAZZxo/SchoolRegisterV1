Public Class FindOldData
    Private OldStudentData As Students

    Private Sub DecryptData(Path As String, Key As Integer)
        Dim NoOfLines As Integer
        Dim Counter As Integer
        Dim CurrentLine As String
        Dim TempData() As String
        Dim RawData As String
        Dim ConvertedData As String = Nothing

        Do While Not EOF(1)
            NoOfLines += 1
            CurrentLine = LineInput(1)
            TempData = Split(CurrentLine, ",")
            For ItemLoop = 0 To TempData.Length - 1
                RawData = TempData(ItemLoop)
                For CharLoop = 0 To RawData.Length - 1
                    ConvertedData &= Convert.ToChar(Math.Abs(Key - Asc(RawData(CharLoop))))
                Next
                TempData(ItemLoop) = ConvertedData
                ConvertedData = Nothing
            Next
            Dim CurrentStudent As Student = New Student(TempData(0), TempData(1), TempData(2), TempData(3), TempData(4), TempData(5))
            OldStudentData.AddAStudent(CurrentStudent)
            Counter += 1
        Loop
    End Sub

    Private Sub FindButton_Click(sender As Object, e As EventArgs) Handles FindButton.Click
        Dim Path As String

        If OldStudentData IsNot Nothing Then
            OldStudentData = Nothing
            OldStudentData = New Students(False)
        Else
            OldStudentData = New Students(False)
        End If

        Path = Application.StartupPath & "\Old Data\StudentData " & Day.Text & "-" & Month.Text & "-" & Year.Text & ".txt"

        If Day.Text = "" Or Month.Text = "" Or Year.Text = "" Then
            MsgBox("Fill all the textboxes")
        Else
            Try
                FileOpen(1, Path, OpenMode.Input)
                DecryptData(Path, AdminForm.GetKey)
                FileClose(1)
                ShowStudents()
            Catch ex As Exception
                StudentGrid.Visible = False
                FileNotFoundLabel.Visible = True
            End Try
        End If
    End Sub

    Private Sub ShowStudents()
        FileNotFoundLabel.Visible = False
        StudentGrid.Visible = True
        StudentGrid.Rows.Clear()
        For looper = 0 To OldStudentData.GetNoOfStudents
            StudentGrid.Rows.Add()
            StudentGrid.Item(0, looper).Value = OldStudentData.GetAStudent(looper).GetID
            StudentGrid.Item(1, looper).Value = OldStudentData.GetAStudent(looper).GetName
            StudentGrid.Item(2, looper).Value = OldStudentData.GetAStudent(looper).GetSurname
            StudentGrid.Item(3, looper).Value = OldStudentData.GetAStudent(looper).GetForm
            StudentGrid.Item(4, looper).Value = OldStudentData.GetAStudent(looper).GetTimeSignedIn
            StudentGrid.Item(5, looper).Value = OldStudentData.GetAStudent(looper).GetCurrentHub
        Next
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        AdminForm.SetOldDataWindow(False)
        Me.Close()
    End Sub
End Class