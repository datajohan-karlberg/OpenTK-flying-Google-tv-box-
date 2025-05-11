Module Module1

    Public textures(10) As Integer

    Function jhsin(ByVal vinkel) As Double
        Dim pi As Double = 3.14159265358979
        Dim V As Double
        Dim XX As Double
        jhsin = 0
        V = vinkel - pi / 4

        If V > pi * 2 Then
            XX = Int(V / (pi * 2))
            V = V - (pi * 2) * XX
        End If

        If V < 0 Then
            XX = Int(Math.Abs(V) / (pi * 2)) + 1
            V = V + (pi * 2) * XX
        End If

        Select Case V
            '**********************************************************
            Case Is <= pi / 2

                jhsin = 1

                '**********************************************************
            Case Is <= pi

                jhsin = 2 - ((V - pi / 2) / pi * 2) * 2 - 1

                '**********************************************************
            Case Is <= (pi / 2 * 3)
                jhsin = -1


                '**********************************************************
            Case Is <= pi * 2

                jhsin = ((V - pi / 2 * 3) / pi * 2) * 2 - 1 - 0


                '**********************************************************
        End Select
        jhsin = (jhsin + Math.Sin(V)) / 2
    End Function

    Function jhcos(ByVal vinkel)
        Dim pi As Double = 3.14159265358979

        jhcos = jhsin(vinkel + pi / 2)


    End Function

End Module
