using PoeHUD.Controllers;
using PoeHUD.Models.Interfaces;
using PoeHUD.Poe;
using PoeHUD.Poe.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using Vector3 = SharpDX.Vector3;

namespace PoeHUD.Models
{
    public class EntityWrapper : IEntity
    {
        private readonly long cachedId;
        private readonly Dictionary<string, long> components;
        private readonly GameController gameController;
        private readonly Entity internalEntity;
        public bool IsInList = true;

        public EntityWrapper(GameController Poe, Entity entity)
        {
            gameController = Poe;
            internalEntity = entity;
            components = internalEntity.GetComponents();
            Path = internalEntity.Path;
            cachedId = internalEntity.Id;
            LongId = internalEntity.Id;
        }

        public EntityWrapper(GameController Poe, long address) : this(Poe, Poe.Game.GetObject<Entity>(address))
        {
        }

        public Entity InternalEntity => internalEntity.Address == 0 ? null : internalEntity;

        public string Path { get; }
        public bool IsValid => internalEntity.IsValid && IsInList && cachedId == internalEntity.Id;
        public long Address => internalEntity.Address;
        public long Id => cachedId;
        public bool IsHostile => internalEntity.IsHostile;
        public long LongId { get; }
        public bool IsAlive => GetComponent<Life>().CurHP > 0;

        public Vector3 Pos
        {
            get
            {
                var p = GetComponent<Positioned>();
                return new Vector3(p.X, p.Y, GetComponent<Render>().Z);
            }
        }

        public List<EntityWrapper> Minions
        {
            get
            {
                return GetComponent<Actor>().Minions.Select(current => gameController.EntityListWrapper.GetEntityById(current)).Where(byId => byId != null).ToList();
            }
        }

        public T GetComponent<T>() where T : Component, new()
        {
            string name = typeof(T).Name;
            return gameController.Game.GetObject<T>(components.ContainsKey(name) ? components[name] : 0);
        }

        public bool HasComponent<T>() where T : Component, new()
        {
            return components.ContainsKey(typeof(T).Name);
        }

        public List<string> PrintComponents()
        {
            List<string> result = new List<string>();
            result.Add(internalEntity.Path + " " + internalEntity.Address.ToString("X"));

            foreach (var current in components)
            {
                result.Add(current.Key + " " + current.Value.ToString("X"));
            }
            return result;
        }

        public override bool Equals(object obj)
        {
            var entity = obj as EntityWrapper;
            return entity != null && entity.LongId == LongId;
        }

        public override int GetHashCode()
        {
            return LongId.GetHashCode();
        }

        public override string ToString()
        {
            return "EntityWrapper: " + Path;
        }
    }
}