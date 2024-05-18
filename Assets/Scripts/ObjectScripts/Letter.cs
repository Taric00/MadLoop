using Interfaces;
using UnityEngine;
using UnityEngine.Serialization;

namespace ObjectScripts
{
    public class Letter : MonoBehaviour,Iinteractable
    {
        public GameObject LetterImage;
        public GameObject Point;
        public GameObject dialogue;
        private bool isOpened;
        
        public void CanInteractable()
        {
            if (!isOpened)
            {
                LetterImage.SetActive(true);
                Point.SetActive(false);
                Time.timeScale = 0;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        }

        public void OnClickCloseLetter()
        {
            LetterImage.SetActive(false);
            Point.SetActive(true);
            Time.timeScale = 1;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            dialogue.SetActive(true);
            isOpened = true;
            
        }
        
        
    }
}
