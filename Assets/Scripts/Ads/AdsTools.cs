using UnityEngine;
using UnityEngine.Advertisements;

namespace GB_2D_MobileGame
{
    public class AdsTools : MonoBehaviour, IAdsShower
    {
        private const string _gameId = "4165793";
        private const string videoId = "video";
        private const string rewardedVideoId = "rewardedVideo";
        bool testMode = true;
        
        private void Start()
        {
            Advertisement.Initialize(_gameId,testMode);
        }
        public void ShowVideoPlacement()
        {
            if (Advertisement.IsReady())
            {
                Advertisement.Show(videoId);
            }
            else
            {
                Debug.Log("Рекламное видео не готовов для показа.");
            }
            
        }

        public void ShowRewardedVideoPlacement()
        {
            Advertisement.Show(rewardedVideoId);
        }


    }
}