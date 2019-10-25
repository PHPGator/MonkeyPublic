using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KD_OptionsMenu : MonoBehaviour
{
    public GameObject SoundSlider;
    public GameObject FullScreenBoolean;

    public static float soundVolume;

    private void Update()
    {
        SetSoundVolume();
    }

    public void SetScreenSize(bool value)
    {
        if (value == true)
        {
            Screen.SetResolution(Screen.width, Screen.height, FullScreenMode.ExclusiveFullScreen);
            Debug.Log("FullScreen");
        }
        else if (value == false)
        {
            Screen.SetResolution(Screen.width, Screen.height, FullScreenMode.Windowed);
            Debug.Log("Windowed");
        }
    }

    public void ReturnButtonClicked()
    {
        SceneManager.LoadScene(0);
    }

    public void SetSoundVolume()
    {
        soundVolume = SoundSlider.GetComponent<Slider>().value;
        //Debug.Log($"Current Sound Volume{soundVolume}");    
    }
}
