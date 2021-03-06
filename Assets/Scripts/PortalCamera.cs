using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCamera : MonoBehaviour
{
    [SerializeField] Transform playerCamera;
    [SerializeField] Transform portal;
    [SerializeField] Transform otherPortal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 playerOffsetFromPortal = playerCamera.position - otherPortal.position;
        playerOffsetFromPortal = Vector3.ClampMagnitude(playerOffsetFromPortal, 3);
        transform.position = portal.position + playerOffsetFromPortal;



        float angularDifferenceBetweenPortalRotations = Quaternion.Angle(portal.localRotation, otherPortal.localRotation);

        Quaternion portalRotationDifference = Quaternion.AngleAxis(angularDifferenceBetweenPortalRotations, Vector3.up);
        Vector3 newCameraDirection = portalRotationDifference * playerCamera.forward;
        transform.rotation = Quaternion.LookRotation(newCameraDirection, Vector3.up);
    }
}
