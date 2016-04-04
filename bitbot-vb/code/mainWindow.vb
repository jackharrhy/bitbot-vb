Imports System.Runtime.InteropServices

Public Class mainWindow
    Public WithEvents phidgetMan As Phidgets.Manager

    ' Custom Error handler
    Public Sub HandleError(ByVal text As String)
        If Not ConsoleActive Then
            AllocConsole()
            Console.Title = "Error! :("
        End If
        Console.WriteLine("Error: " + text)
        Debug.WriteLine("Error: " + text)
    End Sub

    ' Once Form1 loads, createa new Phidget Manager and initiate the DataGridView
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Debug.WriteLine("New instance")

        phidgetMan = New Phidgets.Manager()

        AttachedGrid.ColumnCount = 2
        AttachedGrid.Columns(0).Name = "Device Name"
        AttachedGrid.Columns(0).Width = 40
        AttachedGrid.Columns(0).MinimumWidth = 40
        AttachedGrid.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        AttachedGrid.Columns(1).Name = "Serial No."
        AttachedGrid.Columns(1).Width = 80
        AttachedGrid.Columns(1).MinimumWidth = 80
    End Sub

    Public ConsoleActive As Boolean = False
    <DllImport("kernel32.dll")> Public Shared Function AllocConsole() As Boolean
    End Function
    <DllImport("kernel32.dll")> Public Shared Function FreeConsole() As Boolean
    End Function

    Public Sub Start()
        If myCode.DoYouWantToHaveAConsole Then
            ConsoleActive = True
            AllocConsole()

            Console.SetWindowSize(50, 30)
            Console.Title = "My Console"
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("CONSOLE OUTPUT")
            Console.ForegroundColor = ConsoleColor.White
        End If

        myCode.OnStartup()
        Timer.Enabled = True
    End Sub

    ' Change color of start button based off if connected or not
    Private Sub phidgetMan_ServerConnect() Handles phidgetMan.ServerConnect
        StartButton.Text = "Connected!"
        StartButton.BackColor = Color.DarkGreen
        Start()
    End Sub
    Private Sub phidgetMan_ServerDisconnect() Handles phidgetMan.ServerDisconnect
        StartButton.Text = "Disconnected"
        StartButton.BackColor = Color.Black
        deviceManager.RemoveAllDevices()
    End Sub

    ' Add a new row to the DataGridView with info from the new device
    Private Sub phidgetMan_Attach(ByVal sender As Object, ByVal e As Phidgets.Events.AttachEventArgs) Handles phidgetMan.Attach
        deviceManager.AddNewDevice(e.Device)
    End Sub

    ' Loop through DataGridView, trying to find the detached serial number, then removing it
    Private Sub phidgetMan_Detach(ByVal sender As Object, ByVal e As Phidgets.Events.DetachEventArgs) Handles phidgetMan.Detach
        deviceManager.RemoveDevice(e.Device.SerialNumber)
    End Sub

    ' MessageBox popup on an error with the Phidget Manager
    Private Sub phidgetMan_Error(ByVal sender As Object, ByVal e As Phidgets.Events.ErrorEventArgs) Handles phidgetMan.Error
        StartButton.BackColor = Color.Red
        StartButton.Text = "Check Console"
        Beep()
        HandleError(e.Description)
    End Sub

    ' Open the Phidget manager on the chosen Hostname
    Private Sub StartButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartButton.Click
        StartButton.BackColor = Color.DarkSlateBlue
        StartButton.Text = "Connecting..."

        If String.Equals(IPTextBox.Text, "") Then
            IPTextBox.Text = myCode.YourPhidgetSBCsIP
        End If
        If String.Equals(HostnameTextBox.Text, "") Then
            HostnameTextBox.Text = myCode.YourPhidgetSBCsHostname
        End If

        phidgetMan.open(IPTextBox.Text, 5001)
    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Quit()
    End Sub

    ' Safely close the Phidget Manager, then the window itself
    Public Sub Quit()
        myCode.OnClosing()
        deviceManager.RemoveAllDevices()

        ConsoleActive = False
        FreeConsole()

        RemoveHandler phidgetMan.Attach, AddressOf phidgetMan_Attach
        RemoveHandler phidgetMan.Detach, AddressOf phidgetMan_Detach
        RemoveHandler phidgetMan.Error, AddressOf phidgetMan_Error
        phidgetMan.close()

        Application.DoEvents()
        Me.Close()
    End Sub

    Private Sub specialButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles specialButton.Click
        specialWindow.Show()
    End Sub

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        If Not String.Equals(Timer.Interval, myCode.LoopIntervalInMilliseconds) Then
            Timer.Interval = myCode.LoopIntervalInMilliseconds
        End If

        myCode.LoopingSub()
    End Sub
End Class
