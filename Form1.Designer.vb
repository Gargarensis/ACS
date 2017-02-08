<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TabEnemy = New System.Windows.Forms.TabPage
        Me.TabFriendly = New System.Windows.Forms.TabPage
        Me.TabItem = New System.Windows.Forms.TabPage
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabEnemy)
        Me.TabControl1.Controls.Add(Me.TabFriendly)
        Me.TabControl1.Controls.Add(Me.TabItem)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(962, 723)
        Me.TabControl1.TabIndex = 0
        '
        'TabEnemy
        '
        Me.TabEnemy.Location = New System.Drawing.Point(4, 25)
        Me.TabEnemy.Name = "TabEnemy"
        Me.TabEnemy.Padding = New System.Windows.Forms.Padding(3)
        Me.TabEnemy.Size = New System.Drawing.Size(954, 694)
        Me.TabEnemy.TabIndex = 1
        Me.TabEnemy.Text = "Enemy"
        Me.TabEnemy.UseVisualStyleBackColor = True
        '
        'TabFriendly
        '
        Me.TabFriendly.Location = New System.Drawing.Point(4, 25)
        Me.TabFriendly.Name = "TabFriendly"
        Me.TabFriendly.Size = New System.Drawing.Size(954, 694)
        Me.TabFriendly.TabIndex = 2
        Me.TabFriendly.Text = "Friendly"
        Me.TabFriendly.UseVisualStyleBackColor = True
        '
        'TabItem
        '
        Me.TabItem.Location = New System.Drawing.Point(4, 25)
        Me.TabItem.Name = "TabItem"
        Me.TabItem.Size = New System.Drawing.Size(954, 694)
        Me.TabItem.TabIndex = 3
        Me.TabItem.Text = "Item"
        Me.TabItem.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 747)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "ACS"
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabEnemy As System.Windows.Forms.TabPage
    Friend WithEvents TabFriendly As System.Windows.Forms.TabPage
    Friend WithEvents TabItem As System.Windows.Forms.TabPage

End Class
