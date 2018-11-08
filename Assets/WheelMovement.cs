using UnityEngine;
using System.Collections;

public class WheelMovement : MonoBehaviour
{
    public bool allowInput = true;

    public float acceleration = 1f;

    public Transform[] wheels;

    public bool usingWheel = true;

    public Rigidbody leftWheelRigidBody;
    //public Rigidbody rightWheelRigidBody;
    public float maximumVelocity = 200.0f;
    private float leftWheelController;
    //private float rightWheelController;

    public float wheelInput;

    void Start()
    {
        leftWheelController = 0;
    }


    void FixedUpdate()
    {
        if (allowInput)
        {
            if (usingWheel)
                leftWheelController = acceleration * wheelInput * Time.deltaTime * 300.0f;
            else
                leftWheelController = acceleration * -Input.GetAxis("Vertical") * Time.deltaTime * 300.0f;
            //rightWheelController = Input.GetAxis("Vertical2") * Time.deltaTime * 300.0f;

            leftWheelRigidBody.AddForce(transform.forward * leftWheelController);
            //rightWheelRigidBody.AddForce(transform.forward * rightWheelController);

            /*leftWheelRigidBody.angularVelocity = (transform.right * leftWheelController);
            rightWheelRigidBody.angularVelocity = (transform.right * rightWheelController);*/
        }
    }

}