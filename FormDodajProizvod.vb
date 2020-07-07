Public Class FormDodajProizvod
    Private Sub FormDodajProizvod_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormProizvodi.Show()
    End Sub

    Private Sub FormDodajProizvod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmd.CommandText = "select NazivVrsteProizvoda from Vrsta_proizvoda;"
        Dim tableReader = cmd.ExecuteReader()
        Dim listaVrsta As New List(Of String)
        For Each value In tableReader
            listaVrsta.Add(tableReader.GetString(0))
        Next
        tableReader.Close()

        ComboBoxVrsta.DataSource = listaVrsta
        ComboBoxVrsta.Refresh()

        cmd.CommandText = "select NazivMotiva from Motiv;"
        tableReader = cmd.ExecuteReader()
        Dim listaMotiva As New List(Of String)
        For Each value In tableReader
            listaMotiva.Add(tableReader.GetString(0))
        Next
        tableReader.Close()

        ComboBoxMotiv.DataSource = listaMotiva
        ComboBoxMotiv.Refresh()
    End Sub

    Private Sub ButtonDodaj_Click(sender As Object, e As EventArgs) Handles ButtonDodaj.Click
        Dim naziv = TextBoxNaziv.Text
        Dim vrsta = ComboBoxVrsta.Text
        Dim motiv = ComboBoxMotiv.Text
        Dim cijena = TextBoxCijena.Text

        cmd.CommandText = "select IdVrsteProizvoda from Vrsta_proizvoda where NazivVrsteProizvoda='" + vrsta + "';"
        Dim idVrste As String = cmd.ExecuteScalar()

        cmd.CommandText = "select IdMotiva from Motiv where NazivMotiva='" + motiv + "';"
        Dim idMotiva As String = cmd.ExecuteScalar()

        cmd.CommandText = "call addProizvod('" + naziv + "'," + idVrste + "," + idMotiva + "," + cijena + ");"
        cmd.ExecuteScalar()

        MessageBox.Show("Uspješno ste dodali proizvod " + naziv + "!!!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        TextBoxNaziv.Text = ""
        ComboBoxVrsta.Text = ""
        ComboBoxMotiv.Text = ""
        TextBoxCijena.Text = ""
    End Sub
End Class