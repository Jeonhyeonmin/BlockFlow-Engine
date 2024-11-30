using System.Collections;
using Manager.etc;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Manager
{
    public class SceneLoaderManager : SingletonManagerMonoBehaviour<SceneLoaderManager>
    {
        public void LoadScene(string sceneName) => LoadSceneAsync(sceneName); 

        private void LoadSceneAsync(string sceneName)
        {
            StartCoroutine(LoadAsyncOperation(sceneName));
        }

        private IEnumerator LoadAsyncOperation(string sceneName = null)
        {
            AsyncOperation sceneInfo = SceneManager.LoadSceneAsync(sceneName);
        
            while (sceneInfo != null && !sceneInfo.isDone)
            {
                yield return null;
            }
        }
    }
}
