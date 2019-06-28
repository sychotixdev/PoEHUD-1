using PoeHUD.Framework;
using PoeHUD.Poe.RemoteMemoryObjects;

namespace PoeHUD.Poe
{
    public abstract class RemoteMemoryObject
    {
        public long Address { get; protected set; }
        protected static TheGame Game { get; set; }
        protected static Memory M { get; set; }

        protected Offsets Offsets => M.offsets;

        public T ReadObjectAt<T>(int offset) where T : RemoteMemoryObject, new()
        {
            return ReadObject<T>(Address + offset);
        }

        public T ReadObject<T>(long addressPointer) where T : RemoteMemoryObject, new()
        {
            var t = new T { Address = M.ReadLong(addressPointer) };
            return t;
        }

        public T GetObjectAt<T>(int offset) where T : RemoteMemoryObject, new()
        {
            return GetObject<T>(Address + offset);
        }

        public T GetObjectAt<T>(params long[] offsets) where T : RemoteMemoryObject, new()
        {
            //Simple for better then LINQ for often operation
            var num = M.ReadLong(Address + offsets[0]);
            var result = num;

            for (var index = 1; index < offsets.Length; index++)
            {
                if (result == 0)
                    break;
                var offset = offsets[index];
                result = M.ReadLong(result + offset);
            }

            return GetObject<T>(result);
        }

        public T GetObjectAt<T>(long offset) where T : RemoteMemoryObject, new()
        {
            return GetObject<T>(Address + offset);
        }

        public T GetObject<T>(long address) where T : RemoteMemoryObject, new()
        {
            var t = new T { Address = address };
            return t;
        }

        public T AsObject<T>() where T : RemoteMemoryObject, new()
        {
            var t = new T { Address = Address };
            return t;
        }

        internal static T CreateObject<T>(long address) where T : RemoteMemoryObject, new()
        {
            var t = new T { Address = address };
            return t;
        }

        public override bool Equals(object obj)
        {
            return obj is RemoteMemoryObject remoteMemoryObject && remoteMemoryObject.Address == Address;
        }

        public override int GetHashCode()
        {
            return (int)Address + GetType().Name.GetHashCode();
        }
    }
}