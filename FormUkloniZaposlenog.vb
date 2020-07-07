Public Class FormUkloniZaposlenog
    Private Sub UkloniDodajZaposlenog_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormZaposleni.Show()
    End Sub

    Private Sub FormUkloniZaposlenog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmd.CommandText = "select ImeZaposlenog,PrezimeZaposlenog,KorisnickoIme from Zaposleni;"
        Dim tableReader = cmd.ExecuteReader()
        Dim lista As New List(Of String)
        For Each value In tableReader
            lista.Add(tableReader.GetString(0) + "-" + tableReader.GetString(1) + "-" + tableReader.GetString(2))
        Next
        tableReader.Close()

        ComboBoxKorisnici.DataSource = lista
        ComboBoxKorisnici.Refresh()
    End Sub

    Private Sub ButtonUkloni_Click(sender As Object, e As EventArgs) Handles ButtonUkloni.Click
        Dim ime = ComboBoxKorisnici.Text.Split("-")(0)
        Dim prezime = ComboBoxKorisnici.Text.Split("-")(1)
        Dim korisnickoIme = ComboBoxKorisnici.Text.Split("-")(2)

        cmd.CommandText = "select IdZaposlenog from Zaposleni where ImeZaposlenog='" + ime + "' and PrezimeZaposlenog='" + prezime + "' and KorisnickoIme='" + korisnickoIme + "';"
        Dim idZaposlenog As String = cmd.ExecuteScalar()

        cmd.CommandText = "delete from Zaposleni where IdZaposlenog='" + idZaposlenog + "';"
        cmd.ExecuteScalar()

        MessageBox.Show("Uspješno ste uklonili korisnika " + ime + " " + prezime + "!!!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)


        cmd.CommandText = "select ImeZaposlenog,PrezimeZaposlenog,KorisnickoIme from Zaposleni;"
        Dim tableReader = cmd.ExecuteReader()
        Dim lista As New List(Of String)
        For Each value In tableReader
            lista.Add(tableReader.GetString(0) + "-" + tableReader.GetString(1) + "-" + tableReader.GetString(2))
        Next
        tableReader.Close()

        ComboBoxKorisnici.DataSource = lista
        ComboBoxKorisnici.Refresh()
    End Sub
End Class