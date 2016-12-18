Module Global_Structures

    <System.Runtime.InteropServices.StructLayout(Runtime.InteropServices.LayoutKind.Explicit)>
    Public Structure Word32Bit

        '--------------------------------------------------- Words
        <System.Runtime.InteropServices.FieldOffset(0)>
        Dim u32 As UInt32
        <System.Runtime.InteropServices.FieldOffset(0)>
        Dim s32 As Int32

        '--------------------------------------------------- Bytes
        <System.Runtime.InteropServices.FieldOffset(0)>
        Dim u8_1 As Byte
        <System.Runtime.InteropServices.FieldOffset(1)>
        Dim u8_2 As Byte
        <System.Runtime.InteropServices.FieldOffset(2)>
        Dim u8_3 As Byte
        <System.Runtime.InteropServices.FieldOffset(3)>
        Dim u8_4 As Byte
        <System.Runtime.InteropServices.FieldOffset(0)>
        Dim s8_1 As SByte
        <System.Runtime.InteropServices.FieldOffset(1)>
        Dim s8_2 As SByte
        <System.Runtime.InteropServices.FieldOffset(2)>
        Dim s8_3 As SByte
        <System.Runtime.InteropServices.FieldOffset(3)>
        Dim s8_4 As SByte

        '--------------------------------------------------- Halves
        <System.Runtime.InteropServices.FieldOffset(0)>
        Dim u16_1 As UInt16
        <System.Runtime.InteropServices.FieldOffset(2)>
        Dim u16_2 As UInt16
        <System.Runtime.InteropServices.FieldOffset(0)>
        Dim s16_1 As Int16
        <System.Runtime.InteropServices.FieldOffset(2)>
        Dim s16_2 As Int16

    End Structure

    <System.Runtime.InteropServices.StructLayout(Runtime.InteropServices.LayoutKind.Explicit)>
    Public Structure MIPSAsmStructure
        <System.Runtime.InteropServices.FieldOffset(0)>
        Dim b1 As Byte
        <System.Runtime.InteropServices.FieldOffset(1)>
        Dim b2 As Byte
        <System.Runtime.InteropServices.FieldOffset(2)>
        Dim b3 As Byte
        <System.Runtime.InteropServices.FieldOffset(3)>
        Dim b4 As Byte

        <System.Runtime.InteropServices.FieldOffset(0)>
        Dim sImmediate As Int16
        <System.Runtime.InteropServices.FieldOffset(0)>
        Dim uImmediate As UInt16

        <System.Runtime.InteropServices.FieldOffset(0)>
        Dim i32 As Int32
        <System.Runtime.InteropServices.FieldOffset(0)>
        Dim u32 As UInt32

        <System.Runtime.InteropServices.FieldOffset(4)>
        Dim loadBytes As Func(Of Byte(), Int32, Byte)

        <System.Runtime.InteropServices.FieldOffset(8)>
        Dim rs As Func(Of Byte)
        <System.Runtime.InteropServices.FieldOffset(12)>
        Dim rt As Func(Of Byte)
        <System.Runtime.InteropServices.FieldOffset(16)>
        Dim rd As Func(Of Byte)
        <System.Runtime.InteropServices.FieldOffset(20)>
        Dim sa As Func(Of Byte)
        <System.Runtime.InteropServices.FieldOffset(24)>
        Dim target As Func(Of UInt32)

    End Structure

    <System.Runtime.InteropServices.StructLayout(Runtime.InteropServices.LayoutKind.Explicit)>
    Public Structure RegisterFloat
        <System.Runtime.InteropServices.FieldOffset(0)>
        Dim u32 As UInt32
        <System.Runtime.InteropServices.FieldOffset(0)>
        Dim f32 As Single
    End Structure

    <System.Runtime.InteropServices.StructLayout(Runtime.InteropServices.LayoutKind.Explicit)>
    Public Structure Register128
        '------------------------------------------------- Lower 32 bit section
        <System.Runtime.InteropServices.FieldOffset(0)>
        Dim u64_1 As UInt64
        <System.Runtime.InteropServices.FieldOffset(0)>
        Dim s64_1 As Int64
        <System.Runtime.InteropServices.FieldOffset(0)>
        Dim u32_1 As UInt32
        <System.Runtime.InteropServices.FieldOffset(0)>
        Dim s32_1 As Int32
        <System.Runtime.InteropServices.FieldOffset(0)>
        Dim u16_1 As UInt16
        <System.Runtime.InteropServices.FieldOffset(0)>
        Dim s16_1 As Int16
        <System.Runtime.InteropServices.FieldOffset(0)>
        Dim u8_1 As Byte
        <System.Runtime.InteropServices.FieldOffset(0)>
        Dim s8_1 As SByte
        <System.Runtime.InteropServices.FieldOffset(4)>
        Dim Overflow_1 As Int32


        '------------------------------------------------- Lower 64 bit section
        <System.Runtime.InteropServices.FieldOffset(8)>
        Dim u64_2 As UInt64
        <System.Runtime.InteropServices.FieldOffset(8)>
        Dim s64_2 As Int64
        <System.Runtime.InteropServices.FieldOffset(8)>
        Dim u32_2 As UInt32
        <System.Runtime.InteropServices.FieldOffset(8)>
        Dim s32_2 As Int32
        <System.Runtime.InteropServices.FieldOffset(&HC)>
        Dim Overflow_2 As Int32


        '------------------------------------------------- Upper 64 bit section
        <System.Runtime.InteropServices.FieldOffset(&H10)>
        Dim u64_3 As UInt64
        <System.Runtime.InteropServices.FieldOffset(&H10)>
        Dim s64_3 As Int64
        <System.Runtime.InteropServices.FieldOffset(&H10)>
        Dim u32_3 As UInt32
        <System.Runtime.InteropServices.FieldOffset(&H10)>
        Dim s32_3 As Int32
        <System.Runtime.InteropServices.FieldOffset(&H14)>
        Dim Overflow_3 As Int32

        '------------------------------------------------- Upper 128 bit section
        <System.Runtime.InteropServices.FieldOffset(&H18)>
        Dim u64_4 As UInt64
        <System.Runtime.InteropServices.FieldOffset(&H18)>
        Dim s64_4 As Int64
        <System.Runtime.InteropServices.FieldOffset(&H18)>
        Dim u32_4 As UInt32
        <System.Runtime.InteropServices.FieldOffset(&H18)>
        Dim s32_4 As Int32
        <System.Runtime.InteropServices.FieldOffset(&H1C)>
        Dim Overflow_4 As Int32


    End Structure


End Module
