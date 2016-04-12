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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainWindow))
        Me.AttachedGrid = New System.Windows.Forms.DataGridView()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.ConnectingToInfo = New System.Windows.Forms.Label()
        CType(Me.AttachedGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AttachedGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AttachedGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.AttachedGrid.Enabled = False
        Me.AttachedGrid.Location = New System.Drawing.Point(12, 71)
        Me.AttachedGrid.MultiSelect = False
        Me.AttachedGrid.Name = "AttachedGrid"
        Me.AttachedGrid.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AttachedGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.AttachedGrid.RowHeadersVisible = False
        Me.AttachedGrid.Size = New System.Drawing.Size(288, 265)
        Me.AttachedGrid.TabIndex = 6
        '
        'StartButton
        '
        Me.StartButton.BackColor = System.Drawing.Color.DarkSlateGray
        Me.StartButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.StartButton.Location = New System.Drawing.Point(12, 12)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(288, 40)
        Me.StartButton.TabIndex = 7
        Me.StartButton.TabStop = False
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = False
        '
        'Timer
        '
        Me.Timer.Enabled = True
        '
        'ConnectingToInfo
        '
        Me.ConnectingToInfo.AutoSize = True
        Me.ConnectingToInfo.Location = New System.Drawing.Point(12, 55)
        Me.ConnectingToInfo.Name = "ConnectingToInfo"
        Me.ConnectingToInfo.Size = New System.Drawing.Size(39, 13)
        Me.ConnectingToInfo.TabIndex = 8
        Me.ConnectingToInfo.Text = "Label1"
        '
        'mainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 348)
        Me.Controls.Add(Me.ConnectingToInfo)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.AttachedGrid)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(328, 387)
        Me.MinimumSize = New System.Drawing.Size(328, 387)
        Me.Name = "mainWindow"
        Me.ShowIcon = False
        Me.Text = "bitbot-vb v1.5, by Jack Harrhy"
        CType(Me.AttachedGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AttachedGrid As System.Windows.Forms.DataGridView
    Friend WithEvents StartButton As System.Windows.Forms.Button
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents ConnectingToInfo As System.Windows.Forms.Label

End Class
