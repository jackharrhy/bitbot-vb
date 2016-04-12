Public Class customMotor
    Public myDevice As New Phidgets.MotorControl

    Private inputArray As CheckBox()
    Private encoderArray As TextBox()
    Private sensorArray As TextBox()

    Public Sub CurrentChange(ByVal sender As Object, ByVal e As Phidgets.Events.CurrentChangeEventArgs)
        CurrentTextBox0.Text = myDevice.motors(0).Current
        CurrentTextBox1.Text = myDevice.motors(1).Current
    End Sub

    Public Sub VelocityChange(ByVal sender As Object, ByVal e As Phidgets.Events.VelocityChangeEventArgs)
        VelocityTextBox0.Text = myDevice.motors(0).Velocity
        VelocityTextBox1.Text = myDevice.motors(1).Velocity
    End Sub
    Private Sub TargetVelocityTextBox0_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TargetVelocityTextBox0.TextChanged
        If Not String.Equals(TargetVelocityTextBox0.Text, "") Then
            Try
                Dim TarVel As Double = TargetVelocityTextBox0.Text
                myDevice.motors(0).Velocity = TarVel
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
                myDevice.motors(1).Velocity = TarVel
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
                If Acel >= myDevice.motors(0).AccelerationMin And Acel <= myDevice.motors(0).AccelerationMax Then
                    myDevice.motors(0).Acceleration = TarAcelTextBox0.Text
                    AcelTextBox0.Text = myDevice.motors(0).Acceleration
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
                If Acel >= myDevice.motors(1).AccelerationMin And Acel <= myDevice.motors(1).AccelerationMax Then
                    myDevice.motors(1).Acceleration = TarAcelTextBox1.Text
                    AcelTextBox1.Text = myDevice.motors(1).Acceleration
                    TarAcelTextBox1.BackColor = Color.White
                Else
                    TarAcelTextBox1.BackColor = Color.OrangeRed
                End If
            Catch ex As Exception
                TarAcelTextBox1.BackColor = Color.DarkRed
            End Try
        End If
    End Sub

    Public Sub New(ByRef newDevice As Phidgets.MotorControl)
        InitializeComponent()

        myDevice = newDevice

        AddHandler myDevice.Attach, AddressOf Attach
        AddHandler myDevice.Detach, AddressOf Detach
        AddHandler myDevice.CurrentChange, AddressOf CurrentChange

        Me.Text = newDevice.ToString() + " | " + newDevice.Name
        Me.Show()
    End Sub

    Private Sub Attach(ByVal sender As Object, ByVal e As Phidgets.Events.AttachEventArgs)
        TarAcelTextBox0.Text = myDevice.motors(0).AccelerationMax.ToString()
        TarAcelTextBox1.Text = myDevice.motors(1).AccelerationMax.ToString()

        TargetVelocityTextBox0.Text = myDevice.motors(0).Velocity.ToString()
        TargetVelocityTextBox1.Text = myDevice.motors(1).Velocity.ToString()

        CurrentTextBox0.Text = myDevice.motors(0).Current.ToString()
        CurrentTextBox1.Text = myDevice.motors(1).Current.ToString()

        VelocityTextBox0.Text = myDevice.motors(0).Velocity.ToString()
        VelocityTextBox1.Text = myDevice.motors(1).Velocity.ToString()
    End Sub
    Private Sub Detach(ByVal sender As Object, ByVal e As Phidgets.Events.DetachEventArgs)
        RemoveHandler myDevice.Attach, AddressOf Attach
        RemoveHandler myDevice.Detach, AddressOf Detach
        RemoveHandler myDevice.CurrentChange, AddressOf CurrentChange
    End Sub

    Private Sub customMotor_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim i As Integer
        If myDevice.Attached = True Then
            For i = 0 To myDevice.motors.Count - 1
                myDevice.motors(i).Velocity = 0
            Next
        End If

        RemoveHandler myDevice.CurrentChange, AddressOf CurrentChange
        RemoveHandler myDevice.VelocityChange, AddressOf VelocityChange

        myDevice.close()
    End Sub
End Class