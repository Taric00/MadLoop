using UnityEngine;

namespace CameraScripts
{
    public class CameraFollow : MonoBehaviour
    {
        public float MouseSensitivity = 2.0f;
        public Transform Character;

        public float CamMin;
        public float CamMax;
        
        private float _xRotation = 0f;

        private void Awake()
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

        private void Update()
        {
            LookAround();
        }

        private void LookAround()
        {
            float mouseX = Input.GetAxis("Mouse X") * MouseSensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * MouseSensitivity * Time.deltaTime;

            _xRotation -= mouseY;
            _xRotation = Mathf.Clamp(_xRotation, -CamMin, CamMax);

            // Sadece kameranın yukarı/aşağı hareketi
            transform.localRotation = Quaternion.Euler(_xRotation, 0, 0);

            // Karakterin y-ekseni etrafında dönmesi
            Character.Rotate(Vector3.up * mouseX);
        }
    }
}