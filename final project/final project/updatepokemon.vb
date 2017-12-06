Option Explicit On
Option Strict On
Public Class updatepokemon
    Public Property id As Integer
    Dim mPokemon As New Pokemon
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub updatepokemon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim row As PokemonDataSet.PokemonRow
        row = mPokemon.FindByID(CShort(id))
        lblid.Text = CStr(row.ID)
        lblName.Text = row.name
        lblTyping.Text = CStr(row.typeid)
        txtAbility.Text = row.ability
        txtMove1.Text = row.move1
        txtMove2.Text = row.move2
        txtMove3.Text = row.move3
        txtMove4.Text = row.move4
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim ability As String = txtAbility.Text
        Dim move1 As String = txtMove1.Text
        Dim move2 As String = txtMove2.Text
        Dim move3 As String = txtMove3.Text
        Dim move4 As String = txtMove4.Text
        If mPokemon.Update(id, ability, move1, move2, move3, move4) Then
            Me.Close()
        Else
            MessageBox.Show("unable to update pokemon.")
        End If
    End Sub
End Class