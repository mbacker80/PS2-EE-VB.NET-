Module MIPS_DATAFILE

    Public Function MIPS_File() As String
        Dim ret As String

        ret = ""
        ret = ret + "========================================" + vbCrLf
        ret = ret + "NOP : No Operation" + vbCrLf
        ret = ret + "00000000000000000000000000000000" + vbCrLf
        ret = ret + "11111111111111111111111111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "32:0" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "ADD : Add Word" + vbCrLf
        ret = ret + "ADD rd, rs, rt" + vbCrLf
        ret = ret + "00000000000000000000000000100000" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "6:ADD" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "ADDI : Add Immediate Word" + vbCrLf
        ret = ret + "ADDI rt, rs, immediate" + vbCrLf
        ret = ret + "00100000000000000000000000000000" + vbCrLf
        ret = ret + "11111100000000000000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "16:immediate" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "ADDIU : Add Immediate Unsigned Word" + vbCrLf
        ret = ret + "ADDIU rt, rs, immediate" + vbCrLf
        ret = ret + "00100100000000000000000000000000" + vbCrLf
        ret = ret + "11111100000000000000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:ADDIU" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "16:immediate" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "ADDU : Add Unsigned Word" + vbCrLf
        ret = ret + "ADDU rd, rs, rt" + vbCrLf
        ret = ret + "00000000000000000000000000100001" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "6:ADDU" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "AND : And" + vbCrLf
        ret = ret + "AND rd, rs, rt" + vbCrLf
        ret = ret + "00000000000000000000000000100100" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "6:AND" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "ANDI : Add Immediate" + vbCrLf
        ret = ret + "ANDI rt, rs, immediate" + vbCrLf
        ret = ret + "00110000000000000000000000000000" + vbCrLf
        ret = ret + "11111100000000000000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:ANDI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "16:immediate" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "BEQ : Branch on Equal" + vbCrLf
        ret = ret + "BEQ rs, rt, offset" + vbCrLf
        ret = ret + "00010000000000000000000000000000" + vbCrLf
        ret = ret + "11111100000000000000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:BEQ" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "16:offset" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "BEQL : Branch on Equal Likely" + vbCrLf
        ret = ret + "BEQL rs, rt, offset" + vbCrLf
        ret = ret + "01010000000000000000000000000000" + vbCrLf
        ret = ret + "11111100000000000000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:BEQL" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "16:offset" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "BGEZ : Branch on Greater Than or Equal to Zero" + vbCrLf
        ret = ret + "BGEZ rs, offset" + vbCrLf
        ret = ret + "00000100000000010000000000000000" + vbCrLf
        ret = ret + "11111100000111110000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:REGIMM" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:BGEZ" + vbCrLf
        ret = ret + "16:offset" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "BGEZAL : Branch on Greater Than or Equal to Zero and Link" + vbCrLf
        ret = ret + "BGEZAL rs, offset" + vbCrLf
        ret = ret + "00000100000100010000000000000000" + vbCrLf
        ret = ret + "11111100000111110000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:REGIMM" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:BGEZAL" + vbCrLf
        ret = ret + "16:offset" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "BGEZALL : Branch on Greater Than or Equal to Zero and Link Likely" + vbCrLf
        ret = ret + "BGEZALL rs, offset" + vbCrLf
        ret = ret + "00000100000100110000000000000000" + vbCrLf
        ret = ret + "11111100000111110000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:REGIMM" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:BGEZALL" + vbCrLf
        ret = ret + "16:offset" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "BGEZL : Branch on Greater Than or Equal to Zero Likely" + vbCrLf
        ret = ret + "BGEZL rs, offset" + vbCrLf
        ret = ret + "00000100000000110000000000000000" + vbCrLf
        ret = ret + "11111100000111110000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:REGIMM" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:BGEZL" + vbCrLf
        ret = ret + "16:offset" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "BGTZ : Branch on Greater Than Zero" + vbCrLf
        ret = ret + "BGTZ rs, offset" + vbCrLf
        ret = ret + "00011100000000000000000000000000" + vbCrLf
        ret = ret + "11111100000111110000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:BGTZ" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "16:offset" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "BGTZL : Branch on Greater Than Zero Likely" + vbCrLf
        ret = ret + "BGTZL rs, offset" + vbCrLf
        ret = ret + "01011100000000000000000000000000" + vbCrLf
        ret = ret + "11111100000111110000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:BGTZL" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "16:offset" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "BLEZ : Branch on Less Than or Equal to Zero" + vbCrLf
        ret = ret + "BLEZ rs, offset" + vbCrLf
        ret = ret + "00011000000000000000000000000000" + vbCrLf
        ret = ret + "11111100000111110000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:BLEZ" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "16:offset" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "BLEZL : Branch on Less Than or Equal to Zero Likely" + vbCrLf
        ret = ret + "BLEZL rs, offset" + vbCrLf
        ret = ret + "01011000000000000000000000000000" + vbCrLf
        ret = ret + "11111100000111110000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:BLEZL" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "16:offset" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "BLTZ : Branch on Less Than Zero" + vbCrLf
        ret = ret + "BLTZ rs, offset" + vbCrLf
        ret = ret + "00000100000000000000000000000000" + vbCrLf
        ret = ret + "11111100000111110000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:REGIMM" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:BLTZ" + vbCrLf
        ret = ret + "16:offset" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "BLTZAL : Branch on Less Than Zero and Link" + vbCrLf
        ret = ret + "BLTZAL rs, offset" + vbCrLf
        ret = ret + "00000100000100000000000000000000" + vbCrLf
        ret = ret + "11111100000111110000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:REGIMM" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:BLTZAL" + vbCrLf
        ret = ret + "16:offset" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "BLTZALL : Branch on Less Than Zero and Link Likely" + vbCrLf
        ret = ret + "BLTZALL rs, offset" + vbCrLf
        ret = ret + "00000100000100100000000000000000" + vbCrLf
        ret = ret + "11111100000111110000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:REGIMM" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:BLTZALL" + vbCrLf
        ret = ret + "16:offset" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "BLTZL : Branch on Less Than Zero Likely" + vbCrLf
        ret = ret + "BLTZL rs, offset" + vbCrLf
        ret = ret + "00000100000000100000000000000000" + vbCrLf
        ret = ret + "11111100000111110000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:REGIMM" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:BLTZL" + vbCrLf
        ret = ret + "16:offset" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "BNE : Branch on Not Equal" + vbCrLf
        ret = ret + "BNE rs, rt, offset" + vbCrLf
        ret = ret + "00010100000000000000000000000000" + vbCrLf
        ret = ret + "11111100000000000000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:BNE" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "16:offset" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "BNEL : Branch on Not Equal Likely" + vbCrLf
        ret = ret + "BNEL rs, rt, offset" + vbCrLf
        ret = ret + "01010100000000000000000000000000" + vbCrLf
        ret = ret + "11111100000000000000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:BNEL" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "16:offset" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "BREAK : Breakpoint" + vbCrLf
        ret = ret + "BREAK (code)" + vbCrLf
        ret = ret + "00000000000000000000000000001101" + vbCrLf
        ret = ret + "11111100000000000000000000111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "20:code" + vbCrLf
        ret = ret + "6:BREAK" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "DADD : int64word Add" + vbCrLf
        ret = ret + "DADD rd, rs, rt" + vbCrLf
        ret = ret + "00000000000000000000000000101100" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "6:DADD" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "DADDI : int64word Add Immediate" + vbCrLf
        ret = ret + "DADDI rt, rs, immediate" + vbCrLf
        ret = ret + "01100000000000000000000000000000" + vbCrLf
        ret = ret + "11111100000000000000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:DADDI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "16:immediate" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "DADDIU : int64word Add Immediate Unsigned" + vbCrLf
        ret = ret + "DADDIU rt, rs, immediate" + vbCrLf
        ret = ret + "01100100000000000000000000000000" + vbCrLf
        ret = ret + "11111100000000000000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:DADDIU" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "16:immediate" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "DADDU : int64word Add Unsigned" + vbCrLf
        ret = ret + "DADDU rd, rs, rt" + vbCrLf
        ret = ret + "00000000000000000000000000101101" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "6:DADDU" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "DIV : Divide Word" + vbCrLf
        ret = ret + "DIV rs, rt" + vbCrLf
        ret = ret + "00000000000000000000000000011010" + vbCrLf
        ret = ret + "11111100000000001111111111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "10:0" + vbCrLf
        ret = ret + "6:DIV" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "DIVU : Divide Unsigned Word" + vbCrLf
        ret = ret + "DIVU rs, rt" + vbCrLf
        ret = ret + "00000000000000000000000000011011" + vbCrLf
        ret = ret + "11111100000000001111111111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "10:0" + vbCrLf
        ret = ret + "6:DIVU" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "DSLL : int64word Shift Left Logical" + vbCrLf
        ret = ret + "DSLL rd, rt, sa" + vbCrLf
        ret = ret + "00000000000000000000000000111000" + vbCrLf
        ret = ret + "11111111111000000000000000111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:sa" + vbCrLf
        ret = ret + "6:DSLL" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "DSLL32 : int64word Shift Left Logical Plus 32" + vbCrLf
        ret = ret + "DSLL32 rd, rt, sa" + vbCrLf
        ret = ret + "00000000000000000000000000111100" + vbCrLf
        ret = ret + "11111111111000000000000000111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:sa" + vbCrLf
        ret = ret + "6:DSLL32" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "DSLLV : int64word Shift Left Logical Variable" + vbCrLf
        ret = ret + "DSLLV rd, rt, rs" + vbCrLf
        ret = ret + "00000000000000000000000000010100" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "6:DSLLV" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "DSRA : int64word Shift Right Arithmetic" + vbCrLf
        ret = ret + "DSRA rd, rt, sa" + vbCrLf
        ret = ret + "00000000000000000000000000111011" + vbCrLf
        ret = ret + "11111111111000000000000000111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:sa" + vbCrLf
        ret = ret + "6:DSRA" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "DSRA32 : int64word Shift Right Arithmetic Plus 32" + vbCrLf
        ret = ret + "DSRA32 rd, rt, sa" + vbCrLf
        ret = ret + "00000000000000000000000000111111" + vbCrLf
        ret = ret + "11111111111000000000000000111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:sa" + vbCrLf
        ret = ret + "6:DSRA32" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "DSRAV : int64word Shift Right Arithmetic Variable" + vbCrLf
        ret = ret + "DSRAV rd, rt, rs" + vbCrLf
        ret = ret + "00000000000000000000000000010111" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "6:DSRAV" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "DSRL : int64word Shift Right Logical" + vbCrLf
        ret = ret + "DSRL rd, rt, sa" + vbCrLf
        ret = ret + "00000000000000000000000000111010" + vbCrLf
        ret = ret + "11111111111000000000000000111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:sa" + vbCrLf
        ret = ret + "6:DSRL" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "DSRL32 : int64word Shift Right Logical Plus 32" + vbCrLf
        ret = ret + "DSRL32 rd, rt, sa" + vbCrLf
        ret = ret + "00000000000000000000000000111110" + vbCrLf
        ret = ret + "11111111111000000000000000111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:sa" + vbCrLf
        ret = ret + "6:DSRL32" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "DSRLV : int64word Shift Right Logical Variable" + vbCrLf
        ret = ret + "DSRLV rd, rt, rs" + vbCrLf
        ret = ret + "00000000000000000000000000010110" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "6:DSRLV" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "DSUB : int64word Subtract" + vbCrLf
        ret = ret + "DSUB rd, rs, rt" + vbCrLf
        ret = ret + "00000000000000000000000000101110" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "6:DSUB" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "DSUBU : int64word Subtract Unsigned" + vbCrLf
        ret = ret + "DSUBU rd, rs, rt" + vbCrLf
        ret = ret + "00000000000000000000000000101111" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "6:DSUBU" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "J : Jump" + vbCrLf
        ret = ret + "J target" + vbCrLf
        ret = ret + "00001000000000000000000000000000" + vbCrLf
        ret = ret + "11111100000000000000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:J" + vbCrLf
        ret = ret + "26:target" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "JAL : Jump and Link" + vbCrLf
        ret = ret + "JAL target" + vbCrLf
        ret = ret + "00001100000000000000000000000000" + vbCrLf
        ret = ret + "11111100000000000000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:JAL" + vbCrLf
        ret = ret + "26:target" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "JALR : Jump and Link Register" + vbCrLf
        ret = ret + "JALR rs" + vbCrLf
        ret = ret + "JALR rd, rs" + vbCrLf
        ret = ret + "00000000000000000000000000001001" + vbCrLf
        ret = ret + "11111100000111110000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "6:JALR" + vbCrLf
        ret = ret + "rd=31" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "JR : Jump Register" + vbCrLf
        ret = ret + "JR rs" + vbCrLf
        ret = ret + "00000000000000000000000000001000" + vbCrLf
        ret = ret + "11111100000111111111111111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "15:0" + vbCrLf
        ret = ret + "6:JR" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "LB : Load Byte" + vbCrLf
        ret = ret + "LB rt, offset(base)" + vbCrLf
        ret = ret + "10000000000000000000000000000000" + vbCrLf
        ret = ret + "11111100000000000000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:LB" + vbCrLf
        ret = ret + "5:base" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "16:offset" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "LBU : Load Byte Unsigned" + vbCrLf
        ret = ret + "LBU rt, offset(base)" + vbCrLf
        ret = ret + "10010000000000000000000000000000" + vbCrLf
        ret = ret + "11111100000000000000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:LBU" + vbCrLf
        ret = ret + "5:base" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "16:offset" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "LD : Load int64word" + vbCrLf
        ret = ret + "LD rt, offset(base)" + vbCrLf
        ret = ret + "11011100000000000000000000000000" + vbCrLf
        ret = ret + "11111100000000000000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:LD" + vbCrLf
        ret = ret + "5:base" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "16:offset" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "LDL : Load int64word Left" + vbCrLf
        ret = ret + "LDL rt, offset(base)" + vbCrLf
        ret = ret + "01101000000000000000000000000000" + vbCrLf
        ret = ret + "11111100000000000000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:LDL" + vbCrLf
        ret = ret + "5:base" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "16:offset" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "LDR : Load int64word Right" + vbCrLf
        ret = ret + "LDR rt, offset(base)" + vbCrLf
        ret = ret + "01101100000000000000000000000000" + vbCrLf
        ret = ret + "11111100000000000000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:LDR" + vbCrLf
        ret = ret + "5:base" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "16:offset" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "LH : Load Halfword" + vbCrLf
        ret = ret + "LH rt, offset(base)" + vbCrLf
        ret = ret + "10000100000000000000000000000000" + vbCrLf
        ret = ret + "11111100000000000000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:LH" + vbCrLf
        ret = ret + "5:base" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "16:offset" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "LHU : Load Halfword Unsigned" + vbCrLf
        ret = ret + "LHU rt, offset(base)" + vbCrLf
        ret = ret + "10010100000000000000000000000000" + vbCrLf
        ret = ret + "11111100000000000000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:LHU" + vbCrLf
        ret = ret + "5:base" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "16:offset" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "LUI : Load Upper Immediate" + vbCrLf
        ret = ret + "LUI rt, immediate" + vbCrLf
        ret = ret + "00111100000000000000000000000000" + vbCrLf
        ret = ret + "11111111111000000000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:LUI" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "16:immediate" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "LW : Load Word" + vbCrLf
        ret = ret + "LW rt, offset(base)" + vbCrLf
        ret = ret + "10001100000000000000000000000000" + vbCrLf
        ret = ret + "11111100000000000000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:LW" + vbCrLf
        ret = ret + "5:base" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "16:offset" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "LWL : Load Word Left" + vbCrLf
        ret = ret + "LWL rt, offset(base)" + vbCrLf
        ret = ret + "10001000000000000000000000000000" + vbCrLf
        ret = ret + "11111100000000000000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:LWL" + vbCrLf
        ret = ret + "5:base" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "16:offset" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "LWR : Load Word Right" + vbCrLf
        ret = ret + "LWR rt, offset(base)" + vbCrLf
        ret = ret + "10011000000000000000000000000000" + vbCrLf
        ret = ret + "11111100000000000000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:LWR" + vbCrLf
        ret = ret + "5:base" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "16:offset" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "LWU : Load Word Unsigned" + vbCrLf
        ret = ret + "LWU rt, offset(base)" + vbCrLf
        ret = ret + "10011100000000000000000000000000" + vbCrLf
        ret = ret + "11111100000000000000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:LWU" + vbCrLf
        ret = ret + "5:base" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "16:offset" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "MFHI : Move from HI Register" + vbCrLf
        ret = ret + "MFHI rd" + vbCrLf
        ret = ret + "00000000000000000000000000010000" + vbCrLf
        ret = ret + "11111111111111110000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "10:0" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "6:MFHI" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "MFLO : Move from LO Register" + vbCrLf
        ret = ret + "MFLO rd" + vbCrLf
        ret = ret + "00000000000000000000000000010010" + vbCrLf
        ret = ret + "11111111111111110000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "10:0" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "6:MFLO" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "MOVN : Move Conditional on Not Zero" + vbCrLf
        ret = ret + "MOVN rd, rs, rt" + vbCrLf
        ret = ret + "00000000000000000000000000001011" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "6:MOVN" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "MOVZ : Move Conditional on Zero" + vbCrLf
        ret = ret + "MOVZ rd, rs, rt" + vbCrLf
        ret = ret + "00000000000000000000000000001010" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "6:MOVZ" + vbCrLf

        ret = ret + MIPS_File_0()
        ret = ret + MIPS_File_1()
        ret = ret + MIPS_File_2()
        ret = ret + MIPS_File_3()


        MIPS_File = ret
    End Function

    Private Function MIPS_File_0() As String
        Dim ret As String

        ret = ""
        ret = ret + "========================================" + vbCrLf
        ret = ret + "MTHI : Move to HI Register" + vbCrLf
        ret = ret + "MTHI rs" + vbCrLf
        ret = ret + "00000000000000000000000000010001" + vbCrLf
        ret = ret + "11111100000111111111111111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "15:0" + vbCrLf
        ret = ret + "6:MTHI" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "MTLO : Move to LO Register" + vbCrLf
        ret = ret + "MTLO rs" + vbCrLf
        ret = ret + "00000000000000000000000000010011" + vbCrLf
        ret = ret + "11111100000111111111111111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "15:0" + vbCrLf
        ret = ret + "6:MTLO" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "MULT : Multiply Word" + vbCrLf
        ret = ret + "MULT rs, rt" + vbCrLf
        ret = ret + "00000000000000000000000000011000" + vbCrLf
        ret = ret + "11111100000000001111111111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "10:0" + vbCrLf
        ret = ret + "6:MULT" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "MULTU : Multiply Unsigned Word" + vbCrLf
        ret = ret + "MULTU rs, rt" + vbCrLf
        ret = ret + "00000000000000000000000000011001" + vbCrLf
        ret = ret + "11111100000000001111111111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "10:0" + vbCrLf
        ret = ret + "6:MULTU" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "NOR : Not Or" + vbCrLf
        ret = ret + "NOR rd, rs, rt" + vbCrLf
        ret = ret + "00000000000000000000000000100111" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "6:NOR" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "OR : Or" + vbCrLf
        ret = ret + "OR rd, rs, rt" + vbCrLf
        ret = ret + "00000000000000000000000000100101" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "6:OR" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "ORI : Or immediate" + vbCrLf
        ret = ret + "ORI rt, rs, immediate" + vbCrLf
        ret = ret + "00110100000000000000000000000000" + vbCrLf
        ret = ret + "11111100000000000000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:ORI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "16:immediate" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PREF : Prefetch" + vbCrLf
        ret = ret + "PREF hint, offset(base)" + vbCrLf
        ret = ret + "11001100000000000000000000000000" + vbCrLf
        ret = ret + "11111100000000000000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:PREF" + vbCrLf
        ret = ret + "5:base" + vbCrLf
        ret = ret + "5:hint" + vbCrLf
        ret = ret + "16:offset" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "SB : Store Byte" + vbCrLf
        ret = ret + "SB rt, offset(base)" + vbCrLf
        ret = ret + "10100000000000000000000000000000" + vbCrLf
        ret = ret + "11111100000000000000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SB" + vbCrLf
        ret = ret + "5:base" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "16:offset" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "SD : Store int64word" + vbCrLf
        ret = ret + "SD rt, offset(base)" + vbCrLf
        ret = ret + "11111100000000000000000000000000" + vbCrLf
        ret = ret + "11111100000000000000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SD" + vbCrLf
        ret = ret + "5:base" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "16:offset" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "SDL : Store int64word Left" + vbCrLf
        ret = ret + "SDL rt, offset(base)" + vbCrLf
        ret = ret + "10110000000000000000000000000000" + vbCrLf
        ret = ret + "11111100000000000000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SDL" + vbCrLf
        ret = ret + "5:base" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "16:offset" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "SDR : Store int64word Right" + vbCrLf
        ret = ret + "SDR rt, offset(base)" + vbCrLf
        ret = ret + "10110100000000000000000000000000" + vbCrLf
        ret = ret + "11111100000000000000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SDR" + vbCrLf
        ret = ret + "5:base" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "16:offset" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "SH : Store Halfword" + vbCrLf
        ret = ret + "SH rt, offset(base)" + vbCrLf
        ret = ret + "10100100000000000000000000000000" + vbCrLf
        ret = ret + "11111100000000000000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SH" + vbCrLf
        ret = ret + "5:base" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "16:offset" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "SLL : Shift Word Left Logical" + vbCrLf
        ret = ret + "SLL rd, rt, sa" + vbCrLf
        ret = ret + "00000000000000000000000000000000" + vbCrLf
        ret = ret + "11111111111000000000000000111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:sa" + vbCrLf
        ret = ret + "6:SLL" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "SLLV : Shift Word Left Logical Variable" + vbCrLf
        ret = ret + "SLLV rd, rt, rs" + vbCrLf
        ret = ret + "00000000000000000000000000000100" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "6:SLLV" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "SLT : Set on Less Than" + vbCrLf
        ret = ret + "SLT rd, rs, rt" + vbCrLf
        ret = ret + "00000000000000000000000000101010" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "6:SLT" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "SLTI : Set on Less Than Immediate" + vbCrLf
        ret = ret + "SLTI rt, rs, immediate" + vbCrLf
        ret = ret + "00101000000000000000000000000000" + vbCrLf
        ret = ret + "11111100000000000000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SLTI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "16:immediate" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "SLTIU : Set on Less Than Immediate Unsigned" + vbCrLf
        ret = ret + "SLTIU rt, rs, immediate" + vbCrLf
        ret = ret + "00101100000000000000000000000000" + vbCrLf
        ret = ret + "11111100000000000000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SLTIU" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "16:immediate" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "SLTU : Set on Less Than Unsigned" + vbCrLf
        ret = ret + "SLTU rd, rs, rt" + vbCrLf
        ret = ret + "00000000000000000000000000101011" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "6:SLTU" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "SRA : Shift Word Right Arithmetic" + vbCrLf
        ret = ret + "SRA rd, rt sa" + vbCrLf
        ret = ret + "00000000000000000000000000000011" + vbCrLf
        ret = ret + "11111111111000000000000000111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:sa" + vbCrLf
        ret = ret + "6:SRA" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "SRAV : Shift Word Right Arithmetic Variable" + vbCrLf
        ret = ret + "SRAV rd, rt, rs" + vbCrLf
        ret = ret + "00000000000000000000000000000111" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "6:SRAV" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "SRL : Shift Word Right Logical" + vbCrLf
        ret = ret + "SRL rd, rt, sa" + vbCrLf
        ret = ret + "00000000000000000000000000000010" + vbCrLf
        ret = ret + "11111111111000000000000000111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:sa" + vbCrLf
        ret = ret + "6:SRL" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "SRLV : Shift Word Right Logical Variable" + vbCrLf
        ret = ret + "SRLV rd, rt, rs" + vbCrLf
        ret = ret + "00000000000000000000000000000110" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "6:SRLV" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "SUB : Subtract Word" + vbCrLf
        ret = ret + "SUB rd, rs, rt" + vbCrLf
        ret = ret + "00000000000000000000000000100010" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "6:SUB" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "SUBU : Subtract Unsigned Word" + vbCrLf
        ret = ret + "SUBU rd, rs, rt" + vbCrLf
        ret = ret + "00000000000000000000000000100011" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "6:SUBU" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "SW : Store Word" + vbCrLf
        ret = ret + "SW rt, offset(base)" + vbCrLf
        ret = ret + "10101100000000000000000000000000" + vbCrLf
        ret = ret + "11111100000000000000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SW" + vbCrLf
        ret = ret + "5:base" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "16:offset" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "SWL : Store Word Left" + vbCrLf
        ret = ret + "SWL rt, offset(base)" + vbCrLf
        ret = ret + "10101000000000000000000000000000" + vbCrLf
        ret = ret + "11111100000000000000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SWL" + vbCrLf
        ret = ret + "5:base" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "16:offset" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "SWR : Store Word Right" + vbCrLf
        ret = ret + "SWR rt, offset(base)" + vbCrLf
        ret = ret + "10111000000000000000000000000000" + vbCrLf
        ret = ret + "11111100000000000000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SWR" + vbCrLf
        ret = ret + "5:base" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "16:offset" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "SYNC : Synchronize Shared Memory" + vbCrLf
        ret = ret + "00000000000000000000000000001111" + vbCrLf
        ret = ret + "11111111111111111111110000111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "15:0" + vbCrLf
        ret = ret + "5:stype" + vbCrLf
        ret = ret + "6:SYNC" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "SYNC.P : Synchronize Shared Memory" + vbCrLf
        ret = ret + "00000000000000000000010000001111" + vbCrLf
        ret = ret + "11111111111111111111110000111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "15:0" + vbCrLf
        ret = ret + "5:stype" + vbCrLf
        ret = ret + "6:SYNC" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "SYSCALL : System Call" + vbCrLf
        ret = ret + "SYSCALL (code)" + vbCrLf
        ret = ret + "00000000000000000000000000001100" + vbCrLf
        ret = ret + "11111100000000000000000000111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "20:code" + vbCrLf
        ret = ret + "6:SYSCALL" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "TEQ : Trap if Equal" + vbCrLf
        ret = ret + "TEQ rs, rt (code)" + vbCrLf
        ret = ret + "00000000000000000000000000110100" + vbCrLf
        ret = ret + "11111100000000000000000000111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "10:code" + vbCrLf
        ret = ret + "6:TEQ" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "TEQI : Trap if Equal Immediate" + vbCrLf
        ret = ret + "TEQI rs, immediate" + vbCrLf
        ret = ret + "00000100000011000000000000000000" + vbCrLf
        ret = ret + "11111100000111110000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:REGIMM" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:TEQI" + vbCrLf
        ret = ret + "16:immediate" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "TGE : Trap if Greater or Equal" + vbCrLf
        ret = ret + "TGE rs, rt (code)" + vbCrLf
        ret = ret + "00000000000000000000000000110000" + vbCrLf
        ret = ret + "11111100000000000000000000111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "10:code" + vbCrLf
        ret = ret + "6:TGE" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "TGEI : Trap if Greater or Equal Immediate" + vbCrLf
        ret = ret + "TGEI rs, immediate" + vbCrLf
        ret = ret + "00000100000010000000000000000000" + vbCrLf
        ret = ret + "11111100000111110000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:REGIMM" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:TGEI" + vbCrLf
        ret = ret + "16:immediate" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "TGEIU : Trap if Greater or Equal Immediate Unsigned" + vbCrLf
        ret = ret + "TGEIU rs, immediate" + vbCrLf
        ret = ret + "00000100000010010000000000000000" + vbCrLf
        ret = ret + "11111100000111110000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:REGIMM" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:TGEIU" + vbCrLf
        ret = ret + "16:immediate" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "TGEU : Trap if Greater or Equal Unsigned" + vbCrLf
        ret = ret + "TGEU rs, rt (code)" + vbCrLf
        ret = ret + "00000000000000000000000000110001" + vbCrLf
        ret = ret + "11111100000000000000000000111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "10:code" + vbCrLf
        ret = ret + "6:TGEU" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "TLT : Trap if Less Than" + vbCrLf
        ret = ret + "TLT rs, rt (code)" + vbCrLf
        ret = ret + "00000000000000000000000000110010" + vbCrLf
        ret = ret + "11111100000000000000000000111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "10:code" + vbCrLf
        ret = ret + "6:TLT" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "TLTI : Trap if Less Than Immediate" + vbCrLf
        ret = ret + "TLTI rs, immediate" + vbCrLf
        ret = ret + "00000100000010100000000000000000" + vbCrLf
        ret = ret + "11111100000111110000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:REGIMM" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:TLTI" + vbCrLf
        ret = ret + "16:immediate" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "TLTIU : Trap if Less Than Immediate Unsigned" + vbCrLf
        ret = ret + "TLTIU rs, immediate" + vbCrLf
        ret = ret + "00000100000010110000000000000000" + vbCrLf
        ret = ret + "11111100000111110000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:REGIMM" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:TLTIU" + vbCrLf
        ret = ret + "16:immediate" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "TLTU : Trap if Less Than Unsigned" + vbCrLf
        ret = ret + "TLTU rs, rt (code)" + vbCrLf
        ret = ret + "00000000000000000000000000110011" + vbCrLf
        ret = ret + "11111100000000000000000000111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "10:code" + vbCrLf
        ret = ret + "6:TLTU" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "TNE : Trap if Not Equal" + vbCrLf
        ret = ret + "TNE rs, rt (code)" + vbCrLf
        ret = ret + "00000000000000000000000000110110" + vbCrLf
        ret = ret + "11111100000000000000000000111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "10:code" + vbCrLf
        ret = ret + "6:TNE" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "TNEI : Trap if Not Equal Immediate" + vbCrLf
        ret = ret + "TNEI rs, immediate" + vbCrLf
        ret = ret + "00000100000011100000000000000000" + vbCrLf
        ret = ret + "11111100000111110000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:REGIMM" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:TNEI" + vbCrLf
        ret = ret + "16:immediate" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "XOR : Exclusive OR" + vbCrLf
        ret = ret + "XOR rd, rs, rt" + vbCrLf
        ret = ret + "00000000000000000000000000100110" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "6:XOR" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "XORI : Exclusive OR Immediate" + vbCrLf
        ret = ret + "XORI rt, rs, immediate" + vbCrLf
        ret = ret + "00111000000000000000000000000000" + vbCrLf
        ret = ret + "11111100000000000000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:XORI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "16:immediate" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "DIV1 : Divide Word Pipeline 1" + vbCrLf
        ret = ret + "DIV1 rs, rt" + vbCrLf
        ret = ret + "01110000000000000000000000011010" + vbCrLf
        ret = ret + "11111100000000001111111111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "10:0" + vbCrLf
        ret = ret + "6:DIV1" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "DIVU1 : Divide Unsigned Word Pipeline 1" + vbCrLf
        ret = ret + "DIVU1 rs, rt" + vbCrLf
        ret = ret + "01110000000000000000000000011011" + vbCrLf
        ret = ret + "11111100000000001111111111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "10:0" + vbCrLf
        ret = ret + "6:DIVU1" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "LQ : Load Quadword" + vbCrLf
        ret = ret + "LQ rt, offset(base)" + vbCrLf
        ret = ret + "01111000000000000000000000000000" + vbCrLf
        ret = ret + "11111100000000000000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:LQ" + vbCrLf
        ret = ret + "5:base" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "16:offset" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "MADD : Multiply-Add word" + vbCrLf
        ret = ret + "MADD rs, rt" + vbCrLf
        ret = ret + "MADD rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000000000000000" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "6:MADD" + vbCrLf
        ret = ret + "rd=0" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "MADD1 : Multiply-Add word Pipeline 1" + vbCrLf
        ret = ret + "MADD1 rs, rt" + vbCrLf
        ret = ret + "MADD1 rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000000000100000" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "6:MADD1" + vbCrLf
        ret = ret + "rd=0" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "MADDU : Multiply-Add Unsigned word" + vbCrLf
        ret = ret + "MADDU rs, rt" + vbCrLf
        ret = ret + "MADDU rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000000000000001" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "6:MADDU" + vbCrLf
        ret = ret + "rd=0" + vbCrLf

        MIPS_File_0 = ret
    End Function

    Private Function MIPS_File_1() As String
        Dim ret As String

        ret = ""
        ret = ret + "========================================" + vbCrLf
        ret = ret + "MADDU1 : Multiply-Add Unsigned word Pipeline 1" + vbCrLf
        ret = ret + "MADDU1 rs, rt" + vbCrLf
        ret = ret + "MADDU1 rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000000000100001" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "6:MADDU1" + vbCrLf
        ret = ret + "rd=0" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "MFHI1 : Move From HI1 Register" + vbCrLf
        ret = ret + "MFHI1 rd" + vbCrLf
        ret = ret + "01110000000000000000000000010000" + vbCrLf
        ret = ret + "11111111111111110000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "10:0" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "6:MFHI1" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "MFLO1 : Move From LO1 Register" + vbCrLf
        ret = ret + "MFLO1 rd" + vbCrLf
        ret = ret + "01110000000000000000000000010010" + vbCrLf
        ret = ret + "11111111111111110000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "10:0" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "6:MFLO1" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "MFSA : Move from Shift Amount Register" + vbCrLf
        ret = ret + "MFSA rd" + vbCrLf
        ret = ret + "00000000000000000000000000101000" + vbCrLf
        ret = ret + "11111111111111110000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "10:0" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "6:MFSA" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "MTHI1 : Move To HI1 Register" + vbCrLf
        ret = ret + "MTHI1 rs" + vbCrLf
        ret = ret + "01110000000000000000000000010001" + vbCrLf
        ret = ret + "11111100000111111111111111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "15:0" + vbCrLf
        ret = ret + "6:MTHI1" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "MTLO1 : Move To LO1 Register" + vbCrLf
        ret = ret + "MTLO1 rs" + vbCrLf
        ret = ret + "01110000000000000000000000010011" + vbCrLf
        ret = ret + "11111100000111111111111111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "15:0" + vbCrLf
        ret = ret + "6:MTLO1" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "MTSA : Move to Shift Amount Register" + vbCrLf
        ret = ret + "MTSA rs" + vbCrLf
        ret = ret + "00000000000000000000000000101001" + vbCrLf
        ret = ret + "11111100000111111111111111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "15:0" + vbCrLf
        ret = ret + "6:MTSA" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "MTSAB : Move Byte Count to Shift Amount Register" + vbCrLf
        ret = ret + "MTSAB rs, immediate" + vbCrLf
        ret = ret + "00000100000110000000000000000000" + vbCrLf
        ret = ret + "11111100000111110000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:REGIMM" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:11000" + vbCrLf
        ret = ret + "16:immediate" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "MTSAH : Move Halfword Count to Shift Amount Register" + vbCrLf
        ret = ret + "MTSAH rs, immediate" + vbCrLf
        ret = ret + "00000100000110010000000000000000" + vbCrLf
        ret = ret + "11111100000111110000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:REGIMM" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:11001" + vbCrLf
        ret = ret + "16:immediate" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "MULT : Multiply Word" + vbCrLf
        ret = ret + "MULT rs, rt" + vbCrLf
        ret = ret + "MULT rd, rs, rt" + vbCrLf
        ret = ret + "00000000000000000000000000011000" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "6:MULT" + vbCrLf
        ret = ret + "rd=0" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "MULT1 : Multiply Word Pipeline 1" + vbCrLf
        ret = ret + "MULT1 rs, rt" + vbCrLf
        ret = ret + "MULT1 rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000000000011000" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "6:MULT1" + vbCrLf
        ret = ret + "rd=0" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "MULTU : Multiply Unsigned Word" + vbCrLf
        ret = ret + "MULTU rs, rt" + vbCrLf
        ret = ret + "MULTU rd, rs, rt" + vbCrLf
        ret = ret + "00000000000000000000000000011001" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SPECIAL" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "6:MULTU" + vbCrLf
        ret = ret + "rd=0" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "MULTU1 : Multiply Unsigned Word Pipeline 1" + vbCrLf
        ret = ret + "MULTU1 rs, rt" + vbCrLf
        ret = ret + "MULTU1 rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000000000011001" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "6:MULTU1" + vbCrLf
        ret = ret + "rd=0" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PABSH : Parallel Absolute Halfword" + vbCrLf
        ret = ret + "PABSH rd, rt" + vbCrLf
        ret = ret + "01110000000000000000000101101000" + vbCrLf
        ret = ret + "11111111111000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PABSH" + vbCrLf
        ret = ret + "6:MMI1" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PABSW : Parallel Absolute Word" + vbCrLf
        ret = ret + "PABSW rd, rt" + vbCrLf
        ret = ret + "01110000000000000000000001101000" + vbCrLf
        ret = ret + "11111111111000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PABSW" + vbCrLf
        ret = ret + "6:MMI1" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PADDB : Parallel Add Byte" + vbCrLf
        ret = ret + "PADDB rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000001000001000" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PADDB" + vbCrLf
        ret = ret + "6:MMI0" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PADDH : Parallel Add Halfword" + vbCrLf
        ret = ret + "PADDH rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000000100001000" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PADDH" + vbCrLf
        ret = ret + "6:MMI0" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PADDSB : Parallel Add with Signed saturation Byte" + vbCrLf
        ret = ret + "PADDSB rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000011000001000" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PADDSB" + vbCrLf
        ret = ret + "6:MMI0" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PADDSH : Parallel Add with Signed saturation Halfword" + vbCrLf
        ret = ret + "PADDSH rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000010100001000" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PADDSH" + vbCrLf
        ret = ret + "6:MMI0" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PADDSW : Parallel Add with Signed saturation Word" + vbCrLf
        ret = ret + "PADDSW rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000010000001000" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PADDSW" + vbCrLf
        ret = ret + "6:MMI0" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PADDUB : Parallel Add with Unsigned saturation Byte" + vbCrLf
        ret = ret + "PADDUB rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000011000101000" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PADDUB" + vbCrLf
        ret = ret + "6:MMI1" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PADDUH : Parallel Add with Unsigned saturation Halfword" + vbCrLf
        ret = ret + "PADDUH rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000010100101000" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PADDUH" + vbCrLf
        ret = ret + "6:MMI1" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PADDUW : Parallel Add with Unsigned saturation Word" + vbCrLf
        ret = ret + "PADDUW rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000010000101000" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PADDUW" + vbCrLf
        ret = ret + "6:MMI1" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PADDW : Parallel Add Word" + vbCrLf
        ret = ret + "PADDW rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000000000001000" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PADDW" + vbCrLf
        ret = ret + "6:MMI0" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PADSBH : Parallel Add/Subtract Halfword" + vbCrLf
        ret = ret + "PADSBH rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000000100101000" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PADSBH" + vbCrLf
        ret = ret + "6:MMI1" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PAND : Parallel And" + vbCrLf
        ret = ret + "PAND rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000010010001001" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PAND" + vbCrLf
        ret = ret + "6:MMI2" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PCEQB : Parallel Compare for Equal Byte" + vbCrLf
        ret = ret + "PCEQB rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000001010101000" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PCEQB" + vbCrLf
        ret = ret + "6:MMI1" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PCEQH : Parallel Compare for Equal Halfword" + vbCrLf
        ret = ret + "PCEQH rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000000110101000" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PCEQH" + vbCrLf
        ret = ret + "6:MMI1" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PCEQW : Parallel Compare for Equal Word" + vbCrLf
        ret = ret + "PCEQW rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000000010101000" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PCEQW" + vbCrLf
        ret = ret + "6:MMI1" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PCGTB : Parallel Compare for Greater Than Byte" + vbCrLf
        ret = ret + "PCGTB rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000001010001000" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PCGTB" + vbCrLf
        ret = ret + "6:MMI0" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PCGTH : Parallel Compare for Greater Than Halfword" + vbCrLf
        ret = ret + "PCGTH rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000000110001000" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PCGTH" + vbCrLf
        ret = ret + "6:MMI0" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PCGTW : Parallel Compare for Greater Than Word" + vbCrLf
        ret = ret + "PCGTW rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000000010001000" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PCGTW" + vbCrLf
        ret = ret + "6:MMI0" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PCPYH : Parallel Copy Halfword" + vbCrLf
        ret = ret + "PCPYH rd, rt" + vbCrLf
        ret = ret + "01110000000000000000011011101001" + vbCrLf
        ret = ret + "11111111111000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PCPYH" + vbCrLf
        ret = ret + "6:MMI3" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PCPYLD : Parallel Copy Lower int64word" + vbCrLf
        ret = ret + "PCPYLD rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000001110001001" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PCPYLD" + vbCrLf
        ret = ret + "6:MMI2" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PCPYUD : Parallel Copy Upper int64word" + vbCrLf
        ret = ret + "PCPYUD rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000001110101001" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PCPYUD" + vbCrLf
        ret = ret + "6:MMI3" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PDIVBW : Parallel Divide Broadcast Word" + vbCrLf
        ret = ret + "PDIVBW rs, rt" + vbCrLf
        ret = ret + "01110000000000000000011101001001" + vbCrLf
        ret = ret + "11111100000000001111111111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "5:PDIVBW" + vbCrLf
        ret = ret + "6:MMI2" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PDIVUW : Parallel Divide Unsigned Word" + vbCrLf
        ret = ret + "PDIVUW rs, rt" + vbCrLf
        ret = ret + "01110000000000000000001101101001" + vbCrLf
        ret = ret + "11111100000000001111111111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "5:PDIVUW" + vbCrLf
        ret = ret + "6:MMI3" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PDIVW : Parallel Divide Word" + vbCrLf
        ret = ret + "PDIVW rs, rt" + vbCrLf
        ret = ret + "01110000000000000000001101001001" + vbCrLf
        ret = ret + "11111100000000001111111111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "5:PDIVW" + vbCrLf
        ret = ret + "6:MMI2" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PEXCH : Parallel Exchange Center Halfword" + vbCrLf
        ret = ret + "PEXCH rd, rt" + vbCrLf
        ret = ret + "01110000000000000000011010101001" + vbCrLf
        ret = ret + "11111111111000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PEXCH" + vbCrLf
        ret = ret + "6:MMI3" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PEXCW : Parallel Exchange Center Word" + vbCrLf
        ret = ret + "PEXCW rd, rt" + vbCrLf
        ret = ret + "01110000000000000000011110101001" + vbCrLf
        ret = ret + "11111111111000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PEXCW" + vbCrLf
        ret = ret + "6:MMI3" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PEXEH : Parallel Exchange Even Halfword" + vbCrLf
        ret = ret + "PEXEH rd, rt" + vbCrLf
        ret = ret + "01110000000000000000011010001001" + vbCrLf
        ret = ret + "11111111111000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PEXEH" + vbCrLf
        ret = ret + "6:MMI2" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PEXEW : Parallel Exchange Even Word" + vbCrLf
        ret = ret + "PEXEW rd, rt" + vbCrLf
        ret = ret + "01110000000000000000011110001001" + vbCrLf
        ret = ret + "11111111111000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PEXEW" + vbCrLf
        ret = ret + "6:MMI2" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PEXT5 : Parallel Extend from 5 bits" + vbCrLf
        ret = ret + "PEXT5 rd, rt" + vbCrLf
        ret = ret + "01110000000000000000011110001000" + vbCrLf
        ret = ret + "11111111111000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PEXT5" + vbCrLf
        ret = ret + "6:MMI0" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PEXTLB : Parallel Extend Lower from Byte" + vbCrLf
        ret = ret + "PEXTLB rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000011010001000" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PEXTLB" + vbCrLf
        ret = ret + "6:MMI0" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PEXTLH : Parallel Extend Lower from Halfword" + vbCrLf
        ret = ret + "PEXTLH rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000010110001000" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PEXTLH" + vbCrLf
        ret = ret + "6:MMI0" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PEXTLW : Parallel Extend Lower from Word" + vbCrLf
        ret = ret + "PEXTLW rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000010010001000" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PEXTLW" + vbCrLf
        ret = ret + "6:MMI0" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PEXTUB : Parallel Extend Upper from Byte" + vbCrLf
        ret = ret + "PEXTUB rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000011010101000" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PEXTUB" + vbCrLf
        ret = ret + "6:MMI1" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PEXTUH : Parallel Extend Upper from Halfword" + vbCrLf
        ret = ret + "PEXTUH rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000010110101000" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PEXTUH" + vbCrLf
        ret = ret + "6:MMI1" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PEXTUW : Parallel Extend Upper from Word" + vbCrLf
        ret = ret + "PEXTUW rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000010010101000" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PEXTUW" + vbCrLf
        ret = ret + "6:MMI1" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PHMADH : Parallel Horizontal Multiply-Add Halfword" + vbCrLf
        ret = ret + "PHMADH rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000010001001001" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PHMADH" + vbCrLf
        ret = ret + "6:MMI2" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PHMSBH : Parallel Horizontal Multiply-Subtract Halfword" + vbCrLf
        ret = ret + "PHMSBH rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000010101001001" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PHMSBH" + vbCrLf
        ret = ret + "6:MMI2" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PINTEH : Parallel Interleave Even Halfword" + vbCrLf
        ret = ret + "PINTEH rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000001010101001" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PINTEH" + vbCrLf
        ret = ret + "6:MMI3" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PINTH : Parallel Interleave Halfword" + vbCrLf
        ret = ret + "PINTH rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000001010001001" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PINTH" + vbCrLf
        ret = ret + "6:MMI2" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PLZCW : Parallel Leading Zero or one Count Word" + vbCrLf
        ret = ret + "PLZCW rd, rs" + vbCrLf
        ret = ret + "01110000000000000000000000000100" + vbCrLf
        ret = ret + "11111100000111110000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "6:PLZCW" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PMADDH : Parallel Multiply-Add Halfword" + vbCrLf
        ret = ret + "PMADDH rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000010000001001" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PMADDH" + vbCrLf
        ret = ret + "6:MMI2" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PMADDUW : Parallel Multiply-Add Unsigned Word" + vbCrLf
        ret = ret + "PMADDUW rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000000000101001" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PMADDUW" + vbCrLf
        ret = ret + "6:MMI3" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PMADDW : Parallel Multiply-Add Word" + vbCrLf
        ret = ret + "PMADDW rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000000000001001" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PMADDW" + vbCrLf
        ret = ret + "6:MMI2" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PMAXH : Parallel Maximize Halfword" + vbCrLf
        ret = ret + "PMAXH rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000000111001000" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PMAXH" + vbCrLf
        ret = ret + "6:MMI0" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PMAXW : Parallel Maximize Word" + vbCrLf
        ret = ret + "PMAXW rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000000011001000" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PMAXW" + vbCrLf
        ret = ret + "6:MMI0" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PMFHI : Parallel Move From HI Register" + vbCrLf
        ret = ret + "PMFHI rd" + vbCrLf
        ret = ret + "01110000000000000000001000001001" + vbCrLf
        ret = ret + "11111111111111110000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "10:0" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PMFHI" + vbCrLf
        ret = ret + "6:MMI2" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PMFHL.LH : Parallel Move From HI/LO Register" + vbCrLf
        ret = ret + "PMFHL.LH rd" + vbCrLf
        ret = ret + "01110000000000000000000011110000" + vbCrLf
        ret = ret + "11111111111111110000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "10:0" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:fmt" + vbCrLf
        ret = ret + "6:PMFHL" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PMFHL.LW : Parallel Move From HI/LO Register" + vbCrLf
        ret = ret + "PMFHL.LW rd" + vbCrLf
        ret = ret + "01110000000000000000000000110000" + vbCrLf
        ret = ret + "11111111111111110000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "10:0" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:fmt" + vbCrLf
        ret = ret + "6:PMFHL" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PMFHL.SH : Parallel Move From HI/LO Register" + vbCrLf
        ret = ret + "PMFHL.SH rd" + vbCrLf
        ret = ret + "01110000000000000000000100110000" + vbCrLf
        ret = ret + "11111111111111110000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "10:0" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:fmt" + vbCrLf
        ret = ret + "6:PMFHL" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PMFHL.SLW : Parallel Move From HI/LO Register" + vbCrLf
        ret = ret + "PMFHL.SLW rd" + vbCrLf
        ret = ret + "01110000000000000000000010110000" + vbCrLf
        ret = ret + "11111111111111110000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "10:0" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:fmt" + vbCrLf
        ret = ret + "6:PMFHL" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PMFHL.UW : Parallel Move From HI/LO Register" + vbCrLf
        ret = ret + "PMFHL.UW rd" + vbCrLf
        ret = ret + "01110000000000000000000001110000" + vbCrLf
        ret = ret + "11111111111111110000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "10:0" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:fmt" + vbCrLf
        ret = ret + "6:PMFHL" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PMFLO : Parallel Move From LO Register" + vbCrLf
        ret = ret + "PMFLO rd" + vbCrLf
        ret = ret + "01110000000000000000001001001001" + vbCrLf
        ret = ret + "11111111111111110000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "10:0" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PMFLO" + vbCrLf
        ret = ret + "6:MMI2" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PMINH : Parallel Minimize Halfword" + vbCrLf
        ret = ret + "PMINH rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000000111101000" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PMINH" + vbCrLf
        ret = ret + "6:MMI1" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PMINW : Parallel Minimize Word" + vbCrLf
        ret = ret + "PMINW rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000000011101000" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PMINW" + vbCrLf
        ret = ret + "6:MMI1" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PMSUBH : Parallel Multiply-Subtract Halfword" + vbCrLf
        ret = ret + "PMSUBH rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000010100001001" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PMSUBH" + vbCrLf
        ret = ret + "6:MMI2" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PMSUBW : Parallel Multiply-Subtract Word" + vbCrLf
        ret = ret + "PMSUBW rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000000100001001" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PMSUBW" + vbCrLf
        ret = ret + "6:MMI2" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PMTHI : Parallel Move To HI Register" + vbCrLf
        ret = ret + "PMTHI rs" + vbCrLf
        ret = ret + "01110000000000000000001000101001" + vbCrLf
        ret = ret + "11111100000111111111111111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "10:0" + vbCrLf
        ret = ret + "5:PMTHI" + vbCrLf
        ret = ret + "6:MMI3" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PMTHL.LW : Parallel Move To HI/LO Register" + vbCrLf
        ret = ret + "PMTHL.LW rs" + vbCrLf
        ret = ret + "01110000000000000000000000110001" + vbCrLf
        ret = ret + "11111100000111111111111111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "10:0" + vbCrLf
        ret = ret + "5:fmt" + vbCrLf
        ret = ret + "6:PMTHL" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PMTLO : Parallel Move To LO Register" + vbCrLf
        ret = ret + "PMTLO rs" + vbCrLf
        ret = ret + "01110000000000000000001001101001" + vbCrLf
        ret = ret + "11111100000111111111111111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "10:0" + vbCrLf
        ret = ret + "5:PMTLO" + vbCrLf
        ret = ret + "6:MMI3" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PMULTH : Parallel Multiply Halfword" + vbCrLf
        ret = ret + "PMULTH rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000011100001001" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PMULTH" + vbCrLf
        ret = ret + "6:MMI2" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PMULTUW : Parallel Multiply Unsigned Word" + vbCrLf
        ret = ret + "PMULTUW rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000001100101001" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PMULTUW" + vbCrLf
        ret = ret + "6:MMI3" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PMULTW : Parallel Multiply Word" + vbCrLf
        ret = ret + "PMULTW rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000001100001001" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PMULTW" + vbCrLf
        ret = ret + "6:MMI2" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PNOR : Parallel Not Or" + vbCrLf
        ret = ret + "PNOR rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000010011101001" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PNOR" + vbCrLf
        ret = ret + "6:MMI3" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "POR : Parallel Or" + vbCrLf
        ret = ret + "POR rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000010010101001" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:POR" + vbCrLf
        ret = ret + "6:MMI3" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PPAC5 : Parallel Pack to 5 bits" + vbCrLf
        ret = ret + "PPAC5 rd, rt" + vbCrLf
        ret = ret + "01110000000000000000011111001000" + vbCrLf
        ret = ret + "11111111111000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PPAC5" + vbCrLf
        ret = ret + "6:MMI0" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PPACB : Parallel Pack to Byte" + vbCrLf
        ret = ret + "PPACB rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000011011001000" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PPACB" + vbCrLf
        ret = ret + "6:MMI0" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PPACH : Parallel Pack to Halfword" + vbCrLf
        ret = ret + "PPACH rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000010111001000" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PPACH" + vbCrLf
        ret = ret + "6:MMI0" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PPACW : Parallel Pack to Word" + vbCrLf
        ret = ret + "PPACW rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000010011001000" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PPACW" + vbCrLf
        ret = ret + "6:MMI0" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PREVH : Parallel Reverse Halfword" + vbCrLf
        ret = ret + "PREVH rd, rt" + vbCrLf
        ret = ret + "01110000000000000000011011001001" + vbCrLf
        ret = ret + "11111111111000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PREVH" + vbCrLf
        ret = ret + "6:MMI2" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PROT3W : Parallel Rotate 3 Words Left" + vbCrLf
        ret = ret + "PROT3W rd, rt" + vbCrLf
        ret = ret + "01110000000000000000011111001001" + vbCrLf
        ret = ret + "11111111111000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PROT3W" + vbCrLf
        ret = ret + "6:MMI2" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PSLLH : Parallel Shift Left Logical Halfword" + vbCrLf
        ret = ret + "PSLLH rd, rt, sa" + vbCrLf
        ret = ret + "01110000000000000000000000110100" + vbCrLf
        ret = ret + "11111111111000000000000000111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:sa" + vbCrLf
        ret = ret + "6:PSLLH" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PSLLVW : Parallel Shift Left Logical Variable Word" + vbCrLf
        ret = ret + "PSLLVW rd, rt, rs" + vbCrLf
        ret = ret + "01110000000000000000000010001001" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PSLLVW" + vbCrLf
        ret = ret + "6:MMI2" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PSLLW : Parallel Shift Left Logical Word" + vbCrLf
        ret = ret + "PSLLW rd, rt, sa" + vbCrLf
        ret = ret + "01110000000000000000000000111100" + vbCrLf
        ret = ret + "11111111111000000000000000111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:sa" + vbCrLf
        ret = ret + "6:PSLLW" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PSRAH : Parallel Shift Right Arithmetic Halfword" + vbCrLf
        ret = ret + "PSRAH rd, rt, sa" + vbCrLf
        ret = ret + "01110000000000000000000000110111" + vbCrLf
        ret = ret + "11111111111000000000000000111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:sa" + vbCrLf
        ret = ret + "6:PSRAH" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PSRAVW : Parallel Shift Right Arithmetic Variable Word" + vbCrLf
        ret = ret + "PSRAVW rd, rt, rs" + vbCrLf
        ret = ret + "01110000000000000000000011101001" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PSRAVW" + vbCrLf
        ret = ret + "6:MMI3" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PSRAW : Parallel Shift Right Arithmetic Word" + vbCrLf
        ret = ret + "PSRAW rd, rt, sa" + vbCrLf
        ret = ret + "01110000000000000000000000111111" + vbCrLf
        ret = ret + "11111111111000000000000000111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:sa" + vbCrLf
        ret = ret + "6:PSRAW" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PSRLH : Parallel Shift Right Logical Halfword" + vbCrLf
        ret = ret + "PSRLH rd, rt, sa" + vbCrLf
        ret = ret + "01110000000000000000000000110110" + vbCrLf
        ret = ret + "11111111111000000000000000111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:sa" + vbCrLf
        ret = ret + "6:PSRLH" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PSRLVW : Parallel Shift Right Logical Variable Word" + vbCrLf
        ret = ret + "PSRLVW rd, rt, rs" + vbCrLf
        ret = ret + "01110000000000000000000011001001" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PSRLVW" + vbCrLf
        ret = ret + "6:MMI2" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PSRLW : Parallel Shift Right Logical Word" + vbCrLf
        ret = ret + "PSRLW rd, rt, sa" + vbCrLf
        ret = ret + "01110000000000000000000000111110" + vbCrLf
        ret = ret + "11111111111000000000000000111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:sa" + vbCrLf
        ret = ret + "6:PSRLW" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PSUBB : Parallel Subtract Byte" + vbCrLf
        ret = ret + "PSUBB rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000001001001000" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PSUBB" + vbCrLf
        ret = ret + "6:MMI0" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PSUBH : Parallel Subtract Halfword" + vbCrLf
        ret = ret + "PSUBH rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000000101001000" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PSUBH" + vbCrLf
        ret = ret + "6:MMI0" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PSUBSB : Parallel Subtract with Signed saturation Byte" + vbCrLf
        ret = ret + "PSUBSB rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000011001001000" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PSUBSB" + vbCrLf
        ret = ret + "6:MMI0" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PSUBSH : Parallel Subtract with Signed Saturation Halfword" + vbCrLf
        ret = ret + "PSUBSH rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000010101001000" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PSUBSH" + vbCrLf
        ret = ret + "6:MMI0" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PSUBSW : Parallel Subtract with Signed Saturation Word" + vbCrLf
        ret = ret + "PSUBSW rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000010001001000" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PSUBSW" + vbCrLf
        ret = ret + "6:MMI0" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PSUBUB : Parallel Subtract with Unsigned Saturation Byte" + vbCrLf
        ret = ret + "PSUBUB rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000011001101000" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PSUBUB" + vbCrLf
        ret = ret + "6:MMI1" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PSUBUH : Parallel Subtract with Unsigned Saturation Halfword" + vbCrLf
        ret = ret + "PSUBUH rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000010101101000" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PSUBUH" + vbCrLf
        ret = ret + "6:MMI1" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PSUBUW : Parallel Subtract with Unsigned Saturation Word" + vbCrLf
        ret = ret + "PSUBUW rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000010001101000" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PSUBUW" + vbCrLf
        ret = ret + "6:MMI1" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PSUBW : Parallel Subtract Word" + vbCrLf
        ret = ret + "PSUBW rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000000001001000" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PSUBW" + vbCrLf
        ret = ret + "6:MMI0" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "PXOR : Parallel Exclusive OR" + vbCrLf
        ret = ret + "PXOR rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000010011001001" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:PXOR" + vbCrLf
        ret = ret + "6:MMI2" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "QFSRV : Quadword Funnel Shift Right Variable" + vbCrLf
        ret = ret + "QFSRV rd, rs, rt" + vbCrLf
        ret = ret + "01110000000000000000011011101000" + vbCrLf
        ret = ret + "11111100000000000000011111111111" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:MMI" + vbCrLf
        ret = ret + "5:rs" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:rd" + vbCrLf
        ret = ret + "5:QFSRV" + vbCrLf
        ret = ret + "6:MMI1" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "SQ : Store Quadword" + vbCrLf
        ret = ret + "SQ rt, offset(base)" + vbCrLf
        ret = ret + "01111100000000000000000000000000" + vbCrLf
        ret = ret + "11111100000000000000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:SQ" + vbCrLf
        ret = ret + "5:base" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "16:offset" + vbCrLf

        MIPS_File_1 = ret
    End Function

    Private Function MIPS_File_2() As String
        Dim ret As String

        ret = ""
        ret = ret + "========================================" + vbCrLf
        ret = ret + "BC0F : Branch on Coprocessor 0 False" + vbCrLf
        ret = ret + "BC0F offset" + vbCrLf
        ret = ret + "01000001000000000000000000000000" + vbCrLf
        ret = ret + "11111111111111110000000000000000" + vbCrLf
        ret = ret + "COP0" + vbCrLf
        ret = ret + "6:COP0" + vbCrLf
        ret = ret + "5:BC0" + vbCrLf
        ret = ret + "5:BC0F" + vbCrLf
        ret = ret + "16:offset" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "BC0FL : Branch on Coprocessor 0 False Likely" + vbCrLf
        ret = ret + "BC0FL offset" + vbCrLf
        ret = ret + "01000001000000100000000000000000" + vbCrLf
        ret = ret + "11111111111111110000000000000000" + vbCrLf
        ret = ret + "COP0" + vbCrLf
        ret = ret + "6:COP0" + vbCrLf
        ret = ret + "5:BC0" + vbCrLf
        ret = ret + "5:BC0FL" + vbCrLf
        ret = ret + "16:offset" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "BC0T : Branch on Coprocessor 0 True" + vbCrLf
        ret = ret + "BC0T offset" + vbCrLf
        ret = ret + "01000001000000010000000000000000" + vbCrLf
        ret = ret + "11111111111111110000000000000000" + vbCrLf
        ret = ret + "COP0" + vbCrLf
        ret = ret + "6:COP0" + vbCrLf
        ret = ret + "5:BC0" + vbCrLf
        ret = ret + "5:BC0T" + vbCrLf
        ret = ret + "16:offset" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "BC0TL : Branch on Coprocessor 0 True Likely" + vbCrLf
        ret = ret + "BC0TL offset" + vbCrLf
        ret = ret + "01000001000000110000000000000000" + vbCrLf
        ret = ret + "11111111111111110000000000000000" + vbCrLf
        ret = ret + "COP0" + vbCrLf
        ret = ret + "6:COP0" + vbCrLf
        ret = ret + "5:BC0" + vbCrLf
        ret = ret + "5:BC0TL" + vbCrLf
        ret = ret + "16:offset" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "DI : Disable Interrupt" + vbCrLf
        ret = ret + "DI" + vbCrLf
        ret = ret + "01000010000000000000000000111001" + vbCrLf
        ret = ret + "11111111111111111111111111111111" + vbCrLf
        ret = ret + "COP0" + vbCrLf
        ret = ret + "6:COP0" + vbCrLf
        ret = ret + "5:CO" + vbCrLf
        ret = ret + "15:0" + vbCrLf
        ret = ret + "6:DI" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "EI : Enable Interrupt" + vbCrLf
        ret = ret + "EI" + vbCrLf
        ret = ret + "01000010000000000000000000111000" + vbCrLf
        ret = ret + "11111111111111111111111111111111" + vbCrLf
        ret = ret + "COP0" + vbCrLf
        ret = ret + "6:COP0" + vbCrLf
        ret = ret + "5:CO" + vbCrLf
        ret = ret + "15:0" + vbCrLf
        ret = ret + "6:EI" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "ERET : Exception Return" + vbCrLf
        ret = ret + "ERET" + vbCrLf
        ret = ret + "01000010000000000000000000011000" + vbCrLf
        ret = ret + "11111111111111111111111111111111" + vbCrLf
        ret = ret + "COP0" + vbCrLf
        ret = ret + "6:COP0" + vbCrLf
        ret = ret + "5:CO" + vbCrLf
        ret = ret + "15:0" + vbCrLf
        ret = ret + "6:ERET" + vbCrLf

        ret = ret + "========================================" + vbCrLf
        ret = ret + "MFC0 : Move from System Control Coprocessor" + vbCrLf
        ret = ret + "MFC0 rt, reg" + vbCrLf
        ret = ret + "MFC0 rt, reg, sel" + vbCrLf
        ret = ret + "01000000000000000000000000000000" + vbCrLf
        ret = ret + "11111111111000000000011111111000" + vbCrLf
        ret = ret + "COP0" + vbCrLf
        ret = ret + "6:COP0" + vbCrLf
        ret = ret + "5:MF0" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:reg" + vbCrLf
        ret = ret + "8:0" + vbCrLf
        ret = ret + "3:sel" + vbCrLf
        ret = ret + "sel=0" + vbCrLf

        ret = ret + "========================================" + vbCrLf
        ret = ret + "MTC0 : Move to System Control Coprocessor" + vbCrLf
        ret = ret + "MTC0 rt, reg" + vbCrLf
        ret = ret + "MTC0 rt, reg, sel" + vbCrLf
        ret = ret + "01000000100000000000000000000000" + vbCrLf
        ret = ret + "11111111111000000000011111111000" + vbCrLf
        ret = ret + "COP0" + vbCrLf
        ret = ret + "6:COP0" + vbCrLf
        ret = ret + "5:MT0" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:reg" + vbCrLf
        ret = ret + "8:0" + vbCrLf
        ret = ret + "3:sel" + vbCrLf
        ret = ret + "sel=0" + vbCrLf


        MIPS_File_2 = ret
    End Function

    Private Function MIPS_File_3() As String
        Dim ret As String

        ret = ""
        ret = ret + "========================================" + vbCrLf
        ret = ret + "ABS.S : Floating Point Absolute Value" + vbCrLf
        ret = ret + "ABS.S fd, fs" + vbCrLf
        ret = ret + "01000110000000000000000000000101" + vbCrLf
        ret = ret + "11111111111111110000000000111111" + vbCrLf
        ret = ret + "COP1" + vbCrLf
        ret = ret + "6:COP1" + vbCrLf
        ret = ret + "5:S" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "5:fs" + vbCrLf
        ret = ret + "5:fd" + vbCrLf
        ret = ret + "6:ABS" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "ADD.S : Floating Point ADD" + vbCrLf
        ret = ret + "ADD.S fd, fs, ft" + vbCrLf
        ret = ret + "01000110000000000000000000000000" + vbCrLf
        ret = ret + "11111111111000000000000000111111" + vbCrLf
        ret = ret + "COP1" + vbCrLf
        ret = ret + "6:COP1" + vbCrLf
        ret = ret + "5:S" + vbCrLf
        ret = ret + "5:ft" + vbCrLf
        ret = ret + "5:fs" + vbCrLf
        ret = ret + "5:fd" + vbCrLf
        ret = ret + "6:ADD" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "ADDA.S : Floating Point Add to Accumulator" + vbCrLf
        ret = ret + "ADDA.S fs, ft" + vbCrLf
        ret = ret + "01000110000000000000000000011000" + vbCrLf
        ret = ret + "11111111111000000000011111111111" + vbCrLf
        ret = ret + "COP1" + vbCrLf
        ret = ret + "6:COP1" + vbCrLf
        ret = ret + "5:S" + vbCrLf
        ret = ret + "5:ft" + vbCrLf
        ret = ret + "5:fs" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "6:ADDA" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "BC1F : Branch on FP False" + vbCrLf
        ret = ret + "BC1F offset" + vbCrLf
        ret = ret + "01000101000000000000000000000000" + vbCrLf
        ret = ret + "11111111111111110000000000000000" + vbCrLf
        ret = ret + "COP1" + vbCrLf
        ret = ret + "6:COP1" + vbCrLf
        ret = ret + "5:BC1" + vbCrLf
        ret = ret + "5:BC1F" + vbCrLf
        ret = ret + "16:offset" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "BC1FL : Branch on FP False Likely" + vbCrLf
        ret = ret + "BC1FL offset" + vbCrLf
        ret = ret + "01000101000000100000000000000000" + vbCrLf
        ret = ret + "11111111111111110000000000000000" + vbCrLf
        ret = ret + "COP1" + vbCrLf
        ret = ret + "6:COP1" + vbCrLf
        ret = ret + "5:BC1" + vbCrLf
        ret = ret + "5:BC1FL" + vbCrLf
        ret = ret + "16:offset" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "BC1T : Branch on FP True" + vbCrLf
        ret = ret + "BC1T offset" + vbCrLf
        ret = ret + "01000101000000010000000000000000" + vbCrLf
        ret = ret + "11111111111111110000000000000000" + vbCrLf
        ret = ret + "COP1" + vbCrLf
        ret = ret + "6:COP1" + vbCrLf
        ret = ret + "5:BC1" + vbCrLf
        ret = ret + "5:BC1T" + vbCrLf
        ret = ret + "16:offset" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "BC1TL : Branch on FP True Likely" + vbCrLf
        ret = ret + "BC1TL offset" + vbCrLf
        ret = ret + "01000101000000110000000000000000" + vbCrLf
        ret = ret + "11111111111111110000000000000000" + vbCrLf
        ret = ret + "COP1" + vbCrLf
        ret = ret + "6:COP1" + vbCrLf
        ret = ret + "5:BC1" + vbCrLf
        ret = ret + "5:BC1TL" + vbCrLf
        ret = ret + "16:offset" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "C.EQ.S : Floating Point Compare" + vbCrLf
        ret = ret + "C.EQ.S fs, ft" + vbCrLf
        ret = ret + "01000110000000000000000000110010" + vbCrLf
        ret = ret + "11111111111000000000011111111111" + vbCrLf
        ret = ret + "COP1" + vbCrLf
        ret = ret + "6:COP1" + vbCrLf
        ret = ret + "5:S" + vbCrLf
        ret = ret + "5:ft" + vbCrLf
        ret = ret + "5:fs" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "2:FC" + vbCrLf
        ret = ret + "1:0" + vbCrLf
        ret = ret + "2:cond" + vbCrLf
        ret = ret + "1:0" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "C.F.S : Floating Point Compare" + vbCrLf
        ret = ret + "C.F.S fs, ft" + vbCrLf
        ret = ret + "01000110000000000000000000110000" + vbCrLf
        ret = ret + "11111111111000000000011111111111" + vbCrLf
        ret = ret + "COP1" + vbCrLf
        ret = ret + "6:COP1" + vbCrLf
        ret = ret + "5:S" + vbCrLf
        ret = ret + "5:ft" + vbCrLf
        ret = ret + "5:fs" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "2:FC" + vbCrLf
        ret = ret + "1:0" + vbCrLf
        ret = ret + "2:cond" + vbCrLf
        ret = ret + "1:0" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "C.LE.S : Floating Point Compare" + vbCrLf
        ret = ret + "C.LE.S fs, ft" + vbCrLf
        ret = ret + "01000110000000000000000000110110" + vbCrLf
        ret = ret + "11111111111000000000011111111111" + vbCrLf
        ret = ret + "COP1" + vbCrLf
        ret = ret + "6:COP1" + vbCrLf
        ret = ret + "5:S" + vbCrLf
        ret = ret + "5:ft" + vbCrLf
        ret = ret + "5:fs" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "2:FC" + vbCrLf
        ret = ret + "1:0" + vbCrLf
        ret = ret + "2:cond" + vbCrLf
        ret = ret + "1:0" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "C.LT.S : Floating Point Compare" + vbCrLf
        ret = ret + "C.LT.S fs, ft" + vbCrLf
        ret = ret + "01000110000000000000000000110100" + vbCrLf
        ret = ret + "11111111111000000000011111111111" + vbCrLf
        ret = ret + "COP1" + vbCrLf
        ret = ret + "6:COP1" + vbCrLf
        ret = ret + "5:S" + vbCrLf
        ret = ret + "5:ft" + vbCrLf
        ret = ret + "5:fs" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "2:FC" + vbCrLf
        ret = ret + "1:0" + vbCrLf
        ret = ret + "2:cond" + vbCrLf
        ret = ret + "1:0" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "CFC1 : Move Control Word from Floating Point" + vbCrLf
        ret = ret + "CFC1 rt, fs" + vbCrLf
        ret = ret + "01000100010000000000000000000000" + vbCrLf
        ret = ret + "11111111111000000000011111111111" + vbCrLf
        ret = ret + "COP1" + vbCrLf
        ret = ret + "6:COP1" + vbCrLf
        ret = ret + "5:CFC1" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:fs" + vbCrLf
        ret = ret + "11:0" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "CTC1 : Move Control Word to Floating Point" + vbCrLf
        ret = ret + "CTC1 rt, fs" + vbCrLf
        ret = ret + "01000100110000000000000000000000" + vbCrLf
        ret = ret + "11111111111000000000011111111111" + vbCrLf
        ret = ret + "COP1" + vbCrLf
        ret = ret + "6:COP1" + vbCrLf
        ret = ret + "5:CTC1" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:fs" + vbCrLf
        ret = ret + "11:0" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "CVT.S.W : Fixed-point Convert to Single Floating Point" + vbCrLf
        ret = ret + "CVT.S.W fd, fs" + vbCrLf
        ret = ret + "01000110100000000000000000100000" + vbCrLf
        ret = ret + "11111111111111110000000000111111" + vbCrLf
        ret = ret + "COP1" + vbCrLf
        ret = ret + "6:COP1" + vbCrLf
        ret = ret + "5:W" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "5:fs" + vbCrLf
        ret = ret + "5:fd" + vbCrLf
        ret = ret + "6:CVTS" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "CVT.W.S : Floating Point Convert to Word Fixed-point" + vbCrLf
        ret = ret + "CVT.W.S fd, fs" + vbCrLf
        ret = ret + "01000110000000000000000000100100" + vbCrLf
        ret = ret + "11111111111111110000000000111111" + vbCrLf
        ret = ret + "COP1" + vbCrLf
        ret = ret + "6:COP1" + vbCrLf
        ret = ret + "5:S" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "5:fs" + vbCrLf
        ret = ret + "5:fd" + vbCrLf
        ret = ret + "6:CVTW" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "DIV.S : Floating Point Divide" + vbCrLf
        ret = ret + "DIV.S fd, fs, ft" + vbCrLf
        ret = ret + "01000110000000000000000000000011" + vbCrLf
        ret = ret + "11111111111000000000000000111111" + vbCrLf
        ret = ret + "COP1" + vbCrLf
        ret = ret + "6:COP1" + vbCrLf
        ret = ret + "5:S" + vbCrLf
        ret = ret + "5:ft" + vbCrLf
        ret = ret + "5:fs" + vbCrLf
        ret = ret + "5:fd" + vbCrLf
        ret = ret + "6:DIV" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "LWC1 : Load Word to Floating Point" + vbCrLf
        ret = ret + "LWC1 ft, offset(base)" + vbCrLf
        ret = ret + "11000100000000000000000000000000" + vbCrLf
        ret = ret + "11111100000000000000000000000000" + vbCrLf
        ret = ret + "COP1" + vbCrLf
        ret = ret + "6:LWC1" + vbCrLf
        ret = ret + "5:base" + vbCrLf
        ret = ret + "5:ft" + vbCrLf
        ret = ret + "16:offset" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "MADD.S : Floating Point Multiply-ADD" + vbCrLf
        ret = ret + "MADD.S fd, fs, ft" + vbCrLf
        ret = ret + "01000110000000000000000000011100" + vbCrLf
        ret = ret + "11111111111000000000000000111111" + vbCrLf
        ret = ret + "COP1" + vbCrLf
        ret = ret + "6:COP1" + vbCrLf
        ret = ret + "5:S" + vbCrLf
        ret = ret + "5:ft" + vbCrLf
        ret = ret + "5:fs" + vbCrLf
        ret = ret + "5:fd" + vbCrLf
        ret = ret + "6:MADD" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "MADDA.S : Floating Point Multiply-Add" + vbCrLf
        ret = ret + "MADDA.S fs, ft" + vbCrLf
        ret = ret + "01000110000000000000000000011110" + vbCrLf
        ret = ret + "11111111111000000000011111111111" + vbCrLf
        ret = ret + "COP1" + vbCrLf
        ret = ret + "6:COP1" + vbCrLf
        ret = ret + "5:S" + vbCrLf
        ret = ret + "5:ft" + vbCrLf
        ret = ret + "5:fs" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "6:MADDA" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "MAX.S : Floating Point Maximum" + vbCrLf
        ret = ret + "MAX.S fd, fs, ft" + vbCrLf
        ret = ret + "01000110000000000000000000101000" + vbCrLf
        ret = ret + "11111111111000000000000000111111" + vbCrLf
        ret = ret + "COP1" + vbCrLf
        ret = ret + "6:COP1" + vbCrLf
        ret = ret + "5:S" + vbCrLf
        ret = ret + "5:ft" + vbCrLf
        ret = ret + "5:fs" + vbCrLf
        ret = ret + "5:fd" + vbCrLf
        ret = ret + "6:MAX" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "MFC1 : Move Word from Floating Point" + vbCrLf
        ret = ret + "MFC1 rt, fs" + vbCrLf
        ret = ret + "01000100000000000000000000000000" + vbCrLf
        ret = ret + "11111111111000000000011111111111" + vbCrLf
        ret = ret + "COP1" + vbCrLf
        ret = ret + "6:COP1" + vbCrLf
        ret = ret + "5:MFC1" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:fs" + vbCrLf
        ret = ret + "11:0" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "MIN.S : Floating Point Minimum" + vbCrLf
        ret = ret + "MIN.S fd, fs, ft" + vbCrLf
        ret = ret + "01000110000000000000000000101001" + vbCrLf
        ret = ret + "11111111111000000000000000111111" + vbCrLf
        ret = ret + "COP1" + vbCrLf
        ret = ret + "6:COP1" + vbCrLf
        ret = ret + "5:S" + vbCrLf
        ret = ret + "5:ft" + vbCrLf
        ret = ret + "5:fs" + vbCrLf
        ret = ret + "5:fd" + vbCrLf
        ret = ret + "6:MIN" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "MOV.S : Floating Point Move" + vbCrLf
        ret = ret + "MOV.S fd, fs" + vbCrLf
        ret = ret + "01000110000000000000000000000110" + vbCrLf
        ret = ret + "11111111111111110000000000111111" + vbCrLf
        ret = ret + "COP1" + vbCrLf
        ret = ret + "6:COP1" + vbCrLf
        ret = ret + "5:S" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "5:fs" + vbCrLf
        ret = ret + "5:fd" + vbCrLf
        ret = ret + "6:MOV" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "MSUB.S : Floating Point Multiply and Subtract" + vbCrLf
        ret = ret + "MSUB.S fd, fs, ft" + vbCrLf
        ret = ret + "01000110000000000000000000011101" + vbCrLf
        ret = ret + "11111111111000000000000000111111" + vbCrLf
        ret = ret + "COP1" + vbCrLf
        ret = ret + "6:COP1" + vbCrLf
        ret = ret + "5:S" + vbCrLf
        ret = ret + "5:ft" + vbCrLf
        ret = ret + "5:fs" + vbCrLf
        ret = ret + "5:fd" + vbCrLf
        ret = ret + "6:MSUB" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "MSUBA.S : Floating Point Multiply and Subtract from Accumulator" + vbCrLf
        ret = ret + "MSUBA.S fs, ft" + vbCrLf
        ret = ret + "01000110000000000000000000011111" + vbCrLf
        ret = ret + "11111111111000000000011111111111" + vbCrLf
        ret = ret + "COP1" + vbCrLf
        ret = ret + "6:COP1" + vbCrLf
        ret = ret + "5:S" + vbCrLf
        ret = ret + "5:ft" + vbCrLf
        ret = ret + "5:fs" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "6:MSUBA" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "MTC1 : Move Word to Floating Point" + vbCrLf
        ret = ret + "MTC1 rt, fs" + vbCrLf
        ret = ret + "01000100100000000000000000000000" + vbCrLf
        ret = ret + "11111111111000000000011111111111" + vbCrLf
        ret = ret + "COP1" + vbCrLf
        ret = ret + "6:COP1" + vbCrLf
        ret = ret + "5:MTC1" + vbCrLf
        ret = ret + "5:rt" + vbCrLf
        ret = ret + "5:fs" + vbCrLf
        ret = ret + "11:0" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "MUL.S : Floating Point Multiply" + vbCrLf
        ret = ret + "MUL.S fd, fs, ft" + vbCrLf
        ret = ret + "01000110000000000000000000000010" + vbCrLf
        ret = ret + "11111111111000000000000000111111" + vbCrLf
        ret = ret + "COP1" + vbCrLf
        ret = ret + "6:COP1" + vbCrLf
        ret = ret + "5:S" + vbCrLf
        ret = ret + "5:ft" + vbCrLf
        ret = ret + "5:fs" + vbCrLf
        ret = ret + "5:fd" + vbCrLf
        ret = ret + "6:MUL" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "MULA.S : Floating Point Multiply to Accumulator" + vbCrLf
        ret = ret + "MULA.S fs, ft" + vbCrLf
        ret = ret + "01000110000000000000000000011010" + vbCrLf
        ret = ret + "11111111111000000000011111111111" + vbCrLf
        ret = ret + "COP1" + vbCrLf
        ret = ret + "6:COP1" + vbCrLf
        ret = ret + "5:S" + vbCrLf
        ret = ret + "5:ft" + vbCrLf
        ret = ret + "5:fs" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "6:MULA" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "NEG.S : Floating Point Negate" + vbCrLf
        ret = ret + "NEG.S fd, fs" + vbCrLf
        ret = ret + "01000110000000000000000000000111" + vbCrLf
        ret = ret + "11111111111111110000000000111111" + vbCrLf
        ret = ret + "COP1" + vbCrLf
        ret = ret + "6:COP1" + vbCrLf
        ret = ret + "5:S" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "5:fs" + vbCrLf
        ret = ret + "5:fd" + vbCrLf
        ret = ret + "6:NEG" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "RSQRT.S : Floating Point Reciprocal Square Root" + vbCrLf
        ret = ret + "RSQRT.S fd, fs, ft" + vbCrLf
        ret = ret + "01000110000000000000000000010110" + vbCrLf
        ret = ret + "11111111111000000000000000111111" + vbCrLf
        ret = ret + "COP1" + vbCrLf
        ret = ret + "6:COP1" + vbCrLf
        ret = ret + "5:S" + vbCrLf
        ret = ret + "5:ft" + vbCrLf
        ret = ret + "5:fs" + vbCrLf
        ret = ret + "5:fd" + vbCrLf
        ret = ret + "6:RSQRT" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "SQRT.S : Floating Point Square Root" + vbCrLf
        ret = ret + "SQRT.S fd, ft" + vbCrLf
        ret = ret + "01000110000000000000000000000100" + vbCrLf
        ret = ret + "11111111111000001111100000111111" + vbCrLf
        ret = ret + "COP1" + vbCrLf
        ret = ret + "6:COP1" + vbCrLf
        ret = ret + "5:S" + vbCrLf
        ret = ret + "5:ft" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "5:fd" + vbCrLf
        ret = ret + "6:SQRT" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "SUB.S : Floating Point Subtract" + vbCrLf
        ret = ret + "SUB.S fd, fs, ft" + vbCrLf
        ret = ret + "01000110000000000000000000000001" + vbCrLf
        ret = ret + "11111111111000000000000000111111" + vbCrLf
        ret = ret + "COP1" + vbCrLf
        ret = ret + "6:COP1" + vbCrLf
        ret = ret + "5:S" + vbCrLf
        ret = ret + "5:ft" + vbCrLf
        ret = ret + "5:fs" + vbCrLf
        ret = ret + "5:fd" + vbCrLf
        ret = ret + "6:SUB" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "SUBA.S : Floating Point Subtract to Accumulator" + vbCrLf
        ret = ret + "SUBA.S fs, ft" + vbCrLf
        ret = ret + "01000110000000000000000000011001" + vbCrLf
        ret = ret + "11111111111000000000011111111111" + vbCrLf
        ret = ret + "COP1" + vbCrLf
        ret = ret + "6:COP1" + vbCrLf
        ret = ret + "5:S" + vbCrLf
        ret = ret + "5:ft" + vbCrLf
        ret = ret + "5:fs" + vbCrLf
        ret = ret + "5:0" + vbCrLf
        ret = ret + "6:SUBA" + vbCrLf
        ret = ret + "========================================" + vbCrLf
        ret = ret + "SWC1 : Store Word from Floating Point" + vbCrLf
        ret = ret + "SWC1 ft, offset(base)" + vbCrLf
        ret = ret + "11100100000000000000000000000000" + vbCrLf
        ret = ret + "11111100000000000000000000000000" + vbCrLf
        ret = ret + "COP1" + vbCrLf
        ret = ret + "6:SWC1" + vbCrLf
        ret = ret + "5:base" + vbCrLf
        ret = ret + "5:ft" + vbCrLf
        ret = ret + "16:offset"
        ret = ret + "========================================" + vbCrLf
        ret = ret + "CACHE : Cache Operation" + vbCrLf
        ret = ret + "CACHE cvar, %i(base)" + vbCrLf
        ret = ret + "10111100000000000000000000000000" + vbCrLf
        ret = ret + "11111100000000000000000000000000" + vbCrLf
        ret = ret + "EE" + vbCrLf
        ret = ret + "6:CACHE" + vbCrLf
        ret = ret + "5:base" + vbCrLf
        ret = ret + "5:cvar" + vbCrLf
        ret = ret + "16:offset"

        MIPS_File_3 = ret
    End Function




End Module
