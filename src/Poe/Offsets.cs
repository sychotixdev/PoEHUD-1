using PoeHUD.Framework;
using PoeHUD.Models;
using System.IO;


namespace PoeHUD.Poe
{

    public class Offsets
    {
        public static Offsets Regular = new Offsets { IgsOffset = 0, IgsDelta = 0, ExeName = "PathOfExile_x64" };
        public static Offsets Steam = new Offsets { IgsOffset = 0x28, IgsDelta = 0, ExeName = "PathOfExile_x64Steam" };

        /*
        PathOfExile_x64.exe+45FFC0 - 40 53                 - push rbx
        PathOfExile_x64.exe+45FFC2 - 48 83 EC 50           - sub rsp,50 { 80 }
        PathOfExile_x64.exe+45FFC6 - 48 C7 44 24 20 FEFFFFFF - mov [rsp+20],FFFFFFFE { -2 }
        PathOfExile_x64.exe+45FFCF - C7 44 24 60 00000000  - mov [rsp+60],00000000 { 0 }
        PathOfExile_x64.exe+45FFD7 - 48 8B 05 FA57CF00     - mov rax,[PathOfExile_x64.exe+11557D8] { [004D2D10] } <----RIP to Base
        PathOfExile_x64.exe+45FFDE - 48 85 C0              - test rax,rax
        PathOfExile_x64.exe+45FFE1 - 0F85 84000000         - jne PathOfExile_x64.exe+46006B
         */

        private static readonly Pattern basePtrPattern = new Pattern(new byte[]
        {
            0x40, 0x53,
            0x48, 0x83, 0xEC, 0x50,
            0x48, 0xC7, 0x44, 0x24, 0x20, 0xFE, 0xFF, 0xFF, 0xFF,
            0xC7, 0x44, 0x24, 0x60, 0x00, 0x00, 0x00, 0x00,
            0x48, 0x8b, 0x05
        }, "xxxxxxxxxxxxxxxxxxxxxxxxxx");

        /*
        00007FF6E2077CB0 | 48 8B C4                       | mov rax,rsp                                  |
        00007FF6E2077CB3 | 48 89 48 08                    | mov qword ptr ds:[rax+8],rcx                 |
        00007FF6E2077CB7 | 55                             | push rbp                                     |
        00007FF6E2077CB8 | 41 56                          | push r14                                     |
        00007FF6E2077CBA | 41 57                          | push r15                                     | r15:"minkernel\\ntdll\\ldrinit.c"
        00007FF6E2077CBC | 48 8D A8 48 FF FF FF           | lea rbp,qword ptr ds:[rax-B8]                |
        00007FF6E2077CC3 | 48 81 EC A0 01 00 00           | sub rsp,1A0                                  |
        00007FF6E2077CCA | 48 C7 44 24 40 FE FF FF FF     | mov qword ptr ss:[rsp+40],FFFFFFFFFFFFFFFE   | [rsp+40]:"sed at 0x%p. Status = 0x%x\n"
        00007FF6E2077CD3 | 48 89 58 10                    | mov qword ptr ds:[rax+10],rbx                | rbx:"LdrpInitializeProcess"
        00007FF6E2077CD7 | 48 89 70 18                    | mov qword ptr ds:[rax+18],rsi                |
        00007FF6E2077CDB | 48 89 78 20                    | mov qword ptr ds:[rax+20],rdi                |
        00007FF6E2077CDF | 33 D2                          | xor edx,edx                                  |
        00007FF6E2077CE1 | 48 8D 0D 38 E4 DB 00           | lea rcx,qword ptr ds:[7FF6E2E36120]          | <---FileRoot RIP
        00007FF6E2077CE8 | E8 63 06 00 00                 | call pathofexile_x64 - 2.4.3c.7FF6E2078350   |
        00007FF6E2077CED | 90                             | nop                                          |
        00007FF6E2077CEE | 48 8B 35 33 E4 DB 00           | mov rsi,qword ptr ds:[7FF6E2E36128]          |
        00007FF6E2077CF5 | 48 8B 1E                       | mov rbx,qword ptr ds:[rsi]                   | rbx:"LdrpInitializeProcess"
        00007FF6E2077CF8 | 45 33 F6                       | xor r14d,r14d                                |
        00007FF6E2077CFB | 4C 8D 3D 16 83 89 00           | lea r15,qword ptr ds:[7FF6E2910018]          | r15:"minkernel\\ntdll\\ldrinit.c"
        00007FF6E2077D02 | 48 89 9D C0 00 00 00           | mov qword ptr ss:[rbp+C0],rbx                |
        00007FF6E2077D09 | 48 3B DE                       | cmp rbx,rsi                                  | rbx:"LdrpInitializeProcess"        
        */

