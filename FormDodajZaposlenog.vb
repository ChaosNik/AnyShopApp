Public Class FormDodajZaposlenog
    Private Sub FormDodajZaposlenog_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormZaposleni.Show()
    End Sub

    Private Sub FormDodajZaposlenog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmd.CommandText = "select NazivProdavnice from Prodavnica;"
        Dim tableReader = cmd.ExecuteReader()
        Dim listaProdavnica As New List(Of String)
        For Each value In tableReader
            listaProdavnica.Add(tableReader.GetString(0))
        Next
        tableReader.Close()

        ComboBoxRadnoMjesto.DataSource = listaProdavnica
        ComboBoxRadnoMjesto.Refresh()
    End Sub

    Private Sub ButtonDodaj_Click(sender As Object, e As EventArgs) Handles ButtonDodaj.Click
        If Not TextBoxJMB.TextLength = 13 Then
            MessageBox.Show("Dužina JMB mora biti 13 karaktera!!!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Else
            Dim ime = TextBoxIme.Text
            Dim prezime = TextBoxPrezime.Text
            Dim jmb = TextBoxJMB.Text
            Dim korisnickoIme = TextBoxKorisničkoIme.Text
            Dim lozinka = TextBoxLozinka.Text
            Dim radnoMjesto = ComboBoxRadnoMjesto.Text

            Dim hash = 0
            For i = 0 To lozinka.Length - 1
                hash = hash Mod (Integer.MaxValue / 200)
                hash *= 123
                hash += Asc(lozinka(i))
            Next

            cmd.CommandText = "call addZaposleni('" + ime + "','" + prezime + "','" + jmb + "','" + korisnickoIme + "'," + CStr(hash) + ");"
            cmd.ExecuteScalar()

            cmd.CommandText = "select IdProdavnice from Prodavnica where NazivProdavnice='" + radnoMjesto + "';"
            Dim idProdavnice As String = cmd.ExecuteScalar()

            cmd.CommandText = "select max(IdZaposlenog) from Zaposleni;"
            Dim idZaposlenog As String = cmd.ExecuteScalar()

            cmd.CommandText = "insert into Zaposleni_u_prodavnici(IdZaposlenog, IdProdavnice) values (" + idZaposlenog + "," + idProdavnice + ");"
            cmd.ExecuteScalar()

            MessageBox.Show("Uspješno ste dodali korisnika " + ime + " " + prezime + "!!!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        End If
    End Sub
End Class