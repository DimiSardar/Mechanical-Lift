Public Class bibliothhkes

    Private Sub bibliothhkes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_Table_Standard_Lift_ChambersDataSet.Standard_Lift_Cabins' table. You can move, or remove it, as needed.
        Me.Standard_Lift_CabinsTableAdapter.Fill(Me._Table_Standard_Lift_ChambersDataSet.Standard_Lift_Cabins)
        'TODO: This line of code loads data into the '_Table_Standard_Lift_ChambersDataSet.Standard_Lift_Cabins' table. You can move, or remove it, as needed.
        Me.Standard_Lift_CabinsTableAdapter.Fill(Me._Table_Standard_Lift_ChambersDataSet.Standard_Lift_Cabins)
        'TODO: This line of code loads data into the '_Table_Standard_Lift_ChambersDataSet.Standard_Lift_Cabins' table. You can move, or remove it, as needed.
        Me.Standard_Lift_CabinsTableAdapter.Fill(Me._Table_Standard_Lift_ChambersDataSet.Standard_Lift_Cabins)
        'TODO: This line of code loads data into the '_Table_Max_UseFull_Chamber_AreaDataSet.Maximum_Useful_Chamber' table. You can move, or remove it, as needed.
        Me.Maximum_Useful_ChamberTableAdapter.Fill(Me._Table_Max_UseFull_Chamber_AreaDataSet.Maximum_Useful_Chamber)
        'TODO: This line of code loads data into the '_Table_Min_UseFull_Chamber_AreaDataSet.Minimum_Useful_Chamber' table. You can move, or remove it, as needed.
        Me.Minimum_Useful_ChamberTableAdapter.Fill(Me._Table_Min_UseFull_Chamber_AreaDataSet.Minimum_Useful_Chamber)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedItem = "Ελάχ. Ωφέλ. Επιφ. Θαλάμ." Then
            TabControl1.SelectTab(0)
        ElseIf ListBox1.SelectedItem = "Μεγ. Ωφέλ. Επιφ. Θαλάμ." Then
            TabControl1.SelectTab(1)
        ElseIf ListBox1.SelectedItem = "Τυποποίηση θαλάμων" Then
            TabControl1.SelectTab(2)


        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        On Error GoTo Errr

        If TabControl1.SelectedTab.Text = "TabPage1" Then
            MinimumUsefulChamberBindingSource.AddNew()
        ElseIf TabControl1.SelectedTab.Text = "TabPage2" Then
            MaximumUsefulChamberBindingSource.AddNew()
        ElseIf TabControl1.SelectedTab.Text = "TabPage3" Then
            StandardLiftCabinsBindingSource.AddNew()


        End If

Errr:
        Exit Sub


    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        On Error GoTo Errr

        If TabControl1.SelectedTab.Text = "TabPage1" Then
            MinimumUsefulChamberBindingSource.RemoveCurrent()
        ElseIf TabControl1.SelectedTab.Text = "TabPage2" Then
            MaximumUsefulChamberBindingSource.RemoveCurrent()
        ElseIf TabControl1.SelectedTab.Text = "TabPage3" Then
            StandardLiftCabinsBindingSource.RemoveCurrent()

        End If

Errr:
        Exit Sub


    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        On Error GoTo Errr

        If TabControl1.SelectedTab.Text = "TabPage1" Then

            MinimumUsefulChamberBindingSource.EndEdit()
            Minimum_Useful_ChamberTableAdapter.Update(_Table_Min_UseFull_Chamber_AreaDataSet.Minimum_Useful_Chamber)
            MessageBox.Show("Η προσθήκη ήταν επιτυχής!")

        ElseIf TabControl1.SelectedTab.Text = "TabPage2" Then

            MaximumUsefulChamberBindingSource.EndEdit()
            Maximum_Useful_ChamberTableAdapter.Update(_Table_Max_UseFull_Chamber_AreaDataSet.Maximum_Useful_Chamber)
            MessageBox.Show("Η προσθήκη ήταν επιτυχής!")

        ElseIf TabControl1.SelectedTab.Text = "TabPage3" Then

            StandardLiftCabinsBindingSource.EndEdit()
            Standard_Lift_CabinsTableAdapter.Update(_Table_Standard_Lift_ChambersDataSet.Standard_Lift_Cabins)
            MessageBox.Show("Η προσθήκη ήταν επιτυχής!")

        End If

Errr:
        Exit Sub


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Dim iExit As DialogResult
        iExit = MessageBox.Show("Είσαι σίγουρος, ότι Θέλεις να αποχωρήσεις από τις Βιβλιοθήκες;", "DataGridView system", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If iExit = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Me.PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        Me.PrintForm1.PrinterSettings.DefaultPageSettings.PaperSize = New Printing.PaperSize("size1", 1500, 1100)
        Me.PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.FullWindow)
    End Sub


End Class