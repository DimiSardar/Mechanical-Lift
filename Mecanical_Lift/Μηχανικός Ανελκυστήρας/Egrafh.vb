Imports MySql.Data.MySqlClient

Public Class RegisterForm


    Dim MysqlCom As MySqlCommand



    Dim MysqlConn As MySqlConnection



    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click

        ' Me.Close()

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
             "SERVER=sql11.freesqldatabase.com;PORT=3306;USER ID=sql11409686;PASSWORD=wM3xs82Pdb;DATABASE=sql11409686"
        MysqlConn.Open()

        Dim strql As String

        strql = "SELECT *  FROM LoginSystemPasswords "

        'Password

        Dim MysqlCom As MySqlCommand
        Dim MysqlRead As MySqlDataReader

        MysqlCom = New MySqlCommand(strql, MysqlConn)

        MysqlRead = MysqlCom.ExecuteReader

        '(MysqlRead.Read()) And

        MysqlRead.Read()

        If KwdikosBox.Text = MysqlRead("Password").ToString Or OnomaXrhsthBox.Text = MysqlRead("Username").ToString Or EmailBox.Text = MysqlRead("Email").ToString Then

            Dim ans As String

            ans = MsgBox("Έχει γίνει ήδη καταχώρηση, που να ταιριάζει με ένα τουλάχιστον από τα προηγούμενα δεδομένα!")

            OnomaXrhsthBox.Text = ""
            KwdikosBox.Text = ""
            EmailBox.Text = ""

            Exit Sub
        Else
            MsgBox("Δεν υπάρχουν δεδομένα κοινά με προηγούμενα!")


        End If


    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click

        MysqlConn = New MySqlConnection

        MysqlConn.ConnectionString =
             "SERVER=sql11.freesqldatabase.com;PORT=3306;USER ID=sql11409686;PASSWORD=wM3xs82Pdb;DATABASE=sql11409686"

        Try

            MysqlConn.Open()
            MysqlCom = New MySqlCommand("INSERT INTO LoginSystemPasswords ( Username, Password, Email)VALUES('" & OnomaXrhsthBox.Text & "','" & KwdikosBox.Text & "','" & EmailBox.Text & "')", MysqlConn)
            MysqlCom.ExecuteNonQuery()
            MysqlConn.Close()
            MsgBox("Η εγγραφή σας ολοκληρώθηκε!", vbInformation)

        Catch ex As Exception

            MysqlConn.Close()
            MsgBox("ex.message", vbCritical)

        End Try


    End Sub

End Class