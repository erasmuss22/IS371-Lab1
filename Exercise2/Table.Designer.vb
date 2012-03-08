<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Table
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
        Me.TableTextBox = New System.Windows.Forms.TextBox()
        Me.DoneButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TableTextBox
        '
        Me.TableTextBox.Location = New System.Drawing.Point(34, 56)
        Me.TableTextBox.Multiline = True
        Me.TableTextBox.Name = "TableTextBox"
        Me.TableTextBox.Size = New System.Drawing.Size(326, 410)
        Me.TableTextBox.TabIndex = 0
        '
        'DoneButton
        '
        Me.DoneButton.Location = New System.Drawing.Point(156, 472)
        Me.DoneButton.Name = "DoneButton"
        Me.DoneButton.Size = New System.Drawing.Size(75, 23)
        Me.DoneButton.TabIndex = 1
        Me.DoneButton.Text = "Done"
        Me.DoneButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(39, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 43)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Payment Number"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(100, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 46)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Periodic Payments"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(167, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 44)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Payment Interest"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(228, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 44)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Payment Principal"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(299, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 26)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Balance"
        '
        'Table
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 507)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DoneButton)
        Me.Controls.Add(Me.TableTextBox)
        Me.Name = "Table"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DoneButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
