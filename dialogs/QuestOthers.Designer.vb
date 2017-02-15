<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuestOthers
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
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tabRequest = New System.Windows.Forms.TabPage
        Me.tabEnd = New System.Windows.Forms.TabPage
        Me.tabGiver = New System.Windows.Forms.TabPage
        Me.tabTaker = New System.Windows.Forms.TabPage
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabRequest)
        Me.TabControl1.Controls.Add(Me.tabEnd)
        Me.TabControl1.Controls.Add(Me.tabGiver)
        Me.TabControl1.Controls.Add(Me.tabTaker)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(443, 382)
        Me.TabControl1.TabIndex = 0
        '
        'tabRequest
        '
        Me.tabRequest.Location = New System.Drawing.Point(4, 25)
        Me.tabRequest.Name = "tabRequest"
        Me.tabRequest.Padding = New System.Windows.Forms.Padding(3)
        Me.tabRequest.Size = New System.Drawing.Size(435, 353)
        Me.tabRequest.TabIndex = 0
        Me.tabRequest.Text = "RequestItemText"
        Me.tabRequest.UseVisualStyleBackColor = True
        '
        'tabEnd
        '
        Me.tabEnd.Location = New System.Drawing.Point(4, 25)
        Me.tabEnd.Name = "tabEnd"
        Me.tabEnd.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEnd.Size = New System.Drawing.Size(435, 353)
        Me.tabEnd.TabIndex = 1
        Me.tabEnd.Text = "End Text"
        Me.tabEnd.UseVisualStyleBackColor = True
        '
        'tabGiver
        '
        Me.tabGiver.Location = New System.Drawing.Point(4, 25)
        Me.tabGiver.Name = "tabGiver"
        Me.tabGiver.Size = New System.Drawing.Size(435, 353)
        Me.tabGiver.TabIndex = 2
        Me.tabGiver.Text = "Quest Givers"
        Me.tabGiver.UseVisualStyleBackColor = True
        '
        'tabTaker
        '
        Me.tabTaker.Location = New System.Drawing.Point(4, 25)
        Me.tabTaker.Name = "tabTaker"
        Me.tabTaker.Size = New System.Drawing.Size(435, 353)
        Me.tabTaker.TabIndex = 3
        Me.tabTaker.Text = "Quest Takers"
        Me.tabTaker.UseVisualStyleBackColor = True
        '
        'QuestOthers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 434)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(473, 463)
        Me.MinimumSize = New System.Drawing.Size(473, 463)
        Me.Name = "QuestOthers"
        Me.Text = "QuestOthers"
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabRequest As System.Windows.Forms.TabPage
    Friend WithEvents tabEnd As System.Windows.Forms.TabPage
    Friend WithEvents tabGiver As System.Windows.Forms.TabPage
    Friend WithEvents tabTaker As System.Windows.Forms.TabPage
End Class
