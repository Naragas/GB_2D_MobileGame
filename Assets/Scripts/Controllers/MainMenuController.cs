using UnityEngine;

namespace GB_2D_MobileGame
{
    public class MainMenuController : BaseController
    {
        private ResourcesPath _mainMenuPath = new ResourcesPath {PathResource = "Prefabs/MainMenu"};
        private MainMenuView _mainMenuView;
        private ProfilerPlayer _profilerPlayer;

        public MainMenuController(Transform placeForUI, ProfilerPlayer profilerPlayer)
        {
            _profilerPlayer = profilerPlayer;
            _mainMenuView = LoadView(placeForUI);
            _mainMenuView.Init(StartGame);
        }
        
        private MainMenuView LoadView(Transform spawnPlace)
        {
            var viewGameObject = Object.Instantiate(ResourcesLoader.LoadPrefab(_mainMenuPath),spawnPlace,false);
            AddGameObject(viewGameObject);

            MainMenuView temp = viewGameObject.GetComponent<MainMenuView>();
            
            var mainMenuView = temp != null
                ? temp
                : viewGameObject.AddComponent<MainMenuView>().GetComponent<MainMenuView>();
            
            return mainMenuView;
        }

        private void StartGame()
        {
            _profilerPlayer.CurrentState.Value = GameState.Game;
            _profilerPlayer.AnalyticsTools.SendMessage("start_button_click");
            _profilerPlayer.AdsTools.ShowVideoPlacement();
        }
    }
}