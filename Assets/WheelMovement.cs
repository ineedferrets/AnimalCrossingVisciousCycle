using UnityEngine;
using System.Collections;

public class WheelMovement : MonoBehaviour
{

    public Transform[] wheels;

    public Rigidbody leftWheelRigidBody;
    public float maximumAngularVelocity = 5f;


    void FixedUpdate()
    {
        Debug.Log(gameObject.GetComponent<WheelCollider>().rpm);
        
        wheels[0].Rotate(gameObject.GetComponent<WheelCollider>().rpm, 0, 0);
        //wheels[1].Rotate(getCollider(1).rpm, 0, 0);

        leftWheelRigidBody.angularVelocity = (transform.right * maximumAngularVelocity);
        Debug.DrawRay(leftWheelRigidBody.transform.position, transform.right, Color.red);
    }

}