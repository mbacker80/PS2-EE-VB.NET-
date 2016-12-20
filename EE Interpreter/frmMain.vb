Public Class frmMain

    Private mpAsm As MIPSAssembly, EE As EEProcessor

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mpAsm = New MIPSAssembly
        EE = New EEProcessor

        mpAsm.init()
        InitRAM()
        EE.Init(mpAsm)

        GC.Collect()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim rt As Integer, ret As String, ET As Stopwatch, ipc As Int64, ips As String
        Dim ipd As Double, slowest As Double, fastest As Double, i As Int32
        Dim ips2 As String

        slowest = -1
        fastest = -1
        For i = 1 To 100
            EE.Position = Val("&H00100000")
            ET = Stopwatch.StartNew
            rt = EE.Run1()
            ET.Stop()
            ipc = EE.PerfCount()
            ipd = ipc / (ET.Elapsed.TotalMilliseconds / 1000)
            If fastest = -1 Then fastest = ipd
            If slowest = -1 Then slowest = ipd
            If ipd > fastest Then fastest = ipd
            If ipd < slowest Then slowest = ipd
        Next

        ips = Math.Round(fastest, 2).ToString + " ips"
        If ipd > 999 Then ips = Math.Round(fastest / 1000, 2).ToString + " kips"
        If ipd > 999999 Then ips = Math.Round(fastest / 1000000, 2).ToString + " mips"
        If ipd > 999999999 Then ips = Math.Round(fastest / 1000000000, 2).ToString + " bips"

        ips2 = Math.Round(slowest, 2).ToString + " ips"
        If ipd > 999 Then ips2 = Math.Round(slowest / 1000, 2).ToString + " kips"
        If ipd > 999999 Then ips2 = Math.Round(slowest / 1000000, 2).ToString + " mips"
        If ipd > 999999999 Then ips2 = Math.Round(slowest / 1000000000, 2).ToString + " bips"

        ret = "Starting @00100000" + vbCrLf
        ret += "Ended @" + Strings.Right("00000000" + Hex(EE.Position), 8) + vbCrLf
        ret += "Fastest rate: " + ips + vbCrLf
        ret += "Slowest rate: " + ips2 + vbCrLf
        ret += "EE Returned: " + ErrRetString(rt)

        txtOut.Text = ret
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim rt As Integer, ret As String, ET As Stopwatch, ipc As Int64, ips As String
        Dim ipd As Double

        EE.Position = Val("&H00100000")
        ET = Stopwatch.StartNew
        rt = EE.Run1()
        ET.Stop()
        ipc = EE.PerfCount()
        ipd = ipc / (ET.Elapsed.TotalMilliseconds / 1000)

        ips = Math.Round(ipd, 2).ToString + " ips"
        If ipd > 999 Then ips = Math.Round(ipd / 1000, 2).ToString + " kips"
        If ipd > 999999 Then ips = Math.Round(ipd / 1000000, 2).ToString + " mips"
        If ipd > 999999999 Then ips = Math.Round(ipd / 1000000000, 2).ToString + " bips"

        ret = "Starting @00100000" + vbCrLf
        ret += "Ended @" + Strings.Right("00000000" + Hex(EE.Position), 8) + vbCrLf
        ret += "Execution time: " + Math.Round((ET.Elapsed.TotalMilliseconds / 1000), 4).ToString + " sec" + vbCrLf
        ret += "Execution rate: " + ips + vbCrLf
        ret += "EE Returned: " + ErrRetString(rt)

        txtOut.Text = ret + vbCrLf + EE.DumpGPRs
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim mData As UInt32

        EE.Exec1()

        mData = PSMemory(0).W(PatchMemAddress(EE.Position, 0) \ 4)

        txtOut.Text = Strings.Right("00000000" + Hex(EE.Position), 8) + vbCrLf +
                      mpAsm.DisassembleValue(mdata) + vbCrLf +
                      EE.DumpGPRs
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        EE.Position = Val("&H00100000")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim outp As UInt32, rt As Integer, ret As String

        txtOut.Text = (256 And 255).ToString

        Exit Sub
        rt = mpAsm.AssembleInstruction(txtIn.Text, outp)
        If rt < 0 Then
            txtOut.Text = "syntax error " + rt.ToString
        Else
            txtOut.Text = Strings.Right("00000000" + Hex(outp), 8) + vbCrLf +
                          mpAsm.DisassembleValue(outp)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim memAddr As Int32, RSpace As Int16, i As Int32, rc(10) As Int32
        Dim Lines() As String, sp() As String

        Lines = Split(txtIn.Text, vbCrLf)
        For i = 0 To Lines.Count - 1
            sp = Split(Lines(i), " ")
            memAddr = Val("&H" + sp(0))
            memAddr = PatchMemAddress(memAddr, RSpace) \ 4
            With PSMemory(RSpace)
                .W(memAddr) = CDec("&H" + sp(1))
                .IC(memAddr) = -1   ' mpAsm.FetchInstr(.W(memAddr))
                'mpAsm.FetchRegs(.W(memAddr), .IC(memAddr), .RC(memAddr).r)
            End With
        Next

        Exit Sub

        memAddr = Val("&H00100000")

        memAddr = PatchMemAddress(memAddr, RSpace) \ 4

        For i = memAddr To PSMemory(RSpace).W.Count - 1
            PSMemory(RSpace).W(i) = CDec("&H24840001")
            PSMemory(RSpace).IC(i) = -1 'mpAsm.FetchInstr(PSMemory(RSpace).W(i))
            'mpAsm.FetchRegs(PSMemory(RSpace).W(i), PSMemory(RSpace).IC(i), rc)
            'PSMemory(RSpace).r1(i) = rc(0)
            'PSMemory(RSpace).r2(i) = rc(1)
            'PSMemory(RSpace).r3(i) = rc(2)
        Next i

    End Sub
End Class
