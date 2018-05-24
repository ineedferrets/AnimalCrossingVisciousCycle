using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalMovement : MonoBehaviour {

    [Range(0f, 20f)]
    public float maxAngularVelocity = 5f;

    [Range(0f, 10f)]
    public float minAngularVelocity = 3f;

    [Range(0f,20f)]
    public float maxLinearVelocity = 8f;

    [Range(0f, 10f)]
    public float minLinearVelocity = 6f;

	// Use this for initialization
	void Start () {
        Physics.IgnoreLayerCollision(9, 9, true);
        this.GetComponent<Rigidbody>().velocity = transform.forward * Random.RandomRange(minLinearVelocity, maxLinearVelocity);
        this.GetComponent<Rigidbody>().angularVelocity = new Vector3(Random.RandomRange(-1.0f, 1.0f), 
            Random.RandomRange(-1.0f, 1.0f), 
            Random.RandomRange(-1.0f, 1.0f)) * Random.RandomRange(minAngularVelocity, maxAngularVelocity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
