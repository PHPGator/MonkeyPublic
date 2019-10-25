using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KD_MainMenu : MonoBehaviour
{
    public void StartButtonClicked()
    {
        SceneManager.LoadScene(3);
    }
    public void OptionsButtonClicked()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitButtonClicked()
    {
        //Possibly add a save feature.
        //Quit the Application
        Debug.Log("The Application Quit");
    }
}
