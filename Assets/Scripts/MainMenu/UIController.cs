using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    AudioSource audio;
    public Image soundImage;
    public Sprite offSound;
    public Sprite onSound;

    private bool soundPlaying = false;
    private void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.Play(1000);
        soundPlaying = true;
    }
    private void Update()
    {
        
    }
    public void AppExit()
    {
        Application.Quit();
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
