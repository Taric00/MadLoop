using Interfaces;
using UnityEngine;

namespace ObjectScripts.Level3
{
    public class AnahtarKodu : MonoBehaviour,Iinteractable
    {
        public bool isHaveKey;
        public NewDoor NewDoor;

        public void CanInteractable()
        {
            isHaveKey = true;
            NewDoor.Key = isHaveKey;
            Destroy(gameObject);
        }
    }
}
