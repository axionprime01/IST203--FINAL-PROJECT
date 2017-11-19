Public Class MainForm
    Private Sub ViewSavedTeamsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewSavedTeamsToolStripMenuItem.Click
        ViewTeamForm.ShowDialog()
    End Sub

    Private Sub LookForAPokemonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LookForAPokemonToolStripMenuItem.Click
        PickPokemonForm.ShowDialog()
    End Sub
End Class
