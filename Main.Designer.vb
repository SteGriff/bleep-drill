<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.BeginLabel = New System.Windows.Forms.Label()
        Me.timingTemplate = New System.Windows.Forms.Panel()
        Me.Spinner = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AddAnother = New System.Windows.Forms.Button()
        Me.GoButton = New System.Windows.Forms.Button()
        Me.RepeatSpinner = New System.Windows.Forms.NumericUpDown()
        Me.RepeatForever = New System.Windows.Forms.CheckBox()
        Me.ExecuteGroup = New System.Windows.Forms.GroupBox()
        Me.GoLabel = New System.Windows.Forms.Label()
        Me.RunTimesLabel = New System.Windows.Forms.Label()
        Me.RemoveRow = New System.Windows.Forms.Button()
        Me.ToolsPanel = New System.Windows.Forms.Panel()
        Me.EndLabel = New System.Windows.Forms.Label()
        Me.timingTemplate.SuspendLayout()
        CType(Me.Spinner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepeatSpinner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ExecuteGroup.SuspendLayout()
        Me.ToolsPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI Light", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(12, 9)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(166, 37)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "Drill Program"
        '
        'BeginLabel
        '
        Me.BeginLabel.AutoSize = True
        Me.BeginLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BeginLabel.Location = New System.Drawing.Point(15, 46)
        Me.BeginLabel.Name = "BeginLabel"
        Me.BeginLabel.Size = New System.Drawing.Size(243, 19)
        Me.BeginLabel.TabIndex = 1
        Me.BeginLabel.Text = "Play the Begin tone, then do this loop:"
        '
        'timingTemplate
        '
        Me.timingTemplate.Controls.Add(Me.Spinner)
        Me.timingTemplate.Controls.Add(Me.Label3)
        Me.timingTemplate.Location = New System.Drawing.Point(304, 388)
        Me.timingTemplate.Name = "timingTemplate"
        Me.timingTemplate.Size = New System.Drawing.Size(199, 29)
        Me.timingTemplate.TabIndex = 2
        Me.timingTemplate.Visible = False
        '
        'Spinner
        '
        Me.Spinner.Location = New System.Drawing.Point(43, 3)
        Me.Spinner.Name = "Spinner"
        Me.Spinner.Size = New System.Drawing.Size(59, 20)
        Me.Spinner.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "After                 seconds, beep"
        '
        'AddAnother
        '
        Me.AddAnother.Location = New System.Drawing.Point(0, 22)
        Me.AddAnother.Name = "AddAnother"
        Me.AddAnother.Size = New System.Drawing.Size(106, 29)
        Me.AddAnother.TabIndex = 3
        Me.AddAnother.Text = "&More"
        Me.AddAnother.UseVisualStyleBackColor = True
        '
        'GoButton
        '
        Me.GoButton.Location = New System.Drawing.Point(6, 101)
        Me.GoButton.Name = "GoButton"
        Me.GoButton.Size = New System.Drawing.Size(165, 43)
        Me.GoButton.TabIndex = 4
        Me.GoButton.Text = "&Go (Alt + G)"
        Me.GoButton.UseVisualStyleBackColor = True
        '
        'RepeatSpinner
        '
        Me.RepeatSpinner.Location = New System.Drawing.Point(120, 32)
        Me.RepeatSpinner.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.RepeatSpinner.Name = "RepeatSpinner"
        Me.RepeatSpinner.Size = New System.Drawing.Size(51, 20)
        Me.RepeatSpinner.TabIndex = 5
        Me.RepeatSpinner.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'RepeatForever
        '
        Me.RepeatForever.AutoSize = True
        Me.RepeatForever.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RepeatForever.Location = New System.Drawing.Point(6, 58)
        Me.RepeatForever.Name = "RepeatForever"
        Me.RepeatForever.Size = New System.Drawing.Size(145, 17)
        Me.RepeatForever.TabIndex = 6
        Me.RepeatForever.Text = "Run continuously instead"
        Me.RepeatForever.UseVisualStyleBackColor = True
        '
        'ExecuteGroup
        '
        Me.ExecuteGroup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExecuteGroup.Controls.Add(Me.GoLabel)
        Me.ExecuteGroup.Controls.Add(Me.RunTimesLabel)
        Me.ExecuteGroup.Controls.Add(Me.GoButton)
        Me.ExecuteGroup.Controls.Add(Me.RepeatForever)
        Me.ExecuteGroup.Controls.Add(Me.RepeatSpinner)
        Me.ExecuteGroup.Location = New System.Drawing.Point(326, 12)
        Me.ExecuteGroup.Name = "ExecuteGroup"
        Me.ExecuteGroup.Size = New System.Drawing.Size(177, 203)
        Me.ExecuteGroup.TabIndex = 7
        Me.ExecuteGroup.TabStop = False
        Me.ExecuteGroup.Text = "Execute"
        '
        'GoLabel
        '
        Me.GoLabel.AutoSize = True
        Me.GoLabel.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GoLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GoLabel.Location = New System.Drawing.Point(54, 147)
        Me.GoLabel.Name = "GoLabel"
        Me.GoLabel.Size = New System.Drawing.Size(72, 47)
        Me.GoLabel.TabIndex = 8
        Me.GoLabel.Text = "GO"
        Me.GoLabel.Visible = False
        '
        'RunTimesLabel
        '
        Me.RunTimesLabel.AutoSize = True
        Me.RunTimesLabel.Location = New System.Drawing.Point(6, 34)
        Me.RunTimesLabel.Name = "RunTimesLabel"
        Me.RunTimesLabel.Size = New System.Drawing.Size(104, 13)
        Me.RunTimesLabel.TabIndex = 7
        Me.RunTimesLabel.Text = "Run this many times:"
        '
        'RemoveRow
        '
        Me.RemoveRow.Location = New System.Drawing.Point(112, 22)
        Me.RemoveRow.Name = "RemoveRow"
        Me.RemoveRow.Size = New System.Drawing.Size(106, 29)
        Me.RemoveRow.TabIndex = 8
        Me.RemoveRow.Text = "&Less"
        Me.RemoveRow.UseVisualStyleBackColor = True
        '
        'ToolsPanel
        '
        Me.ToolsPanel.Controls.Add(Me.EndLabel)
        Me.ToolsPanel.Controls.Add(Me.AddAnother)
        Me.ToolsPanel.Controls.Add(Me.RemoveRow)
        Me.ToolsPanel.Location = New System.Drawing.Point(19, 259)
        Me.ToolsPanel.Name = "ToolsPanel"
        Me.ToolsPanel.Size = New System.Drawing.Size(268, 56)
        Me.ToolsPanel.TabIndex = 9
        '
        'EndLabel
        '
        Me.EndLabel.AutoSize = True
        Me.EndLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.EndLabel.Location = New System.Drawing.Point(0, 0)
        Me.EndLabel.Name = "EndLabel"
        Me.EndLabel.Size = New System.Drawing.Size(219, 19)
        Me.EndLabel.TabIndex = 9
        Me.EndLabel.Text = "...1 time, then play the Finish tone."
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 429)
        Me.Controls.Add(Me.ToolsPanel)
        Me.Controls.Add(Me.ExecuteGroup)
        Me.Controls.Add(Me.timingTemplate)
        Me.Controls.Add(Me.BeginLabel)
        Me.Controls.Add(Me.TitleLabel)
        Me.Name = "Main"
        Me.Text = "Bleep Drill"
        Me.timingTemplate.ResumeLayout(False)
        Me.timingTemplate.PerformLayout()
        CType(Me.Spinner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepeatSpinner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ExecuteGroup.ResumeLayout(False)
        Me.ExecuteGroup.PerformLayout()
        Me.ToolsPanel.ResumeLayout(False)
        Me.ToolsPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents BeginLabel As System.Windows.Forms.Label
    Friend WithEvents timingTemplate As System.Windows.Forms.Panel
    Friend WithEvents Spinner As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AddAnother As System.Windows.Forms.Button
    Friend WithEvents GoButton As System.Windows.Forms.Button
    Friend WithEvents RepeatSpinner As System.Windows.Forms.NumericUpDown
    Friend WithEvents RepeatForever As System.Windows.Forms.CheckBox
    Friend WithEvents ExecuteGroup As System.Windows.Forms.GroupBox
    Friend WithEvents RunTimesLabel As System.Windows.Forms.Label
    Friend WithEvents GoLabel As System.Windows.Forms.Label
    Friend WithEvents RemoveRow As System.Windows.Forms.Button
    Friend WithEvents ToolsPanel As System.Windows.Forms.Panel
    Friend WithEvents EndLabel As System.Windows.Forms.Label

End Class
