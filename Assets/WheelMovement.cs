using UnityEngine;
using System.Collections;

public class WheelMovement : MonoBehaviour
{

    public Transform[] wheels;

    public Rigidbody leftWheelRigidBody;
    public Rigidbody rightWheelRigidBody;
    public float maximumVelocity = 200.0f;
    private float leftWheelController;
    private float rightWheelController;

    void Start()
    {
        leftWheelController = 0;
    }


    void FixedUpdate()
    {

        leftWheelController = Input.GetAxis("Vertical") * Time.deltaTime * 300.0f;
        rightWheelController = Input.GetAxis("Vertical2") * Time.deltaTime * 300.0f;


        leftWheelRigidBody.angularVelocity = (transform.right * leftWheelController);
        rightWheelRigidBody.angularVelocity = (transform.right * rightWheelController);
    }

}