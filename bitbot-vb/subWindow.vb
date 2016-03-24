Public Class subWindow1
    Private myDevice

    Public Sub New(ByVal Device)
        InitializeComponent()

        Me.Text = Device.Name

        myDevice = Device
    End Sub

    Private Sub subWindow1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
End Class