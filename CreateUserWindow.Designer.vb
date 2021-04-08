<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateUserWindow
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
        Me.GenPassCheckBox = New System.Windows.Forms.CheckBox()
        Me.UserNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.CreateButton = New System.Windows.Forms.Button()
        Me.PermissionsComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "New User Name"
        '
        'GenPassCheckBox
        '
        Me.GenPassCheckBox.AutoSize = True
        Me.GenPassCheckBox.Location = New System.Drawing.Point(12, 69)
        Me.GenPassCheckBox.Name = "GenPassCheckBox"
        Me.GenPassCheckBox.Size = New System.Drawing.Size(197, 21)
        Me.GenPassCheckBox.TabIndex = 1
        Me.GenPassCheckBox.Text = "User Generated Password"
        Me.GenPassCheckBox.UseVisualStyleBackColor = True
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.Location = New System.Drawing.Point(162, 9)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.Size = New System.Drawing.Size(127, 22)
        Me.UserNameTextBox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(162, 41)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(127, 22)
        Me.PasswordTextBox.TabIndex = 4
        '
        'CreateButton
        '
        Me.CreateButton.Location = New System.Drawing.Point(112, 147)
        Me.CreateButton.Name = "CreateButton"
        Me.CreateButton.Size = New System.Drawing.Size(75, 23)
        Me.CreateButton.TabIndex = 5
        Me.CreateButton.Text = "Create"
        Me.CreateButton.UseVisualStyleBackColor = True
        '
        'PermissionsComboBox
        '
        Me.PermissionsComboBox.FormattingEnabled = True
        Me.PermissionsComboBox.Items.AddRange(New Object() {"Normal", "Admin"})
        Me.PermissionsComboBox.Location = New System.Drawing.Point(162, 96)
        Me.PermissionsComboBox.Name = "PermissionsComboBox"
        Me.PermissionsComboBox.Size = New System.Drawing.Size(127, 24)
        Me.PermissionsComboBox.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Permissions"
        '
        'CreateUserWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 182)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PermissionsComboBox)
        Me.Controls.Add(Me.CreateButton)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.UserNameTextBox)
        Me.Controls.Add(Me.GenPassCheckBox)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CreateUserWindow"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CreateUserWindow"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GenPassCheckBox As CheckBox
    Friend WithEvents UserNameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents CreateButton As Button
    Friend WithEvents PermissionsComboBox As ComboBox
    Friend WithEvents Label3 As Label
End Class
