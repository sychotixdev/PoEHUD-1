using PoeHUD.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Runtime.InteropServices;
using PoeHUD.Controllers;
using PoeHUD.Poe.FilesInMemory;
using PoeHUD.Poe.RemoteMemoryObjects;

namespace PoeHUD.Poe.Components
{
    [StructLayout(LayoutKind.Explicit)]
    public struct ProphecyStruct
    {
        [FieldOffset(0x8)]
        public long OwnerPtr;
        [FieldOffset(0x20)]
        public long ProphecyDatPtr;
    }

    public class Prophecy : StructuredRemoteMemoryObject<ProphecyStruct>, Component
    {
        public Entity Owner => GetObject<Entity>(Structure.OwnerPtr);

        public ProphecyDat DatProphecy => GameController.Instance.Files.Prophecies.GetByAddress(Structure.ProphecyDatPtr);
    }
}
