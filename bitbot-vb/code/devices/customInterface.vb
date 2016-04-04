﻿Public Class customInterface
    Public WithEvents device As New Phidgets.InterfaceKit
    Private mySerialNumber As Int32

    Private digiInArray As CheckBox()
    Private digiOutArray As CheckBox()
    Private sensorInArray As TextBox()

    Public Sub InputChange(ByVal sender As Object, ByVal e As Phidgets.Events.InputChangeEventArgs) Handles device.InputChange
        digiInArray(e.Index).Checked = e.Value
    End Sub
    Public Sub OutputChange(ByVal sender As Object, ByVal e As Phidgets.Events.OutputChangeEventArgs) Handles device.OutputChange
        digiOutArray(e.Index).Checked = e.Value
    End Sub
    Public Sub SensorChange(ByVal sender As Object, ByVal e As Phidgets.Events.SensorChangeEventArgs) Handles device.SensorChange
        sensorInArray(e.Index).Text = e.Value.ToString()
    End Sub

    Private Sub makeDigiInArray()
        ReDim digiOutArray(15)

        digiOutArray(0) = digitalOut1
        digiOutArray(1) = digitalOut2
        digiOutArray(2) = digitalOut3
        digiOutArray(3) = digitalOut4
        digiOutArray(4) = digitalOut5
        digiOutArray(5) = digitalOut6
        digiOutArray(6) = digitalOut7
        digiOutArray(7) = digitalOut8
        digiOutArray(8) = digitalOut9
        digiOutArray(9) = digitalOut10
        digiOutArray(10) = digitalOut11
        digiOutArray(11) = digitalOut12
        digiOutArray(12) = digitalOut13
        digiOutArray(13) = digitalOut14
        digiOutArray(14) = digitalOut15
        digiOutArray(15) = digitalOut16
    End Sub
    Private Sub ClickOutputs(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim outputIndex As Integer
        Dim outputState As Boolean
        outputIndex = DirectCast(sender, CheckBox).Tag
        outputState = DirectCast(sender, CheckBox).CheckState

        device.outputs(outputIndex) = outputState
    End Sub
    Private Sub makeDigiOutArray()
        ReDim digiInArray(15)

        digiInArray(0) = digitalIn1
        digiInArray(1) = digitalIn2
        digiInArray(2) = digitalIn3
        digiInArray(3) = digitalIn4
        digiInArray(4) = digitalIn5
        digiInArray(5) = digitalIn6
        digiInArray(6) = digitalIn7
        digiInArray(7) = digitalIn8
        digiInArray(8) = digitalIn9
        digiInArray(9) = digitalIn10
        digiInArray(10) = digitalIn11
        digiInArray(11) = digitalIn12
        digiInArray(12) = digitalIn13
        digiInArray(13) = digitalIn14
        digiInArray(14) = digitalIn15
        digiInArray(15) = digitalIn16

        Dim i As Integer
        For i = 0 To 15
            digiInArray(i).Visible = False
        Next i
    End Sub
    Private Sub makeSensorInArray()
        ReDim sensorInArray(7)

        sensorInArray(0) = analogText1
        sensorInArray(1) = analogText2
        sensorInArray(2) = analogText3
        sensorInArray(3) = analogText4
        sensorInArray(4) = analogText5
        sensorInArray(5) = analogText6
        sensorInArray(6) = analogText7
        sensorInArray(7) = analogText8

        Dim i As Integer
        For i = 0 To 7
            sensorInArray(i).Visible = False
        Next i
    End Sub

    Public Sub New(ByVal newDevice As Phidgets.InterfaceKit)
        InitializeComponent()

        makeDigiInArray()
        makeDigiOutArray()
        makeSensorInArray()

        sensitivitySlider.Value = 0
        sensitivitySlider.Enabled = False

        mySerialNumber = newDevice.SerialNumber
        Me.Text = mySerialNumber.ToString() + " | " + newDevice.Name
        newDevice.open(mySerialNumber, mainWindow.HostnameTextBox.Text)
        Me.Show()
    End Sub

    Private Sub Attach(ByVal sender As Object, ByVal e As Phidgets.Events.AttachEventArgs) Handles device.Attach
        Dim i As Integer
        For i = 0 To device.inputs.Count - 1
            digiInArray(i).Visible = True
        Next i

        For i = 0 To device.outputs.Count - 1
            digiOutArray(i).Visible = True
            digiOutArray(i).Enabled = True
        Next i

        For i = 0 To device.sensors.Count - 1
            sensorInArray(i).Visible = True
        Next i

        If device.sensors.Count > 0 Then
            sensitivitySlider.Enabled = True
            sensitivitySlider.SetRange(0, 1000)
            sensitivitySlider.Value = device.sensors(0).Sensitivity

            device.ratiometric = True
            RatiometricButton.BackColor = Color.Green
        End If
    End Sub

    Public Sub Quit()
        If device.Attached Then
            deviceManager.RemoveDevice(device.SerialNumber)
        End If

        RemoveHandler device.InputChange, AddressOf InputChange
        RemoveHandler device.OutputChange, AddressOf OutputChange
        RemoveHandler device.SensorChange, AddressOf SensorChange

        device.close()
        Me.Close()
    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Quit()
    End Sub

    Private Sub RatiometricButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RatiometricButton.Click
        If device.Attached Then
            device.ratiometric = Not device.ratiometric
        End If

        If device.ratiometric Then
            RatiometricButton.BackColor = Color.Green
        Else
            RatiometricButton.BackColor = Color.DarkRed
        End If
    End Sub
End Class