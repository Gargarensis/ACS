Public Class VendorForm
    Dim oldModel As Integer = 0

    Private Sub browserModel_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles browserModel.DocumentCompleted
        'WebBrowser1.Document.Body.InnerHtml = ""
        'Me.WebBrowser1.ScriptErrorsSuppressed = True
        'Dim code = New Object() {"ModelViewer.show({ type: 1, typeId: 35144, displayId: 29815 });"}

        'WebBrowser1.Document.InvokeScript("eval", code)

        'modelviewer-screen

        Dim links = browserModel.Document.Body.GetElementsByTagName("a")

        For Each d As HtmlElement In links
            If d.GetAttribute("className") = "dialog-x fa fa-times" Or d.GetAttribute("className") = "dialog-question fa fa-question" Then
                d.Style = "Display:none"
                MsgBox(d.InnerHtml)
            End If
        Next

        Me.browserModel.Visible = True
        Me.browserModel.AllowNavigation = False
    End Sub

    Private Sub numModel_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numModel.Leave
        If numModel.Value = 0 Or numModel.Value = oldModel Or checkViewer.CheckState = CheckState.Unchecked Then
            Return
        End If

        Me.browserModel.AllowNavigation = True
        Me.browserModel.Stop()
        Me.browserModel.Visible = False
        Me.browserModel.Navigate("http://it.wowhead.com/3453#modelviewer:1:" + numModel.Value.ToString() + ":0:11+0")

        If Not oldModel = 0 Then
            browserModel.Refresh()
        End If
        oldModel = numModel.Value
    End Sub

    Private Sub checkViewer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkViewer.CheckedChanged
        If checkViewer.CheckState = CheckState.Unchecked Then
            browserModel.Visible = False
        Else
            If numModel.Value <> oldModel Then
                numModel_Leave(New Object, New EventArgs)
            End If
        End If
    End Sub

    Sub checkEntryAvailability()
        If Not lblEntryCheck.Visible Then
            lblEntryCheck.Visible = True
        End If

        Dim check As Boolean = False
        If Not numEntry.Value = 0 Then
            For Each s As String In IO.File.ReadAllLines(CREATURE_ENTRIES_PATH)
                If Convert.ToUInt64(s) = numEntry.Value Then
                    check = True
                    Exit For
                End If
            Next
        Else
            check = True
        End If
        If check Then
            Me.lblEntryCheck.Text = ENTRY_NOT_AVAILABLE
            lblEntryCheck.ForeColor = Color.Red
        Else
            Me.lblEntryCheck.Text = ENTRY_AVAILABLE
            lblEntryCheck.ForeColor = Color.Green
        End If
    End Sub

    Private Sub numEntry_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numEntry.ValueChanged
        checkEntryTimer.Enabled = True
    End Sub

    Private Sub numEntry_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles numEntry.KeyPress
        checkEntryTimer.Enabled = True
    End Sub

    Private Sub checkEntryTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkEntryTimer.Tick
        checkEntryAvailability()
        checkEntryTimer.Enabled = False
    End Sub

    Sub checkFaction()
        If Not lblFactionCheck.Visible Then
            lblFactionCheck.Visible = True
        End If

        Dim check As Boolean = False
        Dim fname As String = ""
        For Each s As String In IO.File.ReadAllLines(FACTION_ENTRIES_PATH)
            Dim temp As String()
            temp = s.Split(",")

            Dim name As String = temp(1)
            Dim id As Integer = Convert.ToUInt64(temp(0))

            If id = numFaction.Value Then
                check = True
                fname = name
                Exit For
            End If
        Next
        If check Then
            Me.lblFactionCheck.Text = FACTION_AVAILABLE + fname
            lblFactionCheck.ForeColor = Color.Green
        Else
            Me.lblFactionCheck.Text = FACTION_NOT_AVAILABLE
            lblFactionCheck.ForeColor = Color.Red
        End If
    End Sub

    Private Sub numFaction_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numFaction.ValueChanged
        checkFactionTimer.Enabled = True
    End Sub

    Private Sub numFaction_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles numFaction.KeyPress
        checkFactionTimer.Enabled = True
    End Sub

    Private Sub checkFactionTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkFactionTimer.Tick
        checkFaction()
        checkFactionTimer.Enabled = False
    End Sub

    Private Sub lblFaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFaction.Click
        FormData.Show()
        FormData.setData(IO.File.ReadAllLines(FACTION_ENTRIES_PATH), DATA_TYPE.FACTIONS, numFaction)
    End Sub

    Private Sub btnNpcData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNpcData.Click
        FormData.Show()
        FormData.setData(IO.File.ReadAllLines(CREATURE_TEMPLATE_1_ENTRIES_PATH), DATA_TYPE.TEMPLATE1)
    End Sub

    Private Sub lblItemId_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblItemId.Click
        FormData.Show()
        FormData.setData(IO.File.ReadAllLines(ITEM_1_ENTRIES_PATH), DATA_TYPE.ITEMS1, numItemId)
    End Sub

    Private Sub listVendorItems_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listVendorItems.SelectedIndexChanged
        If listVendorItems.SelectedItem Is Nothing Then
            Return
        End If

        btnChange.Enabled = True

        Dim s As String() = listVendorItems.SelectedItem.ToString().Split(vbTab)
        numItemId.Value = DirectCast(listVendorItems.SelectedItem, VendorItem).getId()
        numItemCost.Value = DirectCast(listVendorItems.SelectedItem, VendorItem).getExtCostId()
    End Sub

    Private Sub btnNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewItem.Click
        If numItemId.Value = vbNull Or numItemId.Value = 0 Then
            Exit Sub
        End If

        listVendorItems.Items.Add(New VendorItem(numItemId.Value, numItemCost.Value))
    End Sub

    Private Sub btnDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteItem.Click
        listVendorItems.Items.Remove(listVendorItems.SelectedItem)
        If listVendorItems.Items.Count = 0 Then
            btnChange.Enabled = False
        End If
    End Sub

    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click
        If listVendorItems.SelectedItem Is Nothing Then
            Exit Sub
        End If
        If numItemId.Value = vbNull Or numItemId.Value = 0 Then
            Exit Sub
        End If

        listVendorItems.Items(listVendorItems.SelectedIndex) = New VendorItem(numItemId.Value, numItemCost.Value)
    End Sub

    Private Sub lblItemCost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblItemCost.Click
        FormData.Show()
        FormData.setData(IO.File.ReadAllLines(EXTENDED_COST_ENTRIES_PATH), DATA_TYPE.EXTCOST, numItemCost)
    End Sub

    Private Sub Vendor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ttmgr As New TooltipMgr
        ttmgr.initializeVendorTooltip()
    End Sub

    Sub removeChanges(ByVal ctrl As Control)
        If TypeOf ctrl Is TextBox Then
            ctrl.Text = ""
        ElseIf TypeOf ctrl Is CheckBox Then
            DirectCast(ctrl, CheckBox).Checked = False
        ElseIf TypeOf ctrl Is NumericUpDown Then
            DirectCast(ctrl, NumericUpDown).Value = 0
        ElseIf TypeOf ctrl Is ListBox Then
            DirectCast(ctrl, ListBox).Items.Clear()
        ElseIf TypeOf ctrl Is GroupBox Then
            For Each subctrl As Control In DirectCast(ctrl, GroupBox).Controls
                removeChanges(subctrl)
            Next
        End If
    End Sub
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        If MsgBox("You will discard everything, are you sure?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If
        For Each ctrl As Control In Me.Controls
            removeChanges(ctrl)
        Next
    End Sub

    Private Sub btnSQL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSQL.Click
        Details.Show()
        Details.Size = VENDOR_QUERY_WINDOW_SIZE
        Dim s, repFlag As String
        If checkRepair.Checked Then
            repFlag = 4225
        Else
            repFlag = 129
        End If
        s = String.Format(VENDOR_QUERY, numEntry.Value, numModel.Value, txtName.Text, txtSubname.Text, numFaction.Value, numSize.Value, repFlag)
        Dim i As Integer = 0
        For Each item As VendorItem In listVendorItems.Items
            If i = listVendorItems.Items.Count - 1 Then
                s = s + String.Format(VENDOR_QUERY_SINGLE, numEntry.Value, item.getId(), item.getExtCostId()) + ";"
            Else
                s = s + String.Format(VENDOR_QUERY_SINGLE, numEntry.Value, item.getId(), item.getExtCostId()) + "," + vbCrLf
            End If
            i = i + 1
        Next
        Details.RichTextBox1.Text = s
    End Sub
End Class