using Interfaces;
using UnityEngine;

namespace ObjectScripts.Level3
{
    public class RaporuAc : MonoBehaviour,Iinteractable
    {
        public GameObject RaporImage;
        public GameObject FourthDialog;
        public GameObject Key;
        
        
        public void CanInteractable()
        {
            RaporImage.SetActive(true);
            FourthDialog.SetActive(true);
            Key.SetActive(true);
        }
        
        
        
    }
}
