<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuestForm
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
        Me.lblTitleQuest = New System.Windows.Forms.Label
        Me.boxBasic = New System.Windows.Forms.GroupBox
        Me.lblExperienceValue = New System.Windows.Forms.Label
        Me.numMaxLevel = New System.Windows.Forms.NumericUpDown
        Me.lblMaxLevel = New System.Windows.Forms.Label
        Me.numExperience = New System.Windows.Forms.NumericUpDown
        Me.lblExperience = New System.Windows.Forms.Label
        Me.numMinLevel = New System.Windows.Forms.NumericUpDown
        Me.lblMinLevel = New System.Windows.Forms.Label
        Me.numLevel = New System.Windows.Forms.NumericUpDown
        Me.Label2 = New System.Windows.Forms.Label
        Me.numZone = New System.Windows.Forms.NumericUpDown
        Me.lblZone = New System.Windows.Forms.Label
        Me.numPrevQuest = New System.Windows.Forms.NumericUpDown
        Me.lblPrevQuest = New System.Windows.Forms.Label
        Me.numNextQuest = New System.Windows.Forms.NumericUpDown
        Me.lblNextQuest = New System.Windows.Forms.Label
        Me.numId = New System.Windows.Forms.NumericUpDown
        Me.lblId = New System.Windows.Forms.Label
        Me.boxFlags = New System.Windows.Forms.GroupBox
        Me.chkRaid = New System.Windows.Forms.CheckBox
        Me.chkDaily = New System.Windows.Forms.CheckBox
        Me.chkWeekly = New System.Windows.Forms.CheckBox
        Me.chkRepeatable = New System.Windows.Forms.CheckBox
        Me.chkShare = New System.Windows.Forms.CheckBox
        Me.boxAllow = New System.Windows.Forms.GroupBox
        Me.lblRaces = New System.Windows.Forms.Label
        Me.lblClasses = New System.Windows.Forms.Label
        Me.btnRacesClassMask = New System.Windows.Forms.Button
        Me.boxStartItem = New System.Windows.Forms.GroupBox
        Me.lblProvidedName = New System.Windows.Forms.Label
        Me.lblProvidedItem = New System.Windows.Forms.Label
        Me.numProvidedCount = New System.Windows.Forms.NumericUpDown
        Me.lblStartItemCount = New System.Windows.Forms.Label
        Me.numProvidedId = New System.Windows.Forms.NumericUpDown
        Me.lblItemStart = New System.Windows.Forms.Label
        Me.boxRequirements = New System.Windows.Forms.GroupBox
        Me.lblFactionRequiredList = New System.Windows.Forms.Label
        Me.btnFactionRequired = New System.Windows.Forms.Button
        Me.lblCreatureKilledList = New System.Windows.Forms.Label
        Me.btnCreatuerRequired = New System.Windows.Forms.Button
        Me.lblItemrequiredList = New System.Windows.Forms.Label
        Me.btnRequireItems = New System.Windows.Forms.Button
        Me.boxQuestGiver = New System.Windows.Forms.GroupBox
        Me.btnAddTaker = New System.Windows.Forms.Button
        Me.listTakers = New System.Windows.Forms.ListBox
        Me.btnAddGiver = New System.Windows.Forms.Button
        Me.listGiver = New System.Windows.Forms.ListBox
        Me.boxRewards = New System.Windows.Forms.GroupBox
        Me.lblFac5 = New System.Windows.Forms.Label
        Me.lblFac4 = New System.Windows.Forms.Label
        Me.lblFac3 = New System.Windows.Forms.Label
        Me.lblFac2 = New System.Windows.Forms.Label
        Me.lblFac1 = New System.Windows.Forms.Label
        Me.btnRewards = New System.Windows.Forms.Button
        Me.questDisplay = New System.Windows.Forms.PictureBox
        Me.boxBasic.SuspendLayout()
        CType(Me.numMaxLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numExperience, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMinLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numZone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPrevQuest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numNextQuest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numId, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.boxFlags.SuspendLayout()
        Me.boxAllow.SuspendLayout()
        Me.boxStartItem.SuspendLayout()
        CType(Me.numProvidedCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numProvidedId, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.boxRequirements.SuspendLayout()
        Me.boxQuestGiver.SuspendLayout()
        Me.boxRewards.SuspendLayout()
        CType(Me.questDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitleQuest
        '
        Me.lblTitleQuest.AutoSize = True
        Me.lblTitleQuest.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleQuest.Location = New System.Drawing.Point(387, 9)
        Me.lblTitleQuest.Name = "lblTitleQuest"
        Me.lblTitleQuest.Size = New System.Drawing.Size(96, 32)
        Me.lblTitleQuest.TabIndex = 20
        Me.lblTitleQuest.Text = "Quest"
        '
        'boxBasic
        '
        Me.boxBasic.Controls.Add(Me.lblExperienceValue)
        Me.boxBasic.Controls.Add(Me.numMaxLevel)
        Me.boxBasic.Controls.Add(Me.lblMaxLevel)
        Me.boxBasic.Controls.Add(Me.numExperience)
        Me.boxBasic.Controls.Add(Me.lblExperience)
        Me.boxBasic.Controls.Add(Me.numMinLevel)
        Me.boxBasic.Controls.Add(Me.lblMinLevel)
        Me.boxBasic.Controls.Add(Me.numLevel)
        Me.boxBasic.Controls.Add(Me.Label2)
        Me.boxBasic.Controls.Add(Me.numZone)
        Me.boxBasic.Controls.Add(Me.lblZone)
        Me.boxBasic.Controls.Add(Me.numPrevQuest)
        Me.boxBasic.Controls.Add(Me.lblPrevQuest)
        Me.boxBasic.Controls.Add(Me.numNextQuest)
        Me.boxBasic.Controls.Add(Me.lblNextQuest)
        Me.boxBasic.Controls.Add(Me.numId)
        Me.boxBasic.Controls.Add(Me.lblId)
        Me.boxBasic.Location = New System.Drawing.Point(18, 44)
        Me.boxBasic.Name = "boxBasic"
        Me.boxBasic.Size = New System.Drawing.Size(270, 315)
        Me.boxBasic.TabIndex = 21
        Me.boxBasic.TabStop = False
        Me.boxBasic.Text = "Basic"
        '
        'lblExperienceValue
        '
        Me.lblExperienceValue.AutoSize = True
        Me.lblExperienceValue.ForeColor = System.Drawing.Color.Green
        Me.lblExperienceValue.Location = New System.Drawing.Point(116, 274)
        Me.lblExperienceValue.Name = "lblExperienceValue"
        Me.lblExperienceValue.Size = New System.Drawing.Size(113, 17)
        Me.lblExperienceValue.TabIndex = 34
        Me.lblExperienceValue.Text = "2200 experience"
        '
        'numMaxLevel
        '
        Me.numMaxLevel.Location = New System.Drawing.Point(185, 226)
        Me.numMaxLevel.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.numMaxLevel.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numMaxLevel.Name = "numMaxLevel"
        Me.numMaxLevel.Size = New System.Drawing.Size(59, 22)
        Me.numMaxLevel.TabIndex = 16
        Me.numMaxLevel.Value = New Decimal(New Integer() {80, 0, 0, 0})
        '
        'lblMaxLevel
        '
        Me.lblMaxLevel.AutoSize = True
        Me.lblMaxLevel.Location = New System.Drawing.Point(182, 206)
        Me.lblMaxLevel.Name = "lblMaxLevel"
        Me.lblMaxLevel.Size = New System.Drawing.Size(75, 17)
        Me.lblMaxLevel.TabIndex = 15
        Me.lblMaxLevel.Text = "Max Level:"
        '
        'numExperience
        '
        Me.numExperience.Location = New System.Drawing.Point(9, 272)
        Me.numExperience.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.numExperience.Name = "numExperience"
        Me.numExperience.Size = New System.Drawing.Size(100, 22)
        Me.numExperience.TabIndex = 33
        Me.numExperience.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblExperience
        '
        Me.lblExperience.AutoSize = True
        Me.lblExperience.Location = New System.Drawing.Point(6, 254)
        Me.lblExperience.Name = "lblExperience"
        Me.lblExperience.Size = New System.Drawing.Size(82, 17)
        Me.lblExperience.TabIndex = 32
        Me.lblExperience.Text = "Experience:"
        '
        'numMinLevel
        '
        Me.numMinLevel.Location = New System.Drawing.Point(103, 226)
        Me.numMinLevel.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.numMinLevel.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numMinLevel.Name = "numMinLevel"
        Me.numMinLevel.Size = New System.Drawing.Size(59, 22)
        Me.numMinLevel.TabIndex = 14
        Me.numMinLevel.Value = New Decimal(New Integer() {80, 0, 0, 0})
        '
        'lblMinLevel
        '
        Me.lblMinLevel.AutoSize = True
        Me.lblMinLevel.Location = New System.Drawing.Point(100, 206)
        Me.lblMinLevel.Name = "lblMinLevel"
        Me.lblMinLevel.Size = New System.Drawing.Size(72, 17)
        Me.lblMinLevel.TabIndex = 13
        Me.lblMinLevel.Text = "Min Level:"
        '
        'numLevel
        '
        Me.numLevel.Location = New System.Drawing.Point(9, 224)
        Me.numLevel.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.numLevel.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numLevel.Name = "numLevel"
        Me.numLevel.Size = New System.Drawing.Size(59, 22)
        Me.numLevel.TabIndex = 12
        Me.numLevel.Value = New Decimal(New Integer() {80, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Quest Level:"
        '
        'numZone
        '
        Me.numZone.Location = New System.Drawing.Point(9, 181)
        Me.numZone.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.numZone.Minimum = New Decimal(New Integer() {1000000, 0, 0, -2147483648})
        Me.numZone.Name = "numZone"
        Me.numZone.Size = New System.Drawing.Size(100, 22)
        Me.numZone.TabIndex = 10
        '
        'lblZone
        '
        Me.lblZone.AutoSize = True
        Me.lblZone.Location = New System.Drawing.Point(6, 163)
        Me.lblZone.Name = "lblZone"
        Me.lblZone.Size = New System.Drawing.Size(74, 17)
        Me.lblZone.TabIndex = 9
        Me.lblZone.Text = "Sorting ID:"
        '
        'numPrevQuest
        '
        Me.numPrevQuest.Location = New System.Drawing.Point(9, 134)
        Me.numPrevQuest.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.numPrevQuest.Name = "numPrevQuest"
        Me.numPrevQuest.Size = New System.Drawing.Size(100, 22)
        Me.numPrevQuest.TabIndex = 8
        '
        'lblPrevQuest
        '
        Me.lblPrevQuest.AutoSize = True
        Me.lblPrevQuest.Location = New System.Drawing.Point(6, 116)
        Me.lblPrevQuest.Name = "lblPrevQuest"
        Me.lblPrevQuest.Size = New System.Drawing.Size(126, 17)
        Me.lblPrevQuest.TabIndex = 7
        Me.lblPrevQuest.Text = "Previous Quest ID:"
        '
        'numNextQuest
        '
        Me.numNextQuest.Location = New System.Drawing.Point(9, 90)
        Me.numNextQuest.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.numNextQuest.Name = "numNextQuest"
        Me.numNextQuest.Size = New System.Drawing.Size(100, 22)
        Me.numNextQuest.TabIndex = 6
        '
        'lblNextQuest
        '
        Me.lblNextQuest.AutoSize = True
        Me.lblNextQuest.Location = New System.Drawing.Point(6, 72)
        Me.lblNextQuest.Name = "lblNextQuest"
        Me.lblNextQuest.Size = New System.Drawing.Size(99, 17)
        Me.lblNextQuest.TabIndex = 5
        Me.lblNextQuest.Text = "Next Quest ID:"
        '
        'numId
        '
        Me.numId.Location = New System.Drawing.Point(9, 47)
        Me.numId.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.numId.Name = "numId"
        Me.numId.Size = New System.Drawing.Size(100, 22)
        Me.numId.TabIndex = 4
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(6, 29)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(25, 17)
        Me.lblId.TabIndex = 3
        Me.lblId.Text = "ID:"
        '
        'boxFlags
        '
        Me.boxFlags.Controls.Add(Me.chkRaid)
        Me.boxFlags.Controls.Add(Me.chkDaily)
        Me.boxFlags.Controls.Add(Me.chkWeekly)
        Me.boxFlags.Controls.Add(Me.chkRepeatable)
        Me.boxFlags.Controls.Add(Me.chkShare)
        Me.boxFlags.Location = New System.Drawing.Point(18, 365)
        Me.boxFlags.Name = "boxFlags"
        Me.boxFlags.Size = New System.Drawing.Size(270, 159)
        Me.boxFlags.TabIndex = 22
        Me.boxFlags.TabStop = False
        Me.boxFlags.Text = "Flags"
        '
        'chkRaid
        '
        Me.chkRaid.AutoSize = True
        Me.chkRaid.Location = New System.Drawing.Point(6, 48)
        Me.chkRaid.Name = "chkRaid"
        Me.chkRaid.Size = New System.Drawing.Size(59, 21)
        Me.chkRaid.TabIndex = 5
        Me.chkRaid.Text = "Raid"
        Me.chkRaid.UseVisualStyleBackColor = True
        '
        'chkDaily
        '
        Me.chkDaily.AutoSize = True
        Me.chkDaily.Location = New System.Drawing.Point(6, 102)
        Me.chkDaily.Name = "chkDaily"
        Me.chkDaily.Size = New System.Drawing.Size(61, 21)
        Me.chkDaily.TabIndex = 4
        Me.chkDaily.Text = "Daily"
        Me.chkDaily.UseVisualStyleBackColor = True
        '
        'chkWeekly
        '
        Me.chkWeekly.AutoSize = True
        Me.chkWeekly.Location = New System.Drawing.Point(6, 129)
        Me.chkWeekly.Name = "chkWeekly"
        Me.chkWeekly.Size = New System.Drawing.Size(76, 21)
        Me.chkWeekly.TabIndex = 3
        Me.chkWeekly.Text = "Weekly"
        Me.chkWeekly.UseVisualStyleBackColor = True
        '
        'chkRepeatable
        '
        Me.chkRepeatable.AutoSize = True
        Me.chkRepeatable.Location = New System.Drawing.Point(6, 75)
        Me.chkRepeatable.Name = "chkRepeatable"
        Me.chkRepeatable.Size = New System.Drawing.Size(103, 21)
        Me.chkRepeatable.TabIndex = 2
        Me.chkRepeatable.Text = "Repeatable"
        Me.chkRepeatable.UseVisualStyleBackColor = True
        '
        'chkShare
        '
        Me.chkShare.AutoSize = True
        Me.chkShare.Location = New System.Drawing.Point(6, 21)
        Me.chkShare.Name = "chkShare"
        Me.chkShare.Size = New System.Drawing.Size(87, 21)
        Me.chkShare.TabIndex = 1
        Me.chkShare.Text = "Sharable"
        Me.chkShare.UseVisualStyleBackColor = True
        '
        'boxAllow
        '
        Me.boxAllow.Controls.Add(Me.lblRaces)
        Me.boxAllow.Controls.Add(Me.lblClasses)
        Me.boxAllow.Controls.Add(Me.btnRacesClassMask)
        Me.boxAllow.Location = New System.Drawing.Point(18, 528)
        Me.boxAllow.Name = "boxAllow"
        Me.boxAllow.Size = New System.Drawing.Size(270, 134)
        Me.boxAllow.TabIndex = 23
        Me.boxAllow.TabStop = False
        Me.boxAllow.Text = "Allow to take quest"
        '
        'lblRaces
        '
        Me.lblRaces.AutoSize = True
        Me.lblRaces.Location = New System.Drawing.Point(14, 90)
        Me.lblRaces.Name = "lblRaces"
        Me.lblRaces.Size = New System.Drawing.Size(101, 17)
        Me.lblRaces.TabIndex = 35
        Me.lblRaces.Text = "Races mask: 0"
        '
        'lblClasses
        '
        Me.lblClasses.AutoSize = True
        Me.lblClasses.Location = New System.Drawing.Point(14, 63)
        Me.lblClasses.Name = "lblClasses"
        Me.lblClasses.Size = New System.Drawing.Size(110, 17)
        Me.lblClasses.TabIndex = 34
        Me.lblClasses.Text = "Classes mask: 0"
        '
        'btnRacesClassMask
        '
        Me.btnRacesClassMask.Location = New System.Drawing.Point(17, 21)
        Me.btnRacesClassMask.Name = "btnRacesClassMask"
        Me.btnRacesClassMask.Size = New System.Drawing.Size(237, 34)
        Me.btnRacesClassMask.TabIndex = 33
        Me.btnRacesClassMask.Text = "Show choices..."
        Me.btnRacesClassMask.UseVisualStyleBackColor = True
        '
        'boxStartItem
        '
        Me.boxStartItem.Controls.Add(Me.lblProvidedName)
        Me.boxStartItem.Controls.Add(Me.lblProvidedItem)
        Me.boxStartItem.Controls.Add(Me.numProvidedCount)
        Me.boxStartItem.Controls.Add(Me.lblStartItemCount)
        Me.boxStartItem.Controls.Add(Me.numProvidedId)
        Me.boxStartItem.Controls.Add(Me.lblItemStart)
        Me.boxStartItem.Location = New System.Drawing.Point(298, 44)
        Me.boxStartItem.Name = "boxStartItem"
        Me.boxStartItem.Size = New System.Drawing.Size(198, 102)
        Me.boxStartItem.TabIndex = 24
        Me.boxStartItem.TabStop = False
        Me.boxStartItem.Text = "Start Item"
        '
        'lblProvidedName
        '
        Me.lblProvidedName.AutoSize = True
        Me.lblProvidedName.Location = New System.Drawing.Point(6, 64)
        Me.lblProvidedName.Name = "lblProvidedName"
        Me.lblProvidedName.Size = New System.Drawing.Size(0, 17)
        Me.lblProvidedName.TabIndex = 22
        '
        'lblProvidedItem
        '
        Me.lblProvidedItem.AutoSize = True
        Me.lblProvidedItem.Location = New System.Drawing.Point(185, 41)
        Me.lblProvidedItem.Name = "lblProvidedItem"
        Me.lblProvidedItem.Size = New System.Drawing.Size(0, 17)
        Me.lblProvidedItem.TabIndex = 21
        '
        'numProvidedCount
        '
        Me.numProvidedCount.Location = New System.Drawing.Point(133, 39)
        Me.numProvidedCount.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.numProvidedCount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numProvidedCount.Name = "numProvidedCount"
        Me.numProvidedCount.Size = New System.Drawing.Size(46, 22)
        Me.numProvidedCount.TabIndex = 20
        Me.numProvidedCount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblStartItemCount
        '
        Me.lblStartItemCount.AutoSize = True
        Me.lblStartItemCount.Location = New System.Drawing.Point(130, 21)
        Me.lblStartItemCount.Name = "lblStartItemCount"
        Me.lblStartItemCount.Size = New System.Drawing.Size(49, 17)
        Me.lblStartItemCount.TabIndex = 19
        Me.lblStartItemCount.Text = "Count:"
        '
        'numProvidedId
        '
        Me.numProvidedId.Location = New System.Drawing.Point(6, 39)
        Me.numProvidedId.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.numProvidedId.Name = "numProvidedId"
        Me.numProvidedId.Size = New System.Drawing.Size(100, 22)
        Me.numProvidedId.TabIndex = 18
        '
        'lblItemStart
        '
        Me.lblItemStart.AutoSize = True
        Me.lblItemStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemStart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblItemStart.Location = New System.Drawing.Point(3, 21)
        Me.lblItemStart.Name = "lblItemStart"
        Me.lblItemStart.Size = New System.Drawing.Size(98, 17)
        Me.lblItemStart.TabIndex = 17
        Me.lblItemStart.Text = "Provided item:"
        '
        'boxRequirements
        '
        Me.boxRequirements.Controls.Add(Me.lblFactionRequiredList)
        Me.boxRequirements.Controls.Add(Me.btnFactionRequired)
        Me.boxRequirements.Controls.Add(Me.lblCreatureKilledList)
        Me.boxRequirements.Controls.Add(Me.btnCreatuerRequired)
        Me.boxRequirements.Controls.Add(Me.lblItemrequiredList)
        Me.boxRequirements.Controls.Add(Me.btnRequireItems)
        Me.boxRequirements.Location = New System.Drawing.Point(298, 380)
        Me.boxRequirements.Name = "boxRequirements"
        Me.boxRequirements.Size = New System.Drawing.Size(198, 157)
        Me.boxRequirements.TabIndex = 25
        Me.boxRequirements.TabStop = False
        Me.boxRequirements.Text = "Requirements to complete"
        '
        'lblFactionRequiredList
        '
        Me.lblFactionRequiredList.AutoSize = True
        Me.lblFactionRequiredList.Cursor = System.Windows.Forms.Cursors.Help
        Me.lblFactionRequiredList.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFactionRequiredList.ForeColor = System.Drawing.Color.Blue
        Me.lblFactionRequiredList.Location = New System.Drawing.Point(164, 118)
        Me.lblFactionRequiredList.Name = "lblFactionRequiredList"
        Me.lblFactionRequiredList.Size = New System.Drawing.Size(34, 17)
        Me.lblFactionRequiredList.TabIndex = 37
        Me.lblFactionRequiredList.Text = "List"
        '
        'btnFactionRequired
        '
        Me.btnFactionRequired.Location = New System.Drawing.Point(6, 109)
        Me.btnFactionRequired.Name = "btnFactionRequired"
        Me.btnFactionRequired.Size = New System.Drawing.Size(152, 35)
        Me.btnFactionRequired.TabIndex = 36
        Me.btnFactionRequired.Text = "Faction Required..."
        Me.btnFactionRequired.UseVisualStyleBackColor = True
        '
        'lblCreatureKilledList
        '
        Me.lblCreatureKilledList.AutoSize = True
        Me.lblCreatureKilledList.Cursor = System.Windows.Forms.Cursors.Help
        Me.lblCreatureKilledList.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreatureKilledList.ForeColor = System.Drawing.Color.Blue
        Me.lblCreatureKilledList.Location = New System.Drawing.Point(164, 77)
        Me.lblCreatureKilledList.Name = "lblCreatureKilledList"
        Me.lblCreatureKilledList.Size = New System.Drawing.Size(34, 17)
        Me.lblCreatureKilledList.TabIndex = 35
        Me.lblCreatureKilledList.Text = "List"
        '
        'btnCreatuerRequired
        '
        Me.btnCreatuerRequired.Location = New System.Drawing.Point(6, 68)
        Me.btnCreatuerRequired.Name = "btnCreatuerRequired"
        Me.btnCreatuerRequired.Size = New System.Drawing.Size(152, 35)
        Me.btnCreatuerRequired.TabIndex = 34
        Me.btnCreatuerRequired.Text = "Creature Killed..."
        Me.btnCreatuerRequired.UseVisualStyleBackColor = True
        '
        'lblItemrequiredList
        '
        Me.lblItemrequiredList.AutoSize = True
        Me.lblItemrequiredList.Cursor = System.Windows.Forms.Cursors.Help
        Me.lblItemrequiredList.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemrequiredList.ForeColor = System.Drawing.Color.Blue
        Me.lblItemrequiredList.Location = New System.Drawing.Point(164, 36)
        Me.lblItemrequiredList.Name = "lblItemrequiredList"
        Me.lblItemrequiredList.Size = New System.Drawing.Size(34, 17)
        Me.lblItemrequiredList.TabIndex = 33
        Me.lblItemrequiredList.Text = "List"
        '
        'btnRequireItems
        '
        Me.btnRequireItems.Location = New System.Drawing.Point(6, 27)
        Me.btnRequireItems.Name = "btnRequireItems"
        Me.btnRequireItems.Size = New System.Drawing.Size(152, 35)
        Me.btnRequireItems.TabIndex = 32
        Me.btnRequireItems.Text = "Item Required..."
        Me.btnRequireItems.UseVisualStyleBackColor = True
        '
        'boxQuestGiver
        '
        Me.boxQuestGiver.Controls.Add(Me.btnAddTaker)
        Me.boxQuestGiver.Controls.Add(Me.listTakers)
        Me.boxQuestGiver.Controls.Add(Me.btnAddGiver)
        Me.boxQuestGiver.Controls.Add(Me.listGiver)
        Me.boxQuestGiver.Location = New System.Drawing.Point(298, 548)
        Me.boxQuestGiver.Name = "boxQuestGiver"
        Me.boxQuestGiver.Size = New System.Drawing.Size(198, 127)
        Me.boxQuestGiver.TabIndex = 27
        Me.boxQuestGiver.TabStop = False
        Me.boxQuestGiver.Text = "Quest Giver and Taker"
        '
        'btnAddTaker
        '
        Me.btnAddTaker.Location = New System.Drawing.Point(148, 21)
        Me.btnAddTaker.Name = "btnAddTaker"
        Me.btnAddTaker.Size = New System.Drawing.Size(89, 35)
        Me.btnAddTaker.TabIndex = 3
        Me.btnAddTaker.Text = "Add Taker"
        Me.btnAddTaker.UseVisualStyleBackColor = True
        '
        'listTakers
        '
        Me.listTakers.FormattingEnabled = True
        Me.listTakers.ItemHeight = 16
        Me.listTakers.Location = New System.Drawing.Point(133, 62)
        Me.listTakers.Name = "listTakers"
        Me.listTakers.Size = New System.Drawing.Size(117, 52)
        Me.listTakers.TabIndex = 2
        '
        'btnAddGiver
        '
        Me.btnAddGiver.Location = New System.Drawing.Point(17, 21)
        Me.btnAddGiver.Name = "btnAddGiver"
        Me.btnAddGiver.Size = New System.Drawing.Size(89, 35)
        Me.btnAddGiver.TabIndex = 1
        Me.btnAddGiver.Text = "Add Giver"
        Me.btnAddGiver.UseVisualStyleBackColor = True
        '
        'listGiver
        '
        Me.listGiver.FormattingEnabled = True
        Me.listGiver.ItemHeight = 16
        Me.listGiver.Location = New System.Drawing.Point(6, 62)
        Me.listGiver.Name = "listGiver"
        Me.listGiver.Size = New System.Drawing.Size(109, 52)
        Me.listGiver.TabIndex = 0
        '
        'boxRewards
        '
        Me.boxRewards.Controls.Add(Me.lblFac5)
        Me.boxRewards.Controls.Add(Me.lblFac4)
        Me.boxRewards.Controls.Add(Me.lblFac3)
        Me.boxRewards.Controls.Add(Me.lblFac2)
        Me.boxRewards.Controls.Add(Me.lblFac1)
        Me.boxRewards.Controls.Add(Me.btnRewards)
        Me.boxRewards.Location = New System.Drawing.Point(298, 150)
        Me.boxRewards.Name = "boxRewards"
        Me.boxRewards.Size = New System.Drawing.Size(198, 209)
        Me.boxRewards.TabIndex = 33
        Me.boxRewards.TabStop = False
        Me.boxRewards.Text = "Rewards"
        '
        'lblFac5
        '
        Me.lblFac5.AutoSize = True
        Me.lblFac5.Location = New System.Drawing.Point(14, 161)
        Me.lblFac5.Name = "lblFac5"
        Me.lblFac5.Size = New System.Drawing.Size(0, 17)
        Me.lblFac5.TabIndex = 35
        '
        'lblFac4
        '
        Me.lblFac4.AutoSize = True
        Me.lblFac4.Location = New System.Drawing.Point(14, 138)
        Me.lblFac4.Name = "lblFac4"
        Me.lblFac4.Size = New System.Drawing.Size(0, 17)
        Me.lblFac4.TabIndex = 34
        '
        'lblFac3
        '
        Me.lblFac3.AutoSize = True
        Me.lblFac3.Location = New System.Drawing.Point(14, 115)
        Me.lblFac3.Name = "lblFac3"
        Me.lblFac3.Size = New System.Drawing.Size(0, 17)
        Me.lblFac3.TabIndex = 3
        '
        'lblFac2
        '
        Me.lblFac2.AutoSize = True
        Me.lblFac2.Location = New System.Drawing.Point(14, 90)
        Me.lblFac2.Name = "lblFac2"
        Me.lblFac2.Size = New System.Drawing.Size(0, 17)
        Me.lblFac2.TabIndex = 2
        '
        'lblFac1
        '
        Me.lblFac1.AutoSize = True
        Me.lblFac1.Location = New System.Drawing.Point(14, 67)
        Me.lblFac1.Name = "lblFac1"
        Me.lblFac1.Size = New System.Drawing.Size(0, 17)
        Me.lblFac1.TabIndex = 1
        '
        'btnRewards
        '
        Me.btnRewards.Location = New System.Drawing.Point(6, 21)
        Me.btnRewards.Name = "btnRewards"
        Me.btnRewards.Size = New System.Drawing.Size(179, 40)
        Me.btnRewards.TabIndex = 0
        Me.btnRewards.Text = "Rewards..."
        Me.btnRewards.UseVisualStyleBackColor = True
        '
        'questDisplay
        '
        Me.questDisplay.BackgroundImage = Global.ACS.My.Resources.Resources.Empty_Quest_Log
        Me.questDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.questDisplay.Location = New System.Drawing.Point(502, 12)
        Me.questDisplay.Name = "questDisplay"
        Me.questDisplay.Size = New System.Drawing.Size(446, 663)
        Me.questDisplay.TabIndex = 28
        Me.questDisplay.TabStop = False
        '
        'QuestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 700)
        Me.Controls.Add(Me.boxRewards)
        Me.Controls.Add(Me.questDisplay)
        Me.Controls.Add(Me.boxQuestGiver)
        Me.Controls.Add(Me.boxRequirements)
        Me.Controls.Add(Me.boxStartItem)
        Me.Controls.Add(Me.boxAllow)
        Me.Controls.Add(Me.boxFlags)
        Me.Controls.Add(Me.boxBasic)
        Me.Controls.Add(Me.lblTitleQuest)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "QuestForm"
        Me.Tag = "QuestForm"
        Me.Text = "Quest"
        Me.boxBasic.ResumeLayout(False)
        Me.boxBasic.PerformLayout()
        CType(Me.numMaxLevel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numExperience, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMinLevel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numLevel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numZone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPrevQuest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numNextQuest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numId, System.ComponentModel.ISupportInitialize).EndInit()
        Me.boxFlags.ResumeLayout(False)
        Me.boxFlags.PerformLayout()
        Me.boxAllow.ResumeLayout(False)
        Me.boxAllow.PerformLayout()
        Me.boxStartItem.ResumeLayout(False)
        Me.boxStartItem.PerformLayout()
        CType(Me.numProvidedCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numProvidedId, System.ComponentModel.ISupportInitialize).EndInit()
        Me.boxRequirements.ResumeLayout(False)
        Me.boxRequirements.PerformLayout()
        Me.boxQuestGiver.ResumeLayout(False)
        Me.boxRewards.ResumeLayout(False)
        Me.boxRewards.PerformLayout()
        CType(Me.questDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitleQuest As System.Windows.Forms.Label
    Friend WithEvents boxBasic As System.Windows.Forms.GroupBox
    Friend WithEvents numPrevQuest As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblPrevQuest As System.Windows.Forms.Label
    Friend WithEvents numNextQuest As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblNextQuest As System.Windows.Forms.Label
    Friend WithEvents numId As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents numMaxLevel As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblMaxLevel As System.Windows.Forms.Label
    Friend WithEvents numMinLevel As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblMinLevel As System.Windows.Forms.Label
    Friend WithEvents numLevel As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents numZone As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblZone As System.Windows.Forms.Label
    Friend WithEvents boxFlags As System.Windows.Forms.GroupBox
    Friend WithEvents chkRaid As System.Windows.Forms.CheckBox
    Friend WithEvents chkRepeatable As System.Windows.Forms.CheckBox
    Friend WithEvents chkShare As System.Windows.Forms.CheckBox
    Friend WithEvents chkDaily As System.Windows.Forms.CheckBox
    Friend WithEvents chkWeekly As System.Windows.Forms.CheckBox
    Friend WithEvents boxAllow As System.Windows.Forms.GroupBox
    Friend WithEvents boxStartItem As System.Windows.Forms.GroupBox
    Friend WithEvents numProvidedId As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblItemStart As System.Windows.Forms.Label
    Friend WithEvents lblProvidedItem As System.Windows.Forms.Label
    Friend WithEvents numProvidedCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblStartItemCount As System.Windows.Forms.Label
    Friend WithEvents boxRequirements As System.Windows.Forms.GroupBox
    Friend WithEvents lblCreatureKilledList As System.Windows.Forms.Label
    Friend WithEvents btnCreatuerRequired As System.Windows.Forms.Button
    Friend WithEvents lblItemrequiredList As System.Windows.Forms.Label
    Friend WithEvents btnRequireItems As System.Windows.Forms.Button
    Friend WithEvents lblFactionRequiredList As System.Windows.Forms.Label
    Friend WithEvents btnFactionRequired As System.Windows.Forms.Button
    Friend WithEvents boxQuestGiver As System.Windows.Forms.GroupBox
    Friend WithEvents btnAddTaker As System.Windows.Forms.Button
    Friend WithEvents listTakers As System.Windows.Forms.ListBox
    Friend WithEvents btnAddGiver As System.Windows.Forms.Button
    Friend WithEvents listGiver As System.Windows.Forms.ListBox
    Friend WithEvents questDisplay As System.Windows.Forms.PictureBox
    Friend WithEvents lblExperienceValue As System.Windows.Forms.Label
    Friend WithEvents numExperience As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblExperience As System.Windows.Forms.Label
    Friend WithEvents btnRacesClassMask As System.Windows.Forms.Button
    Friend WithEvents lblRaces As System.Windows.Forms.Label
    Friend WithEvents lblClasses As System.Windows.Forms.Label
    Friend WithEvents boxRewards As System.Windows.Forms.GroupBox
    Friend WithEvents btnRewards As System.Windows.Forms.Button
    Friend WithEvents lblProvidedName As System.Windows.Forms.Label
    Friend WithEvents lblFac5 As System.Windows.Forms.Label
    Friend WithEvents lblFac4 As System.Windows.Forms.Label
    Friend WithEvents lblFac3 As System.Windows.Forms.Label
    Friend WithEvents lblFac2 As System.Windows.Forms.Label
    Friend WithEvents lblFac1 As System.Windows.Forms.Label
End Class
