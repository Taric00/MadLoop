using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameController
{
    public class StartGame : MonoBehaviour
    {
        void OnEnable()
        {
            SceneManager.sceneLoaded += OnSceneLoaded;
        }

        void OnDisable()
        {
            SceneManager.sceneLoaded -= OnSceneLoaded;
        }

        void OnSceneLoaded(Scene scene, LoadSceneMode mode)
        {
            Time.timeScale = 1;
        }
    }
}