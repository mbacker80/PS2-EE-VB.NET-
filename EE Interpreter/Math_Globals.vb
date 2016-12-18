
Module Math_Globals

    Public Function BinToDec(BIN As String) As Int64
        Dim I As Int64, Exp As Int64, TotOut As Int64

        Exp = CDec(0)
        TotOut = CDec(0)
        For I = 0 To Len(BIN) - 1

            If Mid(BIN, Len(BIN) - I, 1) = "1" Then
                TotOut = CDec(CDec(TotOut) + CDec((2 ^ CDec(Exp))))
            End If

            Exp = CDec(CDec(Exp) + 1)
        Next I

        BinToDec = CDec(TotOut)
    End Function

End Module
