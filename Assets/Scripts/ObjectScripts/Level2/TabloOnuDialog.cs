using System;
using UnityEngine;

namespace ObjectScripts.Level2
{
    public class TabloOnuDialog : MonoBehaviour
    {
        public GameObject Dialog;
        private bool isTrigged;
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player") && !isTrigged)
            {
                Dialog.SetActive(true);
                isTrigged = true;
            }
        }
    }
}
