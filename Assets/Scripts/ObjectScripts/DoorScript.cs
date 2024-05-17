using Interfaces;
using UnityEngine;

namespace ObjectScripts
{
    public class DoorScript : MonoBehaviour,Iinteractable
    {
        public Animator Animator;
        public void CanInteractable()
        {
            Animator.SetBool("isOpen",true);
        }
    }
}
