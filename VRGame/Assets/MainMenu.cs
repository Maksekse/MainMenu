using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public class MainMenu : MonoBehaviour
{

    public GameObject mainView;
    public GameObject settingsView;
    public GameObject helpView;
    public GameObject quitView;

    public void SettingsButton()
    {
        Debug.Log("Clicked");
        mainView.SetActive(false);
        settingsView.SetActive(true);
        helpView.SetActive(false);
        quitView.SetActive(false);
    }

    public void HelpButton()
    {
        Debug.Log("Clicked");
        mainView.SetActive(false);
        settingsView.SetActive(false);
        helpView.SetActive(true);
        quitView.SetActive(false);
    }

    public void ExitButton()
    {
        Debug.Log("Clicked");
        mainView.SetActive(false);
        settingsView.SetActive(false);
        helpView.SetActive(false);
        quitView.SetActive(true);
    }

    public void ReturnButton()
    {
        Debug.Log("Clicked");
        mainView.SetActive(true);
        settingsView.SetActive(false);
        helpView.SetActive(false);
        quitView.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
