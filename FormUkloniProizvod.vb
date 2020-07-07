Public Class FormUkloniProizvod
    Private Sub FormUkloniProizvod_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormProizvodi.Show()
    End Sub

    Private Sub FormUkloniProizvod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmd.CommandText = "select NazivProizvoda,Motiv.NazivMotiva from Proizvod inner join Motiv on Motiv.IdMotiva=Proizvod.IdMotiva;"
        Dim tableReader = cmd.ExecuteReader()
        Dim lista As New List(Of String)
        For Each value In tableReader
            lista.Add(tableReader.GetString(0) + "-" + tableReader.GetString(1))
        Next
        tableReader.Close()

        ComboBoxNaziv.DataSource = lista
        ComboBoxNaziv.Refresh()
    End Sub

    Private Sub ButtonUkloni_Click(sender As Object, e As EventArgs) Handles ButtonUkloni.Click
        Dim naziv = ComboBoxNaziv.Text.Split("-")(0)
        Dim motiv = ComboBoxNaziv.Text.Split("-")(1)

        cmd.CommandText = "select IdMotiva from Motiv where NazivMotiva='" + motiv + "';"
        Dim idMotiva As String = cmd.ExecuteScalar()

        cmd.CommandText = "select IdProizvoda from Proizvod where NazivProizvoda='" + naziv + "' and IdMotiva='" + idMotiva + "';"
        Dim idProizvoda As String = cmd.ExecuteScalar()

        cmd.CommandText = "delete from Proizvod where IdProizvoda='" + idProizvoda + "';"
        cmd.ExecuteScalar()

        MessageBox.Show("Uspješno ste uklonili Proizvod " + ComboBoxNaziv.Text + "!!!", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        cmd.CommandText = "select NazivProizvoda,Motiv.NazivMotiva from Proizvod inner join Motiv on Motiv.IdMotiva=Proizvod.IdMotiva;"
        Dim tableReader = cmd.ExecuteReader()
        Dim lista As New List(Of String)
        For Each value In tableReader
            lista.Add(tableReader.GetString(0) + "-" + tableReader.GetString(1))
        Next
        tableReader.Close()

        ComboBoxNaziv.DataSource = lista
        ComboBoxNaziv.Refresh()
    End Sub
End Class