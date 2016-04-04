Module myCode
    ' Need help?
    ' jackharrhy.com/robotics
    ' jack@jackharrhy.com

    Public DoYouWantToHaveAConsole As Boolean = True
    Public YourPhidgetSBCsHostname As String = "maxbrokenlegsSBC"
    Public YourPhidgetSBCsIP As String = "192.168.1.62"

    ' Called once the connection to the PhidgetSBC has been made
    Public Sub OnStartup()

    End Sub

    Private Motor As customMotor

    ' Called once a device is added to the device manager
    Public Sub OnNewDevice(ByRef Device)

    End Sub

    ' Called again and again, at an interval
    Public LoopIntervalInMilliseconds As Integer = 200
    Public Sub LoopingSub()

    End Sub

    ' Called once the window closes
    Public Sub OnClosing()

    End Sub
End Module
