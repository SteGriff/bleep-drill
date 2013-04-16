
Public Class Row
    Dim Time As Integer
    Friend WithEvents RowPanel As System.Windows.Forms.Panel
    Friend WithEvents RowSpinner As System.Windows.Forms.NumericUpDown
    Friend WithEvents RowLabel As System.Windows.Forms.Label

    Sub New(ByVal RowNumber As Integer, ByVal Time As Integer, ByVal Left As Integer, ByVal Top As Integer)

        Me.RowPanel = New System.Windows.Forms.Panel()
        Me.RowSpinner = New System.Windows.Forms.NumericUpDown()
        Me.RowLabel = New System.Windows.Forms.Label()

        'RowPanel
        Me.RowPanel.Controls.Add(Me.RowSpinner)
        Me.RowPanel.Controls.Add(Me.RowLabel)
        Me.RowPanel.Location = New System.Drawing.Point(Left, Top)
        Me.RowPanel.Name = "RowPanel" & RowNumber
        Me.RowPanel.Size = New System.Drawing.Size(200, 30)
        Me.RowPanel.TabIndex = 2
        Me.RowPanel.Visible = True

        'RowSpinner
        Me.RowSpinner.Location = New System.Drawing.Point(43, 3)
        Me.RowSpinner.Name = "RowSpinner"
        Me.RowSpinner.Size = New System.Drawing.Size(60, 20)
        Me.RowSpinner.TabIndex = 3
        Me.RowSpinner.Value = Time

        'RowLabel
        Me.RowLabel.AutoSize = True
        Me.RowLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RowLabel.Location = New System.Drawing.Point(3, 4)
        Me.RowLabel.Name = "RowLabel"
        Me.RowLabel.Size = New System.Drawing.Size(193, 20)
        Me.RowLabel.Text = "After                 seconds, beep"

        Me.RowPanel.ResumeLayout(False)
        Me.RowPanel.PerformLayout()

    End Sub

End Class
