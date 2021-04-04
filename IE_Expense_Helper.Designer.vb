<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IE_Expense_Helper
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DevCheckBox = New System.Windows.Forms.CheckBox()
        Me.UserControlButton = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccessControlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 26)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(385, 113)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Drag and Drop Document (.pdf)"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "[Drop Document(s) .pdf file(s) here]"
        '
        'DevCheckBox
        '
        Me.DevCheckBox.AutoSize = True
        Me.DevCheckBox.Location = New System.Drawing.Point(12, 163)
        Me.DevCheckBox.Name = "DevCheckBox"
        Me.DevCheckBox.Size = New System.Drawing.Size(152, 21)
        Me.DevCheckBox.TabIndex = 1
        Me.DevCheckBox.Text = "Development Mode"
        Me.DevCheckBox.UseVisualStyleBackColor = True
        Me.DevCheckBox.Visible = False
        '
        'UserControlButton
        '
        Me.UserControlButton.Location = New System.Drawing.Point(274, 158)
        Me.UserControlButton.Name = "UserControlButton"
        Me.UserControlButton.Size = New System.Drawing.Size(99, 29)
        Me.UserControlButton.TabIndex = 2
        Me.UserControlButton.Text = "User Control"
        Me.UserControlButton.UseVisualStyleBackColor = True
        Me.UserControlButton.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(385, 28)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccessControlToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'AccessControlToolStripMenuItem
        '
        Me.AccessControlToolStripMenuItem.Name = "AccessControlToolStripMenuItem"
        Me.AccessControlToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.AccessControlToolStripMenuItem.Text = "Access Control"
        '
        'IE_Expense_Helper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 196)
        Me.Controls.Add(Me.UserControlButton)
        Me.Controls.Add(Me.DevCheckBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "IE_Expense_Helper"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "IE Expense Helper"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DevCheckBox As CheckBox
    Friend WithEvents UserControlButton As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccessControlToolStripMenuItem As ToolStripMenuItem
End Class
