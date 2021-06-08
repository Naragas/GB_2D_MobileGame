using UnityEngine;

namespace GD_2D_MobileGame
{
    internal class InputGameController : BaseController
    {
        private readonly ResourcesPath _viewPath = new ResourcesPath {PathResource = "Prefabs/MobileSingleStickControl"};
        private BaseInputView _view;
        
        public InputGameController(SubscriptionProperty<float> leftMove, SubscriptionProperty<float> rightMove, Car car)
        {
            _view = LoadView();
            _view.Init(leftMove,rightMove,car.Speed);
        }

        private BaseInputView LoadView()
        {
            GameObject inputViewGameObject = Object.Instantiate(ResourcesLoader.LoadPrefab(_viewPath));
            AddGameObject(inputViewGameObject);

            return inputViewGameObject.GetComponent<BaseInputView>();
        }
    }
}