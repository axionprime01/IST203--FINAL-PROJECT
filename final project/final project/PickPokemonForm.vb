Option Strict On
Option Explicit On
Public Class PickPokemonForm
    Dim teamadapter As New PokemonDataSetTableAdapters.teamTableAdapter
    Dim teamtablenumber As New PokemonDataSet.teamDataTable
    Dim index As Integer
    Private mPokemon As New Pokemon
    Dim teamsize As Integer = teamtablenumber.Count()
    Private formloading As Boolean = True
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub PickPokemonForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mPokemon.Pokemonlist.Reset()
        'TODO: This line of code loads data into the 'PokemonDataSet.Pokemon' table. You can move, or remove it, as needed.
        Me.PokemonTableAdapter.Fill(Me.PokemonDataSet.Pokemon)
        Dim mtype As New Type
        With cboType
            .DataSource = mtype.Items
            .DisplayMember = "typing"
            .ValueMember = "typeid"
            .SelectedIndex = -1
        End With
        formloading = False
        dgvPickPokemon.DataSource = mPokemon.Items

    End Sub
    Private Sub btnAddPokemon_Click(sender As Object, e As EventArgs) Handles btnAddPokemon.Click
        If teamsize < 6 Then
            If index < 6 Then
                If dgvPickPokemon.SelectedRows.Count > 0 Then
                    index += 1
                    Dim pkmnindex As Integer = dgvPickPokemon.CurrentCell.RowIndex
                    Dim dexID As Short = CShort(dgvPickPokemon.SelectedRows(0).Cells(0).Value)
                    Dim name As String = CStr(dgvPickPokemon.SelectedRows(0).Cells(1).Value)
                    Dim typeid As Integer = CInt(dgvPickPokemon.SelectedRows(0).Cells(2).Value)
                    Dim ability As String = CStr(dgvPickPokemon.SelectedRows(0).Cells(3).Value)
                    Dim move1 As String = CStr(dgvPickPokemon.SelectedRows(0).Cells(4).Value)
                    Dim move2 As String = CStr(dgvPickPokemon.SelectedRows(0).Cells(5).Value)
                    Dim move3 As String = CStr(dgvPickPokemon.SelectedRows(0).Cells(6).Value)
                    Dim move4 As String = CStr(dgvPickPokemon.SelectedRows(0).Cells(7).Value)
                    teamadapter.Insert(dexID, name, typeid, ability, move1, move2, move3, move4)


                    Dim currencyManager1 As CurrencyManager = CType(BindingContext(dgvPickPokemon.DataSource), CurrencyManager)
                    currencyManager1.SuspendBinding()
                    dgvPickPokemon.Rows(pkmnindex).Visible = False
                    currencyManager1.ResumeBinding()


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

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgvPickPokemon.SelectedRows.Count > 0 Then
            Dim mID As Integer = CInt(dgvPickPokemon.SelectedRows(0).Cells(0).Value)
            Dim frm As New updatepokemon
            frm.id = mID
            frm.ShowDialog()
            dgvPickPokemon.DataSource = mPokemon.Items
        Else
            MessageBox.Show("Please select a pokemon to edit")
        End If
    End Sub
    Private Sub cboType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboType.SelectedIndexChanged
        If formloading = False Then
            Dim typeid As Short = CShort(cboType.SelectedValue)
            dgvPickPokemon.DataSource = mPokemon.GetByType(typeid)
        End If
    End Sub

    Private Sub btnSearchAll_Click(sender As Object, e As EventArgs) Handles btnSearchAll.Click
        dgvPickPokemon.DataSource = mPokemon.Items
    End Sub
End Class