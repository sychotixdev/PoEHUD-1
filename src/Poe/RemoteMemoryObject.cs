using PoeHUD.Framework;
using PoeHUD.Poe.RemoteMemoryObjects;

namespace PoeHUD.Poe
{
    public abstract class RemoteMemoryObject
    {
        public long Address { get; protected set; }
        protected TheGame Game { get; set; }
        protected Memory M { get; set; }

        protected Offsets Offsets => M.offsets;

        public T ReadObjectAt<T>(int offset) where T : RemoteMemoryObject, new()
        {
            return ReadObject<T>(Address + offset);
        }


        public T ReadObject<T>(long addressPointer) where T : RemoteMemoryObject, new()
        {
            var t = new T { M = M, Address = M.ReadLong(addressPointer), Game = Game };
            return t;
        }

        public T GetObjectAt<T>(int offset) where T : RemoteMemoryObject, new()
        {
            return GetObject<T>(Address + offset);
        }

        public T GetObjectAt<T>(long offset) where T : RemoteMemoryObject, new()
        {
            return GetObject<T>(Address + offset);
        }


        public T GetObject<T>(long address) where T : RemoteMemoryObject, new()
        {
            var t = new T { M = M, Address = address, Game = Game };
            return t;
        }

        public T AsObject<T>() where T : RemoteMemoryObject, new()
        {
            var t = new T { M = M, Address = Address, Game = Game };
            return t;
        }

        public override bool Equals(object obj)
        {
            var remoteMemoryObject = obj as RemoteMemoryObject;
            return remoteMemoryObject != null && remoteMemoryObject.Address == Address;
        }

        public override int GetHashCode()
        {
            return (int)Address + GetType().Name.GetHashCode();
        }
    }
}