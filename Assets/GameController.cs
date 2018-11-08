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

    public Image readyIm;
    public AudioSource readySound;
    public Image goIm;
    public AudioSource goSound;

    public AudioSource[] winAudioSources;
    public AudioSource[] loseAudioSources;

    public bool dead = false;
    public bool win = false;

	// Use this for initialization
	void Start () {
        restartBut.gameObject.SetActive(false);
        quitBut.gameObject.SetActive(false);
        youFellIm.gameObject.SetActive(false);
        youSurvivedIm.gameObject.SetActive(false);
        goIm.gameObject.SetActive(false);

        player.GetComponent<WheelMovement>().allowInput = false;
    }

    private float readyGoTimer = 0f;

    public float readyTime = 1f;
    private bool readySoundPlayed;
    public float goTime = 1f;
    private bool goSoundPlayed;

	// Update is called once per frame
	void Update () {
        if (readyGoTimer <= readyTime)
        {
            readyGoTimer += Time.deltaTime;
            if (!readySoundPlayed)
            {
                readySound.Play();
                readySoundPlayed = true;
            }
        }
        else if (readyGoTimer <= goTime + readyTime && readyGoTimer > readyTime)
        {
            readyGoTimer += Time.deltaTime;
            readyIm.gameObject.SetActive(false);
            goIm.gameObject.SetActive(true);

            if (!goSoundPlayed)
            {
                goSound.Play();
                goSoundPlayed = true;
            }

            player.GetComponent<WheelMovement>().allowInput = true;
        }
        else if (readyGoTimer > goTime && goIm.gameObject.activeInHierarchy)
        {
            readyGoTimer += Time.deltaTime;
            goIm.gameObject.SetActive(false);
        }
	}

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

    public void PlayerWin() {
        if (win == false)
        {
            win = true;
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

    }

    public void PlayerLose()
    {
        if (dead == false && win == false)
        {
            dead = true;

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
