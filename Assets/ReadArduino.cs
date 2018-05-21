using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadArduino : MonoBehaviour {

    private ArduinoConnector arduino;

	// Use this for initialization
	void Start () {
        arduino = this.GetComponent<ArduinoConnector>();
        arduino.Open();
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(arduino.ReadFromArduino(200));
	}

    private void OnApplicationQuit() {
        arduino.Close();
    }
}
