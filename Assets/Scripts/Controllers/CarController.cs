using UnityEngine;

namespace GB_2D_MobileGame
{
    public class CarController : BaseController
    {
        private ResourcesPath _viewPath = new ResourcesPath {PathResource = "Prefabs/Car"};
        private CarView _carView;

        public CarView CarView => _carView;

        public CarController()
        {
            _carView = LoadView();
        }

        private CarView LoadView()
        {
            var viewGameObject = Object.Instantiate(ResourcesLoader.LoadPrefab(_viewPath));
            AddGameObject(viewGameObject);

            CarView temp = viewGameObject.GetComponent<CarView>();
            
            var carView = temp != null
                ? temp
                : viewGameObject.AddComponent<CarView>().GetComponent<CarView>();
            
            return carView;
        }
    }
}