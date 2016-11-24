using PoeHUD.Framework.Enums;
using PoeHUD.Models;
using PoeHUD.Poe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace PoeHUD.Framework
{
    public class Memory : IDisposable
    {
        public readonly long AddressOfProcess;
        private readonly Dictionary<string, int> modules;
        private bool closed;
        public Offsets offsets;
        private IntPtr procHandle;

        public Memory(Offsets offs, int pId)
        {
            try
            {
                offsets = offs;
                Process = Process.GetProcessById(pId);
                AddressOfProcess = Process.MainModule.BaseAddress.ToInt64();
                procHandle = WinApi.OpenProcess(Process, ProcessAccessFlags.All);
                modules = new Dictionary<string, int>();
            }
            catch (Win32Exception ex)
            {
                throw new Exception("You should run program as an administrator", ex);
            }
        }

        public Process Process { get; }

        public void Dispose()
        {
            Close();
        }

        ~Memory()
        {
            Close();
        }

        public int GetModule(string name)
        {
            if (modules.ContainsKey(name))
            {
                return modules[name];
            }
            int num = Process.Modules.Cast<ProcessModule>().First(m => m.ModuleName == name).BaseAddress.ToInt32();
            modules.Add(name, num);
            return num;
        }

        public bool IsInvalid()
        {
            return Process.HasExited || closed;
        }

        public int ReadInt(int addr)
        {
            return BitConverter.ToInt32(ReadMem(addr, 4), 0);
        }

        public int ReadInt(long addr)
        {
            return BitConverter.ToInt32(ReadMem(addr, 4), 0);
        }

        public int ReadInt(int addr, params int[] offsets)
        {
            int num = ReadInt(addr);
            return offsets.Aggregate(num, (current, num2) => ReadInt(current + num2));
        }

        public int ReadInt(long addr, params long[] offsets)
        {
            long num = ReadLong(addr);
            return (int)offsets.Aggregate(num, (current, num2) => ReadLong(current + num2));
        }

      


        public float ReadFloat(long addr)
        {
            return BitConverter.ToSingle(ReadMem(addr, 4), 0);
        }

        public long ReadLong(long addr)
        {
            return BitConverter.ToInt64(ReadMem(addr, 8), 0);
        }

        public long ReadLong(long addr, params long[] offsets)
        {
            long num = ReadLong(addr);
            return offsets.Aggregate(num, (current, num2) => ReadLong(current + num2));
        }

        public uint ReadUInt(long addr)
        {
            return BitConverter.ToUInt32(ReadMem(addr, 4), 0);
        }


        /// <summary>
        /// Read string as ASCII
        /// </summary>
        /// <param name="addr"></param>
        /// <param name="length"></param>
        /// <param name="replaceNull"></param>
        /// <returns></returns>
        public string ReadString(long addr, int length = 256, bool replaceNull = true)
        {
            if (addr <= 65536 && addr >= -1)
            {
                return string.Empty;
            }
            string @string = Encoding.ASCII.GetString(ReadMem(addr, length));
            return replaceNull ? RTrimNull(@string) : @string;
        }

        private static string RTrimNull(string text)
        {
            int num = text.IndexOf('\0');
            return num > 0 ? text.Substring(0, num) : String.Empty;
        }

        /// <summary>
        /// Read string as Unicode
        /// </summary>
        /// <param name="addr"></param>
        /// <param name="length"></param>
        /// <param name="replaceNull"></param>
        /// <returns></returns>
        public string ReadStringU(long addr, int length = 256, bool replaceNull = true)
        {
            if (addr <= 65536 && addr >= -1)
            {
                return string.Empty;
            }
            byte[] mem = ReadMem(addr, length);
            if (mem[0] == 0 && mem[1] == 0)
                return string.Empty;
            string @string = Encoding.Unicode.GetString(mem);
            return replaceNull ? RTrimNull(@string) : @string;
        }

        public byte ReadByte(int addr)
        {
            return ReadBytes(addr, 1).FirstOrDefault();
        }

        public byte ReadByte(long addr)
        {
            return ReadBytes(addr, 1).FirstOrDefault();
        }

        public byte[] ReadBytes(int addr, int length)
        {
            return ReadMem(addr, length);
        }

        public byte[] ReadBytes(long addr, int length)
        {
            return ReadMem(addr, length);
        }

        private void Close()
        {
            if (!closed)
            {
                closed = true;
                WinApi.CloseHandle(procHandle);
            }
        }

        private byte[] ReadMem(int addr, int size)
        {
            var array = new byte[size];
            WinApi.ReadProcessMemory(procHandle, (IntPtr)addr, array);
            return array;
        }
        private byte[] ReadMem(long addr, int size)
        {
            var array = new byte[size];
            WinApi.ReadProcessMemory(procHandle, (IntPtr)addr, array);
            return array;
        }

        public string DebugStr = "";
        public long[] FindPatterns(params Pattern[] patterns)
        {
            byte[] exeImage = ReadBytes(AddressOfProcess, 0x2000000); //33mb
            var address = new long[patterns.Length];

            for (int iPattern = 0; iPattern < patterns.Length; iPattern++)
            {
                Pattern pattern = patterns[iPattern];
                byte[] patternData = pattern.Bytes;
                int patternLength = patternData.Length;

                bool found = false;

                for (int offset = 0; offset < exeImage.Length - patternLength; offset++)
                {
                    if (CompareData(pattern, exeImage, offset))
                    {
                        found = true;
                        address[iPattern] = offset;
                        DebugStr += "Pattern " + iPattern + " is found at " + (AddressOfProcess + offset).ToString("X") + " offset: " + offset.ToString("X") + Environment.NewLine;
                        //break;
                    }
                }

                if(!found)
                {
                    //System.Windows.Forms.MessageBox.Show("Pattern " + iPattern + " is not found!");
                    DebugStr += "Pattern " + iPattern + " is not found!" + Environment.NewLine;
                }
            }
            return address;
        }

        private bool CompareData(Pattern pattern, byte[] data, int offset)
        {
            return !pattern.Bytes.Where((t, i) => pattern.Mask[i] == 'x' && t != data[offset + i]).Any();
        }
    }
}