using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundToggler : MonoBehaviour
{
    [SerializeField]
    private GameObject offSoundBtn;
    [SerializeField]
    private GameObject onSoundBtn;
    [SerializeField]
    private GameObject _UIController;

    private UIController controllerScript;

    void Start()
    {
        controllerScript = _UIController.GetComponent<UIController>();
        if (controllerScript.soundPlaying)
        {
            onSoundBtn.SetActive(true);
            offSoundBtn.SetActive(false);
        } else
        {
            onSoundBtn.SetActive(false);
            offSoundBtn.SetActive(true);
        }
    }

    public void offSound ()
    {
        onSoundBtn.SetActive(true);
        offSoundBtn.SetActive(false);
        controllerScript.ToggleAudio();
    }

    public void onSound()
    {
        onSoundBtn.SetActive(false);
        offSoundBtn.SetActive(true);
        controllerScript.ToggleAudio();
    }
}
