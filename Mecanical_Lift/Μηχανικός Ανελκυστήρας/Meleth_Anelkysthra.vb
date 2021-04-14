Imports System.Data.OleDb

Public Class Meleth_Anelkysthra

    Private Sub Meleth_Anelkysthra_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        WfelimoFortiolist.SelectedIndex = (0)
        YpsosOrofwnList.SelectedIndex = (1)
        EmbadonBox.SelectedIndex = (1)
        ThalamosBox.SelectedIndex = (1)
        IdioBarosCheck.Checked = True
        PosostoAntistathmishs.Text = 0.5

    End Sub


    Private Sub ΒιβλιοθήκεςToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ΒιβλιοθήκεςToolStripMenuItem.Click
        bibliothhkes.Show()
    End Sub

    Private Sub NextCentralTab_Click(sender As Object, e As EventArgs) Handles NextCentralTab1.Click

        If TestMode.Checked = True Then GoTo parabiash


        If (MhxEpanw.Checked = False And MhxKatw.Checked = False) Or (anarthsh1pros1.Checked = False And anarthsh2pros1.Checked = False) Or WfelimoFortiolist.Text = "" _
            Or YpsosOrofwnList.Text = "" Or EmbadonBox.Text = "" Or ThalamosBox.Text = "" Or (IdioBarosCheck.Checked = False And AnalytBarosCheck.Checked = False) _
           Or Wfelimotxt.Text = "" Or ArithmAtomwntxt.Text = "" Or YpsosKtirioutxt.Text = "" Or (ElaxEmbadtxt.Text = "" And MegEmbadtxt.Text = "") Or (PlatosField.Text = "" And BathosField.Text = "") _
           Or (idibarosBox.Text = "" And BarosSasiBox.Text = "" And BarosThalamBox.Text = "") Or WfelimoFortioField.Text = "" Or TaxuthtaAnupswshs.Text = "" Or YpsosKtirioy.Text = "" _
           Or EmbadonThalam.Text = "" Then

                MessageBox.Show("Συμπληρώστε όλα τα πεδία για να συνεχίσετε!")

            ElseIf ElegxosEmbadThalam.ForeColor = Color.Red Then

                MessageBox.Show("Τα όρια δεν είναι στα επιτρεπτά πλαίσια που ορίζει ο κανονισμός!")

            Else
