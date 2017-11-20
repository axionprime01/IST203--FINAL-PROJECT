Option Strict On
Option Explicit On
Public Class PickPokemonForm
    Dim pokedex As New SortedDictionary(Of Integer, Pokemon)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub PickPokemonForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PokemonDataSet.Pokemon' table. You can move, or remove it, as needed.
        Me.PokemonTableAdapter.Fill(Me.PokemonDataSet.Pokemon)

    End Sub

    Private Sub dgvPickPokemon_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPickPokemon.CellContentClick

    End Sub
End Class