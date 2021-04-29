Imports System.Data.OleDb
Public Class BarosThalamAnalytika

    Private Sub Baros_Thalamou_TextChanged(sender As Object, e As EventArgs) Handles Orofh.SelectedIndexChanged, Pseudorofh.SelectedIndexChanged, Plaina.SelectedIndexChanged, Ypostrwma_Plainwn.SelectedIndexChanged, Epikalupsh_Plainwn.SelectedIndexChanged, Metalliko_Dapedo.SelectedIndexChanged, Ypostrwma_Dapedou.SelectedIndexChanged, Epistrwsh_Dapedou.SelectedIndexChanged
        On Error GoTo Errr

        Dim axb, orofi, pseudorofi, PlainaThalamou, YpostPlainwn, EpiklPlainwn, MetalDapedo, YpostDapedou, EpistDapedou, EmbPlainwn, U, platos, bathos As Double

        platos = Meleth_Anelkysthra.PlatosField.Text
        bathos = Meleth_Anelkysthra.BathosField.Text

        U = Ypsos_Thalamou.Text
        axb = (Val(platos) / 1000 * Val(bathos) / 1000)  ' Εμβαδόν δαπέδου
        EmbPlainwn = (U * (2 * (bathos / 1000) + (platos / 1000))) ' Εμβαδόν πλαϊνών

        If Orofh.SelectedIndex = 2 Then
            orofi = 20
        ElseIf Orofh.SelectedIndex = 3 Then
            orofi = 27
        End If

        If Pseudorofh.SelectedIndex = 2 Then
            pseudorofi = 7
        End If

        If Plaina.SelectedIndex = 2 Then
            PlainaThalamou = (136 / 6.3)
        ElseIf Plaina.SelectedIndex = 3 Then
            PlainaThalamou = (170 / 6.3)
        End If

        If Ypostrwma_Plainwn.SelectedIndex = 2 Then
            YpostPlainwn = (10 / 6.3)
        ElseIf Ypostrwma_Plainwn.SelectedIndex = 3 Then
            YpostPlainwn = (30 / 6.3)
        ElseIf Ypostrwma_Plainwn.SelectedIndex = 4 Then
            YpostPlainwn = (42 / 6.3)
        End If

        If Epikalupsh_Plainwn.SelectedIndex = 2 Then
            EpiklPlainwn = (6 / 6.3)
        ElseIf Epikalupsh_Plainwn.SelectedIndex = 3 Then
            EpiklPlainwn = (60 / 6.3)
        End If

        If Metalliko_Dapedo.SelectedIndex = 2 Then
            MetalDapedo = 28
        ElseIf Metalliko_Dapedo.SelectedIndex = 3 Then
            MetalDapedo = 34
        End If

        If Ypostrwma_Dapedou.SelectedIndex = 2 Then
            YpostDapedou = 16
        ElseIf Ypostrwma_Dapedou.SelectedIndex = 3 Then
            YpostDapedou = 24
        ElseIf Ypostrwma_Dapedou.SelectedIndex = 4 Then
            YpostDapedou = 32
        End If

        If Epistrwsh_Dapedou.SelectedIndex = 1 Then
            EpistDapedou = 4
        ElseIf Epistrwsh_Dapedou.SelectedIndex = 2 Then
            EpistDapedou = 8
        ElseIf Epistrwsh_Dapedou.SelectedIndex = 3 Then
            EpistDapedou = 17
        ElseIf Epistrwsh_Dapedou.SelectedIndex = 4 Then
            EpistDapedou = 27
        ElseIf Epistrwsh_Dapedou.SelectedIndex = 5 Then
            EpistDapedou = 44
        End If

        Baros_Thalamou.Text = Math.Ceiling((axb) * (orofi + pseudorofi) + (axb) * (MetalDapedo + YpostDapedou + EpistDapedou) + (EmbPlainwn) * (YpostPlainwn + EpiklPlainwn + PlainaThalamou))


