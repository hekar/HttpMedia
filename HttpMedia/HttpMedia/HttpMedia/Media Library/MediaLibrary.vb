Public Class MediaLibrary

    ' Libraries for different categories of entertainment
    Private _music As MusicLibrary
    Private _video As VideoLibrary
    Private _picture As PictureLibrary

    Public Sub New()

    End Sub

    Public Function GetMusic() As MusicLibrary
        Return _music
    End Function

    Public Function GetVideo() As VideoLibrary
        Return _video
    End Function

    Public Function GetPicture() As PictureLibrary
        Return _picture
    End Function
End Class
