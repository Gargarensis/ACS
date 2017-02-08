Imports ACS.Tables
Imports ACS.TooltipMgr
Public Class Form1

    Public activeTab As Integer = 0

    Sub initializeVendorTab()
        Dim vendorForm As New VendorForm()
        Dim tab As New TabPage
        vendorForm.TopLevel = False
        vendorForm.Parent = tab
        tab.Text = "Vendor"
        tab.Controls.Add(vendorForm)
        tab.BackColor = vendorForm.BackColor
        TabControl1.TabPages.Add(tab)
        vendorForm.Show()
    End Sub

    Sub initializeQuestTab()
        Dim questForm As New QuestForm()
        Dim tab As New TabPage
        questForm.TopLevel = False
        questForm.Parent = tab
        tab.Text = "Quest"
        tab.Controls.Add(questForm)
        tab.BackColor = questForm.BackColor
        TabControl1.TabPages.Add(tab)
        questForm.Show()
    End Sub

    Sub initializeDictionaries()
        For i As Integer = 0 To CLASSES.Length - 1
            Tables.CLASS_DICT.Add(CLASSES(i), CLASSES_MASK(i))
        Next
        For i As Integer = 0 To RACES.Length - 1
            Tables.RACES_DICT.Add(RACES(i), RACES_MASK(i))
        Next
    End Sub

    Sub initializeFonts()
        FONT_COLLECTION.AddFontFile(Application.StartupPath + "\fonts\MORPHEUS.TTF")
        FONT_COLLECTION.AddFontFile(Application.StartupPath + "\fonts\FRIZ.TTF")

        FONT_MORPHEUS = New Font(FONT_COLLECTION.Families(0), 14, FontStyle.Regular)
        FONT_FRIZ = New Font(FONT_COLLECTION.Families(1), 6, FontStyle.Regular)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initializeDictionaries()
        initializeFonts()

        initializeVendorTab()
        initializeQuestTab()

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        activeTab = TabControl1.SelectedIndex
    End Sub
End Class
