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
        Me.UserInfoDataGridView = New System.Windows.Forms.DataGridView()
        Me.InfoType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Info = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreateUserButton = New System.Windows.Forms.Button()
        Me.DeleteUserButton = New System.Windows.Forms.Button()
        Me.UserColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserTypeColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.UserDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserInfoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserDataGridView
        '
        Me.UserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserColumn, Me.PasswordColumn, Me.UserTypeColumn})
        Me.UserDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.UserDataGridView.Name = "UserDataGridView"
        Me.UserDataGridView.RowHeadersVisible = False
        Me.UserDataGridView.RowHeadersWidth = 51
        Me.UserDataGridView.RowTemplate.Height = 24
        Me.UserDataGridView.Size = New System.Drawing.Size(400, 426)
        Me.UserDataGridView.TabIndex = 0
        '
        'UserInfoDataGridView
        '
        Me.UserInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserInfoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.InfoType, Me.Info})
        Me.UserInfoDataGridView.Location = New System.Drawing.Point(418, 12)
        Me.UserInfoDataGridView.Name = "UserInfoDataGridView"
        Me.UserInfoDataGridView.RowHeadersVisible = False
        Me.UserInfoDataGridView.RowHeadersWidth = 51
        Me.UserInfoDataGridView.RowTemplate.Height = 24
        Me.UserInfoDataGridView.Size = New System.Drawing.Size(370, 426)
        Me.UserInfoDataGridView.TabIndex = 1
        '
        'InfoType
        '
        Me.InfoType.HeaderText = "InfoType"
        Me.InfoType.MinimumWidth = 6
        Me.InfoType.Name = "InfoType"
        Me.InfoType.Width = 125
        '
        'Info
        '
        Me.Info.HeaderText = "Information"
        Me.Info.MinimumWidth = 6
        Me.Info.Name = "Info"
        Me.Info.Width = 125
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
        Me.DeleteUserButton.Location = New System.Drawing.Point(665, 444)
        Me.DeleteUserButton.Name = "DeleteUserButton"
        Me.DeleteUserButton.Size = New System.Drawing.Size(123, 29)
        Me.DeleteUserButton.TabIndex = 3
        Me.DeleteUserButton.Text = "Delete User"
        Me.DeleteUserButton.UseVisualStyleBackColor = True
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
        'AdminUserControls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 485)
        Me.Controls.Add(Me.DeleteUserButton)
        Me.Controls.Add(Me.CreateUserButton)
        Me.Controls.Add(Me.UserInfoDataGridView)
        Me.Controls.Add(Me.UserDataGridView)
        Me.Name = "AdminUserControls"
        Me.Text = "UserControls"
        CType(Me.UserDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserInfoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UserDataGridView As DataGridView
    Friend WithEvents UserInfoDataGridView As DataGridView
    Friend WithEvents CreateUserButton As Button
    Friend WithEvents DeleteUserButton As Button
    Friend WithEvents InfoType As DataGridViewTextBoxColumn
    Friend WithEvents Info As DataGridViewTextBoxColumn
    Friend WithEvents UserColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserTypeColumn As DataGridViewTextBoxColumn
End Class
