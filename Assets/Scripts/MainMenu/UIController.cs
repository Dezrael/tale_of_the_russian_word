using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class UIController : MonoBehaviour
{
    new AudioSource audio;
    public Image soundImage;
    public Sprite offSound;
    public Sprite onSound;
    private Dictionary<string, GameObject> levels;

    private bool soundPlaying = false;
    private void Start()
    {
        levels = new Dictionary<string, GameObject>();
        audio = GetComponent<AudioSource>();
        audio.PlayDelayed(1000f);
        soundPlaying = true;
        levels.Add("mainMenu", GameObject.FindGameObjectWithTag("MainMenu").gameObject);
        levels.Add("gameMethods", GameObject.FindGameObjectWithTag("GameMethodsMenu").gameObject);
        levels["gameMethods"].SetActive(false);
    }
    private void Update()
    {
       
    }
    public void AppExit()
    {
        Application.Quit();
    }

    public void ChapterSelect()
    {
        levels["mainMenu"].SetActive(false);
        levels["gameMethods"].SetActive(true);
    }

    public void ProgressPage()
    {
        
    }

    public void RulesPage()
    {
        
    }

    public void ToggleAudio()
    {
        if (soundPlaying)
        {
            audio.Stop();
            soundPlaying = false;
            soundImage.sprite = offSound;
        } else
        {
            audio.Play();
            soundPlaying = true;
            soundImage.sprite = onSound;
        }
    }
}
