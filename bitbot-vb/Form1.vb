Public Class Foum1
    Dim WithEvents phidgetMotor As Phidgets.MotorControl

    Dim WithEvents phidgetMan As Phidgets.Manager

    ' Once Form1 loads, createa new Phidget Manager and initiate the DataGridView
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        phidgetMan = New Phidgets.Manager()

        phidgetMotor = New Phidgets.MotorControl

        AttachedGrid.ColumnCount = 2
        AttachedGrid.Columns(0).Name = "Device Name"
        AttachedGrid.Columns(0).Width = 40
        AttachedGrid.Columns(0).MinimumWidth = 40
        AttachedGrid.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        AttachedGrid.Columns(1).Name = "Serial No."
        AttachedGrid.Columns(1).Width = 80
        AttachedGrid.Columns(1).MinimumWidth = 80
    End Sub

    ' Change color of start button based off if connected or not
    Private Sub phidgetMan_ServerConnect() Handles phidgetMan.ServerConnect
        StartButton.BackColor = Color.DarkGreen
    End Sub
    Private Sub phidgetMan_ServerDisconnect() Handles phidgetMan.ServerDisconnect
        StartButton.BackColor = Color.DarkSlateBlue
    End Sub

    ' Add a new row to the DataGridView with info from the new device
    Private Sub phidgetMan_Attach(ByVal sender As Object, ByVal e As Phidgets.Events.AttachEventArgs) Handles phidgetMan.Attach
        Dim newrow() As String = {e.Device.Name, e.Device.SerialNumber.ToString()}
        AttachedGrid.Rows.Add(newrow)
    End Sub

    ' Loop through DataGridView, trying to find the detached serial number, then removing it
    Private Sub phidgetMan_Detach(ByVal sender As Object, ByVal e As Phidgets.Events.DetachEventArgs) Handles phidgetMan.Detach
        Dim row As DataGridViewRow
        For Each row In AttachedGrid.Rows
            If row.Cells(1).Value.Equals(e.Device.SerialNumber.ToString()) Then
                AttachedGrid.Rows.Remove(row)
            End If
        Next
    End Sub

    ' MessageBox popup on an error with the Phidget Manager
    Private Sub phidgetMan_Error(ByVal sender As Object, ByVal e As Phidgets.Events.ErrorEventArgs) Handles phidgetMan.Error
        MessageBox.Show("Phidget Error!: " + e.Description)
    End Sub

    ' Open the Phidget manager on the chosen IP address
    Private Sub StartButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartButton.Click
        StartButton.BackColor = Color.DarkSlateBlue
        phidgetMan.open(IPTextBox.Text, 5001)
    End Sub

    ' Close the Phidget Manager, then the window itself
    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        phidgetMan.close()
        Me.Close()
    End Sub
End Class
