<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainWindow
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainWindow))
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.IPTextBox = New System.Windows.Forms.TextBox()
        Me.IPLabel = New System.Windows.Forms.Label()
        Me.AttachedGrid = New System.Windows.Forms.DataGridView()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.specialButton = New System.Windows.Forms.Button()
        Me.HostnameLabel = New System.Windows.Forms.Label()
        Me.HostnameTextBox = New System.Windows.Forms.TextBox()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.AttachedGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.Color.DarkRed
        Me.CloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CloseButton.Location = New System.Drawing.Point(236, 12)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(40, 40)
        Me.CloseButton.TabIndex = 0
        Me.CloseButton.TabStop = False
        Me.CloseButton.Text = "X"
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'IPTextBox
        '
        Me.IPTextBox.Location = New System.Drawing.Point(78, 58)
        Me.IPTextBox.Name = "IPTextBox"
        Me.IPTextBox.Size = New System.Drawing.Size(198, 20)
        Me.IPTextBox.TabIndex = 2
        '
        'IPLabel
        '
        Me.IPLabel.AutoSize = True
        Me.IPLabel.Location = New System.Drawing.Point(55, 61)
        Me.IPLabel.Name = "IPLabel"
        Me.IPLabel.Size = New System.Drawing.Size(17, 13)
        Me.IPLabel.TabIndex = 3
        Me.IPLabel.Text = "IP"
        '
        'AttachedGrid
        '
        Me.AttachedGrid.AllowUserToAddRows = False
        Me.AttachedGrid.AllowUserToDeleteRows = False
        Me.AttachedGrid.AllowUserToResizeColumns = False
        Me.AttachedGrid.AllowUserToResizeRows = False
        Me.AttachedGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AttachedGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AttachedGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AttachedGrid.DefaultCellStyle = DataGridViewCellStyle5
        Me.AttachedGrid.Enabled = False
        Me.AttachedGrid.Location = New System.Drawing.Point(12, 110)
        Me.AttachedGrid.MultiSelect = False
        Me.AttachedGrid.Name = "AttachedGrid"
        Me.AttachedGrid.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AttachedGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.AttachedGrid.RowHeadersVisible = False
        Me.AttachedGrid.Size = New System.Drawing.Size(264, 262)
        Me.AttachedGrid.TabIndex = 5
        '
        'StartButton
        '
        Me.StartButton.BackColor = System.Drawing.Color.DarkSlateGray
        Me.StartButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.StartButton.Location = New System.Drawing.Point(12, 12)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(172, 40)
        Me.StartButton.TabIndex = 1
        Me.StartButton.TabStop = False
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = False
        '
        'specialButton
        '
        Me.specialButton.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.specialButton.BackgroundImage = CType(resources.GetObject("specialButton.BackgroundImage"), System.Drawing.Image)
        Me.specialButton.Font = New System.Drawing.Font("Impact", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.specialButton.ForeColor = System.Drawing.Color.GhostWhite
        Me.specialButton.Location = New System.Drawing.Point(190, 12)
        Me.specialButton.Name = "specialButton"
        Me.specialButton.Size = New System.Drawing.Size(40, 40)
        Me.specialButton.TabIndex = 6
        Me.specialButton.TabStop = False
        Me.specialButton.Text = "?"
        Me.specialButton.UseVisualStyleBackColor = False
        '
        'HostnameLabel
        '
        Me.HostnameLabel.AutoSize = True
        Me.HostnameLabel.Location = New System.Drawing.Point(17, 87)
        Me.HostnameLabel.Name = "HostnameLabel"
        Me.HostnameLabel.Size = New System.Drawing.Size(55, 13)
        Me.HostnameLabel.TabIndex = 7
        Me.HostnameLabel.Text = "Hostname"
        '
        'HostnameTextBox
        '
        Me.HostnameTextBox.Location = New System.Drawing.Point(78, 84)
        Me.HostnameTextBox.Name = "HostnameTextBox"
        Me.HostnameTextBox.Size = New System.Drawing.Size(198, 20)
        Me.HostnameTextBox.TabIndex = 8
        '
        'Timer
        '
        '
        'mainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(288, 384)
        Me.ControlBox = False
        Me.Controls.Add(Me.HostnameTextBox)
        Me.Controls.Add(Me.HostnameLabel)
        Me.Controls.Add(Me.specialButton)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.AttachedGrid)
        Me.Controls.Add(Me.IPLabel)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.IPTextBox)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(304, 652)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(304, 400)
        Me.Name = "mainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "bitbot-vb v1.4, by Jack Harrhy"
        CType(Me.AttachedGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents IPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IPLabel As System.Windows.Forms.Label
    Friend WithEvents AttachedGrid As System.Windows.Forms.DataGridView
    Friend WithEvents StartButton As System.Windows.Forms.Button
    Friend WithEvents specialButton As System.Windows.Forms.Button
    Friend WithEvents HostnameLabel As System.Windows.Forms.Label
    Friend WithEvents HostnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Timer As System.Windows.Forms.Timer

End Class
