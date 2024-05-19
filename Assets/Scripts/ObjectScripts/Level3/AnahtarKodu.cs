using Interfaces;
using UnityEngine;

namespace ObjectScripts.Level3
{
    public class AnahtarKodu : MonoBehaviour,Iinteractable
    {
        public bool isHaveKey;

        public void CanInteractable()
        {
            isHaveKey = true;
            Destroy(gameObject);
        }
    }
}
