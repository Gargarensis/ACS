Public Class SmartAIForm
    Private action As Int64
    Private reaction As Int64
    Private target As Int64
    Private actionParameters(4) As Int64
    Private reactionParameters(6) As Int64
    Private targetParameters(7) As Int64
    Private link As Int64
    Private flag As Int64
    Private chance As Int64

    Public Function getAction() As Int64
        Return action
    End Function
    Public Function getReaction() As Int64
        Return reaction
    End Function
    Public Function getTarget() As Int64
        Return target
    End Function
    Public Function getActionParameters() As Int64()
        Return actionParameters
    End Function
    Public Function getReactionParameters() As Int64()
        Return reactionParameters
    End Function
    Public Function getTargetParameters() As Int64()
        Return targetParameters
    End Function
    Public Function getLink() As Int64
        Return link
    End Function
    Public Function getFlag() As Int64
        Return flag
    End Function
    Public Function getChance() As Int64
        Return chance
    End Function

    Public Sub setAction(ByVal value As Int64)
        action = value
    End Sub
    Public Sub setReaction(ByVal value As Int64)
        reaction = value
    End Sub
    Public Sub setTarget(ByVal value As Int64)
        target = value
    End Sub
    Public Sub setActionParameters(ByVal value As Int64())
        actionParameters = value
    End Sub
    Public Sub setReactionParameters(ByVal value As Int64())
        reactionParameters = value
    End Sub
    Public Sub setTargetParameters(ByVal value As Int64())
        targetParameters = value
    End Sub
    Public Sub setLink(ByVal value As Int64)
        link = value
    End Sub
    Public Sub setFlag(ByVal value As Int64)
        flag = value
    End Sub
    Public Sub setChance(ByVal value As Int64)
        chance = value
    End Sub
End Class

Public Structure Reaction
    Public id As Int64
    Public name As String
    Public description As String

    Public Overrides Function toString() As String
        Return id & ", " & description
    End Function

End Structure

Public Structure Action
    Public id As Int64
    Public name As String
    Public description As String

    Public Overrides Function toString() As String
        Return id & ", " & description
    End Function

End Structure

Public Structure Target
    Public id As Int64
    Public name As String
    Public description As String

    Public Overrides Function toString() As String
        Return id & ", " & description
    End Function

End Structure
