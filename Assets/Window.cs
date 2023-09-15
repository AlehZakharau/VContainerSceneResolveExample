using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;
using VContainer;

namespace DefaultNamespace
{
    public class Window : MonoBehaviour
    {
        [SerializeField] private AssetReference _scene1;
        [SerializeField] private AssetReference _scene2;
        
        [SerializeField] private Button _buttonScene1;
        [SerializeField] private Button _buttonScene2;

        private SceneLoader sceneLoader;

        [Inject]
        public void Initialize(SceneLoader sceneLoader)
        {
            this.sceneLoader = sceneLoader;
            _buttonScene1.onClick.AddListener(() =>
            {
                this.sceneLoader.LoadScene(_scene1);
            });
            _buttonScene2.onClick.AddListener(() =>
            {
                this.sceneLoader.LoadScene(_scene2);
            });
        }
    }
}