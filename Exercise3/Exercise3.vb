﻿'Erin Rasmussen
'ejrasmussen2@wisc.edu
'CS 371
'Lab1
Public Class Exercise3
    Dim managerNumber As Integer
    Dim managerCount As Integer
    Dim Managers As New List(Of Manager)
    Private temp As Manager
    Dim errorIndicator As Boolean = True

    ' This method checks that a user entered a valid number for the amount of managers they would
    ' like to rate. If it is valid, the name and score text boxes open up to entry
    Private Sub EnterButton_Click(sender As System.Object, e As System.EventArgs) Handles EnterButton.Click
        If IsNumeric(NumberTextBox.Text) And Val(NumberTextBox.Text) > 0 Then
            Try
                managerNumber = Convert.ToInt16(NumberTextBox.Text)
                ' If a number can't be converted to an integer, the next lines of code
                ' are skipped
                NumberTextBox.Enabled = False
                EnterButton.Visible = False
                NameTextBox.Enabled = True
                ResultTextBox.Enabled = True
                CultureTextBox.Enabled = True
                WarningLabel.Visible = False
                managerCount = managerNumber

                ' If there is only 1 manager entered, the submit button reads "Evaluate"
                If managerNumber = 1 Then
                    SubmitButton.Text = "Evaluate"
                End If
            Catch ex As Exception
                WarningLabel.Visible = True
            End Try
        Else
            WarningLabel.Visible = True
        End If
    End Sub


    ' This method handles the continuous manager entry by validating input and then storing the
    ' manager in a list of managers
    Private Sub SubmitButton_Click(sender As System.Object, e As System.EventArgs) Handles SubmitButton.Click
        errorIndicator = True
        ' This code is used to change the text on the button to read "Evaluate" if the manager can
        ' be added to the list
        If managerCount = 2 Then
            While errorIndicator
                Try
                    temp = New Manager(NameTextBox.Text, CultureTextBox.Text, ResultTextBox.Text)
                    ' If the manager throws an exception, the following code won't be executed
                    Managers.Add(temp)
                    InputWarningLabel.Visible = False
                    SubmitButton.Text = "Evaluate"
                    managerCount -= 1
                    NameTextBox.Clear()
                    ResultTextBox.Clear()
                    CultureTextBox.Clear()
                    errorIndicator = False
                Catch ArgumentOutOfRangeException As Exception
                    InputWarningLabel.Visible = True
                    Exit While
                End Try
            End While

            ' This section of the if statement handles the situation when the user is entering
            ' their last manager. Upon validation, the outcomes of the managers gets displayed
        ElseIf SubmitButton.Text = "Evaluate" Then
            While errorIndicator
                Try
                    temp = New Manager(NameTextBox.Text, CultureTextBox.Text, ResultTextBox.Text)
                    Managers.Add(temp)
                    InputWarningLabel.Visible = False
                    managerCount -= 1
                    OutTextBox.Enabled = True
                    NameTextBox.Clear()
                    ResultTextBox.Clear()
                    CultureTextBox.Clear()
                    errorIndicator = False
                    printOutput(Managers)
                Catch ArgumentOutOfRangeException As Exception
                    InputWarningLabel.Visible = True
                    Exit While
                End Try
            End While

            ' This is not a special case and the manager gets added to the list upon validation
        Else
            While errorIndicator
                Try
                    temp = New Manager(NameTextBox.Text, CultureTextBox.Text, ResultTextBox.Text)
                    Managers.Add(temp)
                    InputWarningLabel.Visible = False
                    managerCount -= 1
                    NameTextBox.Clear()
                    ResultTextBox.Clear()
                    CultureTextBox.Clear()
                    errorIndicator = False
                Catch ArgumentOutOfRangeException As Exception
                    InputWarningLabel.Visible = True
                    Exit While
                End Try
            End While
        End If
    End Sub

    ' This method prints out each manager to an output box with a new line after each manager
    Sub printOutput(ByRef managersList As List(Of Manager))
        For Each person In managersList
            OutTextBox.AppendText("Name: " + person.ManagerName + "  Total Score: " + person.ManagerScore.ToString + "  Outcome: " + person.ManagerOutcome)
            OutTextBox.AppendText(vbCrLf)
        Next
    End Sub

    ' This method clears all the data from the boxes, but does not delete managers
    Private Sub ClearButton_Click(sender As System.Object, e As System.EventArgs) Handles ClearButton.Click
        NameTextBox.Clear()
        ResultTextBox.Clear()
        CultureTextBox.Clear()
    End Sub

    ' This method restarts the entire program including the deletion of any managers entered
    Private Sub ResetButton_Click(sender As System.Object, e As System.EventArgs) Handles ResetButton.Click
        Application.Restart()
    End Sub
End Class
