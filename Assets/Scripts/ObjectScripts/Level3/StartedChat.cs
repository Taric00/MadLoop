using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;

namespace ObjectScripts.Level3
{
    public class StartedChat : MonoBehaviour
    {
        public GameObject FirstDialogue;
        void Start()
        {
            StartCoroutine(EnableMessage());
        }

        IEnumerator EnableMessage()
        {
            yield return new WaitForSeconds(2);
            FirstDialogue.SetActive(true);
        }
        
    }
}
