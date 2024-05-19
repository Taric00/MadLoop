using System.Collections;
using Interfaces;
using MenuScripts;
using UnityEngine;

namespace ObjectScripts.Level3
{
    public class RaporuAc : MonoBehaviour,Iinteractable
    {
        public GameObject RaporImage;
        public GameObject FourthDialog;
        //public GameObject Key;
        
        
        public void CanInteractable()
        {
            RaporImage.SetActive(true);
            FourthDialog.SetActive(true);
            //Key.SetActive(true);
            StartCoroutine(CloseRapor());
        }

        IEnumerator CloseRapor()
        {
            yield return new WaitForSeconds(FourthDialog.GetComponent<Diyalog>().endDialogueDelay +5);
            RaporImage.SetActive(false);
        }
        
    }
}
