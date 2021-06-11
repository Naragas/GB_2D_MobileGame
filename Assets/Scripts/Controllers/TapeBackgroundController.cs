
using UnityEngine;

namespace GB_2D_MobileGame
{


    public class TapeBackgroundController : BaseController
    {
        public TapeBackgroundController(IReadOnlySubscriptionProperty<float> leftMove,
            IReadOnlySubscriptionProperty<float> rightMove)
        {
            _view = LoadView();
            _diff = new SubscriptionProperty<float>();

            _leftMove = leftMove;
            _rightMove = rightMove;

            _view.Init(_diff);

            _leftMove.SubscribeOnChange(Move);
            _rightMove.SubscribeOnChange(Move);
        }

        private readonly ResourcesPath _viewPath = new ResourcesPath {PathResource = "Prefabs/background"};
        private TapeBackgroundView _view;
        private readonly SubscriptionProperty<float> _diff;
        private readonly IReadOnlySubscriptionProperty<float> _leftMove;
        private readonly IReadOnlySubscriptionProperty<float> _rightMove;

        protected override void OnDispose()
        {
            _leftMove.UnSubscribeOnChange(Move);
            _rightMove.UnSubscribeOnChange(Move);

            base.OnDispose();
        }

        private TapeBackgroundView LoadView()
        {
            var objView = Object.Instantiate(ResourcesLoader.LoadPrefab(_viewPath));
            AddGameObject(objView);

            return objView.GetComponent<TapeBackgroundView>();
        }

        private void Move(float value)
        {
            _diff.Value = value;
        }
    }
}
