using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] SceneLoader sceneLoader;
    [SerializeField] GameObject optionsUI;
    //[SerializeField] GameObject pauseUI;

    public void OnStartGame()
    {
        // screen fade
        // load first scene

    }

    public void OnOptions()
    {
        optionsUI.SetActive(true);
    }

    public void OnQuit()
    {
        Application.Quit();
    }

    public void OnBackOptions()
    {
        if (optionsUI != null) optionsUI.SetActive(false);
    }

    public void OnResume()
    {
        //if (pauseUI != null) pauseUI.SetActive(false);
    }

    public void OnLoadScene(string sceneName)
    {
        sceneLoader.Load(sceneName);
    }

    public void MenuOn(GameObject menuToTurnOn)
    {
        menuToTurnOn.SetActive(true);
    }

    public void MenuOff(GameObject menuToTurnOff)
    {
        menuToTurnOff.SetActive(false);
    }
}
