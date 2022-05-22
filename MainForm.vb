Imports System.Xml

Public Class MainForm
    Dim TotalBattles As Integer = 0
    Dim ClanGoldAmount As String = Nothing

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PlayerList.Rows.Clear()
        Dim doc As New XmlDocument
        doc = DownloadAPI("https://api.worldoftanks.eu/wot/clans/info/?application_id=0736c8bb8838d6b17b7e7f29b8a319ee&clan_id=500063884&fields=members.account_id%2Cmembers.account_name")
        Dim count As Integer = 1
        Dim battlesplayed As String = 0
        TotalBattles = 0
        For Each node As XmlNode In doc.ChildNodes(0).ChildNodes(2).ChildNodes(0).ChildNodes
            PlayerID = node.ChildNodes(1).InnerText
            PlayerNickName = node.ChildNodes(0).InnerText
            battlesplayed = GetBattles(PlayerID)
            If battlesplayed <> "" AndAlso CInt(battlesplayed) > 0 Then
                PlayerList.Rows.Add(count, PlayerID, PlayerNickName, battlesplayed)
                TotalBattles += battlesplayed
                count += 1
            End If
        Next
        Dim total_gold_spent As Integer = 0
        Dim gold_per_battle As Integer = CInt(ClanGold.Text) / TotalBattles
        For Each row As DataGridViewRow In PlayerList.Rows
            row.Cells(4).Value = CInt(row.Cells(3).Value) * gold_per_battle
            total_gold_spent += CInt(row.Cells(4).Value)
        Next
        lblGoldPerBattle.Text = "Gold Per Battle: " & gold_per_battle
        lblTotalGoldShare.Text = "Total gold being shared: " & total_gold_spent
    End Sub
End Class
