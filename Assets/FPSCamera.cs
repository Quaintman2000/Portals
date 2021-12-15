using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCamera : MonoBehaviour
{
    [SerializeField] float mouseSensitivity = 100;
    [SerializeField] Transform bodyTransform;
    float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.mousePosition.x * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.mousePosition.y * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90);

        transform.localEulerAngles = new Vector3(xRotation, 0f, 0f);
        bodyTransform.Rotate(Vector3.up * mouseX);
    }
}
