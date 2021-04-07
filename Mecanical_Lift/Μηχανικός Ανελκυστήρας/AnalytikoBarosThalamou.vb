Public Class BarosThalamAnalytika

    Private Sub Baros_Thalamou_TextChanged(sender As Object, e As EventArgs) Handles Orofh.SelectedIndexChanged, Pseudorofh.SelectedIndexChanged, Plaina.SelectedIndexChanged, Ypostrwma_Plainwn.SelectedIndexChanged, Epikalupsh_Plainwn.SelectedIndexChanged, Metalliko_Dapedo.SelectedIndexChanged, Ypostrwma_Dapedou.SelectedIndexChanged, Epistrwsh_Dapedou.SelectedIndexChanged
        On Error GoTo Errr

        Orofh.SelectedIndex = 1
        Pseudorofh.SelectedIndex = 0
        Plaina.SelectedIndex = 1
        Ypostrwma_Plainwn.SelectedIndex = 1
        Epikalupsh_Plainwn.SelectedIndex = 1
        Metalliko_Dapedo.SelectedIndex = 1
        Ypostrwma_Dapedou.SelectedIndex = 1
        Epistrwsh_Dapedou.SelectedIndex = 4
        Ypsos_Thalamou.Value = 2.1

        Dim axb, orofi, pseudorofi, PlainaThalamou, YpostPlainwn, EpiklPlainwn, MetalDapedo, YpostDapedou, EpistDapedou As Integer
        Dim U, EmbPlainwn, platos, bathos, axbxu As String

        platos = Meleth_Anelkysthra.PlatosField.Text
        bathos = Meleth_Anelkysthra.BathosField.Text
        U = Ypsos_Thalamou.Text
        axb = (Val(platos) / 1000 * Val(bathos) / 1000)  ' Εμβαδόν δαπέδου
        axbxu = ((Val(platos) / 1000) + 2 * (Val(bathos) / 1000)) * U ' Εμβαδόν πλαϊνών

        EmbPlainwn = (U * (2 * bathos / 1000 + platos / 1000)).ToString

        If Orofh.SelectedIndex = 0 Then
            orofi = 20
        ElseIf Orofh.SelectedIndex = 1 Then
            orofi = 27
        End If

        If Pseudorofh.SelectedIndex = 0 Then
            pseudorofi = 7
        End If

        If Plaina.SelectedIndex = 0 Then
            PlainaThalamou = (136 / EmbPlainwn)
        ElseIf Plaina.SelectedIndex = 1 Then
            PlainaThalamou = (170 / EmbPlainwn)
        End If

        If Ypostrwma_Plainwn.SelectedIndex = 0 Then
            YpostPlainwn = 10 / EmbPlainwn
        ElseIf Ypostrwma_Plainwn.SelectedIndex = 1 Then
            YpostPlainwn = 30 / EmbPlainwn
        ElseIf Ypostrwma_Plainwn.SelectedIndex = 2 Then
            YpostPlainwn = 42 / EmbPlainwn
        End If

        If Epikalupsh_Plainwn.SelectedIndex = 0 Then
            EpiklPlainwn = 6 / EmbPlainwn
        ElseIf Epikalupsh_Plainwn.SelectedIndex = 1 Then
            EpiklPlainwn = 60 / EmbPlainwn
        End If

        If Metalliko_Dapedo.SelectedIndex = 0 Then
            MetalDapedo = 28
        ElseIf Metalliko_Dapedo.SelectedIndex = 1 Then
            MetalDapedo = 34
        End If

        If Ypostrwma_Dapedou.SelectedIndex = 0 Then
            YpostDapedou = 16
        ElseIf Ypostrwma_Dapedou.SelectedIndex = 1 Then
            YpostDapedou = 24
        ElseIf Ypostrwma_Dapedou.SelectedIndex = 2 Then
            YpostDapedou = 32
        End If

        If Epistrwsh_Dapedou.SelectedIndex = 0 Then
            EpistDapedou = 4
        ElseIf Epistrwsh_Dapedou.SelectedIndex = 1 Then
            EpistDapedou = 8
        ElseIf Epistrwsh_Dapedou.SelectedIndex = 2 Then
            EpistDapedou = 17
        ElseIf Epistrwsh_Dapedou.SelectedIndex = 3 Then
            EpistDapedou = 27
        ElseIf Epistrwsh_Dapedou.SelectedIndex = 4 Then
            EpistDapedou = 44
        End If

        Baros_Thalamou.Text = Math.Ceiling((axb) * (orofi + pseudorofi) + (axb) * (MetalDapedo + YpostDapedou + EpistDapedou) + (axbxu) * (YpostPlainwn + EpiklPlainwn + PlainaThalamou))



Errr:
        Exit Sub

    End Sub

    Private Sub SynexeiaStoProgramma_Click(sender As Object, e As EventArgs) Handles SynexeiaStoProgramma.Click

        Meleth_Anelkysthra.BarosThalamBox.Text = Baros_Thalamou.Text
        Meleth_Anelkysthra.AnalytikaBarosThalam.ForeColor = Color.Green
        Meleth_Anelkysthra.BarosThalamBox.Enabled = True
        Meleth_Anelkysthra.BarosThalamBox.ReadOnly = True
        Meleth_Anelkysthra.BarosThalamBox.ForeColor = Color.Green
        Meleth_Anelkysthra.BarosThalamBox.BackColor = Meleth_Anelkysthra.BarosThalamBox.BackColor
        Me.Close()

    End Sub
End Class