        private static readonly Pattern fileRootPattern = new Pattern(new byte[]
        {
                  0x89, 0x58, 0x10,
            0x48, 0x89, 0x70, 0x18,
            0x48, 0x89, 0x78, 0x20,
            0x33, 0xD2,
            0x48, 0x8D, 0x0D
        }, "xxxxxxxxxxxxxxxx");

        /*  areaChangePattern

        PathOfExile_x64.exe+3486C4 - E8 8BAD6700           - call PathOfExile_x64.exe+9C3454
        PathOfExile_x64.exe+348719 - 90                    - nop 
        PathOfExile_x64.exe+34871A - 48 8B 86 C8.1A.00.00     - mov rax,[rsi+00001AC8]
        PathOfExile_x64.exe+348721 - 33 D2                 - xor edx,edx
        PathOfExile_x64.exe+348723 - 48 8B 88 98.0D.00.00     - mov rcx,[rax+00000D98]
        PathOfExile_x64.exe+34872A - E8 11.F9.54.00           - call PathOfExile_x64.exe+898040
        PathOfExile_x64.exe+34872F - E8 FC.01.05.00           - call PathOfExile_x64.exe+398930
        PathOfExile_x64.exe+348734 - FF 05 E2.68.C5.00        - inc [PathOfExile_x64.exe+F9F01C] { [0000000A] } <--Here
        PathOfExile_x64.exe+34873A - 48 8B C8              - mov rcx,rax
        */

        private static readonly Pattern areaChangePattern = new Pattern(new byte[]
        {
            0xE8, 0x00, 0x00, 0x00, 0x00,
            0x90,
            0x48, 0x8B, 0x86, 0x00,  0x00, 0x00, 0x00,
            0x33, 0xd2,
            0x48, 0x8B, 0x88, 0x00, 0x00, 0x00, 0x00,
            0xE8, 0x00, 0x00, 0x00, 0x00,
            0xE8, 0x00, 0x00, 0x00, 0x00,
            0xFF, 0x05, 0x00, 0x00, 0x00, 0x00,
            0x48, 0x8B, 0xC8,
        }, "x????xxxx????xxxxx????x????x????xx????xxx");


        private static readonly Pattern inGameOffsetPattern =
            new Pattern(@"\x8B\x0F\x6A\x01\x51\xFF\x15\x00\x00\x00\x00\x88\x9F\x00\x00\x00\x00\xC7\x86\x00\x00\x00\x00\x00\x00\x00\x00\xEB\x11",
                "xxxxxxx????xx????xx????????xx");

        /*
             8B 0F                              mov     ecx, [edi]
             6A 01                              push    1
             51                                 push    ecx
             FF 15 54 5A B9 00                  call    ds:shutdown
             88 9F 80 00 00 00                  mov     [edi+80h], bl
             C7 86 BC 30 00 00 01 00 00 00      mov     dword ptr [esi+30BCh], 1
             EB 11                              jmp     short loc_5F3972
        */

        public long AreaChangeCount { get; private set; }
        public long Base { get; private set; }
        public string ExeName { get; private set; }
        public long FileRoot { get; private set; }
        public int IgsDelta { get; private set; }
        public int IgsOffset { get; private set; }
        //public int InGameOffset { get; private set; }

        public int IgsOffsetDelta => IgsOffset + IgsDelta;



        //public long basePointer;
        public long areaCC_pointer;
        public void DoPatternScans(Memory m)
        {
            long[] array = m.FindPatterns(basePtrPattern, fileRootPattern, areaChangePattern);
            Base = m.ReadInt(m.AddressOfProcess + array[0] + 0x1A) + array[0] + 0x1E;
            System.Console.WriteLine("Base Address: " + (Base + m.AddressOfProcess).ToString("x8"));
            FileRoot = m.ReadInt(m.AddressOfProcess + array[1] + 0x10) + array[1] + 0x14;
            System.Console.WriteLine("FileRoot Pointer: " + (FileRoot + m.AddressOfProcess).ToString("x8"));
            AreaChangeCount = m.ReadInt(m.AddressOfProcess + array[2] + 0x22) + array[2] + 0x26;
            System.Console.WriteLine("AreaChangeCount Pointer: " + (AreaChangeCount + m.AddressOfProcess).ToString("x8"));
        }
    }
}