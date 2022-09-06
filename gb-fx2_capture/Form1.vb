Imports System.IO.Ports
Public Class Form1
    Public Event SerialPortDataToProcess(sender As Object, e As SerialPortDataToProcessEventArgs)

    Private S_HEIGHT As Integer = 144
    Private S_WIDTH As Integer = 160
    Private V_PACKSIZE As Integer = 4
    Private S_SIZE As Integer = (S_WIDTH * S_HEIGHT) / V_PACKSIZE
    Private COLORS(4) As Color
    Private screen_buffer(S_SIZE) As Byte

    Private serial_port As SerialPort

    Private color_schemes As List(Of Color())

    Private Sub Close_SerialPort()
        Try
            RemoveHandler serial_port.DataReceived, AddressOf serial_port_DataReceived
            If serial_port.IsOpen Then
                serial_port.DiscardInBuffer()
                serial_port.DiscardOutBuffer()
                serial_port.Close()
            End If
            If serial_port.IsOpen Then
                tsslbl_Status.Text = "Online"
                tstbx_Port.Enabled = False
                tstbx_Baud.Enabled = False
                tsbtn_Connect.Enabled = False
                tsbtn_Disconnect.Enabled = True
            Else
                tsslbl_Status.Text = "Offline"
                tstbx_Port.Enabled = True
                tstbx_Baud.Enabled = True
                tsbtn_Connect.Enabled = True
                tsbtn_Disconnect.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub tsbtn_Connect_Click(sender As Object, e As EventArgs) Handles tsbtn_Connect.Click
        Try
            serial_port = New SerialPort()
            AddHandler serial_port.DataReceived, AddressOf serial_port_DataReceived
            serial_port.PortName = tstbx_Port.Text
            serial_port.BaudRate = tstbx_Baud.Text
            serial_port.DtrEnable = True
            serial_port.Open()
            'bgw_DataReader.RunWorkerAsync()
        Catch ex As Exception
            MsgBox("Couldn't open serial port." & vbCrLf & ex.Message, MsgBoxStyle.Critical)
            If serial_port.IsOpen Then
                serial_port.DiscardInBuffer()
                serial_port.DiscardOutBuffer()
                Close_SerialPort()
            End If
            Return
        End Try
        If serial_port.IsOpen Then
            tsslbl_Status.Text = "Online"
            tstbx_Port.Enabled = False
            tstbx_Baud.Enabled = False
            tsbtn_Connect.Enabled = False
            tsbtn_Disconnect.Enabled = True
        Else
            tsslbl_Status.Text = "Offline"
            tstbx_Port.Enabled = True
            tstbx_Baud.Enabled = True
            tsbtn_Connect.Enabled = True
            tsbtn_Disconnect.Enabled = False
        End If
    End Sub

    Private Sub tsbtn_Disconnect_Click(sender As Object, e As EventArgs) Handles tsbtn_Disconnect.Click
        Close_SerialPort()
    End Sub


    Private Sub serial_port_DataReceived(sender As Object, e As SerialDataReceivedEventArgs)
        Do While serial_port.BytesToRead > 0
            Try
                Dim data_in As Byte = serial_port.ReadByte()
                'Me.Invoke(New EventHandler(AddressOf Process_SerialData))
                RaiseEvent SerialPortDataToProcess(serial_port, New SerialPortDataToProcessEventArgs(data_in))
            Catch ex As Exception
                'Debug.Print("DataReceived: " & ex.Message)
            End Try
        Loop
    End Sub

    Dim x As Integer = 0
    Dim y As Integer = 0
    Dim img_chunk As Integer = 0
    Dim image = New Bitmap(S_WIDTH, S_HEIGHT)
    Private Sub Process_SerialData(ByVal sender As Object, ByVal e As SerialPortDataToProcessEventArgs) Handles Me.SerialPortDataToProcess
        For i As Integer = V_PACKSIZE - 1 To 0 Step -1
            Dim pixeldata As Byte
            pixeldata = e.Data >> (i * 2) And &H3
            'tsslbl_DATA0.Text = pixeldata
            image.SetPixel(x + Math.Abs(((V_PACKSIZE - 1) - i)), y, COLORS(pixeldata))
        Next
        If x < S_WIDTH - V_PACKSIZE - 1 Then
            x += V_PACKSIZE
        Else
            x = 0
            If y < S_HEIGHT - 1 Then
                y += 1
            Else
                y = 0
                Process_Image(image)
            End If
        End If
    End Sub

    Private Sub Process_Image(ByRef image As Image)
        Try
            pbx_Screen.Image = image
        Catch ex As Exception
            tsslbl_xypos.Text = ex.Message
            'Debug.Print(ex.Message)
        End Try

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        color_schemes = New List(Of Color())
        Dim gbcolors(4) As Color
        gbcolors(0) = Color.FromArgb(255, 0, 0, 0)
        gbcolors(1) = Color.FromArgb(255, 85, 85, 85)
        gbcolors(2) = Color.FromArgb(255, 170, 170, 170)
        gbcolors(3) = Color.FromArgb(255, 255, 255, 255)
        Dim gbcolors2(4) As Color
        gbcolors2(0) = Color.FromArgb(255, 15, 56, 15)
        gbcolors2(1) = Color.FromArgb(255, 48, 98, 48)
        gbcolors2(2) = Color.FromArgb(255, 139, 172, 15)
        gbcolors2(3) = Color.FromArgb(255, 155, 188, 15)

        color_schemes.Add(gbcolors)
        color_schemes.Add(gbcolors2)
        ComboBox1.SelectedIndex = 0
        tsbtn_Disconnect.Enabled = False
    End Sub

    Private Sub UpdateColor(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Color0.Click, btn_Color1.Click, btn_Color2.Click, btn_Color3.Click
        If sender IsNot Nothing Then
            Dim opencolordialog As New ColorDialog
            If opencolordialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                sender.BackColor = opencolordialog.Color
            Else
                Return
            End If
        End If
        COLORS(0) = btn_Color0.BackColor
        COLORS(1) = btn_Color1.BackColor
        COLORS(2) = btn_Color2.BackColor
        COLORS(3) = btn_Color3.BackColor
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Close_SerialPort()
        e.Cancel = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        btn_Color0.BackColor = color_schemes(ComboBox1.SelectedIndex)(0)
        btn_Color1.BackColor = color_schemes(ComboBox1.SelectedIndex)(1)
        btn_Color2.BackColor = color_schemes(ComboBox1.SelectedIndex)(2)
        btn_Color3.BackColor = color_schemes(ComboBox1.SelectedIndex)(3)
        UpdateColor(Nothing, Nothing)
    End Sub
End Class

Public Class SerialPortDataToProcessEventArgs
    Inherits EventArgs

    Public Property Data As Byte

    Public Sub New(wData As Byte)
        MyBase.New()
        Me.Data = wData
    End Sub
End Class
