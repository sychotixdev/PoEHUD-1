using PoeHUD.Framework;
using PoeHUD.Models;


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
            PathOfExile_x64.exe+3B3180 - 48 8B C4              - mov rax,rsp
            PathOfExile_x64.exe+3B3183 - 48 89 48 08           - mov [rax+08],rcx
            PathOfExile_x64.exe+3B3187 - 55                    - push rbp
            PathOfExile_x64.exe+3B3188 - 41 56                 - push r14
            PathOfExile_x64.exe+3B318A - 41 57                 - push r15
            PathOfExile_x64.exe+3B318C - 48 8D A8 48FFFFFF     - lea rbp,[rax-000000B8]
            PathOfExile_x64.exe+3B3193 - 48 81 EC A0010000     - sub rsp,000001A0 { 416 }
            PathOfExile_x64.exe+3B319A - 48 C7 44 24 40 FEFFFFFF - mov [rsp+40],FFFFFFFE { -2 }
            PathOfExile_x64.exe+3B31A3 - 48 89 58 10           - mov [rax+10],rbx
            PathOfExile_x64.exe+3B31A7 - 48 89 70 18           - mov [rax+18],rsi
            PathOfExile_x64.exe+3B31AB - 48 89 78 20           - mov [rax+20],rdi
            PathOfExile_x64.exe+3B31AF - 33 D2                 - xor edx,edx
            PathOfExile_x64.exe+3B31B1 - 48 8D 0D C864DE00     - lea rcx,[PathOfExile_x64.exe+1199680] { [1.00] }
            PathOfExile_x64.exe+3B31B8 - E8 63060000           - call PathOfExile_x64.exe+3B3820
            PathOfExile_x64.exe+3B31BD - 90                    - nop
            PathOfExile_x64.exe+3B31BE - 48 8B 35 C364DE00     - mov rsi,[PathOfExile_x64.exe+1199688] { [241FA6992E0] }
            PathOfExile_x64.exe+3B31C5 - 48 8B 1E              - mov rbx,[rsi]
            PathOfExile_x64.exe+3B31C8 - 45 33 F6              - xor r14d,r14d
            PathOfExile_x64.exe+3B31CB - 4C 8D 3D 3EF08A00     - lea r15,[PathOfExile_x64.exe+C62210] { [7FF62940A460] }
            PathOfExile_x64.exe+3B31D2 - 48 89 9D C0000000     - mov [rbp+000000C0],rbx
            PathOfExile_x64.exe+3B31D9 - 48 3B DE              - cmp rbx,rsi
        */

        private static readonly Pattern fileRootPattern = new Pattern(new byte[]
        {
            0x48, 0x8D, 0x0D, 0x00, 0x00, 0x00, 0x00, 0xE8, 0x63, 0x06, 0x00, 0x00, 0x90
        }, "xxx????xxxxxx");


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
