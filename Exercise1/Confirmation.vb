'Erin Rasmussen
'ejrasmussen2@wisc.edu
'CS 371
'Lab1

' This class displays a form for the user to double-check their entry before proceding
' The class is also responsible for creating the id if the user decides to continue
Public Class Confirmation
    Dim firstName As String
    Dim lastName As String
    Dim phone As String
    Dim id As String

    ' If the user confirms their entry, this method exports the data to the Alert form with their
    ' new user id.
    Private Sub ConfirmButton_Click(sender As System.Object, e As System.EventArgs) Handles ConfirmButton.Click
        firstName = FirstNameLabel.Text
        lastName = LastNameLabel.Text

        ' Creating the user id with the given format
        Try
            phone = PhoneLabel.Text.Substring(9, 4)
            id = firstName + "." + lastName + "." + phone
            Alert.UserIDLabel.Text = id
        Catch ex As Exception
        End Try

        Alert.Show() ' Show the alert and close out of the confirmation
        Me.Close()
    End Sub

    ' If the user wants to fix the entry, they are returned to the entry screen where all of their
    ' data looks the same as what they entered
    Private Sub FixButton_Click(sender As System.Object, e As System.EventArgs) Handles FixButton.Click
        Me.Close()
        Exercise1.Show()
    End Sub
End Class