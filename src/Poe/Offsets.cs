using PoeHUD.Framework;
using PoeHUD.Models;
using System.IO;

namespace PoeHUD.Poe
{
    public class Offsets
    {
        public static Offsets Regular = new Offsets { IgsOffset = 0, IgsDelta = 0, ExeName = "PathOfExile" };
        public static Offsets Steam = new Offsets { IgsOffset = 0x18, IgsDelta = 0, ExeName = "PathOfExileSteam" };

        /*
            00EBA2D5 | 8B 35 04 27 AE 01                    | mov esi,dword ptr ds:[1AE2704] <-----BasePtr                |
            00EBA2DB | A3 04 27 AE 01                       | mov dword ptr ds:[1AE2704],eax                              |
            00EBA2E0 | 85 F6                                | test esi,esi                                                |
            00EBA2E2 | 74 15                                | je pathofexile.EBA2F9                                       |
            00EBA2E4 | 8B CE                                | mov ecx,esi                                                 |
            00EBA2E6 | E8 75 CA 00 00                       | call pathofexile.EC6D60                                     |
            00EBA2EB | 68 40 05 00 00                       | push 540                                                    |
            00EBA2F0 | 56                                   | push esi                                                    |
            00EBA2F1 | E8 D0 F6 69 00                       | call pathofexile.15599C6                                    |
            00EBA2F6 | 83 C4 08                             | add esp,8                                                   |
            00EBA2F9 | C6 05 EF CE 95 01 01                 | mov byte ptr ds:[195CEEF],1                                 |

            8B 35 ?? ?? ?? ?? A3 ?? ?? ?? ?? 85 F6 74 15 8B CE E8 ?? ?? ?? ?? 68 ?? ?? ?? ?? 56 E8 ?? ?? ?? ?? 83 c4 08 C6
        */

        private static readonly Pattern basePtrPattern = new Pattern(new byte[]
        {
            0x8B, 0x35, 0x00, 0x00, 0x00, 0x00,
            0xA3, 0x00, 0x00, 0x00, 0x00,
            0x85, 0xF6,
            0x74, 0x15,
            0x8B, 0xCE,
            0xE8, 0x00, 0x00, 0x00, 0x00,
            0x68, 0x00, 0x00, 0x00, 0x00,
            0x56,
            0xE8, 0x00, 0x00, 0x00, 0x00,
            0x83, 0xc4, 0x08,
            0xC6
        }, "xx????x????xxxxxxx????x????xx????xxxx");

        /*
        private static readonly Pattern fileRootPattern = new Pattern(new byte[]
        {
            0xc7, 0x45, 0x00, 0x00, 0x00, 0x00, 0x00, 0x6a, 0x00, 0xc7, 0x05
        }, "xx?xxxxxxxx");
        */
        private static readonly Pattern fileRootPattern = new Pattern(new byte[]
        {
            0x51,
            0x8D, 0x45, 0xF0,
            0xC7, 0x45, 0xEC, 0x00, 0x00, 0x00, 0x00,
            0x50,
            0xC7, 0x45, 0xF0, 0x00, 0x00, 0x00, 0x00,
            0xE8, 0x00, 0x00, 0x00, 0x00,
            0x6A, 0x00
        }, "xxxxxxx????xxxxxxxxx????xx");
        /*
            00F37640 | 55                                   | push ebp                                                    |
            00F37641 | 8B EC                                | mov ebp,esp                                                 |
            00F37643 | 6A FF                                | push FFFFFFFF                                               |
            00F37645 | 68 7B 20 6F 01                       | push pathofexile.16F207B                                    |
            00F3764A | 64 A1 00 00 00 00                    | mov eax,dword ptr fs:[0]                                    |
            00F37650 | 50                                   | push eax                                                    |
            00F37651 | 64 89 25 00 00 00 00                 | mov dword ptr fs:[0],esp                                    |
            00F37658 | 83 EC 0C                             | sub esp,C                                                   |
            00F3765B | 51                                   | push ecx                                                    |
            00F3765C | 8D 45 F0                             | lea eax,dword ptr ss:[ebp-10]                               |
            00F3765F | C7 45 EC ?? ?? ?? ??                 | mov dword ptr ss:[ebp-14],<pathofexile.FileRootForRealz>    |
            00F37666 | 50                                   | push eax                                                    |
            00F37667 | C7 45 F0 00 00 00 00                 | mov dword ptr ss:[ebp-10],0                                 |
            00F3766E | E8 ?? ?? ?? ??                       | call pathofexile.F38300                                     |
            00F37673 | 6A 00                                | push 0                                                      |
            00F37675 | C7 45 FC 00 00 00 00                 | mov dword ptr ss:[ebp-4],0                                  |
            00F3767C | 6A 00                                | push 0                                                      |
            00F3767E | C7 05 10 47 B9 01 00 00 00 00        | mov dword ptr ds:[1B94710],0                                |
            00F37688 | C7 05 14 47 B9 01 00 00 00 00        | mov dword ptr ds:[1B94714],0                                |
            00F37692 | E8 79 67 D8 FF                       | call pathofexile.CBDE10                                     |
            00F37697 | A3 10 47 B9 01                       | mov dword ptr ds:[1B94710],eax                              |
            00F3769C | 68 20 47 B9 01                       | push pathofexile.1B94720                                    |
            00F376A1 | C7 05 18 47 B9 01 00 00 00 00        | mov dword ptr ds:[1B94718],0                                |
            00F376AB | C6 05 1C 47 B9 01 00                 | mov byte ptr ds:[1B9471C],0                                 |
            00F376B2 | FF 15 3C 31 74 01                    | call dword ptr ds:[<&RtlInitializeCriticalSection>]         |
            00F376B8 | C6 45 FC 02                          | mov byte ptr ss:[ebp-4],2                                   |
            00F376BC | F3 0F 10 05 48 80 93 01              | movss xmm0,dword ptr ds:[1938048]                           |
            00F376C4 | F3 0F 5E 05 F0 46 B9 01              | divss xmm0,dword ptr ds:[<FileRootForRealz>]                |
            00F376CC | E8 CF 28 D6 FF                       | call pathofexile.C99FA0                                     |
            00F376D1 | E8 5A 89 6F 00                       | call pathofexile.1630030                                    |
            00F376D6 | 50                                   | push eax                                                    |
            00F376D7 | E8 C4 08 00 00                       | call pathofexile.F37FA0                                     |
            00F376DC | B9 F0 46 B9 01                       | mov ecx,<pathofexile.FileRootForRealz>                      |
            00F376E1 | E8 2A 06 00 00                       | call pathofexile.F37D10                                     |
            00F376E6 | 8B 4D F4                             | mov ecx,dword ptr ss:[ebp-C]                                | ecx:DbgUiRemoteBreakin
            00F376E9 | B8 F0 46 B9 01                       | mov eax,<pathofexile.FileRootForRealz>                      |
            00F376EE | C6 05 18 44 A1 01 01                 | mov byte ptr ds:[1A14418],1                                 |
            00F376F5 | 64 89 0D 00 00 00 00                 | mov dword ptr fs:[0],ecx                                    |
            00F376FC | 8B E5                                | mov esp,ebp                                                 |
            00F376FE | 5D                                   | pop ebp                                                     |
            00F376FF | C3                                   | ret                                                         |
        */

