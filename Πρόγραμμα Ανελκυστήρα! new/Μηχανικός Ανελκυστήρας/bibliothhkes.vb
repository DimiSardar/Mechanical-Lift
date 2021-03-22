Public Class bibliothhkes

    Private Sub bibliothhkes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_Table_Μέγιστη_Ωφέλιμη_ΕπιφάνειαDataSet.Πίν_Μέγ_Ωφέλ_Επιφ' table. You can move, or remove it, as needed.
        Me.Πίν_Μέγ_Ωφέλ_ΕπιφTableAdapter.Fill(Me._Table_Μέγιστη_Ωφέλιμη_ΕπιφάνειαDataSet.Πίν_Μέγ_Ωφέλ_Επιφ)
        'TODO: This line of code loads data into the '_Table_Ελάχιστη_Ωφέλιμη_ΕπιφάνειαDataSet.Πιν_Ελάχ_Ωφέλ_Επίφ' table. You can move, or remove it, as needed.
        Me.Πιν_Ελάχ_Ωφέλ_ΕπίφTableAdapter.Fill(Me._Table_Ελάχιστη_Ωφέλιμη_ΕπιφάνειαDataSet.Πιν_Ελάχ_Ωφέλ_Επίφ)

    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedItem = "Ελάχ. Ωφέλ. Επιφ. Θαλάμ." Then
            TabControl1.SelectTab(0)
        ElseIf ListBox1.SelectedItem = "Μεγ. Ωφέλ. Επιφ. Θαλάμ." Then
            TabControl1.SelectTab(1)

        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        On Error GoTo Errr

        If TabControl1.SelectedTab.Text = "TabPage1" Then
            ΠινΕλάχΩφέλΕπίφBindingSource.AddNew()
        ElseIf TabControl1.SelectedTab.Text = "TabPage2" Then
            ΠίνΜέγΩφέλΕπιφBindingSource.AddNew()


        End If

Errr:
        Exit Sub


    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        On Error GoTo Errr

        If TabControl1.SelectedTab.Text = "TabPage1" Then
            ΠινΕλάχΩφέλΕπίφBindingSource.RemoveCurrent()
        ElseIf TabControl1.SelectedTab.Text = "TabPage2" Then
            ΠίνΜέγΩφέλΕπιφBindingSource.RemoveCurrent()


        End If

Errr:
        Exit Sub


    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        On Error GoTo Errr

        If TabControl1.SelectedTab.Text = "TabPage1" Then

            ΠινΕλάχΩφέλΕπίφBindingSource.EndEdit()
            Πιν_Ελάχ_Ωφέλ_ΕπίφTableAdapter.Update(_Table_Ελάχιστη_Ωφέλιμη_ΕπιφάνειαDataSet.Πιν_Ελάχ_Ωφέλ_Επίφ)
            MessageBox.Show("Η προσθήκη ήταν επιτυχής!")

        ElseIf TabControl1.SelectedTab.Text = "TabPage2" Then

            ΠίνΜέγΩφέλΕπιφBindingSource.EndEdit()
            Πίν_Μέγ_Ωφέλ_ΕπιφTableAdapter.Update(_Table_Μέγιστη_Ωφέλιμη_ΕπιφάνειαDataSet.Πίν_Μέγ_Ωφέλ_Επιφ)
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