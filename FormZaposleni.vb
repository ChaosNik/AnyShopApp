Public Class FormZaposleni
    Private Sub FormZaposleni_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmd.CommandText = "select * from SviZaposleni;"
        Dim table = New DataTable()
        Dim tableReader = cmd.ExecuteReader()
        table.Load(tableReader)
        tableReader.Close()

        DataGridViewTabela.DataSource = table
        DataGridViewTabela.Refresh()
    End Sub
    Private Sub FormZaposleni_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        cmd.CommandText = "select * from SviZaposleni;"
        Dim table = New DataTable()
        Dim tableReader = cmd.ExecuteReader()
        table.Load(tableReader)
        tableReader.Close()

        DataGridViewTabela.DataSource = table
        DataGridViewTabela.Refresh()
    End Sub

    Private Sub ButtonDodajZaposlenog_Click(sender As Object, e As EventArgs) Handles ButtonDodajZaposlenog.Click
        FormDodajZaposlenog.Show()
        Hide()
    End Sub

    Private Sub ButtonUkloniZaposlenog_Click(sender As Object, e As EventArgs) Handles ButtonUkloniZaposlenog.Click
        FormUkloniZaposlenog.Show()
        Hide()
    End Sub

    Private Sub FormZaposleni_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Home.Show()
    End Sub
End Class