Imports System.Data.OleDb

Public Class Meleth_Anelkysthra


    Private Sub Meleth_Anelkysthra_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


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

    Private Sub Wfelimotxt_MouseClick(sender As Object, e As EventArgs) Handles WfelimoFortioField.MouseClick, WfelimoFortiolist.MouseClick, TaxuthtaAnupswshs.MouseClick, Panel2.Paint

        If WfelimoFortiolist.SelectedIndex = 0 Then
            Wfelimotxt.Text = Val(WfelimoFortioField.Text) * 75
        ElseIf WfelimoFortiolist.SelectedIndex = 1 Then
            Wfelimotxt.Text = Val(WfelimoFortioField.Text)
        Else
        End If

    End Sub

    Private Sub ArithmAtomwntxt_Click(sender As Object, e As EventArgs) Handles ArithmAtomwntxt.Click, WfelimoFortiolist.MouseClick, TaxuthtaAnupswshs.MouseClick, Panel2.Paint

        Dim d As Double

        If WfelimoFortiolist.SelectedIndex = 0 Then
            ArithmAtomwntxt.Text = Val(WfelimoFortioField.Text)
        ElseIf WfelimoFortiolist.SelectedIndex = 1 Then
            d = (Val(WfelimoFortioField.Text) / 75)
            ArithmAtomwntxt.Text = Math.Floor(d)

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

    Private Sub ElaxEmbadtxt_click(sender As Object, e As EventArgs) Handles ElaxEmbadtxt.Click

        Dim conn As New OleDbConnection

        conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\GitHub\Mechanical Lift\Mecanical_Lift\Libraries\DataAccess_Libraries\Table.Min_UseFull_Chamber_Area.accdb")
        conn.Open()

        Dim strql As String

        strql = "SELECT Minimum_Useful_Chamber_Area_m2 FROM Minimum_Useful_Chamber WHERE Number_Of_Passengers =" + ArithmAtomwntxt.Text + ""

        Dim cmd As New OleDbCommand(strql, conn)
        Dim myreader As OleDbDataReader

        myreader = cmd.ExecuteReader

        If (myreader.Read()) Then

            ElaxEmbadtxt.Text = myreader("Minimum_Useful_Chamber_Area_m2")


        End If

        myreader.Close()
        conn.Close()

    End Sub

End Class