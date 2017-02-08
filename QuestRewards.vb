Public Class QuestRewards

    Dim dItemNumLbl As New Dictionary(Of NumericUpDown, Label)
    Dim dItemLblNum As New Dictionary(Of Label, NumericUpDown)

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
    End Sub

    Private Sub lblItemId_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblItemId1.Click, lblItemId2.Click, lblItemId3.Click, lblItemId4.Click, lblItemChoiceId6.Click, lblItemChoiceId5.Click, lblItemChoiceId4.Click, lblItemChoiceId3.Click, lblItemChoiceId2.Click, lblItemChoiceId1.Click
        FormData.Show()
        FormData.setData(IO.File.ReadAllLines(ITEM_1_ENTRIES_PATH), DATA_TYPE.ITEMS1, dItemLblNum(sender))
    End Sub

    Private Sub numItemId_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numItemId1.ValueChanged, numItemId2.ValueChanged, numItemId3.ValueChanged, numItemId4.ValueChanged, numItemChoice6.ValueChanged, numItemChoice5.ValueChanged, numItemChoice4.ValueChanged, numItemChoice3.ValueChanged, numItemChoice2.ValueChanged, numItemChoice1.ValueChanged
        modifyItem(sender, dItemNumLbl(sender), IO.File.ReadAllLines(ITEM_1_ENTRIES_PATH))
    End Sub

    Private Sub modifyItem(ByVal num As NumericUpDown, ByVal lbl As Label, ByVal source As String())
        For Each s As String In source
            Dim template As String()
            template = s.Split(",")
            If template(0) = num.Value.ToString() Then
                lbl.Text = ACS.TICK & " " & template(1)
                lbl.ForeColor = Color.Green
                Exit Sub
            End If
        Next
        lbl.Text = ACS.ENTRY_NOT_AVAILABLE
        lbl.ForeColor = Color.Red
    End Sub

    Private Sub QuestRewards_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initializeDictionaries()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class