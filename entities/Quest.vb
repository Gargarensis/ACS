Public Class Quest

    Private id As Int64
    Private basic() As Int64
    Private flag As Int32
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
    Private questDetails() As String = {"Title", "Quest Description", "Objective Description", "", "", "", "", "", "", "", "", ""}


    Sub New()

    End Sub

    'getter
    Public Function getBasic() As Int64()
        Return basic
    End Function
    Public Function getFlag() As Int32
        Return flag
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
        Return itemRewards
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
    Public Function getMoneyReward() As Int64
        Return otherRewards(0)
    End Function
    Public Function getStringRewards() As String
        Dim result As String
        result = "You will receive: " + vbCrLf
        Dim i As Integer = 0
        If getItemRewards().Count > 0 Then
            result = result + "You will get the following items: " + vbCrLf
            For Each k As Int64 In getItemRewards().Keys
                result = result + "    " + Tables.findItemNameById(k)
                If i = 0 Then
                    result = result + vbTab + vbTab
                    i = i + 1
                Else
                    result = result + vbCrLf + vbCrLf
                    i = i - 1
                End If
            Next
        End If

        i = 0
        If Not result.EndsWith(vbCrLf) Then
            result = result + vbCrLf
        Else
            result.Remove(result.Length - 1, 1)
        End If
        If getItemChoiceRewards().Count > 0 Then
            result = result + "You will choose between one of the following items: " + vbCrLf
            For Each k As Int64 In getItemChoiceRewards().Keys
                result = result + "    " + Tables.findItemNameById(k)
                If i = 0 Then
                    result = result + vbTab + vbTab
                    i = i + 1
                Else
                    result = result + vbCrLf + vbCrLf
                    i = i - 1
                End If
            Next
        End If

        If Not result.EndsWith(vbCrLf) Then
            result = result + vbCrLf
        Else
            result.Remove(result.Length - 1, 1)
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


    'setter
    Public Sub setBasic(ByVal value As Int64())
        basic = value
    End Sub
    Public Sub setFlag(ByVal value As Int32)
        flag = value
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
        itemRewards = value
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


End Class
