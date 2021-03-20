Public Class Meleth_Anelkysthra
    Private Sub ΒιβλιοθήκεςToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ΒιβλιοθήκεςToolStripMenuItem.Click
        bibliothhkes.Show()
    End Sub

    Private Sub NextCentralTab_Click(sender As Object, e As EventArgs) Handles NextCentralTab1.Click

        If Not CentralTabControl.SelectedTab Is TabPage5 Then

            CentralTabControl.SelectedIndex = CentralTabControl.SelectedIndex + 1

        End If

    End Sub

    Private Sub PreviousCentralTab_Click(sender As Object, e As EventArgs) Handles PreviousCentralTab1.Click

        If Not CentralTabControl.SelectedTab Is TabPage1 Then

            CentralTabControl.SelectedIndex = CentralTabControl.SelectedIndex - 1

        End If

    End Sub

    Private Sub anarthsh1pros1_CheckedChanged(sender As Object, e As EventArgs) Handles anarthsh1pros1.CheckedChanged

        If anarthsh1pros1.Checked = True Then
            anarthsh2pros1.Checked = False
            imglift.Image = My.Resources.Resource1._1προς1_Μηχανικός
        End If

    End Sub

    Private Sub anarthsh2pros1_CheckedChanged(sender As Object, e As EventArgs) Handles anarthsh2pros1.CheckedChanged

        If anarthsh2pros1.Checked = True Then
            anarthsh1pros1.Checked = False
            imglift.Image = My.Resources.Resource1._2προς1_Μηχανικός2
        End If

    End Sub

    Private Sub Wfelimotxt_MouseClick(sender As Object, e As EventArgs) Handles WfelimoFortioField.MouseClick, WfelimoFortiolist.MouseClick, TaxuthtaAnupswshs.MouseClick

        If WfelimoFortiolist.SelectedIndex = 0 Then
            Wfelimotxt.Text = Val(WfelimoFortioField.Text) * 75
        ElseIf WfelimoFortiolist.SelectedIndex = 1 Then
            Wfelimotxt.Text = Val(WfelimoFortioField.Text)
        Else
        End If

    End Sub

    Private Sub MhxEpanw_CheckedChanged(sender As Object, e As EventArgs) Handles MhxEpanw.CheckedChanged

        If MhxEpanw.Checked = True Then
            MhxKatw.Checked = False
            freatio_img.Image = My.Resources.Resource1.freatio_epanw
        End If

    End Sub

    Private Sub MhxKatw_CheckedChanged(sender As Object, e As EventArgs) Handles MhxKatw.CheckedChanged

        If MhxKatw.Checked = True Then
            MhxEpanw.Checked = False
            freatio_img.Image = My.Resources.Resource1.freatio_katw
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles NextCentralTab2.Click
        If Not CentralTabControl.SelectedTab Is TabPage5 Then

            CentralTabControl.SelectedIndex = CentralTabControl.SelectedIndex + 1

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles NextCentralTab3.Click
        If Not CentralTabControl.SelectedTab Is TabPage5 Then

            CentralTabControl.SelectedIndex = CentralTabControl.SelectedIndex + 1

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles NextCentralTab4.Click
        If Not CentralTabControl.SelectedTab Is TabPage5 Then

            CentralTabControl.SelectedIndex = CentralTabControl.SelectedIndex + 1

        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles NextCentralTab5.Click
        If Not CentralTabControl.SelectedTab Is TabPage5 Then

            CentralTabControl.SelectedIndex = CentralTabControl.SelectedIndex + 1

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles PreviousCentralTab2.Click
        If Not CentralTabControl.SelectedTab Is TabPage1 Then

            CentralTabControl.SelectedIndex = CentralTabControl.SelectedIndex - 1

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles PreviousCentralTab3.Click
        If Not CentralTabControl.SelectedTab Is TabPage1 Then

            CentralTabControl.SelectedIndex = CentralTabControl.SelectedIndex - 1

        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles PreviousCentralTab4.Click
        If Not CentralTabControl.SelectedTab Is TabPage1 Then

            CentralTabControl.SelectedIndex = CentralTabControl.SelectedIndex - 1

        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles PreviousCentralTab5.Click
        If Not CentralTabControl.SelectedTab Is TabPage1 Then

            CentralTabControl.SelectedIndex = CentralTabControl.SelectedIndex - 1

        End If
    End Sub
End Class