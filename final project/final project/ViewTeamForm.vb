Option Strict On
Option Explicit On
Public Class ViewTeamForm
    Dim mTeam As New team
    Private Sub ViewTeamForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PokemonDataSet.team' table. You can move, or remove it, as needed.
        Me.TeamTableAdapter.Fill(Me.PokemonDataSet.team)

    End Sub
    Private Sub tsbtnCancel_Click(sender As Object, e As EventArgs) Handles tsbtnCancel.Click
        Me.Close()
    End Sub

    Private Sub tsbtnDeleteTeam_Click(sender As Object, e As EventArgs) Handles tsbtnDeleteTeam.Click
        Dim arraylistids As New List(Of Integer)
        For Each row As DataGridViewRow In dgvteam.Rows

            arraylistids.Add(CInt(row.Cells(0).Value))
        Next
        mTeam.deleteteam(arraylistids)
        dgvteam.DataSource = mTeam.Items
    End Sub

    Private Sub tsbtnAddPokemon_Click(sender As Object, e As EventArgs) Handles tsbtnAddPokemon.Click
        addpokemon.ShowDialog()
        Me.Close()
    End Sub

    Private Sub tsbtnDeletePokemon_Click(sender As Object, e As EventArgs) Handles tsbtnDeletePokemon.Click
        If dgvteam.SelectedRows.Count > 0 Then
            Dim dexID As Short = CShort(dgvteam.SelectedRows(0).Cells(0).Value)
            If mTeam.Delete(dexID) Then
                dgvteam.DataSource = mTeam.Items
            Else
                MessageBox.Show("could not delete pokemon")
            End If
        End If
    End Sub

    Private Sub tsbtnShowTeam_Click(sender As Object, e As EventArgs) Handles tsbtnShowTeam.Click
        dgvteam.DataSource = mTeam.Items
    End Sub
End Class