<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exercise3
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
        Me.NumberTextBox = New System.Windows.Forms.TextBox()
        Me.EnterButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.ResultTextBox = New System.Windows.Forms.TextBox()
        Me.CultureTextBox = New System.Windows.Forms.TextBox()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.OutTextBox = New System.Windows.Forms.RichTextBox()
        Me.WarningLabel = New System.Windows.Forms.Label()
        Me.InputWarningLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(146, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number of Managers:"
        '
        'NumberTextBox
        '
        Me.NumberTextBox.Location = New System.Drawing.Point(307, 24)
        Me.NumberTextBox.MaxLength = 3
        Me.NumberTextBox.Name = "NumberTextBox"
        Me.NumberTextBox.Size = New System.Drawing.Size(65, 22)
        Me.NumberTextBox.TabIndex = 1
        '
        'EnterButton
        '
        Me.EnterButton.Location = New System.Drawing.Point(434, 19)
        Me.EnterButton.Name = "EnterButton"
        Me.EnterButton.Size = New System.Drawing.Size(89, 33)
        Me.EnterButton.TabIndex = 2
        Me.EnterButton.Text = "Enter"
        Me.EnterButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(146, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Manager's Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(146, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Results Score (1-10):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(146, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Cultrue Score (1-10):"
        '
        'NameTextBox
        '
        Me.NameTextBox.Enabled = False
        Me.NameTextBox.Location = New System.Drawing.Point(307, 75)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(150, 22)
        Me.NameTextBox.TabIndex = 6
        '
        'ResultTextBox
        '
        Me.ResultTextBox.Enabled = False
        Me.ResultTextBox.Location = New System.Drawing.Point(307, 111)
        Me.ResultTextBox.MaxLength = 2
        Me.ResultTextBox.Name = "ResultTextBox"
        Me.ResultTextBox.Size = New System.Drawing.Size(52, 22)
        Me.ResultTextBox.TabIndex = 7
        '
        'CultureTextBox
        '
        Me.CultureTextBox.Enabled = False
        Me.CultureTextBox.Location = New System.Drawing.Point(307, 149)
        Me.CultureTextBox.MaxLength = 2
        Me.CultureTextBox.Name = "CultureTextBox"
        Me.CultureTextBox.Size = New System.Drawing.Size(51, 22)
        Me.CultureTextBox.TabIndex = 8
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(108, 181)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(78, 29)
        Me.SubmitButton.TabIndex = 9
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(242, 180)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(88, 28)
        Me.ClearButton.TabIndex = 10
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(394, 180)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(88, 26)
        Me.ResetButton.TabIndex = 11
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'OutTextBox
        '
        Me.OutTextBox.Enabled = False
        Me.OutTextBox.Location = New System.Drawing.Point(17, 216)
        Me.OutTextBox.Name = "OutTextBox"
        Me.OutTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.OutTextBox.Size = New System.Drawing.Size(548, 267)
        Me.OutTextBox.TabIndex = 12
        Me.OutTextBox.Text = ""
        '
        'WarningLabel
        '
        Me.WarningLabel.AutoSize = True
        Me.WarningLabel.ForeColor = System.Drawing.Color.Red
        Me.WarningLabel.Location = New System.Drawing.Point(194, 49)
        Me.WarningLabel.Name = "WarningLabel"
        Me.WarningLabel.Size = New System.Drawing.Size(109, 17)
        Me.WarningLabel.TabIndex = 13
        Me.WarningLabel.Text = "Enter a number!"
        Me.WarningLabel.Visible = False
        '
        'InputWarningLabel
        '
        Me.InputWarningLabel.AutoSize = True
        Me.InputWarningLabel.ForeColor = System.Drawing.Color.Red
        Me.InputWarningLabel.Location = New System.Drawing.Point(476, 131)
        Me.InputWarningLabel.Name = "InputWarningLabel"
        Me.InputWarningLabel.Size = New System.Drawing.Size(60, 17)
        Me.InputWarningLabel.TabIndex = 14
        Me.InputWarningLabel.Text = "Fix Input"
        Me.InputWarningLabel.Visible = False
        '
        'Exercise3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 495)
        Me.Controls.Add(Me.InputWarningLabel)
        Me.Controls.Add(Me.WarningLabel)
        Me.Controls.Add(Me.OutTextBox)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.CultureTextBox)
        Me.Controls.Add(Me.ResultTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.EnterButton)
        Me.Controls.Add(Me.NumberTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Exercise3"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EnterButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ResultTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CultureTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SubmitButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents ResetButton As System.Windows.Forms.Button
    Friend WithEvents OutTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents WarningLabel As System.Windows.Forms.Label
    Friend WithEvents InputWarningLabel As System.Windows.Forms.Label

End Class
