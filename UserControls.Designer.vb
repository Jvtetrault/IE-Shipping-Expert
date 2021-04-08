<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControls
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
        Me.UserNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChangePasswordButton = New System.Windows.Forms.Button()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.CompanyTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.FaxTextBox = New System.Windows.Forms.TextBox()
        Me.PermissionComboBox = New System.Windows.Forms.ComboBox()
        Me.PermLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.Enabled = False
        Me.UserNameTextBox.Location = New System.Drawing.Point(91, 34)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.Size = New System.Drawing.Size(127, 22)
        Me.UserNameTextBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "User Name"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ChangePasswordButton)
        Me.GroupBox1.Controls.Add(Me.PasswordTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.UserNameTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(317, 114)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Login"
        '
        'ChangePasswordButton
        '
        Me.ChangePasswordButton.Location = New System.Drawing.Point(224, 61)
        Me.ChangePasswordButton.Name = "ChangePasswordButton"
        Me.ChangePasswordButton.Size = New System.Drawing.Size(87, 39)
        Me.ChangePasswordButton.TabIndex = 4
        Me.ChangePasswordButton.Text = "Change"
        Me.ChangePasswordButton.UseVisualStyleBackColor = True
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Enabled = False
        Me.PasswordTextBox.Location = New System.Drawing.Point(91, 69)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(127, 22)
        Me.PasswordTextBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 37)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "First Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(3, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 37)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Company"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(3, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 37)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Title"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Location = New System.Drawing.Point(3, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 37)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Email"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Location = New System.Drawing.Point(3, 185)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 37)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Phone"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 132)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(421, 285)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Contact Information"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.47267!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.52733!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PhoneTextBox, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.EmailTextBox, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TitleTextBox, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.CompanyTextBox, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LastNameTextBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.NameTextBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.FaxTextBox, 1, 6)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 18)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28572!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(415, 264)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Location = New System.Drawing.Point(3, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 37)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Last Name"
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PhoneTextBox.Location = New System.Drawing.Point(100, 188)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(312, 22)
        Me.PhoneTextBox.TabIndex = 14
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmailTextBox.Location = New System.Drawing.Point(100, 151)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(312, 22)
        Me.EmailTextBox.TabIndex = 13
        '
        'TitleTextBox
        '
        Me.TitleTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TitleTextBox.Location = New System.Drawing.Point(100, 114)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(312, 22)
        Me.TitleTextBox.TabIndex = 12
        '
        'CompanyTextBox
        '
        Me.CompanyTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CompanyTextBox.Location = New System.Drawing.Point(100, 77)
        Me.CompanyTextBox.Name = "CompanyTextBox"
        Me.CompanyTextBox.Size = New System.Drawing.Size(312, 22)
        Me.CompanyTextBox.TabIndex = 11
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LastNameTextBox.Location = New System.Drawing.Point(100, 40)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(312, 22)
        Me.LastNameTextBox.TabIndex = 10
        '
        'NameTextBox
        '
        Me.NameTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NameTextBox.Location = New System.Drawing.Point(100, 3)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(312, 22)
        Me.NameTextBox.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Location = New System.Drawing.Point(3, 222)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 42)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Fax"
        '
        'FaxTextBox
        '
        Me.FaxTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FaxTextBox.Location = New System.Drawing.Point(100, 225)
        Me.FaxTextBox.Name = "FaxTextBox"
        Me.FaxTextBox.Size = New System.Drawing.Size(312, 22)
        Me.FaxTextBox.TabIndex = 17
        '
        'PermissionComboBox
        '
        Me.PermissionComboBox.FormattingEnabled = True
        Me.PermissionComboBox.Items.AddRange(New Object() {"Normal", "Admin"})
        Me.PermissionComboBox.Location = New System.Drawing.Point(335, 73)
        Me.PermissionComboBox.Name = "PermissionComboBox"
        Me.PermissionComboBox.Size = New System.Drawing.Size(107, 24)
        Me.PermissionComboBox.TabIndex = 10
        Me.PermissionComboBox.Text = "Normal"
        '
        'PermLabel
        '
        Me.PermLabel.AutoSize = True
        Me.PermLabel.Location = New System.Drawing.Point(335, 46)
        Me.PermLabel.Name = "PermLabel"
        Me.PermLabel.Size = New System.Drawing.Size(84, 17)
        Me.PermLabel.TabIndex = 11
        Me.PermLabel.Text = "Permissions"
        '
        'UserControls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 446)
        Me.Controls.Add(Me.PermLabel)
        Me.Controls.Add(Me.PermissionComboBox)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UserControls"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "UserControls"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserNameTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ChangePasswordButton As Button
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label9 As Label
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents TitleTextBox As TextBox
    Friend WithEvents CompanyTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents FaxTextBox As TextBox
    Friend WithEvents PermissionComboBox As ComboBox
    Friend WithEvents PermLabel As Label
End Class
