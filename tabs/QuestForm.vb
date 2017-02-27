Imports ACS.Tables
Imports System.Drawing.Drawing2D

Public Class QuestForm

    Dim pen1 As New System.Drawing.Pen(Color.Green, 4)
    Dim g As System.Drawing.Graphics
    Dim questXp As New Dictionary(Of Int16, Int64())
    Dim currentQuest As Quest

    Private Sub initializeQuest()
        currentQuest = New Quest()
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

                'g.DrawLine(Pens.Black, 0, POINT_QUEST_TITLE.Y, questDisplay.Width, POINT_QUEST_TITLE.Y)
                'g.DrawLine(Pens.Black, 0, POINT_QUEST_OBJ.Y, questDisplay.Width, POINT_QUEST_OBJ.Y)
                'g.DrawLine(Pens.Black, 0, POINT_QUEST_DESC_BOLD.Y, questDisplay.Width, POINT_QUEST_DESC_BOLD.Y)
                'g.DrawLine(Pens.Black, 0, POINT_QUEST_REWARDS_BOLD.Y, questDisplay.Width, POINT_QUEST_REWARDS_BOLD.Y)

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


                g.DrawString(checkObjectivesLength(currentQuest.getObjectivesText(), 7), FONT_MONOSPACE, Brushes.Black, POINT_QUEST_OBJ_COUNT)

                questDisplay.Image = CType(bmp.Clone, Image)
            End Using
        End Using
    End Sub

    Private Function checkObjectivesLength(ByVal s As String, ByVal length As Integer) As String
        Dim result As String = ""

        Dim temp As String() = s.Split(vbCrLf)

        If temp.Length - 1 <= length Then
            Return s
        End If

        For i As Integer = 0 To length - 1
            result = result + temp(i)
        Next

        result = result + vbCrLf + "..."

        For c As Integer = 1 To 5
            CType(Me.boxRequirements.Controls("lblObj" & c.ToString()), Label).Text = ""
            Me.boxRequirements.Controls.SetChildIndex(Me.boxRequirements.Controls("lblObj" & c.ToString()), c + 1)
        Next

        Dim j As Integer = 1
        For i As Integer = length To temp.Length - 2
            CType(Me.boxRequirements.Controls("lblObj" & j.ToString()), Label).Text = temp(i)
            j = j + 1
        Next

        Return result
    End Function

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

    Private Sub lblItemStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblItemStart.Click
        FormData.Show()
        FormData.setData(IO.File.ReadAllLines(ITEM_1_ENTRIES_PATH), DATA_TYPE.ITEMS1, numProvidedId)
    End Sub

    Private Sub numProvidedId_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numProvidedId.ValueChanged
        modifyItem(sender, Me.lblProvidedName, IO.File.ReadAllLines(ITEM_1_ENTRIES_PATH))
    End Sub

    Private Sub questDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles questDisplay.Click
        Dim y As Int32 = DirectCast(e, MouseEventArgs).Y

        For Each x As Control In questDisplay.Controls
            If TypeOf x Is TextBox Or TypeOf x Is RichTextBox Then
                questDisplay.Focus()
            End If
        Next

        Select Case y
            Case 0 To POINT_QUEST_TITLE.Y
                ' nothing? (click above title)

            Case Tables.POINT_QUEST_TITLE.Y To POINT_QUEST_OBJ.Y
                editTitle()
            Case Tables.POINT_QUEST_OBJ.Y To POINT_QUEST_DESC_BOLD.Y
                editObj()

            Case Tables.POINT_QUEST_DESC_BOLD.Y To POINT_QUEST_REWARDS_BOLD.Y
                editDescription()

            Case Else
                btnRewards.PerformClick()


        End Select

    End Sub

    Private Sub editTitle()
        Dim t As New TextBox
        t.Name = "txtTitle"
        t.Visible = True
        t.Width = TEXTS_EDITORS_WIDTH
        t.Height = TITLE_EDITOR_HEIGHT
        t.Location = POINT_QUEST_TITLE
        Me.questDisplay.Controls.Add(t)
        t.BringToFront()
        t.Text = currentQuest.getQuestDetail()(0)
        t.Focus()

        AddHandler t.Leave, AddressOf exitEditorAndSave
        AddHandler t.KeyUp, AddressOf exitEditorWithKeyPress ' this also save

    End Sub

    Private Sub editDescription()
        Dim t As New RichTextBox
        Dim loc As New Point(POINT_QUEST_DESC_BOLD.X, POINT_QUEST_DESC_BOLD.Y + 20)

        t.Name = "txtDescription"
        t.Visible = True
        t.Width = TEXTS_EDITORS_WIDTH
        t.Height = POINT_QUEST_REWARDS_BOLD.Y - POINT_QUEST_DESC_BOLD.Y - 20
        t.Location = loc
        Me.questDisplay.Controls.Add(t)
        t.BringToFront()
        t.Text = currentQuest.getQuestDetail()(1)
        t.Focus()

        AddHandler t.Leave, AddressOf exitEditorAndSave
        AddHandler t.KeyUp, AddressOf exitEditorWithKeyPress ' this also save

    End Sub

    Private Sub editObj()
        Dim t As New RichTextBox
        t.Name = "txtObjDesc"
        t.Visible = True
        t.Width = TEXTS_EDITORS_WIDTH
        t.Height = POINT_QUEST_OBJ_COUNT.Y - POINT_QUEST_OBJ.Y - 5
        t.Location = POINT_QUEST_OBJ
        Me.questDisplay.Controls.Add(t)
        t.BringToFront()
        t.Text = currentQuest.getQuestDetail()(2)
        t.Focus()

        AddHandler t.Leave, AddressOf exitEditorAndSave
        AddHandler t.KeyUp, AddressOf exitEditorWithKeyPress ' this also save

    End Sub

    Private Sub exitEditorAndSave(sender As Object, e As EventArgs)
        Dim temp() As String = currentQuest.getQuestDetail()
        If TypeOf sender Is TextBox Then
            temp(0) = DirectCast(sender, TextBox).Text
        ElseIf TypeOf sender Is RichTextBox Then
            If DirectCast(sender, RichTextBox).Name = "txtObjDesc" Then
                temp(2) = DirectCast(sender, RichTextBox).Text
            Else
                temp(1) = DirectCast(sender, RichTextBox).Text
            End If
        End If
        Me.questDisplay.Controls.Remove(sender)
        sender = Nothing
        currentQuest.setQuestDetail(temp)
        drawQuest()
    End Sub

    Private Sub exitEditorWithKeyPress(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Escape Then
            exitEditorAndSave(sender, e)
        End If
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

    Public Sub receiveQuestGivers(ByVal givers As Int64())
        currentQuest.setQuestGivers(givers)
        listGivers.Items.Clear()
        For Each x As Int64 In givers
            If x <> 0 Then
                listGivers.Items.Add(x)
            End If
        Next
    End Sub

    Public Sub receiveQuestTexts(ByVal texts As String())
        currentQuest.setQuestDetail(texts)
        drawQuest()
    End Sub

    Public Sub receiveQuestTakers(ByVal takers As Int64())
        currentQuest.setQuestTakers(takers)
        listTakers.Items.Clear()
        For Each x As Int64 In takers
            If x <> 0 Then
                listTakers.Items.Add(x)
            End If
        Next
    End Sub

    Private Sub btnRequirements_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRequirements.Click
        QuestRequirements.Show()
        QuestRequirements.setOwner(Me)
        QuestRequirements.setQuest(currentQuest)
    End Sub

    Private Sub lblObj5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblObj5.Click, lblObj4.Click, lblObj3.Click, lblObj2.Click, lblObj1.Click
        MsgBox(CType(sender, Label).Size.Height.ToString())
        CType(sender, Label).BringToFront()
    End Sub

    Private Sub lblZone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblZone.Click
        FormData.Show()
        FormData.setData(IO.File.ReadAllLines(Tables.QUEST_SORTID_PATH), DATA_TYPE.SORTID, numZone)
    End Sub

    Private Sub numZone_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numZone.ValueChanged
        modifyItem(sender, lblSortIdName, IO.File.ReadAllLines(Tables.QUEST_SORTID_PATH))
    End Sub

    Private Sub btnAddGiver_Click(sender As Object, e As EventArgs) Handles btnAddGiver.Click
        QuestGiverTaker.Show()
        QuestGiverTaker.setOwner(Me)
        QuestGiverTaker.setQuest(currentQuest)
    End Sub

    Private Sub btnAddTaker_Click(sender As Object, e As EventArgs) Handles btnAddTaker.Click
        QuestGiverTaker.Show()
        QuestGiverTaker.setOwner(Me)
        QuestGiverTaker.setQuest(currentQuest)
        QuestGiverTaker.TabControl1.SelectedIndex = 1
    End Sub

    Private Sub btnText_Click(sender As Object, e As EventArgs) Handles btnText.Click
        QuestTexts.Show()
        QuestTexts.setOwner(Me)
        QuestTexts.setQuest(currentQuest)
    End Sub

    Public Sub changeFlag(ByVal value As Int64, ByVal sender As CheckBox)
        If sender.Checked Then
            currentQuest.setFlag(currentQuest.getFlag() And value)
        Else
            currentQuest.setFlag(currentQuest.getFlag() And Not value)
        End If
    End Sub

    Private Sub chkShare_CheckedChanged(sender As Object, e As EventArgs) Handles chkShare.CheckedChanged
        changeFlag(QUEST_SHARABLE_FLAG, sender)
    End Sub

    Private Sub chkRaid_CheckedChanged(sender As Object, e As EventArgs) Handles chkRaid.CheckedChanged
        changeFlag(QUEST_RAID_FLAG, sender)
        If chkRaid.Checked Then
            currentQuest.setQuestType(41)
        Else
            currentQuest.setQuestType(0)
        End If
    End Sub

    Private Sub chkRepeatable_CheckedChanged(sender As Object, e As EventArgs) Handles chkRepeatable.CheckedChanged
        changeFlag(QUEST_REPEATABLE_FLAG, sender)
        If chkRepeatable.Checked Then
            currentQuest.setSpecialFlag(1)
        Else
            currentQuest.setSpecialFlag(0)
        End If
    End Sub

    Private Sub chkDaily_CheckedChanged(sender As Object, e As EventArgs) Handles chkDaily.CheckedChanged
        changeFlag(QUEST_DAILY_FLAG, sender)
    End Sub

    Private Sub chkWeekly_CheckedChanged(sender As Object, e As EventArgs) Handles chkWeekly.CheckedChanged
        changeFlag(QUEST_WEEKLY_FLAG, sender)
    End Sub


    Private Sub btnSQL_Click(sender As Object, e As EventArgs) Handles btnSQL.Click
        Details.Show()
        Details.Size = VENDOR_QUERY_WINDOW_SIZE

        Dim q As Quest = currentQuest

        q.setBasic(Me.getBasicInfo())

        Dim dfactionsReq As New Dictionary(Of Int64, Int32)(q.getFactionReq())
        Dim dcreatureReq As New Dictionary(Of Int64, Int32)(q.getCreatureReq())
        Dim ditemReq As New Dictionary(Of Int64, Int32)(q.getItemReq())
        Dim dfactionsRew As New Dictionary(Of Int64, Int32)(q.getFactionRewards())
        Dim ditemRew As New Dictionary(Of Int64, Int32)(q.getItemRewards())
        Dim ditemchoiceRew As New Dictionary(Of Int64, Int32)(q.getItemChoiceRewards())

        dfactionsReq.Add(0, 0)
        dcreatureReq.Add(0, 0)
        ditemReq.Add(0, 0)
        dfactionsRew.Add(0, 0)
        ditemRew.Add(0, 0)
        ditemchoiceRew.Add(0, 0)

        Dim factionsReq As New List(Of Int64)(q.getFactionReq().Keys)
        Dim creatureReq As New List(Of Int64)(q.getCreatureReq().Keys)
        Dim itemReq As New List(Of Int64)(q.getItemReq().Keys)
        Dim factionsRew As New List(Of Int64)(q.getFactionRewards().Keys)
        Dim itemRew As New List(Of Int64)(q.getItemRewards().Keys)
        Dim itemchoiceRew As New List(Of Int64)(q.getItemChoiceRewards().Keys)

        While factionsReq.Count < 6
            factionsReq.Add(0)
        End While
        While creatureReq.Count < 6
            creatureReq.Add(0)
        End While
        While itemReq.Count < 6
            itemReq.Add(0)
        End While
        While factionsRew.Count < 6
            factionsRew.Add(0)
        End While
        While itemRew.Count < 6
            itemRew.Add(0)
        End While
        While itemchoiceRew.Count < 6
            itemchoiceRew.Add(0)
        End While

        Dim s As String = String.Format(QUEST_QUERY, numId.Value, numLevel.Value, numMinLevel.Value, numMaxLevel.Value, numZone.Value, q.getQuestType(), q.getClasses(), q.getRaces(), factionsReq(0), factionsReq(1), dfactionsReq(factionsReq(0)), dfactionsReq(factionsReq(1)), numPrevQuest.Value, numNextQuest.Value, numExperience.Value, q.getOtherRewards()(0), q.getOtherRewards()(1), Me.numProvidedId.Value, Me.numProvidedCount.Value, q.getFlag(), q.getSpecialFlag(), q.getOtherRewards()(2), itemRew(0), itemRew(1), itemRew(2), itemRew(3), ditemRew(itemRew(0)), ditemRew(itemRew(1)), ditemRew(itemRew(2)), ditemRew(itemRew(3)),
                                        itemchoiceRew(0), itemchoiceRew(1), itemchoiceRew(2), itemchoiceRew(3), itemchoiceRew(4), itemchoiceRew(5), ditemchoiceRew(itemchoiceRew(0)), ditemchoiceRew(itemchoiceRew(1)), ditemchoiceRew(itemchoiceRew(2)), ditemchoiceRew(itemchoiceRew(3)), ditemchoiceRew(itemchoiceRew(4)), ditemchoiceRew(itemchoiceRew(5)),
                                        factionsRew(0), factionsRew(1), factionsRew(2), factionsRew(3), factionsRew(4), dfactionsRew(factionsRew(0)), dfactionsRew(factionsRew(1)), dfactionsRew(factionsRew(2)), dfactionsRew(factionsRew(3)), dfactionsRew(factionsRew(4)), q.getQuestDetail()(0), q.getQuestDetail()(2), q.getQuestDetail()(1), q.getQuestDetail()(4), q.getQuestDetail()(3), creatureReq(0), creatureReq(1), creatureReq(2), creatureReq(3), dcreatureReq(creatureReq(0)), dcreatureReq(creatureReq(1)), dcreatureReq(creatureReq(2)), dcreatureReq(creatureReq(3)),
                                        itemReq(0), itemReq(1), itemReq(2), itemReq(3), itemReq(4), itemReq(5), ditemReq(itemReq(0)), ditemReq(itemReq(1)), ditemReq(itemReq(2)), ditemReq(itemReq(3)), ditemReq(itemReq(4)), ditemReq(itemReq(5)), q.getObjectivesOverride()(0), q.getObjectivesOverride()(1), q.getObjectivesOverride()(2), q.getObjectivesOverride()(3)) + ";" + vbCrLf
        For Each starter As Int64 In q.getQuestGivers()
            If starter = 0 Then
                Continue For
            End If
            s = s + "-- Creature Starter: " + findCreatureNameById(starter) + vbCrLf + String.Format(QUEST_STARTER_QUERY, starter, q.getBasic()(0)) + vbCrLf
        Next
        For Each ender As Int64 In q.getQuestTakers()
            If ender = 0 Then
                Continue For
            End If
            s = s + "-- Creature Ender: " + findCreatureNameById(ender) + vbCrLf + String.Format(QUEST_ENDER_QUERY, ender, q.getBasic()(0)) + vbCrLf
        Next
        Details.RichTextBox1.Text = s
    End Sub
End Class