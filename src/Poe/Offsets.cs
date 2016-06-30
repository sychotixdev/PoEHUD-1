using PoeHUD.Framework;
using PoeHUD.Models;
using System.IO;

namespace PoeHUD.Poe
{
    public class Offsets
    {
        public static Offsets Regular = new Offsets { IgsOffset = 0, IgsDelta = 0, ExeName = "PathOfExile", AreaChangeCount = 0xA3C118 };
        public static Offsets Steam = new Offsets { IgsOffset = 0x1C, IgsDelta = 0x4, ExeName = "PathOfExileSteam", AreaChangeCount = 0xA47118 };
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
            0x50, 0x64, 0x89, 0x25, 0x00, 0x00, 0x00, 0x00,
            0x81, 0xEC, 0xB0, 0x00, 0x00, 0x00, 0xA1, 0x00,
            0x00, 0x00, 0x00, 0x85, 0xC0, 0x0F, 0x95, 0xC1,
            0x84, 0xC9, 0x56, 0x0F, 0x94, 0xC1, 0x84, 0xC9
        }, "xxxxxxxxxxxxxxx????xxxxxxxxxxxxx");

        /*
        private static readonly Pattern fileRootPattern = new Pattern(new byte[]
        {
            0xc7, 0x45, 0x00, 0x00, 0x00, 0x00, 0x00, 0x6a, 0x00, 0xc7, 0x05
        }, "xx?xxxxxxxx");
        */
        private static readonly Pattern fileRootPattern = new Pattern(new byte[]
                {
                    0xFC, 0xFF, 0xFF, 0xFF, 0xFF, 0xE8, 0x00, 0x00,
                    0x00, 0x00, 0x83, 0xC4, 0x08, 0xFF, 0xB7, 0x00,
                    0x00, 0x00, 0x00, 0xB9, 0x00, 0x00, 0x00, 0x00,
                    0xE8, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x15
                }, "xxxxxx????xxxxx????x????x????xx");
        /*
        003F1BF4   E8 4A944E00      CALL PathOfEx.008DB043
        003F1BF9   68 0867D400      PUSH PathOfEx.00D46708
        003F1BFE   C745 FC FFFFFFFF MOV DWORD PTR SS:[EBP-4],-1
        003F1C05   E8 C4954E00      CALL PathOfEx.008DB1CE
        003F1C0A   83C4 08          ADD ESP,8
        003F1C0D   FFB7 2C180000    PUSH DWORD PTR DS:[EDI+182C]
        003F1C13   B9 1067D400      MOV ECX,PathOfEx.00D46710      <---PointerToFileRoot
        003F1C18   E8 D33B0400      CALL PathOfEx.004357F0
        003F1C1D   FF15 C8839D00    CALL DWORD PTR DS:[<&USER32.ReleaseCaptu>; USER32.ReleaseCapture
        */

        private static readonly Pattern areaChangePattern = new Pattern(new byte[]
            {
                0x18, 0x33, 0xac, 0x01, 0xb0, 0x00, 0x00, 0x00,
                0x00, 0x33, 0xac, 0x01
            }, "xxxxx????xxx");

        /*
            PathOfExile.exe+A420EB - 01 B0 9FAE0110        - add [eax+1001AE9F],esi
            PathOfExile.exe+A420F1 - A2 AE01C89B           - mov byte ptr [9BC801AE],al
            PathOfExile.exe+A420F6 - AE                    - scasb 
            PathOfExile.exe+A420F7 - 01 10                 - add [eax],edx
            PathOfExile.exe+A420F9 - 00 AC 01 4832AC01     - add [ecx+eax+PathOfExile.exe+8C3248],ch
            PathOfExile.exe+A42100 - 18 33                 - sbb [ebx],dh
            PathOfExile.exe+A42102 - AC                    - lodsb 
            PathOfExile.exe+A42103 - 01 B0 32AC0180        - add [eax-7FFE53CE],esi
            PathOfExile.exe+A42109 - 33 AC 01 E833AC01     - xor ebp,[ecx+eax+PathOfExile.exe+8C33E8]
            PathOfExile.exe+A42118 <-------------AreaChangeCount
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
        public int GarenaTWDelta = 0;
        //public int InGameOffset { get; private set; }

        public int IgsOffsetDelta => IgsOffset + IgsDelta;

        public void DoPatternScans(Memory m)
        {
            if (System.IO.File.Exists("config/GarenaTWDelta.txt"))
            {
                using (StreamReader reader = new StreamReader("config/GarenaTWDelta.txt"))
                {
                    string strDelta = reader.ReadLine();
                    // try to convert the contents of the first line to an int
                    if (!int.TryParse(strDelta, out GarenaTWDelta))
                        System.Console.WriteLine("Failed to convert the contents of config/GarenaTWDelta.txt to an int");
                }
            }
            int[] array = m.FindPatterns(basePtrPattern, fileRootPattern);
            Base = m.ReadInt(m.AddressOfProcess + array[0] + 0x0F) - m.AddressOfProcess;
            System.Console.WriteLine("Base Address: " + (Base + m.AddressOfProcess).ToString("x8"));
            FileRoot = m.ReadInt(m.AddressOfProcess + array[1] + 0x14) - m.AddressOfProcess;
        }
    }
}