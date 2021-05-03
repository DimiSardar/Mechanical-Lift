Imports MySql.Data.MySqlClient

Public Class Eisodos

    Dim MysqlConn As MySqlConnection

    Private Sub Eisodos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection

        MysqlConn.ConnectionString =
             "SERVER=sql11.freesqldatabase.com;PORT=3306;USER ID=sql11409686;PASSWORD=wM3xs82Pdb;DATABASE=sql11409686"

        Try
            MysqlConn.Open()
            MsgBox("Η σύνδεση σας είναι επιτυχής!")
        Catch ex As Exception
            MsgBox("Η σύνδεση είναι αδύνατη. Παρακαλώ πολύ επικοινωνήστε με τον διαχειριστή του συστήματος!", vbExclamation)
            MsgBox(ex.Message)
            MysqlConn.Close()
        End Try



    End Sub

    Private Sub EgrafhBtn_Click(sender As Object, e As EventArgs) Handles EgrafhBtn.Click

        RegisterForm.Show()

    End Sub

    Private Sub EjodosBtn_Click(sender As Object, e As EventArgs) Handles EjodosBtn.Click

        Me.Close()

    End Sub

    Private Sub EisodosBtn_Click(sender As Object, e As EventArgs) Handles EisodosBtn.Click


    End Sub

End Class