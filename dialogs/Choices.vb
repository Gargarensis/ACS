Public Class Choices

    Private origin As String()
    Private currentType As Tables.DATA_TYPE
    Private resultControl As Control

    Public Sub setData(ByVal data As String(), ByVal type As Tables.DATA_TYPE, ByVal resultCtrl As Control)
        For Each s As String In data
            If Not type = CHOICE_TYPE.ITEMS Then
                ' do stuff
            End If
            origin = data
        Next
        currentType = type
        resultControl = resultCtrl
    End Sub

    Public Sub setData(ByVal data As String(), ByVal type As Tables.DATA_TYPE)
        For Each s As String In data
            If Not type = CHOICE_TYPE.ITEMS Then
                'do stuff
            End If
            origin = data
        Next
        currentType = type
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class