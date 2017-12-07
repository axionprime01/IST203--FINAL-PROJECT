Option Strict On
Option Explicit On
Public Class PickPokemonForm
    'necessary variable declarations and instance of object creations
    Dim mtype As New Type
    Dim teamadapter As New PokemonDataSetTableAdapters.teamTableAdapter
    Dim teamtablenumber As New PokemonDataSet.teamDataTable
    Dim index As Integer
    Private mPokemon As New Pokemon
    Private formloading As Boolean = True
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'close form
        Me.Close()
    End Sub

    Private Sub PickPokemonForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PokemonTableAdapter.Fill(Me.PokemonDataSet.Pokemon)
        'sets up cbotype
        With cboType
            .DataSource = mtype.Items
            .DisplayMember = "typing"
            .ValueMember = "typeid"
            .SelectedIndex = -1
        End With
        'sets variable to a new value
        formloading = False
        'sets dgv pokemons datasource
        dgvPickPokemon.DataSource = mPokemon.Items
        'reset index value on form_load
        index = 0
    End Sub
    Private Sub btnAddPokemon_Click(sender As Object, e As EventArgs) Handles btnAddPokemon.Click
        'assigns team tablenumber a value
        teamtablenumber = teamadapter.GetData()
        'initializes and assigns teamsize a value
        Dim teamsize As Integer = teamtablenumber.Count()
        If teamsize < 6 Then
            If index < 6 Then
                If dgvPickPokemon.SelectedRows.Count > 0 Then
                    'increase idnex by 1
                    index += 1
                    'variable initalization and assignment
                    Dim pkmnindex As Integer = dgvPickPokemon.CurrentCell.RowIndex
                    Dim dexID As Short = CShort(dgvPickPokemon.SelectedRows(0).Cells(0).Value)
                    Dim name As String = CStr(dgvPickPokemon.SelectedRows(0).Cells(1).Value)
                    Dim typeid As Integer = CInt(dgvPickPokemon.SelectedRows(0).Cells(2).Value)
                    Dim ability As String = CStr(dgvPickPokemon.SelectedRows(0).Cells(3).Value)
                    Dim move1 As String = CStr(dgvPickPokemon.SelectedRows(0).Cells(4).Value)
                    Dim move2 As String = CStr(dgvPickPokemon.SelectedRows(0).Cells(5).Value)
                    Dim move3 As String = CStr(dgvPickPokemon.SelectedRows(0).Cells(6).Value)
                    Dim move4 As String = CStr(dgvPickPokemon.SelectedRows(0).Cells(7).Value)
                    'adds pokemon to your team
                    teamadapter.Insert(dexID, name, typeid, ability, move1, move2, move3, move4)

                    'handles error disallowing us to "hide"pokemon in dgvpickpokemon
                    Dim currencyManager1 As CurrencyManager = CType(BindingContext(dgvPickPokemon.DataSource), CurrencyManager)
                    currencyManager1.SuspendBinding()
                    dgvPickPokemon.Rows(pkmnindex).Visible = False
                    currencyManager1.ResumeBinding()


                End If
            End If
        End If
        'constraints keeping you from doing things
        If teamsize = 6 Then
            MessageBox.Show("please remove some pokemon from your team before attempting to add more.")
        End If
        If index = 6 Then
            MessageBox.Show("please click on the view team button to view your team.")
        End If
    End Sub

    Private Sub btnNEWPKMNINSTANCE_Click(sender As Object, e As EventArgs) Handles btnNEWPKMNINSTANCE.Click
        'open new form close current
        Me.Close()
        addpokemon.ShowDialog()
    End Sub

    Private Sub btnViewTeam_Click(sender As Object, e As EventArgs) Handles btnViewTeam.Click
        'open new form close current
        ViewTeamForm.ShowDialog()
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgvPickPokemon.SelectedRows.Count > 0 Then
            'initialize variable sand object instances and assign them values
            Dim mID As Integer = CInt(dgvPickPokemon.SelectedRows(0).Cells(0).Value)
            Dim frm As New updatepokemon
            frm.id = mID
            'open new form
            frm.ShowDialog()
            dgvPickPokemon.DataSource = mPokemon.Items
        Else
            MessageBox.Show("Please select a pokemon to edit")
        End If
    End Sub
    Private Sub cboType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboType.SelectedIndexChanged
        'handles selecting a different type in cbotype
        If formloading = False Then
            Dim typeid As Short = CShort(cboType.SelectedValue)
            dgvPickPokemon.DataSource = mPokemon.GetByType(typeid)
        End If
    End Sub

    Private Sub btnSearchAll_Click(sender As Object, e As EventArgs) Handles btnSearchAll.Click
        'resets the search filter from a specific type to all pokemon currently available.
        dgvPickPokemon.DataSource = mPokemon.Items
    End Sub
End Class