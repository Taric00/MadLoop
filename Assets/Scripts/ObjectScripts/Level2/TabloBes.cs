using System.Collections;
using Interfaces;
using UnityEngine;

namespace ObjectScripts.Level2
{
    public class TabloBes : MonoBehaviour, Iinteractable
    {
        public GameObject TabloDialog;
        public GameObject AnahtarDialog;
        
        public Animator Animator;
        public Level2Door Level2Door;
        
        public void CanInteractable()
        {
            TabloDialog.SetActive(true);
            
            StartCoroutine(WaitText());
        }

        IEnumerator WaitText()
        {
            yield return new WaitForSeconds(1.5f);
                        
            TabloDialog.SetActive(false);
                        
            AnahtarDialog.SetActive(true);
            Animator.SetBool("Key",true);
            
            Level2Door.isHaveKey = true;
            Debug.Log("Anahtar alındı.");
        }
        
    }
}
