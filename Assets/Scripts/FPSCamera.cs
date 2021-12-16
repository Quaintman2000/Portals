using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCamera : MonoBehaviour
{
    // Sensitivity level of the rotation.
    [SerializeField] float mouseSensitivity = 100;
    // The transform for the main body.
    [SerializeField] Transform bodyTransform;
    // Stores the amount of rotation to for the camera on the X axis.
    float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        // Lock the cursor from the screen.
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // Get the X & Y axis input from the mouse * the senesitivity level over time.
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Set the xRotation to the negative Y input from the mouse and clamp it between -90 and 90 degrees.
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90);

        // Rotate the camera up & down and the body left & right based on the mouse input.
        transform.localEulerAngles = new Vector3(xRotation, 0f, 0f);
        bodyTransform.Rotate(Vector3.up * mouseX);
    }
}
