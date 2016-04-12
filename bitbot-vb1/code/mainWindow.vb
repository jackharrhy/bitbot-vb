Public Class mainWindow
    Public WithEvents phidgetMan As New Phidgets.Manager

    Private Sub mainWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConnectingToInfo.Text = "Connecting to: " + myCode.SBCHostname + ", IP: " + myCode.SBCIP.ToString()

        AttachedGrid.ColumnCount = 2
        AttachedGrid.Columns(0).Name = "Device Name"
        AttachedGrid.Columns(0).Width = 40
        AttachedGrid.Columns(0).MinimumWidth = 40
        AttachedGrid.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        AttachedGrid.Columns(1).Name = "Serial No."
        AttachedGrid.Columns(1).Width = 80
        AttachedGrid.Columns(1).MinimumWidth = 80
    End Sub

    Private Sub phidgetMan_Attach(ByVal sender As Object, ByVal e As Phidgets.Events.AttachEventArgs) Handles phidgetMan.Attach
        Dim newrow() As String = {e.Device.Name, e.Device.SerialNumber.ToString()}
        AttachedGrid.Rows.Add(newrow)

        myCode.NewDeviceConnected(e.Device)
    End Sub

    Private Sub phidgetMan_Detach(ByVal sender As Object, ByVal e As Phidgets.Events.DetachEventArgs) Handles phidgetMan.Detach
        Dim row As DataGridViewRow
        For Each row In AttachedGrid.Rows
            If row.Cells(1).Value.Equals(e.Device.SerialNumber) Then
                AttachedGrid.Rows.Remove(row)
            End If
        Next
    End Sub

    Private Sub phidgetMan_Error(ByVal sender As Object, ByVal e As Phidgets.Events.ErrorEventArgs) Handles phidgetMan.Error
        StartButton.BackColor = Color.Red
        StartButton.Text = "Check Debug Console"
        Beep()
        Debug.WriteLine(e.Description)
    End Sub

    Private Sub phidgetMan_ServerConnect() Handles phidgetMan.ServerConnect
        StartButton.Text = "Connected!"
        StartButton.BackColor = Color.DarkGreen
    End Sub

    Private Sub phidgetMan_ServerDisconnect() Handles phidgetMan.ServerDisconnect
        StartButton.Text = "Disconnected"
        StartButton.BackColor = Color.Black
    End Sub

    Private Sub StartButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartButton.Click
        StartButton.BackColor = Color.DarkSlateBlue
        StartButton.Text = "Connecting..."

        phidgetMan.open(myCode.SBCIP, 5001)
    End Sub

    Private Sub mainWindow_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        myCode.ClosingDown()

        phidgetMan.close()
        RemoveHandler phidgetMan.Attach, AddressOf phidgetMan_Attach
        RemoveHandler phidgetMan.Detach, AddressOf phidgetMan_Detach
        RemoveHandler phidgetMan.Error, AddressOf phidgetMan_Error
    End Sub

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        If Not String.Equals(Timer.Interval, myCode.IntervalInMilliseconds) Then
            Timer.Interval = myCode.IntervalInMilliseconds
        End If

        myCode.LoopingSub()
    End Sub
End Class
