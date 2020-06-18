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

    public bool soundPlaying = false;
    private void Start()
    {
        InitLevels();
        audio = GetComponent<AudioSource>();
        audio.PlayDelayed(2500);
        soundPlaying = true;
    }

    public void AppExit()
    {
        Application.Quit();
    }

    public void GameMethodSelect()
    {
        ActivateLevel("GameMethods");
    }

    public void ChapterSelect()
    {
        ActivateLevel("ChapterSelect");
    }

    public void ThemeSelect()
    {
        ActivateLevel("ThemeSelect");
    }

    public void LevelSelect()
    {
        ActivateLevel("LevelSelect");
    }

    public void ProgressPage()
    {
        ActivateLevel("Progress");
    }

    public void OptionsPage()
    {
        ActivateLevel("Options");
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

    public void ContactDeveloper ()
    {
        Application.OpenURL("mailto:nagahiko.yamamoto@gmail.com");
    }

    private void InitLevels()
    {
        levels = new Dictionary<string, GameObject>();
        FillLevels();
        foreach (string key in levels.Keys)
        {
            levels[key].SetActive(false);
        }
        ActivateLevel("MainMenu");
    }

    private void FillLevels()
    {
        GameObject[] levelObjects = GameObject.FindGameObjectsWithTag("Level");
        foreach (GameObject level in levelObjects)
        {
            levels.Add(level.name, level);
        }
    }
    
    private void ActivateLevel(string levelName)
    {
        foreach (string key in levels.Keys)
        {
            levels[key].SetActive(false);
        }

        levels[levelName].SetActive(true);
    }
}
