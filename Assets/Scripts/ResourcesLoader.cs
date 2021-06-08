using UnityEngine;

namespace GD_2D_MobileGame
{
    public class ResourcesLoader
    {
        public static GameObject LoadPrefab(ResourcesPath path)
        {
            return Resources.Load<GameObject>(path.PathResource);
        }
    }
}