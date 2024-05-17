using Interfaces;
using UnityEngine;

namespace ObjectScripts
{
    public class Cube : MonoBehaviour,Iinteractable
    {
        public void CanInteractable()
        {
            Debug.Log("Etkileşim oldu.");
        }
    }
}
