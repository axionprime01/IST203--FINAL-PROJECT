Option Strict On
Option Explicit On
Public Class addpokemon
    'necessary variable declarations and object instance creations
    Dim apokemon As New Pokemon
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'closes form
        Me.Close()
    End Sub

    Private Sub btnAddPokemon_Click(sender As Object, e As EventArgs) Handles btnAddPokemon.Click
        'necessary variable declarations
        Dim mID As Integer
        'validate controls
        If Integer.TryParse(txtID.Text, mID) Then
            If apokemon.checkId(mID) = False Then
                'declare and assign variables
                Dim mName As String = txtName.Text
                Dim mtypingid As Integer
                Dim mAbility As String = txtAbility.Text
                Dim mMove1 As String = txtMove1.Text
                Dim mMove2 As String = txtMove2.Text
                Dim mMove3 As String = txtMove3.Text
                Dim mMove4 As String = txtMove4.Text
                'more validation
                If IsNumeric(mName) = True Or txtName.Text = "" Then
                    MessageBox.Show("please enter a non numberic value for your name")
                    Return
                End If
                If IsNumeric(mAbility) = True Or txtAbility.Text = "" Then
                    MessageBox.Show("please enter a non numeric value for your ability")
                    Return
                End If
                If IsNumeric(mMove1) = True Or txtMove1.Text = "" Then
                    MessageBox.Show("please enter a non numberic value for your move1")
                    Return
                End If
                If IsNumeric(mMove2) = True Or txtMove2.Text = "" Then
                    MessageBox.Show("please enter a non numberic value for your move2")
                    Return
                End If
                If IsNumeric(mMove3) = True Or txtMove3.Text = "" Then
                    MessageBox.Show("please enter a non numberic value for your move3")
                    Return
                End If
                If IsNumeric(mMove4) = True Or txtMove4.Text = "" Then
                    MessageBox.Show("please enter a non numberic value for your move4")
                    Return
                End If
                If Integer.TryParse(txtTyping.Text, mtypingid) And mtypingid <= 18 Then
                    'add pokemon to database
                    apokemon.Insert(mID, mName, mtypingid, mAbility, mMove1, mMove2, mMove3, mMove4)
                    MessageBox.Show("successfully added pokemon!")
                    Me.Close()
                Else
                    MessageBox.Show("please enter one of the valid type ids")
                End If
            Else
                MessageBox.Show("please enter a unique id number")
            End If
        Else
            MessageBox.Show("please enter a proper integer ID number greater than 0")
        End If
    End Sub
End Class