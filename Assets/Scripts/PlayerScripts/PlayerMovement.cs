using System;
using UnityEngine;

namespace PlayerScripts
{
    public class PlayerMovement : MonoBehaviour
    {
        public float MovementSpeed;


        private void Update()
        {
            Move();
            //Turn();
        }

        public void Move()
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.forward * (MovementSpeed * Time.deltaTime));
            }
            else if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.back * (MovementSpeed * Time.deltaTime));
            }
            
        }
        
        
    }
}
