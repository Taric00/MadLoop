using System;
using UnityEngine;

namespace PlayerScripts
{
    public class PlayerMovement : MonoBehaviour
    {
        public float MovementSpeed;
        public float TurnSpeed;


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

        public void Turn()
        {
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(0, TurnSpeed, 0);
            }else if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(0, -TurnSpeed, 0);
            }
        }
        
    }
}
