using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameController
{
    public class Timer : MonoBehaviour
    {
        public float timerDuration = 60f;
        private float timer;
        public TextMeshProUGUI timerText;
        void Start()
        {
            timer = timerDuration;
        }

        void Update()
        {
            timer -= Time.deltaTime;
            
            if (timer <= 0f)
            {
                RestartLevel();
            }
            
            if (timerText != null)
            {
                timerText.text = "Kalan Zaman: " + Mathf.Ceil(timer).ToString();
            }
        }

        void RestartLevel()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
