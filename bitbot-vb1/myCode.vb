Module myCode
    Public IWantAConsole As Boolean = True
    Public SBCHostname As String = "theforsakenSBC"
    Public SBCIP As String = "192.168.0.61"

    Dim inter As New Phidgets.InterfaceKit
    Dim motor As New Phidgets.MotorControl

    Public Sub NewDeviceConnected(ByVal newDevice)
        If String.Equals(newDevice.GetType(), "PhidgetInterfaceKit") Then
            Dim interWindow As New customInterface(inter)
            inter.open(newDevice.SerialNumber, myCode.SBCHostname)
        ElseIf String.Equals(newDevice.GetType(), "PhidgetMotorControl") Then
            Dim motorWindow As New customMotor(motor)
            motor.open(newDevice.SerialNumber, myCode.SBCHostname)
        End If
    End Sub

    Public IntervalInMilliseconds As Integer = 200
    Public Sub LoopingSub()
        If motor.Attached Then
            motor.motors(0).Velocity = joyStick.y() * -100
        End If
    End Sub

    Public Sub ClosingDown()

    End Sub
End Module
