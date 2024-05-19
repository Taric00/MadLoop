using System.Collections;
using Interfaces;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

namespace ObjectScripts.Level2
{
    public class Level2Door : MonoBehaviour,Iinteractable
    {
        public bool isHaveKey;
        public Animator Animator;
        public float WaitAnimationTime;

        public void CanInteractable()
        {
            if (isHaveKey)
            {
                Animator.SetBool("OpenDoor",true);
                StartCoroutine("WaitDoorAnimations");
            }
        }
        
        IEnumerator WaitDoorAnimations()
        {
            yield return new WaitForSeconds(WaitAnimationTime);
            Debug.Log("Çalıştı");
            SceneManager.LoadScene(4);
        }

        
        
    }
}
