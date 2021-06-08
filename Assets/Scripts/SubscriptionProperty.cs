using System;

namespace GD_2D_MobileGame
{
    public class SubscriptionProperty<T> : IReadOnlySubscriptionProperty<T>
    {
        private T _value;
        private Action<T> _onChangeValue;
        
        public T Value
        {
            get => _value;
            set
            {
                _value = value;
                _onChangeValue?.Invoke(value);
            }

        }
        public void SubscribeOnChange(Action<T> subscribeAction)
        {
            _onChangeValue += subscribeAction;
        }

        public void UnSubscribeOnChange(Action<T> unSubscribeAction)
        {
            _onChangeValue -= unSubscribeAction;
        }
    }
}