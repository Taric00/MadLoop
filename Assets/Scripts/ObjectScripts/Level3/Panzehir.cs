using System.Collections;
using Interfaces;
using UnityEngine;
using UnityEngine.Serialization;

namespace ObjectScripts.Level3
{
    public class Panzehir : MonoBehaviour,Iinteractable
    {
        public GameObject panzehirDialogue;
        public GameObject Key;
        public void CanInteractable()
        {
            panzehirDialogue.SetActive(true);
            StartCoroutine(PanzehirWait());
        }

        IEnumerator PanzehirWait()
        {
            yield return new WaitForSeconds(2);
            Destroy(gameObject);
            Key.SetActive(true);
        }
    }
}
