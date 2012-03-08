'Erin Rasmussen
'ejrasmussen2@wisc.edu
'CS 371
'Lab1


Public Class Exercise1
    Dim Iowa() As String = {"", "Des Moines", "Dubuque", "Iowa City"}
    Dim Indiana() As String = {"", "Bloomington", "Gary", "Indianapolis"}
    Dim Illinois() As String = {"", "Champagne", "Chicago", "Springfield"}
    Dim Michigan() As String = {"", "Ann Arbor", "Detroit", "East Lansing", "Kalamazoo"}
    Dim Minnesota() As String = {"", "Duluth", "Minneapolis", "Saint Paul", "Winona"}
    Dim Wisconsin() As String = {"", "Appleton", "Green Bay", "Madison", "Milwaukee", "Minocqua", "Stevens Point", "Wausau"}
    ' The above hold the options a user can select given a state
    Dim LongerMonth() As String = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"}
    Dim ShorterMonth() As String = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"}
    Dim February() As String = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28"}
    ' The above hold the options a user can select for their date of birth depending on which month
    Dim firstName, lastName, address, state, city, zipCode, email, areaCode, firstPhone As String
    Dim lastPhone, month, day, year, id As String
    Dim warnings As Boolean = False


    ' This method changes the options in the city combo box when a user selects a state from the state combo box
    Private Sub StateComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles StateComboBox.SelectedIndexChanged
        CityComboBox.Enabled = True
        Select Case StateComboBox.SelectedItem
            Case "IA"
                CityComboBox.DataSource = Iowa
            Case "IN"
                CityComboBox.DataSource = Indiana
            Case "IL"
                CityComboBox.DataSource = Illinois
            Case "MI"
                CityComboBox.DataSource = Michigan
            Case "MN"
                CityComboBox.DataSource = Minnesota
            Case "WI"
                CityComboBox.DataSource = Wisconsin
        End Select
    End Sub


    ' This method controls the workings of the submit button. If everything is valid, a new window opens to let
    ' the user double-check their entry. If something is wrong such as an empty box or a letter where an Integer
    ' was expected, then a warning asterisk appears next to that input area.
    Private Sub SubmitButton_Click(sender As System.Object, e As System.EventArgs) Handles SubmitButton.Click
        warnings = False  ' If there are warnings, the user will be prompted to fix them

        ' If the user entered nothing or a number for their first name they will receive a warning label
        If FirstNameTextBox.Text.Length = 0 Or Val(FirstNameTextBox.Text) > 0 Then
            FirstNameWarningLabel.Visible = True
            WarningLabel.Visible = True
            warnings = True
        Else
            FirstNameWarningLabel.Visible = False
        End If

        ' If the user entered nothing or a number for last first name they will receive a warning label
        If LastNameTextBox.Text.Length = 0 Or Val(LastNameTextBox.Text) > 0 Then
            LastNameWarningLabel.Visible = True
            WarningLabel.Visible = True
            warnings = True
        Else
            LastNameWarningLabel.Visible = False
        End If

        ' If the user entered nothing for their address then they receive a warning label
        If AddressTextBox.Text.Length = 0 Then
            AddressWarningLabel.Visible = True
            WarningLabel.Visible = True
            warnings = True
        Else
            AddressWarningLabel.Visible = False
        End If

        ' If the user didn't select a state, they will receive a warning label
        If StateComboBox.SelectedItem = "" Then
            StateWarningLabel.Visible = True
            WarningLabel.Visible = True
            warnings = True
        Else
            StateWarningLabel.Visible = False
        End If


        ' If the user didn't select a city, they will receive a warning label
        If CityComboBox.SelectedItem = "" Then
            CityWarningLabel.Visible = True
            WarningLabel.Visible = True
            warnings = True
        Else
            CityWarningLabel.Visible = False
        End If

        ' If the user didn't follow the proper format for a zip code they will receive a warning
        ' label. Try-Catch is used because of the IsNumeric method and conversions to integer
        Try
            If ZipCodeTextBox.Text.Length < 5 Then
                ZipCodeWarningLabel.Visible = True
                WarningLabel.Visible = True
                warnings = True
            ElseIf Not IsNumeric(ZipCodeTextBox.Text) Then
                ZipCodeWarningLabel.Visible = True
                WarningLabel.Visible = True
                NumberWarningLabel.Visible = True
                warnings = True
            ElseIf ZipCodeTextBox.Text.Contains(".") Then
                ZipCodeWarningLabel.Visible = True
                WarningLabel.Visible = True
                NumberWarningLabel.Visible = True
                warnings = True
            ElseIf ZipCodeTextBox.Text.Contains("$") Then
                ZipCodeWarningLabel.Visible = True
                WarningLabel.Visible = True
                NumberWarningLabel.Visible = True
                warnings = True
            ElseIf ZipCodeTextBox.Text.Contains("-") Then
                ZipCodeWarningLabel.Visible = True
                WarningLabel.Visible = True
                NumberWarningLabel.Visible = True
                warnings = True
            Else
                ZipCodeWarningLabel.Visible = False
            End If
        Catch ex As Exception
        End Try

        ' If the user didn't follow the correct email format, they receive a warning label. A Try-Catch
        ' is used here to avoid null pointers.
        Try
            If EmailTextBox.Text.Length = 0 Then
                EmailWarningLabel.Visible = True
                WarningLabel.Visible = True
                warnings = True
            Else
                email = EmailTextBox.Text
                If Not email.IndexOf("@") > 0 Or Not email.IndexOf("@") < email.IndexOf(".") Or email.IndexOf(".") = email.Length - 1 Or (email.IndexOf(".") - email.IndexOf("@")) = 1 Then
                    EmailWarningLabel.Visible = True
                    WarningLabel.Visible = True
                    FormatWarningLabel.Visible = True
                    warnings = True
                Else
                    EmailWarningLabel.Visible = False
                End If
            End If
        Catch ex As Exception
        End Try

        ' This code checks for a correctly entered phone number and will give an error message for an
        ' improper entry
        Try
            If AreaCodeTextBox.Text.Length < 3 Or Phone1TextBox.Text.Length < 3 Or Phone2TextBox.Text.Length < 4 Then
                PhoneWarningLabel.Visible = True
                WarningLabel.Visible = True
                warnings = True
            ElseIf Not IsNumeric(AreaCodeTextBox.Text) Or Not IsNumeric(Phone1TextBox.Text) Or Not IsNumeric(Phone2TextBox.Text) Then
                PhoneWarningLabel.Visible = True
                WarningLabel.Visible = True
                NumberWarningLabel.Visible = True
                warnings = True
            ElseIf AreaCodeTextBox.Text.Contains(".") Or Phone1TextBox.Text.Contains(".") Or Phone2TextBox.Text.Contains(".") Then
                PhoneWarningLabel.Visible = True
                WarningLabel.Visible = True
                NumberWarningLabel.Visible = True
                warnings = True
            ElseIf AreaCodeTextBox.Text.Contains("$") Or Phone1TextBox.Text.Contains("$") Or Phone2TextBox.Text.Contains("$") Then
                PhoneWarningLabel.Visible = True
                WarningLabel.Visible = True
                NumberWarningLabel.Visible = True
                warnings = True
            ElseIf AreaCodeTextBox.Text.Contains("-") Or Phone1TextBox.Text.Contains("-") Or Phone2TextBox.Text.Contains("-") Then
                PhoneWarningLabel.Visible = True
                WarningLabel.Visible = True
                NumberWarningLabel.Visible = True
                warnings = True
            Else
                PhoneWarningLabel.Visible = False
            End If
        Catch ex As Exception
        End Try

        ' this code makes sure the user selected a month, day, and year. Otherwise it gives and error message
        If MonthComboBox.SelectedItem = "" Or DayComboBox.SelectedItem = "" Or YearComboBox.SelectedItem = "" Then
            DateWarningLabel.Visible = True
            WarningLabel.Visible = True
            warnings = True
        Else
            DateWarningLabel.Visible = False
        End If

        ' This code gives a formatting warning if a phone number or zip code isn't entered correctly
        Try
            If Not IsNumeric(ZipCodeTextBox.Text) Or Not IsNumeric(AreaCodeTextBox.Text) Or Not IsNumeric(Phone1TextBox.Text) Or Not IsNumeric(Phone2TextBox.Text) Then
                NumberWarningLabel.Visible = True
            ElseIf ZipCodeTextBox.Text.Contains(".") Or AreaCodeTextBox.Text.Contains(".") Or Phone1TextBox.Text.Contains(".") Or Phone2TextBox.Text.Contains(".") Then
                NumberWarningLabel.Visible = True
            ElseIf ZipCodeTextBox.Text.Contains("$") Or AreaCodeTextBox.Text.Contains("$") Or Phone1TextBox.Text.Contains("$") Or Phone2TextBox.Text.Contains("$") Then
                NumberWarningLabel.Visible = True
            ElseIf ZipCodeTextBox.Text.Contains("-") Or AreaCodeTextBox.Text.Contains("-") Or Phone1TextBox.Text.Contains("-") Or Phone2TextBox.Text.Contains("-") Then
                NumberWarningLabel.Visible = True
            Else
                NumberWarningLabel.Visible = False
            End If
        Catch ex As Exception
        End Try

        ' All of the entries are collected as variables
        firstName = FirstNameTextBox.Text
        lastName = LastNameTextBox.Text
        address = AddressTextBox.Text
        state = StateComboBox.SelectedItem
        city = CityComboBox.SelectedItem
        zipCode = ZipCodeTextBox.Text
        email = EmailTextBox.Text
        areaCode = AreaCodeTextBox.Text
        firstPhone = Phone1TextBox.Text
        lastPhone = Phone2TextBox.Text
        month = MonthComboBox.SelectedItem
        day = DayComboBox.SelectedItem
        year = YearComboBox.SelectedItem

        ' If there wasn't a problem, then the data gets output to the confirmation form
        Try
            If Not warnings Then
                WarningLabel.Visible = False
                Confirmation.FirstNameLabel.Text = firstName
                Confirmation.LastNameLabel.Text = lastName
                Confirmation.AddressLabel.Text = address
                Confirmation.StateLabel.Text = state
                Confirmation.CityLabel.Text = city
                Confirmation.ZipCodeLabel.Text = zipCode
                Confirmation.EmailLabel.Text = email
                Confirmation.PhoneLabel.Text = "(" + areaCode + ")" + firstPhone + "-" + lastPhone
                Confirmation.DateOfBirthLabel.Text = month + "/" + day + "/" + year
                Confirmation.Show() ' shows the confirmation window and hides the entry form
                Me.Hide()
            End If
        Catch ex As Exception
        End Try

    End Sub

    ' This method changes the days available to a user given the month they select. Longer months have
    ' 31 days, February 28, etc.
    Private Sub MonthComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles MonthComboBox.SelectedIndexChanged
        Dim MonthSelected As String = MonthComboBox.SelectedItem.ToString()
        Select Case MonthSelected
            Case "01", "03", "05", "07", "08", "10", "12"
                DayComboBox.DataSource = LongerMonth
                DayComboBox.Enabled = True
            Case "02"
                DayComboBox.DataSource = February
                DayComboBox.Enabled = True
            Case Else
                DayComboBox.DataSource = ShorterMonth
                DayComboBox.Enabled = True
        End Select
    End Sub

    ' This method clears everything including data and warning labels from the screen
    Private Sub ClearButton_Click(sender As System.Object, e As System.EventArgs) Handles ClearButton.Click
        warnings = False
        FirstNameTextBox.Text = String.Empty
        FirstNameWarningLabel.Visible = False
        LastNameTextBox.Text = String.Empty
        LastNameWarningLabel.Visible = False
        AddressTextBox.Text = String.Empty
        AddressWarningLabel.Visible = False
        StateComboBox.ResetText()
        StateWarningLabel.Visible = False
        CityComboBox.ResetText()
        CityWarningLabel.Visible = False
        CityComboBox.Enabled = False
        ZipCodeTextBox.Text = String.Empty
        ZipCodeWarningLabel.Visible = False
        EmailTextBox.Text = String.Empty
        EmailWarningLabel.Visible = False
        AreaCodeTextBox.Text = String.Empty
        Phone1TextBox.Text = String.Empty
        Phone2TextBox.Text = String.Empty
        PhoneWarningLabel.Visible = False
        MonthComboBox.ResetText()
        DayComboBox.ResetText()
        DayComboBox.Enabled = False
        YearComboBox.ResetText()
        DateWarningLabel.Visible = False
        FormatWarningLabel.Visible = False
        NumberWarningLabel.Visible = False
        WarningLabel.Visible = False
    End Sub
End Class
