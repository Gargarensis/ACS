Public Class QuestTexts

    Dim currentQuest As Quest

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Public Sub setOwner(ByVal f As Form)
        Owner = f
    End Sub

    Public Sub setQuest(ByVal q As Quest)
        currentQuest = q

        Dim temp() As String = q.getQuestDetail()

        Me.txtTitle.Text = temp(0)
        Me.txtDescription.Text = temp(1)
        Me.txtObjDesc.Text = temp(2)
        Me.txtRequest.Text = temp(3)
        Me.txtCompleted.Text = temp(4)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim result(5) As String
        result(0) = txtTitle.Text
        result(1) = txtDescription.Text
        result(2) = txtObjDesc.Text
        result(3) = txtRequest.Text
        result(4) = txtCompleted.Text

        If Owner.Name = "QuestForm" Then
            DirectCast(Owner, QuestForm).receiveQuestTexts(result)
            Me.Close()
        End If
    End Sub
End Class