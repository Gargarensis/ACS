<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormData
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
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.listContent = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(50, 3)
        Me.txtFilter.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(256, 20)
        Me.txtFilter.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Filter:"
        '
        'listContent
        '
        Me.listContent.FormattingEnabled = True
        Me.listContent.Location = New System.Drawing.Point(9, 26)
        Me.listContent.Margin = New System.Windows.Forms.Padding(2)
        Me.listContent.Name = "listContent"
        Me.listContent.Size = New System.Drawing.Size(296, 277)
        Me.listContent.TabIndex = 3
        '
        'FormData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 307)
        Me.Controls.Add(Me.listContent)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFilter)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormData"
        Me.Text = "FormData"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFilter As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents listContent As System.Windows.Forms.ListBox
End Class
