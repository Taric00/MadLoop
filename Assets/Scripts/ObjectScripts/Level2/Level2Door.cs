using Interfaces;
using UnityEngine;

namespace ObjectScripts.Level2
{
    public class Level2Door : MonoBehaviour,Iinteractable
    {
        public GameObject DialoguePanel;
        public bool isHaveKey;
        public void CanInteractable()
        {
            if (gameObject.name == "Kapi1")
            {
                DialoguePanel.SetActive(true);
            }

            if (gameObject.name == "Kapi2" && isHaveKey)
            {
                Debug.Log("Kapı açıldı");
            }
        }
    }
}
