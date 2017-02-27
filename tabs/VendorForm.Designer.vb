<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VendorForm
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
        Me.components = New System.ComponentModel.Container()
        Me.boxItems = New System.Windows.Forms.GroupBox()
        Me.numItemCost = New System.Windows.Forms.NumericUpDown()
        Me.numItemId = New System.Windows.Forms.NumericUpDown()
        Me.lblItemCost = New System.Windows.Forms.Label()
        Me.lblItemId = New System.Windows.Forms.Label()
        Me.btnDeleteItem = New System.Windows.Forms.Button()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.btnNewItem = New System.Windows.Forms.Button()
        Me.listVendorItems = New System.Windows.Forms.ListBox()
        Me.checkViewer = New System.Windows.Forms.CheckBox()
        Me.browserModel = New System.Windows.Forms.WebBrowser()
        Me.lblTitleVendor = New System.Windows.Forms.Label()
        Me.boxBasic = New System.Windows.Forms.GroupBox()
        Me.numEntry = New System.Windows.Forms.NumericUpDown()
        Me.lblEntryCheck = New System.Windows.Forms.Label()
        Me.lblEntry = New System.Windows.Forms.Label()
        Me.boxInteraction = New System.Windows.Forms.GroupBox()
        Me.numFaction = New System.Windows.Forms.NumericUpDown()
        Me.lblFactionCheck = New System.Windows.Forms.Label()
        Me.lblFaction = New System.Windows.Forms.Label()
        Me.checkRepair = New System.Windows.Forms.CheckBox()
        Me.boxAppearance = New System.Windows.Forms.GroupBox()
        Me.numModel = New System.Windows.Forms.NumericUpDown()
        Me.numSize = New System.Windows.Forms.NumericUpDown()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblSubname = New System.Windows.Forms.Label()
        Me.txtSubname = New System.Windows.Forms.TextBox()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnSQL = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.tooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.checkFactionTimer = New System.Windows.Forms.Timer(Me.components)
        Me.checkEntryTimer = New System.Windows.Forms.Timer(Me.components)
        Me.boxItems.SuspendLayout()
        CType(Me.numItemCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numItemId, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.boxBasic.SuspendLayout()
        CType(Me.numEntry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.boxInteraction.SuspendLayout()
        CType(Me.numFaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.boxAppearance.SuspendLayout()
        CType(Me.numModel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'boxItems
        '
        Me.boxItems.Controls.Add(Me.numItemCost)
        Me.boxItems.Controls.Add(Me.numItemId)
        Me.boxItems.Controls.Add(Me.lblItemCost)
        Me.boxItems.Controls.Add(Me.lblItemId)
        Me.boxItems.Controls.Add(Me.btnDeleteItem)
        Me.boxItems.Controls.Add(Me.btnChange)
        Me.boxItems.Controls.Add(Me.btnNewItem)
        Me.boxItems.Controls.Add(Me.listVendorItems)
        Me.boxItems.Location = New System.Drawing.Point(8, 328)
        Me.boxItems.Margin = New System.Windows.Forms.Padding(2)
        Me.boxItems.Name = "boxItems"
        Me.boxItems.Padding = New System.Windows.Forms.Padding(2)
        Me.boxItems.Size = New System.Drawing.Size(702, 198)
        Me.boxItems.TabIndex = 22
        Me.boxItems.TabStop = False
        Me.boxItems.Text = "Items"
        '
        'numItemCost
        '
        Me.numItemCost.Location = New System.Drawing.Point(152, 25)
        Me.numItemCost.Margin = New System.Windows.Forms.Padding(2)
        Me.numItemCost.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.numItemCost.Name = "numItemCost"
        Me.numItemCost.Size = New System.Drawing.Size(68, 20)
        Me.numItemCost.TabIndex = 14
        '
        'numItemId
        '
        Me.numItemId.Location = New System.Drawing.Point(72, 25)
        Me.numItemId.Margin = New System.Windows.Forms.Padding(2)
        Me.numItemId.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.numItemId.Name = "numItemId"
        Me.numItemId.Size = New System.Drawing.Size(68, 20)
        Me.numItemId.TabIndex = 13
        '
        'lblItemCost
        '
        Me.lblItemCost.AutoSize = True
        Me.lblItemCost.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblItemCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemCost.ForeColor = System.Drawing.Color.Blue
        Me.lblItemCost.Location = New System.Drawing.Point(149, 9)
        Me.lblItemCost.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblItemCost.Name = "lblItemCost"
        Me.lblItemCost.Size = New System.Drawing.Size(78, 13)
        Me.lblItemCost.TabIndex = 3
        Me.lblItemCost.Text = "Extended cost:"
        '
        'lblItemId
        '
        Me.lblItemId.AutoSize = True
        Me.lblItemId.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblItemId.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemId.ForeColor = System.Drawing.Color.Blue
        Me.lblItemId.Location = New System.Drawing.Point(70, 9)
        Me.lblItemId.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblItemId.Name = "lblItemId"
        Me.lblItemId.Size = New System.Drawing.Size(19, 13)
        Me.lblItemId.TabIndex = 3
        Me.lblItemId.Text = "Id:"
        '
        'btnDeleteItem
        '
        Me.btnDeleteItem.Enabled = False
        Me.btnDeleteItem.Location = New System.Drawing.Point(340, 17)
        Me.btnDeleteItem.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDeleteItem.Name = "btnDeleteItem"
        Me.btnDeleteItem.Size = New System.Drawing.Size(58, 26)
        Me.btnDeleteItem.TabIndex = 1
        Me.btnDeleteItem.Text = "Remove"
        Me.btnDeleteItem.UseVisualStyleBackColor = True
        '
        'btnChange
        '
        Me.btnChange.Enabled = False
        Me.btnChange.Location = New System.Drawing.Point(229, 17)
        Me.btnChange.Margin = New System.Windows.Forms.Padding(2)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(58, 26)
        Me.btnChange.TabIndex = 1
        Me.btnChange.Text = "Update"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'btnNewItem
        '
        Me.btnNewItem.Location = New System.Drawing.Point(7, 17)
        Me.btnNewItem.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNewItem.Name = "btnNewItem"
        Me.btnNewItem.Size = New System.Drawing.Size(58, 26)
        Me.btnNewItem.TabIndex = 1
        Me.btnNewItem.Text = "Add"
        Me.btnNewItem.UseVisualStyleBackColor = True
        '
        'listVendorItems
        '
        Me.listVendorItems.FormattingEnabled = True
        Me.listVendorItems.Location = New System.Drawing.Point(7, 54)
        Me.listVendorItems.Margin = New System.Windows.Forms.Padding(2)
        Me.listVendorItems.Name = "listVendorItems"
        Me.listVendorItems.Size = New System.Drawing.Size(692, 134)
        Me.listVendorItems.TabIndex = 0
        '
        'checkViewer
        '
        Me.checkViewer.AutoSize = True
        Me.checkViewer.Checked = True
        Me.checkViewer.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkViewer.Location = New System.Drawing.Point(533, 12)
        Me.checkViewer.Margin = New System.Windows.Forms.Padding(2)
        Me.checkViewer.Name = "checkViewer"
        Me.checkViewer.Size = New System.Drawing.Size(184, 17)
        Me.checkViewer.TabIndex = 21
        Me.checkViewer.Text = "Wowhead Model Viewer Enabled"
        Me.checkViewer.UseVisualStyleBackColor = True
        '
        'browserModel
        '
        Me.browserModel.Location = New System.Drawing.Point(303, 37)
        Me.browserModel.Margin = New System.Windows.Forms.Padding(2)
        Me.browserModel.MinimumSize = New System.Drawing.Size(15, 16)
        Me.browserModel.Name = "browserModel"
        Me.browserModel.ScriptErrorsSuppressed = True
        Me.browserModel.ScrollBarsEnabled = False
        Me.browserModel.Size = New System.Drawing.Size(403, 274)
        Me.browserModel.TabIndex = 20
        Me.browserModel.Url = New System.Uri("", System.UriKind.Relative)
        Me.browserModel.Visible = False
        Me.browserModel.WebBrowserShortcutsEnabled = False
        '
        'lblTitleVendor
        '
        Me.lblTitleVendor.AutoSize = True
        Me.lblTitleVendor.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleVendor.Location = New System.Drawing.Point(270, 3)
        Me.lblTitleVendor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitleVendor.Name = "lblTitleVendor"
        Me.lblTitleVendor.Size = New System.Drawing.Size(145, 26)
        Me.lblTitleVendor.TabIndex = 19
        Me.lblTitleVendor.Text = "NPC Vendor"
        '
        'boxBasic
        '
        Me.boxBasic.Controls.Add(Me.numEntry)
        Me.boxBasic.Controls.Add(Me.lblEntryCheck)
        Me.boxBasic.Controls.Add(Me.lblEntry)
        Me.boxBasic.Location = New System.Drawing.Point(8, 15)
        Me.boxBasic.Margin = New System.Windows.Forms.Padding(2)
        Me.boxBasic.Name = "boxBasic"
        Me.boxBasic.Padding = New System.Windows.Forms.Padding(2)
        Me.boxBasic.Size = New System.Drawing.Size(221, 64)
        Me.boxBasic.TabIndex = 18
        Me.boxBasic.TabStop = False
        Me.boxBasic.Text = "Basic"
        '
        'numEntry
        '
        Me.numEntry.Location = New System.Drawing.Point(7, 29)
        Me.numEntry.Margin = New System.Windows.Forms.Padding(2)
        Me.numEntry.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.numEntry.Name = "numEntry"
        Me.numEntry.Size = New System.Drawing.Size(75, 20)
        Me.numEntry.TabIndex = 2
        '
        'lblEntryCheck
        '
        Me.lblEntryCheck.AutoSize = True
        Me.lblEntryCheck.Location = New System.Drawing.Point(86, 31)
        Me.lblEntryCheck.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEntryCheck.Name = "lblEntryCheck"
        Me.lblEntryCheck.Size = New System.Drawing.Size(0, 13)
        Me.lblEntryCheck.TabIndex = 2
        Me.lblEntryCheck.Visible = False
        '
        'lblEntry
        '
        Me.lblEntry.AutoSize = True
        Me.lblEntry.Location = New System.Drawing.Point(4, 15)
        Me.lblEntry.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEntry.Name = "lblEntry"
        Me.lblEntry.Size = New System.Drawing.Size(34, 13)
        Me.lblEntry.TabIndex = 0
        Me.lblEntry.Text = "Entry:"
        '
        'boxInteraction
        '
        Me.boxInteraction.Controls.Add(Me.numFaction)
        Me.boxInteraction.Controls.Add(Me.lblFactionCheck)
        Me.boxInteraction.Controls.Add(Me.lblFaction)
        Me.boxInteraction.Controls.Add(Me.checkRepair)
        Me.boxInteraction.Location = New System.Drawing.Point(8, 211)
        Me.boxInteraction.Margin = New System.Windows.Forms.Padding(2)
        Me.boxInteraction.Name = "boxInteraction"
        Me.boxInteraction.Padding = New System.Windows.Forms.Padding(2)
        Me.boxInteraction.Size = New System.Drawing.Size(221, 78)
        Me.boxInteraction.TabIndex = 17
        Me.boxInteraction.TabStop = False
        Me.boxInteraction.Text = "Interaction"
        '
        'numFaction
        '
        Me.numFaction.Location = New System.Drawing.Point(7, 29)
        Me.numFaction.Margin = New System.Windows.Forms.Padding(2)
        Me.numFaction.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.numFaction.Name = "numFaction"
        Me.numFaction.Size = New System.Drawing.Size(75, 20)
        Me.numFaction.TabIndex = 10
        '
        'lblFactionCheck
        '
        Me.lblFactionCheck.AutoSize = True
        Me.lblFactionCheck.Location = New System.Drawing.Point(86, 29)
        Me.lblFactionCheck.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFactionCheck.Name = "lblFactionCheck"
        Me.lblFactionCheck.Size = New System.Drawing.Size(0, 13)
        Me.lblFactionCheck.TabIndex = 3
        '
        'lblFaction
        '
        Me.lblFaction.AutoSize = True
        Me.lblFaction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblFaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFaction.ForeColor = System.Drawing.Color.Blue
        Me.lblFaction.Location = New System.Drawing.Point(4, 15)
        Me.lblFaction.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFaction.Name = "lblFaction"
        Me.lblFaction.Size = New System.Drawing.Size(45, 13)
        Me.lblFaction.TabIndex = 0
        Me.lblFaction.Text = "Faction:"
        '
        'checkRepair
        '
        Me.checkRepair.AutoSize = True
        Me.checkRepair.Location = New System.Drawing.Point(7, 52)
        Me.checkRepair.Margin = New System.Windows.Forms.Padding(2)
        Me.checkRepair.Name = "checkRepair"
        Me.checkRepair.Size = New System.Drawing.Size(57, 17)
        Me.checkRepair.TabIndex = 2
        Me.checkRepair.Text = "Repair"
        Me.checkRepair.UseVisualStyleBackColor = True
        '
        'boxAppearance
        '
        Me.boxAppearance.Controls.Add(Me.numModel)
        Me.boxAppearance.Controls.Add(Me.numSize)
        Me.boxAppearance.Controls.Add(Me.lblName)
        Me.boxAppearance.Controls.Add(Me.txtName)
        Me.boxAppearance.Controls.Add(Me.lblSubname)
        Me.boxAppearance.Controls.Add(Me.txtSubname)
        Me.boxAppearance.Controls.Add(Me.lblModel)
        Me.boxAppearance.Controls.Add(Me.lblSize)
        Me.boxAppearance.Location = New System.Drawing.Point(8, 92)
        Me.boxAppearance.Margin = New System.Windows.Forms.Padding(2)
        Me.boxAppearance.Name = "boxAppearance"
        Me.boxAppearance.Padding = New System.Windows.Forms.Padding(2)
        Me.boxAppearance.Size = New System.Drawing.Size(221, 105)
        Me.boxAppearance.TabIndex = 16
        Me.boxAppearance.TabStop = False
        Me.boxAppearance.Text = "Appearance"
        '
        'numModel
        '
        Me.numModel.Location = New System.Drawing.Point(7, 77)
        Me.numModel.Margin = New System.Windows.Forms.Padding(2)
        Me.numModel.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numModel.Name = "numModel"
        Me.numModel.Size = New System.Drawing.Size(75, 20)
        Me.numModel.TabIndex = 10
        '
        'numSize
        '
        Me.numSize.Location = New System.Drawing.Point(86, 77)
        Me.numSize.Margin = New System.Windows.Forms.Padding(2)
        Me.numSize.Name = "numSize"
        Me.numSize.Size = New System.Drawing.Size(75, 20)
        Me.numSize.TabIndex = 10
        Me.numSize.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(4, 15)
        Me.lblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(7, 31)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(76, 20)
        Me.txtName.TabIndex = 1
        '
        'lblSubname
        '
        Me.lblSubname.AutoSize = True
        Me.lblSubname.Location = New System.Drawing.Point(84, 15)
        Me.lblSubname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSubname.Name = "lblSubname"
        Me.lblSubname.Size = New System.Drawing.Size(55, 13)
        Me.lblSubname.TabIndex = 0
        Me.lblSubname.Text = "Subname:"
        '
        'txtSubname
        '
        Me.txtSubname.Location = New System.Drawing.Point(86, 31)
        Me.txtSubname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSubname.Name = "txtSubname"
        Me.txtSubname.Size = New System.Drawing.Size(76, 20)
        Me.txtSubname.TabIndex = 1
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblModel.Location = New System.Drawing.Point(4, 61)
        Me.lblModel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(39, 13)
        Me.lblModel.TabIndex = 0
        Me.lblModel.Text = "Model:"
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Location = New System.Drawing.Point(84, 61)
        Me.lblSize.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(30, 13)
        Me.lblSize.TabIndex = 0
        Me.lblSize.Text = "Size:"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(622, 531)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(84, 28)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "Save current"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnSQL
        '
        Me.btnSQL.Location = New System.Drawing.Point(533, 531)
        Me.btnSQL.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSQL.Name = "btnSQL"
        Me.btnSQL.Size = New System.Drawing.Size(84, 28)
        Me.btnSQL.TabIndex = 14
        Me.btnSQL.Text = "Look SQL"
        Me.btnSQL.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(401, 531)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(84, 28)
        Me.btnNew.TabIndex = 15
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'tooltip
        '
        Me.tooltip.AutoPopDelay = 10000
        Me.tooltip.InitialDelay = 500
        Me.tooltip.ReshowDelay = 100
        '
        'checkFactionTimer
        '
        '
        'checkEntryTimer
        '
        '
        'VendorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 569)
        Me.Controls.Add(Me.boxItems)
        Me.Controls.Add(Me.checkViewer)
        Me.Controls.Add(Me.browserModel)
        Me.Controls.Add(Me.lblTitleVendor)
        Me.Controls.Add(Me.boxBasic)
        Me.Controls.Add(Me.boxInteraction)
        Me.Controls.Add(Me.boxAppearance)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnSQL)
        Me.Controls.Add(Me.btnNew)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "VendorForm"
        Me.Text = "Vendor"
        Me.boxItems.ResumeLayout(False)
        Me.boxItems.PerformLayout()
        CType(Me.numItemCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numItemId, System.ComponentModel.ISupportInitialize).EndInit()
        Me.boxBasic.ResumeLayout(False)
        Me.boxBasic.PerformLayout()
        CType(Me.numEntry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.boxInteraction.ResumeLayout(False)
        Me.boxInteraction.PerformLayout()
        CType(Me.numFaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.boxAppearance.ResumeLayout(False)
        Me.boxAppearance.PerformLayout()
        CType(Me.numModel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents boxItems As System.Windows.Forms.GroupBox
    Friend WithEvents numItemCost As System.Windows.Forms.NumericUpDown
    Friend WithEvents numItemId As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblItemCost As System.Windows.Forms.Label
    Friend WithEvents lblItemId As System.Windows.Forms.Label
    Friend WithEvents btnDeleteItem As System.Windows.Forms.Button
    Friend WithEvents btnChange As System.Windows.Forms.Button
    Friend WithEvents btnNewItem As System.Windows.Forms.Button
    Friend WithEvents listVendorItems As System.Windows.Forms.ListBox
    Friend WithEvents checkViewer As System.Windows.Forms.CheckBox
    Friend WithEvents browserModel As System.Windows.Forms.WebBrowser
    Friend WithEvents lblTitleVendor As System.Windows.Forms.Label
    Friend WithEvents boxBasic As System.Windows.Forms.GroupBox
    Friend WithEvents numEntry As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblEntryCheck As System.Windows.Forms.Label
    Friend WithEvents lblEntry As System.Windows.Forms.Label
    Friend WithEvents boxInteraction As System.Windows.Forms.GroupBox
    Friend WithEvents numFaction As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblFactionCheck As System.Windows.Forms.Label
    Friend WithEvents lblFaction As System.Windows.Forms.Label
    Friend WithEvents checkRepair As System.Windows.Forms.CheckBox
    Friend WithEvents boxAppearance As System.Windows.Forms.GroupBox
    Friend WithEvents numModel As System.Windows.Forms.NumericUpDown
    Friend WithEvents numSize As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblSubname As System.Windows.Forms.Label
    Friend WithEvents txtSubname As System.Windows.Forms.TextBox
    Friend WithEvents lblModel As System.Windows.Forms.Label
    Friend WithEvents lblSize As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnSQL As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents tooltip As System.Windows.Forms.ToolTip
    Friend WithEvents checkFactionTimer As System.Windows.Forms.Timer
    Friend WithEvents checkEntryTimer As System.Windows.Forms.Timer
End Class
