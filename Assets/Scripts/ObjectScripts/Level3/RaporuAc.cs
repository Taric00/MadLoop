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
        public GameObject Panzehir;
        public GameObject tup;
        
        
        public void CanInteractable()
        {
            RaporImage.SetActive(true);
            FourthDialog.SetActive(true);
            //Key.SetActive(true);
            Panzehir.SetActive(true);
            tup.SetActive(true);
            StartCoroutine(CloseRapor());
        }

        IEnumerator CloseRapor()
        {
            yield return new WaitForSeconds(FourthDialog.GetComponent<Diyalog>().endDialogueDelay+2);
            RaporImage.SetActive(false);
        }
        
    }
}
