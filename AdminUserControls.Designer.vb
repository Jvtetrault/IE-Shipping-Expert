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
        CType(Me.UserDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserDataGridView
        '
        Me.UserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserColumn, Me.PasswordColumn, Me.UserTypeColumn})
        Me.UserDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.UserDataGridView.Name = "UserDataGridView"
        Me.UserDataGridView.RowHeadersWidth = 51
        Me.UserDataGridView.RowTemplate.Height = 24
        Me.UserDataGridView.Size = New System.Drawing.Size(776, 426)
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
        Me.PasswordColumn.ReadOnly = True
        Me.PasswordColumn.Width = 125
        '
        'UserTypeColumn
        '
        Me.UserTypeColumn.HeaderText = "User Type"
        Me.UserTypeColumn.MinimumWidth = 6
        Me.UserTypeColumn.Name = "UserTypeColumn"
        Me.UserTypeColumn.ReadOnly = True
        Me.UserTypeColumn.Width = 125
        '
        'UserControls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.UserDataGridView)
        Me.Name = "UserControls"
        Me.Text = "UserControls"
        CType(Me.UserDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UserDataGridView As DataGridView
    Friend WithEvents UserColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserTypeColumn As DataGridViewTextBoxColumn
End Class
