Imports System.Data.OleDb

Public Class Meleth_Anelkysthra

    Private Sub Meleth_Anelkysthra_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        WfelimoFortiolist.SelectedIndex = (0)
        YpsosOrofwnList.SelectedIndex = (1)
        EmbadonBox.SelectedIndex = (1)
        ThalamosBox.SelectedIndex = (1)

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

    Private Sub Wfelimotxt_TextChanged(sender As Object, e As EventArgs) Handles WfelimoFortioField.TextChanged, WfelimoFortiolist.SelectedIndexChanged

        If WfelimoFortiolist.SelectedIndex = 0 And WfelimoFortioField.Text <> "" Then
            Wfelimotxt.Text = Val(WfelimoFortioField.Text) * 75
        ElseIf WfelimoFortiolist.SelectedIndex = 1 Then
            Wfelimotxt.Text = Val(WfelimoFortioField.Text)
        Else
        End If

    End Sub

    Private Sub ArithmAtomwntxt_TextChanged(sender As Object, e As EventArgs) Handles WfelimoFortioField.TextChanged, WfelimoFortiolist.SelectedIndexChanged

        Dim d As Double

        If WfelimoFortiolist.SelectedIndex = 0 And WfelimoFortioField.Text <> "" Then
            ArithmAtomwntxt.Text = Val(WfelimoFortioField.Text)
        ElseIf WfelimoFortiolist.SelectedIndex = 1 Then
            d = (Val(WfelimoFortioField.Text) / 75)
            ArithmAtomwntxt.Text = Math.Floor(d)

        Else
        End If

    End Sub

    Private Sub YpsosKtirioutxt_TextChanged(sender As Object, e As EventArgs) Handles YpsosKtirioy.TextChanged

        Dim d As Integer

        If YpsosOrofwnList.SelectedIndex = 0 Then
            YpsosKtirioutxt.Text = Val(YpsosKtirioy.Text)
        ElseIf YpsosOrofwnList.SelectedIndex = 1 Then
            d = (Val(YpsosKtirioy.Text) * 3)
            YpsosKtirioutxt.Text = Math.Floor(d + 3)

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

    Private Sub ElaxEmbadtxt_TextChanged(sender As Object, e As EventArgs) Handles ArithmAtomwntxt.TextChanged, Wfelimotxt.TextChanged, EmbadonBox.SelectedIndexChanged

        If EmbadonBox.SelectedIndex = 0 Then

            ElaxEmbadtxt.ReadOnly = False
            ElaxEmbadtxt.Text = ""
            elxtEmbtxt.Text = ""
            ElaxEmbadtxt.BorderStyle = BorderStyle.Fixed3D
            ElaxEmbadtxt.ForeColor = Color.Black

        ElseIf EmbadonBox.SelectedIndex = 1 Then

            elxtEmbtxt.Text = ""

            ElaxEmbadtxt.Text = ""

            On Error GoTo Err
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
                elxtEmbtxt.Text = "( Από πίνακα )"
                ElaxEmbadtxt.ReadOnly = True
                ElaxEmbadtxt.BorderStyle = BorderStyle.None
                ElaxEmbadtxt.ForeColor = Color.Green
                ElaxEmbadtxt.BackColor = ElaxEmbadtxt.BackColor

            End If

            myreader.Close()
            conn.Close()

        End If


Err:
        Exit Sub

    End Sub

    Private Sub MegEmbadtxt_TextChanged(sender As Object, e As EventArgs) Handles ArithmAtomwntxt.TextChanged, Wfelimotxt.TextChanged, EmbadonBox.SelectedIndexChanged

        If EmbadonBox.SelectedIndex = 0 Then

            MegEmbadtxt.ReadOnly = False
            MegEmbadtxt.Text = ""
            megEmbtxt.Text = ""
            MegEmbadtxt.BorderStyle = BorderStyle.Fixed3D
            MegEmbadtxt.ForeColor = Color.Black

        ElseIf EmbadonBox.SelectedIndex = 1 Then

            megEmbtxt.Text = ""

            MegEmbadtxt.Text = ""

            On Error GoTo Err
            Dim conn As New OleDbConnection

            conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\GitHub\Mechanical Lift\Mecanical_Lift\Libraries\DataAccess_Libraries\Table.Max_UseFull_Chamber_Area.accdb")
            conn.Open()

            Dim strql As String

            strql = "SELECT Maximum_Useful_Chamber_Area_m2 FROM Maximum_Useful_Chamber WHERE Useful_Load_kg =" + Wfelimotxt.Text + " ORDER BY Useful_Load_kg DESC"
            Dim cmd As New OleDbCommand(strql, conn)
            Dim myreader As OleDbDataReader

            myreader = cmd.ExecuteReader

            If (myreader.Read()) Then

                MegEmbadtxt.Text = myreader("Maximum_Useful_Chamber_Area_m2")
                megEmbtxt.Text = "( Από πίνακα )"
                MegEmbadtxt.ReadOnly = True
                MegEmbadtxt.BorderStyle = BorderStyle.None
                MegEmbadtxt.ForeColor = Color.Green
                MegEmbadtxt.BackColor = MegEmbadtxt.BackColor

            ElseIf ArithmAtomwntxt.Text = 1 Then
                MegEmbadtxt.Text = 0.37

            ElseIf ArithmAtomwntxt.Text = 2 Then
                MegEmbadtxt.Text = 0.58

            ElseIf ArithmAtomwntxt.Text = 21 Then
                MegEmbadtxt.Text = 3.56

            ElseIf ArithmAtomwntxt.Text = 26 Then
                MegEmbadtxt.Text = 4.2

            ElseIf ArithmAtomwntxt.Text = 33 Then
                MegEmbadtxt.Text = 5

            End If

            myreader.Close()
            conn.Close()

        End If

