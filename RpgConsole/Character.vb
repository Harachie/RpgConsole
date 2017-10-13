Imports RpgConsole

Public Class Character

    Public Health As Double
    Public Attack As Double
    Public Name As String

    Friend Function Attacks(two As Character) As ArenaStep
        Dim r As New ArenaStep

        r.One = Me.Clone
        r.Two = two.Clone

        r.Two.Health -= r.One.Attack

        Return r
    End Function

    Public Function Clone() As Character
        Dim r As New Character

        r.Health = Me.Health
        r.Attack = Me.Attack
        r.Name = Me.Name

        Return r
    End Function

End Class
