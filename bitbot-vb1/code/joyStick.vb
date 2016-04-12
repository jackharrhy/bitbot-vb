Module joyStick
    Public Function x()
        Dim State = OpenTK.Input.Joystick.GetState(0)
        If State.IsConnected Then
            Return State.GetAxis(OpenTK.Input.JoystickAxis.Axis0)
        End If
        Return False
    End Function
    Public Function y()
        Dim State = OpenTK.Input.Joystick.GetState(0)
        If State.IsConnected Then
            Return State.GetAxis(OpenTK.Input.JoystickAxis.Axis1)
        End If
        Return False
    End Function
    Public Function z()
        Dim State = OpenTK.Input.Joystick.GetState(0)
        If State.IsConnected Then
            Return State.GetAxis(OpenTK.Input.JoystickAxis.Axis2)
        End If
        Return False
    End Function

    Public Function button(ByVal number As Integer)
        Dim State = OpenTK.Input.Joystick.GetState(0)

        If State.IsConnected Then
            Select Case number
                Case 1
                    Return State.IsButtonDown(OpenTK.Input.JoystickButton.Button0)
                Case 2
                    Return State.IsButtonDown(OpenTK.Input.JoystickButton.Button1)
                Case 3
                    Return State.IsButtonDown(OpenTK.Input.JoystickButton.Button2)
                Case 4
                    Return State.IsButtonDown(OpenTK.Input.JoystickButton.Button3)
                Case 5
                    Return State.IsButtonDown(OpenTK.Input.JoystickButton.Button4)
                Case 6
                    Return State.IsButtonDown(OpenTK.Input.JoystickButton.Button5)
                Case 7
                    Return State.IsButtonDown(OpenTK.Input.JoystickButton.Button6)
                Case 8
                    Return State.IsButtonDown(OpenTK.Input.JoystickButton.Button7)
                Case 9
                    Return State.IsButtonDown(OpenTK.Input.JoystickButton.Button8)
                Case 10
                    Return State.IsButtonDown(OpenTK.Input.JoystickButton.Button9)
                Case 11
                    Return State.IsButtonDown(OpenTK.Input.JoystickButton.Button10)
            End Select
        End If
        Return False
    End Function
End Module
