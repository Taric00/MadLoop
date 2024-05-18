using Interfaces;
using UnityEngine;

namespace ObjectScripts
{
    public class CekmeceScript : MonoBehaviour,Iinteractable
    {
        public Animator Animator;
        private bool isAlreadyOpened;
        
        public void CanInteractable()
        {
            if (!isAlreadyOpened)
            {
                Animator.SetBool("Close",false);
                Animator.SetBool("Open",true);
                isAlreadyOpened = true;
            }
            else
            {
                Animator.SetBool("Open",false);
                Animator.SetBool("Close",true);
                isAlreadyOpened = false;
            }
        }
    }
}
