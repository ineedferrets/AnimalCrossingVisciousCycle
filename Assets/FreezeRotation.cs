using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeRotation : MonoBehaviour {

    public bool freezeX;

    public bool freezeY;

    public bool freezeZ;

	void LateUpdate ()
    {
        Vector3 currentRotation = transform.localEulerAngles;

        if(freezeX)
        {
            currentRotation.x = 0;
        }

        if(freezeY)
        {
            currentRotation.y = 0;
        }

        if(freezeZ)
        {
            currentRotation.z = 0;
        }

        transform.localEulerAngles = currentRotation;
	}
}
