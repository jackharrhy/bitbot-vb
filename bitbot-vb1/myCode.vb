Module myCode
    Public IWantAConsole As Boolean = True
    Public SBCHostname As String = "theforsakenSBC"
    Public SBCIP As String = "192.168.0.61"

    Dim inter As New Phidgets.InterfaceKit
    Dim motor As New Phidgets.MotorControl
    Dim servo As New Phidgets.AdvancedServo

    Public Sub NewDeviceConnected(ByVal newDevice)
        If String.Equals(newDevice.Type, "PhidgetInterfaceKit") Then
            Dim interWindow As New customInterface(inter)
            inter.open(newDevice.SerialNumber, myCode.SBCHostname)
        ElseIf String.Equals(newDevice.Type, "PhidgetMotorControl") Then
            Dim motorWindow As New customMotor(motor)
            motor.open(newDevice.SerialNumber, myCode.SBCHostname)
        ElseIf String.Equals(newDevice.Type, "PhidgetAdvancedServo") Then
            servo.open(newDevice.SerialNumber, myCode.SBCHostname)
        End If
    End Sub

    Private ServoHalf As Double

    Public IntervalInMilliseconds As Integer = 200
    Public Sub LoopingSub()
        If motor.Attached And motor.motors.Count > 0 Then
            motor.motors(0).Velocity = (joyStick.y() * -100)
            motor.motors(1).Velocity = (joyStick.y() * -100)
        End If

        If servo.Attached And servo.servos.Count > 0 Then
            If Not servo.servos(0).Engaged Then
                servo.servos(0).Engaged = True
                ServoHalf = (servo.servos(0).PositionMax / 2) - (joyStick.x() * (servo.servos(0).PositionMax / 2))
            Else
                servo.servos(0).Position = (servo.servos(0).PositionMax / 2) - ((joyStick.x() / -2) * (servo.servos(0).PositionMax / 2))
                Debug.WriteLine(servo.servos(0).Position)
            End If
        End If
    End Sub

    Public Sub ClosingDown()
        If servo.Attached And servo.servos.Count > 0 Then
            servo.servos(0).Engaged = False
        End If
    End Sub
End Module
