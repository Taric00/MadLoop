using UnityEngine;

namespace GameController
{
    public class GameManager : MonoBehaviour
    {
        public GameObject PauseMenu;
        private bool isGamePaused;
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
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            isGamePaused = true;
            Debug.Log("Game Paused");
        }

        public void ReturnGame()
        {
            PauseMenu.SetActive(false);
            Time.timeScale = 1;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            isGamePaused = false;
        }
        
        
    }
}
