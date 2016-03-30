Module deviceManager
    Public d As New List(Of Object)()

    Private Function Iterate(ByVal SerialNumber)
        For Each obj In d
            If String.Equals(obj.SerialNumber, SerialNumber) Then
                Return obj
            End If
        Next

        Return False
    End Function

    Public Sub AddNewDevice(ByVal Device)
        d.Add(Device)
    End Sub

    Public Sub RemoveDevice(ByVal SerialNumber As Int32)
        For Each obj In d
            If String.Equals(obj.SerialNumber, SerialNumber) Then
                obj = Nothing
            End If
        Next
    End Sub

    Public Function GetDevice(ByVal SerialNumber As Int32)
        Return Iterate(SerialNumber)
    End Function
End Module
