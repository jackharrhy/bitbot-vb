Public Class customMotor
    Public WithEvents device As New Phidgets.MotorControl
    Private mySerialNumber As Int32

    Private inputArray As CheckBox()
    Private encoderArray As TextBox()
    Private sensorArray As TextBox()

    Public Sub CurrentChange(ByVal sender As Object, ByVal e As Phidgets.Events.CurrentChangeEventArgs) Handles device.CurrentChange
        CurrentTextBox0.Text = device.motors(0).Current
        CurrentTextBox1.Text = device.motors(1).Current
    End Sub

    Public Sub VelocityChange(ByVal sender As Object, ByVal e As Phidgets.Events.VelocityChangeEventArgs) Handles device.VelocityChange
        VelocityTextBox0.Text = device.motors(0).Velocity
        VelocityTextBox1.Text = device.motors(1).Velocity
    End Sub
    Private Sub TargetVelocityTextBox0_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TargetVelocityTextBox0.TextChanged
        If Not String.Equals(TargetVelocityTextBox0.Text, "") Then
            Try
                Dim TarVel As Double = TargetVelocityTextBox0.Text
                device.motors(0).Velocity = TarVel
                TargetVelocityTextBox0.BackColor = Color.White
            Catch ex As Exception
                TargetVelocityTextBox0.BackColor = Color.DarkRed
            End Try
        End If
    End Sub

    Private Sub TargetVelocityTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TargetVelocityTextBox1.TextChanged
        If Not String.Equals(TargetVelocityTextBox1.Text, "") Then
            Try
                Dim TarVel As Double = TargetVelocityTextBox1.Text
                device.motors(1).Velocity = TarVel
                TargetVelocityTextBox1.BackColor = Color.White
            Catch ex As Exception
                TargetVelocityTextBox1.BackColor = Color.DarkRed
            End Try
        End If
    End Sub

    Private Sub TarAcelTextBox0_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TarAcelTextBox0.TextChanged
        If Not String.Equals(TarAcelTextBox0.Text, "") Then
            Try
                Dim Acel As Double = TarAcelTextBox0.Text
                If Acel >= device.motors(0).AccelerationMin And Acel <= device.motors(0).AccelerationMax Then
                    device.motors(0).Acceleration = TarAcelTextBox0.Text
                    AcelTextBox0.Text = device.motors(0).Acceleration
                    TarAcelTextBox0.BackColor = Color.White
                Else
                    TarAcelTextBox0.BackColor = Color.OrangeRed
                End If
            Catch ex As Exception
                TarAcelTextBox0.BackColor = Color.DarkRed
            End Try
        End If
    End Sub
    Private Sub TarAcelTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TarAcelTextBox1.TextChanged
        If Not String.Equals(TarAcelTextBox1.Text, "") Then
            Try
                Dim Acel As Double = TarAcelTextBox1.Text
                If Acel >= device.motors(1).AccelerationMin And Acel <= device.motors(1).AccelerationMax Then
                    device.motors(1).Acceleration = TarAcelTextBox1.Text
                    AcelTextBox1.Text = device.motors(1).Acceleration
                    TarAcelTextBox1.BackColor = Color.White
                Else
                    TarAcelTextBox1.BackColor = Color.OrangeRed
                End If
            Catch ex As Exception
                TarAcelTextBox1.BackColor = Color.DarkRed
            End Try
        End If
    End Sub

    Public Sub New(ByVal newDevice As Phidgets.MotorControl)
        InitializeComponent()

        mySerialNumber = newDevice.SerialNumber
        Me.Text = mySerialNumber.ToString() + " | " + newDevice.Name
        newDevice.open(mySerialNumber, mainWindow.HostnameTextBox.Text)
        Me.Show()
    End Sub

    Private Sub Attach(ByVal sender As Object, ByVal e As Phidgets.Events.AttachEventArgs) Handles device.Attach
        TarAcelTextBox0.Text = device.motors(0).AccelerationMax.ToString()
        TarAcelTextBox1.Text = device.motors(1).AccelerationMax.ToString()

        TargetVelocityTextBox0.Text = device.motors(0).Velocity.ToString()
        TargetVelocityTextBox1.Text = device.motors(1).Velocity.ToString()

        CurrentTextBox0.Text = device.motors(0).Current.ToString()
        CurrentTextBox1.Text = device.motors(1).Current.ToString()

        VelocityTextBox0.Text = device.motors(0).Velocity.ToString()
        VelocityTextBox1.Text = device.motors(1).Velocity.ToString()
    End Sub

    Public Sub Quit()
        deviceManager.RemoveDevice(mySerialNumber)

        Dim i As Integer
        If device.Attached = True Then
            For i = 0 To device.motors.Count - 1
                device.motors(i).Velocity = 0
            Next
        End If

        RemoveHandler device.CurrentChange, AddressOf CurrentChange
        RemoveHandler device.VelocityChange, AddressOf VelocityChange

        device.close()
        Me.Close()
    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Quit()
    End Sub
End Class