Errr:
        Exit Sub

    End Sub

    Private Sub AnoigmaOdhgApo_Click(sender As Object, e As EventArgs) Handles EpiloghMazasSasi.TextChanged, Orofh.SelectedIndexChanged, Pseudorofh.SelectedIndexChanged, Plaina.SelectedIndexChanged, Ypostrwma_Plainwn.SelectedIndexChanged, Epikalupsh_Plainwn.SelectedIndexChanged, Metalliko_Dapedo.SelectedIndexChanged, Ypostrwma_Dapedou.SelectedIndexChanged, Epistrwsh_Dapedou.SelectedIndexChanged

        WfelimoAnalThalam.Text = Meleth_Anelkysthra.Wfelimotxt.Text
        ArithAtomAnalThalam.Text = Meleth_Anelkysthra.ArithmAtomwntxt.Text

        On Error GoTo Err
        Dim conn As New OleDbConnection

        conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\GitHub\Mechanical Lift\Mecanical_Lift\Libraries\DataAccess_Libraries\Table.Suspension_Frame_Weights.accdb")
        conn.Open()

        Dim strql As String

        strql = "SELECT Drivers_Distance_mm_From, Drivers_Distance_mm_To,Weight_Of_Frame_Suspension_kg_From,Weight_Of_Frame_Suspension_kg_To FROM Detailed_Weight_Of_Chassis WHERE Useful_Load_Mass_kg =" + WfelimoAnalThalam.Text + ""


        Dim cmd As New OleDbCommand(strql, conn)
        Dim myreader As OleDbDataReader

        myreader = cmd.ExecuteReader


        If (myreader.Read()) Then

            AnoigmaOdhgApo.Text = myreader("Drivers_Distance_mm_From")
            AnoigmaOdhgEws.Text = myreader("Drivers_Distance_mm_To")

            BarosPlaisiouApo.Text = myreader("Weight_Of_Frame_Suspension_kg_From")
            BarosPlaisiouEws.Text = myreader("Weight_Of_Frame_Suspension_kg_To")

            AnoigmaOdhgApo.ForeColor = Color.Green
            AnoigmaOdhgApo.BackColor = AnoigmaOdhgApo.BackColor
            AnoigmaOdhgEws.ForeColor = Color.Green
            AnoigmaOdhgEws.BackColor = AnoigmaOdhgEws.BackColor

            BarosPlaisiouApo.ForeColor = Color.Green
            BarosPlaisiouApo.BackColor = BarosPlaisiouApo.BackColor
            BarosPlaisiouEws.ForeColor = Color.Green
            BarosPlaisiouEws.BackColor = BarosPlaisiouEws.BackColor

        End If


        If EpiloghMazasSasi.Value <= BarosPlaisiouEws.Text And EpiloghMazasSasi.Value >= BarosPlaisiouApo.Text Then
            MazaSasi.Text = EpiloghMazasSasi.Text
        End If

        If MazaSasi.Text <= BarosPlaisiouEws.Text And MazaSasi.Text >= BarosPlaisiouApo.Text And EpiloghMazasSasi.Text <> "" _
            And Orofh.SelectedIndex > 1 _
            And Pseudorofh.SelectedIndex > 1 _
            And Plaina.SelectedIndex > 1 _
            And Ypostrwma_Plainwn.SelectedIndex > 1 _
            And Epikalupsh_Plainwn.SelectedIndex > 1 _
            And Metalliko_Dapedo.SelectedIndex > 1 _
            And Ypostrwma_Dapedou.SelectedIndex > 1 _
            And Epistrwsh_Dapedou.SelectedIndex > 0 Then

            SynexeiaStoProgramma.Enabled = True
            SynexeiaStoProgramma.ForeColor = Color.Green
            SynexeiaStoProgramma.BackColor = SynexeiaStoProgramma.BackColor
        Else
            SynexeiaStoProgramma.ForeColor = Color.Gray
            SynexeiaStoProgramma.BackColor = SynexeiaStoProgramma.BackColor
            SynexeiaStoProgramma.Enabled = False
        End If

        myreader.Close()
        conn.Close()

