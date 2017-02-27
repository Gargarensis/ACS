<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AudioForm
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.listContent = New System.Windows.Forms.ListBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.soundDirectory = New System.Windows.Forms.WebBrowser()
        Me.timerBrowse = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'listContent
        '
        Me.listContent.FormattingEnabled = True
        Me.listContent.Location = New System.Drawing.Point(12, 89)
        Me.listContent.Name = "listContent"
        Me.listContent.Size = New System.Drawing.Size(329, 303)
        Me.listContent.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"-1, Everything", "0, Unused/Miscellaneous " & Global.Microsoft.VisualBasic.ChrW(9), "1, Spells " & Global.Microsoft.VisualBasic.ChrW(9), "2, UI " & Global.Microsoft.VisualBasic.ChrW(9), "3, Footsteps " & Global.Microsoft.VisualBasic.ChrW(9), "4, Weapons/Impact " & Global.Microsoft.VisualBasic.ChrW(9), "6, Weapons/Miss " & Global.Microsoft.VisualBasic.ChrW(9), "7, Greetings " & Global.Microsoft.VisualBasic.ChrW(9), "8, Casting " & Global.Microsoft.VisualBasic.ChrW(9), "9, Pick Up/Put Down " & Global.Microsoft.VisualBasic.ChrW(9), "10, NPC Combat " & Global.Microsoft.VisualBasic.ChrW(9), "12, Errors " & Global.Microsoft.VisualBasic.ChrW(9), "13, Birds " & Global.Microsoft.VisualBasic.ChrW(9), "14, Objects " & Global.Microsoft.VisualBasic.ChrW(9), "16, Death " & Global.Microsoft.VisualBasic.ChrW(9), "17, NPC Greetings " & Global.Microsoft.VisualBasic.ChrW(9), "18, Test/Temporary " & Global.Microsoft.VisualBasic.ChrW(9), "19, Armor/Foley " & Global.Microsoft.VisualBasic.ChrW(9), "20, Footsteps " & Global.Microsoft.VisualBasic.ChrW(9), "21, Water/Character " & Global.Microsoft.VisualBasic.ChrW(9), "22, Water/Liquid " & Global.Microsoft.VisualBasic.ChrW(9), "23, Tradeskills " & Global.Microsoft.VisualBasic.ChrW(9), "25, Doodads " & Global.Microsoft.VisualBasic.ChrW(9), "26, Spell Fizzle " & Global.Microsoft.VisualBasic.ChrW(9), "27, NPC Loops " & Global.Microsoft.VisualBasic.ChrW(9), "28, Zone Music " & Global.Microsoft.VisualBasic.ChrW(9), "29, Emotes " & Global.Microsoft.VisualBasic.ChrW(9), "30, Narration Music " & Global.Microsoft.VisualBasic.ChrW(9), "31, Narration " & Global.Microsoft.VisualBasic.ChrW(9), "50, Zone Ambience "})
        Me.ComboBox1.Location = New System.Drawing.Point(12, 62)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(201, 21)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.Text = "-1, Everything"
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(12, 23)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(329, 20)
        Me.txtFilter.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Category:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(402, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Current saved sounds:"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(484, 381)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(403, 381)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'soundDirectory
        '
        Me.soundDirectory.Location = New System.Drawing.Point(403, 23)
        Me.soundDirectory.MinimumSize = New System.Drawing.Size(20, 20)
        Me.soundDirectory.Name = "soundDirectory"
        Me.soundDirectory.Size = New System.Drawing.Size(156, 352)
        Me.soundDirectory.TabIndex = 12
        '
        'timerBrowse
        '
        Me.timerBrowse.Interval = 1000
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 406)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(456, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Tip: use canc to move the sound files to the recycle bin, shift+canc to delete th" &
    "em permanently!"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(219, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Zone Music not available :,("
        '
        'AudioForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 428)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.soundDirectory)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFilter)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.listContent)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AudioForm"
        Me.Text = "AudioForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents listContent As ListBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txtFilter As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents soundDirectory As WebBrowser
    Friend WithEvents timerBrowse As Timer
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
