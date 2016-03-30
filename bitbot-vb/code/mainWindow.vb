Imports System.Runtime.InteropServices

Public Class mainWindow
    Public WithEvents phidgetMan As Phidgets.Manager

    ' Custom Error handler
    Public Sub HandleError(ByVal text As String)
        If Not ConsoleActive Then
            AllocConsole()
            Console.Title = "Error! :("
        End If
        Console.WriteLine("Error: " + text)
        Debug.WriteLine("Error: " + text)
    End Sub

    ' Once Form1 loads, createa new Phidget Manager and initiate the DataGridView
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        phidgetMan = New Phidgets.Manager()

        AttachedGrid.ColumnCount = 2
        AttachedGrid.Columns(0).Name = "Device Name"
        AttachedGrid.Columns(0).Width = 40
        AttachedGrid.Columns(0).MinimumWidth = 40
        AttachedGrid.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        AttachedGrid.Columns(1).Name = "Serial No."
        AttachedGrid.Columns(1).Width = 80
        AttachedGrid.Columns(1).MinimumWidth = 80
    End Sub

    Public ConsoleActive As Boolean = False
    <DllImport("kernel32.dll")> Public Shared Function AllocConsole() As Boolean
    End Function
    <DllImport("kernel32.dll")> Public Shared Function FreeConsole() As Boolean
    End Function

    Public Sub Start()
        Debug.WriteLine("New instance")

        ConsoleActive = True
        AllocConsole()

        Console.SetWindowSize(50, 30)
        Console.Title = "My Console"
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("CONSOLE OUTPUT")
        Console.ForegroundColor = ConsoleColor.White

        myCode.OnStartup()
    End Sub

    ' Change color of start button based off if connected or not
    Private Sub phidgetMan_ServerConnect() Handles phidgetMan.ServerConnect
        StartButton.BackColor = Color.DarkGreen
        Start()
    End Sub
    Private Sub phidgetMan_ServerDisconnect() Handles phidgetMan.ServerDisconnect
        StartButton.BackColor = Color.DarkSlateBlue
        Quit()
    End Sub

    ' Add a new row to the DataGridView with info from the new device
    Private Sub phidgetMan_Attach(ByVal sender As Object, ByVal e As Phidgets.Events.AttachEventArgs) Handles phidgetMan.Attach
        subWindow.Create(e.Device)

        Dim newrow() As String = {e.Device.Name, e.Device.SerialNumber.ToString()}
        AttachedGrid.Rows.Add(newrow)
    End Sub

    ' Loop through DataGridView, trying to find the detached serial number, then removing it
    Private Sub phidgetMan_Detach(ByVal sender As Object, ByVal e As Phidgets.Events.DetachEventArgs) Handles phidgetMan.Detach
        Dim row As DataGridViewRow
        For Each row In AttachedGrid.Rows
            If row.Cells(1).Value.Equals(e.Device.SerialNumber.ToString()) Then
                AttachedGrid.Rows.Remove(row)
            End If
        Next
    End Sub

    ' MessageBox popup on an error with the Phidget Manager
    Private Sub phidgetMan_Error(ByVal sender As Object, ByVal e As Phidgets.Events.ErrorEventArgs) Handles phidgetMan.Error
        StartButton.BackColor = Color.Red
        StartButton.Text = "Check Console"
        Beep()
        HandleError(e.Description)
    End Sub

    ' Open the Phidget manager on the chosen IP addressart
    Private Sub StartButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartButton.Click
        StartButton.BackColor = Color.DarkSlateBlue
        StartButton.Text = "Connecting..."
        phidgetMan.open(IPTextBox.Text, 5001)
    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Quit()
    End Sub

    ' Safely close the Phidget Manager, then the window itself
    Public Sub Quit()
        myCode.OnClosing()
        ConsoleActive = False
        FreeConsole()

        RemoveHandler phidgetMan.Attach, AddressOf phidgetMan_Attach
        RemoveHandler phidgetMan.Detach, AddressOf phidgetMan_Detach
        RemoveHandler phidgetMan.Error, AddressOf phidgetMan_Error
        phidgetMan.close()

        Application.DoEvents()
        Me.Close()
    End Sub

    Private Sub specialButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles specialButton.Click
        specialWindow.Show()
    End Sub
End Class
