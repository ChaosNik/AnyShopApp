Public Class FormStavkeNarudžbe
    Private Sub FormStavkeNarudžbe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmd.Parameters.Clear()
        cmd.Connection = conn

        cmd.CommandText = "call getStavkeNarudzbeById(" + CStr(FormNarudžbe.id) + ");"
        Dim table = New DataTable()
        Dim tableReader = cmd.ExecuteReader()
        table.Load(tableReader)
        tableReader.Close()

        DataGridViewTabela.DataSource = table
        DataGridViewTabela.Refresh()

        cmd.CommandText = "select NazivProizvoda,Motiv.NazivMotiva from Proizvod inner join Motiv on Motiv.IdMotiva=Proizvod.IdMotiva;"
        tableReader = cmd.ExecuteReader()
        Dim listaProizvoda As New List(Of String)
        For Each value In tableReader
            listaProizvoda.Add(tableReader.GetString(0) + "-" + (tableReader.GetString(1)))
        Next
        tableReader.Close()

        ComboBoxNazivProizvoda.DataSource = listaProizvoda
        ComboBoxNazivProizvoda.Refresh()
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Close()
    End Sub

    Private Sub FormStavkeNarudžbe_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormNarudžbe.Show()
    End Sub

    Private Sub ButtonDodaj_Click(sender As Object, e As EventArgs) Handles ButtonDodaj.Click
        Dim nazivProizvoda As String = ComboBoxNazivProizvoda.Text.Split("-")(0)
        Dim nazivMotiva As String = ComboBoxNazivProizvoda.Text.Split("-")(1)
        cmd.CommandText = "select IdMotiva from Motiv where NazivMotiva='" + nazivMotiva + "';"
        Dim idMotiva As String = cmd.ExecuteScalar()
        cmd.CommandText = "select IdProizvoda from Proizvod where NazivProizvoda='" + nazivProizvoda + "' and idMotiva='" + idMotiva + "';"
        Dim idProizvoda As String = cmd.ExecuteScalar()

        cmd.CommandText = "call setStavkaNarudzbe(" + CStr(FormNarudžbe.id) + "," + idProizvoda + "," + TextBoxKoličina.Text + ");"
        cmd.ExecuteScalar()

        cmd.CommandText = "call getStavkeNarudzbeById(" + CStr(FormNarudžbe.id) + ");"
        Dim table = New DataTable()
        Dim tableReader = cmd.ExecuteReader()
        table.Load(tableReader)
        tableReader.Close()

        DataGridViewTabela.DataSource = table
        DataGridViewTabela.Refresh()
    End Sub
End Class