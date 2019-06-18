using System;
using System.Collections.Generic;
using System.IO;
using System.Media;

namespace PoeHUD.Hud
{
    public static class Sounds
    {
        public static SoundPlayer AlertSound;
        public static SoundPlayer AttentionSound;
		public static SoundPlayer BeastSound;
		public static SoundPlayer BombSound;
		public static SoundPlayer CorruptedSound;
		public static SoundPlayer DangerSound;
		public static SoundPlayer ElementalSound;
		public static SoundPlayer InceptionSound;
		public static SoundPlayer PhysicalSound;
		public static SoundPlayer TreasureSound;
		public static SoundPlayer VolatileSound;

		private static readonly Dictionary<string, SoundPlayer> soundLib = new Dictionary<string, SoundPlayer>();

        public static void AddSound(string name)
        {
            if (!soundLib.ContainsKey(name))
            {
                try
                {
                    String path = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase), $"sounds/{name}");
                    var soundPlayer = new SoundPlayer(path); 
                    soundPlayer.Load();
                    soundLib[name] = soundPlayer;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error when loading {name}| {ex.Message}:", ex);
                }
            }
        }

        public static SoundPlayer GetSound(string name)
        {
            return soundLib[name];
        }

        public static void LoadSounds()
        {
            AddSound("alert.wav");
			AddSound("attention.wav");
			AddSound("beast.wav");
			AddSound("bomb.wav");
			AddSound("corrupted.wav");
			AddSound("danger.wav");
			AddSound("elemental.wav");
			AddSound("inception.wav");
			AddSound("physical.wav");
			AddSound("treasure.wav");
			AddSound("volatile.wav");
			AlertSound = GetSound("alert.wav");
			AttentionSound = GetSound("attention.wav");
			BeastSound = GetSound("beast.wav");
			BombSound = GetSound("bomb.wav");
			CorruptedSound = GetSound("corrupted.wav");
			DangerSound = GetSound("danger.wav");
			ElementalSound = GetSound("elemental.wav");
			InceptionSound = GetSound("inception.wav");
			PhysicalSound = GetSound("physical.wav");
			TreasureSound = GetSound("treasure.wav");
			VolatileSound = GetSound("volatile.wav");
		}
	}
}