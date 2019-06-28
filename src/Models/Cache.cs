using PoeHUD.Controllers;
using PoeHUD.Poe;
using PoeHUD.Poe.RemoteMemoryObjects;
using SharpDX;

namespace PoeHUD.Models
{
    public class Cache
    {
        private readonly GameController _gameController;
        private InGameState _inGameState = null;
        private Camera _camera;
        private Element _uiRoot;
        private InGameUIElements _inGameUi;
        private ServerData _serverData;
        private InGameData _data;
        private DiagnosticElement _fpsRectangle;
        private DiagnosticElement _latencyRectangle;
        private RectangleF _window;
        private bool _enable = true;

        private static Cache _instance;

        public InGameState InGameState
        {
            get => _inGameState;
            set
            {
                if (_inGameState == null)
                    _inGameState = value;
            }
        }

        public Camera Camera
        {
            get => _camera;
            set
            {
                if(_camera==null)
                    _camera = value;
            }
        }

        public Element UIRoot
        {
            get => _uiRoot;
            set
            {
                if (_uiRoot == null)
                    _uiRoot = value;
            }
        }

        public InGameUIElements InGameUi
        {
            get => _inGameUi;
            set
            {
                if (_inGameUi == null)
                    _inGameUi = value;
            }
        }

        public ServerData ServerData
        {
            get => _serverData;
            set
            {
                if (_serverData==null)
                    _serverData = value;
            }
        }
    
        public InGameData Data
        {
            get => _data;
            set
            {
                if (_data == null)
                    _data = value;
            }
        }

        public DiagnosticElement FPSRectangle
        {
            get => _fpsRectangle;
            set
            {
                if (_fpsRectangle == null)
                    _fpsRectangle = value;
            }
        }

        public DiagnosticElement LatencyRectangle
        {
            get => _latencyRectangle;
            set
            {
                if (_latencyRectangle == null)
                    _latencyRectangle = value;
            }
        }


        public RectangleF Window => _window.IsEmpty ? (_window= _gameController.Window.GetWindowRectangleReal()) :_window;


        public bool Enable
        {
            get { return _enable; }
            set
            {
                if (value)
                    UpdateCache();
                _enable = value;
            }
        }

        public Cache()
        {
            _window = RectangleF.Empty;
            _gameController = GameController.Instance;
           
        }
        public void UpdateCache()
        {
            _gameController.Game.RefreshTheGameState();
            _inGameState = null;
            _camera = null;
            _uiRoot = null;
            _inGameUi = null;
            _serverData = null;
            _data = null;
            _fpsRectangle = null;
            _latencyRectangle = null;
            _window = _gameController.Window.GetWindowRectangleReal();
        }

        public void ForceUpdateWindowCache()
        {
            _window = _gameController.Window.GetWindowRectangleReal();
        }
    }
}