using PoeHUD.Framework;
using PoeHUD.Models;
using System.IO;


namespace PoeHUD.Poe
{
    public class Offsets
    {
        public static Offsets Regular = new Offsets { IgsOffset = 0, IgsDelta = 0, ExeName = "PathOfExile_x64" };
        public static Offsets Steam = new Offsets { IgsOffset = 0x1C, IgsDelta = -0x4, ExeName = "PathOfExileSteam" };
        
        /*
	    PathOfExile_x64.exe+FA5F38 - 40 5F                 - pop rdi
        PathOfExile_x64.exe+FA5F3A - 71 7D                 - jno PathOfExile_x64.exe+FA5FB9
        PathOfExile_x64.exe+FA5F3C - F6 7F 00              - idiv byte ptr [rdi+00]
        PathOfExile_x64.exe+FA5F3F - 00 D0                 - add al,dl
        PathOfExile_x64.exe+FA5F41 - 84 35 7D F6 7F 00        - test [7FF67DF155C4],dh { 2112968132 }
        PathOfExile_x64.exe+FA5F47 - 00 E0                 - add al,ah            ;<< Starts from E0
        PathOfExile_x64.exe+FA5F49 - D9 47 3C              - fld dword ptr [rdi+3C]
        PathOfExile_x64.exe+FA5F4C - 60                    - pushad (invalid) 
        PathOfExile_x64.exe+FA5F4D - 00 00                 - add [rax],al
        PathOfExile_x64.exe+FA5F4F - 00 20                 - add [rax],ah

		 */

        private static readonly Pattern basePtrPattern = new Pattern(new byte[]
        {
            0x40, 0x5F,
            0x71, 0x7d,
            0xF6, 0x7F, 0x00,
            0x00, 0xD0,
            0x84, 0x35, 0x7D, 0xF6, 0x7F, 0x00,
            0x00, 0x00,
            0x00, 0x00, 0x00
        }, "xxxxxxxxxxxxxxxx????");

        /*
        private static readonly Pattern fileRootPattern = new Pattern(new byte[]
        {
            0xc7, 0x45, 0x00, 0x00, 0x00, 0x00, 0x00, 0x6a, 0x00, 0xc7, 0x05
        }, "xx?xxxxxxxx");
        */
        private static readonly Pattern fileRootPattern = new Pattern(new byte[]
        {
            0xB7, 0x00, 0x00, 0x00, 0x00, 0xB9, 0x00, 0x00,
            0x00, 0x00, 0xE8, 0x00, 0x00, 0x00, 0x00, 0xFF,
            0x15
        }, "x????x????x????xx");
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



        /*  areaChangePattern

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
            0x90,
            0x48, 0x8B, 0x86, 0x00,  0x00, 0x00, 0x00,
            0x33, 0xd2,
            0x48, 0x8B, 0x88, 0x00, 0x00, 0x00, 0x00,
            0xE8, 0x00, 0x00, 0x00, 0x00,
            0xE8, 0x00, 0x00, 0x00, 0x00,
            0xFF, 0x05, 0x00, 0x00, 0x00, 0x00,
            0x48, 0x8B, 0xC8,
        }, "xxxx????xxxxx????x????x????xx????xxx");


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
        public int GarenaTWDelta = 0;
        //public int InGameOffset { get; private set; }

        public int IgsOffsetDelta => IgsOffset + IgsDelta;

     

        //public long basePointer;
        public long areaCC_pointer;
        public void DoPatternScans(Memory m)
        {
            /*
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
            
            long[] array = m.FindPatterns(basePtrPattern, fileRootPattern, areaChangePattern);
            Base = m.ReadLong(m.AddressOfProcess + array[0] + 0x10) - m.AddressOfProcess;

            System.Console.WriteLine("Base Address: " + (Base + m.AddressOfProcess).ToString("x8"));
            FileRoot = m.ReadLong(m.AddressOfProcess + array[1] + 0x6) - m.AddressOfProcess;
            System.Console.WriteLine("FileRoot Pointer: " + (FileRoot + m.AddressOfProcess).ToString("x8"));
            AreaChangeCount = m.ReadLong(m.AddressOfProcess + array[2] + 0x30) - m.AddressOfProcess;
            */

            Base = 0xfa9708;
            AreaChangeCount = 0xFA27CC;
            FileRoot = 0x1156120;
        }
    }
}