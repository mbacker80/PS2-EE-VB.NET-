Public Module RAM
    Public PSMemory() As MemoryBlock

    Public Const EE_Space = 0
    Public Const KSEG0_Space = 1
    Public Const IOP_Space = 2

    Public Structure RegCache
        Dim r() As Int32
    End Structure
    Public Structure MemoryBlock
        Dim W() As UInt32
        Dim IC() As Int16
        Dim RC() As RegCache
    End Structure

    Public Sub InitRAM()
        Dim EE_Sz As Long, KSEG0_Sz As Long, IOP_Sz As Long
        Dim BitSize As Integer

        BitSize = 4 ' 32 bit words

        KSEG0_Sz = CDec("&H0007FFFF")
        EE_Sz = CDec("&H01F7FFFF")
        IOP_Sz = CDec("&H001FFFFF")


        ReDim PSMemory(2)

        '-------------------------------------------------- Initialize EE RAM
        ReDim PSMemory(EE_Space).W(((EE_Sz + 1) / BitSize) - 1)
        ReDim PSMemory(EE_Space).IC(((EE_Sz + 1) / 4) - 1)
        ReDim PSMemory(EE_Space).RC(((EE_Sz + 1) / 4) - 1)
        FlushMemory(EE_Space)
        FlushCache(EE_Space)

        '-------------------------------------------------- Initialize KSEG0 RAM
        ReDim PSMemory(KSEG0_Space).W(((KSEG0_Sz + 1) / BitSize) - 1)
        ReDim PSMemory(KSEG0_Space).IC(((KSEG0_Sz + 1) / 4) - 1)
        ReDim PSMemory(KSEG0_Space).RC(((KSEG0_Sz + 1) / 4) - 1)
        FlushMemory(KSEG0_Space)
        FlushCache(KSEG0_Space)

        '-------------------------------------------------- Initialize IOP RAM
        ReDim PSMemory(IOP_Space).W(((IOP_Sz + 1) / BitSize) - 1)
        ReDim PSMemory(IOP_Space).IC(((IOP_Sz + 1) / 4) - 1)
        ReDim PSMemory(IOP_Space).RC(((IOP_Sz + 1) / 4) - 1)
        FlushMemory(IOP_Space)
        FlushCache(IOP_Space)

    End Sub

    Public Sub FlushMemory(RAMSpace As Integer)
        Dim I As Int32
        For I = 0 To PSMemory(RAMSpace).IC.Count() - 1
            PSMemory(RAMSpace).W(I) = 0
        Next
    End Sub

    Public Sub FlushCache(RAMSpace As Integer)
        Dim I As Int32
        For I = 0 To PSMemory(RAMSpace).IC.Count() - 1
            PSMemory(RAMSpace).IC(I) = -1
            ReDim PSMemory(RAMSpace).RC(I).r(2)
            PSMemory(RAMSpace).RC(I).r(0) = 0
            PSMemory(RAMSpace).RC(I).r(1) = 0
            PSMemory(RAMSpace).RC(I).r(2) = 0
        Next
    End Sub




    '========================================================================== Address Checks
    Public Function IsAddrAlign(memAddr As Double, bitAlign As Byte) As Boolean
        If (memAddr And ((bitAlign / 8) - 1)) = 0 Then Return True
        Return False
    End Function

    Public Function RevertMemAddress(MemAddr As Int32, RAMSpace As Int16) As Int32
        Select Case RAMSpace
            Case EE_Space
                Return MemAddr + &H80000
            Case KSEG0_Space
                Return MemAddr + &H80000000
            Case IOP_Space
                Return MemAddr + &HBFC00000
        End Select
    End Function

    Public Function PatchMemIndex(mIndex As Int32, RamSpace As Int16) As Int32
        Select Case RamSpace
            Case EE_Space
                Return mIndex - &H80000
            Case KSEG0_Space
                Return mIndex
            Case IOP_Space
                Return mIndex
        End Select
    End Function

    Public Function PatchMemAddress(MemAddr As Int32, ByRef RAMSpace As Int16) As Int32

        'EE 0  = 00080000 - 01FFFFFF
        'EE 1  = 20080000 - 21FFFFFF (Mirror -> EE 0)
        'EE 2  = 30080000 - 31FFFFFF (Mirror -> EE 0)
        'KSEG0 = 80000000 - 8007FFFF
        'KSEG1 = A0000000 - A007FFFF (Mirror -> KSEG0)
        'IOP   = BFC00000 - BFDFFFFF

        If (MemAddr >= &H80000) And (MemAddr < &H2000000) Then
            RAMSpace = EE_Space
            Return MemAddr - &H80000
        End If
        If (MemAddr >= &H20080000) And (MemAddr < &H22000000) Then
            RAMSpace = EE_Space
            Return MemAddr - &H20080000
        End If
        If (MemAddr >= &H30080000) And (MemAddr < &H32000000) Then
            RAMSpace = EE_Space
            Return MemAddr - &H30080000
        End If

        If (MemAddr < &H80080000) And (MemAddr >= &H80000000) Then
            RAMSpace = KSEG0_Space
            Return MemAddr - &H80000000
        End If
        If (MemAddr < &HA0080000) And (MemAddr >= &HA0000000) Then
            RAMSpace = KSEG0_Space
            Return MemAddr - &HA0000000
        End If

        If (MemAddr < &HBFE00000) And (MemAddr >= &HBFC00000) Then
            RAMSpace = IOP_Space
            Return MemAddr - &HBFC00000
        End If

        RAMSpace = -1
        Return -1
    End Function

End Module
