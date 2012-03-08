'Erin Rasmussen
'ejrasmussen2@wisc.edu
'CS 371
'Lab1
Public Class Table

    ' This method closes the table window and returns to the data entry window
    Private Sub DoneButton_Click(sender As System.Object, e As System.EventArgs) Handles DoneButton.Click
        Me.Close()
        Exercise2.Show()
    End Sub
End Class