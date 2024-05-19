using System.Collections;
using Interfaces;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ObjectScripts
{
    public class DoorScript : MonoBehaviour,Iinteractable
    {
        public Animator Animator;
        public Animator FadeAnimator;
        public GameObject Fade;
        
        private bool isAlreadyOpened;
        public bool isHaveKey = false;
        public float WaitAnimationTime;
        
        public void CanInteractable()
        {
            if (isHaveKey)
            {
                if (!isAlreadyOpened)
                {
                    Animator.SetBool("CloseDoor",false);
                    Animator.SetBool("OpenDoor",true);
                    StartCoroutine("WaitDoorAnimations");
                    //Fade.SetActive(true);
                    //FadeAnimator.SetBool("Sleep",true);
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

        IEnumerator WaitDoorAnimations()
        {
            yield return new WaitForSeconds(WaitAnimationTime);
            SceneManager.LoadScene(4);
        }
        
    }
}
