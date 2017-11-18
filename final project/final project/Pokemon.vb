Option Strict On
Option Explicit On
Public Class Pokemon
    Public Property ID As Integer
    Public Property Name As String
    Public Property typing As String
    Public Property ability As String
    Public Property move1 As String
    Public Property move2 As String
    Public Property move3 As String
    Public Property move4 As String

    Public Sub New(ByVal pID As Integer,
                   ByVal pName As String,
                   ByVal pTyping As String,
                   ByVal pAbility As String,
                   ByVal pMove1 As String,
                   ByVal pMove2 As String,
                   ByVal pMove3 As String,
                   ByVal pMove4 As String)
        ID = pID
        Name = pName
        typing = pTyping
        ability = pAbility
        move1 = pMove1
        move2 = pMove2
        move3 = pMove3
        move4 = pMove4
    End Sub
End Class
