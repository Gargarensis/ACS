Public Class QuestGiverTaker

    Private currentQuest As Quest

    Private Sub lblId_Click(sender As Object, e As EventArgs) Handles lblIdGiver.Click, lblIdTaker.Click
        FormData.Show()
        If TabControl1.SelectedIndex = 0 Then
            FormData.setData(IO.File.ReadAllLines(CREATURE_TEMPLATE_1_ENTRIES_PATH), DATA_TYPE.CREATURE_NAME, Me.numIdGiver)
        ElseIf TabControl1.SelectedIndex = 1 Then
            FormData.setData(IO.File.ReadAllLines(CREATURE_TEMPLATE_1_ENTRIES_PATH), DATA_TYPE.CREATURE_NAME, Me.numIdTaker)
        End If


    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAddGiver.Click, btnAddTaker.Click
        If TabControl1.SelectedIndex = 0 Then ' giver
            If numIdGiver.Value = vbNull Or numIdGiver.Value = 0 Then
                Exit Sub
            End If

            listGiver.Items.Add(New NPC(numIdGiver.Value))

        ElseIf TabControl1.SelectedIndex = 1 Then
            If numIdTaker.Value = vbNull Or numIdTaker.Value = 0 Then
                Exit Sub
            End If

            listTaker.Items.Add(New NPC(numIdTaker.Value))

        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdateGiver.Click, btnUpdateTaker.Click
        If TabControl1.SelectedIndex = 0 Then ' giver
            If listGiver.SelectedItem Is Nothing Then
                Exit Sub
            End If
            If numIdGiver.Value = vbNull Or numIdGiver.Value = 0 Then
                Exit Sub
            End If

            listGiver.Items(listGiver.SelectedIndex) = New NPC(numIdGiver.Value)

        ElseIf TabControl1.SelectedIndex = 1 Then
            If listTaker.SelectedItem Is Nothing Then
                Exit Sub
            End If
            If numIdTaker.Value = vbNull Or numIdTaker.Value = 0 Then
                Exit Sub
            End If

            listTaker.Items(listTaker.SelectedIndex) = New NPC(numIdTaker.Value)

        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemoveGiver.Click, btnRemoveTaker.Click
        If TabControl1.SelectedIndex = 0 Then ' giver
            listGiver.Items.RemoveAt(listGiver.SelectedIndex)

            If listGiver.Items.Count = 0 Then
                btnUpdateGiver.Enabled = False
                btnRemoveGiver.Enabled = False
            End If

        ElseIf TabControl1.SelectedIndex = 1 Then
            listTaker.Items.RemoveAt(listTaker.SelectedIndex)

            If listTaker.Items.Count = 0 Then
                btnUpdateTaker.Enabled = False
                btnRemoveTaker.Enabled = False
            End If

        End If
    End Sub

    Private Sub list_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listGiver.SelectedIndexChanged, listTaker.SelectedIndexChanged
        If sender.SelectedItem Is Nothing Then
            Return
        End If

        If TabControl1.SelectedIndex = 0 Then ' giver
            btnUpdateGiver.Enabled = True
            btnRemoveGiver.Enabled = True

            numIdGiver.Value = DirectCast(sender.SelectedItem, NPC).getId()

        ElseIf TabControl1.SelectedIndex = 1 Then
            btnUpdateTaker.Enabled = True
            btnRemoveTaker.Enabled = True

            numIdTaker.Value = DirectCast(sender.SelectedItem, NPC).getId()
        End If
    End Sub

    Private Sub numId_ValueChanged(sender As Object, e As EventArgs) Handles numIdGiver.ValueChanged, numIdTaker.ValueChanged
        If TabControl1.SelectedIndex = 0 Then ' giver
            modifyItem(sender, lblNameGiver, IO.File.ReadAllLines(Tables.CREATURE_TEMPLATE_1_ENTRIES_PATH))
        ElseIf TabControl1.SelectedIndex = 1 Then
            modifyItem(sender, lblNameTaker, IO.File.ReadAllLines(Tables.CREATURE_TEMPLATE_1_ENTRIES_PATH))
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim givers(listGiver.Items.Count) As Int64
        Dim takers(listTaker.Items.Count) As Int64

        Dim i As Integer = 0
        For Each giver As NPC In listGiver.Items
            givers(i) = giver.getId()
            i = i + 1
        Next

        i = 0
        For Each taker As NPC In listTaker.Items
            takers(i) = taker.getId()
            i = i + 1
        Next

        If Owner.Name = "QuestForm" Then
            DirectCast(Owner, QuestForm).receiveQuestGivers(givers)
            DirectCast(Owner, QuestForm).receiveQuestTakers(takers)
            Me.Close()
        End If

    End Sub

    Public Sub setOwner(ByVal f As Form)
        Owner = f
    End Sub

    Public Sub setQuest(ByVal q As Quest)
        currentQuest = q

        For Each giver As Int64 In q.getQuestGivers()
            If giver = 0 Then
                Continue For
            End If
            listGiver.Items.Add(New NPC(giver))
        Next

        For Each taker As Int64 In q.getQuestTakers()
            If taker = 0 Then
                Continue For
            End If
            listTaker.Items.Add(New NPC(taker))
        Next

    End Sub
End Class