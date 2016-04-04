<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customMotor
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
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.CurrentTextBox0 = New System.Windows.Forms.TextBox()
        Me.VelocityTextBox0 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VelocityTextBox1 = New System.Windows.Forms.TextBox()
        Me.CurrentTextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TarAcelTextBox1 = New System.Windows.Forms.TextBox()
        Me.TarAcelTextBox0 = New System.Windows.Forms.TextBox()
        Me.TargetVelocityTextBox1 = New System.Windows.Forms.TextBox()
        Me.TargetVelocityTextBox0 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AcelTextBox1 = New System.Windows.Forms.TextBox()
        Me.AcelTextBox0 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.Color.DarkRed
        Me.CloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CloseButton.Location = New System.Drawing.Point(274, 12)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(40, 40)
        Me.CloseButton.TabIndex = 1
        Me.CloseButton.TabStop = False
        Me.CloseButton.Text = "X"
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'CurrentTextBox0
        '
        Me.CurrentTextBox0.Location = New System.Drawing.Point(65, 71)
        Me.CurrentTextBox0.Name = "CurrentTextBox0"
        Me.CurrentTextBox0.ReadOnly = True
        Me.CurrentTextBox0.Size = New System.Drawing.Size(109, 20)
        Me.CurrentTextBox0.TabIndex = 2
        '
        'VelocityTextBox0
        '
        Me.VelocityTextBox0.Location = New System.Drawing.Point(65, 97)
        Me.VelocityTextBox0.Name = "VelocityTextBox0"
        Me.VelocityTextBox0.ReadOnly = True
        Me.VelocityTextBox0.Size = New System.Drawing.Size(109, 20)
        Me.VelocityTextBox0.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Current"
        '
        'VelocityTextBox1
        '
        Me.VelocityTextBox1.Location = New System.Drawing.Point(195, 97)
        Me.VelocityTextBox1.Name = "VelocityTextBox1"
        Me.VelocityTextBox1.ReadOnly = True
        Me.VelocityTextBox1.Size = New System.Drawing.Size(119, 20)
        Me.VelocityTextBox1.TabIndex = 11
        '
        'CurrentTextBox1
        '
        Me.CurrentTextBox1.Location = New System.Drawing.Point(195, 71)
        Me.CurrentTextBox1.Name = "CurrentTextBox1"
        Me.CurrentTextBox1.ReadOnly = True
        Me.CurrentTextBox1.Size = New System.Drawing.Size(119, 20)
        Me.CurrentTextBox1.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Tar Acel"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(97, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Motor 0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(230, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Motor 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Velocity"
        '
        'TarAcelTextBox1
        '
        Me.TarAcelTextBox1.Location = New System.Drawing.Point(195, 175)
        Me.TarAcelTextBox1.Name = "TarAcelTextBox1"
        Me.TarAcelTextBox1.Size = New System.Drawing.Size(119, 20)
        Me.TarAcelTextBox1.TabIndex = 23
        '
        'TarAcelTextBox0
        '
        Me.TarAcelTextBox0.Location = New System.Drawing.Point(65, 175)
        Me.TarAcelTextBox0.Name = "TarAcelTextBox0"
        Me.TarAcelTextBox0.Size = New System.Drawing.Size(109, 20)
        Me.TarAcelTextBox0.TabIndex = 22
        '
        'TargetVelocityTextBox1
        '
        Me.TargetVelocityTextBox1.Location = New System.Drawing.Point(195, 123)
        Me.TargetVelocityTextBox1.Name = "TargetVelocityTextBox1"
        Me.TargetVelocityTextBox1.Size = New System.Drawing.Size(119, 20)
        Me.TargetVelocityTextBox1.TabIndex = 27
        '
        'TargetVelocityTextBox0
        '
        Me.TargetVelocityTextBox0.Location = New System.Drawing.Point(65, 123)
        Me.TargetVelocityTextBox0.Name = "TargetVelocityTextBox0"
        Me.TargetVelocityTextBox0.Size = New System.Drawing.Size(109, 20)
        Me.TargetVelocityTextBox0.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Tar Vel"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Acel"
        '
        'AcelTextBox1
        '
        Me.AcelTextBox1.Location = New System.Drawing.Point(195, 149)
        Me.AcelTextBox1.Name = "AcelTextBox1"
        Me.AcelTextBox1.ReadOnly = True
        Me.AcelTextBox1.Size = New System.Drawing.Size(119, 20)
        Me.AcelTextBox1.TabIndex = 29
        '
        'AcelTextBox0
        '
        Me.AcelTextBox0.Location = New System.Drawing.Point(65, 149)
        Me.AcelTextBox0.Name = "AcelTextBox0"
        Me.AcelTextBox0.ReadOnly = True
        Me.AcelTextBox0.Size = New System.Drawing.Size(109, 20)
        Me.AcelTextBox0.TabIndex = 28
        '
        'customMotor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(326, 207)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.AcelTextBox1)
        Me.Controls.Add(Me.AcelTextBox0)
        Me.Controls.Add(Me.TargetVelocityTextBox1)
        Me.Controls.Add(Me.TargetVelocityTextBox0)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TarAcelTextBox1)
        Me.Controls.Add(Me.TarAcelTextBox0)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.VelocityTextBox1)
        Me.Controls.Add(Me.CurrentTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.VelocityTextBox0)
        Me.Controls.Add(Me.CurrentTextBox0)
        Me.Controls.Add(Me.CloseButton)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "customMotor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "to be changed"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents CurrentTextBox0 As System.Windows.Forms.TextBox
    Friend WithEvents VelocityTextBox0 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents VelocityTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CurrentTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TarAcelTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TarAcelTextBox0 As System.Windows.Forms.TextBox
    Friend WithEvents TargetVelocityTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TargetVelocityTextBox0 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents AcelTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents AcelTextBox0 As System.Windows.Forms.TextBox
End Class
