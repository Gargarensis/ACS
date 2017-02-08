Imports ACS.Tables
Imports System.Drawing.Drawing2D

Public Class QuestForm

    Dim pen1 As New System.Drawing.Pen(Color.Green, 4)
    Dim g As System.Drawing.Graphics
    Dim questXp As New Dictionary(Of Int16, Int64())
    Dim currentQuest As Quest

    Private Sub initializeQuest()
        currentQuest = New Quest()
        currentQuest.setBasic(getBasicInfo())
    End Sub

    Private Function getBasicInfo() As Int64()
        Dim result(7) As Int64
        result(0) = Me.numId.Value
        result(1) = Me.numNextQuest.Value
        result(2) = Me.numPrevQuest.Value
        result(3) = Me.numZone.Value
        result(4) = Me.numLevel.Value
        result(5) = Me.numMinLevel.Value
        result(6) = Me.numMaxLevel.Value

        Return result
    End Function

    Private Sub drawQuest()
        Me.questDisplay.Image = CType(New Bitmap(questDisplay.Width, questDisplay.Height), Image)
        Using bmp As New Bitmap(questDisplay.Width, questDisplay.Height)
            Using g As Graphics = Graphics.FromImage(bmp)
                g.DrawLine(Pens.Black, 0, 81, questDisplay.Width, 81)
                g.DrawLine(Pens.Black, 0, 101, questDisplay.Width, 101)
                g.DrawLine(Pens.Black, 0, 151, questDisplay.Width, 151)
                g.DrawLine(Pens.Black, 0, 281, questDisplay.Width, 281)

                g.DrawString(currentQuest.getQuestDetail(0), FONT_MORPHEUS, Brushes.Black, 20, 80)
                g.DrawString(currentQuest.getQuestDetail(2), FONT_FRIZ, Brushes.Black, 20, 100)
                g.DrawString("Description", FONT_MORPHEUS, Brushes.Black, 20, 150)
                g.DrawString(currentQuest.getQuestDetail(1), FONT_FRIZ, Brushes.Black, 20, 170)
                g.DrawString("Rewards", FONT_MORPHEUS, Brushes.Black, 20, 280)

                questDisplay.Image = CType(bmp.Clone, Image)
            End Using
        End Using
    End Sub

    Private Function stringToIntArray(ByVal start As String(), ByVal initialIndex As Int64) As Int64()
        Dim intArray(start.Length - initialIndex) As Int64
        For i As Int32 = initialIndex To start.Length - 1
            intArray(i - initialIndex) = Int64.Parse(start(i))
        Next
        Return intArray
    End Function

    Private Sub QuestForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ttmgr As New TooltipMgr
        ttmgr.initializeQuestTooltip()

        initializeQuest()

        For Each l As String In IO.File.ReadAllLines(QUEST_XP_ENTRIES_PATH)
            Dim list As String() = l.Split(",")
            Dim intArray() As Int64
            intArray = stringToIntArray(list, 1)
            Dim level As New Int16
            level = Int16.Parse(list(0))
            questXp.Add(level, intArray)
        Next

        drawQuest()
    End Sub

    Private Sub chkRepeatable_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRepeatable.CheckedChanged
        'also 1 in special flag
    End Sub

    Private Sub chkRaid_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRaid.CheckedChanged
        'also coso in type
    End Sub

    Private Sub lblItemStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblItemStart.Click
        FormData.setData(IO.File.ReadAllLines(ITEM_1_ENTRIES_PATH), DATA_TYPE.ITEMS1, numProvidedId)
    End Sub

    Private Sub questDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles questDisplay.Click
        Dim y As Int32 = DirectCast(e, MouseEventArgs).Y

        Select Case y
            Case 0 To 81

            Case 81 To 100
                MsgBox("title")

            Case 101 To 150
                MsgBox("Obj")

            Case 151 To 281
                MsgBox("Description")



        End Select

    End Sub

    Private Sub numExperience_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numExperience.ValueChanged, numLevel.ValueChanged
        Dim level As Int16 = Me.numLevel.Value
        If questXp.ContainsKey(level) Then
            Me.lblExperienceValue.Text = questXp(level)(Me.numExperience.Value) & " experience"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRacesClassMask.Click
        ClassRaceMask.Show()
        ClassRaceMask.setOwner(Me)
        ClassRaceMask.setMasks(currentQuest.getClasses(), currentQuest.getRaces())
    End Sub

    Public Sub receiveClassMask(ByVal value As Integer)
        currentQuest.setClasses(value)
        lblClasses.Text = "Classes mask: " & value
    End Sub

    Public Sub receiveRaceMask(ByVal value As Integer)
        currentQuest.setRaces(value)
        lblRaces.Text = "Races mask: " & value
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        QuestRewards.Show()
    End Sub

    Public Sub receiveItemRewards(ByVal itemRewards As Dictionary(Of Int64, Int32))
        currentQuest.setItemRewards(itemRewards)
        drawRewards()
    End Sub

    Private Sub drawRewards()
        'TODO
    End Sub
End Class