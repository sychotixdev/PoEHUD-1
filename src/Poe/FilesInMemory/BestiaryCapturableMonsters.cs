using PoeHUD.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Runtime.InteropServices;
using PoeHUD.Controllers;
using PoeHUD.Poe.FilesInMemory.Base;
using PoeHUD.Poe.RemoteMemoryObjects;

namespace PoeHUD.Poe.FilesInMemory
{
    public class BestiaryCapturableMonsters : UniversalFileWrapper<BestiaryCapturableMonster>
    {
        public BestiaryCapturableMonsters(Memory m, long address) : base(m, address)
        {
        }

        private int IdCounter;
        protected override void EntryAdded(long addr, BestiaryCapturableMonster entry)
        {
            entry.Id = IdCounter++;
        }
    }
}