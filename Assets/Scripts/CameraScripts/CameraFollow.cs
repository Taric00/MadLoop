using UnityEngine;

namespace CameraScripts
{
    public class CameraFollow : MonoBehaviour
    {
        public float MouseSensitivity = 2.0f;
        public Transform Character;

        public float CamMin;
        public float CamMax;

        public float TurnSpeed;
        private float _xRotation = 0f;

        private void Awake()
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

        private void Update()
        {
            LookAround();
            Turn();
        }

        private void LookAround()
        {
            float mouseX = Input.GetAxis("Mouse X") * MouseSensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * MouseSensitivity * Time.deltaTime;

            _xRotation -= mouseY;
            _xRotation = Mathf.Clamp(_xRotation, -CamMin, CamMax);

            transform.localRotation = Quaternion.Euler(_xRotation, 0, 0);

            Character.Rotate(Vector3.up * mouseX);
        }

        private void Turn()
        {
            if (Input.GetKey(KeyCode.D))
            {
                Character.Rotate(Vector3.up * TurnSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                Character.Rotate(Vector3.up * -TurnSpeed * Time.deltaTime);
            }
        }
    }
}