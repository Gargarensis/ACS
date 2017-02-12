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
        currentQuest.setItemRewards(New Dictionary(Of Int64, Int32))
        currentQuest.setItemChoiceRewards(New Dictionary(Of Int64, Int32))
        currentQuest.setFactionRewards(New Dictionary(Of Int64, Int32))
        currentQuest.setCreatureReq(New Dictionary(Of Int64, Int32))
        currentQuest.setItemReq(New Dictionary(Of Int64, Int32))
        currentQuest.setFactionReq(New Dictionary(Of Int64, Int32))

        Dim objs() As String = {"", "", "", ""}
        currentQuest.setObjectivesOverride(objs)

        Dim otherRewards(3) As Int64
        currentQuest.setOtherRewards(otherRewards)
    End Sub

    Private Function getBasicInfo() As Int64()
        Dim result(8) As Int64
        result(0) = Me.numId.Value
        result(1) = Me.numNextQuest.Value
        result(2) = Me.numPrevQuest.Value
        result(3) = Me.numZone.Value
        result(4) = Me.numLevel.Value
        result(5) = Me.numMinLevel.Value
        result(6) = Me.numMaxLevel.Value
        result(7) = Me.numExperience.Value

        Return result
    End Function

    Public Sub drawQuest()
        Me.questDisplay.Image = CType(New Bitmap(questDisplay.Width, questDisplay.Height), Image)
        Using bmp As New Bitmap(questDisplay.Width, questDisplay.Height)
            Using g As Graphics = Graphics.FromImage(bmp)

                For Each v As Control In questDisplay.Controls
                    questDisplay.Controls.Remove(v)
                Next

                g.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit
                g.CompositingQuality = Drawing2D.CompositingQuality.HighQuality

                g.DrawLine(Pens.Black, 0, POINT_QUEST_TITLE.Y, questDisplay.Width, POINT_QUEST_TITLE.Y)
                g.DrawLine(Pens.Black, 0, POINT_QUEST_OBJ.Y, questDisplay.Width, POINT_QUEST_OBJ.Y)
                g.DrawLine(Pens.Black, 0, POINT_QUEST_DESC_BOLD.Y, questDisplay.Width, POINT_QUEST_DESC_BOLD.Y)
                g.DrawLine(Pens.Black, 0, POINT_QUEST_REWARDS_BOLD.Y, questDisplay.Width, POINT_QUEST_REWARDS_BOLD.Y)

                g.DrawString(currentQuest.getQuestDetail(0), FONT_MORPHEUS, Brushes.Black, POINT_QUEST_TITLE)
                g.DrawString(currentQuest.getQuestDetail(2), FONT_MONOSPACE, Brushes.Black, POINT_QUEST_OBJ)
                g.DrawString("Description", FONT_MORPHEUS, Brushes.Black, POINT_QUEST_DESC_BOLD)
                g.DrawString(currentQuest.getQuestDetail(1), FONT_MONOSPACE, Brushes.Black, POINT_QUEST_DESCRIPTION)
                g.DrawString("Rewards", FONT_MORPHEUS, Brushes.Black, POINT_QUEST_REWARDS_BOLD)

                g.DrawString(currentQuest.getStringRewards(), FONT_MONOSPACE, Brushes.Black, POINT_QUEST_REWARDS)

                Dim type As rewardType = rewardType.ITEM
                If currentQuest.hasItemRewards() And Not currentQuest.hasItemChoiceRewards() Then
                    type = rewardType.ITEM
                End If
                If Not currentQuest.hasItemRewards() And currentQuest.hasItemChoiceRewards() Then
                    type = rewardType.CHOICE
                End If
                If currentQuest.hasItemRewards() And currentQuest.hasItemChoiceRewards() Then
                    type = rewardType.BOTH
                End If

                For Each c As Control In questDisplay.Controls
                    questDisplay.Controls.Remove(c)
                Next
                drawQuestRewards(type, START_POINT_REWARDS.X, START_POINT_REWARDS.Y)

                g.DrawString(currentQuest.getObjectivesText(), FONT_MONOSPACE, Brushes.Black, POINT_QUEST_OBJ_COUNT)

                questDisplay.Image = CType(bmp.Clone, Image)
            End Using
        End Using
    End Sub

    Private Enum rewardType
        ITEM
        CHOICE
        BOTH
    End Enum

    Private Sub drawQuestRewards(ByVal type As rewardType, ByVal startX As Integer, ByVal startY As Integer)
        Dim l As List(Of Int64) = New List(Of Int64)

        Dim x As Integer = startX
        Dim y As Integer = startY

        If type = rewardType.BOTH Then
            drawQuestRewards(rewardType.ITEM, START_POINT_REWARDS.X, START_POINT_REWARDS.Y)

            Dim countCheck As Integer = 0
            Dim additionalHeight As Integer = 20
            If currentQuest.getItemRewards.Keys.Count <= 2 Then
                additionalHeight = 15
            End If
            For c As Integer = 0 To currentQuest.getItemRewards.Keys.Count - 1
                If c Mod 2 = 0 Then
                    countCheck = countCheck + 1
                End If
            Next
            Dim calculateStart As Integer = START_POINT_REWARDS.Y + (countCheck * ICON_REWARD_SIZE.Height) + additionalHeight

            drawQuestRewards(rewardType.CHOICE, START_POINT_REWARDS.X, calculateStart)
            Exit Sub
        End If

        If type = rewardType.ITEM Then
            l = New List(Of Int64)(currentQuest.getItemRewards().Keys)
        End If

        If type = rewardType.CHOICE Then
            l = New List(Of Int64)(currentQuest.getItemChoiceRewards().Keys)
        End If

        Dim tImage As Bitmap
        Dim i As Integer = 1

        For Each k As Int64 In l
            Try
                Dim url As String = Tables.getItemIconURL(Tables.getItemDisplayNameById(k))
                Dim tClient As Net.WebClient = New Net.WebClient
                tImage = Bitmap.FromStream(New IO.MemoryStream(tClient.DownloadData(url)))
            Catch
                tImage = My.Resources.cross
            End Try

            Dim p As New PictureBox
            p.Image = Tables.ResizeIcon(tImage, ICON_REWARD_SIZE)

            If i Mod 2 = 1 Then
                p.Location = New Point(x, y)
                x = x + Tables.REWARDS_SPACE_LENGTH
            Else
                p.Location = New Point(x, y)
                x = START_POINT_REWARDS.X
                y = y + ICON_REWARD_SIZE.Width
            End If

            p.Name = "img" + type.ToString() + "Reward" & i
            p.Tag = k
            p.Visible = True
            p.Width = ICON_REWARD_SIZE.Width
            p.Height = ICON_REWARD_SIZE.Height
            Me.questDisplay.Controls.Add(p)
            p.BringToFront()
            AddHandler p.MouseUp, AddressOf handleItemRewardClick

            i = i + 1
        Next

    End Sub


    Private Sub handleItemRewardClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = MouseButtons.Right Then

            Dim p As PictureBox = DirectCast(sender, PictureBox)

            If p.Name.ToLower().Contains("item") Then
                Dim temp As Dictionary(Of Int64, Int32) = currentQuest.getItemRewards()
                temp.Remove(p.Tag)
                currentQuest.setItemRewards(temp)
                drawQuest()
            End If

            If DirectCast(sender, PictureBox).Name.ToLower().Contains("choice") Then
                Dim temp As Dictionary(Of Int64, Int32) = currentQuest.getItemChoiceRewards()
                temp.Remove(p.Tag)
                currentQuest.setItemChoiceRewards(temp)
                drawQuest()
            End If


        End If

        If e.Button = MouseButtons.Left Then
            btnRewards.PerformClick()
            If DirectCast(sender, PictureBox).Name.ToLower().Contains("choice") Then
                QuestRewards.TabControl1.SelectedIndex = 1
            End If
        End If

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
        FormData.Show()
        FormData.setData(IO.File.ReadAllLines(ITEM_1_ENTRIES_PATH), DATA_TYPE.ITEMS1, numProvidedId)
    End Sub

    Private Sub numProvidedId_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numProvidedId.ValueChanged
        modifyItem(sender, Me.lblProvidedName, IO.File.ReadAllLines(ITEM_1_ENTRIES_PATH))
    End Sub

    Private Sub questDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles questDisplay.Click
        Dim y As Int32 = DirectCast(e, MouseEventArgs).Y

        Select Case y
            Case 0 To Tables.POINT_QUEST_TITLE.Y
                '

            Case Tables.POINT_QUEST_TITLE.Y To Tables.POINT_QUEST_OBJ.Y
                ' stuff wth title
            Case Tables.POINT_QUEST_OBJ.Y To Tables.POINT_QUEST_DESC_BOLD.Y
                ' stuff with objectives

            Case Tables.POINT_QUEST_DESC_BOLD.Y To Tables.POINT_QUEST_REWARDS_BOLD.Y
                ' stuff with description

            Case Else
                btnRewards.PerformClick()


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

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRewards.Click
        QuestRewards.Show()
        QuestRewards.setOwner(Me)
        QuestRewards.setQuest(currentQuest)
    End Sub

    Public Sub receiveItemRewards(ByVal itemRewards As Dictionary(Of Int64, Int32))
        currentQuest.setItemRewards(itemRewards)
    End Sub
    Public Sub receiveItemChoiceRewards(ByVal itemRewards As Dictionary(Of Int64, Int32))
        currentQuest.setItemChoiceRewards(itemRewards)
    End Sub
    Public Sub receiveOtherRewards(ByVal otherRewards() As Int64)
        currentQuest.setOtherRewards(otherRewards)
    End Sub
    Public Sub receiveItemReq(ByVal itemReq As Dictionary(Of Int64, Int32))
        currentQuest.setItemReq(itemReq)
    End Sub
    Public Sub receiveCreatureReq(ByVal creatureReq As Dictionary(Of Int64, Int32))
        currentQuest.setCreatureReq(creatureReq)
    End Sub
    Public Sub receiveFactionReq(ByVal factionReq As Dictionary(Of Int64, Int32))
        currentQuest.setFactionReq(factionReq)
    End Sub
    Public Sub receiveObjOverride(ByVal obj As String())
        currentQuest.setObjectivesOverride(obj)
    End Sub

    Public Sub receiveFactionRewards(ByVal factionRewards As Dictionary(Of Int64, Int32))
        currentQuest.setFactionRewards(factionRewards)

        Dim l As New List(Of Int64)(factionRewards.Keys)

        For Each c As Control In Me.boxRewards.Controls
            If TypeOf c Is Label Then
                Dim i As Int16 = Convert.ToInt16(c.Name.ToCharArray()(c.Name.Length - 1))
                i = i - 49 ' 48 to get num, -1 for index
                If (i >= factionRewards.Keys.Count Or i < 0) Then
                    Continue For
                End If

                c.Text = factionRewards(l(i)) & " with " & Tables.getFactionNameById(l(i))

                If factionRewards(l(i)) > 0 Then
                    c.ForeColor = Color.Green
                    c.Text = "+" + c.Text
                Else
                    c.ForeColor = Color.Red
                    c.Text = "-" + c.Text
                End If
            End If
        Next
    End Sub

    Private Sub btnRequirements_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRequirements.Click
        QuestRequirements.Show()
        QuestRequirements.setOwner(Me)
        QuestRequirements.setQuest(currentQuest)
    End Sub
End Class