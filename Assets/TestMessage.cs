using UnityEngine;
using VContainer.Unity;

namespace DefaultNamespace
{
    public class Messenger : IStartable
    {
        private readonly TestMessage testMessage;

        public Messenger(TestMessage testMessage, SceneLoader sceneLoader)
        {
            this.testMessage = testMessage;
            Debug.Log($"Scene Loader injected {sceneLoader}");
        }
        
        
        public void Start()
        {
            testMessage.TestMessageCall();
        }
    }
    public class TestMessage
    {
        public void TestMessageCall()
        {
            Debug.Log("Test message created");
        }
        
        
    }
}