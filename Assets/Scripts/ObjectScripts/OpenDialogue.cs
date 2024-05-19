using UnityEngine;

namespace ObjectScripts
{
    public class OpenDialogue : MonoBehaviour
    {
        public GameObject Dialogue;
        public bool isOpenedBefore;
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player") && !isOpenedBefore)
            {
                Dialogue.SetActive(true);
                isOpenedBefore = true;
            }
        }
    }
}
