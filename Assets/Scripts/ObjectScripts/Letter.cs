using Interfaces;
using UnityEngine;

namespace ObjectScripts
{
    public class Letter : MonoBehaviour,Iinteractable
    {
        public GameObject LetterText;
        public GameObject Point;
        public void CanInteractable()
        {
            LetterText.SetActive(true);
            Point.SetActive(false);
        }
    }
}
