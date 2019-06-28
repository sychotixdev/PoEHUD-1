using System;
using PoeHUD.EntitiesCache.CachedEntities.Interfaces;
using PoeHUD.Framework;

namespace PoeHUD.EntitiesCache.CachedEntities.Base
{
    /// <summary>
    /// This is common class for items and world entities
    /// </summary>
    public abstract class BaseEntity : IEntityCachedData
    {
        internal BaseEntity(NewCachedEntityParams entityParams) //mean this comes from world entity cache
        {
            Address = entityParams.Address;
            MetadataAddress = entityParams.MetadataAddress;

            if (entityParams.Metadata == null)//this happen in PlayerInfo class, we adding player and don't reading metadata
                ReadMetadata();
            else
            {
                Metadata = Path = entityParams.Metadata;
                SplitMetadata();
            }
        }

        internal BaseEntity(long address) //For ItemEntity
        {
            Address = address;
            ReadMetadata();
        }

        private void ReadMetadata()
        {
            MetadataAddress = Memory.Instance.ReadLong(Address, 0x18);
            Path = Memory.Instance.ReadStringU(MetadataAddress); //TODO: Add structs reading
            Metadata = Path;
            SplitMetadata();
        }

        private void SplitMetadata()
        {    
            try
            {
                if (!string.IsNullOrEmpty(Metadata))
                {
                    var splitIndex = Metadata.IndexOf("@", StringComparison.Ordinal);

                    if (splitIndex != -1)
                        Metadata = Metadata.Substring(0, splitIndex);
                }
            }
            catch
            {
                // ignored
            }
        }

        [Obsolete("Better to use Metadata instead (it remove ...@75 ending in monsters path")]
        public string Path { get; private set; }
        public string Metadata { get; private set; }
        public long Address { get; internal set; }

        /// <summary>
        /// We're gonna use it instead of string for component caching.
        /// </summary>
        internal long MetadataAddress { get; set; }

        public override string ToString()
        {
            return $"{GetType().Name}, Address: {Address}, Metadata: {Metadata}";
        }
    }

    internal class NewCachedEntityParams
    {
        internal NewCachedEntityParams(long address, string metadata, long metadataAddress)
        {
            Address = address;
            Metadata = metadata;
            MetadataAddress = metadataAddress;
        }

        public long Address { get; }
        public string Metadata { get; }
        public long MetadataAddress { get; }
    }
}
