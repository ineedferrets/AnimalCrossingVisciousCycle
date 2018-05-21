using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour {

    public Transform targetTransform;

    public Vector3 offsetPosition;
    public Vector3 angleToView;

    public float lerpSpeed = 5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 cameraTargetPosition = targetTransform.position + offsetPosition;
        Vector3 cameraTargetAngle = angleToView;

        transform.position = Vector3.Lerp(transform.position, cameraTargetPosition, lerpSpeed);
	}
}
