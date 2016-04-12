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
        Me.components = New System.ComponentModel.Container()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AcelTextBox1 = New System.Windows.Forms.TextBox()
        Me.AcelTextBox0 = New System.Windows.Forms.TextBox()
        Me.TargetVelocityTextBox1 = New System.Windows.Forms.TextBox()
        Me.TargetVelocityTextBox0 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TarAcelTextBox0 = New System.Windows.Forms.TextBox()
        Me.UpdateLoop = New System.Windows.Forms.Timer(Me.components)
        Me.TarAcelTextBox1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.VelocityTextBox1 = New System.Windows.Forms.TextBox()
        Me.CurrentTextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VelocityTextBox0 = New System.Windows.Forms.TextBox()
        Me.CurrentTextBox0 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Acel"
        '
        'AcelTextBox1
        '
        Me.AcelTextBox1.Location = New System.Drawing.Point(189, 102)
        Me.AcelTextBox1.Name = "AcelTextBox1"
        Me.AcelTextBox1.ReadOnly = True
        Me.AcelTextBox1.Size = New System.Drawing.Size(119, 20)
        Me.AcelTextBox1.TabIndex = 46
        '
        'AcelTextBox0
        '
        Me.AcelTextBox0.Location = New System.Drawing.Point(59, 102)
        Me.AcelTextBox0.Name = "AcelTextBox0"
        Me.AcelTextBox0.ReadOnly = True
        Me.AcelTextBox0.Size = New System.Drawing.Size(109, 20)
        Me.AcelTextBox0.TabIndex = 45
        '
        'TargetVelocityTextBox1
        '
        Me.TargetVelocityTextBox1.Location = New System.Drawing.Point(189, 76)
        Me.TargetVelocityTextBox1.Name = "TargetVelocityTextBox1"
        Me.TargetVelocityTextBox1.Size = New System.Drawing.Size(119, 20)
        Me.TargetVelocityTextBox1.TabIndex = 44
        '
        'TargetVelocityTextBox0
        '
        Me.TargetVelocityTextBox0.Location = New System.Drawing.Point(59, 76)
        Me.TargetVelocityTextBox0.Name = "TargetVelocityTextBox0"
        Me.TargetVelocityTextBox0.Size = New System.Drawing.Size(109, 20)
        Me.TargetVelocityTextBox0.TabIndex = 43
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Tar Vel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Velocity"
        '
        'TarAcelTextBox0
        '
        Me.TarAcelTextBox0.Location = New System.Drawing.Point(59, 128)
        Me.TarAcelTextBox0.Name = "TarAcelTextBox0"
        Me.TarAcelTextBox0.Size = New System.Drawing.Size(109, 20)
        Me.TarAcelTextBox0.TabIndex = 39
        '
        'UpdateLoop
        '
        Me.UpdateLoop.Interval = 50
        '
        'TarAcelTextBox1
        '
        Me.TarAcelTextBox1.Location = New System.Drawing.Point(189, 128)
        Me.TarAcelTextBox1.Name = "TarAcelTextBox1"
        Me.TarAcelTextBox1.Size = New System.Drawing.Size(119, 20)
        Me.TarAcelTextBox1.TabIndex = 40
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(224, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Motor 1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(91, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Motor 0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Tar Acel"
        '
        'VelocityTextBox1
        '
        Me.VelocityTextBox1.Location = New System.Drawing.Point(189, 50)
        Me.VelocityTextBox1.Name = "VelocityTextBox1"
        Me.VelocityTextBox1.ReadOnly = True
        Me.VelocityTextBox1.Size = New System.Drawing.Size(119, 20)
        Me.VelocityTextBox1.TabIndex = 35
        '
        'CurrentTextBox1
        '
        Me.CurrentTextBox1.Location = New System.Drawing.Point(189, 24)
        Me.CurrentTextBox1.Name = "CurrentTextBox1"
        Me.CurrentTextBox1.ReadOnly = True
        Me.CurrentTextBox1.Size = New System.Drawing.Size(119, 20)
        Me.CurrentTextBox1.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Current"
        '
        'VelocityTextBox0
        '
        Me.VelocityTextBox0.Location = New System.Drawing.Point(59, 50)
        Me.VelocityTextBox0.Name = "VelocityTextBox0"
        Me.VelocityTextBox0.ReadOnly = True
        Me.VelocityTextBox0.Size = New System.Drawing.Size(109, 20)
        Me.VelocityTextBox0.TabIndex = 32
        '
        'CurrentTextBox0
        '
        Me.CurrentTextBox0.Location = New System.Drawing.Point(59, 24)
        Me.CurrentTextBox0.Name = "CurrentTextBox0"
        Me.CurrentTextBox0.ReadOnly = True
        Me.CurrentTextBox0.Size = New System.Drawing.Size(109, 20)
        Me.CurrentTextBox0.TabIndex = 31
        '
        'customMotor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 162)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.AcelTextBox1)
        Me.Controls.Add(Me.AcelTextBox0)
        Me.Controls.Add(Me.TargetVelocityTextBox1)
        Me.Controls.Add(Me.TargetVelocityTextBox0)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TarAcelTextBox0)
        Me.Controls.Add(Me.TarAcelTextBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.VelocityTextBox1)
        Me.Controls.Add(Me.CurrentTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.VelocityTextBox0)
        Me.Controls.Add(Me.CurrentTextBox0)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(343, 201)
        Me.MinimumSize = New System.Drawing.Size(343, 201)
        Me.Name = "customMotor"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents AcelTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents AcelTextBox0 As System.Windows.Forms.TextBox
    Friend WithEvents TargetVelocityTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TargetVelocityTextBox0 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TarAcelTextBox0 As System.Windows.Forms.TextBox
    Friend WithEvents UpdateLoop As System.Windows.Forms.Timer
    Friend WithEvents TarAcelTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents VelocityTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CurrentTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents VelocityTextBox0 As System.Windows.Forms.TextBox
    Friend WithEvents CurrentTextBox0 As System.Windows.Forms.TextBox
End Class
