Option Strict On
Option Explicit On
Public Class Pokemon
    Private adapter As New PokemonDataSetTableAdapters.PokemonTableAdapter
    Public ReadOnly Property Pokemonlist As DataTable
        Get
            Dim listAdapter As New PokemonDataSetTableAdapters.PokemonTableAdapter
            Return listAdapter.GetData()
        End Get
    End Property
    Public Shared Property LastError As String
    Public Function Insert(ByVal pID As Integer,
                           ByVal pName As String,
                           ByVal pTyping As String,
                           ByVal pAbility As String,
                           ByVal pMove1 As String,
                           ByVal pMove2 As String,
                           ByVal pMove3 As String,
                           ByVal pMove4 As String) As Boolean
        'insert a new row into th eappointments talbe. return true if successful.
        'if an exception is thrown, last error will hold an error message.
        Try
            LastError = String.Empty
            adapter.Insert(pID, pName, pTyping, pAbility, pMove1, pMove2, pMove3, pMove4)
            Return True
        Catch ex As Exception
            LastError = ex.Message
            Return False
        End Try
    End Function
    Public ReadOnly Property AppointmentList As DataTable
        Get
            Dim listAdapter As New PokemonDataSetTableAdapters.PokemonTableAdapter
            Return listAdapter.GetData()
        End Get
    End Property
    Public ReadOnly Property Items() As DataTable
        Get
            Return adapter.GetData()
        End Get
    End Property
    Public Function Update(ByVal pID As Integer,
                           ByVal pAbility As String,
                           ByVal pMove1 As String,
                           ByVal pMove2 As String,
                           ByVal pMove3 As String,
                           ByVal pMove4 As String) As Boolean
        'update a row into the appointments table.
        'return true if successful. if an exception is thrown last error will hold an error message.
        LastError = String.Empty
        Try
            adapter.Update(pAbility, pMove1, pMove2, pMove3, pMove4, pID)
            Return True
        Catch ex As Exception
            LastError = ex.Message
            Return False
        End Try
    End Function
    Public Function Delete(ByVal pID As Integer) As Boolean
        Dim rowsAffected As Integer = adapter.Delete(pID)
        Return rowsAffected > 0
    End Function
End Class
