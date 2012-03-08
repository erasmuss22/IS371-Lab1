'Erin Rasmussen
'ejrasmussen2@wisc.edu
'CS 371
'Lab1

' This class displays an alert with the user's new id. After viewing, the user returns to the entry
' screen
Public Class Alert

    ' After viewing, the user returns to the entry screen
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Exercise1.Show()
    End Sub
End Class