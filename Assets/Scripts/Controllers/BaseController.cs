using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

namespace GD_2D_MobileGame
{
    public class BaseController : IDisposable
    {
        private List<BaseController> _baseControllers = new List<BaseController>();
        private List<GameObject> _gameObjects = new List<GameObject>();
        private bool _isDisposed;

        public void Dispose()
        {
            if (_isDisposed) return;

            _isDisposed = true;

            for (int i = 0; i < _baseControllers.Count; i++)
            {
                _baseControllers[i]?.Dispose();
            }

            _baseControllers.Clear();

            for (int i = 0; i < _gameObjects.Count; i++)
            {
                Object.Destroy(_gameObjects[i]);
            }

            _gameObjects.Clear();

            OnDispose();
        }

        protected void AddController(BaseController controller)
        {
            _baseControllers.Add(controller);
        }

        protected void AddGameObject(GameObject gameObject)
        {
            _gameObjects.Add(gameObject);
        }

        protected virtual void OnDispose()
        {

        }
    }
}
