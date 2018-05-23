using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public bool dead, ressurectPlayer;
    public GameObject player;

	// Use this for initialization
	void Start () {
        dead = false;
        ressurectPlayer = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (dead)
        {
            //shows UI
        }

        if (ressurectPlayer)
        {
            ressurectPlayer = false;
            player.GetComponent<WheelMovement>().ressurect = true;
        }
	}
}
