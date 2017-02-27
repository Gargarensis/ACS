<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuestTexts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QuestTexts))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabDescription = New System.Windows.Forms.TabPage()
        Me.txtDescription = New System.Windows.Forms.RichTextBox()
        Me.tabObjDesc = New System.Windows.Forms.TabPage()
        Me.txtObjDesc = New System.Windows.Forms.RichTextBox()
        Me.tabTurn = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCompleted = New System.Windows.Forms.RichTextBox()
        Me.txtRequest = New System.Windows.Forms.RichTextBox()
        Me.tabHelp = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tabDescription.SuspendLayout()
        Me.tabObjDesc.SuspendLayout()
        Me.tabTurn.SuspendLayout()
        Me.tabHelp.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabDescription)
        Me.TabControl1.Controls.Add(Me.tabObjDesc)
        Me.TabControl1.Controls.Add(Me.tabTurn)
        Me.TabControl1.Controls.Add(Me.tabHelp)
        Me.TabControl1.Location = New System.Drawing.Point(12, 33)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(319, 279)
        Me.TabControl1.TabIndex = 0
        '
        'tabDescription
        '
        Me.tabDescription.Controls.Add(Me.txtDescription)
        Me.tabDescription.Location = New System.Drawing.Point(4, 22)
        Me.tabDescription.Name = "tabDescription"
        Me.tabDescription.Size = New System.Drawing.Size(311, 253)
        Me.tabDescription.TabIndex = 1
        Me.tabDescription.Text = "Description"
        Me.tabDescription.UseVisualStyleBackColor = True
        '
        'txtDescription
        '
        Me.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDescription.Location = New System.Drawing.Point(0, 0)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(311, 253)
        Me.txtDescription.TabIndex = 0
        Me.txtDescription.Text = ""
        '
        'tabObjDesc
        '
        Me.tabObjDesc.Controls.Add(Me.txtObjDesc)
        Me.tabObjDesc.Location = New System.Drawing.Point(4, 22)
        Me.tabObjDesc.Name = "tabObjDesc"
        Me.tabObjDesc.Size = New System.Drawing.Size(311, 253)
        Me.tabObjDesc.TabIndex = 2
        Me.tabObjDesc.Text = "Obj. Description"
        Me.tabObjDesc.UseVisualStyleBackColor = True
        '
        'txtObjDesc
        '
        Me.txtObjDesc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtObjDesc.Location = New System.Drawing.Point(0, 0)
        Me.txtObjDesc.Name = "txtObjDesc"
        Me.txtObjDesc.Size = New System.Drawing.Size(311, 253)
        Me.txtObjDesc.TabIndex = 1
        Me.txtObjDesc.Text = ""
        '
        'tabTurn
        '
        Me.tabTurn.Controls.Add(Me.Label5)
        Me.tabTurn.Controls.Add(Me.Label4)
        Me.tabTurn.Controls.Add(Me.txtCompleted)
        Me.tabTurn.Controls.Add(Me.txtRequest)
        Me.tabTurn.Location = New System.Drawing.Point(4, 22)
        Me.tabTurn.Name = "tabTurn"
        Me.tabTurn.Size = New System.Drawing.Size(311, 253)
        Me.tabTurn.TabIndex = 3
        Me.tabTurn.Text = "Turn in texts"
        Me.tabTurn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "CompletedText:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "RequestItem:"
        '
        'txtCompleted
        '
        Me.txtCompleted.Location = New System.Drawing.Point(0, 136)
        Me.txtCompleted.Name = "txtCompleted"
        Me.txtCompleted.Size = New System.Drawing.Size(305, 97)
        Me.txtCompleted.TabIndex = 1
        Me.txtCompleted.Text = ""
        '
        'txtRequest
        '
        Me.txtRequest.Location = New System.Drawing.Point(3, 20)
        Me.txtRequest.Name = "txtRequest"
        Me.txtRequest.Size = New System.Drawing.Size(305, 97)
        Me.txtRequest.TabIndex = 1
        Me.txtRequest.Text = ""
        '
        'tabHelp
        '
        Me.tabHelp.Controls.Add(Me.Label3)
        Me.tabHelp.Controls.Add(Me.Label2)
        Me.tabHelp.Location = New System.Drawing.Point(4, 22)
        Me.tabHelp.Name = "tabHelp"
        Me.tabHelp.Size = New System.Drawing.Size(311, 253)
        Me.tabHelp.TabIndex = 4
        Me.tabHelp.Text = "Help"
        Me.tabHelp.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(278, 65)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(303, 130)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Title:"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(49, 6)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(278, 20)
        Me.txtTitle.TabIndex = 2
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(256, 314)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(175, 314)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'QuestTexts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 344)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(359, 383)
        Me.MinimumSize = New System.Drawing.Size(359, 383)
        Me.Name = "QuestTexts"
        Me.Text = "Quest Texts"
        Me.TabControl1.ResumeLayout(False)
        Me.tabDescription.ResumeLayout(False)
        Me.tabObjDesc.ResumeLayout(False)
        Me.tabTurn.ResumeLayout(False)
        Me.tabTurn.PerformLayout()
        Me.tabHelp.ResumeLayout(False)
        Me.tabHelp.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabDescription As TabPage
    Friend WithEvents tabObjDesc As TabPage
    Friend WithEvents tabTurn As TabPage
    Friend WithEvents txtDescription As RichTextBox
    Friend WithEvents txtObjDesc As RichTextBox
    Friend WithEvents txtRequest As RichTextBox
    Friend WithEvents tabHelp As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCompleted As RichTextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
End Class
