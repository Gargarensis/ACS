Public Class VendorItem
    Inherits Item

    Protected extendedCostId As Int32
    Protected extendedCostString As String

    Public Sub New(ByVal id As Int64, ByVal cost As Int64)
        MyBase.New(id)
        setExtCost(cost)
    End Sub


    Public Sub setExtCost(ByVal cost As Int32)
        Me.extendedCostId = cost
        If Not extendedCostId = 0 And Not extendedCostId = vbNull Then
            For Each s As String In IO.File.ReadAllLines(EXTENDED_COST_ENTRIES_PATH)
                If Convert.ToUInt64(s.Split(",")(0)) = extendedCostId Then
                    Dim space As String = "          "
                    For Each x As Char In s.Split(",")(0)
                        space = space.Remove(0, 2)
                    Next
                    extendedCostString = extendedCostString + space + s.Split(New Char() {","}, 2)(1)
                    Exit For
                Else
                    extendedCostString = extendedCostId
                End If
            Next
        Else
            extendedCostString = "Gold"
        End If
    End Sub

    Public Function getExtCostId() As Int32
        Return Me.extendedCostId
    End Function

    Public Function getExtCostString() As String
        Return Me.extendedCostString
    End Function

    Public Overrides Function toString() As String
        Return id.ToString() + vbTab + name + vbTab + extendedCostString
    End Function

End Class
