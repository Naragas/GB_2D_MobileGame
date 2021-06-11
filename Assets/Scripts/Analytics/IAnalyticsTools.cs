namespace GB_2D_MobileGame
{
    public interface IAnalyticsTools
    {
        void SendMessage(string nameEvent);
        
        void SendMessage(string nameEvent,(string, object) data);

    }
}