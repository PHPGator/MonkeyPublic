using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KD_MainMenu : MonoBehaviour
{
    public Canvas MainMenu;
    public Canvas OptionsMenu;
    public Canvas PauseMenu;

    private void Awake()
    {
        OptionsMenu.gameObject.SetActive(false);
        PauseMenu.gameObject.SetActive(false);
    }
    public void StartButtonClicked()
    {
        //SceneManager.LoadScene(3);
        SceneManager.LoadScene(4);

    }
    public void OptionsButtonClicked()
    {
        //SceneManager.LoadScene(1);
        MainMenu.gameObject.SetActive(false);
        OptionsMenu.gameObject.SetActive(true);

    }
    public void QuitButtonClicked()
    {
        //Possibly add a save feature.
        //Quit the Application
        Debug.Log("The Application Quit");
    }
}
