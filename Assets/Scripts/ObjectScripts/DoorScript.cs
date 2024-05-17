using Interfaces;
using UnityEngine;

namespace ObjectScripts
{
    public class DoorScript : MonoBehaviour,Iinteractable
    {
        public Animator Animator;
        private bool isAlreadyOpened;
        
        public void CanInteractable()
        {
            if (!isAlreadyOpened)
            {
                Animator.SetBool("CloseDoor",false);
                Animator.SetBool("OpenDoor",true);
                isAlreadyOpened = true;
            }
            else
            {
                Animator.SetBool("OpenDoor",false);
                Animator.SetBool("CloseDoor",true);
                isAlreadyOpened = false;
            }
        }
    }
}
