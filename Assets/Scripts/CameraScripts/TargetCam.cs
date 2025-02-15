using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCam : MonoBehaviour
{
    public Transform target;

    public float desiredDistance = 5;

    void Start()
    {

    }

    void LateUpdate()
    {
        Vector3 vToTarget = target.position - transform.position;

        // position of the camera
        Vector3 targetPosition = -vToTarget;
        targetPosition.Normalize();
        targetPosition *= desiredDistance;

        targetPosition += target.position;

        transform.position = AnimMath.Ease(transform.position, targetPosition, .01f);

        //turning to look at target
        transform.rotation = Quaternion.LookRotation(vToTarget, Vector3.up);
    }
}
