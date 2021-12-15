using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    Rigidbody rigidbody;
    [SerializeField] float movementSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float forwardMovement = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
        float rightMovement = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;

        if ((forwardMovement > 0.1 || forwardMovement < -0.1) || (rightMovement > 0.1 || rightMovement < -0.1))
            rigidbody.velocity = transform.right * rightMovement + transform.forward * forwardMovement;

    }
}
