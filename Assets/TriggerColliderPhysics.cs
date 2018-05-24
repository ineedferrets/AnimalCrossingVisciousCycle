using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerColliderPhysics : MonoBehaviour {

    public GameObject gameController;
    
    // Use this for initialization
	void Start () {

	}
	

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Floor")
        {
            gameController.GetComponent<GameController>().dead = true;
        } else if (other.gameObject.tag == "Finish") {
            gameController.GetComponent<GameController>().PlayerWin();
        }
    }
}
