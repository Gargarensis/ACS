<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuestRewards
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
        Me.tabItem = New System.Windows.Forms.TabPage
        Me.lblInfoItem = New System.Windows.Forms.Label
        Me.lblItemName4 = New System.Windows.Forms.Label
        Me.lblItemId4 = New System.Windows.Forms.Label
        Me.numItemId4 = New System.Windows.Forms.NumericUpDown
        Me.lblItemName3 = New System.Windows.Forms.Label
        Me.lblItemId3 = New System.Windows.Forms.Label
        Me.numItemId3 = New System.Windows.Forms.NumericUpDown
        Me.lblItemName2 = New System.Windows.Forms.Label
        Me.lblItemId2 = New System.Windows.Forms.Label
        Me.numItemId2 = New System.Windows.Forms.NumericUpDown
        Me.lblItemName1 = New System.Windows.Forms.Label
        Me.lblItemId1 = New System.Windows.Forms.Label
        Me.numItemId1 = New System.Windows.Forms.NumericUpDown
        Me.tabChoice = New System.Windows.Forms.TabPage
        Me.lblItemChoiceName6 = New System.Windows.Forms.Label
        Me.lblItemChoiceName5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblItemChoiceName4 = New System.Windows.Forms.Label
        Me.lblItemChoiceId6 = New System.Windows.Forms.Label
        Me.lblItemChoiceId5 = New System.Windows.Forms.Label
        Me.lblItemChoiceId4 = New System.Windows.Forms.Label
        Me.numItemChoice6 = New System.Windows.Forms.NumericUpDown
        Me.numItemChoice5 = New System.Windows.Forms.NumericUpDown
        Me.numItemChoice4 = New System.Windows.Forms.NumericUpDown
        Me.lblItemChoiceName3 = New System.Windows.Forms.Label
        Me.lblItemChoiceId3 = New System.Windows.Forms.Label
        Me.numItemChoice3 = New System.Windows.Forms.NumericUpDown
        Me.lblItemChoiceName2 = New System.Windows.Forms.Label
        Me.lblItemChoiceId2 = New System.Windows.Forms.Label
        Me.numItemChoice2 = New System.Windows.Forms.NumericUpDown
        Me.lblItemChoiceName1 = New System.Windows.Forms.Label
        Me.lblItemChoiceId1 = New System.Windows.Forms.Label
        Me.numItemChoice1 = New System.Windows.Forms.NumericUpDown
        Me.tabCurrenciesFaction = New System.Windows.Forms.TabPage
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.TabControl1.SuspendLayout()
        Me.tabItem.SuspendLayout()
        CType(Me.numItemId4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numItemId3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numItemId2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numItemId1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabChoice.SuspendLayout()
        CType(Me.numItemChoice6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numItemChoice5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numItemChoice4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numItemChoice3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numItemChoice2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numItemChoice1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabItem)
        Me.TabControl1.Controls.Add(Me.tabChoice)
        Me.TabControl1.Controls.Add(Me.tabCurrenciesFaction)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(433, 370)
        Me.TabControl1.TabIndex = 0
        '
        'tabItem
        '
        Me.tabItem.Controls.Add(Me.lblInfoItem)
        Me.tabItem.Controls.Add(Me.lblItemName4)
        Me.tabItem.Controls.Add(Me.lblItemId4)
        Me.tabItem.Controls.Add(Me.numItemId4)
        Me.tabItem.Controls.Add(Me.lblItemName3)
        Me.tabItem.Controls.Add(Me.lblItemId3)
        Me.tabItem.Controls.Add(Me.numItemId3)
        Me.tabItem.Controls.Add(Me.lblItemName2)
        Me.tabItem.Controls.Add(Me.lblItemId2)
        Me.tabItem.Controls.Add(Me.numItemId2)
        Me.tabItem.Controls.Add(Me.lblItemName1)
        Me.tabItem.Controls.Add(Me.lblItemId1)
        Me.tabItem.Controls.Add(Me.numItemId1)
        Me.tabItem.Location = New System.Drawing.Point(4, 25)
        Me.tabItem.Name = "tabItem"
        Me.tabItem.Padding = New System.Windows.Forms.Padding(3)
        Me.tabItem.Size = New System.Drawing.Size(425, 341)
        Me.tabItem.TabIndex = 0
        Me.tabItem.Text = "Items"
        Me.tabItem.UseVisualStyleBackColor = True
        '
        'lblInfoItem
        '
        Me.lblInfoItem.AutoSize = True
        Me.lblInfoItem.Location = New System.Drawing.Point(3, 310)
        Me.lblInfoItem.Name = "lblInfoItem"
        Me.lblInfoItem.Size = New System.Drawing.Size(265, 17)
        Me.lblInfoItem.TabIndex = 12
        Me.lblInfoItem.Text = "The player will get every item listed here."
        '
        'lblItemName4
        '
        Me.lblItemName4.AutoSize = True
        Me.lblItemName4.Location = New System.Drawing.Point(103, 175)
        Me.lblItemName4.Name = "lblItemName4"
        Me.lblItemName4.Size = New System.Drawing.Size(0, 17)
        Me.lblItemName4.TabIndex = 11
        '
        'lblItemId4
        '
        Me.lblItemId4.AutoSize = True
        Me.lblItemId4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemId4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblItemId4.Location = New System.Drawing.Point(6, 153)
        Me.lblItemId4.Name = "lblItemId4"
        Me.lblItemId4.Size = New System.Drawing.Size(23, 17)
        Me.lblItemId4.TabIndex = 10
        Me.lblItemId4.Text = "Id:"
        '
        'numItemId4
        '
        Me.numItemId4.Location = New System.Drawing.Point(6, 173)
        Me.numItemId4.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.numItemId4.Name = "numItemId4"
        Me.numItemId4.Size = New System.Drawing.Size(91, 22)
        Me.numItemId4.TabIndex = 9
        '
        'lblItemName3
        '
        Me.lblItemName3.AutoSize = True
        Me.lblItemName3.Location = New System.Drawing.Point(103, 125)
        Me.lblItemName3.Name = "lblItemName3"
        Me.lblItemName3.Size = New System.Drawing.Size(0, 17)
        Me.lblItemName3.TabIndex = 8
        '
        'lblItemId3
        '
        Me.lblItemId3.AutoSize = True
        Me.lblItemId3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemId3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblItemId3.Location = New System.Drawing.Point(6, 103)
        Me.lblItemId3.Name = "lblItemId3"
        Me.lblItemId3.Size = New System.Drawing.Size(23, 17)
        Me.lblItemId3.TabIndex = 7
        Me.lblItemId3.Text = "Id:"
        '
        'numItemId3
        '
        Me.numItemId3.Location = New System.Drawing.Point(6, 123)
        Me.numItemId3.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.numItemId3.Name = "numItemId3"
        Me.numItemId3.Size = New System.Drawing.Size(91, 22)
        Me.numItemId3.TabIndex = 6
        '
        'lblItemName2
        '
        Me.lblItemName2.AutoSize = True
        Me.lblItemName2.Location = New System.Drawing.Point(103, 74)
        Me.lblItemName2.Name = "lblItemName2"
        Me.lblItemName2.Size = New System.Drawing.Size(0, 17)
        Me.lblItemName2.TabIndex = 5
        '
        'lblItemId2
        '
        Me.lblItemId2.AutoSize = True
        Me.lblItemId2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemId2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblItemId2.Location = New System.Drawing.Point(6, 52)
        Me.lblItemId2.Name = "lblItemId2"
        Me.lblItemId2.Size = New System.Drawing.Size(23, 17)
        Me.lblItemId2.TabIndex = 4
        Me.lblItemId2.Text = "Id:"
        '
        'numItemId2
        '
        Me.numItemId2.Location = New System.Drawing.Point(6, 72)
        Me.numItemId2.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.numItemId2.Name = "numItemId2"
        Me.numItemId2.Size = New System.Drawing.Size(91, 22)
        Me.numItemId2.TabIndex = 3
        '
        'lblItemName1
        '
        Me.lblItemName1.AutoSize = True
        Me.lblItemName1.Location = New System.Drawing.Point(103, 28)
        Me.lblItemName1.Name = "lblItemName1"
        Me.lblItemName1.Size = New System.Drawing.Size(0, 17)
        Me.lblItemName1.TabIndex = 2
        '
        'lblItemId1
        '
        Me.lblItemId1.AutoSize = True
        Me.lblItemId1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemId1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblItemId1.Location = New System.Drawing.Point(6, 6)
        Me.lblItemId1.Name = "lblItemId1"
        Me.lblItemId1.Size = New System.Drawing.Size(23, 17)
        Me.lblItemId1.TabIndex = 1
        Me.lblItemId1.Text = "Id:"
        '
        'numItemId1
        '
        Me.numItemId1.Location = New System.Drawing.Point(6, 26)
        Me.numItemId1.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.numItemId1.Name = "numItemId1"
        Me.numItemId1.Size = New System.Drawing.Size(91, 22)
        Me.numItemId1.TabIndex = 0
        '
        'tabChoice
        '
        Me.tabChoice.Controls.Add(Me.lblItemChoiceName6)
        Me.tabChoice.Controls.Add(Me.lblItemChoiceName5)
        Me.tabChoice.Controls.Add(Me.Label1)
        Me.tabChoice.Controls.Add(Me.lblItemChoiceName4)
        Me.tabChoice.Controls.Add(Me.lblItemChoiceId6)
        Me.tabChoice.Controls.Add(Me.lblItemChoiceId5)
        Me.tabChoice.Controls.Add(Me.lblItemChoiceId4)
        Me.tabChoice.Controls.Add(Me.numItemChoice6)
        Me.tabChoice.Controls.Add(Me.numItemChoice5)
        Me.tabChoice.Controls.Add(Me.numItemChoice4)
        Me.tabChoice.Controls.Add(Me.lblItemChoiceName3)
        Me.tabChoice.Controls.Add(Me.lblItemChoiceId3)
        Me.tabChoice.Controls.Add(Me.numItemChoice3)
        Me.tabChoice.Controls.Add(Me.lblItemChoiceName2)
        Me.tabChoice.Controls.Add(Me.lblItemChoiceId2)
        Me.tabChoice.Controls.Add(Me.numItemChoice2)
        Me.tabChoice.Controls.Add(Me.lblItemChoiceName1)
        Me.tabChoice.Controls.Add(Me.lblItemChoiceId1)
        Me.tabChoice.Controls.Add(Me.numItemChoice1)
        Me.tabChoice.Location = New System.Drawing.Point(4, 25)
        Me.tabChoice.Name = "tabChoice"
        Me.tabChoice.Padding = New System.Windows.Forms.Padding(3)
        Me.tabChoice.Size = New System.Drawing.Size(425, 341)
        Me.tabChoice.TabIndex = 1
        Me.tabChoice.Text = "Choice Items"
        Me.tabChoice.UseVisualStyleBackColor = True
        '
        'lblItemChoiceName6
        '
        Me.lblItemChoiceName6.AutoSize = True
        Me.lblItemChoiceName6.Location = New System.Drawing.Point(103, 271)
        Me.lblItemChoiceName6.Name = "lblItemChoiceName6"
        Me.lblItemChoiceName6.Size = New System.Drawing.Size(0, 17)
        Me.lblItemChoiceName6.TabIndex = 26
        '
        'lblItemChoiceName5
        '
        Me.lblItemChoiceName5.AutoSize = True
        Me.lblItemChoiceName5.Location = New System.Drawing.Point(103, 222)
        Me.lblItemChoiceName5.Name = "lblItemChoiceName5"
        Me.lblItemChoiceName5.Size = New System.Drawing.Size(0, 17)
        Me.lblItemChoiceName5.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 310)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(338, 17)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "The player can choose only one item amongst them."
        '
        'lblItemChoiceName4
        '
        Me.lblItemChoiceName4.AutoSize = True
        Me.lblItemChoiceName4.Location = New System.Drawing.Point(103, 175)
        Me.lblItemChoiceName4.Name = "lblItemChoiceName4"
        Me.lblItemChoiceName4.Size = New System.Drawing.Size(0, 17)
        Me.lblItemChoiceName4.TabIndex = 24
        '
        'lblItemChoiceId6
        '
        Me.lblItemChoiceId6.AutoSize = True
        Me.lblItemChoiceId6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemChoiceId6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblItemChoiceId6.Location = New System.Drawing.Point(6, 251)
        Me.lblItemChoiceId6.Name = "lblItemChoiceId6"
        Me.lblItemChoiceId6.Size = New System.Drawing.Size(23, 17)
        Me.lblItemChoiceId6.TabIndex = 23
        Me.lblItemChoiceId6.Text = "Id:"
        '
        'lblItemChoiceId5
        '
        Me.lblItemChoiceId5.AutoSize = True
        Me.lblItemChoiceId5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemChoiceId5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblItemChoiceId5.Location = New System.Drawing.Point(6, 202)
        Me.lblItemChoiceId5.Name = "lblItemChoiceId5"
        Me.lblItemChoiceId5.Size = New System.Drawing.Size(23, 17)
        Me.lblItemChoiceId5.TabIndex = 23
        Me.lblItemChoiceId5.Text = "Id:"
        '
        'lblItemChoiceId4
        '
        Me.lblItemChoiceId4.AutoSize = True
        Me.lblItemChoiceId4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemChoiceId4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblItemChoiceId4.Location = New System.Drawing.Point(6, 153)
        Me.lblItemChoiceId4.Name = "lblItemChoiceId4"
        Me.lblItemChoiceId4.Size = New System.Drawing.Size(23, 17)
        Me.lblItemChoiceId4.TabIndex = 23
        Me.lblItemChoiceId4.Text = "Id:"
        '
        'numItemChoice6
        '
        Me.numItemChoice6.Location = New System.Drawing.Point(6, 271)
        Me.numItemChoice6.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.numItemChoice6.Name = "numItemChoice6"
        Me.numItemChoice6.Size = New System.Drawing.Size(91, 22)
        Me.numItemChoice6.TabIndex = 22
        '
        'numItemChoice5
        '
        Me.numItemChoice5.Location = New System.Drawing.Point(6, 222)
        Me.numItemChoice5.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.numItemChoice5.Name = "numItemChoice5"
        Me.numItemChoice5.Size = New System.Drawing.Size(91, 22)
        Me.numItemChoice5.TabIndex = 22
        '
        'numItemChoice4
        '
        Me.numItemChoice4.Location = New System.Drawing.Point(6, 173)
        Me.numItemChoice4.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.numItemChoice4.Name = "numItemChoice4"
        Me.numItemChoice4.Size = New System.Drawing.Size(91, 22)
        Me.numItemChoice4.TabIndex = 22
        '
        'lblItemChoiceName3
        '
        Me.lblItemChoiceName3.AutoSize = True
        Me.lblItemChoiceName3.Location = New System.Drawing.Point(103, 125)
        Me.lblItemChoiceName3.Name = "lblItemChoiceName3"
        Me.lblItemChoiceName3.Size = New System.Drawing.Size(0, 17)
        Me.lblItemChoiceName3.TabIndex = 21
        '
        'lblItemChoiceId3
        '
        Me.lblItemChoiceId3.AutoSize = True
        Me.lblItemChoiceId3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemChoiceId3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblItemChoiceId3.Location = New System.Drawing.Point(6, 103)
        Me.lblItemChoiceId3.Name = "lblItemChoiceId3"
        Me.lblItemChoiceId3.Size = New System.Drawing.Size(23, 17)
        Me.lblItemChoiceId3.TabIndex = 20
        Me.lblItemChoiceId3.Text = "Id:"
        '
        'numItemChoice3
        '
        Me.numItemChoice3.Location = New System.Drawing.Point(6, 123)
        Me.numItemChoice3.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.numItemChoice3.Name = "numItemChoice3"
        Me.numItemChoice3.Size = New System.Drawing.Size(91, 22)
        Me.numItemChoice3.TabIndex = 19
        '
        'lblItemChoiceName2
        '
        Me.lblItemChoiceName2.AutoSize = True
        Me.lblItemChoiceName2.Location = New System.Drawing.Point(103, 74)
        Me.lblItemChoiceName2.Name = "lblItemChoiceName2"
        Me.lblItemChoiceName2.Size = New System.Drawing.Size(0, 17)
        Me.lblItemChoiceName2.TabIndex = 18
        '
        'lblItemChoiceId2
        '
        Me.lblItemChoiceId2.AutoSize = True
        Me.lblItemChoiceId2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemChoiceId2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblItemChoiceId2.Location = New System.Drawing.Point(6, 52)
        Me.lblItemChoiceId2.Name = "lblItemChoiceId2"
        Me.lblItemChoiceId2.Size = New System.Drawing.Size(23, 17)
        Me.lblItemChoiceId2.TabIndex = 17
        Me.lblItemChoiceId2.Text = "Id:"
        '
        'numItemChoice2
        '
        Me.numItemChoice2.Location = New System.Drawing.Point(6, 72)
        Me.numItemChoice2.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.numItemChoice2.Name = "numItemChoice2"
        Me.numItemChoice2.Size = New System.Drawing.Size(91, 22)
        Me.numItemChoice2.TabIndex = 16
        '
        'lblItemChoiceName1
        '
        Me.lblItemChoiceName1.AutoSize = True
        Me.lblItemChoiceName1.Location = New System.Drawing.Point(103, 28)
        Me.lblItemChoiceName1.Name = "lblItemChoiceName1"
        Me.lblItemChoiceName1.Size = New System.Drawing.Size(0, 17)
        Me.lblItemChoiceName1.TabIndex = 15
        '
        'lblItemChoiceId1
        '
        Me.lblItemChoiceId1.AutoSize = True
        Me.lblItemChoiceId1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemChoiceId1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblItemChoiceId1.Location = New System.Drawing.Point(6, 6)
        Me.lblItemChoiceId1.Name = "lblItemChoiceId1"
        Me.lblItemChoiceId1.Size = New System.Drawing.Size(23, 17)
        Me.lblItemChoiceId1.TabIndex = 14
        Me.lblItemChoiceId1.Text = "Id:"
        '
        'numItemChoice1
        '
        Me.numItemChoice1.Location = New System.Drawing.Point(6, 26)
        Me.numItemChoice1.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.numItemChoice1.Name = "numItemChoice1"
        Me.numItemChoice1.Size = New System.Drawing.Size(91, 22)
        Me.numItemChoice1.TabIndex = 13
        '
        'tabCurrenciesFaction
        '
        Me.tabCurrenciesFaction.Location = New System.Drawing.Point(4, 25)
        Me.tabCurrenciesFaction.Name = "tabCurrenciesFaction"
        Me.tabCurrenciesFaction.Size = New System.Drawing.Size(425, 341)
        Me.tabCurrenciesFaction.TabIndex = 2
        Me.tabCurrenciesFaction.Text = "Currencies and Faction"
        Me.tabCurrenciesFaction.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(272, 384)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 40)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(353, 384)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 40)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'QuestRewards
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 436)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "QuestRewards"
        Me.Text = "Quest Rewards"
        Me.TabControl1.ResumeLayout(False)
        Me.tabItem.ResumeLayout(False)
        Me.tabItem.PerformLayout()
        CType(Me.numItemId4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numItemId3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numItemId2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numItemId1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabChoice.ResumeLayout(False)
        Me.tabChoice.PerformLayout()
        CType(Me.numItemChoice6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numItemChoice5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numItemChoice4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numItemChoice3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numItemChoice2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numItemChoice1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabItem As System.Windows.Forms.TabPage
    Friend WithEvents tabChoice As System.Windows.Forms.TabPage
    Friend WithEvents tabCurrenciesFaction As System.Windows.Forms.TabPage
    Friend WithEvents lblItemName1 As System.Windows.Forms.Label
    Friend WithEvents lblItemId1 As System.Windows.Forms.Label
    Friend WithEvents numItemId1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblItemName4 As System.Windows.Forms.Label
    Friend WithEvents lblItemId4 As System.Windows.Forms.Label
    Friend WithEvents numItemId4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblItemName3 As System.Windows.Forms.Label
    Friend WithEvents lblItemId3 As System.Windows.Forms.Label
    Friend WithEvents numItemId3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblItemName2 As System.Windows.Forms.Label
    Friend WithEvents lblItemId2 As System.Windows.Forms.Label
    Friend WithEvents numItemId2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblInfoItem As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblItemChoiceName4 As System.Windows.Forms.Label
    Friend WithEvents lblItemChoiceId4 As System.Windows.Forms.Label
    Friend WithEvents numItemChoice4 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblItemChoiceName3 As System.Windows.Forms.Label
    Friend WithEvents lblItemChoiceId3 As System.Windows.Forms.Label
    Friend WithEvents numItemChoice3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblItemChoiceName2 As System.Windows.Forms.Label
    Friend WithEvents lblItemChoiceId2 As System.Windows.Forms.Label
    Friend WithEvents numItemChoice2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblItemChoiceName1 As System.Windows.Forms.Label
    Friend WithEvents lblItemChoiceId1 As System.Windows.Forms.Label
    Friend WithEvents numItemChoice1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblItemChoiceName6 As System.Windows.Forms.Label
    Friend WithEvents lblItemChoiceName5 As System.Windows.Forms.Label
    Friend WithEvents lblItemChoiceId6 As System.Windows.Forms.Label
    Friend WithEvents lblItemChoiceId5 As System.Windows.Forms.Label
    Friend WithEvents numItemChoice6 As System.Windows.Forms.NumericUpDown
    Friend WithEvents numItemChoice5 As System.Windows.Forms.NumericUpDown
End Class
