using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    new AudioSource audio;
    public Image soundImage;
    public Sprite offSound;
    public Sprite onSound;

    private bool soundPlaying = false;
    private void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.Play(1000);
        DontDestroyOnLoad(audio);
        soundPlaying = true;
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
        SceneManager.LoadScene("ChapterSelect", LoadSceneMode.Single);
    }

    public void ProgressPage()
    {
        SceneManager.LoadScene("Progress", LoadSceneMode.Single);
    }

    public void RulesPage()
    {
        SceneManager.LoadScene("Rules", LoadSceneMode.Single);
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
