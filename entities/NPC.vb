Public Class NPC

    Protected id As Int64
    Protected name As String
    Protected modelid(3) As Int64
    Protected subname As String
    Protected faction As Int64
    Protected smartAI As List(Of SmartAIForm)

    Public Sub New(ByVal id As Int64)
        setId(id)
        loadDataFromTable()
        setSmartAI(New List(Of SmartAIForm))
    End Sub

    Public Sub loadDataFromTable()
        For Each l As String In IO.File.ReadAllLines(Tables.CREATURE_TEMPLATE_1_ENTRIES_PATH)
            Dim values() As String = l.Split(",")
            If values(0).ToString() <> id.ToString() Then
                Continue For
            End If
            name = values(1)
            subname = values(2)
            modelid(0) = values(3)
            modelid(1) = values(4)
            modelid(2) = values(5)
            modelid(3) = values(6)
            faction = values(7)
        Next
    End Sub


    Public Sub setId(ByVal id As Int64)
        Me.id = id
    End Sub

    Public Function getId() As Int64
        Return Me.id
    End Function

    Public Function getName() As String
        Return Me.name
    End Function

    Public Sub setName(ByVal newName As String)
        name = newName
    End Sub

    Public Function getSmartAI() As List(Of SmartAIForm)
        Return smartAI
    End Function

    Public Sub setSmartAI(ByVal value As List(Of SmartAIForm))
        smartAI = value
    End Sub

    Public Overrides Function toString() As String
        Return id & vbTab & name
    End Function

End Class
