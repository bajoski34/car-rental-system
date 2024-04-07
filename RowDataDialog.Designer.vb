<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RowDataDialog
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.carModelLabel = New System.Windows.Forms.Label()
        Me.rentalDurationLabel = New System.Windows.Forms.Label()
        Me.costLabel = New System.Windows.Forms.Label()
        Me.licenseLabel = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.totalCostLabel = New System.Windows.Forms.Label()
        Me.totalCostValue = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(113, 88)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(130, 20)
        Me.TextBox1.TabIndex = 0
        '
        'carModelLabel
        '
        Me.carModelLabel.AutoSize = True
        Me.carModelLabel.Location = New System.Drawing.Point(41, 91)
        Me.carModelLabel.Name = "carModelLabel"
        Me.carModelLabel.Size = New System.Drawing.Size(58, 13)
        Me.carModelLabel.TabIndex = 1
        Me.carModelLabel.Text = "Car Model:"
        '
        'rentalDurationLabel
        '
        Me.rentalDurationLabel.AutoSize = True
        Me.rentalDurationLabel.Location = New System.Drawing.Point(41, 130)
        Me.rentalDurationLabel.Name = "rentalDurationLabel"
        Me.rentalDurationLabel.Size = New System.Drawing.Size(84, 13)
        Me.rentalDurationLabel.TabIndex = 2
        Me.rentalDurationLabel.Text = "Rental Duration:"
        '
        'costLabel
        '
        Me.costLabel.AutoSize = True
        Me.costLabel.Location = New System.Drawing.Point(44, 164)
        Me.costLabel.Name = "costLabel"
        Me.costLabel.Size = New System.Drawing.Size(77, 13)
        Me.costLabel.TabIndex = 3
        Me.costLabel.Text = "Cost of Rental:"
        '
        'licenseLabel
        '
        Me.licenseLabel.AutoSize = True
        Me.licenseLabel.Location = New System.Drawing.Point(52, 53)
        Me.licenseLabel.Name = "licenseLabel"
        Me.licenseLabel.Size = New System.Drawing.Size(47, 13)
        Me.licenseLabel.TabIndex = 4
        Me.licenseLabel.Text = "License:"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(132, 130)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 5
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(132, 164)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 6
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(111, 53)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(107, 20)
        Me.TextBox4.TabIndex = 7
        '
        'totalCostLabel
        '
        Me.totalCostLabel.AutoSize = True
        Me.totalCostLabel.Location = New System.Drawing.Point(67, 215)
        Me.totalCostLabel.Name = "totalCostLabel"
        Me.totalCostLabel.Size = New System.Drawing.Size(58, 13)
        Me.totalCostLabel.TabIndex = 8
        Me.totalCostLabel.Text = "Total Cost:"
        '
        'totalCostValue
        '
        Me.totalCostValue.AutoSize = True
        Me.totalCostValue.Location = New System.Drawing.Point(131, 215)
        Me.totalCostValue.Name = "totalCostValue"
        Me.totalCostValue.Size = New System.Drawing.Size(22, 13)
        Me.totalCostValue.TabIndex = 9
        Me.totalCostValue.Text = "0.0"
        '
        'RowDataDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 343)
        Me.Controls.Add(Me.totalCostValue)
        Me.Controls.Add(Me.totalCostLabel)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.licenseLabel)
        Me.Controls.Add(Me.costLabel)
        Me.Controls.Add(Me.rentalDurationLabel)
        Me.Controls.Add(Me.carModelLabel)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "RowDataDialog"
        Me.Text = "Rental Invoice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents carModelLabel As Label
    Friend WithEvents rentalDurationLabel As Label
    Friend WithEvents costLabel As Label
    Friend WithEvents licenseLabel As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents totalCostLabel As Label
    Friend WithEvents totalCostValue As Label
End Class
