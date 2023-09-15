using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;
using VContainer.Unity;

namespace DefaultNamespace
{
    public class SceneLoader
    {
        private readonly LifetimeScope currentScope;

        public SceneLoader(LifetimeScope lifetimeScope)
        {
            currentScope = lifetimeScope;
        }
        private AsyncOperationHandle<SceneInstance> currentScene;

        public void LoadScene(AssetReference assetReference)
        {
            if (currentScene.IsValid())
            {
                Addressables.UnloadSceneAsync(currentScene);
            }

            Addressables.LoadSceneAsync(assetReference, LoadSceneMode.Additive).Completed += OnSceneLoaded;
        }

        private void OnSceneLoaded(AsyncOperationHandle<SceneInstance> obj)
        {
            if (obj.Status == AsyncOperationStatus.Succeeded)
            {
                currentScene = obj;
            }
        }
    }
}