Imports System.IO
Imports System.IO.MemoryMappedFiles
Imports System.Text
Imports System.Threading

' Uses shared memory for now, but switching to Message Queue later
Public Class AppCommandDispatcher
    Implements IDisposable

    Private Const kMemoryPath As String = "nTVMemoryMapping.dat"
    Private Const kMemorySize As Integer = 5012
    Private _commandlisteners As New List(Of IAppCommandListener)
    Private _memory As MemoryMappedFile
    Private _memorystream As MemoryMappedViewStream

    Public Sub New()
        _memory = MemoryMappedFile.CreateOrOpen(kMemoryPath, kMemorySize)
        _memorystream = _memory.CreateViewStream()
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
    End Sub

    Public Sub AddCommandListener(ByRef commandlistener As IAppCommandListener)
        _commandlisteners.Add(commandlistener)
    End Sub

    Public Sub RemoveCommandListener(ByRef commandlistener As IAppCommandListener)
        _commandlisteners.Remove(commandlistener)
    End Sub

    Public Sub SendCommand(ByRef command As String)
        For Each listener As IAppCommandListener In _commandlisteners
            listener.OnCommand(New AppCommand(command))
        Next
    End Sub

    Public Sub CheckForMessage()
        Dim encoder As New ASCIIEncoding()

        Dim version(4) As Byte
        Dim headersize(4) As Byte
        Dim datasize(4) As Byte
        Dim alreadyread(4) As Byte

        _memorystream.Seek(0, SeekOrigin.Begin)

        _memorystream.Read(version, 0, 4)
        _memorystream.Read(headersize, 0, 4)
        _memorystream.Read(datasize, 0, 4)
        _memorystream.Read(alreadyread, 0, 4)

        Dim commandsize As Integer = 2048 '= Convert.ToInt32(datasize(0) + datasize(1) + datasize(2) + datasize(3))
        Dim command(commandsize) As Byte

        _memorystream.Read(command, 0, commandsize)

        Dim commandstring As String = encoder.GetString(command)

        If Not alreadyread(0) Then
            commandstring = commandstring.Replace(" ", "")
            SendCommand(commandstring)

            _memorystream.Seek(0, SeekOrigin.Begin)
            _memorystream.Write(version, 0, 4)
            _memorystream.Write(headersize, 0, 4)

            For i As Integer = 0 To 3
                datasize(i) = 0
                alreadyread(i) = 1
            Next

            _memorystream.Write(datasize, 0, 4)
            _memorystream.Write(alreadyread, 0, 4)
            _memorystream.WriteByte(0)
        End If
    End Sub

End Class
