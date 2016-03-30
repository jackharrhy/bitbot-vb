Public Module subWindow
    Public Sub Create(ByVal Device)
        Debug.WriteLine("creating new: " + Device.Type)

        If String.Equals(Device.Type, "PhidgetInterfaceKit") Then
            Dim newWindow As New customInterface(Device)
        End If
    End Sub
End Module