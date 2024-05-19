using System.Collections;
using UnityEngine;

namespace ObjectScripts.Level2
{
    public class TabloUcDialog : MonoBehaviour
    {
        public GameObject Dialog;
        public bool isTrigged;

        IEnumerator WaitText()
        {
            yield return new WaitForSeconds(3f);
            //Time.timeScale = 0;
            //yield return new WaitForSecondsRealtime(3);
            //Time.timeScale = 1;
            Destroy(gameObject);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                Dialog.SetActive(true);
                StartCoroutine(WaitText());
            }
        }
    }
}