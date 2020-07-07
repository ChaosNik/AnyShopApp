Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data.SqlClient
Imports System
Imports System.Collections

Public Class FormNarudžbe
    Public id As Integer = 0
    Public Function ExportDataTable(table As DataTable) As List(Of List(Of Object))
        Dim result As New List(Of List(Of Object))
        For Each row As DataRow In table.Rows
            Dim values As New List(Of Object)
            For Each column As DataColumn In table.Columns
                If row.IsNull(column) Then
                    values.Add(Nothing)
                Else
                    values.Add(row.Item(column))
                End If
            Next
            result.Add(values)
        Next
        Return result
    End Function
    Private Sub FormNarudžbe_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Home.Show()
    End Sub

    Private Sub FormNarudžbe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = FormatDateTime(DateAndTime.Today, DateFormat.LongDate)
        ButtonStavke.Enabled = False

        cmd.Parameters.Clear()
        cmd.Connection = conn

        cmd.CommandText = "call getStavkeNarudzbeById(" + CStr(id) + ");"
        Dim table = New DataTable()
        Dim tableReader = cmd.ExecuteReader()
        table.Load(tableReader)
        tableReader.Close()

        DataGridViewTabela.DataSource = table
        DataGridViewTabela.Refresh()


        cmd.CommandText = "select NazivDobavljaca from Dobavljac;"
        tableReader = cmd.ExecuteReader()
        Dim listaDobavljača As New List(Of String)
        For Each value In tableReader
            listaDobavljača.Add(tableReader.GetString(0))
        Next
        tableReader.Close()

        ComboBoxDobavljač.DataSource = listaDobavljača
        ComboBoxDobavljač.Refresh()


        cmd.CommandText = "select NazivProdavnice from Prodavnica;"
        tableReader = cmd.ExecuteReader()
        Dim listaProdavnica As New List(Of String)
        For Each value In tableReader
            listaProdavnica.Add(tableReader.GetString(0))
        Next
        tableReader.Close()

        ComboBoxProdavnica.DataSource = listaProdavnica
        ComboBoxProdavnica.Refresh()

        If ButtonStavke.Enabled = False Then
            cmd.CommandText = "select max(IdNarudzbe) from Narudzba;"
            Me.id = CInt(cmd.ExecuteScalar()) + 1
        End If

    End Sub

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        If ButtonStavke.Enabled = False Then
            Dim currentDate As Date = FormatDateTime(DateAndTime.Today, DateFormat.ShortDate)
            cmd.CommandText = "select IdDobavljaca from Dobavljac where NazivDobavljaca='" + ComboBoxDobavljač.SelectedValue.ToString() + "';"
            Dim idDobavljaca As Integer = cmd.ExecuteScalar()
            cmd.CommandText = "select IdProdavnice from Prodavnica where NazivProdavnice='" + ComboBoxProdavnica.SelectedValue.ToString() + "';"
            Dim idProdavnice As Integer = cmd.ExecuteScalar()
            Dim cd As String = currentDate.ToShortDateString
            Dim ri As String = currentDate.AddDays(CInt(TextBoxRokIsporuke.Text)).ToShortDateString()
            cmd.CommandText = "call setNarudzba(" + CStr(idProdavnice) + "," + CStr(idDobavljaca) + ",'" + cd + "','" + ri + "');"
            cmd.ExecuteScalar()
            ButtonStavke.Enabled = True
        Else
            Close()
        End If
    End Sub

    Private Sub ButtonStavke_Click(sender As Object, e As EventArgs) Handles ButtonStavke.Click
        FormStavkeNarudžbe.Show()
        Me.Hide()
    End Sub

    Private Sub FormNarudžbe_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        cmd.CommandText = "call getStavkeNarudzbeById(" + CStr(id) + ");"
        Dim table = New DataTable()
        Dim tableReader = cmd.ExecuteReader()
        table.Load(tableReader)
        tableReader.Close()

        DataGridViewTabela.DataSource = table
        DataGridViewTabela.Refresh()

        cmd.CommandText = "select count(Ukupno)from SveStavkeNarudzbe where ID=" + CStr(id) + ";"
        Dim temp As String = cmd.ExecuteScalar()
        If Not temp = "0" Then
            cmd.CommandText = "select sum(Ukupno) from SveStavkeNarudzbe where ID=" + CStr(id) + ";"
            TextBoxUkupno.Text = cmd.ExecuteScalar()
            LabelUkupno.Visible = True
            LabelKM.Visible = True
            TextBoxUkupno.Visible = True
        End If
    End Sub

    Private Sub ButtonPregled_Click(sender As Object, e As EventArgs) Handles ButtonPregled.Click
        FormPregledNarudžbi.Show()
        Me.Hide()
    End Sub
End Class