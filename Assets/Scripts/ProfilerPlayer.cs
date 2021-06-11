namespace GB_2D_MobileGame
{
    public class ProfilerPlayer
    {
        public SubscriptionProperty<GameState> CurrentState { get; }
        
        public IAnalyticsTools AnalyticsTools { get; }
        public Car CurrentCar { get; }
        
        public AdsTools AdsTools { get; }
        
        public ProfilerPlayer(float carSpeed, AdsTools adsTools)
        {
            CurrentState = new SubscriptionProperty<GameState>();
            CurrentCar = new Car(carSpeed);
            AnalyticsTools = new AnalyticsTools();
            AdsTools = adsTools;
        }
        
        
    }
}