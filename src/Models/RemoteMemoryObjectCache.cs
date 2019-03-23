using PoeHUD.Plugins;
using PoeHUD.Poe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace PoeHUD.Models
{
    public class RemoteMemoryObjectCache
    {
        private static readonly string RMOCachePrefix = "RMOCache";

        public static T GetCachedObject<T>(long address) where T : RemoteMemoryObject
        {
            ObjectCache cache = MemoryCache.Default;
            RemoteMemoryObject rmo = cache[$"{RMOCachePrefix}{address}"] as RemoteMemoryObject;
            if (rmo != null)
            {
                BasePlugin.LogMessage("Found rmo in the cache!", 2);
                if (rmo is T)
                {
                    BasePlugin.LogMessage("And it was even the type we expected!", 2);
                    return rmo as T;
                }
            }
            return null;
        }

        public static bool CacheObject(RemoteMemoryObject rmo)
        {
            if (rmo.Address == 0)
                return false;

            ObjectCache cache = MemoryCache.Default;

            CacheItemPolicy policy = new CacheItemPolicy();
            policy.AbsoluteExpiration =
                DateTimeOffset.Now.AddSeconds(60.0);

            cache.Set($"{RMOCachePrefix}{rmo.Address}", rmo, policy);

            return true;
        }
    }
}
