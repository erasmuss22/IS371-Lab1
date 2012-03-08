<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exercise2
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PrincipalTextBox = New System.Windows.Forms.TextBox()
        Me.InterestRateTextBox = New System.Windows.Forms.TextBox()
        Me.PaymentsTextBox = New System.Windows.Forms.TextBox()
        Me.PaymentButton = New System.Windows.Forms.Button()
        Me.TableButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PaymentLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.WarningLabel = New System.Windows.Forms.Label()
        Me.PrincipalWarningLabel = New System.Windows.Forms.Label()
        Me.PaymentWarningLabel = New System.Windows.Forms.Label()
        Me.InterestWarningLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.InterestFactorLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Initial Principal Amount: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Rate of Interest:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Number of Payments:"
        '
        'PrincipalTextBox
        '
        Me.PrincipalTextBox.Location = New System.Drawing.Point(190, 27)
        Me.PrincipalTextBox.Name = "PrincipalTextBox"
        Me.PrincipalTextBox.Size = New System.Drawing.Size(170, 22)
        Me.PrincipalTextBox.TabIndex = 3
        '
        'InterestRateTextBox
        '
        Me.InterestRateTextBox.Location = New System.Drawing.Point(190, 62)
        Me.InterestRateTextBox.Name = "InterestRateTextBox"
        Me.InterestRateTextBox.Size = New System.Drawing.Size(170, 22)
        Me.InterestRateTextBox.TabIndex = 4
        '
        'PaymentsTextBox
        '
        Me.PaymentsTextBox.Location = New System.Drawing.Point(190, 97)
        Me.PaymentsTextBox.MaxLength = 5
        Me.PaymentsTextBox.Name = "PaymentsTextBox"
        Me.PaymentsTextBox.Size = New System.Drawing.Size(62, 22)
        Me.PaymentsTextBox.TabIndex = 5
        '
        'PaymentButton
        '
        Me.PaymentButton.Location = New System.Drawing.Point(15, 233)
        Me.PaymentButton.Name = "PaymentButton"
        Me.PaymentButton.Size = New System.Drawing.Size(111, 68)
        Me.PaymentButton.TabIndex = 6
        Me.PaymentButton.Text = "Calculate Periodic Payment"
        Me.PaymentButton.UseVisualStyleBackColor = True
        '
        'TableButton
        '
        Me.TableButton.Location = New System.Drawing.Point(148, 233)
        Me.TableButton.Name = "TableButton"
        Me.TableButton.Size = New System.Drawing.Size(113, 66)
        Me.TableButton.TabIndex = 7
        Me.TableButton.Text = "Create Payment Table"
        Me.TableButton.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(283, 232)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(107, 67)
        Me.ResetButton.TabIndex = 8
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Periodic Payment:"
        '
        'PaymentLabel
        '
        Me.PaymentLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PaymentLabel.Location = New System.Drawing.Point(225, 163)
        Me.PaymentLabel.Name = "PaymentLabel"
        Me.PaymentLabel.Size = New System.Drawing.Size(165, 19)
        Me.PaymentLabel.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(366, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "%"
        '
        'WarningLabel
        '
        Me.WarningLabel.AutoSize = True
        Me.WarningLabel.ForeColor = System.Drawing.Color.Red
        Me.WarningLabel.Location = New System.Drawing.Point(99, 198)
        Me.WarningLabel.Name = "WarningLabel"
        Me.WarningLabel.Size = New System.Drawing.Size(205, 17)
        Me.WarningLabel.TabIndex = 12
        Me.WarningLabel.Text = "Illegal data entry! Check Above!"
        Me.WarningLabel.Visible = False
        '
        'PrincipalWarningLabel
        '
        Me.PrincipalWarningLabel.AutoSize = True
        Me.PrincipalWarningLabel.ForeColor = System.Drawing.Color.Red
        Me.PrincipalWarningLabel.Location = New System.Drawing.Point(377, 31)
        Me.PrincipalWarningLabel.Name = "PrincipalWarningLabel"
        Me.PrincipalWarningLabel.Size = New System.Drawing.Size(13, 17)
        Me.PrincipalWarningLabel.TabIndex = 13
        Me.PrincipalWarningLabel.Text = "*"
        Me.PrincipalWarningLabel.Visible = False
        '
        'PaymentWarningLabel
        '
        Me.PaymentWarningLabel.AutoSize = True
        Me.PaymentWarningLabel.ForeColor = System.Drawing.Color.Red
        Me.PaymentWarningLabel.Location = New System.Drawing.Point(258, 100)
        Me.PaymentWarningLabel.Name = "PaymentWarningLabel"
        Me.PaymentWarningLabel.Size = New System.Drawing.Size(13, 17)
        Me.PaymentWarningLabel.TabIndex = 14
        Me.PaymentWarningLabel.Text = "*"
        Me.PaymentWarningLabel.Visible = False
        '
        'InterestWarningLabel
        '
        Me.InterestWarningLabel.AutoSize = True
        Me.InterestWarningLabel.ForeColor = System.Drawing.Color.Red
        Me.InterestWarningLabel.Location = New System.Drawing.Point(392, 65)
        Me.InterestWarningLabel.Name = "InterestWarningLabel"
        Me.InterestWarningLabel.Size = New System.Drawing.Size(13, 17)
        Me.InterestWarningLabel.TabIndex = 15
        Me.InterestWarningLabel.Text = "*"
        Me.InterestWarningLabel.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(208, 17)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Present Value of Interest Factor"
        '
        'InterestFactorLabel
        '
        Me.InterestFactorLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.InterestFactorLabel.Location = New System.Drawing.Point(225, 134)
        Me.InterestFactorLabel.Name = "InterestFactorLabel"
        Me.InterestFactorLabel.Size = New System.Drawing.Size(164, 16)
        Me.InterestFactorLabel.TabIndex = 17
        '
        'Exercise2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 325)
        Me.Controls.Add(Me.InterestFactorLabel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.InterestWarningLabel)
        Me.Controls.Add(Me.PaymentWarningLabel)
        Me.Controls.Add(Me.PrincipalWarningLabel)
        Me.Controls.Add(Me.WarningLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PaymentLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.TableButton)
        Me.Controls.Add(Me.PaymentButton)
        Me.Controls.Add(Me.PaymentsTextBox)
        Me.Controls.Add(Me.InterestRateTextBox)
        Me.Controls.Add(Me.PrincipalTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Exercise2"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PrincipalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InterestRateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PaymentsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PaymentButton As System.Windows.Forms.Button
    Friend WithEvents TableButton As System.Windows.Forms.Button
    Friend WithEvents ResetButton As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PaymentLabel As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents WarningLabel As System.Windows.Forms.Label
    Friend WithEvents PrincipalWarningLabel As System.Windows.Forms.Label
    Friend WithEvents PaymentWarningLabel As System.Windows.Forms.Label
    Friend WithEvents InterestWarningLabel As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents InterestFactorLabel As System.Windows.Forms.Label

End Class
