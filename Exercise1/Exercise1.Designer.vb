<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exercise1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.StateComboBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CityComboBox = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ZipCodeTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.AreaCodeTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Phone1TextBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Phone2TextBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.MonthComboBox = New System.Windows.Forms.ComboBox()
        Me.DayComboBox = New System.Windows.Forms.ComboBox()
        Me.YearComboBox = New System.Windows.Forms.ComboBox()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.FirstNameWarningLabel = New System.Windows.Forms.Label()
        Me.DateWarningLabel = New System.Windows.Forms.Label()
        Me.PhoneWarningLabel = New System.Windows.Forms.Label()
        Me.EmailWarningLabel = New System.Windows.Forms.Label()
        Me.ZipCodeWarningLabel = New System.Windows.Forms.Label()
        Me.CityWarningLabel = New System.Windows.Forms.Label()
        Me.StateWarningLabel = New System.Windows.Forms.Label()
        Me.AddressWarningLabel = New System.Windows.Forms.Label()
        Me.LastNameWarningLabel = New System.Windows.Forms.Label()
        Me.WarningLabel = New System.Windows.Forms.Label()
        Me.NumberWarningLabel = New System.Windows.Forms.Label()
        Me.FormatWarningLabel = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name:"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(137, 38)
        Me.FirstNameTextBox.MaxLength = 20
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(161, 22)
        Me.FirstNameTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Last Name:"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(137, 75)
        Me.LastNameTextBox.MaxLength = 20
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(161, 22)
        Me.LastNameTextBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Address:"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(137, 113)
        Me.AddressTextBox.MaxLength = 40
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(161, 22)
        Me.AddressTextBox.TabIndex = 5
        '
        'StateComboBox
        '
        Me.StateComboBox.FormattingEnabled = True
        Me.StateComboBox.Items.AddRange(New Object() {"IA", "IL", "IN", "MI", "MN", "WI"})
        Me.StateComboBox.Location = New System.Drawing.Point(137, 152)
        Me.StateComboBox.Name = "StateComboBox"
        Me.StateComboBox.Size = New System.Drawing.Size(161, 24)
        Me.StateComboBox.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "State:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "City:"
        '
        'CityComboBox
        '
        Me.CityComboBox.Enabled = False
        Me.CityComboBox.FormattingEnabled = True
        Me.CityComboBox.Location = New System.Drawing.Point(137, 191)
        Me.CityComboBox.Name = "CityComboBox"
        Me.CityComboBox.Size = New System.Drawing.Size(161, 24)
        Me.CityComboBox.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Zip Code:"
        '
        'ZipCodeTextBox
        '
        Me.ZipCodeTextBox.Location = New System.Drawing.Point(137, 230)
        Me.ZipCodeTextBox.MaxLength = 5
        Me.ZipCodeTextBox.Name = "ZipCodeTextBox"
        Me.ZipCodeTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ZipCodeTextBox.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 275)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Email: "
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(137, 270)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(161, 22)
        Me.EmailTextBox.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 312)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Primary Phone:"
        '
        'AreaCodeTextBox
        '
        Me.AreaCodeTextBox.Location = New System.Drawing.Point(146, 311)
        Me.AreaCodeTextBox.MaxLength = 3
        Me.AreaCodeTextBox.Name = "AreaCodeTextBox"
        Me.AreaCodeTextBox.Size = New System.Drawing.Size(45, 22)
        Me.AreaCodeTextBox.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(137, 311)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 17)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "("
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(188, 311)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 17)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = ")"
        '
        'Phone1TextBox
        '
        Me.Phone1TextBox.Location = New System.Drawing.Point(208, 311)
        Me.Phone1TextBox.MaxLength = 3
        Me.Phone1TextBox.Name = "Phone1TextBox"
        Me.Phone1TextBox.Size = New System.Drawing.Size(49, 22)
        Me.Phone1TextBox.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(254, 315)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 17)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "-"
        '
        'Phone2TextBox
        '
        Me.Phone2TextBox.Location = New System.Drawing.Point(263, 312)
        Me.Phone2TextBox.MaxLength = 4
        Me.Phone2TextBox.Name = "Phone2TextBox"
        Me.Phone2TextBox.Size = New System.Drawing.Size(70, 22)
        Me.Phone2TextBox.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 351)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 17)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Date Of Birth:"
        '
        'MonthComboBox
        '
        Me.MonthComboBox.FormattingEnabled = True
        Me.MonthComboBox.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.MonthComboBox.Location = New System.Drawing.Point(140, 348)
        Me.MonthComboBox.Name = "MonthComboBox"
        Me.MonthComboBox.Size = New System.Drawing.Size(51, 24)
        Me.MonthComboBox.TabIndex = 22
        '
        'DayComboBox
        '
        Me.DayComboBox.Enabled = False
        Me.DayComboBox.FormattingEnabled = True
        Me.DayComboBox.Location = New System.Drawing.Point(208, 348)
        Me.DayComboBox.Name = "DayComboBox"
        Me.DayComboBox.Size = New System.Drawing.Size(49, 24)
        Me.DayComboBox.TabIndex = 23
        '
        'YearComboBox
        '
        Me.YearComboBox.FormattingEnabled = True
        Me.YearComboBox.Items.AddRange(New Object() {"2000", "1999", "1998", "1997", "1996", "1995", "1994", "1993", "1992", "1991", "1990", "1989", "1988", "1987", "1986", "1985", "1984", "1983", "1982", "1981", "1980", "1979", "1978", "1977", "1976", "1975", "1974", "1973", "1972", "1971", "1970", "1969", "1968", "1967", "1966", "1965", "1964", "1963", "1962", "1961", "1960", "1959", "1958", "1957", "1956", "1955", "1954", "1953", "1952", "1951", "1950", "1949", "1948", "1947", "1946", "1945", "1944", "1943", "1942", "1941", "1940", "1939", "1938", "1937", "1936", "1935", "1934", "1933", "1932", "1931", "1930", "1929", "1928", "1927", "1926", "1925", "1924", "1923", "1922", "1921", "1920", "1919", "1918", "1917", "1916", "1915", "1914", "1913", "1912", "1911", "1910"})
        Me.YearComboBox.Location = New System.Drawing.Point(264, 348)
        Me.YearComboBox.Name = "YearComboBox"
        Me.YearComboBox.Size = New System.Drawing.Size(69, 24)
        Me.YearComboBox.TabIndex = 24
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(15, 454)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(118, 47)
        Me.SubmitButton.TabIndex = 25
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(164, 454)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(114, 47)
        Me.ClearButton.TabIndex = 26
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'FirstNameWarningLabel
        '
        Me.FirstNameWarningLabel.AutoSize = True
        Me.FirstNameWarningLabel.ForeColor = System.Drawing.Color.Red
        Me.FirstNameWarningLabel.Location = New System.Drawing.Point(305, 38)
        Me.FirstNameWarningLabel.Name = "FirstNameWarningLabel"
        Me.FirstNameWarningLabel.Size = New System.Drawing.Size(13, 17)
        Me.FirstNameWarningLabel.TabIndex = 27
        Me.FirstNameWarningLabel.Text = "*"
        Me.FirstNameWarningLabel.Visible = False
        '
        'DateWarningLabel
        '
        Me.DateWarningLabel.AutoSize = True
        Me.DateWarningLabel.ForeColor = System.Drawing.Color.Red
        Me.DateWarningLabel.Location = New System.Drawing.Point(339, 355)
        Me.DateWarningLabel.Name = "DateWarningLabel"
        Me.DateWarningLabel.Size = New System.Drawing.Size(13, 17)
        Me.DateWarningLabel.TabIndex = 28
        Me.DateWarningLabel.Text = "*"
        Me.DateWarningLabel.Visible = False
        '
        'PhoneWarningLabel
        '
        Me.PhoneWarningLabel.AutoSize = True
        Me.PhoneWarningLabel.ForeColor = System.Drawing.Color.Red
        Me.PhoneWarningLabel.Location = New System.Drawing.Point(339, 315)
        Me.PhoneWarningLabel.Name = "PhoneWarningLabel"
        Me.PhoneWarningLabel.Size = New System.Drawing.Size(13, 17)
        Me.PhoneWarningLabel.TabIndex = 29
        Me.PhoneWarningLabel.Text = "*"
        Me.PhoneWarningLabel.Visible = False
        '
        'EmailWarningLabel
        '
        Me.EmailWarningLabel.AutoSize = True
        Me.EmailWarningLabel.ForeColor = System.Drawing.Color.Red
        Me.EmailWarningLabel.Location = New System.Drawing.Point(304, 273)
        Me.EmailWarningLabel.Name = "EmailWarningLabel"
        Me.EmailWarningLabel.Size = New System.Drawing.Size(13, 17)
        Me.EmailWarningLabel.TabIndex = 30
        Me.EmailWarningLabel.Text = "*"
        Me.EmailWarningLabel.Visible = False
        '
        'ZipCodeWarningLabel
        '
        Me.ZipCodeWarningLabel.AutoSize = True
        Me.ZipCodeWarningLabel.ForeColor = System.Drawing.Color.Red
        Me.ZipCodeWarningLabel.Location = New System.Drawing.Point(244, 233)
        Me.ZipCodeWarningLabel.Name = "ZipCodeWarningLabel"
        Me.ZipCodeWarningLabel.Size = New System.Drawing.Size(13, 17)
        Me.ZipCodeWarningLabel.TabIndex = 31
        Me.ZipCodeWarningLabel.Text = "*"
        Me.ZipCodeWarningLabel.Visible = False
        '
        'CityWarningLabel
        '
        Me.CityWarningLabel.AutoSize = True
        Me.CityWarningLabel.ForeColor = System.Drawing.Color.Red
        Me.CityWarningLabel.Location = New System.Drawing.Point(304, 194)
        Me.CityWarningLabel.Name = "CityWarningLabel"
        Me.CityWarningLabel.Size = New System.Drawing.Size(13, 17)
        Me.CityWarningLabel.TabIndex = 32
        Me.CityWarningLabel.Text = "*"
        Me.CityWarningLabel.Visible = False
        '
        'StateWarningLabel
        '
        Me.StateWarningLabel.AutoSize = True
        Me.StateWarningLabel.ForeColor = System.Drawing.Color.Red
        Me.StateWarningLabel.Location = New System.Drawing.Point(304, 159)
        Me.StateWarningLabel.Name = "StateWarningLabel"
        Me.StateWarningLabel.Size = New System.Drawing.Size(13, 17)
        Me.StateWarningLabel.TabIndex = 33
        Me.StateWarningLabel.Text = "*"
        Me.StateWarningLabel.Visible = False
        '
        'AddressWarningLabel
        '
        Me.AddressWarningLabel.AutoSize = True
        Me.AddressWarningLabel.ForeColor = System.Drawing.Color.Red
        Me.AddressWarningLabel.Location = New System.Drawing.Point(305, 113)
        Me.AddressWarningLabel.Name = "AddressWarningLabel"
        Me.AddressWarningLabel.Size = New System.Drawing.Size(13, 17)
        Me.AddressWarningLabel.TabIndex = 34
        Me.AddressWarningLabel.Text = "*"
        Me.AddressWarningLabel.Visible = False
        '
        'LastNameWarningLabel
        '
        Me.LastNameWarningLabel.AutoSize = True
        Me.LastNameWarningLabel.ForeColor = System.Drawing.Color.Red
        Me.LastNameWarningLabel.Location = New System.Drawing.Point(304, 75)
        Me.LastNameWarningLabel.Name = "LastNameWarningLabel"
        Me.LastNameWarningLabel.Size = New System.Drawing.Size(13, 17)
        Me.LastNameWarningLabel.TabIndex = 35
        Me.LastNameWarningLabel.Text = "*"
        Me.LastNameWarningLabel.Visible = False
        '
        'WarningLabel
        '
        Me.WarningLabel.AutoSize = True
        Me.WarningLabel.ForeColor = System.Drawing.Color.Red
        Me.WarningLabel.Location = New System.Drawing.Point(36, 389)
        Me.WarningLabel.Name = "WarningLabel"
        Me.WarningLabel.Size = New System.Drawing.Size(262, 17)
        Me.WarningLabel.TabIndex = 36
        Me.WarningLabel.Text = "* Please enter the required data above *"
        Me.WarningLabel.Visible = False
        '
        'NumberWarningLabel
        '
        Me.NumberWarningLabel.AutoSize = True
        Me.NumberWarningLabel.ForeColor = System.Drawing.Color.Red
        Me.NumberWarningLabel.Location = New System.Drawing.Point(0, 406)
        Me.NumberWarningLabel.Name = "NumberWarningLabel"
        Me.NumberWarningLabel.Size = New System.Drawing.Size(375, 17)
        Me.NumberWarningLabel.TabIndex = 37
        Me.NumberWarningLabel.Text = "Zip Codes and Phone Numbers can only contain numbers!"
        Me.NumberWarningLabel.Visible = False
        '
        'FormatWarningLabel
        '
        Me.FormatWarningLabel.AutoSize = True
        Me.FormatWarningLabel.ForeColor = System.Drawing.Color.Red
        Me.FormatWarningLabel.Location = New System.Drawing.Point(53, 423)
        Me.FormatWarningLabel.Name = "FormatWarningLabel"
        Me.FormatWarningLabel.Size = New System.Drawing.Size(204, 17)
        Me.FormatWarningLabel.TabIndex = 38
        Me.FormatWarningLabel.Text = "Format Email as: abc@xyz.com"
        Me.FormatWarningLabel.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(143, 375)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(30, 17)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "MM"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(209, 375)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 17)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "DD"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(273, 375)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 17)
        Me.Label15.TabIndex = 41
        Me.Label15.Text = "YYYY"
        '
        'Exercise1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 510)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.FormatWarningLabel)
        Me.Controls.Add(Me.NumberWarningLabel)
        Me.Controls.Add(Me.WarningLabel)
        Me.Controls.Add(Me.LastNameWarningLabel)
        Me.Controls.Add(Me.AddressWarningLabel)
        Me.Controls.Add(Me.StateWarningLabel)
        Me.Controls.Add(Me.CityWarningLabel)
        Me.Controls.Add(Me.ZipCodeWarningLabel)
        Me.Controls.Add(Me.EmailWarningLabel)
        Me.Controls.Add(Me.PhoneWarningLabel)
        Me.Controls.Add(Me.DateWarningLabel)
        Me.Controls.Add(Me.FirstNameWarningLabel)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.YearComboBox)
        Me.Controls.Add(Me.DayComboBox)
        Me.Controls.Add(Me.MonthComboBox)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Phone2TextBox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Phone1TextBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.AreaCodeTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ZipCodeTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CityComboBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.StateComboBox)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Exercise1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StateComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CityComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ZipCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents AreaCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Phone1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Phone2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents MonthComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DayComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents YearComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SubmitButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents FirstNameWarningLabel As System.Windows.Forms.Label
    Friend WithEvents DateWarningLabel As System.Windows.Forms.Label
    Friend WithEvents PhoneWarningLabel As System.Windows.Forms.Label
    Friend WithEvents EmailWarningLabel As System.Windows.Forms.Label
    Friend WithEvents ZipCodeWarningLabel As System.Windows.Forms.Label
    Friend WithEvents CityWarningLabel As System.Windows.Forms.Label
    Friend WithEvents StateWarningLabel As System.Windows.Forms.Label
    Friend WithEvents AddressWarningLabel As System.Windows.Forms.Label
    Friend WithEvents LastNameWarningLabel As System.Windows.Forms.Label
    Friend WithEvents WarningLabel As System.Windows.Forms.Label
    Friend WithEvents NumberWarningLabel As System.Windows.Forms.Label
    Friend WithEvents FormatWarningLabel As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label

End Class
