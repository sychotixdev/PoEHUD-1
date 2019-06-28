using System;
using System.Collections;
using System.Collections.Generic;
using PoeHUD.EntitiesCache.CachedEntities;
using PoeHUD.EntitiesCache.CachedEntities.Base;

namespace PoeHUD.EntitiesCache.CacheControllers
{
    public class EntityCollectionFilter<T> : IEnumerable<T> where T : BaseEntity
    {
        private readonly List<T> _collection;
        private readonly Func<T, bool> _filter;

        internal EntityCollectionFilter(List<T> collection, Func<T, bool> filter)
        {
            _collection = collection;
            _filter = filter;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var entity in _collection)
            {
                if (!_filter(entity))
                    continue;

                yield return entity;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}