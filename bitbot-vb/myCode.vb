Module myCode
    ' Called once the connection to the PhidgetSBC has been made
    Public Sub OnStartup()
        mainWindow.IPTextBox.Text = "192.168.1.62"
    End Sub

    ' Called once the window closes
    Public Sub OnClosing()

    End Sub
End Module
