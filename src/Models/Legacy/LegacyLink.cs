using PoeHUD.Models.Enums;
using System;

namespace PoeHUD.Models.Legacy
{
    [Obsolete]
    public class LegacyLink
    {
        public static readonly LegacyLink EmptyLegacyLink = new LegacyLink(new LegacySocket[0]);
        private readonly LegacySocket[] link;

        public int Length => link.Length;

        public int NumberOfRed
        {
            get;
            private set;
        }

        public int NumberOfGreen
        {
            get;
            private set;
        }

        public int NumberOfBlue
        {
            get;
            private set;
        }

        public LegacyLink(LegacySocket[] legacySockets)
        {
            link = legacySockets;
            CountColors();
        }

        public LegacyLink(string sockets)
        {
            link = new LegacySocket[sockets.Length];
            for (int i = 0; i < sockets.Length; i++)
            {
                link[i] = CharToSocket(sockets.ToCharArray()[i]);
            }
            CountColors();
        }

        private void CountColors()
        {
            LegacySocket[] array = link;
            foreach (LegacySocket t in array)
            {
                switch (t)
                {
                    case LegacySocket.Red:
                        NumberOfRed++;
                        break;

                    case LegacySocket.Green:
                        NumberOfGreen++;
                        break;

                    case LegacySocket.Blue:
                        NumberOfBlue++;
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        private LegacySocket CharToSocket(char s)
        {
            char c = char.ToUpper(s);
            switch (c)
            {
                case 'B':
                    return LegacySocket.Blue;

                case 'G':
                    return LegacySocket.Green;

                case 'R':
                    return LegacySocket.Red;
            }
            throw new Exception("Invalid socket char: " + s);
        }

        public bool Contains(LegacyLink other)
        {
            return other.NumberOfRed <= NumberOfRed && other.NumberOfGreen <= NumberOfGreen && other.NumberOfBlue <= NumberOfBlue;
        }
    }
}