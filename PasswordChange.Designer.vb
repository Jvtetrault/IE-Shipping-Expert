<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasswordChange
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
        Me.CurrentPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NewPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComfirmPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.AcceptButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CurrentPasswordTextBox
        '
        Me.CurrentPasswordTextBox.Location = New System.Drawing.Point(138, 12)
        Me.CurrentPasswordTextBox.Name = "CurrentPasswordTextBox"
        Me.CurrentPasswordTextBox.Size = New System.Drawing.Size(198, 22)
        Me.CurrentPasswordTextBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Current Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "New Password"
        '
        'NewPasswordTextBox
        '
        Me.NewPasswordTextBox.Location = New System.Drawing.Point(138, 40)
        Me.NewPasswordTextBox.Name = "NewPasswordTextBox"
        Me.NewPasswordTextBox.Size = New System.Drawing.Size(198, 22)
        Me.NewPasswordTextBox.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Comfirm Password"
        '
        'ComfirmPasswordTextBox
        '
        Me.ComfirmPasswordTextBox.Location = New System.Drawing.Point(138, 68)
        Me.ComfirmPasswordTextBox.Name = "ComfirmPasswordTextBox"
        Me.ComfirmPasswordTextBox.Size = New System.Drawing.Size(198, 22)
        Me.ComfirmPasswordTextBox.TabIndex = 4
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(15, 109)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 6
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'AcceptButton
        '
        Me.AcceptButton.Location = New System.Drawing.Point(261, 109)
        Me.AcceptButton.Name = "AcceptButton"
        Me.AcceptButton.Size = New System.Drawing.Size(75, 23)
        Me.AcceptButton.TabIndex = 7
        Me.AcceptButton.Text = "Accept"
        Me.AcceptButton.UseVisualStyleBackColor = True
        '
        'PasswordChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 144)
        Me.Controls.Add(Me.AcceptButton)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComfirmPasswordTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NewPasswordTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CurrentPasswordTextBox)
        Me.Name = "PasswordChange"
        Me.Text = "PasswordChange"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CurrentPasswordTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NewPasswordTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComfirmPasswordTextBox As TextBox
#Disable Warning BC40004 ' Member conflicts with member in the base type and should be declared 'Shadows'
    Friend WithEvents CancelButton As Button
#Enable Warning BC40004 ' Member conflicts with member in the base type and should be declared 'Shadows'
#Disable Warning BC40004 ' Member conflicts with member in the base type and should be declared 'Shadows'
    Friend WithEvents AcceptButton As Button
#Enable Warning BC40004 ' Member conflicts with member in the base type and should be declared 'Shadows'
End Class
