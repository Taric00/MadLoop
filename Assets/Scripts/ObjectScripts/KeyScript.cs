using Interfaces;
using UnityEngine;

namespace ObjectScripts
{
    public class KeyScript : MonoBehaviour,Iinteractable
    {
        public DoorScript DoorScript;
        public void CanInteractable()
        {
            DoorScript.isHaveKey = true;
            Destroy(gameObject);
        }
    }
}
