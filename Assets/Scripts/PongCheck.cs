using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PongCheck : MonoBehaviour {

    public ArduinoConnector connector;
    public Text pongText;

    public float pongReceiveHoldTime = 2.0f;

	// Use this for initialization
	void Start () {
        connector.Open();
        pongText.text = "Nothing received";

        StartCoroutine(connector.AsynchronousReadFromArduino((string s) => Debug.Log(s), () => Debug.Log("Error!"), 10000f));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SendPing() {
        connector.WriteToArduino("PING");
    }
}
