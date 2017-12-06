Option Explicit On
Option Strict On
Public Class Type
    Private adapter As New PokemonDataSetTableAdapters.typingTableAdapter
    Public ReadOnly Property Items() As DataTable
        Get
            Dim table As DataTable = adapter.GetData()
            table.DefaultView.Sort = "typing"
            Return table
        End Get
    End Property
End Class
