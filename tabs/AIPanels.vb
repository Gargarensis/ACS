Public Class AIPanels

    Private typeId As Int64
    Private source() As String
    Private dData As New Dictionary(Of Integer, Integer)

    Public Sub New(ByVal data As AI_TYPE)
        InitializeComponent() ' do not remove

        Select Case data
            Case AI_TYPE.ACTION
                source = IO.File.ReadAllLines(SAI_EVENT_DATA)

            Case AI_TYPE.REACTION
                source = IO.File.ReadAllLines(SAI_ACTION_DATA)

            Case AI_TYPE.TARGET
                'stuff

        End Select

        generateDictionary()

    End Sub

    Private Sub generateDictionary()
        For i As Integer = 0 To source.Length - 1
            Dim temp As String() = source(i).Split(",")

            If IsNumeric(temp(0)) Then
                dData.Add(Convert.ToInt32(temp(0)), i)
            End If

        Next
    End Sub

    Public Sub changeTypeValue(ByVal id As Int64)
        typeId = id
        refreshForm()
    End Sub

    Private Sub refreshForm()
        Dim s As String() = source(dData(typeId)).Split(",")
        lblDescription.Text = s(2)
        Dim start As Integer = dData(typeId) + 1
        Dim i As Integer = 0

        aiPanel.Controls.Clear()

        For Each x As Control In Me.Controls
            If TypeOf x Is Label And Not x.Name = "lblDescription" Then
                x.Visible = False
            End If
        Next

        While Not IsNumeric(source(start).Split(",")(0))
            Dim temp As String() = source(start).Split(",")
            renderControl(temp(0), i)
            fixLabel(temp(1), temp(2), i + 1)
            i = i + 1
            start = start + 1
            If start >= source.Length Then
                Exit While
            End If
        End While

    End Sub

    Private Sub renderControl(ByVal type As String, ByVal number As Integer)
        Dim control As Control = New TextBox
        Select Case type
            Case = "txt"
                control = New TextBox
            Case = "num"
                control = New NumericUpDown
                DirectCast(control, NumericUpDown).Maximum = 2 ^ 32
                DirectCast(control, NumericUpDown).Minimum = -2 ^ 32

            Case = "bool"
                renderBool(number)
                Exit Sub
        End Select

        aiPanel.Controls.Add(control)
        control.Name = type & "Param" & (number + 1)
        control.Size = New Size(aiPanel.Width - 20, control.Height - 5)
        control.Parent = aiPanel
        control.Location = AI_PANEL_POSITIONS(number)
        control.Show()
    End Sub

    Private Sub renderBool(ByVal number As Integer)
        Dim cZero As New RadioButton
        Dim cOne As New RadioButton

        aiPanel.Controls.Add(cZero)
        aiPanel.Controls.Add(cOne)

        cZero.Parent = aiPanel
        cOne.Parent = aiPanel

        cZero.Name = "cZero"
        cZero.Text = "0"
        cOne.Name = "cOne"
        cOne.Text = "1"

        cZero.Size = New Size(30, cZero.Size.Height)
        cZero.Location = AI_PANEL_POSITIONS(number)
        cZero.Checked = True
        cZero.Show()

        cOne.Size = New Size(30, cOne.Size.Height)
        cOne.Location = New Point(AI_PANEL_POSITIONS(number).X + 40, AI_PANEL_POSITIONS(number).Y)
        cOne.Checked = False
        cOne.Show()
    End Sub

    Private Sub fixLabel(ByVal description As String, ByVal link As String, ByVal number As Integer)
        Dim lbl As Label = CType(Me.Controls("lblParam" & number.ToString()), Label)

        lbl.Text = description
        If AI_AVAILABLE_LINKS_LIST.Contains(link) Then
            lbl.ForeColor = Color.Blue
            lbl.Font = New Font(lbl.Font, FontStyle.Underline)
            lbl.Tag = link
            AddHandler lbl.Click, AddressOf linkClickHandler
        Else
            lbl.ForeColor = Color.Black
            lbl.Font = New Font(lbl.Font, FontStyle.Regular)
            RemoveHandler lbl.Click, AddressOf linkClickHandler
        End If
        lbl.Visible = True
    End Sub

    Private Sub linkClickHandler(sender As Object, e As EventArgs)
        If Not TypeOf sender Is Label Then
            Exit Sub
        End If

        Dim lbl As Label = DirectCast(sender, Label)

        If lbl.ForeColor = Color.Black Then
            Exit Sub
        End If

        Dim number As String = lbl.Name.Chars(lbl.Name.Length - 1)
        Dim receiver As NumericUpDown = CType(aiPanel.Controls("numParam" & number.ToString()), NumericUpDown)

        Dim cZero As New RadioButton
        cZero.Checked = True
        Dim cOne As RadioButton

        If aiPanel.Controls.ContainsKey("cZero") And aiPanel.Controls.ContainsKey("cOne") Then
            cZero = CType(aiPanel.Controls("cZero"), RadioButton)
            cOne = CType(aiPanel.Controls("cOne"), RadioButton)
        End If


        Select Case lbl.Tag
            Case = "FACTION"
                FormData.Show()
                FormData.setData(IO.File.ReadAllLines(Tables.FACTION_ENTRIES_PATH), DATA_TYPE.FACTIONS, receiver)
            Case = "ENTRY"
                FormData.Show()
                FormData.setData(IO.File.ReadAllLines(Tables.CREATURE_TEMPLATE_1_ENTRIES_PATH), DATA_TYPE.CREATURE_NAME, receiver)
            Case = "MODEL"
                FormData.Show()
                FormData.setData(IO.File.ReadAllLines(Tables.CREATURE_TEMPLATE_1_ENTRIES_PATH), DATA_TYPE.CREATURE_MODELS, receiver)
            Case = "SOUND"
                Dim audioF As New AudioForm
                audioF.setReceiver(receiver)
                audioF.ShowDialog()
            Case = "EMOTE"
                FormData.Show()
                FormData.setData(IO.File.ReadAllLines(Tables.EMOTES_ENTRIES_PATH), DATA_TYPE.EMOTES, receiver)
            Case = "SPELL"
                FormData.Show()
                FormData.setData(IO.File.ReadAllLines(Tables.SPELL_ENTRIES_PATH), DATA_TYPE.SPELL, receiver)
            Case = "SPELL_FLAG"
                FormData.Show()
                FormData.setData(IO.File.ReadAllLines(Tables.CAST_FLAG_ENTRIES_PATH), DATA_TYPE.CAST_FLAG, receiver)
            Case = "SUMMON_TYPE"
                FormData.Show()
                FormData.setData(IO.File.ReadAllLines(Tables.SUMMON_TYPES_PATH), DATA_TYPE.SUMMON_TYPES, receiver)
            Case = "FLAG_1_OR_0"
                FormData.Show()
                If cZero.Checked Then
                    FormData.setData(IO.File.ReadAllLines(Tables.CREATURE_FLAG_PATH), DATA_TYPE.CREATURE_FLAGS, receiver)
                Else
                    FormData.setData(IO.File.ReadAllLines(Tables.CREATURE_FLAG_2_PATH), DATA_TYPE.CREATURE_FLAGS, receiver)
                End If

            Case = "QUEST"
                FormData.Show()
                FormData.setData(IO.File.ReadAllLines(Tables.QUEST_ENTRIES_PATH), DATA_TYPE.QUEST_ENTRIES, receiver)
            Case = "NPC_FLAG"
                FormData.Show()
                FormData.setData(IO.File.ReadAllLines(Tables.NPC_FLAGS_PATH), DATA_TYPE.NPC_FLAGS, receiver)
            Case = "DYNAMIC_FLAG"
                FormData.Show()
                FormData.setData(IO.File.ReadAllLines(Tables.DYNAMIC_FLAG_PATH), DATA_TYPE.CREATURE_FLAGS, receiver)
            Case = "EQUIP_MASK"
                FormData.Show()
                FormData.setData(IO.File.ReadAllLines(Tables.EQUIP_MASK_ENTRIES_PATH), DATA_TYPE.EQUIP_MASK, receiver)
            Case = "MOVIE"
                MsgBox("Not available right now :(")
            Case = "WAYPOINTS"
            Case = "CREATURE_TEXTS"
            Case = "LINK"
            Case = "GOSSIP_MENU"
            Case = "GOSSIP_ITEM"
            Case = "GO_ENTRY"
            Case Else
                MsgBox("Unhandled link! " & lbl.Tag)
        End Select
    End Sub
End Class