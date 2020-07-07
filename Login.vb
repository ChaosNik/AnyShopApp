Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data.SqlClient

Public Class FormLogin
    Dim pogresanLogin = False
    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Close()
    End Sub

    Private Sub TextBoxUsername_Click(sender As Object, e As EventArgs) Handles TextBoxUsername.Click
        If TextBoxUsername.Text = "Username" Then
            TextBoxUsername.Text = ""
        End If
    End Sub

    Private Sub TextBoxPassword_Click(sender As Object, e As EventArgs) Handles TextBoxPassword.Click
        If TextBoxPassword.Text = "Password" Then
            TextBoxPassword.Text = ""
        End If
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Server=localhost; user id=root; password=root; database=Trgovina;"
        conn.Open()
    End Sub

    Private Sub FormLogin_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        conn.Close()
    End Sub

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        username = TextBoxUsername.Text
        Dim password = TextBoxPassword.Text

        'Development mode
        '---------------------------------
        If username = "Username" Then
            username = "chaosnik"
        End If
        If password = "Password" Then
            password = "MaliMrav123"
        End If
        '---------------------------------

        Dim hash = 0
        For i = 0 To password.Length - 1
            hash = hash Mod (Integer.MaxValue / 200)
            hash *= 123
            hash += Asc(password(i))
        Next

        cmd.Parameters.Clear()
        cmd.Connection = conn
        cmd.CommandText = "call getLozinkaByKorisnickoIme(@username)"
        cmd.Parameters.AddWithValue("username", username)
        Dim valueText = Convert.ToString(cmd.ExecuteScalar())

        If valueText = "" Then
            pogresanLogin = True
            MessageBox.Show("Nepostojeći korisnik!!!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            Dim value = CInt(valueText)
            If value = hash Then
                'MessageBox.Show("Dobrodošao " + username + "!!!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                cmd.Connection = conn
                cmd.CommandText = "call getImeByKorisnickoIme(@username)"
                Variables.name = Convert.ToString(cmd.ExecuteScalar())

                cmd.Connection = conn
                cmd.CommandText = "call getPrezimeByKorisnickoIme(@username)"
                Variables.surname = Convert.ToString(cmd.ExecuteScalar())

                cmd.Connection = conn
                cmd.CommandText = "call getImeAdministratoraByKorisnickoIme(@username)"
                Dim temp = Convert.ToString(cmd.ExecuteScalar())
                Variables.radnoMjesto = "Administrator"
                If temp = "" Then
                    cmd.CommandText = "call getImeProdavcaByKorisnickoIme(@username)"
                    temp = Convert.ToString(cmd.ExecuteScalar())
                    Variables.radnoMjesto = "Prodavac"
                    If temp = "" Then
                        cmd.CommandText = "call getImeSkladistaraByKorisnickoIme(@username)"
                        temp = Convert.ToString(cmd.ExecuteScalar())
                        Variables.radnoMjesto = "Skladištar"
                    End If
                End If

                Home.Show()
                Me.Hide()
            Else
                pogresanLogin = True
                MessageBox.Show("Unijeli ste pogrešnu lozinku!!!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        End If
    End Sub
End Class