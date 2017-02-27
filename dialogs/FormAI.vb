Public Class FormAI

    Private reactionList As New List(Of Reaction)
    Private actionList As New List(Of Action)
    Private targetList As New List(Of Target)
    Private p1 As New AIPanels(AI_TYPE.REACTION)
    'Private p2 As New AIPanels(AI_TYPE.ACTION)
    'Private p3 As New AIPanels(AI_TYPE.TARGET)

    Private Sub loadReactions()
        reactionList.Clear()
        For Each l As String In IO.File.ReadAllLines(SAI_ACTIONTYPE)
            If l.Split(",")(2) = "1" Then
                Dim temp As New Reaction
                temp.id = l.Split(",")(0)
                temp.name = l.Split(",")(1)
                temp.description = l.Split(",")(3)

                reactionList.Add(temp)
            End If
        Next
    End Sub

    Private Sub loadActions()
        actionList.Clear()
        For Each l As String In IO.File.ReadAllLines(SAI_EVENTTYPE)
            If l.Split(",")(2) = "1" Then
                Dim temp As New Action
                temp.id = l.Split(",")(0)
                temp.name = l.Split(",")(1)
                temp.description = l.Split(",")(3)

                actionList.Add(temp)
            End If
        Next
    End Sub

    Private Sub loadTargets()
        targetList.Clear()
        For Each l As String In IO.File.ReadAllLines(SAI_TARGETTYPE)
            If l.Split(",")(2) = "1" Then
                Dim temp As New Target
                temp.id = l.Split(",")(0)
                temp.name = l.Split(",")(1)
                temp.description = l.Split(",")(3)

                targetList.Add(temp)
            End If
        Next
    End Sub

    Private Sub FormAI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadReactions()
        For Each reaction As Reaction In reactionList
            comboReaction.Items.Add(reaction)
        Next

        loadActions()
        For Each action As Action In actionList
            comboAction.Items.Add(action)
        Next

        loadTargets()
        For Each target As Target In targetList
            comboTarget.Items.Add(target)
        Next
        initializePanels(Panel1, p1)
        'initializePanels(Panel2, p2)
        'initializePanels(Panel3, p3)
    End Sub

    Public Sub initializePanels(ByVal p As Panel, ByVal aip As AIPanels)
        Dim tab As Panel = p
        aip.TopLevel = False
        aip.Parent = tab
        tab.Text = "Quest"
        tab.Controls.Add(aip)
        tab.BackColor = aip.BackColor
        aip.Show()
    End Sub

    Private Sub combo_KeyUp(sender As Object, e As KeyEventArgs) Handles comboReaction.KeyUp, comboAction.KeyUp, comboTarget.KeyUp
        Dim index As Integer
        Dim actual As String
        Dim found As String

        If ((e.KeyCode = Keys.Back) Or
            (e.KeyCode = Keys.Left) Or
            (e.KeyCode = Keys.Right) Or
            (e.KeyCode = Keys.Up) Or
            (e.KeyCode = Keys.Delete) Or
            (e.KeyCode = Keys.Down) Or
            (e.KeyCode = Keys.PageUp) Or
            (e.KeyCode = Keys.PageDown) Or
            (e.KeyCode = Keys.Home) Or
            (e.KeyCode = Keys.End)) Then

            Return
        End If

        If Not TypeOf sender Is ComboBox Then
            Return
        End If

        Dim send As ComboBox = DirectCast(sender, ComboBox)

        actual = send.Text
        index = send.FindString(actual)

        If (index > -1) Then
            found = send.Items(index).ToString()
            send.SelectedIndex = index

            send.SelectionStart = actual.Length
            send.SelectionLength = found.Length
        End If
    End Sub

    Public Sub forceComboboxSelection(item As Object)
        Dim combobox As ComboBox = comboReaction
        If TypeOf item Is Reaction Then
            combobox = comboReaction
        End If
        If TypeOf item Is Action Then
            combobox = comboAction
        End If
        If TypeOf item Is Target Then
            combobox = comboTarget
        End If
        combobox.SelectedIndex = combobox.Items.IndexOf(item)
    End Sub

    Private Sub comboReaction_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboReaction.SelectedIndexChanged
        p1.changeTypeValue(Convert.ToInt64(comboReaction.Text.Split(",")(0)))
    End Sub
End Class