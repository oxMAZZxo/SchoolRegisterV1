Public Class HubChooser
    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        Dim Invalid As Boolean
        Dim InvalidChars As String = "¬`""!£$%^&*()_+-={}[]:@~;'#<>?,./|\ "

        For looper = 0 To TextBox1.Text.Length - 1
            Select Case TextBox1.Text(looper)
                Case "A" To "Z", "a" To "z"
                    Invalid = True
                    MsgBox("PLEASE ENTER NUMBERS ONLY!" & vbCrLf & "LETTERS ARE NOT ALLOWED!")
                    Exit For
                Case Else
                    If InStr(InvalidChars, TextBox1.Text(looper)) > 0 Then
                        Invalid = True
                        MsgBox("PLEASE ENTER NUMBERS ONLY!")
                        Exit For
                    End If
            End Select
        Next

        If Invalid = False Then
            AdminForm.ShowStudentForms(Val(TextBox1.Text))
        End If
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        AdminForm.Show()
        Me.Close()
    End Sub
End Class