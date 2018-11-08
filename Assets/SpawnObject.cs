using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour {

    public GameObject[] prefabAnimals;

    [Range(0.1f, 20)]
    public float maxTimeToSpawn = 6f;

    [Range(0.1f, 10f)]
    public float minTimeToSpawn = 2f;

    private float timeToSpawn;
    private float timer;

	// Use this for initialization
	void Start () {
        ResetTimer();

	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;

        if (timer > timeToSpawn) {
            GameObject newObj = Instantiate(prefabAnimals[Random.RandomRange(0, prefabAnimals.Length)], transform.position, Quaternion.identity, transform);
            newObj.transform.Rotate(transform.rotation.eulerAngles);
            ResetTimer();
        }
	}

    private void ResetTimer() {
        timer = 0f;
        timeToSpawn = Random.RandomRange(minTimeToSpawn, maxTimeToSpawn);
    }
}
