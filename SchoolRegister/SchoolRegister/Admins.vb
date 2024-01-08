Public Class Admins
    'an array of type Admin
    Private Admins() As Admin
    'the array AdminInfo holds the raw data of admins 
    'For example once the admins have been loaded the first position in the array will be 'T001,Paulos,Vlastos,p_vlastos,donkey'
    'which represent the variables ID,Name,Surname,Username,Password in the admin class
    Private AdminInfo() As String
    'number of admins
    Private NoOfAdmin As Integer

    Friend Sub New()
        LoadAdmins()
        Dim TempArray() As String
        ReDim Admins(NoOfAdmin - 1)
        For looper = 0 To Admins.Length - 1
            'extracts the raw data from each position in AdminInfo and splits them into five different pieces of data,
            'which are temporarly stored in TempArray
            'then proceeds to assign each piece into the corresponding variable in the Admins array
            TempArray = Split(AdminInfo(looper), ",")
            Admins(looper) = New Admin(TempArray(0), TempArray(1), TempArray(2), TempArray(3), TempArray(4))
        Next
    End Sub

    'following method loads admin information from an Excel CSV file
    Private Sub LoadAdmins()
        Dim Read As Boolean
        Dim Counter As Integer

        Try
            Read = True
            FileOpen(1, Application.StartupPath & "/Required Data/Admins.csv", OpenMode.Input)
        Catch ex As Exception
            MsgBox("The file named 'Admins' cannot be found in the 'Required Data' folder, on the installation folder of the application" _
                   & vbCrLf & "Make sure you place the a file of type '.csv' and name it 'Admins'" & vbCrLf &
                   "Refer to the manual if not sure how to proceed")
            Read = False
        End Try

        If Read Then
            Do While Not EOF(1)
                ReDim Preserve Me.AdminInfo(Counter)
                Me.AdminInfo(Counter) = LineInput(1)
                Me.NoOfAdmin += 1
                Counter += 1
            Loop
            FileClose(1)
        Else
            Application.Exit()
        End If
    End Sub

#Region "Getters"
    'gets a specific admin from Admins array
    Friend Function GetAdmin(Pos) As Admin
        Return Admins(Pos)
    End Function
    Friend Function GetNumberOfAdmins() As Integer
        Return NoOfAdmin - 1
    End Function
#End Region
End Class
