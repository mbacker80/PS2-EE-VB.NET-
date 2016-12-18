Module EE_Global_Functions

    Private Const NoError = 0
    Private Const UnknownInstruction = -1
    Private Const User_Break = -98
    Private Const NotImplementedYet = -99

    Private Const EXCEPTION_TLB_Modification = -2
    Private Const EXCEPTION_TLB_Load_InstFetch = -3
    Private Const EXCEPTION_TLB_Store = -4
    Private Const EXCEPTION_TLB_AddressLoad_InstFetch = -5
    Private Const EXCEPTION_TLB_AddressStore = -6
    Private Const EXCEPTION_TLB_BusError_Instr = -7
    Private Const EXCEPTION_TLB_BusError_Data = -8
    Private Const EXCEPTION_TLB_SysCall = -9
    Private Const EXCEPTION_TLB_BreakPoint = -10
    Private Const EXCEPTION_TLB_Reserved_Instr = -11
    Private Const EXCEPTION_TLB_CoprocesserUnusable = -12
    Private Const EXCEPTION_TLB_Overflow = -13
    Private Const EXCEPTION_TLB_Unknown = -14

    Public Function ErrRetString(ErrRet As Integer) As String
        Select Case ErrRet
            Case NoError
                Return "No Error."
            Case UnknownInstruction
                Return "Unknown Instruction"
            Case EXCEPTION_TLB_Modification
                Return "EXCEPTION: TLB Modification"
            Case EXCEPTION_TLB_Load_InstFetch
                Return "EXCEPTION: TLB Load Inst/Fetch"
            Case EXCEPTION_TLB_Store
                Return "EXCEPTION: TLB Store"
            Case EXCEPTION_TLB_AddressLoad_InstFetch
                Return "EXCEPTION: TLB Address Load Inst/Fetch"
            Case EXCEPTION_TLB_AddressStore
                Return "EXCEPTION: TLB Address Store"
            Case EXCEPTION_TLB_BusError_Instr
                Return "EXCEPTION: TLB Bus Error /Instr"
            Case EXCEPTION_TLB_BusError_Data
                Return "EXCEPTION: TLB Bus Error /Data"
            Case EXCEPTION_TLB_SysCall
                Return "EXCEPTION: Syscall"
            Case EXCEPTION_TLB_BreakPoint
                Return "EXCEPTION: Breakpoint"
            Case EXCEPTION_TLB_Reserved_Instr
                Return "EXCEPTION: Reserved Instruction"
            Case EXCEPTION_TLB_CoprocesserUnusable
                Return "EXCEPTION: Coprocessor Unusable"
            Case EXCEPTION_TLB_Overflow
                Return "EXCEPTION: Overflow"
            Case EXCEPTION_TLB_Unknown
                Return "EXCEPTION: Unknown"
            Case User_Break
                Return "Break set by user"
            Case NotImplementedYet
                Return "Instruction not implemented yet"
        End Select

        Return "Idk"
    End Function

    Public Function GetCACHEVarStr(VarIndex As Int64) As String
        Select Case VarIndex
            Case 0
                Return "ixltg"
            Case 1
                Return "ixldt"
            Case 2
                Return "bxlbt"
            Case 4
                Return "ixstg"
            Case 5
                Return "ixsdt"
            Case 6
                Return "bxsbt"
            Case 7
                Return "ixin"
            Case 10
                Return "bhinbt"
            Case 11
                Return "ihin"
            Case 12
                Return "bfh"
            Case 14
                Return "ifl"
            Case 16
                Return "dxltg"
            Case 17
                Return "dxldt"
            Case 18
                Return "dxstg"
            Case 19
                Return "dxsdt"
            Case 20
                Return "dxwbin"
            Case 22
                Return "dxin"
            Case 24
                Return "dhwbin"
            Case 26
                Return "dhinHit"
            Case 28
                Return "dhwoin"
            Case Else
                Return "$" + VarIndex.ToString
        End Select
    End Function

    Public Function GetCOP0RegStr(RegIndex As Int64) As String
        Select Case RegIndex
            Case 0
                Return "$index"
            Case 1
                Return "$random"
            Case 2
                Return "$entrylo0"
            Case 3
                Return "$entrylo1"
            Case 4
                Return "$context"
            Case 5
                Return "$pagemask"
            Case 6
                Return "$wired"
            Case 7
                Return "$7"
            Case 8
                Return "$badvaddr"
            Case 9
                Return "$count"
            Case 10
                Return "$entryhi"
            Case 11
                Return "$compare"
            Case 12
                Return "$status"
            Case 13
                Return "$cause"
            Case 14
                Return "$epc"
            Case 15
                Return "$prid"
            Case 16
                Return "$config"
            Case 17
                Return "$lladr"
            Case 18
                Return "$watchlo"
            Case 19
                Return "$watchhi"
            Case 20
                Return "$xcontext"
            Case 21
                Return "$21"
            Case 22
                Return "$22"
            Case 23
                Return "$badpaddr"
            Case 24
                Return "$debug"
            Case 25
                Return "$perf"
            Case 26
                Return "$ecc"
            Case 27
                Return "$cacheerr"
            Case 28
                Return "$taglo"
            Case 29
                Return "$taghi"
            Case 30
                Return "$errepc"
            Case 31
                Return "$31"
        End Select
    End Function

    Public Function GetCOP1RegStr(RegIndex As Int64) As String
        Return "$f" + RegIndex.ToString
    End Function

    Public Function GetEERegStr(RegIndex As Int64) As String
        Select Case RegIndex
            Case 0
                Return "zero"
            Case 1
                Return "at"
            Case 2
                Return "v0"
            Case 3
                Return "v1"
            Case 4
                Return "a0"
            Case 5
                Return "a1"
            Case 6
                Return "a2"
            Case 7
                Return "a3"
            Case 8
                Return "t0"
            Case 9
                Return "t1"
            Case 10
                Return "t2"
            Case 11
                Return "t3"
            Case 12
                Return "t4"
            Case 13
                Return "t5"
            Case 14
                Return "t6"
            Case 15
                Return "t7"
            Case 16
                Return "s0"
            Case 17
                Return "s1"
            Case 18
                Return "s2"
            Case 19
                Return "s3"
            Case 20
                Return "s4"
            Case 21
                Return "s5"
            Case 22
                Return "s6"
            Case 23
                Return "s7"
            Case 24
                Return "t8"
            Case 25
                Return "t9"
            Case 26
                Return "k0"
            Case 27
                Return "k1"
            Case 28
                Return "gp"
            Case 29
                Return "sp"
            Case 30
                Return "fp"
            Case 31
                Return "ra"
            Case Else
                Return "zero"
        End Select
    End Function

    Public Function GetCOP0RegVal(strReg As String) As Int64
        Select Case LCase(strReg)
            Case "$index"
                Return 0
            Case "$random"
                Return 1
            Case "$entrylo0"
                Return 2
            Case "$entrylo1"
                Return 3
            Case "$context"
                Return 4
            Case "$pagemask"
                Return 5
            Case "$wired"
                Return 6
            Case "$7"
                Return 7
            Case "$badvaddr"
                Return 8
            Case "$count"
                Return 9
            Case "$entryhi"
                Return 10
            Case "$compare"
                Return 11
            Case "$status"
                Return 12
            Case "$cause"
                Return 13
            Case "$epc"
                Return 14
            Case "$prid"
                Return 15
            Case "$config"
                Return 16
            Case "$lladr"
                Return 17
            Case "$watchlo"
                Return 18
            Case "$watchhi"
                Return 19
            Case "$xcontext"
                Return 20
            Case "$21"
                Return 21
            Case "$22"
                Return 22
            Case "$badpaddr"
                Return 23
            Case "$debug"
                Return 24
            Case "$perf"
                Return 25
            Case "$ecc"
                Return 26
            Case "$cacheerr"
                Return 27
            Case "$taglo"
                Return 28
            Case "$taghi"
                Return 29
            Case "$errepc"
                Return 30
            Case "$31"
                Return 31
            Case Else
                Return 0
        End Select
    End Function

    Public Function GetCOP1RegVal(strReg As String) As Int64
        Dim tReg As String

        tReg = LCase(strReg)
        tReg = Replace(tReg, "$", "")
        tReg = Replace(tReg, "f", "")

        Return CDec(tReg)
    End Function

    Public Function GetEERegVal(strReg As String) As Int64
        Select Case LCase(strReg)
            Case "zero"
                Return 0
            Case "0"
                Return 0
            Case "at"
                Return 1
            Case "v0"
                Return 2
            Case "v1"
                Return 3
            Case "a0"
                Return 4
            Case "a1"
                Return 5
            Case "a2"
                Return 6
            Case "a3"
                Return 7
            Case "t0"
                Return 8
            Case "t1"
                Return 9
            Case "t2"
                Return 10
            Case "t3"
                Return 11
            Case "t4"
                Return 12
            Case "t5"
                Return 13
            Case "t6"
                Return 14
            Case "t7"
                Return 15
            Case "s0"
                Return 16
            Case "s1"
                Return 17
            Case "s2"
                Return 18
            Case "s3"
                Return 19
            Case "s4"
                Return 20
            Case "s5"
                Return 21
            Case "s6"
                Return 22
            Case "s7"
                Return 23
            Case "t8"
                Return 24
            Case "t9"
                Return 25
            Case "k0"
                Return 26
            Case "k1"
                Return 27
            Case "gp"
                Return 28
            Case "sp"
                Return 29
            Case "fp"
                Return 30
            Case "ra"
                Return 31
            Case Else
                Return 0
        End Select
    End Function



End Module
