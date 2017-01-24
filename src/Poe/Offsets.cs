using PoeHUD.Framework;
using PoeHUD.Models;
using System.IO;
using System.Windows.Forms;


namespace PoeHUD.Poe
{

    public class Offsets
    {
        public static Offsets Regular = new Offsets { IgsOffset = 0, IgsDelta = 0, ExeName = "PathOfExile_x64" };
        public static Offsets Steam = new Offsets { IgsOffset = 0x28, IgsDelta = 0, ExeName = "PathOfExile_x64Steam" };

        /* Base Pointer
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

        /* FileRoot Pointer
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
            0x48, 0x8D, 0x1D, 0x49, 0x5B, 0xDE, 0x00, 0x48, 0x8B, 0xCB, 0xE8, 0x41, 0xF5, 0xFF, 0xFF

        }, "xxxxxxxxxxxxxxx");

        /* Area Change
        00007FF63317CE40 | 48 83 EC 58                    | sub rsp,58                                      |
        00007FF63317CE44 | 4C 8B C1                       | mov r8,rcx                                      |
        00007FF63317CE47 | 41 B9 01 00 00 00              | mov r9d,1                                       |
        00007FF63317CE4D | 48 8B 49 10                    | mov rcx,qword ptr ds:[rcx+10]                   |
        00007FF63317CE51 | 48 89 4C 24 30                 | mov qword ptr ss:[rsp+30],rcx                   |
        00007FF63317CE56 | 48 85 C9                       | test rcx,rcx                                    |
        00007FF63317CE59 | 74 11                          | je pathofexile_x64 - alpha 2.5.7FF63317CE6C     |
        00007FF63317CE5B | 41 8B C1                       | mov eax,r9d                                     |
        00007FF63317CE5E | F0 0F C1 41 54                 | lock xadd dword ptr ds:[rcx+54],eax             |
        00007FF63317CE63 | 8B 05 7B 09 F0 00              | mov eax,dword ptr ds:[<AreaChangeCount>]        |
        00007FF63317CE69 | 89 41 50                       | mov dword ptr ds:[rcx+50],eax                   |
        00007FF63317CE6C | 49 8B 08                       | mov rcx,qword ptr ds:[r8]                       |
        00007FF63317CE6F | 49 8B 40 18                    | mov rax,qword ptr ds:[r8+18]                    |
        */

        private static readonly Pattern areaChangePattern = new Pattern(new byte[]
        {
             0x48, 0x83, 0xEC, 0x58,
             0x4C, 0x8B, 0xC1,
             0x41, 0xB9, 0x01, 0x00, 0x00, 0x00,
             0x48, 0x8B, 0x49, 0x10
        }, "xxxxxxxxxxxxxxxxx");

        /*
             8B 0F                              mov     ecx, [edi]
             6A 01                              push    1
             51                                 push    ecx
             FF 15 54 5A B9 00                  call    ds:shutdown
             88 9F 80 00 00 00                  mov     [edi+80h], bl
             C7 86 BC 30 00 00 01 00 00 00      mov     dword ptr [esi+30BCh], 1
             EB 11                              jmp     short loc_5F3972
        */

        private static readonly Pattern inGameOffsetPattern =
            new Pattern(@"\x8B\x0F\x6A\x01\x51\xFF\x15\x00\x00\x00\x00\x88\x9F\x00\x00\x00\x00\xC7\x86\x00\x00\x00\x00\x00\x00\x00\x00\xEB\x11",
                "xxxxxxx????xx????xx????????xx");


        public long AreaChangeCount { get; private set; }
        public long Base { get; private set; }
        public string ExeName { get; private set; }
        public long FileRoot { get; private set; }
        public int IgsDelta { get; private set; }
        public int IgsOffset { get; private set; }
        //public int InGameOffset { get; private set; }

        public int IgsOffsetDelta => IgsOffset + IgsDelta;
        public long areaCC_pointer;
        public void DoPatternScans(Memory m)
        {
            long[] array = m.FindPatterns(basePtrPattern, fileRootPattern, areaChangePattern);
            Base = m.ReadInt(m.AddressOfProcess + array[0] + 0x1A) + array[0] + 0x1E;
            System.Console.WriteLine("Base Address: " + (Base + m.AddressOfProcess).ToString("x8"));

            FileRoot = m.ReadInt(m.AddressOfProcess + array[1] + 0x3) + array[1] + 0x7;
            System.Console.WriteLine("FileRoot Pointer: " + (FileRoot + m.AddressOfProcess).ToString("x8"));

            AreaChangeCount = m.ReadInt(m.AddressOfProcess + array[2] + 0x25) + array[2] + 0x29;
            System.Console.WriteLine("AreaChangeCount Pointer: " + (AreaChangeCount + m.AddressOfProcess).ToString("x8"));
        }
    }
}