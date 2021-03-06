﻿Public Class team
    'created adapter to work with database
    Private adapter As New PokemonDataSetTableAdapters.teamTableAdapter
    'get info method
    Public ReadOnly Property teamlist As DataTable
        Get
            Dim listAdapter As New PokemonDataSetTableAdapters.teamTableAdapter
            Return listAdapter.GetData()
        End Get
    End Property
    Public Shared Property LastError As String
    'insert method
    Public Function Insert(ByVal pID As Integer,
                           ByVal pName As String,
                           ByVal pTypeid As Integer,
                           ByVal pAbility As String,
                           ByVal pMove1 As String,
                           ByVal pMove2 As String,
                           ByVal pMove3 As String,
                           ByVal pMove4 As String) As Boolean
        'insert a new row into th eappointments talbe. return true if successful.
        'if an exception is thrown, last error will hold an error message.
        Try
            LastError = String.Empty
            adapter.Insert(pID, pName, pTypeid, pAbility, pMove1, pMove2, pMove3, pMove4)
            Return True
        Catch ex As Exception
            LastError = ex.Message
            Return False
        End Try
    End Function
    'get more info method
    Public ReadOnly Property Items() As DataTable
        Get
            Return adapter.GetData()
        End Get
    End Property
    'delete function
    Public Function Delete(ByVal pID As Integer) As Boolean
        Dim rowsAffected As Integer = adapter.Delete(pID)
        Return rowsAffected > 0
    End Function
    'function to delete team
    Public Sub deleteteam(ByVal ids As List(Of Integer))
        'loop through array using above delete method
        For Each id In ids
            Delete(id)
        Next

    End Sub
End Class
