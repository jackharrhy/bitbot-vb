Public Class customMotor
    ' Subs that get called once things change on the motor controller
    Public Sub CurrentChange(ByVal sender As Object, ByVal e As Phidgets.Events.CurrentChangeEventArgs)
        Debug.WriteLine("Current: " + e.Current.ToString("F3"))
    End Sub
    Public Sub InputChange(ByVal sender As Object, ByVal e As Phidgets.Events.InputChangeEventArgs)
        Debug.WriteLine(e.Value)
    End Sub
    Public Sub VelocityChange(ByVal sender As Object, ByVal e As Phidgets.Events.VelocityChangeEventArgs)
        Debug.WriteLine(e.Velocity.ToString("F2"))
    End Sub
End Class
