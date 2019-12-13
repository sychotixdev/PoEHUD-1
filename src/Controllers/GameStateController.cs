using System;
using System.Collections.Generic;
using PoeHUD.Framework;
using PoeHUD.Controllers;
using PoeHUD.Hud;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class GameStateController : StructuredRemoteMemoryObject<EnumOffsets.GameStateController>
    {
        public GameStateController(Memory m, TheGame game)
        {
            Game = game;
            M = m;
            Instance = this;
            Address = m.ReadLong(Offsets.GameStateOffset + m.AddressOfProcess);
            AllGameStates = ReadHashMap((long)Structure.allGameStates);
			foreach (var _state in AllGameStates)
			{
				System.Console.WriteLine(_state.Key + ": 0x" + _state.Value.Address.ToString("x8"));
			}
            PreGameStatePtr = AllGameStates["PreGameState"].Address;
            LoginStatePtr = AllGameStates["LoginState"].Address;
			SelectCharacterStatePtr = AllGameStates["SelectCharacterState"].Address;
			WaitingStatePtr = AllGameStates["WaitingState"].Address;
			InGameStatePtr = AllGameStates["InGameState"].Address;
			LoadingState = AllGameStates["AreaLoadingState"].AsObject<AreaLoadingState>();
			IngameState = AllGameStates["InGameState"].AsObject<IngameState>();
		}

        //How to reversing it
        //you should search for string of current active state, something like "IngameState" then you should search who using it (maybe on area change)..
        //then after few scans you will got the green address. Then you know what to do..

		//I hope this caching will works fine
		private static long PreGameStatePtr = -1;
        private static long LoginStatePtr = -1;
        private static long SelectCharacterStatePtr = -1;
        private static long WaitingStatePtr = -1;
        private static long InGameStatePtr = -1;
        private static GameStateController Instance;

        public readonly Dictionary<string, GameState> AllGameStates;
        public static AreaLoadingState LoadingState { get; private set; }
        public static IngameState IngameState { get; private set; }
        public static List<GameState> CurrentGameStates => Instance.M.ReadDoublePtrVectorClasses<GameState>(Instance.Address + 0x8);
        public static List<GameState> ActiveGameStates => Instance.M.ReadDoublePtrVectorClasses<GameState>(Instance.Address + 0x20, true);

        //For debug
        public List<GameState> _CurrentGameStates => CurrentGameStates;
        //For debug
        public List<GameState> _ActiveGameStates => ActiveGameStates;

        public static bool IsPreGame => GameStateActive(PreGameStatePtr);
        public static bool IsLoginState => GameStateActive(LoginStatePtr);
        public static bool IsSelectCharacterState => GameStateActive(SelectCharacterStatePtr);
        public static bool IsWaitingState => GameStateActive(WaitingStatePtr);//This happens after selecting character, maybe other cases
        public static bool IsInGameState
        {
            get
            {
                var isLoading = IsLoading;
                var ingameStateStateActive = GameStateActive(InGameStatePtr);
                return ingameStateStateActive && !isLoading;
            }
        }

        public static bool IsLoading => LoadingState.IsLoading;

        private static bool GameStateActive(long stateAddress)
        {
            var M = GameController.Instance.Memory;
            var start = (long)Instance.Structure.activeGameStatesStart;
            var last = (long)Instance.Structure.activeGameStatesEnd;

            var length = (int)(last - start);
            var bytes = M.ReadBytes(start, length);

            for (int readOffset = 0; readOffset < length; readOffset += 16)
            {
                var pointer = BitConverter.ToInt64(bytes, readOffset);
                if (stateAddress == pointer) return true;
            }
            return false;
        }

        private Dictionary<string, GameState> ReadHashMap(long pointer)
        {
            var result = new Dictionary<string, GameState>();

            Stack<GameStateHashNode> stack = new Stack<GameStateHashNode>();
            var startNode = GetObject<GameStateHashNode>(pointer);
            var item = startNode.Root;
            stack.Push(item);

            var stuckCounter = 100;
            while (stack.Count != 0 && stuckCounter-- > 0)
            {
                GameStateHashNode node = stack.Pop();
                if (!node.IsNull)
                    result[node.Key] = node.Value1;

                GameStateHashNode prev = node.Previous;
                if (!prev.IsNull)
                    stack.Push(prev);

                GameStateHashNode next = node.Next;
                if (!next.IsNull)
                    stack.Push(next);
            }
            return result;
        }
        private class GameStateHashNode : StructuredRemoteMemoryObject<EnumOffsets.GameStateHashNode>
        {
            public GameStateHashNode Previous => GetObject<GameStateHashNode>((long)Structure.previous);
            public GameStateHashNode Root => GetObject<GameStateHashNode>((long)Structure.root);
            public GameStateHashNode Next => GetObject<GameStateHashNode>((long)Structure.next);
            //public readonly byte Unknown;
            public bool IsNull => Address != 0 && Structure.IsNull != 0;
            //private readonly byte byte_0;
            //private readonly byte byte_1;
            public string Key => M.ReadNativeString(Address + 0x20);
            //public readonly int Useless;
            public GameState Value1 => GetObject<GameState>((long)Structure.value1);
            //public readonly long Value2;
        }
    }

    public class GameState : RemoteMemoryObject
    {
        private string stateName;
        public string StateName => stateName ?? (stateName = M.ReadNativeString(Address + 0x10));

        public override string ToString()
        {
            return StateName;
        }
    }

    public class AreaLoadingState : GameState
    {
        //This is actualy pointer to loading screen stuff (image, etc), but should works fine.
        //UPDATE: This is a byte.
        public bool IsLoading => M.ReadLong(Address + 0xD8) == 1; 

        public override string ToString()
        {
            return $"IsLoading: {IsLoading}";
        }
    }
}
