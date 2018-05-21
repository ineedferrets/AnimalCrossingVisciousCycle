using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenArduino : MonoBehaviour {

    public ArduinoConnector arduino;

	// Use this for initialization
	void Start () {
        arduino = this.GetComponent<ArduinoConnector>();
        arduino.Open();
        StartCoroutine(
            arduino.AsynchronousReadFromArduino(
                (string s) => Debug.Log(s),
                () => Debug.LogError("Error!"),
                1000f
            )
        );
    }

    private void OnApplicationQuit() {
        arduino.Close();
    }
}
