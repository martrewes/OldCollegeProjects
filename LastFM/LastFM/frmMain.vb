Imports LastFmLib.TypeClasses
Imports System.IO


Public Class frmMain
    Dim stream As String
    Dim speech As String = """"

    Dim DW As System.IO.File
    Dim TW As System.IO.TextWriter






    'Change this if you want to. Will disable (nearly) all the message boxes.
    Const DISABLE_WARNINGS As Boolean = True

    'The user for the client
    Dim m_user As LastFmUser

    'The client itself
    Dim m_client As LastFmLib.LastFmClient

    'The playlist
    Dim m_playlist As LastFmLib.Radio.RadioPlaylist

    'For storing track information
    Dim m_trackMetaData As MetaData
    '*************************************
    'As some functions are only available if you download the track, this is for (async)
    'downloading. Tracks will be saved to Application.UserAppDataPath.
    'Each track will be deleted after "playing" it. If you, for some reason,
    'do not want that, just comment out the "CleanMP3CacheFolder" in clsTrackDownloader: l. 178


    Private Sub btnButLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnButLogin.Click
        Dim F2 As New frmLogin()
        F2.ShowDialog()
        'Generate the password md5
        Dim passhash As String = LastFmLib.GenerateHash(frmLogin.Pass.Text)

        m_user = New LastFmUser(frmLogin.User.Text, passhash)
        m_client = New LastFmLib.LastFmClient(m_user)

        'Change the Text of the login button
        btnButLogin.Text = "Logging in..."
        Application.DoEvents()

        'For storing the Handshake instance of the login
        Dim hs As LastFmLib.WebRequests.Handshake
        'Log in with the client
        hs = m_client.Login()

        If hs.succeeded Then
            'save the username in registry
            SaveSetting(Application.ProductName, "settings", "user", frmLogin.User.Text)
            btnButLogin.Text = "Logged in"
            btnButLogin.Enabled = False
            Application.DoEvents()
            Debug.Print("Logged in.")
        Else
            btnButLogin.BackColor = Color.Red
            btnButLogin.Text = "Login Failed"
        End If
        Dim a As WeightedArtistList = m_user.GetTopListenedArtists(LastFmLib.WebRequests.TopXTimeSpan.None)
    End Sub

    Private Sub btnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        System.IO.File.Delete("\playlist.asx")
        TW = System.IO.File.CreateText("\playlist.asx")

        stream = "lastfm://artist/" & txtArtist.Text & "/similarartists"
        Dim station As Station = m_client.ChangeStation(stream)
        lblStation.Text = stream
        Label1.Enabled = False
        txtArtist.Enabled = False
        btnPlay.Enabled = False
        btnStop.Enabled = True

        If station IsNot Nothing Then
            Debug.Print("Successfully changed station to " & station.Url.ToString & _
                        ". Station name is " & station.Name)
            lblListening.Text = station.Name
            m_playlist = m_client.GetRadioPlaylist()
            TW.WriteLine("<asx version=3.0>")
            TW.WriteLine("  <title>Last.FM Stream</title>")

            Dim n As Integer = 0
            'Print track and download Url to console
            Debug.Print("")
            Debug.Print("-=RadioPlaylist track listing=-")
            Debug.Indent()
            For Each t As TrackInfo In m_client.GetRadioPlaylist.Tracks
                n += 1
                Debug.Print("Track #" & CStr(n) & " in playlist: " & t.ToString)
                TW.WriteLine("")
                TW.WriteLine("  <entry>")
                TW.WriteLine("    <title>" & t.ToString & "</title>")
                Debug.Print("Url: " & t.DownloadUriStrings(0))
                TW.WriteLine("    <ref href=" & speech & t.DownloadUriStrings(0) & speech & " />")
                TW.WriteLine("  </entry>")

                Debug.Print("         ")
            Next
            Debug.Unindent()
            Debug.Print("-=End of RadioPlaylist track listing=-")
        End If
        TW.WriteLine("</asx>")
        TW.Flush()
        TW.Close()
        WMP.URL = "\playlist.asx"

    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        WMP.Ctlcontrols.stop()
        Label1.Enabled = True
        txtArtist.Enabled = True
        btnPlay.Enabled = True
        btnStop.Enabled = False
    End Sub
End Class
