using System;

namespace GB_2D_MobileGame
{
    public interface IReadOnlySubscriptionProperty<T>
    {
        T Value { get; }

        void SubscribeOnChange(Action<T> subscribeAction);
     
        void UnSubscribeOnChange(Action<T> unSubscribeAction);
        
    }
}