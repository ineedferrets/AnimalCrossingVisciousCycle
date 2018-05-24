using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeColor : MonoBehaviour {

    public Image image;

    public float frequency = 2.0f;

    public float minAlpha = 0.6f;

    public float maxAlpha = 0.8f;

    private float alphaDiff;

	// Use this for initialization
	void Start () {
        alphaDiff = maxAlpha - minAlpha;
	}
	
	// Update is called once per frame
	void Update () {
        float alpha = (0.5f + Mathf.Sin(Time.time / frequency * 2 * Mathf.PI)) * alphaDiff + minAlpha;
        Color newColor = Color.white;
        newColor.a = alpha;
        image.color = newColor;

	}
}
