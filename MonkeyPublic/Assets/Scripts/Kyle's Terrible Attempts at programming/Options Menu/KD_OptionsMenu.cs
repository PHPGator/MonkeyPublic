using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KD_OptionsMenu : MonoBehaviour
{
    public GameObject SoundSlider;
    public Canvas MainUI;


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
        KD_MainMenu MainUIContainer = MainUI.GetComponent<KD_MainMenu>();
        MainUIContainer.OptionsMenu.gameObject.SetActive(false);
        MainUIContainer.MainMenu.gameObject.SetActive(true);
    }

    public void SetSoundVolume()
    {
        soundVolume = SoundSlider.GetComponent<Slider>().value;
        //Debug.Log($"Current Sound Volume{soundVolume}");    
    }
}
