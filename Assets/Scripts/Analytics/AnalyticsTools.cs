using System.Collections.Generic;
using UnityEngine.Analytics;

namespace GB_2D_MobileGame
{
    public class AnalyticsTools : IAnalyticsTools
    {
        public void SendMessage(string nameEvent)
        {
            var eventData = new Dictionary<string, object>();
            Analytics.CustomEvent(nameEvent, eventData);
        }

        public void SendMessage(string nameEvent, (string, object) data)
        {
            var eventData = new Dictionary<string, object>(){[data.Item1] = data.Item2};
            Analytics.CustomEvent(nameEvent, eventData);
        }
    }
}