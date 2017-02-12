Imports System.Drawing.Imaging

Public Class ClassRaceMask

    Dim d As New Dictionary(Of PictureBox, Boolean)

    Private Sub ClassRaceMask_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Single_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Human.Click, Dwarf.Click, NE.Click, Gnome.Click, Draenei.Click, Warrior.Click, Warlock.Click, Undead.Click, Troll.Click, Tauren.Click, Shaman.Click, Rogue.Click, Priest.Click, Paladin.Click, Orc.Click, Mage.Click, Hunter.Click, Druid.Click, DK.Click, BE.Click

        If (d.ContainsKey(sender)) Then
            If (d(sender) = False) Then
                d(sender) = True
            Else
                d(sender) = False
            End If
        Else
            d.Add(sender, True)
        End If

        DirectCast(sender, PictureBox).Image = CType(New Bitmap(DirectCast(sender, PictureBox).Width, DirectCast(sender, PictureBox).Height), Image)
        Using bmp As New Bitmap(DirectCast(sender, PictureBox).Width, DirectCast(sender, PictureBox).Height)
            Using g As Graphics = Graphics.FromImage(bmp)
                If (d(sender) = True) Then
                    g.DrawString(ACS.TICK, New Font("Arial", 32, FontStyle.Regular, GraphicsUnit.Pixel, 64), Brushes.Green, 10, 10)
                End If

                DirectCast(sender, PictureBox).Image = CType(bmp.Clone, Image)
            End Using
        End Using
    End Sub

    Private Sub Alliance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Alliance.Click
        d(Human) = False
        Single_Click(Human, New System.EventArgs)
        d(Dwarf) = False
        Single_Click(Dwarf, New System.EventArgs)
        d(NE) = False
        Single_Click(NE, New System.EventArgs)
        d(Gnome) = False
        Single_Click(Gnome, New System.EventArgs)
        d(Draenei) = False
        Single_Click(Draenei, New System.EventArgs)
    End Sub

    Private Sub Horde_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Horde.Click
        d(Orc) = False
        Single_Click(Orc, New System.EventArgs)
        d(Undead) = False
        Single_Click(Undead, New System.EventArgs)
        d(Tauren) = False
        Single_Click(Tauren, New System.EventArgs)
        d(Troll) = False
        Single_Click(Troll, New System.EventArgs)
        d(BE) = False
        Single_Click(BE, New System.EventArgs)
    End Sub

    Private Sub AllClasses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllClasses.Click
        d(Warrior) = False
        Single_Click(Warrior, New System.EventArgs)
        d(Paladin) = False
        Single_Click(Paladin, New System.EventArgs)
        d(DK) = False
        Single_Click(DK, New System.EventArgs)
        d(Priest) = False
        Single_Click(Priest, New System.EventArgs)
        d(Shaman) = False
        Single_Click(Shaman, New System.EventArgs)
        d(Druid) = False
        Single_Click(Druid, New System.EventArgs)
        d(Warlock) = False
        Single_Click(Warlock, New System.EventArgs)
        d(Mage) = False
        Single_Click(Mage, New System.EventArgs)
        d(Rogue) = False
        Single_Click(Rogue, New System.EventArgs)
        d(Hunter) = False
        Single_Click(Hunter, New System.EventArgs)

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim c As Integer = 0
        Dim r As Integer = 0

        For Each p As PictureBox In d.Keys
            For i As Integer = 0 To RACES.Length - 1
                If RACES(i) = p.Tag Then
                    r = r + 2 ^ RACES_MASK(i)
                End If
            Next
            For i As Integer = 0 To CLASSES.Length - 1
                If CLASSES(i) = p.Tag Then
                    c = c + 2 ^ CLASSES_MASK(i)
                End If
            Next
        Next

        If Owner.Name = "QuestForm" Then
            DirectCast(Owner, QuestForm).receiveClassMask(c)
            DirectCast(Owner, QuestForm).receiveRaceMask(r)
            Me.Close()
        End If
    End Sub

    Public Sub setOwner(ByVal f As Form)
        Owner = f
    End Sub

    Public Sub setMasks(ByVal c As Integer, ByVal r As Integer)

        If c = 0 And r = 0 Then
            Exit Sub
        End If

        For Each p As Control In Me.Controls
            If Not TypeOf p Is PictureBox Then
                Continue For
            End If
            For i As Integer = 0 To RACES.Length - 1
                If RACES(i) = p.Tag Then
                    If ((r And 2 ^ RACES_MASK(i)) <> 0) Then
                        Single_Click(p, New System.EventArgs)
                    End If
                End If
            Next
            For i As Integer = 0 To CLASSES.Length - 1
                If CLASSES(i) = p.Tag Then
                    If ((c And 2 ^ CLASSES_MASK(i)) <> 0) Then
                        Single_Click(p, New System.EventArgs)
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class