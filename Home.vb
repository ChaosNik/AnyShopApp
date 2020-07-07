Public Class Home
    Private Sub Home_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormLogin.Close()
    End Sub
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Variables.radnoMjesto + " " + Variables.name + " " + Variables.surname
        If radnoMjesto = "Administrator" Then
            Me.Size = New Size(Me.Size.Width, 280)
            ButonZaposleni.Visible = True
            ButtonSkladišta.Visible = True
            ButtonProdavnice.Visible = True
            ButtonPoštanskiBrojevi.Visible = True
        End If
        Me.MinimumSize = Me.Size
        Me.MaximumSize = Me.Size

        ButtonDobavljači.Enabled = False
        ButtonRačuni.Enabled = False
        ButtonBanke.Enabled = False
        ButtonKupci.Enabled = False
        ButtonSkladišta.Enabled = False
        ButtonProdavnice.Enabled = False
        ButtonSkladišta.Enabled = False
        ButtonProdavnice.Enabled = False
        ButtonPoštanskiBrojevi.Enabled = False
    End Sub

    Private Sub ButtonNarudžbe_Click(sender As Object, e As EventArgs) Handles ButtonNarudžbe.Click
        FormNarudžbe.Show()
        Hide()
    End Sub

    Private Sub ButtonRačuni_Click(sender As Object, e As EventArgs) Handles ButtonRačuni.Click

    End Sub

    Private Sub ButtonProizvodi_Click(sender As Object, e As EventArgs) Handles ButtonProizvodi.Click
        FormProizvodi.Show()
        Hide()
    End Sub

    Private Sub ButtonBanke_Click(sender As Object, e As EventArgs) Handles ButtonBanke.Click

    End Sub

    Private Sub ButtonDobavljači_Click(sender As Object, e As EventArgs) Handles ButtonDobavljači.Click

    End Sub

    Private Sub ButtonKupci_Click(sender As Object, e As EventArgs) Handles ButtonKupci.Click

    End Sub

    Private Sub ButonZaposleni_Click(sender As Object, e As EventArgs) Handles ButonZaposleni.Click
        FormZaposleni.Show()
        Hide()
    End Sub

    Private Sub ButtonSkladišta_Click(sender As Object, e As EventArgs) Handles ButtonSkladišta.Click

    End Sub

    Private Sub ButtonProdavnice_Click(sender As Object, e As EventArgs) Handles ButtonProdavnice.Click

    End Sub

    Private Sub ButtonPoštanskiBrojevi_Click(sender As Object, e As EventArgs) Handles ButtonPoštanskiBrojevi.Click

    End Sub

End Class