parabiash:
            If Not CentralTabControl.SelectedTab Is TabPage5 Then
                    CentralTabControl.SelectedIndex = CentralTabControl.SelectedIndex + 1
                End If

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

        ElseIf anarthsh1pros1.Checked = False And anarthsh2pros1.Checked = False Then
            imglift.Image = My.Resources.Resource1.blank_image
        End If

    End Sub

    Private Sub anarthsh2pros1_CheckedChanged(sender As Object, e As EventArgs) Handles anarthsh2pros1.CheckedChanged

        If anarthsh2pros1.Checked = True Then
            anarthsh1pros1.Checked = False
            imglift.Image = My.Resources.Resource1._2προς1_Μηχανικός2

        ElseIf anarthsh1pros1.Checked = False And anarthsh2pros1.Checked = False Then
            imglift.Image = My.Resources.Resource1.blank_image
        End If

    End Sub

    Private Sub Wfelimotxt_TextChanged(sender As Object, e As EventArgs) Handles WfelimoFortioField.TextChanged, WfelimoFortiolist.SelectedIndexChanged

        Wfelimotxt.ReadOnly = True
        Wfelimotxt.ForeColor = Color.Red
        Wfelimotxt.BackColor = Wfelimotxt.BackColor

        If WfelimoFortiolist.SelectedIndex = 0 And WfelimoFortioField.Text <> "" Then
            Wfelimotxt.Text = Val(WfelimoFortioField.Text) * 75
        ElseIf WfelimoFortiolist.SelectedIndex = 1 Then
            Wfelimotxt.Text = Val(WfelimoFortioField.Text)
        Else
        End If

    End Sub

    Private Sub ArithmAtomwntxt_TextChanged(sender As Object, e As EventArgs) Handles WfelimoFortioField.TextChanged, WfelimoFortiolist.SelectedIndexChanged

        Dim d As Double

        ArithmAtomwntxt.ReadOnly = True
        ArithmAtomwntxt.ForeColor = Color.Red
        ArithmAtomwntxt.BackColor = ArithmAtomwntxt.BackColor

        If WfelimoFortiolist.SelectedIndex = 0 And WfelimoFortioField.Text <> "" Then
            ArithmAtomwntxt.Text = Val(WfelimoFortioField.Text)
        ElseIf WfelimoFortiolist.SelectedIndex = 1 Then
            d = (Val(WfelimoFortioField.Text) / 75)
            ArithmAtomwntxt.Text = Math.Floor(d)

        Else
        End If

    End Sub

    Private Sub YpsosKtirioutxt_TextChanged(sender As Object, e As EventArgs) Handles YpsosKtirioy.TextChanged, WfelimoFortioField.TextChanged, WfelimoFortiolist.SelectedIndexChanged

        Dim d As Integer

        YpsosKtirioutxt.ReadOnly = True
        YpsosKtirioutxt.ForeColor = Color.Red
        YpsosKtirioutxt.BackColor = YpsosKtirioutxt.BackColor

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
        ElseIf MhxEpanw.Checked = False And MhxKatw.Checked = False Then
            freatio_img.Image = My.Resources.Resource1.blank_image
        End If

    End Sub

    Private Sub MhxKatw_CheckedChanged(sender As Object, e As EventArgs) Handles MhxKatw.CheckedChanged

        If MhxKatw.Checked = True Then
            MhxEpanw.Checked = False
            freatio_img.Image = My.Resources.Resource1.freatio_katw
        ElseIf MhxEpanw.Checked = False And MhxKatw.Checked = False Then
            freatio_img.Image = My.Resources.Resource1.blank_image
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

            ElaxEmbadtxt.BorderStyle = BorderStyle.None
            MegEmbadtxt.BorderStyle = BorderStyle.None

            ElaxEmbadtxt.ReadOnly = True
            MegEmbadtxt.ReadOnly = True

            ElaxEmbadtxt.Text = ""
            MegEmbadtxt.Text = ""

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

            ElaxEmbadtxt.BorderStyle = BorderStyle.None
            MegEmbadtxt.BorderStyle = BorderStyle.None

            ElaxEmbadtxt.ReadOnly = True
            MegEmbadtxt.ReadOnly = True

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

            PlatosField.ForeColor = Color.Black
            BathosField.ForeColor = Color.Black
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

            PlatosField.BorderStyle = BorderStyle.None
            BathosField.BorderStyle = BorderStyle.None

            PlatosField.ReadOnly = True
            BathosField.ReadOnly = True

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
                PlatosField.ForeColor = Color.Green
                PlatosField.BackColor = PlatosField.BackColor
                BathosField.ForeColor = Color.Green
                BathosField.BackColor = BathosField.BackColor
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

    Private Sub EmbadonThalam_TextChanged(sender As Object, e As EventArgs) Handles EmbadonThalam.TextChanged, PlatosField.TextChanged, BathosField.TextChanged

        On Error GoTo Errr

        If PlatosField.Text = "" And BathosField.Text = "" Then

            ElegxosEmbadThalam.Text = ""
            EmbadonThalam.Text = ""

        Else

            EmbadonThalam.Text = (Val(PlatosField.Text) / 1000) * (Val(BathosField.Text) / 1000)
            EmbadonThalam.ReadOnly = True
            EmbadonThalam.ForeColor = Color.Red
            EmbadonThalam.BackColor = BathosField.BackColor

            If EmbadonThalam.Text >= ElaxEmbadtxt.Text And EmbadonThalam.Text <= MegEmbadtxt.Text Then

                ElegxosEmbadThalam.Text = "( Είναι στα επιτρεπτά όρια! )"
                EmbadonThalam.ForeColor = Color.Green
                EmbadonThalam.BackColor = EmbadonThalam.BackColor
                ElegxosEmbadThalam.ForeColor = Color.Green
                ElegxosEmbadThalam.BackColor = ElegxosEmbadThalam.BackColor


            ElseIf EmbadonThalam.Text < ElaxEmbadtxt.Text Or EmbadonThalam.Text > MegEmbadtxt.Text And PlatosField.Text <> "" Or BathosField.Text <> "" Then

                ElegxosEmbadThalam.Text = "( Δεν είναι στα επιτρεπτά όρια! )"
                EmbadonThalam.ForeColor = Color.Red
                EmbadonThalam.BackColor = EmbadonThalam.BackColor
                ElegxosEmbadThalam.ForeColor = Color.Red
                ElegxosEmbadThalam.BackColor = ElegxosEmbadThalam.BackColor

            End If

        End If
