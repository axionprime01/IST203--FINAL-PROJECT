Option Strict On
Option Explicit On
Public Class PickPokemonForm
    Dim pokedex As New SortedDictionary(Of Integer, Pokemon)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub PickPokemonForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'add pokemon to pokedex sorted dictionary
        pokedex.Add(127, New Pokemon(127, "Pinsir",
                                            "bug",
                                            "hypercutter / mold breaker",
                                            "quick attack",
                                            "earthquake",
                                            "swaords dance",
                                            "return"))
        pokedex.Add(214, New Pokemon(214, "Heracross",
                                            "bug/fighting",
                                            "Swarm/guts/moxie",
                                            "Close combat",
                                            "megahorn",
                                            "siesmic toss",
                                            "stone edge"))
        pokedex.Add(248, New Pokemon(248, "Tyranitar",
                                            "Rock/dark",
                                            "Sandstream",
                                            "Pursuit",
                                            "crunch",
                                            "stealth rock",
                                            "stone edge"))
        pokedex.Add(141, New Pokemon(141, "Kabutops",
                                            "Rock/water",
                                            "swift swim/battle armor",
                                            "aqua jet",
                                            "waterfall",
                                            "swords dance",
                                            "stone edge"))
        pokedex.Add(186, New Pokemon(186, "Politoed",
                                            "Water",
                                            "Damp/water absorb/Drizzle",
                                            "scald",
                                            "perish song",
                                            "toxic",
                                            "ice beam"))
        pokedex.Add(4, New Pokemon(4, "Charmander",
                                        "fire",
                                        "Blaze",
                                        "scratch",
                                        "ember",
                                        "tackle",
                                        "flamethrower"))
        pokedex.Add(1, New Pokemon(1, "Bulbasaur",
                                        "grass",
                                        "Overgrow/Chlorophyll",
                                        "leechseed",
                                        "vinewhip",
                                        "tackle",
                                        "razerleaf"))
        fillpokedex()
    End Sub
    Public Sub fillpokedex()
        lstboxPokemon.Items.Clear()
        For Each entry In pokedex
            lstboxPokemon.Items.Add(entry.Value.ToString)
        Next
    End Sub
End Class