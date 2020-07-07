Public Class FormPregledNarudžbi
    Private Sub ButtonPrikaži_Click(sender As Object, e As EventArgs) Handles ButtonPrikaži.Click
        Dim id = ComboBoxId.Text.Split("-")(0)
        cmd.CommandText = "call getStavkeNarudzbeById(" + id + ");"
        Dim table = New DataTable()
        Dim tableReader = cmd.ExecuteReader()
        table.Load(tableReader)
        tableReader.Close()

        DataGridViewTabela.DataSource = table
        DataGridViewTabela.Refresh()

        cmd.CommandText = "select count(IdNarudzbe) from Narudzba where IdNarudzbe=" + id + ";"
        Dim res As String = cmd.ExecuteScalar()
        If Not res = "0" Then
            cmd.CommandText = "select DatumKreiranjaNarudzbe from Narudzba where IdNarudzbe=" + id + ";"
            TextBoxNaručeno.Text = cmd.ExecuteScalar()
            cmd.CommandText = "select RokIsporuke from Narudzba where IdNarudzbe=" + id + ";"
            TextBoxRok.Text = cmd.ExecuteScalar()
        End If
    End Sub

    Private Sub FormPregledNarudžbi_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        FormNarudžbe.Show()
    End Sub

    Private Sub FormPregledNarudžbi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmd.CommandText = "select IdNarudzbe,DatumKreiranjaNarudzbe from Narudzba;"
        Dim tableReader = cmd.ExecuteReader()
        Dim lista As New List(Of String)
        For Each value In tableReader
            lista.Add(tableReader.GetString(0) + "-" + tableReader.GetString(1))
        Next
        tableReader.Close()

        ComboBoxId.DataSource = lista
        ComboBoxId.Refresh()
    End Sub

    Private Sub FormPregledNarudžbi_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        cmd.CommandText = "select IdNarudzbe,DatumKreiranjaNarudzbe from Narudzba;"
        Dim tableReader = cmd.ExecuteReader()
        Dim lista As New List(Of String)
        For Each value In tableReader
            lista.Add(tableReader.GetString(0) + "-" + tableReader.GetString(1))
        Next
        tableReader.Close()

        ComboBoxId.DataSource = lista
        ComboBoxId.Refresh()
    End Sub
End Class