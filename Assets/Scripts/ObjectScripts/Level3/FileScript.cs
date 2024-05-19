using Interfaces;
using UnityEngine;

namespace ObjectScripts.Level3
{
    public class FileScript : MonoBehaviour,Iinteractable
    {
        public GameObject ThirdDialog;
        public void CanInteractable()
        {
            ThirdDialog.SetActive(true);
        }
    }
}
