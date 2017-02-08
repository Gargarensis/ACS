Public Class Item

    Protected id As Int64
    Protected name As String

    Public Sub New(ByVal id As Int64)
        setId(id)
    End Sub

    Private Sub updateName()
        For Each s As String In IO.File.ReadAllLines(ITEM_1_ENTRIES_PATH)
            Try
                If Convert.ToUInt64(s.Split(",")(0)) = id Then
                    name = s.Split(",")(1)
                    Exit Sub
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next
        name = ERR_ITEM_NOT_FOUND
    End Sub

    Public Sub setId(ByVal id As Int64)
        Me.id = id
        updateName()
    End Sub

    Public Function getId() As Int64
        Return Me.id
    End Function

    Public Function getName() As String
        Return Me.name
    End Function

    Public Overrides Function toString() As String
        Return "Item id: " & id
    End Function

End Class
