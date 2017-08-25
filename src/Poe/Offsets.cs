using PoeHUD.Framework;
using PoeHUD.Models;
using System.IO;

namespace PoeHUD.Poe
{
    public class Offsets
    {
        public static Offsets Regular = new Offsets { IgsOffset = 0, IgsDelta = 0, ExeName = "PathOfExile" };
        public static Offsets Steam = new Offsets { IgsOffset = 0x1C, IgsDelta = -0x4, ExeName = "PathOfExileSteam" };
        /* offsets from some older steam version:
		 	Base = 8841968;
			FileRoot = 8820476;
			MaphackFunc = 4939552;
			ZoomHackFunc = 2225383;
			AreaChangeCount = 8730996;
			Fullbright1 = 7639804;
			Fullbright2 = 8217084;
		*/

        /* maphack function
        FF D0                 - call eax
        8B 46 48              - mov eax,[esi+48]
        3B 46 4C              - cmp eax,[esi+4C]
        74 3A                 - je PathOfExile.exe+4D2FFC
        BA 04000000           - mov edx,00000004
        D9 00                 - fld dword ptr [eax]          //1 replace to  fld1  ( D9E8 )
        8B 0C 24              - mov ecx,[esp]
        D9 19                 - fstp dword ptr [ecx]
        8B 0C 24              - mov ecx,[esp]
        03 CA                 - add ecx,edx
        89 0C 24              - mov [esp],ecx
        D9 00                 - fld dword ptr [eax]          //2 (prev+0xC) replace to  fld1  ( D9E8 )
        D9 19                 - fstp dword ptr [ecx]
        8B 0C 24              - mov ecx,[esp]
        03 CA                 - add ecx,edx
        89 0C 24              - mov [esp],ecx
        D9 00                 - fld dword ptr [eax]          //3 (prev+0xC) replace to  fld1  ( D9E8 )
        D9 19                 - fstp dword ptr [ecx]
        8B 0C 24              - mov ecx,[esp]
        03 CA                 - add ecx,edx
        89 0C 24              - mov [esp],ecx
        D9 00                 - fld dword ptr [eax]         //4 (prev+0xC) replace to  fld1  ( D9E8 )
        */
        /* fullbright base (function begin here)
        55                    - push ebp
        8B EC                 - mov ebp,esp
        83 E4 F8              - and esp,-08
        6A FF                 - push -01
        68 8661EC00           - push PathOfExile.std::_Mutex::_Mutex+72D2C
        64 A1 00000000        - mov eax,fs:[00000000]
        50                    - push eax
        64 89 25 00000000     - mov fs:[00000000],esp
        81 EC A0000000        - sub esp,000000A0
        53                    - push ebx
        8B 5D 10              - mov ebx,[ebp+10]
        C7 44 24 44 00000000  - mov [esp+44],00000000
         *
         * ......
       F3 0F59 44 24 20      - mulss xmm0,[esp+20]
       F3 0F59 25 E027FB00   - mulss xmm4,[PathOfExile.std::_Mutex::_Mutex+15F386]  -//fullbright1 <- const 1300
       83 EC 0C              - sub esp,0C
        ....
         *
       F3 0F10 4C 24 54      - movss xmm1,[esp+54]
       F3 0F5C 0D D8680401   - subss xmm1,[PathOfExile.std::_Mutex::_Mutex+1F347E]  -//fullbright2 <- const 300
       F3 0F58 8C 24 AC000000  - addss xmm1,[esp+000000AC]
       F3 0F11 54 24 64      - movss [esp+64],xmm2

        */

        /*
			64 A1 00 00 00 00          mov     eax, large fs:0
			6A FF                      push    0FFFFFFFFh
			68 90 51 4D 01             push    offset SEH_10D6970
			50                         push    eax
			64 89 25 00 00 00 00       mov     large fs:0, esp
			A1 EC 6A 70 01             mov     eax, off_1706AEC ; <--- BP IS HERE
			81 EC C8 00 00 00          sub     esp, 0C8h
			53                         push    ebx
			55                         push    ebp
			33 DB                      xor     ebx, ebx
			56                         push    esi
			57                         push    edi
			3B C3                      cmp     eax, ebx
		 */

        private static readonly Pattern basePtrPattern = new Pattern(new byte[]
        {
            0x50,
            0x64, 0x89, 0x25, 0x00, 0x00, 0x00, 0x00,
            0x83, 0xEC, 0x08,
            0xA1, 0x00, 0x00, 0x00, 0x00, // BasePtr
            0x56, 0x85, 0xC0
        }, "xxxxxxxxxxxx????xxx");

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
            Base = m.ReadInt(m.AddressOfProcess + array[0] + 0xC) - m.AddressOfProcess;
            System.Console.WriteLine("Base Address: " + (Base + m.AddressOfProcess).ToString("x8"));
            FileRoot = m.ReadInt(m.AddressOfProcess + array[1] + 0x7) - m.AddressOfProcess;
            System.Console.WriteLine("FileRoot Pointer: " + (FileRoot + m.AddressOfProcess).ToString("x8"));
            AreaChangeCount = m.ReadInt(m.AddressOfProcess + array[2] + 0x12) - m.AddressOfProcess;
        }
    }
}