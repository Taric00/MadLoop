using System;
using Interfaces;
using UnityEngine;

namespace CharacterScripts
{
    public class InteractWithObjects : MonoBehaviour
    {
        public float maxInteractionDistance;
        private void Update()
        {
            InteractRay();
        }

        private void InteractRay()
        {
            var screenPointRay = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;

            bool hasHit = Physics.Raycast(screenPointRay, out hit,maxInteractionDistance);

            if (hasHit)
            {
                if (Input.GetKey(KeyCode.F))
                {
                    GameObject o = hit.transform.gameObject;
                    if (o.TryGetComponent(out Iinteractable interactableObject))
                    {
                        interactableObject.CanInteractable();
                    }
                }
            }

        }

    }
}