Err:
        Exit Sub

    End Sub

    Private Sub SynexeiaStoProgramma_Click(sender As Object, e As EventArgs) Handles SynexeiaStoProgramma.Click

        If MazaSasi.Text <= BarosPlaisiouEws.Text And MazaSasi.Text >= BarosPlaisiouApo.Text And EpiloghMazasSasi.Text <> "" _
            And Orofh.SelectedIndex > 1 _
            And Pseudorofh.SelectedIndex > 1 _
            And Plaina.SelectedIndex > 1 _
            And Ypostrwma_Plainwn.SelectedIndex > 1 _
            And Epikalupsh_Plainwn.SelectedIndex > 1 _
            And Metalliko_Dapedo.SelectedIndex > 1 _
            And Ypostrwma_Dapedou.SelectedIndex > 1 _
            And Epistrwsh_Dapedou.SelectedIndex > 0 Then

            SynexeiaStoProgramma.ForeColor = Color.Green
            SynexeiaStoProgramma.BackColor = SynexeiaStoProgramma.BackColor

            Meleth_Anelkysthra.BarosThalamBox.Text = Baros_Thalamou.Text
            Meleth_Anelkysthra.BarosSasiBox.Text = MazaSasi.Text

            Meleth_Anelkysthra.AnalytikaBarosThalam.ForeColor = Color.Green

            Meleth_Anelkysthra.BarosThalamBox.Enabled = True
            Meleth_Anelkysthra.BarosThalamBox.ReadOnly = True

            Meleth_Anelkysthra.BarosSasiBox.Enabled = True
            Meleth_Anelkysthra.BarosSasiBox.ReadOnly = True

            Meleth_Anelkysthra.BarosThalamBox.ForeColor = Color.Green
            Meleth_Anelkysthra.BarosThalamBox.BackColor = Meleth_Anelkysthra.BarosThalamBox.BackColor

            Meleth_Anelkysthra.BarosSasiBox.ForeColor = Color.Green
            Meleth_Anelkysthra.BarosSasiBox.BackColor = Meleth_Anelkysthra.BarosSasiBox.BackColor

            Me.WindowState = FormWindowState.Minimized

        End If

    End Sub

    Private Sub BarosThalamTestMode_CheckedChanged(sender As Object, e As EventArgs) Handles BarosThalamTestMode.CheckedChanged

        If BarosThalamTestMode.Checked = True Then

            Orofh.SelectedIndex = 3
            Pseudorofh.SelectedIndex = 2
            Plaina.SelectedIndex = 3
            Ypostrwma_Plainwn.SelectedIndex = 4
            Epikalupsh_Plainwn.SelectedIndex = 3
            Metalliko_Dapedo.SelectedIndex = 3
            Ypostrwma_Dapedou.SelectedIndex = 4
            Epistrwsh_Dapedou.SelectedIndex = 5

            EpiloghMazasSasi.Text = (Val(BarosPlaisiouApo.Text) + Val(BarosPlaisiouEws.Text)) / 2


        ElseIf BarosThalamTestMode.Checked = False Then

            Orofh.SelectedIndex = False
            Pseudorofh.SelectedIndex = False
            Plaina.SelectedIndex = False
            Ypostrwma_Plainwn.SelectedIndex = False
            Epikalupsh_Plainwn.SelectedIndex = False
            Metalliko_Dapedo.SelectedIndex = False
            Ypostrwma_Dapedou.SelectedIndex = False
            Epistrwsh_Dapedou.SelectedIndex = False
            Ypsos_Thalamou.Value = 2.1

        End If

    End Sub


End Class