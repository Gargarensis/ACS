Public Class QuestRewards

    Dim dItemNumLbl As New Dictionary(Of NumericUpDown, Label)
    Dim dItemLblNum As New Dictionary(Of Label, NumericUpDown)
    Dim currentQuest As Quest
    Dim dItemBoxes As New Dictionary(Of NumericUpDown, NumericUpDown)
    Dim dItemChoiceBoxes As New Dictionary(Of NumericUpDown, NumericUpDown)
    Dim dFactionBoxes As New Dictionary(Of NumericUpDown, NumericUpDown)

    Private Enum TABS
        TAB_ITEM
        TAB_CHOICE
        TAB_FACTION
    End Enum

    Private Sub initializeDictionaries()
        dItemNumLbl.Add(Me.numItemId1, lblItemName1)
        dItemNumLbl.Add(Me.numItemId2, lblItemName2)
        dItemNumLbl.Add(Me.numItemId3, lblItemName3)
        dItemNumLbl.Add(Me.numItemId4, lblItemName4)

        dItemLblNum.Add(Me.lblItemId1, numItemId1)
        dItemLblNum.Add(Me.lblItemId2, numItemId2)
        dItemLblNum.Add(Me.lblItemId3, numItemId3)
        dItemLblNum.Add(Me.lblItemId4, numItemId4)

        dItemNumLbl.Add(Me.numItemChoice1, lblItemChoiceName1)
        dItemNumLbl.Add(Me.numItemChoice2, lblItemChoiceName2)
        dItemNumLbl.Add(Me.numItemChoice3, lblItemChoiceName3)
        dItemNumLbl.Add(Me.numItemChoice4, lblItemChoiceName4)
        dItemNumLbl.Add(Me.numItemChoice5, lblItemChoiceName5)
        dItemNumLbl.Add(Me.numItemChoice6, lblItemChoiceName6)

        dItemLblNum.Add(Me.lblItemChoiceId1, numItemChoice1)
        dItemLblNum.Add(Me.lblItemChoiceId2, numItemChoice2)
        dItemLblNum.Add(Me.lblItemChoiceId3, numItemChoice3)
        dItemLblNum.Add(Me.lblItemChoiceId4, numItemChoice4)
        dItemLblNum.Add(Me.lblItemChoiceId5, numItemChoice5)
        dItemLblNum.Add(Me.lblItemChoiceId6, numItemChoice6)

        dItemNumLbl.Add(Me.numFaction1, Me.lblFactionName1)
        dItemNumLbl.Add(Me.numFaction2, lblFactionName2)
        dItemNumLbl.Add(Me.numFaction3, lblFactionName3)
        dItemNumLbl.Add(Me.numFaction4, lblFactionName4)
        dItemNumLbl.Add(Me.numFaction5, lblFactionName5)

        dItemLblNum.Add(Me.lblFactionID1, numFaction1)
        dItemLblNum.Add(Me.lblFactionID2, numFaction2)
        dItemLblNum.Add(Me.lblFactionID3, numFaction3)
        dItemLblNum.Add(Me.lblFactionID4, numFaction4)
        dItemLblNum.Add(Me.lblFactionID5, numFaction5)


        dItemBoxes.Add(Me.numItemId1, Me.numCount1)
        dItemBoxes.Add(Me.numItemId2, Me.numCount2)
        dItemBoxes.Add(Me.numItemId3, Me.numCount3)
        dItemBoxes.Add(Me.numItemId4, Me.numCount4)

        dItemChoiceBoxes.Add(Me.numItemChoice1, Me.numitemChoiceCount1)
        dItemChoiceBoxes.Add(Me.numItemChoice2, Me.numitemChoiceCount2)
        dItemChoiceBoxes.Add(Me.numItemChoice3, Me.numitemChoiceCount3)
        dItemChoiceBoxes.Add(Me.numItemChoice4, Me.numitemChoiceCount4)
        dItemChoiceBoxes.Add(Me.numItemChoice5, Me.numitemChoiceCount5)
        dItemChoiceBoxes.Add(Me.numItemChoice6, Me.numitemChoiceCount6)

        dFactionBoxes.Add(Me.numFaction1, Me.numFactionValue1)
        dFactionBoxes.Add(Me.numFaction2, Me.numFactionValue2)
        dFactionBoxes.Add(Me.numFaction3, Me.numFactionValue3)
        dFactionBoxes.Add(Me.numFaction4, Me.numFactionValue4)
        dFactionBoxes.Add(Me.numFaction5, Me.numFactionValue5)


    End Sub

    Private Sub lblItemId_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblItemId1.Click, lblItemId2.Click, lblItemId3.Click, lblItemId4.Click, lblItemChoiceId6.Click, lblItemChoiceId5.Click, lblItemChoiceId4.Click, lblItemChoiceId3.Click, lblItemChoiceId2.Click, lblItemChoiceId1.Click
        FormData.Show()
        FormData.setData(IO.File.ReadAllLines(ITEM_1_ENTRIES_PATH), DATA_TYPE.ITEMS1, dItemLblNum(sender))
    End Sub

    Private Sub numItemId_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numItemId1.ValueChanged, numItemId2.ValueChanged, numItemId3.ValueChanged, numItemId4.ValueChanged, numItemChoice6.ValueChanged, numItemChoice5.ValueChanged, numItemChoice4.ValueChanged, numItemChoice3.ValueChanged, numItemChoice2.ValueChanged, numItemChoice1.ValueChanged
        modifyItem(sender, dItemNumLbl(sender), IO.File.ReadAllLines(ITEM_1_ENTRIES_PATH))
    End Sub

    Private Sub QuestRewards_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initializeDictionaries()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub lblFactionID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFactionID5.Click, lblFactionID4.Click, lblFactionID3.Click, lblFactionID2.Click, lblFactionID1.Click
        FormData.Show()
        FormData.setData(IO.File.ReadAllLines(FACTION_ENTRIES_PATH), DATA_TYPE.FACTIONS, dItemLblNum(sender))
    End Sub

    Private Sub numFaction1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numFaction5.ValueChanged, numFaction4.ValueChanged, numFaction3.ValueChanged, numFaction2.ValueChanged, numFaction1.ValueChanged
        modifyItem(sender, dItemNumLbl(sender), IO.File.ReadAllLines(FACTION_ENTRIES_PATH))
    End Sub

    Private Sub numGold_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numGold.ValueChanged
        lblGold.Text = Math.Floor(numGold.Value / 10000) & " gold, " & Math.Floor(numGold.Value / 100) Mod 100 & " silver, " & numGold.Value Mod 100 & " copper."
    End Sub


    Private Sub saveField(ByVal d As Dictionary(Of Int64, Int32), ByVal t As TABS)
        Dim keys As New List(Of Int64)(d.Keys)

        Dim num As List(Of NumericUpDown)
        Dim numCount As List(Of NumericUpDown)

        Select Case t
            Case TABS.TAB_ITEM
                num = New List(Of NumericUpDown)(Me.dItemBoxes.Keys)
                numCount = New List(Of NumericUpDown)(Me.dItemBoxes.Values)
            Case TABS.TAB_CHOICE
                num = New List(Of NumericUpDown)(Me.dItemChoiceBoxes.Keys)
                numCount = New List(Of NumericUpDown)(Me.dItemChoiceBoxes.Values)
            Case TABS.TAB_FACTION
                num = New List(Of NumericUpDown)(Me.dFactionBoxes.Keys)
                numCount = New List(Of NumericUpDown)(Me.dFactionBoxes.Values)
            Case Else
                Exit Sub
        End Select

        For i As Integer = 0 To num.Count - 1
            If Not (d.ContainsKey(num(i).Value)) And Not num(i).Value = 0 Then
                d.Add(num(i).Value, numCount(i).Value)
            End If
        Next
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim itemReward As New Dictionary(Of Int64, Int32)
        Dim itemChoiceReward As New Dictionary(Of Int64, Int32)
        Dim factionReward As New Dictionary(Of Int64, Int32)
        Dim otherReward(3) As Int64

        ' dItemBoxes
        
        saveField(itemReward, TABS.TAB_ITEM)
        saveField(itemChoiceReward, TABS.TAB_CHOICE)
        saveField(factionReward, TABS.TAB_FACTION)

        otherReward(0) = Me.numGold.Value
        otherReward(1) = Me.numHonor.Value
        otherReward(2) = Me.numArena.Value

        If Owner.Name = "QuestForm" Then
            DirectCast(Owner, QuestForm).receiveItemRewards(itemReward)
            DirectCast(Owner, QuestForm).receiveItemChoiceRewards(itemChoiceReward)
            DirectCast(Owner, QuestForm).receiveFactionRewards(factionReward)
            DirectCast(Owner, QuestForm).receiveOtherRewards(otherReward)
            DirectCast(Owner, QuestForm).drawQuest()
            Me.Close()
        End If
    End Sub
    Public Sub setOwner(ByVal f As Form)
        Owner = f
    End Sub
    Public Sub setQuest(ByVal q As Quest)
        currentQuest = q

        Dim itemReward As Dictionary(Of Int64, Int32) = q.getItemRewards()
        Dim itemChoiceReward As Dictionary(Of Int64, Int32) = q.getItemChoiceRewards()
        Dim factionReward As Dictionary(Of Int64, Int32) = q.getFactionRewards()
        Dim otherReward As Int64() = q.getOtherRewards()

        compileField(itemReward, TABS.TAB_ITEM)
        compileField(itemChoiceReward, TABS.TAB_CHOICE)
        compileField(factionReward, TABS.TAB_FACTION)

        Me.numGold.Value = otherReward(0)
        Me.numHonor.Value = otherReward(1)
        Me.numArena.Value = otherReward(2)
    End Sub

    Private Sub compileField(ByVal d As Dictionary(Of Int64, Int32), ByVal tabEnum As TABS)
        Dim keys As New List(Of Int64)(d.Keys)

        Dim num As List(Of NumericUpDown)
        Dim numCount As List(Of NumericUpDown)

        Select Case tabEnum
            Case TABS.TAB_ITEM
                num = New List(Of NumericUpDown)(Me.dItemBoxes.Keys)
                numCount = New List(Of NumericUpDown)(Me.dItemBoxes.Values)
            Case TABS.TAB_CHOICE
                num = New List(Of NumericUpDown)(Me.dItemChoiceBoxes.Keys)
                numCount = New List(Of NumericUpDown)(Me.dItemChoiceBoxes.Values)
            Case TABS.TAB_FACTION
                num = New List(Of NumericUpDown)(Me.dFactionBoxes.Keys)
                numCount = New List(Of NumericUpDown)(Me.dFactionBoxes.Values)
            Case Else
                Exit Sub
        End Select

        For i As Integer = 0 To keys.Count - 1
            Dim k As Int64 = keys(i)
            num(i).Value = k
            numCount(i).Value = d(k)
        Next

    End Sub
End Class