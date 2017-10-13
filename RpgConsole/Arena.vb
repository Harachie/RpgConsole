Public Class Arena

    Public Function Fight(one As Character, two As Character) As ArenaResult
        Dim r As New ArenaResult
        Dim s As ArenaStep
        Dim o, t As Character

        o = one
        t = two

        Do
            s = o.Attacks(t)
            r.Steps.Add(s)

            If TrySelectWinner(s, r) Then
                Exit Do
            End If

            o = s.One
            t = s.Two
            s = t.Attacks(o)
            r.Steps.Add(s)

            If TrySelectWinner(s, r) Then
                Exit Do
            End If

            o = s.Two
            t = s.One
        Loop

        Return r
    End Function

    Public Function TrySelectWinner(s As ArenaStep, r As ArenaResult) As Boolean
        If s.One.Health <= 0.0 AndAlso s.Two.Health <= 0.0 Then
            r.Loser = s.One
            r.Winner = s.Two
            r.IsTie = True

            Return True
        End If

        If s.One.Health <= 0.0 Then
            r.Loser = s.One
            r.Winner = s.Two

            Return True
        End If

        If s.Two.Health <= 0.0 Then
            r.Loser = s.Two
            r.Winner = s.One

            Return True
        End If

        Return False
    End Function

End Class
