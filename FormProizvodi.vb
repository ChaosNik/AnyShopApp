Public Class FormProizvodi
    Private Sub FormProizvodi_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Home.Show()
    End Sub

    Private Sub ButtonDodaj_Click(sender As Object, e As EventArgs) Handles ButtonDodaj.Click
        FormDodajProizvod.Show()
        Hide()
    End Sub

    Private Sub ButtonUkloni_Click(sender As Object, e As EventArgs) Handles ButtonUkloni.Click
        FormUkloniProizvod.Show()
        Hide()
    End Sub

    Private Sub FormProizvodi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmd.CommandText = "select * from SviProizvodi;"
        Dim table = New DataTable()
        Dim tableReader = cmd.ExecuteReader()
        table.Load(tableReader)
        tableReader.Close()

        DataGridViewTabela.DataSource = table
        DataGridViewTabela.Refresh()
    End Sub

    Private Sub FormProizvodi_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        cmd.CommandText = "select * from SviProizvodi;"
        Dim table = New DataTable()
        Dim tableReader = cmd.ExecuteReader()
        table.Load(tableReader)
        tableReader.Close()

        DataGridViewTabela.DataSource = table
        DataGridViewTabela.Refresh()
    End Sub
End Class