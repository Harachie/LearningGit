Module Program

    Sub Main()
        Dim wort As String
        Dim richtigGerateneBuchstaben As String

        wort = "Baum"
        richtigGerateneBuchstaben = "au"
    End Sub

    Sub ZeichneHangmanWort(wort As String, richtigGerateneBuchstaben As String)
        Dim wortAlsKleinbuchstaben As String
        Dim gerateneBuchstabenAlsKleinbuchstaben As String

        wortAlsKleinbuchstaben = wort.ToLower
        gerateneBuchstabenAlsKleinbuchstaben = richtigGerateneBuchstaben.ToLower

        For i As Integer = 0 To wort.Length - 1
            If gerateneBuchstabenAlsKleinbuchstaben.Contains(wortAlsKleinbuchstaben(i)) Then
                Console.Write(wort(i) & " ")
            Else
                Console.Write("_ ")
            End If
        Next
    End Sub

End Module