Err:
        Exit Sub

    End Sub

    Private Sub ThalamosBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ThalamosBox.SelectedIndexChanged, ElaxEmbadtxt.TextChanged, MegEmbadtxt.TextChanged

        If ThalamosBox.SelectedIndex = 0 Then

            PlatosField.ReadOnly = False
            BathosField.ReadOnly = False
            PlatosField.Text = ""
            BathosField.Text = ""
            PlatosField.BorderStyle = BorderStyle.Fixed3D
            BathosField.BorderStyle = BorderStyle.Fixed3D
            platTxt.Text = ""
            bathosTxt.Text = ""

        ElseIf ThalamosBox.SelectedIndex = 1 Then

            platTxt.Text = ""
            bathosTxt.Text = ""

            PlatosField.Text = ""
            BathosField.Text = ""

            On Error GoTo Err
            Dim conn As New OleDbConnection

            conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\GitHub\Mechanical Lift\Mecanical_Lift\Libraries\DataAccess_Libraries\Table.Standard_Lift_Chambers.accdb")
            conn.Open()

            Dim strql As String

            strql = "SELECT Width_mm, Depth_mm FROM Standard_Lift_Cabins WHERE Number_Of_Passengers =" + ArithmAtomwntxt.Text + ""


            Dim cmd As New OleDbCommand(strql, conn)
            Dim myreader As OleDbDataReader

            myreader = cmd.ExecuteReader


            If (myreader.Read()) Then

                PlatosField.Text = myreader("Width_mm")
                BathosField.Text = myreader("Depth_mm")
                PlatosField.ReadOnly = True
                BathosField.ReadOnly = True
                PlatosField.ForeColor = Color.Green
                PlatosField.BackColor = PlatosField.BackColor
                BathosField.ForeColor = Color.Green
                BathosField.BackColor = BathosField.BackColor
                PlatosField.BorderStyle = BorderStyle.None
                BathosField.BorderStyle = BorderStyle.None
                platTxt.Text = "( Από πίνακα )"
                bathosTxt.Text = "( Από πίνακα )"

            End If

            myreader.Close()
            conn.Close()
Err:
            Exit Sub


        Else
        End If

    End Sub

    Private Sub TestMode_CheckedChanged(sender As Object, e As EventArgs) Handles TestMode.CheckedChanged

        If TestMode.Checked = True Then

            'MhxEpanw.Checked = True
            MhxKatw.Checked = True

            'anarthsh1pros1.Checked = True
            anarthsh2pros1.Checked = True

            ' WfelimoFortiolist.SelectedIndex = 1
            ' WfelimoFortioField.Text = 2000

            WfelimoFortiolist.SelectedIndex = 0
            WfelimoFortioField.Text = 8

            TaxuthtaAnupswshs.Text = 0.64

            YpsosOrofwnList.SelectedIndex = 1
            YpsosKtirioy.Text = 7

            EmbadonBox.SelectedIndex = 1

            ThalamosBox.SelectedIndex = 1



        ElseIf TestMode.Checked = False Then

            'MhxEpanw
            MhxKatw.Checked = False

            'anarthsh1pros1
            anarthsh2pros1.Checked = False

            WfelimoFortiolist.SelectedIndex = False
            WfelimoFortioField.Text = ""

            TaxuthtaAnupswshs.Text = ""

            YpsosOrofwnList.SelectedIndex = False
            YpsosKtirioy.Text = ""

            Wfelimotxt.Text = ""
            ArithmAtomwntxt.Text = ""
            YpsosKtirioutxt.Text = ""

            ElaxEmbadtxt.Text = ""
            MegEmbadtxt.Text = ""

            PlatosField.Text = ""
            BathosField.Text = ""

            EmbadonBox.SelectedIndex = False

            ThalamosBox.SelectedIndex = False

            idibarosBox.Text = ""

        End If

    End Sub

    Private Sub idibarosBox_TextChanged(sender As Object, e As EventArgs) Handles PlatosField.TextChanged, BathosField.TextChanged

        Dim a, b, ee, temp As Integer

        a = Val(PlatosField.Text) / 1000
        b = Val(BathosField.Text) / 1000
        ee = Val(a) * Val(b)

        If Val(Wfelimotxt.Text) < 500 Then

            temp = 300 + 100 * ee
            idibarosBox.ForeColor = Color.Red
            idibarosBox.BackColor = idibarosBox.BackColor
            idibarosBox.Text = temp

        ElseIf Val(Wfelimotxt.Text) >= 500 And Val(Wfelimotxt.Text) <= 1000 Then

            temp = 300 + 125 * ee
            idibarosBox.ForeColor = Color.Red
            idibarosBox.BackColor = idibarosBox.BackColor
            idibarosBox.Text = temp

        ElseIf Val(Wfelimotxt.Text) > 1000 Then

            temp = 300 + 150 * ee
            idibarosBox.ForeColor = Color.Red
            idibarosBox.BackColor = idibarosBox.BackColor
            idibarosBox.Text = temp

        End If



    End Sub
End Class