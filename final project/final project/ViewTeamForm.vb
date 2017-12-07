Option Strict On
Option Explicit On
Public Class ViewTeamForm
    'declarations and object instance creations
    Dim mTeam As New team
    Private Sub ViewTeamForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'fillls dgvteam
        Me.TeamTableAdapter.Fill(Me.PokemonDataSet.team)

    End Sub
    Private Sub tsbtnCancel_Click(sender As Object, e As EventArgs) Handles tsbtnCancel.Click
        'closes form
        Me.Close()
    End Sub
    'deletes the entire team
    Private Sub tsbtnDeleteTeam_Click(sender As Object, e As EventArgs) Handles tsbtnDeleteTeam.Click
        Dim arraylistids As New List(Of Integer)
        For Each row As DataGridViewRow In dgvteam.Rows

            arraylistids.Add(CInt(row.Cells(0).Value))
        Next
        mTeam.deleteteam(arraylistids)
        dgvteam.DataSource = mTeam.Items
    End Sub

    Private Sub tsbtnAddPokemon_Click(sender As Object, e As EventArgs) Handles tsbtnAddPokemon.Click
        'open new form close current
        addpokemon.ShowDialog()
        Me.Close()
    End Sub
    'deletes specific pokemon
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
    'button to set dgv team to team.items if does not load during formload after the first time
    Private Sub tsbtnShowTeam_Click(sender As Object, e As EventArgs) Handles tsbtnShowTeam.Click
        dgvteam.DataSource = mTeam.Items
    End Sub
End Class