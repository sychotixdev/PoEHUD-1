using PoeHUD.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Runtime.InteropServices;
using PoeHUD.Controllers;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class Prophecy : RemoteMemoryObject
    {
        public int Index { get; internal set; }

        private string id;
        public string Id => id != null ? id :
            id = M.ReadStringU(M.ReadLong(Address), 255);

        private string predictionText;
        public string PredictionText => predictionText != null ? predictionText :
            predictionText = M.ReadStringU(M.ReadLong(Address + 0x8), 255);

        public int ProphecyId => M.ReadInt(Address + 0x10);

        private string name;
        public string Name => name != null ? name :
            name = M.ReadStringU(M.ReadLong(Address + 0x14));

        private string flavourText;
        public string FlavourText => flavourText != null ? flavourText :
            flavourText = M.ReadStringU(M.ReadLong(Address + 0x1c), 255);

        public long ProphecyChainPtr => M.ReadLong(Address + 0x44);//TODO ProphecyChainDat
        public int ProphecyChainPosition => M.ReadInt(Address + 0x4c);//TODO ProphecyChainDat

        public bool IsEnabled => M.ReadByte(Address + 0x50) > 0;

        public int SealCost => M.ReadInt(Address + 0x51);

        public override string ToString()
        {
            return $"{Name}, {PredictionText}";
        }
        
    }
}
