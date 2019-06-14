using System;
using PoeHUD.Controllers;
using PoeHUD.Models.Interfaces;
using PoeHUD.Poe;
using PoeHUD.Poe.Components;
using System.Collections.Generic;
using Vector3 = SharpDX.Vector3;

namespace PoeHUD.Models
{
    public class EntityWrapper : IEntity
    {
        private readonly uint cachedId;
        private readonly Dictionary<string, long> components;
        private readonly Dictionary<string, object> cacheComponents;
        private readonly GameController gameController;
        private readonly Entity internalEntity;
        public bool IsInList = true;

        public EntityWrapper(GameController Poe, Entity entity)
        {
            gameController = Poe;
            internalEntity = entity;
            components = internalEntity.GetComponents();
            if (gameController.Cache.Enable)
            {
                cacheComponents = new Dictionary<string, object>();
                foreach (var component in components)
                {
                    cacheComponents[component.Key] = null;
                }
            }
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
        public uint Id => cachedId;
        public bool IsHostile => internalEntity.IsHostile;
        public bool IsTargetable => internalEntity.IsTargetable;
        public bool CannotDie => internalEntity.CannotDieAura;
        public bool IsHidden => internalEntity.IsHidden;
        public bool CannotBeDamaged => internalEntity.CannotBeDamagedStat;
        public bool Invincible => internalEntity.CannotBeDamagedStat;
        public bool IsEmerging => internalEntity.IsEmerging;
        public bool IsActive => internalEntity.IsActive;
        public long LongId { get; }
        public bool IsAlive => internalEntity.IsAlive;
        public int DistanceFromPlayer => GetDistanceFromPlayer();
        public Positioned PositionedComp => internalEntity.PositionedComp;
        public Vector3 Pos => internalEntity.Pos;
        public Vector3 BoundsCenterPos => internalEntity.PosEntityCenter;

        // Legion
        public bool IsLegion => Path.StartsWith("Metadata/Monsters/LegionLeague") || Path.StartsWith("Metadata/Chests/LegionChests");
        public bool IsFrozenInTime => HasComponent<Monster>() && GetComponent<Life>().HasBuff("frozen_in_time");

        private int GetDistanceFromPlayer()
        {
            var p        = GetComponent<Render>();
            var player   = GameController.Instance.Player;
            var distance = Math.Sqrt(Math.Pow(player.Pos.X - p.X, 2) + Math.Pow(player.Pos.Y - p.Y, 2));
            return (int)distance;
        }

        public T GetComponent<T>() where T : Component, new()
        {
            string name = typeof(T).Name;
            if (gameController.Cache.Enable)
            {
                if (!cacheComponents.ContainsKey(name) || cacheComponents[name] == null)
                {
                    cacheComponents[name] =
                        gameController.Game.GetObject<T>(components.ContainsKey(name) ? components[name] : 0);
                }
                return (T) cacheComponents[name];
            }
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