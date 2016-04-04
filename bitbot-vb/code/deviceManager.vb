Module deviceManager
    Public d As New List(Of Object)()

    Private Function Iterate(ByRef SerialNumber)
        For Each obj In d
            If String.Equals(obj.SerialNumber, SerialNumber) Then
                Return obj
            End If
        Next

        Return False
    End Function

    Public Sub AddNewDevice(ByVal Device)
        Dim newrow() As String = {Device.Name, Device.SerialNumber.ToString()}
        mainWindow.AttachedGrid.Rows.Add(newrow)
        d.Add(Device)

        If String.Equals(Device.Type, "PhidgetInterfaceKit") Then
            Dim w As New customInterface(Device)
        ElseIf String.Equals(Device.Type, "PhidgetMotorControl") Then
            Dim w As New customMotor(Device)
        End If
    End Sub

    Public Sub RemoveDevice(ByRef SerialNumber As Int32)
        Dim row As DataGridViewRow
        For Each row In mainWindow.AttachedGrid.Rows
            If row.Cells(1).Value.Equals(SerialNumber.ToString()) Then
                mainWindow.AttachedGrid.Rows.Remove(row)
            End If
        Next

        For Each obj In d
            If String.Equals(obj.SerialNumber, SerialNumber) Then
                obj = False
            End If
        Next
    End Sub

    Public Sub RemoveAllDevices()
        Dim row As DataGridViewRow
        For Each row In mainWindow.AttachedGrid.Rows
            mainWindow.AttachedGrid.Rows.Remove(row)
        Next

        For Each obj In d
            obj = False
        Next
    End Sub

    Public Function GetDevice(ByRef SerialNumber As Int32)
        Return Iterate(SerialNumber)
    End Function
End Module
