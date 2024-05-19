using TMPro;
using UnityEngine;

namespace GameController
{
    public class GameManager : MonoBehaviour
    {
        public GameObject PauseMenu;
        private bool isGamePaused;
        public TextMeshProUGUI TimerText;
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (!isGamePaused)
                {
                    OpenPauseMenu();
                }
                else
                {
                    ReturnGame();
                }
            }
        }

        private void OpenPauseMenu()
        {
            PauseMenu.SetActive(true);
            if (TimerText != null)
            {
                TimerText.gameObject.SetActive(false);
            }
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            isGamePaused = true;
            Debug.Log("Game Paused");
            
        }

        public void ReturnGame()
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            if (TimerText != null)
            {
                TimerText.gameObject.SetActive(false);
            }
            PauseMenu.SetActive(false);
            Time.timeScale = 1;
            isGamePaused = false;
            Debug.Log("Game is continue");
            Debug.Log("aS" + PauseMenu.activeSelf);
            Debug.Log("aIH" + PauseMenu.activeInHierarchy);
        }
        
        
    }
}
