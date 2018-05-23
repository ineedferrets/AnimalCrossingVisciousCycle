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
                (string s) => SendVelocityReading(s),
                () => Debug.LogError("Error!"),
                1000f
            )
        );
    }

    private void OnApplicationQuit() {
        arduino.Close();
    }

    private void SendVelocityReading(string s) {
        int velocity = int.Parse(s);
        Debug.Log("Velocity as int: " + velocity);
    }
}
