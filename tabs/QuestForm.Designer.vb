<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QuestForm
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
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitleQuest = New System.Windows.Forms.Label()
        Me.boxBasic = New System.Windows.Forms.GroupBox()
        Me.lblSortIdName = New System.Windows.Forms.Label()
        Me.lblExperienceValue = New System.Windows.Forms.Label()
        Me.numMaxLevel = New System.Windows.Forms.NumericUpDown()
        Me.lblMaxLevel = New System.Windows.Forms.Label()
        Me.numExperience = New System.Windows.Forms.NumericUpDown()
        Me.lblExperience = New System.Windows.Forms.Label()
        Me.numMinLevel = New System.Windows.Forms.NumericUpDown()
        Me.lblMinLevel = New System.Windows.Forms.Label()
        Me.numLevel = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numZone = New System.Windows.Forms.NumericUpDown()
        Me.lblZone = New System.Windows.Forms.Label()
        Me.numPrevQuest = New System.Windows.Forms.NumericUpDown()
        Me.lblPrevQuest = New System.Windows.Forms.Label()
        Me.numNextQuest = New System.Windows.Forms.NumericUpDown()
        Me.lblNextQuest = New System.Windows.Forms.Label()
        Me.numId = New System.Windows.Forms.NumericUpDown()
        Me.lblId = New System.Windows.Forms.Label()
        Me.boxFlags = New System.Windows.Forms.GroupBox()
        Me.chkRaid = New System.Windows.Forms.CheckBox()
        Me.chkDaily = New System.Windows.Forms.CheckBox()
        Me.chkWeekly = New System.Windows.Forms.CheckBox()
        Me.chkRepeatable = New System.Windows.Forms.CheckBox()
        Me.chkShare = New System.Windows.Forms.CheckBox()
        Me.boxAllow = New System.Windows.Forms.GroupBox()
        Me.lblRaces = New System.Windows.Forms.Label()
        Me.lblClasses = New System.Windows.Forms.Label()
        Me.btnRacesClassMask = New System.Windows.Forms.Button()
        Me.boxStartItem = New System.Windows.Forms.GroupBox()
        Me.lblProvidedName = New System.Windows.Forms.Label()
        Me.numProvidedCount = New System.Windows.Forms.NumericUpDown()
        Me.lblStartItemCount = New System.Windows.Forms.Label()
        Me.numProvidedId = New System.Windows.Forms.NumericUpDown()
        Me.lblItemStart = New System.Windows.Forms.Label()
        Me.boxRequirements = New System.Windows.Forms.GroupBox()
        Me.lblObj5 = New System.Windows.Forms.Label()
        Me.lblObj4 = New System.Windows.Forms.Label()
        Me.lblObj3 = New System.Windows.Forms.Label()
        Me.lblObj2 = New System.Windows.Forms.Label()
        Me.lblObj1 = New System.Windows.Forms.Label()
        Me.btnRequirements = New System.Windows.Forms.Button()
        Me.boxRewards = New System.Windows.Forms.GroupBox()
        Me.lblFac5 = New System.Windows.Forms.Label()
        Me.lblFac4 = New System.Windows.Forms.Label()
        Me.lblFac3 = New System.Windows.Forms.Label()
        Me.lblFac2 = New System.Windows.Forms.Label()
        Me.lblFac1 = New System.Windows.Forms.Label()
        Me.btnRewards = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnSQL = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.listGivers = New System.Windows.Forms.ListBox()
        Me.btnAddGiver = New System.Windows.Forms.Button()
        Me.listTakers = New System.Windows.Forms.ListBox()
        Me.btnAddTaker = New System.Windows.Forms.Button()
        Me.boxQuestGiver = New System.Windows.Forms.GroupBox()
        Me.questDisplay = New System.Windows.Forms.PictureBox()
        Me.btnText = New System.Windows.Forms.Button()
        Me.btnEmote = New System.Windows.Forms.Button()
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
        Me.boxRewards.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.boxQuestGiver.SuspendLayout()
        CType(Me.questDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitleQuest
        '
        Me.lblTitleQuest.AutoSize = True
        Me.lblTitleQuest.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleQuest.Location = New System.Drawing.Point(291, -1)
        Me.lblTitleQuest.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitleQuest.Name = "lblTitleQuest"
        Me.lblTitleQuest.Size = New System.Drawing.Size(75, 26)
        Me.lblTitleQuest.TabIndex = 20
        Me.lblTitleQuest.Text = "Quest"
        '
        'boxBasic
        '
        Me.boxBasic.Controls.Add(Me.lblSortIdName)
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
        Me.boxBasic.Location = New System.Drawing.Point(9, 28)
        Me.boxBasic.Margin = New System.Windows.Forms.Padding(2)
        Me.boxBasic.Name = "boxBasic"
        Me.boxBasic.Padding = New System.Windows.Forms.Padding(2)
        Me.boxBasic.Size = New System.Drawing.Size(148, 301)
        Me.boxBasic.TabIndex = 21
        Me.boxBasic.TabStop = False
        Me.boxBasic.Text = "Basic"
        '
        'lblSortIdName
        '
        Me.lblSortIdName.AutoSize = True
        Me.lblSortIdName.Location = New System.Drawing.Point(4, 166)
        Me.lblSortIdName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSortIdName.Name = "lblSortIdName"
        Me.lblSortIdName.Size = New System.Drawing.Size(0, 13)
        Me.lblSortIdName.TabIndex = 35
        '
        'lblExperienceValue
        '
        Me.lblExperienceValue.AutoSize = True
        Me.lblExperienceValue.ForeColor = System.Drawing.Color.Green
        Me.lblExperienceValue.Location = New System.Drawing.Point(53, 275)
        Me.lblExperienceValue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblExperienceValue.Name = "lblExperienceValue"
        Me.lblExperienceValue.Size = New System.Drawing.Size(86, 13)
        Me.lblExperienceValue.TabIndex = 34
        Me.lblExperienceValue.Text = "2200 experience"
        '
        'numMaxLevel
        '
        Me.numMaxLevel.Location = New System.Drawing.Point(66, 235)
        Me.numMaxLevel.Margin = New System.Windows.Forms.Padding(2)
        Me.numMaxLevel.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.numMaxLevel.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numMaxLevel.Name = "numMaxLevel"
        Me.numMaxLevel.Size = New System.Drawing.Size(44, 20)
        Me.numMaxLevel.TabIndex = 7
        Me.numMaxLevel.Value = New Decimal(New Integer() {80, 0, 0, 0})
        '
        'lblMaxLevel
        '
        Me.lblMaxLevel.AutoSize = True
        Me.lblMaxLevel.Location = New System.Drawing.Point(64, 219)
        Me.lblMaxLevel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMaxLevel.Name = "lblMaxLevel"
        Me.lblMaxLevel.Size = New System.Drawing.Size(59, 13)
        Me.lblMaxLevel.TabIndex = 15
        Me.lblMaxLevel.Text = "Max Level:"
        '
        'numExperience
        '
        Me.numExperience.Location = New System.Drawing.Point(7, 274)
        Me.numExperience.Margin = New System.Windows.Forms.Padding(2)
        Me.numExperience.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.numExperience.Name = "numExperience"
        Me.numExperience.Size = New System.Drawing.Size(42, 20)
        Me.numExperience.TabIndex = 8
        Me.numExperience.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblExperience
        '
        Me.lblExperience.AutoSize = True
        Me.lblExperience.Location = New System.Drawing.Point(4, 259)
        Me.lblExperience.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblExperience.Name = "lblExperience"
        Me.lblExperience.Size = New System.Drawing.Size(63, 13)
        Me.lblExperience.TabIndex = 32
        Me.lblExperience.Text = "Experience:"
        '
        'numMinLevel
        '
        Me.numMinLevel.Location = New System.Drawing.Point(7, 235)
        Me.numMinLevel.Margin = New System.Windows.Forms.Padding(2)
        Me.numMinLevel.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.numMinLevel.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numMinLevel.Name = "numMinLevel"
        Me.numMinLevel.Size = New System.Drawing.Size(44, 20)
        Me.numMinLevel.TabIndex = 6
        Me.numMinLevel.Value = New Decimal(New Integer() {80, 0, 0, 0})
        '
        'lblMinLevel
        '
        Me.lblMinLevel.AutoSize = True
        Me.lblMinLevel.Location = New System.Drawing.Point(4, 219)
        Me.lblMinLevel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMinLevel.Name = "lblMinLevel"
        Me.lblMinLevel.Size = New System.Drawing.Size(56, 13)
        Me.lblMinLevel.TabIndex = 13
        Me.lblMinLevel.Text = "Min Level:"
        '
        'numLevel
        '
        Me.numLevel.Location = New System.Drawing.Point(7, 198)
        Me.numLevel.Margin = New System.Windows.Forms.Padding(2)
        Me.numLevel.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.numLevel.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numLevel.Name = "numLevel"
        Me.numLevel.Size = New System.Drawing.Size(44, 20)
        Me.numLevel.TabIndex = 5
        Me.numLevel.Value = New Decimal(New Integer() {80, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 184)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Quest Level:"
        '
        'numZone
        '
        Me.numZone.Location = New System.Drawing.Point(7, 143)
        Me.numZone.Margin = New System.Windows.Forms.Padding(2)
        Me.numZone.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.numZone.Minimum = New Decimal(New Integer() {1000000, 0, 0, -2147483648})
        Me.numZone.Name = "numZone"
        Me.numZone.Size = New System.Drawing.Size(53, 20)
        Me.numZone.TabIndex = 4
        '
        'lblZone
        '
        Me.lblZone.AutoSize = True
        Me.lblZone.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZone.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblZone.Location = New System.Drawing.Point(4, 127)
        Me.lblZone.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblZone.Name = "lblZone"
        Me.lblZone.Size = New System.Drawing.Size(57, 13)
        Me.lblZone.TabIndex = 9
        Me.lblZone.Text = "Sorting ID:"
        '
        'numPrevQuest
        '
        Me.numPrevQuest.Location = New System.Drawing.Point(7, 102)
        Me.numPrevQuest.Margin = New System.Windows.Forms.Padding(2)
        Me.numPrevQuest.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.numPrevQuest.Name = "numPrevQuest"
        Me.numPrevQuest.Size = New System.Drawing.Size(64, 20)
        Me.numPrevQuest.TabIndex = 3
        '
        'lblPrevQuest
        '
        Me.lblPrevQuest.AutoSize = True
        Me.lblPrevQuest.Location = New System.Drawing.Point(4, 88)
        Me.lblPrevQuest.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPrevQuest.Name = "lblPrevQuest"
        Me.lblPrevQuest.Size = New System.Drawing.Size(96, 13)
        Me.lblPrevQuest.TabIndex = 7
        Me.lblPrevQuest.Text = "Previous Quest ID:"
        '
        'numNextQuest
        '
        Me.numNextQuest.Location = New System.Drawing.Point(7, 67)
        Me.numNextQuest.Margin = New System.Windows.Forms.Padding(2)
        Me.numNextQuest.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.numNextQuest.Name = "numNextQuest"
        Me.numNextQuest.Size = New System.Drawing.Size(64, 20)
        Me.numNextQuest.TabIndex = 2
        '
        'lblNextQuest
        '
        Me.lblNextQuest.AutoSize = True
        Me.lblNextQuest.Location = New System.Drawing.Point(4, 52)
        Me.lblNextQuest.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNextQuest.Name = "lblNextQuest"
        Me.lblNextQuest.Size = New System.Drawing.Size(77, 13)
        Me.lblNextQuest.TabIndex = 5
        Me.lblNextQuest.Text = "Next Quest ID:"
        '
        'numId
        '
        Me.numId.Location = New System.Drawing.Point(7, 32)
        Me.numId.Margin = New System.Windows.Forms.Padding(2)
        Me.numId.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.numId.Name = "numId"
        Me.numId.Size = New System.Drawing.Size(64, 20)
        Me.numId.TabIndex = 1
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(4, 17)
        Me.lblId.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(21, 13)
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
        Me.boxFlags.Location = New System.Drawing.Point(9, 333)
        Me.boxFlags.Margin = New System.Windows.Forms.Padding(2)
        Me.boxFlags.Name = "boxFlags"
        Me.boxFlags.Padding = New System.Windows.Forms.Padding(2)
        Me.boxFlags.Size = New System.Drawing.Size(148, 129)
        Me.boxFlags.TabIndex = 22
        Me.boxFlags.TabStop = False
        Me.boxFlags.Text = "Flags"
        '
        'chkRaid
        '
        Me.chkRaid.AutoSize = True
        Me.chkRaid.Location = New System.Drawing.Point(4, 39)
        Me.chkRaid.Margin = New System.Windows.Forms.Padding(2)
        Me.chkRaid.Name = "chkRaid"
        Me.chkRaid.Size = New System.Drawing.Size(48, 17)
        Me.chkRaid.TabIndex = 2
        Me.chkRaid.Text = "Raid"
        Me.chkRaid.UseVisualStyleBackColor = True
        '
        'chkDaily
        '
        Me.chkDaily.AutoSize = True
        Me.chkDaily.Location = New System.Drawing.Point(4, 83)
        Me.chkDaily.Margin = New System.Windows.Forms.Padding(2)
        Me.chkDaily.Name = "chkDaily"
        Me.chkDaily.Size = New System.Drawing.Size(49, 17)
        Me.chkDaily.TabIndex = 4
        Me.chkDaily.Text = "Daily"
        Me.chkDaily.UseVisualStyleBackColor = True
        '
        'chkWeekly
        '
        Me.chkWeekly.AutoSize = True
        Me.chkWeekly.Location = New System.Drawing.Point(4, 105)
        Me.chkWeekly.Margin = New System.Windows.Forms.Padding(2)
        Me.chkWeekly.Name = "chkWeekly"
        Me.chkWeekly.Size = New System.Drawing.Size(62, 17)
        Me.chkWeekly.TabIndex = 5
        Me.chkWeekly.Text = "Weekly"
        Me.chkWeekly.UseVisualStyleBackColor = True
        '
        'chkRepeatable
        '
        Me.chkRepeatable.AutoSize = True
        Me.chkRepeatable.Location = New System.Drawing.Point(4, 61)
        Me.chkRepeatable.Margin = New System.Windows.Forms.Padding(2)
        Me.chkRepeatable.Name = "chkRepeatable"
        Me.chkRepeatable.Size = New System.Drawing.Size(81, 17)
        Me.chkRepeatable.TabIndex = 3
        Me.chkRepeatable.Text = "Repeatable"
        Me.chkRepeatable.UseVisualStyleBackColor = True
        '
        'chkShare
        '
        Me.chkShare.AutoSize = True
        Me.chkShare.Location = New System.Drawing.Point(4, 17)
        Me.chkShare.Margin = New System.Windows.Forms.Padding(2)
        Me.chkShare.Name = "chkShare"
        Me.chkShare.Size = New System.Drawing.Size(68, 17)
        Me.chkShare.TabIndex = 1
        Me.chkShare.Text = "Sharable"
        Me.chkShare.UseVisualStyleBackColor = True
        '
        'boxAllow
        '
        Me.boxAllow.Controls.Add(Me.lblRaces)
        Me.boxAllow.Controls.Add(Me.lblClasses)
        Me.boxAllow.Controls.Add(Me.btnRacesClassMask)
        Me.boxAllow.Location = New System.Drawing.Point(9, 467)
        Me.boxAllow.Margin = New System.Windows.Forms.Padding(2)
        Me.boxAllow.Name = "boxAllow"
        Me.boxAllow.Padding = New System.Windows.Forms.Padding(2)
        Me.boxAllow.Size = New System.Drawing.Size(148, 97)
        Me.boxAllow.TabIndex = 23
        Me.boxAllow.TabStop = False
        Me.boxAllow.Text = "Allow to take quest"
        '
        'lblRaces
        '
        Me.lblRaces.AutoSize = True
        Me.lblRaces.Location = New System.Drawing.Point(10, 73)
        Me.lblRaces.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRaces.Name = "lblRaces"
        Me.lblRaces.Size = New System.Drawing.Size(78, 13)
        Me.lblRaces.TabIndex = 35
        Me.lblRaces.Text = "Races mask: 0"
        '
        'lblClasses
        '
        Me.lblClasses.AutoSize = True
        Me.lblClasses.Location = New System.Drawing.Point(10, 51)
        Me.lblClasses.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblClasses.Name = "lblClasses"
        Me.lblClasses.Size = New System.Drawing.Size(83, 13)
        Me.lblClasses.TabIndex = 34
        Me.lblClasses.Text = "Classes mask: 0"
        '
        'btnRacesClassMask
        '
        Me.btnRacesClassMask.Location = New System.Drawing.Point(13, 17)
        Me.btnRacesClassMask.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRacesClassMask.Name = "btnRacesClassMask"
        Me.btnRacesClassMask.Size = New System.Drawing.Size(127, 28)
        Me.btnRacesClassMask.TabIndex = 33
        Me.btnRacesClassMask.Text = "Show choices..."
        Me.btnRacesClassMask.UseVisualStyleBackColor = True
        '
        'boxStartItem
        '
        Me.boxStartItem.Controls.Add(Me.lblProvidedName)
        Me.boxStartItem.Controls.Add(Me.numProvidedCount)
        Me.boxStartItem.Controls.Add(Me.lblStartItemCount)
        Me.boxStartItem.Controls.Add(Me.numProvidedId)
        Me.boxStartItem.Controls.Add(Me.lblItemStart)
        Me.boxStartItem.Location = New System.Drawing.Point(166, 28)
        Me.boxStartItem.Margin = New System.Windows.Forms.Padding(2)
        Me.boxStartItem.Name = "boxStartItem"
        Me.boxStartItem.Padding = New System.Windows.Forms.Padding(2)
        Me.boxStartItem.Size = New System.Drawing.Size(196, 96)
        Me.boxStartItem.TabIndex = 24
        Me.boxStartItem.TabStop = False
        Me.boxStartItem.Text = "Start Item"
        '
        'lblProvidedName
        '
        Me.lblProvidedName.AutoSize = True
        Me.lblProvidedName.Location = New System.Drawing.Point(4, 52)
        Me.lblProvidedName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProvidedName.Name = "lblProvidedName"
        Me.lblProvidedName.Size = New System.Drawing.Size(0, 13)
        Me.lblProvidedName.TabIndex = 22
        '
        'numProvidedCount
        '
        Me.numProvidedCount.Location = New System.Drawing.Point(157, 32)
        Me.numProvidedCount.Margin = New System.Windows.Forms.Padding(2)
        Me.numProvidedCount.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.numProvidedCount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numProvidedCount.Name = "numProvidedCount"
        Me.numProvidedCount.Size = New System.Drawing.Size(34, 20)
        Me.numProvidedCount.TabIndex = 20
        Me.numProvidedCount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblStartItemCount
        '
        Me.lblStartItemCount.AutoSize = True
        Me.lblStartItemCount.Location = New System.Drawing.Point(154, 17)
        Me.lblStartItemCount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStartItemCount.Name = "lblStartItemCount"
        Me.lblStartItemCount.Size = New System.Drawing.Size(38, 13)
        Me.lblStartItemCount.TabIndex = 19
        Me.lblStartItemCount.Text = "Count:"
        '
        'numProvidedId
        '
        Me.numProvidedId.Location = New System.Drawing.Point(4, 32)
        Me.numProvidedId.Margin = New System.Windows.Forms.Padding(2)
        Me.numProvidedId.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.numProvidedId.Name = "numProvidedId"
        Me.numProvidedId.Size = New System.Drawing.Size(75, 20)
        Me.numProvidedId.TabIndex = 18
        '
        'lblItemStart
        '
        Me.lblItemStart.AutoSize = True
        Me.lblItemStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemStart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblItemStart.Location = New System.Drawing.Point(2, 17)
        Me.lblItemStart.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblItemStart.Name = "lblItemStart"
        Me.lblItemStart.Size = New System.Drawing.Size(74, 13)
        Me.lblItemStart.TabIndex = 17
        Me.lblItemStart.Text = "Provided item:"
        '
        'boxRequirements
        '
        Me.boxRequirements.Controls.Add(Me.lblObj5)
        Me.boxRequirements.Controls.Add(Me.lblObj4)
        Me.boxRequirements.Controls.Add(Me.lblObj3)
        Me.boxRequirements.Controls.Add(Me.lblObj2)
        Me.boxRequirements.Controls.Add(Me.lblObj1)
        Me.boxRequirements.Controls.Add(Me.btnRequirements)
        Me.boxRequirements.Location = New System.Drawing.Point(162, 306)
        Me.boxRequirements.Margin = New System.Windows.Forms.Padding(2)
        Me.boxRequirements.Name = "boxRequirements"
        Me.boxRequirements.Padding = New System.Windows.Forms.Padding(2)
        Me.boxRequirements.Size = New System.Drawing.Size(206, 150)
        Me.boxRequirements.TabIndex = 26
        Me.boxRequirements.TabStop = False
        Me.boxRequirements.Text = "Requirements to complete"
        '
        'lblObj5
        '
        Me.lblObj5.AutoSize = True
        Me.lblObj5.Location = New System.Drawing.Point(4, 122)
        Me.lblObj5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblObj5.Name = "lblObj5"
        Me.lblObj5.Size = New System.Drawing.Size(0, 13)
        Me.lblObj5.TabIndex = 33
        '
        'lblObj4
        '
        Me.lblObj4.AutoSize = True
        Me.lblObj4.Location = New System.Drawing.Point(4, 103)
        Me.lblObj4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblObj4.Name = "lblObj4"
        Me.lblObj4.Size = New System.Drawing.Size(0, 13)
        Me.lblObj4.TabIndex = 33
        '
        'lblObj3
        '
        Me.lblObj3.AutoSize = True
        Me.lblObj3.Location = New System.Drawing.Point(4, 86)
        Me.lblObj3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblObj3.Name = "lblObj3"
        Me.lblObj3.Size = New System.Drawing.Size(0, 13)
        Me.lblObj3.TabIndex = 33
        '
        'lblObj2
        '
        Me.lblObj2.AutoSize = True
        Me.lblObj2.Location = New System.Drawing.Point(4, 67)
        Me.lblObj2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblObj2.Name = "lblObj2"
        Me.lblObj2.Size = New System.Drawing.Size(0, 13)
        Me.lblObj2.TabIndex = 33
        '
        'lblObj1
        '
        Me.lblObj1.AutoSize = True
        Me.lblObj1.Location = New System.Drawing.Point(4, 50)
        Me.lblObj1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblObj1.Name = "lblObj1"
        Me.lblObj1.Size = New System.Drawing.Size(0, 13)
        Me.lblObj1.TabIndex = 33
        '
        'btnRequirements
        '
        Me.btnRequirements.Location = New System.Drawing.Point(4, 22)
        Me.btnRequirements.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRequirements.Name = "btnRequirements"
        Me.btnRequirements.Size = New System.Drawing.Size(196, 28)
        Me.btnRequirements.TabIndex = 0
        Me.btnRequirements.Text = "Requirements..."
        Me.btnRequirements.UseVisualStyleBackColor = True
        '
        'boxRewards
        '
        Me.boxRewards.Controls.Add(Me.lblFac5)
        Me.boxRewards.Controls.Add(Me.lblFac4)
        Me.boxRewards.Controls.Add(Me.lblFac3)
        Me.boxRewards.Controls.Add(Me.lblFac2)
        Me.boxRewards.Controls.Add(Me.lblFac1)
        Me.boxRewards.Controls.Add(Me.btnRewards)
        Me.boxRewards.Location = New System.Drawing.Point(162, 128)
        Me.boxRewards.Margin = New System.Windows.Forms.Padding(2)
        Me.boxRewards.Name = "boxRewards"
        Me.boxRewards.Padding = New System.Windows.Forms.Padding(2)
        Me.boxRewards.Size = New System.Drawing.Size(206, 170)
        Me.boxRewards.TabIndex = 25
        Me.boxRewards.TabStop = False
        Me.boxRewards.Text = "Rewards"
        '
        'lblFac5
        '
        Me.lblFac5.AutoSize = True
        Me.lblFac5.Location = New System.Drawing.Point(10, 131)
        Me.lblFac5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFac5.Name = "lblFac5"
        Me.lblFac5.Size = New System.Drawing.Size(0, 13)
        Me.lblFac5.TabIndex = 35
        '
        'lblFac4
        '
        Me.lblFac4.AutoSize = True
        Me.lblFac4.Location = New System.Drawing.Point(10, 112)
        Me.lblFac4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFac4.Name = "lblFac4"
        Me.lblFac4.Size = New System.Drawing.Size(0, 13)
        Me.lblFac4.TabIndex = 34
        '
        'lblFac3
        '
        Me.lblFac3.AutoSize = True
        Me.lblFac3.Location = New System.Drawing.Point(10, 93)
        Me.lblFac3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFac3.Name = "lblFac3"
        Me.lblFac3.Size = New System.Drawing.Size(0, 13)
        Me.lblFac3.TabIndex = 3
        '
        'lblFac2
        '
        Me.lblFac2.AutoSize = True
        Me.lblFac2.Location = New System.Drawing.Point(10, 73)
        Me.lblFac2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFac2.Name = "lblFac2"
        Me.lblFac2.Size = New System.Drawing.Size(0, 13)
        Me.lblFac2.TabIndex = 2
        '
        'lblFac1
        '
        Me.lblFac1.AutoSize = True
        Me.lblFac1.Location = New System.Drawing.Point(10, 54)
        Me.lblFac1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFac1.Name = "lblFac1"
        Me.lblFac1.Size = New System.Drawing.Size(0, 13)
        Me.lblFac1.TabIndex = 1
        '
        'btnRewards
        '
        Me.btnRewards.Location = New System.Drawing.Point(4, 17)
        Me.btnRewards.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRewards.Name = "btnRewards"
        Me.btnRewards.Size = New System.Drawing.Size(195, 32)
        Me.btnRewards.TabIndex = 0
        Me.btnRewards.Text = "Rewards..."
        Me.btnRewards.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(251, 5)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(84, 28)
        Me.btnSave.TabIndex = 36
        Me.btnSave.Text = "Save current"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnSQL
        '
        Me.btnSQL.Location = New System.Drawing.Point(163, 5)
        Me.btnSQL.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSQL.Name = "btnSQL"
        Me.btnSQL.Size = New System.Drawing.Size(84, 28)
        Me.btnSQL.TabIndex = 35
        Me.btnSQL.Text = "Look SQL"
        Me.btnSQL.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(14, 5)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(84, 28)
        Me.btnNew.TabIndex = 34
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnNew)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnSQL)
        Me.Panel1.Location = New System.Drawing.Point(370, 522)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(340, 37)
        Me.Panel1.TabIndex = 28
        '
        'listGivers
        '
        Me.listGivers.FormattingEnabled = True
        Me.listGivers.Location = New System.Drawing.Point(4, 50)
        Me.listGivers.Margin = New System.Windows.Forms.Padding(2)
        Me.listGivers.Name = "listGivers"
        Me.listGivers.Size = New System.Drawing.Size(83, 43)
        Me.listGivers.TabIndex = 99
        '
        'btnAddGiver
        '
        Me.btnAddGiver.Location = New System.Drawing.Point(13, 17)
        Me.btnAddGiver.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddGiver.Name = "btnAddGiver"
        Me.btnAddGiver.Size = New System.Drawing.Size(67, 28)
        Me.btnAddGiver.TabIndex = 1
        Me.btnAddGiver.Text = "Add Giver"
        Me.btnAddGiver.UseVisualStyleBackColor = True
        '
        'listTakers
        '
        Me.listTakers.FormattingEnabled = True
        Me.listTakers.Location = New System.Drawing.Point(110, 51)
        Me.listTakers.Margin = New System.Windows.Forms.Padding(2)
        Me.listTakers.Name = "listTakers"
        Me.listTakers.Size = New System.Drawing.Size(89, 43)
        Me.listTakers.TabIndex = 100
        '
        'btnAddTaker
        '
        Me.btnAddTaker.Location = New System.Drawing.Point(121, 18)
        Me.btnAddTaker.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddTaker.Name = "btnAddTaker"
        Me.btnAddTaker.Size = New System.Drawing.Size(67, 28)
        Me.btnAddTaker.TabIndex = 3
        Me.btnAddTaker.Text = "Add Taker"
        Me.btnAddTaker.UseVisualStyleBackColor = True
        '
        'boxQuestGiver
        '
        Me.boxQuestGiver.Controls.Add(Me.btnAddTaker)
        Me.boxQuestGiver.Controls.Add(Me.listTakers)
        Me.boxQuestGiver.Controls.Add(Me.btnAddGiver)
        Me.boxQuestGiver.Controls.Add(Me.listGivers)
        Me.boxQuestGiver.Location = New System.Drawing.Point(162, 461)
        Me.boxQuestGiver.Margin = New System.Windows.Forms.Padding(2)
        Me.boxQuestGiver.Name = "boxQuestGiver"
        Me.boxQuestGiver.Padding = New System.Windows.Forms.Padding(2)
        Me.boxQuestGiver.Size = New System.Drawing.Size(204, 103)
        Me.boxQuestGiver.TabIndex = 27
        Me.boxQuestGiver.TabStop = False
        Me.boxQuestGiver.Text = "Quest Giver and Taker"
        '
        'questDisplay
        '
        Me.questDisplay.BackgroundImage = Global.ACS.My.Resources.Resources.Empty_Quest_Log
        Me.questDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.questDisplay.Location = New System.Drawing.Point(376, 10)
        Me.questDisplay.Margin = New System.Windows.Forms.Padding(2)
        Me.questDisplay.Name = "questDisplay"
        Me.questDisplay.Size = New System.Drawing.Size(334, 539)
        Me.questDisplay.TabIndex = 28
        Me.questDisplay.TabStop = False
        '
        'btnText
        '
        Me.btnText.Location = New System.Drawing.Point(449, 60)
        Me.btnText.Name = "btnText"
        Me.btnText.Size = New System.Drawing.Size(94, 33)
        Me.btnText.TabIndex = 28
        Me.btnText.Text = "Quest Text"
        Me.btnText.UseVisualStyleBackColor = True
        '
        'btnEmote
        '
        Me.btnEmote.Enabled = False
        Me.btnEmote.Location = New System.Drawing.Point(611, 60)
        Me.btnEmote.Name = "btnEmote"
        Me.btnEmote.Size = New System.Drawing.Size(94, 33)
        Me.btnEmote.TabIndex = 29
        Me.btnEmote.Text = "Emote"
        Me.btnEmote.UseVisualStyleBackColor = True
        '
        'QuestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 569)
        Me.Controls.Add(Me.btnEmote)
        Me.Controls.Add(Me.btnText)
        Me.Controls.Add(Me.Panel1)
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
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
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
        Me.boxRewards.ResumeLayout(False)
        Me.boxRewards.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.boxQuestGiver.ResumeLayout(False)
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
    Friend WithEvents numProvidedCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblStartItemCount As System.Windows.Forms.Label
    Friend WithEvents boxRequirements As System.Windows.Forms.GroupBox
    Friend WithEvents btnRequirements As System.Windows.Forms.Button
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
    Friend WithEvents lblObj4 As System.Windows.Forms.Label
    Friend WithEvents lblObj3 As System.Windows.Forms.Label
    Friend WithEvents lblObj2 As System.Windows.Forms.Label
    Friend WithEvents lblObj1 As System.Windows.Forms.Label
    Friend WithEvents lblObj5 As System.Windows.Forms.Label
    Friend WithEvents lblSortIdName As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnSQL As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents listGivers As ListBox
    Friend WithEvents btnAddGiver As Button
    Friend WithEvents listTakers As ListBox
    Friend WithEvents btnAddTaker As Button
    Friend WithEvents boxQuestGiver As GroupBox
    Friend WithEvents btnText As Button
    Friend WithEvents btnEmote As Button
End Class
