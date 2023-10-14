using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRightScript : MonoBehaviour
{
    public GameObject target;
    public float speed;
    public float rotationModifier;

    public GameObject other;
    public Rigidbody2D myRigidBody;

    void FixedUpdate()
    {
        // Rotation to fixed point
        Vector3 vectorToTarget = target.transform.position - transform.position;
        float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg - rotationModifier;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * speed);
    }

    void Update()
    {
        if (myRigidBody.IsTouchingLayers())
        {
            other.transform.position = -transform.position;
        }
        else
        {
            transform.position = -other.transform.position;
        }
    }
}
