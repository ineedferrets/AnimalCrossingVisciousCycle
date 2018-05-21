using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerPrototype : MonoBehaviour {

    public Rigidbody leftWheelRigidBody;
    public Rigidbody rightWheelRigidBody;

    public float maximumAngularVelocity = 5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Debug.DrawRay(leftWheelRigidBody.transform.position, transform.right, Color.red);

        if (Input.GetKeyDown(KeyCode.E))
        {
            leftWheelRigidBody.angularVelocity = (transform.right * maximumAngularVelocity);
            Debug.DrawRay(leftWheelRigidBody.transform.position, transform.right, Color.red);
        }

        if(Input.GetKeyDown(KeyCode.D))
        {
            leftWheelRigidBody.angularVelocity = -(transform.right * maximumAngularVelocity);
        }

        if(Input.GetKeyDown(KeyCode.T))
        {
            rightWheelRigidBody.angularVelocity = (transform.right * maximumAngularVelocity);
        }

        if(Input.GetKeyDown(KeyCode.G))
        {
            rightWheelRigidBody.angularVelocity = -(transform.right * maximumAngularVelocity);
        }

    }

}
