using PoeHUD.Framework;
using PoeHUD.Models;


namespace PoeHUD.Poe
{

    public class Offsets
    {
        public static Offsets Regular = new Offsets { IgsOffset = 0, IgsDelta = 0, ExeName = "PathOfExile_x64" };
        public static Offsets Korean = new Offsets { IgsOffset = 0, IgsDelta = 0, ExeName = "Pathofexile_x64_KG" };
        public static Offsets Steam = new Offsets { IgsOffset = 0x28, IgsDelta = 0, ExeName = "PathOfExile_x64Steam" };

        /*
        00007FF7006C7891  | 90                                 | nop                                        |
        00007FF7006C7892  | 48 8B 1D EF 93 06 01               | mov rbx,qword ptr ds:[7FF701730C88]        |
        00007FF7006C7899  | 48 89 05 E8 93 06 01               | mov qword ptr ds:[7FF701730C88],rax        |
        00007FF7006C78A0  | 48 85 DB                           | test rbx,rbx                               |
        00007FF7006C78A3  | 74 15                              | je pathofexile_x64.7FF7006C78BA            |
        00007FF7006C78A5  | 48 8B CB                           | mov rcx,rbx                                |
        00007FF7006C78A8  | E8 53 D7 00 00                     | call pathofexile_x64.7FF7006D5000          |
        */
        //    90 48 03 D8 48 8B 03 48 85 c0 75 ?? 48 8b 1d ?? ?? ?? ?? 48 8b 05 ?? ?? ?? ?? 48 85 c0 74 ?? 66 90

        private static readonly Pattern basePtrPattern = new Pattern(new byte[]
        {
			0x90,
			0x48, 0x03, 0xD8,
			0x48, 0x8B, 0x03,
			0x48, 0x85, 0xC0,
			0x75, 0x00,
			0x48, 0x8B, 0x1D, 0x00, 0x00, 0x00, 0x00,
			0x48, 0x8B, 0x05, 0x00, 0x00, 0x00, 0x00,
			0x48, 0x85, 0xC0,
			0X74, 0x00,
			0x66, 0x90
		}, "xxxxxxxxxxx?xxx????xxx????xxxx?xx");

		/* FileRoot Pointer
		00007FF6C47EED01  | 48 8D 0D A8 23 7F 00               | lea rcx,qword ptr ds:[7FF6C4FE10B0]        | <--FileRootPtr
		00007FF6C47EED08  | E8 E3 5C 56 FF                     | call pathofexile_x64.7FF6C3D549F0          |
		00007FF6C47EED0D  | 48 8B 3D A4 23 7F 00               | mov rdi,qword ptr ds:[7FF6C4FE10B8]        |
		00007FF6C47EED14  | 48 8B 1F                           | mov rbx,qword ptr ds:[rdi]                 |
		00007FF6C47EED17  | 48 3B DF                           | cmp rbx,rdi                                |
		00007FF6C47EED1A  | 0F 84 26 01 00 00                  | je pathofexile_x64.7FF6C47EEE46            |
        */
		// 3.3.x
		//    48 8D 0D ?? ?? ?? ?? E8 ?? ?? ?? ?? 48 8B 3D ?? ?? ?? ?? 48 8B 1F

		private static readonly Pattern fileRootPattern = new Pattern(new byte[]
        {
            0x65, 0x48, 0x8b, 0x04, 0x25, 0x58, 0x00, 0x00, 0x00,
            0x48, 0x8b, 0x08,
            0x48, 0x8d, 0x3d, 0x1f, 0xe8, 0x3e, 0x01,
            0x8b, 0x04, 0x0e
        }, "x?x???????x??x?????x??");

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
        // 3.0.3b
        //     48 83 EC 58 4C 8B C1 41 B9 01 00 00 00 48 8B 49 10
        // 3.5.0: this pattern matched 4 results but they all are pointing towards same pointer i.e. counter.
        // 41 8B C2 F0 41 0F C1 40 54 8B 05 ?? ?? ?? ?? 41 89 40 50 48 8B 49 10 49 89 49 08 48 85 C9

        private static readonly Pattern areaChangePattern = new Pattern(new byte[]
        {
            0x74, 0x11,
            0x41, 0x8b, 0xc7,
            0xf0,
            0x0f, 0xc1, 0x01,
            0x8b, 0x05, 0x01, 0x7d, 0x61, 0x01,
            0x41, 0x89, 0x40, 0x38,
            0x49, 0x8b, 0x55, 0x08,
            0x48, 0x85, 0xd2
        }, "x??x?xxx?x??????x???x???x?");

        // 48 39 2D ?? ?? ?? ?? 0F 85 28 01 00 00 C7 40 08 80 00 00 00 8B CD
        private static readonly Pattern GameStatePattern = new Pattern(new byte[]
        {
            0x48, 0x89, 0x4c, 0x24, 0x08,
            0x55,
            0x56,
            0x57,
            0x48, 0x83, 0xec, 0x50,
            0x48, 0xc7, 0x44, 0x24, 0x20, 0xfe, 0xff, 0xff, 0xff,
            0x48, 0x89, 0x9c, 0x24, 0x80, 0x00, 0x00, 0x00,
            0x48, 0x8b, 0xf9,
            0x33, 0xed,
            0x48, 0x39, 0x2d, 0xff, 0x64, 0x09, 0x02

        }, "?x???????x???xx???????x???????x?x??x?????");

        /*
        PathOfExile_x64.exe+118FD9 - 4C 8B 35 48255B01     - mov r14,[PathOfExile_x64.exe+16CB528] { [C6151734A0] }<<here
        PathOfExile_x64.exe+118FE0 - 4D 85 F6              - test r14,r14
        PathOfExile_x64.exe+118FE3 - 0F94 C0               - sete al
        PathOfExile_x64.exe+118FE6 - 84 C0                 - test al,al
        */

        public long AreaChangeCount { get; private set; }
        public long Base { get; private set; }
        public string ExeName { get; private set; }
        public long FileRoot { get; private set; }
        public int IgsDelta { get; private set; }
        public int IgsOffset { get; private set; }
        public int IgsOffsetDelta => IgsOffset + IgsDelta;
        public long GameStateOffset { get; private set; }

        public void DoPatternScans(Memory m)
        {
            long[] array = m.FindPatterns(fileRootPattern, areaChangePattern, GameStatePattern);

            var fileRootOffset = 15;
            FileRoot = m.ReadInt(m.AddressOfProcess + array[0] + fileRootOffset) + array[0] + fileRootOffset + 4;
            System.Console.WriteLine("FileRoot Pointer: " + (FileRoot + m.AddressOfProcess).ToString("x8"));

            var areaChangeCountOffset = 11;

            AreaChangeCount = m.ReadInt(m.AddressOfProcess + array[1] + areaChangeCountOffset) + array[1] + areaChangeCountOffset + 4;
			System.Console.WriteLine("AreaChangeCount: " + m.ReadInt(AreaChangeCount + m.AddressOfProcess).ToString());

            var gameStateOffset = 37;
            GameStateOffset = m.ReadInt(m.AddressOfProcess + array[2] + gameStateOffset) + array[2] + gameStateOffset + 4;
            System.Console.WriteLine("Game State Offset:" + (GameStateOffset + m.AddressOfProcess).ToString("x8"));
        }
    }
}
