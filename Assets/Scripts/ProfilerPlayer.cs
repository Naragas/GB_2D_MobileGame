namespace GD_2D_MobileGame
{
    public class ProfilerPlayer
    {
        public SubscriptionProperty<GameState> CurrentState { get; }
        public Car CurrentCar { get; }
        
        public ProfilerPlayer(float carSpeed)
        {
            CurrentState = new SubscriptionProperty<GameState>();
            CurrentCar = new Car(carSpeed);
        }
        
        
    }
}