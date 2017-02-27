Imports IrrKlang

Public Class AudioForm
    Dim engine As New ISoundEngine()

    Private Structure Sound

        Public id, type As Int64
        Public name, fileName, path As String

        Public Overrides Function ToString() As String

            Return id.ToString() + "," + name
        End Function

    End Structure

    Dim listOfSound As New List(Of Sound)

    Private Sub txtFilter_TextChanged(sender As Object, e As EventArgs) Handles txtFilter.TextChanged, ComboBox1.SelectedIndexChanged
        If txtFilter.Text.Length < 1 Then
            Exit Sub
        End If

        listContent.BeginUpdate()
        listContent.Items.Clear()
        If (txtFilter.Text = "") Then
            listContent.EndUpdate()
            Return
        End If

        For Each s As Sound In listOfSound

            If s.name.ToLower.Contains(txtFilter.Text.ToLower) Then
                If ComboBox1.SelectedIndex = 0 Then
                    listContent.Items.Add(s)
                Else
                    If ComboBox1.SelectedItem.ToString().Split(",")(0) = s.type.ToString() Then
                        listContent.Items.Add(s)
                    End If
                End If

            End If
        Next
        listContent.EndUpdate()
    End Sub

    Private Sub listContent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listContent.SelectedIndexChanged
        If listContent.SelectedIndex > -1 Then
            Dim name As String = listContent.SelectedItem.ToString().Split(", ")(1)
            Dim succeed As Boolean = downloadSoundIfNotExists(getLink(listContent.SelectedItem), name)
            If succeed Then
                Try
                    engine.StopAllSounds()
                    engine.Play2D(Application.StartupPath + "/sounds/" + name)
                Catch
                    MsgBox("There was an error!")
                End Try
            End If
        End If
    End Sub

    Private Function downloadSoundIfNotExists(ByVal url As String, ByVal name As String) As Boolean

        If IO.File.Exists(Application.StartupPath + "/sounds/" + name) Then
            Return True
        End If

        Try
            My.Computer.Network.DownloadFile(url, Application.StartupPath + "/sounds/" + name)
        Catch e As Exception
            MsgBox("There was an error download the file!" + vbCrLf + e.Message)
            Return False
        End Try

        ' check if the file is correctly created
        If IO.File.Exists(Application.StartupPath + "/sounds/" + name) Then
            Return True
        End If
        Return False
    End Function


    Private Function getLink(ByVal sound As Sound) As String
        Dim result As String = "http://wowimg.zamimg.com/wowsounds/"
        Dim path As String = sound.path.ToLower().Replace("\", "/")
        Dim file As String = sound.fileName.ToLower().Remove(sound.fileName.Length - 4, 4)
        result = result + path + "/" + file + ".ogg"
        Return result
    End Function

    Private Sub AudioForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listOfSound.Clear()
        For Each s As String In IO.File.ReadAllLines(SOUND_ENTRIES_PATH)
            Dim temp As New Sound
            temp.id = Convert.ToInt64(s.Split(",")(0))
            temp.type = Convert.ToInt64(s.Split(",")(1))
            temp.name = s.Split(",")(2)
            temp.fileName = s.Split(",")(3)
            temp.path = s.Split(",")(4)

            Me.listOfSound.Add(temp)
            timerBrowse.Enabled = True
        Next
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private receiver As NumericUpDown
    Public Sub setReceiver(ByVal r As NumericUpDown)
        receiver = r
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        receiver.Value = DirectCast(listContent.SelectedItem, Sound).id
        Me.Close()
    End Sub

    Private Sub timerBrowse_Tick(sender As Object, e As EventArgs) Handles timerBrowse.Tick
        soundDirectory.Navigate(Application.StartupPath + "/sounds")
        timerBrowse.Enabled = False
    End Sub

    Private Sub AudioForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        engine.StopAllSounds()
        engine.Dispose()
    End Sub
End Class