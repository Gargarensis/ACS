<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AIPanels
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblParam6 = New System.Windows.Forms.Label()
        Me.lblParam5 = New System.Windows.Forms.Label()
        Me.lblParam4 = New System.Windows.Forms.Label()
        Me.lblParam3 = New System.Windows.Forms.Label()
        Me.lblParam2 = New System.Windows.Forms.Label()
        Me.lblParam1 = New System.Windows.Forms.Label()
        Me.aiPanel = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(7, 5)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(60, 13)
        Me.lblDescription.TabIndex = 0
        Me.lblDescription.Text = "Description"
        '
        'lblParam6
        '
        Me.lblParam6.AutoSize = True
        Me.lblParam6.Location = New System.Drawing.Point(193, 157)
        Me.lblParam6.Name = "lblParam6"
        Me.lblParam6.Size = New System.Drawing.Size(39, 13)
        Me.lblParam6.TabIndex = 11
        Me.lblParam6.Text = "Label2"
        Me.lblParam6.Visible = False
        '
        'lblParam5
        '
        Me.lblParam5.AutoSize = True
        Me.lblParam5.Location = New System.Drawing.Point(193, 133)
        Me.lblParam5.Name = "lblParam5"
        Me.lblParam5.Size = New System.Drawing.Size(39, 13)
        Me.lblParam5.TabIndex = 9
        Me.lblParam5.Text = "Label1"
        Me.lblParam5.Visible = False
        '
        'lblParam4
        '
        Me.lblParam4.AutoSize = True
        Me.lblParam4.Location = New System.Drawing.Point(193, 108)
        Me.lblParam4.Name = "lblParam4"
        Me.lblParam4.Size = New System.Drawing.Size(39, 13)
        Me.lblParam4.TabIndex = 10
        Me.lblParam4.Text = "Label1"
        Me.lblParam4.Visible = False
        '
        'lblParam3
        '
        Me.lblParam3.AutoSize = True
        Me.lblParam3.Location = New System.Drawing.Point(193, 83)
        Me.lblParam3.Name = "lblParam3"
        Me.lblParam3.Size = New System.Drawing.Size(39, 13)
        Me.lblParam3.TabIndex = 8
        Me.lblParam3.Text = "Label1"
        Me.lblParam3.Visible = False
        '
        'lblParam2
        '
        Me.lblParam2.AutoSize = True
        Me.lblParam2.Location = New System.Drawing.Point(193, 59)
        Me.lblParam2.Name = "lblParam2"
        Me.lblParam2.Size = New System.Drawing.Size(39, 13)
        Me.lblParam2.TabIndex = 7
        Me.lblParam2.Text = "Label1"
        Me.lblParam2.Visible = False
        '
        'lblParam1
        '
        Me.lblParam1.AutoSize = True
        Me.lblParam1.Location = New System.Drawing.Point(193, 35)
        Me.lblParam1.Name = "lblParam1"
        Me.lblParam1.Size = New System.Drawing.Size(39, 13)
        Me.lblParam1.TabIndex = 6
        Me.lblParam1.Text = "Label1"
        Me.lblParam1.Visible = False
        '
        'aiPanel
        '
        Me.aiPanel.Location = New System.Drawing.Point(12, 26)
        Me.aiPanel.Name = "aiPanel"
        Me.aiPanel.Size = New System.Drawing.Size(175, 154)
        Me.aiPanel.TabIndex = 12
        '
        'AIPanels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 181)
        Me.Controls.Add(Me.aiPanel)
        Me.Controls.Add(Me.lblParam6)
        Me.Controls.Add(Me.lblParam5)
        Me.Controls.Add(Me.lblParam4)
        Me.Controls.Add(Me.lblParam3)
        Me.Controls.Add(Me.lblParam2)
        Me.Controls.Add(Me.lblParam1)
        Me.Controls.Add(Me.lblDescription)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AIPanels"
        Me.Text = "AIPanels"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDescription As Label
    Friend WithEvents lblParam6 As Label
    Friend WithEvents lblParam5 As Label
    Friend WithEvents lblParam4 As Label
    Friend WithEvents lblParam3 As Label
    Friend WithEvents lblParam2 As Label
    Friend WithEvents lblParam1 As Label
    Friend WithEvents aiPanel As Panel
End Class
