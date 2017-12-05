Option Strict On
Option Explicit On
Public Class PickPokemonForm
    Dim teamadapter As New PokemonDataSetTableAdapters.teamTableAdapter
    Dim teamtablenumber As New PokemonDataSet.teamDataTable
    Dim index As Integer
    Private mPokemon As New Pokemon
    Dim teamsize As Integer = teamtablenumber.Count()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub PickPokemonForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PokemonDataSet.Pokemon' table. You can move, or remove it, as needed.
        mPokemon.Pokemonlist.Reset()
        Me.PokemonTableAdapter.Fill(Me.PokemonDataSet.Pokemon)


    End Sub
    Private Sub btnAddPokemon_Click(sender As Object, e As EventArgs) Handles btnAddPokemon.Click
        If teamsize < 6 Then
            If index < 6 Then
                If dgvPickPokemon.SelectedRows.Count > 0 Then
                    index += 1
                    Dim dexID As Short = CShort(dgvPickPokemon.SelectedRows(0).Cells(0).Value)
                    Dim name As String = CStr(dgvPickPokemon.SelectedRows(0).Cells(1).Value)
                    Dim type As String = CStr(dgvPickPokemon.SelectedRows(0).Cells(2).Value)
                    Dim ability As String = CStr(dgvPickPokemon.SelectedRows(0).Cells(3).Value)
                    Dim move1 As String = CStr(dgvPickPokemon.SelectedRows(0).Cells(4).Value)
                    Dim move2 As String = CStr(dgvPickPokemon.SelectedRows(0).Cells(5).Value)
                    Dim move3 As String = CStr(dgvPickPokemon.SelectedRows(0).Cells(6).Value)
                    Dim move4 As String = CStr(dgvPickPokemon.SelectedRows(0).Cells(7).Value)
                    If mPokemon.Delete(dexID) Then
                        teamadapter.Insert(dexID, name, type, ability, move1, move2, move3, move4)
                        dgvPickPokemon.DataSource = mPokemon.Items
                    End If
                End If
            End If
        End If
        If teamsize = 6 Then
            MessageBox.Show("please remove some pokemon from your team before attempting to add more.")
        End If
        If index = 6 Then
            MessageBox.Show("please click on the view team button to view your team.")
        End If
    End Sub

    Private Sub btnNEWPKMNINSTANCE_Click(sender As Object, e As EventArgs) Handles btnNEWPKMNINSTANCE.Click
        Me.Close()
        addpokemon.ShowDialog()
    End Sub

    Private Sub btnViewTeam_Click(sender As Object, e As EventArgs) Handles btnViewTeam.Click
        ViewTeamForm.ShowDialog()
        Me.Close()
    End Sub
End Class