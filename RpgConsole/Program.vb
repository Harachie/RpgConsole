Module Program

    Sub Main()
        Dim attackArena As New Arena
        Dim one As New Character With {.Attack = 100, .Health = 1000, .Name = "Eins"}
        Dim two As New Character With {.Attack = 50, .Health = 2000, .Name = "Zwei"}

        Dim result = attackArena.Fight(one, two)

        Dim oP As Double = GetPercentageAlwaysFirst(attackArena, one, two, 1000)
        Dim tP As Double = GetPercentageAlwaysFirst(attackArena, two, one, 1000)
    End Sub

    Public Function GetPercentageAlwaysFirst(a As Arena, one As Character, two As Character, rounds As Integer) As Double
        Dim r As Double
        Dim oWins, tWins As Integer
        Dim result As ArenaResult

        For i As Integer = 1 To rounds
            result = a.Fight(one, two)

            If Not result.IsTie Then
                If result.Winner.Name = one.Name Then
                    oWins += 1
                Else
                    tWins += 1
                End If
            End If
        Next

        Return oWins / rounds
    End Function

End Module
