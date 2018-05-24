using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public bool dead;
    public GameObject player;

    public Button restartBut;
    public Button quitBut;

	// Use this for initialization
	void Start () {
        dead = false;
        restartBut.gameObject.SetActive(false);
        quitBut.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		if (dead)
        {
            //show buttons
            restartBut.gameObject.SetActive(true);
            quitBut.gameObject.SetActive(true);
        }
	}

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
