Public Class FormData

    Private origin As String()
    Private currentType As Tables.DATA_TYPE
    Private resultControl As Control

    Public Sub setData(ByVal data As String(), ByVal type As Tables.DATA_TYPE, ByVal resultCtrl As Control)
        For Each s As String In data
            If Not type = DATA_TYPE.TEMPLATE1 And Not type = DATA_TYPE.ITEMS1 Then
                listContent.Items.Add(s)
            End If
            origin = data
        Next
        currentType = type
        resultControl = resultCtrl
    End Sub

    Public Sub setData(ByVal data As String(), ByVal type As Tables.DATA_TYPE)
        For Each s As String In data
            If Not type = DATA_TYPE.TEMPLATE1 And Not type = DATA_TYPE.ITEMS1 Then
                listContent.Items.Add(s)
            End If
            origin = data
        Next
        currentType = type
    End Sub

    Private Sub txtFilter_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFilter.TextChanged
        If txtFilter.Text.Length < 2 Then
            Exit Sub
        End If
        Select Case currentType
            Case DATA_TYPE.FACTIONS
                updateFactions()
            Case DATA_TYPE.TEMPLATE1
                updateTemplate1()
            Case DATA_TYPE.ITEMS1
                updateTemplate1()
            Case DATA_TYPE.EXTCOST
                updateExtendedCost()
        End Select
    End Sub

    Sub updateExtendedCost()
        listContent.BeginUpdate()
        listContent.Items.Clear()
        If (txtFilter.Text = "") Then
            For Each s As String In origin
                listContent.Items.Add(s)
            Next
            listContent.EndUpdate()
            Return
        End If

        Dim temp As String()
        temp = origin.Clone()

        For Each s As String In origin
            If s.ToLower.Contains(txtFilter.Text.ToLower) Then
                listContent.Items.Add(s)
            End If
        Next
        listContent.EndUpdate()
    End Sub

    Sub updateFactions()
        listContent.BeginUpdate()
        listContent.Items.Clear()
        If (txtFilter.Text = "") Then
            For Each s As String In origin
                listContent.Items.Add(s)
            Next
            listContent.EndUpdate()
            Return
        End If

        Dim temp As String()
        temp = origin.Clone()

        For Each s As String In origin
            If s.ToLower.Contains(txtFilter.Text.ToLower) Then
                listContent.Items.Add(s)
            End If
        Next
        listContent.EndUpdate()
    End Sub

    Sub updateTemplate1()
        listContent.BeginUpdate()
        listContent.Items.Clear()
        If (txtFilter.Text = "") Then
            listContent.EndUpdate()
            Return
        End If

        Dim temp As String()
        temp = origin.Clone()

        For Each s As String In origin
            Dim template As String()
            template = s.Split(",")
            If template(1).ToLower.Contains(txtFilter.Text.ToLower) Then
                listContent.Items.Add(template(0) & "," & template(1))
            End If
        Next
        listContent.EndUpdate()
    End Sub

    Sub updateGivenControl()
        Dim s As String() = listContent.Items(listContent.SelectedIndex).split(",")
        If TypeOf resultControl Is NumericUpDown Then
            DirectCast(resultControl, NumericUpDown).Value = Convert.ToUInt64(s(0))
        ElseIf TypeOf resultControl Is TextBox Then
            DirectCast(resultControl, TextBox).Text = Convert.ToUInt64(s(0))
        End If
    End Sub

    Private Sub listContent_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listContent.DoubleClick
        If currentType = DATA_TYPE.TEMPLATE1 Then

            Dim temp As String()
            temp = origin.Clone()
            Dim creature As String() = {""}

            For Each s As String In origin
                Dim template As String()
                template = s.Split(",")
                If template(0) = listContent.Items(listContent.SelectedIndex).ToString.Split(",")(0) Then
                    creature = template
                    Exit For
                End If
            Next
            If creature(0) = "" Then
                Return
            End If

            Dim row1, row2, row3 As String
            row1 = "ID: " + creature(0) + vbCrLf + "Name: " + creature(1) + vbCrLf + "Subname: " + creature(2) + vbCrLf
            row2 = "Models: " + creature(3) + ", " + creature(4) + ", " + creature(5) + ", " + creature(6) + vbCrLf
            row3 = "Faction: " + creature(7)

            Details.Show()
            Details.RichTextBox1.Text = row1 + row2 + row3
        End If

        If currentType = DATA_TYPE.ITEMS1 Then
            updateGivenControl()
        End If

        If currentType = DATA_TYPE.EXTCOST Then
            updateGivenControl()
        End If

        If currentType = DATA_TYPE.FACTIONS Then
            updateGivenControl()
        End If
    End Sub
End Class