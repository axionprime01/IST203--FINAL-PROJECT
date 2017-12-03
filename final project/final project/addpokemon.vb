Option Strict On
Option Explicit On
Public Class addpokemon
    Dim apokemon As New Pokemon
    Private Sub addpokemon_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub btnAddPokemon_Click(sender As Object, e As EventArgs) Handles btnAddPokemon.Click
        Dim mID As Integer
        If txtTyping.Text = "" Then
        ElseIf txtTyping.Text IsNot "fire" Then
            MessageBox.Show("please enter a correct choice for typing options")
        ElseIf txtTyping.Text IsNot "normal" Then
            MessageBox.Show("please enter a correct choice for typing options")
        ElseIf txtTyping.Text IsNot "fighting" Then
            MessageBox.Show("please enter a correct choice for typing options")
        ElseIf txtTyping.Text IsNot "water" Then
            MessageBox.Show("please enter a correct choice for typing options")
        ElseIf txtTyping.Text IsNot "flying" Then
            MessageBox.Show("please enter a correct choice for typing options")
        ElseIf txtTyping.Text IsNot "grass" Then
            MessageBox.Show("please enter a correct choice for typing options")
        ElseIf txtTyping.Text IsNot "poison" Then
            MessageBox.Show("please enter a correct choice for typing options")
        ElseIf txtTyping.Text IsNot "electric" Then
            MessageBox.Show("please enter a correct choice for typing options")
        ElseIf txtTyping.Text IsNot "ground" Then
            MessageBox.Show("please enter a correct choice for typing options")
        ElseIf txtTyping.Text IsNot "psychic" Then
            MessageBox.Show("please enter a correct choice for typing options")
        ElseIf txtTyping.Text IsNot "bug" Then
            MessageBox.Show("please enter a correct choice for typing options")
        ElseIf txtTyping.Text IsNot "dragon" Then
            MessageBox.Show("please enter a correct choice for typing options")
        ElseIf txtTyping.Text IsNot "rock" Then
            MessageBox.Show("please enter a correct choice for typing options")
        ElseIf txtTyping.Text IsNot "ice" Then
            MessageBox.Show("please enter a correct choice for typing options")
        ElseIf txtTyping.Text IsNot "ghost" Then
            MessageBox.Show("please enter a correct choice for typing options")
        ElseIf txtTyping.Text IsNot "dark" Then
            MessageBox.Show("please enter a correct choice for typing options")
        ElseIf txtTyping.Text IsNot "steel" Then
            MessageBox.Show("please enter a correct choice for typing options")
        ElseIf txtTyping.Text IsNot "fairy" Then
            MessageBox.Show("please enter a correct choice for typing options")
        Else
            If Integer.TryParse(txtID.Text, mID) Then
                mID = CInt(txtID.Text)
                Dim mName As String = txtName.Text
                Dim mTyping As String = txtTyping.Text
                Dim mAbility As String = txtAbility.Text
                Dim mMove1 As String = txtMove1.Text
                Dim mMove2 As String = txtMove2.Text
                Dim mMove3 As String = txtMove3.Text
                Dim mMove4 As String = txtMove4.Text
                apokemon.Insert(mID, mName, mTyping, mAbility, mMove1, mMove2, mMove3, mMove4)
                MessageBox.Show("successfully added pokemon!")
                Me.Close()
            Else
                StatusStrip1.Text = "please enter a proper integer ID number greater than 0"
                Return
            End If
        End If
    End Sub
End Class