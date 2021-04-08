<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminUserControls
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
        Me.UserDataGridView = New System.Windows.Forms.DataGridView()
        Me.UserColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserTypeColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreateUserButton = New System.Windows.Forms.Button()
        Me.DeleteUserButton = New System.Windows.Forms.Button()
        Me.EditUserButton = New System.Windows.Forms.Button()
        Me.CurrentUserLabel = New System.Windows.Forms.Label()
        CType(Me.UserDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserDataGridView
        '
        Me.UserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserColumn, Me.PasswordColumn, Me.UserTypeColumn})
        Me.UserDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.UserDataGridView.MultiSelect = False
        Me.UserDataGridView.Name = "UserDataGridView"
        Me.UserDataGridView.RowHeadersVisible = False
        Me.UserDataGridView.RowHeadersWidth = 51
        Me.UserDataGridView.RowTemplate.Height = 24
        Me.UserDataGridView.Size = New System.Drawing.Size(400, 426)
        Me.UserDataGridView.TabIndex = 0
        '
        'UserColumn
        '
        Me.UserColumn.HeaderText = "User"
        Me.UserColumn.MinimumWidth = 6
        Me.UserColumn.Name = "UserColumn"
        Me.UserColumn.ReadOnly = True
        Me.UserColumn.Width = 125
        '
        'PasswordColumn
        '
        Me.PasswordColumn.HeaderText = "Password"
        Me.PasswordColumn.MinimumWidth = 6
        Me.PasswordColumn.Name = "PasswordColumn"
        Me.PasswordColumn.Width = 125
        '
        'UserTypeColumn
        '
        Me.UserTypeColumn.HeaderText = "User Type"
        Me.UserTypeColumn.MinimumWidth = 6
        Me.UserTypeColumn.Name = "UserTypeColumn"
        Me.UserTypeColumn.Width = 125
        '
        'CreateUserButton
        '
        Me.CreateUserButton.Location = New System.Drawing.Point(12, 444)
        Me.CreateUserButton.Name = "CreateUserButton"
        Me.CreateUserButton.Size = New System.Drawing.Size(123, 29)
        Me.CreateUserButton.TabIndex = 2
        Me.CreateUserButton.Text = "Create User"
        Me.CreateUserButton.UseVisualStyleBackColor = True
        '
        'DeleteUserButton
        '
        Me.DeleteUserButton.Location = New System.Drawing.Point(289, 444)
        Me.DeleteUserButton.Name = "DeleteUserButton"
        Me.DeleteUserButton.Size = New System.Drawing.Size(123, 29)
        Me.DeleteUserButton.TabIndex = 3
        Me.DeleteUserButton.Text = "Delete User"
        Me.DeleteUserButton.UseVisualStyleBackColor = True
        '
        'EditUserButton
        '
        Me.EditUserButton.Location = New System.Drawing.Point(165, 444)
        Me.EditUserButton.Name = "EditUserButton"
        Me.EditUserButton.Size = New System.Drawing.Size(88, 29)
        Me.EditUserButton.TabIndex = 4
        Me.EditUserButton.Text = "Edit User"
        Me.EditUserButton.UseVisualStyleBackColor = True
        '
        'CurrentUserLabel
        '
        Me.CurrentUserLabel.AutoSize = True
        Me.CurrentUserLabel.Location = New System.Drawing.Point(12, 481)
        Me.CurrentUserLabel.Name = "CurrentUserLabel"
        Me.CurrentUserLabel.Size = New System.Drawing.Size(38, 17)
        Me.CurrentUserLabel.TabIndex = 5
        Me.CurrentUserLabel.Text = "User"
        '
        'AdminUserControls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 507)
        Me.Controls.Add(Me.CurrentUserLabel)
        Me.Controls.Add(Me.EditUserButton)
        Me.Controls.Add(Me.DeleteUserButton)
        Me.Controls.Add(Me.CreateUserButton)
        Me.Controls.Add(Me.UserDataGridView)
        Me.Name = "AdminUserControls"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "UserControls"
        CType(Me.UserDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserDataGridView As DataGridView
    Friend WithEvents CreateUserButton As Button
    Friend WithEvents DeleteUserButton As Button
    Friend WithEvents UserColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserTypeColumn As DataGridViewTextBoxColumn
    Friend WithEvents EditUserButton As Button
    Friend WithEvents CurrentUserLabel As Label
End Class
