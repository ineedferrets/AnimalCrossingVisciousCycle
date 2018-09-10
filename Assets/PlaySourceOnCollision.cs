using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySourceOnCollision : MonoBehaviour {

    public AudioSource audioSource = null;

    public string tagString = null;

    public int layerInt = -10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (tagString == null && layerInt == -10)
        {
            audioSource.Play();
        }
        else if (tagString == collision.transform.tag)
        {
            audioSource.Play();
        }
        else if (layerInt == collision.gameObject.layer)
        {
            audioSource.Play();
        }
    }
}