        private static readonly Pattern areaChangePattern = new Pattern(new byte[]
            {
                0x8B, 0x88, 0x00, 0x00, 0x00, 0x00, 0xE8, 0x00,
                0x00, 0x00, 0x00, 0xE8, 0x00, 0x00, 0x00, 0x00,
                0xFF, 0x05
            }, "xx????x????x????xx");

        /*
            005ADF8E  |. C745 FC FFFFFF>MOV DWORD PTR SS:[EBP-4],-1
            005ADF95  |. 83C4 04        ADD ESP,4
            005ADF98  |. 8B83 60180000  MOV EAX,DWORD PTR DS:[EBX+1860]
            005ADF9E  |. 6A 00          PUSH 0
            --- Pattern start
            005ADFA0  |. 8B88 F80A0000  MOV ECX,DWORD PTR DS:[EAX+AF8]
            005ADFA6  |. E8 C5263F00    CALL PathOfEx.009A0670
            005ADFAB  |. E8 007E0400    CALL PathOfEx.005F5DB0
            005ADFB0  |. FF05 6891DC00  <---AreaChangeCountPtr
            --- Pattern end
            005ADFB6  |. 8BC8           MOV ECX,EAX
            005ADFB8  |. E8 037D0400    CALL PathOfEx.005F5CC0
        */

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
        public int AreaChangeCount { get; private set; }
        public int Base { get; private set; }
        public string ExeName { get; private set; }
        public int FileRoot { get; private set; }
        public int IgsDelta { get; private set; }
        public int IgsOffset { get; private set; }
        //public int InGameOffset { get; private set; }

        public int IgsOffsetDelta => IgsOffset + IgsDelta;

        public void DoPatternScans(Memory m)
        {
            int[] array = m.FindPatterns(basePtrPattern, fileRootPattern, areaChangePattern);
            Base = m.ReadInt(m.AddressOfProcess + array[0] + 0x2) - m.AddressOfProcess;
            System.Console.WriteLine("Base Address: " + (Base + m.AddressOfProcess).ToString("x8"));
            FileRoot = m.ReadInt(m.AddressOfProcess + array[1] + 0x7) - m.AddressOfProcess;
            System.Console.WriteLine("FileRoot Pointer: " + (FileRoot + m.AddressOfProcess).ToString("x8"));
            AreaChangeCount = m.ReadInt(m.AddressOfProcess + array[2] + 0x12) - m.AddressOfProcess;
            System.Console.WriteLine("AreaChangeCount Pointer: " + (AreaChangeCount + m.AddressOfProcess).ToString("x8"));
        }
    }
}