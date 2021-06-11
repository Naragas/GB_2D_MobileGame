using UnityEngine;

namespace GB_2D_MobileGame
{

    public class Main : MonoBehaviour
    {
        [SerializeField] private Transform _placeForUI;
        [SerializeField] private AdsTools _adsTools;

        private MainController _mainController;

        private void Awake()
        {
            var profilePlayer = new ProfilerPlayer(15f, _adsTools);
            profilePlayer.CurrentState.Value = GameState.StartMenu;
            _mainController = new MainController(_placeForUI, profilePlayer);
        }
    }
}
