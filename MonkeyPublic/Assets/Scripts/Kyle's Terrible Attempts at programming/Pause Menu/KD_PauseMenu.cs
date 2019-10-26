using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KD_PauseMenu : MonoBehaviour
{
    public Canvas MainUI;
    public void ResumeButtonClicked()
    {

    }
    public void OptionsButtonClicked()
    {

    }
    public void MainMenuButtonClicked()
    {
        SceneManager.LoadScene(0);
        //MainMenu.gameObject.SetActive(false);
        //OptionsMenu.gameObject.SetActive(true);
    }

}
