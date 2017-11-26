Option Strict On
Option Explicit On
Public Class PickPokemonForm
    Private mPokemon As New Pokemon
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub PickPokemonForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PokemonDataSet.Pokemon' table. You can move, or remove it, as needed.
        Me.PokemonTableAdapter.Fill(Me.PokemonDataSet.Pokemon)

    End Sub

    Private Sub dgvPickPokemon_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPickPokemon.CellContentClick

    End Sub

    Private Sub btnAddPokemon_Click(sender As Object, e As EventArgs) Handles btnAddPokemon.Click
        'Dim index As Integer
        'If index < 6 Then
        '    Do While index < 6
        '        index += 1
        '        If dgvPickPokemon.SelectedRows.Count > 0 Then
        '            Dim dexID As Short = CShort(dgvPickPokemon.SelectedRows(0).Cells(0).Value)
        '            If mPokemon.Delete(dexID) Then
        '                dgvPickPokemon.DataSource = mPokemon.Items
        '            Else
        '                MessageBox.Show("could not delete pokemon")
        '            End If
        '        End If
        '    Loop
        'Else
        '    MessageBox.Show("hi")
        'End If
    End Sub

    Private Sub btnNEWPKMNINSTANCE_Click(sender As Object, e As EventArgs) Handles btnNEWPKMNINSTANCE.Click
        Me.Close()
        addpokemon.ShowDialog()
    End Sub
End Class