Errr:
        Exit Sub

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
            'EmbadonBox.SelectedIndex = 0

            ' ThalamosBox.SelectedIndex = 1
            ThalamosBox.SelectedIndex = 0

            PlatosField.Text = 1000
            BathosField.Text = 1000

            IdioBarosCheck.Checked = True

            PosostoAntistathmishs.Text = 0.5


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

            EmbadonBox.SelectedIndex = 1

            ThalamosBox.SelectedIndex = 1

            EmbadonThalam.Text = ""

            IdioBarosCheck.Checked = False

            PosostoAntistathmishs.Text = ""

        End If

    End Sub

    Private Sub idibarosBox_TextChanged(sender As Object, e As EventArgs) Handles IdioBarosCheck.CheckedChanged, PlatosField.TextChanged, BathosField.TextChanged, ThalamosBox.SelectedIndexChanged

        Dim a, b, ee, temp As String

        a = Val(PlatosField.Text) / 1000
        b = Val(BathosField.Text) / 1000
        ee = (a) * (b)

        If Val(Wfelimotxt.Text) < 500 And PlatosField.Text <> "" And BathosField.Text <> "" Then
            idibarosBox.Text = ""
            temp = (300 + 100 * ee)
            idibarosBox.Text = temp

        ElseIf Val(Wfelimotxt.Text) >= 500 And Val(Wfelimotxt.Text) <= 1000 And PlatosField.Text <> "" And BathosField.Text <> "" Then
            idibarosBox.Text = ""
            temp = (300 + 125 * ee)
            idibarosBox.Text = temp

        ElseIf Val(Wfelimotxt.Text) > 1000 And PlatosField.Text <> "" And BathosField.Text <> "" Then
            idibarosBox.Text = ""
            temp = (300 + 150 * ee)
            idibarosBox.Text = temp

        End If


        If PlatosField.Text = "" Or BathosField.Text = "" Then

            idibarosBox.Text = ""

        End If


        If IdioBarosCheck.Checked = True Then

            AnalytBarosCheck.Checked = False
            BarosSasiBox.Text = ""
            BarosThalamBox.Text = ""
            BarosSasiBox.Enabled = False
            BarosThalamBox.Enabled = False
            AnalytBarosCheck.ForeColor = Color.Gray
            AnalytBarosCheck.BackColor = AnalytBarosCheck.BackColor

            idibarosBox.Enabled = True
            idibarosBox.ReadOnly = True
            idibarosBox.ForeColor = Color.Red
            idibarosBox.BackColor = idibarosBox.BackColor
            IdioBarosCheck.ForeColor = Color.Black
            IdioBarosCheck.BackColor = IdioBarosCheck.BackColor

        ElseIf IdioBarosCheck.Checked = False Then

            IdioBarosCheck.Checked = False
            idibarosBox.Text = ""
            idibarosBox.Enabled = False
            IdioBarosCheck.ForeColor = Color.Gray
            IdioBarosCheck.BackColor = IdioBarosCheck.BackColor

        End If

    End Sub

    Private Sub AnalytBarosCheck_CheckedChanged(sender As Object, e As EventArgs) Handles AnalytBarosCheck.CheckedChanged, PlatosField.TextChanged, BathosField.TextChanged, AnalytikaBarosThalam.Click

        If AnalytBarosCheck.Checked = True Then

            BarosSasiBox.Text = ""
            BarosThalamBox.Text = ""
            BarosSasiBox.Enabled = True
            BarosThalamBox.Enabled = True
            AnalytBarosCheck.Checked = True
            AnalytBarosCheck.ForeColor = Color.Black
            AnalytBarosCheck.BackColor = AnalytBarosCheck.BackColor

            IdioBarosCheck.Checked = False
            idibarosBox.Text = ""
            idibarosBox.Enabled = False
            IdioBarosCheck.ForeColor = Color.Gray
            IdioBarosCheck.BackColor = IdioBarosCheck.BackColor

        ElseIf AnalytBarosCheck.Checked = False Then

            AnalytBarosCheck.Checked = False
            BarosSasiBox.Text = ""
            BarosThalamBox.Text = ""
            BarosSasiBox.Enabled = False
            BarosThalamBox.Enabled = False
            AnalytBarosCheck.ForeColor = Color.Gray
            AnalytBarosCheck.BackColor = AnalytBarosCheck.BackColor

            If BarosThalamBox.Text = "" Then
                AnalytikaBarosThalam.ForeColor = Color.Black
            End If

        End If

    End Sub

    Private Sub PosostoAntistathmishs_TextChanged(sender As Object, e As EventArgs) Handles idibarosBox.TextChanged, IdioBarosCheck.CheckedChanged, AnalytBarosCheck.CheckedChanged, BarosSasiBox.TextChanged, BarosThalamBox.TextChanged

        On Error GoTo Errr

        Dim IdioBaross As Integer


        If PosostoAntistathmishs.Text.Contains(".") Then

            PosostoAntistathmishs.Text = PosostoAntistathmishs.Text.Replace(".", ",")
            PosostoAntistathmishs.Focus()
            PosostoAntistathmishs.Select(PosostoAntistathmishs.Text.Length, 0)

        End If


        If idibarosBox.Text <> "" And IdioBarosCheck.Checked = True Then

            BarosAntibarouBox.ReadOnly = True
            BarosAntibarouBox.ForeColor = Color.Red
            BarosAntibarouBox.BackColor = BarosAntibarouBox.BackColor

            BarosAntibarouBox.Text = Format(idibarosBox.Text) + Format(Wfelimotxt.Text) * Format(PosostoAntistathmishs.Text)

        ElseIf BarosSasiBox.Text <> "" And BarosThalamBox.Text <> "" And AnalytBarosCheck.Checked = True Then


            IdioBaross = Val(BarosSasiBox.Text) + Val(BarosThalamBox.Text)

            BarosAntibarouBox.Text = Val(IdioBaross) + Format(Wfelimotxt.Text) * Format(PosostoAntistathmishs.Text)


            BarosAntibarouBox.ReadOnly = True
            BarosAntibarouBox.ForeColor = Color.Red
            BarosAntibarouBox.BackColor = BarosAntibarouBox.BackColor

        Else
            BarosAntibarouBox.Text = ""

        End If
Errr:
        Exit Sub

    End Sub

    Private Sub AnalytikaBarosThalam_Click(sender As Object, e As EventArgs) Handles IdioBarosCheck.CheckedChanged, AnalytBarosCheck.CheckedChanged

        If IdioBarosCheck.Checked = False And AnalytBarosCheck.Checked = False Then
            AnalytikaBarosThalam.Enabled = True
        ElseIf IdioBarosCheck.Checked = True Or AnalytBarosCheck.Checked = True Then
            AnalytikaBarosThalam.Enabled = False
        End If

    End Sub

    Private Sub AnalytikaBarosThalam2_Click(sender As Object, e As EventArgs) Handles AnalytikaBarosThalam.Click

        AnalytikaBarosThalam.Enabled = True
        If IdioBarosCheck.Checked = False And AnalytBarosCheck.Checked = False Then
            BarosThalamAnalytika.Show()
        End If
    End Sub



End Class