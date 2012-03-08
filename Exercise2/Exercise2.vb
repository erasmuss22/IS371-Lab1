'Erin Rasmussen
'ejrasmussen2@wisc.edu
'CS 371
'Lab1

Public Class Exercise2
    Dim principal As Decimal
    Dim interest As Decimal
    Dim payments As Integer
    Dim allGood As Boolean = True
    Dim interestFactor As Decimal
    Dim periodicPayments As Decimal

    ' This method validates the user's data and shows their periodic payments given the data they entered.
    ' Warning labels appear for improper input
    Private Sub PaymentButton_Click(sender As System.Object, e As System.EventArgs) Handles PaymentButton.Click
        allGood = True ' If this remains true, then the calculation is performed

        ' If the user entered a proper number, then the number gets converted to a decimal and stored
        ' as the principal on the loan
        If PrincipalAlright(PrincipalTextBox.Text) Then
            Try
                principal = CDec(PrincipalTextBox.Text)
            Catch ex As Exception
            End Try
            PrincipalWarningLabel.Visible = False
        Else
            allGood = False
            PrincipalWarningLabel.Visible = True
            WarningLabel.Visible = True
        End If

        ' If the user entered a proper number, then the number gets converted to a decimal and stored
        ' as the interest rate for the loan. The number gets divided by 100 to use a a percent
        If InterestAlright(InterestRateTextBox.Text) Then
            Try
                interest = CDec(InterestRateTextBox.Text) / 100
            Catch ex As Exception
            End Try
            InterestWarningLabel.Visible = False
        Else
            allGood = False
            InterestWarningLabel.Visible = True
            WarningLabel.Visible = True
        End If

        ' If the user entered a proper number, then the number gets converted to an Integer and stored
        ' as the number of payments the user would like to make on their loan
        If PaymentsAlright(PaymentsTextBox.Text) Then
            Try
                payments = CInt(PaymentsTextBox.Text)
            Catch ex As Exception
            End Try
            PaymentWarningLabel.Visible = False
        Else
            allGood = False
            PaymentWarningLabel.Visible = True
            WarningLabel.Visible = True
        End If

        ' If there were no problems, then the equation for calculating periodic Payments is used
        ' to give the user that data
        If allGood Then
            PrincipalWarningLabel.Visible = False
            WarningLabel.Visible = False
            InterestWarningLabel.Visible = False
            PaymentWarningLabel.Visible = False
            Try
                interestFactor = (1 / interest) - (1 / (interest * (1 + interest) ^ payments))
                periodicPayments = principal / interestFactor
                ' The data is displayed as a currency
                InterestFactorLabel.Text = String.Format("{0:C}", interestFactor)
                PaymentLabel.Text = String.Format("{0:C}", periodicPayments)
            Catch ex As Exception
            End Try
        End If
    End Sub

    ' This method validates the user's entry for a principal. It checks for letters and negatives.
    Function PrincipalAlright(ByVal principal As String) As Boolean
        If principal.Length = 0 Then
            Return False
        ElseIf Not IsNumeric(principal) Then
            Return False
        ElseIf principal.Contains("-") Then
            Return False
        Else
            Return True
        End If
    End Function

    ' This method validates the user's entry for an interest rate. It checks for letters, negatives,
    ' and $ signs.
    Function InterestAlright(ByVal interest As String) As Boolean
        If interest.Length = 0 Then
            Return False
        ElseIf Not IsNumeric(interest) Then
            Return False
        ElseIf interest.Contains("-") Then
            Return False
        ElseIf interest.Contains("$") Then
            Return False
        ElseIf Val(interest) = 0 Then
            Return False
            ' Unless I'm not understanding something, I have seen Pay Day loans that charge
            ' an outrageous interest rate
        ElseIf Val(interest) > 500 Then
            Return False
        Else
            Return True
        End If
    End Function

    ' This method validates the user's entry for amount of payments. It checks for letters, periods, 
    ' $ signs and negatives.
    Function PaymentsAlright(ByVal payments As String) As Boolean
        If payments.Length = 0 Then
            Return False
        ElseIf Not IsNumeric(payments) Then
            Return False
        ElseIf payments.Contains(".") Then
            Return False
        ElseIf payments.Contains("$") Then
            Return False
        ElseIf payments.Contains("-") Then
            Return False
        ElseIf Val(payments) <= 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    ' This method clears all data and warning labels to start the process over
    Private Sub ResetButton_Click(sender As System.Object, e As System.EventArgs) Handles ResetButton.Click
        PrincipalWarningLabel.Visible = False
        WarningLabel.Visible = False
        InterestWarningLabel.Visible = False
        PaymentWarningLabel.Visible = False
        PrincipalTextBox.Text = String.Empty
        InterestRateTextBox.Text = String.Empty
        PaymentsTextBox.Text = String.Empty
        InterestFactorLabel.Text = String.Empty
        PaymentLabel.Text = String.Empty
    End Sub

    ' This method calculates the payment table for the user given their data entry. It uses the
    ' validation methods before using the algorithm given
    Private Sub TableButton_Click(sender As System.Object, e As System.EventArgs) Handles TableButton.Click
        allGood = True
        If PrincipalAlright(PrincipalTextBox.Text) Then
            Try
                principal = CDec(PrincipalTextBox.Text)
            Catch ex As Exception
            End Try
            PrincipalWarningLabel.Visible = False
        Else
            allGood = False
            PrincipalWarningLabel.Visible = True
            WarningLabel.Visible = True
        End If

        If InterestAlright(InterestRateTextBox.Text) Then
            Try
                interest = CDec(InterestRateTextBox.Text) / 100
            Catch ex As Exception
            End Try
            InterestWarningLabel.Visible = False
        Else
            allGood = False
            InterestWarningLabel.Visible = True
            WarningLabel.Visible = True
        End If

        If PaymentsAlright(PaymentsTextBox.Text) Then
            Try
                payments = CInt(PaymentsTextBox.Text)
            Catch ex As Exception
            End Try
            PaymentWarningLabel.Visible = False
        Else
            allGood = False
            PaymentWarningLabel.Visible = True
            WarningLabel.Visible = True
        End If

        ' If all the data looks good, the algorithm is used to make the table
        If allGood Then
            Dim interestAmount As Decimal
            Dim principalAmount As Decimal
            Dim outstandingPrincipal As Decimal = principal
            Try
                interestFactor = (1 / interest) - (1 / (interest * (1 + interest) ^ payments))
                periodicPayments = principal / interestFactor
                For paymentCounter As Integer = 1 To payments
                    interestAmount = outstandingPrincipal * interest
                    principalAmount = periodicPayments - interestAmount
                    outstandingPrincipal = outstandingPrincipal - principalAmount
                    ' For each payment loop, the data gets output using the printing method
                    ShowOutput(paymentCounter, periodicPayments, interestAmount, principalAmount, outstandingPrincipal)
                Next
            Catch ex As Exception
            End Try
        End If
        Table.Show()
    End Sub

    ' This method prints each payment's data followed by a new line
    Sub ShowOutput(ByVal paymentCounter As Integer, ByVal periodicPayments As Decimal, ByVal interestAmount As Decimal, ByVal principalAmount As Decimal, ByVal outstandingPrincipal As Decimal)
        Table.TableTextBox.AppendText(paymentCounter.ToString + "           " + String.Format("{0:C}", periodicPayments) + "        " + String.Format("{0:C}", interestAmount) + "        " + String.Format("{0:C}", principalAmount) + "       " + String.Format("{0:C}", outstandingPrincipal))
        Table.TableTextBox.AppendText(vbCrLf)
    End Sub
End Class
