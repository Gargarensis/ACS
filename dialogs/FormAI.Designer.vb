<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAI
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
        Me.boxReaction = New System.Windows.Forms.GroupBox()
        Me.lblNameReaction = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.comboReaction = New System.Windows.Forms.ComboBox()
        Me.comboTarget = New System.Windows.Forms.ComboBox()
        Me.comboAction = New System.Windows.Forms.ComboBox()
        Me.boxAction = New System.Windows.Forms.GroupBox()
        Me.lblNameAction = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.boxTarget = New System.Windows.Forms.GroupBox()
        Me.lblNameTarget = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.timerIds = New System.Windows.Forms.Timer(Me.components)
        Me.boxReaction.SuspendLayout()
        Me.boxAction.SuspendLayout()
        Me.boxTarget.SuspendLayout()
        Me.SuspendLayout()
        '
        'boxReaction
        '
        Me.boxReaction.Controls.Add(Me.lblNameReaction)
        Me.boxReaction.Controls.Add(Me.Panel1)
        Me.boxReaction.Controls.Add(Me.comboReaction)
        Me.boxReaction.Location = New System.Drawing.Point(12, 12)
        Me.boxReaction.Name = "boxReaction"
        Me.boxReaction.Size = New System.Drawing.Size(590, 236)
        Me.boxReaction.TabIndex = 0
        Me.boxReaction.TabStop = False
        Me.boxReaction.Text = "What should i do?"
        '
        'lblNameReaction
        '
        Me.lblNameReaction.AutoSize = True
        Me.lblNameReaction.Location = New System.Drawing.Point(370, 22)
        Me.lblNameReaction.Name = "lblNameReaction"
        Me.lblNameReaction.Size = New System.Drawing.Size(0, 13)
        Me.lblNameReaction.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(6, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(578, 184)
        Me.Panel1.TabIndex = 1
        '
        'comboReaction
        '
        Me.comboReaction.FormattingEnabled = True
        Me.comboReaction.Location = New System.Drawing.Point(6, 19)
        Me.comboReaction.Name = "comboReaction"
        Me.comboReaction.Size = New System.Drawing.Size(358, 21)
        Me.comboReaction.TabIndex = 0
        '
        'comboTarget
        '
        Me.comboTarget.FormattingEnabled = True
        Me.comboTarget.Location = New System.Drawing.Point(6, 19)
        Me.comboTarget.Name = "comboTarget"
        Me.comboTarget.Size = New System.Drawing.Size(358, 21)
        Me.comboTarget.TabIndex = 2
        '
        'comboAction
        '
        Me.comboAction.FormattingEnabled = True
        Me.comboAction.Location = New System.Drawing.Point(6, 19)
        Me.comboAction.Name = "comboAction"
        Me.comboAction.Size = New System.Drawing.Size(358, 21)
        Me.comboAction.TabIndex = 1
        '
        'boxAction
        '
        Me.boxAction.Controls.Add(Me.lblNameAction)
        Me.boxAction.Controls.Add(Me.Panel2)
        Me.boxAction.Controls.Add(Me.comboTarget)
        Me.boxAction.Location = New System.Drawing.Point(12, 254)
        Me.boxAction.Name = "boxAction"
        Me.boxAction.Size = New System.Drawing.Size(590, 233)
        Me.boxAction.TabIndex = 3
        Me.boxAction.TabStop = False
        Me.boxAction.Text = "When should i do it?"
        '
        'lblNameAction
        '
        Me.lblNameAction.AutoSize = True
        Me.lblNameAction.Location = New System.Drawing.Point(370, 22)
        Me.lblNameAction.Name = "lblNameAction"
        Me.lblNameAction.Size = New System.Drawing.Size(0, 13)
        Me.lblNameAction.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(6, 46)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(578, 181)
        Me.Panel2.TabIndex = 2
        '
        'boxTarget
        '
        Me.boxTarget.Controls.Add(Me.lblNameTarget)
        Me.boxTarget.Controls.Add(Me.Panel3)
        Me.boxTarget.Controls.Add(Me.comboAction)
        Me.boxTarget.Location = New System.Drawing.Point(12, 493)
        Me.boxTarget.Name = "boxTarget"
        Me.boxTarget.Size = New System.Drawing.Size(590, 187)
        Me.boxTarget.TabIndex = 4
        Me.boxTarget.TabStop = False
        Me.boxTarget.Text = "Which target should i consider?"
        '
        'lblNameTarget
        '
        Me.lblNameTarget.AutoSize = True
        Me.lblNameTarget.Location = New System.Drawing.Point(370, 22)
        Me.lblNameTarget.Name = "lblNameTarget"
        Me.lblNameTarget.Size = New System.Drawing.Size(0, 13)
        Me.lblNameTarget.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(6, 46)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(578, 135)
        Me.Panel3.TabIndex = 2
        '
        'timerIds
        '
        Me.timerIds.Interval = 1000
        '
        'FormAI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 774)
        Me.Controls.Add(Me.boxTarget)
        Me.Controls.Add(Me.boxAction)
        Me.Controls.Add(Me.boxReaction)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormAI"
        Me.Text = "FormAI"
        Me.boxReaction.ResumeLayout(False)
        Me.boxReaction.PerformLayout()
        Me.boxAction.ResumeLayout(False)
        Me.boxAction.PerformLayout()
        Me.boxTarget.ResumeLayout(False)
        Me.boxTarget.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents boxReaction As GroupBox
    Friend WithEvents comboReaction As ComboBox
    Friend WithEvents comboTarget As ComboBox
    Friend WithEvents comboAction As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents boxAction As GroupBox
    Friend WithEvents boxTarget As GroupBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblNameReaction As Label
    Friend WithEvents lblNameAction As Label
    Friend WithEvents lblNameTarget As Label
    Friend WithEvents timerIds As Timer
End Class
