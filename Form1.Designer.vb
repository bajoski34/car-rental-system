<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.lbl_pickup = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lbl_dropoff = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBoxCarTypes = New System.Windows.Forms.ComboBox()
        Me.lbl_Help = New System.Windows.Forms.Label()
        Me.lbl_signin = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Pick-up date"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(112, 149)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(195, 20)
        Me.TextBox5.TabIndex = 7
        '
        'lbl_pickup
        '
        Me.lbl_pickup.AutoSize = True
        Me.lbl_pickup.Location = New System.Drawing.Point(20, 123)
        Me.lbl_pickup.Name = "lbl_pickup"
        Me.lbl_pickup.Size = New System.Drawing.Size(87, 13)
        Me.lbl_pickup.TabIndex = 8
        Me.lbl_pickup.Text = "Pick-up Location"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(110, 118)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(197, 20)
        Me.txtAddress.TabIndex = 9
        Me.txtAddress.Text = "222-05 56th Ave, Bayside, NY 11364"
        '
        'lbl_dropoff
        '
        Me.lbl_dropoff.AutoSize = True
        Me.lbl_dropoff.Location = New System.Drawing.Point(20, 152)
        Me.lbl_dropoff.Name = "lbl_dropoff"
        Me.lbl_dropoff.Size = New System.Drawing.Size(89, 13)
        Me.lbl_dropoff.TabIndex = 10
        Me.lbl_dropoff.Text = "Drop-off Location"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.MenuText
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(92, 205)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(98, 20)
        Me.DateTimePicker1.TabIndex = 12
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(220, 205)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(98, 20)
        Me.DateTimePicker2.TabIndex = 13
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(21, 96)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(160, 17)
        Me.CheckBox1.TabIndex = 16
        Me.CheckBox1.Text = "Drop-off location is the same"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ComboBoxCarTypes)
        Me.Panel1.Controls.Add(Me.lbl_Help)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.lbl_signin)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(7, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1238, 596)
        Me.Panel1.TabIndex = 17
        '
        'ComboBoxCarTypes
        '
        Me.ComboBoxCarTypes.FormattingEnabled = True
        Me.ComboBoxCarTypes.Items.AddRange(New Object() {"Economy", "Economy cars from $37", "$37", "", "Compact", "Compact cars from $37", "$37", "", "Midsize", "Midsize cars from $37", "$37", "", "Standard", "Standard cars from $38", "$38", "", "Full-size", "Full-size cars from $38", "$38", "", "Premium", "Premium cars from $50", "$50", "", "Luxury", "Luxury cars from $70", "$70", "", "Minivan", "Minivan cars from $60", "$60", "", "SUV", "SUV cars from $45", "$45", "", "Van", "Van cars from $99", "$99", "", "Pickup", "Pickup cars from $37", "$37", "", "Sports Car", "Sports Car cars from $60", "$60", "", "Other"})
        Me.ComboBoxCarTypes.Location = New System.Drawing.Point(16, 257)
        Me.ComboBoxCarTypes.Name = "ComboBoxCarTypes"
        Me.ComboBoxCarTypes.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxCarTypes.TabIndex = 14
        Me.ComboBoxCarTypes.Text = "Car Types"
        '
        'lbl_Help
        '
        Me.lbl_Help.AutoSize = True
        Me.lbl_Help.Location = New System.Drawing.Point(1166, 18)
        Me.lbl_Help.Name = "lbl_Help"
        Me.lbl_Help.Size = New System.Drawing.Size(29, 13)
        Me.lbl_Help.TabIndex = 2
        Me.lbl_Help.Text = "Help"
        '
        'lbl_signin
        '
        Me.lbl_signin.AutoSize = True
        Me.lbl_signin.Location = New System.Drawing.Point(1121, 18)
        Me.lbl_signin.Name = "lbl_signin"
        Me.lbl_signin.Size = New System.Drawing.Size(39, 13)
        Me.lbl_signin.TabIndex = 1
        Me.lbl_signin.Tag = ""
        Me.lbl_signin.Text = "Sign in"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(95, 67)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'DirectorySearcher1
        '
        Me.DirectorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 604)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.lbl_dropoff)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.lbl_pickup)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = " Car Rental"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents lbl_pickup As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lbl_dropoff As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_Help As Label
    Friend WithEvents lbl_signin As Label
    Friend WithEvents ComboBoxCarTypes As ComboBox
    Friend WithEvents DirectorySearcher1 As DirectoryServices.DirectorySearcher
End Class
