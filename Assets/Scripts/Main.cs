using UnityEngine;

namespace GD_2D_MobileGame
{

    public class Main : MonoBehaviour
    {
        [SerializeField] private Transform _placeForUI;

        private MainController _mainController;

        private void Awake()
        {
            var profilePlayer = new ProfilerPlayer(15f);
            profilePlayer.CurrentState.Value = GameState.StartMenu;
            _mainController = new MainController(_placeForUI, profilePlayer);
        }
    }
}
