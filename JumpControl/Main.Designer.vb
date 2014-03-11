<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.ShutDownCheckBox = New System.Windows.Forms.CheckBox()
        Me.RestartCheckBox = New System.Windows.Forms.CheckBox()
        Me.SleepCheckBox = New System.Windows.Forms.CheckBox()
        Me.SwitchUserCheckBox = New System.Windows.Forms.CheckBox()
        Me.LockCheckBox = New System.Windows.Forms.CheckBox()
        Me.LogOffCheckBox = New System.Windows.Forms.CheckBox()
        Me.AuthorLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.AuthorLabel = New System.Windows.Forms.Label()
        Me.ChooseItemsLabel = New System.Windows.Forms.Label()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.RestartExplorerCheckBox = New System.Windows.Forms.CheckBox()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShutDownCheckBox
        '
        Me.ShutDownCheckBox.AutoSize = True
        Me.ShutDownCheckBox.Location = New System.Drawing.Point(12, 31)
        Me.ShutDownCheckBox.Name = "ShutDownCheckBox"
        Me.ShutDownCheckBox.Size = New System.Drawing.Size(79, 17)
        Me.ShutDownCheckBox.TabIndex = 0
        Me.ShutDownCheckBox.Text = "Shut Down"
        Me.ShutDownCheckBox.UseVisualStyleBackColor = True
        '
        'RestartCheckBox
        '
        Me.RestartCheckBox.AutoSize = True
        Me.RestartCheckBox.Location = New System.Drawing.Point(12, 54)
        Me.RestartCheckBox.Name = "RestartCheckBox"
        Me.RestartCheckBox.Size = New System.Drawing.Size(60, 17)
        Me.RestartCheckBox.TabIndex = 0
        Me.RestartCheckBox.Text = "Restart"
        Me.RestartCheckBox.UseVisualStyleBackColor = True
        '
        'SleepCheckBox
        '
        Me.SleepCheckBox.AutoSize = True
        Me.SleepCheckBox.Location = New System.Drawing.Point(12, 77)
        Me.SleepCheckBox.Name = "SleepCheckBox"
        Me.SleepCheckBox.Size = New System.Drawing.Size(53, 17)
        Me.SleepCheckBox.TabIndex = 0
        Me.SleepCheckBox.Text = "Sleep"
        Me.SleepCheckBox.UseVisualStyleBackColor = True
        '
        'SwitchUserCheckBox
        '
        Me.SwitchUserCheckBox.AutoSize = True
        Me.SwitchUserCheckBox.Location = New System.Drawing.Point(12, 100)
        Me.SwitchUserCheckBox.Name = "SwitchUserCheckBox"
        Me.SwitchUserCheckBox.Size = New System.Drawing.Size(83, 17)
        Me.SwitchUserCheckBox.TabIndex = 0
        Me.SwitchUserCheckBox.Text = "Switch User"
        Me.SwitchUserCheckBox.UseVisualStyleBackColor = True
        '
        'LockCheckBox
        '
        Me.LockCheckBox.AutoSize = True
        Me.LockCheckBox.Location = New System.Drawing.Point(12, 123)
        Me.LockCheckBox.Name = "LockCheckBox"
        Me.LockCheckBox.Size = New System.Drawing.Size(50, 17)
        Me.LockCheckBox.TabIndex = 0
        Me.LockCheckBox.Text = "Lock"
        Me.LockCheckBox.UseVisualStyleBackColor = True
        '
        'LogOffCheckBox
        '
        Me.LogOffCheckBox.AutoSize = True
        Me.LogOffCheckBox.Location = New System.Drawing.Point(12, 146)
        Me.LogOffCheckBox.Name = "LogOffCheckBox"
        Me.LogOffCheckBox.Size = New System.Drawing.Size(61, 17)
        Me.LogOffCheckBox.TabIndex = 0
        Me.LogOffCheckBox.Text = "Log Off"
        Me.LogOffCheckBox.UseVisualStyleBackColor = True
        '
        'AuthorLinkLabel
        '
        Me.AuthorLinkLabel.AutoSize = True
        Me.AuthorLinkLabel.Location = New System.Drawing.Point(54, 218)
        Me.AuthorLinkLabel.Name = "AuthorLinkLabel"
        Me.AuthorLinkLabel.Size = New System.Drawing.Size(167, 13)
        Me.AuthorLinkLabel.TabIndex = 2
        Me.AuthorLinkLabel.TabStop = True
        Me.AuthorLinkLabel.Text = "http://protosphere.deviantart.com"
        '
        'AuthorLabel
        '
        Me.AuthorLabel.AutoSize = True
        Me.AuthorLabel.Location = New System.Drawing.Point(54, 201)
        Me.AuthorLabel.Name = "AuthorLabel"
        Me.AuthorLabel.Size = New System.Drawing.Size(78, 13)
        Me.AuthorLabel.TabIndex = 3
        Me.AuthorLabel.Text = "© ProtoSphere"
        '
        'ChooseItemsLabel
        '
        Me.ChooseItemsLabel.AutoSize = True
        Me.ChooseItemsLabel.Location = New System.Drawing.Point(12, 9)
        Me.ChooseItemsLabel.Name = "ChooseItemsLabel"
        Me.ChooseItemsLabel.Size = New System.Drawing.Size(144, 13)
        Me.ChooseItemsLabel.TabIndex = 4
        Me.ChooseItemsLabel.Text = "Choose which items to show:"
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.LogoPictureBox.Image = Global.JumpControl.My.Resources.Resources.Logo
        Me.LogoPictureBox.Location = New System.Drawing.Point(12, 198)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(36, 36)
        Me.LogoPictureBox.TabIndex = 1
        Me.LogoPictureBox.TabStop = False
        '
        'RestartExplorerCheckBox
        '
        Me.RestartExplorerCheckBox.AutoSize = True
        Me.RestartExplorerCheckBox.Location = New System.Drawing.Point(12, 169)
        Me.RestartExplorerCheckBox.Name = "RestartExplorerCheckBox"
        Me.RestartExplorerCheckBox.Size = New System.Drawing.Size(101, 17)
        Me.RestartExplorerCheckBox.TabIndex = 0
        Me.RestartExplorerCheckBox.Text = "Restart Explorer"
        Me.RestartExplorerCheckBox.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(230, 246)
        Me.Controls.Add(Me.ChooseItemsLabel)
        Me.Controls.Add(Me.AuthorLabel)
        Me.Controls.Add(Me.AuthorLinkLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.RestartExplorerCheckBox)
        Me.Controls.Add(Me.LogOffCheckBox)
        Me.Controls.Add(Me.LockCheckBox)
        Me.Controls.Add(Me.SwitchUserCheckBox)
        Me.Controls.Add(Me.SleepCheckBox)
        Me.Controls.Add(Me.RestartCheckBox)
        Me.Controls.Add(Me.ShutDownCheckBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.Text = "JumpControl"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShutDownCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents RestartCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SleepCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SwitchUserCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents LockCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents LogOffCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents AuthorLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents AuthorLabel As System.Windows.Forms.Label
    Friend WithEvents ChooseItemsLabel As System.Windows.Forms.Label
    Friend WithEvents RestartExplorerCheckBox As System.Windows.Forms.CheckBox

End Class
