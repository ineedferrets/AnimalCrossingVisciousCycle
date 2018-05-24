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

    public Image youFellIm;
    public Image youSurvivedIm;

	// Use this for initialization
	void Start () {
        dead = false;
        restartBut.gameObject.SetActive(false);
        quitBut.gameObject.SetActive(false);
        youFellIm.gameObject.SetActive(false);
        youSurvivedIm.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		if (dead && !youSurvivedIm.gameObject.activeInHierarchy)
        {
            youFellIm.gameObject.SetActive(true);
            //show buttons
            restartBut.gameObject.SetActive(true);
            quitBut.gameObject.SetActive(true);
        }
	}

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

    public void PlayerWin() {
        youSurvivedIm.gameObject.SetActive(true);
        restartBut.gameObject.SetActive(true);
        quitBut.gameObject.SetActive(true);
    }

    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
