Imports System.Text
Imports System.Xml
Imports System.Data.SQLite
Imports Newtonsoft.Json
' sort by name
' improve to keep
'add option to select the event

Module helpers
    'battles played

    'https://api.worldoftanks.eu/wot/globalmap/seasonaccountinfo/?application_id=&season_id=season_16&vehicle_level=10&account_id=&fields=seasons.account_id%2Cseasons.battles
    'clan memebers
    'https://api.worldoftanks.eu/wot/clans/info/?application_id=&clan_id=500149882&fields=members.account_id%2Cmembers.account_name
    Public conn As New SQLiteConnection("Data Source=db.db")
    Public cmd As New SQLiteCommand("", conn)
    Public Reader As SQLiteDataReader

    Public ClanID As String = 500149882
    Public PlayerID As String = Nothing
    Public PlayerNickName As String = Nothing
    Public Function DownloadAPI(ByVal Link As String) As XmlDocument
        Dim str As String
        Try

            Using client As New Net.WebClient

                client.Encoding = Encoding.UTF8
                str = client.DownloadString(Link)
            End Using
            DownloadAPI = Json2XML(str)
        Catch ex As Exception
            DownloadAPI = Nothing
            Debug.WriteLine(ex.Message)
        End Try
        Return DownloadAPI
    End Function

    Public Function Json2XML(ByVal json As String) As XmlDocument
        Return JsonConvert.DeserializeXmlNode(json, "Root")
    End Function

    Public Function GetBattles(ByVal id As String) As String
        Dim doc As New XmlDocument
        GetBattles = 0
        Try
            doc = DownloadAPI("https://api.worldoftanks.eu/wot/globalmap/eventaccountinfo/?application_id=0736c8bb8838d6b17b7e7f29b8a319ee&clan_id=500063884&front_id=thunderstorm_bg&event_id=thunderstorm&account_id=" & id & "&fields=events.account_id%2Cevents.battles")
            GetBattles = doc.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes(0).ChildNodes(0).ChildNodes(1).InnerText
            If GetBattles < 5 Then
                GetBattles = 0
            End If
        Catch ex As Exception

        End Try
        Return GetBattles
    End Function
End Module
