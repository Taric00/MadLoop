using System;
using Interfaces;
using UnityEngine;

namespace ObjectScripts.Level3
{
    public class NewDoor : MonoBehaviour,Iinteractable
    {
        public AnahtarKodu AnahtarKodu;
        private Animator _animator;

        private void Start()
        {
            _animator = GetComponent<Animator>();
        }

        public void CanInteractable()
        {
            if (!AnahtarKodu.isHaveKey)
            {
                _animator.SetBool("Key",true);
            }
        }
    }
}
