using System;
using Interfaces;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ObjectScripts.Level3
{
    public class NewDoor : MonoBehaviour,Iinteractable
    {
        public AnahtarKodu AnahtarKodu;
        private Animator _animator;
        public bool Key;
        private void Start()
        {
            _animator = GetComponent<Animator>();
        }

        public void CanInteractable()
        {
            if (Key)
            {
                _animator.SetBool("Key",true);
                SceneManager.LoadScene(0);
            }
        }
    }
}
