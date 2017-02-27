Public Class Quest

    Private id As Int64
    Private basic() As Int64
    Private flag As Int32
    Private specialFlag As Int32
    Private questType As Int32
    Private races As Int32
    Private classes As Int32
    Private startItem() As Int64
    Private itemRewards As Dictionary(Of Int64, Int32)
    Private itemChoiceRewards As Dictionary(Of Int64, Int32)
    Private factionRewards As Dictionary(Of Int64, Int32)
    Private otherRewards() As Int64 '0 money, 1 honor, 2 arena
    Private creatureReq As Dictionary(Of Int64, Int32)
    Private itemReq As Dictionary(Of Int64, Int32)
    Private factionReq As Dictionary(Of Int64, Int32)
    Private questGivers() As Int64
    Private questTakers() As Int64
    Private questDetails() As String = {"Title", "Quest Description", "Objective Description", "", "", ""}
    Private objectivesOverride() As String = {"", "", "", ""}


    Sub New()
        Dim emptyArray() As Int64 = {}
        Dim startItem() As Int64 = {0L, 0L}

        setBasic(QUEST_BASIC_STARTING_VALUES)
        setFlag(0)
        setSpecialFlag(0)
        setQuestType(0)
        setRaces(0)
        setClasses(0)
        setStartItem(startItem)
        setItemRewards(New Dictionary(Of Int64, Int32))
        setItemChoiceRewards(New Dictionary(Of Int64, Int32))
        setFactionRewards(New Dictionary(Of Int64, Int32))
        setCreatureReq(New Dictionary(Of Int64, Int32))
        setItemReq(New Dictionary(Of Int64, Int32))
        setFactionReq(New Dictionary(Of Int64, Int32))

        setObjectivesOverride(QUEST_OBJS_STARTING_VALUES)


        setQuestGivers(emptyArray)
        setQuestTakers(emptyArray)

        Dim otherRewards As Int64() = {0, 0, 0}
        setOtherRewards(otherRewards)
    End Sub

    'getter
    Public Function getBasic() As Int64()
        Return basic
    End Function
    Public Function getFlag() As Int32
        Return flag
    End Function
    Public Function getSpecialFlag() As Int32
        Return specialFlag
    End Function
    Public Function getQuestType() As Int32
        Return questType
    End Function
    Public Function getRaces() As Int32
        Return races
    End Function
    Public Function getClasses() As Int32
        Return classes
    End Function
    Public Function getStartItem() As Int64()
        Return startItem
    End Function
    Public Function getItemRewards() As Dictionary(Of Int64, Int32)
        Return itemRewards
    End Function
    Public Function getItemChoiceRewards() As Dictionary(Of Int64, Int32)
        Return itemChoiceRewards
    End Function
    Public Function getFactionRewards() As Dictionary(Of Int64, Int32)
        Return factionRewards
    End Function
    Public Function getOtherRewards() As Int64()
        Return otherRewards
    End Function
    Public Function getCreatureReq() As Dictionary(Of Int64, Int32)
        Return creatureReq
    End Function
    Public Function getItemReq() As Dictionary(Of Int64, Int32)
        Return itemReq
    End Function
    Public Function getFactionReq() As Dictionary(Of Int64, Int32)
        Return factionReq
    End Function
    Public Function getQuestGivers() As Int64()
        Return questGivers
    End Function
    Public Function getQuestTakers() As Int64()
        Return questTakers
    End Function
    Public Function getQuestDetail() As String()
        Return questDetails
    End Function
    Public Function getQuestDetailWithLBPlaceholder() As String()
        Dim result(5) As String
        For i As Integer = 0 To questDetails.Length - 1
            result(i) = questDetails(i).Replace(vbCrLf, "$B$B")
        Next
        Return result
    End Function
    Public Function getMoneyReward() As Int64
        Return otherRewards(0)
    End Function
    Public Function getCoinsReward() As Int64()
        Dim result(3) As Int64
        result(0) = Math.Floor(getMoneyReward() / 10000)
        result(1) = Math.Floor(getMoneyReward() / 100) Mod 100
        result(2) = getMoneyReward() Mod 100
        Return result
    End Function
    Public Function getStringRewards() As String
        ' i should rewrite this better
        Dim result As String
        Dim coins As Int64() = getCoinsReward()
        result = "You will receive: " & coins(0) & " gold, " & coins(1) & " silver, " & coins(2) & " copper." & vbCrLf
        Dim i As Integer = 0
        If getItemRewards().Count > 0 Then
            result = result + "You will get the following items: " + vbCrLf
            For Each k As Int64 In getItemRewards().Keys
                result = result + "        " + addSpaceToText("x" & getItemRewards()(k).ToString() & " " & Tables.findItemNameById(k), 125, FONT_MONOSPACE)
                If i = 0 Then
                    i = i + 1
                Else
                    result = result + vbCrLf + vbCrLf

                    i = i - 1
                End If
            Next
        End If

        i = 0
        If Not result.EndsWith(vbCrLf) Then
            result = result + vbCrLf + vbCrLf
        Else
            result.Remove(result.Length - 1, 1)
        End If
        If getItemChoiceRewards().Count > 0 Then
            result = result + "You will choose between one of the following items: " + vbCrLf
            For Each k As Int64 In getItemChoiceRewards().Keys
                result = result + "        " + addSpaceToText("x" & getItemChoiceRewards()(k).ToString() & " " & Tables.findItemNameById(k), 125, FONT_MONOSPACE)
                If i = 0 Then
                    result = result
                    i = i + 1
                Else
                    result = result + vbCrLf + vbCrLf
                    i = i - 1
                End If
            Next
        End If

        If Not getItemChoiceRewards().Count >= 5 Then
            If Not result.EndsWith(vbCrLf) Then
                result = result + vbCrLf + vbCrLf
            Else
                result.Remove(result.Length - 1, 1)
            End If
        Else
            If Not result.EndsWith(vbCrLf) Then
                result = result + vbCrLf + vbCrLf
            End If
        End If

        If getOtherRewards()(1) > 0 Or getOtherRewards()(2) > 0 Then
            result = result + "You will also receive: "
            If getOtherRewards()(1) > 0 Then
                result = result & getOtherRewards()(1) & " honor" + vbTab
            End If
            If getOtherRewards()(2) > 0 Then
                result = result & getOtherRewards()(2) & " arena points"
            End If

        End If

        Return result
    End Function

    Public Function getObjectivesOverride() As String()
        Return objectivesOverride
    End Function

    Public Function getObjectivesText() As String
        Dim result As String = ""
        Dim i As Integer = 0


        For Each c As Int64 In creatureReq.Keys
            If Not objectivesOverride(i) = "" Then
                result = result & objectivesOverride(i) & " 0/" & creatureReq(c) & vbCrLf
            Else
                result = result & Tables.findCreatureNameById(c) & " slain 0/" & creatureReq(c) & vbCrLf
            End If
            i = i + 1
        Next


        For Each item As Int64 In itemReq.Keys
            result = result & Tables.findItemNameById(item) & " 0/" & itemReq(item) & vbCrLf
        Next


        For Each f As Int64 In factionReq.Keys
            result = result & "Reputation with " & Tables.getFactionNameById(f) & " " & factionReq(f) & vbCrLf
        Next

        Return result
    End Function



    'setter
    Public Sub setBasic(ByVal value As Int64())
        basic = value
    End Sub
    Public Sub setFlag(ByVal value As Int32)
        flag = value
    End Sub
    Public Sub setSpecialFlag(ByVal value As Int32)
        specialFlag = value
    End Sub
    Public Sub setQuestType(ByVal value As Int32)
        questType = value
    End Sub
    Public Sub setRaces(ByVal value As Int32)
        races = value
    End Sub
    Public Sub setClasses(ByVal value As Int32)
        classes = value
    End Sub
    Public Sub setStartItem(ByVal value As Int64())
        startItem = value
    End Sub
    Public Sub setItemRewards(ByVal value As Dictionary(Of Int64, Int32))
        itemRewards = value
    End Sub
    Public Sub setItemChoiceRewards(ByVal value As Dictionary(Of Int64, Int32))
        itemChoiceRewards = value
    End Sub
    Public Sub setFactionRewards(ByVal value As Dictionary(Of Int64, Int32))
        factionRewards = value
    End Sub
    Public Sub setOtherRewards(ByVal value As Int64())
        otherRewards = value
    End Sub
    Public Sub setCreatureReq(ByVal value As Dictionary(Of Int64, Int32))
        creatureReq = value
    End Sub
    Public Sub setItemReq(ByVal value As Dictionary(Of Int64, Int32))
        itemReq = value
    End Sub
    Public Sub setFactionReq(ByVal value As Dictionary(Of Int64, Int32))
        factionReq = value
    End Sub
    Public Sub setQuestGivers(ByVal value As Int64())
        questGivers = value
    End Sub
    Public Sub setQuestTakers(ByVal value As Int64())
        questTakers = value
    End Sub
    Public Sub setQuestDetail(ByVal value As String())
        questDetails = value
    End Sub

    Public Sub setObjectivesOverride(ByVal value As String())
        objectivesOverride = value
    End Sub


    ' checks
    Public Function hasItemRewards() As Boolean
        Return getItemRewards().Keys.Count > 0
    End Function
    Public Function hasItemChoiceRewards() As Boolean
        Return getItemChoiceRewards().Keys.Count > 0
    End Function
End Class
