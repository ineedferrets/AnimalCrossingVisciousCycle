using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public GameObject player;

    public Button restartBut;
    public Button quitBut;

    public Image youFellIm;
    public Image youSurvivedIm;

    public AudioSource[] winAudioSources;
    public AudioSource[] loseAudioSources;

	// Use this for initialization
	void Start () {
        restartBut.gameObject.SetActive(false);
        quitBut.gameObject.SetActive(false);
        youFellIm.gameObject.SetActive(false);
        youSurvivedIm.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
	}

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

    public void PlayerWin() {
        if (winAudioSources != null)
        {
            foreach (AudioSource audioSource in winAudioSources)
            {
                audioSource.Play();
            }
        }
        youSurvivedIm.gameObject.SetActive(true);
        ShowMenuButtons();
    }

    public void PlayerLose()
    {
        if (loseAudioSources != null)
        {
            foreach (AudioSource audioSource in loseAudioSources)
            {
                audioSource.Play();
            }
        }

        youFellIm.gameObject.SetActive(true);
        ShowMenuButtons();
    }

    private void ShowMenuButtons()
    {
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
