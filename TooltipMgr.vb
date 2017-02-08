Imports ACS.Form1
Public Class TooltipMgr

    Public VENDOR_ENTRY As String = "NPC Entry, must be unique."
    Public VENDOR_MODEL As String = "NPC Model id, usually it is taken from existing creatures. Use the button to browse them."
    Public VENDOR_SIZE As String = "NPC Size, 1 = normal size, 0.5 = half size, 2 = double size, ..."
    Public VENDOR_FACTION As String = "NPC Faction id, taken from faction.dbc, click to browse them."
    Public VENDOR_CREPAIR As String = "Check to allow this NPC to repair equipment."
    Public VENDOR_ITEMID As String = "Id of the item to sell. Click to browse items."
    Public VENDOR_ITEMCOST As String = "Id of the item cost (if any), leave it blank or 0 to sell it using Golds (buyprice). Click to browse the extended costs"


    Public Sub initializeVendorTooltip()
        VendorForm.tooltip.SetToolTip(VendorForm.numEntry, VENDOR_ENTRY)
        VendorForm.tooltip.SetToolTip(VendorForm.lblEntry, VENDOR_ENTRY)

        VendorForm.tooltip.SetToolTip(VendorForm.numModel, VENDOR_MODEL)
        VendorForm.tooltip.SetToolTip(VendorForm.lblModel, VENDOR_MODEL)

        VendorForm.tooltip.SetToolTip(VendorForm.numSize, VENDOR_SIZE)
        VendorForm.tooltip.SetToolTip(VendorForm.lblSize, VENDOR_SIZE)

        VendorForm.tooltip.SetToolTip(VendorForm.numFaction, VENDOR_FACTION)
        VendorForm.tooltip.SetToolTip(VendorForm.lblFaction, VENDOR_FACTION)

        VendorForm.tooltip.SetToolTip(VendorForm.checkRepair, VENDOR_CREPAIR)

        VendorForm.tooltip.SetToolTip(VendorForm.numItemId, VENDOR_ITEMID)
        VendorForm.tooltip.SetToolTip(VendorForm.lblItemId, VENDOR_ITEMID)

        VendorForm.tooltip.SetToolTip(VendorForm.numItemCost, VENDOR_ITEMCOST)
        VendorForm.tooltip.SetToolTip(VendorForm.lblItemCost, VENDOR_ITEMCOST)
    End Sub

    Public Sub initializeQuestTooltip()

    End Sub
End Class
