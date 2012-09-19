Imports System.IO
Imports System.IO.MemoryMappedFiles
Imports System.Text
Imports System.Threading

Public Interface IProcConnection
    Sub SendCommand(ByRef command As String)
End Interface

' Sends Commands via a message queue for interprocess communications
Public Class MediaCommander
    Implements IDisposable, IProcConnection

    Private Const kMemoryPath As String = "nTVMemoryMapping.dat"
    Private Const kMemorySize As Integer = 5012

    ' Shared Memory
    Private _memory As MemoryMappedFile
    Private _memorystream As MemoryMappedViewStream

    ' Message Queue for IPCs
    Private _commqueue As New Queue(Of AppCommand)

    ' Shared system semaphore (shared between media application and browser controller)
    Private kSemaphoreName As String = "nTVSemaphore"
    Private _lock As New Mutex

    Private _mediarunner As MediaRunner

    ' Use the media runner for launching the nTV application
    Public Sub New(ByRef mediarunner As MediaRunner)

        Try
            _mediarunner = mediarunner
            _memory = MemoryMappedFile.CreateOrOpen(kMemoryPath, kMemorySize)
            _memorystream = _memory.CreateViewStream()
            ClearMemory()
        Catch ex As IOException
            MessageBox.Show("Failed to Open Memory Mapped File " & kMemoryPath)
        End Try
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
    End Sub

    Private Sub ClearMemory()
        ' Clear the memory stream
        _memorystream.Seek(0, SeekOrigin.Begin)
        While _memorystream.Position <> _memorystream.Capacity - 1
            ' Fill everything with true
            _memorystream.WriteByte(0)
        End While
    End Sub

    Private Sub SendCommand(ByRef comm As AppCommand)
        ' Only send one command at a time
        If Not _lock.WaitOne() Then
            Exit Sub
        End If

        ' Has the memory stream been read?
        Dim isread(4) As Byte

        _memorystream.Seek(12, SeekOrigin.Begin)

        ' Check if the memory stream has been read
        If _memorystream.Read(isread, 0, 4) <> 0 Then
            If Convert.ToInt32(isread(0) + isread(1) + isread(2) + isread(3)) = 0 Then
                ' Quit if it hasn't been read
                '_lock.ReleaseMutex()
                'Exit Sub
            End If
        End If

        Dim command As String = comm.Name

        ' The structure of the message
        Dim version(4) As Byte
        Dim headersize(4) As Byte
        Dim datasize(4) As Byte
        Dim alreadyread(4) As Byte
        ' Command as a null terminated String afterwards

        version(0) = 1
        headersize(0) = 16
        datasize(0) = 0
        alreadyread(0) = 0
        alreadyread(1) = 0
        alreadyread(2) = 0
        alreadyread(3) = 0

        Dim encoder As New ASCIIEncoding()

        ' Count in bytes
        datasize(0) = CType(encoder.GetByteCount(command), Byte)

        _memorystream.Seek(0, SeekOrigin.Begin)

        ' Data is stored in 32 bit integers
        _memorystream.Write(version, 0, 4)
        _memorystream.Write(headersize, 0, 4)
        _memorystream.Write(datasize, 0, 4)
        _memorystream.Write(alreadyread, 0, 4)

        'MessageBox.Show(command)

        ' Write the actual command
        _memorystream.Write(encoder.GetBytes(command), 0, datasize(0))

        ' Write null terminator
        _memorystream.WriteByte(0)

        _lock.ReleaseMutex()
    End Sub

    Public Sub SendCommand(ByRef command As String) _
            Implements IProcConnection.SendCommand

        ' Rule out the start command
        If command = "start" And Not _mediarunner.Running Then
            _mediarunner.StartTMedia()
        Else
            Dim mediacommand As New AppCommand(command)
            SendCommand(mediacommand)
        End If

    End Sub

End Class
