<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuestGiverTaker
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabGiver = New System.Windows.Forms.TabPage()
        Me.lblNameGiver = New System.Windows.Forms.Label()
        Me.btnRemoveGiver = New System.Windows.Forms.Button()
        Me.btnUpdateGiver = New System.Windows.Forms.Button()
        Me.btnAddGiver = New System.Windows.Forms.Button()
        Me.listGiver = New System.Windows.Forms.ListBox()
        Me.numIdGiver = New System.Windows.Forms.NumericUpDown()
        Me.lblIdGiver = New System.Windows.Forms.Label()
        Me.tabTaker = New System.Windows.Forms.TabPage()
        Me.lblNameTaker = New System.Windows.Forms.Label()
        Me.btnRemoveTaker = New System.Windows.Forms.Button()
        Me.btnUpdateTaker = New System.Windows.Forms.Button()
        Me.btnAddTaker = New System.Windows.Forms.Button()
        Me.listTaker = New System.Windows.Forms.ListBox()
        Me.numIdTaker = New System.Windows.Forms.NumericUpDown()
        Me.lblIdTaker = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tabGiver.SuspendLayout()
        CType(Me.numIdGiver, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTaker.SuspendLayout()
        CType(Me.numIdTaker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabGiver)
        Me.TabControl1.Controls.Add(Me.tabTaker)
        Me.TabControl1.Location = New System.Drawing.Point(7, 6)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(332, 310)
        Me.TabControl1.TabIndex = 0
        '
        'tabGiver
        '
        Me.tabGiver.Controls.Add(Me.lblNameGiver)
        Me.tabGiver.Controls.Add(Me.btnRemoveGiver)
        Me.tabGiver.Controls.Add(Me.btnUpdateGiver)
        Me.tabGiver.Controls.Add(Me.btnAddGiver)
        Me.tabGiver.Controls.Add(Me.listGiver)
        Me.tabGiver.Controls.Add(Me.numIdGiver)
        Me.tabGiver.Controls.Add(Me.lblIdGiver)
        Me.tabGiver.Location = New System.Drawing.Point(4, 22)
        Me.tabGiver.Margin = New System.Windows.Forms.Padding(2)
        Me.tabGiver.Name = "tabGiver"
        Me.tabGiver.Size = New System.Drawing.Size(324, 284)
        Me.tabGiver.TabIndex = 2
        Me.tabGiver.Text = "Quest Givers"
        Me.tabGiver.UseVisualStyleBackColor = True
        '
        'lblNameGiver
        '
        Me.lblNameGiver.AutoSize = True
        Me.lblNameGiver.Location = New System.Drawing.Point(91, 24)
        Me.lblNameGiver.Name = "lblNameGiver"
        Me.lblNameGiver.Size = New System.Drawing.Size(0, 13)
        Me.lblNameGiver.TabIndex = 17
        '
        'btnRemoveGiver
        '
        Me.btnRemoveGiver.Enabled = False
        Me.btnRemoveGiver.Location = New System.Drawing.Point(236, 54)
        Me.btnRemoveGiver.Name = "btnRemoveGiver"
        Me.btnRemoveGiver.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoveGiver.TabIndex = 16
        Me.btnRemoveGiver.Text = "Remove"
        Me.btnRemoveGiver.UseVisualStyleBackColor = True
        '
        'btnUpdateGiver
        '
        Me.btnUpdateGiver.Enabled = False
        Me.btnUpdateGiver.Location = New System.Drawing.Point(123, 54)
        Me.btnUpdateGiver.Name = "btnUpdateGiver"
        Me.btnUpdateGiver.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateGiver.TabIndex = 15
        Me.btnUpdateGiver.Text = "Update"
        Me.btnUpdateGiver.UseVisualStyleBackColor = True
        '
        'btnAddGiver
        '
        Me.btnAddGiver.Location = New System.Drawing.Point(11, 54)
        Me.btnAddGiver.Name = "btnAddGiver"
        Me.btnAddGiver.Size = New System.Drawing.Size(75, 23)
        Me.btnAddGiver.TabIndex = 14
        Me.btnAddGiver.Text = "Add"
        Me.btnAddGiver.UseVisualStyleBackColor = True
        '
        'listGiver
        '
        Me.listGiver.FormattingEnabled = True
        Me.listGiver.Location = New System.Drawing.Point(11, 83)
        Me.listGiver.Name = "listGiver"
        Me.listGiver.Size = New System.Drawing.Size(300, 186)
        Me.listGiver.TabIndex = 13
        '
        'numIdGiver
        '
        Me.numIdGiver.Location = New System.Drawing.Point(11, 22)
        Me.numIdGiver.Margin = New System.Windows.Forms.Padding(2)
        Me.numIdGiver.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numIdGiver.Name = "numIdGiver"
        Me.numIdGiver.Size = New System.Drawing.Size(75, 20)
        Me.numIdGiver.TabIndex = 12
        '
        'lblIdGiver
        '
        Me.lblIdGiver.AutoSize = True
        Me.lblIdGiver.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdGiver.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblIdGiver.Location = New System.Drawing.Point(8, 6)
        Me.lblIdGiver.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblIdGiver.Name = "lblIdGiver"
        Me.lblIdGiver.Size = New System.Drawing.Size(19, 13)
        Me.lblIdGiver.TabIndex = 11
        Me.lblIdGiver.Text = "Id:"
        '
        'tabTaker
        '
        Me.tabTaker.Controls.Add(Me.lblNameTaker)
        Me.tabTaker.Controls.Add(Me.btnRemoveTaker)
        Me.tabTaker.Controls.Add(Me.btnUpdateTaker)
        Me.tabTaker.Controls.Add(Me.btnAddTaker)
        Me.tabTaker.Controls.Add(Me.listTaker)
        Me.tabTaker.Controls.Add(Me.numIdTaker)
        Me.tabTaker.Controls.Add(Me.lblIdTaker)
        Me.tabTaker.Location = New System.Drawing.Point(4, 22)
        Me.tabTaker.Margin = New System.Windows.Forms.Padding(2)
        Me.tabTaker.Name = "tabTaker"
        Me.tabTaker.Size = New System.Drawing.Size(324, 284)
        Me.tabTaker.TabIndex = 3
        Me.tabTaker.Text = "Quest Takers"
        Me.tabTaker.UseVisualStyleBackColor = True
        '
        'lblNameTaker
        '
        Me.lblNameTaker.AutoSize = True
        Me.lblNameTaker.Location = New System.Drawing.Point(91, 24)
        Me.lblNameTaker.Name = "lblNameTaker"
        Me.lblNameTaker.Size = New System.Drawing.Size(0, 13)
        Me.lblNameTaker.TabIndex = 24
        '
        'btnRemoveTaker
        '
        Me.btnRemoveTaker.Enabled = False
        Me.btnRemoveTaker.Location = New System.Drawing.Point(236, 54)
        Me.btnRemoveTaker.Name = "btnRemoveTaker"
        Me.btnRemoveTaker.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoveTaker.TabIndex = 23
        Me.btnRemoveTaker.Text = "Remove"
        Me.btnRemoveTaker.UseVisualStyleBackColor = True
        '
        'btnUpdateTaker
        '
        Me.btnUpdateTaker.Enabled = False
        Me.btnUpdateTaker.Location = New System.Drawing.Point(123, 54)
        Me.btnUpdateTaker.Name = "btnUpdateTaker"
        Me.btnUpdateTaker.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateTaker.TabIndex = 22
        Me.btnUpdateTaker.Text = "Update"
        Me.btnUpdateTaker.UseVisualStyleBackColor = True
        '
        'btnAddTaker
        '
        Me.btnAddTaker.Location = New System.Drawing.Point(11, 54)
        Me.btnAddTaker.Name = "btnAddTaker"
        Me.btnAddTaker.Size = New System.Drawing.Size(75, 23)
        Me.btnAddTaker.TabIndex = 21
        Me.btnAddTaker.Text = "Add"
        Me.btnAddTaker.UseVisualStyleBackColor = True
        '
        'listTaker
        '
        Me.listTaker.FormattingEnabled = True
        Me.listTaker.Location = New System.Drawing.Point(11, 83)
        Me.listTaker.Name = "listTaker"
        Me.listTaker.Size = New System.Drawing.Size(300, 186)
        Me.listTaker.TabIndex = 20
        '
        'numIdTaker
        '
        Me.numIdTaker.Location = New System.Drawing.Point(11, 22)
        Me.numIdTaker.Margin = New System.Windows.Forms.Padding(2)
        Me.numIdTaker.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numIdTaker.Name = "numIdTaker"
        Me.numIdTaker.Size = New System.Drawing.Size(75, 20)
        Me.numIdTaker.TabIndex = 19
        '
        'lblIdTaker
        '
        Me.lblIdTaker.AutoSize = True
        Me.lblIdTaker.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdTaker.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblIdTaker.Location = New System.Drawing.Point(8, 6)
        Me.lblIdTaker.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblIdTaker.Name = "lblIdTaker"
        Me.lblIdTaker.Size = New System.Drawing.Size(19, 13)
        Me.lblIdTaker.TabIndex = 18
        Me.lblIdTaker.Text = "Id:"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(260, 317)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(179, 317)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'QuestGiverTaker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 344)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(359, 383)
        Me.MinimumSize = New System.Drawing.Size(359, 383)
        Me.Name = "QuestGiverTaker"
        Me.Text = "Quest Givers & Takers"
        Me.TabControl1.ResumeLayout(False)
        Me.tabGiver.ResumeLayout(False)
        Me.tabGiver.PerformLayout()
        CType(Me.numIdGiver, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTaker.ResumeLayout(False)
        Me.tabTaker.PerformLayout()
        CType(Me.numIdTaker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabGiver As System.Windows.Forms.TabPage
    Friend WithEvents tabTaker As System.Windows.Forms.TabPage
    Friend WithEvents btnRemoveGiver As Button
    Friend WithEvents btnUpdateGiver As Button
    Friend WithEvents btnAddGiver As Button
    Friend WithEvents listGiver As ListBox
    Friend WithEvents numIdGiver As NumericUpDown
    Friend WithEvents lblIdGiver As Label
    Friend WithEvents lblNameGiver As Label
    Friend WithEvents lblNameTaker As Label
    Friend WithEvents btnRemoveTaker As Button
    Friend WithEvents btnUpdateTaker As Button
    Friend WithEvents btnAddTaker As Button
    Friend WithEvents listTaker As ListBox
    Friend WithEvents numIdTaker As NumericUpDown
    Friend WithEvents lblIdTaker As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
End Class
