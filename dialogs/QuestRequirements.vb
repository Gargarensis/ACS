Public Class QuestRequirements

    Dim dItemNumLbl As New Dictionary(Of NumericUpDown, Label)
    Dim dItemLblNum As New Dictionary(Of Label, NumericUpDown)
    Dim dCreatureNumLbl As New Dictionary(Of NumericUpDown, Label)
    Dim dCreatureLblNum As New Dictionary(Of Label, NumericUpDown)
    Dim currentQuest As Quest
    Dim dItemBoxes As New Dictionary(Of NumericUpDown, NumericUpDown)
    Dim dCreatureBoxes As New Dictionary(Of NumericUpDown, NumericUpDown)
    Dim dFactionBoxes As New Dictionary(Of NumericUpDown, NumericUpDown)
    Dim textBoxes() As TextBox

    Private Enum TABS
        TAB_CREATURE
        TAB_ITEM
        TAB_FACTION
        OBJ_OVERRIDE
    End Enum

    Private Sub initializeDictionaries()
        dItemNumLbl.Add(Me.numItemId1, lblItemName1)
        dItemNumLbl.Add(Me.numItemId2, lblItemName2)
        dItemNumLbl.Add(Me.numItemId3, lblItemName3)
        dItemNumLbl.Add(Me.numItemId4, lblItemName4)
        dItemNumLbl.Add(Me.numitemId5, lblItemName5)
        dItemNumLbl.Add(Me.numitemId6, lblItemName6)

        dItemLblNum.Add(Me.lblItemId1, numItemId1)
        dItemLblNum.Add(Me.lblItemId2, numItemId2)
        dItemLblNum.Add(Me.lblItemId3, numItemId3)
        dItemLblNum.Add(Me.lblItemId4, numItemId4)
        dItemLblNum.Add(Me.lblItemId5, numitemId5)
        dItemLblNum.Add(Me.lblItemId6, numitemId6)

        dItemNumLbl.Add(Me.numCreature1, lblCreatureName1)
        dItemNumLbl.Add(Me.numCreature2, lblCreatureName2)
        dItemNumLbl.Add(Me.numCreature3, lblCreatureName3)
        dItemNumLbl.Add(Me.numCreature4, lblCreatureName4)

        dItemLblNum.Add(Me.lblCreatureId1, numCreature1)
        dItemLblNum.Add(Me.lblCreatureId2, numCreature2)
        dItemLblNum.Add(Me.lblCreatureId3, numCreature3)
        dItemLblNum.Add(Me.lblCreatureId4, numCreature4)

        dItemNumLbl.Add(Me.numFaction1, Me.lblFactionName1)
        dItemNumLbl.Add(Me.numFaction2, lblFactionName2)

        dItemLblNum.Add(Me.lblFactionID1, numFaction1)
        dItemLblNum.Add(Me.lblFactionID2, numFaction2)

        dItemBoxes.Add(Me.numItemId1, Me.numCount1)
        dItemBoxes.Add(Me.numItemId2, Me.numCount2)
        dItemBoxes.Add(Me.numItemId3, Me.numCount3)
        dItemBoxes.Add(Me.numItemId4, Me.numCount4)
        dItemBoxes.Add(Me.numitemId5, Me.numCount5)
        dItemBoxes.Add(Me.numitemId6, Me.numCount6)

        dCreatureBoxes.Add(Me.numCreature1, Me.numCreatureCount1)
        dCreatureBoxes.Add(Me.numCreature2, Me.numCreatureCount2)
        dCreatureBoxes.Add(Me.numCreature3, Me.numCreatureCount3)
        dCreatureBoxes.Add(Me.numCreature4, Me.numCreatureCount4)

        dFactionBoxes.Add(Me.numFaction1, Me.numFactionValue1)
        dFactionBoxes.Add(Me.numFaction2, Me.numFactionValue2)

        Dim temp() As TextBox = {Me.txtObj1, Me.txtObj2, Me.txtObj3, Me.txtObj4}
        textBoxes = temp

    End Sub

    Private Sub lblItemId_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblItemId1.Click, lblItemId2.Click, lblItemId3.Click, lblItemId4.Click, lblItemId5.Click, lblItemId6.Click
        FormData.Show()
        FormData.setData(IO.File.ReadAllLines(ITEM_1_ENTRIES_PATH), DATA_TYPE.ITEMS1, dItemLblNum(sender))
    End Sub

    Private Sub QuestRequirements_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initializeDictionaries()
    End Sub

    Private Sub lblCreatureId_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCreatureId4.Click, lblCreatureId3.Click, lblCreatureId2.Click, lblCreatureId1.Click
        FormData.Show()
        FormData.setData(IO.File.ReadAllLines(Tables.CREATURE_TEMPLATE_1_ENTRIES_PATH), DATA_TYPE.CREATURE_NAME, dItemLblNum(sender))
    End Sub

    Private Sub numCreature_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numCreature4.ValueChanged, numCreature3.ValueChanged, numCreature2.ValueChanged, numCreature1.ValueChanged
        modifyItem(sender, dItemNumLbl(sender), IO.File.ReadAllLines(CREATURE_TEMPLATE_1_ENTRIES_PATH))
    End Sub

    Private Sub numItemId_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numitemId6.ValueChanged, numitemId5.ValueChanged, numItemId4.ValueChanged, numItemId3.ValueChanged, numItemId2.ValueChanged, numItemId1.ValueChanged
        modifyItem(sender, dItemNumLbl(sender), IO.File.ReadAllLines(ITEM_1_ENTRIES_PATH))
    End Sub

    Private Sub lblFactionID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFactionID2.Click, lblFactionID1.Click
        FormData.Show()
        FormData.setData(IO.File.ReadAllLines(FACTION_ENTRIES_PATH), DATA_TYPE.FACTIONS, dItemLblNum(sender))
    End Sub

    Private Sub numFaction_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numFaction2.ValueChanged, numFaction1.ValueChanged
        modifyItem(sender, dItemNumLbl(sender), IO.File.ReadAllLines(FACTION_ENTRIES_PATH))
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim creatureReq As New Dictionary(Of Int64, Int32)
        Dim itemReq As New Dictionary(Of Int64, Int32)
        Dim factionReq As New Dictionary(Of Int64, Int32)
        Dim objOverride() As String = {txtObj1.Text, txtObj2.Text, txtObj3.Text, txtObj4.Text}

        ' dItemBoxes

        saveField(creatureReq, TABS.TAB_CREATURE)
        saveField(itemReq, TABS.TAB_ITEM)
        saveField(factionReq, TABS.TAB_FACTION)


        If Owner.Name = "QuestForm" Then
            DirectCast(Owner, QuestForm).receiveCreatureReq(creatureReq)
            DirectCast(Owner, QuestForm).receiveItemReq(itemReq)
            DirectCast(Owner, QuestForm).receiveFactionReq(factionReq)
            DirectCast(Owner, QuestForm).receiveObjOverride(objOverride)
            DirectCast(Owner, QuestForm).drawQuest()
            Me.Close()
        End If
    End Sub

    Private Sub compileField(ByVal d As Dictionary(Of Int64, Int32), ByVal tabEnum As TABS)
        Dim keys As New List(Of Int64)(d.Keys)

        Dim num As List(Of NumericUpDown)
        Dim numCount As List(Of NumericUpDown)

        Select Case tabEnum
            Case TABS.TAB_ITEM
                num = New List(Of NumericUpDown)(Me.dItemBoxes.Keys)
                numCount = New List(Of NumericUpDown)(Me.dItemBoxes.Values)
            Case TABS.TAB_CREATURE
                num = New List(Of NumericUpDown)(Me.dCreatureBoxes.Keys)
                numCount = New List(Of NumericUpDown)(Me.dCreatureBoxes.Values)
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

    Private Sub saveField(ByVal d As Dictionary(Of Int64, Int32), ByVal t As TABS)
        Dim keys As New List(Of Int64)(d.Keys)

        Dim num As List(Of NumericUpDown)
        Dim numCount As List(Of NumericUpDown)

        Select Case t
            Case TABS.TAB_ITEM
                num = New List(Of NumericUpDown)(Me.dItemBoxes.Keys)
                numCount = New List(Of NumericUpDown)(Me.dItemBoxes.Values)
            Case TABS.TAB_CREATURE
                num = New List(Of NumericUpDown)(Me.dCreatureBoxes.Keys)
                numCount = New List(Of NumericUpDown)(Me.dCreatureBoxes.Values)
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

    Public Sub setOwner(ByVal f As Form)
        Owner = f
    End Sub

    Public Sub setQuest(ByVal q As Quest)
        currentQuest = q

        Dim creatureReq As Dictionary(Of Int64, Int32) = q.getCreatureReq()
        Dim itemReq As Dictionary(Of Int64, Int32) = q.getItemReq()
        Dim factionReq As Dictionary(Of Int64, Int32) = q.getFactionReq()

        compileField(creatureReq, TABS.TAB_CREATURE)
        compileField(itemReq, TABS.TAB_ITEM)
        compileField(factionReq, TABS.TAB_FACTION)

        For i As Integer = 0 To q.getObjectivesOverride().Length - 1
            textBoxes(i).Text = q.getObjectivesOverride()(i)
        Next

    End Sub
End Class